namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions43=
    let getRegion id = 
      match id with 
      | 10000064 -> { RegionData.id= 10000064; name= "Essence"; constellationIds= [| 20000727; 20000728; 20000729; 20000730; 20000731; 20000732; 20000733; 20000734; 20000735 |] } |> Some
      | _ -> None