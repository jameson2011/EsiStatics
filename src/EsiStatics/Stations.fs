namespace EsiStatics

module Stations=
    let id (station: Station) = 
        station |> argNull "station"
                |> (fun ss -> ss.Id)

    let internal data = id >> Data.Universe.Stations.getStation

    [<CompiledName("ById")>]
    let byId (id: int) = 
        id  |> Data.Universe.Stations.getStation
            |> Option.map TypeMaps.ofStationData

    let internal navigable (value: Station) = value :> INavigable