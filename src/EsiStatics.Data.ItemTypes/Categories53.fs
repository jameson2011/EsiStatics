namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories53=
    let getCategory id = 
      match id with 
      | 53 -> { CategoryData.id= 53; name= "Effects"; published= false; groupIds= [| 1105; 1107; 1108 |] } |> Some
      | _ -> None