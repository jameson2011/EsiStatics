namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions36=
    let getRegion id = 
      match id with 
      | 10000057 -> { RegionData.id= 10000057; name= "Outer Ring"; constellationIds= [| 20000656; 20000657; 20000658; 20000659; 20000660; 20000661; 20000662; 20000663; 20000664 |] } |> Some
      | 11000030 -> { RegionData.id= 11000030; name= "F-R00030"; constellationIds= [| 21000297; 21000298; 21000299; 21000300; 21000301; 21000302; 21000303; 21000304; 21000305; 21000306; 21000307; 21000308; 21000309; 21000310; 21000330 |] } |> Some
      | 12000003 -> { RegionData.id= 12000003; name= "ADR03"; constellationIds= [| 22000011; 22000012; 22000013; 22000014; 22000015 |] } |> Some
      | _ -> None