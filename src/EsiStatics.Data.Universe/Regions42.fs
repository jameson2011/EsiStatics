namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions42=
    let getRegion id = 
      match id with 
      | 10000063 -> { RegionData.id= 10000063; name= "Period Basis"; constellationIds= [| 20000721; 20000722; 20000723; 20000724; 20000725; 20000726 |] } |> Some
      | _ -> None