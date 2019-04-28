namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories65=
    let getCategory id = 
      match id with 
      | 65 -> { CategoryData.id= 65; name= "Structure"; published= true; groupIds= [| 1404; 1405; 1406; 1407; 1408; 1409; 1410; 1657; 1876; 1924; 2015; 2016; 2017 |] } |> Some
      | _ -> None