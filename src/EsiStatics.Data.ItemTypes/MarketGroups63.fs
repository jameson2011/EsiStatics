namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups63=
    let getMarketGroup id = 
      match id with 
      | 1033 -> { MarketGroupData.id= 1033; name= "Ice Products"; parentMarketGroupId= Some(533); typeIds= [| 17888; 17889; 16272; 16273; 16274; 16275; 17887 |]; description= "Ice isotopes harvested from ice asteroids." } |> Some
      | 1130 -> { MarketGroupData.id= 1130; name= "Amarr Offensive Subsystems"; parentMarketGroupId= Some(1610); typeIds= [| 45600; 45598; 45599 |]; description= "Amarr offensive subsystems." } |> Some
      | 1227 -> { MarketGroupData.id= 1227; name= "Large Energy Weapon Rigs"; parentMarketGroupId= Some(962); typeIds= [| 26384; 26390; 26378; 26380; 26386; 26382; 25968; 25970; 25972; 25974; 25976; 26388; 25978; 25980 |]; description= "Modifications that affect a large starship's energy weapons." } |> Some
      | 1518 -> { MarketGroupData.id= 1518; name= "Implant Slot 10"; parentMarketGroupId= Some(1469); typeIds= [| 27074; 21606; 13256; 32254; 3479; 3481; 3482; 19550 |]; description= "Implant Slot 10" } |> Some
      | 1712 -> { MarketGroupData.id= 1712; name= "Salvagers"; parentMarketGroupId= Some(1711); typeIds= [| 25862 |]; description= "Blueprints of salvager modules." } |> Some
      | 1809 -> { MarketGroupData.id= 1809; name= "Analyzers"; parentMarketGroupId= Some(1710); typeIds= [| 22176; 22178; 27015 |]; description= "Blueprints of analyzers." } |> Some
      | 1906 -> { MarketGroupData.id= 1906; name= "Rogue Drones"; parentMarketGroupId= Some(1897); typeIds= [| 28361; 28362; 28363; 28364; 28365; 28366; 21815 |]; description= "Salvaged bits and pieces from destroyed Rogue Drones, can be integrated with current drone technology for improved performance." } |> Some
      | 2003 -> { MarketGroupData.id= 2003; name= "Caldari"; parentMarketGroupId= Some(2001); typeIds= [| 40579; 40580; 40581; 40582; 40583; 40584; 46089; 46090; 46091; 46092; 46093; 46094; 49812; 36633; 36634; 36635; 36636; 36637; 36638; 48159; 48160; 48155; 48156; 44203; 34732; 34733; 34734; 34735; 48158; 45812; 47500; 45813; 40770; 40771; 45814; 46712; 45815; 41420; 47310; 45816; 45817; 48157; 36705; 36706; 36707; 36708; 36709; 36710; 48222; 44148; 44149; 44150; 44151; 44152; 44153 |]; description= "" } |> Some
      | 2100 -> { MarketGroupData.id= 2100; name= "Faction Battlecruisers"; parentMarketGroupId= Some(1955); typeIds= [|  |]; description= "" } |> Some
      | 2197 -> { MarketGroupData.id= 2197; name= "Structure Anticapital Missiles"; parentMarketGroupId= Some(114); typeIds= [| 37843; 37844; 37845 |]; description= "" } |> Some
      | 2294 -> { MarketGroupData.id= 2294; name= "Shield Command Burst Charges"; parentMarketGroupId= Some(2290); typeIds= [| 42883; 42884; 42885 |]; description= "Shield Command Burst Charges" } |> Some
      | 2391 -> { MarketGroupData.id= 2391; name= "Caldari"; parentMarketGroupId= Some(2309); typeIds= [| 49952; 45832; 48175; 46728; 48566; 46840; 47611; 46109 |]; description= "" } |> Some
      | 2488 -> { MarketGroupData.id= 2488; name= "Booster Slot 01"; parentMarketGroupId= Some(977); typeIds= [|  |]; description= "Booster Slot 01" } |> Some
      | 354404 -> { MarketGroupData.id= 354404; name= "Advanced"; parentMarketGroupId= Some(353575); typeIds= [|  |]; description= "" } |> Some
      | 357120 -> { MarketGroupData.id= 357120; name= "Armor Hardeners"; parentMarketGroupId= Some(357121); typeIds= [|  |]; description= "Actively increases resistance to armor damage." } |> Some
      | 364492 -> { MarketGroupData.id= 364492; name= "Standard"; parentMarketGroupId= Some(364491); typeIds= [|  |]; description= "" } |> Some
      | 451 -> { MarketGroupData.id= 451; name= "Gallente"; parentMarketGroupId= Some(448); typeIds= [| 12005; 12023 |]; description= "Gallente heavy assault cruiser designs." } |> Some
      | 645 -> { MarketGroupData.id= 645; name= "Ballistic Control Systems"; parentMarketGroupId= Some(143); typeIds= [| 14528; 14688; 14530; 15683; 14532; 14534; 15681; 28563; 16457; 21484; 14690; 13935; 13937; 12274; 22291; 46270; 47447; 47448; 14684; 49790; 14686 |]; description= "Systems designed to improve missile launcher efficiency." } |> Some
      | 742 -> { MarketGroupData.id= 742; name= "Dark Blood"; parentMarketGroupId= Some(739); typeIds= [| 17231; 17232; 17233; 17234; 17235; 17236; 17237; 17238; 17239; 17240 |]; description= "Dark Blood identification tags." } |> Some
      | 839 -> { MarketGroupData.id= 839; name= "Heavy Attack Drones"; parentMarketGroupId= Some(159); typeIds= [| 28288; 28268; 28290; 2436; 31876; 2193; 2476; 28266; 2444; 31870; 2446; 1201; 28306; 2195; 28308; 2478; 28292; 31884; 33681; 28286; 31892 |]; description= "Heavy Attack Drones" } |> Some
      | _ -> None