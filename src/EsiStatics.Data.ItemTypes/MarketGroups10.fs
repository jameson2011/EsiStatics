namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups10=
    let getMarketGroup id = 
      match id with 
      | 10 -> { MarketGroupData.id= 10; name= "Turrets & Bays"; parentMarketGroupId= Some(9); typeIds= [|  |]; description= "Weapon systems to inflict damage on enemy targets" } |> Some
      | 107 -> { MarketGroupData.id= 107; name= "Small"; parentMarketGroupId= Some(848); typeIds= [| 215; 216; 217; 218; 219; 220; 221; 222 |]; description= "Small hybrid shells, fired by frigate-sized guns." } |> Some
      | 1077 -> { MarketGroupData.id= 1077; name= "Caldari"; parentMarketGroupId= Some(1075); typeIds= [| 22436 |]; description= "Caldari black ops designs." } |> Some
      | 1368 -> { MarketGroupData.id= 1368; name= "Advanced Cruisers"; parentMarketGroupId= Some(1367); typeIds= [|  |]; description= "Cruiser variants intended for specialized purposes." } |> Some
      | 1562 -> { MarketGroupData.id= 1562; name= "Remote Capacitor Transmitters"; parentMarketGroupId= Some(1546); typeIds= [| 41697; 12226; 41698; 1105; 12218; 12220 |]; description= "Remote Capacitor Transmitters" } |> Some
      | 1659 -> { MarketGroupData.id= 1659; name= "Special Edition Assets"; parentMarketGroupId= None; typeIds= [|  |]; description= "Special Edition Assets are typically limited run items associated with past events in New Eden, such as the Alliance Tournament" } |> Some
      | 1853 -> { MarketGroupData.id= 1853; name= "Complex Biochemical Reactions"; parentMarketGroupId= Some(1849); typeIds= [|  |]; description= "Biochemical processes through which compounds are combined into complex materials" } |> Some
      | 1950 -> { MarketGroupData.id= 1950; name= "ORE"; parentMarketGroupId= Some(766); typeIds= [| 34328 |]; description= "Freighters designed by ORE." } |> Some
      | 204 -> { MarketGroupData.id= 204; name= "Ships"; parentMarketGroupId= Some(2); typeIds= [|  |]; description= "Blueprints of capsuleer spaceships" } |> Some
      | 2047 -> { MarketGroupData.id= 2047; name= "Amarr"; parentMarketGroupId= Some(2043); typeIds= [| 42752; 42753; 36291; 36292; 46774; 43489; 52572; 46775; 37490; 37491; 43488; 42550; 42551; 52571; 45760; 45759 |]; description= "" } |> Some
      | 2144 -> { MarketGroupData.id= 2144; name= "Gallente"; parentMarketGroupId= Some(2141); typeIds= [| 46401; 40324; 47527; 45889; 44907; 42163; 46939 |]; description= "" } |> Some
      | 2241 -> { MarketGroupData.id= 2241; name= "Capital"; parentMarketGroupId= Some(551); typeIds= [| 40354; 40355; 40356; 40357; 41459; 41460; 41461; 41462 |]; description= "Capital-class shield extension systems." } |> Some
      | 2338 -> { MarketGroupData.id= 2338; name= "ORE"; parentMarketGroupId= Some(2337); typeIds= [| 42624; 43786; 43788; 46991; 46995; 46741; 43799; 43801; 42651; 43812; 43814; 43825; 43827; 42681; 43838; 43840; 43673; 43851; 43853; 34645; 44068; 43759; 43761; 43772; 43774 |]; description= "" } |> Some
      | 2435 -> { MarketGroupData.id= 2435; name= "Large"; parentMarketGroupId= Some(2432); typeIds= [| 52240; 47274; 47920; 47921; 47922; 47923 |]; description= "Large Entropic Disintegrators" } |> Some
      | 2532 -> { MarketGroupData.id= 2532; name= "Damage Control Mutaplasmids"; parentMarketGroupId= Some(2436); typeIds= [|  |]; description= "Damage Control and Assault Damage Control Mutaplasmids" } |> Some
      | 301 -> { MarketGroupData.id= 301; name= "Frequency Crystals"; parentMarketGroupId= Some(211); typeIds= [|  |]; description= "Frequency crystal blueprints." } |> Some
      | 353575 -> { MarketGroupData.id= 353575; name= "Drop Uplinks"; parentMarketGroupId= Some(353563); typeIds= [|  |]; description= "" } |> Some
      | 354448 -> { MarketGroupData.id= 354448; name= "Armor Repairers"; parentMarketGroupId= Some(353588); typeIds= [|  |]; description= "" } |> Some
      | 356582 -> { MarketGroupData.id= 356582; name= "Systemic Missile Damage"; parentMarketGroupId= Some(356576); typeIds= [|  |]; description= "" } |> Some
      | 356970 -> { MarketGroupData.id= 356970; name= "Prototype"; parentMarketGroupId= Some(354488); typeIds= [|  |]; description= "" } |> Some
      | 363469 -> { MarketGroupData.id= 363469; name= "Prototype"; parentMarketGroupId= Some(354339); typeIds= [|  |]; description= "Prototype" } |> Some
      | 364051 -> { MarketGroupData.id= 364051; name= "Scrambler Rifles"; parentMarketGroupId= Some(364047); typeIds= [|  |]; description= "Scrambler rifles." } |> Some
      | 366185 -> { MarketGroupData.id= 366185; name= "Vehicles"; parentMarketGroupId= Some(365999); typeIds= [|  |]; description= "" } |> Some
      | 366282 -> { MarketGroupData.id= 366282; name= "Equipment"; parentMarketGroupId= Some(365999); typeIds= [|  |]; description= "" } |> Some
      | 366573 -> { MarketGroupData.id= 366573; name= "Prototype"; parentMarketGroupId= Some(366570); typeIds= [|  |]; description= "Prototype." } |> Some
      | 592 -> { MarketGroupData.id= 592; name= "Minmatar"; parentMarketGroupId= Some(588); typeIds= [| 16232; 24703; 4311 |]; description= "Blueprints of Minmatar battlecruiser designs." } |> Some
      | 689 -> { MarketGroupData.id= 689; name= "Small"; parentMarketGroupId= Some(661); typeIds= [| 23815; 13003; 15794; 37623; 14160; 37624; 14162; 533; 37622; 4471; 15800; 4477 |]; description= "Frigate-sized energy destabilizers." } |> Some
      | 786 -> { MarketGroupData.id= 786; name= "Minmatar"; parentMarketGroupId= Some(782); typeIds= [| 19723 |]; description= "Blueprints of Minmatar dreadnought designs." } |> Some
      | 883 -> { MarketGroupData.id= 883; name= "Exhumers"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of Exhumers." } |> Some
      | _ -> None