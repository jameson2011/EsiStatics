namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations13=
    let getConstellation id = 
      match id with 
      | 20000055 -> { ConstellationData.id= 20000055; name= "VL-OGL"; regionId= 10000004; solarSystemIds= [| 30000382; 30000383; 30000384; 30000385; 30000386; 30000387; 30000388 |]; position= {x = 9.391390137e+16;  y = 7.666155798e+16;  z = 2.956919102e+17;} } |> Some
      | 20000152 -> { ConstellationData.id= 20000152; name= "Hale"; regionId= 10000012; solarSystemIds= [| 30001036; 30001037; 30001038; 30001039; 30001040; 30001041; 30001042; 30001043 |]; position= {x = -9.942089499e+14;  y = -6.393436931e+15;  z = -1.351053845e+17;} } |> Some
      | 20000249 -> { ConstellationData.id= 20000249; name= "Sukanan"; regionId= 10000020; solarSystemIds= [| 30001681; 30001682; 30001683; 30001684; 30001685; 30001686 |]; position= {x = -1.859101865e+17;  y = 9.203013758e+16;  z = -1.190601854e+17;} } |> Some
      | 20000346 -> { ConstellationData.id= 20000346; name= "J-78ZG"; regionId= 10000027; solarSystemIds= [| 30002356; 30002357; 30002358; 30002359; 30002360; 30002361; 30002362; 30002363 |]; position= {x = 9.496028518e+16;  y = 8.030972387e+16;  z = 1.319186567e+16;} } |> Some
      | 20000443 -> { ConstellationData.id= 20000443; name= "Ysiette"; regionId= 10000037; solarSystemIds= [| 30003024; 30003025; 30003026; 30003027; 30003028; 30003029; 30003030 |]; position= {x = -1.809127002e+17;  y = 2.648633853e+16;  z = 1.511497091e+16;} } |> Some
      | 20000540 -> { ConstellationData.id= 20000540; name= "G2E-RJ"; regionId= 10000047; solarSystemIds= [| 30003703; 30003704; 30003705; 30003706; 30003707; 30003708 |]; position= {x = -1.152649888e+17;  y = 6.622717551e+16;  z = -1.202031018e+17;} } |> Some
      | 20000637 -> { ConstellationData.id= 20000637; name= "C-ULS4"; regionId= 10000055; solarSystemIds= [| 30004357; 30004358; 30004359; 30004360; 30004361; 30004362; 30004363 |]; position= {x = -1.155170006e+17;  y = 4.58998267e+16;  z = 4.111922218e+17;} } |> Some
      | 20000734 -> { ConstellationData.id= 20000734; name= "Thoulde"; regionId= 10000064; solarSystemIds= [| 30005015; 30005016; 30005017; 30005018; 30005019; 30005020; 30005021; 30005022; 30005023; 30034971; 30044971 |]; position= {x = -2.045987015e+17;  y = 6.452578526e+16;  z = 4.857479639e+16;} } |> Some
      | 21000028 -> { ConstellationData.id= 21000028; name= "B-C00028"; regionId= 11000004; solarSystemIds= [| 31000427; 31000428; 31000429; 31000430; 31000431; 31000432; 31000433; 31000434; 31000435 |]; position= {x = 7.791195304e+18;  y = 3.352118332e+16;  z = -9.316844915e+18;} } |> Some
      | 21000125 -> { ConstellationData.id= 21000125; name= "C-C00125"; regionId= 11000013; solarSystemIds= [| 31001196; 31001197; 31001198; 31001199; 31001200; 31001201 |]; position= {x = 7.646086008e+18;  y = 1.314436353e+16;  z = -9.257049507e+18;} } |> Some
      | 21000222 -> { ConstellationData.id= 21000222; name= "D-C00222"; regionId= 11000022; solarSystemIds= [| 31001820; 31001821; 31001822; 31001823; 31001824; 31001825 |]; position= {x = 8.002132647e+18;  y = 2.1976532e+15;  z = -9.225278768e+18;} } |> Some
      | 21000319 -> { ConstellationData.id= 21000319; name= "A-C00319"; regionId= 11000001; solarSystemIds= [| 31000084; 31000085; 31000086; 31000087; 31000088; 31000089; 31000090; 31000091; 31000092 |]; position= {x = 7.616750607e+18;  y = 1.258084213e+16;  z = -9.495069067e+18;} } |> Some
      | 22000001 -> { ConstellationData.id= 22000001; name= "ADC01"; regionId= 12000001; solarSystemIds= [| 32000001; 32000002; 32000003; 32000004; 32000005; 32000006; 32000007; 32000008 |]; position= {x = 5.444824766e+18;  y = 6.032347346e+18;  z = -8.347676129e+18;} } |> Some
      | _ -> None