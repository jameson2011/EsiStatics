namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups55=
    let getMarketGroup id = 
      match id with 
      | 1122 -> { MarketGroupData.id= 1122; name= "Amarr Core Subsystems"; parentMarketGroupId= Some(1610); typeIds= [| 45624; 45622; 45623 |]; description= "Amarr core subsystems." } |> Some
      | 1219 -> { MarketGroupData.id= 1219; name= "Small Electronics Superiority Rigs"; parentMarketGroupId= Some(960); typeIds= [| 31298; 31268; 31334; 31304; 31340; 31346; 31352; 31250; 31286; 31256; 31292; 31262 |]; description= "Modifications that affect a small starship's electronic warfare capabilities." } |> Some
      | 1316 -> { MarketGroupData.id= 1316; name= "XL Cruise Missiles"; parentMarketGroupId= Some(114); typeIds= [|  |]; description= "XL cruise missile designs." } |> Some
      | 1704 -> { MarketGroupData.id= 1704; name= "Navy Faction"; parentMarketGroupId= Some(1703); typeIds= [| 33153; 33155; 33157; 33151 |]; description= "Navy faction battlecruiser designs." } |> Some
      | 1801 -> { MarketGroupData.id= 1801; name= "Small Scanning Rigs"; parentMarketGroupId= Some(1795); typeIds= [| 31202; 31311; 31214; 31239 |]; description= "Blueprints of Small Scanning Rigs." } |> Some
      | 1898 -> { MarketGroupData.id= 1898; name= "Angel Cartel"; parentMarketGroupId= Some(1897); typeIds= [| 21729; 21730; 21731; 21732; 21733; 21592; 21593; 21594; 21595; 21596 |]; description= "Materials used in the construction of specific factional equipment." } |> Some
      | 1995 -> { MarketGroupData.id= 1995; name= "Caldari"; parentMarketGroupId= Some(2035); typeIds= [| 35074; 45828; 45829; 46727; 40593; 40594; 46105; 46106; 36646; 36647; 48171; 48172; 52402; 40774; 45013; 48727; 44154; 48223; 36718; 36719; 47610; 44155 |]; description= "" } |> Some
      | 2092 -> { MarketGroupData.id= 2092; name= "Caldari"; parentMarketGroupId= Some(2381); typeIds= [| 36672; 45862; 36744; 40620; 48205; 36334; 49425; 46866; 47641; 46139; 50076 |]; description= "" } |> Some
      | 2189 -> { MarketGroupData.id= 2189; name= "Ballistic Control Systems"; parentMarketGroupId= Some(2179); typeIds= [| 37020 |]; description= "" } |> Some
      | 2286 -> { MarketGroupData.id= 2286; name= "Special Edition Capsules"; parentMarketGroupId= Some(2283); typeIds= [|  |]; description= "" } |> Some
      | 2383 -> { MarketGroupData.id= 2383; name= "Pirate Faction"; parentMarketGroupId= Some(2382); typeIds= [| 46824; 46045; 46878; 46981 |]; description= "" } |> Some
      | 2480 -> { MarketGroupData.id= 2480; name= "Triglavian Data"; parentMarketGroupId= Some(19); typeIds= [| 48768; 48769; 48770; 48771; 48772; 48774; 48775; 48777; 48778; 52408; 52409; 52410; 52411; 52412; 52413; 52190; 52191; 52192; 52195; 52196; 52197; 48121; 48764; 48765; 48767 |]; description= "Data found in Abyssal Deadspace" } |> Some
      | 355463 -> { MarketGroupData.id= 355463; name= "Weapons & Grenades"; parentMarketGroupId= Some(355462); typeIds= [|  |]; description= "" } |> Some
      | 356433 -> { MarketGroupData.id= 356433; name= "Nova Knives"; parentMarketGroupId= Some(364048); typeIds= [|  |]; description= "Nova knives." } |> Some
      | 368655 -> { MarketGroupData.id= 368655; name= "Battle Salvage"; parentMarketGroupId= Some(367771); typeIds= [|  |]; description= "" } |> Some
      | 443 -> { MarketGroupData.id= 443; name= "Amarr"; parentMarketGroupId= Some(442); typeIds= [| 11988 |]; description= "Blueprints of Amarr logistics designs." } |> Some
      | 540 -> { MarketGroupData.id= 540; name= "Resistance Plating"; parentMarketGroupId= Some(14); typeIds= [|  |]; description= "Mechanically enhanced armor plating augmentation." } |> Some
      | 637 -> { MarketGroupData.id= 637; name= "Gallente"; parentMarketGroupId= Some(634); typeIds= [| 12744; 12746 |]; description= "Blueprints of Gallente transport designs." } |> Some
      | 734 -> { MarketGroupData.id= 734; name= "Gallente Navy"; parentMarketGroupId= Some(616); typeIds= [| 15648; 15649; 15650; 15587; 15588; 15589; 15590; 15591; 15592; 15593; 15594; 28236; 16002; 15673; 15994; 15646; 15647 |]; description= "Officially sanctioned Gallente Navy insignias." } |> Some
      | 831 -> { MarketGroupData.id= 831; name= "Gallente"; parentMarketGroupId= Some(822); typeIds= [| 22442; 22466 |]; description= "Gallente command ship designs." } |> Some
      | 928 -> { MarketGroupData.id= 928; name= "Advanced Long Range Rockets"; parentMarketGroupId= Some(118); typeIds= [| 24479; 24477; 24478; 13119 |]; description= "Advanced Long Range Rockets" } |> Some
      | _ -> None