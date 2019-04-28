﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stars7=
    let getStar id = 
      match id with 
      | 40004941 -> { StarData.id= 40004941; name= "Jofan - Star"; solarSystemId= 30000078; typeId= 45036; age= 6236215862L; luminosity= 0.497800; radius= 487300000L; spectralClass= "G4 V"; temperature= 5521 } |> Some
      | 40017454 -> { StarData.id= 40017454; name= "C-DHON - Star"; solarSystemId= 30000278; typeId= 45031; age= 31345857458L; luminosity= 0.021990; radius= 236000000L; spectralClass= "K8 V"; temperature= 3637 } |> Some
      | 40032489 -> { StarData.id= 40032489; name= "I-9GI1 - Star"; solarSystemId= 30000520; typeId= 6; age= 14982127874L; luminosity= 0.788300; radius= 741200000L; spectralClass= "G9 V"; temperature= 5022 } |> Some
      | 40037630 -> { StarData.id= 40037630; name= "WRL4-2 - Star"; solarSystemId= 30000602; typeId= 45032; age= 37455320231L; luminosity= 0.058700; radius= 339200000L; spectralClass= "K7 V"; temperature= 3878 } |> Some
      | 40045778 -> { StarData.id= 40045778; name= "PU-UMM - Star"; solarSystemId= 30000727; typeId= 45047; age= 7345298864L; luminosity= 0.058590; radius= 185600000L; spectralClass= "G7 VI"; temperature= 5240 } |> Some
      | 40052374 -> { StarData.id= 40052374; name= "74L2-U - Star"; solarSystemId= 30000827; typeId= 45039; age= 55739344534L; luminosity= 0.014680; radius= 262200000L; spectralClass= "M2 V"; temperature= 3119 } |> Some
      | 40058485 -> { StarData.id= 40058485; name= "N-6Z8B - Star"; solarSystemId= 30000915; typeId= 3796; age= 1072007986L; luminosity= 4.575000; radius= 807000000L; spectralClass= "F0 V"; temperature= 7470 } |> Some
      | 40059552 -> { StarData.id= 40059552; name= "F-MKH3 - Star"; solarSystemId= 30000934; typeId= 7; age= 12342510243L; luminosity= 0.129600; radius= 581800000L; spectralClass= "K9 V"; temperature= 3609 } |> Some
      | 40071871 -> { StarData.id= 40071871; name= "DOA-YU - Star"; solarSystemId= 30001130; typeId= 45041; age= 10273278249L; luminosity= 0.282000; radius= 477500000L; spectralClass= "K0 V"; temperature= 4839 } |> Some
      | 40074102 -> { StarData.id= 40074102; name= "6-K738 - Star"; solarSystemId= 30001167; typeId= 6; age= 4078256923L; luminosity= 0.411600; radius= 467200000L; spectralClass= "G6 V"; temperature= 5377 } |> Some
      | 40080892 -> { StarData.id= 40080892; name= "YP-J33 - Star"; solarSystemId= 30001271; typeId= 45030; age= 4106776259L; luminosity= 0.371900; radius= 472200000L; spectralClass= "G7 V"; temperature= 5214 } |> Some
      | 40083026 -> { StarData.id= 40083026; name= "QHJ-FW - Star"; solarSystemId= 30001305; typeId= 45040; age= 3935660514L; luminosity= 0.018240; radius= 247500000L; spectralClass= "M0 V"; temperature= 3390 } |> Some
      | 40083996 -> { StarData.id= 40083996; name= "2PLH-3 - Star"; solarSystemId= 30001319; typeId= 7; age= 14646233711L; luminosity= 0.019740; radius= 232000000L; spectralClass= "K9 V"; temperature= 3570 } |> Some
      | 40086906 -> { StarData.id= 40086906; name= "Funtanainen - Star"; solarSystemId= 30001364; typeId= 6; age= 10292290777L; luminosity= 0.026640; radius= 122900000L; spectralClass= "G6 VI"; temperature= 5287 } |> Some
      | 40088167 -> { StarData.id= 40088167; name= "Autaris - Star"; solarSystemId= 30001384; typeId= 45033; age= 24063932961L; luminosity= 0.028870; radius= 215100000L; spectralClass= "K5 V"; temperature= 4078 } |> Some
      | 40105530 -> { StarData.id= 40105530; name= "Ivih - Star"; solarSystemId= 30001656; typeId= 10; age= 1502965946L; luminosity= 3.556000; radius= 830000000L; spectralClass= "F3 V"; temperature= 6916 } |> Some
      | 40109992 -> { StarData.id= 40109992; name= "Rand - Star"; solarSystemId= 30001727; typeId= 3799; age= 3126029727L; luminosity= 0.595000; radius= 493500000L; spectralClass= "G2 V"; temperature= 5737 } |> Some
      | 40111350 -> { StarData.id= 40111350; name= "80G-H5 - Star"; solarSystemId= 30001745; typeId= 8; age= 11052804960L; luminosity= 0.425400; radius= 873400000L; spectralClass= "K6 V"; temperature= 3965 } |> Some
      | 40117267 -> { StarData.id= 40117267; name= "E-C0SR - Star"; solarSystemId= 30001834; typeId= 45033; age= 29929399085L; luminosity= 0.027250; radius= 223600000L; spectralClass= "K6 V"; temperature= 3943 } |> Some
      | 40138413 -> { StarData.id= 40138413; name= "8X6T-8 - Star"; solarSystemId= 30002171; typeId= 3800; age= 38405964049L; luminosity= 0.043890; radius= 384300000L; spectralClass= "M0 V"; temperature= 3388 } |> Some
      | 40139383 -> { StarData.id= 40139383; name= "Amarr - Star"; solarSystemId= 30002187; typeId= 45037; age= 22714021702L; luminosity= 0.084420; radius= 310900000L; spectralClass= "K3 V"; temperature= 4436 } |> Some
      | 40143457 -> { StarData.id= 40143457; name= "Bika - Star"; solarSystemId= 30002252; typeId= 45039; age= 46644866969L; luminosity= 0.012200; radius= 321700000L; spectralClass= "M4 V"; temperature= 2689 } |> Some
      | 40145300 -> { StarData.id= 40145300; name= "Bhizheba - Star"; solarSystemId= 30002282; typeId= 3802; age= 14443430510L; luminosity= 0.036570; radius= 188600000L; spectralClass= "K2 V"; temperature= 4621 } |> Some
      | 40158492 -> { StarData.id= 40158492; name= "LR-2XT - Star"; solarSystemId= 30002493; typeId= 3803; age= 2208976578L; luminosity= 1.107000; radius= 493600000L; spectralClass= "F5 V"; temperature= 6700 } |> Some
      | 40159559 -> { StarData.id= 40159559; name= "Odatrik - Star"; solarSystemId= 30002509; typeId= 45041; age= 16747153978L; luminosity= 0.092110; radius= 304600000L; spectralClass= "K2 V"; temperature= 4580 } |> Some
      | 40161111 -> { StarData.id= 40161111; name= "Gerek - Star"; solarSystemId= 30002531; typeId= 45033; age= 32290162314L; luminosity= 0.171600; radius= 569699968L; spectralClass= "K6 V"; temperature= 3913 } |> Some
      | 40161499 -> { StarData.id= 40161499; name= "Vard - Star"; solarSystemId= 30002538; typeId= 3801; age= 1797348326L; luminosity= 0.135800; radius= 197700000L; spectralClass= "F8 VI"; temperature= 6264 } |> Some
      | 40174206 -> { StarData.id= 40174206; name= "Saikanen - Star"; solarSystemId= 30002745; typeId= 6; age= 10529951732L; luminosity= 0.349300; radius= 474700000L; spectralClass= "G8 V"; temperature= 5120 } |> Some
      | 40179347 -> { StarData.id= 40179347; name= "FBH-JN - Star"; solarSystemId= 30002827; typeId= 45037; age= 12950922025L; luminosity= 0.030200; radius= 200300000L; spectralClass= "K4 V"; temperature= 4274 } |> Some
      | 40180996 -> { StarData.id= 40180996; name= "C3J0-O - Star"; solarSystemId= 30002858; typeId= 45039; age= 34476640045L; luminosity= 0.027170; radius= 557000000L; spectralClass= "M6 V"; temperature= 2496 } |> Some
      | 40181578 -> { StarData.id= 40181578; name= "ND-GL4 - Star"; solarSystemId= 30002867; typeId= 45031; age= 7148832446L; luminosity= 0.123800; radius= 572200000L; spectralClass= "K9 V"; temperature= 3598 } |> Some
      | 40181675 -> { StarData.id= 40181675; name= "9-0QB7 - Star"; solarSystemId= 30002868; typeId= 45036; age= 9084974567L; luminosity= 0.072820; radius= 192500000L; spectralClass= "G5 VI"; temperature= 5433 } |> Some
      | 40191084 -> { StarData.id= 40191084; name= "Halle - Star"; solarSystemId= 30003010; typeId= 3798; age= 23420666693L; luminosity= 0.031050; radius= 210200000L; spectralClass= "K4 V"; temperature= 4201 } |> Some
      | 40216304 -> { StarData.id= 40216304; name= "Arlek - Star"; solarSystemId= 30003411; typeId= 45040; age= 66608360998L; luminosity= 0.012180; radius= 311000000L; spectralClass= "M4 V"; temperature= 2733 } |> Some
      | 40219505 -> { StarData.id= 40219505; name= "Erlendur - Star"; solarSystemId= 30003463; typeId= 45041; age= 12529470397L; luminosity= 0.037840; radius= 202400000L; spectralClass= "K2 V"; temperature= 4498 } |> Some
      | 40224646 -> { StarData.id= 40224646; name= "Miakie - Star"; solarSystemId= 30003539; typeId= 45030; age= 2801543951L; luminosity= 0.346000; radius= 463300000L; spectralClass= "G8 V"; temperature= 5170 } |> Some
      | 40231824 -> { StarData.id= 40231824; name= "ZK-YQ3 - Star"; solarSystemId= 30003658; typeId= 8; age= 26177528972L; luminosity= 0.063190; radius= 340100000L; spectralClass= "K6 V"; temperature= 3945 } |> Some
      | 40235122 -> { StarData.id= 40235122; name= "MH9C-S - Star"; solarSystemId= 30003712; typeId= 3802; age= 13739955000L; luminosity= 0.037260; radius= 199800000L; spectralClass= "K2 V"; temperature= 4510 } |> Some
      | 40242300 -> { StarData.id= 40242300; name= "Aubenall - Star"; solarSystemId= 30003827; typeId= 3803; age= 4506046151L; luminosity= 1.191000; radius= 526800000L; spectralClass= "F5 V"; temperature= 6604 } |> Some
      | 40242785 -> { StarData.id= 40242785; name= "Vlillirier - Star"; solarSystemId= 30003836; typeId= 45033; age= 25417014789L; luminosity= 0.183200; radius= 526700000L; spectralClass= "K5 V"; temperature= 4136 } |> Some
      | 40252194 -> { StarData.id= 40252194; name= "OGY-6D - Star"; solarSystemId= 30003984; typeId= 3797; age= 10076811832L; luminosity= 0.469700; radius= 492600000L; spectralClass= "G5 V"; temperature= 5412 } |> Some
      | 40305738 -> { StarData.id= 40305738; name= "9-MJVQ - Star"; solarSystemId= 30004826; typeId= 3798; age= 11810150751L; luminosity= 0.207900; radius= 520800000L; spectralClass= "K4 V"; temperature= 4294 } |> Some
      | 40310588 -> { StarData.id= 40310588; name= "M9-FIB - Star"; solarSystemId= 30004901; typeId= 45032; age= 31688087316L; luminosity= 0.380700; radius= 915600000L; spectralClass= "K7 V"; temperature= 3767 } |> Some
      | 40314274 -> { StarData.id= 40314274; name= "G-Q5JU - Star"; solarSystemId= 30004962; typeId= 3797; age= 10720080277L; luminosity= 0.071150; radius= 193100000L; spectralClass= "G5 VI"; temperature= 5394 } |> Some
      | 40323586 -> { StarData.id= 40323586; name= "G-GRSZ - Star"; solarSystemId= 30005113; typeId= 3802; age= 12713261071L; luminosity= 0.042910; radius= 194900000L; spectralClass= "K1 V"; temperature= 4731 } |> Some
      | 40331055 -> { StarData.id= 40331055; name= "Chej - Star"; solarSystemId= 30005237; typeId= 7; age= 40655818324L; luminosity= 0.053400; radius= 363600000L; spectralClass= "K8 V"; temperature= 3658 } |> Some
      | 40357536 -> { StarData.id= 40357536; name= "J115048 - Star"; solarSystemId= 31000131; typeId= 9; age= 1449413185L; luminosity= 0.939200; radius= 500700000L; spectralClass= "F7 V"; temperature= 6383 } |> Some
      | 40363647 -> { StarData.id= 40363647; name= "J143649 - Star"; solarSystemId= 31000246; typeId= 45033; age= 7963216365L; luminosity= 0.026010; radius= 209000000L; spectralClass= "K6 V"; temperature= 4030 } |> Some
      | 40371989 -> { StarData.id= 40371989; name= "J151231 - Star"; solarSystemId= 31000409; typeId= 45035; age= 2779045376L; luminosity= 0.220000; radius= 207700000L; spectralClass= "F3 VI"; temperature= 6896 } |> Some
      | 40386539 -> { StarData.id= 40386539; name= "J115347 - Star"; solarSystemId= 31000686; typeId= 3796; age= 386911564L; luminosity= 1.838000; radius= 517500000L; spectralClass= "F0 V"; temperature= 7426 } |> Some
      | 40388576 -> { StarData.id= 40388576; name= "J122638 - Star"; solarSystemId= 31000723; typeId= 45047; age= 12367860644L; luminosity= 0.323800; radius= 472000000L; spectralClass= "G9 V"; temperature= 5038 } |> Some
      | 40394396 -> { StarData.id= 40394396; name= "J132012 - Star"; solarSystemId= 31000830; typeId= 3802; age= 2423505006L; luminosity= 0.042850; radius= 196700000L; spectralClass= "K1 V"; temperature= 4706 } |> Some
      | 40396627 -> { StarData.id= 40396627; name= "J125350 - Star"; solarSystemId= 31000874; typeId= 45039; age= 43032421334L; luminosity= 0.012080; radius= 319400000L; spectralClass= "M4 V"; temperature= 2692 } |> Some
      | 40398082 -> { StarData.id= 40398082; name= "J131228 - Star"; solarSystemId= 31000900; typeId= 45039; age= 40402312145L; luminosity= 0.012490; radius= 318100000L; spectralClass= "M4 V"; temperature= 2720 } |> Some
      | 40407782 -> { StarData.id= 40407782; name= "J205412 - Star"; solarSystemId= 31001095; typeId= 45047; age= 4952847907L; luminosity= 0.815100; radius= 758499968L; spectralClass= "G9 V"; temperature= 5006 } |> Some
      | 40412438 -> { StarData.id= 40412438; name= "J164501 - Star"; solarSystemId= 31001181; typeId= 3798; age= 11201738969L; luminosity= 0.082210; radius= 323900000L; spectralClass= "K4 V"; temperature= 4317 } |> Some
      | 40416706 -> { StarData.id= 40416706; name= "J132746 - Star"; solarSystemId= 31001259; typeId= 3798; age= 15346540830L; luminosity= 0.194400; radius= 518900000L; spectralClass= "K4 V"; temperature= 4230 } |> Some
      | 40421459 -> { StarData.id= 40421459; name= "J133218 - Star"; solarSystemId= 31001356; typeId= 45033; age= 26126828172L; luminosity= 0.011630; radius= 137100000L; spectralClass= "K5 V"; temperature= 4069 } |> Some
      | 40434554 -> { StarData.id= 40434554; name= "J131252 - Star"; solarSystemId= 31001611; typeId= 45047; age= 7085456445L; luminosity= 0.377400; radius= 475900000L; spectralClass= "G7 V"; temperature= 5214 } |> Some
      | 40439307 -> { StarData.id= 40439307; name= "J205922 - Star"; solarSystemId= 31001708; typeId= 45041; age= 2509379582L; luminosity= 0.103700; radius= 300300000L; spectralClass= "K1 V"; temperature= 4751 } |> Some
      | 40442411 -> { StarData.id= 40442411; name= "J171430 - Star"; solarSystemId= 31001767; typeId= 45038; age= 1306182961L; luminosity= 0.696300; radius= 502600000L; spectralClass= "G0 V"; temperature= 5912 } |> Some
      | 40445321 -> { StarData.id= 40445321; name= "J150625 - Star"; solarSystemId= 31001827; typeId= 45035; age= 2861751288L; luminosity= 8.743000; radius= 1287000064L; spectralClass= "F3 IV"; temperature= 6955 } |> Some
      | 40446679 -> { StarData.id= 40446679; name= "J154407 - Star"; solarSystemId= 31001853; typeId= 45039; age= 51081198975L; luminosity= 0.017700; radius= 249000000L; spectralClass= "M0 V"; temperature= 3354 } |> Some
      | 40451723 -> { StarData.id= 40451723; name= "J132601 - Star"; solarSystemId= 31001952; typeId= 45040; age= 21877455230L; luminosity= 0.041460; radius= 437500000L; spectralClass= "M1 V"; temperature= 3130 } |> Some
      | 40452693 -> { StarData.id= 40452693; name= "J120750 - Star"; solarSystemId= 31002500; typeId= 45041; age= 11420386307L; luminosity= 0.040880; radius= 183400000L; spectralClass= "K1 V"; temperature= 4818 } |> Some
      | 40462005 -> { StarData.id= 40462005; name= "J151909 - Star"; solarSystemId= 31002271; typeId= 7; age= 18046365525L; luminosity= 0.021190; radius= 222600000L; spectralClass= "K8 V"; temperature= 3711 } |> Some
      | 40466564 -> { StarData.id= 40466564; name= "J142910 - Star"; solarSystemId= 31002277; typeId= 3803; age= 3824752105L; luminosity= 1.263000; radius= 512500000L; spectralClass= "F4 V"; temperature= 6794 } |> Some
      | 40466758 -> { StarData.id= 40466758; name= "J140524 - Star"; solarSystemId= 31002234; typeId= 8; age= 19833574725L; luminosity= 0.064800; radius= 349100000L; spectralClass= "K6 V"; temperature= 3918 } |> Some
      | 40470444 -> { StarData.id= 40470444; name= "J165953 - Star"; solarSystemId= 31002054; typeId= 3799; age= 3663142895L; luminosity= 3.859000; radius= 1258000000L; spectralClass= "G2 IV"; temperature= 5733 } |> Some
      | 40487807 -> { StarData.id= 40487807; name= "J001348 - Star"; solarSystemId= 31002528; typeId= 34331; age= 440718491L; luminosity= 31.853266; radius= 1244359168L; spectralClass= "A0IV"; temperature= 8936 } |> Some
      | _ -> None