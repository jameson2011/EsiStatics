namespace EsiStatics

module Moons=
    let internal identity (belt: Moon) = 
        belt |> argNull "belt"
             |> (fun ss -> ss.Id)

    let internal data = identity >> Data.Moons.Moons.getMoon

    let internal navigable (value: Moon) = value :> INavigable

    [<CompiledName("ById")>]
    let byId (id: int) = 
        id  |> Data.Moons.Moons.getMoon
            |> Option.map TypeMaps.ofMoonData

    