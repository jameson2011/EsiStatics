namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions87=
    let getRegion id = 
      match id with 
      | 10000011 -> { RegionData.id= 10000011; name= "Great Wildlands"; constellationIds= [| 20000132; 20000133; 20000134; 20000135; 20000136; 20000137; 20000138; 20000139; 20000140; 20000141; 20000142; 20000143; 20000144; 20000145; 20000146 |] } |> Some
      | _ -> None