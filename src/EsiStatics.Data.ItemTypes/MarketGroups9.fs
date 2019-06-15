namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups9=
    let getMarketGroup id = 
      match id with 
      | 106 -> { MarketGroupData.id= 106; name= "Large"; parentMarketGroupId= Some(848); typeIds= [| 231; 232; 233; 234; 235; 236; 237; 238 |]; description= "Large hybrid shells, fired by battleship-sized guns." } |> Some
      | 1076 -> { MarketGroupData.id= 1076; name= "Amarr"; parentMarketGroupId= Some(1075); typeIds= [| 22428 |]; description= "Amarr black ops designs." } |> Some
      | 1367 -> { MarketGroupData.id= 1367; name= "Cruisers"; parentMarketGroupId= Some(4); typeIds= [|  |]; description= "Medium-sized spaceships intended for a variety of roles" } |> Some
      | 1561 -> { MarketGroupData.id= 1561; name= "Reactor Control Units"; parentMarketGroupId= Some(1546); typeIds= [| 1354 |]; description= "Reactor Control Units" } |> Some
      | 1658 -> { MarketGroupData.id= 1658; name= ""; parentMarketGroupId= Some(379); typeIds= [| 17368; 17366; 17367 |]; description= "" } |> Some
      | 1852 -> { MarketGroupData.id= 1852; name= "Simple Biochemical Reactions"; parentMarketGroupId= Some(1849); typeIds= [|  |]; description= "Biochemical processes through which raw materials are made into compounds" } |> Some
      | 1949 -> { MarketGroupData.id= 1949; name= "ORE"; parentMarketGroupId= Some(787); typeIds= [| 34329 |]; description= "Designs for ORE freighters." } |> Some
      | 2046 -> { MarketGroupData.id= 2046; name= "Interceptors"; parentMarketGroupId= Some(2042); typeIds= [|  |]; description= "" } |> Some
      | 2143 -> { MarketGroupData.id= 2143; name= "Caldari"; parentMarketGroupId= Some(2141); typeIds= [| 40322; 45830; 48173; 40595; 46838; 48728; 46107 |]; description= "" } |> Some
      | 2240 -> { MarketGroupData.id= 2240; name= "25000mm Armor Plate"; parentMarketGroupId= Some(133); typeIds= [| 41456; 41457; 41458; 40348; 40349; 40350; 40351 |]; description= "25000mm Armor Plate" } |> Some
      | 2337 -> { MarketGroupData.id= 2337; name= "Industrial Command Ships"; parentMarketGroupId= Some(2006); typeIds= [|  |]; description= "" } |> Some
      | 2434 -> { MarketGroupData.id= 2434; name= "Medium"; parentMarketGroupId= Some(2432); typeIds= [| 47273; 47916; 47917; 52238; 47919; 47918 |]; description= "Medium Entropic Disintegrators" } |> Some
      | 2531 -> { MarketGroupData.id= 2531; name= "Booster Slot 14"; parentMarketGroupId= Some(977); typeIds= [|  |]; description= "" } |> Some
      | 300 -> { MarketGroupData.id= 300; name= "Hybrid Charges"; parentMarketGroupId= Some(211); typeIds= [|  |]; description= "Hybrid charge blueprints." } |> Some
      | 353574 -> { MarketGroupData.id= 353574; name= "Nanohives"; parentMarketGroupId= Some(353563); typeIds= [|  |]; description= "" } |> Some
      | 353671 -> { MarketGroupData.id= 353671; name= "Standard"; parentMarketGroupId= Some(353653); typeIds= [|  |]; description= "" } |> Some
      | 354350 -> { MarketGroupData.id= 354350; name= "Prototype"; parentMarketGroupId= Some(353570); typeIds= [|  |]; description= "" } |> Some
      | 356581 -> { MarketGroupData.id= 356581; name= "Railgun Damage Amplifiers"; parentMarketGroupId= Some(356575); typeIds= [|  |]; description= "" } |> Some
      | 356969 -> { MarketGroupData.id= 356969; name= "Advanced"; parentMarketGroupId= Some(354488); typeIds= [|  |]; description= "" } |> Some
      | 363468 -> { MarketGroupData.id= 363468; name= "Advanced"; parentMarketGroupId= Some(354339); typeIds= [|  |]; description= "Advanced" } |> Some
      | 366281 -> { MarketGroupData.id= 366281; name= "Prototype"; parentMarketGroupId= Some(366193); typeIds= [|  |]; description= "" } |> Some
      | 366572 -> { MarketGroupData.id= 366572; name= "Advanced"; parentMarketGroupId= Some(366570); typeIds= [|  |]; description= "Advanced." } |> Some
      | 494 -> { MarketGroupData.id= 494; name= "Mining Barges"; parentMarketGroupId= Some(1384); typeIds= [| 17480; 17476; 17478 |]; description= "Lumbering, voracious hulks, expressly created for ore accumulation." } |> Some
      | 591 -> { MarketGroupData.id= 591; name= "Gallente"; parentMarketGroupId= Some(588); typeIds= [| 4309; 16230; 24701 |]; description= "Blueprints of Gallente battlecruiser designs." } |> Some
      | 688 -> { MarketGroupData.id= 688; name= "Shield Power Relays"; parentMarketGroupId= Some(554); typeIds= [| 1419; 1422; 8335; 8337; 2331; 37820 |]; description= "Divert power from ship's core to shields, increasing shield recharge rate." } |> Some
      | 785 -> { MarketGroupData.id= 785; name= "Gallente"; parentMarketGroupId= Some(782); typeIds= [| 19725 |]; description= "Blueprints of Gallente dreadnought designs." } |> Some
      | 882 -> { MarketGroupData.id= 882; name= "Recon Ships"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of recon ship-class designs." } |> Some
      | 9 -> { MarketGroupData.id= 9; name= "Ship Equipment"; parentMarketGroupId= None; typeIds= [|  |]; description= "Equipment modules for spaceships, including many types of weapon, electronic, engineering, armor, shield and propulsion systems" } |> Some
      | 979 -> { MarketGroupData.id= 979; name= "Projectile Weapon Rigs"; parentMarketGroupId= Some(1111); typeIds= [|  |]; description= "Permanent modification of a ship's projectile weapon facilities." } |> Some
      | _ -> None