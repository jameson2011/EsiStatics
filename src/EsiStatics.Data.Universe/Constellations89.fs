namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations89=
    let getConstellation id = 
      match id with 
      | 20000034 -> { ConstellationData.id= 20000034; name= "I89-EP"; regionId= 10000003; solarSystemIds= [| 30000238; 30000239; 30000240; 30000241; 30000242; 30000243 |]; position= {x = -7.73074461e+16;  y = 9.942977116e+16;  z = 1.918276958e+17;} } |> Some
      | 20000131 -> { ConstellationData.id= 20000131; name= "W-XBGF"; regionId= 10000010; solarSystemIds= [| 30000894; 30000895; 30000896; 30000897; 30000898; 30000899 |]; position= {x = -6.009135067e+16;  y = 8.174451093e+16;  z = 2.362993276e+17;} } |> Some
      | 20000228 -> { ConstellationData.id= 20000228; name= "3D-ROC"; regionId= 10000018; solarSystemIds= [| 30001548; 30001549; 30001550; 30001551; 30001552; 30001553 |]; position= {x = 2.046869687e+17;  y = 6.620145023e+16;  z = 4.912798576e+16;} } |> Some
      | 20000325 -> { ConstellationData.id= 20000325; name= "Mazake"; regionId= 10000043; solarSystemIds= [| 30002210; 30002211; 30002212; 30002213; 30002214; 30002215; 30002216; 30002217; 30002218; 30002219 |]; position= {x = -1.974869877e+17;  y = 7.7703198e+16;  z = -1.014752572e+17;} } |> Some
      | 20000422 -> { ConstellationData.id= 20000422; name= "P-B2NE"; regionId= 10000034; solarSystemIds= [| 30002874; 30002875; 30002876; 30002877; 30002878; 30002879; 30002880 |]; position= {x = 1.137451415e+17;  y = 3.944910461e+16;  z = 8.704927031e+16;} } |> Some
      | 20000519 -> { ConstellationData.id= 20000519; name= "Jakemhih"; regionId= 10000043; solarSystemIds= [| 30003559; 30003560; 30003561; 30003562; 30003563; 30003564 |]; position= {x = -1.638416207e+17;  y = 8.125221804e+16;  z = -1.445067053e+17;} } |> Some
      | 20000616 -> { ConstellationData.id= 20000616; name= "DA0V-R"; regionId= 10000053; solarSystemIds= [| 30004208; 30004209; 30004210; 30004211; 30004212; 30004213; 30004214 |]; position= {x = 3.109610963e+17;  y = 3.33471404e+16;  z = 2.56009228e+17;} } |> Some
      | 20000713 -> { ConstellationData.id= 20000713; name= "6I-3VX"; regionId= 10000061; solarSystemIds= [| 30004872; 30004873; 30004874; 30004875; 30004876; 30004877 |]; position= {x = 1.222830943e+17;  y = -3.355583657e+16;  z = -3.180727366e+17;} } |> Some
      | 21000007 -> { ConstellationData.id= 21000007; name= "A-C00007"; regionId= 11000002; solarSystemIds= [| 31000205; 31000206; 31000207; 31000208; 31000209; 31000210; 31000211; 31000212; 31000213; 31000214 |]; position= {x = 7.680096266e+18;  y = 7.960210438e+15;  z = -9.485319532e+18;} } |> Some
      | 21000104 -> { ConstellationData.id= 21000104; name= "C-C00104"; regionId= 11000011; solarSystemIds= [| 31001059; 31001060; 31001061; 31001062; 31001063; 31001064; 31001065 |]; position= {x = 7.418664844e+18;  y = 1.972742032e+16;  z = -9.422902384e+18;} } |> Some
      | 21000201 -> { ConstellationData.id= 21000201; name= "D-C00201"; regionId= 11000021; solarSystemIds= [| 31001689; 31001690; 31001691; 31001692; 31001693; 31001694 |]; position= {x = 7.557184523e+18;  y = 2.390120727e+16;  z = -9.149811705e+18;} } |> Some
      | 21000298 -> { ConstellationData.id= 21000298; name= "F-C00298"; regionId= 11000030; solarSystemIds= [| 31002374; 31002375; 31002376; 31002377; 31002378; 31002379; 31002487 |]; position= {x = 7.266134864e+18;  y = -1.032720364e+16;  z = -9.810858148e+18;} } |> Some
      | _ -> None