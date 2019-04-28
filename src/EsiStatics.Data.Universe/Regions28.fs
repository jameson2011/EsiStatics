namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions28=
    let getRegion id = 
      match id with 
      | 10000049 -> { RegionData.id= 10000049; name= "Khanid"; constellationIds= [| 20000564; 20000565; 20000566; 20000567; 20000568; 20000569; 20000570; 20000571; 20000572; 20000573; 20000574; 20000575 |] } |> Some
      | 11000022 -> { RegionData.id= 11000022; name= "D-R00022"; constellationIds= [| 21000213; 21000214; 21000215; 21000216; 21000217; 21000218; 21000219; 21000220; 21000221; 21000222; 21000223; 21000224; 21000225; 21000226 |] } |> Some
      | _ -> None