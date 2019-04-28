namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions4=
    let getRegion id = 
      match id with 
      | 10000025 -> { RegionData.id= 10000025; name= "Immensea"; constellationIds= [| 20000310; 20000311; 20000312; 20000313; 20000314; 20000315; 20000316; 20000317; 20000318; 20000319; 20000320; 20000321 |] } |> Some
      | _ -> None