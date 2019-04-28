namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations10=
    let getConstellation id = 
      match id with 
      | 20000052 -> { ConstellationData.id= 20000052; name= "T7B-VB"; regionId= 10000004; solarSystemIds= [| 30000360; 30000361; 30000362; 30000363; 30000364; 30000365 |]; position= {x = 9.325837483e+16;  y = 5.531347579e+16;  z = 2.298557536e+17;} } |> Some
      | 20000149 -> { ConstellationData.id= 20000149; name= "Elysium"; regionId= 10000012; solarSystemIds= [| 30001016; 30001017; 30001018; 30001019; 30001020; 30001021 |]; position= {x = 1.811817412e+16;  y = 7.080315135e+15;  z = -1.417805662e+17;} } |> Some
      | 20000246 -> { ConstellationData.id= 20000246; name= "Emsek"; regionId= 10000020; solarSystemIds= [| 30001662; 30001663; 30001664; 30001665; 30001666; 30001667; 30001668 |]; position= {x = -1.897623029e+17;  y = 4.659293842e+16;  z = -1.243013115e+17;} } |> Some
      | 20000343 -> { ConstellationData.id= 20000343; name= "ICH-B6"; regionId= 10000027; solarSystemIds= [| 30002337; 30002338; 30002339; 30002340; 30002341; 30002342; 30002343 |]; position= {x = 1.615571415e+17;  y = 4.416673573e+16;  z = 4.94900576e+16;} } |> Some
      | 20000440 -> { ConstellationData.id= 20000440; name= "Enka"; regionId= 10000036; solarSystemIds= [| 30003001; 30003002; 30003003; 30003004; 30003005; 30003006; 30003007; 30003008 |]; position= {x = -1.692823854e+17;  y = 5.356589511e+16;  z = -4.215330206e+16;} } |> Some
      | 20000537 -> { ConstellationData.id= 20000537; name= "UWRZ-2"; regionId= 10000046; solarSystemIds= [| 30003683; 30003684; 30003685; 30003686; 30003687; 30003688; 30003689 |]; position= {x = -2.952593139e+17;  y = 5.270030633e+16;  z = 2.59772209e+17;} } |> Some
      | 20000634 -> { ConstellationData.id= 20000634; name= "GP-GIU"; regionId= 10000055; solarSystemIds= [| 30004335; 30004336; 30004337; 30004338; 30004339; 30004340 |]; position= {x = -1.032083164e+17;  y = 8.515054921e+16;  z = 4.148355735e+17;} } |> Some
      | 20000731 -> { ConstellationData.id= 20000731; name= "Vieres"; regionId= 10000064; solarSystemIds= [| 30004993; 30004994; 30004995; 30004996; 30004997; 30004998; 30004999; 30005000 |]; position= {x = -2.374094584e+17;  y = 2.358254509e+16;  z = 5.89912142e+16;} } |> Some
      | 21000025 -> { ConstellationData.id= 21000025; name= "B-C00025"; regionId= 11000004; solarSystemIds= [| 31000398; 31000399; 31000400; 31000401; 31000402; 31000403; 31000404; 31000405; 31000406; 31000407 |]; position= {x = 7.78322468e+18;  y = 3.20801925e+16;  z = -9.34565939e+18;} } |> Some
      | 21000122 -> { ConstellationData.id= 21000122; name= "C-C00122"; regionId= 11000013; solarSystemIds= [| 31001178; 31001179; 31001180; 31001181; 31001182; 31001183 |]; position= {x = 7.655033493e+18;  y = 2.87028922e+16;  z = -9.192696213e+18;} } |> Some
      | 21000219 -> { ConstellationData.id= 21000219; name= "D-C00219"; regionId= 11000022; solarSystemIds= [| 31001801; 31001802; 31001803; 31001804; 31001805; 31001806 |]; position= {x = 8.032813437e+18;  y = 9.502033641e+15;  z = -9.186026427e+18;} } |> Some
      | 21000316 -> { ConstellationData.id= 21000316; name= "A-C00316"; regionId= 11000001; solarSystemIds= [| 31000054; 31000055; 31000056; 31000057; 31000058; 31000059; 31000060; 31000061; 31000062 |]; position= {x = 7.666125239e+18;  y = 1.606335889e+16;  z = -9.494156893e+18;} } |> Some
      | _ -> None