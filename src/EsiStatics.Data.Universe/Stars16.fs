﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stars16=
    let getStar id = 
      match id with 
      | 40009800 -> { StarData.id= 40009800; name= "Liekuri - Star"; solarSystemId= 30000154; typeId= 3800; age= 47342004607L; luminosity= 0.015300; radius= 281900000L; spectralClass= "M2 V"; temperature= 3039 } |> Some
      | 40013486 -> { StarData.id= 40013486; name= "NCGR-Q - Star"; solarSystemId= 30000212; typeId= 3797; age= 5171495789L; luminosity= 0.537900; radius= 479500000L; spectralClass= "G3 V"; temperature= 5675 } |> Some
      | 40014844 -> { StarData.id= 40014844; name= "MY-T2P - Star"; solarSystemId= 30000232; typeId= 45030; age= 5912997443L; luminosity= 0.153400; radius= 298600000L; spectralClass= "G7 V"; temperature= 5255 } |> Some
      | 40020567 -> { StarData.id= 40020567; name= "D95-FQ - Star"; solarSystemId= 30000327; typeId= 45033; age= 16934114132L; luminosity= 0.028700; radius= 213400000L; spectralClass= "K5 V"; temperature= 4088 } |> Some
      | 40039676 -> { StarData.id= 40039676; name= "C-6YHJ - Star"; solarSystemId= 30000632; typeId= 8; age= 24203361795L; luminosity= 0.069490; radius= 336900000L; spectralClass= "K5 V"; temperature= 4059 } |> Some
      | 40040452 -> { StarData.id= 40040452; name= "4YO-QK - Star"; solarSystemId= 30000646; typeId= 3802; age= 13987122218L; luminosity= 0.103300; radius= 298900000L; spectralClass= "K1 V"; temperature= 4757 } |> Some
      | 40042780 -> { StarData.id= 40042780; name= "XV-MWG - Star"; solarSystemId= 30000678; typeId= 45030; age= 1588206980L; luminosity= 0.132400; radius= 289700000L; spectralClass= "G8 V"; temperature= 5143 } |> Some
      | 40062665 -> { StarData.id= 40062665; name= "OJOS-T - Star"; solarSystemId= 30000983; typeId= 45036; age= 3938829450L; luminosity= 7.226000; radius= 1928000000L; spectralClass= "G5 IV"; temperature= 5418 } |> Some
      | 40069067 -> { StarData.id= 40069067; name= "NIM-FY - Star"; solarSystemId= 30001082; typeId= 45047; age= 10466575187L; luminosity= 0.146300; radius= 295100000L; spectralClass= "G7 V"; temperature= 5224 } |> Some
      | 40079252 -> { StarData.id= 40079252; name= "Q-U96U - Star"; solarSystemId= 30001248; typeId= 45040; age= 44616826245L; luminosity= 0.014560; radius= 264200000L; spectralClass= "M2 V"; temperature= 3101 } |> Some
      | 40084199 -> { StarData.id= 40084199; name= "Q61Y-F - Star"; solarSystemId= 30001323; typeId= 45038; age= 5932009971L; luminosity= 0.246800; radius= 321400000L; spectralClass= "G2 V"; temperature= 5705 } |> Some
      | 40089534 -> { StarData.id= 40089534; name= "Todaki - Star"; solarSystemId= 30001407; typeId= 3798; age= 17133748941L; luminosity= 0.030860; radius= 208600000L; spectralClass= "K4 V"; temperature= 4210 } |> Some
      | 40104860 -> { StarData.id= 40104860; name= "Anjedin - Star"; solarSystemId= 30001647; typeId= 3796; age= 655309627L; luminosity= 4.020000; radius= 812700032L; spectralClass= "F1 V"; temperature= 7207 } |> Some
      | 40112232 -> { StarData.id= 40112232; name= "1-10QG - Star"; solarSystemId= 30001757; typeId= 3796; age= 2156691310L; luminosity= 4.314000; radius= 819400000L; spectralClass= "F1 V"; temperature= 7305 } |> Some
      | 40113493 -> { StarData.id= 40113493; name= "2ID-87 - Star"; solarSystemId= 30001774; typeId= 45041; age= 7494232873L; luminosity= 0.269300; radius= 487600000L; spectralClass= "K1 V"; temperature= 4734 } |> Some
      | 40117761 -> { StarData.id= 40117761; name= "32-GI9 - Star"; solarSystemId= 30001841; typeId= 45041; age= 5485207943L; luminosity= 0.120100; radius= 313300000L; spectralClass= "K0 V"; temperature= 4826 } |> Some
      | 40123096 -> { StarData.id= 40123096; name= "CJF-1P - Star"; solarSystemId= 30001926; typeId= 45039; age= 56531546989L; luminosity= 0.014330; radius= 300100000L; spectralClass= "M3 V"; temperature= 2898 } |> Some
      | 40134736 -> { StarData.id= 40134736; name= "JDAS-0 - Star"; solarSystemId= 30002112; typeId= 45031; age= 43539433693L; luminosity= 0.021940; radius= 235800000L; spectralClass= "K8 V"; temperature= 3637 } |> Some
      | 40135027 -> { StarData.id= 40135027; name= "O7-7UX - Star"; solarSystemId= 30002116; typeId= 45030; age= 2110743505L; luminosity= 1.039000; radius= 759100032L; spectralClass= "G6 V"; temperature= 5318 } |> Some
      | 40148607 -> { StarData.id= 40148607; name= "B-2VXB - Star"; solarSystemId= 30002334; typeId= 3800; age= 53394429796L; luminosity= 0.012260; radius= 303600000L; spectralClass= "M4 V"; temperature= 2771 } |> Some
      | 40148704 -> { StarData.id= 40148704; name= "JAWX-R - Star"; solarSystemId= 30002336; typeId= 3801; age= 6049255708L; luminosity= 0.136900; radius= 205200000L; spectralClass= "F8 VI"; temperature= 6161 } |> Some
      | 40152972 -> { StarData.id= 40152972; name= "Hedaleolfarber - Star"; solarSystemId= 30002406; typeId= 7; age= 19437473498L; luminosity= 0.141100; radius= 589800000L; spectralClass= "K8 V"; temperature= 3661 } |> Some
      | 40154136 -> { StarData.id= 40154136; name= "FDZ4-A - Star"; solarSystemId= 30002423; typeId= 3800; age= 55422466165L; luminosity= 0.015870; radius= 250300000L; spectralClass= "M1 V"; temperature= 3255 } |> Some
      | 40158598 -> { StarData.id= 40158598; name= "4K0N-J - Star"; solarSystemId= 30002495; typeId= 8; age= 32892235135L; luminosity= 0.064150; radius= 341200000L; spectralClass= "K6 V"; temperature= 3953 } |> Some
      | 40159180 -> { StarData.id= 40159180; name= "UER-TH - Star"; solarSystemId= 30002503; typeId= 8; age= 8872664557L; luminosity= 0.029590; radius= 218700000L; spectralClass= "K5 V"; temperature= 4070 } |> Some
      | 40177610 -> { StarData.id= 40177610; name= "Haatomo - Star"; solarSystemId= 30002800; typeId= 45032; age= 27856998700L; luminosity= 0.023620; radius= 224700000L; spectralClass= "K7 V"; temperature= 3795 } |> Some
      | 40181102 -> { StarData.id= 40181102; name= "B3ZU-H - Star"; solarSystemId= 30002860; typeId= 8; age= 2500506997L; luminosity= 0.073200; radius= 331200000L; spectralClass= "K5 V"; temperature= 4147 } |> Some
      | 40185370 -> { StarData.id= 40185370; name= "E-FIC0 - Star"; solarSystemId= 30002922; typeId= 10; age= 1457968931L; luminosity= 3.656000; radius= 810200000L; spectralClass= "F2 V"; temperature= 7049 } |> Some
      | 40205643 -> { StarData.id= 40205643; name= "U-RELP - Star"; solarSystemId= 30003240; typeId= 6; age= 6017567980L; luminosity= 5.268000; radius= 1812000000L; spectralClass= "G8 IV"; temperature= 5165 } |> Some
      | 40236004 -> { StarData.id= 40236004; name= "Shintaht - Star"; solarSystemId= 30003725; typeId= 45034; age= 523170339L; luminosity= 0.145400; radius= 199500000L; spectralClass= "F7 VI"; temperature= 6344 } |> Some
      | 40239108 -> { StarData.id= 40239108; name= "X6AB-Y - Star"; solarSystemId= 30003773; typeId= 3799; age= 2168732695L; luminosity= 0.681100; radius= 518600000L; spectralClass= "G1 V"; temperature= 5788 } |> Some
      | 40241533 -> { StarData.id= 40241533; name= "Mollin - Star"; solarSystemId= 30003814; typeId= 45037; age= 23347782795L; luminosity= 0.033330; radius= 199600000L; spectralClass= "K3 V"; temperature= 4388 } |> Some
      | 40246383 -> { StarData.id= 40246383; name= "Moro - Star"; solarSystemId= 30003893; typeId= 9; age= 498770491L; luminosity= 0.377300; radius= 319700000L; spectralClass= "F7 VI"; temperature= 6361 } |> Some
      | 40251621 -> { StarData.id= 40251621; name= "Q2-N6W - Star"; solarSystemId= 30003975; typeId= 6; age= 7719218083L; luminosity= 0.049390; radius= 180600000L; spectralClass= "G9 VI"; temperature= 5090 } |> Some
      | 40254434 -> { StarData.id= 40254434; name= "L-FVHR - Star"; solarSystemId= 30004018; typeId= 3798; age= 19519862571L; luminosity= 0.083350; radius= 320600000L; spectralClass= "K3 V"; temperature= 4355 } |> Some
      | 40270439 -> { StarData.id= 40270439; name= "Rashagh - Star"; solarSystemId= 30004269; typeId= 45047; age= 6749562827L; luminosity= 0.019170; radius= 113000000L; spectralClass= "G9 VI"; temperature= 5079 } |> Some
      | 40273931 -> { StarData.id= 40273931; name= "HB7R-F - Star"; solarSystemId= 30004325; typeId= 45037; age= 7833295428L; luminosity= 0.088450; radius= 311100000L; spectralClass= "K3 V"; temperature= 4486 } |> Some
      | 40274222 -> { StarData.id= 40274222; name= "X4UV-Z - Star"; solarSystemId= 30004331; typeId= 3802; age= 16284507814L; luminosity= 0.243400; radius= 503000000L; spectralClass= "K2 V"; temperature= 4544 } |> Some
      | 40281691 -> { StarData.id= 40281691; name= "AZN-D2 - Star"; solarSystemId= 30004450; typeId= 45042; age= 4198671596L; luminosity= 2.832000; radius= 804700032L; spectralClass= "F5 V"; temperature= 6635 } |> Some
      | 40288869 -> { StarData.id= 40288869; name= "Y-1W01 - Star"; solarSystemId= 30004568; typeId= 6; age= 9870839150L; luminosity= 0.317700; radius= 461500000L; spectralClass= "G9 V"; temperature= 5071 } |> Some
      | 40295271 -> { StarData.id= 40295271; name= "9T-APQ - Star"; solarSystemId= 30004672; typeId= 3800; age= 34349886956L; luminosity= 0.013320; radius= 304000000L; spectralClass= "M3 V"; temperature= 2827 } |> Some
      | 40297017 -> { StarData.id= 40297017; name= "G-M4GK - Star"; solarSystemId= 30004696; typeId= 6; age= 3219509804L; luminosity= 0.170400; radius= 300700000L; spectralClass= "G6 V"; temperature= 5376 } |> Some
      | 40299151 -> { StarData.id= 40299151; name= "R5-MM8 - Star"; solarSystemId= 30004727; typeId= 45036; age= 5127132861L; luminosity= 0.175800; radius= 295200000L; spectralClass= "G5 V"; temperature= 5468 } |> Some
      | 40302061 -> { StarData.id= 40302061; name= "PS-94K - Star"; solarSystemId= 30004770; typeId= 45037; age= 15691941257L; luminosity= 0.014450; radius= 132600000L; spectralClass= "K3 V"; temperature= 4369 } |> Some
      | 40303419 -> { StarData.id= 40303419; name= "C6Y-ZF - Star"; solarSystemId= 30004791; typeId= 3800; age= 17688290442L; luminosity= 0.012150; radius= 319100000L; spectralClass= "M4 V"; temperature= 2697 } |> Some
      | 40304486 -> { StarData.id= 40304486; name= "6-IAFR - Star"; solarSystemId= 30004810; typeId= 8; age= 20803228893L; luminosity= 0.074980; radius= 341200000L; spectralClass= "K5 V"; temperature= 4111 } |> Some
      | 40329609 -> { StarData.id= 40329609; name= "Hesarid - Star"; solarSystemId= 30005213; typeId= 45041; age= 2376289709L; luminosity= 0.037110; radius= 191500000L; spectralClass= "K2 V"; temperature= 4602 } |> Some
      | 40332228 -> { StarData.id= 40332228; name= "Chiga - Star"; solarSystemId= 30005253; typeId= 3802; age= 5675336489L; luminosity= 0.292700; radius= 472600000L; spectralClass= "K0 V"; temperature= 4909 } |> Some
      | 40335526 -> { StarData.id= 40335526; name= "Vaere - Star"; solarSystemId= 30005306; typeId= 3801; age= 7148832446L; luminosity= 0.326500; radius= 332900000L; spectralClass= "F9 VI"; temperature= 6012 } |> Some
      | 40342801 -> { StarData.id= 40342801; name= "Urhinichi - Star"; solarSystemId= 30040141; typeId= 3796; age= 448279351L; luminosity= 2.004931; radius= 469860192L; spectralClass= "F1 V"; temperature= 7410 } |> Some
      | 40349009 -> { StarData.id= 40349009; name= "Asakai - Star"; solarSystemId= 30045332; typeId= 45032; age= 43095797879L; luminosity= 0.138500; radius= 560000000L; spectralClass= "K8 V"; temperature= 3741 } |> Some
      | 40349591 -> { StarData.id= 40349591; name= "Aivonen - Star"; solarSystemId= 30045340; typeId= 45042; age= 326704194L; luminosity= 0.029190; radius= 80620000L; spectralClass= "F5 VI"; temperature= 6679 } |> Some
      | 40378303 -> { StarData.id= 40378303; name= "J140642 - Star"; solarSystemId= 31000526; typeId= 45031; age= 10159200904L; luminosity= 0.023240; radius= 214500000L; spectralClass= "K7 V"; temperature= 3868 } |> Some
      | 40388973 -> { StarData.id= 40388973; name= "J113039 - Star"; solarSystemId= 31000730; typeId= 3800; age= 43127486152L; luminosity= 0.018110; radius= 256000000L; spectralClass= "M0 V"; temperature= 3327 } |> Some
      | 40389749 -> { StarData.id= 40389749; name= "J161138 - Star"; solarSystemId= 31000744; typeId= 45038; age= 7579790338L; luminosity= 0.575600; radius= 492000000L; spectralClass= "G2 V"; temperature= 5698 } |> Some
      | 40395666 -> { StarData.id= 40395666; name= "J171142 - Star"; solarSystemId= 31000855; typeId= 3802; age= 16747153978L; luminosity= 0.092110; radius= 304600000L; spectralClass= "K2 V"; temperature= 4580 } |> Some
      | 40397218 -> { StarData.id= 40397218; name= "J102057 - Star"; solarSystemId= 31000885; typeId= 3797; age= 1595178394L; luminosity= 0.204600; radius= 310900000L; spectralClass= "G4 V"; temperature= 5535 } |> Some
      | 40402747 -> { StarData.id= 40402747; name= "J115253 - Star"; solarSystemId= 31000994; typeId= 45030; age= 813116358L; luminosity= 0.840300; radius= 741100032L; spectralClass= "G8 V"; temperature= 5103 } |> Some
      | 40405366 -> { StarData.id= 40405366; name= "J152636 - Star"; solarSystemId= 31001043; typeId= 3798; age= 12282303179L; luminosity= 0.033480; radius= 201700000L; spectralClass= "K3 V"; temperature= 4370 } |> Some
      | 40409440 -> { StarData.id= 40409440; name= "J125403 - Star"; solarSystemId= 31001127; typeId= 45030; age= 7624153810L; luminosity= 0.964300; radius= 757000000L; spectralClass= "G7 V"; temperature= 5226 } |> Some
      | 40409731 -> { StarData.id= 40409731; name= "J143918 - Star"; solarSystemId= 31001134; typeId= 45031; age= 4867290442L; luminosity= 0.061250; radius= 347600000L; spectralClass= "K7 V"; temperature= 3872 } |> Some
      | 40427094 -> { StarData.id= 40427094; name= "J162226 - Star"; solarSystemId= 31001460; typeId= 8; age= 10720080277L; luminosity= 0.026980; radius= 213200000L; spectralClass= "K6 V"; temperature= 4027 } |> Some
      | 40428064 -> { StarData.id= 40428064; name= "J152443 - Star"; solarSystemId= 31001478; typeId= 3801; age= 3152964867L; luminosity= 0.329100; radius= 334400000L; spectralClass= "F9 VI"; temperature= 6010 } |> Some
      | 40429131 -> { StarData.id= 40429131; name= "J121347 - Star"; solarSystemId= 31001501; typeId= 6; age= 6711537226L; luminosity= 0.130400; radius= 299600000L; spectralClass= "G9 V"; temperature= 5038 } |> Some
      | 40433496 -> { StarData.id= 40433496; name= "J154724 - Star"; solarSystemId= 31001590; typeId= 7; age= 36884935683L; luminosity= 0.049140; radius= 370900000L; spectralClass= "K9 V"; temperature= 3547 } |> Some
      | 40436406 -> { StarData.id= 40436406; name= "J104624 - Star"; solarSystemId= 31001645; typeId= 10; age= 3282885804L; luminosity= 0.217000; radius= 206300000L; spectralClass= "F3 VI"; temperature= 6895 } |> Some
      | 40437958 -> { StarData.id= 40437958; name= "J114530 - Star"; solarSystemId= 31001679; typeId= 45030; age= 5402818871L; luminosity= 0.859500; radius= 746000000L; spectralClass= "G8 V"; temperature= 5115 } |> Some
      | 40440965 -> { StarData.id= 40440965; name= "J105835 - Star"; solarSystemId= 31001740; typeId= 45038; age= 5583441152L; luminosity= 0.740500; radius= 504200000L; spectralClass= "G0 V"; temperature= 5995 } |> Some
      | 40443196 -> { StarData.id= 40443196; name= "J133931 - Star"; solarSystemId= 31001785; typeId= 45031; age= 31688087316L; luminosity= 0.380700; radius= 915600000L; spectralClass= "K7 V"; temperature= 3767 } |> Some
      | 40445233 -> { StarData.id= 40445233; name= "J115031 - Star"; solarSystemId= 31001824; typeId= 45030; age= 2926711756L; luminosity= 0.020130; radius= 117700000L; spectralClass= "G9 VI"; temperature= 5038 } |> Some
      | 40448046 -> { StarData.id= 40448046; name= "J165611 - Star"; solarSystemId= 31001879; typeId= 3800; age= 22951681568L; luminosity= 0.017830; radius= 245500000L; spectralClass= "M0 V"; temperature= 3384 } |> Some
      | 40457067 -> { StarData.id= 40457067; name= "J115905 - Star"; solarSystemId= 31002299; typeId= 7; age= 10878520551L; luminosity= 0.057560; radius= 347900000L; spectralClass= "K7 V"; temperature= 3811 } |> Some
      | 40469580 -> { StarData.id= 40469580; name= "J114003 - Star"; solarSystemId= 31002386; typeId= 8; age= 15954952611L; luminosity= 0.403600; radius= 862899968L; spectralClass= "K6 V"; temperature= 3937 } |> Some
      | 40475788 -> { StarData.id= 40475788; name= "J104632 - Star"; solarSystemId= 31002421; typeId= 45034; age= 4417319478L; luminosity= 0.064080; radius= 128900000L; spectralClass= "F6 VI"; temperature= 6431 } |> Some
      | 40483160 -> { StarData.id= 40483160; name= "J100858 - Star"; solarSystemId= 31002024; typeId= 3799; age= 3685324632L; luminosity= 0.041300; radius= 123800000L; spectralClass= "G1 VI"; temperature= 5879 } |> Some
      | 40488107 -> { StarData.id= 40488107; name= "J005223 - Star"; solarSystemId= 31002567; typeId= 34331; age= 511621667L; luminosity= 29.217297; radius= 1117568384L; spectralClass= "A0IV"; temperature= 9332 } |> Some
      | 40488495 -> { StarData.id= 40488495; name= "J174618 - Star"; solarSystemId= 31000006; typeId= 34331; age= 472040826L; luminosity= 29.021719; radius= 1312761984L; spectralClass= "A0IV2"; temperature= 9859 } |> Some
      | _ -> None