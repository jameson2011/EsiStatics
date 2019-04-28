namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories1=
    let getCategory id = 
      match id with 
      | 1 -> { CategoryData.id= 1; name= "Owner"; published= false; groupIds= [| 1; 2; 19; 32 |] } |> Some
      | _ -> None