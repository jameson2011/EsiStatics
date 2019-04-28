namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups61=
    let getGroup id = 
      match id with 
      | 1031 -> { GroupData.id= 1031; name= "Planetary Resources"; categoryId= 17; published= true; typeIds= [|  |] } |> Some
      | 1225 -> { GroupData.id= 1225; name= "Tournament Cards: Alliance Tournament All Stars"; categoryId= 63; published= true; typeIds= [| 33223; 33224; 33225; 33226; 33227; 33228; 33229; 33230; 33231; 33232; 33373; 33374; 33385; 33386; 33387; 33388; 33389; 33390; 33391; 33392 |] } |> Some
      | 1322 -> { GroupData.id= 1322; name= "Structure Resource Processing Service Module"; categoryId= 66; published= true; typeIds= [| 35899; 45537; 45538; 45539 |] } |> Some
      | 158 -> { GroupData.id= 158; name= "Hull Mods Blueprint"; categoryId= 9; published= true; typeIds= [| 1237; 1245; 1318; 1320; 1334; 1336; 1404; 1406; 2604; 2606; 21492; 21494; 21497; 21499; 21501; 21856; 33982; 33984; 33986; 34123; 34125; 34127 |] } |> Some
      | 1613 -> { GroupData.id= 1613; name= "Structure Combat Rig M - Missile Application"; categoryId= 66; published= true; typeIds= [| 37216; 37217 |] } |> Some
      | 1807 -> { GroupData.id= 1807; name= "Hidden Zenith Minmatar Capital"; categoryId= 11; published= false; typeIds= [| 42849 |] } |> Some
      | 2001 -> { GroupData.id= 2001; name= "Citizen Ships"; categoryId= 6; published= false; typeIds= [| 48648 |] } |> Some
      | 255 -> { GroupData.id= 255; name= "Gunnery"; categoryId= 16; published= true; typeIds= [| 3300; 3301; 3302; 3303; 3304; 3305; 3306; 3307; 3308; 3309; 3310; 3311; 3312; 3315; 3316; 3317; 11082; 11083; 11084; 12201; 12202; 12203; 12204; 12205; 12206; 12207; 12208; 12209; 12210; 12211; 12212; 12213; 12214; 12215; 20327; 21666; 21667; 22043; 24563; 32856; 41403; 41404; 41405; 41406; 41407; 41408; 41537; 47870; 47871; 47872; 47873; 47874; 47875 |] } |> Some
      | 352 -> { GroupData.id= 352; name= "Auxiliary Power Core Blueprint"; categoryId= 9; published= true; typeIds= [| 4255; 11564; 28741 |] } |> Some
      | 367594 -> { GroupData.id= 367594; name= "Visual Customization"; categoryId= 350001; published= false; typeIds= [| 367600; 367677; 367679; 367681; 367685; 367687; 367689; 367691; 367693; 367695; 367697; 367699; 367701; 367703; 367705; 367707; 367709; 367711; 367713; 367715; 367811; 367854; 367856; 367863; 367864; 367948; 367955; 367959; 367960; 367963; 367987; 367988; 367989; 367998; 367999; 368000; 368001; 368003; 368022; 368023; 368024; 368025; 368026 |] } |> Some
      | 449 -> { GroupData.id= 449; name= "Mobile Hybrid Sentry"; categoryId= 23; published= true; typeIds= [| 16690; 16691; 16692; 17402; 17403; 17404; 27542; 27544; 27545; 27547; 27613; 27615; 27616; 27618; 27619; 27621; 27622; 27624 |] } |> Some
      | 546 -> { GroupData.id= 546; name= "Mining Upgrade"; categoryId= 7; published= true; typeIds= [| 22542; 22576; 22609; 22611; 22613; 22615; 22617; 22619; 22621; 22623; 28576; 28578; 49792 |] } |> Some
      | 61 -> { GroupData.id= 61; name= "Capacitor Battery"; categoryId= 7; published= true; typeIds= [| 522; 1185; 2018; 2020; 2022; 3472; 3480; 3488; 3496; 3504; 4745; 4747; 4749; 4751; 4785; 4787; 4789; 4791; 4869; 4871; 4873; 4875; 4909; 4911; 4913; 4915; 6073; 6083; 6097; 6111; 23801; 23803; 23805; 41212; 41213; 41214; 41215; 41216; 41217; 41218; 41219; 41220; 41484; 41485; 41486; 41487; 41488; 48431; 48435; 48439 |] } |> Some
      | 643 -> { GroupData.id= 643; name= "Carrier Blueprint"; categoryId= 9; published= true; typeIds= [| 23758; 23912; 23916; 24484; 42134 |] } |> Some
      | 740 -> { GroupData.id= 740; name= "Cyber Electronic Systems"; categoryId= 20; published= true; typeIds= [| 3271; 3272; 3273; 3277; 3278; 3279; 3280; 3281; 3282; 3283; 3284; 3287; 3288; 3289; 3290; 13232; 13234; 13235; 13236; 27224; 27225; 27226; 27230; 27231; 27232; 27233; 27234; 27235; 27236; 27237; 47261; 47262; 47263; 50053; 50066; 50067 |] } |> Some
      | 837 -> { GroupData.id= 837; name= "Energy Neutralizing Battery"; categoryId= 23; published= true; typeIds= [| 27672; 27855; 27856; 27857; 27858 |] } |> Some
      | 934 -> { GroupData.id= 934; name= "Zombie Entities"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | _ -> None