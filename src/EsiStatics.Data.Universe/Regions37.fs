namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions37=
    let getRegion id = 
      match id with 
      | 10000058 -> { RegionData.id= 10000058; name= "Fountain"; constellationIds= [| 20000665; 20000666; 20000667; 20000668; 20000669; 20000670; 20000671; 20000672; 20000673; 20000674; 20000675; 20000676; 20000677; 20000678; 20000679; 20000680; 20000681 |] } |> Some
      | 11000031 -> { RegionData.id= 11000031; name= "G-R00031"; constellationIds= [| 21000324 |] } |> Some
      | 12000004 -> { RegionData.id= 12000004; name= "ADR04"; constellationIds= [| 22000016; 22000017; 22000018; 22000019; 22000020 |] } |> Some
      | _ -> None