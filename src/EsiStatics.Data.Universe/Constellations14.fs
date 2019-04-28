namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations14=
    let getConstellation id = 
      match id with 
      | 20000056 -> { ConstellationData.id= 20000056; name= "VW-JMB"; regionId= 10000004; solarSystemIds= [| 30000389; 30000390; 30000391; 30000392; 30000393; 30000394 |]; position= {x = 7.905546169e+16;  y = 5.615093925e+16;  z = 3.073294861e+17;} } |> Some
      | 20000153 -> { ConstellationData.id= 20000153; name= "Heaven"; regionId= 10000012; solarSystemIds= [| 30001044; 30001045; 30001046; 30001047; 30001048; 30001049; 30001050 |]; position= {x = -1.716490247e+16;  y = 1.747838152e+16;  z = -1.386745132e+17;} } |> Some
      | 20000250 -> { ConstellationData.id= 20000250; name= "Damadil"; regionId= 10000020; solarSystemIds= [| 30001687; 30001688; 30001689; 30001690; 30001691; 30001692; 30001693 |]; position= {x = -2.390022118e+17;  y = 4.455673771e+16;  z = -1.280158405e+17;} } |> Some
      | 20000347 -> { ConstellationData.id= 20000347; name= "H7Q-DG"; regionId= 10000027; solarSystemIds= [| 30002364; 30002365; 30002366; 30002367; 30002368; 30002369 |]; position= {x = 1.639677241e+17;  y = 2.908480642e+16;  z = 1.987147743e+16;} } |> Some
      | 20000444 -> { ConstellationData.id= 20000444; name= "Odilis"; regionId= 10000037; solarSystemIds= [| 30003031; 30003032; 30003033; 30003034; 30003035; 30003036; 30003037 |]; position= {x = -1.767115611e+17;  y = 3.018834061e+16;  z = 3.121523912e+16;} } |> Some
      | 20000541 -> { ConstellationData.id= 20000541; name= "4BZ-R3"; regionId= 10000047; solarSystemIds= [| 30003709; 30003710; 30003711; 30003712; 30003713; 30003714; 30003715; 30003716 |]; position= {x = -1.111579399e+17;  y = 4.131266658e+16;  z = -1.805359864e+17;} } |> Some
      | 20000638 -> { ConstellationData.id= 20000638; name= "Q5KW-Z"; regionId= 10000055; solarSystemIds= [| 30004364; 30004365; 30004366; 30004367; 30004368; 30004369; 30004370 |]; position= {x = -1.633817748e+17;  y = 5.471653377e+16;  z = 3.912828043e+17;} } |> Some
      | 20000735 -> { ConstellationData.id= 20000735; name= "Eustron"; regionId= 10000064; solarSystemIds= [| 30005024; 30005025; 30005026; 30005027; 30005028; 30005029; 30024971 |]; position= {x = -2.186698281e+17;  y = 3.540963046e+16;  z = 4.229674735e+16;} } |> Some
      | 21000029 -> { ConstellationData.id= 21000029; name= "B-C00029"; regionId= 11000004; solarSystemIds= [| 31000436; 31000437; 31000438; 31000439; 31000440; 31000441; 31000442; 31000443; 31000444; 31000445; 31000446; 31000447 |]; position= {x = 7.747815738e+18;  y = 2.102174262e+16;  z = -9.311093764e+18;} } |> Some
      | 21000126 -> { ConstellationData.id= 21000126; name= "C-C00126"; regionId= 11000013; solarSystemIds= [| 31001202; 31001203; 31001204; 31001205; 31001206; 31001207 |]; position= {x = 7.719619948e+18;  y = 2.553007209e+16;  z = -9.266779167e+18;} } |> Some
      | 21000223 -> { ConstellationData.id= 21000223; name= "D-C00223"; regionId= 11000022; solarSystemIds= [| 31001826; 31001827; 31001828; 31001829; 31001830; 31001831; 31001832 |]; position= {x = 7.927651753e+18;  y = 4.605176328e+15;  z = -9.205582051e+18;} } |> Some
      | 21000320 -> { ConstellationData.id= 21000320; name= "A-C00320"; regionId= 11000001; solarSystemIds= [| 31000093; 31000094; 31000095; 31000096; 31000097; 31000098; 31000099; 31000100; 31000101; 31000102; 31000103; 31000104 |]; position= {x = 7.633757963e+18;  y = 3.578743636e+16;  z = -9.494708504e+18;} } |> Some
      | 22000002 -> { ConstellationData.id= 22000002; name= "ADC02"; regionId= 12000001; solarSystemIds= [| 32000009; 32000010; 32000011; 32000012; 32000013; 32000014; 32000015; 32000016 |]; position= {x = 3.345239081e+18;  y = 5.073868966e+18;  z = -5.42163796e+18;} } |> Some
      | _ -> None