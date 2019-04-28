namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions25=
    let getRegion id = 
      match id with 
      | 10000046 -> { RegionData.id= 10000046; name= "Fade"; constellationIds= [| 20000536; 20000537; 20000538; 20000539 |] } |> Some
      | 11000019 -> { RegionData.id= 11000019; name= "D-R00019"; constellationIds= [| 21000173; 21000174; 21000175; 21000176; 21000177; 21000178; 21000179; 21000180; 21000181; 21000182; 21000183; 21000184; 21000185; 21000186 |] } |> Some
      | _ -> None