namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations20=
    let getConstellation id = 
      match id with 
      | 20000062 -> { ConstellationData.id= 20000062; name= "0VFS-G"; regionId= 10000004; solarSystemIds= [| 30000427; 30000428; 30000429; 30000430; 30000431; 30000432 |]; position= {x = 8.191864744e+16;  y = 8.673334668e+16;  z = 3.807741779e+17;} } |> Some
      | 20000159 -> { ConstellationData.id= 20000159; name= "E6EO-H"; regionId= 10000013; solarSystemIds= [| 30001083; 30001084; 30001085; 30001086; 30001087; 30001088; 30001089; 30001090 |]; position= {x = 1.46522778e+17;  y = 6.432831947e+16;  z = 1.151799769e+17;} } |> Some
      | 20000256 -> { ConstellationData.id= 20000256; name= "Subhatoub"; regionId= 10000020; solarSystemIds= [| 30001729; 30001730; 30001731; 30001732; 30001733; 30001734; 30041672 |]; position= {x = -2.134216063e+17;  y = 6.119881967e+16;  z = -1.249169052e+17;} } |> Some
      | 20000353 -> { ConstellationData.id= 20000353; name= "Almur"; regionId= 10000028; solarSystemIds= [| 30002402; 30002403; 30002404; 30002405; 30002406; 30002407 |]; position= {x = -4.830405958e+16;  y = 4.913819383e+15;  z = -1.831567554e+14;} } |> Some
      | 20000450 -> { ConstellationData.id= 20000450; name= "Ichida"; regionId= 10000038; solarSystemIds= [| 30003080; 30003081; 30003082; 30003083; 30003084; 30003085 |]; position= {x = -1.435100536e+17;  y = 6.107320126e+16;  z = -6.901191923e+16;} } |> Some
      | 20000547 -> { ConstellationData.id= 20000547; name= "5-88B9"; regionId= 10000047; solarSystemIds= [| 30003748; 30003749; 30003750; 30003751; 30003752; 30003753 |]; position= {x = -1.21979787e+17;  y = 3.693752206e+16;  z = -1.424239944e+17;} } |> Some
      | 20000644 -> { ConstellationData.id= 20000644; name= "1ANT-J"; regionId= 10000056; solarSystemIds= [| 30004404; 30004405; 30004406; 30004407; 30004408; 30004409 |]; position= {x = -1.342735925e+16;  y = -2.022947407e+16;  z = -3.625229454e+17;} } |> Some
      | 20000741 -> { ConstellationData.id= 20000741; name= "Ravin"; regionId= 10000065; solarSystemIds= [| 30005062; 30005063; 30005064; 30005065; 30005066; 30005067; 30005068 |]; position= {x = -3.589027824e+17;  y = 2.071691104e+16;  z = -1.364822739e+17;} } |> Some
      | 21000035 -> { ConstellationData.id= 21000035; name= "B-C00035"; regionId= 11000005; solarSystemIds= [| 31000499; 31000500; 31000501; 31000502; 31000503; 31000504; 31000505; 31000506; 31000507 |]; position= {x = 7.88442168e+18;  y = 1.263515352e+16;  z = -9.50341676e+18;} } |> Some
      | 21000132 -> { ConstellationData.id= 21000132; name= "C-C00132"; regionId= 11000014; solarSystemIds= [| 31001240; 31001241; 31001242; 31001243; 31001244; 31001245; 31001246 |]; position= {x = 7.917656159e+18;  y = 1.01996126e+16;  z = -9.320913949e+18;} } |> Some
      | 21000229 -> { ConstellationData.id= 21000229; name= "D-C00229"; regionId= 11000023; solarSystemIds= [| 31001864; 31001865; 31001866; 31001867; 31001868; 31001869; 31001870 |]; position= {x = 8.062703252e+18;  y = 4.417658552e+16;  z = -9.685330523e+18;} } |> Some
      | 21000326 -> { ConstellationData.id= 21000326; name= "B-C00326"; regionId= 11000004; solarSystemIds= [| 31002515; 31002516; 31002517; 31002518; 31002519; 31002520; 31002521; 31002522; 31002523; 31002524; 31002525; 31002526 |]; position= {x = 7.725025396e+18;  y = 1.60681379e+18;  z = -9.252426492e+18;} } |> Some
      | 22000008 -> { ConstellationData.id= 22000008; name= "ADC08"; regionId= 12000002; solarSystemIds= [| 32000057; 32000058; 32000059; 32000060; 32000061; 32000062; 32000063; 32000064 |]; position= {x = 4.515203168e+18;  y = 4.515304801e+18;  z = -5.423519236e+18;} } |> Some
      | _ -> None