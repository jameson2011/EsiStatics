namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions23=
    let getRegion id = 
      match id with 
      | 10000044 -> { RegionData.id= 10000044; name= "Solitude"; constellationIds= [| 20000520; 20000521; 20000522; 20000523; 20000524; 20000525 |] } |> Some
      | 11000017 -> { RegionData.id= 11000017; name= "D-R00017"; constellationIds= [| 21000162; 21000163; 21000164; 21000165 |] } |> Some
      | _ -> None