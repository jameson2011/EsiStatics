namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations57=
    let getConstellation id = 
      match id with 
      | 20000002 -> { ConstellationData.id= 20000002; name= "Anares"; regionId= 10000001; solarSystemIds= [| 30000009; 30000010; 30000011; 30000012; 30000013; 30000014; 30000015; 30000016 |]; position= {x = -7.918127082e+16;  y = 5.972176602e+16;  z = -8.576756362e+16;} } |> Some
      | 20000099 -> { ConstellationData.id= 20000099; name= "ENP-SH"; regionId= 10000008; solarSystemIds= [| 30000678; 30000679; 30000680; 30000681; 30000682; 30000683; 30000684 |]; position= {x = 8.117497874e+16;  y = 1.21541967e+16;  z = -1.300549695e+17;} } |> Some
      | 20000196 -> { ConstellationData.id= 20000196; name= "0HD-6C"; regionId= 10000015; solarSystemIds= [| 30001344; 30001345; 30001346; 30001347; 30001348; 30001349 |]; position= {x = -7.227289973e+16;  y = 1.158710852e+17;  z = 3.557203655e+17;} } |> Some
      | 20000293 -> { ConstellationData.id= 20000293; name= "WMP-OF"; regionId= 10000023; solarSystemIds= [| 30001991; 30001992; 30001993; 30001994; 30001995; 30001996; 30001997 |]; position= {x = -2.650462018e+17;  y = 1.057966425e+17;  z = 2.358461102e+17;} } |> Some
      | 20000390 -> { ConstellationData.id= 20000390; name= "Firille"; regionId= 10000032; solarSystemIds= [| 30002662; 30002663; 30002664; 30002665; 30002666; 30002667 |]; position= {x = -1.65439877e+17;  y = 2.217851975e+16;  z = 1.863201688e+16;} } |> Some
      | 20000487 -> { ConstellationData.id= 20000487; name= "59H-0G"; regionId= 10000041; solarSystemIds= [| 30003342; 30003343; 30003344; 30003345; 30003346; 30003347; 30003348 |]; position= {x = -3.51213484e+17;  y = 3.448241259e+16;  z = 6.983416989e+16;} } |> Some
      | 20000584 -> { ConstellationData.id= 20000584; name= "8ET-D1"; regionId= 10000050; solarSystemIds= [| 30003996; 30003997; 30003998; 30003999; 30004000; 30004001; 30004002 |]; position= {x = -3.486913865e+17;  y = 1.709956398e+16;  z = -2.380755603e+17;} } |> Some
      | 20000681 -> { ConstellationData.id= 20000681; name= "Basilisk"; regionId= 10000058; solarSystemIds= [| 30004661; 30004662; 30004663; 30004664; 30004665; 30004666 |]; position= {x = -5.032186148e+17;  y = 1.572378733e+16;  z = -6.42854934e+16;} } |> Some
      | 20000778 -> { ConstellationData.id= 20000778; name= "Obray"; regionId= 10000068; solarSystemIds= [| 30005315; 30005316; 30005317; 30005318; 30005319; 30005320; 30005321; 30035305; 30045305 |]; position= {x = -2.42369263e+17;  y = 4.788626325e+16;  z = 4.924346958e+16;} } |> Some
      | 21000072 -> { ConstellationData.id= 21000072; name= "B-C00072"; regionId= 11000008; solarSystemIds= [| 31000876 |]; position= {x = 7.533746882e+18;  y = -1.938945429e+16;  z = -9.610307857e+18;} } |> Some
      | 21000169 -> { ConstellationData.id= 21000169; name= "D-C00169"; regionId= 11000018; solarSystemIds= [| 31001479; 31001480; 31001481; 31001482; 31001483; 31001484; 31001485 |]; position= {x = 7.549767539e+18;  y = 8.760516835e+15;  z = -9.673956031e+18;} } |> Some
      | 21000266 -> { ConstellationData.id= 21000266; name= "E-C00266"; regionId= 11000027; solarSystemIds= [| 31002134; 31002135; 31002136; 31002137; 31002138; 31002139 |]; position= {x = 8.128353204e+18;  y = 1.816141265e+16;  z = -9.299895675e+18;} } |> Some
      | _ -> None