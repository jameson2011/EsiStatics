namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions40=
    let getRegion id = 
      match id with 
      | 10000061 -> { RegionData.id= 10000061; name= "Tenerifis"; constellationIds= [| 20000703; 20000704; 20000705; 20000706; 20000707; 20000708; 20000709; 20000710; 20000711; 20000712; 20000713; 20000714 |] } |> Some
      | _ -> None