namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups24=
    let getMarketGroup id = 
      match id with 
      | 1091 -> { MarketGroupData.id= 1091; name= "Caldari"; parentMarketGroupId= Some(1089); typeIds= [| 28844 |]; description= "Caldari jump freighter designs." } |> Some
      | 1285 -> { MarketGroupData.id= 1285; name= "Starbase Structures"; parentMarketGroupId= Some(477); typeIds= [|  |]; description= "Structures used in constructing capsuleer-run starbases" } |> Some
      | 1382 -> { MarketGroupData.id= 1382; name= "Industrial Ships"; parentMarketGroupId= Some(4); typeIds= [|  |]; description= "Large transport ships that form the backbone of the economy" } |> Some
      | 1479 -> { MarketGroupData.id= 1479; name= "Shield Implants"; parentMarketGroupId= Some(531); typeIds= [|  |]; description= "Shield Implants" } |> Some
      | 1576 -> { MarketGroupData.id= 1576; name= "Remote Sensor Dampeners"; parentMarketGroupId= Some(1566); typeIds= [| 11803 |]; description= "Remote Sensor Dampeners" } |> Some
      | 1673 -> { MarketGroupData.id= 1673; name= "200mm Armor Plate"; parentMarketGroupId= Some(133); typeIds= [| 31904; 31906; 23787; 28782; 11349; 11351; 20347; 11295 |]; description= "200mm Armor Plate" } |> Some
      | 1770 -> { MarketGroupData.id= 1770; name= "Implant Slot 06"; parentMarketGroupId= Some(1763); typeIds= [| 27186; 27190; 27191 |]; description= "Implant Slot 06" } |> Some
      | 1867 -> { MarketGroupData.id= 1867; name= "Caldari Improvement Platforms"; parentMarketGroupId= Some(1022); typeIds= [|  |]; description= "Improvements specifically designed for Caldari outposts." } |> Some
      | 1964 -> { MarketGroupData.id= 1964; name= "Amarr"; parentMarketGroupId= Some(1962); typeIds= [| 53635; 53636; 47493; 47625; 37515; 37516; 37517; 55310; 55311; 56592; 56195; 55317; 57059; 49817; 49818; 53637; 42784; 42785; 42786; 34599; 34600; 52777; 46378; 46535; 36913; 53129; 56888; 34623; 34624; 34625; 34626; 34627; 34628; 46534; 45793; 47307; 45794; 57016; 46802; 45795; 46804; 48854; 42584; 42585; 42586; 55720; 45665; 45666; 45667; 34792; 54761; 52775; 48893; 52392; 46803; 41588; 53365; 46710; 44280; 43515; 43516; 43517; 47102 |]; description= "" } |> Some
      | 2061 -> { MarketGroupData.id= 2061; name= "Gallente"; parentMarketGroupId= Some(2046); typeIds= [| 55613; 45883; 44900; 44901; 46935; 52717; 42158; 42159; 57008; 55631; 46934; 52718; 37558; 37559; 46395; 45882; 36379; 36380; 46394 |]; description= "" } |> Some
      | 2158 -> { MarketGroupData.id= 2158; name= "Structure Equipment"; parentMarketGroupId= Some(2); typeIds= [|  |]; description= "Blueprints of Structure Modules." } |> Some
      | 2255 -> { MarketGroupData.id= 2255; name= "Extra Large"; parentMarketGroupId= Some(850); typeIds= [| 41328; 41326 |]; description= "Fired by dreadnought-sized guns and stationary defense systems." } |> Some
      | 24 -> { MarketGroupData.id= 24; name= "Implants & Boosters"; parentMarketGroupId= None; typeIds= [|  |]; description= "Capsuleers have several options for modifying their personal capabilities, including cybernetic implants and biochemical boosters" } |> Some
      | 2449 -> { MarketGroupData.id= 2449; name= "X-Large Shield Mutaplasmids"; parentMarketGroupId= Some(2438); typeIds= [| 47792; 47839; 47790; 47791 |]; description= "X-Large Shield Mutaplasmids" } |> Some
      | 2740 -> { MarketGroupData.id= 2740; name= "Vorton Tuning Systems"; parentMarketGroupId= Some(143); typeIds= [| 54973; 54974; 54975 |]; description= "" } |> Some
      | 315 -> { MarketGroupData.id= 315; name= "Auto-Targeting"; parentMarketGroupId= Some(314); typeIds= [| 1216; 1825; 1827; 1829; 1831; 1833; 1811; 1815; 1817; 1819; 1821; 1823 |]; description= "Blueprints of friend-or-foe missiles." } |> Some
      | 412 -> { MarketGroupData.id= 412; name= "Gallente"; parentMarketGroupId= Some(408); typeIds= [| 11201; 11203 |]; description= "Blueprints of Gallente interceptor designs." } |> Some
      | 606 -> { MarketGroupData.id= 606; name= "Medium"; parentMarketGroupId= Some(551); typeIds= [| 8517; 28746; 8433; 20629; 31926; 3831; 31928; 3829 |]; description= "Cruiser-class shield extension systems." } |> Some
      | 703 -> { MarketGroupData.id= 703; name= "Small"; parentMarketGroupId= Some(664); typeIds= [| 3488; 1185; 4787; 23801; 41212; 41213; 41214 |]; description= "Frigate-sized capacitor batteries." } |> Some
      | 800 -> { MarketGroupData.id= 800; name= "Components"; parentMarketGroupId= Some(1041); typeIds= [|  |]; description= "Blueprints for intermediary items used in the production of more advanced items." } |> Some
      | 897 -> { MarketGroupData.id= 897; name= "Caldari"; parentMarketGroupId= Some(881); typeIds= [| 22471; 22447 |]; description= "Blueprints of Caldari command ship designs." } |> Some
      | 994 -> { MarketGroupData.id= 994; name= "Faction Crystals"; parentMarketGroupId= Some(101); typeIds= [|  |]; description= "Enhanced frequenzy crystals designed and manufactured by the factions of New Eden" } |> Some
      | _ -> None