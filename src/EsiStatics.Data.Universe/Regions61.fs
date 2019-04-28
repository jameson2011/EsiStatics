namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions61=
    let getRegion id = 
      match id with 
      | 13000001 -> { RegionData.id= 13000001; name= "PR-01"; constellationIds= [| 23000001 |] } |> Some
      | _ -> None