namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations56=
    let getConstellation id = 
      match id with 
      | 20000001 -> { ConstellationData.id= 20000001; name= "San Matar"; regionId= 10000001; solarSystemIds= [| 30000001; 30000002; 30000003; 30000004; 30000005; 30000006; 30000007; 30000008 |]; position= {x = -9.40465597e+16;  y = 4.952015315e+16;  z = -4.273873182e+16;} } |> Some
      | 20000098 -> { ConstellationData.id= 20000098; name= "P-I9PF"; regionId= 10000008; solarSystemIds= [| 30000672; 30000673; 30000674; 30000675; 30000676; 30000677 |]; position= {x = 3.250775943e+16;  y = 3.171501953e+16;  z = -1.190412232e+17;} } |> Some
      | 20000195 -> { ConstellationData.id= 20000195; name= "L-1T22"; regionId= 10000015; solarSystemIds= [| 30001337; 30001338; 30001339; 30001340; 30001341; 30001342; 30001343 |]; position= {x = -1.336954189e+17;  y = 1.263263599e+17;  z = 3.618220603e+17;} } |> Some
      | 20000292 -> { ConstellationData.id= 20000292; name= "YS-GOP"; regionId= 10000023; solarSystemIds= [| 30001984; 30001985; 30001986; 30001987; 30001988; 30001989; 30001990 |]; position= {x = -2.487111951e+17;  y = 8.628495311e+16;  z = 2.049576412e+17;} } |> Some
      | 20000389 -> { ConstellationData.id= 20000389; name= "Coriault"; regionId= 10000032; solarSystemIds= [| 30002655; 30002656; 30002657; 30002658; 30002659; 30002660; 30002661; 30012715 |]; position= {x = -1.837948261e+17;  y = 5.253862744e+16;  z = 2.46952387e+16;} } |> Some
      | 20000486 -> { ConstellationData.id= 20000486; name= "GN-ACS"; regionId= 10000041; solarSystemIds= [| 30003336; 30003337; 30003338; 30003339; 30003340; 30003341 |]; position= {x = -3.274929938e+17;  y = 2.663722336e+16;  z = 1.116268421e+17;} } |> Some
      | 20000583 -> { ConstellationData.id= 20000583; name= "F-RA63"; regionId= 10000050; solarSystemIds= [| 30003990; 30003991; 30003992; 30003993; 30003994; 30003995 |]; position= {x = -3.411967939e+17;  y = 6.154821303e+16;  z = -2.614069405e+17;} } |> Some
      | 20000680 -> { ConstellationData.id= 20000680; name= "Mermaid"; regionId= 10000058; solarSystemIds= [| 30004655; 30004656; 30004657; 30004658; 30004659; 30004660 |]; position= {x = -4.984199762e+17;  y = 4.430655927e+16;  z = -4.834905394e+16;} } |> Some
      | 20000777 -> { ConstellationData.id= 20000777; name= "Kiartanne"; regionId= 10000068; solarSystemIds= [| 30005308; 30005309; 30005310; 30005311; 30005312; 30005313; 30005314 |]; position= {x = -2.422399373e+17;  y = 3.393029043e+16;  z = 4.92919897e+16;} } |> Some
      | 21000071 -> { ConstellationData.id= 21000071; name= "B-C00071"; regionId= 11000008; solarSystemIds= [| 31000869; 31000870; 31000871; 31000872; 31000873; 31000874; 31000875 |]; position= {x = 7.448974393e+18;  y = 3.884166462e+16;  z = -9.638146411e+18;} } |> Some
      | 21000168 -> { ConstellationData.id= 21000168; name= "D-C00168"; regionId= 11000018; solarSystemIds= [| 31001472; 31001473; 31001474; 31001475; 31001476; 31001477; 31001478 |]; position= {x = 7.514802224e+18;  y = 2.558873041e+16;  z = -9.736834978e+18;} } |> Some
      | 21000265 -> { ConstellationData.id= 21000265; name= "E-C00265"; regionId= 11000027; solarSystemIds= [| 31002126; 31002127; 31002128; 31002129; 31002130; 31002131; 31002132; 31002133; 31002490 |]; position= {x = 8.2287845e+18;  y = 9.664776869e+15;  z = -9.27621841e+18;} } |> Some
      | _ -> None