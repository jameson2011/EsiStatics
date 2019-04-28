namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions88=
    let getRegion id = 
      match id with 
      | 10000012 -> { RegionData.id= 10000012; name= "Curse"; constellationIds= [| 20000147; 20000148; 20000149; 20000150; 20000151; 20000152; 20000153 |] } |> Some
      | _ -> None