namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions82=
    let getRegion id = 
      match id with 
      | 10000006 -> { RegionData.id= 10000006; name= "Wicked Creek"; constellationIds= [| 20000077; 20000078; 20000079; 20000080; 20000081; 20000082; 20000083; 20000084; 20000085; 20000086; 20000087; 20000088 |] } |> Some
      | _ -> None