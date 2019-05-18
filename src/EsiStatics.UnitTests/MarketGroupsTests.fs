namespace EsiStatics.UnitTests

open System
open Xunit
open FluentAssertions

module MarketGroupsTests=

    open EsiStatics.Data.ItemTypes
    
    [<Fact>]
    let ``MarketGroups returns non-zero``()=
        let values = MarketGroups.marketGroups()
                        |> Array.ofSeq

        values.Length.Should().NotBe(0, "")

