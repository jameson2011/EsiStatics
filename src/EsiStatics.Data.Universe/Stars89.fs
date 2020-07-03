﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stars89=
    let getStar id = 
      match id with 
      | 40011037 -> { StarData.id= 40011037; name= "Onuse - Star"; solarSystemId= 30000174; typeId= 45039; age= 19881107134L; luminosity= 0.014720; radius= 288400000L; spectralClass= "M2 V"; temperature= 2976 } |> Some
      | 40012201 -> { StarData.id= 40012201; name= "Vouskiaho - Star"; solarSystemId= 30000193; typeId= 45030; age= 1701650374L; luminosity= 0.766100; radius= 719400000L; spectralClass= "G9 V"; temperature= 5061 } |> Some
      | 40020834 -> { StarData.id= 40020834; name= "Y-T3JJ - Star"; solarSystemId= 30000331; typeId= 3800; age= 12916064272L; luminosity= 0.045930; radius= 390800000L; spectralClass= "M0 V"; temperature= 3398 } |> Some
      | 40021222 -> { StarData.id= 40021222; name= "G-EA07 - Star"; solarSystemId= 30000338; typeId= 3802; age= 15834537394L; luminosity= 0.687000; radius= 389249984L; spectralClass= "K1 IV"; temperature= 4735 } |> Some
      | 40022192 -> { StarData.id= 40022192; name= "BFJ-TB - Star"; solarSystemId= 30000355; typeId= 45040; age= 8961391502L; luminosity= 0.015060; radius= 286700000L; spectralClass= "M2 V"; temperature= 3002 } |> Some
      | 40025684 -> { StarData.id= 40025684; name= "Z-YOJ9 - Star"; solarSystemId= 30000414; typeId= 45040; age= 48482773703L; luminosity= 0.015500; radius= 272900000L; spectralClass= "M2 V"; temperature= 3100 } |> Some
      | 40037421 -> { StarData.id= 40037421; name= "LKZ-CY - Star"; solarSystemId= 30000599; typeId= 6; age= 9161025767L; luminosity= 0.133500; radius= 286800000L; spectralClass= "G8 V"; temperature= 5179 } |> Some
      | 40039167 -> { StarData.id= 40039167; name= "VK-A5G - Star"; solarSystemId= 30000625; typeId= 45037; age= 9069130975L; luminosity= 0.218300; radius= 494800000L; spectralClass= "K3 V"; temperature= 4459 } |> Some
      | 40043823 -> { StarData.id= 40043823; name= "U6K-RG - Star"; solarSystemId= 30000693; typeId= 45033; age= 20704995684L; luminosity= 0.029640; radius= 212400000L; spectralClass= "K5 V"; temperature= 4131 } |> Some
      | 40044114 -> { StarData.id= 40044114; name= "ZNF-OK - Star"; solarSystemId= 30000699; typeId= 3802; age= 12605521598L; luminosity= 0.097630; radius= 156050000L; spectralClass= "K2 V"; temperature= 4591 } |> Some
      | 40046442 -> { StarData.id= 40046442; name= "KD-KPR - Star"; solarSystemId= 30000737; typeId= 3798; age= 3961010914L; luminosity= 0.225700; radius= 514000000L; spectralClass= "K3 V"; temperature= 4411 } |> Some
      | 40048673 -> { StarData.id= 40048673; name= "8G-2FP - Star"; solarSystemId= 30000771; typeId= 45033; age= 11949577408L; luminosity= 0.025340; radius= 207600000L; spectralClass= "K6 V"; temperature= 4018 } |> Some
      | 40059149 -> { StarData.id= 40059149; name= "VKU-BG - Star"; solarSystemId= 30000927; typeId= 45042; age= 2413681631L; luminosity= 1.170000; radius= 260300000L; spectralClass= "F5 V"; temperature= 6614 } |> Some
      | 40059440 -> { StarData.id= 40059440; name= "W-RFUO - Star"; solarSystemId= 30000932; typeId= 45040; age= 4109944923L; luminosity= 0.017710; radius= 245600000L; spectralClass= "M0 V"; temperature= 3378 } |> Some
      | 40060798 -> { StarData.id= 40060798; name= "DE71-9 - Star"; solarSystemId= 30000954; typeId= 8; age= 5310923534L; luminosity= 0.431300; radius= 908000000L; spectralClass= "K6 V"; temperature= 3902 } |> Some
      | 40065648 -> { StarData.id= 40065648; name= "S1DP-Y - Star"; solarSystemId= 30001030; typeId= 3802; age= 2347136694L; luminosity= 0.116600; radius= 146150000L; spectralClass= "K0 V"; temperature= 4959 } |> Some
      | 40073796 -> { StarData.id= 40073796; name= "HY-RWO - Star"; solarSystemId= 30001159; typeId= 3801; age= 4826095906L; luminosity= 0.053320; radius= 64450000L; spectralClass= "F8 VI"; temperature= 6141 } |> Some
      | 40073893 -> { StarData.id= 40073893; name= "HED-GP - Star"; solarSystemId= 30001161; typeId= 45041; age= 11350672979L; luminosity= 0.017540; radius= 57850000L; spectralClass= "K0 V"; temperature= 4910 } |> Some
      | 40078258 -> { StarData.id= 40078258; name= "UL-7I8 - Star"; solarSystemId= 30001234; typeId= 45030; age= 7484726609L; luminosity= 0.152200; radius= 304500000L; spectralClass= "G7 V"; temperature= 5193 } |> Some
      | 40079713 -> { StarData.id= 40079713; name= "CNC-4V - Star"; solarSystemId= 30001254; typeId= 3796; age= 2066063330L; luminosity= 0.752700; radius= 325100000L; spectralClass= "F0 VI"; temperature= 7496 } |> Some
      | 40082332 -> { StarData.id= 40082332; name= "P-GKF5 - Star"; solarSystemId= 30001293; typeId= 45031; age= 28221411655L; luminosity= 0.022400; radius= 234300000L; spectralClass= "K8 V"; temperature= 3667 } |> Some
      | 40087861 -> { StarData.id= 40087861; name= "Ekura - Star"; solarSystemId= 30001378; typeId= 45030; age= 9386012066L; luminosity= 0.394300; radius= 479000000L; spectralClass= "G7 V"; temperature= 5254 } |> Some
      | 40090674 -> { StarData.id= 40090674; name= "Isinokka - Star"; solarSystemId= 30001426; typeId= 7; age= 34223133866L; luminosity= 0.060320; radius= 362700000L; spectralClass= "K7 V"; temperature= 3776 } |> Some
      | 40096009 -> { StarData.id= 40096009; name= "2L5-FI - Star"; solarSystemId= 30001510; typeId= 45038; age= 6042918380L; luminosity= 0.702900; radius= 252950000L; spectralClass= "G0 V"; temperature= 5907 } |> Some
      | 40102120 -> { StarData.id= 40102120; name= "6-HFD6 - Star"; solarSystemId= 30001603; typeId= 45039; age= 12174563706L; luminosity= 0.018070; radius= 244200000L; spectralClass= "M0 V"; temperature= 3404 } |> Some
      | 40112693 -> { StarData.id= 40112693; name= "K4UV-G - Star"; solarSystemId= 30001762; typeId= 45047; age= 8451212929L; luminosity= 0.053060; radius= 181400000L; spectralClass= "G8 VI"; temperature= 5170 } |> Some
      | 40123169 -> { StarData.id= 40123169; name= "U6-FCE - Star"; solarSystemId= 30001927; typeId= 45032; age= 32733793773L; luminosity= 0.019290; radius= 237800000L; spectralClass= "K9 V"; temperature= 3506 } |> Some
      | 40123848 -> { StarData.id= 40123848; name= "RP-H66 - Star"; solarSystemId= 30001936; typeId= 9; age= 1618944462L; luminosity= 2.663000; radius= 830200000L; spectralClass= "F6 V"; temperature= 6433 } |> Some
      | 40124333 -> { StarData.id= 40124333; name= "L-A9FS - Star"; solarSystemId= 30001945; typeId= 45036; age= 9379674194L; luminosity= 0.036090; radius= 128200000L; spectralClass= "G3 VI"; temperature= 5586 } |> Some
      | 40144315 -> { StarData.id= 40144315; name= "Ahmak - Star"; solarSystemId= 30002266; typeId= 45030; age= 12497782125L; luminosity= 0.021280; radius= 115700000L; spectralClass= "G8 VI"; temperature= 5153 } |> Some
      | 40144412 -> { StarData.id= 40144412; name= "Adia - Star"; solarSystemId= 30002268; typeId= 8; age= 16002483931L; luminosity= 0.073040; radius= 328800000L; spectralClass= "K5 V"; temperature= 4160 } |> Some
      | 40150135 -> { StarData.id= 40150135; name= "ZZ5X-M - Star"; solarSystemId= 30002360; typeId= 45033; age= 28820316084L; luminosity= 0.010050; radius= 138000000L; spectralClass= "K6 V"; temperature= 3912 } |> Some
      | 40172542 -> { StarData.id= 40172542; name= "Pozirblant - Star"; solarSystemId= 30002714; typeId= 3802; age= 3625117295L; luminosity= 0.047320; radius= 97700000L; spectralClass= "K0 V"; temperature= 4842 } |> Some
      | 40183406 -> { StarData.id= 40183406; name= "FO8M-2 - Star"; solarSystemId= 30002891; typeId= 3803; age= 1250728893L; luminosity= 1.250000; radius= 259050000L; spectralClass= "F4 V"; temperature= 6741 } |> Some
      | 40184085 -> { StarData.id= 40184085; name= "YA0-XJ - Star"; solarSystemId= 30002902; typeId= 3800; age= 10482419323L; luminosity= 0.013120; radius= 344300000L; spectralClass= "M4 V"; temperature= 2647 } |> Some
      | 40184958 -> { StarData.id= 40184958; name= "ZZZR-5 - Star"; solarSystemId= 30002914; typeId= 3798; age= 17016503204L; luminosity= 0.014030; radius= 128500000L; spectralClass= "K3 V"; temperature= 4405 } |> Some
      | 40196016 -> { StarData.id= 40196016; name= "Sahtogas - Star"; solarSystemId= 30003086; typeId= 3800; age= 18002002597L; luminosity= 0.038130; radius= 436300000L; spectralClass= "M2 V"; temperature= 3070 } |> Some
      | 40207753 -> { StarData.id= 40207753; name= "2X-PQG - Star"; solarSystemId= 30003275; typeId= 45039; age= 86413413666L; luminosity= 0.020310; radius= 729200000L; spectralClass= "M9 V"; temperature= 2028 } |> Some
      | 40220557 -> { StarData.id= 40220557; name= "Akila - Star"; solarSystemId= 30003479; typeId= 45041; age= 10995766288L; luminosity= 0.271800; radius= 250350000L; spectralClass= "K1 V"; temperature= 4682 } |> Some
      | 40221236 -> { StarData.id= 40221236; name= "Arbaz - Star"; solarSystemId= 30003487; typeId= 3802; age= 10060967695L; luminosity= 0.105100; radius= 151550000L; spectralClass= "K1 V"; temperature= 4746 } |> Some
      | 40226280 -> { StarData.id= 40226280; name= "Misaba - Star"; solarSystemId= 30003563; typeId= 3802; age= 9490582058L; luminosity= 0.687300; radius= 401800000L; spectralClass= "K1 IV"; temperature= 4660 } |> Some
      | 40227153 -> { StarData.id= 40227153; name= "Octanneve - Star"; solarSystemId= 30003578; typeId= 45033; age= 26126828172L; luminosity= 0.011630; radius= 137100000L; spectralClass= "K5 V"; temperature= 4069 } |> Some
      | 40227444 -> { StarData.id= 40227444; name= "Sarline - Star"; solarSystemId= 30003584; typeId= 6; age= 1328681537L; luminosity= 0.322000; radius= 473900000L; spectralClass= "G9 V"; temperature= 5021 } |> Some
      | 40234719 -> { StarData.id= 40234719; name= "4B-NQN - Star"; solarSystemId= 30003706; typeId= 3800; age= 4620123224L; luminosity= 0.029650; radius= 572400000L; spectralClass= "M5 V"; temperature= 2517 } |> Some
      | 40250724 -> { StarData.id= 40250724; name= "MKD-O8 - Star"; solarSystemId= 30003962; typeId= 7; age= 24548762223L; luminosity= 0.154400; radius= 555299968L; spectralClass= "K7 V"; temperature= 3860 } |> Some
      | 40255089 -> { StarData.id= 40255089; name= "E-VKJV - Star"; solarSystemId= 30004028; typeId= 45038; age= 1474446746L; luminosity= 0.733100; radius= 255250000L; spectralClass= "G0 V"; temperature= 5942 } |> Some
      | 40259357 -> { StarData.id= 40259357; name= "Dantan - Star"; solarSystemId= 30004097; typeId= 45036; age= 9113493903L; luminosity= 0.456800; radius= 488300000L; spectralClass= "G5 V"; temperature= 5398 } |> Some
      | 40274101 -> { StarData.id= 40274101; name= "B-GC1T - Star"; solarSystemId= 30004328; typeId= 45042; age= 2513815875L; luminosity= 0.495300; radius= 163900000L; spectralClass= "F4 VI"; temperature= 6723 } |> Some
      | 40277593 -> { StarData.id= 40277593; name= "D4R-H7 - Star"; solarSystemId= 30004386; typeId= 45035; age= 1368291605L; luminosity= 0.094410; radius= 129800000L; spectralClass= "F2 VI"; temperature= 7060 } |> Some
      | 40280406 -> { StarData.id= 40280406; name= "I5Q2-S - Star"; solarSystemId= 30004430; typeId= 3798; age= 5640479825L; luminosity= 0.034820; radius= 200500000L; spectralClass= "K3 V"; temperature= 4427 } |> Some
      | 40282249 -> { StarData.id= 40282249; name= "J94-MU - Star"; solarSystemId= 30004460; typeId= 45037; age= 22666489294L; luminosity= 0.036060; radius= 209300000L; spectralClass= "K3 V"; temperature= 4371 } |> Some
      | 40298157 -> { StarData.id= 40298157; name= "PR-8CA - Star"; solarSystemId= 30004711; typeId= 3800; age= 23648819206L; luminosity= 0.065430; radius= 863100032L; spectralClass= "M6 V"; temperature= 2498 } |> Some
      | 40306111 -> { StarData.id= 40306111; name= "KW-OAM - Star"; solarSystemId= 30004833; typeId= 45036; age= 8692042275L; luminosity= 0.492500; radius= 475100000L; spectralClass= "G4 V"; temperature= 5577 } |> Some
      | 40335017 -> { StarData.id= 40335017; name= "Costolle - Star"; solarSystemId= 30005298; typeId= 45046; age= 349519608L; luminosity= 2.394000; radius= 802300032L; spectralClass= "F7 V"; temperature= 6372 } |> Some
      | 40336181 -> { StarData.id= 40336181; name= "Eletta - Star"; solarSystemId= 30005315; typeId= 3801; age= 1803685926L; luminosity= 0.845500; radius= 255900000L; spectralClass= "F8 V"; temperature= 6150 } |> Some
      | 40336375 -> { StarData.id= 40336375; name= "Raneilles - Star"; solarSystemId= 30005319; typeId= 45037; age= 11594671805L; luminosity= 0.202900; radius= 531800000L; spectralClass= "K4 V"; temperature= 4223 } |> Some
      | 40342001 -> { StarData.id= 40342001; name= "Laah - Star"; solarSystemId= 30041392; typeId= 45047; age= 9079450024L; luminosity= 0.158996; radius= 197425424L; spectralClass= "G9 V"; temperature= 5054 } |> Some
      | 40357812 -> { StarData.id= 40357812; name= "J215900 - Star"; solarSystemId= 31000136; typeId= 3799; age= 5640479825L; luminosity= 0.682700; radius= 255800000L; spectralClass= "G1 V"; temperature= 5831 } |> Some
      | 40358200 -> { StarData.id= 40358200; name= "J161811 - Star"; solarSystemId= 31000142; typeId= 8; age= 13486449909L; luminosity= 0.011370; radius= 133600000L; spectralClass= "K5 V"; temperature= 4099 } |> Some
      | 40358976 -> { StarData.id= 40358976; name= "J213555 - Star"; solarSystemId= 31000158; typeId= 3802; age= 10102162232L; luminosity= 0.232100; radius= 237200000L; spectralClass= "K2 V"; temperature= 4624 } |> Some
      | 40364699 -> { StarData.id= 40364699; name= "J215754 - Star"; solarSystemId= 31000266; typeId= 45033; age= 20704995684L; luminosity= 0.029640; radius= 212400000L; spectralClass= "K5 V"; temperature= 4131 } |> Some
      | 40370034 -> { StarData.id= 40370034; name= "J144605 - Star"; solarSystemId= 31000372; typeId= 7; age= 38691154145L; luminosity= 0.121200; radius= 573200000L; spectralClass= "K9 V"; temperature= 3576 } |> Some
      | 40372944 -> { StarData.id= 40372944; name= "J112820 - Star"; solarSystemId= 31000427; typeId= 3799; age= 6603797753L; luminosity= 0.097160; radius= 100450000L; spectralClass= "G2 VI"; temperature= 5716 } |> Some
      | 40373526 -> { StarData.id= 40373526; name= "J112801 - Star"; solarSystemId= 31000438; typeId= 7; age= 36631429504L; luminosity= 0.023850; radius= 217600000L; spectralClass= "K7 V"; temperature= 3866 } |> Some
      | 40373817 -> { StarData.id= 40373817; name= "J235117 - Star"; solarSystemId= 31000444; typeId= 45041; age= 15929602211L; luminosity= 0.112100; radius= 143850000L; spectralClass= "K0 V"; temperature= 4951 } |> Some
      | 40375563 -> { StarData.id= 40375563; name= "J134323 - Star"; solarSystemId= 31000476; typeId= 45033; age= 5501052080L; luminosity= 0.456200; radius= 864099968L; spectralClass= "K5 V"; temperature= 4057 } |> Some
      | 40385651 -> { StarData.id= 40385651; name= "J155035 - Star"; solarSystemId= 31000667; typeId= 45037; age= 17640758033L; luminosity= 0.030730; radius= 200300000L; spectralClass= "K4 V"; temperature= 4293 } |> Some
      | 40388658 -> { StarData.id= 40388658; name= "J161411 - Star"; solarSystemId= 31000724; typeId= 3798; age= 21826754430L; luminosity= 0.528100; radius= 761200000L; spectralClass= "K3 IV"; temperature= 4483 } |> Some
      | 40395448 -> { StarData.id= 40395448; name= "J100642 - Star"; solarSystemId= 31000852; typeId= 3799; age= 6749562827L; luminosity= 4.099000; radius= 631000000L; spectralClass= "G1 IV"; temperature= 5812 } |> Some
      | 40398552 -> { StarData.id= 40398552; name= "J124646 - Star"; solarSystemId= 31000912; typeId= 3797; age= 1617993809L; luminosity= 0.555100; radius= 493300000L; spectralClass= "G3 V"; temperature= 5639 } |> Some
      | 40399328 -> { StarData.id= 40399328; name= "J164034 - Star"; solarSystemId= 31000926; typeId= 45040; age= 25958881635L; luminosity= 0.012020; radius= 338700000L; spectralClass= "M5 V"; temperature= 2611 } |> Some
      | 40400395 -> { StarData.id= 40400395; name= "J111856 - Star"; solarSystemId= 31000946; typeId= 45035; age= 3428651150L; luminosity= 0.094520; radius= 130800000L; spectralClass= "F2 VI"; temperature= 7035 } |> Some
      | 40416594 -> { StarData.id= 40416594; name= "J230708 - Star"; solarSystemId= 31001257; typeId= 3802; age= 12095343025L; luminosity= 0.267300; radius= 239950000L; spectralClass= "K1 V"; temperature= 4763 } |> Some
      | 40417661 -> { StarData.id= 40417661; name= "J213423 - Star"; solarSystemId= 31001277; typeId= 45038; age= 6068268781L; luminosity= 0.107500; radius= 99650000L; spectralClass= "G1 VI"; temperature= 5885 } |> Some
      | 40418049 -> { StarData.id= 40418049; name= "J155545 - Star"; solarSystemId= 31001285; typeId= 7; age= 32543666316L; luminosity= 0.139800; radius= 584800000L; spectralClass= "K8 V"; temperature= 3669 } |> Some
      | 40421541 -> { StarData.id= 40421541; name= "J115448 - Star"; solarSystemId= 31001358; typeId= 45037; age= 2583846587L; luminosity= 0.083480; radius= 307700000L; spectralClass= "K3 V"; temperature= 4446 } |> Some
      | 40422608 -> { StarData.id= 40422608; name= "J160225 - Star"; solarSystemId= 31001375; typeId= 8; age= 9053286839L; luminosity= 0.067230; radius= 351900000L; spectralClass= "K6 V"; temperature= 3938 } |> Some
      | 40439971 -> { StarData.id= 40439971; name= "J145739 - Star"; solarSystemId= 31001720; typeId= 45037; age= 14804675073L; luminosity= 0.012190; radius= 124300000L; spectralClass= "K4 V"; temperature= 4324 } |> Some
      | 40444433 -> { StarData.id= 40444433; name= "J172926 - Star"; solarSystemId= 31001808; typeId= 45038; age= 5177833661L; luminosity= 0.736800; radius= 255500000L; spectralClass= "G0 V"; temperature= 5947 } |> Some
      | 40452096 -> { StarData.id= 40452096; name= "J121649 - Star"; solarSystemId= 31001959; typeId= 3802; age= 16674272258L; luminosity= 0.045900; radius= 96700000L; spectralClass= "K0 V"; temperature= 4829 } |> Some
      | 40454812 -> { StarData.id= 40454812; name= "J114403 - Star"; solarSystemId= 31002006; typeId= 45039; age= 18236494071L; luminosity= 0.047280; radius= 373800000L; spectralClass= "M0 V"; temperature= 3500 } |> Some
      | 40473630 -> { StarData.id= 40473630; name= "J160855 - Star"; solarSystemId= 31002398; typeId= 3800; age= 50067178613L; luminosity= 0.010430; radius= 382400000L; spectralClass= "M6 V"; temperature= 2371 } |> Some
      | 40481293 -> { StarData.id= 40481293; name= "J132328 - Star"; solarSystemId= 31002473; typeId= 45041; age= 9490582058L; luminosity= 0.687300; radius= 401800000L; spectralClass= "K1 IV"; temperature= 4660 } |> Some
      | 40485464 -> { StarData.id= 40485464; name= "J172937 - Star"; solarSystemId= 31002144; typeId= 45032; age= 10922887834L; luminosity= 0.095512; radius= 356084128L; spectralClass= "K7 V"; temperature= 3742 } |> Some
      | _ -> None