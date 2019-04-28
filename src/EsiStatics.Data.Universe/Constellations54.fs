namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations54=
    let getConstellation id = 
      match id with 
      | 20000096 -> { ConstellationData.id= 20000096; name= "51ZT-6"; regionId= 10000008; solarSystemIds= [| 30000655; 30000656; 30000657; 30000658; 30000659; 30000660; 30000661; 30000662; 30000663; 30000664; 30000665 |]; position= {x = 4.74342838e+16;  y = 1.268619388e+16;  z = -1.494229869e+17;} } |> Some
      | 20000193 -> { ConstellationData.id= 20000193; name= "Y8HB-U"; regionId= 10000015; solarSystemIds= [| 30001324; 30001325; 30001326; 30001327; 30001328; 30001329; 30001330 |]; position= {x = -1.26207006e+17;  y = 9.536597642e+16;  z = 3.317501257e+17;} } |> Some
      | 20000290 -> { ConstellationData.id= 20000290; name= "U8-CWA"; regionId= 10000023; solarSystemIds= [| 30001969; 30001970; 30001971; 30001972; 30001973; 30001974; 30001975; 30001976 |]; position= {x = -2.313431352e+17;  y = 1.21431227e+17;  z = 2.358176614e+17;} } |> Some
      | 20000387 -> { ConstellationData.id= 20000387; name= "Gallente Border Zone"; regionId= 10000032; solarSystemIds= [| 30002642; 30002643; 30002644; 30002645; 30002646; 30002647 |]; position= {x = -1.585133713e+17;  y = 4.993716085e+16;  z = 8.52575993e+16;} } |> Some
      | 20000484 -> { ConstellationData.id= 20000484; name= "YFN-UN"; regionId= 10000041; solarSystemIds= [| 30003320; 30003321; 30003322; 30003323; 30003324; 30003325; 30003326 |]; position= {x = -3.283172087e+17;  y = 4.63282785e+16;  z = 8.711534199e+16;} } |> Some
      | 20000581 -> { ConstellationData.id= 20000581; name= "8BO-IH"; regionId= 10000050; solarSystemIds= [| 30003978; 30003979; 30003980; 30003981; 30003982; 30003983 |]; position= {x = -3.407756596e+17;  y = 4.124310001e+16;  z = -2.339236238e+17;} } |> Some
      | 20000678 -> { ConstellationData.id= 20000678; name= "Minotaur"; regionId= 10000058; solarSystemIds= [| 30004643; 30004644; 30004645; 30004646; 30004647; 30004648 |]; position= {x = -4.820761781e+17;  y = 5.574562071e+16;  z = -2.558137331e+16;} } |> Some
      | 20000775 -> { ConstellationData.id= 20000775; name= "Woenckee"; regionId= 10000068; solarSystemIds= [| 30005295; 30005296; 30005297; 30005298; 30005299; 30005300 |]; position= {x = -2.328401395e+17;  y = 4.877735821e+16;  z = 6.521293016e+16;} } |> Some
      | 21000069 -> { ConstellationData.id= 21000069; name= "B-C00069"; regionId= 11000008; solarSystemIds= [| 31000846; 31000847; 31000848; 31000849; 31000850; 31000851; 31000852; 31000853; 31000854; 31000855; 31000856 |]; position= {x = 7.504874965e+18;  y = 3.744868289e+15;  z = -9.62539426e+18;} } |> Some
      | 21000166 -> { ConstellationData.id= 21000166; name= "D-C00166"; regionId= 11000018; solarSystemIds= [| 31001460; 31001461; 31001462; 31001463; 31001464; 31001465 |]; position= {x = 7.601666061e+18;  y = -7.177798126e+14;  z = -9.675958872e+18;} } |> Some
      | 21000263 -> { ConstellationData.id= 21000263; name= "E-C00263"; regionId= 11000026; solarSystemIds= [| 31002114; 31002115; 31002116; 31002117; 31002118; 31002119 |]; position= {x = 7.661990047e+18;  y = 2.592951522e+16;  z = -9.033630709e+18;} } |> Some
      | _ -> None