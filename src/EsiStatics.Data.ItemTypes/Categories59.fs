namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories59=
    let getCategory id = 
      match id with 
      | 59 -> { CategoryData.id= 59; name= "Cells"; published= false; groupIds= [| 1126 |] } |> Some
      | _ -> None