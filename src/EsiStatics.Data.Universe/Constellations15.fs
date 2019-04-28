namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations15=
    let getConstellation id = 
      match id with 
      | 20000057 -> { ConstellationData.id= 20000057; name= "HN5-RL"; regionId= 10000004; solarSystemIds= [| 30000395; 30000396; 30000397; 30000398; 30000399; 30000400; 30000401 |]; position= {x = 9.919557832e+16;  y = 8.075555887e+16;  z = 3.260458173e+17;} } |> Some
      | 20000154 -> { ConstellationData.id= 20000154; name= "4R-HUN"; regionId= 10000013; solarSystemIds= [| 30001051; 30001052; 30001053; 30001054; 30001055; 30001056 |]; position= {x = 1.766317101e+17;  y = 7.287986049e+16;  z = 5.728388922e+16;} } |> Some
      | 20000251 -> { ConstellationData.id= 20000251; name= "Rifenda"; regionId= 10000020; solarSystemIds= [| 30001694; 30001695; 30001696; 30001697; 30001698; 30001699 |]; position= {x = -2.126094492e+17;  y = 8.303515979e+16;  z = -1.147668616e+17;} } |> Some
      | 20000348 -> { ConstellationData.id= 20000348; name= "1VN-XC"; regionId= 10000027; solarSystemIds= [| 30002370; 30002371; 30002372; 30002373; 30002374; 30002375; 30002376 |]; position= {x = 6.795557059e+16;  y = 5.626851378e+16;  z = -4.222009126e+15;} } |> Some
      | 20000445 -> { ConstellationData.id= 20000445; name= "Giatole"; regionId= 10000037; solarSystemIds= [| 30003038; 30003039; 30003040; 30003041; 30003042; 30003043; 30003044 |]; position= {x = -1.932981345e+17;  y = 1.054247888e+16;  z = 2.292708195e+16;} } |> Some
      | 20000542 -> { ConstellationData.id= 20000542; name= "AZBG-H"; regionId= 10000047; solarSystemIds= [| 30003717; 30003718; 30003719; 30003720; 30003721; 30003722 |]; position= {x = -1.147654491e+17;  y = 7.070876991e+16;  z = -1.363014651e+17;} } |> Some
      | 20000639 -> { ConstellationData.id= 20000639; name= "BI-NFW"; regionId= 10000055; solarSystemIds= [| 30004371; 30004372; 30004373; 30004374; 30004375; 30004376; 30004377 |]; position= {x = -9.932903119e+16;  y = 6.197624451e+16;  z = 4.419958666e+17;} } |> Some
      | 20000736 -> { ConstellationData.id= 20000736; name= "Jatari"; regionId= 10000065; solarSystemIds= [| 30005030; 30005031; 30005032; 30005033; 30005034; 30005035 |]; position= {x = -2.581815744e+17;  y = 1.851383598e+16;  z = -7.467242871e+16;} } |> Some
      | 21000030 -> { ConstellationData.id= 21000030; name= "B-C00030"; regionId= 11000004; solarSystemIds= [| 31000448; 31000449; 31000450; 31000451; 31000452; 31000453; 31000454; 31000455; 31000456; 31000457; 31000458 |]; position= {x = 7.728105776e+18;  y = 1.386032319e+16;  z = -9.349514088e+18;} } |> Some
      | 21000127 -> { ConstellationData.id= 21000127; name= "C-C00127"; regionId= 11000013; solarSystemIds= [| 31001208; 31001209; 31001210; 31001211; 31001212; 31001213 |]; position= {x = 7.751229365e+18;  y = -2.923892505e+15;  z = -9.181030847e+18;} } |> Some
      | 21000224 -> { ConstellationData.id= 21000224; name= "D-C00224"; regionId= 11000022; solarSystemIds= [| 31001833; 31001834; 31001835; 31001836; 31001837; 31001838; 31001839 |]; position= {x = 8.01234132e+18;  y = 2.459879453e+16;  z = -9.191579609e+18;} } |> Some
      | 21000321 -> { ConstellationData.id= 21000321; name= "A-C00321"; regionId= 11000001; solarSystemIds= [| 31000105; 31000106; 31000107; 31000108; 31000109; 31000110; 31000111; 31000112; 31000113; 31000114; 31000115; 31000116 |]; position= {x = 7.617991222e+18;  y = 1.964109118e+16;  z = -9.50935472e+18;} } |> Some
      | 22000003 -> { ConstellationData.id= 22000003; name= "ADC03"; regionId= 12000001; solarSystemIds= [| 32000017; 32000018; 32000019; 32000020; 32000021; 32000022; 32000023; 32000024 |]; position= {x = 3.312576328e+18;  y = 4.964240215e+18;  z = -5.630149537e+18;} } |> Some
      | _ -> None