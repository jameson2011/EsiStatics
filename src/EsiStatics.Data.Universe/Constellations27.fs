namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations27=
    let getConstellation id = 
      match id with 
      | 20000069 -> { ConstellationData.id= 20000069; name= "1RG-GU"; regionId= 10000005; solarSystemIds= [| 30000472; 30000473; 30000474; 30000475; 30000476; 30000477; 30000478 |]; position= {x = 6.589576157e+16;  y = -2.414094653e+16;  z = -2.058694392e+17;} } |> Some
      | 20000166 -> { ConstellationData.id= 20000166; name= "MW49-U"; regionId= 10000013; solarSystemIds= [| 30001132; 30001133; 30001134; 30001135; 30001136; 30001137; 30001138; 30001139 |]; position= {x = 1.981220659e+17;  y = 8.62789083e+16;  z = 1.128840137e+17;} } |> Some
      | 20000263 -> { ConstellationData.id= 20000263; name= "NPL-WH"; regionId= 10000021; solarSystemIds= [| 30001774; 30001775; 30001776; 30001777; 30001778; 30001779; 30001780; 30001781; 30001782 |]; position= {x = 2.92719928e+17;  y = 3.726168702e+16;  z = 1.247153943e+17;} } |> Some
      | 20000360 -> { ConstellationData.id= 20000360; name= "ZYL-FT"; regionId= 10000029; solarSystemIds= [| 30002451; 30002452; 30002453; 30002454; 30002455; 30002456 |]; position= {x = -4.513748005e+16;  y = 8.118792149e+16;  z = 1.306058341e+17;} } |> Some
      | 20000457 -> { ConstellationData.id= 20000457; name= "R2-BT6"; regionId= 10000039; solarSystemIds= [| 30003125; 30003126; 30003127; 30003128; 30003129; 30003130; 30003131; 30003132 |]; position= {x = -8.170525527e+16;  y = 2.378883311e+15;  z = -4.200148839e+17;} } |> Some
      | 20000554 -> { ConstellationData.id= 20000554; name= "Fislipesnes"; regionId= 10000048; solarSystemIds= [| 30003794; 30003795; 30003796; 30003797; 30003798; 30003799 |]; position= {x = -2.68355112e+17;  y = 4.073747887e+16;  z = 5.5733307e+16;} } |> Some
      | 20000651 -> { ConstellationData.id= 20000651; name= "OFQ-HG"; regionId= 10000056; solarSystemIds= [| 30004459; 30004460; 30004461; 30004462; 30004463; 30004464 |]; position= {x = 2.222212948e+16;  y = -4.696010122e+16;  z = -4.202829078e+17;} } |> Some
      | 20000748 -> { ConstellationData.id= 20000748; name= "9BGY-6"; regionId= 10000066; solarSystemIds= [| 30005106; 30005107; 30005108; 30005109; 30005110; 30005111; 30005112; 30005113; 30005114; 30005115 |]; position= {x = 2.143873887e+17;  y = 4.733797327e+16;  z = 1.383685427e+17;} } |> Some
      | 21000042 -> { ConstellationData.id= 21000042; name= "B-C00042"; regionId= 11000006; solarSystemIds= [| 31000571; 31000572; 31000573; 31000574; 31000575; 31000576; 31000577; 31000578; 31000579 |]; position= {x = 7.827123826e+18;  y = 1.982116602e+16;  z = -9.643145958e+18;} } |> Some
      | 21000139 -> { ConstellationData.id= 21000139; name= "C-C00139"; regionId= 11000014; solarSystemIds= [| 31001285; 31001286; 31001287; 31001288; 31001289; 31001290; 31001291 |]; position= {x = 7.921063065e+18;  y = 3.487424845e+16;  z = -9.286484364e+18;} } |> Some
      | 21000236 -> { ConstellationData.id= 21000236; name= "E-C00236"; regionId= 11000024; solarSystemIds= [| 31001914; 31001915; 31001916; 31001917; 31001918; 31001919 |]; position= {x = 7.131551053e+18;  y = 3.508265828e+14;  z = -9.327736057e+18;} } |> Some
      | 21000333 -> { ConstellationData.id= 21000333; name= "H-C00333"; regionId= 11000032; solarSystemIds= [| 31002595; 31002596; 31002597; 31002598; 31002599; 31002600; 31002601; 31002602; 31002603; 31002604 |]; position= {x = 7.639127403e+18;  y = 1.669733394e+18;  z = -9.893269405e+18;} } |> Some
      | 22000015 -> { ConstellationData.id= 22000015; name= "ADC15"; regionId= 12000003; solarSystemIds= [| 32000113; 32000114; 32000115; 32000116; 32000117; 32000118; 32000119; 32000120 |]; position= {x = 4.199229927e+18;  y = 5.013087236e+18;  z = -7.67577838e+18;} } |> Some
      | _ -> None