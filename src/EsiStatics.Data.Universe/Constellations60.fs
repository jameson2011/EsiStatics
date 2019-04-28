namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations60=
    let getConstellation id = 
      match id with 
      | 20000005 -> { ConstellationData.id= 20000005; name= "Hevaka"; regionId= 10000001; solarSystemIds= [| 30000031; 30000032; 30000033; 30000034; 30000035; 30000036; 30000037 |]; position= {x = -7.705956511e+16;  y = 2.712855388e+16;  z = -2.642336051e+16;} } |> Some
      | 20000102 -> { ConstellationData.id= 20000102; name= "7VJ-7M"; regionId= 10000008; solarSystemIds= [| 30000697; 30000698; 30000699; 30000700; 30000701; 30000702 |]; position= {x = 4.339744294e+16;  y = -1.919095023e+16;  z = -1.346128596e+17;} } |> Some
      | 20000199 -> { ConstellationData.id= 20000199; name= "Koichi"; regionId= 10000016; solarSystemIds= [| 30001362; 30001363; 30001364; 30001365; 30001366; 30001367; 30021392 |]; position= {x = -1.487153189e+17;  y = 8.887507222e+16;  z = 1.389533149e+17;} } |> Some
      | 20000296 -> { ConstellationData.id= 20000296; name= "G8-D09"; regionId= 10000023; solarSystemIds= [| 30002010; 30002011; 30002012; 30002013; 30002014; 30002015 |]; position= {x = -2.365017434e+17;  y = 9.291591385e+16;  z = 2.297762337e+17;} } |> Some
      | 20000393 -> { ConstellationData.id= 20000393; name= "Lolbrerie"; regionId= 10000032; solarSystemIds= [| 30002685; 30002686; 30002687; 30002688; 30002689; 30002690; 30002691 |]; position= {x = -1.647746652e+17;  y = 4.163918718e+16;  z = 6.184225014e+16;} } |> Some
      | 20000490 -> { ConstellationData.id= 20000490; name= "SKX-PL"; regionId= 10000041; solarSystemIds= [| 30003361; 30003362; 30003363; 30003364; 30003365; 30003366; 30003367 |]; position= {x = -3.624190228e+17;  y = 1.631148351e+16;  z = 6.727696384e+16;} } |> Some
      | 20000587 -> { ConstellationData.id= 20000587; name= "LI-BA0"; regionId= 10000050; solarSystemIds= [| 30004019; 30004020; 30004021; 30004022; 30004023; 30004024 |]; position= {x = -3.057821979e+17;  y = 6.868362198e+16;  z = -2.393580689e+17;} } |> Some
      | 20000684 -> { ConstellationData.id= 20000684; name= "I-CCEI"; regionId= 10000059; solarSystemIds= [| 30004679; 30004680; 30004681; 30004682; 30004683; 30004684; 30004685 |]; position= {x = -1.146232158e+17;  y = -4.788479164e+16;  z = -4.710183938e+17;} } |> Some
      | 20000781 -> { ConstellationData.id= 20000781; name= "Urpiken"; regionId= 10000069; solarSystemIds= [| 30045306; 30045307; 30045308; 30045309; 30045310; 30045311; 30045312; 30045313 |]; position= {x = -2.630270785e+17;  y = 7.165551201e+16;  z = 1.876270291e+17;} } |> Some
      | 21000075 -> { ConstellationData.id= 21000075; name= "B-C00075"; regionId= 11000008; solarSystemIds= [| 31000879 |]; position= {x = 7.482021727e+18;  y = -2.912879537e+16;  z = -9.598883743e+18;} } |> Some
      | 21000172 -> { ConstellationData.id= 21000172; name= "D-C00172"; regionId= 11000018; solarSystemIds= [| 31001500; 31001501; 31001502; 31001503; 31001504; 31001505 |]; position= {x = 7.606411889e+18;  y = 1.941937386e+16;  z = -9.733454667e+18;} } |> Some
      | 21000269 -> { ConstellationData.id= 21000269; name= "E-C00269"; regionId= 11000027; solarSystemIds= [| 31002155; 31002156; 31002157; 31002158; 31002159; 31002160; 31002161; 31002162; 31002163; 31002499 |]; position= {x = 8.191385312e+18;  y = 8.088456652e+15;  z = -9.299735509e+18;} } |> Some
      | _ -> None