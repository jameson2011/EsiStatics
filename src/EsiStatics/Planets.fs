namespace EsiStatics

module Planets=
    let internal identity (planet: Planet) = 
        planet |> argNull "planet"
                    |> (fun ss -> ss.Id)

    let internal data = identity >> Data.Universe.Planets.getPlanet

    let internal navigable (value: Planet) = value :> INavigable

    [<CompiledName("Get")>]
    let byId (id: int) = 
        id  |> Data.Universe.Planets.getPlanet
            |> Option.map TypeMaps.ofPlanetData
    
    let asteroidBelts(planet: Planet) =
        planet
            |> argNull "planet"
            |> data
            |> Option.map (fun pr -> pr.asteroidBeltIds)
            |> Option.defaultValue [||]
            |> Seq.map (AsteroidBelts.byId >> Option.get)

    
    let moons(planet: Planet) =
        planet
            |> argNull "planet"
            |> data
            |> Option.map (fun pr -> pr.moonIds)
            |> Option.defaultValue [||]
            |> Seq.map (Moons.byId >> Option.get)
