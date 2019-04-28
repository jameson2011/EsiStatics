namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations39=
    let getConstellation id = 
      match id with 
      | 20000081 -> { ConstellationData.id= 20000081; name= "3GK-WS"; regionId= 10000006; solarSystemIds= [| 30000558; 30000559; 30000560; 30000561; 30000562; 30000563; 30000564 |]; position= {x = 9.106430368e+16;  y = 9.684709253e+15;  z = -1.497122354e+17;} } |> Some
      | 20000178 -> { ConstellationData.id= 20000178; name= "A-JI5E"; regionId= 10000014; solarSystemIds= [| 30001219; 30001220; 30001221; 30001222; 30001223; 30001224; 30001225 |]; position= {x = -1.045394168e+17;  y = 1.872676885e+16;  z = -2.389619258e+17;} } |> Some
      | 20000275 -> { ConstellationData.id= 20000275; name= "U7L-MQ"; regionId= 10000022; solarSystemIds= [| 30001857; 30001858; 30001859; 30001860; 30001861; 30001862; 30001863; 30001864; 30001865; 30001866 |]; position= {x = -1.277698061e+17;  y = 1.640153399e+16;  z = -3.253181681e+17;} } |> Some
      | 20000372 -> { ConstellationData.id= 20000372; name= "Hed"; regionId= 10000030; solarSystemIds= [| 30002537; 30002538; 30002539; 30002540; 30002541; 30002542 |]; position= {x = -1.282693384e+17;  y = 3.821271907e+16;  z = 7.556108809e+15;} } |> Some
      | 20000469 -> { ConstellationData.id= 20000469; name= "F-W6B4"; regionId= 10000040; solarSystemIds= [| 30003210; 30003211; 30003212; 30003213; 30003214; 30003215 |]; position= {x = 2.365053703e+17;  y = 5.183382098e+16;  z = 1.023215316e+17;} } |> Some
      | 20000566 -> { ConstellationData.id= 20000566; name= "Amdimmah"; regionId= 10000049; solarSystemIds= [| 30003876; 30003877; 30003878; 30003879; 30003880; 30003881 |]; position= {x = -2.825809674e+17;  y = 2.427953085e+16;  z = -9.431319324e+16;} } |> Some
      | 20000663 -> { ConstellationData.id= 20000663; name= "Velvet"; regionId= 10000057; solarSystemIds= [| 30004538; 30004539; 30004540; 30004541; 30004542; 30004543 |]; position= {x = -4.097640407e+17;  y = 1.169877281e+16;  z = 9.209357918e+16;} } |> Some
      | 20000760 -> { ConstellationData.id= 20000760; name= "Nazdirer"; regionId= 10000067; solarSystemIds= [| 30005192; 30005193; 30005194; 30005195; 30005196; 30005197 |]; position= {x = -2.208620233e+17;  y = 3.6584934e+16;  z = -1.627452045e+16;} } |> Some
      | 21000054 -> { ConstellationData.id= 21000054; name= "B-C00054"; regionId= 11000006; solarSystemIds= [| 31000693; 31000694; 31000695; 31000696; 31000697; 31000698; 31000699; 31000700; 31000701 |]; position= {x = 7.862727941e+18;  y = 1.464568736e+16;  z = -9.667274056e+18;} } |> Some
      | 21000151 -> { ConstellationData.id= 21000151; name= "C-C00151"; regionId= 11000015; solarSystemIds= [| 31001362; 31001363; 31001364; 31001365; 31001366; 31001367 |]; position= {x = 7.941099292e+18;  y = 1.178515233e+16;  z = -9.472930271e+18;} } |> Some
      | 21000248 -> { ConstellationData.id= 21000248; name= "E-C00248"; regionId= 11000025; solarSystemIds= [| 31002007; 31002008; 31002009; 31002010; 31002011; 31002012; 31002485; 31002503 |]; position= {x = 7.315115275e+18;  y = 2.160075672e+16;  z = -9.102497085e+18;} } |> Some
      | _ -> None