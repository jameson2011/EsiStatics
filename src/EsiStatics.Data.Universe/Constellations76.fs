namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations76=
    let getConstellation id = 
      match id with 
      | 20000021 -> { ConstellationData.id= 20000021; name= "Okomon"; regionId= 10000002; solarSystemIds= [| 30000146; 30000147; 30000148; 30000149; 30000150; 30000151; 30000152 |]; position= {x = -9.693075287e+16;  y = 6.667147806e+16;  z = 1.017411146e+17;} } |> Some
      | 20000118 -> { ConstellationData.id= 20000118; name= "N5V-Y0"; regionId= 10000009; solarSystemIds= [| 30000802; 30000803; 30000804; 30000805; 30000806; 30000807 |]; position= {x = 1.375599389e+17;  y = 1.766886366e+16;  z = -1.073835005e+17;} } |> Some
      | 20000215 -> { ConstellationData.id= 20000215; name= "05-1B6"; regionId= 10000017; solarSystemIds= [| 30001461; 30001462; 30001463; 30001464; 30001465; 30001466 |]; position= {x = 2.430976479e+16;  y = 8.537732857e+16;  z = 2.185085002e+17;} } |> Some
      | 20000312 -> { ConstellationData.id= 20000312; name= "MY-QQI"; regionId= 10000025; solarSystemIds= [| 30002117; 30002118; 30002119; 30002120; 30002121; 30002122 |]; position= {x = -2.28953869e+16;  y = 1.593947894e+15;  z = -2.047200377e+17;} } |> Some
      | 20000409 -> { ConstellationData.id= 20000409; name= "Suon"; regionId= 10000033; solarSystemIds= [| 30002788; 30002789; 30002790; 30002791; 30002792; 30002793; 30040141 |]; position= {x = -1.35047089e+17;  y = 8.207942488e+16;  z = 8.246306012e+16;} } |> Some
      | 20000506 -> { ConstellationData.id= 20000506; name= "Hulf"; regionId= 10000042; solarSystemIds= [| 30003467; 30003468; 30003469; 30003470; 30003471; 30003472 |]; position= {x = -1.053613927e+16;  y = 3.456770894e+16;  z = 4.108112705e+16;} } |> Some
      | 20000603 -> { ConstellationData.id= 20000603; name= "Araz"; regionId= 10000052; solarSystemIds= [| 30004122; 30004123; 30004124; 30004125; 30004126; 30004127; 30004128; 30004129 |]; position= {x = -2.402155514e+17;  y = 3.604199345e+16;  z = -3.69971979e+16;} } |> Some
      | 20000700 -> { ConstellationData.id= 20000700; name= "1-A81R"; regionId= 10000060; solarSystemIds= [| 30004784; 30004785; 30004786; 30004787; 30004788; 30004789 |]; position= {x = -4.637524661e+17;  y = 5.28053747e+16;  z = -2.374909867e+17;} } |> Some
      | 21000091 -> { ConstellationData.id= 21000091; name= "C-C00091"; regionId= 11000010; solarSystemIds= [| 31000974; 31000975; 31000976; 31000977; 31000978; 31000979 |]; position= {x = 7.468877213e+18;  y = 3.164986098e+16;  z = -9.670059559e+18;} } |> Some
      | 21000188 -> { ConstellationData.id= 21000188; name= "D-C00188"; regionId= 11000020; solarSystemIds= [| 31001606; 31001607; 31001608; 31001609; 31001610; 31001611 |]; position= {x = 7.413956837e+18;  y = 9.160685206e+15;  z = -9.221574053e+18;} } |> Some
      | 21000285 -> { ConstellationData.id= 21000285; name= "E-C00285"; regionId= 11000028; solarSystemIds= [| 31002274; 31002275; 31002276; 31002277; 31002278; 31002279; 31002280; 31002281; 31002282 |]; position= {x = 8.06259931e+18;  y = 1.383804459e+16;  z = -9.939171132e+18;} } |> Some
      | _ -> None