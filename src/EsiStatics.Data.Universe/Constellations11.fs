namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations11=
    let getConstellation id = 
      match id with 
      | 20000053 -> { ConstellationData.id= 20000053; name= "B-PHYN"; regionId= 10000004; solarSystemIds= [| 30000366; 30000367; 30000368; 30000369; 30000370; 30000371; 30000372; 30000373; 30000374; 30000375 |]; position= {x = 8.727422741e+16;  y = 5.216433043e+16;  z = 2.597703845e+17;} } |> Some
      | 20000150 -> { ConstellationData.id= 20000150; name= "Sound"; regionId= 10000012; solarSystemIds= [| 30001022; 30001023; 30001024; 30001025; 30001026; 30001027; 30001028 |]; position= {x = 5.625386148e+15;  y = 2.770594818e+16;  z = -1.458598026e+17;} } |> Some
      | 20000247 -> { ConstellationData.id= 20000247; name= "Arvachah"; regionId= 10000020; solarSystemIds= [| 30001669; 30001670; 30001671; 30001672; 30001673; 30001674; 30021672 |]; position= {x = -2.148046313e+17;  y = 6.963858748e+16;  z = -1.307003914e+17;} } |> Some
      | 20000344 -> { ConstellationData.id= 20000344; name= "SLYP-5"; regionId= 10000027; solarSystemIds= [| 30002344; 30002345; 30002346; 30002347; 30002348; 30002349 |]; position= {x = 1.888085121e+17;  y = 4.904146359e+16;  z = 3.160440249e+16;} } |> Some
      | 20000441 -> { ConstellationData.id= 20000441; name= "Osnins"; regionId= 10000037; solarSystemIds= [| 30003009; 30003010; 30003011; 30003012; 30003013; 30003014; 30003015; 30003016 |]; position= {x = -2.001528523e+17;  y = 2.211294429e+16;  z = 1.455158635e+16;} } |> Some
      | 20000538 -> { ConstellationData.id= 20000538; name= "7X-X1Y"; regionId= 10000046; solarSystemIds= [| 30003690; 30003691; 30003692; 30003693; 30003694; 30003695; 30003696 |]; position= {x = -3.134290328e+17;  y = 3.466316588e+16;  z = 2.560650148e+17;} } |> Some
      | 20000635 -> { ConstellationData.id= 20000635; name= "E-312G"; regionId= 10000055; solarSystemIds= [| 30004341; 30004342; 30004343; 30004344; 30004345; 30004346; 30004347; 30004348; 30004349; 30004350 |]; position= {x = -1.462393708e+17;  y = 7.592074293e+16;  z = 4.130595321e+17;} } |> Some
      | 20000732 -> { ConstellationData.id= 20000732; name= "Peccanouette"; regionId= 10000064; solarSystemIds= [| 30005001; 30005002; 30005003; 30005004; 30005006; 30005007; 30005008 |]; position= {x = -2.371265736e+17;  y = 6.307733658e+16;  z = 3.918031749e+16;} } |> Some
      | 21000026 -> { ConstellationData.id= 21000026; name= "B-C00026"; regionId= 11000004; solarSystemIds= [| 31000408; 31000409; 31000410; 31000411; 31000412; 31000413; 31000414; 31000415; 31000416; 31000417 |]; position= {x = 7.779062205e+18;  y = 2.071383654e+16;  z = -9.35621504e+18;} } |> Some
      | 21000123 -> { ConstellationData.id= 21000123; name= "C-C00123"; regionId= 11000013; solarSystemIds= [| 31001184; 31001185; 31001186; 31001187; 31001188; 31001189 |]; position= {x = 7.731890416e+18;  y = 2.533571712e+16;  z = -9.180831134e+18;} } |> Some
      | 21000220 -> { ConstellationData.id= 21000220; name= "D-C00220"; regionId= 11000022; solarSystemIds= [| 31001807; 31001808; 31001809; 31001810; 31001811; 31001812; 31001813 |]; position= {x = 8.003028705e+18;  y = 5.790342409e+15;  z = -9.197346949e+18;} } |> Some
      | 21000317 -> { ConstellationData.id= 21000317; name= "A-C00317"; regionId= 11000001; solarSystemIds= [| 31000063; 31000064; 31000065; 31000066; 31000067; 31000068; 31000069; 31000070; 31000071 |]; position= {x = 7.636076745e+18;  y = 3.270194517e+15;  z = -9.509105239e+18;} } |> Some
      | _ -> None