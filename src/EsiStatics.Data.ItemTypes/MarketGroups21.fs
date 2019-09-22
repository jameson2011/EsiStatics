namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups21=
    let getMarketGroup id = 
      match id with 
      | 1088 -> { MarketGroupData.id= 1088; name= "Warp Core Stabilizers"; parentMarketGroupId= Some(132); typeIds= [| 16297; 16299; 16301; 16303; 10998; 11640; 22875; 22877 |]; description= "Ship systems that help to keep the warp drive operational, despite interference." } |> Some
      | 118 -> { MarketGroupData.id= 118; name= "Rockets"; parentMarketGroupId= Some(114); typeIds= [|  |]; description= "Hundreds of tiny bites will wear away even the toughest opponent." } |> Some
      | 1282 -> { MarketGroupData.id= 1282; name= "Strategic Upgrades"; parentMarketGroupId= Some(1276); typeIds= [| 2008; 2001; 32422; 2009 |]; description= "Strategic upgrades to sovereignty structures." } |> Some
      | 1379 -> { MarketGroupData.id= 1379; name= "Navy Faction"; parentMarketGroupId= Some(1378); typeIds= [| 17728; 17732; 32305; 32307; 32309; 32311; 17636; 17726 |]; description= "Navy faction battleship designs." } |> Some
      | 1476 -> { MarketGroupData.id= 1476; name= "Missile Implants"; parentMarketGroupId= Some(531); typeIds= [|  |]; description= "Missile Implants" } |> Some
      | 1670 -> { MarketGroupData.id= 1670; name= "Adaptive Resistance Plating"; parentMarketGroupId= Some(540); typeIds= [| 1302; 14856; 14858; 14860; 17549; 14862; 14864; 14866; 14868; 14870; 1304; 1306; 16305; 18704; 13999; 14001; 14003; 16309; 16311; 15164; 15166; 15168; 15170; 18700; 15693; 18768; 18702; 15703; 18779; 14556; 14560; 14049; 18710; 18789; 28520; 17514; 18706; 18708; 16307 |]; description= "Adaptive Resistance Plating" } |> Some
      | 1767 -> { MarketGroupData.id= 1767; name= "Implant Slot 10"; parentMarketGroupId= Some(1762); typeIds= [| 22534; 22535; 22570; 22571; 27149; 27150; 27151; 27102; 27103 |]; description= "Implant Slot 10" } |> Some
      | 1864 -> { MarketGroupData.id= 1864; name= "Construction Platforms"; parentMarketGroupId= Some(1021); typeIds= [|  |]; description= "Outpost Construction Platforms" } |> Some
      | 1961 -> { MarketGroupData.id= 1961; name= "Faction Battleships"; parentMarketGroupId= Some(1960); typeIds= [|  |]; description= "" } |> Some
      | 2058 -> { MarketGroupData.id= 2058; name= "Minmatar"; parentMarketGroupId= Some(2045); typeIds= [| 46884; 36808; 36428; 48495; 45943; 36761; 40477 |]; description= "" } |> Some
      | 2155 -> { MarketGroupData.id= 2155; name= "Named Components"; parentMarketGroupId= Some(533); typeIds= [| 41312; 41263; 41264; 41265; 41266; 41267; 41268; 41269; 41302; 41303; 41304; 41305; 41306; 41307; 41308; 41309; 41310; 41311 |]; description= "" } |> Some
      | 2252 -> { MarketGroupData.id= 2252; name= "Extra Large"; parentMarketGroupId= Some(846); typeIds= [| 41320; 41318 |]; description= "Fired by dreadnaught-sized guns and stationary defense systems." } |> Some
      | 2349 -> { MarketGroupData.id= 2349; name= "X-Large Structure Engineering Rigs"; parentMarketGroupId= Some(2340); typeIds= [| 45548; 43704; 43705; 37178; 37179; 37180; 37181; 37182; 37183 |]; description= "X-Large Structure Engineering Rigs" } |> Some
      | 2446 -> { MarketGroupData.id= 2446; name= "Small Shield Mutaplasmids"; parentMarketGroupId= Some(2438); typeIds= [| 47778; 47779; 47780; 47797; 47798; 47799 |]; description= "Small Shield Mutaplasmids" } |> Some
      | 312 -> { MarketGroupData.id= 312; name= "Medium"; parentMarketGroupId= Some(299); typeIds= [| 887; 888; 889; 890; 891; 892; 893; 894 |]; description= "Blueprints of medium projectile ammunition." } |> Some
      | 506 -> { MarketGroupData.id= 506; name= "Corporate Hangar Array"; parentMarketGroupId= Some(1285); typeIds= [| 17621 |]; description= "Communal hangar structures with divisional compartments." } |> Some
      | 603 -> { MarketGroupData.id= 603; name= "Small"; parentMarketGroupId= Some(128); typeIds= [| 19137; 3586; 19139; 3588; 41480; 19129; 8531; 405; 8535; 8537; 19131; 19133; 19135 |]; description= "Frigate-sized shield transport units." } |> Some
      | 700 -> { MarketGroupData.id= 700; name= "Medium"; parentMarketGroupId= Some(668); typeIds= [| 14176; 577; 14178; 4835; 4833; 2024; 23809; 20557; 15784; 15776; 4829; 4831 |]; description= "Cruiser-sized capacitor boosters." } |> Some
      | 894 -> { MarketGroupData.id= 894; name= "Gallente"; parentMarketGroupId= Some(880); typeIds= [| 22461 |]; description= "Blueprints of Gallente interdictor designs." } |> Some
      | 991 -> { MarketGroupData.id= 991; name= "Large"; parentMarketGroupId= Some(990); typeIds= [| 23041; 23043; 23045; 23047; 21740; 23051; 23053; 21416; 21418; 21420; 21422; 21424; 20913; 21426; 20915; 21428; 20917; 21430; 20919; 20921; 20923; 20925; 20927; 22993; 22995; 22997; 22999; 23001; 23003; 23005; 23007; 23049; 21352; 21354; 21356; 21358; 21360; 20977; 21362; 20979; 21364; 20981; 21366; 20983; 20985; 20987; 20989; 20991 |]; description= "Large faction issue hybrid shells, fired by battleship-sized guns." } |> Some
      | _ -> None