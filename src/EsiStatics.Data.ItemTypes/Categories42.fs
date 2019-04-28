namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories42=
    let getCategory id = 
      match id with 
      | 42 -> { CategoryData.id= 42; name= "Planetary Resources"; published= true; groupIds= [| 1032; 1033; 1035 |] } |> Some
      | _ -> None