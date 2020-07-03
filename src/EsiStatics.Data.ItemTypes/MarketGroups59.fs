namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups59=
    let getMarketGroup id = 
      match id with 
      | 1029 -> { MarketGroupData.id= 1029; name= "Electronic Warfare Drones"; parentMarketGroupId= Some(357); typeIds= [| 23714; 23716; 23722; 23724; 23730; 23726; 23728; 23537; 23474; 23507; 23732; 23511; 23513; 23706; 23708 |]; description= "Blueprints of electronic warfare drone designs." } |> Some
      | 1126 -> { MarketGroupData.id= 1126; name= "Amarr Defensive Subsystems"; parentMarketGroupId= Some(1610); typeIds= [| 45586; 45587; 45588 |]; description= "Amarr defensive subsystems." } |> Some
      | 1223 -> { MarketGroupData.id= 1223; name= "Medium Engineering Rigs"; parentMarketGroupId= Some(961); typeIds= [| 31360; 31234; 31396; 31366; 31402; 4395; 31372; 4399; 31408; 43896; 31378; 31414; 31384; 31228; 31390 |]; description= "Modifications that affect a medium starship's energy grid." } |> Some
      | 1320 -> { MarketGroupData.id= 1320; name= "Planetary Infrastructure"; parentMarketGroupId= None; typeIds= [|  |]; description= "Capsuleers can exploit the planetary resources of New Eden by establishing command centers on the ground and orbital infrastructure in space" } |> Some
      | 1514 -> { MarketGroupData.id= 1514; name= "Implant Slot 06"; parentMarketGroupId= Some(1469); typeIds= [| 19547; 20358; 13258; 3299; 3291; 3292; 27070 |]; description= "Implant Slot 06" } |> Some
      | 1708 -> { MarketGroupData.id= 1708; name= "Scanning Equipment"; parentMarketGroupId= Some(9); typeIds= [|  |]; description= "Modules that give or improve scanning capabilities of spaceships" } |> Some
      | 1805 -> { MarketGroupData.id= 1805; name= "Small Targeting Rigs"; parentMarketGroupId= Some(1796); typeIds= [| 31323; 31275 |]; description= "Blueprints of Small Targeting Rigs." } |> Some
      | 1902 -> { MarketGroupData.id= 1902; name= "Sleeper"; parentMarketGroupId= Some(1897); typeIds= [| 21568; 21569; 21570; 21571; 21572; 21585; 20110; 21584; 21073; 21586; 21719; 21720; 21721; 21722; 21723 |]; description= "Artifacts of the Sleeper civilization." } |> Some
      | 1999 -> { MarketGroupData.id= 1999; name= "Faction Frigates"; parentMarketGroupId= Some(1998); typeIds= [|  |]; description= "" } |> Some
      | 2096 -> { MarketGroupData.id= 2096; name= "Caldari"; parentMarketGroupId= Some(2094); typeIds= [| 46145; 36678; 36362; 45868; 36750; 55568; 40626; 48211; 53205; 46872 |]; description= "" } |> Some
      | 2193 -> { MarketGroupData.id= 2193; name= "Structure Guided Bombs"; parentMarketGroupId= Some(211); typeIds= [| 37858; 37859 |]; description= "" } |> Some
      | 2290 -> { MarketGroupData.id= 2290; name= "Command Burst Charges"; parentMarketGroupId= Some(211); typeIds= [|  |]; description= "Command Burst Charges" } |> Some
      | 2387 -> { MarketGroupData.id= 2387; name= "Amarr"; parentMarketGroupId= Some(2315); typeIds= [| 55331; 46773; 45751 |]; description= "Amarr Shuttle Skins" } |> Some
      | 2484 -> { MarketGroupData.id= 2484; name= "Precursor Frigates"; parentMarketGroupId= Some(1998); typeIds= [|  |]; description= "Precursor Frigates" } |> Some
      | 641 -> { MarketGroupData.id= 641; name= "Rapid Light Missile Launchers"; parentMarketGroupId= Some(140); typeIds= [| 13920; 22566; 8007; 17484; 20597; 1875; 1877; 8023; 8025; 8027; 16061; 13919 |]; description= "Fast-launching, cruiser-sized standard missile bays." } |> Some
      | 738 -> { MarketGroupData.id= 738; name= "Nexus Chips"; parentMarketGroupId= Some(19); typeIds= [| 17793; 17794; 17795; 17643; 17646; 17647; 17848; 33618; 33619; 33620; 17814; 17815; 17816; 17849; 17850 |]; description= "Stores artificial intelligence systems. Used when acquiring special ships from Loyalty Point stores" } |> Some
      | 835 -> { MarketGroupData.id= 835; name= "Minmatar"; parentMarketGroupId= Some(823); typeIds= [| 22456 |]; description= "Minmatar interdictor designs." } |> Some
      | 932 -> { MarketGroupData.id= 932; name= "Assembly Arrays"; parentMarketGroupId= Some(1285); typeIds= [| 29613; 33867; 24653; 24654; 24655; 24656; 24657; 24658; 24659; 13780; 30389; 24660; 16220; 24574; 24575 |]; description= "Structures which house manufacturing facilities." } |> Some
      | _ -> None