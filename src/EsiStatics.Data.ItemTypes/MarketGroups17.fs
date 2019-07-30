namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups17=
    let getMarketGroup id = 
      match id with 
      | 1084 -> { MarketGroupData.id= 1084; name= "Minmatar"; parentMarketGroupId= Some(1080); typeIds= [| 28665 |]; description= "Minmatar marauder designs." } |> Some
      | 114 -> { MarketGroupData.id= 114; name= "Missiles"; parentMarketGroupId= Some(11); typeIds= [|  |]; description= "Self-propelled projectiles with various payloads" } |> Some
      | 1375 -> { MarketGroupData.id= 1375; name= "Advanced Battlecruisers"; parentMarketGroupId= Some(1374); typeIds= [|  |]; description= "Advanced battlecruisers make use of advanced technology for maximum effectiveness in a certain role." } |> Some
      | 1472 -> { MarketGroupData.id= 1472; name= "Faction Omega Implants"; parentMarketGroupId= Some(531); typeIds= [|  |]; description= "Faction Omega Implants" } |> Some
      | 1666 -> { MarketGroupData.id= 1666; name= "Kinetic Resistance Plating"; parentMarketGroupId= Some(540); typeIds= [| 1282; 28547; 1284; 1286; 17551; 18712; 14872; 14874; 14876; 18714; 14878; 14880; 14882; 14884; 14886; 18740; 14005; 18742; 14007; 14009; 16315; 16317; 18752; 18754; 16327; 15691; 18770; 15701; 16313; 15196; 18781; 15198; 15200; 15202; 14051; 14564; 18791; 14568; 17512 |]; description= "Kinetic Resistance Plating" } |> Some
      | 1763 -> { MarketGroupData.id= 1763; name= "Scanning Implants"; parentMarketGroupId= Some(531); typeIds= [|  |]; description= "Scanning Implants" } |> Some
      | 1860 -> { MarketGroupData.id= 1860; name= "Polymer Materials"; parentMarketGroupId= Some(1034); typeIds= [| 30304; 30305; 30306; 30307; 30308; 30309; 30310; 30311; 30303 |]; description= "Material made from combining fullerenes." } |> Some
      | 1957 -> { MarketGroupData.id= 1957; name= "Caldari"; parentMarketGroupId= Some(2101); typeIds= [| 49153; 46850; 46851; 46852; 49800; 46731; 47629; 45846; 45847; 45848; 40607; 40608; 40609; 48550; 52401; 46377; 46123; 46124; 46125; 34609; 34610; 36659; 36660; 36661; 48189; 48190; 48191; 48834; 35150; 52559; 47312; 45015; 48217; 48730; 48225; 48729; 52285; 46714; 36731; 36732; 36733; 47615 |]; description= "" } |> Some
      | 2054 -> { MarketGroupData.id= 2054; name= "Minmatar"; parentMarketGroupId= Some(2044); typeIds= [| 46882; 46883; 36806; 36807; 36424; 48493; 48494; 36436; 45941; 45942; 36759; 36760; 40475; 40476 |]; description= "" } |> Some
      | 211 -> { MarketGroupData.id= 211; name= "Ammunition & Charges"; parentMarketGroupId= Some(2); typeIds= [|  |]; description= "Blueprints of ammunition and charges" } |> Some
      | 2151 -> { MarketGroupData.id= 2151; name= ""; parentMarketGroupId= Some(1713); typeIds= [| 37450; 37451; 37452 |]; description= "" } |> Some
      | 2248 -> { MarketGroupData.id= 2248; name= "Burst Projectors"; parentMarketGroupId= Some(1566); typeIds= [| 41388; 41389; 41390; 41391; 41392; 41393; 41394; 27679 |]; description= "" } |> Some
      | 2345 -> { MarketGroupData.id= 2345; name= "Large Structure Combat Rigs"; parentMarketGroupId= Some(2205); typeIds= [| 37248; 37249; 37250; 37251; 37254; 37255; 37256; 37257; 37258; 37259; 37260; 37261 |]; description= "Large Structure Combat Rigs" } |> Some
      | 2442 -> { MarketGroupData.id= 2442; name= "Stasis Webifier Mutaplasmids"; parentMarketGroupId= Some(2436); typeIds= [| 47699; 47700; 47701 |]; description= "Mutaplasmids that can be used on Stasis Webifier modules." } |> Some
      | 2539 -> { MarketGroupData.id= 2539; name= "Rakovene"; parentMarketGroupId= Some(54); typeIds= [| 52315 |]; description= "Rakovene" } |> Some
      | 308 -> { MarketGroupData.id= 308; name= "Medium"; parentMarketGroupId= Some(300); typeIds= [| 1138; 1139; 1140; 1141; 1142; 1143; 1144; 1145 |]; description= "Blueprints of medium hybrid ammunition." } |> Some
      | 353582 -> { MarketGroupData.id= 353582; name= "Armor"; parentMarketGroupId= Some(353579); typeIds= [|  |]; description= "" } |> Some
      | 354455 -> { MarketGroupData.id= 354455; name= "Mobile CRUs"; parentMarketGroupId= Some(353590); typeIds= [|  |]; description= "" } |> Some
      | 356977 -> { MarketGroupData.id= 356977; name= "Advanced"; parentMarketGroupId= Some(354483); typeIds= [|  |]; description= "" } |> Some
      | 363476 -> { MarketGroupData.id= 363476; name= "Corporation Management"; parentMarketGroupId= Some(363475); typeIds= [|  |]; description= "Hardwired neural augmentations used to train new abilities." } |> Some
      | 364058 -> { MarketGroupData.id= 364058; name= "Prototype"; parentMarketGroupId= Some(364055); typeIds= [|  |]; description= "Prototype." } |> Some
      | 365901 -> { MarketGroupData.id= 365901; name= "Railgun Ammo Expansion Units"; parentMarketGroupId= Some(365898); typeIds= [|  |]; description= "Railgun Ammo Expansion Units." } |> Some
      | 365998 -> { MarketGroupData.id= 365998; name= "Republic Command"; parentMarketGroupId= Some(365995); typeIds= [|  |]; description= "The Minmatar store contains items that require loyalty points from the Republic Command." } |> Some
      | 405 -> { MarketGroupData.id= 405; name= "Warp Disruption Fields "; parentMarketGroupId= Some(404); typeIds= [| 4386; 28772; 28774; 12198; 12199; 12200; 26890; 26892; 28770; 26888 |]; description= "Trap a fly in your web." } |> Some
      | 502 -> { MarketGroupData.id= 502; name= "Extra Large"; parentMarketGroupId= Some(845); typeIds= [| 17664; 17666; 17668; 17670; 17672; 17674; 17676; 17678 |]; description= "Fired by dreadnaught-sized guns and stationary defense systems." } |> Some
      | 599 -> { MarketGroupData.id= 599; name= "Extra Large"; parentMarketGroupId= Some(301); typeIds= [| 17681; 17683; 17685; 17687; 17689; 17691; 17693; 17695 |]; description= "Blueprints of capital-sized frequency crystals." } |> Some
      | 696 -> { MarketGroupData.id= 696; name= "Medium"; parentMarketGroupId= Some(663); typeIds= [| 19085; 19083; 19077; 19079; 16489; 16491; 31948; 16493; 23854; 16495; 19081; 12217; 19087; 12221 |]; description= "Cruiser-sized energy transfer arrays." } |> Some
      | 793 -> { MarketGroupData.id= 793; name= "Extra Large"; parentMarketGroupId= Some(287); typeIds= [| 41163; 41092; 41093; 41094; 41095; 41096; 41161; 41162; 20455; 41165; 41168; 41169; 41170; 41171; 20453 |]; description= "Blueprints of capital-sized projectile turrets." } |> Some
      | 890 -> { MarketGroupData.id= 890; name= "Gallente"; parentMarketGroupId= Some(879); typeIds= [| 23912; 23914 |]; description= "Blueprints of Gallente carrier and mothership designs." } |> Some
      | 987 -> { MarketGroupData.id= 987; name= "Large"; parentMarketGroupId= Some(986); typeIds= [| 21894; 21902; 21910; 21918; 28324; 21926; 28332; 21935; 20785; 20787; 20789; 20791; 20793; 20795; 20797; 20799; 20721; 20723; 20725; 20727; 20729; 20731; 20733; 20735 |]; description= "Large faction ammunition, fired by battleship-sized guns." } |> Some
      | _ -> None