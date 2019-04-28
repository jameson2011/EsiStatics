namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations12=
    let getConstellation id = 
      match id with 
      | 20000054 -> { ConstellationData.id= 20000054; name= "9RW5-Z"; regionId= 10000004; solarSystemIds= [| 30000376; 30000377; 30000378; 30000379; 30000380; 30000381 |]; position= {x = 8.788569391e+16;  y = 1.386503912e+16;  z = 1.643773229e+17;} } |> Some
      | 20000151 -> { ConstellationData.id= 20000151; name= "Rapture"; regionId= 10000012; solarSystemIds= [| 30001029; 30001030; 30001031; 30001032; 30001033; 30001034; 30001035 |]; position= {x = 2.976229673e+16;  y = -3.448459593e+15;  z = -1.599603198e+17;} } |> Some
      | 20000248 -> { ConstellationData.id= 20000248; name= "Mimishia"; regionId= 10000020; solarSystemIds= [| 30001675; 30001676; 30001677; 30001678; 30001679; 30001680 |]; position= {x = -2.119589805e+17;  y = 4.558388212e+16;  z = -1.082027533e+17;} } |> Some
      | 20000345 -> { ConstellationData.id= 20000345; name= "8AO-5V"; regionId= 10000027; solarSystemIds= [| 30002350; 30002351; 30002352; 30002353; 30002354; 30002355 |]; position= {x = 9.728974036e+16;  y = 5.617897029e+16;  z = 5.197896101e+16;} } |> Some
      | 20000442 -> { ConstellationData.id= 20000442; name= "Chasnaye"; regionId= 10000037; solarSystemIds= [| 30003017; 30003018; 30003019; 30003020; 30003021; 30003022; 30003023 |]; position= {x = -1.74060447e+17;  y = 1.629119305e+16;  z = 2.052526914e+16;} } |> Some
      | 20000539 -> { ConstellationData.id= 20000539; name= "VNX-P0"; regionId= 10000046; solarSystemIds= [| 30003697; 30003698; 30003699; 30003700; 30003701; 30003702 |]; position= {x = -3.219625861e+17;  y = 6.336086273e+16;  z = 2.622103356e+17;} } |> Some
      | 20000636 -> { ConstellationData.id= 20000636; name= "BZ-10K"; regionId= 10000055; solarSystemIds= [| 30004351; 30004352; 30004353; 30004354; 30004355; 30004356 |]; position= {x = -1.624152861e+17;  y = 5.24354705e+16;  z = 4.106803484e+17;} } |> Some
      | 20000733 -> { ConstellationData.id= 20000733; name= "Arand"; regionId= 10000064; solarSystemIds= [| 30005009; 30005010; 30005011; 30005012; 30005013; 30005014 |]; position= {x = -2.115084042e+17;  y = 1.673231705e+16;  z = 5.672697178e+16;} } |> Some
      | 21000027 -> { ConstellationData.id= 21000027; name= "B-C00027"; regionId= 11000004; solarSystemIds= [| 31000418; 31000419; 31000420; 31000421; 31000422; 31000423; 31000424; 31000425; 31000426 |]; position= {x = 7.728278219e+18;  y = 2.677785379e+16;  z = -9.353824134e+18;} } |> Some
      | 21000124 -> { ConstellationData.id= 21000124; name= "C-C00124"; regionId= 11000013; solarSystemIds= [| 31001190; 31001191; 31001192; 31001193; 31001194; 31001195 |]; position= {x = 7.681608818e+18;  y = 2.957019137e+16;  z = -9.253480779e+18;} } |> Some
      | 21000221 -> { ConstellationData.id= 21000221; name= "D-C00221"; regionId= 11000022; solarSystemIds= [| 31001814; 31001815; 31001816; 31001817; 31001818; 31001819 |]; position= {x = 8.009745002e+18;  y = 8.727761075e+15;  z = -9.26464723e+18;} } |> Some
      | 21000318 -> { ConstellationData.id= 21000318; name= "A-C00318"; regionId= 11000001; solarSystemIds= [| 31000072; 31000073; 31000074; 31000075; 31000076; 31000077; 31000078; 31000079; 31000080; 31000081; 31000082; 31000083 |]; position= {x = 7.647851949e+18;  y = 1.970095941e+15;  z = -9.496176254e+18;} } |> Some
      | _ -> None