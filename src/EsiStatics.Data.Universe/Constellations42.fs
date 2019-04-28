namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations42=
    let getConstellation id = 
      match id with 
      | 20000084 -> { ConstellationData.id= 20000084; name= "R-M719"; regionId= 10000006; solarSystemIds= [| 30000578; 30000579; 30000580; 30000581; 30000582; 30000583; 30000584; 30000585; 30000586 |]; position= {x = 7.048162599e+16;  y = 4.715897905e+15;  z = -1.726310152e+17;} } |> Some
      | 20000181 -> { ConstellationData.id= 20000181; name= "6JCS-4"; regionId= 10000014; solarSystemIds= [| 30001238; 30001239; 30001240; 30001241; 30001242; 30001243; 30001244; 30001245 |]; position= {x = -1.368576193e+17;  y = 1.815156999e+16;  z = -2.440343193e+17;} } |> Some
      | 20000278 -> { ConstellationData.id= 20000278; name= "T-L301"; regionId= 10000022; solarSystemIds= [| 30001880; 30001881; 30001882; 30001883; 30001884; 30001885; 30001886 |]; position= {x = -1.460732316e+17;  y = 5.760296022e+16;  z = -3.564238696e+17;} } |> Some
      | 20000375 -> { ConstellationData.id= 20000375; name= "Evannater"; regionId= 10000030; solarSystemIds= [| 30002555; 30002556; 30002557; 30002558; 30002559; 30002560; 30002561 |]; position= {x = -8.117432398e+16;  y = 6.307765003e+15;  z = 3.445700452e+16;} } |> Some
      | 20000472 -> { ConstellationData.id= 20000472; name= "04-LOF"; regionId= 10000040; solarSystemIds= [| 30003229; 30003230; 30003231; 30003232; 30003233; 30003234 |]; position= {x = 2.499469878e+17;  y = 4.687088538e+16;  z = 1.220565187e+17;} } |> Some
      | 20000569 -> { ConstellationData.id= 20000569; name= "Seevadin"; regionId= 10000049; solarSystemIds= [| 30003896; 30003897; 30003898; 30003899; 30003900; 30003901; 30003902 |]; position= {x = -3.233820274e+17;  y = 6.421478374e+16;  z = -1.503622553e+17;} } |> Some
      | 20000666 -> { ConstellationData.id= 20000666; name= "Wyvern"; regionId= 10000058; solarSystemIds= [| 30004559; 30004560; 30004561; 30004562; 30004563; 30004564; 30004565; 30004566 |]; position= {x = -4.08579297e+17;  y = 2.081132009e+16;  z = 1.707389896e+16;} } |> Some
      | 20000763 -> { ConstellationData.id= 20000763; name= "Ekrin"; regionId= 10000067; solarSystemIds= [| 30005214; 30005215; 30005216; 30005217; 30005218; 30005219; 30005220 |]; position= {x = -2.477354221e+17;  y = 4.522933436e+16;  z = 1.071827785e+16;} } |> Some
      | 21000057 -> { ConstellationData.id= 21000057; name= "B-C00057"; regionId= 11000007; solarSystemIds= [| 31000721; 31000722; 31000723; 31000724; 31000725; 31000726; 31000727; 31000728; 31000729; 31000730; 31000731; 31000732 |]; position= {x = 7.659956481e+18;  y = 2.772432744e+16;  z = -9.711969967e+18;} } |> Some
      | 21000154 -> { ConstellationData.id= 21000154; name= "D-C00154"; regionId= 11000016; solarSystemIds= [| 31001382; 31001383; 31001384; 31001385; 31001386; 31001387; 31001388 |]; position= {x = 7.910643752e+18;  y = 1.93785595e+16;  z = -9.67062302e+18;} } |> Some
      | 21000251 -> { ConstellationData.id= 21000251; name= "E-C00251"; regionId= 11000025; solarSystemIds= [| 31002026; 31002027; 31002028; 31002029; 31002030; 31002031; 31002032; 31002494 |]; position= {x = 7.345252249e+18;  y = 1.248144928e+16;  z = -9.103499538e+18;} } |> Some
      | _ -> None