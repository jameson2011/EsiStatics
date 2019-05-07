namespace EsiStatics

open System.Runtime.CompilerServices


[<Extension>]
type UniverseExtensions=

    [<Extension>]
    static member Constellations(region: Region) =
        region
            |> argNull "region"
            |> Regions.identity
            |> Data.Universe.Regions.getRegion
            |> Option.map (fun r -> r.constellationIds) 
            |> Option.defaultValue Array.empty
            |> Seq.map Data.Universe.Constellations.getConstellation
            |> Seq.reduceOptions
            |> Seq.map TypeMaps.ofConstellationData

    [<Extension>]
    static member SolarSystems(constellation: Constellation) =
        constellation
            |> argNull "constellation"
            |> Constellations.identity
            |> Data.Universe.Constellations.getConstellation
            |> Option.map (fun c -> c.solarSystemIds)
            |> Option.defaultValue Array.empty
            |> Seq.map Data.Universe.SolarSystems.getSolarSystem
            |> Seq.reduceOptions
            |> Seq.map TypeMaps.ofSolarSystemData

    [<Extension>]
    static member Region(constellation: Constellation) =
        constellation
            |> argNull "constellation"
            |> (fun r -> r.RegionId)
            |> Data.Universe.Regions.getRegion
            |> Option.get
            |> TypeMaps.ofRegionData

    [<Extension>]
    static member Constellation(solarSystem: SolarSystem) =
        solarSystem
            |> argNull "solarSystem"
            |> (fun ss -> ss.ConstellationId)
            |> Data.Universe.Constellations.getConstellation
            |> Option.get
            |> TypeMaps.ofConstellationData
    
    [<Extension>]
    static member Planets(solarSystem: SolarSystem) =
        solarSystem
            |> argNull "solarSystem"
            |> SolarSystems.data
            |> Option.map (fun ss -> ss.planetIds 
                                        |> Seq.map (fun p -> p.planetId |> Planets.byId) 
                                        |> Seq.reduceOptions)
            |> Option.defaultValue Seq.empty
    
    [<Extension>]
    static member Star(solarSystem: SolarSystem) =
        solarSystem
            |> argNull "solarSystem"
            |> SolarSystems.data
            |> Option.bind (fun ss -> ss.starIds 
                                        |> Seq.map (Stars.byId >> Option.get)
                                        |> Seq.tryHead)
    
    [<Extension>]
    static member Stations(solarSystem: SolarSystem) =
        solarSystem
            |> argNull "solarSystem"
            |> SolarSystems.data
            |> Option.map (fun ss -> ss.stationIds |> Seq.map Stations.byId |> Seq.reduceOptions )
            |> Option.defaultValue Seq.empty
    
    [<Extension>]
    static member Stargates(solarSystem: SolarSystem) =
        solarSystem
            |> argNull "solarSystem"
            |> SolarSystems.data
            |> Option.map (fun ss -> ss.stargateIds |> Seq.map Stargates.byId |> Seq.reduceOptions )
            |> Option.defaultValue Seq.empty

    [<Extension>]
    static member Neighbours(solarSystem: SolarSystem)(depth: int)=
        
        let rec walk depth  (found: Map<int,int>) (result: int[] list) (systemIds: seq<int>)=
            match depth with
            | 0 ->      result
            | d ->      let neighbourIds = systemIds 
                                            |> Seq.collect SolarSystems.neighbourIds 
                                            |> Seq.filter (found.ContainsKey >> not)
                                            |> Seq.distinct
                                            |> Array.ofSeq
                        let found = neighbourIds |> Seq.fold (fun m i -> m |> Map.add i i ) found 
                        
                        neighbourIds |> walk (d-1) found (neighbourIds :: result)
                                
        let id = solarSystem
                    |> argNull "solarSystem"
                    |> SolarSystems.identity
        
        [id] |> walk (max 0 depth) (Map.ofList [ (id,id) ]) [] 
             |> Seq.rev
             |> Seq.map (Seq.map (SolarSystems.knownSystem) >> Array.ofSeq)

    [<Extension>]
    static member Celestials(solarSystem: SolarSystem)=
        
        let star = Stars.byId >> Option.get >> Stars.navigable
        let station = Stations.byId >> Option.get >> Stations.navigable
        let planet = Planets.byId >> Option.get >> Planets.navigable
        let stargate = Stargates.byId >> Option.get >> Stargates.navigable
        let belt = AsteroidBelts.byId >> Option.get >> AsteroidBelts.navigable
        let moon = Moons.byId >> Option.get >> Moons.navigable

        let celestials (solarSystem: Data.Entities.SolarSystemData) =
            seq {
                yield! solarSystem.starIds |> Seq.map star
                yield! solarSystem.stationIds |> Seq.map station
                yield! solarSystem.stargateIds |> Seq.map stargate
                yield! solarSystem.planetIds |> Seq.map (fun pr -> pr.planetId) |> Seq.map planet
                yield! solarSystem.planetIds |> Seq.collect (fun pr -> pr.beltIds) |> Seq.map belt
                yield! solarSystem.planetIds |> Seq.collect (fun pr -> pr.moonIds) |> Seq.map moon
            }

        solarSystem
            |> argNull "solarSystem" 
            |> SolarSystems.data
            |> Option.map celestials 
            |> Option.defaultValue Seq.empty
             
    [<Extension>]
    static member CelestialDistances(solarSystem: SolarSystem)(position: Position)=
        let solarSystem = solarSystem
                            |> argNull "solarSystem"
        
        solarSystem.Celestials()
                    |> Seq.map (fun n -> (n, Navigation.euclidean position n.Position))
                    |> Seq.sortBy snd

    [<Extension>]
    static member AsteroidBelts(planet: Planet) =
        planet
            |> argNull "planet"
            |> (fun p -> SolarSystems.planetRefData p.SolarSystemId p.Id )
            |> (fun pr -> pr.beltIds)
            |> Seq.map (AsteroidBelts.byId >> Option.get)

    [<Extension>]
    static member Moons(planet: Planet) =
        planet
            |> argNull "planet"
            |> (fun p -> SolarSystems.planetRefData p.SolarSystemId p.Id )
            |> (fun pr -> pr.moonIds)
            |> Seq.map (Moons.byId >> Option.get)
                               
    [<Extension>]
    static member DestinationSolarSystem(stargate: Stargate)=
        stargate
            |> argNull "stargate"
            |> fun sg -> SolarSystems.byId sg.DestinationSolarSystemId 
            |> Option.get
    
    [<Extension>]
    static member DestinationStargate(stargate: Stargate)=
        stargate
            |> argNull "stargate"
            |> fun sg -> Stargates.byId sg.DestinationStargateId
            |> Option.get

    
    [<Extension>]
    static member SolarSystem(stargate: Stargate)=
        stargate
            |> argNull "stargate"
            |> fun sg -> SolarSystems.byId sg.SolarSystemId
            |> Option.get

    [<Extension>]
    static member FindRoute(solarSystem: SolarSystem)(finish: SolarSystem)=
        (solarSystem, finish) |> Navigation.findRoute Navigation.euclideanSystemDistance 

    [<Extension>]
    static member FindHighsecRoute(solarSystem: SolarSystem)(finish: SolarSystem)=
        (solarSystem, finish) |> Navigation.findRoute Navigation.euclideanSystemDistancePreferHighsec

    [<Extension>]
    static member FindExHighsecRoute(solarSystem: SolarSystem)(finish: SolarSystem)=
        (solarSystem, finish) |> Navigation.findRoute Navigation.euclideanSystemDistanceAvoidHighsec
