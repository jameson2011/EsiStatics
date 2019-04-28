namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions11=
    let getRegion id = 
      match id with 
      | 10000032 -> { RegionData.id= 10000032; name= "Sinq Laison"; constellationIds= [| 20000386; 20000387; 20000388; 20000389; 20000390; 20000391; 20000392; 20000393; 20000394; 20000395; 20000396; 20000397; 20000398; 20000399; 20000400 |] } |> Some
      | 11000005 -> { RegionData.id= 11000005; name= "B-R00005"; constellationIds= [| 21000031; 21000032; 21000033; 21000034; 21000035; 21000036; 21000037; 21000038; 21000039; 21000040 |] } |> Some
      | _ -> None