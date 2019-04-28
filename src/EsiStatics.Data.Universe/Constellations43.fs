namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations43=
    let getConstellation id = 
      match id with 
      | 20000085 -> { ConstellationData.id= 20000085; name= "5Y1E-3"; regionId= 10000006; solarSystemIds= [| 30000587; 30000588; 30000589; 30000590; 30000591; 30000592 |]; position= {x = 1.142552309e+17;  y = 1.617048715e+16;  z = -1.565221647e+17;} } |> Some
      | 20000182 -> { ConstellationData.id= 20000182; name= "U-JTBT"; regionId= 10000014; solarSystemIds= [| 30001246; 30001247; 30001248; 30001249; 30001250; 30001251; 30001252; 30001253 |]; position= {x = -1.511212373e+17;  y = 3.557862164e+16;  z = -2.605003732e+17;} } |> Some
      | 20000279 -> { ConstellationData.id= 20000279; name= "QO-17V"; regionId= 10000022; solarSystemIds= [| 30001887; 30001888; 30001889; 30001890; 30001891; 30001892 |]; position= {x = -1.425217373e+17;  y = 4.194612598e+16;  z = -3.638757043e+17;} } |> Some
      | 20000376 -> { ConstellationData.id= 20000376; name= "Urtfer"; regionId= 10000030; solarSystemIds= [| 30002562; 30002563; 30002564; 30002565; 30002566; 30002567 |]; position= {x = -5.758923256e+16;  y = 3.032219061e+16;  z = 4.424913748e+16;} } |> Some
      | 20000473 -> { ConstellationData.id= 20000473; name= "O9X-CV"; regionId= 10000040; solarSystemIds= [| 30003235; 30003236; 30003237; 30003238; 30003239; 30003240; 30003241 |]; position= {x = 2.396265343e+17;  y = 5.484237125e+16;  z = 1.743876493e+17;} } |> Some
      | 20000570 -> { ConstellationData.id= 20000570; name= "Fekhoya"; regionId= 10000049; solarSystemIds= [| 30003903; 30003904; 30003905; 30003906; 30003907; 30003908; 30003909; 30003910 |]; position= {x = -3.081417094e+17;  y = 1.93499805e+16;  z = -1.373445052e+17;} } |> Some
      | 20000667 -> { ConstellationData.id= 20000667; name= "Manticore"; regionId= 10000058; solarSystemIds= [| 30004567; 30004568; 30004569; 30004570; 30004571; 30004572 |]; position= {x = -4.369109002e+17;  y = 6.162885366e+16;  z = 1.672397957e+16;} } |> Some
      | 20000764 -> { ConstellationData.id= 20000764; name= "Mih"; regionId= 10000067; solarSystemIds= [| 30005221; 30005222; 30005223; 30005224; 30005225; 30005226; 30005227; 30005228 |]; position= {x = -2.37785076e+17;  y = 3.005752357e+16;  z = -8.766020665e+15;} } |> Some
      | 21000058 -> { ConstellationData.id= 21000058; name= "B-C00058"; regionId= 11000007; solarSystemIds= [| 31000733; 31000734; 31000735; 31000736; 31000737; 31000738; 31000739; 31000740; 31000741 |]; position= {x = 7.613965947e+18;  y = 2.901170596e+16;  z = -9.743193222e+18;} } |> Some
      | 21000155 -> { ConstellationData.id= 21000155; name= "D-C00155"; regionId= 11000016; solarSystemIds= [| 31001389; 31001390; 31001391; 31001392; 31001393; 31001394; 31001395 |]; position= {x = 7.974580881e+18;  y = 2.331089036e+16;  z = -9.58375149e+18;} } |> Some
      | 21000252 -> { ConstellationData.id= 21000252; name= "E-C00252"; regionId= 11000025; solarSystemIds= [| 31002033; 31002034; 31002035; 31002036; 31002037; 31002038; 31002039; 31002040 |]; position= {x = 7.294089677e+18;  y = 1.569802271e+16;  z = -9.092616806e+18;} } |> Some
      | _ -> None