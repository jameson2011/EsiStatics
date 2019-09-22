namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups65=
    let getMarketGroup id = 
      match id with 
      | 1035 -> { MarketGroupData.id= 1035; name= "Components"; parentMarketGroupId= Some(475); typeIds= [|  |]; description= "Components are manufactured items used in various industry activities" } |> Some
      | 1132 -> { MarketGroupData.id= 1132; name= "Gallente Offensive Subsystems"; parentMarketGroupId= Some(1627); typeIds= [| 45604; 45605; 45606 |]; description= "Gallente offensive subsystems." } |> Some
      | 1229 -> { MarketGroupData.id= 1229; name= "Medium Hybrid Weapon Rigs"; parentMarketGroupId= Some(963); typeIds= [| 31552; 31522; 31558; 31528; 31564; 31534; 31504; 31570; 31540; 31510; 31576; 31546; 31516; 31582 |]; description= "Modifications that affect a medium starship's hybrid weapons." } |> Some
      | 1520 -> { MarketGroupData.id= 1520; name= "Probes"; parentMarketGroupId= Some(211); typeIds= [|  |]; description= "Probes" } |> Some
      | 1617 -> { MarketGroupData.id= 1617; name= "ORE"; parentMarketGroupId= Some(205); typeIds= [| 32881 |]; description= "Blueprints of ORE frigate designs." } |> Some
      | 1811 -> { MarketGroupData.id= 1811; name= "New Eden Open Cards"; parentMarketGroupId= Some(1660); typeIds= [|  |]; description= "New Eden Open Cards" } |> Some
      | 1908 -> { MarketGroupData.id= 1908; name= "R.A.M."; parentMarketGroupId= Some(1035); typeIds= [| 11475; 11476; 11478; 11481; 11482; 11483; 11484; 11485; 11486 |]; description= "Construction tools used in Tech II manufacturing." } |> Some
      | 2005 -> { MarketGroupData.id= 2005; name= "Minmatar"; parentMarketGroupId= Some(2001); typeIds= [| 44161; 44162; 44163; 44164; 44165; 44166; 47507; 46722; 36751; 36752; 36753; 36754; 36755; 36756; 40469; 40470; 40471; 40472; 49156; 48486; 45938; 34747; 34748; 34749; 36798; 36799; 36800; 36801; 36802; 36803; 48837; 47316; 36411; 48485; 48230; 48487; 48488; 48489; 48490; 45933; 45934; 45935; 45936; 45937; 45554; 40467; 34750; 40468; 34751 |]; description= "" } |> Some
      | 2102 -> { MarketGroupData.id= 2102; name= "Command Ships"; parentMarketGroupId= Some(2099); typeIds= [|  |]; description= "" } |> Some
      | 2199 -> { MarketGroupData.id= 2199; name= "Citadels"; parentMarketGroupId= Some(477); typeIds= [|  |]; description= "" } |> Some
      | 2393 -> { MarketGroupData.id= 2393; name= "Refineries"; parentMarketGroupId= Some(1338); typeIds= [| 36977; 36978 |]; description= "Blueprints of Refinery structures." } |> Some
      | 2490 -> { MarketGroupData.id= 2490; name= "Booster Slot 03"; parentMarketGroupId= Some(977); typeIds= [|  |]; description= "Booster Slot 03" } |> Some
      | 453 -> { MarketGroupData.id= 453; name= "Heavy Assault Cruisers"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of heavy assault-class vessels." } |> Some
      | 550 -> { MarketGroupData.id= 550; name= "Shield Resistance Amplifiers"; parentMarketGroupId= Some(554); typeIds= [|  |]; description= "Strengthen various aspects of the shields' subatomic containment fields." } |> Some
      | 647 -> { MarketGroupData.id= 647; name= "Heat Sinks"; parentMarketGroupId= Some(143); typeIds= [| 15808; 15810; 1893; 14812; 23902; 44111; 14800; 14802; 14804; 13941; 14806; 13943; 14808; 5849; 14810; 2363; 2364; 14814 |]; description= "Systems designed to improve laser weapon efficiency." } |> Some
      | 65 -> { MarketGroupData.id= 65; name= "Advanced Components"; parentMarketGroupId= Some(1035); typeIds= [|  |]; description= "Components used in the manufacture of Tech II vessels and equipment." } |> Some
      | 744 -> { MarketGroupData.id= 744; name= "Dread Guristas"; parentMarketGroupId= Some(739); typeIds= [| 17248; 17249; 17250; 17251; 17241; 17242; 17243; 17244; 17245; 17247 |]; description= "Dread Guristas identification tags." } |> Some
      | 841 -> { MarketGroupData.id= 841; name= "Electronic Warfare Drones"; parentMarketGroupId= Some(157); typeIds= [| 23713; 23715; 23729; 23721; 23723; 23725; 23727; 23536; 23473; 23506; 23731; 23510; 23512; 23705; 23707 |]; description= "Drones that affect the tracking and sensor capabilities of ships" } |> Some
      | 938 -> { MarketGroupData.id= 938; name= "Drone Upgrades"; parentMarketGroupId= Some(9); typeIds= [| 32262; 41414; 32919; 32921; 32923; 32925; 33822; 32927; 33824; 32929; 33826; 32931; 33828; 32933; 33830; 32935; 33832; 4393; 33834; 32939; 33836; 32941; 33838; 32943; 33840; 32945; 33842; 32947; 33844; 4405; 33846; 32951; 33848; 32953; 33850; 32955; 33852; 32957; 32949; 31942; 41031; 41032; 41033; 41034; 24395; 41417; 24283; 24417; 41415; 23527; 24427; 23533; 24438; 32937 |]; description= "Modules that increase drone efficiency" } |> Some
      | _ -> None