namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions27=
    let getRegion id = 
      match id with 
      | 10000048 -> { RegionData.id= 10000048; name= "Placid"; constellationIds= [| 20000553; 20000554; 20000555; 20000556; 20000557; 20000558; 20000559; 20000560; 20000561; 20000562; 20000563 |] } |> Some
      | 11000021 -> { RegionData.id= 11000021; name= "D-R00021"; constellationIds= [| 21000195; 21000196; 21000197; 21000198; 21000199; 21000200; 21000201; 21000202; 21000203; 21000204; 21000205; 21000206; 21000207; 21000208; 21000209; 21000210; 21000211; 21000212 |] } |> Some
      | _ -> None