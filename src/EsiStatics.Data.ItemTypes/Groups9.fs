﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups9=
    let getGroup id = 
      match id with 
      | 106 -> { GroupData.id= 106; name= "Cruiser Blueprint"; categoryId= 9; published= true; typeIds= [| 686; 687; 692; 968; 969; 970; 971; 972; 973; 974; 975; 976; 977; 978; 979; 2007; 2837; 3519; 11012; 11958; 11960; 11962; 11964; 11966; 11970; 11972; 11979; 11986; 11988; 11990; 11994; 11996; 12000; 12004; 12006; 12012; 12014; 12016; 12018; 12020; 12022; 12024; 17635; 17710; 17714; 17716; 17719; 17721; 17723; 17844; 17923; 20126; 29338; 29339; 29341; 29345; 32210; 32791; 33396; 33471; 33554; 33640; 33642; 33644; 33646; 33648; 33650; 33652; 33654; 33676; 33819; 34446; 34476; 34478; 34480; 34591; 35782; 42524; 45487; 45532; 45535; 47967; 48637; 49716; 49717; 52253 |] } |> Some
      | 1270 -> { GroupData.id= 1270; name= "Mobile Tractor Unit Blueprint"; categoryId= 9; published= true; typeIds= [| 33519; 33701; 33703 |] } |> Some
      | 1852 -> { GroupData.id= 1852; name= "Structure Engineering Rig L - Drone and Fighter Efficiency"; categoryId= 66; published= true; typeIds= [| 43712; 43713 |] } |> Some
      | 203 -> { GroupData.id= 203; name= "Sensor Backup Array"; categoryId= 7; published= true; typeIds= [| 1946; 1982; 1983; 1984; 1985; 2579; 2580; 2583; 2584; 2587; 2588; 2591; 2592; 4013; 4014; 6193; 6194; 6195; 6199; 6202; 6203; 6207; 6212; 6216; 6217; 6218; 6222; 6225; 6226; 6230; 6234; 6238; 6239; 6241; 6242; 6243; 6244; 6251; 6252; 6257; 6258; 6259; 6260; 6267; 6268; 6275; 6276; 6283; 6284; 6285; 6286; 6289; 6290; 6291; 6292; 20238; 20240; 20242; 20244; 20246; 20248; 20250; 20252; 20254; 20260; 20262; 20264; 21521; 21523; 21525; 21529 |] } |> Some
      | 300 -> { GroupData.id= 300; name= "Cyberimplant"; categoryId= 20; published= true; typeIds= [| 19534; 19535; 19536; 19537; 19538; 19539; 19540; 19551; 19553; 19554; 19555; 19556; 20121; 20157; 20158; 20159; 20160; 20161; 20498; 20499; 20500; 20501; 20502; 20503; 20504; 20505; 20506; 20507; 20508; 20509; 22107; 22108; 22109; 22110; 22111; 22112; 22113; 22114; 22115; 22116; 22117; 22118; 22119; 22120; 22121; 22122; 22123; 22124; 22125; 22126; 22127; 22128; 22129; 22130; 22131; 22133; 22134; 22135; 22136; 22137; 24343; 24344; 24345; 24346; 24347; 24485; 28790; 28791; 28792; 28793; 28794; 28795; 28796; 28797; 28798; 28799; 28800; 28801; 28802; 28803; 28804; 28805; 28806; 28807; 28808; 28809; 28810; 28811; 28812; 28813; 28814; 28815; 28816; 28817; 28818; 28819; 31954; 31955; 31956; 31957; 31958; 31959; 31962; 31963; 31964; 31965; 31966; 31967; 31968; 31969; 31970; 31971; 31972; 31973; 31974; 31975; 31976; 31977; 31978; 31979; 32101; 32102; 32103; 32104; 32105; 32107; 32108; 32109; 32110; 32111; 32112; 32113; 32114; 32115; 32116; 32117; 32118; 32119; 32120; 32121; 32122; 32123; 32124; 32125; 33068; 33516; 33525; 33526; 33527; 33528; 33529; 33555; 33557; 33559; 33561; 33563; 33565; 33917; 33918; 33919; 33920; 33921; 33922; 33923; 33924; 33925; 33926; 33927; 33928; 33929; 33930; 33931; 33932; 33933; 33934; 33935; 33936; 33937; 33938; 33939; 33940; 33941; 33942; 33943; 33944; 33945; 33946; 33947; 33948; 33949; 33950; 33951; 33952; 33953; 33954; 33955; 33956; 33957; 33958; 33959; 33960; 33961; 33962; 33963; 33964; 33965; 33966; 33967; 33968; 33969; 33970; 33971; 33972; 33973; 33974; 33975; 33976; 42145; 42146; 42200; 42201; 42202; 42203; 42204; 42205; 42206; 42207; 42208; 42209; 42210; 42211; 42212; 42213; 42214; 42215 |] } |> Some
      | 350858 -> { GroupData.id= 350858; name= "Infantry Weapons"; categoryId= 350001; published= false; typeIds= [| 350916; 351063; 351296; 351297; 351310; 351311; 351317; 351320; 351332; 351336; 351337; 351706; 351709; 351855; 352263; 352304; 352305; 352313; 352314; 352472; 352499; 352508; 352522; 352526; 352556; 352602; 352891; 353032; 353042; 353106; 353107; 353108; 353109; 353110; 353111; 353112; 353113; 353114; 353115; 353116; 353117; 353118; 353119; 353120; 353126; 353127; 353128; 353129; 353130; 353131; 353132; 353133; 353134; 353135; 353136; 353137; 353138; 353139; 353140; 353143; 353144; 353145; 353146; 353147; 353148; 353149; 353150; 353151; 353152; 353153; 353154; 353155; 353156; 353161; 353162; 353163; 353164; 353165; 353166; 353167; 353168; 353169; 353170; 353171; 353172; 353173; 353174; 353175; 353179; 353180; 353181; 353182; 353183; 353184; 353185; 353186; 353187; 353188; 353189; 353190; 353191; 353192; 353193; 353196; 353197; 353198; 353199; 353200; 353201; 353202; 353203; 353204; 353205; 353206; 353207; 353208; 353209; 353258; 353263; 353264; 353281; 353289; 353691; 353692; 353693; 353694; 353695; 353696; 353697; 353698; 353699; 353701; 353702; 353705; 353730; 353731; 353732; 353733; 353734; 353735; 353736; 353737; 353738; 353741; 353749; 353772; 353773; 353774; 353775; 353783; 353796; 353797; 353800; 353801; 353817; 353818; 353929; 354583; 354685; 354928; 354929; 354930; 354937; 354956; 354957; 354959; 354960; 354961; 354962; 354963; 354964; 355010; 355013; 355015; 355019; 355027; 355032; 355038; 355043; 355050; 355067; 355069; 355071; 355081; 355087; 355098; 355104; 355107; 355109; 355139; 355145; 355151; 355157; 355159; 355161; 355254; 355256; 355257; 355258; 355259; 355260; 355261; 355262; 355263; 355264; 355265; 355432; 355434; 355443; 355476; 355478; 355483; 355488; 355495; 355497; 355498; 355499; 355514; 355515; 355594; 355595; 355596; 355597; 355598; 355599; 355600; 355603; 355604; 355605; 355615; 355616; 355617; 355679; 355685; 355697; 355740; 355741; 355742; 355743; 355744; 355746; 355747; 355748; 355749; 355750; 355751; 355752; 355753; 355761; 355762; 355763; 355764; 355765; 355766; 355779; 355781; 355812; 355813; 355814; 355815; 355820; 355821; 355822; 355823; 355824; 355825; 355826; 355827; 355828; 355829; 355830; 355831; 355832; 355833; 355834; 355835; 355836; 355837; 355839; 355840; 355841; 355842; 355843; 355844; 355845; 355846; 355847; 355848; 355849; 355850; 355851; 355852; 355853; 355854; 355855; 355856; 355857; 355858; 355859; 355860; 355861; 355862; 355863; 355864; 355865; 355866; 355867; 355868; 355869; 355870; 355871; 355872; 355873; 355874; 355875; 355876; 355877; 355878; 355879; 355880; 355881; 355882; 355883; 355949; 355962; 355964; 355994; 356042; 356044; 356046; 356048; 356050; 356052; 356115; 356116; 356214; 356300; 356331; 356332; 356333; 356334; 356393; 356426; 356514; 356515; 356516; 356630; 356632; 356831; 356833; 356835; 356837; 356839; 356847; 356848; 356849; 356850; 356851; 356852; 356853; 356913; 356914; 356925; 363069; 363105; 363106; 363107; 363309; 363350; 363351; 363355; 363356; 363357; 363358; 363359; 363394; 363395; 363396; 363398; 363406; 363408; 363491; 363551; 363570; 363578; 363592; 363604; 363770; 363774; 363775; 363780; 363781; 363782; 363783; 363784; 363785; 363786; 363787; 363794; 363796; 363797; 363798; 363800; 363801; 363848; 363849; 363850; 363851; 363852; 363857; 363858; 364102; 364103; 364200; 364201; 364331; 364332; 364333; 364334; 364559; 364561; 364563; 364786; 364787; 364788; 365409; 365441; 365442; 365443; 365444; 365447; 365448; 365449; 365450; 365451; 365452; 365453; 365454; 365455; 365456; 365457; 365458; 365459; 365460; 365566; 365567; 365568; 365569; 365570; 365572; 365573; 365574; 365575; 365576; 365577; 365578; 365579; 365580; 365581; 365623; 365624; 365625; 365626; 365627; 365628; 365629; 365630; 365631; 365632; 365633; 365634; 365635; 365636; 365650; 365651; 365652; 365654; 365655; 365656; 365657; 365658; 365659; 365660; 365661; 365662; 365663; 365664; 365665; 365666; 365667; 365668; 365669; 365670; 365671; 365673; 365674; 365675; 365676; 365677; 365678; 365679; 365680; 365681; 365682; 365683; 365684; 365685; 365686; 365687; 365688; 365689; 365690; 365691; 365692; 365693; 366009; 366014; 366015; 366094; 366095; 366096; 366097; 366098; 366099; 366100; 366101; 366102; 366103; 366344; 366345; 366372; 366373; 366374; 366375; 366376; 366377; 366378; 366379; 366380; 366381; 366385; 366386; 366387; 366388; 366389; 366390; 366424; 366425; 366426; 366427; 366428; 366429; 366430; 366431; 366432; 366433; 366434; 366452; 366453; 366454; 366455; 366456; 366457; 366458; 366459; 366460; 366461; 366462; 366463; 366464; 366495; 366496; 366497; 366498; 366499; 366500; 366501; 366502; 366503; 366504; 366505; 366506; 366510; 366511; 366512; 366513; 366514; 366515; 366516; 366517; 366518; 366519; 366520; 366521; 367223; 367226; 367227; 367228; 367229; 367230; 367436; 367437; 367439; 367440; 367472; 367477; 367489; 367500; 367502; 367511; 367517; 367519; 367528; 367541; 367548; 367549; 367552; 367586; 367587; 367589; 367590; 367591; 367592; 367621; 367622; 367623; 367624; 367625; 367627; 367628; 367629; 367630; 367631; 367632; 367633; 367813; 367848; 367992; 367994; 367996; 368014; 368015; 368016; 368245; 368519; 368540; 368541; 368542; 368543; 368544; 368545; 368556; 368557; 368558; 368559; 368560; 368561; 368562; 368563; 368564; 368565; 368566; 368567; 368568; 368587; 368588; 368589; 368590; 368591; 368592; 368593; 368595; 368596; 368597; 368598; 368599; 368600; 368601; 368602; 368603; 368604; 368605; 368606; 368607; 368608; 368609; 368610; 368611; 368612; 371027 |] } |> Some
      | 354641 -> { GroupData.id= 354641; name= "Infantry Skill Enhancers"; categoryId= 350001; published= false; typeIds= [| 354643; 354644; 355210; 355217; 355218; 355219; 355558; 355561; 355976; 355977; 355978; 355979; 364094; 364101; 364471; 364472; 364477; 364478; 364479; 365433; 365434; 365435; 365446; 365909; 365912; 365913; 365914; 365915; 365916; 365917; 365918; 365919; 365920; 365921; 365922; 365923; 365924; 365925; 365926; 366022; 366023; 366024; 366025; 366229; 366230; 366231; 366232; 366233; 366234; 366235; 366236; 366237; 366238; 366239; 366240; 366241; 366242; 366243; 366244; 366245; 366246; 366247; 366248; 366249; 366250; 366251; 366252; 369233 |] } |> Some
      | 397 -> { GroupData.id= 397; name= "Assembly Array"; categoryId= 23; published= true; typeIds= [| 13780; 16220; 24574; 24575; 24653; 24654; 24655; 24656; 24657; 24658; 24659; 24660; 25305; 29613; 30389; 33867 |] } |> Some
      | 494 -> { GroupData.id= 494; name= "Deadspace Overseer's Structure"; categoryId= 11; published= false; typeIds= [| 17135; 17179; 17273; 17275; 17388; 17390; 17422; 17563; 17613; 17614; 17631; 17632; 17633; 17645; 17747; 17748; 17799; 17818; 17820; 17821; 17822; 17891; 17979; 17994; 18632; 18633; 18634; 18645; 19426; 19427; 19487; 19501; 19502; 19504; 19557; 19558; 19559; 19560; 19561; 19562; 19565; 19588; 19590; 19622; 19653; 19708; 19714; 19715; 19716; 19738; 19742; 19795; 19957; 20102; 20162; 20166; 20196; 20282; 20283; 20284; 20285; 20325; 20326; 20329; 20523; 20542; 21459; 21519; 21600; 21617; 21622; 21627; 21635; 21861; 21884; 22031; 22039; 22047; 22059; 22098; 22145; 22156; 22158; 22161; 22182; 22184; 22232; 22241; 22289; 22320; 22704; 22709; 22710; 22725; 22739; 22750; 22757; 22794; 23240; 23413; 23514; 23520; 23522; 23567; 23593; 23600; 23617; 23642; 23688; 23689; 23691; 23695; 23696; 23908; 23960; 23964; 24243; 24256; 24257; 24262; 24351; 24356; 24579; 24670; 24671; 24751; 24761; 24771; 25360; 25377; 25384; 25388; 25402; 25717; 25734; 26168; 26247; 26248; 26249; 26250; 26251; 26606; 26731; 26733; 26735; 26736; 26738; 27279; 27292; 33910; 41589 |] } |> Some
      | 688 -> { GroupData.id= 688; name= "Mission Khanid Destroyer"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 882 -> { GroupData.id= 882; name= "Enslavement Programs"; categoryId= 24; published= false; typeIds= [| 30347; 30353; 30354; 30355; 30356; 30357; 30358 |] } |> Some
      | 9 -> { GroupData.id= 9; name= "Asteroid Belt"; categoryId= 2; published= false; typeIds= [| 15; 17774 |] } |> Some
      | 979 -> { GroupData.id= 979; name= "Decryptors - Hybrid"; categoryId= 35; published= true; typeIds= [| 30382; 30383; 30384; 30385 |] } |> Some
      | _ -> None