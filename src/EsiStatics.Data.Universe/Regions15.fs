namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions15=
    let getRegion id = 
      match id with 
      | 10000036 -> { RegionData.id= 10000036; name= "Devoid"; constellationIds= [| 20000433; 20000434; 20000435; 20000436; 20000437; 20000438; 20000439; 20000440 |] } |> Some
      | 11000009 -> { RegionData.id= 11000009; name= "C-R00009"; constellationIds= [| 21000076; 21000077; 21000078; 21000079; 21000080; 21000081; 21000082; 21000083; 21000084; 21000327 |] } |> Some
      | _ -> None