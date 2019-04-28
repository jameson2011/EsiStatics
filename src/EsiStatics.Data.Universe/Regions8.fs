namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions8=
    let getRegion id = 
      match id with 
      | 10000029 -> { RegionData.id= 10000029; name= "Geminate"; constellationIds= [| 20000356; 20000357; 20000358; 20000359; 20000360; 20000361; 20000362; 20000363; 20000364; 20000365; 20000366 |] } |> Some
      | 11000002 -> { RegionData.id= 11000002; name= "A-R00002"; constellationIds= [| 21000001; 21000002; 21000003; 21000004; 21000005; 21000006; 21000007; 21000008; 21000009; 21000010; 21000011; 21000012; 21000013; 21000014 |] } |> Some
      | _ -> None