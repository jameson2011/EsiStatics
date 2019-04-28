namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions20=
    let getRegion id = 
      match id with 
      | 10000041 -> { RegionData.id= 10000041; name= "Syndicate"; constellationIds= [| 20000478; 20000479; 20000480; 20000481; 20000482; 20000483; 20000484; 20000485; 20000486; 20000487; 20000488; 20000489; 20000490; 20000491 |] } |> Some
      | 11000014 -> { RegionData.id= 11000014; name= "C-R00014"; constellationIds= [| 21000129; 21000130; 21000131; 21000132; 21000133; 21000134; 21000135; 21000136; 21000137; 21000138; 21000139; 21000140; 21000141; 21000142; 21000143 |] } |> Some
      | _ -> None