namespace EsiStatics

module Stars=
    let internal identity (star: Star) = 
        star    |> argNull "star"
                |> (fun ss -> ss.Id)

    let internal data = identity >> Data.Universe.Stars.getStar

    let internal navigable (value: Star) = value :> INavigable

    [<CompiledName("Get")>]
    let byId (id: int) = 
        id  |> Data.Universe.Stars.getStar
            |> Option.map TypeMaps.ofStarData
            
    