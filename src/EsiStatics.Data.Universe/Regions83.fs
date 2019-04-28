namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions83=
    let getRegion id = 
      match id with 
      | 10000007 -> { RegionData.id= 10000007; name= "Cache"; constellationIds= [| 20000089; 20000090; 20000091; 20000092; 20000093; 20000094; 20000095 |] } |> Some
      | _ -> None