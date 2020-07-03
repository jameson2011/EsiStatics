namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups93=
    let getGroup id = 
      match id with 
      | 1063 -> { GroupData.id= 1063; name= "Extractor Control Units"; categoryId= 41; published= true; typeIds= [| 2848; 3060; 3061; 3062; 3063; 3064; 3067; 3068 |] } |> Some
      | 1160 -> { GroupData.id= 1160; name= "Survey Probe Blueprints"; categoryId= 9; published= true; typeIds= [| 32839; 32854; 32855 |] } |> Some
      | 1548 -> { GroupData.id= 1548; name= "Structure Guided Bomb"; categoryId= 8; published= true; typeIds= [| 37849; 37850; 37851 |] } |> Some
      | 1839 -> { GroupData.id= 1839; name= "Structure Engineering Rig M - Basic Capital Component ME"; categoryId= 66; published= true; typeIds= [| 43870; 43871; 45544 |] } |> Some
      | 190 -> { GroupData.id= 190; name= "Bloodline Bonus"; categoryId= 14; published= false; typeIds= [| 1601; 1602; 1603; 1604; 1605; 1606; 1607; 1608 |] } |> Some
      | 1936 -> { GroupData.id= 1936; name= "Structure Hybrid Reactor Rig M - ME"; categoryId= 66; published= true; typeIds= [| 46490; 46491 |] } |> Some
      | 287 -> { GroupData.id= 287; name= "Rogue Drone"; categoryId= 11; published= false; typeIds= [| 10649; 13323; 16693 |] } |> Some
      | 384 -> { GroupData.id= 384; name= "Light Missile"; categoryId= 8; published= true; typeIds= [| 210; 211; 212; 213; 16025; 27353; 27361; 27365; 27367; 27369; 27371; 27375; 27379; 27381; 27383; 27385; 27387; 27885; 27886; 30430; 32463; 52476 |] } |> Some
      | 4070 -> { GroupData.id= 4070; name= "Exotic Artefact"; categoryId= 2; published= true; typeIds= [|  |] } |> Some
      | 481 -> { GroupData.id= 481; name= "Scan Probe Launcher"; categoryId= 7; published= true; typeIds= [| 2083; 4258; 4260; 17901; 17938; 18639; 25771; 26173; 28756; 28758 |] } |> Some
      | 578 -> { GroupData.id= 578; name= "Asteroid Blood Raiders BattleCruiser"; categoryId= 11; published= false; typeIds= [| 23244; 23252; 23253; 23254; 23255; 23256 |] } |> Some
      | 675 -> { GroupData.id= 675; name= "Mission Caldari State Other"; categoryId= 11; published= false; typeIds= [| 2378; 29233 |] } |> Some
      | 772 -> { GroupData.id= 772; name= "Heavy Assault Missile"; categoryId= 8; published= true; typeIds= [| 20306; 20307; 20308; 21867; 27393; 27397; 27401; 27403; 27405; 27407; 27411; 27413; 27415; 27417; 27419; 27421; 27887; 27888 |] } |> Some
      | 966 -> { GroupData.id= 966; name= "Ancient Salvage"; categoryId= 4; published= true; typeIds= [| 30018; 30019; 30021; 30022; 30024; 30248; 30251; 30252; 30254; 30258; 30259; 30268; 30269; 30270; 30271; 45660; 45661; 45662; 45663 |] } |> Some
      | _ -> None