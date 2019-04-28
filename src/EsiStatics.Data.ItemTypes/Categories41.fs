namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories41=
    let getCategory id = 
      match id with 
      | 41 -> { CategoryData.id= 41; name= "Planetary Interaction"; published= true; groupIds= [| 1026; 1027; 1028; 1029; 1030; 1036; 1063; 1081; 1082 |] } |> Some
      | _ -> None