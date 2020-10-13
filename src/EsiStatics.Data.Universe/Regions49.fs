namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions49=
    let getRegion id = 
      match id with 
      | 10000070 -> { RegionData.id= 10000070; name= "Pochven"; constellationIds= [| 20000787; 20000788; 20000789 |] } |> Some
      | _ -> None