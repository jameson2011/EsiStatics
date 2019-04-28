namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations34=
    let getConstellation id = 
      match id with 
      | 20000076 -> { ConstellationData.id= 20000076; name= "NZU8-G"; regionId= 10000005; solarSystemIds= [| 30000521; 30000522; 30000523; 30000524; 30000525; 30000526; 30000527; 30000528 |]; position= {x = 1.369090582e+17;  y = -3.47850608e+16;  z = -2.041369428e+17;} } |> Some
      | 20000173 -> { ConstellationData.id= 20000173; name= "JZV-O6"; regionId= 10000014; solarSystemIds= [| 30001182; 30001183; 30001184; 30001185; 30001186; 30001187 |]; position= {x = -7.649489541e+16;  y = 3.989007024e+16;  z = -1.769588462e+17;} } |> Some
      | 20000270 -> { ConstellationData.id= 20000270; name= "KPU3-3"; regionId= 10000021; solarSystemIds= [| 30001825; 30001826; 30001827; 30001828; 30001829; 30001830 |]; position= {x = 2.975644879e+17;  y = -2.331325755e+16;  z = 4.223911211e+16;} } |> Some
      | 20000367 -> { ConstellationData.id= 20000367; name= "Ortner"; regionId= 10000030; solarSystemIds= [| 30002505; 30002506; 30002507; 30002508; 30002509; 30002510; 30002511; 30012505 |]; position= {x = -1.024430186e+17;  y = 4.196754249e+16;  z = -3.279331427e+15;} } |> Some
      | 20000464 -> { ConstellationData.id= 20000464; name= "FY6-NK"; regionId= 10000039; solarSystemIds= [| 30003177; 30003178; 30003179; 30003180; 30003181; 30003182 |]; position= {x = -8.229027028e+16;  y = -2.616638052e+16;  z = -4.709466206e+17;} } |> Some
      | 20000561 -> { ConstellationData.id= 20000561; name= "Amevync"; regionId= 10000048; solarSystemIds= [| 30003836; 30003837; 30003838; 30003839; 30003840; 30003841; 30003842 |]; position= {x = -2.529579097e+17;  y = 1.13716301e+17;  z = 1.296926199e+17;} } |> Some
      | 20000658 -> { ConstellationData.id= 20000658; name= "Belt"; regionId= 10000057; solarSystemIds= [| 30004508; 30004509; 30004510; 30004511; 30004512; 30004513 |]; position= {x = -3.815845325e+17;  y = 8.454685496e+15;  z = 9.213443533e+16;} } |> Some
      | 20000755 -> { ConstellationData.id= 20000755; name= "WXB-RY"; regionId= 10000066; solarSystemIds= [| 30005158; 30005159; 30005160; 30005161; 30005162; 30005163; 30005164; 30005165; 30005166; 30005167 |]; position= {x = 2.30499226e+17;  y = 4.563235257e+16;  z = 1.214353853e+17;} } |> Some
      | 21000049 -> { ConstellationData.id= 21000049; name= "B-C00049"; regionId= 11000006; solarSystemIds= [| 31000641; 31000642; 31000643; 31000644; 31000645; 31000646; 31000647; 31000648; 31000649 |]; position= {x = 7.824611582e+18;  y = 2.116788314e+16;  z = -9.672925211e+18;} } |> Some
      | 21000146 -> { ConstellationData.id= 21000146; name= "C-C00146"; regionId= 11000015; solarSystemIds= [| 31001329; 31001330; 31001331; 31001332; 31001333; 31001334 |]; position= {x = 7.946667891e+18;  y = 4.556416313e+16;  z = -9.473496145e+18;} } |> Some
      | 21000243 -> { ConstellationData.id= 21000243; name= "E-C00243"; regionId= 11000025; solarSystemIds= [| 31001968; 31001969; 31001970; 31001971; 31001972; 31001973 |]; position= {x = 7.325752687e+18;  y = 2.904068992e+16;  z = -9.14519634e+18;} } |> Some
      | 22000022 -> { ConstellationData.id= 22000022; name= "ADC22"; regionId= 12000005; solarSystemIds= [| 32000169; 32000170; 32000171; 32000172; 32000173; 32000174; 32000175; 32000176 |]; position= {x = 5.071773389e+18;  y = 5.517936567e+18;  z = -9.033386069e+18;} } |> Some
      | _ -> None