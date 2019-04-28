namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations81=
    let getConstellation id = 
      match id with 
      | 20000026 -> { ConstellationData.id= 20000026; name= "Aulari"; regionId= 10000002; solarSystemIds= [| 30000180; 30000181; 30000182; 30000183; 30000184; 30000185; 30000186; 30000187 |]; position= {x = -7.083151308e+16;  y = 9.289959528e+16;  z = 9.921411385e+16;} } |> Some
      | 20000123 -> { ConstellationData.id= 20000123; name= "R-CL2W"; regionId= 10000009; solarSystemIds= [| 30000838; 30000839; 30000840; 30000841; 30000842; 30000843; 30000844; 30000845 |]; position= {x = 1.64843069e+17;  y = -3.566602298e+16;  z = -1.924120266e+17;} } |> Some
      | 20000220 -> { ConstellationData.id= 20000220; name= "NSM-6F"; regionId= 10000017; solarSystemIds= [| 30001492; 30001493; 30001494; 30001495; 30001496; 30001497; 30001498; 30001499 |]; position= {x = 3.63020107e+16;  y = 9.580741718e+16;  z = 1.86784678e+17;} } |> Some
      | 20000317 -> { ConstellationData.id= 20000317; name= "Y46-EN"; regionId= 10000025; solarSystemIds= [| 30002153; 30002154; 30002155; 30002156; 30002157; 30002158 |]; position= {x = -8.547993102e+15;  y = -2.35303394e+16;  z = -1.657673074e+17;} } |> Some
      | 20000414 -> { ConstellationData.id= 20000414; name= "6-CBBM"; regionId= 10000034; solarSystemIds= [| 30002820; 30002821; 30002822; 30002823; 30002824; 30002825; 30002826 |]; position= {x = 1.436228927e+17;  y = 2.923801357e+16;  z = 1.137773387e+17;} } |> Some
      | 20000511 -> { ConstellationData.id= 20000511; name= "Yekti"; regionId= 10000043; solarSystemIds= [| 30003500; 30003501; 30003502; 30003503; 30003504; 30003505; 30003506 |]; position= {x = -1.823168098e+17;  y = 4.858544482e+16;  z = -3.296881648e+16;} } |> Some
      | 20000608 -> { ConstellationData.id= 20000608; name= "Qermi"; regionId= 10000052; solarSystemIds= [| 30004155; 30004156; 30004157; 30004158; 30004159; 30004160 |]; position= {x = -2.441136407e+17;  y = 6.354433883e+16;  z = -1.317146663e+17;} } |> Some
      | 20000705 -> { ConstellationData.id= 20000705; name= "CL-QB2"; regionId= 10000061; solarSystemIds= [| 30004817; 30004818; 30004819; 30004820; 30004821; 30004822; 30004823 |]; position= {x = 1.20321386e+16;  y = 1.720669892e+16;  z = -2.700735936e+17;} } |> Some
      | 21000096 -> { ConstellationData.id= 21000096; name= "C-C00096"; regionId= 11000011; solarSystemIds= [| 31001007; 31001008; 31001009; 31001010; 31001011; 31001012; 31001013 |]; position= {x = 7.430769975e+18;  y = 4.692052695e+15;  z = -9.407648776e+18;} } |> Some
      | 21000193 -> { ConstellationData.id= 21000193; name= "D-C00193"; regionId= 11000020; solarSystemIds= [| 31001638; 31001639; 31001640; 31001641; 31001642; 31001643 |]; position= {x = 7.371288771e+18;  y = 8.419636794e+15;  z = -9.295022709e+18;} } |> Some
      | 21000290 -> { ConstellationData.id= 21000290; name= "E-C00290"; regionId= 11000029; solarSystemIds= [| 31002312; 31002313; 31002314; 31002315; 31002316; 31002317; 31002318; 31002319; 31002477; 31002497 |]; position= {x = 7.594244565e+18;  y = 1.927197646e+16;  z = -9.979764191e+18;} } |> Some
      | _ -> None