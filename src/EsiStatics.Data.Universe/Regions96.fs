namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions96=
    let getRegion id = 
      match id with 
      | 10000020 -> { RegionData.id= 10000020; name= "Tash-Murkon"; constellationIds= [| 20000243; 20000244; 20000245; 20000246; 20000247; 20000248; 20000249; 20000250; 20000251; 20000252; 20000253; 20000254; 20000255; 20000256; 20000257 |] } |> Some
      | _ -> None