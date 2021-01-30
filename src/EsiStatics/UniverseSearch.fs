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

    let neighbourMaxDistance = 10.1 // LY
        
    let findNeighbours (systemId) = 
        systemId 
            |> EsiStatics.Data.Universe.SolarSystemJumps.getSolarSystemJumps
            |> Option.map (fun j -> j.jumps |> Array.filter (fun j -> j.distance <= neighbourMaxDistance) )
            |> Option.defaultValue [||]

    member this.Find(system: SolarSystem) (distance: float<LY>)= 
        let distance = distance |> float

        system.Id       |> findNeighbours
                        |> Seq.takeWhile (fun n -> n.distance <= distance)
                        |> Seq.map (fun n -> (SolarSystems.knownSystem n.solarSystemId, (n.distance |> Units.toLY) ))
                        |> Array.ofSeq
    
    member internal this.FindData(system: EsiStatics.Data.Entities.SolarSystemData) (distance: float<LY>)= 
        let distance = distance |> float

        system.id       |> findNeighbours
                        |> Seq.takeWhile (fun n -> n.distance <= distance)
                        |> Seq.map (fun n -> (n.solarSystemId |> Data.Universe.SolarSystems.getSolarSystem |> Option.get, n.distance |> Units.toLY) )
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
        


