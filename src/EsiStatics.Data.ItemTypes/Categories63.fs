namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories63=
    let getCategory id = 
      match id with 
      | 63 -> { CategoryData.id= 63; name= "Special Edition Assets"; published= true; groupIds= [| 976; 1194; 1195; 1225 |] } |> Some
      | _ -> None