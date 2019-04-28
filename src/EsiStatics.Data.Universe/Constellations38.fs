namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations38=
    let getConstellation id = 
      match id with 
      | 20000080 -> { ConstellationData.id= 20000080; name= "DJ-XCW"; regionId= 10000006; solarSystemIds= [| 30000552; 30000553; 30000554; 30000555; 30000556; 30000557 |]; position= {x = 1.047471626e+17;  y = -1.659717469e+15;  z = -1.444300177e+17;} } |> Some
      | 20000177 -> { ConstellationData.id= 20000177; name= "T-1WDH"; regionId= 10000014; solarSystemIds= [| 30001213; 30001214; 30001215; 30001216; 30001217; 30001218 |]; position= {x = -6.670608314e+16;  y = -1.064315281e+16;  z = -2.628729063e+17;} } |> Some
      | 20000274 -> { ConstellationData.id= 20000274; name= "Y-2D6Q"; regionId= 10000022; solarSystemIds= [| 30001851; 30001852; 30001853; 30001854; 30001855; 30001856 |]; position= {x = -1.21723545e+17;  y = 2.921373815e+16;  z = -2.984338591e+17;} } |> Some
      | 20000371 -> { ConstellationData.id= 20000371; name= "Wiedadur"; regionId= 10000030; solarSystemIds= [| 30002531; 30002532; 30002533; 30002534; 30002535; 30002536 |]; position= {x = -7.253969512e+16;  y = 1.647950605e+16;  z = 2.198484279e+16;} } |> Some
      | 20000468 -> { ConstellationData.id= 20000468; name= "CZ-06R"; regionId= 10000040; solarSystemIds= [| 30003204; 30003205; 30003206; 30003207; 30003208; 30003209 |]; position= {x = 2.533558479e+17;  y = 4.790455085e+16;  z = 1.443699639e+17;} } |> Some
      | 20000565 -> { ConstellationData.id= 20000565; name= "Finaka"; regionId= 10000049; solarSystemIds= [| 30003867; 30003868; 30003869; 30003870; 30003871; 30003872; 30003873; 30003874; 30003875 |]; position= {x = -2.763577672e+17;  y = 3.662020752e+16;  z = -1.232632152e+17;} } |> Some
      | 20000662 -> { ConstellationData.id= 20000662; name= "Scepter"; regionId= 10000057; solarSystemIds= [| 30004532; 30004533; 30004534; 30004535; 30004536; 30004537 |]; position= {x = -3.791841612e+17;  y = 3.07217194e+16;  z = 1.141596915e+17;} } |> Some
      | 20000759 -> { ConstellationData.id= 20000759; name= "TPB-KG"; regionId= 10000066; solarSystemIds= [| 30005186; 30005187; 30005188; 30005189; 30005190; 30005191 |]; position= {x = 1.927671628e+17;  y = 3.185415903e+16;  z = 1.656846975e+17;} } |> Some
      | 21000053 -> { ConstellationData.id= 21000053; name= "B-C00053"; regionId= 11000006; solarSystemIds= [| 31000681; 31000682; 31000683; 31000684; 31000685; 31000686; 31000687; 31000688; 31000689; 31000690; 31000691; 31000692 |]; position= {x = 7.829716739e+18;  y = -6.898916452e+14;  z = -9.656622202e+18;} } |> Some
      | 21000150 -> { ConstellationData.id= 21000150; name= "C-C00150"; regionId= 11000015; solarSystemIds= [| 31001356; 31001357; 31001358; 31001359; 31001360; 31001361 |]; position= {x = 8.019142076e+18;  y = 2.203799871e+16;  z = -9.434797024e+18;} } |> Some
      | 21000247 -> { ConstellationData.id= 21000247; name= "E-C00247"; regionId= 11000025; solarSystemIds= [| 31001998; 31001999; 31002000; 31002001; 31002002; 31002003; 31002004; 31002005; 31002006 |]; position= {x = 7.318271371e+18;  y = 1.313154267e+16;  z = -9.119829157e+18;} } |> Some
      | _ -> None