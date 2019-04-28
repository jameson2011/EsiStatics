namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups88=
    let getGroup id = 
      match id with 
      | 1155 -> { GroupData.id= 1155; name= "Target Breaker Blueprint"; categoryId= 9; published= true; typeIds= [| 4410 |] } |> Some
      | 1252 -> { GroupData.id= 1252; name= "Ghost Sites Angel Cartel Cruiser"; categoryId= 11; published= true; typeIds= [| 33491; 33492; 33493; 33494 |] } |> Some
      | 1543 -> { GroupData.id= 1543; name= "Micro Jump Field Generator Blueprint"; categoryId= 9; published= true; typeIds= [| 37621 |] } |> Some
      | 1640 -> { GroupData.id= 1640; name= "Structure Citadel Rig XL - Drone and PDB"; categoryId= 66; published= false; typeIds= [| 37270; 37271 |] } |> Some
      | 1737 -> { GroupData.id= 1737; name= "Roaming Blood Raider Battleship"; categoryId= 11; published= false; typeIds= [| 42239 |] } |> Some
      | 1834 -> { GroupData.id= 1834; name= "Structure Engineering Rig M - Advanced Large Ship ME"; categoryId= 66; published= true; typeIds= [| 43862; 43863 |] } |> Some
      | 185 -> { GroupData.id= 185; name= "Pirate Drone"; categoryId= 11; published= false; typeIds= [| 12245; 12246; 12248; 12249; 21845; 21846; 21847; 21848; 21849; 22053; 25215; 27801 |] } |> Some
      | 282 -> { GroupData.id= 282; name= "Radioactive"; categoryId= 17; published= true; typeIds= [| 3727; 3729; 17475 |] } |> Some
      | 379 -> { GroupData.id= 379; name= "Target Painter"; categoryId= 7; published= true; typeIds= [| 12709; 19806; 19808; 19810; 19812; 19814; 21540; 31944; 32414 |] } |> Some
      | 476 -> { GroupData.id= 476; name= "XL Torpedo"; categoryId= 8; published= true; typeIds= [| 17857; 17859; 17861; 17863; 29616; 29618; 29620; 29622 |] } |> Some
      | 573 -> { GroupData.id= 573; name= "Asteroid Serpentis Hauler"; categoryId= 11; published= false; typeIds= [| 13702; 13703; 13704; 13705; 13706; 13707; 13708; 13709; 13710; 13711; 13712; 13713; 24377; 24378; 24379; 24380 |] } |> Some
      | 670 -> { GroupData.id= 670; name= "Mission Amarr Empire Other"; categoryId= 11; published= false; typeIds= [| 25557; 30974 |] } |> Some
      | 767 -> { GroupData.id= 767; name= "Capacitor Power Relay"; categoryId= 7; published= true; typeIds= [| 506; 1445; 1447; 8171; 8173; 8175; 8177; 8203; 8205; 8207; 8209; 14144; 14146; 15080; 15082; 15084; 15086; 15088; 15090; 15092; 15094; 15437; 17510; 17528; 23896; 28532 |] } |> Some
      | 864 -> { GroupData.id= 864; name= "Bomb Energy"; categoryId= 8; published= true; typeIds= [| 27924; 34264 |] } |> Some
      | 88 -> { GroupData.id= 88; name= "Defender Missiles"; categoryId= 8; published= true; typeIds= [| 32782 |] } |> Some
      | 961 -> { GroupData.id= 961; name= "Deadspace Sleeper Emergent Sentinel"; categoryId= 11; published= false; typeIds= [| 30215; 30216; 30217; 41338 |] } |> Some
      | _ -> None