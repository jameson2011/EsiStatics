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
        
type SolarSystemDistanceFinder() =

    let systems = 
        lazy (
            Data.Universe.Regions.regions()
                |> Seq.collect (fun r -> r.constellationIds)
                |> Seq.map (Constellations.getConstellation >> Option.get)
                |> Seq.collect (fun c -> c.solarSystemIds)
                |> Seq.map (SolarSystems.getSolarSystem >> Option.get)
                |> Seq.map (fun s -> (s.id, s))
                |> Map.ofSeq
        )
    
    let findNeighbours systemId = 
        systemId 
            |> EsiStatics.Data.Universe.SolarSystemJumps.getSolarSystemJumps
            |> Option.map (fun j -> j.jumps)
            |> Option.defaultValue [||]

    let findJumpsInRange distance = findNeighbours >> Seq.takeWhile (fun n -> n.distance <= distance)

    let findNeighbourJumps distance = 
        findJumpsInRange distance 
            >> Seq.map (fun n -> (systems.Value.[n.solarSystemId], (n.distance |> Units.toLY) ))


    member this.Find (distance: float<LY>) (system: SolarSystem)= 
        let distance = distance |> float

        system.Id 
            |> findNeighbourJumps distance
            |> Seq.map (fun (s,d) -> (TypeMaps.ofSolarSystemData s, d ) )
            |> Array.ofSeq
    
    member internal this.FindData(distance: float<LY>) (system: EsiStatics.Data.Entities.SolarSystemData)= 
        let distance = distance |> float

        system.id 
            |> findNeighbourJumps distance
            |> Array.ofSeq        

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
        


