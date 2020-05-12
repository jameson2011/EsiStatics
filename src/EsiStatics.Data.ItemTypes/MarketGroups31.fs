namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups31=
    let getMarketGroup id = 
      match id with 
      | 1001 -> { MarketGroupData.id= 1001; name= "Faction Cruise Missiles"; parentMarketGroupId= Some(580); typeIds= [| 27425; 27395; 27429; 27399; 27431; 27373; 27377; 27427; 27423; 27409; 27389; 27391 |]; description= "Faction issue cruise missiles." } |> Some
      | 1195 -> { MarketGroupData.id= 1195; name= "Reinforced Bulkheads"; parentMarketGroupId= Some(135); typeIds= [| 34487; 5647; 5649; 1333; 1335; 1240; 21496; 34485 |]; description= "Struts and braces that help improve a starship's structural integrity." } |> Some
      | 128 -> { MarketGroupData.id= 128; name= "Remote Shield Boosters"; parentMarketGroupId= Some(554); typeIds= [|  |]; description= "Transfer shields to another ship." } |> Some
      | 1389 -> { MarketGroupData.id= 1389; name= "ORE"; parentMarketGroupId= Some(208); typeIds= [| 3039 |]; description= "Blueprints of ORE industrial designs." } |> Some
      | 1486 -> { MarketGroupData.id= 1486; name= "Implant Slot 08"; parentMarketGroupId= Some(1478); typeIds= [| 27184; 27185; 27178 |]; description= "Implant Slot 08" } |> Some
      | 1583 -> { MarketGroupData.id= 1583; name= "Sensor Backup Arrays"; parentMarketGroupId= Some(1566); typeIds= [| 11824; 11828; 11820; 11836; 11832 |]; description= "Sensor Backup Arrays" } |> Some
      | 1680 -> { MarketGroupData.id= 1680; name= "Explosive Armor Hardeners"; parentMarketGroupId= Some(535); typeIds= [| 18951; 18967; 18959; 16365; 13974; 18905; 13976; 18925; 18975; 13988; 15270; 11303; 15272; 15274; 17504; 18889; 18891; 18927; 15064; 15268; 15066; 18907; 15068; 15709; 15070; 15072; 15074; 15076; 15717; 15078; 16361; 16363; 28524; 14061; 16367; 18937; 18939; 17834; 11646 |]; description= "Explosive Armor Hardeners" } |> Some
      | 1777 -> { MarketGroupData.id= 1777; name= "Implant Slot 10"; parentMarketGroupId= Some(1764); typeIds= [| 25547; 25548 |]; description= "Implant Slot 10" } |> Some
      | 1971 -> { MarketGroupData.id= 1971; name= "Dreadnoughts"; parentMarketGroupId= Some(1968); typeIds= [|  |]; description= "" } |> Some
      | 2068 -> { MarketGroupData.id= 2068; name= "Recon Ships"; parentMarketGroupId= Some(2064); typeIds= [|  |]; description= "" } |> Some
      | 2165 -> { MarketGroupData.id= 2165; name= "Fighter Upgrades"; parentMarketGroupId= Some(2158); typeIds= [|  |]; description= "" } |> Some
      | 2262 -> { MarketGroupData.id= 2262; name= "Force Auxiliaries"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of force auxiliary-class vessels." } |> Some
      | 2359 -> { MarketGroupData.id= 2359; name= "Faction Corvettes"; parentMarketGroupId= Some(2306); typeIds= [|  |]; description= "" } |> Some
      | 2456 -> { MarketGroupData.id= 2456; name= "Filaments"; parentMarketGroupId= Some(19); typeIds= [|  |]; description= "Abyssal Filaments and Jump Filaments" } |> Some
      | 354469 -> { MarketGroupData.id= 354469; name= "Damage Amplifiers"; parentMarketGroupId= Some(353592); typeIds= [|  |]; description= "" } |> Some
      | 354566 -> { MarketGroupData.id= 354566; name= "Advanced"; parentMarketGroupId= Some(354563); typeIds= [|  |]; description= "" } |> Some
      | 366206 -> { MarketGroupData.id= 366206; name= "Standard"; parentMarketGroupId= Some(366177); typeIds= [|  |]; description= "" } |> Some
      | 368922 -> { MarketGroupData.id= 368922; name= "Advanced"; parentMarketGroupId= Some(353651); typeIds= [|  |]; description= "" } |> Some
      | 369213 -> { MarketGroupData.id= 369213; name= "Dropsuits"; parentMarketGroupId= Some(369212); typeIds= [|  |]; description= "" } |> Some
      | 419 -> { MarketGroupData.id= 419; name= "Covert Ops"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of covert ops-class vessels." } |> Some
      | 516 -> { MarketGroupData.id= 516; name= "Plagioclase"; parentMarketGroupId= Some(54); typeIds= [| 28421; 28422; 28423; 46701; 17455; 17456; 18; 46685 |]; description= "Sub-types of plagioclase ore." } |> Some
      | 613 -> { MarketGroupData.id= 613; name= "Boost Amplifiers"; parentMarketGroupId= Some(552); typeIds= [| 20613; 16529; 16531; 16533; 16535; 15905; 15907; 11561; 14636; 14638; 14045; 14047; 19289; 19293; 19295; 19297; 19299; 19301; 19303; 19311; 14708; 14710; 14712; 14714; 24443 |]; description= "Focus and amplify the efficiency of shield boosting modules." } |> Some
      | 904 -> { MarketGroupData.id= 904; name= "ORE"; parentMarketGroupId= Some(883); typeIds= [| 22545; 22547; 22549 |]; description= "Blueprints of ORE exhumer designs." } |> Some
      | _ -> None