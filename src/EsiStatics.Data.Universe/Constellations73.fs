namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations73=
    let getConstellation id = 
      match id with 
      | 20000018 -> { ConstellationData.id= 20000018; name= "Anttanen"; regionId= 10000002; solarSystemIds= [| 30000126; 30000127; 30000128; 30000129; 30000130; 30000131; 30030141 |]; position= {x = -1.156920453e+17;  y = 7.349004175e+16;  z = 9.104403194e+16;} } |> Some
      | 20000115 -> { ConstellationData.id= 20000115; name= "0YMH-Q"; regionId= 10000009; solarSystemIds= [| 30000783; 30000784; 30000785; 30000786; 30000787; 30000788 |]; position= {x = 1.151928256e+17;  y = 3.789365819e+16;  z = -1.109435729e+17;} } |> Some
      | 20000212 -> { ConstellationData.id= 20000212; name= "Mito"; regionId= 10000016; solarSystemIds= [| 30001443; 30001444; 30001446; 30001447; 30001448 |]; position= {x = -1.492898651e+17;  y = 9.458391699e+16;  z = 1.645731837e+17;} } |> Some
      | 20000309 -> { ConstellationData.id= 20000309; name= "Angils"; regionId= 10000042; solarSystemIds= [| 30002097; 30002098; 30002099; 30002100; 30002101; 30002102 |]; position= {x = -1.325795572e+17;  y = 7.00946773e+15;  z = 2.908604233e+16;} } |> Some
      | 20000406 -> { ConstellationData.id= 20000406; name= "Kantanen"; regionId= 10000033; solarSystemIds= [| 30002767; 30002768; 30002769; 30002771; 30002772; 30002773; 30002774 |]; position= {x = -1.664305108e+17;  y = 8.031536001e+16;  z = 9.248632716e+16;} } |> Some
      | 20000503 -> { ConstellationData.id= 20000503; name= "Panorad"; regionId= 10000042; solarSystemIds= [| 30003447; 30003448; 30003449; 30003450; 30003451; 30003452 |]; position= {x = -9.619968642e+16;  y = 2.138202759e+16;  z = 2.032990534e+16;} } |> Some
      | 20000600 -> { ConstellationData.id= 20000600; name= "Heti"; regionId= 10000052; solarSystemIds= [| 30004104; 30004105; 30004106; 30004107; 30004108; 30004109 |]; position= {x = -2.357508834e+17;  y = 1.423936036e+16;  z = -2.230364131e+16;} } |> Some
      | 20000697 -> { ConstellationData.id= 20000697; name= "SG-CTQ"; regionId= 10000060; solarSystemIds= [| 30004766; 30004767; 30004768; 30004769; 30004770; 30004771 |]; position= {x = -4.552400415e+17;  y = 5.497518078e+16;  z = -2.483715892e+17;} } |> Some
      | 21000088 -> { ConstellationData.id= 21000088; name= "C-C00088"; regionId= 11000010; solarSystemIds= [| 31000955; 31000956; 31000957; 31000958; 31000959; 31000960; 31000961 |]; position= {x = 7.478137716e+18;  y = 1.193034078e+16;  z = -9.695023829e+18;} } |> Some
      | 21000185 -> { ConstellationData.id= 21000185; name= "D-C00185"; regionId= 11000019; solarSystemIds= [| 31001586; 31001587; 31001588; 31001589; 31001590; 31001591; 31001592 |]; position= {x = 7.451275385e+18;  y = 3.224537941e+16;  z = -9.591142978e+18;} } |> Some
      | 21000282 -> { ConstellationData.id= 21000282; name= "E-C00282"; regionId= 11000028; solarSystemIds= [| 31002251; 31002252; 31002253; 31002254; 31002255; 31002256; 31002257; 31002258; 31002479 |]; position= {x = 8.03078384e+18;  y = 2.833250285e+16;  z = -9.925272227e+18;} } |> Some
      | _ -> None