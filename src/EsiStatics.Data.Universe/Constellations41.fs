namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations41=
    let getConstellation id = 
      match id with 
      | 20000083 -> { ConstellationData.id= 20000083; name= "J-9M7D"; regionId= 10000006; solarSystemIds= [| 30000572; 30000573; 30000574; 30000575; 30000576; 30000577 |]; position= {x = 5.509428919e+16;  y = 6.470885909e+15;  z = -1.830265377e+17;} } |> Some
      | 20000180 -> { ConstellationData.id= 20000180; name= "NNLX-K"; regionId= 10000014; solarSystemIds= [| 30001232; 30001233; 30001234; 30001235; 30001236; 30001237 |]; position= {x = -1.121841807e+17;  y = 5.43007456e+16;  z = -1.601684812e+17;} } |> Some
      | 20000277 -> { ConstellationData.id= 20000277; name= "H-QXM7"; regionId= 10000022; solarSystemIds= [| 30001873; 30001874; 30001875; 30001876; 30001877; 30001878; 30001879 |]; position= {x = -1.301419456e+17;  y = 4.710609687e+16;  z = -3.417965226e+17;} } |> Some
      | 20000374 -> { ConstellationData.id= 20000374; name= "Akimamur"; regionId= 10000030; solarSystemIds= [| 30002549; 30002550; 30002551; 30002552; 30002553; 30002554 |]; position= {x = -6.302826472e+16;  y = 1.086213333e+16;  z = 3.134671025e+16;} } |> Some
      | 20000471 -> { ConstellationData.id= 20000471; name= "DOCS-O"; regionId= 10000040; solarSystemIds= [| 30003223; 30003224; 30003225; 30003226; 30003227; 30003228 |]; position= {x = 2.725285232e+17;  y = 5.395260456e+16;  z = 1.544701392e+17;} } |> Some
      | 20000568 -> { ConstellationData.id= 20000568; name= "Sib"; regionId= 10000049; solarSystemIds= [| 30003888; 30003889; 30003890; 30003891; 30003892; 30003893; 30003894; 30003895 |]; position= {x = -2.816595541e+17;  y = 3.388004449e+16;  z = -1.72661855e+17;} } |> Some
      | 20000665 -> { ConstellationData.id= 20000665; name= "Pegasus"; regionId= 10000058; solarSystemIds= [| 30004552; 30004553; 30004554; 30004555; 30004556; 30004557; 30004558 |]; position= {x = -4.179030473e+17;  y = 4.61784692e+16;  z = 3.313067131e+16;} } |> Some
      | 20000762 -> { ConstellationData.id= 20000762; name= "Ashela"; regionId= 10000067; solarSystemIds= [| 30005207; 30005208; 30005209; 30005210; 30005211; 30005212; 30005213 |]; position= {x = -2.426534058e+17;  y = 4.954199618e+16;  z = -6.298682646e+15;} } |> Some
      | 21000056 -> { ConstellationData.id= 21000056; name= "B-C00056"; regionId= 11000007; solarSystemIds= [| 31000712; 31000713; 31000714; 31000715; 31000716; 31000717; 31000718; 31000719; 31000720 |]; position= {x = 7.611183742e+18;  y = 4.413400863e+16;  z = -9.76632389e+18;} } |> Some
      | 21000153 -> { ConstellationData.id= 21000153; name= "D-C00153"; regionId= 11000016; solarSystemIds= [| 31001375; 31001376; 31001377; 31001378; 31001379; 31001380; 31001381 |]; position= {x = 7.974116958e+18;  y = 3.303393335e+16;  z = -9.649824099e+18;} } |> Some
      | 21000250 -> { ConstellationData.id= 21000250; name= "E-C00250"; regionId= 11000025; solarSystemIds= [| 31002019; 31002020; 31002021; 31002022; 31002023; 31002024; 31002025 |]; position= {x = 7.365724305e+18;  y = 3.14925955e+16;  z = -9.102794611e+18;} } |> Some
      | _ -> None