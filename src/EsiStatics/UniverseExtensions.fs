﻿namespace EsiStatics

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
    static member FindGateRoute(solarSystem: SolarSystem)(finish: SolarSystem)=
        (solarSystem, finish) |> Navigation.findGateRoute Navigation.euclideanSystemDistance 

    [<Extension>]
    static member FindHighsecGateRoute(solarSystem: SolarSystem)(finish: SolarSystem)=
        (solarSystem, finish) |> Navigation.findGateRoute Navigation.euclideanSystemDistancePreferHighsec

    [<Extension>]
    static member FindExHighsecGateRoute(solarSystem: SolarSystem)(finish: SolarSystem)=
        (solarSystem, finish) |> Navigation.findGateRoute Navigation.euclideanSystemDistanceAvoidHighsec


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
    static member SolarSystem(planet: Planet) =
        planet
            |> argNull "planet"
            |> (fun p -> p.SolarSystemId)
            |> (SolarSystems.byId >> Option.get)
                
[<Extension>]
type StationExts = 
    
    [<Extension>]
    static member SolarSystem(value: Station) =
        value
            |> argNull "value"
            |> (fun p -> p.SolarSystemId)
            |> (SolarSystems.byId >> Option.get)

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

[<Extension>]
type MoonExts = 
    
    [<Extension>]
    static member SolarSystem(value: Moon) =
        value
            |> argNull "value"
            |> (fun p -> p.SolarSystemId)
            |> (SolarSystems.byId >> Option.get)

    [<Extension>]
    static member Planet(value: Moon) =
        value
            |> argNull "value"
            |> (fun p -> p.PlanetId)
            |> (Planets.byId >> Option.get)


[<Extension>]
type AsteroidBeltExts = 
    
    [<Extension>]
    static member SolarSystem(value: AsteroidBelt) =
        value
            |> argNull "value"
            |> (fun p -> p.SolarSystemId)
            |> (SolarSystems.byId >> Option.get)

    [<Extension>]
    static member Planet(value: AsteroidBelt) =
        value
            |> argNull "value"
            |> (fun p -> p.PlanetId)
            |> (Planets.byId >> Option.get)

[<Extension>]
type StarExts = 
    
    [<Extension>]
    static member SolarSystem(value: Star) =
        value
            |> argNull "value"
            |> (fun p -> p.SolarSystemId)
            |> (SolarSystems.byId >> Option.get)