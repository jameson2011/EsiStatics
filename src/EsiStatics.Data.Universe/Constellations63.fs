namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations63=
    let getConstellation id = 
      match id with 
      | 20000008 -> { ConstellationData.id= 20000008; name= "Mossas"; regionId= 10000001; solarSystemIds= [| 30000051; 30000052; 30000053; 30000054; 30000055; 30000056 |]; position= {x = -8.074379501e+16;  y = 3.828316266e+16;  z = -6.481184138e+16;} } |> Some
      | 20000105 -> { ConstellationData.id= 20000105; name= "DITJ-X"; regionId= 10000008; solarSystemIds= [| 30000715; 30000716; 30000717; 30000718; 30000719; 30000720 |]; position= {x = 1.096369744e+17;  y = 2.300028185e+16;  z = -1.345221867e+17;} } |> Some
      | 20000202 -> { ConstellationData.id= 20000202; name= "Kaala"; regionId= 10000016; solarSystemIds= [| 30001380; 30001382; 30001383; 30001384; 30001385 |]; position= {x = -1.514685384e+17;  y = 7.590615734e+16;  z = 1.558990266e+17;} } |> Some
      | 20000299 -> { ConstellationData.id= 20000299; name= "LN-L8L"; regionId= 10000023; solarSystemIds= [| 30002029; 30002030; 30002031; 30002032; 30002033; 30002034 |]; position= {x = -3.011039465e+17;  y = 6.145829462e+16;  z = 2.237534776e+17;} } |> Some
      | 20000396 -> { ConstellationData.id= 20000396; name= "Agiesseson"; regionId= 10000032; solarSystemIds= [| 30002706; 30002707; 30002708; 30002709; 30002710; 30002711; 30022715; 30032715 |]; position= {x = -1.734884241e+17;  y = 4.788021335e+16;  z = 4.104266371e+16;} } |> Some
      | 20000493 -> { ConstellationData.id= 20000493; name= "Lorundio"; regionId= 10000042; solarSystemIds= [| 30003381; 30003382; 30003383; 30003384; 30003385; 30003386 |]; position= {x = -1.198570182e+17;  y = 5.313399715e+16;  z = 7.908570929e+16;} } |> Some
      | 20000590 -> { ConstellationData.id= 20000590; name= "Yrton"; regionId= 10000051; solarSystemIds= [| 30004037; 30004038; 30004039; 30004040; 30004041; 30004042 |]; position= {x = -3.343432165e+17;  y = 5.450425179e+16;  z = 1.165132366e+17;} } |> Some
      | 20000687 -> { ConstellationData.id= 20000687; name= "D9DM-O"; regionId= 10000059; solarSystemIds= [| 30004700; 30004701; 30004702; 30004703; 30004704; 30004705 |]; position= {x = -1.471033127e+17;  y = -3.928933496e+16;  z = -4.801034003e+17;} } |> Some
      | 20000784 -> { ConstellationData.id= 20000784; name= "Aokinen"; regionId= 10000069; solarSystemIds= [| 30045321; 30045322; 30045323; 30045324; 30045325; 30045326; 30045327 |]; position= {x = -2.172576731e+17;  y = 1.030204017e+17;  z = 1.535361406e+17;} } |> Some
      | 21000078 -> { ConstellationData.id= 21000078; name= "C-C00078"; regionId= 11000009; solarSystemIds= [| 31000892; 31000893; 31000894; 31000895; 31000896; 31000897; 31000898 |]; position= {x = 7.764759581e+18;  y = 3.146180155e+16;  z = -9.862079806e+18;} } |> Some
      | 21000175 -> { ConstellationData.id= 21000175; name= "D-C00175"; regionId= 11000019; solarSystemIds= [| 31001520; 31001521; 31001522; 31001523; 31001524; 31001525; 31001526 |]; position= {x = 7.461559134e+18;  y = 4.040087745e+16;  z = -9.587496152e+18;} } |> Some
      | 21000272 -> { ConstellationData.id= 21000272; name= "E-C00272"; regionId= 11000027; solarSystemIds= [| 31002178; 31002179; 31002180; 31002181; 31002182; 31002183; 31002184; 31002185 |]; position= {x = 8.169848591e+18;  y = 3.461559759e+16;  z = -9.371120546e+18;} } |> Some
      | _ -> None