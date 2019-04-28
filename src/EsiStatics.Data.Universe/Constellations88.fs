namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations88=
    let getConstellation id = 
      match id with 
      | 20000033 -> { ConstellationData.id= 20000033; name= "DMXN-3"; regionId= 10000003; solarSystemIds= [| 30000228; 30000229; 30000230; 30000231; 30000232; 30000233; 30000234; 30000235; 30000236; 30000237 |]; position= {x = -9.923376026e+16;  y = 1.312547179e+17;  z = 2.097707507e+17;} } |> Some
      | 20000130 -> { ConstellationData.id= 20000130; name= "03C-SU"; regionId= 10000010; solarSystemIds= [| 30000886; 30000887; 30000888; 30000889; 30000890; 30000891; 30000892; 30000893 |]; position= {x = -1.783845113e+17;  y = 1.107402994e+17;  z = 2.131607111e+17;} } |> Some
      | 20000227 -> { ConstellationData.id= 20000227; name= "J0-59Y"; regionId= 10000018; solarSystemIds= [| 30001541; 30001542; 30001543; 30001544; 30001545; 30001546; 30001547 |]; position= {x = 2.190095002e+17;  y = 2.482002559e+16;  z = -2.084552706e+16;} } |> Some
      | 20000324 -> { ConstellationData.id= 20000324; name= "Yestadan"; regionId= 10000043; solarSystemIds= [| 30002204; 30002205; 30002206; 30002207; 30002208; 30002209 |]; position= {x = -1.658102124e+17;  y = 6.254657051e+16;  z = -1.126602153e+17;} } |> Some
      | 20000421 -> { ConstellationData.id= 20000421; name= "XPG-HE"; regionId= 10000034; solarSystemIds= [| 30002868; 30002869; 30002870; 30002871; 30002872; 30002873 |]; position= {x = 1.243224146e+17;  y = 8.132959659e+16;  z = 9.290522498e+16;} } |> Some
      | 20000518 -> { ConstellationData.id= 20000518; name= "Nakid"; regionId= 10000043; solarSystemIds= [| 30003553; 30003554; 30003555; 30003556; 30003557; 30003558 |]; position= {x = -1.468257469e+17;  y = 6.620761308e+16;  z = -1.124548347e+17;} } |> Some
      | 20000615 -> { ConstellationData.id= 20000615; name= "XHL-TZ"; regionId= 10000053; solarSystemIds= [| 30004202; 30004203; 30004204; 30004205; 30004206; 30004207 |]; position= {x = 2.876502932e+17;  y = 4.90406816e+16;  z = 2.414868776e+17;} } |> Some
      | 20000712 -> { ConstellationData.id= 20000712; name= "BZZ-1U"; regionId= 10000061; solarSystemIds= [| 30004866; 30004867; 30004868; 30004869; 30004870; 30004871 |]; position= {x = 1.014986519e+17;  y = -2.275518765e+16;  z = -3.217880527e+17;} } |> Some
      | 21000006 -> { ConstellationData.id= 21000006; name= "A-C00006"; regionId= 11000002; solarSystemIds= [| 31000195; 31000196; 31000197; 31000198; 31000199; 31000200; 31000201; 31000202; 31000203; 31000204 |]; position= {x = 7.555418413e+18;  y = 2.874338489e+16;  z = -9.494699511e+18;} } |> Some
      | 21000103 -> { ConstellationData.id= 21000103; name= "C-C00103"; regionId= 11000011; solarSystemIds= [| 31001052; 31001053; 31001054; 31001055; 31001056; 31001057; 31001058 |]; position= {x = 7.352168253e+18;  y = 4.421686885e+16;  z = -9.48118228e+18;} } |> Some
      | 21000200 -> { ConstellationData.id= 21000200; name= "D-C00200"; regionId= 11000021; solarSystemIds= [| 31001683; 31001684; 31001685; 31001686; 31001687; 31001688 |]; position= {x = 7.53017663e+18;  y = 3.679353893e+16;  z = -9.088606603e+18;} } |> Some
      | 21000297 -> { ConstellationData.id= 21000297; name= "F-C00297"; regionId= 11000030; solarSystemIds= [| 31002367; 31002368; 31002369; 31002370; 31002371; 31002372; 31002373 |]; position= {x = 7.236762744e+18;  y = 3.355004968e+16;  z = -9.876218451e+18;} } |> Some
      | _ -> None