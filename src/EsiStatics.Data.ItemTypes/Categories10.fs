namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories10=
    let getCategory id = 
      match id with 
      | 10 -> { CategoryData.id= 10; name= "Trading"; published= false; groupIds= [| 94; 95 |] } |> Some
      | _ -> None