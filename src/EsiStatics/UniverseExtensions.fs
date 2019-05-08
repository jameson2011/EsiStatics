namespace EsiStatics

open System.Runtime.CompilerServices


[<Extension>]
type RegionExts=

    [<Extension>]
    static member Constellations(region: Region) =
        Regions.constellations region

[<Extension>]
type ConstellationExts=

    [<Extension>]
    static member SolarSystems(constellation: Constellation) =
        constellation
            |> Constellations.solarSystems

    [<Extension>]
    static member Region(constellation: Constellation) =
        constellation
            |> Constellations.region


[<Extension>]
type SolarSystemExts=

    [<Extension>]
    static member Constellation(solarSystem: SolarSystem) =
        solarSystem |> SolarSystems.constellation
    
    [<Extension>]
    static member Planets(solarSystem: SolarSystem) =
        solarSystem |> SolarSystems.planets
    
    [<Extension>]
    static member Star(solarSystem: SolarSystem) =
        solarSystem |> SolarSystems.star
    
    [<Extension>]
    static member Stations(solarSystem: SolarSystem) =
        solarSystem |> SolarSystems.stations
    
    [<Extension>]
    static member Stargates(solarSystem: SolarSystem) =
        solarSystem |> SolarSystems.stargates

    [<Extension>]
    static member Neighbours(solarSystem: SolarSystem)(depth: int)=
        solarSystem |> SolarSystems.neighbours depth

    [<Extension>]
    static member Celestials(solarSystem: SolarSystem)=
        solarSystem |> SolarSystems.celestials
             
    [<Extension>]
    static member CelestialDistances(solarSystem: SolarSystem)(position: Position)=
        solarSystem |> SolarSystems.celestialDistances position
        
    [<Extension>]
    static member FindRoute(solarSystem: SolarSystem)(finish: SolarSystem)=
        (solarSystem, finish) |> Navigation.findRoute Navigation.euclideanSystemDistance 

    [<Extension>]
    static member FindHighsecRoute(solarSystem: SolarSystem)(finish: SolarSystem)=
        (solarSystem, finish) |> Navigation.findRoute Navigation.euclideanSystemDistancePreferHighsec

    [<Extension>]
    static member FindExHighsecRoute(solarSystem: SolarSystem)(finish: SolarSystem)=
        (solarSystem, finish) |> Navigation.findRoute Navigation.euclideanSystemDistanceAvoidHighsec


[<Extension>]
type PlanetExts=
    [<Extension>]
    static member AsteroidBelts(planet: Planet) =
        planet
            |> argNull "planet"
            |> Planets.asteroidBelts

    [<Extension>]
    static member Moons(planet: Planet) =
        planet
            |> argNull "planet"
            |> Planets.moons
                               
[<Extension>]
type StargateExts=

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
