namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions84=
    let getRegion id = 
      match id with 
      | 10000008 -> { RegionData.id= 10000008; name= "Scalding Pass"; constellationIds= [| 20000096; 20000097; 20000098; 20000099; 20000100; 20000101; 20000102; 20000103; 20000104; 20000105; 20000106; 20000107 |] } |> Some
      | _ -> None