namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations0=
    let getConstellation id = 
      match id with 
      | 20000042 -> { ConstellationData.id= 20000042; name= "0-8MWQ"; regionId= 10000003; solarSystemIds= [| 30000295; 30000296; 30000297; 30000298; 30000299; 30000300 |]; position= {x = -1.971048887e+16;  y = 8.47380413e+16;  z = 1.679617169e+17;} } |> Some
      | 20000139 -> { ConstellationData.id= 20000139; name= "AP-S8F"; regionId= 10000011; solarSystemIds= [| 30000949; 30000950; 30000951; 30000952; 30000953; 30000954; 30000955 |]; position= {x = 5.065310416e+16;  y = 4.274859653e+16;  z = -5.440789892e+16;} } |> Some
      | 20000236 -> { ConstellationData.id= 20000236; name= "O-BSIB"; regionId= 10000019; solarSystemIds= [| 30001598; 30001599; 30001600; 30001601; 30001602; 30001603 |]; position= {x = 3.434232167e+16;  y = 6.924684521e+16;  z = 2.342720284e+17;} } |> Some
      | 20000333 -> { ConstellationData.id= 20000333; name= "Liela"; regionId= 10000043; solarSystemIds= [| 30002269; 30002270; 30002271; 30002272; 30002273; 30002274; 30002275 |]; position= {x = -1.631654104e+17;  y = 4.432472696e+16;  z = -1.135176942e+17;} } |> Some
      | 20000430 -> { ConstellationData.id= 20000430; name= "A21H-Z"; regionId= 10000035; solarSystemIds= [| 30002932; 30002933; 30002934; 30002935; 30002936; 30002937 |]; position= {x = -3.143750915e+17;  y = 9.343993366e+16;  z = 3.18644936e+17;} } |> Some
      | 20000527 -> { ConstellationData.id= 20000527; name= "09-4XW"; regionId= 10000045; solarSystemIds= [| 30003617; 30003618; 30003619; 30003620; 30003621; 30003622 |]; position= {x = -9.220885701e+16;  y = 5.334619991e+16;  z = 4.243990535e+17;} } |> Some
      | 20000624 -> { ConstellationData.id= 20000624; name= "Tid"; regionId= 10000054; solarSystemIds= [| 30004267; 30004268; 30004269; 30004270; 30004271; 30004272 |]; position= {x = -3.726085689e+17;  y = 1.624317976e+16;  z = -7.258838997e+16;} } |> Some
      | 20000721 -> { ConstellationData.id= 20000721; name= "XOV7-5"; regionId= 10000063; solarSystemIds= [| 30004927; 30004928; 30004929; 30004930; 30004931; 30004932; 30004933 |]; position= {x = -3.975867825e+17;  y = 8.495520275e+16;  z = -3.556673669e+17;} } |> Some
      | 21000015 -> { ConstellationData.id= 21000015; name= "A-C00015"; regionId= 11000003; solarSystemIds= [| 31000293; 31000294; 31000295; 31000296; 31000297; 31000298; 31000299; 31000300; 31000301; 31000302; 31000303; 31000304 |]; position= {x = 7.682512547e+18;  y = 1.813375546e+16;  z = -9.280123832e+18;} } |> Some
      | 21000112 -> { ConstellationData.id= 21000112; name= "C-C00112"; regionId= 11000012; solarSystemIds= [| 31001113; 31001114; 31001115; 31001116; 31001117; 31001118; 31001119 |]; position= {x = 7.506517603e+18;  y = 2.481298304e+16;  z = -9.309894018e+18;} } |> Some
      | 21000209 -> { ConstellationData.id= 21000209; name= "D-C00209"; regionId= 11000021; solarSystemIds= [| 31001740; 31001741; 31001742; 31001743; 31001744; 31001745 |]; position= {x = 7.583571885e+18;  y = 4.451008553e+15;  z = -9.124424042e+18;} } |> Some
      | 21000306 -> { ConstellationData.id= 21000306; name= "F-C00306"; regionId= 11000030; solarSystemIds= [| 31002435; 31002436; 31002437; 31002438; 31002439; 31002440; 31002441; 31002442 |]; position= {x = 7.308500568e+18;  y = 1.911845601e+16;  z = -9.818535917e+18;} } |> Some
      | _ -> None