namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories54=
    let getCategory id = 
      match id with 
      | 54 -> { CategoryData.id= 54; name= "Lights"; published= false; groupIds= [| 1110; 1111; 1112 |] } |> Some
      | _ -> None