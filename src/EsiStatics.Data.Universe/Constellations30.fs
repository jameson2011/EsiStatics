namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations30=
    let getConstellation id = 
      match id with 
      | 20000072 -> { ConstellationData.id= 20000072; name= "3R-BJL"; regionId= 10000005; solarSystemIds= [| 30000494; 30000495; 30000496; 30000497; 30000498; 30000499 |]; position= {x = 2.089948922e+17;  y = -1.295298242e+16;  z = -1.94787267e+17;} } |> Some
      | 20000169 -> { ConstellationData.id= 20000169; name= "UX3-N2"; regionId= 10000014; solarSystemIds= [| 30001153; 30001154; 30001155; 30001156; 30001157; 30001158; 30001159; 30001160; 30001161; 30001162 |]; position= {x = -8.144235532e+16;  y = 8.63192348e+15;  z = -2.142002604e+17;} } |> Some
      | 20000266 -> { ConstellationData.id= 20000266; name= "6GU-AT"; regionId= 10000021; solarSystemIds= [| 30001796; 30001797; 30001798; 30001799; 30001800; 30001801; 30001802; 30001803; 30001804 |]; position= {x = 2.53707828e+17;  y = -2.481555079e+16;  z = 2.46901956e+16;} } |> Some
      | 20000363 -> { ConstellationData.id= 20000363; name= "F-ZNNG"; regionId= 10000029; solarSystemIds= [| 30002473; 30002474; 30002475; 30002476; 30002477; 30002478; 30002479; 30002480 |]; position= {x = -3.38612283e+16;  y = 2.354198578e+16;  z = 9.554263702e+16;} } |> Some
      | 20000460 -> { ConstellationData.id= 20000460; name= "E-ILCH"; regionId= 10000039; solarSystemIds= [| 30003148; 30003149; 30003150; 30003151; 30003152; 30003153 |]; position= {x = -6.93960781e+16;  y = -2.507409647e+16;  z = -4.508875357e+17;} } |> Some
      | 20000557 -> { ConstellationData.id= 20000557; name= "Unour"; regionId= 10000048; solarSystemIds= [| 30003812; 30003813; 30003814; 30003815; 30003816; 30003817 |]; position= {x = -2.611386222e+17;  y = 8.653982686e+16;  z = 9.262079895e+16;} } |> Some
      | 20000654 -> { ConstellationData.id= 20000654; name= "42-WDG"; regionId= 10000056; solarSystemIds= [| 30004478; 30004479; 30004480; 30004481; 30004482; 30004483; 30004484; 30004485; 30004486 |]; position= {x = 4.083881335e+16;  y = -4.709668742e+16;  z = -4.489659615e+17;} } |> Some
      | 20000751 -> { ConstellationData.id= 20000751; name= "VT-LHB"; regionId= 10000066; solarSystemIds= [| 30005129; 30005130; 30005131; 30005132; 30005133; 30005134; 30005135; 30005136; 30005137; 30005138 |]; position= {x = 1.764843454e+17;  y = 4.307899492e+16;  z = 9.834434911e+16;} } |> Some
      | 21000045 -> { ConstellationData.id= 21000045; name= "B-C00045"; regionId= 11000006; solarSystemIds= [| 31000602; 31000603; 31000604; 31000605; 31000606; 31000607; 31000608; 31000609; 31000610; 31000611; 31000612; 31000613 |]; position= {x = 7.85348029e+18;  y = 2.034137969e+16;  z = -9.666219432e+18;} } |> Some
      | 21000142 -> { ConstellationData.id= 21000142; name= "C-C00142"; regionId= 11000014; solarSystemIds= [| 31001305; 31001306; 31001307; 31001308; 31001309; 31001310 |]; position= {x = 7.901821373e+18;  y = 1.681066961e+16;  z = -9.296273513e+18;} } |> Some
      | 21000239 -> { ConstellationData.id= 21000239; name= "E-C00239"; regionId= 11000024; solarSystemIds= [| 31001934; 31001935; 31001936; 31001937; 31001938; 31001939; 31001940; 31001941; 31001942; 31002500 |]; position= {x = 7.156073425e+18;  y = 2.729326421e+16;  z = -9.408359262e+18;} } |> Some
      | 22000018 -> { ConstellationData.id= 22000018; name= "ADC18"; regionId= 12000004; solarSystemIds= [| 32000137; 32000138; 32000139; 32000140; 32000141; 32000142; 32000143; 32000144 |]; position= {x = 4.330324318e+18;  y = 5.316479591e+18;  z = -5.99827771e+18;} } |> Some
      | _ -> None