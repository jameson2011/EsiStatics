namespace EsiStatics.UnitTests

open System
open Xunit
open FluentAssertions

module CategoryTests=
    open EsiStatics.Data.ItemTypes


    [<Fact>]
    let ``Categories returns non-zero categories``()=
        let values = Categories.categories()
                        |> Array.ofSeq

        values.Length.Should().NotBe(0, "")

    [<Theory>]
    [<InlineData(1)>]
    [<InlineData(2)>]
    [<InlineData(3)>]
    [<InlineData(4)>]
    [<InlineData(5)>]
    [<InlineData(6)>]
    [<InlineData(7)>]
    [<InlineData(8)>]
    [<InlineData(9)>]
    [<InlineData(10)>]
    [<InlineData(11)>]
    [<InlineData(14)>]
    [<InlineData(16)>]
    [<InlineData(17)>]
    [<InlineData(18)>]
    [<InlineData(20)>]
    [<InlineData(22)>]
    [<InlineData(23)>]
    [<InlineData(24)>]
    [<InlineData(25)>]
    [<InlineData(26)>]
    [<InlineData(29)>]
    [<InlineData(30)>]
    [<InlineData(32)>]
    [<InlineData(34)>]
    [<InlineData(35)>]
    [<InlineData(39)>]
    [<InlineData(40)>]
    [<InlineData(41)>]
    [<InlineData(42)>]
    [<InlineData(43)>]
    [<InlineData(46)>]
    [<InlineData(49)>]
    [<InlineData(53)>]
    let ``Categories return item types``(id)=
        let categoryItemTypes = EsiStatics.Categories.category 
                                >> Option.map ( EsiStatics.Categories.groups >> Seq.collect EsiStatics.Groups.itemTypes)
                                >> Option.defaultValue Seq.empty
                                >> Array.ofSeq
        
        let itemTypes = categoryItemTypes id

        itemTypes.Length.Should().NotBe(0, "")
