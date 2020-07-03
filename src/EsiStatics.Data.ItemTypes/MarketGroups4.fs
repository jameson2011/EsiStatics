namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups4=
    let getMarketGroup id = 
      match id with 
      | 101 -> { MarketGroupData.id= 101; name= "Frequency Crystals"; parentMarketGroupId= Some(11); typeIds= [|  |]; description= "Modulate energy into several different frequencies for beam lasers and pulse lasers " } |> Some
      | 1071 -> { MarketGroupData.id= 1071; name= "Amarr"; parentMarketGroupId= Some(1070); typeIds= [| 12017 |]; description= "Amarr heavy interdiction cruiser designs." } |> Some
      | 1265 -> { MarketGroupData.id= 1265; name= "Medium Projectile Weapon Rigs"; parentMarketGroupId= Some(953); typeIds= [| 31707; 31659; 31695; 31683; 31671 |]; description= "Blueprints of Medium Projectile Weapon Rigs." } |> Some
      | 1362 -> { MarketGroupData.id= 1362; name= "Faction Frigates"; parentMarketGroupId= Some(1361); typeIds= [|  |]; description= "Frigates designed by specific factions." } |> Some
      | 1556 -> { MarketGroupData.id= 1556; name= "Capacitor Flux Coils"; parentMarketGroupId= Some(1546); typeIds= [| 1247 |]; description= "Capacitor Flux Coils" } |> Some
      | 1653 -> { MarketGroupData.id= 1653; name= "Freight Containers"; parentMarketGroupId= Some(379); typeIds= [| 33003; 33005; 33007; 33009; 33011; 24445 |]; description= "Freight Containers" } |> Some
      | 1847 -> { MarketGroupData.id= 1847; name= "Encounter Surveillance Systems"; parentMarketGroupId= Some(404); typeIds= [| 33608; 33585; 33610; 33595 |]; description= "Deployables that monitor bounty payout activity in the system" } |> Some
      | 1944 -> { MarketGroupData.id= 1944; name= "Bottoms, extras"; parentMarketGroupId= Some(1402); typeIds= [| 34048; 34049; 34050; 34051; 34052; 33989; 34054; 34055; 34053; 34045; 34046; 34047 |]; description= "" } |> Some
      | 2041 -> { MarketGroupData.id= 2041; name= "Minmatar"; parentMarketGroupId= Some(2037); typeIds= [| 45952; 40482; 50083; 48838; 52425; 46891; 36813; 52863; 45557; 55694; 52287; 36766; 36447 |]; description= "" } |> Some
      | 2138 -> { MarketGroupData.id= 2138; name= "Caldari"; parentMarketGroupId= Some(2136); typeIds= [| 40321; 55557; 45825; 48168; 53162; 40592; 46835; 46102 |]; description= "" } |> Some
      | 2235 -> { MarketGroupData.id= 2235; name= "Missile Guidance Enhancers"; parentMarketGroupId= Some(2227); typeIds= [| 35962; 47340 |]; description= "" } |> Some
      | 2332 -> { MarketGroupData.id= 2332; name= "Engineering Service Modules"; parentMarketGroupId= Some(2210); typeIds= [| 35877; 35878; 35881; 45550; 35891; 35886 |]; description= "" } |> Some
      | 2429 -> { MarketGroupData.id= 2429; name= "Precursor Battleships"; parentMarketGroupId= Some(1376); typeIds= [|  |]; description= "Precursor Battleships" } |> Some
      | 2526 -> { MarketGroupData.id= 2526; name= "Triglavian"; parentMarketGroupId= Some(437); typeIds= [| 49713 |]; description= "Triglavian Logistics Cruisers" } |> Some
      | 295 -> { MarketGroupData.id= 295; name= "Large"; parentMarketGroupId= Some(288); typeIds= [| 47973; 844; 845; 846; 847; 848; 48473; 48474; 52350 |]; description= "Blueprints of large laser turrets." } |> Some
      | 4 -> { MarketGroupData.id= 4; name= "Ships"; parentMarketGroupId= None; typeIds= [|  |]; description= "Capsuleer spaceships of all sizes and roles, including advanced and faction variants of many hull types" } |> Some
      | 586 -> { MarketGroupData.id= 586; name= "Minmatar"; parentMarketGroupId= Some(582); typeIds= [| 16243; 32879 |]; description= "Blueprints of Minmatar destroyer designs." } |> Some
      | 683 -> { MarketGroupData.id= 683; name= "Stasis Webifiers"; parentMarketGroupId= Some(657); typeIds= [| 28514; 14652; 30328; 41038; 526; 527; 17500; 14648; 14654; 14262; 17559; 14264; 4025; 14266; 4027; 14268; 14650; 14270 |]; description= "Slow them down, then smack them down." } |> Some
      | 974 -> { MarketGroupData.id= 974; name= "Heavy Assault Launchers"; parentMarketGroupId= Some(140); typeIds= [| 20138; 25707; 25709; 25711; 25713; 25715; 34292; 28565; 28375; 28377; 28379; 28381; 28383 |]; description= "For the launching of assault missiles." } |> Some
      | _ -> None