namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups85=
    let getMarketGroup id = 
      match id with 
      | 1055 -> { MarketGroupData.id= 1055; name= "Large"; parentMarketGroupId= Some(538); typeIds= [| 5697; 21508; 3663; 3665; 5755; 5757; 5759 |]; description= "Hull repair system designs, intended for battleship-class vessels." } |> Some
      | 1249 -> { MarketGroupData.id= 1249; name= "Small Electronics Superiority Rigs"; parentMarketGroupId= Some(948); typeIds= [| 31299; 31335; 31251; 31287; 31347; 31263 |]; description= "Blueprints of Small Electronics Superiority Rigs." } |> Some
      | 1346 -> { MarketGroupData.id= 1346; name= "Jump Bridge"; parentMarketGroupId= Some(1841); typeIds= [| 2800 |]; description= "Blueprints of Jump Bridge." } |> Some
      | 1540 -> { MarketGroupData.id= 1540; name= "Armor Hardeners"; parentMarketGroupId= Some(214); typeIds= [| 11304; 41657; 11306; 11302; 11278 |]; description= "Blueprints for Armor Hardeners" } |> Some
      | 1734 -> { MarketGroupData.id= 1734; name= "Capital Hybrid Weapon Rigs"; parentMarketGroupId= Some(963); typeIds= [| 31584; 31554; 31524; 31560; 31530; 31566; 31536; 31506; 31572; 31542; 31512; 31578; 31548; 31518 |]; description= "Modifications that affect a capital starship's hybrid weapons." } |> Some
      | 1831 -> { MarketGroupData.id= 1831; name= "Mobile Depots"; parentMarketGroupId= Some(404); typeIds= [| 33520; 33474; 33522 |]; description= "" } |> Some
      | 2025 -> { MarketGroupData.id= 2025; name= "Caldari"; parentMarketGroupId= Some(2023); typeIds= [| 45856; 47619; 36740; 48199; 40616; 36361; 46860; 46733; 49423; 46133; 36668; 48733; 34814 |]; description= "" } |> Some
      | 2219 -> { MarketGroupData.id= 2219; name= "Signal Amplifiers"; parentMarketGroupId= Some(2207); typeIds= [| 47348; 37532 |]; description= "" } |> Some
      | 2316 -> { MarketGroupData.id= 2316; name= "Special Shuttles"; parentMarketGroupId= Some(2315); typeIds= [| 44258; 47011; 47652; 43532; 49794; 47544; 52281; 47547; 47550; 47647 |]; description= "" } |> Some
      | 2413 -> { MarketGroupData.id= 2413; name= "Standup Support Fighters"; parentMarketGroupId= Some(2409); typeIds= [| 47136; 47137; 47133; 47131; 47132; 47037; 47134; 47135 |]; description= "" } |> Some
      | 2510 -> { MarketGroupData.id= 2510; name= "Navigation Structures"; parentMarketGroupId= Some(1338); typeIds= [| 36960; 36961; 37538 |]; description= "Blueprints of navigation structures." } |> Some
      | 279 -> { MarketGroupData.id= 279; name= "Amarr"; parentMarketGroupId= Some(207); typeIds= [| 996; 997; 24693 |]; description= "Blueprints of Amarr battleship designs." } |> Some
      | 354620 -> { MarketGroupData.id= 354620; name= "Prototype"; parentMarketGroupId= Some(354616); typeIds= [|  |]; description= "" } |> Some
      | 355590 -> { MarketGroupData.id= 355590; name= "Shield Regulators"; parentMarketGroupId= Some(353581); typeIds= [|  |]; description= "Dropsuit shield regulators." } |> Some
      | 366260 -> { MarketGroupData.id= 366260; name= "Equipment"; parentMarketGroupId= Some(365996); typeIds= [|  |]; description= "" } |> Some
      | 376 -> { MarketGroupData.id= 376; name= "Social"; parentMarketGroupId= Some(150); typeIds= [| 3361; 3893; 3894; 3895; 3355; 3356; 3357; 3358; 3359 |]; description= "Skills pertaining to efficient navigation through the social landscape" } |> Some
      | 473 -> { MarketGroupData.id= 473; name= "Minmatar"; parentMarketGroupId= Some(469); typeIds= [| 24702; 4310; 16231 |]; description= "Minmatar battlecruiser designs." } |> Some
      | 570 -> { MarketGroupData.id= 570; name= "Small"; parentMarketGroupId= Some(558); typeIds= [| 13826; 13830; 6671; 6673; 6675; 6677; 23836; 5175; 5177; 5179; 5181; 450; 451; 453; 5217; 3017; 5215; 3001; 13797; 34272; 3041; 5219; 5221; 15849; 13803; 15853; 15856; 13811; 15864; 15871; 15868; 13823 |]; description= "Small pulse lasers, suitable for frigate use." } |> Some
      | 667 -> { MarketGroupData.id= 667; name= "Capacitor Power Relays"; parentMarketGroupId= Some(655); typeIds= [| 14144; 14146; 1445; 17510; 1447; 15080; 15082; 15084; 15437; 15086; 8175; 15088; 8177; 15090; 15092; 15094; 17528; 23896; 506; 28532 |]; description= "Increase capacitor recharge rate at the expense of shield boosting capability." } |> Some
      | 764 -> { MarketGroupData.id= 764; name= "Gallente"; parentMarketGroupId= Some(761); typeIds= [| 19724 |]; description= "Gallente dreadnought designs." } |> Some
      | 85 -> { MarketGroupData.id= 85; name= ""; parentMarketGroupId= Some(8); typeIds= [| 1944; 19744 |]; description= "" } |> Some
      | 861 -> { MarketGroupData.id= 861; name= "Medium"; parentMarketGroupId= Some(849); typeIds= [| 12785; 12789 |]; description= "Medium advanced hybrid shells, fired by cruiser-sized guns." } |> Some
      | 958 -> { MarketGroupData.id= 958; name= "Drone Rigs"; parentMarketGroupId= Some(1111); typeIds= [|  |]; description= "Permanent modification of a ship's drone facilities." } |> Some
      | _ -> None