namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories26=
    let getCategory id = 
      match id with 
      | 26 -> { CategoryData.id= 26; name= "WorldSpace"; published= false; groupIds= [| 935; 1067; 1068 |] } |> Some
      | _ -> None