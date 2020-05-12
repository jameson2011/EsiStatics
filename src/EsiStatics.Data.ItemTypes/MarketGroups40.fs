﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups40=
    let getMarketGroup id = 
      match id with 
      | 1010 -> { MarketGroupData.id= 1010; name= "System Scanning Array"; parentMarketGroupId= Some(1285); typeIds= [| 27675 |]; description= "A system-wide intelligence gathering array." } |> Some
      | 1204 -> { MarketGroupData.id= 1204; name= "Medium Armor Rigs"; parentMarketGroupId= Some(944); typeIds= [| 31056; 31074; 31012; 33895; 31048; 31024; 31000; 31066; 31036 |]; description= "Blueprints of Medium Armor Rigs." } |> Some
      | 1398 -> { MarketGroupData.id= 1398; name= "Tops"; parentMarketGroupId= Some(1397); typeIds= [| 36480; 36481; 36482; 36483; 36484; 36485; 44123; 50131; 34824; 4365; 4367; 4240; 4241; 4242; 4243; 4057; 42704; 4186; 4059; 33062; 47184; 4060; 33578; 53383; 45743; 54320; 37809; 54194; 54328; 4196; 35681; 40526; 47183; 33488; 4195; 4180; 4181; 4182; 4183; 4184; 4185; 4058; 4187; 4188; 4189; 4190; 4191; 4192; 4193; 4194; 4067; 4068; 4197; 4198; 4199; 4200; 37866; 47182; 52200; 33107; 47480; 47188; 47190 |]; description= "Clothing worn on the torso." } |> Some
      | 1495 -> { MarketGroupData.id= 1495; name= "Implant Slot 08"; parentMarketGroupId= Some(1476); typeIds= [| 24640; 27243; 27094; 13227; 27244; 3152; 3153; 3156; 3125; 3126; 3127; 24632 |]; description= "Implant Slot 08" } |> Some
      | 1592 -> { MarketGroupData.id= 1592; name= "Amarr"; parentMarketGroupId= Some(1591); typeIds= [| 17348; 17349; 17350; 17359; 17330; 17334; 17335; 17336; 17338 |]; description= "Amarr" } |> Some
      | 1689 -> { MarketGroupData.id= 1689; name= "Kinetic Resistance Amplifiers"; parentMarketGroupId= Some(550); typeIds= [| 20609; 1802; 14732; 19213; 14734; 14736; 14738; 19221; 19229; 14622; 14626; 15911; 19241; 19243; 15919; 19253; 14037; 14039; 9570; 9582; 2545; 2547 |]; description= "Kinetic Resistance Amplifiers" } |> Some
      | 1786 -> { MarketGroupData.id= 1786; name= "Small Scanning Rigs"; parentMarketGroupId= Some(1780); typeIds= [| 31201; 31238; 31207; 31244; 31213; 31310; 31220; 31316 |]; description= "Modifications that affect a small starship's scanning." } |> Some
      | 1883 -> { MarketGroupData.id= 1883; name= "Advanced Capital Components"; parentMarketGroupId= Some(1035); typeIds= [|  |]; description= "Components used in the manufacture of Tech II capital ships." } |> Some
      | 1980 -> { MarketGroupData.id= 1980; name= "Amarr"; parentMarketGroupId= Some(2377); typeIds= [| 43520; 34659; 34660; 42791; 45800; 52780; 46538; 47308; 48365; 53421; 37520; 36307; 46809; 53642; 49822; 42591 |]; description= "" } |> Some
      | 2077 -> { MarketGroupData.id= 2077; name= "Amarr"; parentMarketGroupId= Some(2067); typeIds= [| 54433; 46530; 37507; 46790; 36295; 48723; 42572; 48546; 48242; 43507; 45781; 53623; 42773 |]; description= "" } |> Some
      | 2174 -> { MarketGroupData.id= 2174; name= "Signal Amplifiers"; parentMarketGroupId= Some(2162); typeIds= [| 37541 |]; description= "" } |> Some
      | 2271 -> { MarketGroupData.id= 2271; name= "Force Auxiliaries"; parentMarketGroupId= Some(1381); typeIds= [|  |]; description= "Capital warships, able to support fleets with their logistics power." } |> Some
      | 2465 -> { MarketGroupData.id= 2465; name= "Small"; parentMarketGroupId= Some(2463); typeIds= [| 47924; 47885; 47925 |]; description= "Small Exotic Plasma Charge" } |> Some
      | 331 -> { MarketGroupData.id= 331; name= "Microwarpdrives"; parentMarketGroupId= Some(252); typeIds= [| 41313; 41256; 41257; 41258; 1067; 12053; 12055 |]; description= "Blueprints of microwarpdrives." } |> Some
      | 353605 -> { MarketGroupData.id= 353605; name= "Railgun"; parentMarketGroupId= Some(353565); typeIds= [|  |]; description= "" } |> Some
      | 354381 -> { MarketGroupData.id= 354381; name= "Advanced"; parentMarketGroupId= Some(353604); typeIds= [|  |]; description= "" } |> Some
      | 354478 -> { MarketGroupData.id= 354478; name= "Blaster"; parentMarketGroupId= Some(353565); typeIds= [|  |]; description= "" } |> Some
      | 363305 -> { MarketGroupData.id= 363305; name= "120mm Armor Plates"; parentMarketGroupId= Some(354444); typeIds= [|  |]; description= "Moderate armor plating" } |> Some
      | 363790 -> { MarketGroupData.id= 363790; name= "Flaylock Pistols"; parentMarketGroupId= Some(364048); typeIds= [|  |]; description= "Flaylock pistols." } |> Some
      | 364760 -> { MarketGroupData.id= 364760; name= "Enforcer"; parentMarketGroupId= Some(353651); typeIds= [|  |]; description= "Optimized for ranged combat, the Enforcer can bombard far away targets, but is susceptible at close-range " } |> Some
      | 365245 -> { MarketGroupData.id= 365245; name= "Ferroscale Plates"; parentMarketGroupId= Some(354423); typeIds= [|  |]; description= "Dropsuit armor plates." } |> Some
      | 366021 -> { MarketGroupData.id= 366021; name= "Faction Booster Amarr"; parentMarketGroupId= Some(354534); typeIds= [|  |]; description= "" } |> Some
      | 366215 -> { MarketGroupData.id= 366215; name= "Prototype"; parentMarketGroupId= Some(366189); typeIds= [|  |]; description= "" } |> Some
      | 369222 -> { MarketGroupData.id= 369222; name= "SKIN"; parentMarketGroupId= Some(365998); typeIds= [|  |]; description= "" } |> Some
      | 428 -> { MarketGroupData.id= 428; name= "Gallente"; parentMarketGroupId= Some(419); typeIds= [| 11378; 11173 |]; description= "Blueprints of Gallente covert ops designs." } |> Some
      | 525 -> { MarketGroupData.id= 525; name= "Gneiss"; parentMarketGroupId= Some(54); typeIds= [| 28397; 46695; 17865; 17866; 1229; 28398; 28399; 46679 |]; description= "Sub-types of gneiss ore." } |> Some
      | 622 -> { MarketGroupData.id= 622; name= "Implant Slot 05"; parentMarketGroupId= Some(532); typeIds= [| 33920; 54402; 28805; 33926; 54408; 28811; 33932; 28817; 33938; 33561; 20504; 20505; 42201; 33950; 33956; 53894; 33962; 33968; 52789; 33974; 52920; 20160; 53707; 53900; 52682; 33527; 53713; 19538; 31971; 31957; 22116; 14299; 31965; 22110; 42208; 53857; 19555; 9956; 42214; 13286; 32104; 31977; 22122; 53906; 32110; 22128; 10225; 10226; 32115; 22135; 32120; 28793; 33944; 54396; 28799 |]; description= "Implants intended for Subcervical Processing Slot 5." } |> Some
      | 719 -> { MarketGroupData.id= 719; name= "Multi Spectrum Jammers"; parentMarketGroupId= Some(677); typeIds= [| 20203; 1957; 20199; 20201; 2567; 20205; 20207; 9521; 28731; 19929; 19931 |]; description= "Targeting jammers that induce multispectral sensor disruption." } |> Some
      | 816 -> { MarketGroupData.id= 816; name= "Minmatar"; parentMarketGroupId= Some(812); typeIds= [| 23773 |]; description= "Minmatar titan designs." } |> Some
      | 913 -> { MarketGroupData.id= 913; name= "Superweapons"; parentMarketGroupId= Some(210); typeIds= [| 41451; 43659; 41445; 41446; 24551; 41448; 24553; 41450; 24555; 41447; 43661; 43663; 42889; 43665; 41449; 41532; 41452; 41438; 24549 |]; description= "Doomsday Device and other Superweapon blueprints" } |> Some
      | _ -> None