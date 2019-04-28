namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions32=
    let getRegion id = 
      match id with 
      | 10000053 -> { RegionData.id= 10000053; name= "Cobalt Edge"; constellationIds= [| 20000609; 20000610; 20000611; 20000612; 20000613; 20000614; 20000615; 20000616; 20000617; 20000618 |] } |> Some
      | 11000026 -> { RegionData.id= 11000026; name= "E-R00026"; constellationIds= [| 21000256; 21000257; 21000258; 21000259; 21000260; 21000261; 21000262; 21000263; 21000264 |] } |> Some
      | _ -> None