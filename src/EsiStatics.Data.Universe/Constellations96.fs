namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations96=
    let getConstellation id = 
      match id with 
      | 20000041 -> { ConstellationData.id= 20000041; name= "DILJ-7"; regionId= 10000003; solarSystemIds= [| 30000289; 30000290; 30000291; 30000292; 30000293; 30000294 |]; position= {x = -5.555738868e+16;  y = 1.039915276e+17;  z = 1.752353325e+17;} } |> Some
      | 20000138 -> { ConstellationData.id= 20000138; name= "Q-PVMK"; regionId= 10000011; solarSystemIds= [| 30000942; 30000943; 30000944; 30000945; 30000946; 30000947; 30000948 |]; position= {x = 1.578757817e+16;  y = 3.751384402e+16;  z = -6.889847325e+16;} } |> Some
      | 20000235 -> { ConstellationData.id= 20000235; name= "MY-HQD"; regionId= 10000018; solarSystemIds= [| 30001592; 30001593; 30001594; 30001595; 30001596; 30001597 |]; position= {x = 2.231586633e+17;  y = 3.920494989e+16;  z = 2.775481959e+16;} } |> Some
      | 20000332 -> { ConstellationData.id= 20000332; name= "Avib"; regionId= 10000043; solarSystemIds= [| 30002263; 30002264; 30002265; 30002266; 30002267; 30002268 |]; position= {x = -1.864438067e+17;  y = 6.134058681e+16;  z = -1.022166416e+17;} } |> Some
      | 20000429 -> { ConstellationData.id= 20000429; name= "S-B1E4"; regionId= 10000035; solarSystemIds= [| 30002921; 30002922; 30002923; 30002924; 30002925; 30002926; 30002927; 30002928; 30002929; 30002930; 30002931 |]; position= {x = -2.813577181e+17;  y = 7.19956332e+16;  z = 3.148855671e+17;} } |> Some
      | 20000526 -> { ConstellationData.id= 20000526; name= "M-J57M"; regionId= 10000045; solarSystemIds= [| 30003608; 30003609; 30003610; 30003611; 30003612; 30003613; 30003614; 30003615; 30003616 |]; position= {x = -7.661036268e+16;  y = 7.34028297e+16;  z = 4.089044394e+17;} } |> Some
      | 20000623 -> { ConstellationData.id= 20000623; name= "Ombil"; regionId= 10000054; solarSystemIds= [| 30004254; 30004255; 30004256; 30004257; 30004258; 30004259; 30004260; 30004261; 30004262; 30004263; 30004264; 30004265; 30004266 |]; position= {x = -3.57172986e+17;  y = 4.31083246e+16;  z = -4.047888419e+16;} } |> Some
      | 20000720 -> { ConstellationData.id= 20000720; name= "RL36-K"; regionId= 10000062; solarSystemIds= [| 30004920; 30004921; 30004922; 30004923; 30004924; 30004925; 30004926 |]; position= {x = 1.481702588e+17;  y = -4.642641506e+16;  z = -4.089545688e+17;} } |> Some
      | 21000014 -> { ConstellationData.id= 21000014; name= "A-C00014"; regionId= 11000002; solarSystemIds= [| 31000282; 31000283; 31000284; 31000285; 31000286; 31000287; 31000288; 31000289; 31000290; 31000291; 31000292 |]; position= {x = 7.571714827e+18;  y = 1.323743337e+16;  z = -9.360664793e+18;} } |> Some
      | 21000111 -> { ConstellationData.id= 21000111; name= "C-C00111"; regionId= 11000012; solarSystemIds= [| 31001106; 31001107; 31001108; 31001109; 31001110; 31001111; 31001112 |]; position= {x = 7.451085091e+18;  y = 3.511738205e+16;  z = -9.333083714e+18;} } |> Some
      | 21000208 -> { ConstellationData.id= 21000208; name= "D-C00208"; regionId= 11000021; solarSystemIds= [| 31001734; 31001735; 31001736; 31001737; 31001738; 31001739 |]; position= {x = 7.611800025e+18;  y = 1.193078096e+16;  z = -9.108593766e+18;} } |> Some
      | 21000305 -> { ConstellationData.id= 21000305; name= "F-C00305"; regionId= 11000030; solarSystemIds= [| 31002426; 31002427; 31002428; 31002429; 31002430; 31002431; 31002432; 31002433; 31002434 |]; position= {x = 7.341971265e+18;  y = 1.80759284e+16;  z = -9.82567814e+18;} } |> Some
      | _ -> None