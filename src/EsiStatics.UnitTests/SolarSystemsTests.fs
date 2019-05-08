namespace EsiStatics.UnitTests

open System
open Xunit
open FluentAssertions
open EsiStatics


module SolarSystemsTests=
    
    [<Theory>]
    [<InlineData(KnownSystems.adirain, 10)>]
    let ``SolarSystem has belts & moons``(id, expectedCount: int)=
        let moons = Planets.moons >> List.ofSeq
        let belts = Planets.asteroidBelts >> List.ofSeq

        let s = SolarSystems.byId id |> Option.get
        let planets = s |> SolarSystems.planets |> Array.ofSeq
        let xs = planets |> Array.map (fun p -> (p, belts p, moons p ))

        xs.Should().HaveCount(expectedCount, "") |> ignore
        (xs |> Array.exists (fun (_,b,_) -> b.Length > 0)).Should().BeTrue("") |> ignore
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
