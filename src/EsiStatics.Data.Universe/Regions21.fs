namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions21=
    let getRegion id = 
      match id with 
      | 10000042 -> { RegionData.id= 10000042; name= "Metropolis"; constellationIds= [| 20000302; 20000303; 20000304; 20000305; 20000306; 20000307; 20000308; 20000309; 20000492; 20000493; 20000494; 20000495; 20000496; 20000497; 20000498; 20000499; 20000500; 20000501; 20000502; 20000503; 20000504; 20000505; 20000506 |] } |> Some
      | 11000015 -> { RegionData.id= 11000015; name= "C-R00015"; constellationIds= [| 21000144; 21000145; 21000146; 21000147; 21000148; 21000149; 21000150; 21000151; 21000152 |] } |> Some
      | _ -> None