namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories24=
    let getCategory id = 
      match id with 
      | 24 -> { CategoryData.id= 24; name= "Reaction"; published= true; groupIds= [| 436; 484; 661; 662; 881; 882; 977 |] } |> Some
      | _ -> None