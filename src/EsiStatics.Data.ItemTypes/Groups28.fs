﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups28=
    let getGroup id = 
      match id with 
      | 1289 -> { GroupData.id= 1289; name= "Warp Accelerator"; categoryId= 7; published= true; typeIds= [| 33981; 33983; 33985 |] } |> Some
      | 1580 -> { GroupData.id= 1580; name= "Structure Assembly Rig M - Large Tech I Ship"; categoryId= 66; published= false; typeIds= [|  |] } |> Some
      | 1677 -> { GroupData.id= 1677; name= "Advanced XL Torpedo"; categoryId= 8; published= true; typeIds= [| 41270; 41271; 41272; 41273; 41274; 41275; 41276; 41277 |] } |> Some
      | 1774 -> { GroupData.id= 1774; name= "Armor Command Burst Charges"; categoryId= 8; published= true; typeIds= [| 42832; 42833; 42834 |] } |> Some
      | 1968 -> { GroupData.id= 1968; name= "Structure Armor Reinforcer"; categoryId= 66; published= true; typeIds= [| 47360; 47362 |] } |> Some
      | 28 -> { GroupData.id= 28; name= "Industrial"; categoryId= 6; published= true; typeIds= [| 648; 649; 650; 651; 652; 653; 654; 655; 656; 657; 1944; 2863; 2998; 4363; 4388; 19744; 32811; 33689; 33691; 33693; 33695 |] } |> Some
      | 319 -> { GroupData.id= 319; name= "Large Collidable Structure"; categoryId= 11; published= false; typeIds= [| 2896; 2902; 2915; 3499; 3500; 3591; 3858; 4011; 4357; 11076; 11077; 11079; 11080; 11081; 11167; 11168; 11169; 11170; 11171; 12989; 13034; 13106; 13200; 16215; 16726; 16727; 16728; 16729; 16730; 16731; 16732; 16733; 16734; 16735; 16736; 16737; 16738; 16748; 16749; 16750; 16751; 16752; 16753; 16754; 16755; 16756; 16757; 16758; 16759; 16760; 16761; 16762; 16763; 16764; 16765; 16766; 16767; 16768; 16769; 16770; 16771; 16772; 16773; 16774; 16775; 16776; 16777; 16778; 16779; 16780; 16781; 16782; 16784; 16785; 16786; 16787; 16788; 16789; 16790; 16791; 16792; 16793; 16794; 16796; 16797; 16798; 16799; 16800; 16801; 16802; 16803; 16804; 16805; 16806; 16807; 16808; 16809; 16810; 16811; 16812; 16813; 16814; 16815; 16816; 16817; 16818; 16819; 16820; 16821; 16822; 16823; 16824; 16825; 16826; 16827; 16828; 16829; 16830; 16831; 16836; 16837; 16838; 16839; 16840; 16841; 16842; 16843; 16844; 16845; 16846; 16847; 16848; 16849; 16850; 16851; 16852; 16853; 16854; 16855; 16856; 16857; 16858; 16859; 16860; 16861; 16862; 16864; 16865; 16866; 17138; 17140; 17380; 17381; 17382; 17393; 17394; 17395; 17396; 17397; 17398; 17399; 17400; 17401; 17626; 17627; 17628; 17629; 17644; 17763; 17775; 17776; 17777; 17778; 17779; 17780; 17781; 17782; 17783; 17784; 17785; 17786; 17787; 17788; 17789; 17790; 18012; 18013; 18014; 18015; 18016; 18017; 18018; 18019; 18020; 18021; 18567; 18568; 18569; 19505; 19533; 19593; 19671; 19672; 19673; 19711; 19712; 19729; 19743; 20165; 20177; 20182; 22711; 22712; 22718; 22742; 22743; 22744; 22758; 23222; 23571; 23663; 23858; 23859; 23860; 23906; 23963; 24245; 24310; 24452; 24453; 24456; 24565; 24587; 24588; 24685; 24716; 24768; 24769; 24770; 25355; 25356; 25357; 25358; 25359; 25363; 25552; 25725; 25815; 25819; 25826; 25828; 25859; 25991; 25992; 25993; 25994; 26121; 26240; 26704; 26706; 26720; 26721; 26722; 26723; 26724; 26725; 26726; 26727; 26728; 26729; 26732; 26734; 26737; 26740; 26751; 26853; 26854; 26855; 26894; 26895; 26896; 26897; 26898; 26899; 26900; 27063; 27290; 27879; 27880; 27881; 27882; 28065; 28227; 28228; 28234; 28235; 28246; 28247; 28248; 28249; 28250; 28251; 28252; 28254; 28258; 28340; 28582; 28608; 28616; 28839; 28854; 29031; 29149; 29165; 29166; 29167; 29168; 29169; 29170; 29171; 29172; 29173; 29174; 29175; 29176; 29177; 29178; 29179; 29180; 29189; 29209; 29262; 29301; 29325; 29346; 29391; 29437; 29446; 29461; 29467; 29468; 29469; 30273; 30274; 30275; 30276; 30277; 30278; 30279; 30280; 30507; 30508; 30509; 30510; 30511; 30512; 30806; 30807; 30927; 32194; 32219; 32221; 32238; 32239; 32264; 32349; 32412; 33480; 34303; 35764; 37870; 42538; 42690; 47401; 48652; 48961; 48962; 52359; 52360; 52361; 52390; 52700; 52842; 53045; 53046; 53047; 53080; 53292; 53305; 54274; 54283; 54313; 54314; 54315; 54316; 54325; 54326; 54571; 54572; 54573; 54574; 54575; 54576; 56699; 56700 |] } |> Some
      | 416 -> { GroupData.id= 416; name= "Moon Mining"; categoryId= 23; published= true; typeIds= [| 16221 |] } |> Some
      | 513 -> { GroupData.id= 513; name= "Freighter"; categoryId= 6; published= true; typeIds= [| 20183; 20185; 20187; 20189; 34328 |] } |> Some
      | 707 -> { GroupData.id= 707; name= "Jump Portal Array"; categoryId= 23; published= true; typeIds= [| 4359; 27897 |] } |> Some
      | 804 -> { GroupData.id= 804; name= "Deadspace Rogue Drone Destroyer"; categoryId= 11; published= false; typeIds= [| 23475; 23476; 23477; 23478; 23479; 23480; 29215 |] } |> Some
      | 901 -> { GroupData.id= 901; name= "Mining Enhancer"; categoryId= 7; published= false; typeIds= [|  |] } |> Some
      | _ -> None