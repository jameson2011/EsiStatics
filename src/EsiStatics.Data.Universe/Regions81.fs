namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions81=
    let getRegion id = 
      match id with 
      | 10000005 -> { RegionData.id= 10000005; name= "Detorid"; constellationIds= [| 20000063; 20000064; 20000065; 20000066; 20000067; 20000068; 20000069; 20000070; 20000071; 20000072; 20000073; 20000074; 20000075; 20000076 |] } |> Some
      | _ -> None