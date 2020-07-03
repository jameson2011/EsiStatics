﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stars2=
    let getStar id = 
      match id with 
      | 40011144 -> { StarData.id= 40011144; name= "Keikaken - Star"; solarSystemId= 30000176; typeId= 8; age= 27891855364L; luminosity= 0.025350; radius= 211800000L; spectralClass= "K6 V"; temperature= 3978 } |> Some
      | 40012114 -> { StarData.id= 40012114; name= "Otanuomi - Star"; solarSystemId= 30000192; typeId= 3796; age= 1436104170L; luminosity= 4.135000; radius= 808300032L; spectralClass= "F1 V"; temperature= 7278 } |> Some
      | 40013375 -> { StarData.id= 40013375; name= "B-588R - Star"; solarSystemId= 30000211; typeId= 45032; age= 8213552519L; luminosity= 0.056260; radius= 371700000L; spectralClass= "K8 V"; temperature= 3665 } |> Some
      | 40030544 -> { StarData.id= 40030544; name= "J-L9MA - Star"; solarSystemId= 30000489; typeId= 45032; age= 11959084760L; luminosity= 0.062430; radius= 353400000L; spectralClass= "K7 V"; temperature= 3858 } |> Some
      | 40040341 -> { StarData.id= 40040341; name= "U93O-A - Star"; solarSystemId= 30000644; typeId= 45033; age= 15831369002L; luminosity= 0.071420; radius= 337800000L; spectralClass= "K5 V"; temperature= 4082 } |> Some
      | 40046258 -> { StarData.id= 40046258; name= "OX-S7P - Star"; solarSystemId= 30000735; typeId= 3797; age= 2854779737L; luminosity= 1.285000; radius= 772700032L; spectralClass= "G4 V"; temperature= 5558 } |> Some
      | 40047907 -> { StarData.id= 40047907; name= "M4-GJ6 - Star"; solarSystemId= 30000761; typeId= 45036; age= 7446700464L; luminosity= 3.293000; radius= 1240000000L; spectralClass= "G4 IV"; temperature= 5550 } |> Some
      | 40054697 -> { StarData.id= 40054697; name= "AW1-2I - Star"; solarSystemId= 30000860; typeId= 45038; age= 3126029727L; luminosity= 1.635000; radius= 396950016L; spectralClass= "G1 V"; temperature= 5823 } |> Some
      | 40055861 -> { StarData.id= 40055861; name= "9GI-FB - Star"; solarSystemId= 30000875; typeId= 45033; age= 20556061675L; luminosity= 0.027380; radius= 218500000L; spectralClass= "K6 V"; temperature= 3993 } |> Some
      | 40056443 -> { StarData.id= 40056443; name= "Y-PZHM - Star"; solarSystemId= 30000884; typeId= 45040; age= 50067178613L; luminosity= 0.010850; radius= 376000000L; spectralClass= "M6 V"; temperature= 2415 } |> Some
      | 40064882 -> { StarData.id= 40064882; name= "VOL-MI - Star"; solarSystemId= 30001019; typeId= 3799; age= 3615610759L; luminosity= 0.236300; radius= 156900000L; spectralClass= "G2 V"; temperature= 5711 } |> Some
      | 40067016 -> { StarData.id= 40067016; name= "8AB-Q4 - Star"; solarSystemId= 30001053; typeId= 6; age= 10304966522L; luminosity= 0.337900; radius= 468100000L; spectralClass= "G8 V"; temperature= 5113 } |> Some
      | 40070411 -> { StarData.id= 40070411; name= "PWPY-4 - Star"; solarSystemId= 30001106; typeId= 45036; age= 4898978170L; luminosity= 1.427000; radius= 799500032L; spectralClass= "G3 V"; temperature= 5609 } |> Some
      | 40076619 -> { StarData.id= 40076619; name= "UQ-PWD - Star"; solarSystemId= 30001208; typeId= 45041; age= 9826476222L; luminosity= 0.272100; radius= 246200000L; spectralClass= "K1 V"; temperature= 4723 } |> Some
      | 40090587 -> { StarData.id= 40090587; name= "Oipo - Star"; solarSystemId= 30001425; typeId= 7; age= 15638070976L; luminosity= 2.366000; radius= 2284000000L; spectralClass= "K7 IV"; temperature= 3765 } |> Some
      | 40099899 -> { StarData.id= 40099899; name= "QFU-4S - Star"; solarSystemId= 30001564; typeId= 45042; age= 681927656L; luminosity= 0.484400; radius= 160950000L; spectralClass= "F4 VI"; temperature= 6747 } |> Some
      | 40101160 -> { StarData.id= 40101160; name= "LH-LY1 - Star"; solarSystemId= 30001587; typeId= 3796; age= 2578142937L; luminosity= 0.654700; radius= 318900000L; spectralClass= "F1 VI"; temperature= 7308 } |> Some
      | 40106689 -> { StarData.id= 40106689; name= "Hilaban - Star"; solarSystemId= 30001674; typeId= 45039; age= 18997008253L; luminosity= 0.022890; radius= 691800000L; spectralClass= "M8 V"; temperature= 2146 } |> Some
      | 40107465 -> { StarData.id= 40107465; name= "Mimime - Star"; solarSystemId= 30001691; typeId= 3801; age= 2981532282L; luminosity= 0.849200; radius= 256550000L; spectralClass= "F8 V"; temperature= 6149 } |> Some
      | 40113576 -> { StarData.id= 40113576; name= "FVQF-W - Star"; solarSystemId= 30001775; typeId= 3797; age= 2459946139L; luminosity= 0.179400; radius= 307100000L; spectralClass= "G5 V"; temperature= 5389 } |> Some
      | 40114061 -> { StarData.id= 40114061; name= "QOK-SX - Star"; solarSystemId= 30001783; typeId= 45038; age= 2862384966L; luminosity= 0.298700; radius= 160100000L; spectralClass= "G0 V"; temperature= 5994 } |> Some
      | 40117359 -> { StarData.id= 40117359; name= "VTGN-U - Star"; solarSystemId= 30001836; typeId= 7; age= 11895708216L; luminosity= 0.023050; radius= 214600000L; spectralClass= "K7 V"; temperature= 3859 } |> Some
      | 40122694 -> { StarData.id= 40122694; name= "Z-R96X - Star"; solarSystemId= 30001919; typeId= 45030; age= 5903490635L; luminosity= 0.051930; radius= 188400000L; spectralClass= "G9 VI"; temperature= 5046 } |> Some
      | 40126283 -> { StarData.id= 40126283; name= "X-7OMU - Star"; solarSystemId= 30001978; typeId= 45032; age= 17675615786L; luminosity= 2.315000; radius= 2136000000L; spectralClass= "K7 IV"; temperature= 3873 } |> Some
      | 40136177 -> { StarData.id= 40136177; name= "R-ZUOL - Star"; solarSystemId= 30002135; typeId= 3796; age= 330189867L; luminosity= 4.692000; radius= 819800000L; spectralClass= "F0 V"; temperature= 7459 } |> Some
      | 40143549 -> { StarData.id= 40143549; name= "Jerma - Star"; solarSystemId= 30002254; typeId= 9; age= 3748700904L; luminosity= 2.674000; radius= 830600000L; spectralClass= "F6 V"; temperature= 6438 } |> Some
      | 40145392 -> { StarData.id= 40145392; name= "9F-3CR - Star"; solarSystemId= 30002284; typeId= 3802; age= 18505842209L; luminosity= 0.240300; radius= 251150000L; spectralClass= "K2 V"; temperature= 4533 } |> Some
      | 40151406 -> { StarData.id= 40151406; name= "RK-Q51 - Star"; solarSystemId= 30002380; typeId= 3797; age= 3273379540L; luminosity= 0.087040; radius= 196000000L; spectralClass= "G3 VI"; temperature= 5629 } |> Some
      | 40154801 -> { StarData.id= 40154801; name= "L-HV5C - Star"; solarSystemId= 30002434; typeId= 45036; age= 7649504210L; luminosity= 1.135000; radius= 757500032L; spectralClass= "G5 V"; temperature= 5441 } |> Some
      | 40158778 -> { StarData.id= 40158778; name= "BE-UUN - Star"; solarSystemId= 30002498; typeId= 45030; age= 8929703230L; luminosity= 0.315700; radius= 472600000L; spectralClass= "G9 V"; temperature= 5003 } |> Some
      | 40159360 -> { StarData.id= 40159360; name= "Abudban - Star"; solarSystemId= 30002507; typeId= 3803; age= 1698798414L; luminosity= 1.218000; radius= 252700000L; spectralClass= "F4 V"; temperature= 6780 } |> Some
      | 40175656 -> { StarData.id= 40175656; name= "Kubinen - Star"; solarSystemId= 30002767; typeId= 3799; age= 6702030418L; luminosity= 0.238400; radius= 155500000L; spectralClass= "G2 V"; temperature= 5749 } |> Some
      | 40177208 -> { StarData.id= 40177208; name= "Inari - Star"; solarSystemId= 30002793; typeId= 3802; age= 9639516068L; luminosity= 0.242900; radius= 241100000L; spectralClass= "K2 V"; temperature= 4639 } |> Some
      | 40178857 -> { StarData.id= 40178857; name= "N-JK02 - Star"; solarSystemId= 30002820; typeId= 45034; age= 5009886579L; luminosity= 0.367200; radius= 314900000L; spectralClass= "F7 VI"; temperature= 6365 } |> Some
      | 40182737 -> { StarData.id= 40182737; name= "BZ-BCK - Star"; solarSystemId= 30002882; typeId= 45040; age= 29194234214L; luminosity= 0.024520; radius= 637500032L; spectralClass= "M7 V"; temperature= 2274 } |> Some
      | 40197093 -> { StarData.id= 40197093; name= "HT4K-M - Star"; solarSystemId= 30003103; typeId= 45038; age= 7636829010L; luminosity= 0.624800; radius= 256400000L; spectralClass= "G2 V"; temperature= 5697 } |> Some
      | 40197966 -> { StarData.id= 40197966; name= "NH-R5B - Star"; solarSystemId= 30003117; typeId= 3802; age= 7205871118L; luminosity= 0.043240; radius= 99600000L; spectralClass= "K1 V"; temperature= 4689 } |> Some
      | 40203398 -> { StarData.id= 40203398; name= "J-D5U7 - Star"; solarSystemId= 30003206; typeId= 3797; age= 8441706665L; luminosity= 0.090100; radius= 198500000L; spectralClass= "G3 VI"; temperature= 5642 } |> Some
      | 40208927 -> { StarData.id= 40208927; name= "QWF-6P - Star"; solarSystemId= 30003292; typeId= 45037; age= 13768473792L; luminosity= 0.082320; radius= 340000000L; spectralClass= "K4 V"; temperature= 4215 } |> Some
      | 40221343 -> { StarData.id= 40221343; name= "Chaven - Star"; solarSystemId= 30003489; typeId= 45036; age= 2864286273L; luminosity= 0.088230; radius= 197800000L; spectralClass= "G3 VI"; temperature= 5623 } |> Some
      | 40223089 -> { StarData.id= 40223089; name= "Pedel - Star"; solarSystemId= 30003516; typeId= 45038; age= 1298260893L; luminosity= 0.244800; radius= 158300000L; spectralClass= "G2 V"; temperature= 5736 } |> Some
      | 40232498 -> { StarData.id= 40232498; name= "C-XNUA - Star"; solarSystemId= 30003670; typeId= 3802; age= 10156032513L; luminosity= 0.093950; radius= 151050000L; spectralClass= "K2 V"; temperature= 4622 } |> Some
      | 40233662 -> { StarData.id= 40233662; name= "L-C3O7 - Star"; solarSystemId= 30003689; typeId= 45040; age= 59066595716L; luminosity= 0.011240; radius= 337400000L; spectralClass= "M5 V"; temperature= 2572 } |> Some
      | 40237833 -> { StarData.id= 40237833; name= "YQB-22 - Star"; solarSystemId= 30003753; typeId= 45033; age= 28408370720L; luminosity= 0.011290; radius= 128800000L; spectralClass= "K5 V"; temperature= 4168 } |> Some
      | 40256166 -> { StarData.id= 40256166; name= "F7C-H0 - Star"; solarSystemId= 30004046; typeId= 8; age= 30030800686L; luminosity= 0.067810; radius= 356900000L; spectralClass= "K6 V"; temperature= 3920 } |> Some
      | 40261792 -> { StarData.id= 40261792; name= "Yooh - Star"; solarSystemId= 30004131; typeId= 45031; age= 17624914986L; luminosity= 0.129700; radius= 601100032L; spectralClass= "K9 V"; temperature= 3551 } |> Some
      | 40263732 -> { StarData.id= 40263732; name= "Zorrabed - Star"; solarSystemId= 30004160; typeId= 3802; age= 1291923293L; luminosity= 0.115400; radius= 144950000L; spectralClass= "K0 V"; temperature= 4967 } |> Some
      | 40270522 -> { StarData.id= 40270522; name= "Afrah - Star"; solarSystemId= 30004271; typeId= 45039; age= 4724693761L; luminosity= 0.015630; radius= 285800000L; spectralClass= "M2 V"; temperature= 3035 } |> Some
      | 40275469 -> { StarData.id= 40275469; name= "YG-82V - Star"; solarSystemId= 30004350; typeId= 45039; age= 30110021367L; luminosity= 0.024600; radius= 612899968L; spectralClass= "M7 V"; temperature= 2321 } |> Some
      | 40279155 -> { StarData.id= 40279155; name= "5-IZGE - Star"; solarSystemId= 30004412; typeId= 6; age= 7633660618L; luminosity= 0.388000; radius= 487300000L; spectralClass= "G7 V"; temperature= 5188 } |> Some
      | 40292153 -> { StarData.id= 40292153; name= "D-Q04X - Star"; solarSystemId= 30004622; typeId= 45038; age= 8080462646L; luminosity= 0.242300; radius= 154850000L; spectralClass= "G2 V"; temperature= 5784 } |> Some
      | 40301368 -> { StarData.id= 40301368; name= "1DQ1-A - Star"; solarSystemId= 30004759; typeId= 3802; age= 12028798089L; luminosity= 0.243100; radius= 255500000L; spectralClass= "K2 V"; temperature= 4507 } |> Some
      | 40302338 -> { StarData.id= 40302338; name= "5-CQDA - Star"; solarSystemId= 30004774; typeId= 45047; age= 5773569698L; luminosity= 0.391200; radius= 484100000L; spectralClass= "G7 V"; temperature= 5215 } |> Some
      | 40311359 -> { StarData.id= 40311359; name= "MMUF-8 - Star"; solarSystemId= 30004913; typeId= 45046; age= 933847938L; luminosity= 0.429400; radius= 320900000L; spectralClass= "F6 VI"; temperature= 6557 } |> Some
      | 40316791 -> { StarData.id= 40316791; name= "Arnon - Star"; solarSystemId= 30005001; typeId= 45037; age= 8416356265L; luminosity= 0.080930; radius= 336800000L; spectralClass= "K4 V"; temperature= 4217 } |> Some
      | 40319410 -> { StarData.id= 40319410; name= "Masanuh - Star"; solarSystemId= 30005041; typeId= 3798; age= 6841458163L; luminosity= 0.032720; radius= 211900000L; spectralClass= "K4 V"; temperature= 4239 } |> Some
      | 40319604 -> { StarData.id= 40319604; name= "Jinkah - Star"; solarSystemId= 30005046; typeId= 3801; age= 4917991243L; luminosity= 0.876900; radius= 257200000L; spectralClass= "F8 V"; temperature= 6191 } |> Some
      | 40319895 -> { StarData.id= 40319895; name= "Soumi - Star"; solarSystemId= 30005052; typeId= 6; age= 5025730715L; luminosity= 0.057590; radius= 185800000L; spectralClass= "G7 VI"; temperature= 5214 } |> Some
      | 40331729 -> { StarData.id= 40331729; name= "Imya - Star"; solarSystemId= 30005246; typeId= 45033; age= 11772124606L; luminosity= 0.165800; radius= 532500000L; spectralClass= "K6 V"; temperature= 4012 } |> Some
      | 40335124 -> { StarData.id= 40335124; name= "Loes - Star"; solarSystemId= 30005300; typeId= 45039; age= 23059422130L; luminosity= 0.015850; radius= 280700000L; spectralClass= "M2 V"; temperature= 3073 } |> Some
      | 40337258 -> { StarData.id= 40337258; name= "Tierijev - Star"; solarSystemId= 30005334; typeId= 3797; age= 2520153747L; luminosity= 0.176000; radius= 298500000L; spectralClass= "G5 V"; temperature= 5440 } |> Some
      | 40372857 -> { StarData.id= 40372857; name= "J152801 - Star"; solarSystemId= 31000424; typeId= 45038; age= 2400055641L; luminosity= 0.014570; radius= 38185000L; spectralClass= "G2 VI"; temperature= 5769 } |> Some
      | 40389444 -> { StarData.id= 40389444; name= "J150533 - Star"; solarSystemId= 31000738; typeId= 3800; age= 16484143712L; luminosity= 0.011030; radius= 344900000L; spectralClass= "M5 V"; temperature= 2532 } |> Some
      | 40393033 -> { StarData.id= 40393033; name= "J232359 - Star"; solarSystemId= 31000803; typeId= 45039; age= 24922680353L; luminosity= 0.028640; radius= 538800000L; spectralClass= "M5 V"; temperature= 2572 } |> Some
      | 40403024 -> { StarData.id= 40403024; name= "J144646 - Star"; solarSystemId= 31000999; typeId= 3802; age= 9639516068L; luminosity= 0.267800; radius= 251300000L; spectralClass= "K1 V"; temperature= 4656 } |> Some
      | 40403121 -> { StarData.id= 40403121; name= "J142520 - Star"; solarSystemId= 31001000; typeId= 9; age= 4062412787L; luminosity= 0.387500; radius= 319900000L; spectralClass= "F7 VI"; temperature= 6400 } |> Some
      | 40416022 -> { StarData.id= 40416022; name= "J153546 - Star"; solarSystemId= 31001246; typeId= 45031; age= 35680787864L; luminosity= 0.050790; radius= 375800000L; spectralClass= "K9 V"; temperature= 3553 } |> Some
      | 40421357 -> { StarData.id= 40421357; name= "J135723 - Star"; solarSystemId= 31001354; typeId= 45036; age= 8441706665L; luminosity= 0.090100; radius= 198500000L; spectralClass= "G3 VI"; temperature= 5642 } |> Some
      | 40424267 -> { StarData.id= 40424267; name= "J121845 - Star"; solarSystemId= 31001407; typeId= 3801; age= 1105914269L; luminosity= 12.020000; radius= 977500032L; spectralClass= "F9 IV"; temperature= 6111 } |> Some
      | 40432512 -> { StarData.id= 40432512; name= "J140912 - Star"; solarSystemId= 31001569; typeId= 8; age= 3469845686L; luminosity= 1.017000; radius= 1398000000L; spectralClass= "K6 IV"; temperature= 3898 } |> Some
      | 40433870 -> { StarData.id= 40433870; name= "J102409 - Star"; solarSystemId= 31001598; typeId= 10; age= 631543559L; luminosity= 1.319000; radius= 493600000L; spectralClass= "F3 V"; temperature= 7000 } |> Some
      | 40434161 -> { StarData.id= 40434161; name= "J124930 - Star"; solarSystemId= 31001603; typeId= 45041; age= 18090729542L; luminosity= 0.039180; radius= 100650000L; spectralClass= "K2 V"; temperature= 4550 } |> Some
      | 40435616 -> { StarData.id= 40435616; name= "J145535 - Star"; solarSystemId= 31001629; typeId= 45046; age= 4274723069L; luminosity= 0.424200; radius= 322100000L; spectralClass= "F6 VI"; temperature= 6525 } |> Some
      | 40439205 -> { StarData.id= 40439205; name= "J150805 - Star"; solarSystemId= 31001704; typeId= 45037; age= 5066925252L; luminosity= 0.012050; radius= 126900000L; spectralClass= "K4 V"; temperature= 4268 } |> Some
      | 40444249 -> { StarData.id= 40444249; name= "J125316 - Star"; solarSystemId= 31001805; typeId= 45039; age= 57450502533L; luminosity= 0.016860; radius= 275600000L; spectralClass= "M1 V"; temperature= 3150 } |> Some
      | 40452397 -> { StarData.id= 40452397; name= "J131401 - Star"; solarSystemId= 31001965; typeId= 45039; age= 10517275987L; luminosity= 0.012940; radius= 309300000L; spectralClass= "M4 V"; temperature= 2783 } |> Some
      | 40456568 -> { StarData.id= 40456568; name= "J143127 - Star"; solarSystemId= 31002196; typeId= 3803; age= 1378431820L; luminosity= 1.207000; radius= 247850000L; spectralClass= "F4 V"; temperature= 6831 } |> Some
      | 40459575 -> { StarData.id= 40459575; name= "J124504 - Star"; solarSystemId= 31002411; typeId= 45041; age= 1436104170L; luminosity= 0.095320; radius= 151850000L; spectralClass= "K2 V"; temperature= 4627 } |> Some
      | 40464813 -> { StarData.id= 40464813; name= "J141615 - Star"; solarSystemId= 31002111; typeId= 45041; age= 14861712657L; luminosity= 0.036540; radius= 96800000L; spectralClass= "K2 V"; temperature= 4559 } |> Some
      | 40477714 -> { StarData.id= 40477714; name= "J142349 - Star"; solarSystemId= 31002172; typeId= 45030; age= 8967728830L; luminosity= 0.343600; radius= 463900000L; spectralClass= "G8 V"; temperature= 5158 } |> Some
      | 40478781 -> { StarData.id= 40478781; name= "J105722 - Star"; solarSystemId= 31002330; typeId= 3796; age= 3002763229L; luminosity= 1.718000; radius= 522600000L; spectralClass= "F1 V"; temperature= 7267 } |> Some
      | 40479169 -> { StarData.id= 40479169; name= "J170809 - Star"; solarSystemId= 31002035; typeId= 45041; age= 6290085599L; luminosity= 0.257700; radius= 238500000L; spectralClass= "K1 V"; temperature= 4734 } |> Some
      | 40481400 -> { StarData.id= 40481400; name= "J104218 - Star"; solarSystemId= 31002164; typeId= 7; age= 28962913310L; luminosity= 0.057050; radius= 373100000L; spectralClass= "K8 V"; temperature= 3671 } |> Some
      | 40487705 -> { StarData.id= 40487705; name= "J002216 - Star"; solarSystemId= 31002514; typeId= 34331; age= 497352234L; luminosity= 32.364861; radius= 1278092288L; spectralClass= "A0IV"; temperature= 8812 } |> Some
      | _ -> None