﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups43=
    let getGroup id = 
      match id with 
      | 1013 -> { GroupData.id= 1013; name= "Supercarrier Blueprints"; categoryId= 9; published= true; typeIds= [| 3515; 22853; 23914; 23918; 23920; 42137 |] } |> Some
      | 1110 -> { GroupData.id= 1110; name= "Point Lights"; categoryId= 54; published= true; typeIds= [| 32634 |] } |> Some
      | 1207 -> { GroupData.id= 1207; name= "Scatter Container"; categoryId= 11; published= true; typeIds= [| 21678; 21679; 21680; 21681; 21683; 21684; 21685; 21686; 21688; 21689; 21690; 21691; 21693; 21694; 21695; 21696; 21708; 21709; 21710; 21711; 21713; 21714; 21715; 21716; 22225; 22226; 22293; 22294; 23188; 23189; 23190; 23191; 23192; 23193; 23194; 23195; 23196; 23197; 23198; 23199; 23200; 23201; 23202; 23203; 23204; 23205; 23206; 23207; 23208; 23209; 23210; 23211; 24464; 26135; 26136; 26137; 26145; 26146; 26148; 26149; 26150; 26151; 26152; 26153; 26154; 26155; 26161; 26162; 26163; 26164; 26165; 26166; 26276; 26277; 27277; 27278; 28871; 28872; 28873; 28874; 28875; 28876; 28877; 28878; 28881; 28882; 28883; 28902; 28904; 28905; 28906; 28907; 28908; 28909; 28911; 28912; 28914; 28915; 28917; 28918; 28920; 28921; 28923; 28924; 28927; 28928; 28930; 28931; 28933; 28934; 28936; 28937; 28938; 28939; 28940; 28941; 28942; 28943; 28944; 28945; 28946; 28948; 28949; 28951; 28952; 28955; 28957; 28958; 28960; 28961; 28964; 28966; 28967; 28969; 28970; 28976; 28977; 28978; 28979; 28982; 28983; 28984; 28985; 28986; 28987; 28988; 28989; 28990; 28991; 28992; 28993; 28994; 30516; 30517; 30518; 30519; 30520; 30521; 30522; 30523; 30524; 30525; 30526; 30527; 30528; 30529; 30530; 32282; 32367; 32369; 33147; 33186; 33187; 33188; 33233; 33234; 33235; 33236; 33237; 33238; 33239; 33240; 33241; 33242; 33243; 33244; 33245; 33246; 33247; 33248; 33249; 33251; 33252; 33253; 33254; 33255; 33256; 33257; 33258; 33259; 33260; 33261; 33262; 33263; 33264; 33265; 33266; 33267; 33268; 33269; 33367; 33368; 34572; 47457; 49788 |] } |> Some
      | 1304 -> { GroupData.id= 1304; name= "Generic Decryptor"; categoryId= 35; published= true; typeIds= [| 34201; 34202; 34203; 34204; 34205; 34206; 34207; 34208 |] } |> Some
      | 140 -> { GroupData.id= 140; name= "Damage Control Blueprint"; categoryId= 9; published= true; typeIds= [| 2047; 2049; 22894; 23419; 30840; 40719; 40720; 40721; 40722; 40723; 47259; 47260 |] } |> Some
      | 1595 -> { GroupData.id= 1595; name= "Structure Assembly Rig XL - Ship"; categoryId= 66; published= false; typeIds= [|  |] } |> Some
      | 1692 -> { GroupData.id= 1692; name= "Asteroid Rogue Drone Supercarrier"; categoryId= 11; published= false; typeIds= [| 37471 |] } |> Some
      | 1789 -> { GroupData.id= 1789; name= "Hidden Zenith Amarr Battleship"; categoryId= 11; published= false; typeIds= [| 42817; 50107; 50108 |] } |> Some
      | 1886 -> { GroupData.id= 1886; name= "Technical Data Chips"; categoryId= 17; published= true; typeIds= [| 45584; 45585 |] } |> Some
      | 1983 -> { GroupData.id= 1983; name= "Abyssal Environment"; categoryId= 2; published= false; typeIds= [| 47862; 47863; 47864; 47865; 47866 |] } |> Some
      | 237 -> { GroupData.id= 237; name= "Corvette"; categoryId= 6; published= true; typeIds= [| 588; 596; 601; 606; 615; 617; 1233; 9854; 9858; 9860; 9862; 33079; 33081; 33083 |] } |> Some
      | 334 -> { GroupData.id= 334; name= "Construction Components"; categoryId= 17; published= true; typeIds= [| 11530; 11531; 11532; 11533; 11534; 11535; 11536; 11537; 11538; 11539; 11540; 11541; 11542; 11543; 11544; 11545; 11547; 11548; 11549; 11550; 11551; 11552; 11553; 11554; 11555; 11556; 11557; 11558; 11688; 11689; 11690; 11691; 11692; 11693; 11694; 11695; 33195; 52310; 52311; 52312; 52313; 52314 |] } |> Some
      | 43 -> { GroupData.id= 43; name= "Capacitor Recharger"; categoryId= 7; published= true; typeIds= [| 421; 1195; 2032; 4421; 4423; 4425; 4427; 4431; 4433; 4435; 4437; 14140; 14142; 15788; 16599; 16601; 16603; 16605; 17526; 21816; 21817; 21818; 21819; 23813; 28530 |] } |> Some
      | 528 -> { GroupData.id= 528; name= "Artifacts and Prototypes"; categoryId= 17; published= true; typeIds= [| 21076; 21079; 21080; 21082; 21088; 21719; 21720; 21721; 21722; 21723; 21724; 21725; 21726; 21727; 21728; 21729; 21730; 21731; 21732; 21733; 23128; 23129; 23130; 23131; 23132; 23133; 23134; 23135; 23136; 23137; 23148; 23149; 23150; 23151; 23152; 23153; 23154; 23155; 23156; 23157; 42226 |] } |> Some
      | 722 -> { GroupData.id= 722; name= "Advanced Hybrid Charge Blueprint"; categoryId= 9; published= true; typeIds= [| 12611; 12613; 12615; 12617; 12619; 12621; 12786; 12788; 12790; 12792; 12794; 12796; 12798; 12800; 12802; 12804; 12806; 12808; 41323; 41325; 41327; 41329 |] } |> Some
      | 819 -> { GroupData.id= 819; name= "Deadspace Overseer Frigate"; categoryId= 11; published= false; typeIds= [| 4010; 4012; 4015; 4354; 4355; 4356; 17283; 17285; 17800; 17890; 17903; 17997; 18004; 18024; 26142; 26661; 26680; 26684; 26687; 26688; 26753; 26862; 26863; 26864; 26865; 26866 |] } |> Some
      | 916 -> { GroupData.id= 916; name= "Nanite Repair Paste"; categoryId= 8; published= true; typeIds= [| 28668 |] } |> Some
      | _ -> None