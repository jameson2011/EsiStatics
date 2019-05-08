namespace EsiStatics

module AsteroidBelts=
    let internal identity (belt: AsteroidBelt) = 
        belt |> argNull "belt"
             |> (fun ss -> ss.Id)

    let internal data = identity >> Data.Universe.AsteroidBelts.getAsteroidBelt

    let internal navigable (value: AsteroidBelt) = value :> INavigable

    [<CompiledName("ById")>]
    let byId (id: int) = 
        id  |> Data.Universe.AsteroidBelts.getAsteroidBelt
            |> Option.map TypeMaps.ofAsteroidBeltData
            

