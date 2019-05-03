namespace EsiStatics.UnitTests

open System
open Xunit
open FluentAssertions

module ItemTypesTests=
    open EsiStatics.Data.ItemTypes
    
    [<Fact>]
    let ``ItemTypes Count is non-zero``() =
        let allTypes = ItemTypes.itemTypes() |> Array.ofSeq

        let c = allTypes.Length

        allTypes.Length.Should().NotBe(0, "") |> ignore

    [<Fact>]
    let ``ItemTypes all have names``() =
        let emptyNames = ItemTypes.itemTypes() 
                        |> Seq.filter (fun n -> n.name.Length = 0 )
                        |> Array.ofSeq
                        
        emptyNames.Length.Should().Be(0, "") |> ignore
