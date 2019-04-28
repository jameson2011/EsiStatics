namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions47=
    let getRegion id = 
      match id with 
      | 10000068 -> { RegionData.id= 10000068; name= "Verge Vendor"; constellationIds= [| 20000775; 20000776; 20000777; 20000778; 20000779; 20000780 |] } |> Some
      | _ -> None