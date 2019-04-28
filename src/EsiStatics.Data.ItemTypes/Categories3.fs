namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories3=
    let getCategory id = 
      match id with 
      | 3 -> { CategoryData.id= 3; name= "Station"; published= false; groupIds= [| 15; 16 |] } |> Some
      | _ -> None