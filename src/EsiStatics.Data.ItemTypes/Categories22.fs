namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories22=
    let getCategory id = 
      match id with 
      | 22 -> { CategoryData.id= 22; name= "Deployable"; published= true; groupIds= [| 361; 1149; 1246; 1247; 1249; 1250; 1273; 1274; 1275; 1276; 1297; 1312; 2005 |] } |> Some
      | _ -> None