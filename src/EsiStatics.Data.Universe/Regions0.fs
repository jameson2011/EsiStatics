namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions0=
    let getRegion id = 
      match id with 
      | 10000021 -> { RegionData.id= 10000021; name= "Outer Passage"; constellationIds= [| 20000258; 20000259; 20000260; 20000261; 20000262; 20000263; 20000264; 20000265; 20000266; 20000267; 20000268; 20000269; 20000270 |] } |> Some
      | _ -> None