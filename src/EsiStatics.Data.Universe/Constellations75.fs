namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations75=
    let getConstellation id = 
      match id with 
      | 20000020 -> { ConstellationData.id= 20000020; name= "Kimotoro"; regionId= 10000002; solarSystemIds= [| 30000139; 30000140; 30000141; 30000142; 30000143; 30000144; 30000145 |]; position= {x = -1.349964005e+17;  y = 6.499945263e+16;  z = 1.033256173e+17;} } |> Some
      | 20000117 -> { ConstellationData.id= 20000117; name= "0-YMZM"; regionId= 10000009; solarSystemIds= [| 30000796; 30000797; 30000798; 30000799; 30000800; 30000801 |]; position= {x = 1.49354745e+17;  y = -4.121710018e+16;  z = -1.577984347e+17;} } |> Some
      | 20000214 -> { ConstellationData.id= 20000214; name= "OG-DJD"; regionId= 10000017; solarSystemIds= [| 30001455; 30001456; 30001457; 30001458; 30001459; 30001460 |]; position= {x = -2.343453392e+15;  y = 1.030111503e+17;  z = 2.253562216e+17;} } |> Some
      | 20000311 -> { ConstellationData.id= 20000311; name= "K-ZKBM"; regionId= 10000025; solarSystemIds= [| 30002109; 30002110; 30002111; 30002112; 30002113; 30002114; 30002115; 30002116 |]; position= {x = 4.640909938e+15;  y = -6.777253311e+14;  z = -2.265951851e+17;} } |> Some
      | 20000408 -> { ConstellationData.id= 20000408; name= "Uusasai"; regionId= 10000033; solarSystemIds= [| 30002781; 30002782; 30002783; 30002784; 30002785; 30002786; 30002787 |]; position= {x = -1.405972056e+17;  y = 9.689716026e+16;  z = 9.919389361e+16;} } |> Some
      | 20000505 -> { ConstellationData.id= 20000505; name= "Rollera"; regionId= 10000042; solarSystemIds= [| 30003459; 30003460; 30003461; 30003462; 30003463; 30003464; 30003465; 30003466 |]; position= {x = -2.9684101e+16;  y = 3.778035258e+16;  z = 3.363830444e+16;} } |> Some
      | 20000602 -> { ConstellationData.id= 20000602; name= "Favo"; regionId= 10000052; solarSystemIds= [| 30004116; 30004117; 30004118; 30004119; 30004120; 30004121 |]; position= {x = -2.650990091e+17;  y = 3.65557419e+16;  z = -3.425647484e+16;} } |> Some
      | 20000699 -> { ConstellationData.id= 20000699; name= "LSC-4P"; regionId= 10000060; solarSystemIds= [| 30004778; 30004779; 30004780; 30004781; 30004782; 30004783 |]; position= {x = -4.055529773e+17;  y = 6.744814196e+16;  z = -2.885111599e+17;} } |> Some
      | 21000090 -> { ConstellationData.id= 21000090; name= "C-C00090"; regionId= 11000010; solarSystemIds= [| 31000968; 31000969; 31000970; 31000971; 31000972; 31000973 |]; position= {x = 7.451168552e+18;  y = 1.154551025e+16;  z = -9.697989169e+18;} } |> Some
      | 21000187 -> { ConstellationData.id= 21000187; name= "D-C00187"; regionId= 11000020; solarSystemIds= [| 31001600; 31001601; 31001602; 31001603; 31001604; 31001605 |]; position= {x = 7.398541029e+18;  y = 1.580315954e+16;  z = -9.303953191e+18;} } |> Some
      | 21000284 -> { ConstellationData.id= 21000284; name= "E-C00284"; regionId= 11000028; solarSystemIds= [| 31002267; 31002268; 31002269; 31002270; 31002271; 31002272; 31002273 |]; position= {x = 8.063602797e+18;  y = 2.079004107e+16;  z = -9.907418358e+18;} } |> Some
      | _ -> None