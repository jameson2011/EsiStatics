namespace EsiStatics.UnitTests

open System
open Xunit
open FluentAssertions
open EsiStatics


module RegionTests=

    [<Fact>]
    let ``unknown region.Constellations returns an empty sequence``() =
        let r = { Region.Id = -1; Name = ""} 

        let constellations = r.Constellations() |> Array.ofSeq

        constellations.Length.Should().Be(0, "must be empty") |> ignore

    [<Fact>]
    let ``region.Constellations returns a non-empty sequence``() =
        let r = { Region.Id = 10000064; Name = ""} 

        let constellations = r.Constellations() |> Array.ofSeq

        constellations.Length.Should().NotBe(0, "need > 0 constellations") |> ignore
        