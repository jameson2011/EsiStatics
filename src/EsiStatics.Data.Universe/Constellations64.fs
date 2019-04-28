namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations64=
    let getConstellation id = 
      match id with 
      | 20000009 -> { ConstellationData.id= 20000009; name= "Mekashtad"; regionId= 10000001; solarSystemIds= [| 30000057; 30000058; 30000059; 30000060; 30000061; 30000062; 30000063; 30000064; 30000065; 30000066; 30000067; 30000068; 30000069 |]; position= {x = -7.059112135e+16;  y = 6.779613876e+16;  z = -5.958701616e+16;} } |> Some
      | 20000106 -> { ConstellationData.id= 20000106; name= "YCM-AI"; regionId= 10000008; solarSystemIds= [| 30000721; 30000722; 30000723; 30000724; 30000725; 30000726; 30000727; 30000728; 30000729 |]; position= {x = 3.184976468e+16;  y = -1.982078994e+16;  z = -1.351554257e+17;} } |> Some
      | 20000203 -> { ConstellationData.id= 20000203; name= "Makiriemi"; regionId= 10000016; solarSystemIds= [| 30001386; 30001387; 30001388; 30001389; 30001390; 30001391 |]; position= {x = -1.694579708e+17;  y = 9.701006377e+16;  z = 1.481791164e+17;} } |> Some
      | 20000300 -> { ConstellationData.id= 20000300; name= "S4GH-I"; regionId= 10000023; solarSystemIds= [| 30002035; 30002036; 30002037; 30002038; 30002039; 30002040; 30002041 |]; position= {x = -2.878810916e+17;  y = 5.886086073e+16;  z = 2.018971343e+17;} } |> Some
      | 20000397 -> { ConstellationData.id= 20000397; name= "Nexus"; regionId= 10000032; solarSystemIds= [| 30002712; 30002713; 30002714; 30002715; 30002716; 30002717 |]; position= {x = -1.618208176e+17;  y = 3.801077927e+16;  z = 2.901527332e+16;} } |> Some
      | 20000494 -> { ConstellationData.id= 20000494; name= "Ankard"; regionId= 10000042; solarSystemIds= [| 30003387; 30003388; 30003389; 30003390; 30003391; 30003392; 30043410 |]; position= {x = -9.218200827e+16;  y = 5.913416629e+16;  z = 6.63267393e+16;} } |> Some
      | 20000591 -> { ConstellationData.id= 20000591; name= "Balenne"; regionId= 10000051; solarSystemIds= [| 30004043; 30004044; 30004045; 30004046; 30004047; 30004048; 30004049 |]; position= {x = -3.212993092e+17;  y = 5.800156656e+16;  z = 1.440894112e+17;} } |> Some
      | 20000688 -> { ConstellationData.id= 20000688; name= "XPJ1-6"; regionId= 10000060; solarSystemIds= [| 30004706; 30004707; 30004708; 30004709; 30004710; 30004711 |]; position= {x = -3.932138394e+17;  y = 4.707299997e+16;  z = -2.173346078e+17;} } |> Some
      | 20000785 -> { ConstellationData.id= 20000785; name= "Ishaga"; regionId= 10000069; solarSystemIds= [| 30045338; 30045339; 30045340; 30045341; 30045342; 30045343; 30045344 |]; position= {x = -2.22687068e+17;  y = 1.083683513e+17;  z = 1.360295961e+17;} } |> Some
      | 21000079 -> { ConstellationData.id= 21000079; name= "C-C00079"; regionId= 11000009; solarSystemIds= [| 31000899; 31000900; 31000901; 31000902; 31000903; 31000904 |]; position= {x = 7.747793877e+18;  y = 1.026907418e+16;  z = -9.802581223e+18;} } |> Some
      | 21000176 -> { ConstellationData.id= 21000176; name= "D-C00176"; regionId= 11000019; solarSystemIds= [| 31001527; 31001528; 31001529; 31001530; 31001531; 31001532 |]; position= {x = 7.4214173e+18;  y = 1.776135823e+16;  z = -9.552978436e+18;} } |> Some
      | 21000273 -> { ConstellationData.id= 21000273; name= "E-C00273"; regionId= 11000027; solarSystemIds= [| 31002186; 31002187; 31002188; 31002189; 31002190; 31002191; 31002192; 31002193 |]; position= {x = 8.204253227e+18;  y = 1.035927691e+16;  z = -9.293077347e+18;} } |> Some
      | _ -> None