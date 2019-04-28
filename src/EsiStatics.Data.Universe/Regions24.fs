namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions24=
    let getRegion id = 
      match id with 
      | 10000045 -> { RegionData.id= 10000045; name= "Tenal"; constellationIds= [| 20000526; 20000527; 20000528; 20000529; 20000530; 20000531; 20000532; 20000533; 20000534; 20000535 |] } |> Some
      | 11000018 -> { RegionData.id= 11000018; name= "D-R00018"; constellationIds= [| 21000166; 21000167; 21000168; 21000169; 21000170; 21000171; 21000172 |] } |> Some
      | _ -> None