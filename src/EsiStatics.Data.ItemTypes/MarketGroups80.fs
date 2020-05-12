namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups80=
    let getMarketGroup id = 
      match id with 
      | 1050 -> { MarketGroupData.id= 1050; name= "Medium"; parentMarketGroupId= Some(134); typeIds= [| 15745; 28549; 13958; 13959; 13960; 17547; 33101; 4569; 3528; 19017; 3530; 19019; 19021; 19023; 19025; 19027; 17493; 19031; 19033; 4573; 22889; 14068; 23797; 15742; 19029 |]; description= "Armor repair designs, intended for cruiser-class vessels." } |> Some
      | 1147 -> { MarketGroupData.id= 1147; name= "Subsystem Components"; parentMarketGroupId= Some(1035); typeIds= [| 30464; 30466; 30470; 29992; 30476; 29994; 33195; 29996; 30478; 30002; 45652; 45653; 45654; 45655; 30008; 34396; 30474 |]; description= "The building blocks of advanced subsystems." } |> Some
      | 1244 -> { MarketGroupData.id= 1244; name= "Medium Drone Rigs"; parentMarketGroupId= Some(946); typeIds= [| 32036; 32072; 32028; 32044; 32052; 32092; 32084; 32060 |]; description= "Blueprints of Medium Drone Rigs." } |> Some
      | 1341 -> { MarketGroupData.id= 1341; name= "Corporate Hangar Arrays"; parentMarketGroupId= Some(1841); typeIds= [| 2787 |]; description= "Blueprints of Corporate Hangar Arrays." } |> Some
      | 1535 -> { MarketGroupData.id= 1535; name= "Ship Maintenance Arrays"; parentMarketGroupId= Some(1841); typeIds= [| 2752; 2750 |]; description= "Ship Maintenance Arrays" } |> Some
      | 1729 -> { MarketGroupData.id= 1729; name= "Capital Shield Rigs"; parentMarketGroupId= Some(954); typeIds= [| 31745; 31781; 31721; 31757; 31821; 31793; 31733; 31769; 31805 |]; description= "Blueprints of Capital Shield Rigs." } |> Some
      | 1923 -> { MarketGroupData.id= 1923; name= "PLEX"; parentMarketGroupId= Some(1922); typeIds= [| 44992 |]; description= "PLEX is an item that can be traded between players on the regional market. PLEX can also be used in the New Eden Store to upgrade your account to Omega Clone State,  purchase virtual goods, and activate other account services." } |> Some
      | 2020 -> { MarketGroupData.id= 2020; name= "Entosis Links"; parentMarketGroupId= Some(1710); typeIds= [| 34594 |]; description= "Entosis Link Blueprints" } |> Some
      | 2214 -> { MarketGroupData.id= 2214; name= "Target Painters"; parentMarketGroupId= Some(2206); typeIds= [| 35947; 47366 |]; description= "" } |> Some
      | 2311 -> { MarketGroupData.id= 2311; name= "Special Battlecruisers"; parentMarketGroupId= Some(1955); typeIds= [|  |]; description= "" } |> Some
      | 2408 -> { MarketGroupData.id= 2408; name= "Structure Burst Projectors"; parentMarketGroupId= Some(2206); typeIds= [| 47072; 47073; 47074; 35944; 47069; 47070; 47071 |]; description= "" } |> Some
      | 2505 -> { MarketGroupData.id= 2505; name= "Pyrolancea"; parentMarketGroupId= Some(2502); typeIds= [| 46000; 48115; 45998; 45999 |]; description= "Pyrolancea Boosters" } |> Some
      | 274 -> { MarketGroupData.id= 274; name= "Amarr"; parentMarketGroupId= Some(206); typeIds= [| 969; 970; 973; 2007 |]; description= "Blueprints of Amarr cruiser designs." } |> Some
      | 363442 -> { MarketGroupData.id= 363442; name= "Shield Extenders"; parentMarketGroupId= Some(353587); typeIds= [|  |]; description= " " } |> Some
      | 365770 -> { MarketGroupData.id= 365770; name= "Standard"; parentMarketGroupId= Some(365769); typeIds= [|  |]; description= "Standard." } |> Some
      | 366255 -> { MarketGroupData.id= 366255; name= "Prototype"; parentMarketGroupId= Some(366190); typeIds= [|  |]; description= "" } |> Some
      | 366352 -> { MarketGroupData.id= 366352; name= "Faction Booster Minmatar"; parentMarketGroupId= Some(354534); typeIds= [|  |]; description= "" } |> Some
      | 468 -> { MarketGroupData.id= 468; name= "Minmatar"; parentMarketGroupId= Some(464); typeIds= [| 16242; 32878 |]; description= "Minmatar destroyer designs." } |> Some
      | 565 -> { MarketGroupData.id= 565; name= "Medium"; parentMarketGroupId= Some(555); typeIds= [| 3082; 7327; 7329; 3106; 7331; 7333; 15815; 13868; 13870; 13872; 13873; 567; 13880; 13881; 570; 14272; 14274; 14276; 14278; 7367; 7369; 7371; 15820; 7373; 15821; 12344; 15835; 12346; 15840; 15841; 20589 |]; description= "Medium-sized railguns, for use on cruisers." } |> Some
      | 662 -> { MarketGroupData.id= 662; name= "Energy Nosferatu"; parentMarketGroupId= Some(655); typeIds= [|  |]; description= "Steal a portion of the target ship's capacitor energy." } |> Some
      | 80 -> { MarketGroupData.id= 80; name= "Caldari"; parentMarketGroupId= Some(7); typeIds= [| 640; 24688; 638 |]; description= "Caldari battleship designs." } |> Some
      | 856 -> { MarketGroupData.id= 856; name= "Small"; parentMarketGroupId= Some(846); typeIds= [| 12633; 12631 |]; description= "Small ADAR ammunition, fired by frigate-sized guns." } |> Some
      | 953 -> { MarketGroupData.id= 953; name= "Projectile Weapon Rigs"; parentMarketGroupId= Some(943); typeIds= [|  |]; description= "Permanent modification of a ship's projectile weapon facilities." } |> Some
      | _ -> None