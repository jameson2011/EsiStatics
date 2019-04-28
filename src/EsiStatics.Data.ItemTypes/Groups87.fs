namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups87=
    let getGroup id = 
      match id with 
      | 1154 -> { GroupData.id= 1154; name= "Target Breaker"; categoryId= 7; published= true; typeIds= [| 4409 |] } |> Some
      | 1542 -> { GroupData.id= 1542; name= "Command Destroyer Blueprint"; categoryId= 9; published= true; typeIds= [| 37617; 37618; 37619; 37620 |] } |> Some
      | 1639 -> { GroupData.id= 1639; name= "Structure Combat Rig XL - Missile and AoE Missile"; categoryId= 66; published= true; typeIds= [| 37268; 37269 |] } |> Some
      | 1736 -> { GroupData.id= 1736; name= "Roaming Blood Raider Battlecruiser"; categoryId= 11; published= false; typeIds= [| 42237 |] } |> Some
      | 1833 -> { GroupData.id= 1833; name= "Structure Engineering Rig M - Advanced Medium Ship TE"; categoryId= 66; published= true; typeIds= [| 43860; 43861 |] } |> Some
      | 281 -> { GroupData.id= 281; name= "Frozen"; categoryId= 17; published= true; typeIds= [| 45; 3715; 3717; 3777; 11855; 21564; 29470; 29481; 29482 |] } |> Some
      | 378 -> { GroupData.id= 378; name= "Cruise Control"; categoryId= 7; published= false; typeIds= [|  |] } |> Some
      | 475 -> { GroupData.id= 475; name= "Microwarpdrive"; categoryId= 7; published= false; typeIds= [|  |] } |> Some
      | 572 -> { GroupData.id= 572; name= "Asteroid Serpentis Frigate"; categoryId= 11; published= false; typeIds= [| 2370; 2379; 10283; 10284; 10285; 10286; 11045; 11046; 11047; 11048; 13049; 13050; 13051; 13052; 23429; 23430; 23431; 23432; 23434; 23435; 24361; 24362; 24363; 24364; 24365; 24366; 24367; 24368 |] } |> Some
      | 669 -> { GroupData.id= 669; name= "Mission Amarr Empire Destroyer"; categoryId= 11; published= false; typeIds= [| 24911; 24912; 24913; 24915; 24917; 24919; 27001; 45051 |] } |> Some
      | 766 -> { GroupData.id= 766; name= "Power Diagnostic System"; categoryId= 7; published= true; typeIds= [| 1537; 1539; 1541; 8211; 8213; 8215; 8217; 8219; 8221; 8223; 8225; 8255; 14134; 14136; 14138; 15096; 15098; 15100; 15102; 15104; 15106; 15108; 15110; 15292; 15294; 15296; 15298; 15439; 17524; 22953; 28739; 31952 |] } |> Some
      | 863 -> { GroupData.id= 863; name= "Bomb ECM"; categoryId= 8; published= true; typeIds= [| 27922 |] } |> Some
      | 87 -> { GroupData.id= 87; name= "Capacitor Booster Charge"; categoryId= 8; published= true; typeIds= [| 263; 264; 3552; 3554; 11283; 11285; 11287; 11289; 31982; 31990; 31998; 32006; 32014; 33330; 33332; 33334; 41489; 41490 |] } |> Some
      | 960 -> { GroupData.id= 960; name= "Deadspace Sleeper Awakened Sentinel"; categoryId= 11; published= false; typeIds= [| 30206; 30207; 30208 |] } |> Some
      | _ -> None