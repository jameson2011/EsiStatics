namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations90=
    let getConstellation id = 
      match id with 
      | 20000035 -> { ConstellationData.id= 20000035; name= "Z-DO53"; regionId= 10000003; solarSystemIds= [| 30000244; 30000245; 30000246; 30000247; 30000248; 30000249; 30000250; 30000251; 30000252; 30000253 |]; position= {x = -9.597904777e+16;  y = 9.11042434e+16;  z = 1.879890644e+17;} } |> Some
      | 20000132 -> { ConstellationData.id= 20000132; name= "730-KH"; regionId= 10000011; solarSystemIds= [| 30000900; 30000901; 30000902; 30000903; 30000904; 30000905 |]; position= {x = 2.035895699e+16;  y = 1.177210911e+16;  z = -7.395968812e+16;} } |> Some
      | 20000229 -> { ConstellationData.id= 20000229; name= "4-0VL9"; regionId= 10000018; solarSystemIds= [| 30001554; 30001555; 30001556; 30001557; 30001558; 30001559; 30001560 |]; position= {x = 2.083673253e+17;  y = 3.923476486e+16;  z = 4.266477638e+16;} } |> Some
      | 20000326 -> { ConstellationData.id= 20000326; name= "Kekah"; regionId= 10000043; solarSystemIds= [| 30002220; 30002221; 30002222; 30002223; 30002224 |]; position= {x = -1.57797883e+17;  y = 7.053489948e+16;  z = -9.938008023e+16;} } |> Some
      | 20000423 -> { ConstellationData.id= 20000423; name= "2Q-8WA"; regionId= 10000034; solarSystemIds= [| 30002881; 30002882; 30002883; 30002884; 30002885; 30002886; 30002887; 30002888 |]; position= {x = 1.571731705e+17;  y = 2.829017953e+16;  z = 1.300389721e+17;} } |> Some
      | 20000520 -> { ConstellationData.id= 20000520; name= "Braille"; regionId= 10000044; solarSystemIds= [| 30003565; 30003566; 30003567; 30003568; 30003569; 30003570; 30003571; 30003572 |]; position= {x = -3.184982408e+17;  y = 4.589614147e+16;  z = 2.438552633e+16;} } |> Some
      | 20000617 -> { ConstellationData.id= 20000617; name= "5ZAB-N"; regionId= 10000053; solarSystemIds= [| 30004215; 30004216; 30004217; 30004218; 30004219; 30004220; 30004221 |]; position= {x = 2.880834339e+17;  y = 7.363963585e+16;  z = 2.540277765e+17;} } |> Some
      | 20000714 -> { ConstellationData.id= 20000714; name= "W-3E44"; regionId= 10000061; solarSystemIds= [| 30004878; 30004879; 30004880; 30004881; 30004882; 30004883 |]; position= {x = 1.259331223e+17;  y = -2.275993386e+16;  z = -3.295130024e+17;} } |> Some
      | 21000008 -> { ConstellationData.id= 21000008; name= "A-C00008"; regionId= 11000002; solarSystemIds= [| 31000215; 31000216; 31000217; 31000218; 31000219; 31000220; 31000221; 31000222; 31000223; 31000224; 31000225; 31000226 |]; position= {x = 7.640357706e+18;  y = 2.749077283e+16;  z = -9.426484172e+18;} } |> Some
      | 21000105 -> { ConstellationData.id= 21000105; name= "C-C00105"; regionId= 11000011; solarSystemIds= [| 31001066; 31001067; 31001068; 31001069; 31001070; 31001071; 31001072 |]; position= {x = 7.4354084e+18;  y = 1.280938145e+16;  z = -9.422836669e+18;} } |> Some
      | 21000202 -> { ConstellationData.id= 21000202; name= "D-C00202"; regionId= 11000021; solarSystemIds= [| 31001695; 31001696; 31001697; 31001698; 31001699; 31001700 |]; position= {x = 7.539116834e+18;  y = 2.91774241e+16;  z = -9.102446286e+18;} } |> Some
      | 21000299 -> { ConstellationData.id= 21000299; name= "F-C00299"; regionId= 11000030; solarSystemIds= [| 31002380; 31002381; 31002382; 31002383; 31002384; 31002385; 31002386; 31002387; 31002388; 31002478; 31002502 |]; position= {x = 7.275112663e+18;  y = 1.779483917e+16;  z = -9.875033608e+18;} } |> Some
      | _ -> None