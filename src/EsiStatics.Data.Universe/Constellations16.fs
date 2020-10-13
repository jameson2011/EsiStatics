namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations16=
    let getConstellation id = 
      match id with 
      | 20000058 -> { ConstellationData.id= 20000058; name= "RO-AZT"; regionId= 10000004; solarSystemIds= [| 30000402; 30000403; 30000404; 30000405; 30000406; 30000407 |]; position= {x = 1.01486057e+17;  y = 9.027563587e+16;  z = 3.095649027e+17;} } |> Some
      | 20000155 -> { ConstellationData.id= 20000155; name= "XI0-X2"; regionId= 10000013; solarSystemIds= [| 30001057; 30001058; 30001059; 30001060; 30001061; 30001062 |]; position= {x = 1.608005873e+17;  y = 7.379465216e+16;  z = 9.371864746e+16;} } |> Some
      | 20000252 -> { ConstellationData.id= 20000252; name= "Nasorin"; regionId= 10000020; solarSystemIds= [| 30001700; 30001701; 30001702; 30001703; 30001704; 30001705; 30001706; 30001707 |]; position= {x = -2.21051491e+17;  y = 6.851643591e+16;  z = -1.107363568e+17;} } |> Some
      | 20000349 -> { ConstellationData.id= 20000349; name= "PG-RWX"; regionId= 10000027; solarSystemIds= [| 30002377; 30002378; 30002379; 30002380; 30002381; 30002382 |]; position= {x = 1.626161275e+17;  y = 5.980319277e+16;  z = 3.586434468e+16;} } |> Some
      | 20000446 -> { ConstellationData.id= 20000446; name= "Elalan"; regionId= 10000037; solarSystemIds= [| 30003045; 30003047; 30003048; 30003049; 30003050; 30003051; 30003052; 30003053; 30003054; 30003055; 30003056 |]; position= {x = -2.155835796e+17;  y = 2.141388335e+16;  z = 2.489798646e+16;} } |> Some
      | 20000543 -> { ConstellationData.id= 20000543; name= "I9B-8X"; regionId= 10000047; solarSystemIds= [| 30003723; 30003724; 30003725; 30003726; 30003727; 30003728 |]; position= {x = -1.269451019e+17;  y = 7.144120767e+16;  z = -1.285377155e+17;} } |> Some
      | 20000640 -> { ConstellationData.id= 20000640; name= "XPBM-F"; regionId= 10000055; solarSystemIds= [| 30004378; 30004379; 30004380; 30004381; 30004382; 30004383 |]; position= {x = -1.903676228e+17;  y = 6.208893292e+16;  z = 4.085156604e+17;} } |> Some
      | 20000737 -> { ConstellationData.id= 20000737; name= "Gebem"; regionId= 10000065; solarSystemIds= [| 30005036; 30005037; 30005038; 30005039; 30005040; 30005041; 30005042; 30005043; 30045042 |]; position= {x = -2.634797564e+17;  y = 3.56289899e+16;  z = -1.013017648e+17;} } |> Some
      | 21000031 -> { ConstellationData.id= 21000031; name= "B-C00031"; regionId= 11000005; solarSystemIds= [| 31000459; 31000460; 31000461; 31000462; 31000463; 31000464; 31000465; 31000466; 31000467 |]; position= {x = 7.837511962e+18;  y = 1.757467747e+16;  z = -9.454994389e+18;} } |> Some
      | 21000128 -> { ConstellationData.id= 21000128; name= "C-C00128"; regionId= 11000013; solarSystemIds= [| 31001214; 31001215; 31001216; 31001217; 31001218; 31001219; 31001220 |]; position= {x = 7.74485478e+18;  y = 2.218373331e+16;  z = -9.202377999e+18;} } |> Some
      | 21000225 -> { ConstellationData.id= 21000225; name= "D-C00225"; regionId= 11000022; solarSystemIds= [| 31001840; 31001841; 31001842; 31001843; 31001844; 31001845 |]; position= {x = 8.037159433e+18;  y = 2.173541899e+15;  z = -9.209874804e+18;} } |> Some
      | 21000322 -> { ConstellationData.id= 21000322; name= "A-C00322"; regionId= 11000001; solarSystemIds= [| 31000117; 31000118; 31000119; 31000120; 31000121; 31000122; 31000123; 31000124; 31000125; 31000126; 31000127 |]; position= {x = 7.630957472e+18;  y = 2.445434238e+16;  z = -9.538065456e+18;} } |> Some
      | 22000004 -> { ConstellationData.id= 22000004; name= "ADC04"; regionId= 12000001; solarSystemIds= [| 32000025; 32000026; 32000027; 32000028; 32000029; 32000030; 32000031; 32000032 |]; position= {x = 3.191469181e+18;  y = 4.937292619e+18;  z = -5.56211428e+18;} } |> Some
      | _ -> None