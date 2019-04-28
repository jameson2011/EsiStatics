namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations5=
    let getConstellation id = 
      match id with 
      | 20000047 -> { ConstellationData.id= 20000047; name= "L5-H1O"; regionId= 10000004; solarSystemIds= [| 30000326; 30000327; 30000328; 30000329; 30000330; 30000331; 30000332; 30000333 |]; position= {x = 1.123451812e+17;  y = 5.824925441e+16;  z = 2.079237453e+17;} } |> Some
      | 20000144 -> { ConstellationData.id= 20000144; name= "HRJG-D"; regionId= 10000011; solarSystemIds= [| 30000983; 30000984; 30000985; 30000986; 30000987; 30000988 |]; position= {x = 6.660691125e+16;  y = 6.253027464e+16;  z = -4.084525425e+16;} } |> Some
      | 20000241 -> { ConstellationData.id= 20000241; name= "UN2H-D"; regionId= 10000019; solarSystemIds= [| 30001631; 30001632; 30001633; 30001634; 30001635; 30001636 |]; position= {x = -6.980977235e+15;  y = 8.469574497e+16;  z = 3.000661628e+17;} } |> Some
      | 20000338 -> { ConstellationData.id= 20000338; name= "PGPJ-8"; regionId= 10000027; solarSystemIds= [| 30002302; 30002303; 30002304; 30002305; 30002306; 30002307; 30002308; 30002309; 30002310 |]; position= {x = 1.691609536e+17;  y = 7.856357074e+16;  z = 3.483626926e+16;} } |> Some
      | 20000435 -> { ConstellationData.id= 20000435; name= "Kisana"; regionId= 10000036; solarSystemIds= [| 30002969; 30002970; 30002971; 30002972; 30002973; 30002974 |]; position= {x = -1.183018177e+17;  y = 5.146423762e+16;  z = -4.575396574e+16;} } |> Some
      | 20000532 -> { ConstellationData.id= 20000532; name= "2-ZRM0"; regionId= 10000045; solarSystemIds= [| 30003650; 30003651; 30003652; 30003653; 30003654; 30003655; 30003656; 30003657 |]; position= {x = -2.782719239e+16;  y = 1.015726074e+17;  z = 4.104071746e+17;} } |> Some
      | 20000629 -> { ConstellationData.id= 20000629; name= "Selonat"; regionId= 10000054; solarSystemIds= [| 30004303; 30004304; 30004305; 30004306; 30004307; 30004308; 30004309 |]; position= {x = -4.138920308e+17;  y = 2.090053578e+16;  z = -7.852700965e+16;} } |> Some
      | 20000726 -> { ConstellationData.id= 20000726; name= "OY3-DM"; regionId= 10000063; solarSystemIds= [| 30004961; 30004962; 30004963; 30004964; 30004965; 30004966 |]; position= {x = -4.402027132e+17;  y = 6.610604517e+16;  z = -4.18089646e+17;} } |> Some
      | 21000020 -> { ConstellationData.id= 21000020; name= "A-C00020"; regionId= 11000003; solarSystemIds= [| 31000343; 31000344; 31000345; 31000346; 31000347; 31000348; 31000349; 31000350; 31000351; 31000352; 31000353; 31000354 |]; position= {x = 7.610579077e+18;  y = 2.460087914e+16;  z = -9.36449274e+18;} } |> Some
      | 21000117 -> { ConstellationData.id= 21000117; name= "C-C00117"; regionId= 11000012; solarSystemIds= [| 31001146; 31001147; 31001148; 31001149; 31001150; 31001151 |]; position= {x = 7.485510022e+18;  y = 6.693912221e+15;  z = -9.334880795e+18;} } |> Some
      | 21000214 -> { ConstellationData.id= 21000214; name= "D-C00214"; regionId= 11000022; solarSystemIds= [| 31001771; 31001772; 31001773; 31001774; 31001775; 31001776 |]; position= {x = 7.952165245e+18;  y = 1.510746992e+16;  z = -9.236726331e+18;} } |> Some
      | 21000311 -> { ConstellationData.id= 21000311; name= "A-C00311"; regionId= 11000001; solarSystemIds= [| 31000007; 31000008; 31000009; 31000010; 31000011; 31000012 |]; position= {x = 7.638114723e+18;  y = 1.087091814e+16;  z = -9.479967906e+18;} } |> Some
      | _ -> None