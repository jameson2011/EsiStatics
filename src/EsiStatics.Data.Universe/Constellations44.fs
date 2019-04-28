namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations44=
    let getConstellation id = 
      match id with 
      | 20000086 -> { ConstellationData.id= 20000086; name= "760-9C"; regionId= 10000006; solarSystemIds= [| 30000593; 30000594; 30000595; 30000596; 30000597; 30000598 |]; position= {x = 9.927712877e+16;  y = -1.304326031e+16;  z = -1.629261737e+17;} } |> Some
      | 20000183 -> { ConstellationData.id= 20000183; name= "BRP2-K"; regionId= 10000014; solarSystemIds= [| 30001254; 30001255; 30001256; 30001257; 30001258; 30001259; 30001260 |]; position= {x = -1.768049413e+17;  y = 3.799258236e+16;  z = -2.568099158e+17;} } |> Some
      | 20000280 -> { ConstellationData.id= 20000280; name= "VH1-NS"; regionId= 10000022; solarSystemIds= [| 30001893; 30001894; 30001895; 30001896; 30001897; 30001898 |]; position= {x = -1.764737663e+17;  y = 4.761583401e+16;  z = -3.155679277e+17;} } |> Some
      | 20000377 -> { ConstellationData.id= 20000377; name= "Erada"; regionId= 10000030; solarSystemIds= [| 30002568; 30002569; 30002570; 30002571; 30002572; 30002573; 30022547; 30032547; 30042547 |]; position= {x = -9.354461432e+16;  y = 4.393528487e+16;  z = 4.448932138e+16;} } |> Some
      | 20000474 -> { ConstellationData.id= 20000474; name= "D4J-PP"; regionId= 10000040; solarSystemIds= [| 30003242; 30003243; 30003244; 30003245; 30003246; 30003247; 30003248 |]; position= {x = 2.497855569e+17;  y = 5.773354249e+16;  z = 1.054808665e+17;} } |> Some
      | 20000571 -> { ConstellationData.id= 20000571; name= "Arniri"; regionId= 10000049; solarSystemIds= [| 30003911; 30003912; 30003913; 30003914; 30003915; 30003916 |]; position= {x = -3.073967423e+17;  y = 2.139963094e+16;  z = -1.216562631e+17;} } |> Some
      | 20000668 -> { ConstellationData.id= 20000668; name= "Sphinx"; regionId= 10000058; solarSystemIds= [| 30004573; 30004574; 30004575; 30004576; 30004577; 30004578; 30004579; 30004580; 30004581; 30004582; 30004583 |]; position= {x = -4.267497368e+17;  y = 2.261571459e+16;  z = 2.873716129e+16;} } |> Some
      | 20000765 -> { ConstellationData.id= 20000765; name= "Ubar"; regionId= 10000067; solarSystemIds= [| 30005229; 30005230; 30005231; 30005232; 30005233; 30005234; 30005235 |]; position= {x = -2.611500842e+17;  y = 1.652243857e+16;  z = 1.310461297e+16;} } |> Some
      | 21000059 -> { ConstellationData.id= 21000059; name= "B-C00059"; regionId= 11000007; solarSystemIds= [| 31000742; 31000743; 31000744; 31000745; 31000746; 31000747; 31000748; 31000749; 31000750; 31000751 |]; position= {x = 7.633484435e+18;  y = 3.449854859e+16;  z = -9.681850151e+18;} } |> Some
      | 21000156 -> { ConstellationData.id= 21000156; name= "D-C00156"; regionId= 11000016; solarSystemIds= [| 31001396; 31001397; 31001398; 31001399; 31001400; 31001401; 31001402 |]; position= {x = 7.958309055e+18;  y = 2.08167196e+16;  z = -9.672319732e+18;} } |> Some
      | 21000253 -> { ConstellationData.id= 21000253; name= "E-C00253"; regionId= 11000025; solarSystemIds= [| 31002041; 31002042; 31002043; 31002044; 31002045; 31002046; 31002047 |]; position= {x = 7.37088753e+18;  y = 1.169729177e+16;  z = -9.090643694e+18;} } |> Some
      | _ -> None