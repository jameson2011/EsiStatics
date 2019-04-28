namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations72=
    let getConstellation id = 
      match id with 
      | 20000017 -> { ConstellationData.id= 20000017; name= "Ruomo"; regionId= 10000002; solarSystemIds= [| 30000119; 30000120; 30000121; 30000122; 30000123; 30000124; 30000125 |]; position= {x = -1.113283829e+17;  y = 4.712423723e+16;  z = 1.08042345e+17;} } |> Some
      | 20000114 -> { ConstellationData.id= 20000114; name= "UR-HG4"; regionId= 10000009; solarSystemIds= [| 30000777; 30000778; 30000779; 30000780; 30000781; 30000782 |]; position= {x = 1.292997211e+17;  y = -1.217242054e+16;  z = -1.418533032e+17;} } |> Some
      | 20000211 -> { ConstellationData.id= 20000211; name= "Umamon"; regionId= 10000016; solarSystemIds= [| 30001437; 30001438; 30001439; 30001440; 30001441; 30001442 |]; position= {x = -2.334661099e+17;  y = 7.255552799e+16;  z = 1.938781763e+17;} } |> Some
      | 20000308 -> { ConstellationData.id= 20000308; name= "Essin"; regionId= 10000042; solarSystemIds= [| 30002090; 30002091; 30002092; 30002093; 30002094; 30002095; 30002096 |]; position= {x = -1.324840067e+17;  y = 1.780761877e+16;  z = 2.112889739e+16;} } |> Some
      | 20000405 -> { ConstellationData.id= 20000405; name= "Caldari Border Zone"; regionId= 10000033; solarSystemIds= [| 30002761; 30002762; 30002763; 30002764; 30002765; 30002766 |]; position= {x = -1.851012738e+17;  y = 5.350282953e+16;  z = 6.076699998e+16;} } |> Some
      | 20000502 -> { ConstellationData.id= 20000502; name= "Inkelm"; regionId= 10000042; solarSystemIds= [| 30003441; 30003442; 30003443; 30003444; 30003445; 30003446 |]; position= {x = -5.744583141e+16;  y = 6.544753618e+16;  z = 4.71503893e+16;} } |> Some
      | 20000599 -> { ConstellationData.id= 20000599; name= "Trigentia"; regionId= 10000052; solarSystemIds= [| 30004098; 30004099; 30004100; 30004101; 30004102; 30004103; 30015042 |]; position= {x = -2.482659966e+17;  y = 3.964752995e+16;  z = -1.103417365e+17;} } |> Some
      | 20000696 -> { ConstellationData.id= 20000696; name= "O-EIMK"; regionId= 10000060; solarSystemIds= [| 30004759; 30004760; 30004761; 30004762; 30004763; 30004764; 30004765 |]; position= {x = -4.521852509e+17;  y = 3.847204019e+16;  z = -2.522259862e+17;} } |> Some
      | 21000087 -> { ConstellationData.id= 21000087; name= "C-C00087"; regionId= 11000010; solarSystemIds= [| 31000949; 31000950; 31000951; 31000952; 31000953; 31000954 |]; position= {x = 7.466792401e+18;  y = 8.692054029e+15;  z = -9.72676284e+18;} } |> Some
      | 21000184 -> { ConstellationData.id= 21000184; name= "D-C00184"; regionId= 11000019; solarSystemIds= [| 31001580; 31001581; 31001582; 31001583; 31001584; 31001585 |]; position= {x = 7.447350901e+18;  y = 1.650124128e+16;  z = -9.545142466e+18;} } |> Some
      | 21000281 -> { ConstellationData.id= 21000281; name= "E-C00281"; regionId= 11000028; solarSystemIds= [| 31002244; 31002245; 31002246; 31002247; 31002248; 31002249; 31002250 |]; position= {x = 8.033298729e+18;  y = 1.308599368e+16;  z = -9.911488574e+18;} } |> Some
      | _ -> None