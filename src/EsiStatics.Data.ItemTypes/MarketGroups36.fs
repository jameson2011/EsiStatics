﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups36=
    let getMarketGroup id = 
      match id with 
      | 1006 -> { MarketGroupData.id= 1006; name= "Extra Large"; parentMarketGroupId= Some(986); typeIds= [| 20737; 20739; 20741; 20743; 20745; 20747; 21900; 20749; 20751; 21908; 21916; 21920; 28330; 21933; 28338; 21941; 20801; 20803; 20805; 20807; 20809; 20811; 20813; 20815 |]; description= "Fired by dreadnaught-sized guns and stationary defense systems." } |> Some
      | 1103 -> { MarketGroupData.id= 1103; name= "Nanite Repair Paste"; parentMarketGroupId= Some(11); typeIds= [| 28668 |]; description= "A nanite packed-fluid, used for emergency repairs of ship modules" } |> Some
      | 1200 -> { MarketGroupData.id= 1200; name= "Survey Probes"; parentMarketGroupId= Some(120); typeIds= [| 18626; 18635; 18637 |]; description= "Survey probe designs." } |> Some
      | 133 -> { MarketGroupData.id= 133; name= "Armor Plates"; parentMarketGroupId= Some(14); typeIds= [|  |]; description= "Reinforced armor plates for additional protection." } |> Some
      | 1491 -> { MarketGroupData.id= 1491; name= "Implant Slot 08"; parentMarketGroupId= Some(1477); typeIds= [| 16005; 13238; 24663; 27098; 3101; 3102; 3103 |]; description= "Implant Slot 08" } |> Some
      | 1588 -> { MarketGroupData.id= 1588; name= "Caldari"; parentMarketGroupId= Some(1097); typeIds= [| 29056; 29058; 29060; 29094; 29098; 29100; 29102; 29072; 29108 |]; description= "Caldari" } |> Some
      | 1685 -> { MarketGroupData.id= 1685; name= "Energized Kinetic Plating"; parentMarketGroupId= Some(541); typeIds= [| 14080; 17538; 15236; 18821; 15238; 15240; 16393; 15242; 16395; 16397; 16399; 18833; 18835; 15000; 15002; 15727; 15004; 15006; 15008; 15010; 15012; 18853; 15014; 18801; 18877; 18879; 22883; 18855; 11245; 11247; 11249; 28536; 15737; 18811; 14076; 14078 |]; description= "Energized Kinetic Plating" } |> Some
      | 1782 -> { MarketGroupData.id= 1782; name= "Small Resource Processing Rigs"; parentMarketGroupId= Some(1779); typeIds= [| 31089; 31083 |]; description= "Modifications that affect a small starship's resource processing." } |> Some
      | 1976 -> { MarketGroupData.id= 1976; name= "Gallente"; parentMarketGroupId= Some(2374); typeIds= [| 46721; 45573; 45574; 44937; 44938; 47504; 49427; 50078; 36522; 47538; 36401; 36402; 47539; 34654; 47290; 45919; 45920; 42188; 42189; 37584; 37585; 50004; 48213; 34653; 46558; 46431; 34656; 46561; 34655; 50150; 50151; 46432; 46965; 46966 |]; description= "" } |> Some
      | 2073 -> { MarketGroupData.id= 2073; name= "Amarr"; parentMarketGroupId= Some(2066); typeIds= [| 46529; 37506; 46789; 36297; 42571; 43506; 42772; 45780 |]; description= "" } |> Some
      | 2170 -> { MarketGroupData.id= 2170; name= "Target Painters"; parentMarketGroupId= Some(2161); typeIds= [| 37081 |]; description= "" } |> Some
      | 2267 -> { MarketGroupData.id= 2267; name= "Amarr"; parentMarketGroupId= Some(912); typeIds= [| 40632; 43658; 24550; 40631 |]; description= "" } |> Some
      | 2461 -> { MarketGroupData.id= 2461; name= "Electrical Filaments"; parentMarketGroupId= Some(2456); typeIds= [| 47904; 47905; 47906; 47907; 47765 |]; description= "Filaments that connect to Abyssal pockets with Electrical Storms" } |> Some
      | 353601 -> { MarketGroupData.id= 353601; name= "Assault"; parentMarketGroupId= Some(364045); typeIds= [|  |]; description= "Assault dropsuits." } |> Some
      | 354377 -> { MarketGroupData.id= 354377; name= "Advanced"; parentMarketGroupId= Some(353601); typeIds= [|  |]; description= "" } |> Some
      | 366114 -> { MarketGroupData.id= 366114; name= "Prototype"; parentMarketGroupId= Some(366111); typeIds= [|  |]; description= "Prototype." } |> Some
      | 366211 -> { MarketGroupData.id= 366211; name= "Advanced"; parentMarketGroupId= Some(366186); typeIds= [|  |]; description= "" } |> Some
      | 367569 -> { MarketGroupData.id= 367569; name= "Item Bundles"; parentMarketGroupId= Some(365374); typeIds= [|  |]; description= "" } |> Some
      | 424 -> { MarketGroupData.id= 424; name= "Minmatar"; parentMarketGroupId= Some(420); typeIds= [| 12034; 11182 |]; description= "Minmatar covert ops designs." } |> Some
      | 521 -> { MarketGroupData.id= 521; name= "Crokite"; parentMarketGroupId= Some(54); typeIds= [| 46693; 28391; 28392; 1225; 46677; 28393; 17432; 17433 |]; description= "Sub-types of crokite ore." } |> Some
      | 618 -> { MarketGroupData.id= 618; name= "Implant Slot 01"; parentMarketGroupId= Some(532); typeIds= [| 28802; 33923; 28808; 33929; 28814; 33935; 20498; 20499; 33941; 20121; 33947; 33953; 2082; 33959; 9899; 33965; 33971; 42145; 19534; 31954; 19540; 14295; 33555; 31962; 22107; 42204; 31968; 22113; 42210; 13283; 32101; 31974; 22119; 10216; 10217; 32107; 33516; 22125; 32112; 22760; 22131; 32117; 28790; 28796; 33917 |]; description= "Implants intended for Subcervical Processing Slot 1." } |> Some
      | 715 -> { MarketGroupData.id= 715; name= "Magnetometric Jammers"; parentMarketGroupId= Some(677); typeIds= [| 2563; 19923; 19925; 19927; 28729; 1948; 20573 |]; description= "Targeting jammers specialized for use against magnetometric sensors." } |> Some
      | 812 -> { MarketGroupData.id= 812; name= "Titans"; parentMarketGroupId= Some(1381); typeIds= [|  |]; description= "Fathers of the fleet, the biggest of the big." } |> Some
      | _ -> None