namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations46=
    let getConstellation id = 
      match id with 
      | 20000088 -> { ConstellationData.id= 20000088; name= "GU-JZ1"; regionId= 10000006; solarSystemIds= [| 30000605; 30000606; 30000607; 30000608; 30000609; 30000610 |]; position= {x = 8.364759045e+16;  y = -6.955335167e+15;  z = -1.423413405e+17;} } |> Some
      | 20000185 -> { ConstellationData.id= 20000185; name= "ST-0EZ"; regionId= 10000015; solarSystemIds= [| 30001268; 30001269; 30001270; 30001271; 30001272; 30001273 |]; position= {x = -1.499293575e+17;  y = 1.150551705e+17;  z = 2.761420503e+17;} } |> Some
      | 20000282 -> { ConstellationData.id= 20000282; name= "JG-ZLG"; regionId= 10000022; solarSystemIds= [| 30001905; 30001906; 30001907; 30001908; 30001909; 30001910 |]; position= {x = -1.645553802e+17;  y = 3.481298696e+16;  z = -3.644041306e+17;} } |> Some
      | 20000379 -> { ConstellationData.id= 20000379; name= "5J-SSP"; regionId= 10000031; solarSystemIds= [| 30002581; 30002582; 30002583; 30002584; 30002585; 30002586; 30002587 |]; position= {x = -4.433146959e+16;  y = 2.544914794e+15;  z = -3.053009731e+17;} } |> Some
      | 20000476 -> { ConstellationData.id= 20000476; name= "S-Q02B"; regionId= 10000040; solarSystemIds= [| 30003255; 30003256; 30003257; 30003258; 30003259; 30003260 |]; position= {x = 2.207125178e+17;  y = 7.569290141e+16;  z = 1.194174661e+17;} } |> Some
      | 20000573 -> { ConstellationData.id= 20000573; name= "Homroon"; regionId= 10000049; solarSystemIds= [| 30003923; 30003924; 30003925; 30003926; 30003927; 30003928; 30003929 |]; position= {x = -3.492358507e+17;  y = 3.862045706e+15;  z = -1.350432782e+17;} } |> Some
      | 20000670 -> { ConstellationData.id= 20000670; name= "Unicorn"; regionId= 10000058; solarSystemIds= [| 30004590; 30004591; 30004592; 30004593; 30004594; 30004595 |]; position= {x = -4.185710768e+17;  y = 3.090078748e+16;  z = -2.104380141e+15;} } |> Some
      | 20000767 -> { ConstellationData.id= 20000767; name= "Reya"; regionId= 10000067; solarSystemIds= [| 30005243; 30005244; 30005245; 30005246; 30005247; 30005248 |]; position= {x = -2.582547307e+17;  y = 2.198244252e+16;  z = -1.583436633e+16;} } |> Some
      | 21000061 -> { ConstellationData.id= 21000061; name= "B-C00061"; regionId= 11000008; solarSystemIds= [| 31000762; 31000763; 31000764; 31000765; 31000766; 31000767; 31000768; 31000769; 31000770; 31000771 |]; position= {x = 7.510617264e+18;  y = 1.813628534e+16;  z = -9.651764548e+18;} } |> Some
      | 21000158 -> { ConstellationData.id= 21000158; name= "D-C00158"; regionId= 11000016; solarSystemIds= [| 31001410; 31001411; 31001412; 31001413; 31001414; 31001415; 31001416 |]; position= {x = 7.908206022e+18;  y = 1.005402855e+16;  z = -9.618832697e+18;} } |> Some
      | 21000255 -> { ConstellationData.id= 21000255; name= "E-C00255"; regionId= 11000025; solarSystemIds= [| 31002055; 31002056; 31002057; 31002058; 31002059; 31002060 |]; position= {x = 7.327152511e+18;  y = 3.266965565e+16;  z = -9.138654603e+18;} } |> Some
      | _ -> None