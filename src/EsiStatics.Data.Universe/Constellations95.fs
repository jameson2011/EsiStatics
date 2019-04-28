namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations95=
    let getConstellation id = 
      match id with 
      | 20000040 -> { ConstellationData.id= 20000040; name= "A3-T8B"; regionId= 10000003; solarSystemIds= [| 30000280; 30000281; 30000282; 30000283; 30000284; 30000285; 30000286; 30000287; 30000288 |]; position= {x = -1.559995139e+16;  y = 5.820417041e+16;  z = 1.460949195e+17;} } |> Some
      | 20000137 -> { ConstellationData.id= 20000137; name= "IYOO-M"; regionId= 10000011; solarSystemIds= [| 30000936; 30000937; 30000938; 30000939; 30000940; 30000941 |]; position= {x = 4.77762623e+16;  y = 1.239056814e+16;  z = -1.077939822e+17;} } |> Some
      | 20000234 -> { ConstellationData.id= 20000234; name= "E65-47"; regionId= 10000018; solarSystemIds= [| 30001586; 30001587; 30001588; 30001589; 30001590; 30001591 |]; position= {x = 2.634561263e+17;  y = 2.840786466e+16;  z = 7.001819728e+16;} } |> Some
      | 20000331 -> { ConstellationData.id= 20000331; name= "Kehina"; regionId= 10000043; solarSystemIds= [| 30002257; 30002258; 30002259; 30002260; 30002261; 30002262 |]; position= {x = -1.78313128e+17;  y = 5.851111207e+16;  z = -1.007232348e+17;} } |> Some
      | 20000428 -> { ConstellationData.id= 20000428; name= "N-U2LX"; regionId= 10000035; solarSystemIds= [| 30002915; 30002916; 30002917; 30002918; 30002919; 30002920 |]; position= {x = -2.492594186e+17;  y = 5.180596551e+16;  z = 2.977811024e+17;} } |> Some
      | 20000525 -> { ConstellationData.id= 20000525; name= "Mobrault"; regionId= 10000044; solarSystemIds= [| 30003602; 30003603; 30003604; 30003605; 30003606; 30003607 |]; position= {x = -3.281619797e+17;  y = 5.186210379e+16;  z = 4.411864205e+16;} } |> Some
      | 20000622 -> { ConstellationData.id= 20000622; name= "Mayonhen"; regionId= 10000054; solarSystemIds= [| 30004248; 30004249; 30004250; 30004251; 30004252; 30004253 |]; position= {x = -3.677623463e+17;  y = 8.425247534e+15;  z = -4.878437404e+16;} } |> Some
      | 20000719 -> { ConstellationData.id= 20000719; name= "U7-GIV"; regionId= 10000062; solarSystemIds= [| 30004911; 30004912; 30004913; 30004914; 30004915; 30004916; 30004917; 30004918; 30004919 |]; position= {x = 1.297698961e+17;  y = -8.545805273e+15;  z = -4.101863374e+17;} } |> Some
      | 21000013 -> { ConstellationData.id= 21000013; name= "A-C00013"; regionId= 11000002; solarSystemIds= [| 31000271; 31000272; 31000273; 31000274; 31000275; 31000276; 31000277; 31000278; 31000279; 31000280; 31000281 |]; position= {x = 7.609103841e+18;  y = 3.391253644e+15;  z = -9.384705295e+18;} } |> Some
      | 21000110 -> { ConstellationData.id= 21000110; name= "C-C00110"; regionId= 11000012; solarSystemIds= [| 31001099; 31001100; 31001101; 31001102; 31001103; 31001104; 31001105 |]; position= {x = 7.45590345e+18;  y = 1.525968351e+16;  z = -9.279211445e+18;} } |> Some
      | 21000207 -> { ConstellationData.id= 21000207; name= "D-C00207"; regionId= 11000021; solarSystemIds= [| 31001727; 31001728; 31001729; 31001730; 31001731; 31001732; 31001733 |]; position= {x = 7.63310728e+18;  y = 1.282538258e+16;  z = -9.070313829e+18;} } |> Some
      | 21000304 -> { ConstellationData.id= 21000304; name= "F-C00304"; regionId= 11000030; solarSystemIds= [| 31002417; 31002418; 31002419; 31002420; 31002421; 31002422; 31002423; 31002424; 31002425 |]; position= {x = 7.332948964e+18;  y = 5.740384359e+15;  z = -9.79590932e+18;} } |> Some
      | _ -> None