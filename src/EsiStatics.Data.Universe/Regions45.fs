namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions45=
    let getRegion id = 
      match id with 
      | 10000066 -> { RegionData.id= 10000066; name= "Perrigen Falls"; constellationIds= [| 20000745; 20000746; 20000747; 20000748; 20000749; 20000750; 20000751; 20000752; 20000753; 20000754; 20000755; 20000756; 20000757; 20000758; 20000759 |] } |> Some
      | _ -> None