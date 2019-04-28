namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions38=
    let getRegion id = 
      match id with 
      | 10000059 -> { RegionData.id= 10000059; name= "Paragon Soul"; constellationIds= [| 20000682; 20000683; 20000684; 20000685; 20000686; 20000687 |] } |> Some
      | 11000032 -> { RegionData.id= 11000032; name= "H-R00032"; constellationIds= [| 21000331; 21000332; 21000333 |] } |> Some
      | 12000005 -> { RegionData.id= 12000005; name= "ADR05"; constellationIds= [| 22000021; 22000022; 22000023; 22000024; 22000025 |] } |> Some
      | _ -> None