namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations77=
    let getConstellation id = 
      match id with 
      | 20000022 -> { ConstellationData.id= 20000022; name= "Onirvura"; regionId= 10000002; solarSystemIds= [| 30000153; 30000154; 30000155; 30000156; 30000157; 30000158 |]; position= {x = -9.050711587e+16;  y = 8.25506234e+16;  z = 9.746921388e+16;} } |> Some
      | 20000119 -> { ConstellationData.id= 20000119; name= "N-LY4R"; regionId= 10000009; solarSystemIds= [| 30000808; 30000809; 30000810; 30000811; 30000812; 30000813 |]; position= {x = 1.354646847e+17;  y = 3.854081934e+16;  z = -1.013063407e+17;} } |> Some
      | 20000216 -> { ConstellationData.id= 20000216; name= "WSC-AL"; regionId= 10000017; solarSystemIds= [| 30001467; 30001468; 30001469; 30001470; 30001471; 30001472 |]; position= {x = 4.951450986e+16;  y = 6.658616216e+16;  z = 1.866068414e+17;} } |> Some
      | 20000313 -> { ConstellationData.id= 20000313; name= "RTCU-5"; regionId= 10000025; solarSystemIds= [| 30002123; 30002124; 30002125; 30002126; 30002127; 30002128 |]; position= {x = -3.514851215e+15;  y = 2.972619111e+15;  z = -2.011624887e+17;} } |> Some
      | 20000410 -> { ConstellationData.id= 20000410; name= "Otawasa"; regionId= 10000033; solarSystemIds= [| 30002794; 30002795; 30002796; 30002797; 30002798; 30002799 |]; position= {x = -1.74377026e+17;  y = 7.255618733e+16;  z = 1.021927393e+17;} } |> Some
      | 20000507 -> { ConstellationData.id= 20000507; name= "Fua"; regionId= 10000043; solarSystemIds= [| 30003473; 30003474; 30003475; 30003476; 30003477; 30003478; 30003479; 30003480 |]; position= {x = -2.219483179e+17;  y = 5.833704786e+16;  z = -1.820377289e+16;} } |> Some
      | 20000604 -> { ConstellationData.id= 20000604; name= "Ahrnot"; regionId= 10000052; solarSystemIds= [| 30004130; 30004131; 30004132; 30004133; 30004134; 30004135 |]; position= {x = -2.361574071e+17;  y = 5.119749613e+16;  z = -1.069450299e+17;} } |> Some
      | 20000701 -> { ConstellationData.id= 20000701; name= "F-I56R"; regionId= 10000060; solarSystemIds= [| 30004790; 30004791; 30004792; 30004793; 30004794; 30004795 |]; position= {x = -4.137338148e+17;  y = 8.206794002e+16;  z = -2.9448489e+17;} } |> Some
      | 21000092 -> { ConstellationData.id= 21000092; name= "C-C00092"; regionId= 11000010; solarSystemIds= [| 31000980; 31000981; 31000982; 31000983; 31000984; 31000985; 31000986 |]; position= {x = 7.436964426e+18;  y = 3.279987677e+16;  z = -9.695343554e+18;} } |> Some
      | 21000189 -> { ConstellationData.id= 21000189; name= "D-C00189"; regionId= 11000020; solarSystemIds= [| 31001612; 31001613; 31001614; 31001615; 31001616; 31001617; 31001618 |]; position= {x = 7.379417909e+18;  y = 1.037717578e+16;  z = -9.222481762e+18;} } |> Some
      | 21000286 -> { ConstellationData.id= 21000286; name= "E-C00286"; regionId= 11000029; solarSystemIds= [| 31002283; 31002284; 31002285; 31002286; 31002287; 31002288; 31002289 |]; position= {x = 7.588411439e+18;  y = 1.674813387e+16;  z = -1.003280151e+19;} } |> Some
      | _ -> None