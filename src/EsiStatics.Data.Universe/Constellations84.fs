namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations84=
    let getConstellation id = 
      match id with 
      | 20000029 -> { ConstellationData.id= 20000029; name= "Orpana"; regionId= 10000002; solarSystemIds= [| 30000201; 30000202; 30000203; 30000204; 30000205; 30000207 |]; position= {x = -9.77662679e+16;  y = 7.148116632e+16;  z = 1.444526032e+17;} } |> Some
      | 20000126 -> { ConstellationData.id= 20000126; name= "LLAP-1"; regionId= 10000010; solarSystemIds= [| 30000861; 30000862; 30000863; 30000864; 30000865; 30000866 |]; position= {x = -1.319755616e+17;  y = 1.04012241e+17;  z = 2.169351762e+17;} } |> Some
      | 20000223 -> { ConstellationData.id= 20000223; name= "2RX9-6"; regionId= 10000017; solarSystemIds= [| 30001512; 30001513; 30001514; 30001515; 30001516; 30001517 |]; position= {x = -2.260163057e+16;  y = 9.006804692e+16;  z = 2.417335668e+17;} } |> Some
      | 20000320 -> { ConstellationData.id= 20000320; name= "WTE-CK"; regionId= 10000025; solarSystemIds= [| 30002172; 30002173; 30002174; 30002175; 30002176; 30002177 |]; position= {x = 4.288299095e+16;  y = -1.58598755e+16;  z = -2.454462934e+17;} } |> Some
      | 20000417 -> { ConstellationData.id= 20000417; name= "3NA-Z1"; regionId= 10000034; solarSystemIds= [| 30002839; 30002840; 30002841; 30002842; 30002843; 30002844; 30002845 |]; position= {x = 1.262415059e+17;  y = 3.26041578e+16;  z = 1.016397154e+17;} } |> Some
      | 20000514 -> { ConstellationData.id= 20000514; name= "Maddam"; regionId= 10000043; solarSystemIds= [| 30003520; 30003521; 30003522; 30003523; 30003524; 30003525; 30003526; 30003527; 30033489 |]; position= {x = -1.669662203e+17;  y = 8.995116243e+16;  z = -8.732942202e+16;} } |> Some
      | 20000611 -> { ConstellationData.id= 20000611; name= "SI1-CF"; regionId= 10000053; solarSystemIds= [| 30004177; 30004178; 30004179; 30004180; 30004181; 30004182 |]; position= {x = 2.899358392e+17;  y = 4.256446947e+16;  z = 1.913075238e+17;} } |> Some
      | 20000708 -> { ConstellationData.id= 20000708; name= "G3IP-E"; regionId= 10000061; solarSystemIds= [| 30004839; 30004840; 30004841; 30004842; 30004843; 30004844 |]; position= {x = 3.778197748e+16;  y = -1.670389397e+15;  z = -2.892302163e+17;} } |> Some
      | 21000002 -> { ConstellationData.id= 21000002; name= "A-C00002"; regionId= 11000002; solarSystemIds= [| 31000151; 31000152; 31000153; 31000154; 31000155; 31000156; 31000157; 31000158; 31000159; 31000160; 31000161; 31000162 |]; position= {x = 7.586754154e+18;  y = 2.874236146e+16;  z = -9.440448718e+18;} } |> Some
      | 21000099 -> { ConstellationData.id= 21000099; name= "C-C00099"; regionId= 11000011; solarSystemIds= [| 31001026; 31001027; 31001028; 31001029; 31001030; 31001031; 31001032 |]; position= {x = 7.3671156e+18;  y = 3.404894073e+16;  z = -9.503382356e+18;} } |> Some
      | 21000196 -> { ConstellationData.id= 21000196; name= "D-C00196"; regionId= 11000021; solarSystemIds= [| 31001657; 31001658; 31001659; 31001660; 31001661; 31001662 |]; position= {x = 7.549822995e+18;  y = 1.418690537e+16;  z = -9.178382428e+18;} } |> Some
      | 21000293 -> { ConstellationData.id= 21000293; name= "E-C00293"; regionId= 11000029; solarSystemIds= [| 31002338; 31002339; 31002340; 31002341; 31002342; 31002343; 31002344; 31002345 |]; position= {x = 7.625459269e+18;  y = 2.286924188e+16;  z = -1.001234733e+19;} } |> Some
      | _ -> None