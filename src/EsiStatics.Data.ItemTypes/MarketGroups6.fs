namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups6=
    let getMarketGroup id = 
      match id with 
      | 103 -> { MarketGroupData.id= 103; name= "Medium"; parentMarketGroupId= Some(851); typeIds= [| 247; 248; 249; 250; 251; 252; 253; 254 |]; description= "Medium frequency crystals, for use with cruiser-sized lasers." } |> Some
      | 1073 -> { MarketGroupData.id= 1073; name= "Gallente"; parentMarketGroupId= Some(1070); typeIds= [| 12021 |]; description= "Gallente heavy interdiction cruiser designs." } |> Some
      | 1267 -> { MarketGroupData.id= 1267; name= "Small Shield Rigs"; parentMarketGroupId= Some(954); typeIds= [| 31777; 31717; 31753; 31789; 31729; 31765; 31817; 31801; 31741 |]; description= "Blueprints of Small Shield Rigs." } |> Some
      | 1364 -> { MarketGroupData.id= 1364; name= "Advanced Frigates"; parentMarketGroupId= Some(1361); typeIds= [|  |]; description= "Frigate variants intended for specialized purposes." } |> Some
      | 1558 -> { MarketGroupData.id= 1558; name= "Capacitor Batteries"; parentMarketGroupId= Some(1546); typeIds= [| 41640; 1186; 2019; 2021; 41639 |]; description= "Capacitor Batteries" } |> Some
      | 1849 -> { MarketGroupData.id= 1849; name= "Reaction Formulas"; parentMarketGroupId= Some(2); typeIds= [|  |]; description= "Chemical reactions used in Refineries to create many useful materials, as well as various booster drugs" } |> Some
      | 2043 -> { MarketGroupData.id= 2043; name= "Assault Frigates"; parentMarketGroupId= Some(2042); typeIds= [|  |]; description= "" } |> Some
      | 2140 -> { MarketGroupData.id= 2140; name= "Minmatar"; parentMarketGroupId= Some(2136); typeIds= [| 48498; 45946; 40516; 40325; 46887 |]; description= "" } |> Some
      | 2237 -> { MarketGroupData.id= 2237; name= "Fighters"; parentMarketGroupId= Some(357); typeIds= [|  |]; description= "" } |> Some
      | 2334 -> { MarketGroupData.id= 2334; name= "ORE"; parentMarketGroupId= Some(2333); typeIds= [| 43910; 28607 |]; description= "Blueprints of ORE industrial command ship designs." } |> Some
      | 2431 -> { MarketGroupData.id= 2431; name= "Precursor Turrets"; parentMarketGroupId= Some(10); typeIds= [|  |]; description= "Precursor Turrets" } |> Some
      | 297 -> { MarketGroupData.id= 297; name= "Medium"; parentMarketGroupId= Some(287); typeIds= [| 824; 825; 826; 827; 828 |]; description= "Blueprints of medium projectile turrets." } |> Some
      | 353571 -> { MarketGroupData.id= 353571; name= "Swarm Launchers"; parentMarketGroupId= Some(364047); typeIds= [|  |]; description= "Swarm launchers." } |> Some
      | 354347 -> { MarketGroupData.id= 354347; name= "Standard"; parentMarketGroupId= Some(353570); typeIds= [|  |]; description= "" } |> Some
      | 354444 -> { MarketGroupData.id= 354444; name= "Armor Plates"; parentMarketGroupId= Some(353588); typeIds= [|  |]; description= "" } |> Some
      | 363465 -> { MarketGroupData.id= 363465; name= "Advanced"; parentMarketGroupId= Some(354338); typeIds= [|  |]; description= "Advanced" } |> Some
      | 364047 -> { MarketGroupData.id= 364047; name= "Light"; parentMarketGroupId= Some(353567); typeIds= [|  |]; description= "Light handheld weapons." } |> Some
      | 366181 -> { MarketGroupData.id= 366181; name= "Weapons"; parentMarketGroupId= Some(365999); typeIds= [|  |]; description= "" } |> Some
      | 366278 -> { MarketGroupData.id= 366278; name= "Prototype"; parentMarketGroupId= Some(366275); typeIds= [|  |]; description= "" } |> Some
      | 394 -> { MarketGroupData.id= 394; name= "Minmatar"; parentMarketGroupId= Some(391); typeIds= [| 11132 |]; description= "Minmatar shuttle designs." } |> Some
      | 491 -> { MarketGroupData.id= 491; name= "Narcotics"; parentMarketGroupId= Some(19); typeIds= [| 3713; 3818; 3820; 3822; 3824; 3826; 3703; 3705; 3707; 3709; 3711 |]; description= "Illegal substances that alter brain chemistry, for good or ill. Transport with caution" } |> Some
      | 588 -> { MarketGroupData.id= 588; name= "Battlecruisers"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of battlecruiser-class vessels." } |> Some
      | 6 -> { MarketGroupData.id= 6; name= "Standard Cruisers"; parentMarketGroupId= Some(1367); typeIds= [|  |]; description= "The middle children of the starship industry, but not to be underestimated." } |> Some
      | 685 -> { MarketGroupData.id= 685; name= "ECCM"; parentMarketGroupId= Some(657); typeIds= [|  |]; description= "Auxiliary systems giving a boost to sensor strength for a short time." } |> Some
      | 782 -> { MarketGroupData.id= 782; name= "Dreadnoughts"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of dreadnought-class vessels." } |> Some
      | 879 -> { MarketGroupData.id= 879; name= "Carriers"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of carrier- and mothership-class vessels." } |> Some
      | _ -> None