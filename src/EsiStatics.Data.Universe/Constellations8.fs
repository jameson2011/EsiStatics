namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations8=
    let getConstellation id = 
      match id with 
      | 20000050 -> { ConstellationData.id= 20000050; name= "7PUP-K"; regionId= 10000004; solarSystemIds= [| 30000347; 30000348; 30000349; 30000350; 30000351; 30000352 |]; position= {x = 7.43499642e+16;  y = 5.798032853e+16;  z = 2.377076601e+17;} } |> Some
      | 20000147 -> { ConstellationData.id= 20000147; name= "Tranquility"; regionId= 10000012; solarSystemIds= [| 30001001; 30001002; 30001003; 30001004; 30001005; 30001006 |]; position= {x = 4.502242109e+16;  y = -3.026585963e+16;  z = -1.671241346e+17;} } |> Some
      | 20000244 -> { ConstellationData.id= 20000244; name= "Somi"; regionId= 10000020; solarSystemIds= [| 30001650; 30001651; 30001652; 30001653; 30001654; 30001655 |]; position= {x = -1.967208034e+17;  y = 6.1164379e+16;  z = -8.854449055e+16;} } |> Some
      | 20000341 -> { ConstellationData.id= 20000341; name= "6TT8-Z"; regionId= 10000027; solarSystemIds= [| 30002323; 30002324; 30002325; 30002326; 30002327; 30002328; 30002329; 30002330 |]; position= {x = 1.293634717e+17;  y = 8.366948777e+16;  z = 2.439808306e+16;} } |> Some
      | 20000438 -> { ConstellationData.id= 20000438; name= "Daredan"; regionId= 10000036; solarSystemIds= [| 30002988; 30002989; 30002990; 30002991; 30002992; 30002993; 30002994 |]; position= {x = -1.381496034e+17;  y = 7.729621975e+16;  z = -8.551770733e+16;} } |> Some
      | 20000535 -> { ConstellationData.id= 20000535; name= "E-72A3"; regionId= 10000045; solarSystemIds= [| 30003670; 30003671; 30003672; 30003673; 30003674; 30003675 |]; position= {x = -7.138583173e+16;  y = 1.510794576e+16;  z = 4.506955961e+17;} } |> Some
      | 20000632 -> { ConstellationData.id= 20000632; name= "304-QS"; regionId= 10000055; solarSystemIds= [| 30004323; 30004324; 30004325; 30004326; 30004327; 30004328 |]; position= {x = -1.434427828e+17;  y = 6.121488076e+16;  z = 3.723059384e+17;} } |> Some
      | 20000729 -> { ConstellationData.id= 20000729; name= "Jeon"; regionId= 10000064; solarSystemIds= [| 30004979; 30004980; 30004981; 30004982; 30004983; 30004984; 30004985; 30004986 |]; position= {x = -2.069076348e+17;  y = 4.829087907e+16;  z = 7.960999001e+16;} } |> Some
      | 21000023 -> { ConstellationData.id= 21000023; name= "B-C00023"; regionId= 11000004; solarSystemIds= [| 31000375; 31000376; 31000377; 31000378; 31000379; 31000380; 31000381; 31000382; 31000383; 31000384; 31000385 |]; position= {x = 7.770807003e+18;  y = 1.090506299e+16;  z = -9.323914578e+18;} } |> Some
      | 21000120 -> { ConstellationData.id= 21000120; name= "C-C00120"; regionId= 11000012; solarSystemIds= [| 31001165; 31001166; 31001167; 31001168; 31001169; 31001170 |]; position= {x = 7.468459815e+18;  y = 1.125617973e+16;  z = -9.356112994e+18;} } |> Some
      | 21000217 -> { ConstellationData.id= 21000217; name= "D-C00217"; regionId= 11000022; solarSystemIds= [| 31001789; 31001790; 31001791; 31001792; 31001793; 31001794 |]; position= {x = 7.916731587e+18;  y = 2.122811618e+16;  z = -9.254081089e+18;} } |> Some
      | 21000314 -> { ConstellationData.id= 21000314; name= "A-C00314"; regionId= 11000001; solarSystemIds= [| 31000035; 31000036; 31000037; 31000038; 31000039; 31000040; 31000041; 31000042; 31000043; 31000044 |]; position= {x = 7.635989822e+18;  y = 1.616419522e+16;  z = -9.489430886e+18;} } |> Some
      | _ -> None