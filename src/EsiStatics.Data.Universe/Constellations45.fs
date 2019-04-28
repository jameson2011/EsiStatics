namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations45=
    let getConstellation id = 
      match id with 
      | 20000087 -> { ConstellationData.id= 20000087; name= "4-QV2L"; regionId= 10000006; solarSystemIds= [| 30000599; 30000600; 30000601; 30000602; 30000603; 30000604 |]; position= {x = 8.335422955e+16;  y = 2.186316305e+16;  z = -1.805820769e+17;} } |> Some
      | 20000184 -> { ConstellationData.id= 20000184; name= "1G-8KY"; regionId= 10000015; solarSystemIds= [| 30001261; 30001262; 30001263; 30001264; 30001265; 30001266; 30001267 |]; position= {x = -1.707017678e+17;  y = 1.110760508e+17;  z = 2.54829097e+17;} } |> Some
      | 20000281 -> { ConstellationData.id= 20000281; name= "Q4IG-S"; regionId= 10000022; solarSystemIds= [| 30001899; 30001900; 30001901; 30001902; 30001903; 30001904 |]; position= {x = -1.812608032e+17;  y = 6.853668965e+16;  z = -3.15579728e+17;} } |> Some
      | 20000378 -> { ConstellationData.id= 20000378; name= "Benurad"; regionId= 10000030; solarSystemIds= [| 30002574; 30002575; 30002576; 30002577; 30002578; 30002579; 30002580 |]; position= {x = -6.298554177e+16;  y = 5.117709237e+15;  z = 4.190675083e+16;} } |> Some
      | 20000475 -> { ConstellationData.id= 20000475; name= "D61-WV"; regionId= 10000040; solarSystemIds= [| 30003249; 30003250; 30003251; 30003252; 30003253; 30003254 |]; position= {x = 2.091506657e+17;  y = 9.117208685e+16;  z = 7.069687024e+16;} } |> Some
      | 20000572 -> { ConstellationData.id= 20000572; name= "Akar"; regionId= 10000049; solarSystemIds= [| 30003917; 30003918; 30003919; 30003920; 30003921; 30003922 |]; position= {x = -3.363328708e+17;  y = 2.978340276e+16;  z = -1.428698109e+17;} } |> Some
      | 20000669 -> { ConstellationData.id= 20000669; name= "Centaur"; regionId= 10000058; solarSystemIds= [| 30004584; 30004585; 30004586; 30004587; 30004588; 30004589 |]; position= {x = -4.301518286e+17;  y = 4.796805892e+16;  z = 5.223675532e+16;} } |> Some
      | 20000766 -> { ConstellationData.id= 20000766; name= "Meli"; regionId= 10000067; solarSystemIds= [| 30005236; 30005237; 30005238; 30005239; 30005240; 30005241; 30005242 |]; position= {x = -2.732846433e+17;  y = 1.876694326e+16;  z = -5.326663225e+16;} } |> Some
      | 21000060 -> { ConstellationData.id= 21000060; name= "B-C00060"; regionId= 11000008; solarSystemIds= [| 31000752; 31000753; 31000754; 31000755; 31000756; 31000757; 31000758; 31000759; 31000760; 31000761 |]; position= {x = 7.530665461e+18;  y = 2.704060054e+16;  z = -9.628359604e+18;} } |> Some
      | 21000157 -> { ConstellationData.id= 21000157; name= "D-C00157"; regionId= 11000016; solarSystemIds= [| 31001403; 31001404; 31001405; 31001406; 31001407; 31001408; 31001409 |]; position= {x = 7.983185022e+18;  y = 3.263870197e+16;  z = -9.625904852e+18;} } |> Some
      | 21000254 -> { ConstellationData.id= 21000254; name= "E-C00254"; regionId= 11000025; solarSystemIds= [| 31002048; 31002049; 31002050; 31002051; 31002052; 31002053; 31002054; 31002482 |]; position= {x = 7.346417597e+18;  y = 1.02903121e+16;  z = -9.135958183e+18;} } |> Some
      | _ -> None