namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations22=
    let getConstellation id = 
      match id with 
      | 20000064 -> { ConstellationData.id= 20000064; name= "RFQ-8Y"; regionId= 10000005; solarSystemIds= [| 30000440; 30000441; 30000442; 30000443; 30000444; 30000445 |]; position= {x = 1.336604813e+17;  y = -1.622889035e+16;  z = -1.902736393e+17;} } |> Some
      | 20000161 -> { ConstellationData.id= 20000161; name= "7UNX-J"; regionId= 10000013; solarSystemIds= [| 30001097; 30001098; 30001099; 30001100; 30001101; 30001102 |]; position= {x = 1.585630226e+17;  y = 6.880032381e+16;  z = 6.310646965e+16;} } |> Some
      | 20000258 -> { ConstellationData.id= 20000258; name= "B-D245"; regionId= 10000021; solarSystemIds= [| 30001743; 30001744; 30001745; 30001746; 30001747; 30001748 |]; position= {x = 2.732161807e+17;  y = -3.155330945e+16;  z = 1.806294733e+16;} } |> Some
      | 20000355 -> { ConstellationData.id= 20000355; name= "Elfrard"; regionId= 10000028; solarSystemIds= [| 30002414; 30002415; 30002416; 30002417; 30002418; 30002419; 30002420 |]; position= {x = -1.787034142e+16;  y = -1.102556933e+16;  z = -1.80496448e+16;} } |> Some
      | 20000452 -> { ConstellationData.id= 20000452; name= "Ohvarainen"; regionId= 10000038; solarSystemIds= [| 30003092; 30003093; 30003094; 30003095; 30003096; 30003097 |]; position= {x = -1.748344074e+17;  y = 2.827218696e+16;  z = -4.446887675e+16;} } |> Some
      | 20000549 -> { ConstellationData.id= 20000549; name= "P6N8-J"; regionId= 10000047; solarSystemIds= [| 30003760; 30003761; 30003762; 30003763; 30003764; 30003765 |]; position= {x = -1.177111527e+17;  y = 4.951203236e+16;  z = -1.184955525e+17;} } |> Some
      | 20000646 -> { ConstellationData.id= 20000646; name= "I-3ODK"; regionId= 10000056; solarSystemIds= [| 30004418; 30004419; 30004420; 30004421; 30004422; 30004423; 30004424 |]; position= {x = 1.933065374e+16;  y = -2.09603814e+16;  z = -3.64920786e+17;} } |> Some
      | 20000743 -> { ConstellationData.id= 20000743; name= "Comadu"; regionId= 10000065; solarSystemIds= [| 30005076; 30005077; 30005078; 30005079; 30005080; 30005081 |]; position= {x = -2.577145482e+17;  y = 4.170936355e+16;  z = -7.282022204e+16;} } |> Some
      | 21000037 -> { ConstellationData.id= 21000037; name= "B-C00037"; regionId= 11000005; solarSystemIds= [| 31000519; 31000520; 31000521; 31000522; 31000523; 31000524; 31000525; 31000526; 31000527; 31000528; 31000529 |]; position= {x = 7.925720793e+18;  y = 2.739511989e+16;  z = -9.493869601e+18;} } |> Some
      | 21000134 -> { ConstellationData.id= 21000134; name= "C-C00134"; regionId= 11000014; solarSystemIds= [| 31001254; 31001255; 31001256; 31001257; 31001258; 31001259 |]; position= {x = 7.932311743e+18;  y = 3.856321178e+15;  z = -9.30717269e+18;} } |> Some
      | 21000231 -> { ConstellationData.id= 21000231; name= "D-C00231"; regionId= 11000023; solarSystemIds= [| 31001877; 31001878; 31001879 |]; position= {x = 8.064057559e+18;  y = 2.168344984e+15;  z = -9.741727507e+18;} } |> Some
      | 21000328 -> { ConstellationData.id= 21000328; name= "D-C00328"; regionId= 11000016; solarSystemIds= [| 31002538; 31002539; 31002540; 31002541; 31002542; 31002543; 31002544; 31002545; 31002546; 31002547; 31002548; 31002549; 31002550; 31002551; 31002552; 31002553; 31002554; 31002555 |]; position= {x = 7.849376742e+18;  y = 1.423857876e+18;  z = -9.760976596e+18;} } |> Some
      | 22000010 -> { ConstellationData.id= 22000010; name= "ADC10"; regionId= 12000002; solarSystemIds= [| 32000073; 32000074; 32000075; 32000076; 32000077; 32000078; 32000079; 32000080 |]; position= {x = 4.793705058e+18;  y = 4.507140134e+18;  z = -5.510838629e+18;} } |> Some
      | _ -> None