namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups91=
    let getMarketGroup id = 
      match id with 
      | 1061 -> { MarketGroupData.id= 1061; name= "Medium"; parentMarketGroupId= Some(1018); typeIds= [| 4296; 27930 |]; description= "Remote hull repair system designs, intended for use on cruiser-class vessels." } |> Some
      | 1255 -> { MarketGroupData.id= 1255; name= "Small Energy Weapon Rigs"; parentMarketGroupId= Some(950); typeIds= [| 31491; 31431; 31467; 31443; 31479; 31419; 31455 |]; description= "Blueprints of Small Energy Weapon Rigs." } |> Some
      | 1352 -> { MarketGroupData.id= 1352; name= "Moon Harvesting Arrays"; parentMarketGroupId= Some(1841); typeIds= [|  |]; description= "Blueprints of Moon Harvesting Arrays." } |> Some
      | 1546 -> { MarketGroupData.id= 1546; name= "Engineering Equipment"; parentMarketGroupId= Some(209); typeIds= [|  |]; description= "Engineering Equipment" } |> Some
      | 1643 -> { MarketGroupData.id= 1643; name= "Salvage Drones"; parentMarketGroupId= Some(357); typeIds= [| 32982 |]; description= "Blueprints of salvage drone designs." } |> Some
      | 1740 -> { MarketGroupData.id= 1740; name= "Capital Astronautic Rigs"; parentMarketGroupId= Some(957); typeIds= [| 31169; 31139; 34308; 31109; 31175; 31145; 31115; 31181; 31151; 31121; 31187; 31157; 31127; 31193; 31163; 31133; 31199 |]; description= "Modifications that affect a capital starship's astronautics." } |> Some
      | 1837 -> { MarketGroupData.id= 1837; name= "Special Edition Recon Ships"; parentMarketGroupId= Some(1612); typeIds= [| 45531; 33395; 33675; 44995; 48635 |]; description= "" } |> Some
      | 2031 -> { MarketGroupData.id= 2031; name= "Pirate Faction"; parentMarketGroupId= Some(1999); typeIds= [| 43533; 47375; 47249; 46996; 46997; 44951; 46873; 47003; 47006; 49435; 47013; 48552; 49961; 45483; 47541; 46520; 44219; 53436; 47293; 53952; 45507; 37965; 46051; 54229; 45018; 52703; 44256; 46819; 35690; 37867; 53019; 53949; 52595; 49146; 49148; 47509 |]; description= "" } |> Some
      | 2322 -> { MarketGroupData.id= 2322; name= "Engineering Complexes"; parentMarketGroupId= Some(1338); typeIds= [| 36971; 36972; 36973 |]; description= "Blueprints of Engineering Complex structures." } |> Some
      | 2419 -> { MarketGroupData.id= 2419; name= "CONCORD"; parentMarketGroupId= Some(2418); typeIds= [| 47682; 47684 |]; description= "" } |> Some
      | 2516 -> { MarketGroupData.id= 2516; name= "Entropic Radiation Sink Mutaplasmids"; parentMarketGroupId= Some(2512); typeIds= [| 49736; 49737; 49735 |]; description= "" } |> Some
      | 285 -> { MarketGroupData.id= 285; name= "Amarr"; parentMarketGroupId= Some(208); typeIds= [| 1945; 19745 |]; description= "Blueprints of Amarr industrial designs." } |> Some
      | 382 -> { MarketGroupData.id= 382; name= "Small"; parentMarketGroupId= Some(141); typeIds= [| 14214; 1547; 1549; 1551; 9744; 1553; 14226; 14228; 1557; 1559; 1563; 1565; 21534; 15925; 9784; 15935; 15941; 9670; 15949; 28557; 9680; 23864; 15957; 14200; 14202 |]; description= "Frigate-sized smartbombs." } |> Some
      | 479 -> { MarketGroupData.id= 479; name= "Missile Batteries"; parentMarketGroupId= Some(480); typeIds= [| 27560; 27562; 17773; 27640; 27638; 27641; 16696; 16697; 27643 |]; description= "Stationary missile batteries for starbase defense." } |> Some
      | 576 -> { MarketGroupData.id= 576; name= "Large"; parentMarketGroupId= Some(559); typeIds= [| 2945; 14469; 14471; 2953; 14475; 9327; 9247; 9249; 9251; 9253; 2929; 21557; 14473; 16057; 16059; 16060; 9287; 9289; 9291; 9293; 34288; 13785; 13787; 13788; 494; 495; 496; 9329; 9331; 9333; 14457; 14459 |]; description= "Battleship-sized autocannons. Deal massive damage, up close and personal." } |> Some
      | 673 -> { MarketGroupData.id= 673; name= "Remote Sensor Boosters"; parentMarketGroupId= Some(656); typeIds= [| 5281; 5282; 1963; 1964; 22925; 41198; 41199; 5279 |]; description= "Augment target ship's targeting range and target acquisition time." } |> Some
      | 770 -> { MarketGroupData.id= 770; name= "Minmatar"; parentMarketGroupId= Some(766); typeIds= [| 20189 |]; description= "Minmatar freighter designs." } |> Some
      | 867 -> { MarketGroupData.id= 867; name= "Medium"; parentMarketGroupId= Some(852); typeIds= [| 12826; 12822 |]; description= "Medium advanced beam laser crystals, for use with cruiser-sized lasers." } |> Some
      | 964 -> { MarketGroupData.id= 964; name= "Missile Launcher Rigs"; parentMarketGroupId= Some(1111); typeIds= [|  |]; description= "Permanent modification of a ship's missile launcher facilities." } |> Some
      | _ -> None