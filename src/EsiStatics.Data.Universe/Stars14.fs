﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stars14=
    let getStar id = 
      match id with 
      | 40000001 -> { StarData.id= 40000001; name= "Tanoo - Star"; solarSystemId= 30000001; typeId= 45041; age= 14262808228L; luminosity= 0.015750; radius= 63350000L; spectralClass= "K2 V"; temperature= 4567 } |> Some
      | 40004754 -> { StarData.id= 40004754; name= "Tidacha - Star"; solarSystemId= 30000076; typeId= 3798; age= 20695490509L; luminosity= 0.198900; radius= 519500000L; spectralClass= "K4 V"; temperature= 4251 } |> Some
      | 40013678 -> { StarData.id= 40013678; name= "HE-V4V - Star"; solarSystemId= 30000214; typeId= 45040; age= 63724745630L; luminosity= 0.012640; radius= 326700000L; spectralClass= "M4 V"; temperature= 2692 } |> Some
      | 40023766 -> { StarData.id= 40023766; name= "JB-007 - Star"; solarSystemId= 30000381; typeId= 45039; age= 52697292158L; luminosity= 0.012340; radius= 312700000L; spectralClass= "M4 V"; temperature= 2735 } |> Some
      | 40029004 -> { StarData.id= 40029004; name= "GC-LTF - Star"; solarSystemId= 30000464; typeId= 3796; age= 1030813518L; luminosity= 0.110100; radius= 128600000L; spectralClass= "F0 VI"; temperature= 7372 } |> Some
      | 40032011 -> { StarData.id= 40032011; name= "O5Q7-U - Star"; solarSystemId= 30000512; typeId= 3801; age= 4185996396L; luminosity= 0.833000; radius= 254400000L; spectralClass= "F8 V"; temperature= 6145 } |> Some
      | 40033563 -> { StarData.id= 40033563; name= "MLQ-O9 - Star"; solarSystemId= 30000539; typeId= 3800; age= 20898293710L; luminosity= 0.015390; radius= 278200000L; spectralClass= "M2 V"; temperature= 3064 } |> Some
      | 40041711 -> { StarData.id= 40041711; name= "DE-A7P - Star"; solarSystemId= 30000663; typeId= 45037; age= 21154968281L; luminosity= 0.035290; radius= 204900000L; spectralClass= "K3 V"; temperature= 4393 } |> Some
      | 40046076 -> { StarData.id= 40046076; name= "V-F6DQ - Star"; solarSystemId= 30000732; typeId= 3800; age= 45662534879L; luminosity= 0.013910; radius= 313600000L; spectralClass= "M3 V"; temperature= 2814 } |> Some
      | 40049277 -> { StarData.id= 40049277; name= "3U-48K - Star"; solarSystemId= 30000782; typeId= 45041; age= 1686123213L; luminosity= 0.105200; radius= 148000000L; spectralClass= "K1 V"; temperature= 4802 } |> Some
      | 40063536 -> { StarData.id= 40063536; name= "N-RAEL - Star"; solarSystemId= 30000999; typeId= 3797; age= 4933835379L; luminosity= 0.033470; radius= 121800000L; spectralClass= "G3 VI"; temperature= 5623 } |> Some
      | 40070035 -> { StarData.id= 40070035; name= "CLW-SI - Star"; solarSystemId= 30001100; typeId= 45038; age= 5688011689L; luminosity= 0.262000; radius= 155850000L; spectralClass= "G1 V"; temperature= 5880 } |> Some
      | 40079444 -> { StarData.id= 40079444; name= "4NBN-9 - Star"; solarSystemId= 30001251; typeId= 45040; age= 74055057108L; luminosity= 0.021770; radius= 639000000L; spectralClass= "M8 V"; temperature= 2205 } |> Some
      | 40091084 -> { StarData.id= 40091084; name= "Uesuro - Star"; solarSystemId= 30001432; typeId= 3802; age= 3184652867L; luminosity= 0.229700; radius= 235400000L; spectralClass= "K2 V"; temperature= 4630 } |> Some
      | 40096613 -> { StarData.id= 40096613; name= "G5J-LH - Star"; solarSystemId= 30001517; typeId= 45032; age= 14215275820L; luminosity= 0.053010; radius= 366700000L; spectralClass= "K8 V"; temperature= 3636 } |> Some
      | 40097486 -> { StarData.id= 40097486; name= "5LAJ-8 - Star"; solarSystemId= 30001532; typeId= 3802; age= 13423074453L; luminosity= 0.111800; radius= 148250000L; spectralClass= "K0 V"; temperature= 4872 } |> Some
      | 40104470 -> { StarData.id= 40104470; name= "50-TJY - Star"; solarSystemId= 30001641; typeId= 8; age= 28135854190L; luminosity= 0.074840; radius= 329900000L; spectralClass= "K5 V"; temperature= 4178 } |> Some
      | 40104761 -> { StarData.id= 40104761; name= "Goram - Star"; solarSystemId= 30001646; typeId= 45046; age= 2150670549L; luminosity= 1.026000; radius= 505900000L; spectralClass= "F6 V"; temperature= 6493 } |> Some
      | 40107962 -> { StarData.id= 40107962; name= "Gaknem - Star"; solarSystemId= 30001698; typeId= 3798; age= 15318022038L; luminosity= 0.221000; radius= 491900000L; spectralClass= "K3 V"; temperature= 4486 } |> Some
      | 40111260 -> { StarData.id= 40111260; name= "HLR-GL - Star"; solarSystemId= 30001744; typeId= 7; age= 16255989022L; luminosity= 0.054900; radius= 364000000L; spectralClass= "K8 V"; temperature= 3681 } |> Some
      | 40121639 -> { StarData.id= 40121639; name= "0-7XA8 - Star"; solarSystemId= 30001904; typeId= 45036; age= 4176489860L; luminosity= 0.188200; radius= 306800000L; spectralClass= "G5 V"; temperature= 5456 } |> Some
      | 40127653 -> { StarData.id= 40127653; name= "Q-5211 - Star"; solarSystemId= 30002001; typeId= 45031; age= 21294394938L; luminosity= 0.021930; radius= 226300000L; spectralClass= "K8 V"; temperature= 3712 } |> Some
      | 40138226 -> { StarData.id= 40138226; name= "6-I162 - Star"; solarSystemId= 30002167; typeId= 3797; age= 10323979050L; luminosity= 0.029960; radius= 123500000L; spectralClass= "G5 VI"; temperature= 5433 } |> Some
      | 40139002 -> { StarData.id= 40139002; name= "M-ZJWJ - Star"; solarSystemId= 30002181; typeId= 3802; age= 15086698956L; luminosity= 0.015910; radius= 57950000L; spectralClass= "K1 V"; temperature= 4787 } |> Some
      | 40151224 -> { StarData.id= 40151224; name= "M-V0PQ - Star"; solarSystemId= 30002377; typeId= 3797; age= 5798920098L; luminosity= 0.069890; radius= 191700000L; spectralClass= "G5 VI"; temperature= 5388 } |> Some
      | 40158305 -> { StarData.id= 40158305; name= "Atioth - Star"; solarSystemId= 30002489; typeId= 45042; age= 1844880462L; luminosity= 7.002000; radius= 628499968L; spectralClass= "F5 V"; temperature= 6658 } |> Some
      | 40158402 -> { StarData.id= 40158402; name= "N-HK93 - Star"; solarSystemId= 30002492; typeId= 3800; age= 58527899440L; luminosity= 0.013100; radius= 328200000L; spectralClass= "M4 V"; temperature= 2710 } |> Some
      | 40159760 -> { StarData.id= 40159760; name= "Alakgur - Star"; solarSystemId= 30002512; typeId= 45040; age= 3647299031L; luminosity= 0.015460; radius= 294400000L; spectralClass= "M2 V"; temperature= 2982 } |> Some
      | 40165483 -> { StarData.id= 40165483; name= "HOHF-B - Star"; solarSystemId= 30002596; typeId= 45036; age= 7256571919L; luminosity= 0.468300; radius= 481800000L; spectralClass= "G5 V"; temperature= 5468 } |> Some
      | 40166744 -> { StarData.id= 40166744; name= "442-CS - Star"; solarSystemId= 30002616; typeId= 45032; age= 18258676079L; luminosity= 0.061180; radius= 349700000L; spectralClass= "K7 V"; temperature= 3859 } |> Some
      | 40167617 -> { StarData.id= 40167617; name= "FR-B1H - Star"; solarSystemId= 30002630; typeId= 45040; age= 49306664431L; luminosity= 0.015540; radius= 289300000L; spectralClass= "M2 V"; temperature= 3012 } |> Some
      | 40176153 -> { StarData.id= 40176153; name= "Isutaka - Star"; solarSystemId= 30002777; typeId= 45037; age= 12998453345L; luminosity= 0.013190; radius= 122800000L; spectralClass= "K3 V"; temperature= 4437 } |> Some
      | 40181779 -> { StarData.id= 40181779; name= "PNFW-O - Star"; solarSystemId= 30002870; typeId= 45039; age= 52919105710L; luminosity= 0.084310; radius= 763400000L; spectralClass= "M3 V"; temperature= 2830 } |> Some
      | 40184592 -> { StarData.id= 40184592; name= "2O9G-D - Star"; solarSystemId= 30002909; typeId= 3797; age= 7551271546L; luminosity= 0.226700; radius= 317600000L; spectralClass= "G3 V"; temperature= 5619 } |> Some
      | 40191964 -> { StarData.id= 40191964; name= "Lirsautton - Star"; solarSystemId= 30003025; typeId= 3802; age= 12874869736L; luminosity= 0.111900; radius= 149000000L; spectralClass= "K0 V"; temperature= 4861 } |> Some
      | 40200791 -> { StarData.id= 40200791; name= "P9F-ZG - Star"; solarSystemId= 30003163; typeId= 45041; age= 20685983156L; luminosity= 0.235600; radius= 252650000L; spectralClass= "K2 V"; temperature= 4497 } |> Some
      | 40206708 -> { StarData.id= 40206708; name= "X-CYNC - Star"; solarSystemId= 30003259; typeId= 3800; age= 57006871075L; luminosity= 0.026190; radius= 571500032L; spectralClass= "M6 V"; temperature= 2442 } |> Some
      | 40208163 -> { StarData.id= 40208163; name= "EZA-FM - Star"; solarSystemId= 30003281; typeId= 6; age= 6581615745L; luminosity= 0.853700; radius= 742499968L; spectralClass= "G8 V"; temperature= 5118 } |> Some
      | 40209327 -> { StarData.id= 40209327; name= "T-LIWS - Star"; solarSystemId= 30003299; typeId= 3800; age= 82452405745L; luminosity= 0.019150; radius= 689500032L; spectralClass= "M9 V"; temperature= 2056 } |> Some
      | 40211461 -> { StarData.id= 40211461; name= "A-SJ8X - Star"; solarSystemId= 30003335; typeId= 45041; age= 5760894498L; luminosity= 0.116300; radius= 143900000L; spectralClass= "K0 V"; temperature= 4995 } |> Some
      | 40216699 -> { StarData.id= 40216699; name= "Urnhard - Star"; solarSystemId= 30003417; typeId= 45037; age= 6372474671L; luminosity= 0.031400; radius= 209800000L; spectralClass= "K4 V"; temperature= 4217 } |> Some
      | 40222616 -> { StarData.id= 40222616; name= "Sayartchen - Star"; solarSystemId= 30003508; typeId= 8; age= 10054629823L; luminosity= 0.175600; radius= 531300000L; spectralClass= "K5 V"; temperature= 4075 } |> Some
      | 40229503 -> { StarData.id= 40229503; name= "1QH-0K - Star"; solarSystemId= 30003617; typeId= 45031; age= 5016224451L; luminosity= 0.052190; radius= 380100000L; spectralClass= "K9 V"; temperature= 3557 } |> Some
      | 40229988 -> { StarData.id= 40229988; name= "NV-3KA - Star"; solarSystemId= 30003627; typeId= 3801; age= 3992699187L; luminosity= 0.348900; radius= 161450000L; spectralClass= "F8 VI"; temperature= 6205 } |> Some
      | 40232413 -> { StarData.id= 40232413; name= "Q1U-IU - Star"; solarSystemId= 30003669; typeId= 45031; age= 28693562994L; luminosity= 0.143900; radius= 570099968L; spectralClass= "K8 V"; temperature= 3743 } |> Some
      | 40234159 -> { StarData.id= 40234159; name= "WQY-IQ - Star"; solarSystemId= 30003696; typeId= 45041; age= 14548001591L; luminosity= 0.036460; radius= 93700000L; spectralClass= "K2 V"; temperature= 4632 } |> Some
      | 40235808 -> { StarData.id= 40235808; name= "OXIY-V - Star"; solarSystemId= 30003722; typeId= 3802; age= 7858645828L; luminosity= 0.239300; radius= 251450000L; spectralClass= "K2 V"; temperature= 4526 } |> Some
      | 40240852 -> { StarData.id= 40240852; name= "Gare - Star"; solarSystemId= 30003805; typeId= 45039; age= 11658047261L; luminosity= 0.012680; radius= 328000000L; spectralClass= "M4 V"; temperature= 2688 } |> Some
      | 40244247 -> { StarData.id= 40244247; name= "Ipref - Star"; solarSystemId= 30003861; typeId= 45037; age= 3669480496L; luminosity= 0.081420; radius= 336600000L; spectralClass= "K4 V"; temperature= 4225 } |> Some
      | 40244441 -> { StarData.id= 40244441; name= "Jachanu - Star"; solarSystemId= 30003864; typeId= 45040; age= 25898673481L; luminosity= 0.016380; radius= 260100000L; spectralClass= "M1 V"; temperature= 3218 } |> Some
      | 40252104 -> { StarData.id= 40252104; name= "W6V-VM - Star"; solarSystemId= 30003983; typeId= 3800; age= 16484143712L; luminosity= 0.011030; radius= 344900000L; spectralClass= "M5 V"; temperature= 2532 } |> Some
      | 40265975 -> { StarData.id= 40265975; name= "FV1-RQ - Star"; solarSystemId= 30004197; typeId= 45042; age= 2685248460L; luminosity= 1.099000; radius= 247250000L; spectralClass= "F5 V"; temperature= 6681 } |> Some
      | 40278391 -> { StarData.id= 40278391; name= "QYZM-W - Star"; solarSystemId= 30004402; typeId= 45030; age= 6115801189L; luminosity= 0.423800; radius= 481600000L; spectralClass= "G6 V"; temperature= 5335 } |> Some
      | 40285666 -> { StarData.id= 40285666; name= "RTX0-S - Star"; solarSystemId= 30004516; typeId= 8; age= 25889168306L; luminosity= 0.025410; radius= 207800000L; spectralClass= "K6 V"; temperature= 4019 } |> Some
      | 40286636 -> { StarData.id= 40286636; name= "NP6-38 - Star"; solarSystemId= 30004533; typeId= 10; age= 322584740L; luminosity= 0.219100; radius= 205800000L; spectralClass= "F3 VI"; temperature= 6920 } |> Some
      | 40301865 -> { StarData.id= 40301865; name= "HZAQ-W - Star"; solarSystemId= 30004767; typeId= 7; age= 35585723047L; luminosity= 0.050890; radius= 363400000L; spectralClass= "K9 V"; temperature= 3615 } |> Some
      | 40325145 -> { StarData.id= 40325145; name= "9WVY-F - Star"; solarSystemId= 30005137; typeId= 45037; age= 4572590815L; luminosity= 0.034800; radius= 198300000L; spectralClass= "K3 V"; temperature= 4450 } |> Some
      | 40325727 -> { StarData.id= 40325727; name= "9-EXU9 - Star"; solarSystemId= 30005148; typeId= 45033; age= 26744745129L; luminosity= 0.063320; radius= 339000000L; spectralClass= "K6 V"; temperature= 3953 } |> Some
      | 40328637 -> { StarData.id= 40328637; name= "Pakhshi - Star"; solarSystemId= 30005198; typeId= 3800; age= 43032421334L; luminosity= 0.012080; radius= 319400000L; spectralClass= "M4 V"; temperature= 2692 } |> Some
      | 40334263 -> { StarData.id= 40334263; name= "New Eden - Star"; solarSystemId= 30005286; typeId= 45041; age= 21595431348L; luminosity= 0.093740; radius= 158400000L; spectralClass= "K2 V"; temperature= 4511 } |> Some
      | 40335427 -> { StarData.id= 40335427; name= "Cistuvaert - Star"; solarSystemId= 30005305; typeId= 45038; age= 996590328L; luminosity= 0.725000; radius= 257900000L; spectralClass= "G0 V"; temperature= 5895 } |> Some
      | 40348522 -> { StarData.id= 40348522; name= "Astoh - Star"; solarSystemId= 30045323; typeId= 45030; age= 14408573846L; luminosity= 0.120700; radius= 288600000L; spectralClass= "G9 V"; temperature= 5034 } |> Some
      | 40348813 -> { StarData.id= 40348813; name= "Ahtila - Star"; solarSystemId= 30045328; typeId= 56084; age= 1045706865L; luminosity= 0.264400; radius= 202400000L; spectralClass= "F1 VI"; temperature= 7314 } |> Some
      | 40355991 -> { StarData.id= 40355991; name= "J111707 - Star"; solarSystemId= 31000102; typeId= 7; age= 27188378765L; luminosity= 0.052940; radius= 358600000L; spectralClass= "K8 V"; temperature= 3675 } |> Some
      | 40358416 -> { StarData.id= 40358416; name= "J130931 - Star"; solarSystemId= 31000148; typeId= 45039; age= 76083097832L; luminosity= 0.010570; radius= 359600000L; spectralClass= "M6 V"; temperature= 2453 } |> Some
      | 40360162 -> { StarData.id= 40360162; name= "J150745 - Star"; solarSystemId= 31000180; typeId= 45030; age= 8894846021L; luminosity= 0.154900; radius= 299600000L; spectralClass= "G7 V"; temperature= 5260 } |> Some
      | 40362490 -> { StarData.id= 40362490; name= "J162118 - Star"; solarSystemId= 31000224; typeId= 45031; age= 12342510243L; luminosity= 0.056690; radius= 372700000L; spectralClass= "K8 V"; temperature= 3667 } |> Some
      | 40363751 -> { StarData.id= 40363751; name= "J110605 - Star"; solarSystemId= 31000249; typeId= 45047; age= 11499606988L; luminosity= 0.767700; radius= 719000000L; spectralClass= "G9 V"; temperature= 5065 } |> Some
      | 40364721 -> { StarData.id= 40364721; name= "J102837 - Star"; solarSystemId= 31000267; typeId= 45037; age= 11892539824L; luminosity= 0.081050; radius= 338700000L; spectralClass= "K4 V"; temperature= 4207 } |> Some
      | 40371608 -> { StarData.id= 40371608; name= "J132557 - Star"; solarSystemId= 31000401; typeId= 45047; age= 10529951732L; luminosity= 0.349300; radius= 474700000L; spectralClass= "G8 V"; temperature= 5120 } |> Some
      | 40372481 -> { StarData.id= 40372481; name= "J142533 - Star"; solarSystemId= 31000418; typeId= 45032; age= 8137500775L; luminosity= 0.129800; radius= 577699968L; spectralClass= "K9 V"; temperature= 3623 } |> Some
      | 40373451 -> { StarData.id= 40373451; name= "J143429 - Star"; solarSystemId= 31000436; typeId= 7; age= 28392526584L; luminosity= 0.062550; radius= 370400000L; spectralClass= "K7 V"; temperature= 3770 } |> Some
      | 40374324 -> { StarData.id= 40374324; name= "J150921 - Star"; solarSystemId= 31000453; typeId= 6; age= 10716910797L; luminosity= 0.021380; radius= 116400000L; spectralClass= "G8 VI"; temperature= 5143 } |> Some
      | 40377040 -> { StarData.id= 40377040; name= "J105203 - Star"; solarSystemId= 31000502; typeId= 8; age= 20245520089L; luminosity= 0.073950; radius= 350400000L; spectralClass= "K5 V"; temperature= 4042 } |> Some
      | 40377816 -> { StarData.id= 40377816; name= "J134618 - Star"; solarSystemId= 31000516; typeId= 8; age= 17666108434L; luminosity= 0.029760; radius= 211100000L; spectralClass= "K5 V"; temperature= 4148 } |> Some
      | 40385382 -> { StarData.id= 40385382; name= "J214725 - Star"; solarSystemId= 31000662; typeId= 3802; age= 4372956006L; luminosity= 0.105600; radius= 150250000L; spectralClass= "K1 V"; temperature= 4772 } |> Some
      | 40385673 -> { StarData.id= 40385673; name= "J102504 - Star"; solarSystemId= 31000668; typeId= 45033; age= 25879660954L; luminosity= 0.071870; radius= 340500000L; spectralClass= "K5 V"; temperature= 4071 } |> Some
      | 40425637 -> { StarData.id= 40425637; name= "J224148 - Star"; solarSystemId= 31001435; typeId= 45039; age= 27666869065L; luminosity= 0.054790; radius= 1041000000L; spectralClass= "M8 V"; temperature= 2176 } |> Some
      | 40427189 -> { StarData.id= 40427189; name= "J125302 - Star"; solarSystemId= 31001462; typeId= 45040; age= 38437652321L; luminosity= 0.030870; radius= 513700000L; spectralClass= "M4 V"; temperature= 2684 } |> Some
      | 40430293 -> { StarData.id= 40430293; name= "J110719 - Star"; solarSystemId= 31001526; typeId= 45039; age= 40972696693L; luminosity= 0.011200; radius= 353200000L; spectralClass= "M5 V"; temperature= 2512 } |> Some
      | 40430487 -> { StarData.id= 40430487; name= "J130332 - Star"; solarSystemId= 31001530; typeId= 45037; age= 9379674194L; luminosity= 0.035000; radius= 201300000L; spectralClass= "K3 V"; temperature= 4423 } |> Some
      | 40445134 -> { StarData.id= 40445134; name= "J163754 - Star"; solarSystemId= 31001822; typeId= 45039; age= 14240626220L; luminosity= 0.016080; radius= 250900000L; spectralClass= "M1 V"; temperature= 3262 } |> Some
      | 40457453 -> { StarData.id= 40457453; name= "J212302 - Star"; solarSystemId= 31002342; typeId= 45035; age= 3355768613L; luminosity= 3.556000; radius= 821299968L; spectralClass= "F3 V"; temperature= 6953 } |> Some
      | 40466377 -> { StarData.id= 40466377; name= "J215215 - Star"; solarSystemId= 31002085; typeId= 3796; age= 2046416715L; luminosity= 0.653800; radius= 325600000L; spectralClass= "F1 VI"; temperature= 7231 } |> Some
      | 40479763 -> { StarData.id= 40479763; name= "J144107 - Star"; solarSystemId= 31002032; typeId= 45033; age= 1958640696L; luminosity= 0.010780; radius= 141800000L; spectralClass= "K6 V"; temperature= 3927 } |> Some
      | 40484516 -> { StarData.id= 40484516; name= "J170736 - Star"; solarSystemId= 31002333; typeId= 8; age= 15394073238L; luminosity= 0.026980; radius= 218800000L; spectralClass= "K6 V"; temperature= 3976 } |> Some
      | 40487620 -> { StarData.id= 40487620; name= "Thera - Star"; solarSystemId= 31000005; typeId= 34331; age= 478490130L; luminosity= 30.337400; radius= 1223500032L; spectralClass= "A0"; temperature= 9632 } |> Some
      | _ -> None