namespace EsiStatics

module Stargates=
    let id (stargate: Stargate) = 
        stargate |> argNull "stargate"
                 |> (fun ss -> ss.Id)

    let internal data = id >> Data.Universe.Stargates.getStargate

    [<CompiledName("ById")>]
    let byId (id: int) = 
        id  |> Data.Universe.Stargates.getStargate
            |> Option.map TypeMaps.ofStargateData

    let internal navigable (value: Stargate) = value :> INavigable