namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories40=
    let getCategory id = 
      match id with 
      | 40 -> { CategoryData.id= 40; name= "Sovereignty Structures"; published= true; groupIds= [| 1003; 1004; 1005; 1012 |] } |> Some
      | _ -> None