namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations82=
    let getConstellation id = 
      match id with 
      | 20000027 -> { ConstellationData.id= 20000027; name= "Etsala"; regionId= 10000002; solarSystemIds= [| 30000188; 30000189; 30000190; 30000191; 30000192; 30000193; 30000194 |]; position= {x = -9.179470434e+16;  y = 7.9537338e+16;  z = 1.360239214e+17;} } |> Some
      | 20000124 -> { ConstellationData.id= 20000124; name= "1P-VL2"; regionId= 10000010; solarSystemIds= [| 30000846; 30000847; 30000848; 30000849; 30000850; 30000851 |]; position= {x = -1.489413427e+17;  y = 8.43219575e+16;  z = 1.998143572e+17;} } |> Some
      | 20000221 -> { ConstellationData.id= 20000221; name= "F-8DMX"; regionId= 10000017; solarSystemIds= [| 30001500; 30001501; 30001502; 30001503; 30001504; 30001505 |]; position= {x = 4.622110045e+16;  y = 6.459300259e+16;  z = 2.116418865e+17;} } |> Some
      | 20000318 -> { ConstellationData.id= 20000318; name= "EL8Z-M"; regionId= 10000025; solarSystemIds= [| 30002159; 30002160; 30002161; 30002162; 30002163; 30002164 |]; position= {x = 3.8867358e+16;  y = -1.643237991e+16;  z = -2.283891846e+17;} } |> Some
      | 20000415 -> { ConstellationData.id= 20000415; name= "78-6RI"; regionId= 10000034; solarSystemIds= [| 30002827; 30002828; 30002829; 30002830; 30002831; 30002832 |]; position= {x = 1.352705968e+17;  y = 7.189834643e+16;  z = 9.854679799e+16;} } |> Some
      | 20000512 -> { ConstellationData.id= 20000512; name= "Hoosa"; regionId= 10000043; solarSystemIds= [| 30003507; 30003508; 30003509; 30003510; 30003511; 30003512; 30043489 |]; position= {x = -1.942240944e+17;  y = 5.663729627e+16;  z = -4.245004894e+16;} } |> Some
      | 20000609 -> { ConstellationData.id= 20000609; name= "QJ2-0M"; regionId= 10000053; solarSystemIds= [| 30004161; 30004162; 30004163; 30004164; 30004165; 30004166 |]; position= {x = 2.734076348e+17;  y = 4.460959799e+16;  z = 1.442923861e+17;} } |> Some
      | 20000706 -> { ConstellationData.id= 20000706; name= "E-IFSA"; regionId= 10000061; solarSystemIds= [| 30004824; 30004825; 30004826; 30004827; 30004828; 30004829; 30004830 |]; position= {x = -1.202852725e+16;  y = -6.000384057e+15;  z = -2.840198454e+17;} } |> Some
      | 21000097 -> { ConstellationData.id= 21000097; name= "C-C00097"; regionId= 11000011; solarSystemIds= [| 31001014; 31001015; 31001016; 31001017; 31001018; 31001019 |]; position= {x = 7.422464777e+18;  y = 1.385651198e+16;  z = -9.43912112e+18;} } |> Some
      | 21000194 -> { ConstellationData.id= 21000194; name= "D-C00194"; regionId= 11000020; solarSystemIds= [| 31001644; 31001645; 31001646; 31001647; 31001648; 31001649 |]; position= {x = 7.420564267e+18;  y = 1.181446338e+16;  z = -9.280010913e+18;} } |> Some
      | 21000291 -> { ConstellationData.id= 21000291; name= "E-C00291"; regionId= 11000029; solarSystemIds= [| 31002320; 31002321; 31002322; 31002323; 31002324; 31002325; 31002326; 31002327; 31002328; 31002471 |]; position= {x = 7.610449539e+18;  y = 3.949515557e+15;  z = -1.0016719e+19;} } |> Some
      | _ -> None