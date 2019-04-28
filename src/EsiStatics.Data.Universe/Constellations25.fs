namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations25=
    let getConstellation id = 
      match id with 
      | 20000067 -> { ConstellationData.id= 20000067; name= "PR-ACX"; regionId= 10000005; solarSystemIds= [| 30000460; 30000461; 30000462; 30000463; 30000464; 30000465 |]; position= {x = 1.067257522e+17;  y = -3.04088836e+16;  z = -1.861286622e+17;} } |> Some
      | 20000164 -> { ConstellationData.id= 20000164; name= "GDBW-2"; regionId= 10000013; solarSystemIds= [| 30001117; 30001118; 30001119; 30001120; 30001121; 30001122; 30001123; 30001124; 30001125 |]; position= {x = 1.595854158e+17;  y = 5.037062421e+16;  z = 1.090652458e+17;} } |> Some
      | 20000261 -> { ConstellationData.id= 20000261; name= "AGI1-F"; regionId= 10000021; solarSystemIds= [| 30001762; 30001763; 30001764; 30001765; 30001766; 30001767 |]; position= {x = 3.125610741e+17;  y = -3.195190298e+16;  z = 5.077332026e+16;} } |> Some
      | 20000358 -> { ConstellationData.id= 20000358; name= "IPS-QB"; regionId= 10000029; solarSystemIds= [| 30002438; 30002439; 30002440; 30002441; 30002442; 30002443 |]; position= {x = -2.364324439e+16;  y = 8.629620815e+16;  z = 1.228180903e+17;} } |> Some
      | 20000455 -> { ConstellationData.id= 20000455; name= "Q-2BI6"; regionId= 10000039; solarSystemIds= [| 30003113; 30003114; 30003115; 30003116; 30003117; 30003118 |]; position= {x = -1.21897659e+17;  y = 5.11822059e+15;  z = -3.834210618e+17;} } |> Some
      | 20000552 -> { ConstellationData.id= 20000552; name= "Q-6LG1"; regionId= 10000047; solarSystemIds= [| 30003781; 30003782; 30003783; 30003784; 30003785; 30003786 |]; position= {x = -1.216517423e+17;  y = 5.331407409e+16;  z = -1.488857178e+17;} } |> Some
      | 20000649 -> { ConstellationData.id= 20000649; name= "JQA8-6"; regionId= 10000056; solarSystemIds= [| 30004443; 30004444; 30004445; 30004446; 30004447; 30004448; 30004449 |]; position= {x = 2.858066867e+16;  y = -2.010030128e+16;  z = -3.763696298e+17;} } |> Some
      | 20000746 -> { ConstellationData.id= 20000746; name= "O5PO-O"; regionId= 10000066; solarSystemIds= [| 30005094; 30005095; 30005096; 30005097; 30005098; 30005099 |]; position= {x = 1.978236435e+17;  y = 5.724368761e+16;  z = 8.309090291e+16;} } |> Some
      | 21000040 -> { ConstellationData.id= 21000040; name= "B-C00040"; regionId= 11000005; solarSystemIds= [| 31000550; 31000551; 31000552; 31000553; 31000554; 31000555; 31000556; 31000557; 31000558; 31000559; 31000560 |]; position= {x = 7.842275257e+18;  y = 2.20391038e+16;  z = -9.535480693e+18;} } |> Some
      | 21000137 -> { ConstellationData.id= 21000137; name= "C-C00137"; regionId= 11000014; solarSystemIds= [| 31001273; 31001274; 31001275; 31001276; 31001277; 31001278 |]; position= {x = 7.928898577e+18;  y = 4.700424201e+15;  z = -9.330352976e+18;} } |> Some
      | 21000234 -> { ConstellationData.id= 21000234; name= "E-C00234"; regionId= 11000024; solarSystemIds= [| 31001898; 31001899; 31001900; 31001901; 31001902; 31001903; 31001904; 31001905; 31001906 |]; position= {x = 7.153086996e+18;  y = 2.048323334e+16;  z = -9.318442544e+18;} } |> Some
      | 21000331 -> { ConstellationData.id= 21000331; name= "H-C00331"; regionId= 11000032; solarSystemIds= [| 31002580; 31002581; 31002582; 31002583 |]; position= {x = 7.668788073e+18;  y = 1.577114057e+18;  z = -9.658905594e+18;} } |> Some
      | 22000013 -> { ConstellationData.id= 22000013; name= "ADC13"; regionId= 12000003; solarSystemIds= [| 32000097; 32000098; 32000099; 32000100; 32000101; 32000102; 32000103; 32000104 |]; position= {x = 4.130444906e+18;  y = 4.91117381e+18;  z = -7.792571289e+18;} } |> Some
      | _ -> None