namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions31=
    let getRegion id = 
      match id with 
      | 10000052 -> { RegionData.id= 10000052; name= "Kador"; constellationIds= [| 20000596; 20000597; 20000598; 20000599; 20000600; 20000601; 20000602; 20000603; 20000604; 20000605; 20000606; 20000607; 20000608 |] } |> Some
      | 11000025 -> { RegionData.id= 11000025; name= "E-R00025"; constellationIds= [| 21000243; 21000244; 21000245; 21000246; 21000247; 21000248; 21000249; 21000250; 21000251; 21000252; 21000253; 21000254; 21000255 |] } |> Some
      | _ -> None