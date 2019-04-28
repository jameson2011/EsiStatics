namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions1=
    let getRegion id = 
      match id with 
      | 10000022 -> { RegionData.id= 10000022; name= "Stain"; constellationIds= [| 20000271; 20000272; 20000273; 20000274; 20000275; 20000276; 20000277; 20000278; 20000279; 20000280; 20000281; 20000282; 20000283; 20000284; 20000285; 20000286; 20000287; 20000288 |] } |> Some
      | _ -> None