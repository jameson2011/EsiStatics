namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations67=
    let getConstellation id = 
      match id with 
      | 20000012 -> { ConstellationData.id= 20000012; name= "Oraron"; regionId= 10000001; solarSystemIds= [| 30000082; 30000083; 30000084; 30000085; 30000086; 30000087; 30000088 |]; position= {x = -1.005080807e+17;  y = 5.298512994e+16;  z = -6.783894095e+16;} } |> Some
      | 20000109 -> { ConstellationData.id= 20000109; name= "U-EUG7"; regionId= 10000009; solarSystemIds= [| 30000743; 30000744; 30000745; 30000746; 30000747; 30000748; 30000749 |]; position= {x = 1.546263541e+17;  y = -1.182384027e+16;  z = -1.254234339e+17;} } |> Some
      | 20000206 -> { ConstellationData.id= 20000206; name= "Karnola"; regionId= 10000016; solarSystemIds= [| 30001404; 30001405; 30001406; 30001407; 30001408; 30001409; 30011407 |]; position= {x = -1.747858229e+17;  y = 1.001274806e+17;  z = 1.175140816e+17;} } |> Some
      | 20000303 -> { ConstellationData.id= 20000303; name= "Tiat"; regionId= 10000042; solarSystemIds= [| 30002054; 30002055; 30002056; 30002057; 30002058; 30002059 |]; position= {x = -1.329206566e+17;  y = 2.996719808e+16;  z = 4.369143101e+16;} } |> Some
      | 20000400 -> { ConstellationData.id= 20000400; name= "Ambrye"; regionId= 10000032; solarSystemIds= [| 30002731; 30002732; 30002733; 30002734; 30002735; 30002736; 30042715 |]; position= {x = -1.70443315e+17;  y = 4.211219384e+16;  z = 2.037451806e+16;} } |> Some
      | 20000497 -> { ConstellationData.id= 20000497; name= "Meinigefur"; regionId= 10000042; solarSystemIds= [| 30003409; 30003410; 30003411; 30003412; 30003413; 30003414; 30003415; 30023410 |]; position= {x = -5.539101032e+16;  y = 5.104161174e+16;  z = 3.318997102e+16;} } |> Some
      | 20000594 -> { ConstellationData.id= 20000594; name= "Assilot"; regionId= 10000051; solarSystemIds= [| 30004065; 30004066; 30004067; 30004068; 30004069; 30004070 |]; position= {x = -3.075244862e+17;  y = 8.33849438e+16;  z = 1.764057009e+17;} } |> Some
      | 20000691 -> { ConstellationData.id= 20000691; name= "O5K-Y6"; regionId= 10000060; solarSystemIds= [| 30004724; 30004725; 30004726; 30004727; 30004728; 30004729 |]; position= {x = -4.299569315e+17;  y = 5.889156844e+16;  z = -2.22333617e+17;} } |> Some
      | 20000788 -> { ConstellationData.id= 20000788; name= "Krai Svarog"; regionId= 10000070; solarSystemIds= [| 30000021; 30001413; 30002225; 30002411; 30002770; 30003495; 30003504; 30040141; 30045328 |]; position= {x = -1.094979294e+17;  y = 4.567735368e+16;  z = 2.044155464e+16;} } |> Some
      | 21000082 -> { ConstellationData.id= 21000082; name= "C-C00082"; regionId= 11000009; solarSystemIds= [| 31000918; 31000919; 31000920; 31000921; 31000922; 31000923 |]; position= {x = 7.74248425e+18;  y = 2.964319566e+16;  z = -9.859114133e+18;} } |> Some
      | 21000179 -> { ConstellationData.id= 21000179; name= "D-C00179"; regionId= 11000019; solarSystemIds= [| 31001547; 31001548; 31001549; 31001550; 31001551; 31001552 |]; position= {x = 7.475579763e+18;  y = 3.561921122e+16;  z = -9.537201403e+18;} } |> Some
      | 21000276 -> { ConstellationData.id= 21000276; name= "E-C00276"; regionId= 11000028; solarSystemIds= [| 31002209; 31002210; 31002211; 31002212; 31002213; 31002214 |]; position= {x = 8.004786839e+18;  y = 2.457439851e+16;  z = -9.916690753e+18;} } |> Some
      | _ -> None