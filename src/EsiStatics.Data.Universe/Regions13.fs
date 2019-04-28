namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions13=
    let getRegion id = 
      match id with 
      | 10000034 -> { RegionData.id= 10000034; name= "The Kalevala Expanse"; constellationIds= [| 20000414; 20000415; 20000416; 20000417; 20000418; 20000419; 20000420; 20000421; 20000422; 20000423 |] } |> Some
      | 11000007 -> { RegionData.id= 11000007; name= "B-R00007"; constellationIds= [| 21000055; 21000056; 21000057; 21000058; 21000059 |] } |> Some
      | _ -> None