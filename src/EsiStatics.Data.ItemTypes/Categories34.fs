namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories34=
    let getCategory id = 
      match id with 
      | 34 -> { CategoryData.id= 34; name= "Ancient Relics"; published= true; groupIds= [| 971; 990; 991; 992; 993; 997 |] } |> Some
      | _ -> None