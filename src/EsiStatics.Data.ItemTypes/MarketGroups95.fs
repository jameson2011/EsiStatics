namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups95=
    let getMarketGroup id = 
      match id with 
      | 1065 -> { MarketGroupData.id= 1065; name= "Electronic Attack Frigates"; parentMarketGroupId= Some(1364); typeIds= [|  |]; description= "Frigates specialized in electronic warfare." } |> Some
      | 1259 -> { MarketGroupData.id= 1259; name= "Medium Hybrid Weapon Rigs"; parentMarketGroupId= Some(951); typeIds= [| 31553; 31529; 31565; 31505; 31541; 31577; 31517 |]; description= "Blueprints of Medium Hybrid Weapon Rigs." } |> Some
      | 1356 -> { MarketGroupData.id= 1356; name= "Sovereignty Structures"; parentMarketGroupId= Some(2015); typeIds= [| 2737; 2735 |]; description= "Blueprints of Sovereignty Structures." } |> Some
      | 1550 -> { MarketGroupData.id= 1550; name= "Shield Power Relays"; parentMarketGroupId= Some(1545); typeIds= [| 2332 |]; description= "Shield Power Relays" } |> Some
      | 1841 -> { MarketGroupData.id= 1841; name= "Starbase Structures"; parentMarketGroupId= Some(1338); typeIds= [|  |]; description= "Blueprints of deployable structures." } |> Some
      | 1938 -> { MarketGroupData.id= 1938; name= "Warp Disruptors"; parentMarketGroupId= Some(1566); typeIds= [| 3243; 40740; 40741; 40742; 40743 |]; description= "" } |> Some
      | 2035 -> { MarketGroupData.id= 2035; name= "Standard Destroyers"; parentMarketGroupId= Some(1989); typeIds= [|  |]; description= "" } |> Some
      | 2132 -> { MarketGroupData.id= 2132; name= "Gallente"; parentMarketGroupId= Some(2125); typeIds= [| 37483 |]; description= "" } |> Some
      | 2229 -> { MarketGroupData.id= 2229; name= "Guided Bomb Launchers"; parentMarketGroupId= Some(2209); typeIds= [| 35923; 47325 |]; description= "" } |> Some
      | 2520 -> { MarketGroupData.id= 2520; name= "Precursor Destroyers"; parentMarketGroupId= Some(1989); typeIds= [|  |]; description= "Precursor Destroyers" } |> Some
      | 289 -> { MarketGroupData.id= 289; name= "Large"; parentMarketGroupId= Some(286); typeIds= [| 1122; 1123; 1124; 1125; 1126; 12355 |]; description= "Blueprints of large hybrid turrets." } |> Some
      | 353563 -> { MarketGroupData.id= 353563; name= "Dropsuit Equipment"; parentMarketGroupId= Some(353562); typeIds= [|  |]; description= "Deployable and handheld equipment used by infantry" } |> Some
      | 354339 -> { MarketGroupData.id= 354339; name= "Anti-Vehicle Grenades"; parentMarketGroupId= Some(353557); typeIds= [|  |]; description= "" } |> Some
      | 363457 -> { MarketGroupData.id= 363457; name= "Light"; parentMarketGroupId= Some(363442); typeIds= [|  |]; description= "Lightweight shield extenders add a moderate amount of shield hit points with less cost to CPU and power grid usage." } |> Some
      | 366173 -> { MarketGroupData.id= 366173; name= "Dropsuits"; parentMarketGroupId= Some(365996); typeIds= [|  |]; description= "" } |> Some
      | 366755 -> { MarketGroupData.id= 366755; name= "Prototype"; parentMarketGroupId= Some(366752); typeIds= [|  |]; description= "Prototype." } |> Some
      | 483 -> { MarketGroupData.id= 483; name= "Silos"; parentMarketGroupId= Some(1285); typeIds= [| 25280; 14343; 25270; 25271; 25821; 17982; 30655 |]; description= "For storing or providing resources, or regulating material flow in industrial processes. " } |> Some
      | 580 -> { MarketGroupData.id= 580; name= "Cruise Missiles"; parentMarketGroupId= Some(114); typeIds= [|  |]; description= "Lifting-wing, jet-propelled guided missiles with heavy payloads." } |> Some
      | 677 -> { MarketGroupData.id= 677; name= "Electronic Counter Measures"; parentMarketGroupId= Some(657); typeIds= [|  |]; description= "Designed to disrupt and lock down enemy ships' sensor arrays." } |> Some
      | 774 -> { MarketGroupData.id= 774; name= "Extra Large"; parentMarketGroupId= Some(558); typeIds= [| 41104; 41067; 3559; 41064; 41065; 37290; 41063; 41100; 41101; 41102; 41103; 37296; 37297; 37298; 41099; 20444; 41066 |]; description= "Capital ship pulse lasers, for use on dreadnoughts and titans." } |> Some
      | 871 -> { MarketGroupData.id= 871; name= "Small"; parentMarketGroupId= Some(853); typeIds= [| 12563; 12565 |]; description= "Small advanced pulse laser crystals, for use with frigate-sized lasers." } |> Some
      | 968 -> { MarketGroupData.id= 968; name= "Heavy Assault Missiles"; parentMarketGroupId= Some(114); typeIds= [|  |]; description= "Jet-propelled projectiles for heavy assault launchers." } |> Some
      | _ -> None