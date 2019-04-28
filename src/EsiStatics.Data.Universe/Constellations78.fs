namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations78=
    let getConstellation id = 
      match id with 
      | 20000023 -> { ConstellationData.id= 20000023; name= "Ihatalo"; regionId= 10000002; solarSystemIds= [| 30000159; 30000160; 30000161; 30000162; 30000163; 30000164 |]; position= {x = -7.032240031e+16;  y = 5.371825528e+16;  z = 8.824889686e+16;} } |> Some
      | 20000120 -> { ConstellationData.id= 20000120; name= "V2S-RH"; regionId= 10000009; solarSystemIds= [| 30000814; 30000815; 30000816; 30000817; 30000818; 30000819; 30000820; 30000821; 30000822; 30000823 |]; position= {x = 2.000120278e+17;  y = -9.311472489e+15;  z = -1.622473739e+17;} } |> Some
      | 20000217 -> { ConstellationData.id= 20000217; name= "BS8-ZQ"; regionId= 10000017; solarSystemIds= [| 30001473; 30001474; 30001475; 30001476; 30001477; 30001478 |]; position= {x = 1.040503449e+16;  y = 8.922947956e+16;  z = 2.274141105e+17;} } |> Some
      | 20000314 -> { ConstellationData.id= 20000314; name= "C73-U5"; regionId= 10000025; solarSystemIds= [| 30002129; 30002130; 30002131; 30002132; 30002133; 30002134; 30002135; 30002136; 30002137 |]; position= {x = -2.257406361e+16;  y = -1.427706435e+16;  z = -1.906634408e+17;} } |> Some
      | 20000411 -> { ConstellationData.id= 20000411; name= "Tasen"; regionId= 10000033; solarSystemIds= [| 30002800; 30002801; 30002802; 30002803; 30002804; 30002805 |]; position= {x = -1.518734068e+17;  y = 7.336409331e+16;  z = 8.159301213e+16;} } |> Some
      | 20000508 -> { ConstellationData.id= 20000508; name= "Kashag"; regionId= 10000043; solarSystemIds= [| 30003481; 30003482; 30003483; 30003484; 30003485; 30003486 |]; position= {x = -1.627600197e+17;  y = 8.683045959e+16;  z = -1.232404752e+17;} } |> Some
      | 20000605 -> { ConstellationData.id= 20000605; name= "Pezarba"; regionId= 10000052; solarSystemIds= [| 30004136; 30004137; 30004138; 30004139; 30004140; 30004141 |]; position= {x = -2.485796403e+17;  y = 6.71213173e+16;  z = -4.452531283e+16;} } |> Some
      | 20000702 -> { ConstellationData.id= 20000702; name= "OK-FEM"; regionId= 10000060; solarSystemIds= [| 30004796; 30004797; 30004798; 30004799; 30004800; 30004801; 30004802 |]; position= {x = -4.05565219e+17;  y = 6.541769527e+16;  z = -3.256718109e+17;} } |> Some
      | 21000093 -> { ConstellationData.id= 21000093; name= "C-C00093"; regionId= 11000011; solarSystemIds= [| 31000987; 31000988; 31000989; 31000990; 31000991; 31000992; 31000993 |]; position= {x = 7.450548225e+18;  y = 3.917197597e+16;  z = -9.486232752e+18;} } |> Some
      | 21000190 -> { ConstellationData.id= 21000190; name= "D-C00190"; regionId= 11000020; solarSystemIds= [| 31001619; 31001620; 31001621; 31001622; 31001623; 31001624 |]; position= {x = 7.35786779e+18;  y = 1.893979505e+16;  z = -9.255099604e+18;} } |> Some
      | 21000287 -> { ConstellationData.id= 21000287; name= "E-C00287"; regionId= 11000029; solarSystemIds= [| 31002290; 31002291; 31002292; 31002293; 31002294; 31002295 |]; position= {x = 7.591123313e+18;  y = 1.923183456e+16;  z = -1.001248328e+19;} } |> Some
      | _ -> None