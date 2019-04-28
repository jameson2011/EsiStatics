namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations9=
    let getConstellation id = 
      match id with 
      | 20000051 -> { ConstellationData.id= 20000051; name= "V8UW-M"; regionId= 10000004; solarSystemIds= [| 30000353; 30000354; 30000355; 30000356; 30000357; 30000358; 30000359 |]; position= {x = 9.885052834e+16;  y = 7.955961935e+16;  z = 2.586380583e+17;} } |> Some
      | 20000148 -> { ConstellationData.id= 20000148; name= "Paradise"; regionId= 10000012; solarSystemIds= [| 30001007; 30001008; 30001009; 30001010; 30001011; 30001012; 30001013; 30001014; 30001015 |]; position= {x = 1.713646649e+16;  y = 4.157756309e+15;  z = -1.621731582e+17;} } |> Some
      | 20000245 -> { ConstellationData.id= 20000245; name= "Mise"; regionId= 10000020; solarSystemIds= [| 30001656; 30001657; 30001658; 30001659; 30001660; 30001661 |]; position= {x = -1.98950511e+17;  y = 7.240894544e+16;  z = -1.304551883e+17;} } |> Some
      | 20000342 -> { ConstellationData.id= 20000342; name= "RDD-E6"; regionId= 10000027; solarSystemIds= [| 30002331; 30002332; 30002333; 30002334; 30002335; 30002336 |]; position= {x = 1.828945562e+17;  y = 6.481552448e+16;  z = 2.666618827e+16;} } |> Some
      | 20000439 -> { ConstellationData.id= 20000439; name= "Abthi"; regionId= 10000036; solarSystemIds= [| 30002995; 30002996; 30002997; 30002998; 30002999; 30003000 |]; position= {x = -1.250640969e+17;  y = 7.010302314e+16;  z = -9.401822488e+16;} } |> Some
      | 20000536 -> { ConstellationData.id= 20000536; name= "XFLN-F"; regionId= 10000046; solarSystemIds= [| 30003676; 30003677; 30003678; 30003679; 30003680; 30003681; 30003682 |]; position= {x = -2.659411747e+17;  y = 8.281456285e+16;  z = 2.532858992e+17;} } |> Some
      | 20000633 -> { ConstellationData.id= 20000633; name= "0C-PZ4"; regionId= 10000055; solarSystemIds= [| 30004329; 30004330; 30004331; 30004332; 30004333; 30004334 |]; position= {x = -1.246033792e+17;  y = 7.541147221e+16;  z = 4.014561065e+17;} } |> Some
      | 20000730 -> { ConstellationData.id= 20000730; name= "Balrille"; regionId= 10000064; solarSystemIds= [| 30004987; 30004988; 30004989; 30004990; 30004991; 30004992 |]; position= {x = -2.220895543e+17;  y = 7.633597424e+15;  z = 3.691991349e+16;} } |> Some
      | 21000024 -> { ConstellationData.id= 21000024; name= "B-C00024"; regionId= 11000004; solarSystemIds= [| 31000386; 31000387; 31000388; 31000389; 31000390; 31000391; 31000392; 31000393; 31000394; 31000395; 31000396; 31000397 |]; position= {x = 7.748204933e+18;  y = 2.509452024e+16;  z = -9.347369905e+18;} } |> Some
      | 21000121 -> { ConstellationData.id= 21000121; name= "C-C00121"; regionId= 11000012; solarSystemIds= [| 31001171; 31001172; 31001173; 31001174; 31001175; 31001176; 31001177 |]; position= {x = 7.482214107e+18;  y = 2.422532616e+16;  z = -9.31761286e+18;} } |> Some
      | 21000218 -> { ConstellationData.id= 21000218; name= "D-C00218"; regionId= 11000022; solarSystemIds= [| 31001795; 31001796; 31001797; 31001798; 31001799; 31001800 |]; position= {x = 7.994335023e+18;  y = 1.393644224e+16;  z = -9.203345504e+18;} } |> Some
      | 21000315 -> { ConstellationData.id= 21000315; name= "A-C00315"; regionId= 11000001; solarSystemIds= [| 31000045; 31000046; 31000047; 31000048; 31000049; 31000050; 31000051; 31000052; 31000053 |]; position= {x = 7.679584462e+18;  y = 6.291825509e+15;  z = -9.487476149e+18;} } |> Some
      | _ -> None