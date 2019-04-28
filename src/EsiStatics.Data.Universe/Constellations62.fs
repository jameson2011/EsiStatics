namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations62=
    let getConstellation id = 
      match id with 
      | 20000007 -> { ConstellationData.id= 20000007; name= "Ananah"; regionId= 10000001; solarSystemIds= [| 30000044; 30000045; 30000046; 30000047; 30000048; 30000049; 30000050 |]; position= {x = -8.138726738e+16;  y = 3.579562939e+16;  z = -9.315303608e+16;} } |> Some
      | 20000104 -> { ConstellationData.id= 20000104; name= "WQZ8-4"; regionId= 10000008; solarSystemIds= [| 30000709; 30000710; 30000711; 30000712; 30000713; 30000714 |]; position= {x = 8.783681881e+16;  y = 3.147063791e+16;  z = -1.143928294e+17;} } |> Some
      | 20000201 -> { ConstellationData.id= 20000201; name= "Okela"; regionId= 10000016; solarSystemIds= [| 30001374; 30001375; 30001376; 30001377; 30001378; 30001379; 30011392; 30031407; 30041407 |]; position= {x = -1.488809652e+17;  y = 8.809805234e+16;  z = 1.216579515e+17;} } |> Some
      | 20000298 -> { ConstellationData.id= 20000298; name= "K-QUVW"; regionId= 10000023; solarSystemIds= [| 30002023; 30002024; 30002025; 30002026; 30002027; 30002028 |]; position= {x = -2.697364302e+17;  y = 8.655815766e+16;  z = 2.11400119e+17;} } |> Some
      | 20000395 -> { ConstellationData.id= 20000395; name= "Wyllequet"; regionId= 10000032; solarSystemIds= [| 30002699; 30002700; 30002701; 30002702; 30002703; 30002704; 30002705 |]; position= {x = -1.771214174e+17;  y = 5.124951079e+16;  z = 5.614099164e+15;} } |> Some
      | 20000492 -> { ConstellationData.id= 20000492; name= "Gedur"; regionId= 10000042; solarSystemIds= [| 30003374; 30003375; 30003376; 30003377; 30003378; 30003379; 30003380; 30013410; 30022505 |]; position= {x = -7.504134056e+16;  y = 4.828623303e+16;  z = 1.12208909e+16;} } |> Some
      | 20000589 -> { ConstellationData.id= 20000589; name= "XLL-Z7"; regionId= 10000050; solarSystemIds= [| 30004031; 30004032; 30004033; 30004034; 30004035; 30004036 |]; position= {x = -3.453324057e+17;  y = 6.91076064e+16;  z = -3.029139764e+17;} } |> Some
      | 20000686 -> { ConstellationData.id= 20000686; name= "GEP-XF"; regionId= 10000059; solarSystemIds= [| 30004692; 30004693; 30004694; 30004695; 30004696; 30004697; 30004698; 30004699 |]; position= {x = -1.18461288e+17;  y = -4.837231641e+15;  z = -4.635490645e+17;} } |> Some
      | 20000783 -> { ConstellationData.id= 20000783; name= "Inolari"; regionId= 10000069; solarSystemIds= [| 30045314; 30045315; 30045316; 30045317; 30045318; 30045319; 30045320 |]; position= {x = -2.3340885e+17;  y = 1.014831778e+17;  z = 1.628835751e+17;} } |> Some
      | 21000077 -> { ConstellationData.id= 21000077; name= "C-C00077"; regionId= 11000009; solarSystemIds= [| 31000886; 31000887; 31000888; 31000889; 31000890; 31000891 |]; position= {x = 7.740454792e+18;  y = 1.429214803e+16;  z = -9.83593483e+18;} } |> Some
      | 21000174 -> { ConstellationData.id= 21000174; name= "D-C00174"; regionId= 11000019; solarSystemIds= [| 31001513; 31001514; 31001515; 31001516; 31001517; 31001518; 31001519 |]; position= {x = 7.462392349e+18;  y = 1.591766389e+16;  z = -9.563520965e+18;} } |> Some
      | 21000271 -> { ConstellationData.id= 21000271; name= "E-C00271"; regionId= 11000027; solarSystemIds= [| 31002171; 31002172; 31002173; 31002174; 31002175; 31002176; 31002177 |]; position= {x = 8.147487272e+18;  y = 1.286330367e+16;  z = -9.282641913e+18;} } |> Some
      | _ -> None