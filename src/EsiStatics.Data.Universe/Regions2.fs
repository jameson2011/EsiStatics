namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions2=
    let getRegion id = 
      match id with 
      | 10000023 -> { RegionData.id= 10000023; name= "Pure Blind"; constellationIds= [| 20000289; 20000290; 20000291; 20000292; 20000293; 20000294; 20000295; 20000296; 20000297; 20000298; 20000299; 20000300; 20000301 |] } |> Some
      | _ -> None