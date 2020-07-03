﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups23=
    let getGroup id = 
      match id with 
      | 1090 -> { GroupData.id= 1090; name= "Bottoms"; categoryId= 30; published= true; typeIds= [| 3992; 3997; 3998; 3999; 4016; 4017; 4018; 4019; 4020; 4021; 4022; 4026; 4028; 4030; 4032; 4033; 4034; 4035; 4036; 4069; 4070; 4071; 4072; 4073; 4074; 4075; 4076; 4078; 4085; 4101; 4102; 4103; 4104; 4105; 4106; 4107; 4108; 4109; 4110; 4111; 4112; 4113; 4114; 4115; 4165; 4166; 4167; 4168; 4169; 4170; 4171; 33744; 33745; 33746; 33747; 33748; 33749; 33750; 33751; 33752; 33753; 33754; 33755; 33756; 33757; 33758; 33759; 33760; 33761; 33781; 33782; 33783; 33784; 33785; 33786; 33787; 33788; 33789; 33790; 33989; 34045; 34046; 34047; 34048; 34049; 34050; 34051; 34052; 34053; 34054; 34055; 34101; 34102; 34103; 34104; 34105; 34106; 34107; 34108; 34109; 34110; 34111; 34354; 34355; 34356; 34357; 34358; 34359; 36493; 36494; 36495; 36496; 36497; 36498; 36499; 36500; 36501; 36502; 36503; 36504; 40524; 40525; 42701; 44121; 44124; 48083; 54306; 54308; 54365; 54366; 54367; 54368; 54369; 54370; 54371; 54372; 54373; 54374; 54375; 54376 |] } |> Some
      | 120 -> { GroupData.id= 120; name= "Shield Booster Blueprint"; categoryId= 9; published= true; typeIds= [| 1032; 1033; 3543; 10040; 10837; 10839; 10841; 10843; 10851; 10859; 12712; 12714; 12716; 12718; 20368; 20618; 20620; 20622; 20624; 20704; 22886; 41632; 41633; 41634; 41635; 41636; 41637 |] } |> Some
      | 1672 -> { GroupData.id= 1672; name= "Stasis Grappler"; categoryId= 7; published= true; typeIds= [| 41040; 41054; 41055; 41056; 41057; 41058; 41059 |] } |> Some
      | 1769 -> { GroupData.id= 1769; name= "Shield Command Burst Charges"; categoryId= 8; published= true; typeIds= [| 42694; 42695; 42696 |] } |> Some
      | 1866 -> { GroupData.id= 1866; name= "Structure Engineering Rig L - Blueprint Copy Optimization"; categoryId= 66; published= true; typeIds= [| 43729; 43730 |] } |> Some
      | 23 -> { GroupData.id= 23; name= "Clone"; categoryId= 5; published= false; typeIds= [| 164; 165; 166; 9917; 9919; 9921; 9923; 9925; 9927; 9929; 9931; 9933; 9935; 9937; 9939; 16715; 16718; 23734; 29138; 29139; 29140; 29141; 29142; 29143 |] } |> Some
      | 314 -> { GroupData.id= 314; name= "Miscellaneous"; categoryId= 17; published= true; typeIds= [| 2074; 2075; 2100; 2197; 2198; 2199; 2200; 2201; 2202; 2215; 2216; 2219; 2220; 2221; 2250; 2368; 2369; 2371; 2373; 2374; 2375; 2376; 2377; 2595; 2596; 2597; 2598; 2599; 2601; 2602; 2608; 2610; 2615; 2616; 2617; 2618; 2619; 2620; 2623; 2624; 2626; 2627; 2628; 2631; 2632; 2633; 2635; 2636; 2639; 2640; 2641; 2642; 2644; 2645; 2646; 2652; 2653; 2654; 2657; 2659; 2660; 2673; 2682; 2683; 2684; 2685; 2686; 2687; 2688; 2689; 2690; 2691; 2692; 2693; 2694; 2695; 2696; 2697; 2698; 2710; 2712; 2713; 2714; 2715; 2716; 2717; 2718; 2719; 2720; 2721; 2722; 2723; 2724; 2729; 2730; 2731; 2732; 2851; 2853; 2861; 2862; 2880; 2888; 2893; 2899; 2900; 2904; 2917; 2930; 2934; 2943; 2944; 2951; 2952; 2955; 2956; 2957; 2960; 2963; 2964; 2965; 2967; 2968; 2971; 2972; 2973; 2974; 2979; 2980; 2981; 2982; 2987; 2988; 2989; 2990; 2991; 2992; 2995; 2996; 2997; 3000; 3003; 3005; 3007; 3011; 3012; 3013; 3014; 3015; 3016; 3019; 3020; 3021; 3022; 3023; 3024; 3027; 3028; 3029; 3030; 3031; 3035; 3037; 3038; 3501; 3583; 3584; 3585; 3627; 3701; 3837; 3838; 3843; 3844; 4089; 4390; 10646; 11013; 11066; 11067; 11068; 11069; 11070; 11071; 11508; 11509; 11510; 11511; 11512; 11528; 11585; 11586; 11587; 11588; 11602; 11603; 11604; 11606; 11607; 11608; 11635; 11654; 11702; 11703; 11707; 11723; 11856; 11944; 12250; 12302; 12303; 12478; 12994; 12995; 13067; 13204; 13205; 13206; 13210; 13211; 13212; 13213; 13214; 13215; 13288; 13328; 13918; 14292; 14293; 14358; 14483; 15316; 15318; 15319; 15353; 15410; 16041; 16042; 16043; 16044; 16045; 16614; 16686; 16712; 16713; 16714; 16832; 17143; 17391; 17423; 17424; 17624; 17640; 17643; 17646; 17647; 17755; 17756; 17757; 17759; 17761; 17793; 17794; 17795; 17814; 17815; 17816; 17840; 17848; 17849; 17850; 17893; 17894; 17895; 17897; 18583; 18655; 19382; 19399; 19461; 19462; 19463; 19493; 19582; 19730; 20328; 20362; 20375; 20541; 20551; 21624; 22222; 22730; 22764; 23863; 23871; 23882; 23909; 23945; 23948; 24717; 25382; 26270; 26707; 26774; 26776; 26778; 26779; 26781; 26782; 26784; 26785; 26786; 26787; 26790; 26791; 26792; 26974; 27803; 28256; 28257; 28359; 28360; 28827; 28828; 28829; 28830; 28833; 28834; 28836; 28843; 28865; 28866; 28868; 28870; 28896; 28897; 28972; 28973; 28975; 28996; 29026; 29137; 29162; 29202; 29203; 29205; 29211; 29268; 29272; 29278; 29284; 29321; 29464; 29471; 29474; 29475; 29476; 29477; 29478; 29480; 29531; 29607; 29932; 29933; 29934; 29935; 29936; 29937; 29938; 29939; 29940; 29941; 29942; 29943; 29944; 29945; 29946; 29947; 29948; 29949; 29950; 29951; 29952; 29953; 29954; 29955; 30755; 30756; 30768; 30776; 30778; 30780; 30782; 30784; 30794; 30809; 30810; 30811; 30816; 30907; 30951; 30952; 30954; 30955; 30964; 30967; 32099; 32106; 32200; 32201; 32202; 32204; 32218; 32220; 32223; 32225; 32229; 32234; 32235; 32237; 32241; 32252; 32253; 32257; 32258; 32259; 32265; 32266; 32267; 32272; 32277; 32280; 32283; 32284; 32285; 32286; 32287; 32288; 32289; 32290; 32294; 32350; 32351; 32352; 32365; 32366; 32371; 32375; 32376; 32383; 32393; 32403; 32407; 32408; 32418; 32885; 32886; 32887; 32888; 32889; 32890; 32891; 32892; 33070; 33071; 33072; 33073; 33117; 33118; 33119; 33120; 33121; 33122; 33123; 33124; 33125; 33126; 33127; 33128; 33129; 33577; 33618; 33619; 33620; 34311; 34312; 34313; 34314; 34381; 34382; 34383; 34400; 34401; 34402; 34450; 34451; 34452; 40456; 40548; 40549; 40701; 42683; 45536; 46278; 47025; 47026; 47027; 47041; 53476; 54257; 54356; 54357; 54358; 54528; 54529; 54530; 54531; 54532; 54533; 54546; 54547; 54548; 54549; 54550; 54551; 54563; 54629; 54630; 54631; 54632; 54633; 54634; 54637; 54639; 54641; 54642; 54644; 54646; 54647 |] } |> Some
      | 351648 -> { GroupData.id= 351648; name= "Infantry Skills"; categoryId= 350001; published= false; typeIds= [| 352887; 352888; 352890; 353317; 353318; 353322; 353323; 353326; 353327; 353330; 353331; 353335; 353336; 353352; 353353; 353357; 353363; 353365; 353366; 353368; 353369; 353370; 353371; 353372; 353373; 353375; 353376; 353377; 353378; 353379; 353381; 353382; 353386; 353387; 353388; 353389; 353390; 353391; 353399; 353405; 353408; 353413; 353426; 353427; 353428; 353435; 353436; 353437; 353438; 353440; 353441; 353443; 353444; 353445; 353446; 353447; 353448; 353449; 353450; 353451; 353452; 353453; 353454; 353455; 353456; 353457; 353458; 353459; 353460; 353461; 353462; 353463; 353464; 353465; 353466; 353467; 353468; 353469; 353470; 353471; 353472; 353473; 353474; 353475; 353476; 353477; 353478; 353479; 353482; 353484; 353485; 353685; 353686; 353687; 355212; 355213; 355280; 355932; 356658; 356701; 356724; 356725; 356915; 363360; 363362; 363788; 363789; 363861; 363862; 364519; 364520; 364521; 364531; 364532; 364533; 364534; 364555; 364556; 364570; 364571; 364573; 364575; 364576; 364578; 364579; 364580; 364581; 364594; 364595; 364596; 364597; 364598; 364599; 364600; 364601; 364602; 364603; 364604; 364605; 364606; 364607; 364608; 364609; 364610; 364611; 364612; 364613; 364614; 364615; 364616; 364617; 364618; 364633; 364639; 364640; 364641; 364656; 364658; 364659; 364661; 364662; 364663; 364664; 364665; 364666; 364667; 364668; 364669; 364670; 364671; 364672; 364673; 364674; 364675; 364676; 364677; 364678; 364679; 364680; 364681; 364682; 364683; 364684; 364685; 364686; 364687; 364688; 364689; 364690; 364691; 364692; 364693; 364694; 364695; 364696; 364697; 364698; 364699; 364700; 364701; 364702; 364703; 364704; 364705; 364706; 364707; 364708; 364709; 364747; 364748; 364749; 364750; 364751; 364761; 364763; 364769; 364773; 364775; 364776; 364777; 364916; 364918; 364919; 364920; 364921; 364922; 364933; 364935; 364943; 364945; 365386; 365388; 365389; 365391; 365392; 365393; 365395; 365396; 365397; 365399; 365400; 365401; 365404; 365405; 365406; 365407; 365408; 365832; 365844; 365845; 365848; 365850; 365851; 365853; 365854; 365855; 365857; 365859; 365860; 365861; 365864; 365865; 365866; 365868; 365870; 365872; 365873; 365875; 365876; 365877; 365878; 365879; 365893; 366228; 366587; 366589; 366590; 366591; 366592; 366595; 366596; 366597; 366598; 366599; 366600; 366760; 367382 |] } |> Some
      | 411 -> { GroupData.id= 411; name= "Force Field"; categoryId= 2; published= false; typeIds= [| 16103 |] } |> Some
      | 508 -> { GroupData.id= 508; name= "Missile Launcher Torpedo"; categoryId= 7; published= true; typeIds= [| 503; 2420; 8001; 8113; 8115; 8117; 13923; 13924; 14524; 14525; 14526; 14527; 14680; 14681; 14682; 14683; 16067; 17490; 20603; 22569; 28513; 34294 |] } |> Some
      | 605 -> { GroupData.id= 605; name= "Deadspace Blood Raiders Destroyer"; categoryId= 11; published= false; typeIds= [| 23970; 23979; 23980; 23981; 23982; 23983; 24223; 24224; 24225; 24226; 24227; 24228 |] } |> Some
      | 702 -> { GroupData.id= 702; name= "Mission Mordu Battlecruiser"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 799 -> { GroupData.id= 799; name= "Asteroid Guristas Commander Destroyer"; categoryId= 11; published= false; typeIds= [| 23343; 23344; 23345; 23346; 23347; 23348; 23942; 23943 |] } |> Some
      | 896 -> { GroupData.id= 896; name= "Rig Security Transponder"; categoryId= 7; published= false; typeIds= [|  |] } |> Some
      | 993 -> { GroupData.id= 993; name= "Sleeper Defensive Relics"; categoryId= 34; published= true; typeIds= [| 30614; 30615; 30618 |] } |> Some
      | _ -> None