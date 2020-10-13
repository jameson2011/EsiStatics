namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations21=
    let getConstellation id = 
      match id with 
      | 20000063 -> { ConstellationData.id= 20000063; name= "GJH-1C"; regionId= 10000005; solarSystemIds= [| 30000433; 30000434; 30000435; 30000436; 30000437; 30000438; 30000439 |]; position= {x = 9.561642601e+16;  y = -3.15150328e+16;  z = -1.647488648e+17;} } |> Some
      | 20000160 -> { ConstellationData.id= 20000160; name= "PFL-QY"; regionId= 10000013; solarSystemIds= [| 30001091; 30001092; 30001093; 30001094; 30001095; 30001096 |]; position= {x = 1.841960381e+17;  y = 7.672571824e+16;  z = 4.631136322e+16;} } |> Some
      | 20000257 -> { ConstellationData.id= 20000257; name= "Peges"; regionId= 10000020; solarSystemIds= [| 30001735; 30001736; 30001737; 30001738; 30001739; 30001740; 30001741; 30001742 |]; position= {x = -2.068958639e+17;  y = 5.52001587e+16;  z = -1.4073302e+17;} } |> Some
      | 20000354 -> { ConstellationData.id= 20000354; name= "Eoldulf"; regionId= 10000028; solarSystemIds= [| 30002408; 30002409; 30002410; 30002412; 30002413 |]; position= {x = -1.431959497e+16;  y = -3.718163042e+15;  z = 4.605796255e+15;} } |> Some
      | 20000451 -> { ConstellationData.id= 20000451; name= "Tandoiras"; regionId= 10000038; solarSystemIds= [| 30003086; 30003087; 30003088; 30003089; 30003090; 30003091 |]; position= {x = -1.645070679e+17;  y = 1.703819912e+15;  z = -3.286158151e+16;} } |> Some
      | 20000548 -> { ConstellationData.id= 20000548; name= "UD-ZJ3"; regionId= 10000047; solarSystemIds= [| 30003754; 30003755; 30003756; 30003757; 30003758; 30003759 |]; position= {x = -1.239151626e+17;  y = 3.110911272e+16;  z = -1.670790299e+17;} } |> Some
      | 20000645 -> { ConstellationData.id= 20000645; name= "AV-SCL"; regionId= 10000056; solarSystemIds= [| 30004410; 30004411; 30004412; 30004413; 30004414; 30004415; 30004416; 30004417 |]; position= {x = 2.605131419e+15;  y = -4.131808092e+16;  z = -3.750181804e+17;} } |> Some
      | 20000742 -> { ConstellationData.id= 20000742; name= "Orus"; regionId= 10000065; solarSystemIds= [| 30005069; 30005070; 30005071; 30005072; 30005073; 30005074; 30005075 |]; position= {x = -2.335218526e+17;  y = 8.425237759e+16;  z = -9.477974124e+16;} } |> Some
      | 21000036 -> { ConstellationData.id= 21000036; name= "B-C00036"; regionId= 11000005; solarSystemIds= [| 31000508; 31000509; 31000510; 31000511; 31000512; 31000513; 31000514; 31000515; 31000516; 31000517; 31000518 |]; position= {x = 7.903443974e+18;  y = 2.123496527e+16;  z = -9.539490911e+18;} } |> Some
      | 21000133 -> { ConstellationData.id= 21000133; name= "C-C00133"; regionId= 11000014; solarSystemIds= [| 31001247; 31001248; 31001249; 31001250; 31001251; 31001252; 31001253 |]; position= {x = 7.920402928e+18;  y = 2.65024508e+15;  z = -9.294086027e+18;} } |> Some
      | 21000230 -> { ConstellationData.id= 21000230; name= "D-C00230"; regionId= 11000023; solarSystemIds= [| 31001871; 31001872; 31001873; 31001874; 31001875; 31001876 |]; position= {x = 8.050410327e+18;  y = 1.807458903e+16;  z = -9.697441691e+18;} } |> Some
      | 21000327 -> { ConstellationData.id= 21000327; name= "C-C00327"; regionId= 11000009; solarSystemIds= [| 31002527; 31002528; 31002529; 31002530; 31002531; 31002532; 31002533; 31002534; 31002535; 31002536; 31002537 |]; position= {x = 7.747916765e+18;  y = 1.569538314e+18;  z = -9.931674178e+18;} } |> Some
      | 22000009 -> { ConstellationData.id= 22000009; name= "ADC09"; regionId= 12000002; solarSystemIds= [| 32000065; 32000066; 32000067; 32000068; 32000069; 32000070; 32000071; 32000072 |]; position= {x = 4.692558026e+18;  y = 4.38642186e+18;  z = -5.341203161e+18;} } |> Some
      | _ -> None