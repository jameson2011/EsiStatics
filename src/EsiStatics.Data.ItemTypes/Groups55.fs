namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups55=
    let getGroup id = 
      match id with 
      | 1025 -> { GroupData.id= 1025; name= "Orbital Infrastructure"; categoryId= 46; published= false; typeIds= [| 2233; 3964; 4318 |] } |> Some
      | 1122 -> { GroupData.id= 1122; name= "Salvager"; categoryId= 7; published= true; typeIds= [| 25861; 26983; 30836 |] } |> Some
      | 1316 -> { GroupData.id= 1316; name= "Entosis Command Node"; categoryId= 2; published= false; typeIds= [| 34832 |] } |> Some
      | 1413 -> { GroupData.id= 1413; name= "Amarr Navy Roaming Logistics"; categoryId= 11; published= false; typeIds= [| 35813 |] } |> Some
      | 152 -> { GroupData.id= 152; name= "Smart Bomb Blueprint"; categoryId= 9; published= true; typeIds= [| 1548; 1550; 1552; 1554; 1558; 1560; 1564; 1566; 3938; 3940; 3942; 3944; 3948; 3950; 3954; 3956; 3978; 3980; 3982; 3984; 3988; 3990; 3994; 3996; 15926; 15928; 15930; 15932; 15936; 15938; 15940; 15942; 15946; 15948; 15950; 15954; 15956; 15958; 15960; 15962; 15964; 21535; 21537; 21539; 23865; 23867; 23869; 28546; 28551; 28558 |] } |> Some
      | 1607 -> { GroupData.id= 1607; name= "Structure Laboratory Rig L - Capital Component"; categoryId= 66; published= false; typeIds= [| 37204; 37205 |] } |> Some
      | 1704 -> { GroupData.id= 1704; name= "Super Weapon Beacon"; categoryId= 2; published= false; typeIds= [| 41233; 41235; 41342; 41343; 41344; 41345; 41346; 41347; 41348; 41349; 41540 |] } |> Some
      | 1995 -> { GroupData.id= 1995; name= "Triglavian Data"; categoryId= 17; published= true; typeIds= [| 48121 |] } |> Some
      | 346 -> { GroupData.id= 346; name= "Co-Processor Blueprint"; categoryId= 9; published= true; typeIds= [| 11619; 11747; 15676; 15678; 20568; 20570; 28562 |] } |> Some
      | 443 -> { GroupData.id= 443; name= "Warp Scrambling Battery"; categoryId= 23; published= true; typeIds= [| 17181; 17182; 27563; 27565; 27567; 27569 |] } |> Some
      | 540 -> { GroupData.id= 540; name= "Command Ship"; categoryId= 6; published= true; typeIds= [| 22442; 22444; 22446; 22448; 22466; 22468; 22470; 22474 |] } |> Some
      | 55 -> { GroupData.id= 55; name= "Projectile Weapon"; categoryId= 7; published= true; typeIds= [| 484; 485; 486; 487; 488; 489; 490; 491; 492; 493; 494; 495; 496; 497; 498; 2865; 2873; 2881; 2889; 2897; 2905; 2913; 2921; 2929; 2937; 2945; 2953; 2961; 2969; 2977; 3571; 3573; 8759; 8785; 8787; 8789; 8815; 8817; 8819; 8821; 8863; 8865; 8867; 8869; 8903; 8905; 8907; 8909; 9071; 9073; 9091; 9093; 9127; 9129; 9131; 9133; 9135; 9137; 9139; 9141; 9207; 9209; 9211; 9213; 9247; 9249; 9251; 9253; 9287; 9289; 9291; 9293; 9327; 9329; 9331; 9333; 9367; 9369; 9371; 9373; 9377; 9411; 9413; 9415; 9417; 9419; 9421; 9451; 9453; 9455; 9457; 9491; 9493; 9495; 9497; 13773; 13774; 13775; 13776; 13777; 13778; 13779; 13781; 13782; 13783; 13784; 13785; 13786; 13787; 13788; 14457; 14459; 14461; 14463; 14465; 14467; 14469; 14471; 14473; 14475; 15443; 15445; 16046; 16047; 16048; 16049; 16050; 16051; 16052; 16053; 16054; 16055; 16056; 16057; 16058; 16059; 16060; 16148; 16149; 16150; 20452; 20454; 21545; 21547; 21549; 21551; 21553; 21555; 21557; 21559; 21561; 34284; 34286; 34288; 37289; 37304; 37305; 37306; 37307; 41080; 41081; 41082; 41083; 41150; 41151; 41152; 41153; 41154; 41156; 41157; 41158; 41159; 41160 |] } |> Some
      | 734 -> { GroupData.id= 734; name= "Decryptors - Takmahl"; categoryId= 17; published= true; typeIds= [| 23173; 23174; 23175; 23176; 23177 |] } |> Some
      | 831 -> { GroupData.id= 831; name= "Interceptor"; categoryId= 6; published= true; typeIds= [| 11176; 11178; 11184; 11186; 11196; 11198; 11200; 11202; 33673; 35779 |] } |> Some
      | _ -> None