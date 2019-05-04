namespace EsiStatics

open EsiStatics.Data.Universe

type SolarSystemFinder() =
    
    let solarSystems = Regions.regions()
                            |> Seq.collect (fun r -> r.constellationIds)
                            |> Seq.map (Constellations.getConstellation >> Option.get)
                            |> Seq.collect (fun c -> c.solarSystemIds)
                            |> Seq.map (SolarSystems.getSolarSystem >> Option.get)

    let indexValues = solarSystems
                            |> Seq.map (fun s -> (s.name, (s.name, s.id)))

    let index = MutableTrie.Create indexValues

    member this.Find(search: string) =
        search
            |> argNull "search"
            |> index.Find 
            |> Seq.map (snd >> EsiStatics.SolarSystems.knownSystem)
        

