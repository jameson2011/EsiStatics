namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations94=
    let getConstellation id = 
      match id with 
      | 20000039 -> { ConstellationData.id= 20000039; name= "YDS0-Y"; regionId= 10000003; solarSystemIds= [| 30000274; 30000275; 30000276; 30000277; 30000278; 30000279 |]; position= {x = -3.761108019e+16;  y = 1.045673402e+17;  z = 1.438897984e+17;} } |> Some
      | 20000136 -> { ConstellationData.id= 20000136; name= "BB8E-G"; regionId= 10000011; solarSystemIds= [| 30000927; 30000928; 30000929; 30000930; 30000931; 30000932; 30000933; 30000934; 30000935 |]; position= {x = 4.346864785e+16;  y = 4.144114361e+16;  z = -7.926356062e+16;} } |> Some
      | 20000233 -> { ConstellationData.id= 20000233; name= "OWT3-6"; regionId= 10000018; solarSystemIds= [| 30001580; 30001581; 30001582; 30001583; 30001584; 30001585 |]; position= {x = 2.5035911e+17;  y = 1.204304774e+16;  z = -1.551751864e+16;} } |> Some
      | 20000330 -> { ConstellationData.id= 20000330; name= "Nashar"; regionId= 10000043; solarSystemIds= [| 30002251; 30002252; 30002253; 30002254; 30002255; 30002256 |]; position= {x = -1.841050267e+17;  y = 8.721575737e+16;  z = -1.047517459e+17;} } |> Some
      | 20000427 -> { ConstellationData.id= 20000427; name= "UTQ-BO"; regionId= 10000035; solarSystemIds= [| 30002908; 30002909; 30002910; 30002911; 30002912; 30002913; 30002914 |]; position= {x = -2.534608372e+17;  y = 8.101286276e+16;  z = 2.986293594e+17;} } |> Some
      | 20000524 -> { ConstellationData.id= 20000524; name= "Elerelle"; regionId= 10000044; solarSystemIds= [| 30003594; 30003595; 30003596; 30003597; 30003598; 30003599; 30003600; 30003601 |]; position= {x = -3.394841389e+17;  y = 4.110992479e+16;  z = 2.505790277e+16;} } |> Some
      | 20000621 -> { ConstellationData.id= 20000621; name= "Mareerieh"; regionId= 10000054; solarSystemIds= [| 30004242; 30004243; 30004244; 30004245; 30004246; 30004247 |]; position= {x = -3.550947849e+17;  y = 2.346375905e+16;  z = -7.007639531e+16;} } |> Some
      | 20000718 -> { ConstellationData.id= 20000718; name= "8MJO-4"; regionId= 10000062; solarSystemIds= [| 30004904; 30004905; 30004906; 30004907; 30004908; 30004909; 30004910 |]; position= {x = 1.150467779e+17;  y = -3.784323076e+16;  z = -3.971626613e+17;} } |> Some
      | 21000012 -> { ConstellationData.id= 21000012; name= "A-C00012"; regionId= 11000002; solarSystemIds= [| 31000261; 31000262; 31000263; 31000264; 31000265; 31000266; 31000267; 31000268; 31000269; 31000270 |]; position= {x = 7.622709294e+18;  y = 4.665065382e+15;  z = -9.486358959e+18;} } |> Some
      | 21000109 -> { ConstellationData.id= 21000109; name= "C-C00109"; regionId= 11000012; solarSystemIds= [| 31001093; 31001094; 31001095; 31001096; 31001097; 31001098 |]; position= {x = 7.43576816e+18;  y = 2.136303777e+16;  z = -9.364103303e+18;} } |> Some
      | 21000206 -> { ConstellationData.id= 21000206; name= "D-C00206"; regionId= 11000021; solarSystemIds= [| 31001720; 31001721; 31001722; 31001723; 31001724; 31001725; 31001726 |]; position= {x = 7.546120034e+18;  y = 9.776504779e+15;  z = -9.093534573e+18;} } |> Some
      | 21000303 -> { ConstellationData.id= 21000303; name= "F-C00303"; regionId= 11000030; solarSystemIds= [| 31002411; 31002412; 31002413; 31002414; 31002415; 31002416; 31002489 |]; position= {x = 7.300361817e+18;  y = 1.872850586e+16;  z = -9.845436697e+18;} } |> Some
      | _ -> None