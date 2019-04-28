namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions93=
    let getRegion id = 
      match id with 
      | 10000017 -> { RegionData.id= 10000017; name= "J7HZ-F"; constellationIds= [| 20000213; 20000214; 20000215; 20000216; 20000217; 20000218; 20000219; 20000220; 20000221; 20000222; 20000223; 20000224 |] } |> Some
      | _ -> None