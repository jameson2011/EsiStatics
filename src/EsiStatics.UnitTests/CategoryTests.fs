namespace EsiStatics.UnitTests

open System
open Xunit
open FluentAssertions

module CategoryTests=
    open EsiStatics.Data.ItemTypes


    [<Fact>]
    let ``Categories returns non-zero``()=
        let values = Categories.categories()
                        |> Array.ofSeq

        values.Length.Should().NotBe(0, "")
