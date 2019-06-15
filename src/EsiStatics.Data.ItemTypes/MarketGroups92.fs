namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups92=
    let getMarketGroup id = 
      match id with 
      | 1062 -> { MarketGroupData.id= 1062; name= "Large"; parentMarketGroupId= Some(1018); typeIds= [| 27904; 3986 |]; description= "Remote hull repair system designs, intended for use on battleship-class vessels." } |> Some
      | 1256 -> { MarketGroupData.id= 1256; name= "Medium Energy Weapon Rigs"; parentMarketGroupId= Some(950); typeIds= [| 31457; 31493; 31433; 31469; 31445; 31481; 31421 |]; description= "Blueprints of Medium Energy Weapon Rigs." } |> Some
      | 1353 -> { MarketGroupData.id= 1353; name= "Reprocessing Arrays"; parentMarketGroupId= Some(1841); typeIds= [|  |]; description= "Blueprints of Reprocessing Arrays." } |> Some
      | 1547 -> { MarketGroupData.id= 1547; name= "Shield Flux Coils"; parentMarketGroupId= Some(1545); typeIds= [| 1255 |]; description= "Shield Flux Coils" } |> Some
      | 1838 -> { MarketGroupData.id= 1838; name= "Special Edition Covert Ops"; parentMarketGroupId= Some(1612); typeIds= [| 44993; 45530; 48636; 33397; 42246 |]; description= "" } |> Some
      | 1935 -> { MarketGroupData.id= 1935; name= "Warp Disruptors"; parentMarketGroupId= Some(657); typeIds= [| 21510; 15889; 15891; 5399; 40730; 40731; 40732; 5405; 40734; 40736; 40737; 14242; 5403; 14244; 14246; 14248; 3242; 3244; 40733; 14656; 14658; 14660; 14662; 15431; 32459; 28516; 41062; 14250 |]; description= "" } |> Some
      | 2032 -> { MarketGroupData.id= 2032; name= ""; parentMarketGroupId= Some(143); typeIds= [| 35788; 35789; 35790 |]; description= "" } |> Some
      | 2226 -> { MarketGroupData.id= 2226; name= "Missile Launchers"; parentMarketGroupId= Some(2209); typeIds= [|  |]; description= "" } |> Some
      | 2323 -> { MarketGroupData.id= 2323; name= "Engineering Service Modules"; parentMarketGroupId= Some(2166); typeIds= [| 43928; 43929; 43925; 43926; 43927 |]; description= "" } |> Some
      | 2420 -> { MarketGroupData.id= 2420; name= "Special Battleships"; parentMarketGroupId= Some(1960); typeIds= [|  |]; description= "" } |> Some
      | 2517 -> { MarketGroupData.id= 2517; name= "Ballistic Control System Mutaplasmids"; parentMarketGroupId= Some(2512); typeIds= [| 49739; 49740; 49741 |]; description= "" } |> Some
      | 286 -> { MarketGroupData.id= 286; name= "Hybrid Turrets"; parentMarketGroupId= Some(210); typeIds= [|  |]; description= "Blueprints of hybrid turrets for capsule-fitted vessels." } |> Some
      | 353657 -> { MarketGroupData.id= 353657; name= "Standard"; parentMarketGroupId= Some(353651); typeIds= [|  |]; description= "" } |> Some
      | 354336 -> { MarketGroupData.id= 354336; name= "Advanced"; parentMarketGroupId= Some(353568); typeIds= [|  |]; description= "" } |> Some
      | 354433 -> { MarketGroupData.id= 354433; name= "Shield Rechargers"; parentMarketGroupId= Some(353581); typeIds= [|  |]; description= "Dropsuit shield rechargers." } |> Some
      | 366267 -> { MarketGroupData.id= 366267; name= "Prototype"; parentMarketGroupId= Some(366264); typeIds= [|  |]; description= "" } |> Some
      | 366752 -> { MarketGroupData.id= 366752; name= "Cloak Fields"; parentMarketGroupId= Some(353563); typeIds= [|  |]; description= "Cloak Fields." } |> Some
      | 383 -> { MarketGroupData.id= 383; name= "Medium"; parentMarketGroupId= Some(141); typeIds= [| 9728; 14210; 9734; 14220; 14222; 21536; 9762; 28550; 15929; 23866; 15937; 9800; 15945; 15953; 15961; 3937; 3939; 3941; 3943; 3947; 3949; 14192; 3953; 14194; 3955 |]; description= "Cruiser-sized smartbombs." } |> Some
      | 480 -> { MarketGroupData.id= 480; name= "Weapon Batteries"; parentMarketGroupId= Some(1285); typeIds= [|  |]; description= "Stationary weapon batteries for starbase defense." } |> Some
      | 577 -> { MarketGroupData.id= 577; name= "Small"; parentMarketGroupId= Some(560); typeIds= [| 2977; 8907; 9413; 8903; 488; 8905; 487; 8909; 13779; 21549; 21547; 9411; 16052; 13781; 9417; 2905; 9415; 16053 |]; description= "Small artillery cannons, suitable for frigate use." } |> Some
      | 771 -> { MarketGroupData.id= 771; name= "Extra Large"; parentMarketGroupId= Some(556); typeIds= [| 20450; 41078; 41126; 41127; 41128; 41129; 41130; 37291; 37300; 37301; 37302; 41079; 41076; 3546; 41077 |]; description= "Capital ship blasters, for use on dreadnoughts and titans." } |> Some
      | 868 -> { MarketGroupData.id= 868; name= "Small"; parentMarketGroupId= Some(852); typeIds= [| 12557; 12559 |]; description= "Small advanced beam laser crystals, for use with frigate-sized lasers." } |> Some
      | 965 -> { MarketGroupData.id= 965; name= "Shield Rigs"; parentMarketGroupId= Some(1111); typeIds= [|  |]; description= "Permanent modification of a ship's shield facilities." } |> Some
      | _ -> None