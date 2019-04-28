﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stars20=
    let getStar id = 
      match id with 
      | 40007185 -> { StarData.id= 40007185; name= "Berta - Star"; solarSystemId= 30000109; typeId= 45033; age= 26522929399L; luminosity= 0.064830; radius= 329800000L; spectralClass= "K6 V"; temperature= 4032 } |> Some
      | 40010580 -> { StarData.id= 40010580; name= "Sakkikainen - Star"; solarSystemId= 30000167; typeId= 3800; age= 30230435496L; luminosity= 0.014800; radius= 262900000L; spectralClass= "M2 V"; temperature= 3121 } |> Some
      | 40018922 -> { StarData.id= 40018922; name= "1-GBBP - Star"; solarSystemId= 30000301; typeId= 45047; age= 13755799136L; luminosity= 0.054550; radius= 186900000L; spectralClass= "G8 VI"; temperature= 5129 } |> Some
      | 40023190 -> { StarData.id= 40023190; name= "HP-PMX - Star"; solarSystemId= 30000370; typeId= 3798; age= 3533221686L; luminosity= 0.012800; radius= 131800000L; spectralClass= "K4 V"; temperature= 4251 } |> Some
      | 40027846 -> { StarData.id= 40027846; name= "XSUD-1 - Star"; solarSystemId= 30000447; typeId= 3802; age= 16005653412L; luminosity= 0.116700; radius= 300400000L; spectralClass= "K0 V"; temperature= 4892 } |> Some
      | 40028137 -> { StarData.id= 40028137; name= "JFV-ID - Star"; solarSystemId= 30000451; typeId= 45030; age= 7443532073L; luminosity= 0.169500; radius= 305400000L; spectralClass= "G6 V"; temperature= 5327 } |> Some
      | 40031338 -> { StarData.id= 40031338; name= "E-ACV6 - Star"; solarSystemId= 30000503; typeId= 45039; age= 27432377591L; luminosity= 0.011120; radius= 329900000L; spectralClass= "M5 V"; temperature= 2594 } |> Some
      | 40033278 -> { StarData.id= 40033278; name= "LP1M-Q - Star"; solarSystemId= 30000533; typeId= 3797; age= 5215859261L; luminosity= 0.072710; radius= 191600000L; spectralClass= "G5 VI"; temperature= 5443 } |> Some
      | 40035703 -> { StarData.id= 40035703; name= "G9NE-B - Star"; solarSystemId= 30000570; typeId= 45039; age= 68477956005L; luminosity= 0.013120; radius= 318800000L; spectralClass= "M4 V"; temperature= 2750 } |> Some
      | 40036479 -> { StarData.id= 40036479; name= "4-OS2A - Star"; solarSystemId= 30000582; typeId= 3800; age= 34888585409L; luminosity= 0.157900; radius= 1620999936L; spectralClass= "M7 V"; temperature= 2271 } |> Some
      | 40041911 -> { StarData.id= 40041911; name= "F-5FDA - Star"; solarSystemId= 30000666; typeId= 3801; age= 1706403506L; luminosity= 0.338600; radius= 314800000L; spectralClass= "F8 VI"; temperature= 6238 } |> Some
      | 40068780 -> { StarData.id= 40068780; name= "LY-WRW - Star"; solarSystemId= 30001078; typeId= 3803; age= 4325423869L; luminosity= 1.109000; radius= 506600000L; spectralClass= "F5 V"; temperature= 6616 } |> Some
      | 40070138 -> { StarData.id= 40070138; name= "R-RMDH - Star"; solarSystemId= 30001102; typeId= 3796; age= 382475203L; luminosity= 1.658000; radius= 509000000L; spectralClass= "F1 V"; temperature= 7298 } |> Some
      | 40070817 -> { StarData.id= 40070817; name= "XTVZ-E - Star"; solarSystemId= 30001113; typeId= 3800; age= 40972696693L; luminosity= 0.011200; radius= 353200000L; spectralClass= "M5 V"; temperature= 2512 } |> Some
      | 40073145 -> { StarData.id= 40073145; name= "4QY-NT - Star"; solarSystemId= 30001149; typeId= 45037; age= 13156893618L; luminosity= 0.226600; radius= 526400000L; spectralClass= "K3 V"; temperature= 4364 } |> Some
      | 40082069 -> { StarData.id= 40082069; name= "AJCJ-1 - Star"; solarSystemId= 30001289; typeId= 45041; age= 1804319740L; luminosity= 0.044930; radius= 183400000L; spectralClass= "K0 V"; temperature= 4932 } |> Some
      | 40087598 -> { StarData.id= 40087598; name= "Iidoken - Star"; solarSystemId= 30001374; typeId= 45047; age= 5244378597L; luminosity= 0.309800; radius= 459400000L; spectralClass= "G9 V"; temperature= 5051 } |> Some
      | 40122130 -> { StarData.id= 40122130; name= "DP-2WP - Star"; solarSystemId= 30001912; typeId= 45039; age= 88378077845L; luminosity= 0.020200; radius= 716200000L; spectralClass= "M9 V"; temperature= 2044 } |> Some
      | 40142403 -> { StarData.id= 40142403; name= "Milal - Star"; solarSystemId= 30002236; typeId= 45037; age= 10171876649L; luminosity= 0.215600; radius= 505700000L; spectralClass= "K3 V"; temperature= 4397 } |> Some
      | 40142888 -> { StarData.id= 40142888; name= "Arera - Star"; solarSystemId= 30002244; typeId= 3796; age= 2931782000L; luminosity= 1.720000; radius= 531100000L; spectralClass= "F1 V"; temperature= 7210 } |> Some
      | 40155595 -> { StarData.id= 40155595; name= "SV-K8J - Star"; solarSystemId= 30002445; typeId= 45041; age= 2700775757L; luminosity= 0.040630; radius= 195700000L; spectralClass= "K1 V"; temperature= 4656 } |> Some
      | 40157535 -> { StarData.id= 40157535; name= "E-91FV - Star"; solarSystemId= 30002477; typeId= 7; age= 27831647211L; luminosity= 0.048620; radius= 363500000L; spectralClass= "K9 V"; temperature= 3574 } |> Some
      | 40160251 -> { StarData.id= 40160251; name= "Edmalbrurdus - Star"; solarSystemId= 30002518; typeId= 45036; age= 6477045208L; luminosity= 0.209900; radius= 301100000L; spectralClass= "G3 V"; temperature= 5660 } |> Some
      | 40166362 -> { StarData.id= 40166362; name= "UK-SHL - Star"; solarSystemId= 30002610; typeId= 8; age= 27670037457L; luminosity= 0.163800; radius= 541000000L; spectralClass= "K6 V"; temperature= 3969 } |> Some
      | 40195462 -> { StarData.id= 40195462; name= "Gammel - Star"; solarSystemId= 30003076; typeId= 3799; age= 3036669376L; luminosity= 0.229500; radius= 308900000L; spectralClass= "G2 V"; temperature= 5714 } |> Some
      | 40196238 -> { StarData.id= 40196238; name= "Kurniainen - Star"; solarSystemId= 30003089; typeId= 6; age= 1695312638L; luminosity= 0.152700; radius= 301800000L; spectralClass= "G7 V"; temperature= 5221 } |> Some
      | 40201088 -> { StarData.id= 40201088; name= "C-PEWN - Star"; solarSystemId= 30003169; typeId= 45047; age= 3606104495L; luminosity= 0.159900; radius= 296200000L; spectralClass= "G6 V"; temperature= 5331 } |> Some
      | 40229800 -> { StarData.id= 40229800; name= "W8O-19 - Star"; solarSystemId= 30003622; typeId= 3798; age= 19225162944L; luminosity= 0.030660; radius= 209900000L; spectralClass= "K4 V"; temperature= 4191 } |> Some
      | 40239209 -> { StarData.id= 40239209; name= "2V-CS5 - Star"; solarSystemId= 30003774; typeId= 45035; age= 3282885804L; luminosity= 0.217000; radius= 206300000L; spectralClass= "F3 VI"; temperature= 6895 } |> Some
      | 40240761 -> { StarData.id= 40240761; name= "Cumemare - Star"; solarSystemId= 30003802; typeId= 45035; age= 2390232538L; luminosity= 3.769000; radius= 803400000L; spectralClass= "F2 V"; temperature= 7133 } |> Some
      | 40255408 -> { StarData.id= 40255408; name= "ES-Q0W - Star"; solarSystemId= 30004033; typeId= 45039; age= 12684741190L; luminosity= 0.011270; radius= 356900000L; spectralClass= "M5 V"; temperature= 2502 } |> Some
      | 40265399 -> { StarData.id= 40265399; name= "1M7-RK - Star"; solarSystemId= 30004189; typeId= 45042; age= 625839705L; luminosity= 0.522600; radius= 333100000L; spectralClass= "F4 VI"; temperature= 6760 } |> Some
      | 40266951 -> { StarData.id= 40266951; name= "58Z-IH - Star"; solarSystemId= 30004212; typeId= 7; age= 28522448065L; luminosity= 0.055130; radius= 370900000L; spectralClass= "K8 V"; temperature= 3651 } |> Some
      | 40268309 -> { StarData.id= 40268309; name= "Yehaba - Star"; solarSystemId= 30004236; typeId= 45047; age= 10156032513L; luminosity= 0.065590; radius= 191100000L; spectralClass= "G6 VI"; temperature= 5312 } |> Some
      | 40268697 -> { StarData.id= 40268697; name= "Isid - Star"; solarSystemId= 30004243; typeId= 7; age= 8701549084L; luminosity= 0.023920; radius= 228200000L; spectralClass= "K7 V"; temperature= 3777 } |> Some
      | 40280434 -> { StarData.id= 40280434; name= "PO-3QW - Star"; solarSystemId= 30004431; typeId= 3797; age= 2139262841L; luminosity= 0.083110; radius= 201700000L; spectralClass= "G4 VI"; temperature= 5485 } |> Some
      | 40282665 -> { StarData.id= 40282665; name= "23M-PX - Star"; solarSystemId= 30004467; typeId= 7; age= 23759728159L; luminosity= 0.024870; radius= 234600000L; spectralClass= "K7 V"; temperature= 3762 } |> Some
      | 40309146 -> { StarData.id= 40309146; name= "M-RPN3 - Star"; solarSystemId= 30004881; typeId= 7; age= 21490861356L; luminosity= 0.382500; radius= 891100032L; spectralClass= "K7 V"; temperature= 3823 } |> Some
      | 40312153 -> { StarData.id= 40312153; name= "L-YMYU - Star"; solarSystemId= 30004927; typeId= 45038; age= 5932009971L; luminosity= 0.100600; radius= 193000000L; spectralClass= "G1 VI"; temperature= 5882 } |> Some
      | 40319719 -> { StarData.id= 40319719; name= "Polfaly - Star"; solarSystemId= 30005048; typeId= 3796; age= 1303964815L; luminosity= 4.612000; radius= 823800000L; spectralClass= "F0 V"; temperature= 7409 } |> Some
      | 40349207 -> { StarData.id= 40349207; name= "Teskanen - Star"; solarSystemId= 30045335; typeId= 45047; age= 7633660618L; luminosity= 0.388000; radius= 487300000L; spectralClass= "G7 V"; temperature= 5188 } |> Some
      | 40352408 -> { StarData.id= 40352408; name= "J144530 - Star"; solarSystemId= 31000041; typeId= 45047; age= 9969072359L; luminosity= 0.059950; radius= 189100000L; spectralClass= "G7 VI"; temperature= 5221 } |> Some
      | 40358034 -> { StarData.id= 40358034; name= "J163804 - Star"; solarSystemId= 31000139; typeId= 3799; age= 5142976452L; luminosity= 0.269000; radius= 318300000L; spectralClass= "G1 V"; temperature= 5858 } |> Some
      | 40361332 -> { StarData.id= 40361332; name= "J122717 - Star"; solarSystemId= 31000202; typeId= 3798; age= 21554237900L; luminosity= 0.012440; radius= 128700000L; spectralClass= "K4 V"; temperature= 4272 } |> Some
      | 40362302 -> { StarData.id= 40362302; name= "J113050 - Star"; solarSystemId= 31000221; typeId= 45046; age= 2430793124L; luminosity= 1.030000; radius= 498600000L; spectralClass= "F6 V"; temperature= 6546 } |> Some
      | 40365406 -> { StarData.id= 40365406; name= "J102734 - Star"; solarSystemId= 31000279; typeId= 3796; age= 1045706865L; luminosity= 0.264400; radius= 202400000L; spectralClass= "F1 VI"; temperature= 7314 } |> Some
      | 40365988 -> { StarData.id= 40365988; name= "J143421 - Star"; solarSystemId= 31000290; typeId= 3802; age= 5130301252L; luminosity= 0.094520; radius= 308600000L; spectralClass= "K2 V"; temperature= 4580 } |> Some
      | 40366667 -> { StarData.id= 40366667; name= "J103341 - Star"; solarSystemId= 31000303; typeId= 45041; age= 15875731930L; luminosity= 0.229300; radius= 469400000L; spectralClass= "K2 V"; temperature= 4634 } |> Some
      | 40369674 -> { StarData.id= 40369674; name= "J111740 - Star"; solarSystemId= 31000366; typeId= 8; age= 27891855364L; luminosity= 0.025350; radius= 211800000L; spectralClass= "K6 V"; temperature= 3978 } |> Some
      | 40375979 -> { StarData.id= 40375979; name= "J114405 - Star"; solarSystemId= 31000482; typeId= 45041; age= 2675108245L; luminosity= 0.111300; radius= 294700000L; spectralClass= "K0 V"; temperature= 4883 } |> Some
      | 40381314 -> { StarData.id= 40381314; name= "J145225 - Star"; solarSystemId= 31000581; typeId= 3800; age= 31428246531L; luminosity= 0.018380; radius= 239600000L; spectralClass= "M0 V"; temperature= 3451 } |> Some
      | 40384321 -> { StarData.id= 40384321; name= "J212238 - Star"; solarSystemId= 31000641; typeId= 45037; age= 12405886788L; luminosity= 0.081420; radius= 329100000L; spectralClass= "K4 V"; temperature= 4272 } |> Some
      | 40392566 -> { StarData.id= 40392566; name= "J102209 - Star"; solarSystemId= 31000795; typeId= 45040; age= 52982482254L; luminosity= 0.012360; radius= 311100000L; spectralClass= "M4 V"; temperature= 2743 } |> Some
      | 40392857 -> { StarData.id= 40392857; name= "J105244 - Star"; solarSystemId= 31000800; typeId= 45041; age= 17609070850L; luminosity= 0.254400; radius= 464100000L; spectralClass= "K1 V"; temperature= 4783 } |> Some
      | 40397610 -> { StarData.id= 40397610; name= "J105007 - Star"; solarSystemId= 31000891; typeId= 3798; age= 6061931453L; luminosity= 0.517500; radius= 823299968L; spectralClass= "K4 IV"; temperature= 4289 } |> Some
      | 40399550 -> { StarData.id= 40399550; name= "J111619 - Star"; solarSystemId= 31000929; typeId= 45032; age= 15150074412L; luminosity= 0.052950; radius= 352000000L; spectralClass= "K8 V"; temperature= 3710 } |> Some
      | 40400908 -> { StarData.id= 40400908; name= "J125949 - Star"; solarSystemId= 31000955; typeId= 45030; age= 2414632421L; luminosity= 0.134600; radius= 296100000L; spectralClass= "G8 V"; temperature= 5107 } |> Some
      | 40407892 -> { StarData.id= 40407892; name= "J132737 - Star"; solarSystemId= 31001097; typeId= 45039; age= 10517275987L; luminosity= 0.012940; radius= 309300000L; spectralClass= "M4 V"; temperature= 2783 } |> Some
      | 40410414 -> { StarData.id= 40410414; name= "J114916 - Star"; solarSystemId= 31001147; typeId= 6; age= 706961217L; luminosity= 0.067200; radius= 194400000L; spectralClass= "G6 VI"; temperature= 5299 } |> Some
      | 40411966 -> { StarData.id= 40411966; name= "J213411 - Star"; solarSystemId= 31001173; typeId= 3802; age= 10995766288L; luminosity= 0.271800; radius= 500700000L; spectralClass= "K1 V"; temperature= 4682 } |> Some
      | 40415070 -> { StarData.id= 40415070; name= "J224401 - Star"; solarSystemId= 31001229; typeId= 3802; age= 7158339254L; luminosity= 0.042750; radius= 199700000L; spectralClass= "K1 V"; temperature= 4668 } |> Some
      | 40420987 -> { StarData.id= 40420987; name= "J215326 - Star"; solarSystemId= 31001348; typeId= 45038; age= 5231703397L; luminosity= 0.592500; radius= 486500000L; spectralClass= "G2 V"; temperature= 5772 } |> Some
      | 40425061 -> { StarData.id= 40425061; name= "J141218 - Star"; solarSystemId= 31001424; typeId= 45030; age= 7592466082L; luminosity= 1.069000; radius= 768899968L; spectralClass= "G6 V"; temperature= 5321 } |> Some
      | 40425837 -> { StarData.id= 40425837; name= "J231614 - Star"; solarSystemId= 31001438; typeId= 3800; age= 8910690157L; luminosity= 0.012920; radius= 327600000L; spectralClass= "M4 V"; temperature= 2703 } |> Some
      | 40428747 -> { StarData.id= 40428747; name= "J104603 - Star"; solarSystemId= 31001492; typeId= 45038; age= 2777144069L; luminosity= 0.582200; radius= 489200000L; spectralClass= "G2 V"; temperature= 5730 } |> Some
      | 40429911 -> { StarData.id= 40429911; name= "J235219 - Star"; solarSystemId= 31001519; typeId= 45038; age= 2712500439L; luminosity= 0.246000; radius= 316900000L; spectralClass= "G2 V"; temperature= 5740 } |> Some
      | 40430881 -> { StarData.id= 40430881; name= "J154109 - Star"; solarSystemId= 31001541; typeId= 45039; age= 8486070138L; luminosity= 0.013940; radius= 296200000L; spectralClass= "M3 V"; temperature= 2897 } |> Some
      | 40445528 -> { StarData.id= 40445528; name= "J152711 - Star"; solarSystemId= 31001830; typeId= 45032; age= 11113012024L; luminosity= 0.141700; radius= 598099968L; spectralClass= "K8 V"; temperature= 3640 } |> Some
      | 40453967 -> { StarData.id= 40453967; name= "J120816 - Star"; solarSystemId= 31001990; typeId= 45041; age= 5241209661L; luminosity= 0.099170; radius= 322100000L; spectralClass= "K2 V"; temperature= 4537 } |> Some
      | 40455713 -> { StarData.id= 40455713; name= "J114809 - Star"; solarSystemId= 31002503; typeId= 45040; age= 55010518623L; luminosity= 0.013020; radius= 338400000L; spectralClass= "M4 V"; temperature= 2664 } |> Some
      | 40459884 -> { StarData.id= 40459884; name= "J161635 - Star"; solarSystemId= 31002119; typeId= 3799; age= 7380155528L; luminosity= 1.817000; radius= 803299968L; spectralClass= "G0 V"; temperature= 5944 } |> Some
      | 40463958 -> { StarData.id= 40463958; name= "J210750 - Star"; solarSystemId= 31002211; typeId= 6; age= 6869977500L; luminosity= 0.010250; radius= 74430000L; spectralClass= "G6 VI"; temperature= 5352 } |> Some
      | 40466189 -> { StarData.id= 40466189; name= "J154021 - Star"; solarSystemId= 31002423; typeId= 45033; age= 28962913310L; luminosity= 0.026890; radius= 218300000L; spectralClass= "K6 V"; temperature= 3977 } |> Some
      | 40475016 -> { StarData.id= 40475016; name= "J114430 - Star"; solarSystemId= 31002441; typeId= 7; age= 20419803410L; luminosity= 0.022210; radius= 223700000L; spectralClass= "K8 V"; temperature= 3745 } |> Some
      | 40479478 -> { StarData.id= 40479478; name= "J133011 - Star"; solarSystemId= 31002496; typeId= 45030; age= 9661698076L; luminosity= 0.933800; radius= 754899968L; spectralClass= "G7 V"; temperature= 5191 } |> Some
      | 40487820 -> { StarData.id= 40487820; name= "J001670 - Star"; solarSystemId= 31002530; typeId= 34331; age= 490685239L; luminosity= 31.014826; radius= 1242377088L; spectralClass= "A0IV"; temperature= 9120 } |> Some
      | 40487917 -> { StarData.id= 40487917; name= "J002423 - Star"; solarSystemId= 31002542; typeId= 34331; age= 494920207L; luminosity= 28.517616; radius= 1262824960L; spectralClass= "A0IV"; temperature= 9682 } |> Some
      | _ -> None