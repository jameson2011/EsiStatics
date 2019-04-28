namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions90=
    let getRegion id = 
      match id with 
      | 10000014 -> { RegionData.id= 10000014; name= "Catch"; constellationIds= [| 20000169; 20000170; 20000171; 20000172; 20000173; 20000174; 20000175; 20000176; 20000177; 20000178; 20000179; 20000180; 20000181; 20000182; 20000183 |] } |> Some
      | _ -> None