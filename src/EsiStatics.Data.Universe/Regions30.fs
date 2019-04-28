namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions30=
    let getRegion id = 
      match id with 
      | 10000051 -> { RegionData.id= 10000051; name= "Cloud Ring"; constellationIds= [| 20000590; 20000591; 20000592; 20000593; 20000594; 20000595 |] } |> Some
      | 11000024 -> { RegionData.id= 11000024; name= "E-R00024"; constellationIds= [| 21000232; 21000233; 21000234; 21000235; 21000236; 21000237; 21000238; 21000239; 21000240; 21000241; 21000242; 21000329 |] } |> Some
      | _ -> None