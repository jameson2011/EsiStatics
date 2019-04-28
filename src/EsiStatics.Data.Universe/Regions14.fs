namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions14=
    let getRegion id = 
      match id with 
      | 10000035 -> { RegionData.id= 10000035; name= "Deklein"; constellationIds= [| 20000424; 20000425; 20000426; 20000427; 20000428; 20000429; 20000430; 20000431; 20000432 |] } |> Some
      | 11000008 -> { RegionData.id= 11000008; name= "B-R00008"; constellationIds= [| 21000060; 21000061; 21000062; 21000063; 21000064; 21000065; 21000066; 21000067; 21000068; 21000069; 21000070; 21000071; 21000072; 21000073; 21000074; 21000075 |] } |> Some
      | _ -> None