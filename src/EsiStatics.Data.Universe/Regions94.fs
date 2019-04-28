namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions94=
    let getRegion id = 
      match id with 
      | 10000018 -> { RegionData.id= 10000018; name= "The Spire"; constellationIds= [| 20000225; 20000226; 20000227; 20000228; 20000229; 20000230; 20000231; 20000232; 20000233; 20000234; 20000235 |] } |> Some
      | _ -> None