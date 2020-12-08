namespace EsiStatics.UnitTests

open System
open Xunit
open EsiStatics
open EsiStatics.Units
open FluentAssertions

module SolarSystemDistanceFinder=
        
    let finder = new SolarSystemFinder()
    let eagerDistances = new SolarSystemDistanceFinder(true)
    let lazyDistances = new SolarSystemDistanceFinder(false)

    [<Theory>]
    [<InlineData("adirain", 2.<LY>, false, 9)>]
    [<InlineData("adirain", 2.<LY>, true, 2)>]
    [<InlineData("adirain", 8.<LY>, false, 391)>]
    [<InlineData("adirain", 8.<LY>, true, 143)>]
    let ``find neighbours eagerly``(search: string, distance: float<LY>, ignoreHighsec: bool, expectedCount: int)=
                
        let system = search  |> finder.Find |> Seq.head

        let neighbours = eagerDistances.Find system distance |> Array.ofSeq

        let neighbours = if ignoreHighsec then neighbours |> Array.filter (fun (s,_) -> s.Level <> SecurityLevel.Highsec) else neighbours                    
        
        neighbours.Should().HaveCount(expectedCount,"")

    [<Theory>]
    [<InlineData("adirain", 2.<LY>, false, 9)>]
    [<InlineData("adirain", 2.<LY>, true, 2)>]
    [<InlineData("adirain", 8.<LY>, false, 391)>]
    [<InlineData("adirain", 8.<LY>, true, 143)>]
    let ``find neighbours lazily``(search: string, distance: float<LY>, ignoreHighsec: bool, expectedCount: int)=
                
        let system = search  |> finder.Find |> Seq.head

        let neighbours = eagerDistances.Find system distance |> Array.ofSeq

        let neighbours = if ignoreHighsec then neighbours |> Array.filter (fun (s,_) -> s.Level <> SecurityLevel.Highsec) else neighbours                    
        
        neighbours.Should().HaveCount(expectedCount,"")
