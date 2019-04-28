namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations70=
    let getConstellation id = 
      match id with 
      | 20000015 -> { ConstellationData.id= 20000015; name= "Subi"; regionId= 10000001; solarSystemIds= [| 30000106; 30000107; 30000108; 30000109; 30000110; 30000111 |]; position= {x = -9.60220705e+16;  y = 3.929649678e+16;  z = -8.362476221e+16;} } |> Some
      | 20000112 -> { ConstellationData.id= 20000112; name= "Z-ONUI"; regionId= 10000009; solarSystemIds= [| 30000764; 30000765; 30000766; 30000767; 30000768; 30000769 |]; position= {x = 1.740257522e+17;  y = 1.479966905e+16;  z = -1.419609851e+17;} } |> Some
      | 20000209 -> { ConstellationData.id= 20000209; name= "Asalola"; regionId= 10000016; solarSystemIds= [| 30001424; 30001425; 30001426; 30001427; 30001428; 30001429 |]; position= {x = -2.219338102e+17;  y = 1.136182925e+17;  z = 1.851487694e+17;} } |> Some
      | 20000306 -> { ConstellationData.id= 20000306; name= "Fribrodi"; regionId= 10000042; solarSystemIds= [| 30002076; 30002077; 30002078; 30002079; 30002080; 30002081 |]; position= {x = -1.379979718e+17;  y = 2.446066402e+15;  z = 4.411968304e+16;} } |> Some
      | 20000403 -> { ConstellationData.id= 20000403; name= "Arekin"; regionId= 10000033; solarSystemIds= [| 30002749; 30002750; 30002751; 30002752; 30002753; 30002754 |]; position= {x = -1.365706809e+17;  y = 8.456537744e+16;  z = 1.373684186e+17;} } |> Some
      | 20000500 -> { ConstellationData.id= 20000500; name= "Brazinget"; regionId= 10000042; solarSystemIds= [| 30003428; 30003429; 30003430; 30003431; 30003432; 30003433 |]; position= {x = -9.550424541e+16;  y = 2.000348589e+16;  z = 3.705665027e+16;} } |> Some
      | 20000597 -> { ConstellationData.id= 20000597; name= "Kakol"; regionId= 10000052; solarSystemIds= [| 30004084; 30004085; 30004086; 30004087; 30004088; 30004089; 30004090 |]; position= {x = -2.347374656e+17;  y = 5.831586399e+16;  z = -4.58784065e+16;} } |> Some
      | 20000694 -> { ConstellationData.id= 20000694; name= "D5-SOW"; regionId= 10000060; solarSystemIds= [| 30004744; 30004745; 30004746; 30004747; 30004748; 30004749 |]; position= {x = -4.484503802e+17;  y = 4.146398326e+16;  z = -2.221957722e+17;} } |> Some
      | 21000085 -> { ConstellationData.id= 21000085; name= "C-C00085"; regionId= 11000010; solarSystemIds= [| 31000936; 31000937; 31000938; 31000939; 31000940; 31000941 |]; position= {x = 7.48737586e+18;  y = 2.339824264e+16;  z = -9.723753277e+18;} } |> Some
      | 21000182 -> { ConstellationData.id= 21000182; name= "D-C00182"; regionId= 11000019; solarSystemIds= [| 31001566; 31001567; 31001568; 31001569; 31001570; 31001571; 31001572 |]; position= {x = 7.449743974e+18;  y = 4.07434552e+16;  z = -9.595688821e+18;} } |> Some
      | 21000279 -> { ConstellationData.id= 21000279; name= "E-C00279"; regionId= 11000028; solarSystemIds= [| 31002230; 31002231; 31002232; 31002233; 31002234; 31002235; 31002236; 31002237 |]; position= {x = 8.043430285e+18;  y = 1.864482752e+16;  z = -9.841865257e+18;} } |> Some
      | _ -> None