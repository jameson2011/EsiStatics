namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations83=
    let getConstellation id = 
      match id with 
      | 20000028 -> { ConstellationData.id= 20000028; name= "Mivora"; regionId= 10000002; solarSystemIds= [| 30000195; 30000196; 30000197; 30000198; 30000199; 30000200 |]; position= {x = -4.919500463e+16;  y = 3.51545564e+16;  z = 8.06270311e+16;} } |> Some
      | 20000125 -> { ConstellationData.id= 20000125; name= "X-VN63"; regionId= 10000010; solarSystemIds= [| 30000852; 30000853; 30000854; 30000855; 30000856; 30000857; 30000858; 30000859; 30000860 |]; position= {x = -1.601268857e+17;  y = 1.015473349e+17;  z = 2.274381526e+17;} } |> Some
      | 20000222 -> { ConstellationData.id= 20000222; name= "D-YMGR"; regionId= 10000017; solarSystemIds= [| 30001506; 30001507; 30001508; 30001509; 30001510; 30001511 |]; position= {x = -4.873854146e+15;  y = 9.980657542e+16;  z = 2.592846131e+17;} } |> Some
      | 20000319 -> { ConstellationData.id= 20000319; name= "YENX-U"; regionId= 10000025; solarSystemIds= [| 30002165; 30002166; 30002167; 30002168; 30002169; 30002170; 30002171 |]; position= {x = 4.136513282e+16;  y = -2.098750639e+15;  z = -2.379745952e+17;} } |> Some
      | 20000416 -> { ConstellationData.id= 20000416; name= "2O-VY7"; regionId= 10000034; solarSystemIds= [| 30002833; 30002834; 30002835; 30002836; 30002837; 30002838 |]; position= {x = 1.396836199e+17;  y = 6.5730017e+16;  z = 5.99201867e+16;} } |> Some
      | 20000513 -> { ConstellationData.id= 20000513; name= "Chardu"; regionId= 10000043; solarSystemIds= [| 30003513; 30003514; 30003515; 30003516; 30003517; 30003518; 30003519 |]; position= {x = -1.987102517e+17;  y = 7.214409761e+16;  z = -5.910888115e+16;} } |> Some
      | 20000610 -> { ConstellationData.id= 20000610; name= "HNZF-Z"; regionId= 10000053; solarSystemIds= [| 30004167; 30004168; 30004169; 30004170; 30004171; 30004172; 30004173; 30004174; 30004175; 30004176 |]; position= {x = 2.906326927e+17;  y = 3.994077795e+16;  z = 1.637307165e+17;} } |> Some
      | 20000707 -> { ConstellationData.id= 20000707; name= "ZQ7-QS"; regionId= 10000061; solarSystemIds= [| 30004831; 30004832; 30004833; 30004834; 30004835; 30004836; 30004837; 30004838 |]; position= {x = 1.527326207e+16;  y = 7.40729304e+15;  z = -2.816650128e+17;} } |> Some
      | 21000001 -> { ConstellationData.id= 21000001; name= "A-C00001"; regionId= 11000002; solarSystemIds= [| 31000140; 31000141; 31000142; 31000143; 31000144; 31000145; 31000146; 31000147; 31000148; 31000149; 31000150 |]; position= {x = 7.603181148e+18;  y = 2.067174993e+16;  z = -9.386121146e+18;} } |> Some
      | 21000098 -> { ConstellationData.id= 21000098; name= "C-C00098"; regionId= 11000011; solarSystemIds= [| 31001020; 31001021; 31001022; 31001023; 31001024; 31001025 |]; position= {x = 7.389365001e+18;  y = 1.996193216e+16;  z = -9.445206623e+18;} } |> Some
      | 21000195 -> { ConstellationData.id= 21000195; name= "D-C00195"; regionId= 11000021; solarSystemIds= [| 31001650; 31001651; 31001652; 31001653; 31001654; 31001655; 31001656 |]; position= {x = 7.59055142e+18;  y = 2.325744355e+16;  z = -9.100755597e+18;} } |> Some
      | 21000292 -> { ConstellationData.id= 21000292; name= "E-C00292"; regionId= 11000029; solarSystemIds= [| 31002329; 31002330; 31002331; 31002332; 31002333; 31002334; 31002335; 31002336; 31002337; 31002475 |]; position= {x = 7.577144493e+18;  y = 1.542032645e+16;  z = -1.001774446e+19;} } |> Some
      | _ -> None