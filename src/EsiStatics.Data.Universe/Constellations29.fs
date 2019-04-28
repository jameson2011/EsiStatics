namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations29=
    let getConstellation id = 
      match id with 
      | 20000071 -> { ConstellationData.id= 20000071; name= "D-95MV"; regionId= 10000005; solarSystemIds= [| 30000485; 30000486; 30000487; 30000488; 30000489; 30000490; 30000491; 30000492; 30000493 |]; position= {x = 1.114120079e+17;  y = -1.20626717e+16;  z = -2.072131713e+17;} } |> Some
      | 20000168 -> { ConstellationData.id= 20000168; name= "2747-4"; regionId= 10000013; solarSystemIds= [| 30001147; 30001148; 30001149; 30001150; 30001151; 30001152 |]; position= {x = 2.048930409e+17;  y = 6.748125491e+16;  z = 8.867340058e+16;} } |> Some
      | 20000265 -> { ConstellationData.id= 20000265; name= "7-ZDOK"; regionId= 10000021; solarSystemIds= [| 30001789; 30001790; 30001791; 30001792; 30001793; 30001794; 30001795 |]; position= {x = 3.05171537e+17;  y = 6.560450813e+16;  z = 1.476272807e+17;} } |> Some
      | 20000362 -> { ConstellationData.id= 20000362; name= "V1G-63"; regionId= 10000029; solarSystemIds= [| 30002467; 30002468; 30002469; 30002470; 30002471; 30002472 |]; position= {x = 1.346962699e+16;  y = 8.448194318e+16;  z = 1.209542487e+17;} } |> Some
      | 20000459 -> { ConstellationData.id= 20000459; name= "7ZRW-G"; regionId= 10000039; solarSystemIds= [| 30003140; 30003141; 30003142; 30003143; 30003144; 30003145; 30003146; 30003147 |]; position= {x = -8.757234082e+16;  y = 2.617548798e+16;  z = -4.386169635e+17;} } |> Some
      | 20000556 -> { ConstellationData.id= 20000556; name= "Josmaert"; regionId= 10000048; solarSystemIds= [| 30003806; 30003807; 30003808; 30003809; 30003810; 30003811 |]; position= {x = -2.650566485e+17;  y = 6.278431864e+16;  z = 8.624185836e+16;} } |> Some
      | 20000653 -> { ConstellationData.id= 20000653; name= "RHG-4O"; regionId= 10000056; solarSystemIds= [| 30004471; 30004472; 30004473; 30004474; 30004475; 30004476; 30004477 |]; position= {x = 7.472199535e+16;  y = 7.618882541e+15;  z = -3.841491083e+17;} } |> Some
      | 20000750 -> { ConstellationData.id= 20000750; name= "4LEZ-6"; regionId= 10000066; solarSystemIds= [| 30005123; 30005124; 30005125; 30005126; 30005127; 30005128 |]; position= {x = 2.32005853e+17;  y = 2.580826761e+16;  z = 1.426081064e+17;} } |> Some
      | 21000044 -> { ConstellationData.id= 21000044; name= "B-C00044"; regionId= 11000006; solarSystemIds= [| 31000591; 31000592; 31000593; 31000594; 31000595; 31000596; 31000597; 31000598; 31000599; 31000600; 31000601 |]; position= {x = 7.812753843e+18;  y = 5.989682479e+15;  z = -9.672335492e+18;} } |> Some
      | 21000141 -> { ConstellationData.id= 21000141; name= "C-C00141"; regionId= 11000014; solarSystemIds= [| 31001299; 31001300; 31001301; 31001302; 31001303; 31001304 |]; position= {x = 7.893287293e+18;  y = 1.816682855e+16;  z = -9.290998635e+18;} } |> Some
      | 21000238 -> { ConstellationData.id= 21000238; name= "E-C00238"; regionId= 11000024; solarSystemIds= [| 31001927; 31001928; 31001929; 31001930; 31001931; 31001932; 31001933; 31002483 |]; position= {x = 7.222202036e+18;  y = 2.399163535e+16;  z = -9.34050936e+18;} } |> Some
      | 22000017 -> { ConstellationData.id= 22000017; name= "ADC17"; regionId= 12000004; solarSystemIds= [| 32000129; 32000130; 32000131; 32000132; 32000133; 32000134; 32000135; 32000136 |]; position= {x = 4.342670011e+18;  y = 5.312236806e+18;  z = -6.250972914e+18;} } |> Some
      | _ -> None