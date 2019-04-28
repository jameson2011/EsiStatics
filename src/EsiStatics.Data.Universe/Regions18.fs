namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions18=
    let getRegion id = 
      match id with 
      | 10000039 -> { RegionData.id= 10000039; name= "Esoteria"; constellationIds= [| 20000453; 20000454; 20000455; 20000456; 20000457; 20000458; 20000459; 20000460; 20000461; 20000462; 20000463; 20000464 |] } |> Some
      | 11000012 -> { RegionData.id= 11000012; name= "C-R00012"; constellationIds= [| 21000106; 21000107; 21000108; 21000109; 21000110; 21000111; 21000112; 21000113; 21000114; 21000115; 21000116; 21000117; 21000118; 21000119; 21000120; 21000121 |] } |> Some
      | _ -> None