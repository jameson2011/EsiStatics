namespace EsiStatics

module Regions =
    let internal identity (region: Region) = 
        region  |> argNull "region"
                |> (fun r -> r.Id)

    [<CompiledName("ById")>]
    let byId (id: int) = 
        id  |> Data.Universe.Regions.getRegion
            |> Option.map TypeMaps.ofRegionData

    [<CompiledName("GetAll")>]
    let all () = 
        Data.Universe.Regions.regions() |> Seq.map TypeMaps.ofRegionData

    let constellations(region: Region)=
        region
            |> argNull "region"
            |> identity
            |> Data.Universe.Regions.getRegion
            |> Option.map (fun r -> r.constellationIds) 
            |> Option.defaultValue Array.empty
            |> Seq.map Data.Universe.Constellations.getConstellation
            |> Seq.reduceOptions
            |> Seq.map TypeMaps.ofConstellationData
