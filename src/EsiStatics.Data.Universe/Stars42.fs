﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stars42=
    let getStar id = 
      match id with 
      | 40000999 -> { StarData.id= 40000999; name= "Nazhgete - Star"; solarSystemId= 30000016; typeId= 45039; age= 55644284071L; luminosity= 0.013960; radius= 313200000L; spectralClass= "M3 V"; temperature= 2818 } |> Some
      | 40001581 -> { StarData.id= 40001581; name= "Fovihi - Star"; solarSystemId= 30000023; typeId= 45034; age= 3995867850L; luminosity= 1.080000; radius= 524100000L; spectralClass= "F6 V"; temperature= 6462 } |> Some
      | 40007595 -> { StarData.id= 40007595; name= "Khabi - Star"; solarSystemId= 30000117; typeId= 45036; age= 1798298979L; luminosity= 0.518900; radius= 496400000L; spectralClass= "G4 V"; temperature= 5527 } |> Some
      | 40011378 -> { StarData.id= 40011378; name= "Korsiki - Star"; solarSystemId= 30000181; typeId= 3803; age= 1957056364L; luminosity= 7.214000; radius= 1264000000L; spectralClass= "F5 V"; temperature= 6689 } |> Some
      | 40015161 -> { StarData.id= 40015161; name= "N-5QPW - Star"; solarSystemId= 30000236; typeId= 6; age= 11908382871L; luminosity= 0.158200; radius= 305000000L; spectralClass= "G7 V"; temperature= 5239 } |> Some
      | 40015549 -> { StarData.id= 40015549; name= "K8X-6B - Star"; solarSystemId= 30000244; typeId= 45042; age= 1658871370L; luminosity= 7.593000; radius= 1262000000L; spectralClass= "F4 IV"; temperature= 6780 } |> Some
      | 40019235 -> { StarData.id= 40019235; name= "Y-ZXIO - Star"; solarSystemId= 30000306; typeId= 45033; age= 7424519000L; luminosity= 0.072840; radius= 334000000L; spectralClass= "K5 V"; temperature= 4125 } |> Some
      | 40019526 -> { StarData.id= 40019526; name= "BR-6XP - Star"; solarSystemId= 30000311; typeId= 3798; age= 4521890015L; luminosity= 0.083740; radius= 324100000L; spectralClass= "K3 V"; temperature= 4336 } |> Some
      | 40020205 -> { StarData.id= 40020205; name= "VORM-W - Star"; solarSystemId= 30000322; typeId= 45041; age= 7617816482L; luminosity= 0.267400; radius= 500100000L; spectralClass= "K1 V"; temperature= 4666 } |> Some
      | 40022921 -> { StarData.id= 40022921; name= "J-Z1UW - Star"; solarSystemId= 30000366; typeId= 45035; age= 1434836678L; luminosity= 3.749000; radius= 806099968L; spectralClass= "F2 V"; temperature= 7111 } |> Some
      | 40034076 -> { StarData.id= 40034076; name= "G9L-LP - Star"; solarSystemId= 30000545; typeId= 3798; age= 3932491578L; luminosity= 0.030830; radius= 207200000L; spectralClass= "K4 V"; temperature= 4224 } |> Some
      | 40035434 -> { StarData.id= 40035434; name= "SR-4EK - Star"; solarSystemId= 30000565; typeId= 45047; age= 11936902752L; luminosity= 0.173200; radius= 309000000L; spectralClass= "G6 V"; temperature= 5325 } |> Some
      | 40043776 -> { StarData.id= 40043776; name= "SD4A-2 - Star"; solarSystemId= 30000692; typeId= 3797; age= 10720080277L; luminosity= 0.177000; radius= 301400000L; spectralClass= "G5 V"; temperature= 5421 } |> Some
      | 40049693 -> { StarData.id= 40049693; name= "74-VZA - Star"; solarSystemId= 30000787; typeId= 45040; age= 52982482254L; luminosity= 0.012360; radius= 311100000L; spectralClass= "M4 V"; temperature= 2743 } |> Some
      | 40054543 -> { StarData.id= 40054543; name= "UMI-KK - Star"; solarSystemId= 30000858; typeId= 45038; age= 5944685171L; luminosity= 0.696400; radius= 497500000L; spectralClass= "G0 V"; temperature= 5943 } |> Some
      | 40054640 -> { StarData.id= 40054640; name= "GKP-YT - Star"; solarSystemId= 30000859; typeId= 45047; age= 8967728830L; luminosity= 0.343600; radius= 463900000L; spectralClass= "G8 V"; temperature= 5158 } |> Some
      | 40062400 -> { StarData.id= 40062400; name= "HB-1NJ - Star"; solarSystemId= 30000979; typeId= 8; age= 30591680059L; luminosity= 0.182000; radius= 542499968L; spectralClass= "K5 V"; temperature= 4069 } |> Some
      | 40070548 -> { StarData.id= 40070548; name= "Y-XZA7 - Star"; solarSystemId= 30001108; typeId= 3797; age= 9034273766L; luminosity= 0.070820; radius= 189800000L; spectralClass= "G5 VI"; temperature= 5433 } |> Some
      | 40075301 -> { StarData.id= 40075301; name= "RNF-YH - Star"; solarSystemId= 30001187; typeId= 45036; age= 3488858486L; luminosity= 0.507800; radius= 496500000L; spectralClass= "G4 V"; temperature= 5497 } |> Some
      | 40099454 -> { StarData.id= 40099454; name= "4HF-4R - Star"; solarSystemId= 30001558; typeId= 45032; age= 28012269492L; luminosity= 0.059200; radius= 357400000L; spectralClass= "K7 V"; temperature= 3786 } |> Some
      | 40099648 -> { StarData.id= 40099648; name= "L7-BLT - Star"; solarSystemId= 30001560; typeId= 45030; age= 5139808061L; luminosity= 0.379900; radius= 472600000L; spectralClass= "G7 V"; temperature= 5240 } |> Some
      | 40102170 -> { StarData.id= 40102170; name= "P3UD-M - Star"; solarSystemId= 30001604; typeId= 3800; age= 28506603929L; luminosity= 0.032150; radius= 485000000L; spectralClass= "M4 V"; temperature= 2790 } |> Some
      | 40108378 -> { StarData.id= 40108378; name= "Arkoz - Star"; solarSystemId= 30001704; typeId= 45030; age= 6705199354L; luminosity= 0.362100; radius= 483500000L; spectralClass= "G8 V"; temperature= 5119 } |> Some
      | 40109639 -> { StarData.id= 40109639; name= "Marthia - Star"; solarSystemId= 30001722; typeId= 45047; age= 4182827460L; luminosity= 0.958200; radius= 765000000L; spectralClass= "G7 V"; temperature= 5190 } |> Some
      | 40109736 -> { StarData.id= 40109736; name= "Assiad - Star"; solarSystemId= 30001723; typeId= 6; age= 10583820924L; luminosity= 0.126500; radius= 299000000L; spectralClass= "G9 V"; temperature= 5005 } |> Some
      | 40111482 -> { StarData.id= 40111482; name= "2EV-BA - Star"; solarSystemId= 30001746; typeId= 3803; age= 1397127781L; luminosity= 3.282000; radius= 835400000L; spectralClass= "F4 V"; temperature= 6757 } |> Some
      | 40117399 -> { StarData.id= 40117399; name= "0Y1-M7 - Star"; solarSystemId= 30001837; typeId= 45030; age= 3637792495L; luminosity= 0.359700; radius= 475800000L; spectralClass= "G8 V"; temperature= 5152 } |> Some
      | 40120891 -> { StarData.id= 40120891; name= "S91-TI - Star"; solarSystemId= 30001891; typeId= 45030; age= 4997211379L; luminosity= 0.798900; radius= 733299968L; spectralClass= "G9 V"; temperature= 5066 } |> Some
      | 40123801 -> { StarData.id= 40123801; name= "QCKK-T - Star"; solarSystemId= 30001935; typeId= 45031; age= 4125789060L; luminosity= 0.024300; radius= 219500000L; spectralClass= "K7 V"; temperature= 3867 } |> Some
      | 40133016 -> { StarData.id= 40133016; name= "Uisper - Star"; solarSystemId= 30002083; typeId= 3796; age= 641050027L; luminosity= 1.688000; radius= 509100000L; spectralClass= "F1 V"; temperature= 7330 } |> Some
      | 40145335 -> { StarData.id= 40145335; name= "2G-VDP - Star"; solarSystemId= 30002283; typeId= 45031; age= 28043957765L; luminosity= 0.058150; radius= 355300000L; spectralClass= "K7 V"; temperature= 3780 } |> Some
      | 40145723 -> { StarData.id= 40145723; name= "AID-9T - Star"; solarSystemId= 30002289; typeId= 45047; age= 9744087149L; luminosity= 0.843000; radius= 728300032L; spectralClass= "G8 V"; temperature= 5152 } |> Some
      | 40148439 -> { StarData.id= 40148439; name= "1GH-48 - Star"; solarSystemId= 30002332; typeId= 45035; age= 641683773L; luminosity= 1.484000; radius= 511700000L; spectralClass= "F2 V"; temperature= 7080 } |> Some
      | 40163377 -> { StarData.id= 40163377; name= "Jorus - Star"; solarSystemId= 30002567; typeId= 45039; age= 75956344742L; luminosity= 0.010490; radius= 384300000L; spectralClass= "M6 V"; temperature= 2369 } |> Some
      | 40164638 -> { StarData.id= 40164638; name= "TM-0P2 - Star"; solarSystemId= 30002584; typeId= 3802; age= 15292671638L; luminosity= 0.109700; radius= 300000000L; spectralClass= "K1 V"; temperature= 4821 } |> Some
      | 40170846 -> { StarData.id= 40170846; name= "Olettiers - Star"; solarSystemId= 30002686; typeId= 3797; age= 5402818871L; luminosity= 0.184900; radius= 308700000L; spectralClass= "G5 V"; temperature= 5415 } |> Some
      | 40179382 -> { StarData.id= 40179382; name= "BVRQ-O - Star"; solarSystemId= 30002828; typeId= 3798; age= 16341546486L; luminosity= 0.034650; radius= 197900000L; spectralClass= "K3 V"; temperature= 4451 } |> Some
      | 40182292 -> { StarData.id= 40182292; name= "BGMZ-0 - Star"; solarSystemId= 30002876; typeId= 3803; age= 3349431013L; luminosity= 0.186400; radius= 209400000L; spectralClass= "F5 VI"; temperature= 6588 } |> Some
      | 40191507 -> { StarData.id= 40191507; name= "Harerget - Star"; solarSystemId= 30003017; typeId= 6; age= 9978578623L; luminosity= 0.052990; radius= 186500000L; spectralClass= "G8 VI"; temperature= 5098 } |> Some
      | 40194611 -> { StarData.id= 40194611; name= "Lamaa - Star"; solarSystemId= 30003063; typeId= 45038; age= 7541764737L; luminosity= 0.749000; radius= 523700000L; spectralClass= "G0 V"; temperature= 5899 } |> Some
      | 40210131 -> { StarData.id= 40210131; name= "IIRH-G - Star"; solarSystemId= 30003311; typeId= 6; age= 6464370008L; luminosity= 0.052900; radius= 185100000L; spectralClass= "G8 VI"; temperature= 5115 } |> Some
      | 40214399 -> { StarData.id= 40214399; name= "Todrir - Star"; solarSystemId= 30003383; typeId= 45047; age= 4826095906L; luminosity= 5.875000; radius= 1831000064L; spectralClass= "G7 IV"; temperature= 5279 } |> Some
      | 40215466 -> { StarData.id= 40215466; name= "Anbald - Star"; solarSystemId= 30003398; typeId= 45034; age= 1836958394L; luminosity= 0.398300; radius= 318700000L; spectralClass= "F6 VI"; temperature= 6457 } |> Some
      | 40232053 -> { StarData.id= 40232053; name= "EN-GTB - Star"; solarSystemId= 30003662; typeId= 45033; age= 13708266727L; luminosity= 0.074370; radius= 344800000L; spectralClass= "K5 V"; temperature= 4081 } |> Some
      | 40236224 -> { StarData.id= 40236224; name= "B-WPLZ - Star"; solarSystemId= 30003730; typeId= 3799; age= 5142976452L; luminosity= 0.269000; radius= 318300000L; spectralClass= "G1 V"; temperature= 5858 } |> Some
      | 40239231 -> { StarData.id= 40239231; name= "H9-J8N - Star"; solarSystemId= 30003775; typeId= 45038; age= 3900803578L; luminosity= 0.108700; radius= 205600000L; spectralClass= "G1 VI"; temperature= 5810 } |> Some
      | 40247670 -> { StarData.id= 40247670; name= "Rahabeda - Star"; solarSystemId= 30003914; typeId= 3797; age= 6974548036L; luminosity= 0.500000; radius= 495500000L; spectralClass= "G4 V"; temperature= 5482 } |> Some
      | 40253975 -> { StarData.id= 40253975; name= "8QT-H4 - Star"; solarSystemId= 30004012; typeId= 45032; age= 33018988225L; luminosity= 0.022570; radius= 237000000L; spectralClass= "K8 V"; temperature= 3653 } |> Some
      | 40256400 -> { StarData.id= 40256400; name= "O-0HW8 - Star"; solarSystemId= 30004050; typeId= 8; age= 24577279926L; luminosity= 0.167300; radius= 561299968L; spectralClass= "K6 V"; temperature= 3917 } |> Some
      | 40267264 -> { StarData.id= 40267264; name= "E-EFAM - Star"; solarSystemId= 30004217; typeId= 45039; age= 80297611932L; luminosity= 0.024960; radius= 598600000L; spectralClass= "M7 V"; temperature= 2357 } |> Some
      | 40277061 -> { StarData.id= 40277061; name= "5-P1Y2 - Star"; solarSystemId= 30004374; typeId= 45036; age= 6727380818L; luminosity= 0.212600; radius= 303800000L; spectralClass= "G3 V"; temperature= 5653 } |> Some
      | 40284045 -> { StarData.id= 40284045; name= "KJ-V0P - Star"; solarSystemId= 30004488; typeId= 45033; age= 19624432563L; luminosity= 0.064770; radius= 340800000L; spectralClass= "K6 V"; temperature= 3965 } |> Some
      | 40286955 -> { StarData.id= 40286955; name= "W2F-ZH - Star"; solarSystemId= 30004538; typeId= 6; age= 5783075962L; luminosity= 0.311200; radius= 457200000L; spectralClass= "G9 V"; temperature= 5068 } |> Some
      | 40290835 -> { StarData.id= 40290835; name= "UAYL-F - Star"; solarSystemId= 30004602; typeId= 45041; age= 2198519524L; luminosity= 0.015600; radius= 121600000L; spectralClass= "K2 V"; temperature= 4650 } |> Some
      | 40299080 -> { StarData.id= 40299080; name= "E3OI-U - Star"; solarSystemId= 30004725; typeId= 45046; age= 3132050488L; luminosity= 16.930000; radius= 2096000000L; spectralClass= "F6 IV"; temperature= 6429 } |> Some
      | 40300438 -> { StarData.id= 40300438; name= "T-M0FA - Star"; solarSystemId= 30004745; typeId= 45039; age= 32638731133L; luminosity= 0.126800; radius= 1800000000L; spectralClass= "M9 V"; temperature= 2041 } |> Some
      | 40300729 -> { StarData.id= 40300729; name= "D-3GIQ - Star"; solarSystemId= 30004750; typeId= 45041; age= 2966955775L; luminosity= 0.091630; radius= 308600000L; spectralClass= "K2 V"; temperature= 4544 } |> Some
      | 40302281 -> { StarData.id= 40302281; name= "M2-XFE - Star"; solarSystemId= 30004773; typeId= 45047; age= 9347985921L; luminosity= 0.381900; radius= 474300000L; spectralClass= "G7 V"; temperature= 5238 } |> Some
      | 40322651 -> { StarData.id= 40322651; name= "V-3K7C - Star"; solarSystemId= 30005097; typeId= 45040; age= 24748397032L; luminosity= 0.018590; radius= 236700000L; spectralClass= "M0 V"; temperature= 3483 } |> Some
      | 40323136 -> { StarData.id= 40323136; name= "RZ3O-K - Star"; solarSystemId= 30005105; typeId= 3798; age= 21402135499L; luminosity= 0.034040; radius= 193400000L; spectralClass= "K3 V"; temperature= 4481 } |> Some
      | 40327792 -> { StarData.id= 40327792; name= "2AUL-X - Star"; solarSystemId= 30005182; typeId= 3796; age= 1947549828L; luminosity= 1.705000; radius= 512100000L; spectralClass= "F1 V"; temperature= 7327 } |> Some
      | 40337201 -> { StarData.id= 40337201; name= "Osmomonne - Star"; solarSystemId= 30005332; typeId= 45038; age= 486095257L; luminosity= 0.104200; radius= 198900000L; spectralClass= "G1 VI"; temperature= 5845 } |> Some
      | 40347677 -> { StarData.id= 40347677; name= "Okagaiken - Star"; solarSystemId= 30045307; typeId= 45047; age= 11911552352L; luminosity= 0.022450; radius= 121500000L; spectralClass= "G8 VI"; temperature= 5095 } |> Some
      | 40350005 -> { StarData.id= 40350005; name= "Notoras - Star"; solarSystemId= 30045348; typeId= 45041; age= 5051081116L; luminosity= 0.111900; radius= 286400000L; spectralClass= "K0 V"; temperature= 4959 } |> Some
      | 40363585 -> { StarData.id= 40363585; name= "J213653 - Star"; solarSystemId= 31000245; typeId= 45031; age= 4867290442L; luminosity= 0.061250; radius= 347600000L; spectralClass= "K7 V"; temperature= 3872 } |> Some
      | 40363682 -> { StarData.id= 40363682; name= "J223855 - Star"; solarSystemId= 31000247; typeId= 3802; age= 7548102610L; luminosity= 0.115100; radius= 287000000L; spectralClass= "K0 V"; temperature= 4988 } |> Some
      | 40364070 -> { StarData.id= 40364070; name= "J122712 - Star"; solarSystemId= 31000255; typeId= 3800; age= 48926409517L; luminosity= 0.018810; radius= 238900000L; spectralClass= "M0 V"; temperature= 3476 } |> Some
      | 40370569 -> { StarData.id= 40370569; name= "J211936 - Star"; solarSystemId= 31000382; typeId= 45041; age= 7113975782L; luminosity= 0.016030; radius= 115300000L; spectralClass= "K1 V"; temperature= 4809 } |> Some
      | 40375419 -> { StarData.id= 40375419; name= "J143359 - Star"; solarSystemId= 31000473; typeId= 45033; age= 17114736413L; luminosity= 2.780000; radius= 2072000000L; spectralClass= "K5 IV"; temperature= 4116 } |> Some
      | 40376195 -> { StarData.id= 40376195; name= "J113108 - Star"; solarSystemId= 31000486; typeId= 3801; age= 5051081116L; luminosity= 0.844700; radius= 494800000L; spectralClass= "F8 V"; temperature= 6253 } |> Some
      | 40379687 -> { StarData.id= 40379687; name= "J121412 - Star"; solarSystemId= 31000554; typeId= 45035; age= 987400835L; luminosity= 1.348000; radius= 502900000L; spectralClass= "F3 V"; temperature= 6972 } |> Some
      | 40381045 -> { StarData.id= 40381045; name= "J214238 - Star"; solarSystemId= 31000577; typeId= 45030; age= 5193677797L; luminosity= 0.333400; radius= 455800000L; spectralClass= "G8 V"; temperature= 5164 } |> Some
      | 40381433 -> { StarData.id= 40381433; name= "J223853 - Star"; solarSystemId= 31000583; typeId= 45033; age= 28135854190L; luminosity= 0.074840; radius= 329900000L; spectralClass= "K5 V"; temperature= 4178 } |> Some
      | 40383858 -> { StarData.id= 40383858; name= "J231644 - Star"; solarSystemId= 31000632; typeId= 3802; age= 14855375874L; luminosity= 0.278300; radius= 466800000L; spectralClass= "K0 V"; temperature= 4878 } |> Some
      | 40389290 -> { StarData.id= 40389290; name= "J143234 - Star"; solarSystemId= 31000735; typeId= 3799; age= 971239860L; luminosity= 0.245200; radius= 319600000L; spectralClass= "G2 V"; temperature= 5711 } |> Some
      | 40391909 -> { StarData.id= 40391909; name= "J144004 - Star"; solarSystemId= 31000784; typeId= 45037; age= 6118969581L; luminosity= 0.552700; radius= 818800000L; spectralClass= "K3 IV"; temperature= 4372 } |> Some
      | 40402482 -> { StarData.id= 40402482; name= "J152143 - Star"; solarSystemId= 31000987; typeId= 3799; age= 1609121087L; luminosity= 0.243800; radius= 311400000L; spectralClass= "G2 V"; temperature= 5777 } |> Some
      | 40404519 -> { StarData.id= 40404519; name= "J111309 - Star"; solarSystemId= 31001026; typeId= 45036; age= 582743929L; luminosity= 0.561400; radius= 492500000L; spectralClass= "G3 V"; temperature= 5660 } |> Some
      | 40410339 -> { StarData.id= 40410339; name= "J170132 - Star"; solarSystemId= 31001146; typeId= 3800; age= 73136105919L; luminosity= 0.021530; radius= 688000000L; spectralClass= "M8 V"; temperature= 2119 } |> Some
      | 40415771 -> { StarData.id= 40415771; name= "J173330 - Star"; solarSystemId= 31001241; typeId= 45036; age= 6274241462L; luminosity= 0.487700; radius= 488300000L; spectralClass= "G4 V"; temperature= 5487 } |> Some
      | 40435559 -> { StarData.id= 40435559; name= "J145944 - Star"; solarSystemId= 31001628; typeId= 45036; age= 7551271546L; luminosity= 0.226700; radius= 317600000L; spectralClass= "G3 V"; temperature= 5619 } |> Some
      | 40441088 -> { StarData.id= 40441088; name= "J140932 - Star"; solarSystemId= 31001742; typeId= 3798; age= 5057418988L; luminosity= 0.033410; radius= 201000000L; spectralClass= "K3 V"; temperature= 4375 } |> Some
      | 40441573 -> { StarData.id= 40441573; name= "J113158 - Star"; solarSystemId= 31001751; typeId= 45041; age= 12317159843L; luminosity= 0.042830; radius= 194300000L; spectralClass= "K1 V"; temperature= 4735 } |> Some
      | 40446035 -> { StarData.id= 40446035; name= "J170127 - Star"; solarSystemId= 31001839; typeId= 45036; age= 4930666443L; luminosity= 1.401000; radius= 784499968L; spectralClass= "G3 V"; temperature= 5636 } |> Some
      | 40446617 -> { StarData.id= 40446617; name= "J225530 - Star"; solarSystemId= 31001852; typeId= 3796; age= 1468109146L; luminosity= 1.739000; radius= 512300000L; spectralClass= "F0 V"; temperature= 7362 } |> Some
      | 40459809 -> { StarData.id= 40459809; name= "J115308 - Star"; solarSystemId= 31002165; typeId= 45037; age= 11721423806L; luminosity= 0.012820; radius= 133000000L; spectralClass= "K4 V"; temperature= 4234 } |> Some
      | 40466987 -> { StarData.id= 40466987; name= "J161747 - Star"; solarSystemId= 31002472; typeId= 45041; age= 1238687371L; luminosity= 0.108100; radius= 311600000L; spectralClass= "K1 V"; temperature= 4713 } |> Some
      | 40479597 -> { StarData.id= 40479597; name= "J145825 - Star"; solarSystemId= 31002241; typeId= 45041; age= 6350921986L; luminosity= 0.114273; radius= 218318064L; spectralClass= "K1 V"; temperature= 4781 } |> Some
      | 40487939 -> { StarData.id= 40487939; name= "J005259 - Star"; solarSystemId= 31002546; typeId= 34331; age= 464738826L; luminosity= 30.754679; radius= 1215595264L; spectralClass= "A0IV"; temperature= 9916 } |> Some
      | _ -> None