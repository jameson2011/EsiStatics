namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations1=
    let getConstellation id = 
      match id with 
      | 20000043 -> { ConstellationData.id= 20000043; name= "F-V9QW"; regionId= 10000003; solarSystemIds= [| 30000301; 30000302; 30000303; 30000304; 30000305; 30000306 |]; position= {x = -5.465547459e+16;  y = 1.231086765e+17;  z = 2.188795934e+17;} } |> Some
      | 20000140 -> { ConstellationData.id= 20000140; name= "T-W4L3"; regionId= 10000011; solarSystemIds= [| 30000956; 30000957; 30000958; 30000959; 30000960; 30000961; 30000962; 30000963 |]; position= {x = 2.195407515e+16;  y = 5.180420594e+16;  z = -9.049531184e+16;} } |> Some
      | 20000237 -> { ConstellationData.id= 20000237; name= "W1-F3U"; regionId= 10000019; solarSystemIds= [| 30001604; 30001605; 30001606; 30001607; 30001608; 30001609 |]; position= {x = 2.40755905e+16;  y = 5.66671873e+16;  z = 2.619200131e+17;} } |> Some
      | 20000334 -> { ConstellationData.id= 20000334; name= "Norgoh"; regionId= 10000043; solarSystemIds= [| 30002276; 30002277; 30002278; 30002279; 30002280; 30002281; 30002282; 30023489 |]; position= {x = -1.931284051e+17;  y = 4.984517245e+16;  z = -7.426830708e+16;} } |> Some
      | 20000431 -> { ConstellationData.id= 20000431; name= "RFY-QB"; regionId= 10000035; solarSystemIds= [| 30002938; 30002939; 30002940; 30002941; 30002942; 30002943; 30002944; 30002945; 30002946; 30002947; 30002948; 30002949; 30002950 |]; position= {x = -3.38333119e+17;  y = 8.520548056e+16;  z = 3.268346165e+17;} } |> Some
      | 20000528 -> { ConstellationData.id= 20000528; name= "9P57-V"; regionId= 10000045; solarSystemIds= [| 30003623; 30003624; 30003625; 30003626; 30003627; 30003628 |]; position= {x = -5.085420859e+16;  y = 8.905130469e+16;  z = 4.143605872e+17;} } |> Some
      | 20000625 -> { ConstellationData.id= 20000625; name= "Helab"; regionId= 10000054; solarSystemIds= [| 30004273; 30004274; 30004275; 30004276; 30004277; 30004278; 30004279 |]; position= {x = -3.762809948e+17;  y = 3.336055488e+16;  z = -7.649035257e+16;} } |> Some
      | 20000722 -> { ConstellationData.id= 20000722; name= "N-39FI"; regionId= 10000063; solarSystemIds= [| 30004934; 30004935; 30004936; 30004937; 30004938; 30004939 |]; position= {x = -4.046076395e+17;  y = 7.902546574e+16;  z = -3.91262985e+17;} } |> Some
      | 21000016 -> { ConstellationData.id= 21000016; name= "A-C00016"; regionId= 11000003; solarSystemIds= [| 31000305; 31000306; 31000307; 31000308; 31000309; 31000310; 31000311; 31000312; 31000313 |]; position= {x = 7.69223734e+18;  y = 1.173854386e+16;  z = -9.335620448e+18;} } |> Some
      | 21000113 -> { ConstellationData.id= 21000113; name= "C-C00113"; regionId= 11000012; solarSystemIds= [| 31001120; 31001121; 31001122; 31001123; 31001124; 31001125; 31001126 |]; position= {x = 7.440519573e+18;  y = 2.734787073e+16;  z = -9.314172351e+18;} } |> Some
      | 21000210 -> { ConstellationData.id= 21000210; name= "D-C00210"; regionId= 11000021; solarSystemIds= [| 31001746; 31001747; 31001748; 31001749; 31001750; 31001751; 31001752 |]; position= {x = 7.561065385e+18;  y = 8.690436878e+15;  z = -9.13740432e+18;} } |> Some
      | 21000307 -> { ConstellationData.id= 21000307; name= "F-C00307"; regionId= 11000030; solarSystemIds= [| 31002443; 31002444; 31002445; 31002446; 31002447; 31002448; 31002474; 31002484 |]; position= {x = 7.326582597e+18;  y = 2.920747605e+16;  z = -9.862781128e+18;} } |> Some
      | _ -> None