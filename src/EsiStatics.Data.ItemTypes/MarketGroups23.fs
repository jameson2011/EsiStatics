namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups23=
    let getMarketGroup id = 
      match id with 
      | 1090 -> { MarketGroupData.id= 1090; name= "Amarr"; parentMarketGroupId= Some(1089); typeIds= [| 28850 |]; description= "Amarr jump freighter designs." } |> Some
      | 120 -> { MarketGroupData.id= 120; name= "Probes"; parentMarketGroupId= Some(11); typeIds= [|  |]; description= "Deployed into space for scanning or disruption purposes" } |> Some
      | 1284 -> { MarketGroupData.id= 1284; name= "Military Upgrades"; parentMarketGroupId= Some(1276); typeIds= [| 2062; 2059; 2060; 2026; 2027; 2028; 2029; 2030; 2031; 2034; 2035; 2036; 2037; 2058; 2061 |]; description= "Military upgrades to sovereignty structures." } |> Some
      | 1381 -> { MarketGroupData.id= 1381; name= "Capital Ships"; parentMarketGroupId= Some(4); typeIds= [|  |]; description= "Huge spaceships capable of dominating battlefields or industry sectors" } |> Some
      | 1478 -> { MarketGroupData.id= 1478; name= "Science Implants"; parentMarketGroupId= Some(531); typeIds= [|  |]; description= "Science Implants" } |> Some
      | 1575 -> { MarketGroupData.id= 1575; name= "ECCM"; parentMarketGroupId= Some(1566); typeIds= [|  |]; description= "ECCM" } |> Some
      | 1672 -> { MarketGroupData.id= 1672; name= "100mm Armor Plate"; parentMarketGroupId= Some(133); typeIds= [| 23783; 28778; 11341; 11343; 31896; 20345; 31898; 23791; 11293 |]; description= "100mm Armor Plate" } |> Some
      | 1769 -> { MarketGroupData.id= 1769; name= "Implant Slot 07"; parentMarketGroupId= Some(1762); typeIds= [| 20700 |]; description= "Implant Slot 07" } |> Some
      | 1866 -> { MarketGroupData.id= 1866; name= "Amarr Improvement Platforms"; parentMarketGroupId= Some(1022); typeIds= [|  |]; description= "Improvements specifically designed for Amarrian outposts." } |> Some
      | 1963 -> { MarketGroupData.id= 1963; name= "Pirate Faction"; parentMarketGroupId= Some(1961); typeIds= [| 46977; 47106; 47511; 43535; 47377; 48146; 47251; 44949; 46999; 49434; 46875; 47005; 47008; 47015; 48554; 49963; 45485; 50035; 47029; 47030; 46522; 44220; 47295; 45509; 37967; 46042; 45020; 44255; 45668; 46821; 37869; 50034; 48147; 35700; 49150 |]; description= "" } |> Some
      | 2060 -> { MarketGroupData.id= 2060; name= "Caldari"; parentMarketGroupId= Some(2046); typeIds= [| 45824; 36644; 36645; 48166; 48167; 47627; 36716; 36717; 40590; 36335; 36336; 46833; 46834; 46100; 46101; 40591; 45823 |]; description= "" } |> Some
      | 2157 -> { MarketGroupData.id= 2157; name= "Structure Modifications"; parentMarketGroupId= Some(2); typeIds= [|  |]; description= "Blueprints of structure modifications." } |> Some
      | 2254 -> { MarketGroupData.id= 2254; name= "Extra Large"; parentMarketGroupId= Some(849); typeIds= [| 41322; 41324 |]; description= "Fired by dreadnought-sized guns and stationary defense systems." } |> Some
      | 23 -> { MarketGroupData.id= 23; name= "Passengers"; parentMarketGroupId= Some(19); typeIds= [| 17767; 3810; 13267; 17796; 17765; 4358; 3719; 3721; 3723; 18029; 12110; 12049; 12243; 26902; 3806; 17791 |]; description= "Ferrying passengers can give a nice profit" } |> Some
      | 2351 -> { MarketGroupData.id= 2351; name= "Defender Launchers"; parentMarketGroupId= Some(140); typeIds= [| 44102 |]; description= "For launching defender missiles." } |> Some
      | 2448 -> { MarketGroupData.id= 2448; name= "Large Shield Mutaplasmids"; parentMarketGroupId= Some(2438); typeIds= [| 47786; 47787; 47788; 47837; 47805; 47806; 47807 |]; description= "Large Shield Mutaplasmids" } |> Some
      | 314 -> { MarketGroupData.id= 314; name= "Missiles"; parentMarketGroupId= Some(211); typeIds= [|  |]; description= "Missile blueprints." } |> Some
      | 353588 -> { MarketGroupData.id= 353588; name= "Armor"; parentMarketGroupId= Some(353580); typeIds= [|  |]; description= "" } |> Some
      | 354364 -> { MarketGroupData.id= 354364; name= "Standard"; parentMarketGroupId= Some(353571); typeIds= [|  |]; description= "" } |> Some
      | 354461 -> { MarketGroupData.id= 354461; name= "Boosts (Ground)"; parentMarketGroupId= Some(353591); typeIds= [|  |]; description= "These speed boost modules only apply to ground vehicles" } |> Some
      | 366198 -> { MarketGroupData.id= 366198; name= "Advanced"; parentMarketGroupId= Some(366174); typeIds= [|  |]; description= "" } |> Some
      | 411 -> { MarketGroupData.id= 411; name= ""; parentMarketGroupId= Some(408); typeIds= [| 11177; 11179 |]; description= "" } |> Some
      | 605 -> { MarketGroupData.id= 605; name= "Small"; parentMarketGroupId= Some(551); typeIds= [| 28742; 8521; 8427; 20625; 31922; 20627; 31924; 377; 380 |]; description= "Frigate-class shield extension systems." } |> Some
      | 702 -> { MarketGroupData.id= 702; name= "Micro"; parentMarketGroupId= Some(664); typeIds= [| 522 |]; description= "Give a small increase in capacitor energy." } |> Some
      | 799 -> { MarketGroupData.id= 799; name= "Fleet Assistance Modules"; parentMarketGroupId= Some(209); typeIds= [| 21604; 28647; 28653; 43544; 23954; 23736; 43545; 43546; 43547; 43548 |]; description= "Blueprints of Fleet Assistance Modules." } |> Some
      | 896 -> { MarketGroupData.id= 896; name= "Amarr"; parentMarketGroupId= Some(881); typeIds= [| 22449; 22475 |]; description= "Blueprints of Amarr command ship designs." } |> Some
      | 993 -> { MarketGroupData.id= 993; name= "Small"; parentMarketGroupId= Some(990); typeIds= [| 19968; 21384; 21386; 21388; 21390; 21392; 21394; 21396; 21398; 22961; 21320; 22963; 22965; 22967; 22969; 22971; 22973; 22975; 20034; 20036; 20038; 20040; 21322; 21324; 21326; 21328; 20945; 21330; 20947; 21332; 20949; 21334; 20951; 20953; 20955; 20957; 20959; 23009; 23011; 23013; 23015; 23017; 23019; 23021; 23023; 19962; 19964; 19966 |]; description= "Small faction issue hybrid shells, fired by frigate-sized guns." } |> Some
      | _ -> None