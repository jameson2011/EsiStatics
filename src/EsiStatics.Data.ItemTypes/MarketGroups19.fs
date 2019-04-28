﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups19=
    let getMarketGroup id = 
      match id with 
      | 1086 -> { MarketGroupData.id= 1086; name= "Inertial Stabilizers"; parentMarketGroupId= Some(132); typeIds= [| 5533; 34481; 34483; 1401; 21498; 1403; 1405 |]; description= "Ship systems that stabilize the ship and allow for more graceful maneuvers." } |> Some
      | 116 -> { MarketGroupData.id= 116; name= "Defender"; parentMarketGroupId= Some(114); typeIds= [| 32782 |]; description= "The anti-missile missile." } |> Some
      | 1377 -> { MarketGroupData.id= 1377; name= "Advanced Battleships"; parentMarketGroupId= Some(1376); typeIds= [|  |]; description= "By focusing the design down to a single purpose, these battleships excel at their designated tasks like no other starship can." } |> Some
      | 1474 -> { MarketGroupData.id= 1474; name= "Industry Implants"; parentMarketGroupId= Some(531); typeIds= [|  |]; description= "Industry Implants" } |> Some
      | 1571 -> { MarketGroupData.id= 1571; name= "Target Painters"; parentMarketGroupId= Some(1566); typeIds= [| 12710 |]; description= "Target Painters" } |> Some
      | 1668 -> { MarketGroupData.id= 1668; name= "EM Resistance Plating"; parentMarketGroupId= Some(540); typeIds= [| 28554; 17555; 18720; 18722; 1193; 1197; 1198; 14904; 14906; 14908; 14910; 14912; 14017; 14914; 14019; 14916; 14021; 14918; 15687; 18760; 16329; 18762; 16331; 15180; 16333; 15182; 16335; 15184; 15697; 15186; 18775; 18785; 14055; 18748; 18795; 17518; 14580; 18750; 14584 |]; description= "EM Resistance Plating" } |> Some
      | 1765 -> { MarketGroupData.id= 1765; name= "Implant Slot 07"; parentMarketGroupId= Some(1761); typeIds= [| 10244; 3269; 3270; 3268; 27130; 27131 |]; description= "Implant Slot 07" } |> Some
      | 1862 -> { MarketGroupData.id= 1862; name= "Ancient Salvaged Materials"; parentMarketGroupId= Some(1861); typeIds= [| 30018; 30019; 30021; 30022; 30024; 45660; 30251; 30252; 30254; 45661; 30248; 30258; 30259; 45662; 45663; 30268; 30269; 30270; 30271 |]; description= "Despite being very old, these materials hold unimaginable technological secrets." } |> Some
      | 19 -> { MarketGroupData.id= 19; name= "Trade Goods"; parentMarketGroupId= None; typeIds= [|  |]; description= "Many unusual goods are traded by capsuleers, including various tags, chips, tokens, charters and tools that are used in special activities or have exchange value with non-capsuleers" } |> Some
      | 1959 -> { MarketGroupData.id= 1959; name= "Minmatar"; parentMarketGroupId= Some(2101); typeIds= [| 47104; 46724; 45967; 45968; 45969; 35090; 49811; 47637; 48560; 50033; 36777; 36778; 36779; 40495; 40496; 40497; 46904; 46905; 46906; 34620; 34621; 47167; 47170; 48839; 47318; 36824; 36825; 36826; 34618; 48529; 48233; 52284; 45553 |]; description= "" } |> Some
      | 2056 -> { MarketGroupData.id= 2056; name= "Caldari"; parentMarketGroupId= Some(2045); typeIds= [| 36643; 48165; 36715; 40589; 46832; 36338; 46099; 45822 |]; description= "" } |> Some
      | 2153 -> { MarketGroupData.id= 2153; name= "Stasis Grapplers"; parentMarketGroupId= Some(1566); typeIds= [| 41221 |]; description= "Stasis Grappler Blueprints" } |> Some
      | 2250 -> { MarketGroupData.id= 2250; name= "Capital"; parentMarketGroupId= Some(661); typeIds= [| 40659; 40660; 40661; 40662; 40663; 40664 |]; description= "Capital-sized energy neutralizers." } |> Some
      | 2347 -> { MarketGroupData.id= 2347; name= "Medium Structure Engineering Rigs"; parentMarketGroupId= Some(2340); typeIds= [| 43862; 43919; 43920; 43921; 37146; 37147; 37148; 37149; 37150; 37151; 37152; 37153; 37154; 37155; 37156; 37157; 37158; 37159; 37160; 37161; 37162; 37163; 45544; 45640; 43854; 43855; 43856; 43857; 43858; 43859; 43732; 43733; 43734; 43863; 43864; 43865; 43866; 43867; 43868; 43869; 43870; 43871; 43872; 43873; 43874; 43875; 43876; 43877; 43878; 43879; 43880; 43881; 43882; 43883; 43884; 43885; 43886; 43887; 43888; 43889; 43890; 43891; 43892; 43893; 43860; 43861 |]; description= "Medium Structure Engineering Rigs" } |> Some
      | 2444 -> { MarketGroupData.id= 2444; name= "Medium Armor Mutaplasmids"; parentMarketGroupId= Some(2437); typeIds= [| 47843; 47813; 47814; 47815; 47770; 47771; 47772 |]; description= "Medium Armor Mutaplasmids" } |> Some
      | 353584 -> { MarketGroupData.id= 353584; name= "Electronics"; parentMarketGroupId= Some(353579); typeIds= [|  |]; description= "" } |> Some
      | 353681 -> { MarketGroupData.id= 353681; name= "Weaponry"; parentMarketGroupId= Some(353633); typeIds= [|  |]; description= "Hardwired neural augmentations used to train new abilities." } |> Some
      | 356979 -> { MarketGroupData.id= 356979; name= "Standard"; parentMarketGroupId= Some(353613); typeIds= [|  |]; description= "" } |> Some
      | 366194 -> { MarketGroupData.id= 366194; name= "Dropsuit Modules"; parentMarketGroupId= Some(365999); typeIds= [|  |]; description= "" } |> Some
      | 407 -> { MarketGroupData.id= 407; name= "Warp Disruption Fields"; parentMarketGroupId= Some(406); typeIds= [| 12297; 12300; 12301 |]; description= "Blueprints of Warp disruption fields." } |> Some
      | 504 -> { MarketGroupData.id= 504; name= "Extra Large"; parentMarketGroupId= Some(848); typeIds= [| 17648; 17650; 17652; 17654; 17656; 17658; 17660; 17662 |]; description= "Fired by dreadnought-sized guns and stationary defense systems." } |> Some
      | 601 -> { MarketGroupData.id= 601; name= "Large"; parentMarketGroupId= Some(128); typeIds= [| 8641; 41482; 3606; 3608; 8635; 8639 |]; description= "Battleship-sized shield transport units." } |> Some
      | 698 -> { MarketGroupData.id= 698; name= "Micro"; parentMarketGroupId= Some(668); typeIds= [| 4961; 3556; 14182; 3558; 15782; 14180; 4955; 4957; 15774; 4959 |]; description= "Small capacitor boosters, for when powergrid and CPU are scarce." } |> Some
      | 892 -> { MarketGroupData.id= 892; name= "Amarr"; parentMarketGroupId= Some(880); typeIds= [| 22453 |]; description= "Blueprints of Amarr interdictor designs." } |> Some
      | 989 -> { MarketGroupData.id= 989; name= "Small"; parentMarketGroupId= Some(986); typeIds= [| 19970; 19972; 19974; 19976; 21898; 20753; 21906; 20755; 19988; 20757; 19990; 20759; 19992; 20761; 21914; 20763; 20765; 20767; 21924; 28328; 21931; 28336; 21939; 19986 |]; description= "Small faction ammunition, fired by frigate-sized guns" } |> Some
      | _ -> None