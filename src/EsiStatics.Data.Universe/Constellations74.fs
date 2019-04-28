namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations74=
    let getConstellation id = 
      match id with 
      | 20000019 -> { ConstellationData.id= 20000019; name= "Ihilakken"; regionId= 10000002; solarSystemIds= [| 30000132; 30000133; 30000134; 30000135; 30000136; 30000137; 30000138; 30010141; 30021407 |]; position= {x = -1.436456547e+17;  y = 5.290958025e+16;  z = 1.096193769e+17;} } |> Some
      | 20000116 -> { ConstellationData.id= 20000116; name= "0EA3-8"; regionId= 10000009; solarSystemIds= [| 30000789; 30000790; 30000791; 30000792; 30000793; 30000794; 30000795 |]; position= {x = 1.083816419e+17;  y = -3.650128614e+15;  z = -1.326093818e+17;} } |> Some
      | 20000213 -> { ConstellationData.id= 20000213; name= "1-Z95W"; regionId= 10000017; solarSystemIds= [| 30001449; 30001450; 30001451; 30001452; 30001453; 30001454 |]; position= {x = 3.68006685e+15;  y = 6.602729773e+16;  z = 2.171942543e+17;} } |> Some
      | 20000310 -> { ConstellationData.id= 20000310; name= "Q-IPAA"; regionId= 10000025; solarSystemIds= [| 30002103; 30002104; 30002105; 30002106; 30002107; 30002108 |]; position= {x = 7.415183584e+15;  y = -2.129678431e+16;  z = -2.18319827e+17;} } |> Some
      | 20000407 -> { ConstellationData.id= 20000407; name= "Outartoh"; regionId= 10000033; solarSystemIds= [| 30002775; 30002776; 30002777; 30002778; 30002779; 30002780 |]; position= {x = -1.212501661e+17;  y = 8.128344847e+16;  z = 1.253973208e+17;} } |> Some
      | 20000504 -> { ConstellationData.id= 20000504; name= "Argeir"; regionId= 10000042; solarSystemIds= [| 30003453; 30003454; 30003455; 30003456; 30003457; 30003458 |]; position= {x = -5.432302686e+16;  y = 5.035026626e+16;  z = 4.812347886e+16;} } |> Some
      | 20000601 -> { ConstellationData.id= 20000601; name= "Parrosa"; regionId= 10000052; solarSystemIds= [| 30004110; 30004111; 30004112; 30004113; 30004114; 30004115 |]; position= {x = -2.202368694e+17;  y = 3.050459795e+16;  z = -2.194726825e+16;} } |> Some
      | 20000698 -> { ConstellationData.id= 20000698; name= "NJU-QV"; regionId= 10000060; solarSystemIds= [| 30004772; 30004773; 30004774; 30004775; 30004776; 30004777 |]; position= {x = -4.655247114e+17;  y = 2.078430199e+16;  z = -2.112841533e+17;} } |> Some
      | 21000089 -> { ConstellationData.id= 21000089; name= "C-C00089"; regionId= 11000010; solarSystemIds= [| 31000962; 31000963; 31000964; 31000965; 31000966; 31000967 |]; position= {x = 7.451474954e+18;  y = -5.121587424e+15;  z = -9.710566119e+18;} } |> Some
      | 21000186 -> { ConstellationData.id= 21000186; name= "D-C00186"; regionId= 11000019; solarSystemIds= [| 31001593; 31001594; 31001595; 31001596; 31001597; 31001598; 31001599 |]; position= {x = 7.403112434e+18;  y = 2.249445484e+16;  z = -9.532031257e+18;} } |> Some
      | 21000283 -> { ConstellationData.id= 21000283; name= "E-C00283"; regionId= 11000028; solarSystemIds= [| 31002259; 31002260; 31002261; 31002262; 31002263; 31002264; 31002265; 31002266 |]; position= {x = 8.005396657e+18;  y = 1.471334135e+16;  z = -9.843449556e+18;} } |> Some
      | _ -> None