namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups93=
    let getMarketGroup id = 
      match id with 
      | 1063 -> { MarketGroupData.id= 1063; name= "Capital"; parentMarketGroupId= Some(1018); typeIds= [| 41475; 27934 |]; description= "Remote hull repair system designs, intended for use on capital-class vessels." } |> Some
      | 1257 -> { MarketGroupData.id= 1257; name= ""; parentMarketGroupId= Some(950); typeIds= [| 25969; 25971; 25973; 25975; 25977; 25979; 25981 |]; description= "" } |> Some
      | 1354 -> { MarketGroupData.id= 1354; name= "Shield Hardening Arrays"; parentMarketGroupId= Some(1841); typeIds= [| 2761; 2755; 2757; 2759 |]; description= "Blueprints of Shield Hardening Arrays." } |> Some
      | 1548 -> { MarketGroupData.id= 1548; name= "Shield Hardeners"; parentMarketGroupId= Some(1545); typeIds= [| 1129; 2290; 2292; 2294; 2296; 46011; 41662 |]; description= "Shield Hardeners" } |> Some
      | 1936 -> { MarketGroupData.id= 1936; name= "Warp Scramblers"; parentMarketGroupId= Some(657); typeIds= [| 21512; 16140; 15887; 40750; 14256; 14252; 40754; 14254; 40752; 14258; 14260; 40758; 40756; 40762; 40764; 447; 448; 5443; 5445; 14664; 15433; 14666; 14668; 14670; 41061; 28518; 5439; 15893 |]; description= "" } |> Some
      | 2033 -> { MarketGroupData.id= 2033; name= "Missile Guidance Enhancers"; parentMarketGroupId= Some(143); typeIds= [| 35770; 35771; 35774 |]; description= "" } |> Some
      | 2227 -> { MarketGroupData.id= 2227; name= "Weapon Upgrades"; parentMarketGroupId= Some(2209); typeIds= [|  |]; description= "" } |> Some
      | 2324 -> { MarketGroupData.id= 2324; name= "Engineering Complexes"; parentMarketGroupId= Some(477); typeIds= [| 35825; 35826; 35827 |]; description= "" } |> Some
      | 2421 -> { MarketGroupData.id= 2421; name= "Special Battleships"; parentMarketGroupId= Some(2420); typeIds= [| 47650; 49796; 52278; 47655 |]; description= "" } |> Some
      | 2518 -> { MarketGroupData.id= 2518; name= "Precursor Battlecruisers"; parentMarketGroupId= Some(1955); typeIds= [|  |]; description= "Precursor Battlecruisers" } |> Some
      | 287 -> { MarketGroupData.id= 287; name= "Projectile Turrets"; parentMarketGroupId= Some(210); typeIds= [|  |]; description= "Blueprints of projectile turrets for capsule-fitted vessels." } |> Some
      | 354337 -> { MarketGroupData.id= 354337; name= "Prototype"; parentMarketGroupId= Some(353568); typeIds= [|  |]; description= "" } |> Some
      | 354434 -> { MarketGroupData.id= 354434; name= "Damage Amplifiers"; parentMarketGroupId= Some(353586); typeIds= [|  |]; description= "" } |> Some
      | 366268 -> { MarketGroupData.id= 366268; name= "Standard"; parentMarketGroupId= Some(366191); typeIds= [|  |]; description= "" } |> Some
      | 366753 -> { MarketGroupData.id= 366753; name= "Standard"; parentMarketGroupId= Some(366752); typeIds= [|  |]; description= "Standard." } |> Some
      | 481 -> { MarketGroupData.id= 481; name= "Electronic Warfare Batteries"; parentMarketGroupId= Some(480); typeIds= [| 27778; 27779; 17174; 17175; 17176; 17177; 17178; 17180; 17181; 17182; 27563; 27565; 27567; 27569; 27570; 27573; 27574; 27576; 27577; 27579; 27580; 27582; 27583; 27585 |]; description= "Batteries providing electronic countermeasures for starbase defense." } |> Some
      | 578 -> { MarketGroupData.id= 578; name= "Medium"; parentMarketGroupId= Some(560); typeIds= [| 21553; 13783; 16056; 2921; 9451; 492; 493; 9453; 2969; 9457; 21555; 9455; 16055; 9207; 13784; 9209; 9211; 9213 |]; description= "Medium artillery cannons, suitable for cruiser use." } |> Some
      | 675 -> { MarketGroupData.id= 675; name= "Cloaking Devices"; parentMarketGroupId= Some(656); typeIds= [| 32260; 11370; 20565; 15790; 20561; 20563; 16126; 14776; 11577; 11578; 14780; 14234; 14782; 14778 |]; description= "Use advanced spatial distortion technology to render ships invisible." } |> Some
      | 772 -> { MarketGroupData.id= 772; name= "Extra Large"; parentMarketGroupId= Some(555); typeIds= [| 20448; 41138; 41139; 41140; 41141; 41142; 37303; 3550 |]; description= "Capital ship railguns, for use on dreadnoughts and titans." } |> Some
      | 869 -> { MarketGroupData.id= 869; name= "Large"; parentMarketGroupId= Some(853); typeIds= [| 12816; 12820 |]; description= "Large advanced pulse laser crystals, for use with battleship-sized lasers." } |> Some
      | _ -> None