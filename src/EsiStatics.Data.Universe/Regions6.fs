namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions6=
    let getRegion id = 
      match id with 
      | 10000027 -> { RegionData.id= 10000027; name= "Etherium Reach"; constellationIds= [| 20000335; 20000336; 20000337; 20000338; 20000339; 20000340; 20000341; 20000342; 20000343; 20000344; 20000345; 20000346; 20000347; 20000348; 20000349 |] } |> Some
      | _ -> None