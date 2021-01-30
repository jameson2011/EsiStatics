namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups7=
    let getMarketGroup id = 
      match id with 
      | 1074 -> { MarketGroupData.id= 1074; name= "Minmatar"; parentMarketGroupId= Some(1070); typeIds= [| 12013 |]; description= "Minmatar heavy interdiction cruiser designs." } |> Some
      | 1268 -> { MarketGroupData.id= 1268; name= "Medium Shield Rigs"; parentMarketGroupId= Some(954); typeIds= [| 31779; 31719; 31755; 31791; 31819; 31731; 31767; 31803; 31743 |]; description= "Blueprints of Medium Shield Rigs." } |> Some
      | 1365 -> { MarketGroupData.id= 1365; name= "Pirate Faction"; parentMarketGroupId= Some(1362); typeIds= [| 17924; 17926; 17928; 17930; 17932; 33816; 33468 |]; description= "Non-Empire faction frigate designs." } |> Some
      | 1559 -> { MarketGroupData.id= 1559; name= "Auxiliary Power Controls"; parentMarketGroupId= Some(1546); typeIds= [| 11564 |]; description= "Auxiliary Power Controls" } |> Some
      | 1850 -> { MarketGroupData.id= 1850; name= "Simple Reactions"; parentMarketGroupId= Some(1849); typeIds= [|  |]; description= "Chemical processes through which raw materials are made into compounds" } |> Some
      | 2044 -> { MarketGroupData.id= 2044; name= "Covert Ops"; parentMarketGroupId= Some(2042); typeIds= [|  |]; description= "" } |> Some
      | 2141 -> { MarketGroupData.id= 2141; name= "Command Destroyers"; parentMarketGroupId= Some(2036); typeIds= [|  |]; description= "" } |> Some
      | 2238 -> { MarketGroupData.id= 2238; name= "Support Fighters"; parentMarketGroupId= Some(2237); typeIds= [| 45650; 41367; 47224; 41369; 47226; 41371; 47228; 41373; 47230 |]; description= "Blueprints of support fighter designs." } |> Some
      | 2335 -> { MarketGroupData.id= 2335; name= "Industrial Command Ships"; parentMarketGroupId= Some(1382); typeIds= [|  |]; description= "" } |> Some
      | 2432 -> { MarketGroupData.id= 2432; name= "Entropic Disintegrators"; parentMarketGroupId= Some(2431); typeIds= [|  |]; description= "Entropic Disintegrators" } |> Some
      | 2529 -> { MarketGroupData.id= 2529; name= "Medium"; parentMarketGroupId= Some(2527); typeIds= [| 49770; 49771; 49772; 49773; 49774 |]; description= "Medium Mutadaptive Remote Armor Repairers" } |> Some
      | 298 -> { MarketGroupData.id= 298; name= "Large"; parentMarketGroupId= Some(287); typeIds= [| 832; 833; 829; 830; 831 |]; description= "Blueprints of large projectile turrets." } |> Some
      | 395 -> { MarketGroupData.id= 395; name= "Gallente"; parentMarketGroupId= Some(391); typeIds= [| 11129 |]; description= "Gallente shuttle designs." } |> Some
      | 492 -> { MarketGroupData.id= 492; name= "Consumer Products"; parentMarketGroupId= Some(19); typeIds= [| 3715; 3717; 11585; 17423; 17424; 14358; 11944; 42; 43; 45; 15410; 12865; 11069; 12478; 3647; 3777; 12994; 12995; 16712; 16713; 16714; 11855; 15316; 3673; 3699; 9844; 17143; 9850; 9852 |]; description= "Products in high demand with the materialistic public. Can be bought and sold for profit" } |> Some
      | 589 -> { MarketGroupData.id= 589; name= "Amarr"; parentMarketGroupId= Some(588); typeIds= [| 4305; 16234; 24697 |]; description= "Blueprints of Amarr battlecruiser designs." } |> Some
      | 686 -> { MarketGroupData.id= 686; name= "Projected ECCM"; parentMarketGroupId= Some(657); typeIds= [|  |]; description= "Boost a target ship's sensor strength for a short time." } |> Some
      | 7 -> { MarketGroupData.id= 7; name= "Standard Battleships"; parentMarketGroupId= Some(1376); typeIds= [|  |]; description= "The foundations of any respectable fighting force." } |> Some
      | 783 -> { MarketGroupData.id= 783; name= "Amarr"; parentMarketGroupId= Some(782); typeIds= [| 19721 |]; description= "Blueprints of Amarr dreadnought designs." } |> Some
      | 880 -> { MarketGroupData.id= 880; name= "Interdictors"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of interdictor-class vessels." } |> Some
      | 977 -> { MarketGroupData.id= 977; name= "Booster"; parentMarketGroupId= Some(24); typeIds= [| 56733 |]; description= "Illegal substances that give temporary effects, but with adverse side-effects as well" } |> Some
      | _ -> None