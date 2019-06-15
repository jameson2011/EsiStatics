namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups78=
    let getMarketGroup id = 
      match id with 
      | 1048 -> { MarketGroupData.id= 1048; name= "ORE"; parentMarketGroupId= Some(1047); typeIds= [| 28352 |]; description= "ORE capital industrial ship designs." } |> Some
      | 1242 -> { MarketGroupData.id= 1242; name= "Large Astronautic Rigs"; parentMarketGroupId= Some(945); typeIds= [| 34307; 26057; 26059; 26061; 26063; 26067; 26069; 26071; 26073 |]; description= "Blueprints of Large Astronautic Rigs." } |> Some
      | 1339 -> { MarketGroupData.id= 1339; name= "Control Towers"; parentMarketGroupId= Some(1841); typeIds= [| 2784; 2785; 2774; 2775; 2776; 2777; 2778; 2779; 2780; 2781; 2782; 2783 |]; description= "Blueprints of Control Towers." } |> Some
      | 1533 -> { MarketGroupData.id= 1533; name= ""; parentMarketGroupId= Some(1530); typeIds= [| 23560; 23562; 23564; 23526 |]; description= "" } |> Some
      | 1727 -> { MarketGroupData.id= 1727; name= "Capital Missile Launcher Rigs"; parentMarketGroupId= Some(952); typeIds= [| 31649; 31591; 31625; 31603; 31637; 31613 |]; description= "Blueprints of Capital Missile Launcher Rigs." } |> Some
      | 1824 -> { MarketGroupData.id= 1824; name= "Subsystems"; parentMarketGroupId= Some(150); typeIds= [| 30532; 30537; 30538; 30539; 30540; 30544; 30545; 30546; 30547; 30548; 30549; 30550; 30551; 30552; 30553; 30554 |]; description= "Skills pertaining to the use and control of ship subsystems" } |> Some
      | 1921 -> { MarketGroupData.id= 1921; name= "Compression Array"; parentMarketGroupId= Some(1285); typeIds= [| 12239 |]; description= "Anchorable compression structures." } |> Some
      | 2018 -> { MarketGroupData.id= 2018; name= "Entosis Links"; parentMarketGroupId= Some(1708); typeIds= [| 34593; 34595; 40307; 40308; 40309; 40310 |]; description= "" } |> Some
      | 2115 -> { MarketGroupData.id= 2115; name= "Special Edition Heavy Interdiction Cruisers"; parentMarketGroupId= Some(1612); typeIds= [| 35781 |]; description= "Heavy Interdiction Cruisers which have been offered to capsuleers on occasion for limited periods." } |> Some
      | 2212 -> { MarketGroupData.id= 2212; name= "Remote Sensor Dampeners"; parentMarketGroupId= Some(2206); typeIds= [| 47368; 35941 |]; description= "" } |> Some
      | 2309 -> { MarketGroupData.id= 2309; name= "Tactical Destroyers"; parentMarketGroupId= Some(2036); typeIds= [|  |]; description= "" } |> Some
      | 2406 -> { MarketGroupData.id= 2406; name= "Special Black Ops"; parentMarketGroupId= Some(2109); typeIds= [| 48578; 47683; 48581; 47158; 47159; 47160; 47002 |]; description= "" } |> Some
      | 2503 -> { MarketGroupData.id= 2503; name= "Hardshell"; parentMarketGroupId= Some(2502); typeIds= [| 46001; 46002; 46003; 48113 |]; description= "Hardshell Boosters" } |> Some
      | 272 -> { MarketGroupData.id= 272; name= "Amarr"; parentMarketGroupId= Some(205); typeIds= [| 29249; 936; 937; 938; 944; 2162 |]; description= "Blueprints of Amarr frigate designs." } |> Some
      | 355195 -> { MarketGroupData.id= 355195; name= "Advanced"; parentMarketGroupId= Some(355193); typeIds= [|  |]; description= "" } |> Some
      | 363440 -> { MarketGroupData.id= 363440; name= "Light"; parentMarketGroupId= Some(354448); typeIds= [|  |]; description= " " } |> Some
      | 364895 -> { MarketGroupData.id= 364895; name= "Advanced"; parentMarketGroupId= Some(364893); typeIds= [|  |]; description= "Advanced heavy frames." } |> Some
      | 365768 -> { MarketGroupData.id= 365768; name= "Prototype"; parentMarketGroupId= Some(365765); typeIds= [|  |]; description= "Prototype." } |> Some
      | 366253 -> { MarketGroupData.id= 366253; name= "Standard"; parentMarketGroupId= Some(366190); typeIds= [|  |]; description= "" } |> Some
      | 366350 -> { MarketGroupData.id= 366350; name= "Faction Booster Caldari"; parentMarketGroupId= Some(354534); typeIds= [|  |]; description= "" } |> Some
      | 369 -> { MarketGroupData.id= 369; name= ""; parentMarketGroupId= Some(150); typeIds= [| 22242; 3395; 3396; 3397; 3398; 3400; 24268; 26224; 24625; 3380; 3387; 3388 |]; description= "" } |> Some
      | 466 -> { MarketGroupData.id= 466; name= "Caldari"; parentMarketGroupId= Some(464); typeIds= [| 32876; 16238 |]; description= "Caldari destroyer designs." } |> Some
      | 563 -> { MarketGroupData.id= 563; name= "Large"; parentMarketGroupId= Some(556); typeIds= [| 22913; 22915; 13889; 13891; 7829; 7831; 7833; 14375; 14377; 14379; 14381; 14383; 14385; 3122; 571; 573; 7743; 7745; 13890; 7747; 7749; 15825; 3154; 15829; 15833; 7783; 7785; 34282; 7787; 7789; 3186; 7827; 575; 22911 |]; description= "Slow-tracking, high-damage blasters, for use on battleships." } |> Some
      | 660 -> { MarketGroupData.id= 660; name= "Auxiliary Power Controls"; parentMarketGroupId= Some(655); typeIds= [| 31936; 16537; 11563; 28740; 4254 |]; description= "Supplementary systems providing a flat boost to powercore energy." } |> Some
      | 757 -> { MarketGroupData.id= 757; name= "Target Painters"; parentMarketGroupId= Some(657); typeIds= [| 19810; 21540; 12709; 19814; 31944; 32414; 19812; 19806 |]; description= "Project an electronic signal towards a target, increasing its signature radius." } |> Some
      | 78 -> { MarketGroupData.id= 78; name= "Minmatar"; parentMarketGroupId= Some(7); typeIds= [| 644; 24694; 639 |]; description= "Minmatar battleship designs." } |> Some
      | 854 -> { MarketGroupData.id= 854; name= "Large"; parentMarketGroupId= Some(846); typeIds= [| 12761; 12765 |]; description= "Large ADAR ammunition, fired by battleship-sized guns." } |> Some
      | 951 -> { MarketGroupData.id= 951; name= "Hybrid Weapon Rigs"; parentMarketGroupId= Some(943); typeIds= [|  |]; description= "Permanent modification of a ship's hybrid weapon facilities." } |> Some
      | _ -> None