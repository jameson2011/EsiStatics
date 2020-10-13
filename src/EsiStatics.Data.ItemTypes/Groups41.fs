﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups41=
    let getGroup id = 
      match id with 
      | 1108 -> { GroupData.id= 1108; name= "Animated Lights"; categoryId= 53; published= false; typeIds= [| 32618; 32738 |] } |> Some
      | 1399 -> { GroupData.id= 1399; name= "Missile Guidance Computer Blueprint"; categoryId= 9; published= true; typeIds= [| 35791; 35792 |] } |> Some
      | 1593 -> { GroupData.id= 1593; name= "Structure Assembly Rig L - Subsystem"; categoryId= 66; published= false; typeIds= [| 37176; 37177 |] } |> Some
      | 1690 -> { GroupData.id= 1690; name= "Asteroid Serpentis Titan"; categoryId= 11; published= false; typeIds= [| 40637 |] } |> Some
      | 1884 -> { GroupData.id= 1884; name= "Ubiquitous Moon Asteroids"; categoryId= 25; published= true; typeIds= [| 45490; 45491; 45492; 45493; 46280; 46281; 46282; 46283; 46284; 46285; 46286; 46287 |] } |> Some
      | 1981 -> { GroupData.id= 1981; name= "Triglavian Support Pylons"; categoryId= 2; published= false; typeIds= [| 47437; 47438; 47442; 47443; 47444; 47469; 47470; 48254 |] } |> Some
      | 332 -> { GroupData.id= 332; name= "Tool"; categoryId= 17; published= true; typeIds= [| 11457; 11458; 11459; 11460; 11461; 11462; 11463; 11464; 11465; 11466; 11467; 11468; 11469; 11470; 11471; 11472; 11473; 11474; 11475; 11476; 11477; 11478; 11479; 11480; 11481; 11482; 11483; 11484; 11485; 11486; 11513; 11514; 11653; 11746; 20422; 24468; 27021; 27023 |] } |> Some
      | 41 -> { GroupData.id= 41; name= "Remote Shield Booster"; categoryId= 7; published= true; typeIds= [| 405; 406; 3544; 3586; 3588; 3596; 3598; 3606; 3608; 3616; 3618; 8531; 8533; 8535; 8537; 8579; 8581; 8583; 8585; 8627; 8629; 8631; 8633; 8635; 8637; 8639; 8641; 8683; 8685; 8687; 8689; 19129; 19131; 19133; 19135; 19137; 19139; 19141; 19143; 19145; 19147; 19149; 19151; 32467; 41469; 41470; 41471; 41472; 41473; 41474 |] } |> Some
      | 429 -> { GroupData.id= 429; name= "Composite"; categoryId= 4; published= true; typeIds= [| 16670; 16671; 16672; 16673; 16678; 16679; 16680; 16681; 16682; 16683; 17317; 33359; 33360; 33361; 33362 |] } |> Some
      | 526 -> { GroupData.id= 526; name= "Commodities"; categoryId= 17; published= true; typeIds= [| 2887; 2912; 3507; 3836; 3925; 3926; 11610; 15331; 20434; 20713; 21043; 21044; 21046; 21053; 21054; 21067; 21091; 21126; 21180; 21449; 21453; 21454; 21460; 21461; 21462; 21463; 21464; 21465; 21468; 21469; 21514; 21516; 21517; 21520; 21531; 21544; 21565; 21566; 21567; 21601; 21602; 21607; 21612; 21613; 21614; 21615; 21616; 21619; 21620; 21623; 21625; 21632; 21634; 21637; 21661; 21663; 21664; 21665; 21669; 21671; 21676; 21677; 21736; 21739; 21742; 21783; 21784; 21793; 21800; 21801; 21804; 21851; 21852; 21877; 21878; 21880; 21885; 21892; 21893; 21930; 21971; 21973; 22030; 22033; 22035; 22036; 22037; 22038; 22044; 22045; 22046; 22049; 22054; 22055; 22056; 22060; 22062; 22063; 22073; 22074; 22077; 22078; 22080; 22083; 22087; 22096; 22099; 22100; 22101; 22102; 22103; 22140; 22141; 22142; 22144; 22146; 22149; 22151; 22152; 22155; 22159; 22162; 22163; 22164; 22165; 22166; 22167; 22174; 22205; 22206; 22207; 22211; 22214; 22217; 22218; 22219; 22220; 22231; 22234; 22248; 22249; 22254; 22277; 22288; 22315; 22317; 22494; 22701; 22705; 22707; 22738; 22740; 22741; 22751; 22754; 22756; 22793; 22795; 23234; 23272; 23273; 23303; 23420; 23421; 23508; 23515; 23516; 23517; 23518; 23519; 23521; 23538; 23539; 23541; 23542; 23543; 23544; 23545; 23546; 23547; 23548; 23549; 23550; 23551; 23552; 23554; 23555; 23556; 23573; 23597; 23602; 23604; 23605; 23621; 23622; 23626; 23629; 23630; 23632; 23633; 23634; 23635; 23673; 23675; 23676; 23677; 23678; 23679; 23680; 23681; 23682; 23683; 23684; 23690; 23692; 23700; 23737; 23738; 23739; 23740; 23744; 23745; 23748; 23749; 23764; 23766; 23874; 23876; 23877; 23880; 23883; 23890; 23891; 23892; 23893; 23925; 23926; 23929; 23930; 23931; 23932; 23933; 23934; 23935; 23936; 23937; 24030; 24031; 24123; 24244; 24246; 24247; 24248; 24249; 24250; 24253; 24254; 24255; 24263; 24276; 24277; 24278; 24287; 24288; 24289; 24300; 24304; 24315; 24316; 24317; 24354; 24355; 24357; 24446; 24465; 24564; 24576; 24580; 24581; 24707; 24708; 24714; 24715; 24719; 24720; 24722; 24725; 24726; 24727; 24728; 24730; 24733; 24734; 24735; 24736; 24744; 24745; 24756; 24763; 25364; 25367; 25369; 25383; 25387; 25391; 25393; 25394; 25398; 25401; 25408; 25467; 25514; 25515; 25516; 25517; 25522; 25575; 25844; 25878; 25879; 25988; 26120; 26122; 26123; 26124; 26125; 26126; 26127; 26129; 26131; 26132; 26167; 26458; 26459; 26460; 26461; 26462; 26463; 26464; 26465; 26466; 26710; 26789; 26902; 26903; 26904; 26905; 26906; 27038; 27274; 27294; 28190; 28837; 28838; 29030; 29185; 29186; 29187; 29188; 29206; 29217; 29226; 29246; 29285; 29472; 29473; 29479; 29483; 29484; 29485; 30497; 30826; 30906; 30966; 32126; 33539; 33988; 43680; 44248; 44249; 44250; 44251; 44252; 47450; 49756; 49809; 49810; 50088; 52263; 52269; 52270; 52318; 52520; 52568; 53082; 53083; 53291; 53299; 54225; 54226; 54227; 54228; 54648; 54650; 54652; 54653; 54654; 54808; 54809; 54810; 54811; 56707; 56708; 56709; 56710; 56711; 56712; 56713; 56714; 56715; 56716 |] } |> Some
      | 623 -> { GroupData.id= 623; name= "Deadspace Sansha's Nation Destroyer"; categoryId= 11; published= false; typeIds= [| 23972; 23989; 23990; 23991; 23992; 23993; 24211; 24212; 24213; 24214; 24215; 24216 |] } |> Some
      | 817 -> { GroupData.id= 817; name= "Mission Generic Cruisers"; categoryId= 11; published= false; typeIds= [| 11597; 11650; 11655; 11668; 11669; 11670; 11671; 11675; 11676; 11677; 11699; 11704; 11708; 11721; 11722; 12197; 12244; 12251; 12252; 12253; 12254; 12255; 12835; 12892; 12996; 13201; 13268; 13513; 13670; 13671; 13672; 13673; 13771; 13896; 13897; 13899; 13900; 13902; 13903; 13905; 13906; 15333; 15334; 15390; 15391; 15582; 15583; 15584; 15585; 15586; 16093; 16094; 16095; 16096; 16097; 16198; 16199; 16209; 16250; 16251; 16254; 16256; 16545; 16555; 16556; 16559; 16560; 16572; 16573; 16574; 16575; 16580; 16581; 16584; 16585; 16588; 16590; 16609; 16611; 16612; 16620; 16626; 16873; 18573; 18577; 18578; 18579; 18656; 19589; 19662; 19676; 19681; 19768; 19769; 20279; 20363; 20547; 20714; 24454; 24455; 28826; 29024; 29905; 29908; 29912; 29913; 29918; 29919; 29923; 29926; 30819; 34592; 34783; 34785 |] } |> Some
      | 914 -> { GroupData.id= 914; name= "Advanced Capital Construction Component Blueprints"; categoryId= 9; published= true; typeIds= [| 3927; 3928; 29040; 29042; 29044; 29046; 29048; 29050; 29052; 29054; 29056; 29058; 29060; 29062; 29064; 29066; 29068; 29070; 29072; 29074; 29076; 29078; 29080; 29082; 29084; 29086; 29088; 29090; 29092; 29094; 29096; 29098; 29100; 29102; 29104; 29106; 29108; 29110 |] } |> Some
      | _ -> None