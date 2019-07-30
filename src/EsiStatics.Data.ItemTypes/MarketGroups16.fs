namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups16=
    let getMarketGroup id = 
      match id with 
      | 1083 -> { MarketGroupData.id= 1083; name= "Gallente"; parentMarketGroupId= Some(1080); typeIds= [| 28661 |]; description= "Gallente marauder designs." } |> Some
      | 113 -> { MarketGroupData.id= 113; name= "Small"; parentMarketGroupId= Some(845); typeIds= [| 178; 179; 180; 181; 182; 183; 184; 185 |]; description= "Small projectile shells, fired by frigate-sized guns." } |> Some
      | 1374 -> { MarketGroupData.id= 1374; name= ""; parentMarketGroupId= Some(4); typeIds= [|  |]; description= "" } |> Some
      | 1471 -> { MarketGroupData.id= 1471; name= "Engineering Implants"; parentMarketGroupId= Some(531); typeIds= [|  |]; description= "Engineering Implants" } |> Some
      | 1568 -> { MarketGroupData.id= 1568; name= "ECM Burst"; parentMarketGroupId= Some(1566); typeIds= [| 1210; 41395 |]; description= "ECM Burst" } |> Some
      | 1665 -> { MarketGroupData.id= 1665; name= "Thermal Resistance Plating"; parentMarketGroupId= Some(540); typeIds= [| 14592; 1292; 1294; 28559; 1296; 17557; 18724; 18726; 18728; 32809; 18730; 15176; 18764; 15178; 15172; 15685; 15174; 14023; 14920; 14025; 14922; 14027; 14924; 14926; 15695; 14928; 16337; 14930; 16339; 14932; 16341; 14934; 16343; 18777; 18787; 14057; 18797; 18766; 14588 |]; description= "Thermal Resistance Plating" } |> Some
      | 1762 -> { MarketGroupData.id= 1762; name= "Resource Processing Implants"; parentMarketGroupId= Some(531); typeIds= [|  |]; description= "Resource Processing Implants" } |> Some
      | 1859 -> { MarketGroupData.id= 1859; name= "Fullerenes"; parentMarketGroupId= Some(1032); typeIds= [| 30370; 30371; 30372; 30373; 30374; 30375; 30376; 30377; 30378 |]; description= "This rare form of gas can only be harvested in wormhole space." } |> Some
      | 1956 -> { MarketGroupData.id= 1956; name= "Amarr"; parentMarketGroupId= Some(2101); typeIds= [| 37510; 37511; 37512; 42778; 42779; 42780; 49946; 48547; 34601; 34602; 34603; 34604; 34606; 34607; 47624; 36915; 48221; 52393; 52282; 46531; 46532; 46533; 47306; 46796; 46797; 46798; 42578; 42579; 42580; 45787; 45788; 45789; 52582; 35434; 41587; 46709; 43510; 43511; 43512; 47101 |]; description= "" } |> Some
      | 2053 -> { MarketGroupData.id= 2053; name= "Gallente"; parentMarketGroupId= Some(2044); typeIds= [| 46932; 44897; 44898; 46391; 50153; 42155; 42156; 46931; 45879; 37555; 37556; 45561; 45880; 36377; 46553; 36381; 46392 |]; description= "" } |> Some
      | 210 -> { MarketGroupData.id= 210; name= "Turrets & Bays"; parentMarketGroupId= Some(209); typeIds= [|  |]; description= "Blueprints of weapons systems for capsule-fitted vessels." } |> Some
      | 2150 -> { MarketGroupData.id= 2150; name= "Minmatar"; parentMarketGroupId= Some(2146); typeIds= [| 37460 |]; description= "Minmatar Logistics Frigates" } |> Some
      | 2247 -> { MarketGroupData.id= 2247; name= "Rapid Torpedo Launchers"; parentMarketGroupId= Some(140); typeIds= [| 37288; 41224; 37292; 37293; 41223 |]; description= "" } |> Some
      | 2344 -> { MarketGroupData.id= 2344; name= "Medium Structure Combat Rigs"; parentMarketGroupId= Some(2205); typeIds= [| 37216; 37217; 37218; 37219; 37220; 37221; 37222; 37223; 37228; 37229; 37230; 37231; 37232; 37233; 37234; 37235 |]; description= "Medium Structure Combat Rigs" } |> Some
      | 2441 -> { MarketGroupData.id= 2441; name= "Warp Disruption Mutaplasmids"; parentMarketGroupId= Some(2436); typeIds= [| 47729; 47730; 47731; 47733; 47734; 47735 |]; description= "Mutaplasmids that can be used on Warp Disruption modules." } |> Some
      | 2538 -> { MarketGroupData.id= 2538; name= "Bezdnacine"; parentMarketGroupId= Some(54); typeIds= [| 52316 |]; description= "Bezdnacine" } |> Some
      | 307 -> { MarketGroupData.id= 307; name= "Small"; parentMarketGroupId= Some(300); typeIds= [| 1130; 1131; 1132; 1133; 1134; 1135; 1136; 1137 |]; description= "Blueprints of small hybrid ammunition." } |> Some
      | 353581 -> { MarketGroupData.id= 353581; name= "Shield"; parentMarketGroupId= Some(353579); typeIds= [|  |]; description= "" } |> Some
      | 354454 -> { MarketGroupData.id= 354454; name= "Damage Control Systems"; parentMarketGroupId= Some(353590); typeIds= [|  |]; description= "" } |> Some
      | 356976 -> { MarketGroupData.id= 356976; name= "Standard"; parentMarketGroupId= Some(354483); typeIds= [|  |]; description= "" } |> Some
      | 363475 -> { MarketGroupData.id= 363475; name= "Corporations"; parentMarketGroupId= Some(353633); typeIds= [|  |]; description= "Hardwired neural augmentations used to train new abilities." } |> Some
      | 364057 -> { MarketGroupData.id= 364057; name= "Advanced"; parentMarketGroupId= Some(364055); typeIds= [|  |]; description= "Advanced." } |> Some
      | 365900 -> { MarketGroupData.id= 365900; name= "Missile Launcher Ammo Expansion Units"; parentMarketGroupId= Some(365898); typeIds= [|  |]; description= "Missile Launcher Ammo Expansion Units." } |> Some
      | 365997 -> { MarketGroupData.id= 365997; name= "Imperial Guard"; parentMarketGroupId= Some(365995); typeIds= [|  |]; description= "The Amarr store contains items that require loyalty points from the Imperial Guard." } |> Some
      | 366191 -> { MarketGroupData.id= 366191; name= "Dropsuit Modules"; parentMarketGroupId= Some(365997); typeIds= [|  |]; description= "" } |> Some
      | 366288 -> { MarketGroupData.id= 366288; name= "Prototype"; parentMarketGroupId= Some(366194); typeIds= [|  |]; description= "" } |> Some
      | 404 -> { MarketGroupData.id= 404; name= "Deployable Structures"; parentMarketGroupId= Some(477); typeIds= [|  |]; description= "Various structures that can be deployed on behalf of an individual or group of capsuleers" } |> Some
      | 501 -> { MarketGroupData.id= 501; name= "Raw Moon Materials"; parentMarketGroupId= Some(1034); typeIds= [| 16640; 16641; 16642; 16643; 16644; 16646; 16647; 16648; 16649; 16650; 16651; 16652; 16653; 16633; 16634; 16635; 16636; 16637; 16638; 16639 |]; description= "Pure elements and other raw materials from nature." } |> Some
      | 598 -> { MarketGroupData.id= 598; name= "Extra Large"; parentMarketGroupId= Some(300); typeIds= [| 17649; 17651; 17653; 17655; 17657; 17659; 17661; 17663 |]; description= "Blueprints of capital-sized hybrid ammunition." } |> Some
      | 695 -> { MarketGroupData.id= 695; name= "Small"; parentMarketGroupId= Some(663); typeIds= [| 5089; 5091; 5093; 1190; 19073; 23852; 31950; 529; 19075; 19065; 19071; 19067; 19069; 5087 |]; description= "Frigate-sized energy transfer arrays." } |> Some
      | 792 -> { MarketGroupData.id= 792; name= "Extra Large"; parentMarketGroupId= Some(286); typeIds= [| 41088; 20449; 20451; 41089; 41132; 41133; 41134; 41135; 41143; 41144; 41146; 41148; 41085; 41086; 41087 |]; description= "Blueprints of capital-sized hybrid turrets." } |> Some
      | 889 -> { MarketGroupData.id= 889; name= "Caldari"; parentMarketGroupId= Some(879); typeIds= [| 23916; 23918 |]; description= "Blueprints of Caldari carrier and mothership designs." } |> Some
      | 986 -> { MarketGroupData.id= 986; name= "Faction Ammo"; parentMarketGroupId= Some(99); typeIds= [|  |]; description= "Enhanced ammunition designed and manufactured by the factions of New Eden" } |> Some
      | _ -> None