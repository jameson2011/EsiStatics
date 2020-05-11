namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups20=
    let getMarketGroup id = 
      match id with 
      | 1087 -> { MarketGroupData.id= 1087; name= "Overdrives"; parentMarketGroupId= Some(132); typeIds= [| 15812; 1192; 14126; 21491; 1236; 1244; 5631 |]; description= "Ship systems that add more raw power to the ship's engines." } |> Some
      | 117 -> { MarketGroupData.id= 117; name= "Light Missiles"; parentMarketGroupId= Some(114); typeIds= [|  |]; description= "Jet-propelled projectiles for standard-sized launchers." } |> Some
      | 1378 -> { MarketGroupData.id= 1378; name= "Faction Battleships"; parentMarketGroupId= Some(1376); typeIds= [|  |]; description= "Battleships designed by specific factions." } |> Some
      | 1475 -> { MarketGroupData.id= 1475; name= "Fleet Support Implants"; parentMarketGroupId= Some(531); typeIds= [|  |]; description= "Fleet Support Implants" } |> Some
      | 1572 -> { MarketGroupData.id= 1572; name= "Warp Disruption Field Generators"; parentMarketGroupId= Some(1566); typeIds= [| 28655 |]; description= "Warp Disruption Field Generators" } |> Some
      | 1669 -> { MarketGroupData.id= 1669; name= "Layered Plating"; parentMarketGroupId= Some(14); typeIds= [| 1272; 16345; 1274; 16347; 1276; 16349; 16351 |]; description= "Layered Plating" } |> Some
      | 1766 -> { MarketGroupData.id= 1766; name= "Implant Slot 08"; parentMarketGroupId= Some(1761); typeIds= [| 3274; 3275; 3276; 13233; 27227; 27229 |]; description= "Implant Slot 08" } |> Some
      | 1863 -> { MarketGroupData.id= 1863; name= "Salvaged Materials"; parentMarketGroupId= Some(1861); typeIds= [| 25600; 25601; 25602; 25603; 25604; 25605; 25606; 25607; 25608; 25609; 25610; 25611; 25612; 25613; 25614; 25615; 25616; 25617; 25618; 25619; 25620; 25621; 25622; 25623; 25624; 25625; 25588; 25589; 25590; 25591; 25592; 25593; 25594; 25595; 25596; 25597; 25598; 25599 |]; description= "Materials salvaged from destroyed starships." } |> Some
      | 1960 -> { MarketGroupData.id= 1960; name= "Battleships"; parentMarketGroupId= Some(1954); typeIds= [|  |]; description= "" } |> Some
      | 20 -> { MarketGroupData.id= 20; name= "Industrial Goods"; parentMarketGroupId= Some(19); typeIds= [| 41024; 33539; 41025; 40456; 17893; 12302; 41027; 41028; 41029; 30497; 41; 16686; 3643; 3773; 41023; 2368; 2369; 41026; 2371; 11588; 2373; 2374; 2375; 2376; 2377; 40549; 40548; 17894; 3685; 9826; 15331; 3812; 3771; 3814; 3687; 17897; 17895; 15353; 40701 |]; description= "Various products used in a variety of industries" } |> Some
      | 2057 -> { MarketGroupData.id= 2057; name= "Gallente"; parentMarketGroupId= Some(2045); typeIds= [| 44899; 42157; 37557; 45881; 46393; 36378; 46933 |]; description= "" } |> Some
      | 214 -> { MarketGroupData.id= 214; name= "Hull & Armor "; parentMarketGroupId= Some(209); typeIds= [|  |]; description= "Blueprints of hull and armor systems." } |> Some
      | 2154 -> { MarketGroupData.id= 2154; name= "Stasis Grapplers"; parentMarketGroupId= Some(657); typeIds= [| 41056; 41057; 41058; 41059; 41040; 41054; 41055 |]; description= "Stasis Grapplers" } |> Some
      | 2251 -> { MarketGroupData.id= 2251; name= "Capital"; parentMarketGroupId= Some(662); typeIds= [| 40665; 40666; 40667; 40668; 40669; 40670 |]; description= "Capital-sized energy nosferatu." } |> Some
      | 2348 -> { MarketGroupData.id= 2348; name= "Large Structure Engineering Rigs"; parentMarketGroupId= Some(2340); typeIds= [| 45641; 37164; 37165; 37166; 37167; 37168; 37169; 37170; 37171; 37172; 37173; 37174; 37175; 43707; 43708; 43709; 43711; 43712; 43713; 43714; 43715; 43716; 43717; 43718; 43719; 43720; 43721; 43722; 43723; 43724; 43725; 43726; 43727; 43729; 43730; 45546 |]; description= "Large Structure Engineering Rigs" } |> Some
      | 2445 -> { MarketGroupData.id= 2445; name= "Large Armor Mutaplasmids"; parentMarketGroupId= Some(2437); typeIds= [| 47776; 47845; 47816; 47818; 47819; 47774; 47775 |]; description= "Large Armor Mutaplasmids" } |> Some
      | 353585 -> { MarketGroupData.id= 353585; name= "Engineering"; parentMarketGroupId= Some(353579); typeIds= [|  |]; description= "" } |> Some
      | 354458 -> { MarketGroupData.id= 354458; name= "Power Grid Upgrades"; parentMarketGroupId= Some(353590); typeIds= [|  |]; description= "" } |> Some
      | 356980 -> { MarketGroupData.id= 356980; name= "Advanced"; parentMarketGroupId= Some(353613); typeIds= [|  |]; description= "" } |> Some
      | 408 -> { MarketGroupData.id= 408; name= "Interceptors"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of interceptor-class vessels." } |> Some
      | 505 -> { MarketGroupData.id= 505; name= "XL Torpedoes"; parentMarketGroupId= Some(114); typeIds= [|  |]; description= "The most powerful missiles to be found anywhere." } |> Some
      | 602 -> { MarketGroupData.id= 602; name= "Medium"; parentMarketGroupId= Some(128); typeIds= [| 8579; 41481; 19141; 19147; 8583; 8585; 19143; 3596; 19149; 3598; 19151; 19145 |]; description= "Cruiser-sized shield transport units." } |> Some
      | 699 -> { MarketGroupData.id= 699; name= "Small"; parentMarketGroupId= Some(668); typeIds= [| 15780; 14184; 14186; 20555; 3566; 5007; 3568; 5009; 5011; 5013; 15772; 23807 |]; description= "Frigate-sized capacitor boosters." } |> Some
      | 796 -> { MarketGroupData.id= 796; name= "Standard Capital Ship Components"; parentMarketGroupId= Some(800); typeIds= [| 21024; 24546; 21026; 21028; 21030; 21036; 21042; 21038; 24557; 21040; 24561; 21010; 21012; 21014; 24548; 21018; 24559; 21020; 21022 |]; description= "Blueprints of Capital Ship Components." } |> Some
      | 893 -> { MarketGroupData.id= 893; name= "Caldari"; parentMarketGroupId= Some(880); typeIds= [| 22465 |]; description= "Blueprints of Caldari interdictor designs." } |> Some
      | 990 -> { MarketGroupData.id= 990; name= "Faction Charges"; parentMarketGroupId= Some(100); typeIds= [|  |]; description= "Enhanced ammunition designed and manufactured by the factions of New Eden" } |> Some
      | _ -> None