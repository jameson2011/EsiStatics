namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions16=
    let getRegion id = 
      match id with 
      | 10000037 -> { RegionData.id= 10000037; name= "Everyshore"; constellationIds= [| 20000441; 20000442; 20000443; 20000444; 20000445; 20000446; 20000447 |] } |> Some
      | 11000010 -> { RegionData.id= 11000010; name= "C-R00010"; constellationIds= [| 21000085; 21000086; 21000087; 21000088; 21000089; 21000090; 21000091; 21000092 |] } |> Some
      | _ -> None