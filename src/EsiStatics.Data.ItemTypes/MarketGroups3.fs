namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups3=
    let getMarketGroup id = 
      match id with 
      | 100 -> { MarketGroupData.id= 100; name= "Hybrid Charges"; parentMarketGroupId= Some(11); typeIds= [|  |]; description= "Charges with a plasma core designed for railguns and blasters" } |> Some
      | 1070 -> { MarketGroupData.id= 1070; name= "Heavy Interdiction Cruisers"; parentMarketGroupId= Some(1368); typeIds= [|  |]; description= "Cruiser-class vessels, designed to pull other vessels out of warp." } |> Some
      | 1264 -> { MarketGroupData.id= 1264; name= "Small Projectile Weapon Rigs"; parentMarketGroupId= Some(953); typeIds= [| 31657; 31693; 31669; 31705; 31681 |]; description= "Blueprints of Small Projectile Weapon Rigs." } |> Some
      | 1361 -> { MarketGroupData.id= 1361; name= "Frigates"; parentMarketGroupId= Some(4); typeIds= [|  |]; description= "Small spaceships that excel in any role involving speed and agility" } |> Some
      | 1555 -> { MarketGroupData.id= 1555; name= "Capacitor Rechargers"; parentMarketGroupId= Some(1546); typeIds= [| 1196 |]; description= "Capacitor Rechargers" } |> Some
      | 1652 -> { MarketGroupData.id= 1652; name= "Audit Log Containers"; parentMarketGroupId= Some(379); typeIds= [| 17363; 17364; 17365 |]; description= "Audit Log Containers" } |> Some
      | 1846 -> { MarketGroupData.id= 1846; name= "Bounty Reimbursement Tags"; parentMarketGroupId= Some(19); typeIds= [| 33600; 33601; 33602; 33603; 33604; 33605; 33606; 33607; 33612; 33482; 33483; 33484; 33485; 33597; 33598; 33599 |]; description= "These tags can be turned in, at empire navy stations, in return for ISK" } |> Some
      | 1943 -> { MarketGroupData.id= 1943; name= "Headwear"; parentMarketGroupId= Some(1407); typeIds= [| 53381; 34056; 34057; 34058; 34059; 34060; 34061; 34062; 34063; 34064; 34065; 34066; 34067; 34068; 34069; 34070; 34071; 34072; 34073; 34074; 34076; 34077; 34078; 54304; 55003; 54948; 54949; 54310; 45739; 45740; 44125; 53384; 54322; 52201; 54327; 55754; 47477; 55755; 55751; 55002; 55753; 42698; 42699; 55010; 55758; 55757; 55011; 42708; 42709; 42710; 47191; 42712; 47193; 44122; 42715; 42717; 42718; 42721; 42722; 42723; 42726; 42729; 42730; 42732; 42733; 42734; 42736; 42738; 42739; 42740; 42741; 47478; 42743; 42744; 42745; 50132; 52202; 50133 |]; description= "" } |> Some
      | 2040 -> { MarketGroupData.id= 2040; name= "Gallente"; parentMarketGroupId= Some(2037); typeIds= [| 46402; 55628; 44908; 45890; 36399; 42164; 52725; 37562; 46940 |]; description= "" } |> Some
      | 2137 -> { MarketGroupData.id= 2137; name= "Amarr"; parentMarketGroupId= Some(2136); typeIds= [| 40320; 45766; 43495; 53608; 42759; 42557; 55353; 46781 |]; description= "" } |> Some
      | 2234 -> { MarketGroupData.id= 2234; name= "Ballistic Control Systems"; parentMarketGroupId= Some(2227); typeIds= [| 47342; 35959 |]; description= "" } |> Some
      | 2331 -> { MarketGroupData.id= 2331; name= "ORE"; parentMarketGroupId= Some(2330); typeIds= [| 46993; 43675 |]; description= "" } |> Some
      | 2428 -> { MarketGroupData.id= 2428; name= "Triglavian"; parentMarketGroupId= Some(2427); typeIds= [| 49712; 47270 |]; description= "Triglavian Cruisers" } |> Some
      | 2525 -> { MarketGroupData.id= 2525; name= "Triglavian"; parentMarketGroupId= Some(2524); typeIds= [| 49711 |]; description= "Triglavian Battlecruisers." } |> Some
      | 391 -> { MarketGroupData.id= 391; name= "Shuttles"; parentMarketGroupId= Some(4); typeIds= [|  |]; description= "Fast and cheap vessels for easy transport" } |> Some
      | 488 -> { MarketGroupData.id= 488; name= "Moon Harvesting Arrays"; parentMarketGroupId= Some(1285); typeIds= [| 16221 |]; description= "Deployable arrays designed to gather minerals from moons." } |> Some
      | 585 -> { MarketGroupData.id= 585; name= "Gallente"; parentMarketGroupId= Some(582); typeIds= [| 16241; 32873 |]; description= "Blueprints of Gallente destroyer designs." } |> Some
      | 779 -> { MarketGroupData.id= 779; name= "Fleet Assistance Modules"; parentMarketGroupId= Some(9); typeIds= [|  |]; description= "Modules used to assist fleet members" } |> Some
      | 973 -> { MarketGroupData.id= 973; name= "Advanced Anti-Ship Heavy Assault Missile"; parentMarketGroupId= Some(968); typeIds= [| 24488; 24490; 24486; 2679 |]; description= "Advanced anti-ship heavy assault missiles." } |> Some
      | _ -> None