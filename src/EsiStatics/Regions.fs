namespace EsiStatics

module Regions =
    let id (region: Region) = 
        region  |> argNull "region"
                |> (fun r -> r.Id)

    [<CompiledName("ById")>]
    let byId (id: int) = 
        id  |> Data.Universe.Regions.getRegion
            |> Option.map TypeMaps.ofRegionData

    [<CompiledName("GetAll")>]
    let all () = 
        Data.Universe.Regions.regions() |> Seq.map TypeMaps.ofRegionData
