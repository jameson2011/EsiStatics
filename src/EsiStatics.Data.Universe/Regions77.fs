namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions77=
    let getRegion id = 
      match id with 
      | 10000001 -> { RegionData.id= 10000001; name= "Derelik"; constellationIds= [| 20000001; 20000002; 20000003; 20000004; 20000005; 20000006; 20000007; 20000008; 20000009; 20000010; 20000011; 20000012; 20000013; 20000014; 20000015; 20000016 |] } |> Some
      | _ -> None