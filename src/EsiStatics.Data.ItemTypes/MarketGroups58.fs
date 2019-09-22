namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups58=
    let getMarketGroup id = 
      match id with 
      | 1028 -> { MarketGroupData.id= 1028; name= "Light Fighters"; parentMarketGroupId= Some(2237); typeIds= [| 41376; 47216; 41379; 45670; 41382; 45672; 41385; 47210; 47211; 47213; 23056; 47208; 23058; 47219; 23060; 23062; 47209; 47222 |]; description= "Blueprints of light fighter designs." } |> Some
      | 1125 -> { MarketGroupData.id= 1125; name= "Minmatar Core Subsystems"; parentMarketGroupId= Some(1626); typeIds= [| 45632; 45633; 45631 |]; description= "Minmatar core subsystems." } |> Some
      | 1222 -> { MarketGroupData.id= 1222; name= "Small Engineering Rigs"; parentMarketGroupId= Some(961); typeIds= [| 31232; 31394; 31364; 43894; 31400; 31370; 31406; 31376; 26929; 26931; 31412; 31382; 31226; 31388; 31358 |]; description= "Modifications that affect a small starship's energy grid." } |> Some
      | 1416 -> { MarketGroupData.id= 1416; name= "Reactive Armor Hardeners"; parentMarketGroupId= Some(535); typeIds= [| 4403 |]; description= "Armor Hardeners that shift resistance based on damaged received." } |> Some
      | 1513 -> { MarketGroupData.id= 1513; name= "Implant Slot 09"; parentMarketGroupId= Some(1470); typeIds= [| 3288; 3289; 3290; 13232; 13235; 13236; 3271; 3272; 3273; 3280; 3281; 3282; 3283; 3284; 3287; 27224; 27225; 27226; 27232; 27233; 27234; 27235; 27236; 27237 |]; description= "Implant Slot 09" } |> Some
      | 1610 -> { MarketGroupData.id= 1610; name= "Amarr Subsystems"; parentMarketGroupId= Some(1112); typeIds= [|  |]; description= "Amarr Subsystems" } |> Some
      | 1707 -> { MarketGroupData.id= 1707; name= "Scanning Upgrades"; parentMarketGroupId= Some(1710); typeIds= [| 33177; 33179; 33181 |]; description= "Blueprints of scanning upgrade modules" } |> Some
      | 1804 -> { MarketGroupData.id= 1804; name= "Capital Scanning Rigs"; parentMarketGroupId= Some(1795); typeIds= [| 31315; 31218; 31243; 31206 |]; description= "Blueprints of Capital Scanning Rigs." } |> Some
      | 1901 -> { MarketGroupData.id= 1901; name= "Serpentis"; parentMarketGroupId= Some(1897); typeIds= [| 42226; 23153; 23154; 23155; 23156; 23157; 23163; 23164; 23165; 23166; 23167 |]; description= "Materials used in the construction of specific factional equipment." } |> Some
      | 1998 -> { MarketGroupData.id= 1998; name= "Frigates"; parentMarketGroupId= Some(1954); typeIds= [|  |]; description= "" } |> Some
      | 2095 -> { MarketGroupData.id= 2095; name= "Amarr"; parentMarketGroupId= Some(2094); typeIds= [| 36320; 48368; 46818; 42600; 43529; 42800; 45809; 37529; 49948; 48861 |]; description= "" } |> Some
      | 2192 -> { MarketGroupData.id= 2192; name= "Structure Antisubcapital Missiles"; parentMarketGroupId= Some(314); typeIds= [| 37856; 37857; 37855 |]; description= "" } |> Some
      | 2483 -> { MarketGroupData.id= 2483; name= "Precursor Cruisers"; parentMarketGroupId= Some(1988); typeIds= [|  |]; description= "Precursor Cruisers" } |> Some
      | 252 -> { MarketGroupData.id= 252; name= "Propulsion "; parentMarketGroupId= Some(209); typeIds= [|  |]; description= "Blueprints of propulsion systems." } |> Some
      | 446 -> { MarketGroupData.id= 446; name= "Minmatar"; parentMarketGroupId= Some(442); typeIds= [| 11979 |]; description= "Blueprints of Minmatar logistics designs." } |> Some
      | 640 -> { MarketGroupData.id= 640; name= "Light Missile Launchers"; parentMarketGroupId= Some(140); typeIds= [| 17491; 20595; 2404; 13925; 13926; 499; 16068; 8089; 8091; 22565 |]; description= "For the launching of light missiles." } |> Some
      | 737 -> { MarketGroupData.id= 737; name= "Individuals"; parentMarketGroupId= Some(616); typeIds= [| 18657; 15658; 15659; 15980; 15667; 15668; 15637; 15638; 15639; 17817; 15645 |]; description= "Individual identification tags." } |> Some
      | 834 -> { MarketGroupData.id= 834; name= "Minmatar"; parentMarketGroupId= Some(822); typeIds= [| 22468; 22444 |]; description= "Minmatar command ship designs." } |> Some
      | 931 -> { MarketGroupData.id= 931; name= "Advanced Anti-Ship Torpedoes"; parentMarketGroupId= Some(387); typeIds= [| 24521; 2811; 24523; 24519 |]; description= "Advanced Anti-Ship Torpedoes" } |> Some
      | _ -> None