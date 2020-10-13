namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations55=
    let getConstellation id = 
      match id with 
      | 20000097 -> { ConstellationData.id= 20000097; name= "4YFT-F"; regionId= 10000008; solarSystemIds= [| 30000666; 30000667; 30000668; 30000669; 30000670; 30000671 |]; position= {x = 5.165055402e+16;  y = 6.432635259e+15;  z = -1.297557599e+17;} } |> Some
      | 20000194 -> { ConstellationData.id= 20000194; name= "XMNF-7"; regionId= 10000015; solarSystemIds= [| 30001331; 30001332; 30001333; 30001334; 30001335; 30001336 |]; position= {x = -1.740252445e+17;  y = 1.110185285e+17;  z = 3.484675183e+17;} } |> Some
      | 20000291 -> { ConstellationData.id= 20000291; name= "38G6-L"; regionId= 10000023; solarSystemIds= [| 30001977; 30001978; 30001979; 30001980; 30001981; 30001982; 30001983 |]; position= {x = -2.426277746e+17;  y = 9.066986836e+16;  z = 2.354026185e+17;} } |> Some
      | 20000388 -> { ConstellationData.id= 20000388; name= "Spaen"; regionId= 10000032; solarSystemIds= [| 30002648; 30002649; 30002650; 30002651; 30002653; 30002654 |]; position= {x = -1.751246564e+17;  y = 4.03713269e+16;  z = -5.696121941e+15;} } |> Some
      | 20000485 -> { ConstellationData.id= 20000485; name= "49A-BZ"; regionId= 10000041; solarSystemIds= [| 30003327; 30003328; 30003329; 30003330; 30003331; 30003332; 30003333; 30003334; 30003335 |]; position= {x = -3.18510718e+17;  y = 2.506385683e+16;  z = 9.827181813e+16;} } |> Some
      | 20000582 -> { ConstellationData.id= 20000582; name= "K-JO26"; regionId= 10000050; solarSystemIds= [| 30003984; 30003985; 30003986; 30003987; 30003988; 30003989 |]; position= {x = -3.142381809e+17;  y = 8.417109191e+16;  z = -2.103183857e+17;} } |> Some
      | 20000679 -> { ConstellationData.id= 20000679; name= "Skaven"; regionId= 10000058; solarSystemIds= [| 30004649; 30004650; 30004651; 30004652; 30004653; 30004654 |]; position= {x = -4.753953831e+17;  y = 3.075169936e+16;  z = -1.599592125e+16;} } |> Some
      | 20000776 -> { ConstellationData.id= 20000776; name= "Anwyns"; regionId= 10000068; solarSystemIds= [| 30005301; 30005302; 30005303; 30005304; 30005305; 30005306; 30005307; 30015305; 30025305 |]; position= {x = -2.45763998e+17;  y = 3.921307437e+16;  z = 3.790197195e+16;} } |> Some
      | 21000070 -> { ConstellationData.id= 21000070; name= "B-C00070"; regionId= 11000008; solarSystemIds= [| 31000857; 31000858; 31000859; 31000860; 31000861; 31000862; 31000863; 31000864; 31000865; 31000866; 31000867; 31000868 |]; position= {x = 7.56697994e+18;  y = 2.647086565e+16;  z = -9.668525908e+18;} } |> Some
      | 21000167 -> { ConstellationData.id= 21000167; name= "D-C00167"; regionId= 11000018; solarSystemIds= [| 31001466; 31001467; 31001468; 31001469; 31001470; 31001471 |]; position= {x = 7.586056273e+18;  y = 8.640133017e+15;  z = -9.717523213e+18;} } |> Some
      | 21000264 -> { ConstellationData.id= 21000264; name= "E-C00264"; regionId= 11000026; solarSystemIds= [| 31002120; 31002121; 31002122; 31002123; 31002124; 31002125 |]; position= {x = 7.72106363e+18;  y = -2.143545727e+16;  z = -9.01761198e+18;} } |> Some
      | _ -> None