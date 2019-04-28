namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions41=
    let getRegion id = 
      match id with 
      | 10000062 -> { RegionData.id= 10000062; name= "Omist"; constellationIds= [| 20000715; 20000716; 20000717; 20000718; 20000719; 20000720 |] } |> Some
      | _ -> None