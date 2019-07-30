namespace EsiStatics.UnitTests

open System
open Xunit
open FluentAssertions

module ItemTypesFinderTests=
    open EsiStatics
    
    [<Theory>]
    [<InlineData(true)>]
    [<InlineData(false)>]
    let ``ctor is eagerly loaded``(isEager) =
        let finder = new ItemTypesFinder(isEager)

        let results = finder.Find("rifter") |> Array.ofSeq
        let results = finder.Find("rifter") |> Array.ofSeq
        results.Should().NotHaveCount(0, "")

    [<Fact>]
    let ``eager loaded returns same as lazy loaded``()=
        let finders =  [| new ItemTypesFinder(false); new ItemTypesFinder(true) |]

        let results = finders |> Array.map (fun f -> f.Find("rifter") |> Array.ofSeq)

        results.[0].Should().HaveCount(results.[1].Length, "")

    