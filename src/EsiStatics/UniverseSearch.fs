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

    
    do  if eagerIndex then index.Value |> ignore

    new() = SolarSystemFinder(false)

    member this.Find(search: string) =
        search
            |> argNull "search"
            |> index.Value.Find 
            |> Seq.map (EsiStatics.SolarSystems.knownSystem)
        
type SolarSystemDistanceFinder(eagerIndex) =

    let neighbourMaxDistance = 10.<LY>

    let index =
        lazy (                            
            // Approximately O(n^2) 
            let neighbours (allSystems: Data.Entities.SolarSystemData[]) (system: Data.Entities.SolarSystemData)=
                let distance (x: Data.Entities.SolarSystemData)= Geometry.euclideanData system.position x.position |> metresToLY                                
                allSystems 
                    |> Seq.filter (fun s -> s <> system)
                    |> Seq.map (fun s -> (distance s, s.id))
                    |> Seq.filter (fun (d,_) -> d <= neighbourMaxDistance)
                    |> Seq.sortBy fst
                    |> Array.ofSeq
            
            let systems = Regions.regions()
                                |> Seq.collect (fun r -> r.constellationIds)
                                |> Seq.map (Constellations.getConstellation >> Option.get)
                                |> Seq.collect (fun c -> c.solarSystemIds)
                                |> Seq.map (SolarSystems.getSolarSystem >> Option.get)
                                |> Seq.filter (fun ss ->    ss.secRating = Data.Entities.SystemSecurity.Lowsec || 
                                                            ss.secRating = Data.Entities.SystemSecurity.Highsec ||
                                                            ss.secRating = Data.Entities.SystemSecurity.Nullsec)
                                |> Array.ofSeq
            
            systems 
                |> Seq.map (fun s -> (s.id, neighbours systems s) )
                |> Map.ofSeq
        )

    do  if eagerIndex then index.Value |> ignore
    
    new() = SolarSystemDistanceFinder(false)

    member this.Find(system: SolarSystem) (distance: float<LY>)= 
        match index.Value |> Map.tryFind system.Id with
        | Some xs -> xs |> Seq.takeWhile (fun (d, _) -> d <= distance)
                        |> Seq.map (fun (d, s) -> (SolarSystems.knownSystem s, d)) 
                        |> Array.ofSeq
        | _ -> [| |]

type ConstellationFinder(eagerIndex) =
    
    let index = 
        lazy (
            Regions.regions()
                            |> Seq.collect (fun r -> r.constellationIds)
                            |> Seq.map (Constellations.getConstellation >> Option.get)
                            |> Seq.map (fun s -> (s.name, s.id))
                            |> ReadonlyTrie.Create
        )
            
    do  if eagerIndex then index.Value |> ignore

    new() = ConstellationFinder(false)

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

    do  if eagerIndex then index.Value |> ignore

    new() = RegionFinder(false)

    member this.Find(search: string) =
        search
            |> argNull "search"
            |> index.Value.Find 
            |> Seq.map (EsiStatics.Regions.byId >> Option.get)
        


