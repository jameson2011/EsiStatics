namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories16=
    let getCategory id = 
      match id with 
      | 16 -> { CategoryData.id= 16; name= "Skill"; published= true; groupIds= [| 255; 256; 257; 258; 266; 268; 269; 270; 272; 273; 274; 275; 278; 505; 1209; 1210; 1213; 1216; 1217; 1218; 1220; 1240; 1241; 1545 |] } |> Some
      | _ -> None