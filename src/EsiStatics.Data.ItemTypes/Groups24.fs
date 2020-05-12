﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups24=
    let getGroup id = 
      match id with 
      | 1091 -> { GroupData.id= 1091; name= "Footwear"; categoryId= 30; published= true; typeIds= [| 3966; 4001; 4002; 4003; 4004; 4008; 4116; 4117; 4118; 4119; 4120; 4121; 4122; 4123; 4124; 4125; 4126; 4127; 4128; 4129; 4130; 4131; 4132; 4133; 4134; 4135; 4172; 4173; 4174; 4175; 4176; 4177; 4178; 4179; 33064; 33714; 33716; 33717; 33718; 33719; 33720; 33721; 33722; 33723; 33724; 33725; 33771; 33772; 33773; 33774; 33775; 33776; 33777; 33778; 33779; 33780; 34079; 34080; 34081; 34082; 34083; 34084; 34085; 34086; 34087; 34088; 34089; 34360; 34361; 34362; 34363; 34364; 34365; 36505; 36506; 36507; 36508; 36509; 36510; 36511; 36512; 36513; 36514; 36515; 36516; 54303; 54309 |] } |> Some
      | 121 -> { GroupData.id= 121; name= "Remote Shield Booster Blueprint"; categoryId= 9; published= true; typeIds= [| 3545; 3587; 3589; 3597; 3599; 3607; 3609; 3617; 3619; 41649; 41650; 41651; 41652; 41666; 41667; 41668; 41669; 41670; 41671 |] } |> Some
      | 1285 -> { GroupData.id= 1285; name= "Asteroid Mordus Legion Commander Frigate"; categoryId= 11; published= false; typeIds= [| 33864 |] } |> Some
      | 1673 -> { GroupData.id= 1673; name= "Missile Launcher Rapid Torpedo"; categoryId= 7; published= true; typeIds= [| 37288; 37292; 37293; 41223; 41224 |] } |> Some
      | 1770 -> { GroupData.id= 1770; name= "Command Burst"; categoryId= 7; published= true; typeIds= [| 42526; 42527; 42528; 42529; 42530; 43551; 43552; 43554; 43555; 43556 |] } |> Some
      | 1867 -> { GroupData.id= 1867; name= "Structure Engineering Rig XL - Equipment and Consumable Efficiency"; categoryId= 66; published= true; typeIds= [| 37178; 37179 |] } |> Some
      | 1964 -> { GroupData.id= 1964; name= "Mutaplasmids"; categoryId= 17; published= true; typeIds= [| 47297; 47299; 47699; 47700; 47701; 47729; 47730; 47731; 47733; 47734; 47735; 47737; 47738; 47739; 47741; 47742; 47743; 47744; 47746; 47747; 47748; 47750; 47751; 47752; 47754; 47755; 47756; 47766; 47767; 47768; 47770; 47771; 47772; 47774; 47775; 47776; 47778; 47779; 47780; 47782; 47783; 47784; 47786; 47787; 47788; 47790; 47791; 47792; 47797; 47798; 47799; 47801; 47802; 47803; 47805; 47806; 47807; 47809; 47810; 47811; 47813; 47814; 47815; 47816; 47818; 47819; 47821; 47822; 47823; 47825; 47826; 47827; 47829; 47830; 47831; 47835; 47837; 47839; 47841; 47843; 47845; 48416; 48417; 48418; 48420; 48421; 48422; 48424; 48425; 48426; 48428; 48429; 48430; 48432; 48433; 48434; 48436; 48437; 48438; 49723; 49724; 49725; 49727; 49728; 49729; 49731; 49732; 49733; 49735; 49736; 49737; 49739; 49740; 49741; 52224; 52225; 52226; 52228; 52229; 52231 |] } |> Some
      | 218 -> { GroupData.id= 218; name= "Heat Sink Blueprint"; categoryId= 9; published= true; typeIds= [| 11612; 11795; 15809; 15811; 23901; 23903; 44118 |] } |> Some
      | 24 -> { GroupData.id= 24; name= "Voucher"; categoryId= 5; published= false; typeIds= [| 49; 50; 51; 29247 |] } |> Some
      | 315 -> { GroupData.id= 315; name= "Warp Core Stabilizer"; categoryId= 7; published= true; typeIds= [| 10998; 11640; 16297; 16299; 16301; 16303; 22875; 22877 |] } |> Some
      | 354753 -> { GroupData.id= 354753; name= "Infantry Installations"; categoryId= 350001; published= false; typeIds= [| 354764; 354765; 354767; 354770; 354772; 354773; 354789; 354790; 354791; 354792; 354793; 354794; 354796; 354797; 354824; 354826; 354827; 354850; 354851; 354852; 354856; 354857; 354858; 354859; 354894; 354949; 354958; 355198; 355199; 355201; 355325; 355326; 355327; 355438; 355439; 355721; 355722; 355723; 355724; 356012; 356322; 356335; 356336; 356337; 357007; 357009 |] } |> Some
      | 509 -> { GroupData.id= 509; name= "Missile Launcher Light"; categoryId= 7; published= true; typeIds= [| 499; 2404; 7993; 8089; 8091; 8093; 13925; 13926; 16068; 16136; 17491; 20595; 22565; 32461 |] } |> Some
      | 606 -> { GroupData.id= 606; name= "Deadspace Blood Raiders Frigate"; categoryId= 11; published= false; typeIds= [| 16563; 16564; 16932; 16933; 16935; 16936; 16937; 16939; 16940; 16942; 16943; 16945; 16946; 16947; 16950; 16951; 16953; 16954; 16955; 16963; 16964; 16966; 16972; 16973; 16974; 16977; 16979; 24039; 24040; 24041; 24042; 24043; 24044 |] } |> Some
      | 703 -> { GroupData.id= 703; name= "Mission Mordu Battleship"; categoryId= 11; published= false; typeIds= [| 16034; 16035; 16036; 16037; 16039 |] } |> Some
      | 800 -> { GroupData.id= 800; name= "Asteroid Guristas Commander Frigate"; categoryId= 11; published= false; typeIds= [| 13576; 13581; 13582; 13585; 13590; 13593; 13594; 13597; 13598; 13604; 21988; 21989; 21990; 21991; 21992; 21993; 21994; 21995; 21996; 21997 |] } |> Some
      | 897 -> { GroupData.id= 897; name= "Covert Cynosural Field"; categoryId= 2; published= false; typeIds= [| 28650 |] } |> Some
      | _ -> None