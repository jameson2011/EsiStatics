namespace EsiStatics.UnitTests

open System
open Xunit
open FluentAssertions

module GroupsTests=

    open EsiStatics.Data.ItemTypes
    
    [<Fact>]
    let ``Groups returns non-zero``()=
        let values = Groups.groups()
                        |> Array.ofSeq

        values.Length.Should().NotBe(0, "")


    [<Fact>]
    let ``Groups address item types``()=        
        let values = Groups.groups()
                        |> Seq.collect (fun g -> g.typeIds)
                        |> Seq.map ItemTypes.getItemType
                        |> Array.ofSeq

        values.Length.Should().NotBe(0, "")