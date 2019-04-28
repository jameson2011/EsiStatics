namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations87=
    let getConstellation id = 
      match id with 
      | 20000032 -> { ConstellationData.id= 20000032; name= "OSJ7-I"; regionId= 10000003; solarSystemIds= [| 30000222; 30000223; 30000224; 30000225; 30000226; 30000227 |]; position= {x = -5.008259865e+16;  y = 8.73624613e+16;  z = 1.587870527e+17;} } |> Some
      | 20000129 -> { ConstellationData.id= 20000129; name= "GORV-P"; regionId= 10000010; solarSystemIds= [| 30000879; 30000880; 30000881; 30000882; 30000883; 30000884; 30000885 |]; position= {x = -1.801360618e+17;  y = 8.517138931e+16;  z = 2.487013296e+17;} } |> Some
      | 20000226 -> { ConstellationData.id= 20000226; name= "OC-TTA"; regionId= 10000018; solarSystemIds= [| 30001533; 30001534; 30001535; 30001536; 30001537; 30001538; 30001539; 30001540 |]; position= {x = 2.05685489e+17;  y = 5.750532327e+16;  z = 1.580591817e+16;} } |> Some
      | 20000323 -> { ConstellationData.id= 20000323; name= "Mobit"; regionId= 10000043; solarSystemIds= [| 30002197; 30002198; 30002199; 30002200; 30002201; 30002202; 30002203 |]; position= {x = -2.351840545e+17;  y = 3.664997015e+16;  z = -4.895803382e+16;} } |> Some
      | 20000420 -> { ConstellationData.id= 20000420; name= "8UD2-J"; regionId= 10000034; solarSystemIds= [| 30002861; 30002862; 30002863; 30002864; 30002865; 30002866; 30002867 |]; position= {x = 1.107092763e+17;  y = 6.463851841e+16;  z = 8.66807594e+16;} } |> Some
      | 20000517 -> { ConstellationData.id= 20000517; name= "Maseend"; regionId= 10000043; solarSystemIds= [| 30003545; 30003546; 30003547; 30003548; 30003549; 30003550; 30003551; 30003552 |]; position= {x = -1.536582764e+17;  y = 7.36038679e+16;  z = -8.081683728e+16;} } |> Some
      | 20000614 -> { ConstellationData.id= 20000614; name= "I-WRVM"; regionId= 10000053; solarSystemIds= [| 30004196; 30004197; 30004198; 30004199; 30004200; 30004201 |]; position= {x = 2.991414388e+17;  y = 3.664242923e+16;  z = 2.191241638e+17;} } |> Some
      | 20000711 -> { ConstellationData.id= 20000711; name= "EIX-HK"; regionId= 10000061; solarSystemIds= [| 30004859; 30004860; 30004861; 30004862; 30004863; 30004864; 30004865 |]; position= {x = 1.009778767e+17;  y = -4.125725553e+16;  z = -3.268532587e+17;} } |> Some
      | 21000005 -> { ConstellationData.id= 21000005; name= "A-C00005"; regionId= 11000002; solarSystemIds= [| 31000186; 31000187; 31000188; 31000189; 31000190; 31000191; 31000192; 31000193; 31000194 |]; position= {x = 7.600112315e+18;  y = 2.340076873e+16;  z = -9.475248108e+18;} } |> Some
      | 21000102 -> { ConstellationData.id= 21000102; name= "C-C00102"; regionId= 11000011; solarSystemIds= [| 31001046; 31001047; 31001048; 31001049; 31001050; 31001051 |]; position= {x = 7.36673479e+18;  y = 2.265033243e+16;  z = -9.43920608e+18;} } |> Some
      | 21000199 -> { ConstellationData.id= 21000199; name= "D-C00199"; regionId= 11000021; solarSystemIds= [| 31001677; 31001678; 31001679; 31001680; 31001681; 31001682 |]; position= {x = 7.527374452e+18;  y = 2.8398547e+16;  z = -9.162225419e+18;} } |> Some
      | 21000296 -> { ConstellationData.id= 21000296; name= "E-C00296"; regionId= 11000029; solarSystemIds= [| 31002360; 31002361; 31002362; 31002363; 31002364; 31002365; 31002366; 31002473; 31002480 |]; position= {x = 7.601509889e+18;  y = 2.137352252e+16;  z = -1.001915759e+19;} } |> Some
      | _ -> None