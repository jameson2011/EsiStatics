namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions26=
    let getRegion id = 
      match id with 
      | 10000047 -> { RegionData.id= 10000047; name= "Providence"; constellationIds= [| 20000540; 20000541; 20000542; 20000543; 20000544; 20000545; 20000546; 20000547; 20000548; 20000549; 20000550; 20000551; 20000552 |] } |> Some
      | 11000020 -> { RegionData.id= 11000020; name= "D-R00020"; constellationIds= [| 21000187; 21000188; 21000189; 21000190; 21000191; 21000192; 21000193; 21000194 |] } |> Some
      | _ -> None