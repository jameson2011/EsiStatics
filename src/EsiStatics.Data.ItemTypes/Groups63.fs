namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups63=
    let getGroup id = 
      match id with 
      | 1033 -> { GroupData.id= 1033; name= "Planet Liquid-Gas - Raw Resource"; categoryId= 42; published= true; typeIds= [| 2268; 2308; 2309; 2310; 2311 |] } |> Some
      | 1227 -> { GroupData.id= 1227; name= "Survey Probe Launcher Blueprint"; categoryId= 9; published= true; typeIds= [| 33271; 33273 |] } |> Some
      | 1324 -> { GroupData.id= 1324; name= "Structure Navigation Service Module"; categoryId= 66; published= false; typeIds= [| 35912; 35913; 35914; 35915 |] } |> Some
      | 160 -> { GroupData.id= 160; name= "Burst Jammer Blueprint"; categoryId= 9; published= true; typeIds= [| 1210; 2118; 20582; 26870 |] } |> Some
      | 1615 -> { GroupData.id= 1615; name= "Structure Combat Rig M - Energy Neutralizer Projection"; categoryId= 66; published= true; typeIds= [| 37218; 37219 |] } |> Some
      | 2003 -> { GroupData.id= 2003; name= "Citizen Modules"; categoryId= 7; published= false; typeIds= [| 48781 |] } |> Some
      | 257 -> { GroupData.id= 257; name= "Spaceship Command"; categoryId= 16; published= true; typeIds= [| 3184; 3327; 3328; 3329; 3330; 3331; 3332; 3333; 3334; 3335; 3336; 3337; 3338; 3339; 3340; 3341; 3342; 3343; 3344; 3345; 3346; 3347; 3755; 3758; 9955; 10264; 11075; 11078; 12092; 12093; 12095; 12096; 12097; 12098; 12099; 16591; 17940; 19430; 19719; 20342; 20524; 20525; 20526; 20527; 20528; 20530; 20531; 20532; 20533; 22551; 22761; 23950; 24311; 24312; 24313; 24314; 28374; 28609; 28615; 28656; 28667; 29029; 29637; 30650; 30651; 30652; 30653; 32918; 33091; 33092; 33093; 33094; 33095; 33096; 33097; 33098; 33856; 34327; 34390; 34533; 35680; 35685; 37615; 40328; 40535; 40536; 40537; 40538; 47445; 47867; 47868; 47869; 49742; 49743; 52997; 54794; 55031; 55032 |] } |> Some
      | 4040 -> { GroupData.id= 4040; name= "180-Day SKIN"; categoryId= 91; published= true; typeIds= [| 53217; 53218; 53219; 53220; 53221; 53222; 53223; 53224 |] } |> Some
      | 451 -> { GroupData.id= 451; name= "Bistot"; categoryId= 25; published= true; typeIds= [| 1223; 17428; 17429; 28388; 28389; 28390; 46676; 46692 |] } |> Some
      | 548 -> { GroupData.id= 548; name= "Interdiction Probe"; categoryId= 8; published= true; typeIds= [| 22778; 34260; 41402 |] } |> Some
      | 63 -> { GroupData.id= 63; name= "Hull Repair Unit"; categoryId= 7; published= true; typeIds= [| 524; 2355; 3653; 3655; 3663; 3665; 5683; 5693; 5697; 5719; 5721; 5723; 5743; 5745; 5747; 5755; 5757; 5759; 21504; 21506; 21508; 41511; 41512; 41513; 41514 |] } |> Some
      | 645 -> { GroupData.id= 645; name= "Drone Damage Modules"; categoryId= 7; published= true; typeIds= [| 4393; 4405; 32919; 32921; 32923; 32925; 33842; 33844; 33846; 33848; 41034 |] } |> Some
      | 742 -> { GroupData.id= 742; name= "Cyber Gunnery"; categoryId= 20; published= true; typeIds= [| 3185; 3188; 3189; 3190; 3191; 3192; 3193; 3194; 3195; 3196; 3197; 3198; 3199; 3200; 3201; 3202; 3203; 3204; 3205; 3206; 3207; 3208; 3209; 3210; 3211; 3212; 3213; 3214; 3215; 3216; 3217; 3220; 3221; 3222; 3223; 3224; 3225; 3226; 3227; 3228; 3229; 3230; 3231; 3232; 3233; 3234; 3235; 3236; 9957; 10204; 13166; 13217; 13218; 13219; 13220; 13221; 13222; 13223; 13224; 13225; 13244; 13245; 13246; 13252; 16249; 19686; 19687; 19688; 19689; 19690; 19691; 19692; 19693; 19694; 19695; 19696; 19697; 19698; 19699; 19700; 20443; 25867; 25868; 27075; 27076; 27077; 27078; 27079; 27080; 27081; 27082; 27083; 27084; 27085; 27086; 27087; 27088; 27089; 27090 |] } |> Some
      | 839 -> { GroupData.id= 839; name= "Cynosural System Jammer"; categoryId= 23; published= true; typeIds= [| 27674 |] } |> Some
      | _ -> None