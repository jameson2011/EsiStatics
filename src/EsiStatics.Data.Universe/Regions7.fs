namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions7=
    let getRegion id = 
      match id with 
      | 10000028 -> { RegionData.id= 10000028; name= "Molden Heath"; constellationIds= [| 20000350; 20000351; 20000352; 20000353; 20000354; 20000355 |] } |> Some
      | 11000001 -> { RegionData.id= 11000001; name= "A-R00001"; constellationIds= [| 21000311; 21000312; 21000313; 21000314; 21000315; 21000316; 21000317; 21000318; 21000319; 21000320; 21000321; 21000322; 21000323; 21000325 |] } |> Some
      | _ -> None