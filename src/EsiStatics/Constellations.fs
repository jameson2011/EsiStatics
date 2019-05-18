namespace EsiStatics

module Constellations=
    let internal identity (constellation: Constellation) = 
        constellation |> argNull "constellation" 
                      |> (fun c -> c.Id)

    [<CompiledName("Get")>]
    let byId (id: int) = 
        id  |> Data.Universe.Constellations.getConstellation
            |> Option.map TypeMaps.ofConstellationData
            
    let solarSystems(constellation: Constellation) =
        constellation
            |> argNull "constellation"
            |> identity
            |> Data.Universe.Constellations.getConstellation
            |> Option.map (fun c -> c.solarSystemIds)
            |> Option.defaultValue Array.empty
            |> Seq.map Data.Universe.SolarSystems.getSolarSystem
            |> Seq.reduceOptions
            |> Seq.map TypeMaps.ofSolarSystemData

    let region(constellation: Constellation) =
        constellation
            |> argNull "constellation"
            |> (fun r -> r.RegionId)
            |> Data.Universe.Regions.getRegion
            |> Option.get
            |> TypeMaps.ofRegionData

