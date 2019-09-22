namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups61=
    let getMarketGroup id = 
      match id with 
      | 1031 -> { MarketGroupData.id= 1031; name= "Raw Materials"; parentMarketGroupId= Some(533); typeIds= [|  |]; description= "The building blocks of New Eden." } |> Some
      | 1128 -> { MarketGroupData.id= 1128; name= "Minmatar Defensive Subsystems"; parentMarketGroupId= Some(1626); typeIds= [| 45595; 45596; 45597 |]; description= "Minmatar defensive subsystems." } |> Some
      | 1225 -> { MarketGroupData.id= 1225; name= "Small Energy Weapon Rigs"; parentMarketGroupId= Some(962); typeIds= [| 31424; 31490; 31460; 31430; 31496; 31466; 31436; 31472; 31442; 31478; 31448; 31418; 31484; 31454 |]; description= "Modifications that affect a small starship's energy weapons." } |> Some
      | 1322 -> { MarketGroupData.id= 1322; name= "Command Centers"; parentMarketGroupId= Some(1320); typeIds= [| 2533; 2534; 2254; 2549; 2550; 2551; 2524; 2525 |]; description= "A Command Center is required to extract resources from a planet" } |> Some
      | 1516 -> { MarketGroupData.id= 1516; name= "Implant Slot 08"; parentMarketGroupId= Some(1469); typeIds= [| 27072; 13257; 3471; 3474; 3475; 19549 |]; description= "Implant Slot 08" } |> Some
      | 158 -> { MarketGroupData.id= 158; name= "Mining Drones"; parentMarketGroupId= Some(157); typeIds= [| 43681; 10246; 41030; 10250; 3218; 43694; 1202; 43699; 43700; 43701 |]; description= "Drones capable of mining asteroids for raw materials" } |> Some
      | 1710 -> { MarketGroupData.id= 1710; name= "Scanning Equipment"; parentMarketGroupId= Some(209); typeIds= [|  |]; description= "Scanning equipment" } |> Some
      | 1807 -> { MarketGroupData.id= 1807; name= "Large Targeting Rigs"; parentMarketGroupId= Some(1796); typeIds= [| 26101; 26103 |]; description= "Blueprints of Large Targeting Rigs." } |> Some
      | 1904 -> { MarketGroupData.id= 1904; name= "Yan Jung"; parentMarketGroupId= Some(1897); typeIds= [| 23168; 23169; 23138; 23139; 23140; 23141; 23142; 23170; 23172; 23171; 23128; 23129; 23130; 23131; 23132 |]; description= "Artifacts of the Yan Jung civilization." } |> Some
      | 2001 -> { MarketGroupData.id= 2001; name= "Standard Frigates"; parentMarketGroupId= Some(1998); typeIds= [|  |]; description= "" } |> Some
      | 2098 -> { MarketGroupData.id= 2098; name= "Minmatar"; parentMarketGroupId= Some(2094); typeIds= [| 40515; 45990; 36454; 36844; 46927; 36797 |]; description= "" } |> Some
      | 2292 -> { MarketGroupData.id= 2292; name= "Information Command Burst Charges"; parentMarketGroupId= Some(2290); typeIds= [| 42877; 42878; 42879 |]; description= "Information Command Burst Charges" } |> Some
      | 2389 -> { MarketGroupData.id= 2389; name= "Gallente"; parentMarketGroupId= Some(2315); typeIds= [| 46928; 45869; 44887 |]; description= "Gallente Shuttle Skins" } |> Some
      | 2486 -> { MarketGroupData.id= 2486; name= "Triglavian"; parentMarketGroupId= Some(2484); typeIds= [| 52417; 49922; 48649; 48653; 48563; 52697; 52442; 50139; 52351 |]; description= "Triglavian Frigates" } |> Some
      | 449 -> { MarketGroupData.id= 449; name= "Amarr"; parentMarketGroupId= Some(448); typeIds= [| 12003; 12019 |]; description= "Amarr heavy assault cruiser designs." } |> Some
      | 61 -> { MarketGroupData.id= 61; name= "Caldari"; parentMarketGroupId= Some(5); typeIds= [| 582; 583; 584; 602; 603; 605 |]; description= "Caldari frigate designs." } |> Some
      | 643 -> { MarketGroupData.id= 643; name= "Cruise Launchers"; parentMarketGroupId= Some(140); typeIds= [| 16513; 16515; 14678; 13927; 13320; 13929; 16519; 17485; 14672; 22568; 14674; 14516; 14518; 20601; 14520; 14676; 14522; 19739; 16062; 16517 |]; description= "For the launching of cruise missiles.  Can also fit torpedoes." } |> Some
      | 740 -> { MarketGroupData.id= 740; name= "Angels"; parentMarketGroupId= Some(739); typeIds= [| 12528; 17190; 17192; 17194; 17196; 17199; 12304; 12529; 12530; 12531 |]; description= "Angel Cartel identification tags." } |> Some
      | 837 -> { MarketGroupData.id= 837; name= "Light Scout Drones"; parentMarketGroupId= Some(159); typeIds= [| 2464; 31872; 2466; 2486; 28262; 28264; 28280; 31888; 28278; 28302; 28304; 2488; 28274; 28276; 2454; 2456; 31864; 31880; 2203; 2205 |]; description= "Light Scout Drones" } |> Some
      | _ -> None