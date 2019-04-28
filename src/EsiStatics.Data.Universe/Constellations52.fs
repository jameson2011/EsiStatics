namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations52=
    let getConstellation id = 
      match id with 
      | 20000094 -> { ConstellationData.id= 20000094; name= "FQ-COP"; regionId= 10000007; solarSystemIds= [| 30000643; 30000644; 30000645; 30000646; 30000647; 30000648 |]; position= {x = 3.055039627e+17;  y = -4.213149003e+16;  z = -8.826306979e+16;} } |> Some
      | 20000191 -> { ConstellationData.id= 20000191; name= "XHYS-O"; regionId= 10000015; solarSystemIds= [| 30001309; 30001310; 30001311; 30001312; 30001313; 30001314 |]; position= {x = -1.581808427e+17;  y = 1.026042945e+17;  z = 3.599093584e+17;} } |> Some
      | 20000288 -> { ConstellationData.id= 20000288; name= "R-IZDC"; regionId= 10000022; solarSystemIds= [| 30001956; 30001957; 30001958; 30001959; 30001960; 30001961; 30001962 |]; position= {x = -2.208960707e+17;  y = 7.937127263e+16;  z = -2.776924872e+17;} } |> Some
      | 20000385 -> { ConstellationData.id= 20000385; name= "QZJ-FL"; regionId= 10000031; solarSystemIds= [| 30002626; 30002627; 30002628; 30002629; 30002630; 30002631 |]; position= {x = -3.09401811e+16;  y = 2.684797261e+16;  z = -3.425917369e+17;} } |> Some
      | 20000482 -> { ConstellationData.id= 20000482; name= "TA-A7V"; regionId= 10000041; solarSystemIds= [| 30003301; 30003302; 30003303; 30003304; 30003305; 30003306; 30003307; 30003308 |]; position= {x = -2.923287948e+17;  y = 3.905112442e+16;  z = 3.670118486e+16;} } |> Some
      | 20000579 -> { ConstellationData.id= 20000579; name= "A-Z7C9"; regionId= 10000050; solarSystemIds= [| 30003962; 30003963; 30003964; 30003965; 30003966; 30003967 |]; position= {x = -3.609640187e+17;  y = 5.355659625e+16;  z = -1.916681556e+17;} } |> Some
      | 20000676 -> { ConstellationData.id= 20000676; name= "Griffin"; regionId= 10000058; solarSystemIds= [| 30004630; 30004631; 30004632; 30004633; 30004634; 30004635 |]; position= {x = -4.554446349e+17;  y = 5.407995048e+16;  z = -3.778862805e+16;} } |> Some
      | 20000773 -> { ConstellationData.id= 20000773; name= "EVE"; regionId= 10000067; solarSystemIds= [| 30005281; 30005282; 30005283; 30005284; 30005285; 30005286; 30005287 |]; position= {x = -2.779144722e+17;  y = -1.976269928e+16;  z = -5.414420075e+16;} } |> Some
      | 21000067 -> { ConstellationData.id= 21000067; name= "B-C00067"; regionId= 11000008; solarSystemIds= [| 31000823; 31000824; 31000825; 31000826; 31000827; 31000828; 31000829; 31000830; 31000831; 31000832; 31000833; 31000834 |]; position= {x = 7.500223479e+18;  y = 1.066521728e+16;  z = -9.668271209e+18;} } |> Some
      | 21000164 -> { ConstellationData.id= 21000164; name= "D-C00164"; regionId= 11000017; solarSystemIds= [| 31001448; 31001449; 31001450; 31001451; 31001452; 31001453 |]; position= {x = 7.773050394e+18;  y = 9.158676996e+15;  z = -9.776935687e+18;} } |> Some
      | 21000261 -> { ConstellationData.id= 21000261; name= "E-C00261"; regionId= 11000026; solarSystemIds= [| 31002099; 31002100; 31002101; 31002102; 31002103; 31002104; 31002105; 31002106; 31002493 |]; position= {x = 7.70533165e+18;  y = 2.744031084e+16;  z = -9.021184439e+18;} } |> Some
      | _ -> None