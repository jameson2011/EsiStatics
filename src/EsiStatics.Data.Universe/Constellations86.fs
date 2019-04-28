namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations86=
    let getConstellation id = 
      match id with 
      | 20000031 -> { ConstellationData.id= 20000031; name= "BUG6-X"; regionId= 10000003; solarSystemIds= [| 30000215; 30000216; 30000217; 30000218; 30000219; 30000220; 30000221 |]; position= {x = -9.537177099e+16;  y = 6.862125742e+16;  z = 1.98066772e+17;} } |> Some
      | 20000128 -> { ConstellationData.id= 20000128; name= "E3-NLE"; regionId= 10000010; solarSystemIds= [| 30000873; 30000874; 30000875; 30000876; 30000877; 30000878 |]; position= {x = -1.500596837e+17;  y = 1.187588731e+17;  z = 2.221869072e+17;} } |> Some
      | 20000225 -> { ConstellationData.id= 20000225; name= "Z6T6-B"; regionId= 10000018; solarSystemIds= [| 30001526; 30001527; 30001528; 30001529; 30001530; 30001531; 30001532 |]; position= {x = 2.151647627e+17;  y = 4.983571264e+16;  z = -2.328346605e+16;} } |> Some
      | 20000322 -> { ConstellationData.id= 20000322; name= "Throne Worlds"; regionId= 10000043; solarSystemIds= [| 30002187; 30002188; 30002189; 30002190; 30002191; 30002192; 30002193; 30002194; 30002195; 30002196 |]; position= {x = -2.152583269e+17;  y = 3.62954143e+16;  z = -6.656998181e+16;} } |> Some
      | 20000419 -> { ConstellationData.id= 20000419; name= "U-HSM3"; regionId= 10000034; solarSystemIds= [| 30002853; 30002854; 30002855; 30002856; 30002857; 30002858; 30002859; 30002860 |]; position= {x = 1.393920541e+17;  y = 7.664598853e+16;  z = 8.146610316e+16;} } |> Some
      | 20000516 -> { ConstellationData.id= 20000516; name= "Mofa"; regionId= 10000043; solarSystemIds= [| 30003538; 30003539; 30003540; 30003541; 30003542; 30003543; 30003544 |]; position= {x = -1.547305489e+17;  y = 9.412398008e+16;  z = -1.005149667e+17;} } |> Some
      | 20000613 -> { ConstellationData.id= 20000613; name= "BB-48X"; regionId= 10000053; solarSystemIds= [| 30004190; 30004191; 30004192; 30004193; 30004194; 30004195 |]; position= {x = 3.052512556e+17;  y = 5.812637526e+16;  z = 1.938359628e+17;} } |> Some
      | 20000710 -> { ConstellationData.id= 20000710; name= "F5-O9O"; regionId= 10000061; solarSystemIds= [| 30004852; 30004853; 30004854; 30004855; 30004856; 30004857; 30004858 |]; position= {x = 7.427117992e+16;  y = -4.376552297e+15;  z = -3.230203215e+17;} } |> Some
      | 21000004 -> { ConstellationData.id= 21000004; name= "A-C00004"; regionId= 11000002; solarSystemIds= [| 31000174; 31000175; 31000176; 31000177; 31000178; 31000179; 31000180; 31000181; 31000182; 31000183; 31000184; 31000185 |]; position= {x = 7.592348624e+18;  y = 5.888460022e+14;  z = -9.424046048e+18;} } |> Some
      | 21000101 -> { ConstellationData.id= 21000101; name= "C-C00101"; regionId= 11000011; solarSystemIds= [| 31001040; 31001041; 31001042; 31001043; 31001044; 31001045 |]; position= {x = 7.43122609e+18;  y = 1.4805485e+16;  z = -9.456669363e+18;} } |> Some
      | 21000198 -> { ConstellationData.id= 21000198; name= "D-C00198"; regionId= 11000021; solarSystemIds= [| 31001670; 31001671; 31001672; 31001673; 31001674; 31001675; 31001676 |]; position= {x = 7.615440351e+18;  y = 2.875345521e+16;  z = -9.14792695e+18;} } |> Some
      | 21000295 -> { ConstellationData.id= 21000295; name= "E-C00295"; regionId= 11000029; solarSystemIds= [| 31002354; 31002355; 31002356; 31002357; 31002358; 31002359 |]; position= {x = 7.588295833e+18;  y = 8.890830688e+15;  z = -1.003475833e+19;} } |> Some
      | _ -> None