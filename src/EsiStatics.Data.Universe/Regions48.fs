namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions48=
    let getRegion id = 
      match id with 
      | 10000069 -> { RegionData.id= 10000069; name= "Black Rise"; constellationIds= [| 20000781; 20000782; 20000783; 20000784; 20000785; 20000786 |] } |> Some
      | _ -> None