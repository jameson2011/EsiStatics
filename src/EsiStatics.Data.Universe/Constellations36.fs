namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations36=
    let getConstellation id = 
      match id with 
      | 20000078 -> { ConstellationData.id= 20000078; name= "AC-RON"; regionId= 10000006; solarSystemIds= [| 30000539; 30000540; 30000541; 30000542; 30000543; 30000544; 30000545 |]; position= {x = 1.373708978e+17;  y = 8.23243216e+15;  z = -1.497832656e+17;} } |> Some
      | 20000175 -> { ConstellationData.id= 20000175; name= "9HXQ-G"; regionId= 10000014; solarSystemIds= [| 30001198; 30001199; 30001200; 30001201; 30001202; 30001203; 30001204 |]; position= {x = -8.145088188e+16;  y = 1.320719808e+16;  z = -2.451902316e+17;} } |> Some
      | 20000272 -> { ConstellationData.id= 20000272; name= "41JS-R"; regionId= 10000022; solarSystemIds= [| 30001838; 30001839; 30001840; 30001841; 30001842; 30001843; 30001844 |]; position= {x = -1.039105514e+17;  y = 2.209236793e+16;  z = -2.918478348e+17;} } |> Some
      | 20000369 -> { ConstellationData.id= 20000369; name= "Osta"; regionId= 10000030; solarSystemIds= [| 30002518; 30002519; 30002520; 30002521; 30002522; 30002523; 30032505 |]; position= {x = -8.083769757e+16;  y = 2.257036371e+16;  z = 4.992598993e+15;} } |> Some
      | 20000466 -> { ConstellationData.id= 20000466; name= "T-4ACL"; regionId= 10000040; solarSystemIds= [| 30003191; 30003192; 30003193; 30003194; 30003195; 30003196 |]; position= {x = 2.188468555e+17;  y = 7.805483184e+16;  z = 9.912682508e+16;} } |> Some
      | 20000563 -> { ConstellationData.id= 20000563; name= "Serthoulde"; regionId= 10000048; solarSystemIds= [| 30003850; 30003851; 30003852; 30003853; 30003854; 30003855; 30003856; 30003857 |]; position= {x = -2.805129335e+17;  y = 5.625867144e+16;  z = 1.354564009e+17;} } |> Some
      | 20000660 -> { ConstellationData.id= 20000660; name= "Sword"; regionId= 10000057; solarSystemIds= [| 30004520; 30004521; 30004522; 30004523; 30004524; 30004525 |]; position= {x = -3.979447805e+17;  y = 3.488917992e+16;  z = 5.859487057e+16;} } |> Some
      | 20000757 -> { ConstellationData.id= 20000757; name= "LWMW-6"; regionId= 10000066; solarSystemIds= [| 30005174; 30005175; 30005176; 30005177; 30005178; 30005179 |]; position= {x = 2.464913015e+17;  y = -5.434191278e+15;  z = 6.046979697e+16;} } |> Some
      | 21000051 -> { ConstellationData.id= 21000051; name= "B-C00051"; regionId= 11000006; solarSystemIds= [| 31000659; 31000660; 31000661; 31000662; 31000663; 31000664; 31000665; 31000666; 31000667; 31000668 |]; position= {x = 7.8364374e+18;  y = 1.575233962e+16;  z = -9.649487912e+18;} } |> Some
      | 21000148 -> { ConstellationData.id= 21000148; name= "C-C00148"; regionId= 11000015; solarSystemIds= [| 31001342; 31001343; 31001344; 31001345; 31001346; 31001347; 31001348 |]; position= {x = 8.002267815e+18;  y = 1.149358391e+16;  z = -9.486230966e+18;} } |> Some
      | 21000245 -> { ConstellationData.id= 21000245; name= "E-C00245"; regionId= 11000025; solarSystemIds= [| 31001983; 31001984; 31001985; 31001986; 31001987; 31001988; 31001989; 31001990; 31002488 |]; position= {x = 7.341020956e+18;  y = 2.058331341e+16;  z = -9.094729379e+18;} } |> Some
      | 22000024 -> { ConstellationData.id= 22000024; name= "ADC24"; regionId= 12000005; solarSystemIds= [| 32000185; 32000186; 32000187; 32000188; 32000189; 32000190; 32000191; 32000192 |]; position= {x = 4.947258649e+18;  y = 5.598882298e+18;  z = -8.846790774e+18;} } |> Some
      | _ -> None