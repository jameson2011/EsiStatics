namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations66=
    let getConstellation id = 
      match id with 
      | 20000011 -> { ConstellationData.id= 20000011; name= "Orshed"; regionId= 10000001; solarSystemIds= [| 30000076; 30000077; 30000078; 30000079; 30000080; 30000081 |]; position= {x = -1.041779905e+17;  y = 6.422897755e+16;  z = -5.785058206e+16;} } |> Some
      | 20000108 -> { ConstellationData.id= 20000108; name= "IV-LWJ"; regionId= 10000009; solarSystemIds= [| 30000736; 30000737; 30000738; 30000739; 30000740; 30000741; 30000742 |]; position= {x = 1.436695423e+17;  y = 3.899293088e+16;  z = -1.21491323e+17;} } |> Some
      | 20000205 -> { ConstellationData.id= 20000205; name= "Minnen"; regionId= 10000016; solarSystemIds= [| 30001398; 30001399; 30001400; 30001401; 30001402; 30001403 |]; position= {x = -1.884977744e+17;  y = 1.045576256e+17;  z = 1.6602448e+17;} } |> Some
      | 20000302 -> { ConstellationData.id= 20000302; name= "Barvigrard"; regionId= 10000042; solarSystemIds= [| 30002048; 30002049; 30002050; 30002051; 30002052; 30002053 |]; position= {x = -1.242648695e+17;  y = 2.894898206e+16;  z = 5.739033518e+16;} } |> Some
      | 20000399 -> { ConstellationData.id= 20000399; name= "Nadire"; regionId= 10000032; solarSystemIds= [| 30002724; 30002725; 30002726; 30002727; 30002728; 30002729; 30002730 |]; position= {x = -2.186196398e+17;  y = 6.856103656e+16;  z = 3.805695504e+15;} } |> Some
      | 20000496 -> { ConstellationData.id= 20000496; name= "Stadakorn"; regionId= 10000042; solarSystemIds= [| 30003400; 30003401; 30003402; 30003403; 30003404; 30003405; 30003406; 30003407; 30003408; 30033410 |]; position= {x = -7.503796378e+16;  y = 3.188201736e+16;  z = 4.020896766e+16;} } |> Some
      | 20000593 -> { ConstellationData.id= 20000593; name= "Prelle"; regionId= 10000051; solarSystemIds= [| 30004057; 30004058; 30004059; 30004060; 30004061; 30004062; 30004063; 30004064 |]; position= {x = -3.264470293e+17;  y = 5.805201458e+16;  z = 1.735838716e+17;} } |> Some
      | 20000690 -> { ConstellationData.id= 20000690; name= "6-UCYU"; regionId= 10000060; solarSystemIds= [| 30004718; 30004719; 30004720; 30004721; 30004722; 30004723 |]; position= {x = -4.045516834e+17;  y = 4.928458306e+16;  z = -2.471114233e+17;} } |> Some
      | 21000081 -> { ConstellationData.id= 21000081; name= "C-C00081"; regionId= 11000009; solarSystemIds= [| 31000912; 31000913; 31000914; 31000915; 31000916; 31000917 |]; position= {x = 7.751049243e+18;  y = 1.426224095e+16;  z = -9.862286893e+18;} } |> Some
      | 21000178 -> { ConstellationData.id= 21000178; name= "D-C00178"; regionId= 11000019; solarSystemIds= [| 31001540; 31001541; 31001542; 31001543; 31001544; 31001545; 31001546 |]; position= {x = 7.481480654e+18;  y = 3.36158122e+16;  z = -9.543963103e+18;} } |> Some
      | 21000275 -> { ConstellationData.id= 21000275; name= "E-C00275"; regionId= 11000028; solarSystemIds= [| 31002203; 31002204; 31002205; 31002206; 31002207; 31002208; 31002472 |]; position= {x = 8.023127493e+18;  y = 2.938883192e+16;  z = -9.891527738e+18;} } |> Some
      | _ -> None