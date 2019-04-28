namespace EsiStatics

module Constellations=
    let id (constellation: Constellation) = 
        constellation |> argNull "constellation" 
                      |> (fun c -> c.Id)

    [<CompiledName("ById")>]
    let byId (id: int) = 
        id  |> Data.Universe.Constellations.getConstellation
            |> Option.map TypeMaps.ofConstellationData
            


