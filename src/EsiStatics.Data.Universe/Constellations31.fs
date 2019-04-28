namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations31=
    let getConstellation id = 
      match id with 
      | 20000073 -> { ConstellationData.id= 20000073; name= "T875-C"; regionId= 10000005; solarSystemIds= [| 30000500; 30000501; 30000502; 30000503; 30000504; 30000505; 30000506; 30000507 |]; position= {x = 8.181163133e+16;  y = -5.072033205e+16;  z = -2.100974527e+17;} } |> Some
      | 20000170 -> { ConstellationData.id= 20000170; name= "N-OGI1"; regionId= 10000014; solarSystemIds= [| 30001163; 30001164; 30001165; 30001166; 30001167; 30001168; 30001169 |]; position= {x = -5.0385963e+16;  y = 6.882943397e+13;  z = -2.060099031e+17;} } |> Some
      | 20000267 -> { ConstellationData.id= 20000267; name= "2FYX-H"; regionId= 10000021; solarSystemIds= [| 30001805; 30001806; 30001807; 30001808; 30001809; 30001810 |]; position= {x = 3.020315101e+17;  y = 1.158139072e+16;  z = 8.823685741e+16;} } |> Some
      | 20000364 -> { ConstellationData.id= 20000364; name= "KR-XF4"; regionId= 10000029; solarSystemIds= [| 30002481; 30002482; 30002483; 30002484; 30002485; 30002486; 30002487; 30002488; 30002489; 30002490; 30002491; 30002492 |]; position= {x = 6.76694249e+15;  y = 9.60143828e+16;  z = 9.383107819e+16;} } |> Some
      | 20000461 -> { ConstellationData.id= 20000461; name= "AJG-MV"; regionId= 10000039; solarSystemIds= [| 30003154; 30003155; 30003156; 30003157; 30003158; 30003159; 30003160; 30003161; 30003162 |]; position= {x = -7.853705173e+16;  y = -3.116484076e+15;  z = -4.515693077e+17;} } |> Some
      | 20000558 -> { ConstellationData.id= 20000558; name= "Ganoure"; regionId= 10000048; solarSystemIds= [| 30003818; 30003819; 30003820; 30003821; 30003822; 30003823 |]; position= {x = -2.941538474e+17;  y = 4.726675995e+16;  z = 5.547251846e+16;} } |> Some
      | 20000655 -> { ConstellationData.id= 20000655; name= "3-PC31"; regionId= 10000056; solarSystemIds= [| 30004487; 30004488; 30004489; 30004490; 30004491; 30004492 |]; position= {x = 2.573506206e+16;  y = -3.92574421e+16;  z = -4.674426808e+17;} } |> Some
      | 20000752 -> { ConstellationData.id= 20000752; name= "BXT7-V"; regionId= 10000066; solarSystemIds= [| 30005139; 30005140; 30005141; 30005142; 30005143; 30005144 |]; position= {x = 2.114570167e+17;  y = 3.776085536e+16;  z = 9.775177863e+16;} } |> Some
      | 21000046 -> { ConstellationData.id= 21000046; name= "B-C00046"; regionId= 11000006; solarSystemIds= [| 31000614; 31000615; 31000616; 31000617; 31000618; 31000619; 31000620; 31000621; 31000622 |]; position= {x = 7.814662155e+18;  y = -1.273340089e+15;  z = -9.669064693e+18;} } |> Some
      | 21000143 -> { ConstellationData.id= 21000143; name= "C-C00143"; regionId= 11000014; solarSystemIds= [| 31001311; 31001312; 31001313; 31001314; 31001315; 31001316 |]; position= {x = 7.91285494e+18;  y = 7.684485113e+15;  z = -9.285136057e+18;} } |> Some
      | 21000240 -> { ConstellationData.id= 21000240; name= "E-C00240"; regionId= 11000024; solarSystemIds= [| 31001943; 31001944; 31001945; 31001946; 31001947; 31001948; 31001949; 31001950; 31001951 |]; position= {x = 7.164453399e+18;  y = 3.233954493e+16;  z = -9.378089399e+18;} } |> Some
      | 22000019 -> { ConstellationData.id= 22000019; name= "ADC19"; regionId= 12000004; solarSystemIds= [| 32000145; 32000146; 32000147; 32000148; 32000149; 32000150; 32000151; 32000152 |]; position= {x = 4.230506544e+18;  y = 5.134139596e+18;  z = -6.168340022e+18;} } |> Some
      | _ -> None