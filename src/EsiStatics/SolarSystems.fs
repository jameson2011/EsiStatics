namespace EsiStatics

module SolarSystems=
    let internal identity (solarSystem: SolarSystem) = 
        solarSystem |> argNull "solarSystem"
                    |> (fun ss -> ss.Id)

    [<CompiledName("Get")>]
    let byId (id: int) = 
        id  |> Data.Universe.SolarSystems.getSolarSystem
            |> Option.map TypeMaps.ofSolarSystemData

    let internal neighbourIds (id: int)=
        id  |> Data.Universe.SolarSystems.getSolarSystem
            |> Option.map (fun ss -> ss.stargateIds 
                                        |> Array.map (Data.Universe.Stargates.getStargate >> Option.get >> (fun sg -> sg.destinationSolarSystemId)))
            |> Option.defaultValue Array.empty
            
    let internal data = identity >> Data.Universe.SolarSystems.getSolarSystem

    let internal knownSystem = byId >> Option.get
    
    let internal navigable (value: Planet) = value :> INavigable

    let constellation(solarSystem: SolarSystem) =
        solarSystem
            |> argNull "solarSystem"
            |> (fun ss -> ss.ConstellationId)
            |> Data.Universe.Constellations.getConstellation
            |> Option.get
            |> TypeMaps.ofConstellationData

    let planets(solarSystem: SolarSystem) =
        solarSystem
            |> argNull "solarSystem"
            |> data
            |> Option.map (fun ss -> ss.planetIds 
                                        |> Seq.map (fun p -> p.planetId |> Planets.byId)  
                                        |> Seq.reduceOptions)
            |> Option.defaultValue Seq.empty

    let star(solarSystem: SolarSystem) =
        solarSystem
            |> argNull "solarSystem"
            |> data
            |> Option.bind (fun ss -> ss.starIds 
                                        |> Seq.map (Stars.byId >> Option.get)
                                        |> Seq.tryHead)

    let stations(solarSystem: SolarSystem) =
        solarSystem
            |> argNull "solarSystem"
            |> data
            |> Option.map (fun ss -> ss.stationIds |> Seq.map Stations.byId |> Seq.reduceOptions )
            |> Option.defaultValue Seq.empty

    let stargates(solarSystem: SolarSystem) =
        solarSystem
            |> argNull "solarSystem"
            |> data
            |> Option.map (fun ss -> ss.stargateIds |> Seq.map Stargates.byId |> Seq.reduceOptions )
            |> Option.defaultValue Seq.empty

    let neighbours(depth: int)(solarSystem: SolarSystem)=
        
        let rec walk depth  (found: Map<int,int>) (result: int[] list) (systemIds: seq<int>)=
            match depth with
            | 0 ->      result
            | d ->      let neighbourIds = systemIds 
                                            |> Seq.collect neighbourIds 
                                            |> Seq.filter (found.ContainsKey >> not)
                                            |> Seq.distinct
                                            |> Array.ofSeq
                        let found = neighbourIds |> Seq.fold (fun m i -> m |> Map.add i i ) found 
                        
                        neighbourIds |> walk (d-1) found (neighbourIds :: result)
                                
        let id = solarSystem
                    |> argNull "solarSystem"
                    |> identity
        
        [id] |> walk (max 0 depth) (Map.ofList [ (id,id) ]) [] 
             |> Seq.rev
             |> Seq.map (Seq.map (knownSystem) >> Array.ofSeq)

    let celestials(solarSystem: SolarSystem)=
        
        let star = Stars.byId >> Option.get >> Stars.navigable
        let station = Stations.byId >> Option.get >> Stations.navigable
        let planet = Planets.byId >> Option.get >> Planets.navigable
        let stargate = Stargates.byId >> Option.get >> Stargates.navigable
        let belt = AsteroidBelts.byId >> Option.get >> AsteroidBelts.navigable
        let moon = Moons.byId >> Option.get >> Moons.navigable
        

        let celestials (solarSystem: Data.Entities.SolarSystemData) =
            let stars = solarSystem.starIds |> Seq.map star
            let stations = solarSystem.stationIds |> Seq.map station
            let stargates = solarSystem.stargateIds |> Seq.map stargate
            let planets = solarSystem.planetIds |> Seq.map (fun pr -> pr.planetId) |> Seq.map planet
            let belts = solarSystem.planetIds |> Seq.collect (fun pr -> pr.beltIds) |> Seq.map belt
            let moons = solarSystem.planetIds |> Seq.collect (fun pr -> pr.moonIds) |> Seq.map moon
            
            Seq.concat [ stars; stations; stargates; planets; belts; moons ]

        solarSystem
            |> argNull "solarSystem" 
            |> data
            |> Option.map celestials 
            |> Option.defaultValue Seq.empty

    let celestialDistances(position: Position)(solarSystem: SolarSystem)=
        let solarSystem = solarSystem
                            |> argNull "solarSystem"
        
        solarSystem |> celestials
                    |> Seq.map (fun n -> (n, Geometry.euclidean position n.Position))
                    |> Seq.sortBy snd