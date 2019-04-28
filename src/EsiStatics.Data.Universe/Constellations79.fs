namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations79=
    let getConstellation id = 
      match id with 
      | 20000024 -> { ConstellationData.id= 20000024; name= "Okkelen"; regionId= 10000002; solarSystemIds= [| 30000165; 30000166; 30000167; 30000168; 30000169; 30000170; 30000171; 30000172 |]; position= {x = -7.418783809e+16;  y = 9.267968412e+16;  z = 1.197439438e+17;} } |> Some
      | 20000121 -> { ConstellationData.id= 20000121; name= "FD-7Y4"; regionId= 10000009; solarSystemIds= [| 30000824; 30000825; 30000826; 30000827; 30000828; 30000829; 30000830 |]; position= {x = 1.898816012e+17;  y = -3.372785637e+16;  z = -1.721478922e+17;} } |> Some
      | 20000218 -> { ConstellationData.id= 20000218; name= "I4-DK8"; regionId= 10000017; solarSystemIds= [| 30001479; 30001480; 30001481; 30001482; 30001483; 30001484; 30001485 |]; position= {x = 3.206296097e+16;  y = 6.893962395e+16;  z = 2.010905831e+17;} } |> Some
      | 20000315 -> { ConstellationData.id= 20000315; name= "K-N3MD"; regionId= 10000025; solarSystemIds= [| 30002138; 30002139; 30002140; 30002141; 30002142; 30002143; 30002144 |]; position= {x = 2.474231321e+16;  y = -1.617700174e+16;  z = -2.206056304e+17;} } |> Some
      | 20000412 -> { ConstellationData.id= 20000412; name= "Isoma"; regionId= 10000033; solarSystemIds= [| 30002806; 30002807; 30002808; 30002809; 30002810; 30002811; 30002812; 30002813 |]; position= {x = -1.879910949e+17;  y = 7.002504236e+16;  z = 1.081915709e+17;} } |> Some
      | 20000509 -> { ConstellationData.id= 20000509; name= "Parud"; regionId= 10000043; solarSystemIds= [| 30003487; 30003488; 30003489; 30003490; 30003491; 30003492; 30013489 |]; position= {x = -1.880777142e+17;  y = 6.047580221e+16;  z = -5.784126831e+16;} } |> Some
      | 20000606 -> { ConstellationData.id= 20000606; name= "Naloran"; regionId= 10000052; solarSystemIds= [| 30004142; 30004143; 30004144; 30004145; 30004146; 30004147 |]; position= {x = -2.386537262e+17;  y = 5.691317691e+16;  z = -1.308378869e+17;} } |> Some
      | 20000703 -> { ConstellationData.id= 20000703; name= "QP6B-I"; regionId= 10000061; solarSystemIds= [| 30004803; 30004804; 30004805; 30004806; 30004807; 30004808; 30004809; 30004810 |]; position= {x = -7.520774421e+15;  y = 1.128178983e+16;  z = -2.424608629e+17;} } |> Some
      | 21000094 -> { ConstellationData.id= 21000094; name= "C-C00094"; regionId= 11000011; solarSystemIds= [| 31000994; 31000995; 31000996; 31000997; 31000998; 31000999; 31001000 |]; position= {x = 7.379070676e+18;  y = 1.870695645e+16;  z = -9.467700118e+18;} } |> Some
      | 21000191 -> { ConstellationData.id= 21000191; name= "D-C00191"; regionId= 11000020; solarSystemIds= [| 31001625; 31001626; 31001627; 31001628; 31001629; 31001630 |]; position= {x = 7.352598082e+18;  y = 2.607875669e+16;  z = -9.235116201e+18;} } |> Some
      | 21000288 -> { ConstellationData.id= 21000288; name= "E-C00288"; regionId= 11000029; solarSystemIds= [| 31002296; 31002297; 31002298; 31002299; 31002300; 31002301; 31002302 |]; position= {x = 7.60477474e+18;  y = 2.332491405e+16;  z = -1.000982379e+19;} } |> Some
      | _ -> None