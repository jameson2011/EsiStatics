namespace EsiStatics

module Planets=
    let internal identity (planet: Planet) = 
        planet |> argNull "planet"
                    |> (fun ss -> ss.Id)

    let internal data = identity >> Data.Universe.Planets.getPlanet

    [<CompiledName("ById")>]
    let byId (id: int) = 
        id  |> Data.Universe.Planets.getPlanet
            |> Option.map TypeMaps.ofPlanetData
            

    
    let internal navigable (value: Planet) = value :> INavigable