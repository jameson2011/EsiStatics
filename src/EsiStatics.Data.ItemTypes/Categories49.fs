namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories49=
    let getCategory id = 
      match id with 
      | 49 -> { CategoryData.id= 49; name= "Placeables"; published= false; groupIds= [| 940; 1079 |] } |> Some
      | _ -> None