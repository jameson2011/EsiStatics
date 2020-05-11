namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups50=
    let getMarketGroup id = 
      match id with 
      | 1214 -> { MarketGroupData.id= 1214; name= "Medium Drone Rigs"; parentMarketGroupId= Some(958); typeIds= [| 32087; 32071; 32035; 32039; 32083; 32043; 32047; 32063; 32095; 32051; 32055; 32091; 32059; 32075; 32027; 32031 |]; description= "Modifications that affect a medium starship's drones." } |> Some
      | 1408 -> { MarketGroupData.id= 1408; name= "Eyewear"; parentMarketGroupId= Some(1407); typeIds= [| 41575; 45745; 4037; 4038; 4039; 41576; 4009; 4042; 4043; 4046; 4048; 45736; 4050; 4052; 32853; 3958; 42905; 42906 |]; description= "Eyewear is almost exclusively used for vanity purposes given advances in modern cyberware that renders externally mounted hardware obsolete.  " } |> Some
      | 1505 -> { MarketGroupData.id= 1505; name= "Implant Slot 10"; parentMarketGroupId= Some(1475); typeIds= [| 21888; 21889; 21890; 43775; 13209; 33403; 33404; 33405; 33406; 22559 |]; description= "Implant Slot 10" } |> Some
      | 1602 -> { MarketGroupData.id= 1602; name= "Orbital Strike"; parentMarketGroupId= Some(301); typeIds= [|  |]; description= "" } |> Some
      | 1699 -> { MarketGroupData.id= 1699; name= "Special Edition Cruisers"; parentMarketGroupId= Some(1612); typeIds= [| 11011; 635; 34590 |]; description= "Cruisers which have been offered to capsuleers on occasion for limited periods." } |> Some
      | 1796 -> { MarketGroupData.id= 1796; name= "Targeting Rigs"; parentMarketGroupId= Some(943); typeIds= [|  |]; description= "Permanent modification of a ship's targeting facilities." } |> Some
      | 1990 -> { MarketGroupData.id= 1990; name= "Amarr"; parentMarketGroupId= Some(2028); typeIds= [| 49813; 47494; 47623; 42766; 42767; 42768; 42769; 44142; 44143; 36916; 46708; 42565; 42566; 42567; 42568; 47305; 45774; 45775; 45776; 45777; 48719; 48220; 34684; 43500; 43501; 43502; 43503; 44144; 44145; 41586; 34676; 34677; 34678; 34679; 34680; 34681; 34682; 34683; 37500; 37501; 37502; 37503 |]; description= "" } |> Some
      | 2087 -> { MarketGroupData.id= 2087; name= "Transport Ships"; parentMarketGroupId= Some(2086); typeIds= [|  |]; description= "" } |> Some
      | 2184 -> { MarketGroupData.id= 2184; name= "Structure Antisubcapital Launcher"; parentMarketGroupId= Some(2178); typeIds= [| 37048 |]; description= "" } |> Some
      | 2281 -> { MarketGroupData.id= 2281; name= "Minmatar"; parentMarketGroupId= Some(2277); typeIds= [| 46149; 47178; 47052; 41685; 41686; 41687; 47646 |]; description= "" } |> Some
      | 2378 -> { MarketGroupData.id= 2378; name= "Faction Dreadnoughts"; parentMarketGroupId= Some(1971); typeIds= [|  |]; description= "" } |> Some
      | 2475 -> { MarketGroupData.id= 2475; name= "Implant Slot 07"; parentMarketGroupId= Some(2473); typeIds= [| 48746; 48747 |]; description= "Implant Slot 07" } |> Some
      | 341 -> { MarketGroupData.id= 341; name= "Smartbombs"; parentMarketGroupId= Some(209); typeIds= [| 3938; 3942; 3948; 3978; 1548; 3982; 1552; 3954; 3988; 1558; 3994; 1564 |]; description= "Blueprints of smartbombs." } |> Some
      | 354488 -> { MarketGroupData.id= 354488; name= "Small"; parentMarketGroupId= Some(354478); typeIds= [|  |]; description= "" } |> Some
      | 355458 -> { MarketGroupData.id= 355458; name= "Equipment"; parentMarketGroupId= Some(355449); typeIds= [|  |]; description= "" } |> Some
      | 367486 -> { MarketGroupData.id= 367486; name= "Services "; parentMarketGroupId= Some(367570); typeIds= [|  |]; description= "" } |> Some
      | 438 -> { MarketGroupData.id= 438; name= "Amarr"; parentMarketGroupId= Some(437); typeIds= [| 11987 |]; description= "Amarr logistics vessel designs." } |> Some
      | 535 -> { MarketGroupData.id= 535; name= "Armor Hardeners"; parentMarketGroupId= Some(14); typeIds= [|  |]; description= "Electronically enhanced armor plating augmentation." } |> Some
      | 632 -> { MarketGroupData.id= 632; name= "Gallente"; parentMarketGroupId= Some(629); typeIds= [| 12745; 12743 |]; description= "Gallente transport ship designs." } |> Some
      | 729 -> { MarketGroupData.id= 729; name= "Radar Sensors"; parentMarketGroupId= Some(685); typeIds= [|  |]; description= "Boost a ship's radar sensor strength for a short duration." } |> Some
      | 826 -> { MarketGroupData.id= 826; name= "Amarr"; parentMarketGroupId= Some(823); typeIds= [| 22452 |]; description= "Amarr interdictor designs." } |> Some
      | 923 -> { MarketGroupData.id= 923; name= "Standard Torpedoes"; parentMarketGroupId= Some(387); typeIds= [| 2506; 267; 2508; 2510 |]; description= "Standard Torpedoes" } |> Some
      | _ -> None