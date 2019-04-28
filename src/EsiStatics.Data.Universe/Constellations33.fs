namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations33=
    let getConstellation id = 
      match id with 
      | 20000075 -> { ConstellationData.id= 20000075; name= "HOV-VI"; regionId= 10000005; solarSystemIds= [| 30000514; 30000515; 30000516; 30000517; 30000518; 30000519; 30000520 |]; position= {x = 5.808591781e+16;  y = -2.887727647e+16;  z = -2.199870462e+17;} } |> Some
      | 20000172 -> { ConstellationData.id= 20000172; name= "ZW-BY5"; regionId= 10000014; solarSystemIds= [| 30001176; 30001177; 30001178; 30001179; 30001180; 30001181 |]; position= {x = -7.387798318e+16;  y = 1.237717833e+16;  z = -1.775586852e+17;} } |> Some
      | 20000269 -> { ConstellationData.id= 20000269; name= "C9XB-L"; regionId= 10000021; solarSystemIds= [| 30001818; 30001819; 30001820; 30001821; 30001822; 30001823; 30001824 |]; position= {x = 2.965900171e+17;  y = -3.134723738e+16;  z = 6.603450216e+16;} } |> Some
      | 20000366 -> { ConstellationData.id= 20000366; name= "74IL-O"; regionId= 10000029; solarSystemIds= [| 30002499; 30002500; 30002501; 30002502; 30002503; 30002504 |]; position= {x = -7.854893875e+15;  y = 7.570842341e+16;  z = 9.836384838e+16;} } |> Some
      | 20000463 -> { ConstellationData.id= 20000463; name= "9D1V-O"; regionId= 10000039; solarSystemIds= [| 30003170; 30003171; 30003172; 30003173; 30003174; 30003175; 30003176 |]; position= {x = -5.704780675e+16;  y = -1.762370666e+16;  z = -4.51824163e+17;} } |> Some
      | 20000560 -> { ConstellationData.id= 20000560; name= "Beyt"; regionId= 10000048; solarSystemIds= [| 30003830; 30003831; 30003832; 30003833; 30003834; 30003835 |]; position= {x = -2.950508067e+17;  y = 3.368729263e+16;  z = 1.187785255e+17;} } |> Some
      | 20000657 -> { ConstellationData.id= 20000657; name= "Heart"; regionId= 10000057; solarSystemIds= [| 30004501; 30004502; 30004503; 30004504; 30004505; 30004506; 30004507 |]; position= {x = -3.682942009e+17;  y = 2.521537448e+16;  z = 8.65463244e+16;} } |> Some
      | 20000754 -> { ConstellationData.id= 20000754; name= "TY0-Q2"; regionId= 10000066; solarSystemIds= [| 30005152; 30005153; 30005154; 30005155; 30005156; 30005157 |]; position= {x = 2.333328998e+17;  y = 3.199044533e+16;  z = 6.909895051e+16;} } |> Some
      | 21000048 -> { ConstellationData.id= 21000048; name= "B-C00048"; regionId= 11000006; solarSystemIds= [| 31000632; 31000633; 31000634; 31000635; 31000636; 31000637; 31000638; 31000639; 31000640 |]; position= {x = 7.795217744e+18;  y = 2.004146872e+16;  z = -9.627835693e+18;} } |> Some
      | 21000145 -> { ConstellationData.id= 21000145; name= "C-C00145"; regionId= 11000015; solarSystemIds= [| 31001323; 31001324; 31001325; 31001326; 31001327; 31001328 |]; position= {x = 7.97026238e+18;  y = 4.085864632e+16;  z = -9.410344808e+18;} } |> Some
      | 21000242 -> { ConstellationData.id= 21000242; name= "E-C00242"; regionId= 11000024; solarSystemIds= [| 31001961; 31001962; 31001963; 31001964; 31001965; 31001966; 31001967 |]; position= {x = 7.197483768e+18;  y = 2.948919725e+16;  z = -9.399472554e+18;} } |> Some
      | 22000021 -> { ConstellationData.id= 22000021; name= "ADC21"; regionId= 12000005; solarSystemIds= [| 32000161; 32000162; 32000163; 32000164; 32000165; 32000166; 32000167; 32000168 |]; position= {x = 4.940727419e+18;  y = 5.585770689e+18;  z = -8.914984173e+18;} } |> Some
      | _ -> None