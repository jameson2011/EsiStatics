namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups8=
    let getMarketGroup id = 
      match id with 
      | 105 -> { MarketGroupData.id= 105; name= "Large"; parentMarketGroupId= Some(851); typeIds= [| 256; 257; 258; 259; 260; 261; 262; 255 |]; description= "Large frequency crystals, for use with battleship-sized lasers." } |> Some
      | 1075 -> { MarketGroupData.id= 1075; name= "Black Ops"; parentMarketGroupId= Some(1377); typeIds= [|  |]; description= "Battleship-Class vessels, designed to operate behind enemy lines." } |> Some
      | 1269 -> { MarketGroupData.id= 1269; name= "Large Shield Rigs"; parentMarketGroupId= Some(954); typeIds= [| 26081; 26083; 26085; 26087; 26089; 26091; 25907; 26077; 26079 |]; description= "Blueprints of Large Shield Rigs." } |> Some
      | 1366 -> { MarketGroupData.id= 1366; name= "Navy Faction"; parentMarketGroupId= Some(1362); typeIds= [| 17703; 33677; 37454; 37453; 37456; 17841; 17619; 17812; 37455 |]; description= "Navy faction frigate designs." } |> Some
      | 1560 -> { MarketGroupData.id= 1560; name= "Power Diagnostic Systems"; parentMarketGroupId= Some(1546); typeIds= [| 1540 |]; description= "Power Diagnostic Systems" } |> Some
      | 1657 -> { MarketGroupData.id= 1657; name= "Standard Containers"; parentMarketGroupId= Some(379); typeIds= [| 3296; 3297; 3293 |]; description= "Standard Containers" } |> Some
      | 1851 -> { MarketGroupData.id= 1851; name= "Complex Reactions"; parentMarketGroupId= Some(1849); typeIds= [|  |]; description= "Chemical processes through which compounds are combined into complex materials" } |> Some
      | 2045 -> { MarketGroupData.id= 2045; name= "Electronic Attack Frigates"; parentMarketGroupId= Some(2042); typeIds= [|  |]; description= "" } |> Some
      | 2142 -> { MarketGroupData.id= 2142; name= "Amarr"; parentMarketGroupId= Some(2141); typeIds= [| 46784; 42562; 43498; 45771; 42764; 53613; 52575; 40319 |]; description= "" } |> Some
      | 2239 -> { MarketGroupData.id= 2239; name= "Support Fighters"; parentMarketGroupId= Some(2410); typeIds= [| 40571; 45651; 40569; 40568; 40345; 40346; 40347; 40570; 37599 |]; description= "Piloted combat vessels, deployable from Carriers and Supercarriers." } |> Some
      | 2336 -> { MarketGroupData.id= 2336; name= "ORE"; parentMarketGroupId= Some(2335); typeIds= [| 42244; 28606 |]; description= "" } |> Some
      | 2433 -> { MarketGroupData.id= 2433; name= "Small"; parentMarketGroupId= Some(2432); typeIds= [| 47272; 47913; 47914; 47915; 52236; 47912 |]; description= "Small Entropic Disintegrators" } |> Some
      | 2530 -> { MarketGroupData.id= 2530; name= "Booster Slot 12"; parentMarketGroupId= Some(977); typeIds= [| 54816; 54817; 54815; 49701; 49749 |]; description= "" } |> Some
      | 299 -> { MarketGroupData.id= 299; name= "Projectile Ammo"; parentMarketGroupId= Some(211); typeIds= [|  |]; description= "Projectile ammo blueprints." } |> Some
      | 353573 -> { MarketGroupData.id= 353573; name= "Scrambler Pistols"; parentMarketGroupId= Some(364048); typeIds= [|  |]; description= "Scrambler pistols." } |> Some
      | 354543 -> { MarketGroupData.id= 354543; name= "Active Boosters"; parentMarketGroupId= Some(354534); typeIds= [|  |]; description= "" } |> Some
      | 356580 -> { MarketGroupData.id= 356580; name= "Systemic Hybrid Damage"; parentMarketGroupId= Some(356575); typeIds= [|  |]; description= "" } |> Some
      | 356968 -> { MarketGroupData.id= 356968; name= "Standard"; parentMarketGroupId= Some(354488); typeIds= [|  |]; description= "" } |> Some
      | 363467 -> { MarketGroupData.id= 363467; name= "Standard"; parentMarketGroupId= Some(354339); typeIds= [|  |]; description= "Standard" } |> Some
      | 364049 -> { MarketGroupData.id= 364049; name= "Heavy"; parentMarketGroupId= Some(353567); typeIds= [|  |]; description= "Heavy handheld weapons." } |> Some
      | 366280 -> { MarketGroupData.id= 366280; name= "Advanced"; parentMarketGroupId= Some(366193); typeIds= [|  |]; description= "" } |> Some
      | 366571 -> { MarketGroupData.id= 366571; name= "Standard"; parentMarketGroupId= Some(366570); typeIds= [|  |]; description= "Standard." } |> Some
      | 396 -> { MarketGroupData.id= 396; name= "Caldari"; parentMarketGroupId= Some(391); typeIds= [| 672 |]; description= "Caldari shuttle designs." } |> Some
      | 590 -> { MarketGroupData.id= 590; name= "Caldari"; parentMarketGroupId= Some(588); typeIds= [| 24699; 4307; 16228 |]; description= "Blueprints of Caldari battlecruiser designs." } |> Some
      | 687 -> { MarketGroupData.id= 687; name= "Shield Flux Coils"; parentMarketGroupId= Some(554); typeIds= [| 37825; 1254; 8295; 1256; 8297; 508 |]; description= "Increase shield recharge rate while lowering maximum shield capacity." } |> Some
      | 784 -> { MarketGroupData.id= 784; name= "Caldari"; parentMarketGroupId= Some(782); typeIds= [| 19727 |]; description= "Blueprints of Caldari dreadnought designs." } |> Some
      | 8 -> { MarketGroupData.id= 8; name= "Standard Industrial Ships"; parentMarketGroupId= Some(1382); typeIds= [|  |]; description= "Built for the transportation of vast amounts of cargo." } |> Some
      | 881 -> { MarketGroupData.id= 881; name= "Command Ships"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of command ship-class vessels." } |> Some
      | _ -> None