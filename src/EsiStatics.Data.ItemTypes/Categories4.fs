namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories4=
    let getCategory id = 
      match id with 
      | 4 -> { CategoryData.id= 4; name= "Material"; published= true; groupIds= [| 17; 18; 20; 422; 423; 427; 428; 429; 712; 754; 886; 966; 967; 974; 1136; 1676; 1996 |] } |> Some
      | _ -> None