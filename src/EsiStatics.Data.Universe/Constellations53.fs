namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations53=
    let getConstellation id = 
      match id with 
      | 20000095 -> { ConstellationData.id= 20000095; name= "MRC-29"; regionId= 10000007; solarSystemIds= [| 30000649; 30000650; 30000651; 30000652; 30000653; 30000654 |]; position= {x = 2.824328892e+17;  y = -1.114912101e+16;  z = -4.991814594e+16;} } |> Some
      | 20000192 -> { ConstellationData.id= 20000192; name= "Y8-HHZ"; regionId= 10000015; solarSystemIds= [| 30001315; 30001316; 30001317; 30001318; 30001319; 30001320; 30001321; 30001322; 30001323 |]; position= {x = -1.125520552e+17;  y = 1.134956038e+17;  z = 3.455025103e+17;} } |> Some
      | 20000289 -> { ConstellationData.id= 20000289; name= "MDM8-J"; regionId= 10000023; solarSystemIds= [| 30001963; 30001964; 30001965; 30001966; 30001967; 30001968 |]; position= {x = -2.024496983e+17;  y = 1.011998709e+17;  z = 2.385539308e+17;} } |> Some
      | 20000386 -> { ConstellationData.id= 20000386; name= "Disier"; regionId= 10000032; solarSystemIds= [| 30002632; 30002633; 30002634; 30002635; 30002636; 30002637; 30002638; 30002639; 30002640; 30002641 |]; position= {x = -1.866183916e+17;  y = 6.534642039e+16;  z = 3.301621561e+16;} } |> Some
      | 20000483 -> { ConstellationData.id= 20000483; name= "MK7-AO"; regionId= 10000041; solarSystemIds= [| 30003309; 30003310; 30003311; 30003312; 30003313; 30003314; 30003315; 30003316; 30003317; 30003318; 30003319 |]; position= {x = -3.087055368e+17;  y = 2.366907594e+16;  z = 3.800230806e+16;} } |> Some
      | 20000580 -> { ConstellationData.id= 20000580; name= "9NP-KR"; regionId= 10000050; solarSystemIds= [| 30003968; 30003969; 30003970; 30003971; 30003972; 30003973; 30003974; 30003975; 30003976; 30003977 |]; position= {x = -3.324710655e+17;  y = 8.934173691e+16;  z = -2.265242211e+17;} } |> Some
      | 20000677 -> { ConstellationData.id= 20000677; name= "Hydra"; regionId= 10000058; solarSystemIds= [| 30004636; 30004637; 30004638; 30004639; 30004640; 30004641; 30004642 |]; position= {x = -4.852358035e+17;  y = 2.411455201e+16;  z = -4.827103293e+16;} } |> Some
      | 20000774 -> { ConstellationData.id= 20000774; name= "Fabas"; regionId= 10000067; solarSystemIds= [| 30005288; 30005289; 30005290; 30005291; 30005292; 30005293; 30005294 |]; position= {x = -2.411400694e+17;  y = 2.176476042e+16;  z = 9.481694105e+15;} } |> Some
      | 21000068 -> { ConstellationData.id= 21000068; name= "B-C00068"; regionId= 11000008; solarSystemIds= [| 31000835; 31000836; 31000837; 31000838; 31000839; 31000840; 31000841; 31000842; 31000843; 31000844; 31000845 |]; position= {x = 7.474163209e+18;  y = 2.152932482e+16;  z = -9.628229948e+18;} } |> Some
      | 21000165 -> { ConstellationData.id= 21000165; name= "D-C00165"; regionId= 11000017; solarSystemIds= [| 31001454; 31001455; 31001456; 31001457; 31001458; 31001459 |]; position= {x = 7.751100078e+18;  y = -4.568672168e+15;  z = -9.773541654e+18;} } |> Some
      | 21000262 -> { ConstellationData.id= 21000262; name= "E-C00262"; regionId= 11000026; solarSystemIds= [| 31002107; 31002108; 31002109; 31002110; 31002111; 31002112; 31002113 |]; position= {x = 7.743600365e+18;  y = 2.892944356e+16;  z = -8.938009106e+18;} } |> Some
      | _ -> None