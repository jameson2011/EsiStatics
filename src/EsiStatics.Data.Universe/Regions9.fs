namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions9=
    let getRegion id = 
      match id with 
      | 10000030 -> { RegionData.id= 10000030; name= "Heimatar"; constellationIds= [| 20000367; 20000368; 20000369; 20000370; 20000371; 20000372; 20000373; 20000374; 20000375; 20000376; 20000377; 20000378 |] } |> Some
      | 11000003 -> { RegionData.id= 11000003; name= "A-R00003"; constellationIds= [| 21000015; 21000016; 21000017; 21000018; 21000019; 21000020 |] } |> Some
      | _ -> None