namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations92=
    let getConstellation id = 
      match id with 
      | 20000037 -> { ConstellationData.id= 20000037; name= "5YHF-H"; regionId= 10000003; solarSystemIds= [| 30000261; 30000262; 30000263; 30000264; 30000265; 30000266; 30000267 |]; position= {x = -6.946072991e+16;  y = 1.072777288e+17;  z = 2.118618336e+17;} } |> Some
      | 20000134 -> { ConstellationData.id= 20000134; name= "K-DLD2"; regionId= 10000011; solarSystemIds= [| 30000912; 30000913; 30000914; 30000915; 30000916; 30000917 |]; position= {x = 2.769092921e+16;  y = 1.391799382e+16;  z = -9.969883322e+16;} } |> Some
      | 20000231 -> { ConstellationData.id= 20000231; name= "E1L-UY"; regionId= 10000018; solarSystemIds= [| 30001568; 30001569; 30001570; 30001571; 30001572; 30001573 |]; position= {x = 2.371994283e+17;  y = 2.046894025e+16;  z = 2.233223776e+16;} } |> Some
      | 20000328 -> { ConstellationData.id= 20000328; name= "Armi"; regionId= 10000043; solarSystemIds= [| 30002236; 30002237; 30002238; 30002239; 30002240; 30002241 |]; position= {x = -2.540499206e+17;  y = 1.299942178e+16;  z = -6.624611398e+16;} } |> Some
      | 20000425 -> { ConstellationData.id= 20000425; name= "Z-D6K5"; regionId= 10000035; solarSystemIds= [| 30002895; 30002896; 30002897; 30002898; 30002899; 30002900; 30002901 |]; position= {x = -2.182658794e+17;  y = 1.09737277e+17;  z = 2.743483231e+17;} } |> Some
      | 20000522 -> { ConstellationData.id= 20000522; name= "Orvanne"; regionId= 10000044; solarSystemIds= [| 30003579; 30003580; 30003581; 30003582; 30003583; 30003584; 30003585; 30003586; 30003587 |]; position= {x = -3.147399608e+17;  y = 3.05444229e+16;  z = -5.566429386e+15;} } |> Some
      | 20000619 -> { ConstellationData.id= 20000619; name= "Anama"; regionId= 10000054; solarSystemIds= [| 30004230; 30004231; 30004232; 30004233; 30004234; 30004235 |]; position= {x = -3.224627916e+17;  y = 7.249403268e+15;  z = -3.851040467e+16;} } |> Some
      | 20000716 -> { ConstellationData.id= 20000716; name= "Y-LRWI"; regionId= 10000062; solarSystemIds= [| 30004890; 30004891; 30004892; 30004893; 30004894; 30004895; 30004896; 30004897 |]; position= {x = 8.06250889e+16;  y = -3.862154567e+16;  z = -3.689342891e+17;} } |> Some
      | 21000010 -> { ConstellationData.id= 21000010; name= "A-C00010"; regionId= 11000002; solarSystemIds= [| 31000239; 31000240; 31000241; 31000242; 31000243; 31000244; 31000245; 31000246; 31000247; 31000248; 31000249; 31000250 |]; position= {x = 7.575492901e+18;  y = 2.352478814e+16;  z = -9.400982361e+18;} } |> Some
      | 21000107 -> { ConstellationData.id= 21000107; name= "C-C00107"; regionId= 11000012; solarSystemIds= [| 31001080; 31001081; 31001082; 31001083; 31001084; 31001085; 31001086 |]; position= {x = 7.488894342e+18;  y = 2.223249308e+16;  z = -9.363731409e+18;} } |> Some
      | 21000204 -> { ConstellationData.id= 21000204; name= "D-C00204"; regionId= 11000021; solarSystemIds= [| 31001707; 31001708; 31001709; 31001710; 31001711; 31001712 |]; position= {x = 7.631014738e+18;  y = 1.760710693e+16;  z = -9.099570268e+18;} } |> Some
      | 21000301 -> { ConstellationData.id= 21000301; name= "F-C00301"; regionId= 11000030; solarSystemIds= [| 31002397; 31002398; 31002399; 31002400; 31002401; 31002402 |]; position= {x = 7.258842617e+18;  y = 3.050598494e+16;  z = -9.85965397e+18;} } |> Some
      | _ -> None