namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations51=
    let getConstellation id = 
      match id with 
      | 20000093 -> { ConstellationData.id= 20000093; name= "VSC-W9"; regionId= 10000007; solarSystemIds= [| 30000637; 30000638; 30000639; 30000640; 30000641; 30000642 |]; position= {x = 2.875285671e+17;  y = -1.889567027e+16;  z = -7.716457649e+16;} } |> Some
      | 20000190 -> { ConstellationData.id= 20000190; name= "W9MQ-1"; regionId= 10000015; solarSystemIds= [| 30001300; 30001301; 30001302; 30001303; 30001304; 30001305; 30001306; 30001307; 30001308 |]; position= {x = -1.387894121e+17;  y = 1.044472471e+17;  z = 3.332954128e+17;} } |> Some
      | 20000287 -> { ConstellationData.id= 20000287; name= "WF-OP4"; regionId= 10000022; solarSystemIds= [| 30001948; 30001949; 30001950; 30001951; 30001952; 30001953; 30001954; 30001955 |]; position= {x = -2.032726258e+17;  y = 1.00980847e+17;  z = -2.736503807e+17;} } |> Some
      | 20000384 -> { ConstellationData.id= 20000384; name= "O6W-QE"; regionId= 10000031; solarSystemIds= [| 30002619; 30002620; 30002621; 30002622; 30002623; 30002624; 30002625 |]; position= {x = -3.480842367e+16;  y = -8.553834518e+15;  z = -3.645961438e+17;} } |> Some
      | 20000481 -> { ConstellationData.id= 20000481; name= "DS-M4Q"; regionId= 10000041; solarSystemIds= [| 30003292; 30003293; 30003294; 30003295; 30003296; 30003297; 30003298; 30003299; 30003300 |]; position= {x = -2.840119883e+17;  y = 2.530013393e+16;  z = 6.09895514e+16;} } |> Some
      | 20000578 -> { ConstellationData.id= 20000578; name= "YB7B-8"; regionId= 10000050; solarSystemIds= [| 30003954; 30003955; 30003956; 30003957; 30003958; 30003959; 30003960; 30003961 |]; position= {x = -3.120426973e+17;  y = 5.634698796e+16;  z = -2.274619519e+17;} } |> Some
      | 20000675 -> { ConstellationData.id= 20000675; name= "Taurus"; regionId= 10000058; solarSystemIds= [| 30004624; 30004625; 30004626; 30004627; 30004628; 30004629 |]; position= {x = -3.948085644e+17;  y = 1.282590447e+16;  z = -1.611142714e+15;} } |> Some
      | 20000772 -> { ConstellationData.id= 20000772; name= "Kihkounad"; regionId= 10000067; solarSystemIds= [| 30005275; 30005276; 30005277; 30005278; 30005279; 30005280 |]; position= {x = -2.991977922e+17;  y = -1.356513349e+16;  z = -5.218595642e+16;} } |> Some
      | 21000066 -> { ConstellationData.id= 21000066; name= "B-C00066"; regionId= 11000008; solarSystemIds= [| 31000811; 31000812; 31000813; 31000814; 31000815; 31000816; 31000817; 31000818; 31000819; 31000820; 31000821; 31000822 |]; position= {x = 7.484771686e+18;  y = 3.309630532e+16;  z = -9.663000857e+18;} } |> Some
      | 21000163 -> { ConstellationData.id= 21000163; name= "D-C00163"; regionId= 11000017; solarSystemIds= [| 31001441; 31001442; 31001443; 31001444; 31001445; 31001446; 31001447 |]; position= {x = 7.745546684e+18;  y = 1.129785239e+16;  z = -9.784227813e+18;} } |> Some
      | 21000260 -> { ConstellationData.id= 21000260; name= "E-C00260"; regionId= 11000026; solarSystemIds= [| 31002091; 31002092; 31002093; 31002094; 31002095; 31002096; 31002097; 31002098 |]; position= {x = 7.70734982e+18;  y = 3.996086384e+16;  z = -8.92321211e+18;} } |> Some
      | _ -> None