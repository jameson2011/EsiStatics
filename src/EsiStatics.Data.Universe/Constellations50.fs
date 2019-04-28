namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations50=
    let getConstellation id = 
      match id with 
      | 20000092 -> { ConstellationData.id= 20000092; name= "Y-JSM8"; regionId= 10000007; solarSystemIds= [| 30000630; 30000631; 30000632; 30000633; 30000634; 30000635; 30000636 |]; position= {x = 2.537792923e+17;  y = 4.640064166e+15;  z = -9.875053065e+16;} } |> Some
      | 20000189 -> { ConstellationData.id= 20000189; name= "E-I1JW"; regionId= 10000015; solarSystemIds= [| 30001292; 30001293; 30001294; 30001295; 30001296; 30001297; 30001298; 30001299 |]; position= {x = -1.736146894e+17;  y = 9.537670661e+16;  z = 2.920686868e+17;} } |> Some
      | 20000286 -> { ConstellationData.id= 20000286; name= "Z01V-Z"; regionId= 10000022; solarSystemIds= [| 30001937; 30001938; 30001939; 30001940; 30001941; 30001942; 30001943; 30001944; 30001945; 30001946; 30001947 |]; position= {x = -1.877071875e+17;  y = 5.344060978e+16;  z = -3.429210433e+17;} } |> Some
      | 20000383 -> { ConstellationData.id= 20000383; name= "EK-NQ2"; regionId= 10000031; solarSystemIds= [| 30002612; 30002613; 30002614; 30002615; 30002616; 30002617; 30002618 |]; position= {x = -4.620483266e+16;  y = -3.052804848e+16;  z = -3.628942298e+17;} } |> Some
      | 20000480 -> { ConstellationData.id= 20000480; name= "Y4Y7-Q"; regionId= 10000041; solarSystemIds= [| 30003286; 30003287; 30003288; 30003289; 30003290; 30003291 |]; position= {x = -2.847840581e+17;  y = -7.732197483e+14;  z = 3.849880847e+16;} } |> Some
      | 20000577 -> { ConstellationData.id= 20000577; name= "PUB-0R"; regionId= 10000050; solarSystemIds= [| 30003948; 30003949; 30003950; 30003951; 30003952; 30003953 |]; position= {x = -3.337218293e+17;  y = 5.821199032e+16;  z = -2.021586548e+17;} } |> Some
      | 20000674 -> { ConstellationData.id= 20000674; name= "Phoenix"; regionId= 10000058; solarSystemIds= [| 30004617; 30004618; 30004619; 30004620; 30004621; 30004622; 30004623 |]; position= {x = -4.600988737e+17;  y = 3.96762133e+16;  z = -2.967897881e+16;} } |> Some
      | 20000771 -> { ConstellationData.id= 20000771; name= "Aven"; regionId= 10000067; solarSystemIds= [| 30005267; 30005268; 30005269; 30005270; 30005271; 30005272; 30005273; 30005274 |]; position= {x = -2.948421818e+17;  y = -4.810207007e+15;  z = -2.123374369e+16;} } |> Some
      | 21000065 -> { ConstellationData.id= 21000065; name= "B-C00065"; regionId= 11000008; solarSystemIds= [| 31000802; 31000803; 31000804; 31000805; 31000806; 31000807; 31000808; 31000809; 31000810 |]; position= {x = 7.501961769e+18;  y = 2.947652729e+16;  z = -9.60952398e+18;} } |> Some
      | 21000162 -> { ConstellationData.id= 21000162; name= "D-C00162"; regionId= 11000017; solarSystemIds= [| 31001435; 31001436; 31001437; 31001438; 31001439; 31001440 |]; position= {x = 7.738239145e+18;  y = 2.695462552e+16;  z = -9.788130127e+18;} } |> Some
      | 21000259 -> { ConstellationData.id= 21000259; name= "E-C00259"; regionId= 11000026; solarSystemIds= [| 31002084; 31002085; 31002086; 31002087; 31002088; 31002089; 31002090; 31002476 |]; position= {x = 7.758831576e+18;  y = 4.007561674e+15;  z = -8.988513133e+18;} } |> Some
      | _ -> None