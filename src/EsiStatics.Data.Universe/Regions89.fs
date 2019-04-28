namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions89=
    let getRegion id = 
      match id with 
      | 10000013 -> { RegionData.id= 10000013; name= "Malpais"; constellationIds= [| 20000154; 20000155; 20000156; 20000157; 20000158; 20000159; 20000160; 20000161; 20000162; 20000163; 20000164; 20000165; 20000166; 20000167; 20000168 |] } |> Some
      | _ -> None