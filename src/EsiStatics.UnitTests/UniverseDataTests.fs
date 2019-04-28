namespace EsiStatics.UnitTests

open System
open Xunit
open FluentAssertions
open EsiStatics.Data.Entities
open EsiStatics.Data.Universe
open EsiStatics.Data.Moons
open EsiStatics.Moons

module UniverseTests=

    [<Fact>]
    let ``Walk Regions Names``() =
        let regions = Regions.regions() 
        
        let names = regions |> Seq.map (fun s -> s.name)

        let emptyNames = names  |> Seq.filter (fun n -> n.Length = 0)
                                |> Seq.length

        emptyNames.Should().Be(0, "no name should be empty")

    
    [<Fact>]
    let ``Walk Constellation Names``() =
        let constellations = getAllConstellations()

        let names = constellations |> Seq.map (fun s -> s.name)

        let emptyNames = names  |> Seq.filter (fun n -> n.Length = 0)
                                |> Seq.length

        emptyNames.Should().Be(0, "no name should be empty")
        

    [<Fact>]
    let ``Walk Systems Names``() =
        let systems = getAllSolarSystems()

        let names = systems |> Seq.map (fun s -> s.name)

        let emptyNames = names  |> Seq.filter (fun n -> n.Length = 0)
                                |> Seq.length

        emptyNames.Should().Be(0, "no name should be empty")
        
    
    [<Fact>]
    let ``Walk Solar System planets``() =
        let values = getAllSolarSystems()
                        |> Seq.collect (fun s -> s.planetIds)
                        |> Seq.map (fun p -> p.planetId)
                        |> Seq.map (Planets.getPlanet >> Option.get)

        let names = values |> Seq.map (fun s -> s.name)

        let emptyNames = names  |> Seq.filter (fun n -> n.Length = 0)
                                |> Seq.length

        emptyNames.Should().Be(0, "no name should be empty")


    
    [<Fact>]
    let ``Walk Solar System stars``() =
        let values = getAllSolarSystems()
                        |> Seq.collect (fun s -> s.starIds)
                        |> Seq.map (Stars.getStar >> Option.get)

        let names = values |> Seq.map (fun s -> s.name)

        let emptyNames = names  |> Seq.filter (fun n -> n.Length = 0)
                                |> Seq.length

        emptyNames.Should().Be(0, "no name should be empty")

    
    [<Fact>]
    let ``Walk Solar System stargates``() =
        let values = getAllSolarSystems()
                        |> Seq.collect (fun s -> s.stargateIds)
                        |> Seq.map (Stargates.getStargate >> Option.get)

        let names = values |> Seq.map (fun s -> s.name)

        let emptyNames = names  |> Seq.filter (fun n -> n.Length = 0)
                                |> Seq.length

        emptyNames.Should().Be(0, "no name should be empty")

    
    [<Fact>]
    let ``Walk Solar System stations``() =
        let values = getAllSolarSystems()
                        |> Seq.collect (fun s -> s.stationIds)
                        |> Seq.map (Stations.getStation >> Option.get)

        let names = values |> Seq.map (fun s -> s.name)

        let emptyNames = names  |> Seq.filter (fun n -> n.Length = 0)
                                |> Seq.length

        emptyNames.Should().Be(0, "no name should be empty")

    
    [<Fact>]
    let ``Walk Solar System belts``() =
        let values = getAllSolarSystems()
                        |> Seq.collect (fun s -> s.planetIds )
                        |> Seq.collect (fun p -> p.beltIds )
                        |> Seq.map (AsteroidBelts.getAsteroidBelt >> Option.get)

        let names = values |> Seq.map (fun s -> s.name)

        let emptyNames = names  |> Seq.filter (fun n -> n.Length = 0)
                                |> Seq.length

        emptyNames.Should().Be(0, "no name should be empty")


    [<Fact>]
    let ``Walk Solar System moons``() =
        let values = getAllSolarSystems()
                        |> Seq.collect (fun s -> s.planetIds)
                        |> Seq.collect (fun p -> p.moonIds)
                        |> Seq.map (Moons.getMoon >> Option.get)

        let names = values |> Seq.map (fun s -> s.name)

        let emptyNames = names  |> Seq.filter (fun n -> n.Length = 0)
                                |> Seq.length

        emptyNames.Should().Be(0, "no name should be empty")

    
