namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations32=
    let getConstellation id = 
      match id with 
      | 20000074 -> { ConstellationData.id= 20000074; name= "4SRW-B"; regionId= 10000005; solarSystemIds= [| 30000508; 30000509; 30000510; 30000511; 30000512; 30000513 |]; position= {x = 6.851962968e+16;  y = -1.678878081e+16;  z = -2.275338576e+17;} } |> Some
      | 20000171 -> { ConstellationData.id= 20000171; name= "EM-L3K"; regionId= 10000014; solarSystemIds= [| 30001170; 30001171; 30001172; 30001173; 30001174; 30001175 |]; position= {x = -5.783971602e+16;  y = 2.001224376e+16;  z = -1.777922277e+17;} } |> Some
      | 20000268 -> { ConstellationData.id= 20000268; name= "NOB-HD"; regionId= 10000021; solarSystemIds= [| 30001811; 30001812; 30001813; 30001814; 30001815; 30001816; 30001817 |]; position= {x = 2.839657874e+17;  y = -7.61353279e+15;  z = 5.572630514e+16;} } |> Some
      | 20000365 -> { ConstellationData.id= 20000365; name= "RJ-1R7"; regionId= 10000029; solarSystemIds= [| 30002493; 30002494; 30002495; 30002496; 30002497; 30002498 |]; position= {x = -3.928206611e+16;  y = 5.601246686e+16;  z = 1.070729872e+17;} } |> Some
      | 20000462 -> { ConstellationData.id= 20000462; name= "O-PQU0"; regionId= 10000039; solarSystemIds= [| 30003163; 30003164; 30003165; 30003166; 30003167; 30003168; 30003169 |]; position= {x = -5.16780704e+16;  y = -6.012975195e+16;  z = -4.719319942e+17;} } |> Some
      | 20000559 -> { ConstellationData.id= 20000559; name= "Pegeler"; regionId= 10000048; solarSystemIds= [| 30003824; 30003825; 30003826; 30003827; 30003828; 30003829 |]; position= {x = -2.465465733e+17;  y = 1.018114818e+17;  z = 1.166788793e+17;} } |> Some
      | 20000656 -> { ConstellationData.id= 20000656; name= "Crown"; regionId= 10000057; solarSystemIds= [| 30004493; 30004494; 30004495; 30004496; 30004497; 30004498; 30004499; 30004500 |]; position= {x = -3.444972438e+17;  y = 1.935101832e+16;  z = 7.875995628e+16;} } |> Some
      | 20000753 -> { ConstellationData.id= 20000753; name= "L7-RDZ"; regionId= 10000066; solarSystemIds= [| 30005145; 30005146; 30005147; 30005148; 30005149; 30005150; 30005151 |]; position= {x = 1.982804805e+17;  y = 2.505387941e+16;  z = 1.526414523e+17;} } |> Some
      | 21000047 -> { ConstellationData.id= 21000047; name= "B-C00047"; regionId= 11000006; solarSystemIds= [| 31000623; 31000624; 31000625; 31000626; 31000627; 31000628; 31000629; 31000630; 31000631 |]; position= {x = 7.84277337e+18;  y = 4.647741698e+14;  z = -9.695859318e+18;} } |> Some
      | 21000144 -> { ConstellationData.id= 21000144; name= "C-C00144"; regionId= 11000015; solarSystemIds= [| 31001317; 31001318; 31001319; 31001320; 31001321; 31001322 |]; position= {x = 7.981196575e+18;  y = 1.653706529e+16;  z = -9.432612893e+18;} } |> Some
      | 21000241 -> { ConstellationData.id= 21000241; name= "E-C00241"; regionId= 11000024; solarSystemIds= [| 31001952; 31001953; 31001954; 31001955; 31001956; 31001957; 31001958; 31001959; 31001960 |]; position= {x = 7.158085851e+18;  y = 5.01855303e+15;  z = -9.327748337e+18;} } |> Some
      | 22000020 -> { ConstellationData.id= 22000020; name= "ADC20"; regionId= 12000004; solarSystemIds= [| 32000153; 32000154; 32000155; 32000156; 32000157; 32000158; 32000159; 32000160 |]; position= {x = 4.324001106e+18;  y = 5.197060067e+18;  z = -6.012646307e+18;} } |> Some
      | _ -> None