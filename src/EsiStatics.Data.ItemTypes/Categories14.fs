namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories14=
    let getCategory id = 
      match id with 
      | 14 -> { CategoryData.id= 14; name= "Bonus"; published= false; groupIds= [| 190; 191; 192; 193; 194; 195; 196; 197; 198; 199 |] } |> Some
      | _ -> None