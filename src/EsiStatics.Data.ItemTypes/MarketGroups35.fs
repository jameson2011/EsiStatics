namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups35=
    let getMarketGroup id = 
      match id with 
      | 1199 -> { MarketGroupData.id= 1199; name= "Scan Probes"; parentMarketGroupId= Some(120); typeIds= [| 30488; 32246; 30028; 30013; 30486 |]; description= "Scan probe designs." } |> Some
      | 132 -> { MarketGroupData.id= 132; name= "Propulsion Upgrades"; parentMarketGroupId= Some(52); typeIds= [|  |]; description= "Hull modifications designed to increase a ship's speed." } |> Some
      | 1490 -> { MarketGroupData.id= 1490; name= "Implant Slot 07"; parentMarketGroupId= Some(1477); typeIds= [| 16004; 19500; 3093; 3094; 3095; 13240; 27099 |]; description= "Implant Slot 07" } |> Some
      | 1587 -> { MarketGroupData.id= 1587; name= "Amarr"; parentMarketGroupId= Some(1097); typeIds= [| 29104; 29064; 29068; 29040; 29096; 29074; 29110; 29048; 29054 |]; description= "Amarr" } |> Some
      | 1684 -> { MarketGroupData.id= 1684; name= "Energized EM Plating"; parentMarketGroupId= Some(541); typeIds= [| 14976; 14978; 14980; 14982; 14088; 18825; 14090; 14092; 18841; 16409; 16411; 16413; 16415; 19361; 18843; 17542; 18869; 18871; 18805; 28540; 11215; 11217; 11219; 15226; 14968; 15723; 15220; 15733; 15222; 15224; 14970; 14972; 19363; 14974; 18815 |]; description= "Energized EM Plating" } |> Some
      | 1781 -> { MarketGroupData.id= 1781; name= "Targeting Rigs"; parentMarketGroupId= Some(1111); typeIds= [|  |]; description= "Permanent modification of a ship's targeting facilities." } |> Some
      | 1975 -> { MarketGroupData.id= 1975; name= "Caldari"; parentMarketGroupId= Some(2374); typeIds= [| 36742; 36359; 47497; 47630; 46864; 46865; 52642; 45860; 45861; 40618; 40619; 46137; 46138; 47291; 36670; 36671; 46277; 48203; 48204; 47315; 36743; 34651; 34652; 49424 |]; description= "" } |> Some
      | 2072 -> { MarketGroupData.id= 2072; name= "Minmatar"; parentMarketGroupId= Some(2065); typeIds= [| 36771; 36772; 45958; 45959; 40488; 40489; 52427; 46895; 46896; 36433; 36818; 36435; 47636; 46019; 48505; 47162; 48506; 36819 |]; description= "" } |> Some
      | 2169 -> { MarketGroupData.id= 2169; name= "Stasis Webifiers"; parentMarketGroupId= Some(2161); typeIds= [| 37080 |]; description= "" } |> Some
      | 2266 -> { MarketGroupData.id= 2266; name= "Minmatar"; parentMarketGroupId= Some(2262); typeIds= [| 41585 |]; description= "Blueprints of Minmatar force auxiliary designs." } |> Some
      | 2460 -> { MarketGroupData.id= 2460; name= "Gamma Filaments"; parentMarketGroupId= Some(2456); typeIds= [| 47900; 47764; 47901; 47902; 47903 |]; description= "Filaments that connect to Abyssal pockets with Gamma-Ray Afterglow" } |> Some
      | 423 -> { MarketGroupData.id= 423; name= "Gallente"; parentMarketGroupId= Some(420); typeIds= [| 11377; 11172 |]; description= "Gallente covert ops designs." } |> Some
      | 617 -> { MarketGroupData.id= 617; name= "XL Torpedoes"; parentMarketGroupId= Some(314); typeIds= [| 17864; 17858; 17860; 17862 |]; description= "Blueprints of XL torpedoes." } |> Some
      | 714 -> { MarketGroupData.id= 714; name= "Survey Scanners"; parentMarketGroupId= Some(1708); typeIds= [| 6569; 444; 2333 |]; description= "For analysis of the composition of asteroids and other celestial objects." } |> Some
      | _ -> None