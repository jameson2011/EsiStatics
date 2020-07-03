namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories29=
    let getCategory id = 
      match id with 
      | 29 -> { CategoryData.id= 29; name= "Abstract"; published= false; groupIds= [| 937; 1109; 1121; 1319; 4071 |] } |> Some
      | _ -> None