﻿namespace EsiStatics.UnitTests

open System
open Xunit
open FluentAssertions
open EsiStatics


module SolarSystemsTests=
    
    [<Theory>]
    [<InlineData(KnownSystems.adirain, 2)>]
    [<InlineData(KnownSystems.avenod, 5)>]
    [<InlineData(KnownSystems.jita, 14)>]
    let ``SolarSystem has stations``(id, expectedCount: int)=
        
        let s = SolarSystems.byId id |> Option.get
        let stations = s |> SolarSystems.stations |> Array.ofSeq
        
        stations.Should().HaveCount(expectedCount, "") |> ignore
        
    [<Theory>]
    [<InlineData(KnownSystems.adirain, 3)>]
    [<InlineData(KnownSystems.avenod, 3)>]
    [<InlineData(KnownSystems.jita, 7)>]
    let ``SolarSystem has stargates``(id, expectedCount: int)=
        
        let s = SolarSystems.byId id |> Option.get
        let gates = s |> SolarSystems.stargates |> Array.ofSeq
        
        gates.Should().HaveCount(expectedCount, "") |> ignore
        

    [<Theory>]
    [<InlineData(KnownSystems.adirain, 10, 1)>]
    [<InlineData(KnownSystems.avenod, 9, 1)>]
    [<InlineData(KnownSystems.jita, 8, 0)>]
    let ``SolarSystem has belts & moons``(id, expectedCount: int, minBelts: int)=
        let moons = Planets.moons >> List.ofSeq
        let belts = Planets.asteroidBelts >> List.ofSeq

        let s = SolarSystems.byId id |> Option.get
        let planets = s |> SolarSystems.planets |> Array.ofSeq
        let xs = planets |> Array.map (fun p -> (p, belts p, moons p ))

        xs.Should().HaveCount(expectedCount, "") |> ignore
        (xs |> Array.exists (fun (_,b,_) -> b.Length >= minBelts)).Should().BeTrue("") |> ignore
        (xs |> Array.exists (fun (_,_,m) -> m.Length > 0)).Should().BeTrue("") |> ignore

    
    [<Theory>]
    [<InlineData(KnownSystems.adirain)>]
    let ``SolarSystem has star``(id)=

        let s = SolarSystems.byId id |> Option.get
        
        let star = s |> SolarSystems.star |> Option.get
        
        star.Should().NotBeNull("") |> ignore

    [<Theory>]
    [<InlineData(KnownSystems.adirain)>]
    let ``SolarSystem has constellation``(id)=

        let s = SolarSystems.byId id |> Option.get
        
        let c = s |> SolarSystems.constellation
        
        c.Id.Should().Be(s.ConstellationId, "") |> ignore

    
    

    [<Theory>]
    [<InlineData(KnownSystems.adirain)>]
    [<InlineData(KnownSystems.avenod)>]
    let ``SolarSystem has celestials``(id)=

        let notEmpty (xs: seq<'a>) = xs.Should().NotBeEmpty("") |> ignore

        let s = SolarSystems.byId id |> Option.get
        
        let cs = s |> SolarSystems.celestials |> Array.ofSeq
        
        cs.Should().NotBeEmpty("") |> ignore

        let planets = cs |> Array.filter (fun c -> c :? Planet)
        let belts = cs |> Array.filter (fun c -> c :? AsteroidBelt)
        let stars = cs |> Array.filter (fun c -> c :? Star)
        let stations = cs |> Array.filter (fun c -> c :? Station)
        let moons = cs |> Array.filter (fun c -> c :? Moon)

        notEmpty planets 
        notEmpty belts
        notEmpty stars
        notEmpty stations
        notEmpty moons

    
    [<Theory>]
    [<InlineData(KnownSystems.adirain)>]
    let ``SolarSystem has celestial distances``(id)=
        let pos = Position.empty

        let s = SolarSystems.byId id |> Option.get
        let cs = s |> SolarSystems.celestials |> Array.ofSeq

        let results = s |> SolarSystems.celestialDistances pos |> Array.ofSeq
        results.Should().HaveCount(cs.Length, "") |> ignore
        
        let distances = results |> Array.map (snd >> float)
        
        distances.Should().BeInAscendingOrder("") |> ignore
        
        