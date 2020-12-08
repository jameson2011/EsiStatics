namespace EsiStatics

open EsiStatics.Data.Universe


type SolarSystemFinder(eagerIndex) =
    
    let index = 
        lazy (
            Regions.regions()
                            |> Seq.collect (fun r -> r.constellationIds)
                            |> Seq.map (Constellations.getConstellation >> Option.get)
                            |> Seq.collect (fun c -> c.solarSystemIds)
                            |> Seq.map (SolarSystems.getSolarSystem >> Option.get)
                            |> Seq.map (fun s -> (s.name,  s.id))
                            |> ReadonlyTrie.Create
        )
            
    do  if eagerIndex then index.Value |> ignore

    new() = SolarSystemFinder(false)

    member this.Find(search: string) =
        search
            |> argNull "search"
            |> index.Value.Find 
            |> Seq.map (EsiStatics.SolarSystems.knownSystem)
        
type SolarSystemDistanceFinder(eagerIndex) =

    let neighbourMaxDistance = 10.1<LY> 
    
    let distance (x: Data.Entities.SolarSystemData) (y: Data.Entities.SolarSystemData)= Geometry.euclideanData x.position y.position |> metresToLY
    
    let systems = Regions.regions()
                        |> Seq.collect (fun r -> r.constellationIds)
                        |> Seq.map (Constellations.getConstellation >> Option.get)
                        |> Seq.collect (fun c -> c.solarSystemIds)
                        |> Seq.map (SolarSystems.getSolarSystem >> Option.get)
                        |> Seq.filter (fun ss ->    ss.secRating = Data.Entities.SystemSecurity.Lowsec || 
                                                    ss.secRating = Data.Entities.SystemSecurity.Highsec ||
                                                    ss.secRating = Data.Entities.SystemSecurity.Nullsec)
    
    // Approximately O(n^2) 
    let neighbours (allSystems: Data.Entities.SolarSystemData seq) (system: Data.Entities.SolarSystemData)=                
        allSystems 
            |> Seq.filter (fun s -> s <> system)
            |> Seq.map (fun s -> (distance s system, s.id))
            |> Seq.filter (fun (d,_) -> d <= neighbourMaxDistance)
            |> Seq.sortBy fst                    
            |> Array.ofSeq

    let index =
        lazy (                                        
            let systems = systems |> Array.ofSeq
            systems
                |> Array.Parallel.map (fun s -> (s.id, neighbours systems s) )
                |> Map.ofArray
        )
            
    do  if eagerIndex then index.Value |> ignore
    
    let findNeighbours (system: SolarSystem) = 
        match eagerIndex with
        | true ->   index.Value |> Map.tryFind system.Id
        | _ ->      system.Id |> SolarSystems.getSolarSystem |> Option.get |> neighbours systems  |> Some

    new() = SolarSystemDistanceFinder(false)

    member this.Find(system: SolarSystem) (distance: float<LY>)= 
        match findNeighbours system with
        | Some xs -> xs |> Seq.takeWhile (fun (d, _) -> d <= distance)
                        |> Seq.map (fun (d, s) -> (SolarSystems.knownSystem s, d)) 
                        |> Array.ofSeq
        | _ -> [| |]

type ConstellationFinder(eagerIndex) =
    
    let index = 
        lazy (
            Regions.regions()
                            |> Seq.collect (fun r -> r.constellationIds)
                            |> Seq.map (Constellations.getConstellation >> Option.get)
                            |> Seq.map (fun s -> (s.name, s.id))
                            |> ReadonlyTrie.Create
        )
            
    do  if eagerIndex then index.Value |> ignore

    new() = ConstellationFinder(false)

    member this.Find(search: string) =
        search
            |> argNull "search"
            |> index.Value.Find 
            |> Seq.map (EsiStatics.Constellations.byId >> Option.get)
        

type RegionFinder(eagerIndex) =
    
    let index = 
        lazy (
            Regions.regions()
                            |> Seq.map (fun s -> (s.name, s.id))
                            |> ReadonlyTrie.Create
        )

    do  if eagerIndex then index.Value |> ignore

    new() = RegionFinder(false)

    member this.Find(search: string) =
        search
            |> argNull "search"
            |> index.Value.Find 
            |> Seq.map (EsiStatics.Regions.byId >> Option.get)
        


