namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions12=
    let getRegion id = 
      match id with 
      | 10000033 -> { RegionData.id= 10000033; name= "The Citadel"; constellationIds= [| 20000401; 20000402; 20000403; 20000404; 20000405; 20000406; 20000407; 20000408; 20000409; 20000410; 20000411; 20000412; 20000413 |] } |> Some
      | 11000006 -> { RegionData.id= 11000006; name= "B-R00006"; constellationIds= [| 21000041; 21000042; 21000043; 21000044; 21000045; 21000046; 21000047; 21000048; 21000049; 21000050; 21000051; 21000052; 21000053; 21000054 |] } |> Some
      | _ -> None