namespace EsiStatics

open System.Collections.Generic
open EsiStatics.Data.Entities;
open EsiStatics.Data.ItemTypes;

type systemScore = (SolarSystem -> float)
type stationScore = (Station -> float)
type systemPicker = (SolarSystem -> (float * SolarSystem) [] )
type internal stationPicker = (Station -> (float * Station) [] )

type JumpPlan =
    {
        ship:                   ItemType option
        jumpDriveCalibration:   int
        jumpDriveConservation:  int
        jumpFreighter:          int option
        route:                  SolarSystem[]
        plans:                  int
        avoidPochvenWeight:     float
        distanceWeight:         float
        stationDockingWeight:   float
        emptyStationsWeight:    float
    } with
    [<CompiledName("Empty")>]
    static member empty = 
        { JumpPlan.ship = None; jumpDriveCalibration = 1; jumpDriveConservation = 5; jumpFreighter = None; route = [||]; plans = 1; 
                    distanceWeight = 1.; stationDockingWeight = 0.; avoidPochvenWeight = 1.; emptyStationsWeight = 1. }
    

type JumpStage = 
    {
        distance: float<LY>
        isotopes: float
        system: SolarSystem
        station: Station option
    }

type internal JumpStageData = 
    {
        system:                         SolarSystemData
        score:                          float
        relativeDistanceScore:          float
        distanceToDestination:          float<LY>
        isotopesToDestination:          float
        stations:                       StationData []
        neighbours:                     (SolarSystemData * float<LY>) []
        nearestHighsecSystem:           SolarSystemData option
        kills:                          int option
        podKills:                       int option
        incursion:                      bool option
        triglavian:                     bool option
        edencom:                        bool option
    }

type internal JumpStageDataStats = 
    {
        maxDistance:    float
        minDistance:    float
        distanceOffset:  float
        distanceScale:  float
    }

type JumpPlanResult =
    {
        score:      float
        stages:     JumpStage[]
        distance:   float<LY>
        isotopes:   float
    }

module internal JumpNavigation =

    [<Literal>]
    let jumpDriveRangeAttributeId = 867
    [<Literal>]
    let jumpDriveRangeBonusAttributeId = 870
    [<Literal>]
    let jumpDriveConsumptionAmountAttributeId = 868

    let dogmaAttribute = DogmaAttributes.getDogmaAttribute >> Option.get
    let systemData = EsiStatics.Data.Universe.SolarSystems.getSolarSystem >> Option.get
    let station id = id |> EsiStatics.Stations.byId |> Option.get
    
    let jumpDriveRangeAttribute = dogmaAttribute jumpDriveRangeAttributeId 
    let jumpDriveRangeBonusAttribute = dogmaAttribute jumpDriveRangeBonusAttributeId 
    let jumpDriveConsumptionAmountAttribute = dogmaAttribute jumpDriveConsumptionAmountAttributeId 
    let jumpDriveCalibrationSkill = ItemTypes.getItemType 21611 |> Option.get
    let jumpDriveRangeBonusValue = jumpDriveCalibrationSkill.dogmaAttributes |> Array.find (fun a -> a.attributeId = jumpDriveRangeBonusAttribute.id)
        
    let getItemType name = ItemTypes.itemTypes() |> Seq.find (fun s -> s.name = name) 
    let getItemTypeAttribute id (itemType: ItemTypeData) =
        itemType.dogmaAttributes |> Array.tryFind (fun a -> a.attributeId = id) 
    
    let categoryItemTypes =
        EsiStatics.Data.ItemTypes.Categories.getCategory
            >> Option.map (fun c -> c.groupIds |> Seq.map EsiStatics.Data.ItemTypes.Groups.getGroup) >> Option.defaultValue Seq.empty >> Seq.reduceOptions
            >> Seq.collect (fun g -> g.typeIds)
            >> Seq.map ItemTypes.getItemType >> Seq.reduceOptions
            >> Array.ofSeq
        
    let ships = categoryItemTypes 6 
    let getShip name = ships |> Array.find (fun s -> s.name = name)
    
    let isPochven =
        let pochvenConstellationIds = EsiStatics.Data.Universe.Regions.regions() 
                                        |> Seq.filter (fun s -> s.name = "Pochven") 
                                        |> Seq.head
                                        |> (fun r -> r.constellationIds)
        fun (system: SolarSystemData) -> pochvenConstellationIds |> Seq.contains system.constellationId 
    
    let jumpableOriginSystem (system: SolarSystemData) = system.secRating = SystemSecurity.Highsec || system.secRating = SystemSecurity.Lowsec || system.secRating = SystemSecurity.Nullsec
    let jumpableSystem (system: SolarSystemData) = system.secRating = SystemSecurity.Lowsec || system.secRating = SystemSecurity.Nullsec
    
    let stations (system: SolarSystemData) =
        system.stationIds |> Seq.map EsiStatics.Data.Universe.Stations.getStation |> Seq.reduceOptions

    let shipDriveRangeValue(ship: ItemTypeData)=
        match ship |> getItemTypeAttribute jumpDriveRangeAttribute.id with
        | Some a -> toLY a.value
        | _ -> toLY jumpDriveRangeAttribute.defaultValue

    let shipFuelConsumptionValue(ship: ItemTypeData)=
        match ship |> getItemTypeAttribute jumpDriveConsumptionAmountAttributeId with
        | Some a -> a.value
        | _ -> jumpDriveConsumptionAmountAttribute.defaultValue

    let jumpRange (jumpDriveCalibration: int) (ship: ItemTypeData) =
        let baseRange = shipDriveRangeValue ship |> float
        ((jumpDriveRangeBonusValue.value / 100.) * (float jumpDriveCalibration) + 1.) * baseRange |> toLY
            
    let fuelConsumption (jumpFuelConversation: int) (jumpFreighter: int option) (ship: ItemTypeData) (distance: float<LY>) =
        let baseConsumption = shipFuelConsumptionValue ship
        let r = (float distance) * baseConsumption * ( 1. - 0.1 * (float jumpFuelConversation) )        
        match jumpFreighter with
        | Some jf -> r * (1. - 0.1 * (float jf))
        | _ -> r
            
    let distance (origin: SolarSystem) (destination: SolarSystem)= Geometry.euclidean origin.Position destination.Position |> metresToLY

    let dockableStationScore (station: Station) =                                    
        match station.DockingRange, station.Radius with
        | Some dr, Some r ->    match float dr / float r with
                                | x when x > 1. -> 1.
                                | x when x > 0.5 -> 0.5
                                | _ -> 0.                                
        | Some dr, _ -> 0.5
        | _, Some r -> 0.5
        | _ -> 0.
       

type internal JumpNavigator(distanceFinder: SolarSystemDistanceFinder, plan: JumpPlan)=  
    // TODO: validate plan, skills, etc.    
    let ship = plan.ship |> Option.get
    let shipData = EsiStatics.Data.ItemTypes.ItemTypes.getItemType ship.Id |> Option.get
    let shipRange = ship.Id |> Data.ItemTypes.ItemTypes.getItemType |> Option.get |> JumpNavigation.jumpRange plan.jumpDriveCalibration 
           
    let systemNeighbours system = distanceFinder.FindData system shipRange 
                                    |> Array.filter (fst >> JumpNavigation.jumpableSystem)

    

    let systemStations (system: Data.Entities.SolarSystemData) = system.stationIds |> Array.map (Data.Universe.Stations.getStation >> Option.get)
    let fuelConsumption = JumpNavigation.fuelConsumption plan.jumpDriveConservation None shipData
    let validateSystems (systems: SolarSystemData list) = 
        let rec validate (systems: SolarSystemData list) count result= 
            match systems with
            | [] ->     result
            | s::remaining ->  
                        let v = if count = 0 then   JumpNavigation.jumpableOriginSystem
                                else                JumpNavigation.jumpableSystem
                        let r = match v s with
                                | true -> None
                                | _ -> Some "The system must be jumpable."
                        validate remaining (count + 1) (r :: result)
        validate systems 0 [] |> Seq.reduceOptions
    
    do if float shipRange <= 0. then 
        raise (System.InvalidOperationException("Ship is not jump capable"))
    let plan = { plan with route = ( plan.route |> Seq.removeConsecutives |> Array.ofSeq )}
    do plan.route   |> invalidOp (fun xs -> xs.Length >= 2) "At least 2 systems are needed in the route."
                    |> Seq.map (fun s -> Data.Universe.SolarSystems.getSolarSystem s.Id |> Option.get) 
                    |> List.ofSeq |> validateSystems |> invalidOpIfNotEmpty    
    
    let jumpStageData  (destination: SolarSystemData) (system: SolarSystemData) =
        let distanceToDestination = Geometry.euclideanData system.position destination.position |> metresToLY;
        let isotopesToDestination = fuelConsumption distanceToDestination
        { JumpStageData.system =                    system;
                        score =                     0.;
                        relativeDistanceScore =     0.;
                        distanceToDestination =     distanceToDestination;
                        isotopesToDestination =     isotopesToDestination;
                        stations =                  systemStations system;
                        neighbours =                systemNeighbours system;
                        nearestHighsecSystem =      None; kills = None; podKills = None; incursion =  None; triglavian = None; edencom = None;
        }
       
    
    let relativeValues (totalDistanceToDestination: float<LY>) (stage: JumpStageData) =                     
        let distance =  if stage.distanceToDestination > totalDistanceToDestination then System.Double.MaxValue
                        else -(totalDistanceToDestination - stage.distanceToDestination |> float)
                
        { stage with relativeDistanceScore = distance }

    let jumpStageStats (stages: seq<JumpStageData>)=        
        let distances = stages |> Seq.map (fun s -> s.relativeDistanceScore ) |> Seq.cache
        let maxDistance = distances |> Seq.max
        let minDistance = distances |> Seq.min
                
        let diffDistance = maxDistance - minDistance |> Math.abs
        let factor = if diffDistance = 0. then 1. else 1. / diffDistance 
                
        { JumpStageDataStats.minDistance = minDistance; 
                            maxDistance = maxDistance;
                            distanceOffset = minDistance;
                            distanceScale = factor }

    let scoreJumpState (stats: JumpStageDataStats)(plan: JumpPlan) (destination: SolarSystemData) (stage: JumpStageData)  = 
                
        if stage.system = destination then
            System.Double.MinValue     
        else                        
            let pochvenAvoidScore = if JumpNavigation.isPochven stage.system then 1. else 0.
            
            let distanceScore = (stage.relativeDistanceScore - stats.distanceOffset) * stats.distanceScale
                                    
            let emptyStationScores = if stage.stations.Length = 0 then 1. else 0.
                                            
            let stationDockingRangeScores = 
                stage.stations
                |> Seq.map (fun s -> EsiStatics.Stations.byId s.id |> Option.get)
                |> Seq.map JumpNavigation.dockableStationScore
                |> List.ofSeq
            let stationDockingScore = 
                match stationDockingRangeScores with
                | [] -> 1.
                | xs -> xs |> Seq.map (fun x -> 1. - x) |> Seq.max

            // TODO: future scores:
            // total kills per system
            // total docking range per station?
            // midpoints - distance to highsec            
            // incursion / trig / edencom
            // ganks / gatecamps
            
            
            let result =    (distanceScore  * plan.distanceWeight) + 
                            (pochvenAvoidScore * plan.avoidPochvenWeight) + 
                            (stationDockingScore * plan.stationDockingWeight) + 
                            (emptyStationScores * plan.emptyStationsWeight)

            result

        
    let findRouteDijkstra (start: SolarSystemData) (destination: SolarSystemData) =
        let jumpStage = jumpStageData destination
        let totalDistanceToDestination = Geometry.euclideanData start.position destination.position |> metresToLY;
        let closed = new HashSet<int>()
        let cameFrom = new Dictionary<int, int>()
        let scores = new Dictionary<int, float>()
        scores.[start.id] <- 0.0

        

        let rec backWalk current result  =
            match current with
            | x when x = start.id -> result
            | _ ->  let next = cameFrom.[current]
                    backWalk next (next :: result)
        
        let rec find (todo: MutablePriorityQueue<float, JumpStageData>)=             
            match todo.Pop() with
            | None -> []
            | Some (_, current) when current.system.id = destination.id ->  
                            backWalk current.system.id [ current.system.id ]
            | Some (score, current)  ->
                            if closed.Contains(current.system.id) |> not then
                                closed.Add current.system.id |> ignore
                                                                
                                let neighbours = current.neighbours
                                                    |> Seq.filter (fun (s,_) -> s.id |> closed.Contains |> not)
                                                    |> Seq.map (fst >> jumpStage >> (relativeValues totalDistanceToDestination))
                                                    |> Array.ofSeq
                                
                                let jumpStageStats = jumpStageStats neighbours
                                
                                let neighbours = neighbours
                                                    |> Array.map (fun stage ->  let stageScore = score + (scoreJumpState jumpStageStats plan destination stage)
                                                                                { stage with score = stageScore } )
                                                    
                                neighbours 
                                    |> Seq.iter (fun stage ->   let t = stage.score
                                                                if (scores.ContainsKey(stage.system.id) |> not) || 
                                                                    (scores.[stage.system.id] > t) then
                                                                    cameFrom.[stage.system.id] <- current.system.id
                                                                    scores.[stage.system.id] <- t   )
                                
                                neighbours 
                                    |> Seq.map  (fun s ->   { s with score = scores.[s.system.id] + (s.score) } )
                                    |> Seq.iter (fun s ->   (s.score, s) |> todo.Push |> ignore)

                            find todo
        
        let startStage = jumpStage start
        (new MutablePriorityQueue<float, JumpStageData>()).Push(0., startStage )
            |> find
            |> List.map SolarSystems.knownSystem
        

    let jumpStages (systems: SolarSystem list) =
        let stage (start: SolarSystem) (finish: SolarSystem)= 
            let distanceToDestination = Geometry.euclidean start.Position finish.Position |> metresToLY;
            let isotopesToDestination = fuelConsumption distanceToDestination
                         
            let station = finish.Stations()
                            |> Seq.map (fun s -> (s, JumpNavigation.dockableStationScore s))
                            |> Seq.sortByDescending snd
                            |> Seq.map fst
                            |> Seq.tryHead

            { JumpStage.system = finish; 
                        distance = distanceToDestination;
                        isotopes = isotopesToDestination;
                        station = station }
            
        systems |> Seq.windowed 2
                |> Seq.map (fun (ss) -> stage ss.[0] ss.[1])
    
    new(plan) = JumpNavigator(new SolarSystemDistanceFinder(false), plan)

    member this.FindRoute()=
        let stages = plan.route 
                        |> Seq.map (fun ss -> ss.Id |> JumpNavigation.systemData)
                        |> Seq.windowed 2
                        |> Seq.map (fun ss -> findRouteDijkstra ss.[0] ss.[1] )
                        |> Seq.collect (fun xs -> xs)
                        |> Seq.removeConsecutives
                        |> jumpStages
                        |> Array.ofSeq
            
        let totalDistance = stages |> Array.sumBy (fun s -> s.distance)
        let totalIsotopes = stages |> Array.sumBy (fun s -> s.isotopes)

        [ { JumpPlanResult.score = 1.; stages = stages; distance = totalDistance; isotopes = totalIsotopes }  ]
        
module JumpRouteNavigation =
    let findRoute distanceFinder plan = 
        let nav = new JumpNavigator(distanceFinder, plan)
        nav.FindRoute()

    let calibration (level) (plan: JumpPlan)=
        { plan with jumpDriveCalibration = level }
    let conservation (level) (plan: JumpPlan)=
        { plan with jumpDriveConservation = level }
    let jumpFreighter (level) (plan: JumpPlan)=
        { plan with jumpFreighter = level }
    let ship (ship: ItemType) (plan: JumpPlan)=
        { plan with ship = Some ship }
    let route (route: SolarSystem[]) (plan: JumpPlan)=
        { plan with route = route }
    let plans (value) (plan: JumpPlan)=
        { plan with plans = value }
    let distanceWeight (value) (plan: JumpPlan)=
        { plan with distanceWeight = value }
    let stationDockingWeight (value) (plan: JumpPlan)=
        { plan with stationDockingWeight = value }
    let emptyStationsWeight (value) (plan: JumpPlan)=
        { plan with emptyStationsWeight = value }
    let avoidPochvenWeight (value) (plan: JumpPlan)=
        { plan with avoidPochvenWeight = value }
