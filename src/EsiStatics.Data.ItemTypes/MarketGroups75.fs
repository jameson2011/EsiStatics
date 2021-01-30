namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups75=
    let getMarketGroup id = 
      match id with 
      | 1045 -> { MarketGroupData.id= 1045; name= "Capital Industrial Ships"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of Capital Industrial Ships." } |> Some
      | 1142 -> { MarketGroupData.id= 1142; name= "Minmatar"; parentMarketGroupId= Some(1138); typeIds= [| 29990 |]; description= "Minmatar strategic cruiser designs." } |> Some
      | 1239 -> { MarketGroupData.id= 1239; name= "Large Projectile Weapon Rigs"; parentMarketGroupId= Some(979); typeIds= [| 26048; 26432; 26434; 26424; 26430; 26038; 26040; 26042; 26428; 26046 |]; description= "Modifications that affect a large starship's projectile weapons." } |> Some
      | 1336 -> { MarketGroupData.id= 1336; name= "Specialized Planetary Materials"; parentMarketGroupId= Some(1332); typeIds= [| 17136; 12836; 9846; 2344; 2345; 2346; 2348; 2349; 28974; 2351; 2352; 9848; 2354; 17392; 2358; 17898; 2360; 2361; 9834; 2366; 2367 |]; description= "The fourth tier of planetary materials." } |> Some
      | 1530 -> { MarketGroupData.id= 1530; name= "Combat Drones"; parentMarketGroupId= Some(357); typeIds= [|  |]; description= "Combat Drones" } |> Some
      | 1627 -> { MarketGroupData.id= 1627; name= "Gallente Subsystems"; parentMarketGroupId= Some(1112); typeIds= [|  |]; description= "Gallente Subsystems" } |> Some
      | 1724 -> { MarketGroupData.id= 1724; name= "Capital Engineering Rigs"; parentMarketGroupId= Some(949); typeIds= [| 31363; 43908; 31399; 31375; 31411; 33304; 31387; 31231 |]; description= "Blueprints of Capital Energy Grid Rigs." } |> Some
      | 1918 -> { MarketGroupData.id= 1918; name= "R.A.M."; parentMarketGroupId= Some(800); typeIds= [| 11872; 11873; 11891; 11887; 11889; 11890; 11859; 11870 |]; description= "" } |> Some
      | 2015 -> { MarketGroupData.id= 2015; name= "Sovereignty and Infrastructure"; parentMarketGroupId= Some(1338); typeIds= [|  |]; description= "" } |> Some
      | 2112 -> { MarketGroupData.id= 2112; name= "Gallente"; parentMarketGroupId= Some(2109); typeIds= [| 45664; 46560; 44932; 55621; 42185; 36397; 37581; 46960; 47536; 45914; 52749; 46426 |]; description= "" } |> Some
      | 2209 -> { MarketGroupData.id= 2209; name= "Structure Weapons"; parentMarketGroupId= Some(2202); typeIds= [|  |]; description= "" } |> Some
      | 2306 -> { MarketGroupData.id= 2306; name= "Corvettes"; parentMarketGroupId= Some(1954); typeIds= [|  |]; description= "" } |> Some
      | 2403 -> { MarketGroupData.id= 2403; name= "Composite Reaction Formulas"; parentMarketGroupId= Some(1849); typeIds= [| 46208; 46209; 46210; 46211; 46212; 46213; 46214; 46215; 46216; 46217; 46218; 46166; 46167; 46168; 46169; 46170; 46171; 46172; 46173; 46174; 46175; 46176; 46177; 46178; 46179; 46180; 46181; 46182; 46183; 46184; 46185; 46186; 46187; 46188; 46189; 46190; 46191; 46192; 46193; 46194; 46195; 46196; 46197; 46198; 46199; 46200; 46201; 46202; 46203; 46204; 46205; 46206; 46207 |]; description= "Reaction formulas that enable the creation of Tech 2 construction materials in Refineries" } |> Some
      | 2500 -> { MarketGroupData.id= 2500; name= "Crash"; parentMarketGroupId= Some(2490); typeIds= [| 10152; 28672; 9947; 10151 |]; description= "Crash Boosters" } |> Some
      | 366 -> { MarketGroupData.id= 366; name= "Drones"; parentMarketGroupId= Some(150); typeIds= [| 22541; 23566; 12305; 23069; 33699; 24613; 23594; 43702; 24241; 23606; 43703; 23618; 12484; 12485; 12486; 12487; 57164; 32339; 3436; 3437; 3438; 3439; 3440; 3441; 3442; 40572; 40573 |]; description= "Skills pertaining to the efficient operation of drones" } |> Some
      | 463 -> { MarketGroupData.id= 463; name= "Minmatar"; parentMarketGroupId= Some(458); typeIds= [| 11401; 11372 |]; description= "Blueprints of Minmatar assault frigate designs." } |> Some
      | 560 -> { MarketGroupData.id= 560; name= "Artillery Cannons"; parentMarketGroupId= Some(87); typeIds= [|  |]; description= "Slow-firing long-range cannons, able to deal crippling blows with great economy." } |> Some
      | 657 -> { MarketGroupData.id= 657; name= "Electronic Warfare"; parentMarketGroupId= Some(9); typeIds= [|  |]; description= "Modules that can disrupt capabilities of enemy targets and defend against same" } |> Some
      | 75 -> { MarketGroupData.id= 75; name= "Caldari"; parentMarketGroupId= Some(6); typeIds= [| 632; 620; 621; 623 |]; description= "Caldari cruiser designs." } |> Some
      | 754 -> { MarketGroupData.id= 754; name= "Political Paraphernalia"; parentMarketGroupId= Some(19); typeIds= [| 32099; 19461; 19462; 19463; 17754; 17755; 17756 |]; description= "Political propaganda and those that engage in it" } |> Some
      | 851 -> { MarketGroupData.id= 851; name= "Standard Crystals"; parentMarketGroupId= Some(101); typeIds= [|  |]; description= "The standard in energy beam frequenzy modulation." } |> Some
      | 948 -> { MarketGroupData.id= 948; name= "Electronics Superiority Rigs"; parentMarketGroupId= Some(943); typeIds= [|  |]; description= "Permanent modification of a ship's electronics superiority facilities." } |> Some
      | _ -> None