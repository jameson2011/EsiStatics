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
    let schoorasana = 30002654
    [<Literal>]
    let amamake = 30002537
    [<Literal>]
    let thera = 31000005
    [<Literal>]
    let ``QX-LIJ`` = 30004714
    [<Literal>]
    let raeghoscon = 30002726
    [<Literal>]
    let deepari = 30013489
    [<Literal>]
    let heild = 30002390

    let knownSystem = EsiStatics.SolarSystems.byId >> Option.get

[<AutoOpen>]
module KnownItemTypes=
    [<Literal>]
    let rifter = 587
    [<Literal>]
    let sin = 22430
    [<Literal>]
    let thanatos = 23911
    [<Literal>]
    let rhea = 28844

    let knownItemType = EsiStatics.ItemTypes.itemType >> Option.get

[<AutoOpen>]
module KnownStations = 
    [<Literal>]
    let instadockStation = 60013870
    [<Literal>]
    let averageStation = 60003715
    [<Literal>]
    let kickoutStation = 60005203

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

