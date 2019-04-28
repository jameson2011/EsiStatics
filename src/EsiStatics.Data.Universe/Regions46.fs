namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions46=
    let getRegion id = 
      match id with 
      | 10000067 -> { RegionData.id= 10000067; name= "Genesis"; constellationIds= [| 20000760; 20000761; 20000762; 20000763; 20000764; 20000765; 20000766; 20000767; 20000768; 20000769; 20000770; 20000771; 20000772; 20000773; 20000774 |] } |> Some
      | _ -> None