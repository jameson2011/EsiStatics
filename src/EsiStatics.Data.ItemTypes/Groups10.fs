﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups10=
    let getGroup id = 
      match id with 
      | 10 -> { GroupData.id= 10; name= "Stargate"; categoryId= 2; published= false; typeIds= [| 16; 17; 3873; 3874; 3875; 3876; 3877; 12292; 29624; 29625; 29626; 29627; 29628; 29629; 29630; 29631; 29632; 29633; 29634; 29635 |] } |> Some
      | 107 -> { GroupData.id= 107; name= "Battleship Blueprint"; categoryId= 9; published= true; typeIds= [| 688; 693; 994; 995; 996; 997; 998; 999; 4006; 11937; 11939; 13203; 17637; 17727; 17729; 17733; 17737; 17739; 17741; 17919; 17921; 22429; 22431; 22437; 22441; 24689; 24691; 24693; 24695; 26843; 28660; 28662; 28666; 28711; 32306; 32308; 32310; 32312; 33473; 33624; 33626; 33628; 33630; 33632; 33634; 33636; 33638; 33821; 34119; 34153; 34214; 34216; 34218; 34220; 34222; 34224; 34226; 34228; 34230; 34232; 34234; 34236; 34238; 34240; 34242; 34244; 34246; 34248; 34250; 34252; 34254; 34256; 34258; 34442; 34458; 34460; 34462; 34464; 34466; 34468; 34470; 34472; 45528; 47716; 47968 |] } |> Some
      | 1174 -> { GroupData.id= 1174; name= "Asteroid Rogue Drone Officer"; categoryId= 11; published= false; typeIds= [| 32959; 32960; 32961; 32962 |] } |> Some
      | 1271 -> { GroupData.id= 1271; name= "Prosthetics"; categoryId= 30; published= true; typeIds= [| 33549; 33550; 33551; 33552; 34017; 34018; 34019; 34020; 34021; 34022; 34023; 34024; 34025; 34026; 34027; 34028; 34029; 34030; 34031; 34032; 34033; 34034; 34035; 34036; 34037; 34038; 34039; 34040; 34041; 34042; 34043; 34044 |] } |> Some
      | 1465 -> { GroupData.id= 1465; name= "Mission Generic Supercarrier"; categoryId= 11; published= false; typeIds= [| 36848 |] } |> Some
      | 1562 -> { GroupData.id= 1562; name= "Structure Multirole Missile Launcher"; categoryId= 66; published= true; typeIds= [| 35922; 47298 |] } |> Some
      | 1853 -> { GroupData.id= 1853; name= "Structure Engineering Rig L - Basic Small Ship Efficiency"; categoryId= 66; published= true; typeIds= [| 43714; 43715 |] } |> Some
      | 1950 -> { GroupData.id= 1950; name= "Permanent SKIN"; categoryId= 91; published= true; typeIds= [| 34599; 34600; 34601; 34602; 34603; 34604; 34605; 34606; 34607; 34608; 34609; 34610; 34611; 34612; 34613; 34614; 34615; 34616; 34617; 34618; 34619; 34620; 34621; 34623; 34624; 34625; 34626; 34627; 34628; 34629; 34630; 34631; 34632; 34633; 34634; 34635; 34636; 34637; 34638; 34639; 34640; 34641; 34642; 34643; 34645; 34646; 34647; 34648; 34649; 34650; 34651; 34652; 34653; 34654; 34655; 34656; 34657; 34658; 34659; 34660; 34661; 34662; 34663; 34664; 34665; 34666; 34667; 34668; 34669; 34670; 34671; 34672; 34673; 34674; 34675; 34676; 34677; 34678; 34679; 34680; 34681; 34682; 34683; 34684; 34685; 34686; 34687; 34688; 34689; 34690; 34691; 34692; 34693; 34694; 34695; 34696; 34697; 34698; 34699; 34700; 34701; 34702; 34703; 34704; 34705; 34706; 34707; 34708; 34709; 34710; 34711; 34712; 34713; 34714; 34715; 34716; 34718; 34719; 34720; 34721; 34722; 34723; 34724; 34725; 34726; 34727; 34728; 34729; 34730; 34731; 34732; 34733; 34734; 34735; 34736; 34737; 34738; 34739; 34740; 34741; 34742; 34743; 34744; 34745; 34746; 34747; 34748; 34749; 34750; 34751; 34752; 34753; 34754; 34755; 34756; 34757; 34758; 34759; 34760; 34786; 34787; 34788; 34789; 34790; 34791; 34792; 34795; 34796; 34797; 34798; 34799; 34800; 34801; 34802; 34805; 34808; 34809; 34810; 34811; 34812; 34813; 34814; 34815; 34816; 34817; 34818; 34819; 34820; 34821; 34822; 34823; 35690; 35695; 35700; 35705; 36274; 36275; 36276; 36277; 36278; 36279; 36280; 36281; 36282; 36283; 36284; 36285; 36286; 36287; 36288; 36289; 36290; 36291; 36292; 36293; 36294; 36295; 36296; 36297; 36298; 36299; 36300; 36301; 36302; 36303; 36304; 36305; 36306; 36307; 36308; 36309; 36310; 36311; 36312; 36313; 36314; 36315; 36316; 36317; 36318; 36319; 36320; 36321; 36322; 36323; 36324; 36325; 36326; 36327; 36328; 36329; 36330; 36331; 36332; 36333; 36334; 36335; 36336; 36337; 36338; 36339; 36340; 36341; 36342; 36343; 36344; 36345; 36346; 36347; 36348; 36349; 36350; 36351; 36352; 36353; 36354; 36355; 36356; 36357; 36358; 36359; 36360; 36361; 36362; 36363; 36364; 36365; 36366; 36367; 36368; 36369; 36370; 36371; 36372; 36373; 36374; 36375; 36376; 36377; 36378; 36379; 36380; 36381; 36382; 36383; 36384; 36385; 36386; 36387; 36388; 36389; 36390; 36391; 36392; 36393; 36394; 36395; 36396; 36397; 36398; 36399; 36400; 36401; 36402; 36403; 36404; 36405; 36406; 36407; 36408; 36409; 36410; 36411; 36412; 36413; 36414; 36415; 36416; 36417; 36418; 36419; 36420; 36421; 36422; 36423; 36424; 36425; 36426; 36427; 36428; 36429; 36430; 36431; 36432; 36433; 36434; 36435; 36436; 36437; 36438; 36439; 36440; 36441; 36442; 36443; 36444; 36445; 36446; 36447; 36448; 36449; 36450; 36451; 36452; 36453; 36454; 36455; 36456; 36457; 36458; 36517; 36518; 36519; 36520; 36522; 36633; 36634; 36635; 36636; 36637; 36638; 36639; 36640; 36641; 36642; 36643; 36644; 36645; 36646; 36647; 36648; 36649; 36650; 36651; 36652; 36653; 36654; 36655; 36656; 36657; 36658; 36659; 36660; 36661; 36662; 36663; 36664; 36665; 36666; 36667; 36668; 36669; 36670; 36671; 36672; 36673; 36674; 36675; 36676; 36677; 36678; 36705; 36706; 36707; 36708; 36709; 36710; 36711; 36712; 36713; 36714; 36715; 36716; 36717; 36718; 36719; 36720; 36721; 36722; 36723; 36724; 36725; 36726; 36727; 36728; 36729; 36730; 36731; 36732; 36733; 36734; 36735; 36736; 36737; 36738; 36739; 36740; 36741; 36742; 36743; 36744; 36745; 36746; 36747; 36748; 36749; 36750; 36751; 36752; 36753; 36754; 36755; 36756; 36757; 36758; 36759; 36760; 36761; 36762; 36763; 36764; 36765; 36766; 36767; 36768; 36769; 36770; 36771; 36772; 36773; 36774; 36775; 36776; 36777; 36778; 36779; 36780; 36781; 36782; 36783; 36784; 36785; 36786; 36787; 36788; 36789; 36790; 36791; 36792; 36793; 36794; 36795; 36796; 36797; 36798; 36799; 36800; 36801; 36802; 36803; 36804; 36805; 36806; 36807; 36808; 36809; 36810; 36811; 36812; 36813; 36814; 36815; 36816; 36817; 36818; 36819; 36820; 36821; 36822; 36823; 36824; 36825; 36826; 36827; 36828; 36829; 36830; 36831; 36832; 36833; 36834; 36835; 36836; 36837; 36838; 36839; 36840; 36841; 36842; 36843; 36844; 36854; 36913; 36914; 36915; 36916; 36951; 36982; 36983; 36984; 36985; 36986; 36987; 36988; 36989; 36990; 36991; 36992; 36993; 36994; 37055; 37056; 37057; 37089; 37090; 37091; 37092; 37093; 37094; 37095; 37096; 37097; 37098; 37099; 37100; 37101; 37102; 37103; 37104; 37105; 37106; 37107; 37108; 37109; 37110; 37111; 37112; 37113; 37114; 37115; 37116; 37117; 37118; 37119; 37120; 37121; 37122; 37123; 37124; 37125; 37126; 37127; 37128; 37129; 37130; 37131; 37132; 37133; 37134; 37484; 37485; 37486; 37487; 37488; 37489; 37490; 37491; 37492; 37493; 37494; 37495; 37496; 37497; 37498; 37499; 37500; 37501; 37502; 37503; 37504; 37505; 37506; 37507; 37508; 37509; 37510; 37511; 37512; 37513; 37514; 37515; 37516; 37517; 37518; 37519; 37520; 37521; 37522; 37523; 37524; 37525; 37526; 37527; 37528; 37529; 37547; 37548; 37549; 37550; 37551; 37552; 37553; 37554; 37555; 37556; 37557; 37558; 37559; 37560; 37561; 37562; 37563; 37564; 37565; 37566; 37567; 37568; 37569; 37570; 37571; 37572; 37573; 37574; 37575; 37576; 37577; 37578; 37579; 37580; 37581; 37582; 37583; 37584; 37585; 37586; 37587; 37588; 37589; 37590; 37591; 37592; 37593; 37594; 37595; 37632; 37637; 37642; 37647; 37652; 37657; 37662; 37667; 37672; 37677; 37682; 37687; 37692; 37697; 37702; 37707; 37712; 37717; 37722; 37727; 37732; 37737; 37742; 37747; 37752; 37757; 37762; 37767; 37772; 37777; 37782; 37787; 37867; 37868; 37869; 37897; 37898; 37899; 37900; 37901; 37902; 37903; 37904; 37905; 37907; 37908; 37909; 37910; 37911; 37912; 37913; 37914; 37915; 37916; 37917; 37921; 37922; 37923; 37928; 37933; 37938; 37939; 37940; 37941; 37942; 37943; 37944; 37945; 37947; 37948; 37949; 37950; 37951; 37952; 37953; 37954; 37955; 37956; 37957; 37958; 37959; 37960; 37961; 37962; 37965; 37966; 37967; 37968; 37969; 37970; 37971; 37972; 37973; 37974; 37979; 37984; 37989; 37994; 37999; 38004; 38009; 38014; 38019; 38024; 38029; 38034; 38039; 38044; 38049; 38054; 38059; 38064; 38069; 38074; 38079; 38084; 38089; 38094; 38099; 38104; 38109; 38114; 38119; 38124; 38129; 38134; 38139; 38140; 38146; 38147; 38148; 38149; 38150; 38155; 38160; 38165; 38170; 38175; 38180; 38185; 38190; 38195; 38200; 38205; 38210; 38211; 38212; 38213; 38214; 38215; 38216; 38217; 38218; 38219; 38220; 38221; 38222; 38227; 38232; 38237; 38242; 38247; 38252; 38257; 38262; 38267; 38272; 38277; 38282; 38287; 38292; 38297; 38302; 38307; 38312; 38317; 38322; 38327; 38332; 38337; 38342; 38347; 38352; 38357; 38362; 38367; 38372; 38377; 38382; 38387; 38392; 38393; 38394; 38395; 38396; 38397; 38398; 38399; 38400; 38402; 38403; 38404; 38409; 38414; 38419; 38424; 38429; 38434; 38439; 38444; 38449; 38454; 38459; 38464; 38469; 38474; 38479; 38484; 38489; 38494; 38499; 38504; 38509; 38514; 38519; 38524; 38529; 38534; 38539; 38544; 38549; 38554; 38559; 38564; 38569; 38574; 38579; 38584; 38589; 38594; 38599; 38604; 38609; 38614; 38619; 38620; 38621; 38622; 38623; 38624; 38625; 38626; 38627; 38628; 38629; 38630; 38632; 38637; 38642; 38647; 38652; 38653; 38654; 38655; 38656; 38664; 38669; 38674; 38679; 38684; 38689; 38694; 38699; 38704; 38709; 38714; 38719; 38724; 38729; 38734; 38739; 38744; 38749; 38754; 38759; 38764; 38769; 38774; 38779; 38784; 38789; 38794; 38799; 38804; 38809; 38814; 38819; 38824; 38829; 38834; 38839; 38844; 38849; 38854; 38859; 38864; 38869; 38874; 38879; 38884; 38889; 38894; 38899; 38904; 38909; 38914; 38919; 38924; 38929; 38934; 38939; 38944; 38949; 38954; 38959; 38964; 38969; 38974; 38979; 38984; 38989; 38994; 38999; 39004; 39009; 39014; 39019; 39024; 39029; 39034; 39039; 39044; 39049; 39054; 39059; 39064; 39069; 39074; 39079; 39084; 39089; 39094; 39099; 39104; 39109; 39114; 39119; 39124; 39129; 39134; 39139; 39144; 39149; 39154; 39159; 39164; 39169; 39174; 39179; 39184; 39189; 39194; 39199; 39204; 39209; 39214; 39219; 39224; 39229; 39234; 39239; 39244; 39249; 39254; 39259; 39264; 39269; 39274; 39279; 39284; 39289; 39294; 39299; 39304; 39309; 39314; 39319; 39324; 39329; 39334; 39339; 39344; 39349; 39354; 39359; 39364; 39369; 39374; 39379; 39384; 39389; 39394; 39399; 39404; 39409; 39414; 39419; 39424; 39429; 39434; 39439; 39444; 39449; 39454; 39459; 39464; 39469; 39474; 39479; 39484; 39489; 39494; 39499; 39504; 39509; 39514; 39519; 39524; 39529; 39534; 39539; 39544; 39549; 39554; 39559; 39564; 39569; 39574; 39584; 39585; 39586; 39591; 39596; 39601; 39606; 39611; 39616; 39621; 39626; 39631; 39636; 39641; 39646; 39651; 39656; 39661; 39666; 39671; 39676; 39681; 39686; 39691; 39696; 39701; 39706; 39711; 39716; 39721; 39726; 39731; 39736; 39741; 39746; 39751; 39756; 39761; 39766; 39771; 39776; 39781; 39786; 39791; 39796; 39801; 39806; 39811; 39816; 39821; 39826; 39831; 39836; 39841; 39846; 39851; 39856; 39861; 39866; 39871; 39876; 39881; 39886; 39891; 39896; 39901; 39906; 39911; 39916; 39921; 39926; 39931; 39936; 39941; 39946; 39951; 39956; 39961; 39966; 39971; 39976; 39981; 39986; 39991; 39996; 40001; 40006; 40011; 40016; 40021; 40026; 40031; 40036; 40041; 40046; 40051; 40056; 40061; 40066; 40071; 40076; 40081; 40086; 40091; 40096; 40101; 40106; 40111; 40116; 40121; 40126; 40131; 40136; 40141; 40146; 40151; 40156; 40161; 40166; 40171; 40176; 40181; 40186; 40191; 40196; 40201; 40206; 40211; 40216; 40221; 40226; 40231; 40236; 40241; 40246; 40251; 40256; 40261; 40266; 40271; 40276; 40281; 40286; 40291; 40296; 40319; 40320; 40321; 40322; 40323; 40324; 40325; 40326; 40329; 40330; 40331; 40332; 40333; 40366; 40371; 40376; 40381; 40386; 40391; 40396; 40401; 40406; 40411; 40416; 40421; 40426; 40431; 40436; 40441; 40446; 40451; 40467; 40468; 40469; 40470; 40471; 40472; 40473; 40474; 40475; 40476; 40477; 40478; 40479; 40480; 40481; 40482; 40484; 40485; 40486; 40487; 40488; 40489; 40490; 40491; 40492; 40493; 40495; 40496; 40497; 40498; 40499; 40500; 40501; 40502; 40503; 40504; 40505; 40506; 40507; 40508; 40509; 40510; 40511; 40512; 40513; 40514; 40515; 40516; 40517; 40579; 40580; 40581; 40582; 40583; 40584; 40585; 40586; 40587; 40588; 40589; 40590; 40591; 40592; 40593; 40594; 40595; 40596; 40597; 40598; 40599; 40600; 40601; 40602; 40603; 40604; 40605; 40606; 40607; 40608; 40609; 40610; 40611; 40612; 40613; 40614; 40615; 40616; 40617; 40618; 40619; 40620; 40621; 40622; 40623; 40624; 40625; 40626; 40695; 40770; 40771; 40772; 40773; 40774; 40778; 40783; 40788; 40793; 40798; 40803; 40808; 40813; 40818; 40823; 40828; 40833; 40838; 40843; 40848; 40853; 40858; 40863; 40868; 40873; 40878; 40883; 40888; 40893; 40898; 40903; 40908; 40913; 40918; 40923; 40928; 40933; 40938; 40943; 40948; 40953; 40958; 40963; 40968; 40973; 40978; 40983; 40988; 40993; 40998; 41003; 41008; 41013; 41018; 41419; 41420; 41421; 41579; 41580; 41586; 41587; 41588; 41680; 41681; 41682; 41683; 41684; 41685; 41686; 41687; 41770; 41775; 41780; 41785; 41790; 41795; 41800; 41805; 41810; 41815; 41820; 41825; 41830; 41835; 41840; 41845; 41850; 41855; 41860; 41865; 41870; 41875; 41880; 41885; 41890; 41895; 41900; 41905; 41910; 41915; 41920; 41925; 41930; 41935; 41940; 41945; 41950; 41955; 41960; 41965; 41970; 41975; 41980; 41985; 41990; 41995; 42000; 42005; 42010; 42015; 42020; 42025; 42030; 42035; 42040; 42045; 42050; 42055; 42060; 42065; 42070; 42075; 42080; 42085; 42090; 42095; 42100; 42105; 42110; 42147; 42148; 42149; 42150; 42151; 42152; 42153; 42154; 42155; 42156; 42157; 42158; 42159; 42160; 42161; 42162; 42163; 42164; 42165; 42166; 42167; 42168; 42169; 42170; 42171; 42172; 42173; 42174; 42175; 42176; 42177; 42178; 42179; 42180; 42181; 42182; 42183; 42184; 42185; 42186; 42187; 42188; 42189; 42190; 42191; 42192; 42193; 42194; 42195; 42196; 42197; 42198; 42199; 42216; 42221; 42247; 42252; 42257; 42262; 42267; 42272; 42277; 42282; 42287; 42292; 42297; 42302; 42307; 42312; 42317; 42322; 42327; 42332; 42337; 42342; 42347; 42352; 42357; 42362; 42367; 42372; 42377; 42382; 42387; 42392; 42397; 42402; 42407; 42412; 42417; 42422; 42427; 42432; 42437; 42442; 42447; 42452; 42457; 42462; 42467; 42472; 42477; 42482; 42487; 42492; 42497; 42502; 42507; 42542; 42543; 42544; 42545; 42546; 42547; 42548; 42549; 42550; 42551; 42552; 42553; 42554; 42555; 42556; 42557; 42558; 42559; 42560; 42561; 42562; 42563; 42564; 42565; 42566; 42567; 42568; 42569; 42570; 42571; 42572; 42573; 42574; 42575; 42576; 42577; 42578; 42579; 42580; 42581; 42582; 42583; 42584; 42585; 42586; 42587; 42588; 42589; 42590; 42591; 42592; 42593; 42594; 42595; 42596; 42597; 42598; 42599; 42600; 42614; 42615; 42616; 42617; 42618; 42619; 42620; 42621; 42622; 42623; 42624; 42625; 42641; 42642; 42643; 42644; 42645; 42646; 42647; 42648; 42649; 42650; 42651; 42652; 42653; 42671; 42672; 42673; 42674; 42675; 42676; 42677; 42678; 42679; 42680; 42681; 42682; 42746; 42747; 42748; 42749; 42750; 42751; 42752; 42753; 42754; 42755; 42756; 42757; 42758; 42759; 42760; 42761; 42762; 42763; 42764; 42765; 42766; 42767; 42768; 42769; 42770; 42771; 42772; 42773; 42774; 42775; 42776; 42777; 42778; 42779; 42780; 42781; 42782; 42783; 42784; 42785; 42786; 42787; 42788; 42789; 42790; 42791; 42792; 42793; 42794; 42795; 42796; 42797; 42798; 42799; 42800; 42907; 42908; 42909; 42910; 42915; 42920; 42925; 42930; 42935; 42940; 42945; 42950; 42955; 42960; 42965; 42970; 42975; 42980; 42985; 42990; 42995; 43000; 43005; 43010; 43015; 43020; 43025; 43030; 43035; 43040; 43045; 43050; 43055; 43060; 43065; 43070; 43075; 43080; 43085; 43090; 43095; 43100; 43105; 43110; 43115; 43120; 43125; 43130; 43135; 43140; 43145; 43150; 43155; 43160; 43165; 43170; 43175; 43180; 43185; 43190; 43195; 43200; 43205; 43210; 43215; 43220; 43225; 43230; 43235; 43240; 43245; 43250; 43255; 43260; 43265; 43270; 43275; 43280; 43285; 43290; 43295; 43300; 43305; 43310; 43315; 43320; 43325; 43330; 43335; 43340; 43345; 43350; 43355; 43360; 43365; 43370; 43375; 43380; 43385; 43390; 43395; 43400; 43405; 43410; 43482; 43483; 43484; 43485; 43486; 43487; 43488; 43489; 43490; 43491; 43492; 43493; 43494; 43495; 43496; 43497; 43498; 43499; 43500; 43501; 43502; 43503; 43504; 43505; 43506; 43507; 43508; 43509; 43510; 43511; 43512; 43513; 43514; 43515; 43516; 43517; 43518; 43519; 43520; 43521; 43522; 43523; 43524; 43525; 43526; 43527; 43528; 43529; 43530; 43531; 43532; 43533; 43534; 43535; 43536; 43537; 43538; 43539; 43666; 43667; 43668; 43669; 43670; 43671; 43672; 43673; 43674; 43675; 43676; 43749; 43750; 43751; 43752; 43753; 43754; 43755; 43756; 43757; 43758; 43759; 43760; 43761; 43762; 43763; 43764; 43765; 43766; 43767; 43768; 43769; 43770; 43771; 43772; 43773; 43774; 43776; 43777; 43778; 43779; 43780; 43781; 43782; 43783; 43784; 43785; 43786; 43787; 43788; 43789; 43790; 43791; 43792; 43793; 43794; 43795; 43796; 43797; 43798; 43799; 43800; 43801; 43802; 43803; 43804; 43805; 43806; 43807; 43808; 43809; 43810; 43811; 43812; 43813; 43814; 43815; 43816; 43817; 43818; 43819; 43820; 43821; 43822; 43823; 43824; 43825; 43826; 43827; 43828; 43829; 43830; 43831; 43832; 43833; 43834; 43835; 43836; 43837; 43838; 43839; 43840; 43841; 43842; 43843; 43844; 43845; 43846; 43847; 43848; 43849; 43850; 43851; 43852; 43853; 43935; 44068; 44069; 44070; 44071; 44072; 44101; 44127; 44134; 44135; 44136; 44137; 44138; 44139; 44140; 44141; 44142; 44143; 44144; 44145; 44146; 44147; 44148; 44149; 44150; 44151; 44152; 44153; 44154; 44155; 44156; 44157; 44158; 44159; 44160; 44161; 44162; 44163; 44164; 44165; 44166; 44167; 44168; 44169; 44170; 44171; 44172; 44173; 44174; 44175; 44176; 44177; 44178; 44179; 44180; 44181; 44182; 44183; 44184; 44185; 44186; 44200; 44201; 44202; 44203; 44218; 44219; 44220; 44229; 44230; 44231; 44232; 44233; 44234; 44235; 44236; 44237; 44238; 44239; 44240; 44241; 44242; 44254; 44255; 44256; 44257; 44258; 44259; 44280; 44282; 44287; 44292; 44297; 44302; 44307; 44312; 44317; 44322; 44327; 44332; 44337; 44342; 44347; 44352; 44357; 44362; 44367; 44372; 44377; 44382; 44387; 44392; 44397; 44402; 44407; 44412; 44417; 44422; 44427; 44432; 44437; 44442; 44447; 44452; 44457; 44462; 44467; 44472; 44477; 44482; 44487; 44492; 44497; 44502; 44507; 44512; 44517; 44522; 44527; 44532; 44537; 44542; 44547; 44552; 44557; 44562; 44567; 44572; 44577; 44582; 44587; 44592; 44597; 44602; 44607; 44612; 44617; 44622; 44627; 44632; 44637; 44642; 44647; 44652; 44657; 44662; 44667; 44672; 44677; 44682; 44687; 44692; 44697; 44702; 44707; 44712; 44717; 44722; 44727; 44732; 44737; 44742; 44747; 44752; 44757; 44762; 44767; 44772; 44777; 44782; 44787; 44792; 44797; 44802; 44807; 44812; 44817; 44822; 44827; 44832; 44837; 44842; 44847; 44852; 44857; 44862; 44867; 44872; 44877; 44882; 44887; 44888; 44889; 44890; 44891; 44892; 44893; 44894; 44895; 44896; 44897; 44898; 44899; 44900; 44901; 44902; 44903; 44904; 44905; 44906; 44907; 44908; 44909; 44910; 44911; 44912; 44913; 44914; 44915; 44916; 44917; 44918; 44919; 44920; 44921; 44922; 44923; 44924; 44925; 44926; 44927; 44928; 44929; 44930; 44931; 44932; 44933; 44934; 44935; 44936; 44937; 44938; 44939; 44940; 44941; 44942; 44943; 44944; 44945; 44946; 44947; 44948; 44949; 44950; 44951; 45012; 45013; 45014; 45015; 45018; 45019; 45020; 45021; 45022; 45023; 45024; 45025; 45026; 45027; 45029; 45475; 45480; 45481; 45482; 45483; 45484; 45485; 45505; 45507; 45508; 45509; 45552; 45553; 45554; 45555; 45556; 45557; 45558; 45559; 45560; 45561; 45562; 45563; 45564; 45565; 45566; 45567; 45568; 45569; 45570; 45571; 45572; 45573; 45574; 45575; 45576; 45577; 45578; 45579; 45580; 45581; 45582; 45664; 45665; 45666; 45667; 45668; 45751; 45752; 45753; 45754; 45755; 45756; 45757; 45758; 45759; 45760; 45761; 45762; 45763; 45764; 45765; 45766; 45767; 45768; 45769; 45770; 45771; 45772; 45773; 45774; 45775; 45776; 45777; 45778; 45779; 45780; 45781; 45782; 45783; 45784; 45785; 45786; 45787; 45788; 45789; 45790; 45791; 45792; 45793; 45794; 45795; 45796; 45797; 45798; 45799; 45800; 45801; 45802; 45803; 45804; 45805; 45806; 45807; 45808; 45809; 45810; 45811; 45812; 45813; 45814; 45815; 45816; 45817; 45818; 45819; 45820; 45821; 45822; 45823; 45824; 45825; 45826; 45827; 45828; 45829; 45830; 45831; 45832; 45833; 45834; 45835; 45836; 45837; 45838; 45839; 45840; 45841; 45842; 45843; 45844; 45845; 45846; 45847; 45848; 45849; 45850; 45851; 45852; 45853; 45854; 45855; 45856; 45857; 45858; 45859; 45860; 45861; 45862; 45863; 45864; 45865; 45866; 45867; 45868; 45869; 45870; 45871; 45872; 45873; 45874; 45875; 45876; 45877; 45878; 45879; 45880; 45881; 45882; 45883; 45884; 45885; 45886; 45887; 45888; 45889; 45890; 45891; 45892; 45893; 45894; 45895; 45896; 45897; 45898; 45899; 45900; 45901; 45902; 45903; 45904; 45905; 45906; 45907; 45908; 45909; 45910; 45911; 45912; 45913; 45914; 45915; 45916; 45917; 45918; 45919; 45920; 45921; 45922; 45923; 45924; 45925; 45926; 45927; 45928; 45929; 45930; 45931; 45932; 45933; 45934; 45935; 45936; 45937; 45938; 45939; 45940; 45941; 45942; 45943; 45944; 45945; 45946; 45947; 45948; 45949; 45950; 45951; 45952; 45953; 45954; 45955; 45956; 45957; 45958; 45959; 45960; 45961; 45962; 45963; 45964; 45965; 45966; 45967; 45968; 45969; 45970; 45971; 45972; 45973; 45974; 45975; 45976; 45977; 45978; 45979; 45980; 45981; 45982; 45983; 45984; 45985; 45986; 45987; 45988; 45989; 45990; 45991; 45992; 45997; 46014; 46015; 46016; 46017; 46018; 46019; 46020; 46021; 46022; 46024; 46025; 46026; 46040; 46041; 46042; 46043; 46044; 46045; 46051; 46089; 46090; 46091; 46092; 46093; 46094; 46095; 46096; 46097; 46098; 46099; 46100; 46101; 46102; 46103; 46104; 46105; 46106; 46107; 46108; 46109; 46110; 46111; 46112; 46113; 46114; 46115; 46116; 46117; 46118; 46119; 46120; 46121; 46122; 46123; 46124; 46125; 46126; 46127; 46128; 46129; 46130; 46131; 46132; 46133; 46134; 46135; 46136; 46137; 46138; 46139; 46140; 46141; 46142; 46143; 46144; 46145; 46146; 46147; 46148; 46149; 46276; 46277; 46376; 46377; 46378; 46379; 46380; 46383; 46384; 46385; 46386; 46387; 46388; 46389; 46390; 46391; 46392; 46393; 46394; 46395; 46396; 46397; 46398; 46399; 46400; 46401; 46402; 46403; 46404; 46405; 46406; 46407; 46408; 46409; 46410; 46411; 46412; 46413; 46414; 46415; 46416; 46417; 46418; 46419; 46420; 46421; 46422; 46423; 46424; 46425; 46426; 46427; 46428; 46429; 46430; 46431; 46432; 46433; 46434; 46435; 46436; 46437; 46438; 46439; 46440; 46441; 46442; 46443; 46520; 46521; 46522; 46525; 46526; 46527; 46528; 46529; 46530; 46531; 46532; 46533; 46534; 46535; 46536; 46537; 46538; 46539; 46540; 46547; 46548; 46549; 46550; 46551; 46552; 46553; 46554; 46555; 46556; 46557; 46558; 46559; 46560; 46561; 46562; 46563; 46564; 46582; 46584; 46707; 46708; 46709; 46710; 46711; 46712; 46713; 46714; 46715; 46716; 46717; 46718; 46719; 46720; 46721; 46722; 46723; 46724; 46725; 46726; 46727; 46728; 46729; 46730; 46731; 46732; 46733; 46734; 46735; 46736; 46737; 46738; 46739; 46740; 46741; 46742; 46743; 46744; 46745; 46746; 46747; 46748; 46749; 46750; 46751; 46752; 46753; 46754; 46755; 46773; 46774; 46775; 46776; 46777; 46778; 46779; 46780; 46781; 46782; 46783; 46784; 46785; 46786; 46787; 46788; 46789; 46790; 46791; 46792; 46793; 46794; 46795; 46796; 46797; 46798; 46799; 46800; 46801; 46802; 46803; 46804; 46805; 46806; 46807; 46808; 46809; 46810; 46811; 46812; 46813; 46814; 46815; 46816; 46817; 46818; 46819; 46820; 46821; 46822; 46823; 46824; 46827; 46828; 46829; 46830; 46831; 46832; 46833; 46834; 46835; 46836; 46837; 46838; 46839; 46840; 46841; 46842; 46843; 46844; 46845; 46846; 46847; 46848; 46849; 46850; 46851; 46852; 46853; 46854; 46855; 46856; 46857; 46858; 46859; 46860; 46861; 46862; 46863; 46864; 46865; 46866; 46867; 46868; 46869; 46870; 46871; 46872; 46873; 46874; 46875; 46876; 46877; 46878; 46879; 46880; 46881; 46882; 46883; 46884; 46885; 46886; 46887; 46888; 46889; 46890; 46891; 46892; 46893; 46894; 46895; 46896; 46897; 46898; 46899; 46900; 46901; 46902; 46903; 46904; 46905; 46906; 46907; 46908; 46909; 46910; 46911; 46912; 46913; 46914; 46915; 46916; 46917; 46918; 46919; 46920; 46921; 46922; 46923; 46924; 46925; 46926; 46927; 46928; 46929; 46930; 46931; 46932; 46933; 46934; 46935; 46936; 46937; 46938; 46939; 46940; 46941; 46942; 46943; 46944; 46945; 46946; 46947; 46948; 46949; 46950; 46951; 46952; 46953; 46954; 46955; 46956; 46957; 46958; 46959; 46960; 46961; 46962; 46963; 46964; 46965; 46966; 46967; 46968; 46969; 46970; 46971; 46972; 46973; 46974; 46975; 46976; 46977; 46978; 46979; 46980; 46981; 46982; 46983; 46984; 46985; 46986; 46987; 46988; 46989; 46990; 46991; 46992; 46993; 46994; 46995; 46996; 46997; 46998; 46999; 47000; 47001; 47002; 47003; 47004; 47005; 47006; 47007; 47008; 47009; 47010; 47011; 47012; 47013; 47014; 47015; 47029; 47030; 47049; 47050; 47051; 47052; 47075; 47085; 47090; 47095; 47101; 47102; 47103; 47104; 47105; 47106; 47158; 47159; 47160; 47161; 47162; 47163; 47164; 47165; 47166; 47167; 47168; 47169; 47170; 47171; 47172; 47173; 47174; 47175; 47176; 47177; 47178; 47179; 47249; 47250; 47251; 47282; 47289; 47290; 47291; 47292; 47293; 47294; 47295; 47304; 47305; 47306; 47307; 47308; 47309; 47310; 47311; 47312; 47313; 47314; 47315; 47316; 47317; 47318; 47319; 47320; 47321; 47371; 47372; 47375; 47376; 47377; 47493; 47494; 47495; 47496; 47497; 47498; 47499; 47500; 47501; 47502; 47503; 47504; 47505; 47506; 47507; 47508; 47509; 47510; 47511; 47522; 47523; 47524; 47526; 47527; 47528; 47529; 47530; 47531; 47532; 47533; 47534; 47535; 47536; 47537; 47538; 47539; 47540; 47541; 47544; 47545; 47546; 47547; 47548; 47549; 47550; 47551; 47552; 47610; 47611; 47612; 47613; 47614; 47615; 47616; 47617; 47618; 47619; 47621; 47622; 47623; 47624; 47625; 47626; 47627; 47628; 47629; 47630; 47631; 47632; 47633; 47634; 47635; 47636; 47637; 47638; 47639; 47640; 47641; 47642; 47643; 47644; 47645; 47646; 47647; 47648; 47649; 47650; 47651; 47652; 47653; 47654; 47655; 47680; 47681; 47682; 47683; 47684; 47698; 48146; 48147; 48155; 48156; 48157; 48158; 48159; 48160; 48161; 48162; 48163; 48164; 48165; 48166; 48167; 48168; 48169; 48170; 48171; 48172; 48173; 48174; 48175; 48176; 48177; 48178; 48179; 48180; 48181; 48182; 48183; 48184; 48185; 48186; 48187; 48188; 48189; 48190; 48191; 48192; 48193; 48194; 48195; 48196; 48197; 48198; 48199; 48200; 48201; 48202; 48203; 48204; 48205; 48206; 48207; 48208; 48209; 48210; 48211; 48212; 48213; 48214; 48215; 48216; 48217; 48218; 48219; 48220; 48221; 48222; 48223; 48224; 48225; 48226; 48227; 48228; 48229; 48230; 48231; 48232; 48233; 48242; 48243; 48244; 48365; 48366; 48367; 48368; 48369; 48481; 48482; 48483; 48484; 48485; 48486; 48487; 48488; 48489; 48490; 48491; 48492; 48493; 48494; 48495; 48496; 48497; 48498; 48499; 48500; 48501; 48502; 48503; 48504; 48505; 48506; 48507; 48508; 48509; 48510; 48511; 48512; 48513; 48514; 48515; 48516; 48517; 48518; 48519; 48520; 48521; 48522; 48523; 48524; 48525; 48526; 48527; 48528; 48529; 48530; 48543; 48544; 48546; 48547; 48548; 48549; 48550; 48551; 48552; 48553; 48554; 48555; 48556; 48557; 48558; 48559; 48560; 48561; 48562; 48563; 48564; 48565; 48566; 48576; 48577; 48578; 48579; 48580; 48581; 48649; 48650; 48651; 48653; 48654; 48655; 48656; 48719; 48720; 48721; 48722; 48723; 48724; 48725; 48726; 48727; 48728; 48729; 48730; 48731; 48732; 48733; 48734; 48735; 48816; 48817; 48819; 48830; 48831; 48833; 48834; 48836; 48837; 48838; 48839; 48843; 48844; 48845; 48846; 48847; 48848; 48849; 48850; 48851; 48852; 48853; 48854; 48855; 48856; 48857; 48858; 48859; 48860; 48861; 48893; 48894; 48895; 48896; 49141; 49146; 49147; 49148; 49149; 49150; 49151; 49152; 49153; 49154; 49155; 49156; 49157; 49158; 49163; 49168; 49173; 49178; 49183; 49188; 49193; 49198; 49203; 49208; 49213; 49218; 49223; 49228; 49233; 49238; 49243; 49248; 49253; 49258; 49263; 49268; 49273; 49278; 49283; 49288; 49293; 49298; 49303; 49308; 49313; 49318; 49323; 49328; 49333; 49338; 49343; 49348; 49353; 49358; 49363; 49368; 49373; 49378; 49383; 49388; 49393; 49398; 49403; 49408; 49413; 49420; 49421; 49422; 49423; 49424; 49425; 49426; 49427; 49428; 49429; 49430; 49431; 49432; 49433; 49434; 49435; 49436; 49441; 49446; 49451; 49456; 49461; 49466; 49471; 49476; 49481; 49486; 49491; 49496; 49501; 49506; 49511; 49516; 49521; 49526; 49750; 49751; 49752; 49794; 49795; 49796; 49797; 49798; 49799; 49800; 49801; 49811; 49812; 49813; 49814; 49816; 49817; 49818; 49819; 49820; 49821; 49822; 49823; 49824; 49825; 49922; 49923; 49924; 49925; 49926; 49927; 49928; 49933; 49934; 49935; 49936; 49946; 49947; 49948; 49952; 49953; 49954; 49955; 49956; 49957; 49958; 49959; 49960; 49961; 49962; 49963; 50002; 50003; 50004; 50031; 50033; 50034; 50035; 50069; 50070; 50071; 50074; 50075; 50076; 50077; 50078; 50079; 50083; 50084; 50085; 50139; 50140; 50141; 50142; 50143; 50144; 50145; 50146; 50147; 50148; 50149; 50150; 50151; 50152; 50153; 50156; 50157; 50158; 52278; 52279; 52280; 52281; 52282; 52283; 52284; 52285; 52286; 52287; 52288; 52289; 52302; 52303; 52304; 52321; 52322; 52323; 52351; 52352; 52353; 52392; 52393; 52394; 52395; 52396; 52397; 52398; 52399; 52400; 52401; 52402; 52403; 52404; 52405; 52406; 52407; 52417; 52418; 52419; 52420; 52423; 52424; 52425; 52426; 52427; 52428; 52429; 52430; 52431; 52432; 52433; 52434; 52435; 52436; 52437; 52438; 52439; 52440; 52442; 52443; 52444 |] } |> Some
      | 301 -> { GroupData.id= 301; name= "Concord Drone"; categoryId= 11; published= false; typeIds= [| 3863; 3885; 10037; 10038; 11125; 11128 |] } |> Some
      | 495 -> { GroupData.id= 495; name= "Deadspace Overseer's Sentry"; categoryId= 11; published= false; typeIds= [| 3795; 3805; 3809; 17993; 18630; 18631; 19703; 19707; 19955; 19961; 25472; 25524; 25528; 25559; 25805; 25809; 25866; 26275; 28508; 28510; 28998; 29020; 29021; 29022; 29023 |] } |> Some
      | 689 -> { GroupData.id= 689; name= "Mission Khanid Cruiser"; categoryId= 11; published= false; typeIds= [| 11948; 12047; 16173; 16174; 16175 |] } |> Some
      | 786 -> { GroupData.id= 786; name= "Rig Electronic Systems"; categoryId= 7; published= true; typeIds= [| 4369; 25928; 26096; 26106; 26108; 26110; 26112; 26344; 26352; 26354; 26356; 26360; 26366; 26960; 26962; 31250; 31252; 31254; 31256; 31258; 31260; 31262; 31264; 31266; 31268; 31270; 31272; 31286; 31288; 31290; 31292; 31294; 31296; 31298; 31300; 31302; 31304; 31306; 31308; 31334; 31336; 31338; 31340; 31342; 31344; 31346; 31348; 31350; 31352; 31354; 31356 |] } |> Some
      | 883 -> { GroupData.id= 883; name= "Capital Industrial Ship"; categoryId= 6; published= true; typeIds= [| 28352; 33687 |] } |> Some
      | _ -> None