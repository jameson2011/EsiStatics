namespace EsiStatics.UnitTests

open System
open Xunit
open EsiStatics
open EsiStatics.Units
open FluentAssertions

module SolarSystemDistanceFinder=
    

    let finder = new SolarSystemFinder()
    let distances = new SolarSystemDistanceFinder()

    [<Theory>]
    [<InlineData("adirain", 2.<LY>, false, 9)>]
    [<InlineData("adirain", 2.<LY>, true, 2)>]
    [<InlineData("adirain", 8.<LY>, false, 391)>]
    [<InlineData("adirain", 8.<LY>, true, 143)>]
    let ``find neighbours``(search: string, distance: float<LY>, ignoreHighsec: bool, expectedCount: int)=
                
        let system = search  |> finder.Find |> Seq.head

        let neighbours = distances.Find system distance |> Array.ofSeq

        let neighbours = if ignoreHighsec then neighbours |> Array.filter (fun (s,_) -> s.Level <> SecurityLevel.Highsec) else neighbours                    
        
        neighbours.Should().HaveCount(expectedCount,"")
