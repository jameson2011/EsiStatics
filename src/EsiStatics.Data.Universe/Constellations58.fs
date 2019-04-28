namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations58=
    let getConstellation id = 
      match id with 
      | 20000003 -> { ConstellationData.id= 20000003; name= "Mamouna"; regionId= 10000001; solarSystemIds= [| 30000017; 30000018; 30000019; 30000020; 30000021; 30000022 |]; position= {x = -6.654483433e+16;  y = 3.947721775e+16;  z = -1.02442842e+17;} } |> Some
      | 20000100 -> { ConstellationData.id= 20000100; name= "Y-M7ML"; regionId= 10000008; solarSystemIds= [| 30000685; 30000686; 30000687; 30000688; 30000689; 30000690 |]; position= {x = 1.863666087e+16;  y = -2.148566036e+16;  z = -1.580656127e+17;} } |> Some
      | 20000197 -> { ConstellationData.id= 20000197; name= "0KTC-R"; regionId= 10000015; solarSystemIds= [| 30001350; 30001351; 30001352; 30001353; 30001354; 30001355 |]; position= {x = -8.244773216e+16;  y = 9.245443999e+16;  z = 3.604184951e+17;} } |> Some
      | 20000294 -> { ConstellationData.id= 20000294; name= "LY-FY6"; regionId= 10000023; solarSystemIds= [| 30001998; 30001999; 30002000; 30002001; 30002002; 30002003 |]; position= {x = -2.570220793e+17;  y = 1.08211622e+17;  z = 2.149123058e+17;} } |> Some
      | 20000391 -> { ConstellationData.id= 20000391; name= "Jonenor"; regionId= 10000032; solarSystemIds= [| 30002668; 30002669; 30002670; 30002671; 30002672; 30002673; 30002674; 30002675 |]; position= {x = -2.050495427e+17;  y = 4.791479481e+16;  z = 1.472801299e+16;} } |> Some
      | 20000488 -> { ConstellationData.id= 20000488; name= "QS-FVH"; regionId= 10000041; solarSystemIds= [| 30003349; 30003350; 30003351; 30003352; 30003353; 30003354 |]; position= {x = -3.55406788e+17;  y = -7.412017247e+15;  z = 7.652126964e+16;} } |> Some
      | 20000585 -> { ConstellationData.id= 20000585; name= "MPJW-6"; regionId= 10000050; solarSystemIds= [| 30004003; 30004004; 30004005; 30004006; 30004007; 30004008; 30004009; 30004010; 30004011; 30004012 |]; position= {x = -3.48644141e+17;  y = 4.338719159e+16;  z = -2.677795873e+17;} } |> Some
      | 20000682 -> { ConstellationData.id= 20000682; name= "17K-QM"; regionId= 10000059; solarSystemIds= [| 30004667; 30004668; 30004669; 30004670; 30004671; 30004672 |]; position= {x = -8.020240967e+16;  y = -2.471664148e+16;  z = -4.622659453e+17;} } |> Some
      | 20000779 -> { ConstellationData.id= 20000779; name= "Ancbeu"; regionId= 10000068; solarSystemIds= [| 30005322; 30005323; 30005324; 30005325; 30005326; 30005327; 30005328 |]; position= {x = -2.580656014e+17;  y = 3.158253361e+16;  z = 4.112990467e+16;} } |> Some
      | 21000073 -> { ConstellationData.id= 21000073; name= "B-C00073"; regionId= 11000008; solarSystemIds= [| 31000877 |]; position= {x = 7.527673948e+18;  y = 7.262784709e+15;  z = -9.665344503e+18;} } |> Some
      | 21000170 -> { ConstellationData.id= 21000170; name= "D-C00170"; regionId= 11000018; solarSystemIds= [| 31001486; 31001487; 31001488; 31001489; 31001490; 31001491; 31001492 |]; position= {x = 7.570669656e+18;  y = 9.778988789e+15;  z = -9.695408488e+18;} } |> Some
      | 21000267 -> { ConstellationData.id= 21000267; name= "E-C00267"; regionId= 11000027; solarSystemIds= [| 31002140; 31002141; 31002142; 31002143; 31002144; 31002145 |]; position= {x = 8.136337503e+18;  y = 1.582267564e+16;  z = -9.326501164e+18;} } |> Some
      | _ -> None