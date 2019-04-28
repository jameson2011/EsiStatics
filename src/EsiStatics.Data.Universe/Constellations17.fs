namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations17=
    let getConstellation id = 
      match id with 
      | 20000059 -> { ConstellationData.id= 20000059; name= "KCR-1E"; regionId= 10000004; solarSystemIds= [| 30000408; 30000409; 30000410; 30000411; 30000412; 30000413 |]; position= {x = 9.80353623e+16;  y = 9.387941385e+16;  z = 3.574467042e+17;} } |> Some
      | 20000156 -> { ConstellationData.id= 20000156; name= "1M4-FN"; regionId= 10000013; solarSystemIds= [| 30001063; 30001064; 30001065; 30001066; 30001067; 30001068 |]; position= {x = 1.782282155e+17;  y = 7.321193066e+16;  z = 7.63141087e+16;} } |> Some
      | 20000253 -> { ConstellationData.id= 20000253; name= "Tsemshatel"; regionId= 10000020; solarSystemIds= [| 30001708; 30001709; 30001710; 30001711; 30001712; 30001713; 30001714; 30001715 |]; position= {x = -2.326710648e+17;  y = 3.364727436e+16;  z = -1.344501927e+17;} } |> Some
      | 20000350 -> { ConstellationData.id= 20000350; name= "Fittakan"; regionId= 10000028; solarSystemIds= [| 30002383; 30002384; 30002385; 30002386; 30002387; 30002388; 30002389 |]; position= {x = -5.712463228e+16;  y = 1.972622013e+16;  z = 6.614261455e+15;} } |> Some
      | 20000447 -> { ConstellationData.id= 20000447; name= "Marele"; regionId= 10000037; solarSystemIds= [| 30003057; 30003058; 30003059; 30003060; 30003061; 30003062 |]; position= {x = -2.017072986e+17;  y = -1.253301455e+16;  z = 9.296668485e+15;} } |> Some
      | 20000544 -> { ConstellationData.id= 20000544; name= "XV7L-S"; regionId= 10000047; solarSystemIds= [| 30003729; 30003730; 30003731; 30003732; 30003733; 30003734 |]; position= {x = -1.272096167e+17;  y = 4.26149436e+16;  z = -1.047615526e+17;} } |> Some
      | 20000641 -> { ConstellationData.id= 20000641; name= "KWCZ-A"; regionId= 10000055; solarSystemIds= [| 30004384; 30004385; 30004386; 30004387; 30004388; 30004389 |]; position= {x = -1.666548573e+17;  y = 7.408225648e+16;  z = 4.328294935e+17;} } |> Some
      | 20000738 -> { ConstellationData.id= 20000738; name= "Nimedaz"; regionId= 10000065; solarSystemIds= [| 30005044; 30005045; 30005046; 30005047; 30005048; 30005049; 30025042; 30035042 |]; position= {x = -2.467607748e+17;  y = 5.709010506e+16;  z = -1.011740981e+17;} } |> Some
      | 21000032 -> { ConstellationData.id= 21000032; name= "B-C00032"; regionId= 11000005; solarSystemIds= [| 31000468; 31000469; 31000470; 31000471; 31000472; 31000473; 31000474; 31000475; 31000476; 31000477; 31000478 |]; position= {x = 7.857365632e+18;  y = 2.128696766e+16;  z = -9.527636913e+18;} } |> Some
      | 21000129 -> { ConstellationData.id= 21000129; name= "C-C00129"; regionId= 11000014; solarSystemIds= [| 31001221; 31001222; 31001223; 31001224; 31001225; 31001226 |]; position= {x = 7.89340858e+18;  y = 2.067468566e+16;  z = -9.304792153e+18;} } |> Some
      | 21000226 -> { ConstellationData.id= 21000226; name= "D-C00226"; regionId= 11000022; solarSystemIds= [| 31001846; 31001847; 31001848; 31001849; 31001850; 31001851 |]; position= {x = 7.939692184e+18;  y = 3.640307626e+16;  z = -9.251515356e+18;} } |> Some
      | 21000323 -> { ConstellationData.id= 21000323; name= "A-C00323"; regionId= 11000001; solarSystemIds= [| 31000128; 31000129; 31000130; 31000131; 31000132; 31000133; 31000134; 31000135; 31000136; 31000137; 31000138; 31000139 |]; position= {x = 7.623932722e+18;  y = 1.472556792e+16;  z = -9.504813388e+18;} } |> Some
      | 22000005 -> { ConstellationData.id= 22000005; name= "ADC05"; regionId= 12000001; solarSystemIds= [| 32000033; 32000034; 32000035; 32000036; 32000037; 32000038; 32000039; 32000040 |]; position= {x = 3.23292445e+18;  y = 5.189935675e+18;  z = -5.517032468e+18;} } |> Some
      | _ -> None