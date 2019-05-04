namespace EsiStatics.UnitTests

open System
open Xunit
open FluentAssertions

module SolarSystemFinderTests=
    open EsiStatics

    [<Theory>]
    [<InlineData("adira", 10)>]
    let ``find planets``(search: string, expectedCount: int)=
        let finder = new SolarSystemFinder()

        let planets = search  |> finder.Find |> Seq.collect (fun s -> s.Planets() )
                            |> Array.ofSeq
        
        planets.Should().HaveCount(expectedCount,"")
