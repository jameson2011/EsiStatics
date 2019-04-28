namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions86=
    let getRegion id = 
      match id with 
      | 10000010 -> { RegionData.id= 10000010; name= "Tribute"; constellationIds= [| 20000124; 20000125; 20000126; 20000127; 20000128; 20000129; 20000130; 20000131 |] } |> Some
      | _ -> None