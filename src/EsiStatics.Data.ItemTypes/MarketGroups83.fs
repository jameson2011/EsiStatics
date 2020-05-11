namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups83=
    let getMarketGroup id = 
      match id with 
      | 1053 -> { MarketGroupData.id= 1053; name= "Small"; parentMarketGroupId= Some(538); typeIds= [| 21504; 2355; 524; 5743; 5745; 5747; 5693 |]; description= "Hull repair system designs, intended for frigate-class vessels." } |> Some
      | 1344 -> { MarketGroupData.id= 1344; name= "Electronic Warfare Batteries"; parentMarketGroupId= Some(1534); typeIds= [| 2792; 2794; 2763; 2796; 2798; 2736; 2740; 2741 |]; description= "Blueprints of Electronic Warfare Batteries." } |> Some
      | 1538 -> { MarketGroupData.id= 1538; name= "Remote Hull Repairers"; parentMarketGroupId= Some(214); typeIds= [| 27905; 27931; 27933; 27935 |]; description= "Blueprints for Remote Hull Repairers" } |> Some
      | 1732 -> { MarketGroupData.id= 1732; name= "Capital Shield Rigs"; parentMarketGroupId= Some(965); typeIds= [| 31744; 31780; 31814; 31750; 31720; 31820; 31786; 31756; 31826; 31726; 31792; 31762; 31732; 31798; 31768; 31738; 31804; 31774 |]; description= "Modifications that affect a capital starship's shields." } |> Some
      | 1829 -> { MarketGroupData.id= 1829; name= "Mobile Cynosural Inhibitors"; parentMarketGroupId= Some(406); typeIds= [| 33518 |]; description= "Blueprints for Mobile Cynosural Inhibitors" } |> Some
      | 2023 -> { MarketGroupData.id= 2023; name= "Marauders"; parentMarketGroupId= Some(2022); typeIds= [|  |]; description= "" } |> Some
      | 2120 -> { MarketGroupData.id= 2120; name= "Special Edition SKINs"; parentMarketGroupId= Some(2119); typeIds= [| 45552; 46584; 46582; 36854; 43935 |]; description= "" } |> Some
      | 2314 -> { MarketGroupData.id= 2314; name= "Special Destroyers"; parentMarketGroupId= Some(2313); typeIds= [| 47648; 44259; 47012; 47653; 52420; 43531; 49797; 52279; 47545; 47548; 47551 |]; description= "" } |> Some
      | 2411 -> { MarketGroupData.id= 2411; name= "Standup Light Fighters"; parentMarketGroupId= Some(2409); typeIds= [| 47138; 47139; 47140; 47141; 47142; 47143; 47144; 47145; 47146; 47147; 47148; 47149; 47150; 47151; 47035; 47036 |]; description= "" } |> Some
      | 2508 -> { MarketGroupData.id= 2508; name= "Mass Entangler"; parentMarketGroupId= Some(214); typeIds= [| 49100 |]; description= "Blueprints for Mass Entanglers." } |> Some
      | 277 -> { MarketGroupData.id= 277; name= "Gallente"; parentMarketGroupId= Some(205); typeIds= [| 939; 940; 941; 954; 955; 956 |]; description= "Blueprints of Gallente frigate designs." } |> Some
      | 354424 -> { MarketGroupData.id= 354424; name= "Armor Repairers"; parentMarketGroupId= Some(353582); typeIds= [|  |]; description= "" } |> Some
      | 354618 -> { MarketGroupData.id= 354618; name= "Standard"; parentMarketGroupId= Some(354616); typeIds= [|  |]; description= "" } |> Some
      | 366258 -> { MarketGroupData.id= 366258; name= "Advanced"; parentMarketGroupId= Some(366179); typeIds= [|  |]; description= "" } |> Some
      | 366743 -> { MarketGroupData.id= 366743; name= "Advanced"; parentMarketGroupId= Some(366741); typeIds= [|  |]; description= "Advanced" } |> Some
      | 374 -> { MarketGroupData.id= 374; name= "Navigation"; parentMarketGroupId= Some(150); typeIds= [| 3456; 4385; 21603; 21610; 21611; 24562; 3449; 3450; 3451; 3452; 3453; 3454; 3455 |]; description= "Skills pertaining to navigating your spaceship as quickly and efficiently as possible" } |> Some
      | 471 -> { MarketGroupData.id= 471; name= "Caldari"; parentMarketGroupId= Some(469); typeIds= [| 4306; 16227; 24698 |]; description= "Caldari battlecruiser designs." } |> Some
      | 568 -> { MarketGroupData.id= 568; name= "Medium"; parentMarketGroupId= Some(557); typeIds= [| 13824; 13827; 13833; 6759; 23840; 23844; 6959; 6961; 6963; 6965; 3009; 459; 455; 457; 6859; 6861; 6863; 3025; 3285; 6865; 15867; 6757; 15846; 13799; 6761; 6763; 15852; 13805; 15855; 15861; 13819; 15870 |]; description= "Medium beam lasers, suitable for cruiser use." } |> Some
      | 665 -> { MarketGroupData.id= 665; name= "Capacitor Rechargers"; parentMarketGroupId= Some(655); typeIds= [| 21819; 421; 21817; 1195; 15788; 2032; 28530; 4435; 17526; 16599; 21816; 16601; 21818; 16603; 14140; 16605; 14142; 23813 |]; description= "Provide a boost to the capacitor's recharge rate." } |> Some
      | 762 -> { MarketGroupData.id= 762; name= "Amarr"; parentMarketGroupId= Some(761); typeIds= [| 19720 |]; description= "Amarr dreadnought designs." } |> Some
      | 83 -> { MarketGroupData.id= 83; name= "Gallente"; parentMarketGroupId= Some(8); typeIds= [| 656; 657; 650; 654; 655 |]; description= "Gallente industrial designs." } |> Some
      | 859 -> { MarketGroupData.id= 859; name= "Small"; parentMarketGroupId= Some(847); typeIds= [| 12608; 12625 |]; description= "Small ADAC ammunition, fired by frigate-sized guns." } |> Some
      | 956 -> { MarketGroupData.id= 956; name= "Armor Rigs"; parentMarketGroupId= Some(1111); typeIds= [|  |]; description= "Permanent modification of a ship's armor facilities." } |> Some
      | _ -> None