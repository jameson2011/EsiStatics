namespace EsiStatics.UnitTests



module Seq=
    let reduceOptions values = values |> Seq.filter Option.isSome |> Seq.map Option.get

[<AutoOpen>]
module KnownSystems =
    [<Literal>]
    let adirain = 30005003
    [<Literal>]
    let jita = 30000142
    [<Literal>]
    let avenod = 30002089
    [<Literal>]
    let thera = 31000005
    [<Literal>]
    let ``QX-LIJ`` = 30004714

    
    let knownSystem = EsiStatics.SolarSystems.byId >> Option.get

[<AutoOpen>]
module UniverseHelpers=
    open EsiStatics.Data.Entities
    open EsiStatics.Data.Universe
    
    
    let getRegion = Regions.getRegion >> Option.get
    let getConstellation = Constellations.getConstellation >> Option.get
    let getSolarSystem = SolarSystems.getSolarSystem >> Option.get

    let getAllConstellations() = Regions.regions() 
                                |> Seq.collect (fun r -> r.constellationIds)
                                |> Seq.map getConstellation

    
    let getAllSolarSystems() = getAllConstellations()
                                |> Seq.collect (fun c -> c.solarSystemIds)
                                |> Seq.map getSolarSystem
    
    let getNeighbours (system: SolarSystemData) =
        system.stargateIds  |> Seq.map Stargates.getStargate
                            |> Seq.reduceOptions
                            |> Seq.map (fun sg -> sg.destinationSolarSystemId)
                            |> Seq.map getSolarSystem
                            |> Array.ofSeq