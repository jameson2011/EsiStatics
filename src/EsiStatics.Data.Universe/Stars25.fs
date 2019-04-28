﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stars25=
    let getStar id = 
      match id with 
      | 40002340 -> { StarData.id= 40002340; name= "Yishinoon - Star"; solarSystemId= 30000036; typeId= 3801; age= 4937004315L; luminosity= 2.257000; radius= 807600000L; spectralClass= "F8 V"; temperature= 6258 } |> Some
      | 40007093 -> { StarData.id= 40007093; name= "Gamis - Star"; solarSystemId= 30000107; typeId= 45042; age= 919271431L; luminosity= 0.176900; radius= 199000000L; spectralClass= "F5 VI"; temperature= 6671 } |> Some
      | 40010779 -> { StarData.id= 40010779; name= "Vahunomi - Star"; solarSystemId= 30000170; typeId= 45039; age= 25784596136L; luminosity= 0.011960; radius= 346800000L; spectralClass= "M5 V"; temperature= 2577 } |> Some
      | 40015629 -> { StarData.id= 40015629; name= "X445-5 - Star"; solarSystemId= 30000245; typeId= 45038; age= 3155499853L; luminosity= 0.037130; radius= 124300000L; spectralClass= "G2 VI"; temperature= 5714 } |> Some
      | 40023680 -> { StarData.id= 40023680; name= "PE1-R1 - Star"; solarSystemId= 30000379; typeId= 3799; age= 3945167050L; luminosity= 0.287100; radius= 324400000L; spectralClass= "G0 V"; temperature= 5897 } |> Some
      | 40029888 -> { StarData.id= 40029888; name= "0-G8NO - Star"; solarSystemId= 30000480; typeId= 3803; age= 362828589L; luminosity= 3.008000; radius= 839299968L; spectralClass= "F5 V"; temperature= 6596 } |> Some
      | 40030276 -> { StarData.id= 40030276; name= "TYB-69 - Star"; solarSystemId= 30000485; typeId= 8; age= 17666108434L; luminosity= 0.029760; radius= 211100000L; spectralClass= "K5 V"; temperature= 4148 } |> Some
      | 40031149 -> { StarData.id= 40031149; name= "XW2H-V - Star"; solarSystemId= 30000499; typeId= 45031; age= 24795929441L; luminosity= 0.058810; radius= 360500000L; spectralClass= "K7 V"; temperature= 3763 } |> Some
      | 40035902 -> { StarData.id= 40035902; name= "H6-EYX - Star"; solarSystemId= 30000574; typeId= 45047; age= 6252059454L; luminosity= 0.332100; radius= 451900000L; spectralClass= "G8 V"; temperature= 5182 } |> Some
      | 40047639 -> { StarData.id= 40047639; name= "2JT-3Q - Star"; solarSystemId= 30000757; typeId= 3800; age= 54059879161L; luminosity= 0.022900; radius= 686200000L; spectralClass= "M8 V"; temperature= 2155 } |> Some
      | 40052683 -> { StarData.id= 40052683; name= "X1-IZ0 - Star"; solarSystemId= 30000833; typeId= 45035; age= 3549065823L; luminosity= 1.349000; radius= 500600000L; spectralClass= "F3 V"; temperature= 6989 } |> Some
      | 40055981 -> { StarData.id= 40055981; name= "DBT-GB - Star"; solarSystemId= 30000877; typeId= 45032; age= 32638731133L; luminosity= 0.128700; radius= 605400000L; spectralClass= "K9 V"; temperature= 3532 } |> Some
      | 40058212 -> { StarData.id= 40058212; name= "UMDQ-6 - Star"; solarSystemId= 30000911; typeId= 8; age= 12830506808L; luminosity= 0.072550; radius= 331200000L; spectralClass= "K5 V"; temperature= 4138 } |> Some
      | 40061995 -> { StarData.id= 40061995; name= "H7O-JZ - Star"; solarSystemId= 30000973; typeId= 45033; age= 21747533749L; luminosity= 0.065510; radius= 344800000L; spectralClass= "K6 V"; temperature= 3953 } |> Some
      | 40066360 -> { StarData.id= 40066360; name= "G-0Q86 - Star"; solarSystemId= 30001041; typeId= 3801; age= 898040416L; luminosity= 0.909900; radius= 516800000L; spectralClass= "F8 V"; temperature= 6234 } |> Some
      | 40074896 -> { StarData.id= 40074896; name= "KW-I6T - Star"; solarSystemId= 30001180; typeId= 45040; age= 25958881635L; luminosity= 0.012020; radius= 338700000L; spectralClass= "M5 V"; temperature= 2611 } |> Some
      | 40077127 -> { StarData.id= 40077127; name= "AOK-WQ - Star"; solarSystemId= 30001216; typeId= 45031; age= 31425075962L; luminosity= 0.376000; radius= 908000000L; spectralClass= "K7 V"; temperature= 3771 } |> Some
      | 40087991 -> { StarData.id= 40087991; name= "Vellaine - Star"; solarSystemId= 30001380; typeId= 45040; age= 58591275985L; luminosity= 0.019470; radius= 686300032L; spectralClass= "M9 V"; temperature= 2069 } |> Some
      | 40089349 -> { StarData.id= 40089349; name= "Airkio - Star"; solarSystemId= 30001404; typeId= 45042; age= 2103455251L; luminosity= 0.514200; radius= 327000000L; spectralClass= "F4 VI"; temperature= 6795 } |> Some
      | 40094393 -> { StarData.id= 40094393; name= "9-ERCP - Star"; solarSystemId= 30001484; typeId= 45036; age= 2082541144L; luminosity= 0.073950; radius= 193800000L; spectralClass= "G5 VI"; temperature= 5435 } |> Some
      | 40107100 -> { StarData.id= 40107100; name= "Nasesharafa - Star"; solarSystemId= 30001683; typeId= 3802; age= 13873044873L; luminosity= 0.040130; radius= 191100000L; spectralClass= "K1 V"; temperature= 4698 } |> Some
      | 40109525 -> { StarData.id= 40109525; name= "Modun - Star"; solarSystemId= 30001720; typeId= 45036; age= 4214515732L; luminosity= 0.444600; radius= 468400000L; spectralClass= "G5 V"; temperature= 5474 } |> Some
      | 40114957 -> { StarData.id= 40114957; name= "UAJ5-K - Star"; solarSystemId= 30001797; typeId= 3796; age= 963001021L; luminosity= 1.633000; radius= 518000000L; spectralClass= "F1 V"; temperature= 7206 } |> Some
      | 40115539 -> { StarData.id= 40115539; name= "ZZK-VF - Star"; solarSystemId= 30001807; typeId= 45030; age= 13369204172L; luminosity= 0.123500; radius= 286700000L; spectralClass= "G9 V"; temperature= 5080 } |> Some
      | 40117188 -> { StarData.id= 40117188; name= "MB4D-4 - Star"; solarSystemId= 30001832; typeId= 8; age= 10428550131L; luminosity= 0.010400; radius= 134600000L; spectralClass= "K6 V"; temperature= 3993 } |> Some
      | 40120292 -> { StarData.id= 40120292; name= "WEQT-K - Star"; solarSystemId= 30001878; typeId= 3797; age= 4930666443L; luminosity= 1.401000; radius= 784499968L; spectralClass= "G3 V"; temperature= 5636 } |> Some
      | 40130671 -> { StarData.id= 40130671; name= "UI-8ZE - Star"; solarSystemId= 30002047; typeId= 45037; age= 4087763459L; luminosity= 0.225400; radius= 522000000L; spectralClass= "K3 V"; temperature= 4376 } |> Some
      | 40136394 -> { StarData.id= 40136394; name= "QE-E1D - Star"; solarSystemId= 30002138; typeId= 3802; age= 8108981438L; luminosity= 0.015230; radius= 123200000L; spectralClass= "K2 V"; temperature= 4592 } |> Some
      | 40136976 -> { StarData.id= 40136976; name= "W-FHWJ - Star"; solarSystemId= 30002147; typeId= 3797; age= 1460820892L; luminosity= 0.030550; radius= 121400000L; spectralClass= "G4 VI"; temperature= 5506 } |> Some
      | 40144251 -> { StarData.id= 40144251; name= "Azizora - Star"; solarSystemId= 30002265; typeId= 45036; age= 8562121338L; luminosity= 0.465200; radius= 489000000L; spectralClass= "G5 V"; temperature= 5419 } |> Some
      | 40146870 -> { StarData.id= 40146870; name= "GN-TNT - Star"; solarSystemId= 30002306; typeId= 3800; age= 46042789793L; luminosity= 0.018550; radius= 236300000L; spectralClass= "M0 V"; temperature= 3483 } |> Some
      | 40147937 -> { StarData.id= 40147937; name= "R-6KYM - Star"; solarSystemId= 30002324; typeId= 45032; age= 3536390622L; luminosity= 0.062130; radius= 369200000L; spectralClass= "K7 V"; temperature= 3770 } |> Some
      | 40149392 -> { StarData.id= 40149392; name= "89-JPE - Star"; solarSystemId= 30002346; typeId= 45032; age= 26171192189L; luminosity= 0.048640; radius= 370800000L; spectralClass= "K9 V"; temperature= 3539 } |> Some
      | 40151817 -> { StarData.id= 40151817; name= "Bosena - Star"; solarSystemId= 30002387; typeId= 3800; age= 53140923616L; luminosity= 0.018390; radius= 242000000L; spectralClass= "M0 V"; temperature= 3434 } |> Some
      | 40152787 -> { StarData.id= 40152787; name= "Gonheim - Star"; solarSystemId= 30002403; typeId= 45030; age= 10526782251L; luminosity= 0.398300; radius= 473400000L; spectralClass= "G6 V"; temperature= 5298 } |> Some
      | 40154533 -> { StarData.id= 40154533; name= "WH-2EZ - Star"; solarSystemId= 30002429; typeId= 45039; age= 59605291992L; luminosity= 0.010290; radius= 378000000L; spectralClass= "M6 V"; temperature= 2377 } |> Some
      | 40156473 -> { StarData.id= 40156473; name= "4VY-Y1 - Star"; solarSystemId= 30002461; typeId= 45033; age= 19671964972L; luminosity= 0.066480; radius= 346600000L; spectralClass= "K6 V"; temperature= 3957 } |> Some
      | 40173642 -> { StarData.id= 40173642; name= "Fricoure - Star"; solarSystemId= 30002734; typeId= 3799; age= 5158820589L; luminosity= 0.285100; radius= 319800000L; spectralClass= "G0 V"; temperature= 5929 } |> Some
      | 40184215 -> { StarData.id= 40184215; name= "VFK-IV - Star"; solarSystemId= 30002904; typeId= 45030; age= 13610033518L; luminosity= 0.311700; radius= 461300000L; spectralClass= "G9 V"; temperature= 5048 } |> Some
      | 40188095 -> { StarData.id= 40188095; name= "Odin - Star"; solarSystemId= 30002963; typeId= 45041; age= 4582097624L; luminosity= 0.041270; radius= 187700000L; spectralClass= "K1 V"; temperature= 4774 } |> Some
      | 40189841 -> { StarData.id= 40189841; name= "Uadelah - Star"; solarSystemId= 30002991; typeId= 45040; age= 46169542882L; luminosity= 0.014970; radius= 290500000L; spectralClass= "M2 V"; temperature= 2978 } |> Some
      | 40196631 -> { StarData.id= 40196631; name= "Furskeshin - Star"; solarSystemId= 30003095; typeId= 6; age= 12491444253L; luminosity= 0.329100; radius= 475200000L; spectralClass= "G9 V"; temperature= 5041 } |> Some
      | 40199735 -> { StarData.id= 40199735; name= "6-TYRX - Star"; solarSystemId= 30003145; typeId= 45035; age= 2747674215L; luminosity= 1.461000; radius= 496900000L; spectralClass= "F2 V"; temperature= 7157 } |> Some
      | 40209435 -> { StarData.id= 40209435; name= "KTHT-O - Star"; solarSystemId= 30003300; typeId= 45036; age= 5345780198L; luminosity= 1.434000; radius= 789200000L; spectralClass= "G3 V"; temperature= 5652 } |> Some
      | 40211569 -> { StarData.id= 40211569; name= "EN-VOD - Star"; solarSystemId= 30003337; typeId= 45031; age= 23598118405L; luminosity= 0.304300; radius= 917699968L; spectralClass= "K9 V"; temperature= 3558 } |> Some
      | 40221657 -> { StarData.id= 40221657; name= "Youl - Star"; solarSystemId= 30003493; typeId= 45033; age= 29945243222L; luminosity= 0.159800; radius= 554600000L; spectralClass= "K6 V"; temperature= 3896 } |> Some
      | 40239020 -> { StarData.id= 40239020; name= "G-B22J - Star"; solarSystemId= 30003772; typeId= 45032; age= 12672066534L; luminosity= 0.137400; radius= 554800000L; spectralClass= "K8 V"; temperature= 3751 } |> Some
      | 40241445 -> { StarData.id= 40241445; name= "Ivorider - Star"; solarSystemId= 30003813; typeId= 45038; age= 7525920601L; luminosity= 0.578400; radius= 481000000L; spectralClass= "G2 V"; temperature= 5769 } |> Some
      | 40251921 -> { StarData.id= 40251921; name= "NDII-Q - Star"; solarSystemId= 30003980; typeId= 45038; age= 6923847236L; luminosity= 0.250400; radius= 322600000L; spectralClass= "G2 V"; temperature= 5715 } |> Some
      | 40259778 -> { StarData.id= 40259778; name= "Ansasos - Star"; solarSystemId= 30004104; typeId= 6; age= 8311785184L; luminosity= 0.061730; radius= 189700000L; spectralClass= "G7 VI"; temperature= 5251 } |> Some
      | 40266568 -> { StarData.id= 40266568; name= "DK0-N8 - Star"; solarSystemId= 30004207; typeId= 45030; age= 2901361356L; luminosity= 0.382900; radius= 477200000L; spectralClass= "G7 V"; temperature= 5225 } |> Some
      | 40267829 -> { StarData.id= 40267829; name= "HB-5L3 - Star"; solarSystemId= 30004228; typeId= 45033; age= 15394073238L; luminosity= 0.026980; radius= 218800000L; spectralClass= "K6 V"; temperature= 3976 } |> Some
      | 40284222 -> { StarData.id= 40284222; name= "D4-2XN - Star"; solarSystemId= 30004491; typeId= 7; age= 35173777683L; luminosity= 0.059330; radius= 338700000L; spectralClass= "K7 V"; temperature= 3891 } |> Some
      | 40289363 -> { StarData.id= 40289363; name= "RE-C26 - Star"; solarSystemId= 30004577; typeId= 45040; age= 14890232538L; luminosity= 0.012240; radius= 298600000L; spectralClass= "M4 V"; temperature= 2793 } |> Some
      | 40298675 -> { StarData.id= 40298675; name= "YZ9-F6 - Star"; solarSystemId= 30004719; typeId= 45033; age= 27511598272L; luminosity= 0.068830; radius= 343300000L; spectralClass= "K6 V"; temperature= 4011 } |> Some
      | 40299257 -> { StarData.id= 40299257; name= "T-J6HT - Star"; solarSystemId= 30004729; typeId= 45038; age= 4525058951L; luminosity= 0.615100; radius= 504600000L; spectralClass= "G2 V"; temperature= 5720 } |> Some
      | 40303913 -> { StarData.id= 40303913; name= "LWX-93 - Star"; solarSystemId= 30004800; typeId= 45033; age= 16772504378L; luminosity= 0.025140; radius= 208600000L; spectralClass= "K6 V"; temperature= 4000 } |> Some
      | 40305368 -> { StarData.id= 40305368; name= "FE-6YQ - Star"; solarSystemId= 30004821; typeId= 45046; age= 4639136296L; luminosity= 2.566000; radius= 810600000L; spectralClass= "F6 V"; temperature= 6450 } |> Some
      | 40306241 -> { StarData.id= 40306241; name= "EQWO-Y - Star"; solarSystemId= 30004835; typeId= 45047; age= 5637310889L; luminosity= 0.172100; radius= 310900000L; spectralClass= "G6 V"; temperature= 5300 } |> Some
      | 40331364 -> { StarData.id= 40331364; name= "Petidu - Star"; solarSystemId= 30005241; typeId= 10; age= 2872208341L; luminosity= 1.372000; radius= 506100000L; spectralClass= "F3 V"; temperature= 6980 } |> Some
      | 40351152 -> { StarData.id= 40351152; name= "J205818 - Star"; solarSystemId= 31000015; typeId= 3797; age= 8289603720L; luminosity= 0.185000; radius= 303800000L; spectralClass= "G5 V"; temperature= 5459 } |> Some
      | 40352510 -> { StarData.id= 40352510; name= "J125713 - Star"; solarSystemId= 31000043; typeId= 10; age= 1424696463L; luminosity= 1.320000; radius= 512100000L; spectralClass= "F3 V"; temperature= 6873 } |> Some
      | 40356390 -> { StarData.id= 40356390; name= "J134939 - Star"; solarSystemId= 31000109; typeId= 3800; age= 5380637407L; luminosity= 0.013730; radius= 285000000L; spectralClass= "M3 V"; temperature= 2942 } |> Some
      | 40368418 -> { StarData.id= 40368418; name= "J212904 - Star"; solarSystemId= 31000341; typeId= 3797; age= 10355667322L; luminosity= 0.437000; radius= 474600000L; spectralClass= "G5 V"; temperature= 5415 } |> Some
      | 40371522 -> { StarData.id= 40371522; name= "J130256 - Star"; solarSystemId= 31000399; typeId= 9; age= 1877519252L; luminosity= 2.674000; radius= 811500032L; spectralClass= "F6 V"; temperature= 6513 } |> Some
      | 40381125 -> { StarData.id= 40381125; name= "J110538 - Star"; solarSystemId= 31000578; typeId= 6; age= 5912997443L; luminosity= 0.153400; radius= 298600000L; spectralClass= "G7 V"; temperature= 5255 } |> Some
      | 40404987 -> { StarData.id= 40404987; name= "J165118 - Star"; solarSystemId= 31001035; typeId= 45037; age= 13768473792L; luminosity= 0.082320; radius= 340000000L; spectralClass= "K4 V"; temperature= 4215 } |> Some
      | 40405860 -> { StarData.id= 40405860; name= "J113923 - Star"; solarSystemId= 31001053; typeId= 3800; age= 9737749277L; luminosity= 0.035330; radius= 474000000L; spectralClass= "M3 V"; temperature= 2890 } |> Some
      | 40408188 -> { StarData.id= 40408188; name= "J142951 - Star"; solarSystemId= 31001102; typeId= 3803; age= 362828589L; luminosity= 3.008000; radius= 839299968L; spectralClass= "F5 V"; temperature= 6596 } |> Some
      | 40408576 -> { StarData.id= 40408576; name= "J141451 - Star"; solarSystemId= 31001108; typeId= 3799; age= 3564909959L; luminosity= 0.036640; radius= 121000000L; spectralClass= "G2 VI"; temperature= 5772 } |> Some
      | 40409546 -> { StarData.id= 40409546; name= "J235630 - Star"; solarSystemId= 31001129; typeId= 45032; age= 21059903464L; luminosity= 0.303200; radius= 883299968L; spectralClass= "K9 V"; temperature= 3623 } |> Some
      | 40422253 -> { StarData.id= 40422253; name= "J131304 - Star"; solarSystemId= 31001369; typeId= 45039; age= 28677718858L; luminosity= 0.014320; radius= 314400000L; spectralClass= "M3 V"; temperature= 2831 } |> Some
      | 40422544 -> { StarData.id= 40422544; name= "J115909 - Star"; solarSystemId= 31001374; typeId= 3798; age= 4670824024L; luminosity= 0.205900; radius= 539200000L; spectralClass= "K4 V"; temperature= 4209 } |> Some
      | 40424193 -> { StarData.id= 40424193; name= "J141055 - Star"; solarSystemId= 31001405; typeId= 45036; age= 2821190430L; luminosity= 0.188900; radius= 315200000L; spectralClass= "G5 V"; temperature= 5388 } |> Some
      | 40426327 -> { StarData.id= 40426327; name= "J134716 - Star"; solarSystemId= 31001446; typeId= 45038; age= 6746393890L; luminosity= 0.651100; radius= 498500000L; spectralClass= "G1 V"; temperature= 5838 } |> Some
      | 40426812 -> { StarData.id= 40426812; name= "J234421 - Star"; solarSystemId= 31001454; typeId= 8; age= 23515729333L; luminosity= 0.028420; radius= 207200000L; spectralClass= "K5 V"; temperature= 4139 } |> Some
      | 40427879 -> { StarData.id= 40427879; name= "J155338 - Star"; solarSystemId= 31001475; typeId= 45032; age= 24548762223L; luminosity= 0.154400; radius= 555299968L; spectralClass= "K7 V"; temperature= 3860 } |> Some
      | 40428655 -> { StarData.id= 40428655; name= "J103008 - Star"; solarSystemId= 31001490; typeId= 45039; age= 40402312145L; luminosity= 0.012490; radius= 318100000L; spectralClass= "M4 V"; temperature= 2720 } |> Some
      | 40433311 -> { StarData.id= 40433311; name= "J133358 - Star"; solarSystemId= 31001585; typeId= 45033; age= 14392729710L; luminosity= 0.070550; radius= 331700000L; spectralClass= "K5 V"; temperature= 4106 } |> Some
      | 40435251 -> { StarData.id= 40435251; name= "J131113 - Star"; solarSystemId= 31001624; typeId= 45033; age= 5501052080L; luminosity= 0.456200; radius= 864099968L; spectralClass= "K5 V"; temperature= 4057 } |> Some
      | 40443108 -> { StarData.id= 40443108; name= "J173638 - Star"; solarSystemId= 31001782; typeId= 8; age= 22178491641L; luminosity= 0.011490; radius= 134500000L; spectralClass= "K5 V"; temperature= 4097 } |> Some
      | 40445824 -> { StarData.id= 40445824; name= "J114031 - Star"; solarSystemId= 31001834; typeId= 3798; age= 11388699123L; luminosity= 0.218400; radius= 518800000L; spectralClass= "K3 V"; temperature= 4355 } |> Some
      | 40447376 -> { StarData.id= 40447376; name= "J233449 - Star"; solarSystemId= 31001867; typeId= 3799; age= 3098461180L; luminosity= 0.714200; radius= 510700000L; spectralClass= "G0 V"; temperature= 5903 } |> Some
      | 40457173 -> { StarData.id= 40457173; name= "J170807 - Star"; solarSystemId= 31002256; typeId= 3801; age= 3371612477L; luminosity= 0.359900; radius= 328800000L; spectralClass= "F8 VI"; temperature= 6197 } |> Some
      | 40462120 -> { StarData.id= 40462120; name= "J144543 - Star"; solarSystemId= 31002202; typeId= 45031; age= 26034933924L; luminosity= 0.052960; radius= 360300000L; spectralClass= "K8 V"; temperature= 3667 } |> Some
      | 40468328 -> { StarData.id= 40468328; name= "J143245 - Star"; solarSystemId= 31002220; typeId= 45032; age= 32543666316L; luminosity= 0.139800; radius= 584800000L; spectralClass= "K8 V"; temperature= 3669 } |> Some
      | 40469007 -> { StarData.id= 40469007; name= "J161940 - Star"; solarSystemId= 31002240; typeId= 45036; age= 2821190430L; luminosity= 0.188900; radius= 315200000L; spectralClass= "G5 V"; temperature= 5388 } |> Some
      | 40473954 -> { StarData.id= 40473954; name= "J172139 - Star"; solarSystemId= 31002266; typeId= 3803; age= 2023284461L; luminosity= 0.480100; radius= 316400000L; spectralClass= "F4 VI"; temperature= 6790 } |> Some
      | _ -> None