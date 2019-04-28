namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories39=
    let getCategory id = 
      match id with 
      | 39 -> { CategoryData.id= 39; name= "Infrastructure Upgrades"; published= true; groupIds= [| 1016; 1020; 1021 |] } |> Some
      | _ -> None