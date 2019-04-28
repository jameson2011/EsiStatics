namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions80=
    let getRegion id = 
      match id with 
      | 10000004 -> { RegionData.id= 10000004; name= "UUA-F4"; constellationIds= [| 20000047; 20000048; 20000049; 20000050; 20000051; 20000052; 20000053; 20000054; 20000055; 20000056; 20000057; 20000058; 20000059; 20000060; 20000061; 20000062 |] } |> Some
      | _ -> None