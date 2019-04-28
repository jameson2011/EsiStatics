namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups84=
    let getMarketGroup id = 
      match id with 
      | 1054 -> { MarketGroupData.id= 1054; name= "Medium"; parentMarketGroupId= Some(538); typeIds= [| 21506; 3653; 3655; 5683; 5719; 5721; 5723 |]; description= "Hull repair system designs, intended for cruiser-class vessels." } |> Some
      | 1345 -> { MarketGroupData.id= 1345; name= "Energy Neutralization Batteries"; parentMarketGroupId= Some(1534); typeIds= [| 2799 |]; description= "Blueprints of Energy Neutralization Batteries." } |> Some
      | 1539 -> { MarketGroupData.id= 1539; name= "Remote Armor Repairers"; parentMarketGroupId= Some(214); typeIds= [| 11360; 41621; 41622; 41624; 24570; 11356; 11358 |]; description= "Blueprints for Remote Armor Repairers" } |> Some
      | 1733 -> { MarketGroupData.id= 1733; name= "Capital Missile Launcher Rigs"; parentMarketGroupId= Some(964); typeIds= [| 31648; 31618; 31654; 31590; 31624; 31596; 31630; 31602; 31636; 33301; 31642; 31612 |]; description= "Modifications that affect a capital starship's missile launchers." } |> Some
      | 1830 -> { MarketGroupData.id= 1830; name= "Mobile Tractor Units"; parentMarketGroupId= Some(406); typeIds= [| 33519 |]; description= "Blueprints of Mobile Tractor Units" } |> Some
      | 2024 -> { MarketGroupData.id= 2024; name= "Amarr"; parentMarketGroupId= Some(2023); typeIds= [| 49947; 42788; 45797; 46536; 44127; 48214; 37519; 46806; 34810; 36319; 42588; 43519 |]; description= "" } |> Some
      | 2218 -> { MarketGroupData.id= 2218; name= "CPU Upgrades"; parentMarketGroupId= Some(2207); typeIds= [| 47344; 35963 |]; description= "" } |> Some
      | 2315 -> { MarketGroupData.id= 2315; name= "Shuttles"; parentMarketGroupId= Some(1954); typeIds= [|  |]; description= "" } |> Some
      | 2412 -> { MarketGroupData.id= 2412; name= "Standup Heavy Fighters"; parentMarketGroupId= Some(2409); typeIds= [| 47116; 47117; 47118; 47119; 47120; 47121; 47122; 47123; 47124; 47125; 47126; 47127; 47128; 47129; 47130; 47038; 47039 |]; description= "" } |> Some
      | 2509 -> { MarketGroupData.id= 2509; name= "Mass Entanglers"; parentMarketGroupId= Some(14); typeIds= [| 49099 |]; description= "Mass Entanglers lower ship mass at the cost of ship velocity." } |> Some
      | 278 -> { MarketGroupData.id= 278; name= "Minmatar"; parentMarketGroupId= Some(207); typeIds= [| 693; 998; 24695 |]; description= "Blueprints of Minmatar battleship designs." } |> Some
      | 354425 -> { MarketGroupData.id= 354425; name= "Endurance Modifiers"; parentMarketGroupId= Some(353583); typeIds= [|  |]; description= "" } |> Some
      | 354619 -> { MarketGroupData.id= 354619; name= "Advanced"; parentMarketGroupId= Some(354616); typeIds= [|  |]; description= "" } |> Some
      | 366259 -> { MarketGroupData.id= 366259; name= "Prototype"; parentMarketGroupId= Some(366179); typeIds= [|  |]; description= "" } |> Some
      | 366744 -> { MarketGroupData.id= 366744; name= "Prototype"; parentMarketGroupId= Some(366741); typeIds= [|  |]; description= "Prototype" } |> Some
      | 375 -> { MarketGroupData.id= 375; name= "Science"; parentMarketGroupId= Some(150); typeIds= [| 11529; 12179; 21789; 21790; 21791; 11433; 23087; 24624; 11441; 11442; 11443; 11444; 11445; 11446; 11447; 11448; 11449; 11450; 11451; 11452; 11453; 11454; 11455; 30788; 3402; 3403; 3406; 3408; 3409; 23123; 23124; 24270; 23121; 11487; 20433; 30324; 30325; 30327 |]; description= "Skills pertaining to various fields of scientific knowledge" } |> Some
      | 472 -> { MarketGroupData.id= 472; name= "Gallente"; parentMarketGroupId= Some(469); typeIds= [| 24700; 4308; 16229 |]; description= "Gallente battlecruiser designs." } |> Some
      | 569 -> { MarketGroupData.id= 569; name= "Large"; parentMarketGroupId= Some(557); typeIds= [| 7169; 15874; 7171; 7045; 7047; 7049; 13834; 14423; 7043; 7173; 23848; 2985; 23850; 13831; 14451; 14421; 14453; 14433; 15863; 461; 463; 464; 14417; 7123; 7125; 7127; 7131; 15845; 13793; 13817; 14437; 14439; 15848; 3049; 15859; 14449; 14419; 15860; 13813; 14455; 3065; 13820; 14435; 7167 |]; description= "Large beam lasers, suitable for battleship use." } |> Some
      | 666 -> { MarketGroupData.id= 666; name= "Capacitor Flux Coils"; parentMarketGroupId= Some(655); typeIds= [| 1248; 8133; 8135; 23894; 509; 1246 |]; description= "Increase capacitor recharge rate while lowering maximum capacitor capacity." } |> Some
      | 763 -> { MarketGroupData.id= 763; name= "Caldari"; parentMarketGroupId= Some(761); typeIds= [| 19726 |]; description= "Caldari dreadnought designs." } |> Some
      | 84 -> { MarketGroupData.id= 84; name= "Caldari"; parentMarketGroupId= Some(8); typeIds= [| 648; 649 |]; description= "Caldari industrial designs." } |> Some
      | 860 -> { MarketGroupData.id= 860; name= "Large"; parentMarketGroupId= Some(849); typeIds= [| 12787; 12791 |]; description= "Large advanced hybrid shells, fired by battleship-sized guns." } |> Some
      | 957 -> { MarketGroupData.id= 957; name= "Astronautic Rigs"; parentMarketGroupId= Some(1111); typeIds= [|  |]; description= "Permanent modification of a ship's astronautic facilities." } |> Some
      | _ -> None