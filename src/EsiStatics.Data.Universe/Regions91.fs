namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions91=
    let getRegion id = 
      match id with 
      | 10000015 -> { RegionData.id= 10000015; name= "Venal"; constellationIds= [| 20000184; 20000185; 20000186; 20000187; 20000188; 20000189; 20000190; 20000191; 20000192; 20000193; 20000194; 20000195; 20000196; 20000197 |] } |> Some
      | _ -> None