namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups68=
    let getMarketGroup id = 
      match id with 
      | 1038 -> { MarketGroupData.id= 1038; name= "Ice Harvesters"; parentMarketGroupId= Some(1713); typeIds= [| 28752; 22229; 16278 |]; description= "Ice harvester designs." } |> Some
      | 1135 -> { MarketGroupData.id= 1135; name= "Caldari Propulsion Subsystems"; parentMarketGroupId= Some(1625); typeIds= [| 45613; 45614; 45615 |]; description= "Caldari propulsion subsystems." } |> Some
      | 1232 -> { MarketGroupData.id= 1232; name= "Medium Missile Launcher Rigs"; parentMarketGroupId= Some(964); typeIds= [| 31616; 31588; 31622; 31594; 31628; 31600; 31634; 31606; 31640; 31652; 31610; 31646 |]; description= "Modifications that affect a medium starship's missile launchers." } |> Some
      | 1426 -> { MarketGroupData.id= 1426; name= "Target Breaker"; parentMarketGroupId= Some(657); typeIds= [| 4409 |]; description= "Clears all locks on you and all your locks." } |> Some
      | 1620 -> { MarketGroupData.id= 1620; name= "Special Edition Battleships"; parentMarketGroupId= Some(1612); typeIds= [| 11936; 11938; 44996; 4005; 47466; 13202; 26840; 26842 |]; description= "Battleships which have been offered to capsuleers on occasion for limited periods." } |> Some
      | 1717 -> { MarketGroupData.id= 1717; name= "Survey Probe Launchers"; parentMarketGroupId= Some(1708); typeIds= [| 33272; 33270 |]; description= "Probes for surveying moons." } |> Some
      | 1814 -> { MarketGroupData.id= 1814; name= "Special Edition Implants"; parentMarketGroupId= Some(1659); typeIds= [| 33329 |]; description= "Special Edition Implants" } |> Some
      | 2008 -> { MarketGroupData.id= 2008; name= "Caldari"; parentMarketGroupId= Some(2085); typeIds= [| 36673; 34754; 45863; 45864; 36745; 36746; 40621; 40622; 46140; 46867; 46868; 48206; 46753; 48207; 36674; 46141; 52638 |]; description= "" } |> Some
      | 2105 -> { MarketGroupData.id= 2105; name= "Caldari"; parentMarketGroupId= Some(2102); typeIds= [| 48192; 48193; 40610; 40611; 36356; 46853; 36358; 46126; 46127; 46854; 36662; 36663; 45849; 45850; 36734; 36735 |]; description= "" } |> Some
      | 2202 -> { MarketGroupData.id= 2202; name= "Structure Equipment"; parentMarketGroupId= None; typeIds= [|  |]; description= "Modules that provide functionality to Structures" } |> Some
      | 2299 -> { MarketGroupData.id= 2299; name= "Information Command Burst Charges"; parentMarketGroupId= Some(2297); typeIds= [| 42835; 42836; 42837 |]; description= "Information Command Burst Charges" } |> Some
      | 2396 -> { MarketGroupData.id= 2396; name= "Ubiquitous Moon Ores"; parentMarketGroupId= Some(2395); typeIds= [| 46280; 46281; 46282; 46283; 46284; 46285; 46286; 46287; 45490; 45491; 45492; 45493 |]; description= "The most common forms of moon ore" } |> Some
      | 2493 -> { MarketGroupData.id= 2493; name= "Mindflood"; parentMarketGroupId= Some(2488); typeIds= [| 15464; 15465; 28680; 15463 |]; description= "Mindflood Boosters" } |> Some
      | 359 -> { MarketGroupData.id= 359; name= "Heavy Attack Drones"; parentMarketGroupId= Some(1530); typeIds= [| 2194; 2445; 1214; 2477 |]; description= "Blueprints of heavy attack drone designs." } |> Some
      | 456 -> { MarketGroupData.id= 456; name= "Gallente"; parentMarketGroupId= Some(453); typeIds= [| 12024; 12006 |]; description= "Blueprints of Gallente heavy assault cruiser designs." } |> Some
      | 553 -> { MarketGroupData.id= 553; name= "Shield Hardeners"; parentMarketGroupId= Some(554); typeIds= [|  |]; description= "Computerized systems designed to give a temporary increase in shield resistance." } |> Some
      | 747 -> { MarketGroupData.id= 747; name= "Serpentis"; parentMarketGroupId= Some(739); typeIds= [| 17216; 17217; 17218; 17219; 12537; 12538; 12539; 12540; 12541; 17215 |]; description= "Serpentis identification tags." } |> Some
      | _ -> None