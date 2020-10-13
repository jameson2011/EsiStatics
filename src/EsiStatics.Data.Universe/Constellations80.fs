namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations80=
    let getConstellation id = 
      match id with 
      | 20000025 -> { ConstellationData.id= 20000025; name= "Otsabaira"; regionId= 10000002; solarSystemIds= [| 30000173; 30000174; 30000175; 30000176; 30000177; 30000178; 30000179 |]; position= {x = -8.936585472e+16;  y = 7.809834969e+16;  z = 1.228152432e+17;} } |> Some
      | 20000122 -> { ConstellationData.id= 20000122; name= "TL-FDN"; regionId= 10000009; solarSystemIds= [| 30000831; 30000832; 30000833; 30000834; 30000835; 30000836; 30000837 |]; position= {x = 1.655956726e+17;  y = 4.688732254e+16;  z = -9.836633131e+16;} } |> Some
      | 20000219 -> { ConstellationData.id= 20000219; name= "4I-WP1"; regionId= 10000017; solarSystemIds= [| 30001486; 30001487; 30001488; 30001489; 30001490; 30001491 |]; position= {x = 1.401313869e+16;  y = 5.987491258e+16;  z = 1.838569765e+17;} } |> Some
      | 20000316 -> { ConstellationData.id= 20000316; name= "4MY-AB"; regionId= 10000025; solarSystemIds= [| 30002145; 30002146; 30002147; 30002148; 30002149; 30002150; 30002151; 30002152 |]; position= {x = 1.099697389e+16;  y = 1.749468151e+16;  z = -2.178401618e+17;} } |> Some
      | 20000413 -> { ConstellationData.id= 20000413; name= "Santenpaa"; regionId= 10000033; solarSystemIds= [| 30002814; 30002815; 30002816; 30002817; 30002818; 30002819; 30041392 |]; position= {x = -1.422536986e+17;  y = 1.098576536e+17;  z = 1.2709229e+17;} } |> Some
      | 20000510 -> { ConstellationData.id= 20000510; name= "Zemont"; regionId= 10000043; solarSystemIds= [| 30003493; 30003494; 30003496; 30003497; 30003498; 30003499 |]; position= {x = -1.697708494e+17;  y = 5.031160409e+16;  z = -7.396463191e+16;} } |> Some
      | 20000607 -> { ConstellationData.id= 20000607; name= "Moghiz"; regionId= 10000052; solarSystemIds= [| 30004148; 30004149; 30004150; 30004151; 30004152; 30004153; 30004154 |]; position= {x = -2.103111097e+17;  y = 5.469216269e+16;  z = -7.960300102e+16;} } |> Some
      | 20000704 -> { ConstellationData.id= 20000704; name= "AU-S0B"; regionId= 10000061; solarSystemIds= [| 30004811; 30004812; 30004813; 30004814; 30004815; 30004816 |]; position= {x = -3.114225203e+16;  y = 1.41568678e+16;  z = -2.758335049e+17;} } |> Some
      | 21000095 -> { ConstellationData.id= 21000095; name= "C-C00095"; regionId= 11000011; solarSystemIds= [| 31001001; 31001002; 31001003; 31001004; 31001005; 31001006 |]; position= {x = 7.402449514e+18;  y = 5.039351423e+15;  z = -9.470297091e+18;} } |> Some
      | 21000192 -> { ConstellationData.id= 21000192; name= "D-C00192"; regionId= 11000020; solarSystemIds= [| 31001631; 31001632; 31001633; 31001634; 31001635; 31001636; 31001637 |]; position= {x = 7.400775603e+18;  y = 2.740581923e+16;  z = -9.254428164e+18;} } |> Some
      | 21000289 -> { ConstellationData.id= 21000289; name= "E-C00289"; regionId= 11000029; solarSystemIds= [| 31002303; 31002304; 31002305; 31002306; 31002307; 31002308; 31002309; 31002310; 31002311 |]; position= {x = 7.569582761e+18;  y = 7.744279596e+15;  z = -1.001146182e+19;} } |> Some
      | _ -> None