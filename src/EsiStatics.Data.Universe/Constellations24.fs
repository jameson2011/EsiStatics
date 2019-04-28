namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations24=
    let getConstellation id = 
      match id with 
      | 20000066 -> { ConstellationData.id= 20000066; name= "5F8-PZ"; regionId= 10000005; solarSystemIds= [| 30000454; 30000455; 30000456; 30000457; 30000458; 30000459 |]; position= {x = 1.248744967e+17;  y = -2.980202246e+16;  z = -1.660054038e+17;} } |> Some
      | 20000163 -> { ConstellationData.id= 20000163; name= "G-HISF"; regionId= 10000013; solarSystemIds= [| 30001109; 30001110; 30001111; 30001112; 30001113; 30001114; 30001115; 30001116 |]; position= {x = 1.911947657e+17;  y = 4.322187509e+16;  z = 5.138743888e+16;} } |> Some
      | 20000260 -> { ConstellationData.id= 20000260; name= "J33-JR"; regionId= 10000021; solarSystemIds= [| 30001755; 30001756; 30001757; 30001758; 30001759; 30001760; 30001761 |]; position= {x = 3.005382946e+17;  y = -5.743194088e+16;  z = 2.909606417e+16;} } |> Some
      | 20000357 -> { ConstellationData.id= 20000357; name= "UBPU-9"; regionId= 10000029; solarSystemIds= [| 30002428; 30002429; 30002430; 30002431; 30002432; 30002433; 30002434; 30002435; 30002436; 30002437 |]; position= {x = -4.221469572e+16;  y = 5.388774602e+16;  z = 1.197629538e+17;} } |> Some
      | 20000454 -> { ConstellationData.id= 20000454; name= "8T-OLH"; regionId= 10000039; solarSystemIds= [| 30003105; 30003106; 30003107; 30003108; 30003109; 30003110; 30003111; 30003112 |]; position= {x = -8.956342603e+16;  y = 4.956110518e+15;  z = -3.916920794e+17;} } |> Some
      | 20000551 -> { ConstellationData.id= 20000551; name= "H-KW4A"; regionId= 10000047; solarSystemIds= [| 30003774; 30003775; 30003776; 30003777; 30003778; 30003779; 30003780 |]; position= {x = -1.458635399e+17;  y = 8.588219008e+16;  z = -1.722991928e+17;} } |> Some
      | 20000648 -> { ConstellationData.id= 20000648; name= "L-H07K"; regionId= 10000056; solarSystemIds= [| 30004436; 30004437; 30004438; 30004439; 30004440; 30004441; 30004442 |]; position= {x = 3.915777157e+16;  y = -5.53199514e+15;  z = -3.509904102e+17;} } |> Some
      | 20000745 -> { ConstellationData.id= 20000745; name= "NT1-5Q"; regionId= 10000066; solarSystemIds= [| 30005088; 30005089; 30005090; 30005091; 30005092; 30005093 |]; position= {x = 1.942452085e+17;  y = 5.214989838e+16;  z = 1.144183282e+17;} } |> Some
      | 21000039 -> { ConstellationData.id= 21000039; name= "B-C00039"; regionId= 11000005; solarSystemIds= [| 31000539; 31000540; 31000541; 31000542; 31000543; 31000544; 31000545; 31000546; 31000547; 31000548; 31000549 |]; position= {x = 7.909435044e+18;  y = 6.151667313e+15;  z = -9.51784348e+18;} } |> Some
      | 21000136 -> { ConstellationData.id= 21000136; name= "C-C00136"; regionId= 11000014; solarSystemIds= [| 31001267; 31001268; 31001269; 31001270; 31001271; 31001272 |]; position= {x = 7.917667967e+18;  y = 4.485673912e+15;  z = -9.292382187e+18;} } |> Some
      | 21000233 -> { ConstellationData.id= 21000233; name= "E-C00233"; regionId= 11000024; solarSystemIds= [| 31001889; 31001890; 31001891; 31001892; 31001893; 31001894; 31001895; 31001896; 31001897; 31002486 |]; position= {x = 7.109546491e+18;  y = 2.910705183e+16;  z = -9.372355596e+18;} } |> Some
      | 21000330 -> { ConstellationData.id= 21000330; name= "F-C00330"; regionId= 11000030; solarSystemIds= [| 31002575; 31002576; 31002577; 31002578; 31002579 |]; position= {x = 7.326291376e+18;  y = 1.524155971e+18;  z = -9.927218756e+18;} } |> Some
      | 22000012 -> { ConstellationData.id= 22000012; name= "ADC12"; regionId= 12000003; solarSystemIds= [| 32000089; 32000090; 32000091; 32000092; 32000093; 32000094; 32000095; 32000096 |]; position= {x = 4.103853795e+18;  y = 4.877644132e+18;  z = -7.600358085e+18;} } |> Some
      | _ -> None