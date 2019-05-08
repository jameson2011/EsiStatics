namespace EsiStatics

open EsiStatics.Data.Universe

type SolarSystemFinder() =
    
    let index = Regions.regions()
                            |> Seq.collect (fun r -> r.constellationIds)
                            |> Seq.map (Constellations.getConstellation >> Option.get)
                            |> Seq.collect (fun c -> c.solarSystemIds)
                            |> Seq.map (SolarSystems.getSolarSystem >> Option.get)
                            |> Seq.map (fun s -> (s.name,  s.id))
                            |> ReadonlyTrie.Create
    

    member this.Find(search: string) =
        search
            |> argNull "search"
            |> index.Find 
            |> Seq.map (EsiStatics.SolarSystems.knownSystem)
        


type ConstellationFinder() =
    
    let index = Regions.regions()
                            |> Seq.collect (fun r -> r.constellationIds)
                            |> Seq.map (Constellations.getConstellation >> Option.get)
                            |> Seq.map (fun s -> (s.name, s.id))
                            |> ReadonlyTrie.Create
    

    member this.Find(search: string) =
        search
            |> argNull "search"
            |> index.Find 
            |> Seq.map (EsiStatics.Constellations.byId >> Option.get)
        

type RegionFinder() =
    
    let index = Regions.regions()
                            |> Seq.map (fun s -> (s.name, s.id))
                            |> ReadonlyTrie.Create
    

    member this.Find(search: string) =
        search
            |> argNull "search"
            |> index.Find 
            |> Seq.map (EsiStatics.Regions.byId >> Option.get)
        


