namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions79=
    let getRegion id = 
      match id with 
      | 10000003 -> { RegionData.id= 10000003; name= "Vale of the Silent"; constellationIds= [| 20000030; 20000031; 20000032; 20000033; 20000034; 20000035; 20000036; 20000037; 20000038; 20000039; 20000040; 20000041; 20000042; 20000043; 20000044; 20000045; 20000046 |] } |> Some
      | _ -> None