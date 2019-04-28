namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations37=
    let getConstellation id = 
      match id with 
      | 20000079 -> { ConstellationData.id= 20000079; name= "RF9-ZU"; regionId= 10000006; solarSystemIds= [| 30000546; 30000547; 30000548; 30000549; 30000550; 30000551 |]; position= {x = 1.078428756e+17;  y = 2.812639395e+15;  z = -1.767061538e+17;} } |> Some
      | 20000176 -> { ConstellationData.id= 20000176; name= "FDR-EQ"; regionId= 10000014; solarSystemIds= [| 30001205; 30001206; 30001207; 30001208; 30001209; 30001210; 30001211; 30001212 |]; position= {x = -8.869745741e+16;  y = 2.148594248e+16;  z = -1.489006889e+17;} } |> Some
      | 20000273 -> { ConstellationData.id= 20000273; name= "H26A-B"; regionId= 10000022; solarSystemIds= [| 30001845; 30001846; 30001847; 30001848; 30001849; 30001850 |]; position= {x = -1.245894491e+17;  y = 4.654190545e+16;  z = -2.540437923e+17;} } |> Some
      | 20000370 -> { ConstellationData.id= 20000370; name= "Odengsolf"; regionId= 10000030; solarSystemIds= [| 30002524; 30002525; 30002526; 30002527; 30002528; 30002529; 30002530; 30042505 |]; position= {x = -9.872377019e+16;  y = 4.520902393e+16;  z = 2.02902387e+16;} } |> Some
      | 20000467 -> { ConstellationData.id= 20000467; name= "0PS-L5"; regionId= 10000040; solarSystemIds= [| 30003197; 30003198; 30003199; 30003200; 30003201; 30003202; 30003203 |]; position= {x = 2.368185652e+17;  y = 4.216880675e+16;  z = 1.539287134e+17;} } |> Some
      | 20000564 -> { ConstellationData.id= 20000564; name= "Nohshayess"; regionId= 10000049; solarSystemIds= [| 30003858; 30003859; 30003860; 30003861; 30003862; 30003863; 30003864; 30003865; 30003866 |]; position= {x = -2.721699955e+17;  y = 5.009704919e+16;  z = -1.436279321e+17;} } |> Some
      | 20000661 -> { ConstellationData.id= 20000661; name= "Regalia"; regionId= 10000057; solarSystemIds= [| 30004526; 30004527; 30004528; 30004529; 30004530; 30004531 |]; position= {x = -3.816658402e+17;  y = 2.591907214e+16;  z = 1.023774508e+17;} } |> Some
      | 20000758 -> { ConstellationData.id= 20000758; name= "S0X-O4"; regionId= 10000066; solarSystemIds= [| 30005180; 30005181; 30005182; 30005183; 30005184; 30005185 |]; position= {x = 2.429460531e+17;  y = 1.39938302e+16;  z = 4.853103613e+16;} } |> Some
      | 21000052 -> { ConstellationData.id= 21000052; name= "B-C00052"; regionId= 11000006; solarSystemIds= [| 31000669; 31000670; 31000671; 31000672; 31000673; 31000674; 31000675; 31000676; 31000677; 31000678; 31000679; 31000680 |]; position= {x = 7.830612362e+18;  y = 3.222091834e+16;  z = -9.669887304e+18;} } |> Some
      | 21000149 -> { ConstellationData.id= 21000149; name= "C-C00149"; regionId= 11000015; solarSystemIds= [| 31001349; 31001350; 31001351; 31001352; 31001353; 31001354; 31001355 |]; position= {x = 7.933392866e+18;  y = 2.76988535e+16;  z = -9.419774333e+18;} } |> Some
      | 21000246 -> { ConstellationData.id= 21000246; name= "E-C00246"; regionId= 11000025; solarSystemIds= [| 31001991; 31001992; 31001993; 31001994; 31001995; 31001996; 31001997 |]; position= {x = 7.320492577e+18;  y = 2.838633132e+16;  z = -9.113810755e+18;} } |> Some
      | 22000025 -> { ConstellationData.id= 22000025; name= "ADC25"; regionId= 12000005; solarSystemIds= [| 32000193; 32000194; 32000195; 32000196; 32000197; 32000198; 32000199; 32000200 |]; position= {x = 5.088587934e+18;  y = 5.657649784e+18;  z = -8.817336075e+18;} } |> Some
      | _ -> None