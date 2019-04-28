namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions17=
    let getRegion id = 
      match id with 
      | 10000038 -> { RegionData.id= 10000038; name= "The Bleak Lands"; constellationIds= [| 20000448; 20000449; 20000450; 20000451; 20000452 |] } |> Some
      | 11000011 -> { RegionData.id= 11000011; name= "C-R00011"; constellationIds= [| 21000093; 21000094; 21000095; 21000096; 21000097; 21000098; 21000099; 21000100; 21000101; 21000102; 21000103; 21000104; 21000105 |] } |> Some
      | _ -> None