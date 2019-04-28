namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations49=
    let getConstellation id = 
      match id with 
      | 20000091 -> { ConstellationData.id= 20000091; name= "5HN-S5"; regionId= 10000007; solarSystemIds= [| 30000624; 30000625; 30000626; 30000627; 30000628; 30000629 |]; position= {x = 2.241148524e+17;  y = -1.558286852e+16;  z = -8.52587065e+16;} } |> Some
      | 20000188 -> { ConstellationData.id= 20000188; name= "UTZ-7B"; regionId= 10000015; solarSystemIds= [| 30001286; 30001287; 30001288; 30001289; 30001290; 30001291 |]; position= {x = -1.523635555e+17;  y = 1.051609778e+17;  z = 2.955241303e+17;} } |> Some
      | 20000285 -> { ConstellationData.id= 20000285; name= "SB3-IH"; regionId= 10000022; solarSystemIds= [| 30001931; 30001932; 30001933; 30001934; 30001935; 30001936 |]; position= {x = -1.828815714e+17;  y = 3.103880344e+16;  z = -3.365708642e+17;} } |> Some
      | 20000382 -> { ConstellationData.id= 20000382; name= "05M-I1"; regionId= 10000031; solarSystemIds= [| 30002605; 30002606; 30002607; 30002608; 30002609; 30002610; 30002611 |]; position= {x = -4.627215316e+16;  y = 2.380082621e+16;  z = -3.608331554e+17;} } |> Some
      | 20000479 -> { ConstellationData.id= 20000479; name= "2-M6DE"; regionId= 10000041; solarSystemIds= [| 30003280; 30003281; 30003282; 30003283; 30003284; 30003285 |]; position= {x = -2.800734512e+17;  y = 1.724705568e+16;  z = 5.148577761e+16;} } |> Some
      | 20000576 -> { ConstellationData.id= 20000576; name= "H-6HGD"; regionId= 10000050; solarSystemIds= [| 30003942; 30003943; 30003944; 30003945; 30003946; 30003947 |]; position= {x = -3.132026484e+17;  y = 4.944137759e+16;  z = -1.784982846e+17;} } |> Some
      | 20000673 -> { ConstellationData.id= 20000673; name= "Chimera"; regionId= 10000058; solarSystemIds= [| 30004608; 30004609; 30004610; 30004611; 30004612; 30004613; 30004614; 30004615; 30004616 |]; position= {x = -4.45267463e+17;  y = 1.69718263e+16;  z = -1.474902386e+16;} } |> Some
      | 20000770 -> { ConstellationData.id= 20000770; name= "Monalaz"; regionId= 10000067; solarSystemIds= [| 30005261; 30005262; 30005263; 30005264; 30005265; 30005266 |]; position= {x = -2.722965918e+17;  y = -1.127175226e+16;  z = -3.319302503e+16;} } |> Some
      | 21000064 -> { ConstellationData.id= 21000064; name= "B-C00064"; regionId= 11000008; solarSystemIds= [| 31000792; 31000793; 31000794; 31000795; 31000796; 31000797; 31000798; 31000799; 31000800; 31000801 |]; position= {x = 7.486595456e+18;  y = 1.899484684e+16;  z = -9.673280572e+18;} } |> Some
      | 21000161 -> { ConstellationData.id= 21000161; name= "D-C00161"; regionId= 11000016; solarSystemIds= [| 31001429; 31001430; 31001431; 31001432; 31001433; 31001434 |]; position= {x = 7.92363826e+18;  y = -4.47299309e+15;  z = -9.675749537e+18;} } |> Some
      | 21000258 -> { ConstellationData.id= 21000258; name= "E-C00258"; regionId= 11000026; solarSystemIds= [| 31002075; 31002076; 31002077; 31002078; 31002079; 31002080; 31002081; 31002082; 31002083; 31002501 |]; position= {x = 7.710652597e+18;  y = 8.580111999e+15;  z = -8.938053187e+18;} } |> Some
      | _ -> None