namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions44=
    let getRegion id = 
      match id with 
      | 10000065 -> { RegionData.id= 10000065; name= "Kor-Azor"; constellationIds= [| 20000736; 20000737; 20000738; 20000739; 20000740; 20000741; 20000742; 20000743; 20000744 |] } |> Some
      | _ -> None