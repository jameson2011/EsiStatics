namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations71=
    let getConstellation id = 
      match id with 
      | 20000016 -> { ConstellationData.id= 20000016; name= "Joas"; regionId= 10000001; solarSystemIds= [| 30000112; 30000113; 30000114; 30000115; 30000116; 30000117; 30000118 |]; position= {x = -4.917391628e+16;  y = 3.383626501e+16;  z = -4.205706371e+16;} } |> Some
      | 20000113 -> { ConstellationData.id= 20000113; name= "QA-P7J"; regionId= 10000009; solarSystemIds= [| 30000770; 30000771; 30000772; 30000773; 30000774; 30000775; 30000776 |]; position= {x = 1.306614333e+17;  y = 3.70725923e+15;  z = -1.335860376e+17;} } |> Some
      | 20000210 -> { ConstellationData.id= 20000210; name= "Malariya"; regionId= 10000016; solarSystemIds= [| 30001430; 30001431; 30001432; 30001433; 30001434; 30001435; 30001436 |]; position= {x = -2.211338139e+17;  y = 8.925005471e+16;  z = 1.84010749e+17;} } |> Some
      | 20000307 -> { ConstellationData.id= 20000307; name= "Eugidi"; regionId= 10000042; solarSystemIds= [| 30002082; 30002083; 30002084; 30002085; 30002086; 30002087; 30002088; 30002089 |]; position= {x = -1.369060493e+17;  y = 3.344345051e+16;  z = 2.755897345e+16;} } |> Some
      | 20000404 -> { ConstellationData.id= 20000404; name= "Ieyama"; regionId= 10000033; solarSystemIds= [| 30002755; 30002756; 30002757; 30002758; 30002759; 30002760 |]; position= {x = -1.661403869e+17;  y = 4.733229458e+16;  z = 1.397379795e+17;} } |> Some
      | 20000501 -> { ConstellationData.id= 20000501; name= "Frar"; regionId= 10000042; solarSystemIds= [| 30003434; 30003435; 30003436; 30003437; 30003438; 30003439; 30003440 |]; position= {x = -7.371669575e+16;  y = 4.771130868e+16;  z = 6.291730903e+16;} } |> Some
      | 20000598 -> { ConstellationData.id= 20000598; name= "Febihkin"; regionId= 10000052; solarSystemIds= [| 30004091; 30004092; 30004093; 30004094; 30004095; 30004096; 30004097 |]; position= {x = -2.233219776e+17;  y = 5.687530707e+16;  z = -7.957258053e+16;} } |> Some
      | 20000695 -> { ConstellationData.id= 20000695; name= "W-4U1E"; regionId= 10000060; solarSystemIds= [| 30004750; 30004751; 30004752; 30004753; 30004754; 30004755; 30004756; 30004757; 30004758 |]; position= {x = -4.032045893e+17;  y = 5.217550852e+16;  z = -2.777395121e+17;} } |> Some
      | 21000086 -> { ConstellationData.id= 21000086; name= "C-C00086"; regionId= 11000010; solarSystemIds= [| 31000942; 31000943; 31000944; 31000945; 31000946; 31000947; 31000948 |]; position= {x = 7.423376057e+18;  y = 3.420587701e+16;  z = -9.684811707e+18;} } |> Some
      | 21000183 -> { ConstellationData.id= 21000183; name= "D-C00183"; regionId= 11000019; solarSystemIds= [| 31001573; 31001574; 31001575; 31001576; 31001577; 31001578; 31001579 |]; position= {x = 7.437357483e+18;  y = 2.47585958e+16;  z = -9.584089824e+18;} } |> Some
      | 21000280 -> { ConstellationData.id= 21000280; name= "E-C00280"; regionId= 11000028; solarSystemIds= [| 31002238; 31002239; 31002240; 31002241; 31002242; 31002243 |]; position= {x = 8.057646507e+18;  y = 2.051424204e+16;  z = -9.874510403e+18;} } |> Some
      | _ -> None