namespace EsiStatics

open EsiStatics.Data.Universe

type SolarSystemFinder(eagerIndex) =
    
    let index = 
        lazy (
            Regions.regions()
                            |> Seq.collect (fun r -> r.constellationIds)
                            |> Seq.map (Constellations.getConstellation >> Option.get)
                            |> Seq.collect (fun c -> c.solarSystemIds)
                            |> Seq.map (SolarSystems.getSolarSystem >> Option.get)
                            |> Seq.map (fun s -> (s.name,  s.id))
                            |> ReadonlyTrie.Create
        )

    
    do  if eagerIndex then
            index.Value |> ignore

    new() = 
        SolarSystemFinder(false)

    member this.Find(search: string) =
        search
            |> argNull "search"
            |> index.Value.Find 
            |> Seq.map (EsiStatics.SolarSystems.knownSystem)
        


type ConstellationFinder(eagerIndex) =
    
    let index = 
        lazy (
            Regions.regions()
                            |> Seq.collect (fun r -> r.constellationIds)
                            |> Seq.map (Constellations.getConstellation >> Option.get)
                            |> Seq.map (fun s -> (s.name, s.id))
                            |> ReadonlyTrie.Create
        )
            
    do  if eagerIndex then
            index.Value |> ignore

    new() = 
        ConstellationFinder(false)

    member this.Find(search: string) =
        search
            |> argNull "search"
            |> index.Value.Find 
            |> Seq.map (EsiStatics.Constellations.byId >> Option.get)
        

type RegionFinder(eagerIndex) =
    
    let index = 
        lazy (
            Regions.regions()
                            |> Seq.map (fun s -> (s.name, s.id))
                            |> ReadonlyTrie.Create
        )

    do  if eagerIndex then
            index.Value |> ignore

    new() = 
        RegionFinder(false)

    member this.Find(search: string) =
        search
            |> argNull "search"
            |> index.Value.Find 
            |> Seq.map (EsiStatics.Regions.byId >> Option.get)
        


