namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations28=
    let getConstellation id = 
      match id with 
      | 20000070 -> { ConstellationData.id= 20000070; name= "ZPI-2E"; regionId= 10000005; solarSystemIds= [| 30000479; 30000480; 30000481; 30000482; 30000483; 30000484 |]; position= {x = 1.686332115e+17;  y = -3.475339035e+16;  z = -2.280356522e+17;} } |> Some
      | 20000167 -> { ConstellationData.id= 20000167; name= "PX0-P4"; regionId= 10000013; solarSystemIds= [| 30001140; 30001141; 30001142; 30001143; 30001144; 30001145; 30001146 |]; position= {x = 1.670798318e+17;  y = 9.375186086e+16;  z = 8.32231934e+16;} } |> Some
      | 20000264 -> { ConstellationData.id= 20000264; name= "IM-8S5"; regionId= 10000021; solarSystemIds= [| 30001783; 30001784; 30001785; 30001786; 30001787; 30001788 |]; position= {x = 3.035981909e+17;  y = 1.577729305e+16;  z = 1.095500314e+17;} } |> Some
      | 20000361 -> { ConstellationData.id= 20000361; name= "NK-AOZ"; regionId= 10000029; solarSystemIds= [| 30002457; 30002458; 30002459; 30002460; 30002461; 30002462; 30002463; 30002464; 30002465; 30002466 |]; position= {x = 3.595571374e+15;  y = 7.938669337e+16;  z = 1.16826906e+17;} } |> Some
      | 20000458 -> { ConstellationData.id= 20000458; name= "3WN-1T"; regionId= 10000039; solarSystemIds= [| 30003133; 30003134; 30003135; 30003136; 30003137; 30003138; 30003139 |]; position= {x = -9.068555207e+16;  y = 2.676421798e+15;  z = -4.229404886e+17;} } |> Some
      | 20000555 -> { ConstellationData.id= 20000555; name= "Alselbosier"; regionId= 10000048; solarSystemIds= [| 30003800; 30003801; 30003802; 30003803; 30003804; 30003805 |]; position= {x = -2.825767299e+17;  y = 4.597102715e+16;  z = 5.735678804e+16;} } |> Some
      | 20000652 -> { ConstellationData.id= 20000652; name= "YZKE-Q"; regionId= 10000056; solarSystemIds= [| 30004465; 30004466; 30004467; 30004468; 30004469; 30004470 |]; position= {x = 5.687320162e+16;  y = 1.534406364e+16;  z = -3.387182342e+17;} } |> Some
      | 20000749 -> { ConstellationData.id= 20000749; name= "X7-FTR"; regionId= 10000066; solarSystemIds= [| 30005116; 30005117; 30005118; 30005119; 30005120; 30005121; 30005122 |]; position= {x = 2.169532519e+17;  y = 4.245954477e+16;  z = 8.151781063e+16;} } |> Some
      | 21000043 -> { ConstellationData.id= 21000043; name= "B-C00043"; regionId= 11000006; solarSystemIds= [| 31000580; 31000581; 31000582; 31000583; 31000584; 31000585; 31000586; 31000587; 31000588; 31000589; 31000590 |]; position= {x = 7.827386227e+18;  y = 5.250639614e+15;  z = -9.691214106e+18;} } |> Some
      | 21000140 -> { ConstellationData.id= 21000140; name= "C-C00140"; regionId= 11000014; solarSystemIds= [| 31001292; 31001293; 31001294; 31001295; 31001296; 31001297; 31001298 |]; position= {x = 7.894394946e+18;  y = 2.702247436e+16;  z = -9.335010719e+18;} } |> Some
      | 21000237 -> { ConstellationData.id= 21000237; name= "E-C00237"; regionId= 11000024; solarSystemIds= [| 31001920; 31001921; 31001922; 31001923; 31001924; 31001925; 31001926 |]; position= {x = 7.184027752e+18;  y = 1.430423557e+16;  z = -9.327203219e+18;} } |> Some
      | 21000334 -> { ConstellationData.id= 21000334; name= "K-C00334"; regionId= 11000033; solarSystemIds= [| 31000001; 31000002; 31000003; 31000004; 31000006 |]; position= {x = 6.827804192e+18;  y = 1.68692116e+18;  z = -9.795533212e+18;} } |> Some
      | 22000016 -> { ConstellationData.id= 22000016; name= "ADC16"; regionId= 12000004; solarSystemIds= [| 32000121; 32000122; 32000123; 32000124; 32000125; 32000126; 32000127; 32000128 |]; position= {x = 4.34605881e+18;  y = 5.149294927e+18;  z = -6.086071224e+18;} } |> Some
      | _ -> None