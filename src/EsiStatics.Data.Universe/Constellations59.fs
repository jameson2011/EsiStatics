namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations59=
    let getConstellation id = 
      match id with 
      | 20000004 -> { ConstellationData.id= 20000004; name= "Kalangin"; regionId= 10000001; solarSystemIds= [| 30000023; 30000024; 30000025; 30000026; 30000027; 30000028; 30000029; 30000030 |]; position= {x = -7.07428118e+16;  y = 4.532120324e+16;  z = -4.375050451e+16;} } |> Some
      | 20000101 -> { ConstellationData.id= 20000101; name= "QI1M-Q"; regionId= 10000008; solarSystemIds= [| 30000691; 30000692; 30000693; 30000694; 30000695; 30000696 |]; position= {x = 3.795381276e+16;  y = 2.771396521e+16;  z = -1.724271648e+17;} } |> Some
      | 20000198 -> { ConstellationData.id= 20000198; name= "Okunda"; regionId= 10000016; solarSystemIds= [| 30001356; 30001357; 30001358; 30001359; 30001360; 30001361 |]; position= {x = -1.734983411e+17;  y = 1.191140834e+17;  z = 1.698570935e+17;} } |> Some
      | 20000295 -> { ConstellationData.id= 20000295; name= "U-7RBK"; regionId= 10000023; solarSystemIds= [| 30002004; 30002005; 30002006; 30002007; 30002008; 30002009 |]; position= {x = -2.191485517e+17;  y = 9.320653e+16;  z = 2.199365342e+17;} } |> Some
      | 20000392 -> { ConstellationData.id= 20000392; name= "Algintal"; regionId= 10000032; solarSystemIds= [| 30002676; 30002677; 30002678; 30002679; 30002680; 30002681; 30002682; 30002683; 30002684 |]; position= {x = -1.568693997e+17;  y = 4.604076435e+16;  z = 4.359946146e+16;} } |> Some
      | 20000489 -> { ConstellationData.id= 20000489; name= "6-V49K"; regionId= 10000041; solarSystemIds= [| 30003355; 30003356; 30003357; 30003358; 30003359; 30003360 |]; position= {x = -3.331705822e+17;  y = 5.810575097e+15;  z = 7.048168852e+16;} } |> Some
      | 20000586 -> { ConstellationData.id= 20000586; name= "3B-IWE"; regionId= 10000050; solarSystemIds= [| 30004013; 30004014; 30004015; 30004016; 30004017; 30004018 |]; position= {x = -4.084173585e+17;  y = 2.96915508e+16;  z = -2.399950747e+17;} } |> Some
      | 20000683 -> { ConstellationData.id= 20000683; name= "TCC-ZV"; regionId= 10000059; solarSystemIds= [| 30004673; 30004674; 30004675; 30004676; 30004677; 30004678 |]; position= {x = -8.780395218e+16;  y = -4.330391494e+16;  z = -4.683668897e+17;} } |> Some
      | 20000780 -> { ConstellationData.id= 20000780; name= "Aideron"; regionId= 10000068; solarSystemIds= [| 30005329; 30005330; 30005331; 30005332; 30005333; 30005334 |]; position= {x = -2.269310243e+17;  y = 5.075767361e+16;  z = 4.684266971e+16;} } |> Some
      | 21000074 -> { ConstellationData.id= 21000074; name= "B-C00074"; regionId= 11000008; solarSystemIds= [| 31000878 |]; position= {x = 7.52768712e+18;  y = 4.170552287e+16;  z = -9.599345384e+18;} } |> Some
      | 21000171 -> { ConstellationData.id= 21000171; name= "D-C00171"; regionId= 11000018; solarSystemIds= [| 31001493; 31001494; 31001495; 31001496; 31001497; 31001498; 31001499 |]; position= {x = 7.549602843e+18;  y = 1.165916434e+16;  z = -9.702996055e+18;} } |> Some
      | 21000268 -> { ConstellationData.id= 21000268; name= "E-C00268"; regionId= 11000027; solarSystemIds= [| 31002146; 31002147; 31002148; 31002149; 31002150; 31002151; 31002152; 31002153; 31002154; 31002504 |]; position= {x = 8.230245766e+18;  y = 2.340117692e+16;  z = -9.330057729e+18;} } |> Some
      | _ -> None