namespace EsiStatics

module AsteroidBelts=
    let id (belt: AsteroidBelt) = 
        belt |> argNull "belt"
             |> (fun ss -> ss.Id)

    let internal data = id >> Data.Universe.AsteroidBelts.getAsteroidBelt

    [<CompiledName("ById")>]
    let byId (id: int) = 
        id  |> Data.Universe.AsteroidBelts.getAsteroidBelt
            |> Option.map TypeMaps.ofAsteroidBeltData

    let internal navigable (value: AsteroidBelt) = value :> INavigable