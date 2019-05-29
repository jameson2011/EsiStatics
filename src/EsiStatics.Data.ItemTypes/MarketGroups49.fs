namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups49=
    let getMarketGroup id = 
      match id with 
      | 1019 -> { MarketGroupData.id= 1019; name= "Bomb Launchers"; parentMarketGroupId= Some(210); typeIds= [| 27915 |]; description= "Blueprints of bomb launchers." } |> Some
      | 1213 -> { MarketGroupData.id= 1213; name= "Small Drone Rigs"; parentMarketGroupId= Some(958); typeIds= [| 32033; 32037; 32085; 32081; 32041; 32045; 32093; 32061; 32049; 32053; 32089; 32057; 32025; 32029; 32073; 32069 |]; description= "Modifications that affect a small starship's drones." } |> Some
      | 1310 -> { MarketGroupData.id= 1310; name= "Heavy Fighters"; parentMarketGroupId= Some(2410); typeIds= [| 45675; 2948; 32325; 45673; 40566; 40362; 40363; 40364; 40365; 40560; 40561; 40562; 40563; 32340; 40565; 32342; 40567; 32344; 40564 |]; description= "Piloted combat vessels, deployable from Carriers and Supercarriers." } |> Some
      | 1407 -> { MarketGroupData.id= 1407; name= "Accessories"; parentMarketGroupId= Some(1396); typeIds= [|  |]; description= "Apparel items that supplement an outfit by adding style and class" } |> Some
      | 1504 -> { MarketGroupData.id= 1504; name= "Implant Slot 08"; parentMarketGroupId= Some(1474); typeIds= [| 27170; 27171; 27167 |]; description= "Implant Slot 08" } |> Some
      | 1601 -> { MarketGroupData.id= 1601; name= "Orbital Strike"; parentMarketGroupId= Some(300); typeIds= [|  |]; description= "" } |> Some
      | 1698 -> { MarketGroupData.id= 1698; name= "Special Edition Battlecruisers"; parentMarketGroupId= Some(1612); typeIds= [| 3756 |]; description= "Battlecruisers which have been offered to capsuleers on occasion for limited periods." } |> Some
      | 1795 -> { MarketGroupData.id= 1795; name= "Scanning Rigs"; parentMarketGroupId= Some(943); typeIds= [|  |]; description= "Permanent modification of a ship's scanning facilities." } |> Some
      | 1989 -> { MarketGroupData.id= 1989; name= "Destroyers"; parentMarketGroupId= Some(1954); typeIds= [|  |]; description= "" } |> Some
      | 2086 -> { MarketGroupData.id= 2086; name= "Advanced Industrial Ships"; parentMarketGroupId= Some(2006); typeIds= [|  |]; description= "" } |> Some
      | 2183 -> { MarketGroupData.id= 2183; name= "Structure Anticapital Launcher"; parentMarketGroupId= Some(2178); typeIds= [| 37047 |]; description= "" } |> Some
      | 2280 -> { MarketGroupData.id= 2280; name= "Gallente"; parentMarketGroupId= Some(2277); typeIds= [| 47051; 46148; 46443; 47537; 41684; 52439; 47644 |]; description= "" } |> Some
      | 2377 -> { MarketGroupData.id= 2377; name= "Standard Dreadnoughts"; parentMarketGroupId= Some(1971); typeIds= [|  |]; description= "" } |> Some
      | 2474 -> { MarketGroupData.id= 2474; name= "Implant Slot 06"; parentMarketGroupId= Some(2473); typeIds= [|  |]; description= "Implant Slot 06" } |> Some
      | 340 -> { MarketGroupData.id= 340; name= "Missile Launchers"; parentMarketGroupId= Some(210); typeIds= [| 41184; 10630; 26759; 13321; 41226; 41227; 44103; 786; 1876; 41225; 790; 33449; 41178; 788; 41177; 20540; 32445; 41183 |]; description= "Blueprints of missile launchers." } |> Some
      | 353711 -> { MarketGroupData.id= 353711; name= "Vehicle Command"; parentMarketGroupId= Some(353710); typeIds= [|  |]; description= "Hardwired neural augmentations used to train new abilities." } |> Some
      | 354390 -> { MarketGroupData.id= 354390; name= "Prototype"; parentMarketGroupId= Some(353600); typeIds= [|  |]; description= "" } |> Some
      | 355457 -> { MarketGroupData.id= 355457; name= "Dropsuits"; parentMarketGroupId= Some(355449); typeIds= [|  |]; description= "" } |> Some
      | 366224 -> { MarketGroupData.id= 366224; name= "Prototype"; parentMarketGroupId= Some(366178); typeIds= [|  |]; description= "" } |> Some
      | 437 -> { MarketGroupData.id= 437; name= "Logistics"; parentMarketGroupId= Some(1368); typeIds= [|  |]; description= "Support ships, engineered for field assistance in large engagements." } |> Some
      | 631 -> { MarketGroupData.id= 631; name= "Caldari"; parentMarketGroupId= Some(629); typeIds= [| 12729; 12731 |]; description= "Caldari transport ship designs." } |> Some
      | 728 -> { MarketGroupData.id= 728; name= "Multi-Spectrum Sensors"; parentMarketGroupId= Some(685); typeIds= [|  |]; description= "Boost a ship's sensors across the spectrum for a short duration." } |> Some
      | 825 -> { MarketGroupData.id= 825; name= "Amarr"; parentMarketGroupId= Some(822); typeIds= [| 22448; 22474 |]; description= "Amarr command ship designs." } |> Some
      | 922 -> { MarketGroupData.id= 922; name= "Standard Rockets"; parentMarketGroupId= Some(118); typeIds= [| 2512; 266; 2516; 2514 |]; description= "Standard Rockets" } |> Some
      | _ -> None