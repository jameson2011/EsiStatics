namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations18=
    let getConstellation id = 
      match id with 
      | 20000060 -> { ConstellationData.id= 20000060; name= "FL-TD4"; regionId= 10000004; solarSystemIds= [| 30000414; 30000415; 30000416; 30000417; 30000418; 30000419 |]; position= {x = 6.739082732e+16;  y = 8.882016526e+16;  z = 2.602664849e+17;} } |> Some
      | 20000157 -> { ConstellationData.id= 20000157; name= "UL8-RD"; regionId= 10000013; solarSystemIds= [| 30001069; 30001070; 30001071; 30001072; 30001073; 30001074 |]; position= {x = 1.853819809e+17;  y = 6.267492235e+16;  z = 1.297494809e+17;} } |> Some
      | 20000254 -> { ConstellationData.id= 20000254; name= "Anidaza"; regionId= 10000020; solarSystemIds= [| 30001716; 30001717; 30001718; 30001719; 30001720; 30001721 |]; position= {x = -2.153532594e+17;  y = 7.11134758e+16;  z = -1.593251385e+17;} } |> Some
      | 20000351 -> { ConstellationData.id= 20000351; name= "Tartatven"; regionId= 10000028; solarSystemIds= [| 30002390; 30002391; 30002392; 30002393; 30002394; 30002395 |]; position= {x = -4.836875185e+16;  y = 1.799037149e+16;  z = -6.743453976e+15;} } |> Some
      | 20000448 -> { ConstellationData.id= 20000448; name= "Sasen"; regionId= 10000038; solarSystemIds= [| 30003063; 30003064; 30003065; 30003066; 30003067; 30003068; 30003069 |]; position= {x = -1.448774968e+17;  y = 5.785808612e+16;  z = -4.861894656e+16;} } |> Some
      | 20000545 -> { ConstellationData.id= 20000545; name= "ZQ2-CF"; regionId= 10000047; solarSystemIds= [| 30003735; 30003736; 30003737; 30003738; 30003739; 30003740 |]; position= {x = -9.581887122e+16;  y = 6.715312373e+16;  z = -1.982701957e+17;} } |> Some
      | 20000642 -> { ConstellationData.id= 20000642; name= "LIB-F9"; regionId= 10000055; solarSystemIds= [| 30004390; 30004391; 30004392; 30004393; 30004394; 30004395; 30004396 |]; position= {x = -1.923348829e+17;  y = 4.679925579e+16;  z = 4.083656841e+17;} } |> Some
      | 20000739 -> { ConstellationData.id= 20000739; name= "Panoumid"; regionId= 10000065; solarSystemIds= [| 30005050; 30005051; 30005052; 30005053; 30005054; 30005055 |]; position= {x = -3.103488316e+17;  y = -1.015080651e+15;  z = -8.700953608e+16;} } |> Some
      | 21000033 -> { ConstellationData.id= 21000033; name= "B-C00033"; regionId= 11000005; solarSystemIds= [| 31000479; 31000480; 31000481; 31000482; 31000483; 31000484; 31000485; 31000486; 31000487; 31000488; 31000489 |]; position= {x = 7.853381167e+18;  y = 3.781624316e+16;  z = -9.476639806e+18;} } |> Some
      | 21000130 -> { ConstellationData.id= 21000130; name= "C-C00130"; regionId= 11000014; solarSystemIds= [| 31001227; 31001228; 31001229; 31001230; 31001231; 31001232 |]; position= {x = 7.906911732e+18;  y = 1.336253892e+16;  z = -9.290206014e+18;} } |> Some
      | 21000227 -> { ConstellationData.id= 21000227; name= "D-C00227"; regionId= 11000023; solarSystemIds= [| 31001852; 31001853; 31001854; 31001855; 31001856; 31001857 |]; position= {x = 8.113506942e+18;  y = 2.12128192e+16;  z = -9.704326806e+18;} } |> Some
      | 21000324 -> { ConstellationData.id= 21000324; name= "G-C00324"; regionId= 11000031; solarSystemIds= [| 31000005 |]; position= {x = 7.2058e+18;  y = 1.5393e+18;  z = -9.5151e+18;} } |> Some
      | 22000006 -> { ConstellationData.id= 22000006; name= "ADC06"; regionId= 12000002; solarSystemIds= [| 32000041; 32000042; 32000043; 32000044; 32000045; 32000046; 32000047; 32000048 |]; position= {x = 4.668863371e+18;  y = 4.470753703e+18;  z = -5.452242797e+18;} } |> Some
      | _ -> None