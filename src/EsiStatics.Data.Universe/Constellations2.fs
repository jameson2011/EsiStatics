namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations2=
    let getConstellation id = 
      match id with 
      | 20000044 -> { ConstellationData.id= 20000044; name= "E-8CSQ"; regionId= 10000003; solarSystemIds= [| 30000307; 30000308; 30000309; 30000310; 30000311; 30000312; 30000313 |]; position= {x = -1.514667562e+15;  y = 8.165296036e+16;  z = 1.754359091e+17;} } |> Some
      | 20000141 -> { ConstellationData.id= 20000141; name= "V-4QJC"; regionId= 10000011; solarSystemIds= [| 30000964; 30000965; 30000966; 30000967; 30000968; 30000969; 30000970 |]; position= {x = 1.734283933e+16;  y = -4.417019452e+15;  z = -4.360851312e+16;} } |> Some
      | 20000238 -> { ConstellationData.id= 20000238; name= "826-A5"; regionId= 10000019; solarSystemIds= [| 30001610; 30001611; 30001612; 30001613; 30001614; 30001615; 30001616; 30001617 |]; position= {x = 1.683904922e+16;  y = 7.404362917e+16;  z = 2.8276608e+17;} } |> Some
      | 20000335 -> { ConstellationData.id= 20000335; name= "4M6-GJ"; regionId= 10000027; solarSystemIds= [| 30002283; 30002284; 30002285; 30002286; 30002287; 30002288 |]; position= {x = 1.385532579e+17;  y = 6.760625069e+16;  z = 3.407578377e+16;} } |> Some
      | 20000432 -> { ConstellationData.id= 20000432; name= "D-AWFI"; regionId= 10000035; solarSystemIds= [| 30002951; 30002952; 30002953; 30002954; 30002955; 30002956 |]; position= {x = -3.572884588e+17;  y = 1.076129784e+17;  z = 3.528117256e+17;} } |> Some
      | 20000529 -> { ConstellationData.id= 20000529; name= "TJ10-O"; regionId= 10000045; solarSystemIds= [| 30003629; 30003630; 30003631; 30003632; 30003633; 30003634; 30003635 |]; position= {x = -5.885817331e+16;  y = 5.061150522e+16;  z = 4.300236727e+17;} } |> Some
      | 20000626 -> { ConstellationData.id= 20000626; name= "Leseasesh"; regionId= 10000054; solarSystemIds= [| 30004280; 30004281; 30004282; 30004283; 30004284; 30004285; 30004286; 30004287 |]; position= {x = -3.836783595e+17;  y = -6.631790011e+14;  z = -8.67890041e+16;} } |> Some
      | 20000723 -> { ConstellationData.id= 20000723; name= "J8-G8K"; regionId= 10000063; solarSystemIds= [| 30004940; 30004941; 30004942; 30004943; 30004944; 30004945; 30004946 |]; position= {x = -3.888057454e+17;  y = 9.996571127e+16;  z = -3.746006215e+17;} } |> Some
      | 21000017 -> { ConstellationData.id= 21000017; name= "A-C00017"; regionId= 11000003; solarSystemIds= [| 31000314; 31000315; 31000316; 31000317; 31000318; 31000319; 31000320; 31000321; 31000322 |]; position= {x = 7.718357799e+18;  y = 2.324591951e+16;  z = -9.359185202e+18;} } |> Some
      | 21000114 -> { ConstellationData.id= 21000114; name= "C-C00114"; regionId= 11000012; solarSystemIds= [| 31001127; 31001128; 31001129; 31001130; 31001131; 31001132; 31001133 |]; position= {x = 7.453349893e+18;  y = 1.712612758e+16;  z = -9.314973656e+18;} } |> Some
      | 21000211 -> { ConstellationData.id= 21000211; name= "D-C00211"; regionId= 11000021; solarSystemIds= [| 31001753; 31001754; 31001755; 31001756; 31001757; 31001758 |]; position= {x = 7.612427557e+18;  y = 5.162544529e+16;  z = -9.135593331e+18;} } |> Some
      | 21000308 -> { ConstellationData.id= 21000308; name= "F-C00308"; regionId= 11000030; solarSystemIds= [| 31002449; 31002450; 31002451; 31002452; 31002453; 31002454; 31002455; 31002456 |]; position= {x = 7.321196575e+18;  y = 2.564578928e+16;  z = -9.865987076e+18;} } |> Some
      | _ -> None