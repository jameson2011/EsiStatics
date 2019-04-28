namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations26=
    let getConstellation id = 
      match id with 
      | 20000068 -> { ConstellationData.id= 20000068; name= "5P4-QA"; regionId= 10000005; solarSystemIds= [| 30000466; 30000467; 30000468; 30000469; 30000470; 30000471 |]; position= {x = 1.461819729e+17;  y = -1.845768831e+16;  z = -2.117558805e+17;} } |> Some
      | 20000165 -> { ConstellationData.id= 20000165; name= "WS5L-X"; regionId= 10000013; solarSystemIds= [| 30001126; 30001127; 30001128; 30001129; 30001130; 30001131 |]; position= {x = 1.694106885e+17;  y = 8.466253266e+16;  z = 1.07396066e+17;} } |> Some
      | 20000262 -> { ConstellationData.id= 20000262; name= "U-IOR1"; regionId= 10000021; solarSystemIds= [| 30001768; 30001769; 30001770; 30001771; 30001772; 30001773 |]; position= {x = 3.29288472e+17;  y = -2.148122851e+16;  z = 8.039228574e+16;} } |> Some
      | 20000359 -> { ConstellationData.id= 20000359; name= "8K-CHA"; regionId= 10000029; solarSystemIds= [| 30002444; 30002445; 30002446; 30002447; 30002448; 30002449; 30002450 |]; position= {x = -5.169761772e+15;  y = 8.412333331e+16;  z = 1.28732311e+17;} } |> Some
      | 20000456 -> { ConstellationData.id= 20000456; name= "JSZ-X6"; regionId= 10000039; solarSystemIds= [| 30003119; 30003120; 30003121; 30003122; 30003123; 30003124 |]; position= {x = -7.054371762e+16;  y = -1.692080331e+16;  z = -4.221375496e+17;} } |> Some
      | 20000553 -> { ConstellationData.id= 20000553; name= "Viriette"; regionId= 10000048; solarSystemIds= [| 30003787; 30003788; 30003789; 30003790; 30003791; 30003792; 30003793 |]; position= {x = -2.579400791e+17;  y = 3.787448906e+16;  z = 7.204133987e+16;} } |> Some
      | 20000650 -> { ConstellationData.id= 20000650; name= "3-U491"; regionId= 10000056; solarSystemIds= [| 30004450; 30004451; 30004452; 30004453; 30004454; 30004455; 30004456; 30004457; 30004458 |]; position= {x = -3.545908412e+15;  y = -4.753884131e+16;  z = -3.892333684e+17;} } |> Some
      | 20000747 -> { ConstellationData.id= 20000747; name= "B-MQ0Y"; regionId= 10000066; solarSystemIds= [| 30005100; 30005101; 30005102; 30005103; 30005104; 30005105 |]; position= {x = 2.472644085e+17;  y = 2.829254337e+16;  z = 5.334326465e+16;} } |> Some
      | 21000041 -> { ConstellationData.id= 21000041; name= "B-C00041"; regionId= 11000006; solarSystemIds= [| 31000561; 31000562; 31000563; 31000564; 31000565; 31000566; 31000567; 31000568; 31000569; 31000570 |]; position= {x = 7.830583726e+18;  y = 2.366532814e+16;  z = -9.641264147e+18;} } |> Some
      | 21000138 -> { ConstellationData.id= 21000138; name= "C-C00138"; regionId= 11000014; solarSystemIds= [| 31001279; 31001280; 31001281; 31001282; 31001283; 31001284 |]; position= {x = 7.929729162e+18;  y = 3.61743582e+16;  z = -9.311027405e+18;} } |> Some
      | 21000235 -> { ConstellationData.id= 21000235; name= "E-C00235"; regionId= 11000024; solarSystemIds= [| 31001907; 31001908; 31001909; 31001910; 31001911; 31001912; 31001913 |]; position= {x = 7.221007494e+18;  y = -1.389670733e+16;  z = -9.371745884e+18;} } |> Some
      | 21000332 -> { ConstellationData.id= 21000332; name= "H-C00332"; regionId= 11000032; solarSystemIds= [| 31002584; 31002585; 31002586; 31002587; 31002588; 31002589; 31002590; 31002591; 31002592; 31002593; 31002594 |]; position= {x = 7.596456369e+18;  y = 1.559215604e+18;  z = -9.778102888e+18;} } |> Some
      | 22000014 -> { ConstellationData.id= 22000014; name= "ADC14"; regionId= 12000003; solarSystemIds= [| 32000105; 32000106; 32000107; 32000108; 32000109; 32000110; 32000111; 32000112 |]; position= {x = 4.320852872e+18;  y = 5.033264676e+18;  z = -7.711682241e+18;} } |> Some
      | _ -> None