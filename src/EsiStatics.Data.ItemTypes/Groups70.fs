namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups70=
    let getGroup id = 
      match id with 
      | 1040 -> { GroupData.id= 1040; name= "Specialized Commodities - Tier 3"; categoryId= 43; published= true; typeIds= [| 2344; 2345; 2346; 2348; 2349; 2351; 2352; 2354; 2358; 2360; 2361; 2366; 2367; 9834; 9846; 9848; 12836; 17136; 17392; 17898; 28974 |] } |> Some
      | 1137 -> { GroupData.id= 1137; name= "Fuel Block Blueprint"; categoryId= 9; published= true; typeIds= [| 4313; 4314; 4315; 4316 |] } |> Some
      | 1234 -> { GroupData.id= 1234; name= "Rig Targeting"; categoryId= 7; published= true; typeIds= [| 26100; 26102; 26358; 26364; 31274; 31276; 31278; 31280; 31282; 31284; 31322; 31324; 31326; 31328; 31330; 31332 |] } |> Some
      | 1331 -> { GroupData.id= 1331; name= "Structure Burst Projector"; categoryId= 66; published= true; typeIds= [| 35944; 47068; 47069; 47070; 47071; 47072; 47073; 47074; 47252 |] } |> Some
      | 1622 -> { GroupData.id= 1622; name= "Structure Combat Rig M - Boosted Sensors"; categoryId= 66; published= true; typeIds= [| 37234; 37235 |] } |> Some
      | 167 -> { GroupData.id= 167; name= "Hybrid Charge Blueprint"; categoryId= 9; published= true; typeIds= [| 1130; 1131; 1132; 1133; 1134; 1135; 1136; 1137; 1138; 1139; 1140; 1141; 1142; 1143; 1144; 1145; 1146; 1147; 1148; 1149; 1150; 1151; 1152; 1153; 17649; 17651; 17653; 17655; 17657; 17659; 17661; 17663; 21335; 32804 |] } |> Some
      | 1719 -> { GroupData.id= 1719; name= "Structure Disruption Battery"; categoryId= 66; published= true; typeIds= [| 35941; 35945; 35947; 47364; 47366; 47368 |] } |> Some
      | 1816 -> { GroupData.id= 1816; name= "Structure Engineering Rig M - Equipment ME"; categoryId= 66; published= true; typeIds= [| 43920; 43921 |] } |> Some
      | 1913 -> { GroupData.id= 1913; name= "Structure Drilling Rig M - Stability"; categoryId= 66; published= true; typeIds= [| 46325; 46326 |] } |> Some
      | 2010 -> { GroupData.id= 2010; name= "Mass Entangler Blueprints"; categoryId= 9; published= true; typeIds= [| 49100 |] } |> Some
      | 351210 -> { GroupData.id= 351210; name= "Infantry Vehicles"; categoryId= 350001; published= false; typeIds= [| 351252; 351253; 351278; 351321; 351352; 351354; 351355; 351824; 353089; 353486; 353808; 353832; 353879; 353881; 353884; 353886; 353900; 353904; 354741; 354742; 354927; 355249; 355250; 355374; 355423; 355424; 355470; 355471; 355472; 355473; 355474; 355475; 355479; 355772; 356068; 356069; 356072; 356073; 356075; 356077; 356207; 356211; 356841; 356842; 356871; 356872; 356873; 356874; 356875; 356876; 356909; 363354; 364121; 364171; 364172; 364246; 364247; 364344; 364348; 364355; 364369; 364378; 364380; 364490; 365364; 365420; 365428; 365943; 365944; 365945; 366382; 366383; 366384; 366507; 366508; 366509; 368518; 368531; 368532; 368533; 368534; 368537; 368539; 368546; 368547; 368880; 368881; 368882; 368884; 368885; 368887; 368888; 368889; 368890; 368891 |] } |> Some
      | 361 -> { GroupData.id= 361; name= "Mobile Warp Disruptor"; categoryId= 22; published= true; typeIds= [| 12198; 12199; 12200; 26849; 26888; 26890; 26892; 28770; 28772; 28774 |] } |> Some
      | 458 -> { GroupData.id= 458; name= "Plagioclase"; categoryId= 25; published= true; typeIds= [| 18; 17455; 17456; 28421; 28422; 28423; 46685; 46701 |] } |> Some
      | 555 -> { GroupData.id= 555; name= "Asteroid Blood Raiders Cruiser"; categoryId= 11; published= false; typeIds= [| 10281; 10282; 11043; 11044; 11901; 11902; 11903; 11904; 23257; 23258; 23281; 23282; 23283; 23284; 23285; 23286; 23643; 23644; 23645; 23646; 24630; 33135; 33144; 33172; 33182 |] } |> Some
      | 652 -> { GroupData.id= 652; name= "Lease"; categoryId= 17; published= true; typeIds= [| 24592; 24593; 24594; 24595; 24596; 24597 |] } |> Some
      | 749 -> { GroupData.id= 749; name= "Cyber Shields"; categoryId= 20; published= true; typeIds= [| 3077; 3078; 3079; 3080; 3081; 3084; 3085; 3086; 3087; 3088; 3089; 3092; 10228; 13253; 13262; 13263; 16245; 16246; 16247; 16248; 27104; 27105; 27106; 27107; 32255 |] } |> Some
      | 846 -> { GroupData.id= 846; name= "Asteroid Rogue Drone Commander Destroyer"; categoryId= 11; published= false; typeIds= [| 27748; 27749; 27750; 27751; 27752; 27753 |] } |> Some
      | 943 -> { GroupData.id= 943; name= "Legacy Currency"; categoryId= 5; published= true; typeIds= [| 2833; 29668; 32792; 32793; 44204 |] } |> Some
      | _ -> None