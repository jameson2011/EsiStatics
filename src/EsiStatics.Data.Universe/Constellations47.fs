namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations47=
    let getConstellation id = 
      match id with 
      | 20000089 -> { ConstellationData.id= 20000089; name= "BVA-YH"; regionId= 10000007; solarSystemIds= [| 30000611; 30000612; 30000613; 30000614; 30000615; 30000616 |]; position= {x = 2.205341809e+17;  y = 7.175226271e+15;  z = -1.063546996e+17;} } |> Some
      | 20000186 -> { ConstellationData.id= 20000186; name= "48R-PS"; regionId= 10000015; solarSystemIds= [| 30001274; 30001275; 30001276; 30001277; 30001278; 30001279 |]; position= {x = -1.607968868e+17;  y = 1.165164234e+17;  z = 3.069562301e+17;} } |> Some
      | 20000283 -> { ConstellationData.id= 20000283; name= "V-H3V0"; regionId= 10000022; solarSystemIds= [| 30001911; 30001912; 30001913; 30001914; 30001915; 30001916; 30001917; 30001918; 30001919; 30001920; 30001921; 30001922 |]; position= {x = -2.010671516e+17;  y = 3.931209307e+16;  z = -2.996217515e+17;} } |> Some
      | 20000380 -> { ConstellationData.id= 20000380; name= "ZYR-NF"; regionId= 10000031; solarSystemIds= [| 30002588; 30002589; 30002590; 30002591; 30002592; 30002593; 30002594; 30002595; 30002596; 30002597; 30002598 |]; position= {x = -4.139819349e+16;  y = 5.866006475e+15;  z = -3.423439884e+17;} } |> Some
      | 20000477 -> { ConstellationData.id= 20000477; name= "4ZXC-8"; regionId= 10000040; solarSystemIds= [| 30003261; 30003262; 30003263; 30003264; 30003265; 30003266; 30003267 |]; position= {x = 2.425915643e+17;  y = 7.909254635e+16;  z = 1.247568684e+17;} } |> Some
      | 20000574 -> { ConstellationData.id= 20000574; name= "Budar"; regionId= 10000049; solarSystemIds= [| 30003930; 30003931; 30003932; 30003933; 30003934; 30003935 |]; position= {x = -3.565226718e+17;  y = 1.758212012e+16;  z = -1.565149624e+17;} } |> Some
      | 20000671 -> { ConstellationData.id= 20000671; name= "Satyr"; regionId= 10000058; solarSystemIds= [| 30004596; 30004597; 30004598; 30004599; 30004600; 30004601 |]; position= {x = -4.428785242e+17;  y = 4.173549054e+16;  z = 3.608078166e+16;} } |> Some
      | 20000768 -> { ConstellationData.id= 20000768; name= "Charak"; regionId= 10000067; solarSystemIds= [| 30005249; 30005250; 30005251; 30005252; 30005253; 30005254 |]; position= {x = -2.730593331e+17;  y = 1.791289761e+16;  z = -1.735055733e+16;} } |> Some
      | 21000062 -> { ConstellationData.id= 21000062; name= "B-C00062"; regionId= 11000008; solarSystemIds= [| 31000772; 31000773; 31000774; 31000775; 31000776; 31000777; 31000778; 31000779; 31000780; 31000781; 31000782 |]; position= {x = 7.514106932e+18;  y = 1.185102308e+16;  z = -9.639718727e+18;} } |> Some
      | 21000159 -> { ConstellationData.id= 21000159; name= "D-C00159"; regionId= 11000016; solarSystemIds= [| 31001417; 31001418; 31001419; 31001420; 31001421; 31001422 |]; position= {x = 7.955692754e+18;  y = 5.904524845e+15;  z = -9.637355728e+18;} } |> Some
      | 21000256 -> { ConstellationData.id= 21000256; name= "E-C00256"; regionId= 11000026; solarSystemIds= [| 31002061; 31002062; 31002063; 31002064; 31002065; 31002066; 31002067; 31002068 |]; position= {x = 7.700821587e+18;  y = 2.160681082e+16;  z = -9.025643089e+18;} } |> Some
      | _ -> None