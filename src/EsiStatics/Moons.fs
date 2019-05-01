namespace EsiStatics

module Moons=
    let internal id (belt: Moon) = 
        belt |> argNull "belt"
             |> (fun ss -> ss.Id)

    let internal data = id >> Data.Moons.Moons.getMoon

    [<CompiledName("ById")>]
    let byId (id: int) = 
        id  |> Data.Moons.Moons.getMoon
            |> Option.map TypeMaps.ofMoonData

    let internal navigable (value: Moon) = value :> INavigable