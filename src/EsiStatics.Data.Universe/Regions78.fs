namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions78=
    let getRegion id = 
      match id with 
      | 10000002 -> { RegionData.id= 10000002; name= "The Forge"; constellationIds= [| 20000017; 20000018; 20000019; 20000020; 20000021; 20000022; 20000023; 20000024; 20000025; 20000026; 20000027; 20000028; 20000029 |] } |> Some
      | _ -> None