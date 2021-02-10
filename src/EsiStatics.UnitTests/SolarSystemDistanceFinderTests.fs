namespace EsiStatics.UnitTests

open System
open Xunit
open EsiStatics
open EsiStatics.Units
open FluentAssertions

module SolarSystemDistanceFinderTests=
        
    let internal finder = new SolarSystemFinder()
    let internal distances = new SolarSystemDistanceFinder()
    
    [<Theory>]
    [<InlineData("adirain", 2.<LY>, false, 9)>]
    [<InlineData("adirain", 2.<LY>, true, 2)>]
    [<InlineData("adirain", 8.<LY>, false, 391)>]
    [<InlineData("adirain", 8.<LY>, true, 143)>]
    let ``find neighbours``(search: string, distance: float<LY>, ignoreHighsec: bool, expectedCount: int)=
                
        let system = search  |> finder.Find |> Seq.head

        let allNeighbours = distances.Find distance system |> Array.ofSeq

        let neighbours = if ignoreHighsec then allNeighbours |> Array.filter (fun (s,_) -> s.Level <> SecurityLevel.Highsec) else allNeighbours                    
        
        neighbours.Should().HaveCount(expectedCount,"")

    [<Theory>]
    [<InlineData("adirain", 2.<LY>, false, 9)>]
    [<InlineData("adirain", 2.<LY>, true, 2)>]
    [<InlineData("adirain", 8.<LY>, false, 391)>]
    [<InlineData("adirain", 8.<LY>, true, 143)>]
    let ``find neighbours Data``(search: string, distance: float<LY>, ignoreHighsec: bool, expectedCount: int)=
                
        let system = search  |> finder.Find |> Seq.head
                        |> (fun s -> s.Id)
                        |> Data.Universe.SolarSystems.getSolarSystem
                        |> Option.get

        let allNeighbours = distances.FindData distance system |> Array.ofSeq

        let neighbours = if ignoreHighsec then allNeighbours |> Array.filter (fun (s,_) -> s.secRating <> Data.Entities.SystemSecurity.Highsec) else allNeighbours                    
        
        neighbours.Should().HaveCount(expectedCount,"")

