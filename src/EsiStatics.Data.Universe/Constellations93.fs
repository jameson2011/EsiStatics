namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations93=
    let getConstellation id = 
      match id with 
      | 20000038 -> { ConstellationData.id= 20000038; name= "UK-MI6"; regionId= 10000003; solarSystemIds= [| 30000268; 30000269; 30000270; 30000271; 30000272; 30000273 |]; position= {x = -5.245840737e+16;  y = 1.167440246e+17;  z = 1.619399026e+17;} } |> Some
      | 20000135 -> { ConstellationData.id= 20000135; name= "V-LQBF"; regionId= 10000011; solarSystemIds= [| 30000918; 30000919; 30000920; 30000921; 30000922; 30000923; 30000924; 30000925; 30000926 |]; position= {x = 1.936803333e+16;  y = 1.297987098e+16;  z = -1.073938663e+17;} } |> Some
      | 20000232 -> { ConstellationData.id= 20000232; name= "P-FL48"; regionId= 10000018; solarSystemIds= [| 30001574; 30001575; 30001576; 30001577; 30001578; 30001579 |]; position= {x = 2.603410979e+17;  y = -2.6450941e+15;  z = 4.964030059e+16;} } |> Some
      | 20000329 -> { ConstellationData.id= 20000329; name= "Mulata"; regionId= 10000043; solarSystemIds= [| 30002242; 30002243; 30002244; 30002245; 30002246; 30002247; 30002248; 30002249; 30002250 |]; position= {x = -2.359448315e+17;  y = 2.63049135e+16;  z = -7.033359556e+16;} } |> Some
      | 20000426 -> { ConstellationData.id= 20000426; name= "VW7-YN"; regionId= 10000035; solarSystemIds= [| 30002902; 30002903; 30002904; 30002905; 30002906; 30002907 |]; position= {x = -2.461855296e+17;  y = 7.369370507e+16;  z = 2.820748618e+17;} } |> Some
      | 20000523 -> { ConstellationData.id= 20000523; name= "Goins"; regionId= 10000044; solarSystemIds= [| 30003588; 30003589; 30003590; 30003591; 30003592; 30003593 |]; position= {x = -3.218144049e+17;  y = 4.650554639e+15;  z = 1.097016814e+16;} } |> Some
      | 20000620 -> { ConstellationData.id= 20000620; name= "Afinoo"; regionId= 10000054; solarSystemIds= [| 30004236; 30004237; 30004238; 30004239; 30004240; 30004241 |]; position= {x = -3.466537804e+17;  y = 2.856728327e+16;  z = -5.115067039e+16;} } |> Some
      | 20000717 -> { ConstellationData.id= 20000717; name= "5Z0Y-S"; regionId= 10000062; solarSystemIds= [| 30004898; 30004899; 30004900; 30004901; 30004902; 30004903 |]; position= {x = 9.47280117e+16;  y = -9.866671439e+15;  z = -3.804015398e+17;} } |> Some
      | 21000011 -> { ConstellationData.id= 21000011; name= "A-C00011"; regionId= 11000002; solarSystemIds= [| 31000251; 31000252; 31000253; 31000254; 31000255; 31000256; 31000257; 31000258; 31000259; 31000260 |]; position= {x = 7.652253857e+18;  y = 8.242467609e+15;  z = -9.376339365e+18;} } |> Some
      | 21000108 -> { ConstellationData.id= 21000108; name= "C-C00108"; regionId= 11000012; solarSystemIds= [| 31001087; 31001088; 31001089; 31001090; 31001091; 31001092 |]; position= {x = 7.461373997e+18;  y = 1.438725471e+15;  z = -9.328701253e+18;} } |> Some
      | 21000205 -> { ConstellationData.id= 21000205; name= "D-C00205"; regionId= 11000021; solarSystemIds= [| 31001713; 31001714; 31001715; 31001716; 31001717; 31001718; 31001719 |]; position= {x = 7.536558259e+18;  y = 7.945254398e+15;  z = -9.170784098e+18;} } |> Some
      | 21000302 -> { ConstellationData.id= 21000302; name= "F-C00302"; regionId= 11000030; solarSystemIds= [| 31002403; 31002404; 31002405; 31002406; 31002407; 31002408; 31002409; 31002410 |]; position= {x = 7.361601145e+18;  y = 1.673511976e+16;  z = -9.795332238e+18;} } |> Some
      | _ -> None