namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations91=
    let getConstellation id = 
      match id with 
      | 20000036 -> { ConstellationData.id= 20000036; name= "YUT3-U"; regionId= 10000003; solarSystemIds= [| 30000254; 30000255; 30000256; 30000257; 30000258; 30000259; 30000260 |]; position= {x = -9.695956221e+16;  y = 1.159769653e+17;  z = 1.781717003e+17;} } |> Some
      | 20000133 -> { ConstellationData.id= 20000133; name= "U-3HAO"; regionId= 10000011; solarSystemIds= [| 30000906; 30000907; 30000908; 30000909; 30000910; 30000911 |]; position= {x = 6.309895648e+16;  y = 3.147036484e+16;  z = -9.121275345e+16;} } |> Some
      | 20000230 -> { ConstellationData.id= 20000230; name= "E-UBWI"; regionId= 10000018; solarSystemIds= [| 30001561; 30001562; 30001563; 30001564; 30001565; 30001566; 30001567 |]; position= {x = 2.02456187e+17;  y = 4.150647755e+16;  z = -7.557319582e+15;} } |> Some
      | 20000327 -> { ConstellationData.id= 20000327; name= "Sosarir"; regionId= 10000043; solarSystemIds= [| 30002226; 30002227; 30002228; 30002229; 30002230; 30002231; 30002232; 30002233; 30002234; 30002235 |]; position= {x = -1.750724744e+17;  y = 6.311571909e+16;  z = -7.904232607e+16;} } |> Some
      | 20000424 -> { ConstellationData.id= 20000424; name= "29V-1R"; regionId= 10000035; solarSystemIds= [| 30002889; 30002890; 30002891; 30002892; 30002893; 30002894 |]; position= {x = -1.954166216e+17;  y = 1.277326897e+17;  z = 2.677552656e+17;} } |> Some
      | 20000521 -> { ConstellationData.id= 20000521; name= "Elose"; regionId= 10000044; solarSystemIds= [| 30003573; 30003574; 30003575; 30003576; 30003577; 30003578 |]; position= {x = -3.043793537e+17;  y = 1.530886891e+16;  z = 1.497339886e+16;} } |> Some
      | 20000618 -> { ConstellationData.id= 20000618; name= "N4TD-6"; regionId= 10000053; solarSystemIds= [| 30004222; 30004223; 30004224; 30004225; 30004226; 30004227; 30004228; 30004229 |]; position= {x = 2.822456138e+17;  y = 4.723138712e+16;  z = 2.649578316e+17;} } |> Some
      | 20000715 -> { ConstellationData.id= 20000715; name= "O5QG-M"; regionId= 10000062; solarSystemIds= [| 30004884; 30004885; 30004886; 30004887; 30004888; 30004889 |]; position= {x = 5.246832438e+16;  y = -4.106424948e+16;  z = -3.72879771e+17;} } |> Some
      | 21000009 -> { ConstellationData.id= 21000009; name= "A-C00009"; regionId= 11000002; solarSystemIds= [| 31000227; 31000228; 31000229; 31000230; 31000231; 31000232; 31000233; 31000234; 31000235; 31000236; 31000237; 31000238 |]; position= {x = 7.585092645e+18;  y = 2.247456978e+16;  z = -9.428185373e+18;} } |> Some
      | 21000106 -> { ConstellationData.id= 21000106; name= "C-C00106"; regionId= 11000012; solarSystemIds= [| 31001073; 31001074; 31001075; 31001076; 31001077; 31001078; 31001079 |]; position= {x = 7.435856096e+18;  y = 1.032877944e+16;  z = -9.337676285e+18;} } |> Some
      | 21000203 -> { ConstellationData.id= 21000203; name= "D-C00203"; regionId= 11000021; solarSystemIds= [| 31001701; 31001702; 31001703; 31001704; 31001705; 31001706 |]; position= {x = 7.593883409e+18;  y = 2.672867065e+16;  z = -9.092660176e+18;} } |> Some
      | 21000300 -> { ConstellationData.id= 21000300; name= "F-C00300"; regionId= 11000030; solarSystemIds= [| 31002389; 31002390; 31002391; 31002392; 31002393; 31002394; 31002395; 31002396 |]; position= {x = 7.282208297e+18;  y = 2.875325677e+16;  z = -9.806245487e+18;} } |> Some
      | _ -> None