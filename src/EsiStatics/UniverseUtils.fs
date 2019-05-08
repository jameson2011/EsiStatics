namespace EsiStatics

module internal UniverseUtils=
    let solarSystemPlanetRefData solarSystemId planetId =
         solarSystemId 
            |> Data.Universe.SolarSystems.getSolarSystem 
            |> Option.get 
            |> (fun s -> s.planetIds)
            |> Array.find (fun p -> p.planetId = planetId)

