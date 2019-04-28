namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations61=
    let getConstellation id = 
      match id with 
      | 20000006 -> { ConstellationData.id= 20000006; name= "Sazdih"; regionId= 10000001; solarSystemIds= [| 30000038; 30000039; 30000040; 30000041; 30000042; 30000043 |]; position= {x = -6.033625398e+16;  y = 4.132071726e+16;  z = -7.304595161e+16;} } |> Some
      | 20000103 -> { ConstellationData.id= 20000103; name= "02QH-A"; regionId= 10000008; solarSystemIds= [| 30000703; 30000704; 30000705; 30000706; 30000707; 30000708 |]; position= {x = 8.099437227e+16;  y = 1.768952946e+15;  z = -1.039930362e+17;} } |> Some
      | 20000200 -> { ConstellationData.id= 20000200; name= "Haurala"; regionId= 10000016; solarSystemIds= [| 30001368; 30001369; 30001370; 30001371; 30001372; 30001373 |]; position= {x = -1.646822781e+17;  y = 6.999084334e+16;  z = 1.331504471e+17;} } |> Some
      | 20000297 -> { ConstellationData.id= 20000297; name= "304Z-R"; regionId= 10000023; solarSystemIds= [| 30002016; 30002017; 30002018; 30002019; 30002020; 30002021; 30002022 |]; position= {x = -2.771268354e+17;  y = 6.573484119e+16;  z = 2.184850246e+17;} } |> Some
      | 20000394 -> { ConstellationData.id= 20000394; name= "Stion"; regionId= 10000032; solarSystemIds= [| 30002692; 30002693; 30002694; 30002695; 30002696; 30002697; 30002698 |]; position= {x = -1.589355797e+17;  y = 3.216374562e+16;  z = 1.007258412e+16;} } |> Some
      | 20000491 -> { ConstellationData.id= 20000491; name= "JQV5-9"; regionId= 10000041; solarSystemIds= [| 30003368; 30003369; 30003370; 30003371; 30003372; 30003373 |]; position= {x = -3.25136837e+17;  y = 9.117777798e+15;  z = 3.747666357e+16;} } |> Some
      | 20000588 -> { ConstellationData.id= 20000588; name= "4QZ-2M"; regionId= 10000050; solarSystemIds= [| 30004025; 30004026; 30004027; 30004028; 30004029; 30004030 |]; position= {x = -4.210440012e+17;  y = 4.590163705e+16;  z = -2.730390871e+17;} } |> Some
      | 20000685 -> { ConstellationData.id= 20000685; name= "IZ-FBT"; regionId= 10000059; solarSystemIds= [| 30004686; 30004687; 30004688; 30004689; 30004690; 30004691 |]; position= {x = -1.01109038e+17;  y = -3.029210026e+16;  z = -4.701421661e+17;} } |> Some
      | 20000782 -> { ConstellationData.id= 20000782; name= "Okakuola"; regionId= 10000069; solarSystemIds= [| 30045345; 30045346; 30045347; 30045348; 30045349; 30045350; 30045351; 30045352; 30045353; 30045354 |]; position= {x = -1.95768851e+17;  y = 5.915796072e+16;  z = 1.169670414e+17;} } |> Some
      | 21000076 -> { ConstellationData.id= 21000076; name= "C-C00076"; regionId= 11000009; solarSystemIds= [| 31000880; 31000881; 31000882; 31000883; 31000884; 31000885 |]; position= {x = 7.760340454e+18;  y = 2.042759924e+16;  z = -9.845806971e+18;} } |> Some
      | 21000173 -> { ConstellationData.id= 21000173; name= "D-C00173"; regionId= 11000019; solarSystemIds= [| 31001506; 31001507; 31001508; 31001509; 31001510; 31001511; 31001512 |]; position= {x = 7.412175782e+18;  y = 5.659568614e+15;  z = -9.598004725e+18;} } |> Some
      | 21000270 -> { ConstellationData.id= 21000270; name= "E-C00270"; regionId= 11000027; solarSystemIds= [| 31002164; 31002165; 31002166; 31002167; 31002168; 31002169; 31002170 |]; position= {x = 8.161629522e+18;  y = 2.408373156e+16;  z = -9.322133216e+18;} } |> Some
      | _ -> None