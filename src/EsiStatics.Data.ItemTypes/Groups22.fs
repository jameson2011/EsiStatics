namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups22=
    let getGroup id = 
      match id with 
      | 1089 -> { GroupData.id= 1089; name= "Tops"; categoryId= 30; published= true; typeIds= [| 4057; 4058; 4059; 4060; 4061; 4062; 4063; 4064; 4065; 4066; 4067; 4068; 4155; 4156; 4157; 4158; 4159; 4160; 4161; 4162; 4163; 4164; 4180; 4181; 4182; 4183; 4184; 4185; 4186; 4187; 4188; 4189; 4190; 4191; 4192; 4193; 4194; 4195; 4196; 4197; 4198; 4199; 4200; 4201; 4202; 4203; 4204; 4205; 4206; 4207; 4208; 4209; 4210; 4211; 4212; 4213; 4214; 4215; 4216; 4217; 4218; 4219; 4220; 4221; 4222; 4223; 4224; 4225; 4226; 4227; 4228; 4229; 4230; 4231; 4232; 4240; 4241; 4242; 4243; 4365; 4366; 4367; 4368; 33062; 33063; 33107; 33109; 33487; 33488; 33578; 33579; 33767; 33768; 33769; 33770; 33812; 33813; 34210; 34211; 34824; 34825; 35681; 35682; 36480; 36481; 36482; 36483; 36484; 36485; 36486; 36487; 36488; 36489; 36490; 36491; 37808; 37809; 37865; 37866; 40526; 40527; 42700; 42704; 42707; 44120; 44123; 45734; 45743; 47182; 47183; 47184; 47185; 47186; 47187; 47188; 47189; 47190; 47192; 47479; 47480; 50130; 50131; 52198; 52200; 53380; 53383; 54193; 54194; 54320; 54328; 54943; 54944; 55008; 55009; 56146; 56147; 56211; 56212 |] } |> Some
      | 1186 -> { GroupData.id= 1186; name= "FW Minmatar Republic Battlecruiser"; categoryId= 11; published= true; typeIds= [| 32974 |] } |> Some
      | 119 -> { GroupData.id= 119; name= "Shield Recharger Blueprint"; categoryId= 9; published= true; typeIds= [| 1026; 1027 |] } |> Some
      | 1283 -> { GroupData.id= 1283; name= "Expedition Frigate"; categoryId= 6; published= true; typeIds= [| 33697; 37135 |] } |> Some
      | 1768 -> { GroupData.id= 1768; name= "Seeker Scouts"; categoryId= 11; published= false; typeIds= [| 42692; 42693; 46261; 47489; 47490; 47491; 47492; 47542; 47543; 48545; 48567; 48568; 48569; 48570; 48571; 48572; 48573; 48575; 48640; 48647; 50089; 50090; 50092; 50165 |] } |> Some
      | 1865 -> { GroupData.id= 1865; name= "Structure Engineering Rig L - TE Research Optimization"; categoryId= 66; published= true; typeIds= [| 43726; 43727 |] } |> Some
      | 1962 -> { GroupData.id= 1962; name= "Structure QA Modules"; categoryId= 66; published= false; typeIds= [| 47288 |] } |> Some
      | 313 -> { GroupData.id= 313; name= "Drugs"; categoryId= 17; published= true; typeIds= [| 2711; 3703; 3705; 3707; 3709; 3711; 3713; 3818; 3820; 3822; 3824; 3826; 26780 |] } |> Some
      | 410 -> { GroupData.id= 410; name= "Anti Cloaking Pulse Blueprint"; categoryId= 9; published= false; typeIds= [|  |] } |> Some
      | 507 -> { GroupData.id= 507; name= "Missile Launcher Rocket"; categoryId= 7; published= true; typeIds= [| 10629; 10631; 13931; 13933; 16065; 16521; 16523; 16525; 16527; 17488; 20593; 21542; 22564; 28511; 34290 |] } |> Some
      | 604 -> { GroupData.id= 604; name= "Deadspace Blood Raiders Cruiser"; categoryId= 11; published= false; typeIds= [| 11716; 14346; 16166; 16927; 16928; 16929; 16930; 16931; 16944; 16948; 16949; 16956; 16957; 16958; 16959; 16960; 16961; 16962; 16971; 16975; 16976; 24099; 24100; 24101; 24102; 24103; 24104; 24105; 24106; 24107; 24108; 24109; 24110; 26712; 26755; 26971 |] } |> Some
      | 701 -> { GroupData.id= 701; name= "Mission Mordu Cruiser"; categoryId= 11; published= false; typeIds= [| 16027; 16028; 16030; 16031; 16033; 16038; 32456 |] } |> Some
      | 798 -> { GroupData.id= 798; name= "Asteroid Guristas Commander Cruiser"; categoryId= 11; published= false; typeIds= [| 13575; 13577; 13586; 13587; 13591; 13592; 13595; 13596; 13599; 13600; 21998; 21999; 22000; 23939; 26871 |] } |> Some
      | 992 -> { GroupData.id= 992; name= "Sleeper Engineering Relics"; categoryId= 34; published= true; typeIds= [| 30582; 30586; 30588 |] } |> Some
      | _ -> None