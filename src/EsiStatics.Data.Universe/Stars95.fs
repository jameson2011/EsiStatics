﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stars95=
    let getStar id = 
      match id with 
      | 40003186 -> { StarData.id= 40003186; name= "Fera - Star"; solarSystemId= 30000050; typeId= 3799; age= 3796233041L; luminosity= 0.017370; radius= 41100000L; spectralClass= "G1 VI"; temperature= 5810 } |> Some
      | 40005902 -> { StarData.id= 40005902; name= "Ilahed - Star"; solarSystemId= 30000090; typeId= 45032; age= 26513422047L; luminosity= 0.049240; radius= 362000000L; spectralClass= "K9 V"; temperature= 3593 } |> Some
      | 40006096 -> { StarData.id= 40006096; name= "Ishkad - Star"; solarSystemId= 30000093; typeId= 3802; age= 16189444085L; luminosity= 0.045050; radius= 95250000L; spectralClass= "K0 V"; temperature= 4843 } |> Some
      | 40016087 -> { StarData.id= 40016087; name= "47L-J4 - Star"; solarSystemId= 30000255; typeId= 45047; age= 11290465914L; luminosity= 0.022430; radius= 121300000L; spectralClass= "G8 VI"; temperature= 5099 } |> Some
      | 40020258 -> { StarData.id= 40020258; name= "7G-H7D - Star"; solarSystemId= 30000323; typeId= 3797; age= 3119058448L; luminosity= 0.549900; radius= 484000000L; spectralClass= "G3 V"; temperature= 5680 } |> Some
      | 40026369 -> { StarData.id= 40026369; name= "16-31U - Star"; solarSystemId= 30000425; typeId= 3800; age= 63154361081L; luminosity= 0.011240; radius= 319100000L; spectralClass= "M5 V"; temperature= 2645 } |> Some
      | 40032771 -> { StarData.id= 40032771; name= "7-A6XV - Star"; solarSystemId= 30000525; typeId= 45041; age= 1461771546L; luminosity= 0.260200; radius= 244150000L; spectralClass= "K1 V"; temperature= 4690 } |> Some
      | 40034226 -> { StarData.id= 40034226; name= "JQU-KY - Star"; solarSystemId= 30000548; typeId= 6; age= 5272897934L; luminosity= 0.412900; radius= 481600000L; spectralClass= "G6 V"; temperature= 5300 } |> Some
      | 40036845 -> { StarData.id= 40036845; name= "R4N-LD - Star"; solarSystemId= 30000589; typeId= 45041; age= 13945927682L; luminosity= 0.015470; radius= 62550000L; spectralClass= "K2 V"; temperature= 4574 } |> Some
      | 40047224 -> { StarData.id= 40047224; name= "4DS-OI - Star"; solarSystemId= 30000749; typeId= 3802; age= 15530331503L; luminosity= 0.038230; radius= 99550000L; spectralClass= "K2 V"; temperature= 4547 } |> Some
      | 40057312 -> { StarData.id= 40057312; name= "F-G7BO - Star"; solarSystemId= 30000897; typeId= 45030; age= 3704337432L; luminosity= 0.139900; radius= 293100000L; spectralClass= "G8 V"; temperature= 5184 } |> Some
      | 40065072 -> { StarData.id= 40065072; name= "AAM-1A - Star"; solarSystemId= 30001022; typeId= 3799; age= 3093708048L; luminosity= 1.787000; radius= 399150016L; spectralClass= "G0 V"; temperature= 5938 } |> Some
      | 40078749 -> { StarData.id= 40078749; name= "5-N2EY - Star"; solarSystemId= 30001241; typeId= 45041; age= 15425761511L; luminosity= 0.038360; radius= 96300000L; spectralClass= "K2 V"; temperature= 4627 } |> Some
      | 40097858 -> { StarData.id= 40097858; name= "A-J6SN - Star"; solarSystemId= 30001537; typeId= 45046; age= 3878621841L; luminosity= 1.060000; radius= 511700000L; spectralClass= "F6 V"; temperature= 6509 } |> Some
      | 40110565 -> { StarData.id= 40110565; name= "Uhodoh - Star"; solarSystemId= 30001735; typeId= 45041; age= 10859508023L; luminosity= 0.278000; radius= 222550000L; spectralClass= "K0 V"; temperature= 4994 } |> Some
      | 40113766 -> { StarData.id= 40113766; name= "XDTW-F - Star"; solarSystemId= 30001778; typeId= 3802; age= 2509379582L; luminosity= 0.103700; radius= 150150000L; spectralClass= "K1 V"; temperature= 4751 } |> Some
      | 40119198 -> { StarData.id= 40119198; name= "PSJ-10 - Star"; solarSystemId= 30001863; typeId= 6; age= 2028037593L; luminosity= 0.142400; radius= 296200000L; spectralClass= "G8 V"; temperature= 5179 } |> Some
      | 40123466 -> { StarData.id= 40123466; name= "RRWI-5 - Star"; solarSystemId= 30001931; typeId= 45046; age= 1542892990L; luminosity= 1.004000; radius= 505200000L; spectralClass= "F6 V"; temperature= 6463 } |> Some
      | 40130353 -> { StarData.id= 40130353; name= "H1-J33 - Star"; solarSystemId= 30002043; typeId= 45039; age= 58749712992L; luminosity= 0.020740; radius= 722600000L; spectralClass= "M9 V"; temperature= 2048 } |> Some
      | 40133748 -> { StarData.id= 40133748; name= "Ebolfer - Star"; solarSystemId= 30002094; typeId= 3802; age= 6787588427L; luminosity= 0.103000; radius= 147400000L; spectralClass= "K1 V"; temperature= 4788 } |> Some
      | 40138307 -> { StarData.id= 40138307; name= "Y-C4AL - Star"; solarSystemId= 30002169; typeId= 45038; age= 4493370951L; luminosity= 0.275800; radius= 158250000L; spectralClass= "G0 V"; temperature= 5911 } |> Some
      | 40143060 -> { StarData.id= 40143060; name= "Neziel - Star"; solarSystemId= 30002246; typeId= 3798; age= 26792277537L; luminosity= 0.031730; radius= 209800000L; spectralClass= "K4 V"; temperature= 4228 } |> Some
      | 40159841 -> { StarData.id= 40159841; name= "Dammalin - Star"; solarSystemId= 30002513; typeId= 45038; age= 6198189718L; luminosity= 0.292700; radius= 163250000L; spectralClass= "G0 V"; temperature= 5907 } |> Some
      | 40164788 -> { StarData.id= 40164788; name= "Y-JKJ8 - Star"; solarSystemId= 30002586; typeId= 3802; age= 11246101898L; luminosity= 0.118900; radius= 153700000L; spectralClass= "K0 V"; temperature= 4859 } |> Some
      | 40181957 -> { StarData.id= 40181957; name= "K76A-3 - Star"; solarSystemId= 30002872; typeId= 45047; age= 12744949343L; luminosity= 0.363000; radius= 481200000L; spectralClass= "G8 V"; temperature= 5134 } |> Some
      | 40184285 -> { StarData.id= 40184285; name= "2R-CRW - Star"; solarSystemId= 30002905; typeId= 45036; age= 3897634914L; luminosity= 0.484300; radius= 475100000L; spectralClass= "G4 V"; temperature= 5553 } |> Some
      | 40185061 -> { StarData.id= 40185061; name= "3OAT-Q - Star"; solarSystemId= 30002917; typeId= 45037; age= 15967627267L; luminosity= 0.031830; radius= 210100000L; spectralClass= "K4 V"; temperature= 4228 } |> Some
      | 40198738 -> { StarData.id= 40198738; name= "VUAC-Y - Star"; solarSystemId= 30003129; typeId= 10; age= 1366073459L; luminosity= 1.451000; radius= 507400000L; spectralClass= "F2 V"; temperature= 7069 } |> Some
      | 40198932 -> { StarData.id= 40198932; name= "G-YZUX - Star"; solarSystemId= 30003133; typeId= 8; age= 15948614739L; luminosity= 0.066610; radius= 353900000L; spectralClass= "K6 V"; temperature= 3918 } |> Some
      | 40199417 -> { StarData.id= 40199417; name= "NIZJ-0 - Star"; solarSystemId= 30003141; typeId= 45033; age= 11791137134L; luminosity= 0.074230; radius= 349900000L; spectralClass= "K5 V"; temperature= 4049 } |> Some
      | 40207177 -> { StarData.id= 40207177; name= "QYT-X8 - Star"; solarSystemId= 30003266; typeId= 45041; age= 1562856444L; luminosity= 0.109600; radius= 153650000L; spectralClass= "K1 V"; temperature= 4762 } |> Some
      | 40210669 -> { StarData.id= 40210669; name= "3KNK-A - Star"; solarSystemId= 30003322; typeId= 45037; age= 12266459043L; luminosity= 0.194700; radius= 504900000L; spectralClass= "K4 V"; temperature= 4290 } |> Some
      | 40211348 -> { StarData.id= 40211348; name= "RF-GGF - Star"; solarSystemId= 30003333; typeId= 3799; age= 1125560884L; luminosity= 0.091300; radius= 98400000L; spectralClass= "G2 VI"; temperature= 5686 } |> Some
      | 40213676 -> { StarData.id= 40213676; name= "ZV-72W - Star"; solarSystemId= 30003369; typeId= 45040; age= 19155449615L; luminosity= 0.016480; radius= 255000000L; spectralClass= "M1 V"; temperature= 3255 } |> Some
      | 40216877 -> { StarData.id= 40216877; name= "Libold - Star"; solarSystemId= 30003421; typeId= 45040; age= 20540217538L; luminosity= 0.011380; radius= 322400000L; spectralClass= "M5 V"; temperature= 2640 } |> Some
      | 40219593 -> { StarData.id= 40219593; name= "Eurgrana - Star"; solarSystemId= 30003466; typeId= 6; age= 5611960489L; luminosity= 0.812700; radius= 752899968L; spectralClass= "G9 V"; temperature= 5021 } |> Some
      | 40242873 -> { StarData.id= 40242873; name= "Oicx - Star"; solarSystemId= 30003838; typeId= 3800; age= 54947146434L; luminosity= 0.016010; radius= 262600000L; spectralClass= "M1 V"; temperature= 3185 } |> Some
      | 40247044 -> { StarData.id= 40247044; name= "Firbha - Star"; solarSystemId= 30003906; typeId= 3798; age= 19424797753L; luminosity= 0.080870; radius= 332000000L; spectralClass= "K4 V"; temperature= 4247 } |> Some
      | 40259945 -> { StarData.id= 40259945; name= "Zimmem - Star"; solarSystemId= 30004107; typeId= 45035; age= 639782466L; luminosity= 1.517000; radius= 508500000L; spectralClass= "F2 V"; temperature= 7141 } |> Some
      | 40262758 -> { StarData.id= 40262758; name= "Salah - Star"; solarSystemId= 30004146; typeId= 45030; age= 10583820924L; luminosity= 0.389600; radius= 488400000L; spectralClass= "G7 V"; temperature= 5187 } |> Some
      | 40263049 -> { StarData.id= 40263049; name= "Shaggoth - Star"; solarSystemId= 30004150; typeId= 45030; age= 7681192483L; luminosity= 0.060730; radius= 190100000L; spectralClass= "G7 VI"; temperature= 5224 } |> Some
      | 40276338 -> { StarData.id= 40276338; name= "P7Z-R3 - Star"; solarSystemId= 30004362; typeId= 3802; age= 5970035572L; luminosity= 0.114200; radius= 150400000L; spectralClass= "K0 V"; temperature= 4863 } |> Some
      | 40286038 -> { StarData.id= 40286038; name= "GA-2V7 - Star"; solarSystemId= 30004523; typeId= 45031; age= 7018911509L; luminosity= 0.155300; radius= 578800000L; spectralClass= "K7 V"; temperature= 3786 } |> Some
      | 40287299 -> { StarData.id= 40287299; name= "Z-40CG - Star"; solarSystemId= 30004542; typeId= 45038; age= 6562603217L; luminosity= 0.644300; radius= 246650000L; spectralClass= "G1 V"; temperature= 5853 } |> Some
      | 40298745 -> { StarData.id= 40298745; name= "0N-3RO - Star"; solarSystemId= 30004720; typeId= 45041; age= 8514588930L; luminosity= 0.100400; radius= 152100000L; spectralClass= "K1 V"; temperature= 4682 } |> Some
      | 40303013 -> { StarData.id= 40303013; name= "Y5C-YD - Star"; solarSystemId= 30004785; typeId= 45036; age= 4544071751L; luminosity= 0.464100; radius= 486400000L; spectralClass= "G5 V"; temperature= 5430 } |> Some
      | 40303110 -> { StarData.id= 40303110; name= "31X-RE - Star"; solarSystemId= 30004786; typeId= 7; age= 12710091590L; luminosity= 0.056760; radius= 359100000L; spectralClass= "K8 V"; temperature= 3737 } |> Some
      | 40304953 -> { StarData.id= 40304953; name= "78R-PI - Star"; solarSystemId= 30004816; typeId= 45039; age= 55644284071L; luminosity= 0.013960; radius= 313200000L; spectralClass= "M3 V"; temperature= 2818 } |> Some
      | 40305535 -> { StarData.id= 40305535; name= "M-4KDB - Star"; solarSystemId= 30004823; typeId= 45034; age= 3995867850L; luminosity= 1.080000; radius= 524100000L; spectralClass= "F6 V"; temperature= 6462 } |> Some
      | 40311549 -> { StarData.id= 40311549; name= "0DD-MH - Star"; solarSystemId= 30004917; typeId= 45036; age= 1798298979L; luminosity= 0.518900; radius= 496400000L; spectralClass= "G4 V"; temperature= 5527 } |> Some
      | 40315332 -> { StarData.id= 40315332; name= "Actee - Star"; solarSystemId= 30004981; typeId= 3803; age= 1957056364L; luminosity= 7.214000; radius= 632000000L; spectralClass= "F5 V"; temperature= 6689 } |> Some
      | 40319115 -> { StarData.id= 40319115; name= "Amdonen - Star"; solarSystemId= 30005036; typeId= 6; age= 11908382871L; luminosity= 0.158200; radius= 305000000L; spectralClass= "G7 V"; temperature= 5239 } |> Some
      | 40319503 -> { StarData.id= 40319503; name= "Danyana - Star"; solarSystemId= 30005044; typeId= 45042; age= 1658871370L; luminosity= 7.593000; radius= 631000000L; spectralClass= "F4 IV"; temperature= 6780 } |> Some
      | 40323189 -> { StarData.id= 40323189; name= "LW-YEW - Star"; solarSystemId= 30005106; typeId= 45033; age= 7424519000L; luminosity= 0.072840; radius= 334000000L; spectralClass= "K5 V"; temperature= 4125 } |> Some
      | 40323480 -> { StarData.id= 40323480; name= "6-1T6Z - Star"; solarSystemId= 30005111; typeId= 3798; age= 4521890015L; luminosity= 0.083740; radius= 324100000L; spectralClass= "K3 V"; temperature= 4336 } |> Some
      | 40324159 -> { StarData.id= 40324159; name= "C6CG-W - Star"; solarSystemId= 30005122; typeId= 45041; age= 7617816482L; luminosity= 0.267400; radius= 250050000L; spectralClass= "K1 V"; temperature= 4666 } |> Some
      | 40326875 -> { StarData.id= 40326875; name= "3LL-O0 - Star"; solarSystemId= 30005166; typeId= 45035; age= 1434836678L; luminosity= 3.749000; radius= 806099968L; spectralClass= "F2 V"; temperature= 7111 } |> Some
      | 40342201 -> { StarData.id= 40342201; name= "Sakenta - Star"; solarSystemId= 30010141; typeId= 56084; age= 2495174354L; luminosity= 0.791039; radius= 823328640L; spectralClass= "F1 VI"; temperature= 7405 } |> Some
      | 40351222 -> { StarData.id= 40351222; name= "J105711 - Star"; solarSystemId= 31000017; typeId= 45030; age= 6381980935L; luminosity= 0.128800; radius= 298800000L; spectralClass= "G9 V"; temperature= 5028 } |> Some
      | 40351513 -> { StarData.id= 40351513; name= "J155429 - Star"; solarSystemId= 31000024; typeId= 45037; age= 4249372669L; luminosity= 0.034270; radius= 196200000L; spectralClass= "K3 V"; temperature= 4457 } |> Some
      | 40351901 -> { StarData.id= 40351901; name= "J153001 - Star"; solarSystemId= 31000031; typeId= 45047; age= 12890713872L; luminosity= 0.332900; radius= 465000000L; spectralClass= "G8 V"; temperature= 5111 } |> Some
      | 40356266 -> { StarData.id= 40356266; name= "J102206 - Star"; solarSystemId= 31000107; typeId= 45040; age= 31279312522L; luminosity= 0.014060; radius= 292000000L; spectralClass= "M3 V"; temperature= 2924 } |> Some
      | 40367712 -> { StarData.id= 40367712; name= "J112744 - Star"; solarSystemId= 31000326; typeId= 3800; age= 71234822639L; luminosity= 0.021690; radius= 628000000L; spectralClass= "M8 V"; temperature= 2222 } |> Some
      | 40372368 -> { StarData.id= 40372368; name= "J103217 - Star"; solarSystemId= 31000416; typeId= 7; age= 28012269492L; luminosity= 0.059200; radius= 357400000L; spectralClass= "K7 V"; temperature= 3786 } |> Some
      | 40380613 -> { StarData.id= 40380613; name= "J225316 - Star"; solarSystemId= 31000569; typeId= 45033; age= 24881486905L; luminosity= 0.070300; radius= 335800000L; spectralClass= "K5 V"; temperature= 4077 } |> Some
      | 40381971 -> { StarData.id= 40381971; name= "J233129 - Star"; solarSystemId= 31000592; typeId= 9; age= 3995867850L; luminosity= 1.080000; radius= 524100000L; spectralClass= "F6 V"; temperature= 6462 } |> Some
      | 40382165 -> { StarData.id= 40382165; name= "J132617 - Star"; solarSystemId= 31000596; typeId= 45041; age= 12519963045L; luminosity= 4.395000; radius= 883500032L; spectralClass= "K0 IV"; temperature= 4997 } |> Some
      | 40382844 -> { StarData.id= 40382844; name= "J115314 - Star"; solarSystemId= 31000613; typeId= 3796; age= 765584221L; luminosity= 4.632000; radius= 830700032L; spectralClass= "F0 V"; temperature= 7386 } |> Some
      | 40391671 -> { StarData.id= 40391671; name= "J122635 - Star"; solarSystemId= 31000780; typeId= 45031; age= 31751463861L; luminosity= 0.024310; radius= 224400000L; spectralClass= "K7 V"; temperature= 3825 } |> Some
      | 40401468 -> { StarData.id= 40401468; name= "J163526 - Star"; solarSystemId= 31000967; typeId= 9; age= 3948335714L; luminosity= 0.414100; radius= 322900000L; spectralClass= "F6 VI"; temperature= 6477 } |> Some
      | 40406221 -> { StarData.id= 40406221; name= "J105017 - Star"; solarSystemId= 31001061; typeId= 45034; age= 1091337762L; luminosity= 0.379300; radius= 329100000L; spectralClass= "F7 VI"; temperature= 6277 } |> Some
      | 40406706 -> { StarData.id= 40406706; name= "J132750 - Star"; solarSystemId= 31001070; typeId= 3799; age= 1954204403L; luminosity= 0.247300; radius= 160800000L; spectralClass= "G2 V"; temperature= 5706 } |> Some
      | 40407579 -> { StarData.id= 40407579; name= "J124830 - Star"; solarSystemId= 31001089; typeId= 3796; age= 1069156094L; luminosity= 4.216000; radius= 811200000L; spectralClass= "F1 V"; temperature= 7300 } |> Some
      | 40408258 -> { StarData.id= 40408258; name= "J101736 - Star"; solarSystemId= 31001103; typeId= 3799; age= 2095533183L; luminosity= 0.298100; radius= 165350000L; spectralClass= "G0 V"; temperature= 5896 } |> Some
      | 40410780 -> { StarData.id= 40410780; name= "J113347 - Star"; solarSystemId= 31001155; typeId= 3798; age= 23407990949L; luminosity= 0.079480; radius= 318800000L; spectralClass= "K4 V"; temperature= 4315 } |> Some
      | 40422808 -> { StarData.id= 40422808; name= "J104754 - Star"; solarSystemId= 31001379; typeId= 8; age= 27967905475L; luminosity= 0.165500; radius= 552099968L; spectralClass= "K6 V"; temperature= 3939 } |> Some
      | 40426009 -> { StarData.id= 40426009; name= "J142214 - Star"; solarSystemId= 31001441; typeId= 45036; age= 7598803410L; luminosity= 0.512000; radius= 489000000L; spectralClass= "G4 V"; temperature= 5551 } |> Some
      | 40427464 -> { StarData.id= 40427464; name= "J111555 - Star"; solarSystemId= 31001466; typeId= 3799; age= 2259677514L; luminosity= 0.245500; radius= 157250000L; spectralClass= "G2 V"; temperature= 5760 } |> Some
      | 40436291 -> { StarData.id= 40436291; name= "J104404 - Star"; solarSystemId= 31001643; typeId= 45036; age= 5098613524L; luminosity= 1.442000; radius= 803100032L; spectralClass= "G3 V"; temperature= 5611 } |> Some
      | 40439686 -> { StarData.id= 40439686; name= "J103228 - Star"; solarSystemId= 31001716; typeId= 3797; age= 7551271546L; luminosity= 0.460700; radius= 478400000L; spectralClass= "G5 V"; temperature= 5466 } |> Some
      | 40448513 -> { StarData.id= 40448513; name= "J102446 - Star"; solarSystemId= 31001889; typeId= 3796; age= 495918564L; luminosity= 0.264100; radius= 207100000L; spectralClass= "F1 VI"; temperature= 7227 } |> Some
      | 40452975 -> { StarData.id= 40452975; name= "J112003 - Star"; solarSystemId= 31001973; typeId= 45038; age= 2089829398L; luminosity= 0.017470; radius= 39105000L; spectralClass= "G0 VI"; temperature= 5965 } |> Some
      | 40453460 -> { StarData.id= 40453460; name= "J142438 - Star"; solarSystemId= 31001983; typeId= 45040; age= 6400994008L; luminosity= 0.013940; radius= 306100000L; spectralClass= "M3 V"; temperature= 2850 } |> Some
      | 40466264 -> { StarData.id= 40466264; name= "J111003 - Star"; solarSystemId= 31002320; typeId= 45032; age= 12754455607L; luminosity= 0.059620; radius= 340000000L; spectralClass= "K7 V"; temperature= 3888 } |> Some
      | 40472569 -> { StarData.id= 40472569; name= "J222604 - Star"; solarSystemId= 31002495; typeId= 45033; age= 24605799806L; luminosity= 0.064890; radius= 351100000L; spectralClass= "K6 V"; temperature= 3908 } |> Some
      | 40488380 -> { StarData.id= 40488380; name= "J000427 - Star"; solarSystemId= 31002603; typeId= 34331; age= 471948823L; luminosity= 33.121517; radius= 1229130752L; spectralClass= "A0IV"; temperature= 9844 } |> Some
      | _ -> None