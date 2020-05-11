namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups72=
    let getMarketGroup id = 
      match id with 
      | 1139 -> { MarketGroupData.id= 1139; name= "Amarr"; parentMarketGroupId= Some(1138); typeIds= [| 29986 |]; description= "Amarr strategic cruiser designs." } |> Some
      | 1236 -> { MarketGroupData.id= 1236; name= "Large Shield Rigs"; parentMarketGroupId= Some(965); typeIds= [| 26080; 26082; 26084; 26438; 26086; 26088; 26090; 26444; 26450; 26446; 26448; 26440; 25906; 26452; 26436; 26076; 26442; 26078 |]; description= "Modifications that affect a large starship's shields." } |> Some
      | 1333 -> { MarketGroupData.id= 1333; name= "Raw Planetary Materials"; parentMarketGroupId= Some(1332); typeIds= [| 2272; 2305; 2306; 2307; 2308; 2309; 2310; 2311; 2286; 2287; 2288; 2073; 2267; 2268; 2270 |]; description= "The first tier of planetary materials." } |> Some
      | 1527 -> { MarketGroupData.id= 1527; name= "Heavy Missiles"; parentMarketGroupId= Some(314); typeIds= [| 808; 809; 810; 807 |]; description= "Heavy Missiles" } |> Some
      | 1624 -> { MarketGroupData.id= 1624; name= "Special Edition Logistics"; parentMarketGroupId= Some(1612); typeIds= [| 42245; 32790 |]; description= "Logistics Ships which have been offered to capsuleers on occasion for limited periods." } |> Some
      | 1721 -> { MarketGroupData.id= 1721; name= "Capital Drone Rigs"; parentMarketGroupId= Some(946); typeIds= [| 33312; 33282; 33286; 33290; 33294; 33299; 33308; 33278 |]; description= "Blueprints of Capital Drone Rigs." } |> Some
      | 1818 -> { MarketGroupData.id= 1818; name= "Gallente"; parentMarketGroupId= Some(1815); typeIds= [| 606 |]; description= "Gallente rookie ship designs." } |> Some
      | 2012 -> { MarketGroupData.id= 2012; name= "Exhumers"; parentMarketGroupId= Some(2011); typeIds= [| 43782; 43783; 43784; 42647; 46988; 46989; 46738; 43795; 43796; 43669; 43670; 43671; 42648; 42649; 43808; 43809; 43810; 44069; 44070; 44072; 46740; 43847; 43821; 43822; 43823; 43848; 42677; 42678; 42679; 43834; 43835; 43836; 46987; 34758; 34759; 34760; 43849; 43755; 43756; 43757; 46739; 43768; 43769; 43770; 42620; 42621; 42622; 43797 |]; description= "" } |> Some
      | 2109 -> { MarketGroupData.id= 2109; name= "Black Ops"; parentMarketGroupId= Some(2022); typeIds= [|  |]; description= "" } |> Some
      | 2206 -> { MarketGroupData.id= 2206; name= "Electronic Warfare"; parentMarketGroupId= Some(2202); typeIds= [|  |]; description= "" } |> Some
      | 2400 -> { MarketGroupData.id= 2400; name= "Rare Moon Ores"; parentMarketGroupId= Some(2395); typeIds= [| 45504; 46304; 45506; 46307; 46308; 46309; 46310; 46305; 46311; 46306; 45502; 45503 |]; description= "" } |> Some
      | 2497 -> { MarketGroupData.id= 2497; name= "Frentix"; parentMarketGroupId= Some(2489); typeIds= [| 28678; 15460; 15461; 15462 |]; description= "Frentix Boosters" } |> Some
      | 355189 -> { MarketGroupData.id= 355189; name= "Prototype"; parentMarketGroupId= Some(355181); typeIds= [|  |]; description= "" } |> Some
      | 364889 -> { MarketGroupData.id= 364889; name= "Basic"; parentMarketGroupId= Some(364045); typeIds= [|  |]; description= "Basic medium frame dropsuits." } |> Some
      | 365277 -> { MarketGroupData.id= 365277; name= "Prototype"; parentMarketGroupId= Some(365272); typeIds= [|  |]; description= "Prototype pilot dropsuits." } |> Some
      | 365374 -> { MarketGroupData.id= 365374; name= "Item Bundles"; parentMarketGroupId= Some(367566); typeIds= [|  |]; description= "" } |> Some
      | 557 -> { MarketGroupData.id= 557; name= "Beam Lasers"; parentMarketGroupId= Some(88); typeIds= [|  |]; description= "Beam lasers fire a concentrated, persistent stream of energy at their target." } |> Some
      | 72 -> { MarketGroupData.id= 72; name= "Amarr"; parentMarketGroupId= Some(5); typeIds= [| 29248; 589; 590; 591; 2161; 597 |]; description= "Amarr frigate designs." } |> Some
      | 751 -> { MarketGroupData.id= 751; name= "Overseer's Personal Effects"; parentMarketGroupId= Some(614); typeIds= [| 19400; 19401; 19402; 19403; 19404; 19405; 19406; 19407; 19408; 19409; 19410; 19411; 19412; 19413; 19414; 19415; 19416; 19417; 19418; 19419; 19420; 19421; 19422 |]; description= "Proof that there's one less evil bastard in the world." } |> Some
      | 848 -> { MarketGroupData.id= 848; name= "Standard Charges"; parentMarketGroupId= Some(100); typeIds= [|  |]; description= "Standard hybrid slugs." } |> Some
      | 945 -> { MarketGroupData.id= 945; name= "Astronautic Rigs"; parentMarketGroupId= Some(943); typeIds= [|  |]; description= "Permanent modification of a ship's astronautic facilities." } |> Some
      | _ -> None