namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations85=
    let getConstellation id = 
      match id with 
      | 20000030 -> { ConstellationData.id= 20000030; name= "U29-0S"; regionId= 10000003; solarSystemIds= [| 30000208; 30000209; 30000210; 30000211; 30000212; 30000213; 30000214 |]; position= {x = -6.651313559e+16;  y = 1.063325961e+17;  z = 1.659876959e+17;} } |> Some
      | 20000127 -> { ConstellationData.id= 20000127; name= "52-JKU"; regionId= 10000010; solarSystemIds= [| 30000867; 30000868; 30000869; 30000870; 30000871; 30000872 |]; position= {x = -9.775877129e+16;  y = 9.72958978e+16;  z = 2.31010327e+17;} } |> Some
      | 20000224 -> { ConstellationData.id= 20000224; name= "3A-CND"; regionId= 10000017; solarSystemIds= [| 30001518; 30001519; 30001520; 30001521; 30001522; 30001523; 30001524; 30001525 |]; position= {x = -3.099041996e+16;  y = 8.570806356e+16;  z = 2.782506204e+17;} } |> Some
      | 20000321 -> { ConstellationData.id= 20000321; name= "IJE6-J"; regionId= 10000025; solarSystemIds= [| 30002178; 30002179; 30002180; 30002181; 30002182; 30002183; 30002184; 30002185; 30002186 |]; position= {x = 6.668121522e+16;  y = -5.884271961e+15;  z = -2.458010544e+17;} } |> Some
      | 20000418 -> { ConstellationData.id= 20000418; name= "S4S-SD"; regionId= 10000034; solarSystemIds= [| 30002846; 30002847; 30002848; 30002849; 30002850; 30002851; 30002852 |]; position= {x = 1.381259439e+17;  y = 5.824003988e+16;  z = 9.726926999e+16;} } |> Some
      | 20000515 -> { ConstellationData.id= 20000515; name= "Qeti"; regionId= 10000043; solarSystemIds= [| 30003528; 30003529; 30003530; 30003531; 30003532; 30003533; 30003534; 30003535; 30003536; 30003537 |]; position= {x = -1.842058962e+17;  y = 8.74017671e+16;  z = -5.977581629e+16;} } |> Some
      | 20000612 -> { ConstellationData.id= 20000612; name= "G3-MU3"; regionId= 10000053; solarSystemIds= [| 30004183; 30004184; 30004185; 30004186; 30004187; 30004188; 30004189 |]; position= {x = 3.086039537e+17;  y = 4.086080839e+16;  z = 1.645351489e+17;} } |> Some
      | 20000709 -> { ConstellationData.id= 20000709; name= "50-5UD"; regionId= 10000061; solarSystemIds= [| 30004845; 30004846; 30004847; 30004848; 30004849; 30004850; 30004851 |]; position= {x = 6.195564094e+16;  y = 8.00780213e+15;  z = -3.001087441e+17;} } |> Some
      | 21000003 -> { ConstellationData.id= 21000003; name= "A-C00003"; regionId= 11000002; solarSystemIds= [| 31000163; 31000164; 31000165; 31000166; 31000167; 31000168; 31000169; 31000170; 31000171; 31000172; 31000173 |]; position= {x = 7.538447389e+18;  y = 3.57527929e+16;  z = -9.457433912e+18;} } |> Some
      | 21000100 -> { ConstellationData.id= 21000100; name= "C-C00100"; regionId= 11000011; solarSystemIds= [| 31001033; 31001034; 31001035; 31001036; 31001037; 31001038; 31001039 |]; position= {x = 7.416428e+18;  y = 5.216851789e+16;  z = -9.453978873e+18;} } |> Some
      | 21000197 -> { ConstellationData.id= 21000197; name= "D-C00197"; regionId= 11000021; solarSystemIds= [| 31001663; 31001664; 31001665; 31001666; 31001667; 31001668; 31001669 |]; position= {x = 7.589359872e+18;  y = -9.642654226e+15;  z = -9.133368092e+18;} } |> Some
      | 21000294 -> { ConstellationData.id= 21000294; name= "E-C00294"; regionId= 11000029; solarSystemIds= [| 31002346; 31002347; 31002348; 31002349; 31002350; 31002351; 31002352; 31002353 |]; position= {x = 7.575337502e+18;  y = 1.127792918e+16;  z = -9.99673396e+18;} } |> Some
      | _ -> None