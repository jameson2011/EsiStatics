namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories30=
    let getCategory id = 
      match id with 
      | 30 -> { CategoryData.id= 30; name= "Apparel"; published= true; groupIds= [| 1083; 1084; 1085; 1086; 1087; 1088; 1089; 1090; 1091; 1092; 1093; 1271; 1670 |] } |> Some
      | _ -> None