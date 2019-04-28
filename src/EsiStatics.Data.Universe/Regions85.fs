namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions85=
    let getRegion id = 
      match id with 
      | 10000009 -> { RegionData.id= 10000009; name= "Insmother"; constellationIds= [| 20000108; 20000109; 20000110; 20000111; 20000112; 20000113; 20000114; 20000115; 20000116; 20000117; 20000118; 20000119; 20000120; 20000121; 20000122; 20000123 |] } |> Some
      | _ -> None