namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations19=
    let getConstellation id = 
      match id with 
      | 20000061 -> { ConstellationData.id= 20000061; name= "B-HLOG"; regionId= 10000004; solarSystemIds= [| 30000420; 30000421; 30000422; 30000423; 30000424; 30000425; 30000426 |]; position= {x = 1.107407856e+17;  y = 9.56951529e+16;  z = 3.670835023e+17;} } |> Some
      | 20000158 -> { ConstellationData.id= 20000158; name= "3TS-12"; regionId= 10000013; solarSystemIds= [| 30001075; 30001076; 30001077; 30001078; 30001079; 30001080; 30001081; 30001082 |]; position= {x = 1.716771067e+17;  y = 6.120027112e+16;  z = 1.171249679e+17;} } |> Some
      | 20000255 -> { ConstellationData.id= 20000255; name= "Ajah"; regionId= 10000020; solarSystemIds= [| 30001722; 30001723; 30001724; 30001725; 30001726; 30001727; 30001728; 30011672; 30031672 |]; position= {x = -2.265929781e+17;  y = 7.950815834e+16;  z = -1.303572064e+17;} } |> Some
      | 20000352 -> { ConstellationData.id= 20000352; name= "Besateoden"; regionId= 10000028; solarSystemIds= [| 30002396; 30002397; 30002398; 30002399; 30002400; 30002401 |]; position= {x = -3.867440126e+16;  y = 1.165418883e+15;  z = 7.297437656e+15;} } |> Some
      | 20000449 -> { ConstellationData.id= 20000449; name= "Vaarma"; regionId= 10000038; solarSystemIds= [| 30003070; 30003071; 30003072; 30003073; 30003074; 30003075; 30003076; 30003077; 30003078; 30003079 |]; position= {x = -1.56323523e+17;  y = 3.711320025e+16;  z = -5.018303591e+16;} } |> Some
      | 20000546 -> { ConstellationData.id= 20000546; name= "HS7W-T"; regionId= 10000047; solarSystemIds= [| 30003741; 30003742; 30003743; 30003744; 30003745; 30003746; 30003747 |]; position= {x = -1.300962744e+17;  y = 5.983422841e+16;  z = -1.768948933e+17;} } |> Some
      | 20000643 -> { ConstellationData.id= 20000643; name= "T-RQ7S"; regionId= 10000055; solarSystemIds= [| 30004397; 30004398; 30004399; 30004400; 30004401; 30004402; 30004403 |]; position= {x = -1.033477651e+17;  y = 5.328615641e+16;  z = 4.680068024e+17;} } |> Some
      | 20000740 -> { ConstellationData.id= 20000740; name= "Finena"; regionId= 10000065; solarSystemIds= [| 30005056; 30005057; 30005058; 30005059; 30005060; 30005061 |]; position= {x = -3.309483196e+17;  y = 1.334600607e+16;  z = -1.080354112e+17;} } |> Some
      | 21000034 -> { ConstellationData.id= 21000034; name= "B-C00034"; regionId= 11000005; solarSystemIds= [| 31000490; 31000491; 31000492; 31000493; 31000494; 31000495; 31000496; 31000497; 31000498 |]; position= {x = 7.842904794e+18;  y = 2.46418025e+16;  z = -9.499740968e+18;} } |> Some
      | 21000131 -> { ConstellationData.id= 21000131; name= "C-C00131"; regionId= 11000014; solarSystemIds= [| 31001233; 31001234; 31001235; 31001236; 31001237; 31001238; 31001239 |]; position= {x = 7.91903503e+18;  y = 2.10990566e+16;  z = -9.308595306e+18;} } |> Some
      | 21000228 -> { ConstellationData.id= 21000228; name= "D-C00228"; regionId= 11000023; solarSystemIds= [| 31001858; 31001859; 31001860; 31001861; 31001862; 31001863 |]; position= {x = 8.13094113e+18;  y = 1.006037032e+16;  z = -9.736224487e+18;} } |> Some
      | 21000325 -> { ConstellationData.id= 21000325; name= "A-C00325"; regionId= 11000001; solarSystemIds= [| 31002505; 31002506; 31002507; 31002508; 31002509; 31002510; 31002511; 31002512; 31002513; 31002514 |]; position= {x = 7.658505423e+18;  y = 1.548895616e+18;  z = -9.465393575e+18;} } |> Some
      | 22000007 -> { ConstellationData.id= 22000007; name= "ADC07"; regionId= 12000002; solarSystemIds= [| 32000049; 32000050; 32000051; 32000052; 32000053; 32000054; 32000055; 32000056 |]; position= {x = 4.800702461e+18;  y = 4.528422925e+18;  z = -5.502191615e+18;} } |> Some
      | _ -> None