﻿namespace EsiStatics

module SolarSystems=
    let internal identity (solarSystem: SolarSystem) = 
        solarSystem |> argNull "solarSystem"
                    |> (fun ss -> ss.Id)

    [<CompiledName("ById")>]
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

    let internal planetRefData solarSystemId planetId =
         solarSystemId 
            |> Data.Universe.SolarSystems.getSolarSystem 
            |> Option.get 
            |> (fun s -> s.planetIds)
            |> Array.find (fun p -> p.planetId = planetId)

    let internal navigable (value: Planet) = value :> INavigable