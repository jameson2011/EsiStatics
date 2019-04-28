namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations35=
    let getConstellation id = 
      match id with 
      | 20000077 -> { ConstellationData.id= 20000077; name= "0FC-ZX"; regionId= 10000006; solarSystemIds= [| 30000529; 30000530; 30000531; 30000532; 30000533; 30000534; 30000535; 30000536; 30000537; 30000538 |]; position= {x = 1.220727589e+17;  y = -1.677971777e+16;  z = -1.576195976e+17;} } |> Some
      | 20000174 -> { ConstellationData.id= 20000174; name= "XR9-LP"; regionId= 10000014; solarSystemIds= [| 30001188; 30001189; 30001190; 30001191; 30001192; 30001193; 30001194; 30001195; 30001196; 30001197 |]; position= {x = -5.292853447e+16;  y = 2.328859568e+16;  z = -2.208276742e+17;} } |> Some
      | 20000271 -> { ConstellationData.id= 20000271; name= "5VN-B7"; regionId= 10000022; solarSystemIds= [| 30001831; 30001832; 30001833; 30001834; 30001835; 30001836; 30001837 |]; position= {x = -9.675928727e+16;  y = 2.673796472e+16;  z = -2.680988737e+17;} } |> Some
      | 20000368 -> { ConstellationData.id= 20000368; name= "Huvilma"; regionId= 10000030; solarSystemIds= [| 30002512; 30002513; 30002514; 30002515; 30002516; 30002517 |]; position= {x = -1.206444417e+17;  y = 5.913107402e+16;  z = 1.341995667e+15;} } |> Some
      | 20000465 -> { ConstellationData.id= 20000465; name= "WE-WLQ"; regionId= 10000040; solarSystemIds= [| 30003183; 30003184; 30003185; 30003186; 30003187; 30003188; 30003189; 30003190 |]; position= {x = 1.942547503e+17;  y = 8.428088595e+16;  z = 9.280231399e+16;} } |> Some
      | 20000562 -> { ConstellationData.id= 20000562; name= "Mallugier"; regionId= 10000048; solarSystemIds= [| 30003843; 30003844; 30003845; 30003846; 30003847; 30003848; 30003849 |]; position= {x = -2.537725681e+17;  y = 6.501483458e+16;  z = 6.631712761e+16;} } |> Some
      | 20000659 -> { ConstellationData.id= 20000659; name= "Wield"; regionId= 10000057; solarSystemIds= [| 30004514; 30004515; 30004516; 30004517; 30004518; 30004519 |]; position= {x = -3.913477945e+17;  y = 3.248913656e+16;  z = 7.927599366e+16;} } |> Some
      | 20000756 -> { ConstellationData.id= 20000756; name= "Q0-4FU"; regionId= 10000066; solarSystemIds= [| 30005168; 30005169; 30005170; 30005171; 30005172; 30005173 |]; position= {x = 2.333045834e+17;  y = 1.620426961e+16;  z = 5.194138785e+16;} } |> Some
      | 21000050 -> { ConstellationData.id= 21000050; name= "B-C00050"; regionId= 11000006; solarSystemIds= [| 31000650; 31000651; 31000652; 31000653; 31000654; 31000655; 31000656; 31000657; 31000658 |]; position= {x = 7.846536414e+18;  y = 3.822771695e+16;  z = -9.614813527e+18;} } |> Some
      | 21000147 -> { ConstellationData.id= 21000147; name= "C-C00147"; regionId= 11000015; solarSystemIds= [| 31001335; 31001336; 31001337; 31001338; 31001339; 31001340; 31001341 |]; position= {x = 8.000716511e+18;  y = 2.664373099e+16;  z = -9.474617413e+18;} } |> Some
      | 21000244 -> { ConstellationData.id= 21000244; name= "E-C00244"; regionId= 11000025; solarSystemIds= [| 31001974; 31001975; 31001976; 31001977; 31001978; 31001979; 31001980; 31001981; 31001982; 31002481 |]; position= {x = 7.341192433e+18;  y = 6.894203256e+15;  z = -9.110520829e+18;} } |> Some
      | 22000023 -> { ConstellationData.id= 22000023; name= "ADC23"; regionId= 12000005; solarSystemIds= [| 32000177; 32000178; 32000179; 32000180; 32000181; 32000182; 32000183; 32000184 |]; position= {x = 5.108454775e+18;  y = 5.769480014e+18;  z = -9.044544886e+18;} } |> Some
      | _ -> None