namespace EsiStatics

module Stations=
    let internal identity (station: Station) = 
        station |> argNull "station"
                |> (fun ss -> ss.Id)

    let internal data = identity >> Data.Universe.Stations.getStation

    let internal navigable (value: Station) = value :> INavigable

    let internal stationDockingRadius(itemTypeId: int) =
        match itemTypeId with
        | 3867 -> Some 5.<km>
        | 56 -> Some 25.<km>
        | 57 -> Some 30.<km>
        | 3870 -> Some 25.<km>
        | 54 -> Some 10.<km>
        | 3868 -> Some 12.5<km>
        | 3869 -> Some 25.<km>
        | 2499 -> Some 50.<km>
        | 2497 -> Some 20.<km>
        | 2496 -> Some 5.<km>
        | 2498 -> Some 15.<km>
        | 2500 -> Some 3.<km>
        | 1531 -> Some 40.<km>
        | 2501 -> Some 3.<km>
        | 2502 -> Some 5.<km>
        | 1928 -> Some 2.<km>
        | 3865 -> Some 40.<km>
        | 1927 -> Some 40.<km>
        | 1926 -> Some 40.<km>
        | 1931 -> Some 30.<km>
        | 1929 -> Some 12.5<km>
        | 1932 -> Some 15.<km>
        | 1530 -> Some 20.<km>
        | 1529 -> Some 40.<km>
        | 4023 -> Some 20.<km>
        | 4024 -> Some 25.<km>
        | 1930 -> Some 20.<km>
        | 3872 -> Some 17.5<km>
        | 3866 -> Some 15.<km>
        | 3871 -> Some 10.<km>
        | _ -> None
        

    let internal station(station: Station)=
        let itemType = station.TypeId |> EsiStatics.Data.ItemTypes.ItemTypes.getItemType
        
        let dockingRadius = station.TypeId
                                |> stationDockingRadius 
                                |> Option.map (Units.kmToMetres >> Units.toMetres)
        
        let radius = itemType |> Option.map (fun it -> Units.toMetres it.radius) 
        
        { station with DockingRange = dockingRadius;
                        Radius = radius }

    [<CompiledName("Get")>]
    let byId (id: int) = 
        id  |> Data.Universe.Stations.getStation
            |> Option.map (TypeMaps.ofStationData >> station)

    