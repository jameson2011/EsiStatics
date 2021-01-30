namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups1=
    let getMarketGroup id = 
      match id with 
      | 1068 -> { MarketGroupData.id= 1068; name= "Gallente"; parentMarketGroupId= Some(1065); typeIds= [| 11174 |]; description= "Gallente electronic attack frigate designs." } |> Some
      | 1262 -> { MarketGroupData.id= 1262; name= "Medium Missile Launcher Rigs"; parentMarketGroupId= Some(952); typeIds= [| 31589; 31623; 31601; 31635; 31611; 31647 |]; description= "Blueprints of Medium Missile Launcher Rigs." } |> Some
      | 1359 -> { MarketGroupData.id= 1359; name= "Laboratories"; parentMarketGroupId= Some(1841); typeIds= [|  |]; description= "Blueprints of Laboratories." } |> Some
      | 1553 -> { MarketGroupData.id= 1553; name= "Remote Shield Boosters"; parentMarketGroupId= Some(1545); typeIds= [| 3617; 41666; 3587; 41668; 3597; 41667; 3607 |]; description= "Remote Shield Boosters" } |> Some
      | 1650 -> { MarketGroupData.id= 1650; name= "Micro Jump Drives"; parentMarketGroupId= Some(52); typeIds= [| 33915; 4383 |]; description= "Advanced propulsion technology that allows for a jump over a very short distance." } |> Some
      | 1747 -> { MarketGroupData.id= 1747; name= "Shields"; parentMarketGroupId= Some(150); typeIds= [| 3425; 21059; 21802; 12365; 11566; 12367; 24571; 44067; 12366; 3416; 3419; 3420; 3422 |]; description= "Skills pertaining to management of a spaceship's energy barriers" } |> Some
      | 1844 -> { MarketGroupData.id= 1844; name= "Mobile Micro Jump Units"; parentMarketGroupId= Some(404); typeIds= [| 33591 |]; description= "" } |> Some
      | 1941 -> { MarketGroupData.id= 1941; name= "Jump Economizers"; parentMarketGroupId= Some(132); typeIds= [| 34122; 34124; 34126 |]; description= "" } |> Some
      | 2038 -> { MarketGroupData.id= 2038; name= "Amarr"; parentMarketGroupId= Some(2037); typeIds= [| 46785; 42563; 43499; 45772; 42765; 48846; 55345; 57010; 53614; 36313; 37499 |]; description= "" } |> Some
      | 2135 -> { MarketGroupData.id= 2135; name= "Micro Jump Field Generators"; parentMarketGroupId= Some(52); typeIds= [| 37479 |]; description= "" } |> Some
      | 2232 -> { MarketGroupData.id= 2232; name= "Citadel Service Modules"; parentMarketGroupId= Some(2210); typeIds= [| 35892; 35894 |]; description= "" } |> Some
      | 2426 -> { MarketGroupData.id= 2426; name= "Triglavian"; parentMarketGroupId= Some(2425); typeIds= [| 47269 |]; description= "Triglavian Frigates" } |> Some
      | 2523 -> { MarketGroupData.id= 2523; name= "Triglavian"; parentMarketGroupId= Some(2522); typeIds= [| 49710 |]; description= "Triglavian Destroyers" } |> Some
      | 292 -> { MarketGroupData.id= 292; name= "Small"; parentMarketGroupId= Some(288); typeIds= [| 47969; 834; 835; 836; 837; 838; 48469; 48470; 52348 |]; description= "Blueprints of small laser turrets." } |> Some
      | 583 -> { MarketGroupData.id= 583; name= "Amarr"; parentMarketGroupId= Some(582); typeIds= [| 32875; 16237 |]; description= "Blueprints of Amarr destroyer designs." } |> Some
      | 680 -> { MarketGroupData.id= 680; name= "Weapon Disruptors"; parentMarketGroupId= Some(657); typeIds= [| 37546; 5319; 5320; 5321; 5322; 37543; 37544; 22931; 22933; 37545; 2108; 2109 |]; description= "Weapon Disruptors" } |> Some
      | 777 -> { MarketGroupData.id= 777; name= "XL Launchers"; parentMarketGroupId= Some(140); typeIds= [| 41180; 3563; 3565; 37294; 37295; 41174; 41175; 41176; 20539; 32444; 41181; 41182 |]; description= "For the launching of XL torpedoes.  Can only be fitted on dreadnoughts and titans." } |> Some
      | 874 -> { MarketGroupData.id= 874; name= "Exhumers"; parentMarketGroupId= Some(1384); typeIds= [| 22544; 22546; 22548 |]; description= "Elite Mining Barges" } |> Some
      | 971 -> { MarketGroupData.id= 971; name= "Standard Heavy Assault Missiles"; parentMarketGroupId= Some(968); typeIds= [| 20306; 20307; 20308; 21867 |]; description= "Standard heavy assault missiles." } |> Some
      | _ -> None