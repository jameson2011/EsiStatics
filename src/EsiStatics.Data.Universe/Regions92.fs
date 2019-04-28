namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions92=
    let getRegion id = 
      match id with 
      | 10000016 -> { RegionData.id= 10000016; name= "Lonetrek"; constellationIds= [| 20000198; 20000199; 20000200; 20000201; 20000202; 20000203; 20000204; 20000205; 20000206; 20000207; 20000208; 20000209; 20000210; 20000211; 20000212 |] } |> Some
      | _ -> None