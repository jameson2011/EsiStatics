namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups64=
    let getMarketGroup id = 
      match id with 
      | 1034 -> { MarketGroupData.id= 1034; name= "Reaction Materials"; parentMarketGroupId= Some(533); typeIds= [|  |]; description= "The various types of raw materials harvested from the moons of New Eden." } |> Some
      | 1131 -> { MarketGroupData.id= 1131; name= "Caldari Offensive Subsystems"; parentMarketGroupId= Some(1625); typeIds= [| 45601; 45602; 45603 |]; description= "Caldari offensive subsystems." } |> Some
      | 1228 -> { MarketGroupData.id= 1228; name= "Small Hybrid Weapon Rigs"; parentMarketGroupId= Some(963); typeIds= [| 31520; 31556; 31526; 31562; 31532; 31502; 31568; 31538; 31508; 31574; 31544; 31514; 31580; 31550 |]; description= "Modifications that affect a small starship's hybrid weapons." } |> Some
      | 1616 -> { MarketGroupData.id= 1616; name= "ORE"; parentMarketGroupId= Some(5); typeIds= [| 32880; 48648 |]; description= "ORE frigate designs." } |> Some
      | 1713 -> { MarketGroupData.id= 1713; name= "Harvest Equipment"; parentMarketGroupId= Some(9); typeIds= [|  |]; description= "Modules that give or improve harvesting capabilities of spaceships" } |> Some
      | 1810 -> { MarketGroupData.id= 1810; name= "Alliance Tournament Cards"; parentMarketGroupId= Some(1660); typeIds= [|  |]; description= "Alliance Tournament Cards" } |> Some
      | 1907 -> { MarketGroupData.id= 1907; name= "R.Db"; parentMarketGroupId= Some(1872); typeIds= [| 11457; 11458; 11459; 11460; 11461; 11462; 11463; 11464; 11465; 11466; 11467; 11746 |]; description= "Databases used in Tech II research jobs." } |> Some
      | 2004 -> { MarketGroupData.id= 2004; name= "Gallente"; parentMarketGroupId= Some(2001); typeIds= [| 55595; 49799; 55596; 46386; 44174; 36367; 36368; 44177; 44178; 44179; 47503; 55597; 57181; 53209; 47631; 45875; 45871; 37552; 47522; 42147; 42148; 42149; 42150; 42151; 42152; 46387; 44891; 37547; 37548; 37549; 37550; 37551; 34736; 34737; 34738; 34739; 34740; 34741; 34742; 34743; 34744; 34745; 34746; 37055; 45876; 57060; 46388; 55586; 52706; 46384; 55598; 52707; 44889; 44890; 44175; 44892; 44893; 44894; 44176; 48226; 46563; 52708; 52709; 52710; 52711; 45872; 46385; 57107; 46383; 45560; 55585; 45874; 46717; 45873; 53375 |]; description= "" } |> Some
      | 2101 -> { MarketGroupData.id= 2101; name= "Standard Battlecruisers"; parentMarketGroupId= Some(1955); typeIds= [|  |]; description= "" } |> Some
      | 2198 -> { MarketGroupData.id= 2198; name= "Structure Guided Bombs"; parentMarketGroupId= Some(11); typeIds= [| 37849; 37850 |]; description= "" } |> Some
      | 2295 -> { MarketGroupData.id= 2295; name= "Skirmish Command Burst Charges"; parentMarketGroupId= Some(2290); typeIds= [| 42888; 42886; 42887 |]; description= "Skirmish Command Burst Charges" } |> Some
      | 2392 -> { MarketGroupData.id= 2392; name= "Minmatar"; parentMarketGroupId= Some(2309); typeIds= [| 52864; 45953; 56931; 53961; 52426; 46892; 48528; 55647 |]; description= "" } |> Some
      | 2489 -> { MarketGroupData.id= 2489; name= "Booster Slot 02"; parentMarketGroupId= Some(977); typeIds= [|  |]; description= "Booster Slot 02" } |> Some
      | 452 -> { MarketGroupData.id= 452; name= "Minmatar"; parentMarketGroupId= Some(448); typeIds= [| 12015; 11999 |]; description= "Minmatar heavy assault cruiser designs." } |> Some
      | 64 -> { MarketGroupData.id= 64; name= "Minmatar"; parentMarketGroupId= Some(5); typeIds= [| 598; 585; 586; 587; 3766; 599 |]; description= "Minmatar frigate designs." } |> Some
      | 646 -> { MarketGroupData.id= 646; name= "Gyrostabilizers"; parentMarketGroupId= Some(143); typeIds= [| 518; 519; 520; 14538; 14540; 5933; 14542; 44112; 14536; 13939; 21486; 15447; 15806 |]; description= "Systems designed to improve projectile weapon efficiency." } |> Some
      | 743 -> { MarketGroupData.id= 743; name= "Domination"; parentMarketGroupId= Some(739); typeIds= [| 17220; 17221; 17222; 17223; 17224; 17225; 17226; 17227; 17229; 17230 |]; description= "Angel Dominations identification tags." } |> Some
      | 840 -> { MarketGroupData.id= 840; name= "Light Fighters"; parentMarketGroupId= Some(2410); typeIds= [| 40555; 45671; 45669; 40358; 40359; 40360; 40361; 40554; 40552; 40556; 40557; 40558; 23055; 23057; 23059; 23061; 40553; 40559 |]; description= "Single-pilot combat vessels, deployable from Carriers and Supercarriers." } |> Some
      | 937 -> { MarketGroupData.id= 937; name= "Mining Upgrades"; parentMarketGroupId= Some(1711); typeIds= [| 22577; 49973; 22543 |]; description= "Blueprints of mining upgrades." } |> Some
      | _ -> None