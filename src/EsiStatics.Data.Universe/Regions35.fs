namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions35=
    let getRegion id = 
      match id with 
      | 10000056 -> { RegionData.id= 10000056; name= "Feythabolis"; constellationIds= [| 20000644; 20000645; 20000646; 20000647; 20000648; 20000649; 20000650; 20000651; 20000652; 20000653; 20000654; 20000655 |] } |> Some
      | 11000029 -> { RegionData.id= 11000029; name= "E-R00029"; constellationIds= [| 21000286; 21000287; 21000288; 21000289; 21000290; 21000291; 21000292; 21000293; 21000294; 21000295; 21000296 |] } |> Some
      | 12000002 -> { RegionData.id= 12000002; name= "ADR02"; constellationIds= [| 22000006; 22000007; 22000008; 22000009; 22000010 |] } |> Some
      | _ -> None