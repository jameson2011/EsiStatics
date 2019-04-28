namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories0=
    let getCategory id = 
      match id with 
      | 0 -> { CategoryData.id= 0; name= "#System"; published= false; groupIds= [| 0 |] } |> Some
      | _ -> None