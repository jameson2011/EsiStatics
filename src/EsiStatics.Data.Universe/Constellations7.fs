namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations7=
    let getConstellation id = 
      match id with 
      | 20000049 -> { ConstellationData.id= 20000049; name= "LC-AQD"; regionId= 10000004; solarSystemIds= [| 30000340; 30000341; 30000342; 30000343; 30000344; 30000345; 30000346 |]; position= {x = 9.536556183e+16;  y = 3.769139911e+16;  z = 1.910077478e+17;} } |> Some
      | 20000146 -> { ConstellationData.id= 20000146; name= "I3-2J0"; regionId= 10000011; solarSystemIds= [| 30000995; 30000996; 30000997; 30000998; 30000999; 30001000 |]; position= {x = 8.924009709e+16;  y = 2.881930444e+16;  z = -3.772443328e+16;} } |> Some
      | 20000243 -> { ConstellationData.id= 20000243; name= "Sanair"; regionId= 10000020; solarSystemIds= [| 30001644; 30001645; 30001646; 30001647; 30001648; 30001649 |]; position= {x = -1.84504532e+17;  y = 7.100668311e+16;  z = -1.133257398e+17;} } |> Some
      | 20000340 -> { ConstellationData.id= 20000340; name= "M9-AN3"; regionId= 10000027; solarSystemIds= [| 30002317; 30002318; 30002319; 30002320; 30002321; 30002322 |]; position= {x = 1.317732929e+17;  y = 5.563576518e+16;  z = 4.985995159e+16;} } |> Some
      | 20000437 -> { ConstellationData.id= 20000437; name= "Kabo"; regionId= 10000036; solarSystemIds= [| 30002982; 30002983; 30002984; 30002985; 30002986; 30002987 |]; position= {x = -1.141135347e+17;  y = 9.482662218e+16;  z = -9.634524863e+16;} } |> Some
      | 20000534 -> { ConstellationData.id= 20000534; name= "1D-65L"; regionId= 10000045; solarSystemIds= [| 30003664; 30003665; 30003666; 30003667; 30003668; 30003669 |]; position= {x = -1.167485779e+17;  y = 3.61383725e+16;  z = 4.583004528e+17;} } |> Some
      | 20000631 -> { ConstellationData.id= 20000631; name= "8-IL7S"; regionId= 10000055; solarSystemIds= [| 30004317; 30004318; 30004319; 30004320; 30004321; 30004322 |]; position= {x = -1.194865725e+17;  y = 7.484959921e+16;  z = 3.799803908e+17;} } |> Some
      | 20000728 -> { ConstellationData.id= 20000728; name= "Patrie"; regionId= 10000064; solarSystemIds= [| 30004973; 30004974; 30004975; 30004976; 30004977; 30004978 |]; position= {x = -2.086171411e+17;  y = 5.758537148e+16;  z = 6.734361671e+16;} } |> Some
      | 21000022 -> { ConstellationData.id= 21000022; name= "B-C00022"; regionId= 11000004; solarSystemIds= [| 31000364; 31000365; 31000366; 31000367; 31000368; 31000369; 31000370; 31000371; 31000372; 31000373; 31000374 |]; position= {x = 7.739694989e+18;  y = 6.989671907e+15;  z = -9.334096146e+18;} } |> Some
      | 21000119 -> { ConstellationData.id= 21000119; name= "C-C00119"; regionId= 11000012; solarSystemIds= [| 31001158; 31001159; 31001160; 31001161; 31001162; 31001163; 31001164 |]; position= {x = 7.48895026e+18;  y = 2.444739712e+16;  z = -9.299546306e+18;} } |> Some
      | 21000216 -> { ConstellationData.id= 21000216; name= "D-C00216"; regionId= 11000022; solarSystemIds= [| 31001783; 31001784; 31001785; 31001786; 31001787; 31001788 |]; position= {x = 7.955356348e+18;  y = 1.808896404e+16;  z = -9.189450877e+18;} } |> Some
      | 21000313 -> { ConstellationData.id= 21000313; name= "A-C00313"; regionId= 11000001; solarSystemIds= [| 31000025; 31000026; 31000027; 31000028; 31000029; 31000030; 31000031; 31000032; 31000033; 31000034 |]; position= {x = 7.620218377e+18;  y = 1.403572721e+16;  z = -9.489754117e+18;} } |> Some
      | _ -> None