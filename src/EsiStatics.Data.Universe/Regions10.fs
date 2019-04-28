namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions10=
    let getRegion id = 
      match id with 
      | 10000031 -> { RegionData.id= 10000031; name= "Impass"; constellationIds= [| 20000379; 20000380; 20000381; 20000382; 20000383; 20000384; 20000385 |] } |> Some
      | 11000004 -> { RegionData.id= 11000004; name= "B-R00004"; constellationIds= [| 21000021; 21000022; 21000023; 21000024; 21000025; 21000026; 21000027; 21000028; 21000029; 21000030; 21000326 |] } |> Some
      | _ -> None