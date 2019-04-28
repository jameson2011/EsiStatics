namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories46=
    let getCategory id = 
      match id with 
      | 46 -> { CategoryData.id= 46; name= "Orbitals"; published= true; groupIds= [| 1025; 1073; 1106 |] } |> Some
      | _ -> None