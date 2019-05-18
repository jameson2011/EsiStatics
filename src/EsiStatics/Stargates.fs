namespace EsiStatics

module Stargates=
    let internal identity (stargate: Stargate) = 
        stargate |> argNull "stargate"
                 |> (fun ss -> ss.Id)

    let internal data = identity >> Data.Universe.Stargates.getStargate

    let internal navigable (value: Stargate) = value :> INavigable

    [<CompiledName("Get")>]
    let byId (id: int) = 
        id  |> Data.Universe.Stargates.getStargate
            |> Option.map TypeMaps.ofStargateData

    