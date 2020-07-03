﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups89=
    let getGroup id = 
      match id with 
      | 1156 -> { GroupData.id= 1156; name= "Ancillary Shield Booster"; categoryId= 7; published= true; typeIds= [| 4391; 32772; 32774; 32780; 41504; 47836; 47838; 47840 |] } |> Some
      | 1641 -> { GroupData.id= 1641; name= "Structure Combat Rig XL - Energy Neutralizer and EW"; categoryId= 66; published= true; typeIds= [| 37272; 37273 |] } |> Some
      | 1835 -> { GroupData.id= 1835; name= "Structure Engineering Rig M - Advanced Large Ship TE"; categoryId= 66; published= true; typeIds= [| 43864; 43865 |] } |> Some
      | 186 -> { GroupData.id= 186; name= "Wreck"; categoryId= 2; published= false; typeIds= [| 3260; 26468; 26469; 26470; 26472; 26473; 26474; 26475; 26476; 26477; 26478; 26479; 26480; 26481; 26482; 26483; 26484; 26485; 26486; 26487; 26488; 26489; 26490; 26491; 26492; 26494; 26495; 26496; 26497; 26498; 26499; 26500; 26501; 26502; 26503; 26504; 26505; 26506; 26507; 26508; 26509; 26510; 26511; 26512; 26513; 26514; 26516; 26517; 26518; 26519; 26520; 26521; 26522; 26523; 26524; 26525; 26526; 26527; 26528; 26529; 26530; 26531; 26532; 26533; 26534; 26535; 26536; 26538; 26539; 26540; 26541; 26542; 26543; 26544; 26545; 26546; 26547; 26548; 26549; 26550; 26551; 26552; 26553; 26554; 26555; 26556; 26557; 26558; 26559; 26560; 26561; 26562; 26563; 26564; 26565; 26566; 26567; 26568; 26569; 26570; 26571; 26572; 26573; 26574; 26575; 26576; 26577; 26578; 26579; 26580; 26581; 26582; 26583; 26584; 26585; 26586; 26587; 26588; 26589; 26590; 26591; 26592; 26593; 26594; 26595; 26596; 26699; 26700; 26701; 26702; 26703; 26918; 26919; 26920; 26933; 26934; 26935; 26939; 26940; 26941; 26972; 27041; 27042; 27043; 27044; 27045; 27046; 27047; 27048; 27049; 27050; 27051; 27052; 27053; 27054; 27055; 27056; 27057; 27058; 27060; 27061; 27062; 27202; 27286; 27926; 27927; 27928; 27929; 28221; 28222; 28223; 28255; 28603; 29033; 29034; 29035; 29036; 29347; 29365; 29639; 30457; 30458; 30459; 30484; 30485; 30492; 30493; 30494; 30495; 30496; 30822; 30823; 30824; 30825; 33489; 33490; 33538; 33765; 33766; 33907; 33908; 33909; 34395; 34440; 34584; 34768; 34884; 37531; 37596; 37861; 37862; 40639; 40640; 40641; 40642; 40644; 40645; 40646; 40647; 40702; 40703; 40704; 40705; 40706; 40707; 41688; 41689; 41690; 41691; 41692; 41693; 41694; 41695; 41696; 41699; 41700; 42662; 44273; 44275; 44276; 44277; 46338; 46339; 46341; 46342; 46604; 46605; 46606; 47517; 47518; 47519; 47520; 47521; 47560; 47758; 47795; 47977; 47978; 48120; 48372; 48373; 48742; 48970; 49117; 49119; 49121; 49123; 49125; 49627; 49628; 49629; 49630; 49631; 49632; 49664; 49665; 49666; 49692; 49693; 52354; 52355; 52356; 52357; 52358; 52414; 52415; 52416; 52660; 52661; 52662; 52663; 52664; 52665; 52784; 53025; 53068; 53069; 53070; 53071; 53072; 53257; 53258; 53259; 53260; 53261; 53262; 53263; 53264; 53265; 53266; 53267; 53268; 53269; 53270; 53271; 53272; 53273; 53274; 53275; 53276; 53277; 53300; 53306; 53320; 54224; 54565; 54566; 54567; 54730; 54922; 54923; 55748; 55749; 55750; 55818 |] } |> Some
      | 283 -> { GroupData.id= 283; name= "Livestock"; categoryId= 17; published= true; typeIds= [| 2013; 2093; 2217; 2226; 2239; 2240; 2244; 2662; 2663; 2665; 2666; 2668; 2669; 2670; 2671; 2672; 2674; 2675; 2676; 2677; 2678; 2681; 2699; 2700; 2701; 2702; 2703; 2704; 2705; 2706; 2707; 2708; 2709; 2725; 2726; 2727; 2728; 2919; 2942; 2958; 2959; 2975; 2976; 2983; 2984; 2999; 3004; 3006; 3008; 3032; 3036; 3483; 3719; 3721; 3723; 3804; 3806; 3808; 3810; 3923; 4358; 11701; 11709; 11742; 12049; 12110; 12243; 13267; 13837; 16194; 16253; 16593; 16623; 16630; 17409; 17754; 17765; 17767; 17791; 17796; 20554; 20715; 21064; 21066; 21070; 21466; 21467; 21502; 21631; 21672; 21734; 21743; 21850; 22067; 22069; 22085; 22089; 22139; 22143; 22173; 22208; 22209; 22210; 22321; 22708; 22752; 22788; 22792; 22796; 22801; 22802; 22803; 22804; 22847; 23274; 23327; 23509; 23558; 23610; 23699; 24238; 24251; 24342; 24441; 24729; 24731; 24752; 24755; 24760; 24766; 25352; 25373; 25390; 25847; 25850; 25869; 25875; 25885; 25989; 26115; 26140; 26225; 26266; 26271; 26696; 26708; 26773; 26775; 26783; 26788; 26846; 26901; 26907; 26908; 26998; 27203; 28137; 28832; 28835; 28842; 28869; 28886; 28995; 29191; 29216; 29219; 29229; 29253; 29263; 29269; 29283; 29294; 29439; 29447; 29489; 29614; 30182; 30716; 30719; 30757; 30759; 30761; 30774; 30804; 30812; 30814; 30827; 30968; 30980; 31960; 32097; 32193; 32228; 32270; 32292; 32372; 32389; 32398 |] } |> Some
      | 380 -> { GroupData.id= 380; name= "Deep Space Transport"; categoryId= 6; published= true; typeIds= [| 12731; 12745; 12747; 12753 |] } |> Some
      | 4066 -> { GroupData.id= 4066; name= "Advanced Condenser Pack Blueprint"; categoryId= 9; published= true; typeIds= [| 54884; 54885; 54886; 54887; 54888; 54889; 54890; 54891; 54892; 54893; 54894; 54895; 54896; 54897; 54898; 54899 |] } |> Some
      | 477 -> { GroupData.id= 477; name= "Mining Barge Blueprint"; categoryId= 9; published= true; typeIds= [| 17477; 17479; 17481; 22545; 22547; 22549; 33684 |] } |> Some
      | 574 -> { GroupData.id= 574; name= "Asteroid Serpentis Officer"; categoryId= 11; published= false; typeIds= [| 13654; 13659; 13661; 13667 |] } |> Some
      | 671 -> { GroupData.id= 671; name= "Mission Caldari State Frigate"; categoryId= 11; published= false; typeIds= [| 11659; 11664; 13104; 14355; 14359; 14478; 15346; 15579; 15969; 15970; 15971; 15972; 24997; 24999; 25001; 25004; 25007; 25008; 25011; 25012; 25013; 25015; 25033; 25034; 25035; 25036; 25037; 25038; 25039; 25040; 25041; 25042; 29816; 29817; 29818; 29819; 29820; 29821; 29822; 29823; 29824; 29825; 29826; 29827; 29828; 29829; 29830; 30769; 30770; 30771; 30772; 30773; 32384; 32392; 45461 |] } |> Some
      | 768 -> { GroupData.id= 768; name= "Capacitor Flux Coil"; categoryId= 7; published= true; typeIds= [| 509; 1246; 1248; 8131; 8133; 8135; 8137; 8163; 8165; 8167; 8169; 23894 |] } |> Some
      | 865 -> { GroupData.id= 865; name= "Mission Amarr Empire Carrier"; categoryId= 11; published= false; typeIds= [| 27717 |] } |> Some
      | 89 -> { GroupData.id= 89; name= "Torpedo"; categoryId= 8; published= true; typeIds= [| 267; 2210; 2506; 2508; 2510; 27337; 27339; 27341; 27343; 27345; 27347; 27349; 27351; 27355; 27357; 27359; 27363; 27891; 27892 |] } |> Some
      | _ -> None