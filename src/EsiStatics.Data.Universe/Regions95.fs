namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions95=
    let getRegion id = 
      match id with 
      | 10000019 -> { RegionData.id= 10000019; name= "A821-A"; constellationIds= [| 20000236; 20000237; 20000238; 20000239; 20000240; 20000241; 20000242 |] } |> Some
      | _ -> None