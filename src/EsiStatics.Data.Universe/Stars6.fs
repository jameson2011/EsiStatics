﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stars6=
    let getStar id = 
      match id with 
      | 40000381 -> { StarData.id= 40000381; name= "Nirbhi - Star"; solarSystemId= 30000008; typeId= 45039; age= 54598575437L; luminosity= 0.039810; radius= 467000000L; spectralClass= "M2 V"; temperature= 2999 } |> Some
      | 40000769 -> { StarData.id= 40000769; name= "Onsooh - Star"; solarSystemId= 30000013; typeId= 45047; age= 1800517126L; luminosity= 0.984400; radius= 759200000L; spectralClass= "G7 V"; temperature= 5246 } |> Some
      | 40006395 -> { StarData.id= 40006395; name= "Kehrara - Star"; solarSystemId= 30000098; typeId= 45041; age= 16813698914L; luminosity= 0.094400; radius= 152800000L; spectralClass= "K2 V"; temperature= 4601 } |> Some
      | 40014640 -> { StarData.id= 40014640; name= "3HX-DL - Star"; solarSystemId= 30000228; typeId= 3797; age= 6369305735L; luminosity= 0.086120; radius= 194900000L; spectralClass= "G3 VI"; temperature= 5630 } |> Some
      | 40025213 -> { StarData.id= 40025213; name= "RB-2EA - Star"; solarSystemId= 30000406; typeId= 45047; age= 12684741190L; luminosity= 0.942300; radius= 735900032L; spectralClass= "G7 V"; temperature= 5270 } |> Some
      | 40028414 -> { StarData.id= 40028414; name= "4NDT-W - Star"; solarSystemId= 30000455; typeId= 3802; age= 3542728222L; luminosity= 0.115400; radius= 147000000L; spectralClass= "K0 V"; temperature= 4931 } |> Some
      | 40041024 -> { StarData.id= 40041024; name= "K85Y-6 - Star"; solarSystemId= 30000653; typeId= 6; age= 4816589097L; luminosity= 0.764800; radius= 710600000L; spectralClass= "G9 V"; temperature= 5090 } |> Some
      | 40045874 -> { StarData.id= 40045874; name= "Y5-E1U - Star"; solarSystemId= 30000729; typeId= 45032; age= 38817907235L; luminosity= 0.124400; radius= 566300032L; spectralClass= "K9 V"; temperature= 3621 } |> Some
      | 40046165 -> { StarData.id= 40046165; name= "3S-6VU - Star"; solarSystemId= 30000733; typeId= 45040; age= 40782567059L; luminosity= 0.029660; radius= 524400000L; spectralClass= "M5 V"; temperature= 2630 } |> Some
      | 40050627 -> { StarData.id= 40050627; name= "MOCW-2 - Star"; solarSystemId= 30000801; typeId= 45038; age= 5047912179L; luminosity= 0.016010; radius= 39025000L; spectralClass= "G1 VI"; temperature= 5843 } |> Some
      | 40069639 -> { StarData.id= 40069639; name= "Z0H2-4 - Star"; solarSystemId= 30001091; typeId= 45031; age= 33399245316L; luminosity= 0.024700; radius= 219200000L; spectralClass= "K7 V"; temperature= 3885 } |> Some
      | 40073810 -> { StarData.id= 40073810; name= "WD-VTV - Star"; solarSystemId= 30001160; typeId= 45032; age= 38279210959L; luminosity= 0.122100; radius= 580700032L; spectralClass= "K9 V"; temperature= 3559 } |> Some
      | 40086226 -> { StarData.id= 40086226; name= "2IBE-N - Star"; solarSystemId= 30001352; typeId= 45039; age= 53584555075L; luminosity= 0.012500; radius= 309000000L; spectralClass= "M4 V"; temperature= 2760 } |> Some
      | 40101843 -> { StarData.id= 40101843; name= "M-NP5O - Star"; solarSystemId= 30001597; typeId= 45033; age= 25759246825L; luminosity= 0.070610; radius= 320800000L; spectralClass= "K5 V"; temperature= 4176 } |> Some
      | 40118430 -> { StarData.id= 40118430; name= "JS-E8E - Star"; solarSystemId= 30001851; typeId= 10; age= 2021066179L; luminosity= 1.457000; radius= 514400000L; spectralClass= "F2 V"; temperature= 7029 } |> Some
      | 40124347 -> { StarData.id= 40124347; name= "OOO-FS - Star"; solarSystemId= 30001946; typeId= 45038; age= 7392830728L; luminosity= 0.721500; radius= 257450000L; spectralClass= "G0 V"; temperature= 5893 } |> Some
      | 40125705 -> { StarData.id= 40125705; name= "KI-TL0 - Star"; solarSystemId= 30001969; typeId= 45041; age= 7849139564L; luminosity= 0.119100; radius= 146950000L; spectralClass= "K0 V"; temperature= 4972 } |> Some
      | 40135211 -> { StarData.id= 40135211; name= "XD-JW7 - Star"; solarSystemId= 30002118; typeId= 3796; age= 1970682218L; luminosity= 1.786000; radius= 508500000L; spectralClass= "F0 V"; temperature= 7438 } |> Some
      | 40139770 -> { StarData.id= 40139770; name= "Kehour - Star"; solarSystemId= 30002193; typeId= 45034; age= 3926153978L; luminosity= 0.430200; radius= 321300000L; spectralClass= "F6 VI"; temperature= 6556 } |> Some
      | 40141322 -> { StarData.id= 40141322; name= "Hutian - Star"; solarSystemId= 30002217; typeId= 45047; age= 912933831L; luminosity= 0.022990; radius= 115600000L; spectralClass= "G7 VI"; temperature= 5256 } |> Some
      | 40144717 -> { StarData.id= 40144717; name= "Asoutar - Star"; solarSystemId= 30002272; typeId= 45037; age= 13435749109L; luminosity= 0.083730; radius= 324100000L; spectralClass= "K3 V"; temperature= 4336 } |> Some
      | 40151022 -> { StarData.id= 40151022; name= "M9-LAN - Star"; solarSystemId= 30002374; typeId= 3797; age= 2728661142L; luminosity= 0.209700; radius= 309300000L; spectralClass= "G3 V"; temperature= 5583 } |> Some
      | 40168288 -> { StarData.id= 40168288; name= "Iyen-Oursta - Star"; solarSystemId= 30002642; typeId= 3798; age= 23997388025L; luminosity= 0.013310; radius= 124400000L; spectralClass= "K3 V"; temperature= 4420 } |> Some
      | 40170519 -> { StarData.id= 40170519; name= "Jolia - Star"; solarSystemId= 30002679; typeId= 6; age= 9702892612L; luminosity= 0.322600; radius= 468500000L; spectralClass= "G9 V"; temperature= 5052 } |> Some
      | 40172459 -> { StarData.id= 40172459; name= "Alillere - Star"; solarSystemId= 30002712; typeId= 45035; age= 1387621380L; luminosity= 0.531100; radius= 319100000L; spectralClass= "F3 VI"; temperature= 6934 } |> Some
      | 40175854 -> { StarData.id= 40175854; name= "Tunudan - Star"; solarSystemId= 30002770; typeId= 45030; age= 7231221519L; luminosity= 0.407200; radius= 469400000L; spectralClass= "G6 V"; temperature= 5350 } |> Some
      | 40177115 -> { StarData.id= 40177115; name= "Sirppala - Star"; solarSystemId= 30002791; typeId= 45047; age= 8245240247L; luminosity= 0.420800; radius= 473300000L; spectralClass= "G6 V"; temperature= 5372 } |> Some
      | 40185457 -> { StarData.id= 40185457; name= "ZOYW-O - Star"; solarSystemId= 30002923; typeId= 45030; age= 5051081116L; luminosity= 0.022100; radius= 120700000L; spectralClass= "G8 VI"; temperature= 5093 } |> Some
      | 40196321 -> { StarData.id= 40196321; name= "Saidusairos - Star"; solarSystemId= 30003090; typeId= 45041; age= 6331280135L; luminosity= 0.101200; radius= 150000000L; spectralClass= "K1 V"; temperature= 4725 } |> Some
      | 40197485 -> { StarData.id= 40197485; name= "X-7BIX - Star"; solarSystemId= 30003110; typeId= 45037; age= 3463508086L; luminosity= 0.030730; radius= 206800000L; spectralClass= "K4 V"; temperature= 4225 } |> Some
      | 40205148 -> { StarData.id= 40205148; name= "GK3-RX - Star"; solarSystemId= 30003232; typeId= 3797; age= 4325423869L; luminosity= 1.234000; radius= 759400000L; spectralClass= "G4 V"; temperature= 5550 } |> Some
      | 40207282 -> { StarData.id= 40207282; name= "MHC-R3 - Star"; solarSystemId= 30003268; typeId= 3803; age= 4113113860L; luminosity= 1.123000; radius= 250450000L; spectralClass= "F5 V"; temperature= 6674 } |> Some
      | 40214363 -> { StarData.id= 40214363; name= "Flost - Star"; solarSystemId= 30003382; typeId= 45037; age= 4889471906L; luminosity= 0.033220; radius= 201200000L; spectralClass= "K3 V"; temperature= 4368 } |> Some
      | 40228913 -> { StarData.id= 40228913; name= "Toustain - Star"; solarSystemId= 30003606; typeId= 45047; age= 10514107595L; luminosity= 0.400700; radius= 474100000L; spectralClass= "G6 V"; temperature= 5302 } |> Some
      | 40231338 -> { StarData.id= 40231338; name= "Y-YHZQ - Star"; solarSystemId= 30003651; typeId= 3803; age= 492432891L; luminosity= 3.305000; radius= 418849984L; spectralClass= "F4 V"; temperature= 6759 } |> Some
      | 40236091 -> { StarData.id= 40236091; name= "D-6WS1 - Star"; solarSystemId= 30003727; typeId= 45037; age= 16107055012L; luminosity= 0.012470; radius= 128300000L; spectralClass= "K4 V"; temperature= 4281 } |> Some
      | 40244045 -> { StarData.id= 40244045; name= "Odamia - Star"; solarSystemId= 30003857; typeId= 45033; age= 2143065320L; luminosity= 0.010840; radius= 135000000L; spectralClass= "K6 V"; temperature= 4029 } |> Some
      | 40249768 -> { StarData.id= 40249768; name= "0-WT2D - Star"; solarSystemId= 30003947; typeId= 45039; age= 32163409225L; luminosity= 0.014150; radius= 313000000L; spectralClass= "M3 V"; temperature= 2829 } |> Some
      | 40253939 -> { StarData.id= 40253939; name= "N-M1A3 - Star"; solarSystemId= 30004011; typeId= 45037; age= 15397241630L; luminosity= 0.034480; radius= 196900000L; spectralClass= "K3 V"; temperature= 4456 } |> Some
      | 40258110 -> { StarData.id= 40258110; name= "U65-CN - Star"; solarSystemId= 30004074; typeId= 3798; age= 3141873863L; luminosity= 0.196000; radius= 521300000L; spectralClass= "K4 V"; temperature= 4228 } |> Some
      | 40261602 -> { StarData.id= 40261602; name= "Koona - Star"; solarSystemId= 30004128; typeId= 3801; age= 1236786064L; luminosity= 0.332300; radius= 154450000L; spectralClass= "F8 VI"; temperature= 6268 } |> Some
      | 40281390 -> { StarData.id= 40281390; name= "5ELE-A - Star"; solarSystemId= 30004445; typeId= 8; age= 5672167553L; luminosity= 0.074920; radius= 343200000L; spectralClass= "K5 V"; temperature= 4098 } |> Some
      | 40290605 -> { StarData.id= 40290605; name= "B32-14 - Star"; solarSystemId= 30004599; typeId= 45040; age= 13663903799L; luminosity= 0.040640; radius= 398500000L; spectralClass= "M1 V"; temperature= 3263 } |> Some
      | 40300111 -> { StarData.id= 40300111; name= "ZA9-PY - Star"; solarSystemId= 30004741; typeId= 45039; age= 50732627979L; luminosity= 0.016310; radius= 247900000L; spectralClass= "M1 V"; temperature= 3294 } |> Some
      | 40307289 -> { StarData.id= 40307289; name= "R-XDKM - Star"; solarSystemId= 30004853; typeId= 45038; age= 4369787342L; luminosity= 0.017820; radius= 39250000L; spectralClass= "G0 VI"; temperature= 5983 } |> Some
      | 40313206 -> { StarData.id= 40313206; name= "G-C8QO - Star"; solarSystemId= 30004945; typeId= 3799; age= 2122468188L; luminosity= 0.040310; radius= 61850000L; spectralClass= "G1 VI"; temperature= 5845 } |> Some
      | 40325816 -> { StarData.id= 40325816; name= "UYOC-1 - Star"; solarSystemId= 30005150; typeId= 3799; age= 3473014350L; luminosity= 0.681000; radius= 258000000L; spectralClass= "G1 V"; temperature= 5803 } |> Some
      | 40327853 -> { StarData.id= 40327853; name= "F-A3TR - Star"; solarSystemId= 30005184; typeId= 45047; age= 12158719570L; luminosity= 0.153400; radius= 300300000L; spectralClass= "G7 V"; temperature= 5240 } |> Some
      | 40333479 -> { StarData.id= 40333479; name= "Otakod - Star"; solarSystemId= 30005274; typeId= 45033; age= 27967905475L; luminosity= 0.165500; radius= 552099968L; spectralClass= "K6 V"; temperature= 3939 } |> Some
      | 40334740 -> { StarData.id= 40334740; name= "Doza - Star"; solarSystemId= 30005293; typeId= 3798; age= 2637716323L; luminosity= 0.034360; radius= 196700000L; spectralClass= "K3 V"; temperature= 4454 } |> Some
      | 40348902 -> { StarData.id= 40348902; name= "Okkamon - Star"; solarSystemId= 30045330; typeId= 3802; age= 17916445132L; luminosity= 0.097010; radius= 155300000L; spectralClass= "K2 V"; temperature= 4595 } |> Some
      | 40366362 -> { StarData.id= 40366362; name= "J142119 - Star"; solarSystemId= 31000298; typeId= 3800; age= 19824067373L; luminosity= 0.010360; radius= 354800000L; spectralClass= "M6 V"; temperature= 2458 } |> Some
      | 40367332 -> { StarData.id= 40367332; name= "J113632 - Star"; solarSystemId= 31000318; typeId= 8; age= 10720080277L; luminosity= 0.026980; radius= 213200000L; spectralClass= "K6 V"; temperature= 4027 } |> Some
      | 40369854 -> { StarData.id= 40369854; name= "J141857 - Star"; solarSystemId= 31000369; typeId= 7; age= 6793925755L; luminosity= 0.020700; radius= 244700000L; spectralClass= "K9 V"; temperature= 3518 } |> Some
      | 40369951 -> { StarData.id= 40369951; name= "J155737 - Star"; solarSystemId= 31000371; typeId= 45039; age= 75956344742L; luminosity= 0.010490; radius= 384300000L; spectralClass= "M6 V"; temperature= 2369 } |> Some
      | 40371018 -> { StarData.id= 40371018; name= "J132009 - Star"; solarSystemId= 31000391; typeId= 9; age= 2789819269L; luminosity= 2.370000; radius= 800700032L; spectralClass= "F7 V"; temperature= 6363 } |> Some
      | 40372861 -> { StarData.id= 40372861; name= "J120308 - Star"; solarSystemId= 31000425; typeId= 3801; age= 1891461945L; luminosity= 0.302900; radius= 155750000L; spectralClass= "F9 VI"; temperature= 6099 } |> Some
      | 40376450 -> { StarData.id= 40376450; name= "J170038 - Star"; solarSystemId= 31000492; typeId= 3799; age= 4493370951L; luminosity= 0.275800; radius= 158250000L; spectralClass= "G0 V"; temperature= 5911 } |> Some
      | 40377711 -> { StarData.id= 40377711; name= "J135703 - Star"; solarSystemId= 31000513; typeId= 45041; age= 14617714919L; luminosity= 0.014700; radius= 60350000L; spectralClass= "K2 V"; temperature= 4599 } |> Some
      | 40386053 -> { StarData.id= 40386053; name= "J104802 - Star"; solarSystemId= 31000676; typeId= 45041; age= 3520546486L; luminosity= 0.119200; radius= 154650000L; spectralClass= "K0 V"; temperature= 4847 } |> Some
      | 40391388 -> { StarData.id= 40391388; name= "J212906 - Star"; solarSystemId= 31000775; typeId= 3798; age= 3831089705L; luminosity= 0.080990; radius= 333500000L; spectralClass= "K4 V"; temperature= 4238 } |> Some
      | 40393813 -> { StarData.id= 40393813; name= "J150754 - Star"; solarSystemId= 31000818; typeId= 45033; age= 9601491012L; luminosity= 0.011680; radius= 134400000L; spectralClass= "K5 V"; temperature= 4115 } |> Some
      | 40397499 -> { StarData.id= 40397499; name= "J111218 - Star"; solarSystemId= 31000889; typeId= 3800; age= 40243870783L; luminosity= 0.020090; radius= 732700032L; spectralClass= "M9 V"; temperature= 2018 } |> Some
      | 40401573 -> { StarData.id= 40401573; name= "J132635 - Star"; solarSystemId= 31000969; typeId= 3800; age= 50796004524L; luminosity= 0.036470; radius= 412000000L; spectralClass= "M2 V"; temperature= 3124 } |> Some
      | 40407102 -> { StarData.id= 40407102; name= "J130835 - Star"; solarSystemId= 31001078; typeId= 9; age= 3612442095L; luminosity= 1.094000; radius= 531700000L; spectralClass= "F6 V"; temperature= 6436 } |> Some
      | 40409139 -> { StarData.id= 40409139; name= "J224826 - Star"; solarSystemId= 31001119; typeId= 45041; age= 17662940042L; luminosity= 0.039360; radius= 96450000L; spectralClass= "K2 V"; temperature= 4654 } |> Some
      | 40409430 -> { StarData.id= 40409430; name= "J113334 - Star"; solarSystemId= 31001126; typeId= 3802; age= 8520926802L; luminosity= 0.015870; radius= 60650000L; spectralClass= "K1 V"; temperature= 4676 } |> Some
      | 40419906 -> { StarData.id= 40419906; name= "J213534 - Star"; solarSystemId= 31001326; typeId= 3800; age= 63154361081L; luminosity= 0.011240; radius= 319100000L; spectralClass= "M5 V"; temperature= 2645 } |> Some
      | 40420585 -> { StarData.id= 40420585; name= "J133250 - Star"; solarSystemId= 31001341; typeId= 45039; age= 4620123224L; luminosity= 0.029650; radius= 572400000L; spectralClass= "M5 V"; temperature= 2517 } |> Some
      | 40421070 -> { StarData.id= 40421070; name= "J121700 - Star"; solarSystemId= 31001349; typeId= 3800; age= 11151038169L; luminosity= 0.045220; radius= 385800000L; spectralClass= "M0 V"; temperature= 3407 } |> Some
      | 40422331 -> { StarData.id= 40422331; name= "J145632 - Star"; solarSystemId= 31001370; typeId= 45031; age= 24795929441L; luminosity= 0.058810; radius= 360500000L; spectralClass= "K7 V"; temperature= 3763 } |> Some
      | 40423689 -> { StarData.id= 40423689; name= "J161752 - Star"; solarSystemId= 31001396; typeId= 6; age= 12744949343L; luminosity= 0.363000; radius= 481200000L; spectralClass= "G8 V"; temperature= 5134 } |> Some
      | 40425435 -> { StarData.id= 40425435; name= "J132754 - Star"; solarSystemId= 31001431; typeId= 45037; age= 2904530020L; luminosity= 0.086570; radius= 319300000L; spectralClass= "K3 V"; temperature= 4405 } |> Some
      | 40428248 -> { StarData.id= 40428248; name= "J151520 - Star"; solarSystemId= 31001482; typeId= 3798; age= 12782974399L; luminosity= 3.507000; radius= 1964999936L; spectralClass= "K3 IV"; temperature= 4479 } |> Some
      | 40437560 -> { StarData.id= 40437560; name= "J111458 - Star"; solarSystemId= 31001671; typeId= 10; age= 1637006609L; luminosity= 3.543000; radius= 822499968L; spectralClass= "F3 V"; temperature= 6941 } |> Some
      | 40440470 -> { StarData.id= 40440470; name= "J160032 - Star"; solarSystemId= 31001732; typeId= 45040; age= 30125865503L; luminosity= 0.041140; radius= 391400000L; spectralClass= "M1 V"; temperature= 3303 } |> Some
      | 40442410 -> { StarData.id= 40442410; name= "J110915 - Star"; solarSystemId= 31001766; typeId= 45030; age= 6176634310L; luminosity= 0.210763; radius= 378119840L; spectralClass= "G9 V"; temperature= 5051 } |> Some
      | 40448327 -> { StarData.id= 40448327; name= "J134242 - Star"; solarSystemId= 31001885; typeId= 45032; age= 43317615786L; luminosity= 0.814600; radius= 1483000064L; spectralClass= "K9 IV"; temperature= 3579 } |> Some
      | 40448618 -> { StarData.id= 40448618; name= "J164147 - Star"; solarSystemId= 31001891; typeId= 45040; age= 60334117902L; luminosity= 0.038670; radius= 464400000L; spectralClass= "M2 V"; temperature= 2986 } |> Some
      | 40451625 -> { StarData.id= 40451625; name= "J104216 - Star"; solarSystemId= 31001949; typeId= 45037; age= 19288539488L; luminosity= 0.031400; radius= 209900000L; spectralClass= "K4 V"; temperature= 4215 } |> Some
      | 40452013 -> { StarData.id= 40452013; name= "J121146 - Star"; solarSystemId= 31001958; typeId= 45030; age= 14155068755L; luminosity= 0.322400; radius= 471600000L; spectralClass= "G9 V"; temperature= 5035 } |> Some
      | 40454147 -> { StarData.id= 40454147; name= "J173645 - Star"; solarSystemId= 31001994; typeId= 45042; age= 666717334L; luminosity= 1.235000; radius= 256750000L; spectralClass= "F4 V"; temperature= 6750 } |> Some
      | 40458318 -> { StarData.id= 40458318; name= "J140336 - Star"; solarSystemId= 31002033; typeId= 3800; age= 44395012693L; luminosity= 0.017040; radius= 268500000L; spectralClass= "M1 V"; temperature= 3200 } |> Some
      | 40470637 -> { StarData.id= 40470637; name= "J205141 - Star"; solarSystemId= 31002446; typeId= 45034; age= 4734200569L; luminosity= 2.676000; radius= 819900032L; spectralClass= "F6 V"; temperature= 6481 } |> Some
      | 40474905 -> { StarData.id= 40474905; name= "J101755 - Star"; solarSystemId= 31002461; typeId= 6; age= 5314092470L; luminosity= 0.356300; radius= 479300000L; spectralClass= "G8 V"; temperature= 5121 } |> Some
      | 40481016 -> { StarData.id= 40481016; name= "J102053 - Star"; solarSystemId= 31002247; typeId= 3802; age= 15229295093L; luminosity= 0.046530; radius= 91350000L; spectralClass= "K0 V"; temperature= 4986 } |> Some
      | 40483538 -> { StarData.id= 40483538; name= "J123235 - Star"; solarSystemId= 31002150; typeId= 45047; age= 4300073469L; luminosity= 0.048320; radius= 180700000L; spectralClass= "G9 VI"; temperature= 5061 } |> Some
      | 40488291 -> { StarData.id= 40488291; name= "J000522 - Star"; solarSystemId= 31002591; typeId= 34331; age= 466371031L; luminosity= 29.178547; radius= 1204759040L; spectralClass= "A0IV"; temperature= 9022 } |> Some
      | 40488388 -> { StarData.id= 40488388; name= "J000102 - Star"; solarSystemId= 31002604; typeId= 34331; age= 510352133L; luminosity= 28.963400; radius= 1296050688L; spectralClass= "A0IV"; temperature= 9450 } |> Some
      | 40488485 -> { StarData.id= 40488485; name= "J200727 - Star"; solarSystemId= 31000004; typeId= 34331; age= 482510979L; luminosity= 29.580046; radius= 1270598784L; spectralClass= "A0IV2"; temperature= 10291 } |> Some
      | _ -> None