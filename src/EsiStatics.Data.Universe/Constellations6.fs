namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations6=
    let getConstellation id = 
      match id with 
      | 20000048 -> { ConstellationData.id= 20000048; name= "J-4QD7"; regionId= 10000004; solarSystemIds= [| 30000334; 30000335; 30000336; 30000337; 30000338; 30000339 |]; position= {x = 8.223505728e+16;  y = 6.876394372e+16;  z = 1.934689527e+17;} } |> Some
      | 20000145 -> { ConstellationData.id= 20000145; name= "W-3Y6D"; regionId= 10000011; solarSystemIds= [| 30000989; 30000990; 30000991; 30000992; 30000993; 30000994 |]; position= {x = 1.869032802e+16;  y = 1.674128417e+16;  z = -1.070872521e+17;} } |> Some
      | 20000242 -> { ConstellationData.id= 20000242; name= "F-0CTG"; regionId= 10000019; solarSystemIds= [| 30001637; 30001638; 30001639; 30001640; 30001641; 30001642; 30001643 |]; position= {x = 5.37647061e+15;  y = 7.464556573e+16;  z = 3.339992701e+17;} } |> Some
      | 20000339 -> { ConstellationData.id= 20000339; name= "8G-JN6"; regionId= 10000027; solarSystemIds= [| 30002311; 30002312; 30002313; 30002314; 30002315; 30002316 |]; position= {x = 1.157899095e+17;  y = 7.085434854e+16;  z = 3.671140534e+16;} } |> Some
      | 20000436 -> { ConstellationData.id= 20000436; name= "Jayai"; regionId= 10000036; solarSystemIds= [| 30002975; 30002976; 30002977; 30002978; 30002979; 30002980; 30002981 |]; position= {x = -1.535974281e+17;  y = 4.622043691e+16;  z = -3.590949906e+16;} } |> Some
      | 20000533 -> { ConstellationData.id= 20000533; name= "O-EOI9"; regionId= 10000045; solarSystemIds= [| 30003658; 30003659; 30003660; 30003661; 30003662; 30003663 |]; position= {x = -1.054719758e+17;  y = 2.777402687e+16;  z = 4.445014406e+17;} } |> Some
      | 20000630 -> { ConstellationData.id= 20000630; name= "JE7-F2"; regionId= 10000055; solarSystemIds= [| 30004310; 30004311; 30004312; 30004313; 30004314; 30004315; 30004316 |]; position= {x = -1.214999268e+17;  y = 8.793066796e+16;  z = 3.574290478e+17;} } |> Some
      | 20000727 -> { ConstellationData.id= 20000727; name= "Crux"; regionId= 10000064; solarSystemIds= [| 30004967; 30004968; 30004969; 30004970; 30004971; 30004972; 30014971 |]; position= {x = -1.995433022e+17;  y = 4.351474712e+16;  z = 2.787787726e+16;} } |> Some
      | 21000021 -> { ConstellationData.id= 21000021; name= "B-C00021"; regionId= 11000004; solarSystemIds= [| 31000355; 31000356; 31000357; 31000358; 31000359; 31000360; 31000361; 31000362; 31000363 |]; position= {x = 7.786979336e+18;  y = 1.132839463e+15;  z = -9.362063934e+18;} } |> Some
      | 21000118 -> { ConstellationData.id= 21000118; name= "C-C00118"; regionId= 11000012; solarSystemIds= [| 31001152; 31001153; 31001154; 31001155; 31001156; 31001157 |]; position= {x = 7.49320098e+18;  y = 2.53547531e+16;  z = -9.292820349e+18;} } |> Some
      | 21000215 -> { ConstellationData.id= 21000215; name= "D-C00215"; regionId= 11000022; solarSystemIds= [| 31001777; 31001778; 31001779; 31001780; 31001781; 31001782 |]; position= {x = 7.976860289e+18;  y = 2.565158336e+15;  z = -9.171005185e+18;} } |> Some
      | 21000312 -> { ConstellationData.id= 21000312; name= "A-C00312"; regionId= 11000001; solarSystemIds= [| 31000013; 31000014; 31000015; 31000016; 31000017; 31000018; 31000019; 31000020; 31000021; 31000022; 31000023; 31000024 |]; position= {x = 7.641670689e+18;  y = 1.999664996e+16;  z = -9.480867103e+18;} } |> Some
      | _ -> None