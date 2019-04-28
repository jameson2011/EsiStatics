namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions34=
    let getRegion id = 
      match id with 
      | 10000055 -> { RegionData.id= 10000055; name= "Branch"; constellationIds= [| 20000630; 20000631; 20000632; 20000633; 20000634; 20000635; 20000636; 20000637; 20000638; 20000639; 20000640; 20000641; 20000642; 20000643 |] } |> Some
      | 11000028 -> { RegionData.id= 11000028; name= "E-R00028"; constellationIds= [| 21000274; 21000275; 21000276; 21000277; 21000278; 21000279; 21000280; 21000281; 21000282; 21000283; 21000284; 21000285 |] } |> Some
      | 12000001 -> { RegionData.id= 12000001; name= "ADR01"; constellationIds= [| 22000001; 22000002; 22000003; 22000004; 22000005 |] } |> Some
      | _ -> None