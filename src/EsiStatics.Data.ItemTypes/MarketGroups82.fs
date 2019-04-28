namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups82=
    let getMarketGroup id = 
      match id with 
      | 1052 -> { MarketGroupData.id= 1052; name= "Capital"; parentMarketGroupId= Some(134); typeIds= [| 3534; 41501; 41498; 41499; 41500; 20701; 41502; 41503 |]; description= "Armor repair designs, intended for capital-class vessels." } |> Some
      | 1343 -> { MarketGroupData.id= 1343; name= "Cynosural System Jammers"; parentMarketGroupId= Some(1841); typeIds= [| 2789 |]; description= "Blueprints of Cynosural System Jammers." } |> Some
      | 1537 -> { MarketGroupData.id= 1537; name= "Hull Repairers"; parentMarketGroupId= Some(214); typeIds= [| 3654; 1100; 3664; 41627; 41628; 41629 |]; description= "Blueprints for Hull Repairers" } |> Some
      | 1731 -> { MarketGroupData.id= 1731; name= "Capital Projectile Weapon Rigs"; parentMarketGroupId= Some(979); typeIds= [| 31714; 31684; 31690; 31660; 31696; 31666; 31702; 31672; 31708; 31678 |]; description= "Modifications that affect a capital starship's projectile weapons." } |> Some
      | 1828 -> { MarketGroupData.id= 1828; name= "Mobile Depots"; parentMarketGroupId= Some(406); typeIds= [| 33517 |]; description= "Blueprints for Mobile Depots" } |> Some
      | 2022 -> { MarketGroupData.id= 2022; name= "Advanced Battleships"; parentMarketGroupId= Some(1960); typeIds= [|  |]; description= "" } |> Some
      | 2119 -> { MarketGroupData.id= 2119; name= "Multiple Hull SKINs"; parentMarketGroupId= Some(1954); typeIds= [|  |]; description= "" } |> Some
      | 2216 -> { MarketGroupData.id= 2216; name= "Warp Disruptors"; parentMarketGroupId= Some(2206); typeIds= [| 35949; 47334 |]; description= "" } |> Some
      | 2313 -> { MarketGroupData.id= 2313; name= "Special Destroyers"; parentMarketGroupId= Some(1989); typeIds= [|  |]; description= "" } |> Some
      | 2410 -> { MarketGroupData.id= 2410; name= "Carrier-based Fighters"; parentMarketGroupId= Some(2236); typeIds= [|  |]; description= "" } |> Some
      | 276 -> { MarketGroupData.id= 276; name= "Gallente"; parentMarketGroupId= Some(206); typeIds= [| 978; 971; 972; 979 |]; description= "Blueprints of Gallente cruiser designs." } |> Some
      | 354423 -> { MarketGroupData.id= 354423; name= "Armor Plates"; parentMarketGroupId= Some(353582); typeIds= [|  |]; description= "" } |> Some
      | 365772 -> { MarketGroupData.id= 365772; name= "Prototype"; parentMarketGroupId= Some(365769); typeIds= [|  |]; description= "Prototype." } |> Some
      | 366257 -> { MarketGroupData.id= 366257; name= "Standard"; parentMarketGroupId= Some(366179); typeIds= [|  |]; description= "" } |> Some
      | 366742 -> { MarketGroupData.id= 366742; name= "Standard"; parentMarketGroupId= Some(366741); typeIds= [|  |]; description= "Standard" } |> Some
      | 373 -> { MarketGroupData.id= 373; name= "Missiles"; parentMarketGroupId= Some(150); typeIds= [| 12441; 12442; 21668; 28073; 32435; 41409; 41410; 3319; 21071; 20312; 20314; 20315; 20209; 20210; 20211; 20212; 20213; 25718; 25719; 3320; 3321; 3322; 3323; 3324; 3325; 3326 |]; description= "Skills pertaining to the efficient use of self-propelled warheads" } |> Some
      | 470 -> { MarketGroupData.id= 470; name= "Amarr"; parentMarketGroupId= Some(469); typeIds= [| 24696; 16233; 4302 |]; description= "Amarr battlecruiser designs." } |> Some
      | 567 -> { MarketGroupData.id= 567; name= "Small"; parentMarketGroupId= Some(557); typeIds= [| 15872; 13829; 23834; 23838; 13809; 2993; 6715; 6717; 6719; 6721; 452; 454; 3033; 13795; 6631; 6633; 15850; 6635; 6637; 15857; 15865; 13822 |]; description= "Small beam lasers, suitable for frigate use." } |> Some
      | 664 -> { MarketGroupData.id= 664; name= "Capacitor Batteries"; parentMarketGroupId= Some(655); typeIds= [|  |]; description= "Allow the capacitor to store more energy." } |> Some
      | 761 -> { MarketGroupData.id= 761; name= "Dreadnoughts"; parentMarketGroupId= Some(1381); typeIds= [|  |]; description= "Capital ships created for extended sieges of stationary installations." } |> Some
      | 82 -> { MarketGroupData.id= 82; name= "Minmatar"; parentMarketGroupId= Some(8); typeIds= [| 651; 652; 653 |]; description= "Minmatar industrial designs." } |> Some
      | 858 -> { MarketGroupData.id= 858; name= "Medium"; parentMarketGroupId= Some(847); typeIds= [| 12777; 12773 |]; description= "Medium ADAC ammunition, fired by cruiser-sized guns." } |> Some
      | 955 -> { MarketGroupData.id= 955; name= "Ship and Module Modifications"; parentMarketGroupId= None; typeIds= [|  |]; description= "Rigs and subsystems that alter a starship's attributes in such a way as to make it more effective in its chosen role    Mutaplasmids that permanently alter a module's attributes" } |> Some
      | _ -> None