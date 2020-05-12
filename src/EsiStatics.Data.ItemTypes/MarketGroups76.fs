namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups76=
    let getMarketGroup id = 
      match id with 
      | 1046 -> { MarketGroupData.id= 1046; name= "ORE"; parentMarketGroupId= Some(1045); typeIds= [| 28353 |]; description= "Blueprints of ORE Capital Industrial Ship designs." } |> Some
      | 1240 -> { MarketGroupData.id= 1240; name= "Small Astronautic Rigs"; parentMarketGroupId= Some(945); typeIds= [| 31106; 31142; 31178; 31118; 31154; 31190; 31160; 31130; 34267 |]; description= "Blueprints of Small Astronautic Rigs." } |> Some
      | 1337 -> { MarketGroupData.id= 1337; name= "Advanced Planetary Materials"; parentMarketGroupId= Some(1332); typeIds= [| 2867; 2868; 2869; 2870; 2871; 2872; 2875; 2876 |]; description= "The firth and final tier of planetary materials." } |> Some
      | 1531 -> { MarketGroupData.id= 1531; name= "Light Scout Drones"; parentMarketGroupId= Some(1530); typeIds= [| 2465; 2487; 2204; 2455 |]; description= "Blueprints of light scout drone designs." } |> Some
      | 1725 -> { MarketGroupData.id= 1725; name= "Capital Energy Weapon Rigs"; parentMarketGroupId= Some(950); typeIds= [| 31459; 31495; 31435; 31471; 31447; 31483; 31423 |]; description= "Blueprints of Capital Energy Weapon Rigs." } |> Some
      | 1822 -> { MarketGroupData.id= 1822; name= "Tattoos"; parentMarketGroupId= Some(1407); typeIds= [| 33377; 33378; 33379; 33380; 33381; 33382; 33383; 33384 |]; description= "Tattoos for characters" } |> Some
      | 1919 -> { MarketGroupData.id= 1919; name= "R.Db"; parentMarketGroupId= Some(1522); typeIds= [| 11876; 11877; 11878; 11879; 11880; 11881; 11882; 11883; 11884; 11885; 11886; 11857 |]; description= "" } |> Some
      | 2016 -> { MarketGroupData.id= 2016; name= "Military Upgrades"; parentMarketGroupId= Some(2015); typeIds= [| 34848; 34849; 34850; 34851; 34852; 34853; 34854; 34869; 34841; 34842; 34843; 34844; 34845; 34846; 34847 |]; description= "Blueprints of Military Upgrades" } |> Some
      | 2113 -> { MarketGroupData.id= 2113; name= "Minmatar"; parentMarketGroupId= Some(2109); typeIds= [| 36832; 46913; 50084; 48517; 47175; 48216; 48521; 52887; 49960; 36785; 49429; 40503; 45976; 53434; 36445 |]; description= "" } |> Some
      | 2210 -> { MarketGroupData.id= 2210; name= "Service Modules"; parentMarketGroupId= Some(2202); typeIds= [|  |]; description= "" } |> Some
      | 2307 -> { MarketGroupData.id= 2307; name= "Standard Corvettes"; parentMarketGroupId= Some(2306); typeIds= [|  |]; description= "" } |> Some
      | 2404 -> { MarketGroupData.id= 2404; name= "Polymer Reaction Formulas"; parentMarketGroupId= Some(1849); typeIds= [| 46157; 46158; 46159; 46160; 46161; 46162; 46163; 46164; 46165 |]; description= "Reaction formulas that enable the creation of Tech 3 construction materials in Refineries" } |> Some
      | 2501 -> { MarketGroupData.id= 2501; name= "Antipharmakon"; parentMarketGroupId= Some(2490); typeIds= [| 36911 |]; description= "Antipharmakon Boosters" } |> Some
      | 355193 -> { MarketGroupData.id= 355193; name= "Nanite Injectors"; parentMarketGroupId= Some(353563); typeIds= [|  |]; description= "" } |> Some
      | 364893 -> { MarketGroupData.id= 364893; name= "Basic"; parentMarketGroupId= Some(364046); typeIds= [|  |]; description= "Basic heavy frame dropsuits." } |> Some
      | 365766 -> { MarketGroupData.id= 365766; name= "Standard"; parentMarketGroupId= Some(365765); typeIds= [|  |]; description= "Standard." } |> Some
      | 367 -> { MarketGroupData.id= 367; name= "Electronic Systems"; parentMarketGroupId= Some(150); typeIds= [| 27911; 27906; 3427; 19921; 3433; 3434; 3435; 19759; 19760; 19761; 19922; 19766; 19767; 11579; 4411 |]; description= "Skills pertaining to management of a spaceship's electronic systems" } |> Some
      | 464 -> { MarketGroupData.id= 464; name= "Standard Destroyers"; parentMarketGroupId= Some(1372); typeIds= [|  |]; description= "Anti-frigate gunboats.  The middle ground between a frigate and a cruiser." } |> Some
      | 561 -> { MarketGroupData.id= 561; name= "Small"; parentMarketGroupId= Some(556); typeIds= [| 22901; 7579; 7581; 7583; 7585; 562; 563; 564; 13886; 13887; 13888; 7489; 7491; 7493; 22899; 15826; 15827; 15828; 3162; 3170; 34278; 3178; 7535; 7537; 7539; 7541; 22903; 7487 |]; description= "Fast-tracking, low-damage blasters, for use on frigates." } |> Some
      | 658 -> { MarketGroupData.id= 658; name= "Power Diagnostic Systems"; parentMarketGroupId= Some(655); typeIds= [| 15104; 1537; 15106; 1539; 15108; 1541; 15110; 8225; 22953; 14134; 14136; 14138; 15292; 15294; 15296; 15298; 28739; 31952; 17524; 15096; 15098; 15100; 15102 |]; description= "Monitor and optimize the power grid and capacitor systems." } |> Some
      | 76 -> { MarketGroupData.id= 76; name= "Gallente"; parentMarketGroupId= Some(6); typeIds= [| 633; 626; 627; 634 |]; description= "Gallente cruiser designs." } |> Some
      | 852 -> { MarketGroupData.id= 852; name= "Advanced Beam Laser Crystals"; parentMarketGroupId= Some(101); typeIds= [|  |]; description= "Technologically advanced beam laser crystals." } |> Some
      | 949 -> { MarketGroupData.id= 949; name= "Engineering Rigs"; parentMarketGroupId= Some(943); typeIds= [|  |]; description= "Permanent modification of a ship's energy grid facilities." } |> Some
      | _ -> None