namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups2=
    let getMarketGroup id = 
      match id with 
      | 1069 -> { MarketGroupData.id= 1069; name= "Minmatar"; parentMarketGroupId= Some(1065); typeIds= [| 11387 |]; description= "Minmatar electronic attack frigate designs." } |> Some
      | 1263 -> { MarketGroupData.id= 1263; name= "Large Missile Launcher Rigs"; parentMarketGroupId= Some(952); typeIds= [| 26017; 26021; 26023; 26027; 26029; 26031 |]; description= "Blueprints of Large Missile Launcher Rigs." } |> Some
      | 1554 -> { MarketGroupData.id= 1554; name= "Shield Resistance Amplifiers"; parentMarketGroupId= Some(1545); typeIds= [| 2546; 1809; 2530; 2538 |]; description= "Shield Resistance Amplifiers" } |> Some
      | 1651 -> { MarketGroupData.id= 1651; name= "Secure Containers"; parentMarketGroupId= Some(379); typeIds= [| 11488; 3465; 3466; 3467; 11489 |]; description= "Secure Containers" } |> Some
      | 1748 -> { MarketGroupData.id= 1748; name= "Targeting"; parentMarketGroupId= Some(150); typeIds= [| 3428; 3429; 3430; 32999; 33000; 33001; 33002; 3431 |]; description= "Skills pertaining to management of a spaceship's sensor and tracking systems" } |> Some
      | 1845 -> { MarketGroupData.id= 1845; name= "Mobile Scan Inhibitors"; parentMarketGroupId= Some(404); typeIds= [| 33589 |]; description= "" } |> Some
      | 1942 -> { MarketGroupData.id= 1942; name= "Pilot's Services"; parentMarketGroupId= Some(1922); typeIds= [| 34132; 34133 |]; description= "Services available for various customization for capsuleers" } |> Some
      | 2 -> { MarketGroupData.id= 2; name= "Blueprints & Reactions"; parentMarketGroupId= None; typeIds= [|  |]; description= "Blueprints are data items used in industry for manufacturing, research and invention jobs" } |> Some
      | 2039 -> { MarketGroupData.id= 2039; name= "Caldari"; parentMarketGroupId= Some(2037); typeIds= [| 36357; 45831; 36648; 48174; 36720; 40596; 46839; 46108 |]; description= "" } |> Some
      | 2136 -> { MarketGroupData.id= 2136; name= "Logistics Frigates"; parentMarketGroupId= Some(2042); typeIds= [|  |]; description= "" } |> Some
      | 2233 -> { MarketGroupData.id= 2233; name= "Resource Processing Service Modules"; parentMarketGroupId= Some(2210); typeIds= [| 45539; 45009; 45538; 35899; 45537 |]; description= "" } |> Some
      | 2330 -> { MarketGroupData.id= 2330; name= "Special Edition Industrial Ships"; parentMarketGroupId= Some(2006); typeIds= [|  |]; description= "" } |> Some
      | 2427 -> { MarketGroupData.id= 2427; name= "Precursor Cruisers"; parentMarketGroupId= Some(1367); typeIds= [|  |]; description= "Precursor Cruisers" } |> Some
      | 2524 -> { MarketGroupData.id= 2524; name= "Precursor Battlecruisers"; parentMarketGroupId= Some(1374); typeIds= [|  |]; description= "Precursor Battlecruisers." } |> Some
      | 293 -> { MarketGroupData.id= 293; name= "Medium"; parentMarketGroupId= Some(288); typeIds= [| 47971; 839; 840; 841; 842; 843; 52239; 48471; 48472; 52349 |]; description= "Blueprints of medium laser turrets." } |> Some
      | 353567 -> { MarketGroupData.id= 353567; name= "Dropsuit Weapons"; parentMarketGroupId= Some(353562); typeIds= [|  |]; description= "Handheld weaponry used by infantry" } |> Some
      | 353664 -> { MarketGroupData.id= 353664; name= "Standard"; parentMarketGroupId= Some(353652); typeIds= [|  |]; description= "" } |> Some
      | 354343 -> { MarketGroupData.id= 354343; name= "Standard"; parentMarketGroupId= Some(353573); typeIds= [|  |]; description= "" } |> Some
      | 356962 -> { MarketGroupData.id= 356962; name= "Prototype"; parentMarketGroupId= Some(354491); typeIds= [|  |]; description= "" } |> Some
      | 366177 -> { MarketGroupData.id= 366177; name= "Dropsuits"; parentMarketGroupId= Some(365999); typeIds= [|  |]; description= "" } |> Some
      | 366274 -> { MarketGroupData.id= 366274; name= "Prototype"; parentMarketGroupId= Some(366180); typeIds= [|  |]; description= "" } |> Some
      | 368020 -> { MarketGroupData.id= 368020; name= "Sentinel"; parentMarketGroupId= Some(368108); typeIds= [|  |]; description= "" } |> Some
      | 390 -> { MarketGroupData.id= 390; name= "Torpedoes"; parentMarketGroupId= Some(314); typeIds= [| 2507; 1221; 2511; 2509 |]; description= "Blueprints of torpedoes." } |> Some
      | 584 -> { MarketGroupData.id= 584; name= "Caldari"; parentMarketGroupId= Some(582); typeIds= [| 32877; 16239 |]; description= "Blueprints of Caldari destroyer designs." } |> Some
      | 681 -> { MarketGroupData.id= 681; name= "Sensor Backup Arrays"; parentMarketGroupId= Some(657); typeIds= [|  |]; description= "Beef up your sensor strength to resist target jamming." } |> Some
      | 778 -> { MarketGroupData.id= 778; name= "Capital"; parentMarketGroupId= Some(552); typeIds= [| 41504; 41505; 41506; 41507; 41508; 41509; 41510; 3542; 20703 |]; description= "Shield boosters for capital ships" } |> Some
      | 972 -> { MarketGroupData.id= 972; name= "Advanced Long Range Heavy Assault Missiles"; parentMarketGroupId= Some(968); typeIds= [| 13856; 24492; 24493; 24494 |]; description= "Advanced long range heavy assault missiles." } |> Some
      | 99 -> { MarketGroupData.id= 99; name= "Projectile Ammo"; parentMarketGroupId= Some(11); typeIds= [|  |]; description= "Metal-cased shells, fired by artillery guns and autocannons" } |> Some
      | _ -> None