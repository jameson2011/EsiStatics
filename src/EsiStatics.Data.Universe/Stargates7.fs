﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stargates7=
    let getStargate id = 
      match id with 
      | 50000015 -> { StargateData.id= 50000015; name= "Stargate (JVA-FE)"; solarSystemId= 30001561; position= {x = -5.601424589e+11;  y = 2.080198656e+10;  z = 1.296420864e+10;}; typeId= 3875; destinationSolarSystemId= 30001567; destinationStargateId= 50002138 } |> Some
      | 50000112 -> { StargateData.id= 50000112; name= "Stargate (Onsooh)"; solarSystemId= 30000010; position= {x = 4.313106063e+12;  y = 5.696005325e+11;  z = -1.874452439e+12;}; typeId= 29624; destinationSolarSystemId= 30000013; destinationStargateId= 50001442 } |> Some
      | 50000209 -> { StargateData.id= 50000209; name= "Stargate (TP7-KE)"; solarSystemId= 30000716; position= {x = -4.286529946e+11;  y = -1.447668818e+12;  z = -2.921644401e+12;}; typeId= 29635; destinationSolarSystemId= 30000588; destinationStargateId= 50002122 } |> Some
      | 50000306 -> { StargateData.id= 50000306; name= "Stargate (13-49W)"; solarSystemId= 30001051; position= {x = -1.354222387e+11;  y = -2.246301696e+11;  z = 2.41203966e+12;}; typeId= 3874; destinationSolarSystemId= 30001066; destinationStargateId= 50001244 } |> Some
      | 50000403 -> { StargateData.id= 50000403; name= "Stargate (Dodixie)"; solarSystemId= 30002655; position= {x = -1.070150246e+12;  y = -5.511991296e+10;  z = 3.631223194e+11;}; typeId= 3875; destinationSolarSystemId= 30002659; destinationStargateId= 50007872 } |> Some
      | 50000500 -> { StargateData.id= 50000500; name= "Stargate (36N-HZ)"; solarSystemId= 30001154; position= {x = 3.760955105e+12;  y = 5.030022758e+11;  z = -5.666730394e+11;}; typeId= 29624; destinationSolarSystemId= 30001157; destinationStargateId= 50000869 } |> Some
      | 50000597 -> { StargateData.id= 50000597; name= "Stargate (O31W-6)"; solarSystemId= 30001057; position= {x = -3.68378622e+12;  y = -2.793513001e+12;  z = -1.257423299e+12;}; typeId= 29632; destinationSolarSystemId= 30002851; destinationStargateId= 50000697 } |> Some
      | 50000694 -> { StargateData.id= 50000694; name= "Stargate (S4-9DN)"; solarSystemId= 30004804; position= {x = -1.458252718e+12;  y = -2.822909952e+10;  z = -3.311594988e+12;}; typeId= 29633; destinationSolarSystemId= 30004805; destinationStargateId= 50001500 } |> Some
      | 50000791 -> { StargateData.id= 50000791; name= "Stargate (HQ-Q1Q)"; solarSystemId= 30000688; position= {x = -2.393848504e+12;  y = 1.168378675e+11;  z = -3.078818734e+12;}; typeId= 29633; destinationSolarSystemId= 30000686; destinationStargateId= 50000568 } |> Some
      | 50000888 -> { StargateData.id= 50000888; name= "Stargate (PM-DWE)"; solarSystemId= 30000238; position= {x = 6.845446963e+11;  y = 3.845664768e+10;  z = -8.519313408e+11;}; typeId= 16; destinationSolarSystemId= 30000243; destinationStargateId= 50002015 } |> Some
      | 50000985 -> { StargateData.id= 50000985; name= "Stargate (M9-MLR)"; solarSystemId= 30000680; position= {x = -1.275267072e+11;  y = -1.575481344e+10;  z = 1.9012608e+10;}; typeId= 29633; destinationSolarSystemId= 30000681; destinationStargateId= 50001123 } |> Some
      | 50001082 -> { StargateData.id= 50001082; name= "Stargate (Sosa)"; solarSystemId= 30000090; position= {x = 3.515992105e+12;  y = -2.55507456e+11;  z = -3.694071521e+12;}; typeId= 29624; destinationSolarSystemId= 30000089; destinationStargateId= 50000600 } |> Some
      | 50001276 -> { StargateData.id= 50001276; name= "Stargate (X5-0EM)"; solarSystemId= 30000761; position= {x = -6.179258819e+12;  y = -9.175209861e+12;  z = -1.293731635e+12;}; typeId= 3877; destinationSolarSystemId= 30000777; destinationStargateId= 50000002 } |> Some
      | 50001373 -> { StargateData.id= 50001373; name= "Stargate (L-1HKR)"; solarSystemId= 30000875; position= {x = 3.428055859e+11;  y = -1.025814528e+10;  z = -3.229056614e+11;}; typeId= 16; destinationSolarSystemId= 30000874; destinationStargateId= 50000735 } |> Some
      | 50001470 -> { StargateData.id= 50001470; name= "Stargate (Passari)"; solarSystemId= 30001400; position= {x = 2.825941033e+12;  y = 4.280973312e+11;  z = -2.380883436e+12;}; typeId= 16; destinationSolarSystemId= 30001402; destinationStargateId= 50001940 } |> Some
      | 50001567 -> { StargateData.id= 50001567; name= "Stargate (Mifrata)"; solarSystemId= 30000047; position= {x = -6.575854756e+12;  y = 1.182739292e+12;  z = -3.6629325e+12;}; typeId= 29624; destinationSolarSystemId= 30000046; destinationStargateId= 50001047 } |> Some
      | 50001664 -> { StargateData.id= 50001664; name= "Stargate (SJJ-4F)"; solarSystemId= 30000569; position= {x = -2.967497073e+12;  y = -3.597480346e+11;  z = -1.504261448e+12;}; typeId= 29633; destinationSolarSystemId= 30000571; destinationStargateId= 50002621 } |> Some
      | 50001761 -> { StargateData.id= 50001761; name= "Stargate (Fricoure)"; solarSystemId= 30002699; position= {x = -2.124935578e+11;  y = -3.379257876e+12;  z = 2.489819505e+12;}; typeId= 3874; destinationSolarSystemId= 30002734; destinationStargateId= 50009626 } |> Some
      | 50001858 -> { StargateData.id= 50001858; name= "Stargate (Kamela)"; solarSystemId= 30003068; position= {x = 2.860796436e+12;  y = -3.701513011e+11;  z = -4.112915128e+12;}; typeId= 29624; destinationSolarSystemId= 30003069; destinationStargateId= 50001998 } |> Some
      | 50001955 -> { StargateData.id= 50001955; name= "Stargate (1L-AED)"; solarSystemId= 30000957; position= {x = 1.899487273e+12;  y = -9.916772352e+10;  z = -1.873252884e+12;}; typeId= 29633; destinationSolarSystemId= 30000962; destinationStargateId= 50003902 } |> Some
      | 50002052 -> { StargateData.id= 50002052; name= "Stargate (Akonoinen)"; solarSystemId= 30001384; position= {x = -9.91821865e+11;  y = -1.929873408e+11;  z = -1.001418793e+12;}; typeId= 16; destinationSolarSystemId= 30001382; destinationStargateId= 50001676 } |> Some
      | 50002149 -> { StargateData.id= 50002149; name= "Stargate (L5-UWT)"; solarSystemId= 30000788; position= {x = 1.806144676e+12;  y = 5.928431616e+10;  z = -3.060271227e+12;}; typeId= 29633; destinationSolarSystemId= 30000786; destinationStargateId= 50000943 } |> Some
      | 50002246 -> { StargateData.id= 50002246; name= "Stargate (Aikoro)"; solarSystemId= 30002754; position= {x = 1.837509427e+11;  y = 2.990149632e+10;  z = -1.777358561e+12;}; typeId= 16; destinationSolarSystemId= 30002753; destinationStargateId= 50001199 } |> Some
      | 50002343 -> { StargateData.id= 50002343; name= "Stargate (Dysa)"; solarSystemId= 30000099; position= {x = 6.060838625e+12;  y = 4.849398989e+11;  z = -4.463653233e+12;}; typeId= 29624; destinationSolarSystemId= 30000102; destinationStargateId= 50003078 } |> Some
      | 50002537 -> { StargateData.id= 50002537; name= "Stargate (C3J0-O)"; solarSystemId= 30002853; position= {x = 6.130265702e+11;  y = 1.257689088e+10;  z = 8.454012518e+11;}; typeId= 3875; destinationSolarSystemId= 30002858; destinationStargateId= 50004869 } |> Some
      | 50002634 -> { StargateData.id= 50002634; name= "Stargate (Sehmosh)"; solarSystemId= 30001657; position= {x = -1.40355072e+12;  y = -2.770724045e+11;  z = -5.180181258e+12;}; typeId= 29624; destinationSolarSystemId= 30001659; destinationStargateId= 50005997 } |> Some
      | 50002828 -> { StargateData.id= 50002828; name= "Stargate (3-OKDA)"; solarSystemId= 30001201; position= {x = 2.33632297e+12;  y = 4.14715945e+11;  z = -7.3595904e+10;}; typeId= 29624; destinationSolarSystemId= 30001199; destinationStargateId= 50002520 } |> Some
      | 50002925 -> { StargateData.id= 50002925; name= "Stargate (Arena)"; solarSystemId= 30000101; position= {x = 1.103070413e+11;  y = 1.353437184e+10;  z = 4.168003584e+10;}; typeId= 29624; destinationSolarSystemId= 30000099; destinationStargateId= 50002342 } |> Some
      | 50003022 -> { StargateData.id= 50003022; name= "Stargate (O8W-5O)"; solarSystemId= 30005094; position= {x = -2.467594936e+12;  y = 3.534559764e+12;  z = 2.977669079e+12;}; typeId= 29632; destinationSolarSystemId= 30001068; destinationStargateId= 50001932 } |> Some
      | 50003119 -> { StargateData.id= 50003119; name= "Stargate (MN9P-A)"; solarSystemId= 30002842; position= {x = 1.875761971e+11;  y = 3.22271232e+10;  z = 2934743040.0;}; typeId= 3875; destinationSolarSystemId= 30002840; destinationStargateId= 50001322 } |> Some
      | 50003216 -> { StargateData.id= 50003216; name= "Stargate (WNM-V0)"; solarSystemId= 30002855; position= {x = -2.413492101e+12;  y = -1.205889024e+11;  z = -1.46639106e+12;}; typeId= 3875; destinationSolarSystemId= 30002854; destinationStargateId= 50002849 } |> Some
      | 50003313 -> { StargateData.id= 50003313; name= "Stargate (Indregulle)"; solarSystemId= 30004979; position= {x = -2.935560806e+12;  y = -5.920738099e+11;  z = 5.774876221e+12;}; typeId= 3875; destinationSolarSystemId= 30004982; destinationStargateId= 50006806 } |> Some
      | 50003410 -> { StargateData.id= 50003410; name= "Stargate (Kemerk)"; solarSystemId= 30004987; position= {x = -2.77515817e+12;  y = 5.08227625e+11;  z = 1.002779566e+12;}; typeId= 3876; destinationSolarSystemId= 30005206; destinationStargateId= 50003400 } |> Some
      | 50003507 -> { StargateData.id= 50003507; name= "Stargate (VD-8QY)"; solarSystemId= 30000841; position= {x = 3.211724268e+12;  y = 2.561926349e+11;  z = -1.477320745e+12;}; typeId= 29633; destinationSolarSystemId= 30000842; destinationStargateId= 50003654 } |> Some
      | 50003604 -> { StargateData.id= 50003604; name= "Stargate (74L2-U)"; solarSystemId= 30000826; position= {x = 3.67947092e+12;  y = -2.619711898e+11;  z = -9.39855913e+11;}; typeId= 29633; destinationSolarSystemId= 30000827; destinationStargateId= 50003691 } |> Some
      | 50003701 -> { StargateData.id= 50003701; name= "Stargate (1GH-48)"; solarSystemId= 30002333; position= {x = -6.110019994e+11;  y = 4.972105728e+10;  z = -1.619342991e+12;}; typeId= 3875; destinationSolarSystemId= 30002332; destinationStargateId= 50003560 } |> Some
      | 50003798 -> { StargateData.id= 50003798; name= "Stargate (0RI-OV)"; solarSystemId= 30000605; position= {x = -5.701287567e+12;  y = 1.843350528e+12;  z = -2.944164372e+12;}; typeId= 3877; destinationSolarSystemId= 30000566; destinationStargateId= 50001058 } |> Some
      | 50003895 -> { StargateData.id= 50003895; name= "Stargate (S-R9J2)"; solarSystemId= 30001090; position= {x = 2.411904246e+12;  y = 3.927329587e+11;  z = -3.350086042e+11;}; typeId= 3875; destinationSolarSystemId= 30001088; destinationStargateId= 50003287 } |> Some
      | 50003992 -> { StargateData.id= 50003992; name= "Stargate (WE3-BX)"; solarSystemId= 30000973; position= {x = -1.019542118e+12;  y = 2.985947136e+10;  z = 5.924007936e+10;}; typeId= 29633; destinationSolarSystemId= 30000972; destinationStargateId= 50003847 } |> Some
      | 50004089 -> { StargateData.id= 50004089; name= "Stargate (EWOK-K)"; solarSystemId= 30001987; position= {x = 2.571123302e+12;  y = -3.170506752e+11;  z = 1.843995156e+12;}; typeId= 16; destinationSolarSystemId= 30001985; destinationStargateId= 50003970 } |> Some
      | 50004283 -> { StargateData.id= 50004283; name= "Stargate (Scolluzer)"; solarSystemId= 30005304; position= {x = 2.971195392e+11;  y = -2.042005217e+12;  z = 1.77866453e+12;}; typeId= 3874; destinationSolarSystemId= 30005322; destinationStargateId= 50005487 } |> Some
      | 50004380 -> { StargateData.id= 50004380; name= "Stargate (K-BBYU)"; solarSystemId= 30001551; position= {x = 4.21826433e+12;  y = 6.502176768e+11;  z = 1.333649818e+11;}; typeId= 3875; destinationSolarSystemId= 30001550; destinationStargateId= 50003417 } |> Some
      | 50004477 -> { StargateData.id= 50004477; name= "Stargate (1-GBBP)"; solarSystemId= 30000303; position= {x = -3.860681073e+12;  y = 5.287120896e+10;  z = -2.391182991e+12;}; typeId= 16; destinationSolarSystemId= 30000301; destinationStargateId= 50004223 } |> Some
      | 50004574 -> { StargateData.id= 50004574; name= "Stargate (SV-K8J)"; solarSystemId= 30002444; position= {x = -5.475656909e+11;  y = 1.85505792e+10;  z = -1.154715525e+12;}; typeId= 16; destinationSolarSystemId= 30002445; destinationStargateId= 50004666 } |> Some
      | 50004768 -> { StargateData.id= 50004768; name= "Stargate (Dihra)"; solarSystemId= 30002995; position= {x = 5.966488781e+11;  y = -4.486371533e+12;  z = 5.31813716e+12;}; typeId= 17; destinationSolarSystemId= 30002967; destinationStargateId= 50003425 } |> Some
      | 50004865 -> { StargateData.id= 50004865; name= "Stargate (6RQ9-A)"; solarSystemId= 30002447; position= {x = -3.526890701e+11;  y = -4.467339264e+10;  z = 1.256611553e+12;}; typeId= 16; destinationSolarSystemId= 30002446; destinationStargateId= 50004807 } |> Some
      | 50005059 -> { StargateData.id= 50005059; name= "Stargate (YHEN-G)"; solarSystemId= 30000534; position= {x = -1.841267098e+11;  y = 1.710772224e+10;  z = 9.06749952e+10;}; typeId= 29633; destinationSolarSystemId= 30000530; destinationStargateId= 50002606 } |> Some
      | 50005156 -> { StargateData.id= 50005156; name= "Stargate (Shuria)"; solarSystemId= 30002236; position= {x = 2.38388908e+12;  y = 6.257516421e+12;  z = 2.926009836e+12;}; typeId= 17; destinationSolarSystemId= 30002201; destinationStargateId= 50003365 } |> Some
      | 50005253 -> { StargateData.id= 50005253; name= "Stargate (YHEN-G)"; solarSystemId= 30000535; position= {x = -2.69327487e+12;  y = -4.534074163e+11;  z = -2.267037327e+12;}; typeId= 29633; destinationSolarSystemId= 30000530; destinationStargateId= 50002607 } |> Some
      | 50005350 -> { StargateData.id= 50005350; name= "Stargate (SAI-T9)"; solarSystemId= 30000478; position= {x = -1.191004692e+12;  y = 1.786923786e+12;  z = -1.381921874e+12;}; typeId= 3877; destinationSolarSystemId= 30000508; destinationStargateId= 50006228 } |> Some
      | 50005447 -> { StargateData.id= 50005447; name= "Stargate (Tintoh)"; solarSystemId= 30002783; position= {x = 5.69755607e+11;  y = -1.116483994e+11;  z = 3.045976351e+12;}; typeId= 16; destinationSolarSystemId= 30002784; destinationStargateId= 50007078 } |> Some
      | 50005544 -> { StargateData.id= 50005544; name= "Stargate (Arlek)"; solarSystemId= 30003410; position= {x = 4.442823475e+11;  y = 1874780160.0;  z = 1.09360214e+12;}; typeId= 29633; destinationSolarSystemId= 30003411; destinationStargateId= 50006414 } |> Some
      | 50005641 -> { StargateData.id= 50005641; name= "Stargate (9OLQ-6)"; solarSystemId= 30000801; position= {x = -8.966586778e+11;  y = -1.259268096e+11;  z = -3.501820723e+11;}; typeId= 29633; destinationSolarSystemId= 30000800; destinationStargateId= 50005022 } |> Some
      | 50005738 -> { StargateData.id= 50005738; name= "Stargate (Barira)"; solarSystemId= 30003545; position= {x = 4.551365837e+11;  y = 8.277602304e+10;  z = -5.40399489e+12;}; typeId= 29624; destinationSolarSystemId= 30003548; destinationStargateId= 50006549 } |> Some
      | 50005835 -> { StargateData.id= 50005835; name= "Stargate (Azerakish)"; solarSystemId= 30001708; position= {x = -2.907312538e+11;  y = -2.848763904e+10;  z = -2.461580083e+11;}; typeId= 29624; destinationSolarSystemId= 30001711; destinationStargateId= 50007260 } |> Some
      | 50005932 -> { StargateData.id= 50005932; name= "Stargate (CJNF-J)"; solarSystemId= 30002125; position= {x = 3.29340887e+11;  y = -5.287047168e+10;  z = -1.257999974e+11;}; typeId= 29633; destinationSolarSystemId= 30002127; destinationStargateId= 50009025 } |> Some
      | 50006029 -> { StargateData.id= 50006029; name= "Stargate (9K-VDI)"; solarSystemId= 30000427; position= {x = -3.927116636e+12;  y = 2.813695181e+11;  z = 2.592174858e+12;}; typeId= 3876; destinationSolarSystemId= 30000429; destinationStargateId= 50006139 } |> Some
      | 50006126 -> { StargateData.id= 50006126; name= "Stargate (Villore)"; solarSystemId= 30005000; position= {x = 1.443926016e+10;  y = -243916800.0;  z = -1.106745385e+12;}; typeId= 3875; destinationSolarSystemId= 30004993; destinationStargateId= 50003539 } |> Some
      | 50006223 -> { StargateData.id= 50006223; name= "Stargate (Vivanier)"; solarSystemId= 30003809; position= {x = -5.15447255e+12;  y = 5.441673216e+11;  z = 4.075307704e+12;}; typeId= 3875; destinationSolarSystemId= 30003810; destinationStargateId= 50006341 } |> Some
      | 50006320 -> { StargateData.id= 50006320; name= "Stargate (Polfaly)"; solarSystemId= 30005037; position= {x = 2.426040115e+12;  y = 1.118709965e+12;  z = 2.311337042e+12;}; typeId= 17; destinationSolarSystemId= 30005048; destinationStargateId= 50009275 } |> Some
      | 50006417 -> { StargateData.id= 50006417; name= "Stargate (Yanuel)"; solarSystemId= 30001702; position= {x = -4.128807199e+12;  y = -6.885132288e+11;  z = -1.490094858e+12;}; typeId= 29624; destinationSolarSystemId= 30001701; destinationStargateId= 50005853 } |> Some
      | 50006514 -> { StargateData.id= 50006514; name= "Stargate (Wysalan)"; solarSystemId= 30005015; position= {x = -1.115127398e+11;  y = 391372800.0;  z = 9.402986496e+10;}; typeId= 3875; destinationSolarSystemId= 30005016; destinationStargateId= 50008037 } |> Some
      | 50006611 -> { StargateData.id= 50006611; name= "Stargate (LU-HQS)"; solarSystemId= 30002461; position= {x = 2.112561439e+12;  y = 4.261912166e+11;  z = 1.776140698e+11;}; typeId= 16; destinationSolarSystemId= 30002462; destinationStargateId= 50006804 } |> Some
      | 50006708 -> { StargateData.id= 50006708; name= "Stargate (Tierijev)"; solarSystemId= 30005331; position= {x = -8.848823501e+11;  y = -8.156491776e+10;  z = 7.208655667e+11;}; typeId= 3875; destinationSolarSystemId= 30005334; destinationStargateId= 50008469 } |> Some
      | 50006805 -> { StargateData.id= 50006805; name= "Stargate (K25-XD)"; solarSystemId= 30002462; position= {x = 6.712536392e+12;  y = -6.245298586e+11;  z = -3.995520246e+12;}; typeId= 16; destinationSolarSystemId= 30002464; destinationStargateId= 50007153 } |> Some
      | 50006902 -> { StargateData.id= 50006902; name= "Stargate (Ilonarav)"; solarSystemId= 30002259; position= {x = 9.281275945e+12;  y = -1.599429304e+12;  z = -7.834672374e+12;}; typeId= 17; destinationSolarSystemId= 30002208; destinationStargateId= 50005241 } |> Some
      | 50006999 -> { StargateData.id= 50006999; name= "Stargate (Odixie)"; solarSystemId= 30003047; position= {x = -3.097090867e+11;  y = 6.06971904e+10;  z = 2.215954391e+12;}; typeId= 3875; destinationSolarSystemId= 30003050; destinationStargateId= 50009736 } |> Some
      | 50007096 -> { StargateData.id= 50007096; name= "Stargate (Keberz)"; solarSystemId= 30003882; position= {x = -9.584569958e+11;  y = 1.566534451e+11;  z = 1.982650368e+11;}; typeId= 29624; destinationSolarSystemId= 30003883; destinationStargateId= 50007146 } |> Some
      | 50007193 -> { StargateData.id= 50007193; name= "Stargate (RQOO-U)"; solarSystemId= 30002877; position= {x = 6.938628096e+10;  y = 1.250807808e+10;  z = -1.081403105e+12;}; typeId= 3875; destinationSolarSystemId= 30002880; destinationStargateId= 50007912 } |> Some
      | 50007290 -> { StargateData.id= 50007290; name= "Stargate (6E-578)"; solarSystemId= 30003273; position= {x = 1.43298859e+12;  y = 1.696428442e+11;  z = -1.292982804e+12;}; typeId= 3875; destinationSolarSystemId= 30003270; destinationStargateId= 50006435 } |> Some
      | 50007387 -> { StargateData.id= 50007387; name= "Stargate (I2D3-5)"; solarSystemId= 30002878; position= {x = 7.280365978e+11;  y = 7.166963712e+10;  z = 5.547824333e+11;}; typeId= 3875; destinationSolarSystemId= 30002877; destinationStargateId= 50007192 } |> Some
      | 50007484 -> { StargateData.id= 50007484; name= "Stargate (M-NWLB)"; solarSystemId= 30003203; position= {x = -5.828329021e+12;  y = -7.302868992e+10;  z = -3.691861647e+12;}; typeId= 3875; destinationSolarSystemId= 30003200; destinationStargateId= 50007034 } |> Some
      | 50007581 -> { StargateData.id= 50007581; name= "Stargate (Nidupad)"; solarSystemId= 30004122; position= {x = -2.059361772e+12;  y = 3.081721037e+11;  z = -2.337831936e+12;}; typeId= 29624; destinationSolarSystemId= 30004126; destinationStargateId= 50008967 } |> Some
      | 50007678 -> { StargateData.id= 50007678; name= "Stargate (Ervekam)"; solarSystemId= 30003872; position= {x = -3.376738591e+12;  y = 2.15275561e+11;  z = 3.124717117e+12;}; typeId= 29624; destinationSolarSystemId= 30003867; destinationStargateId= 50006858 } |> Some
      | 50007775 -> { StargateData.id= 50007775; name= "Stargate (Arzanni)"; solarSystemId= 30003903; position= {x = 9.669046272e+10;  y = 1.990123807e+12;  z = -7.036080538e+11;}; typeId= 17; destinationSolarSystemId= 30003885; destinationStargateId= 50007398 } |> Some
      | 50007872 -> { StargateData.id= 50007872; name= "Stargate (Vylade)"; solarSystemId= 30002659; position= {x = 1.22934571e+12;  y = -7.187410944e+10;  z = 1.301360517e+12;}; typeId= 3875; destinationSolarSystemId= 30002655; destinationStargateId= 50000403 } |> Some
      | 50007969 -> { StargateData.id= 50007969; name= "Stargate (Oyonata)"; solarSystemId= 30003086; position= {x = 2.662393037e+11;  y = -5.231038464e+10;  z = 6.690092237e+11;}; typeId= 29624; destinationSolarSystemId= 30003088; destinationStargateId= 50008208 } |> Some
      | 50008066 -> { StargateData.id= 50008066; name= "Stargate (S-B7IT)"; solarSystemId= 30004333; position= {x = 9.437927424e+11;  y = 9.394950144e+10;  z = 7.702499328e+10;}; typeId= 16; destinationSolarSystemId= 30004332; destinationStargateId= 50008036 } |> Some
      | 50008163 -> { StargateData.id= 50008163; name= "Stargate (OJ-A8M)"; solarSystemId= 30003608; position= {x = -3.266248335e+12;  y = 1.330931712e+11;  z = 1.258214154e+12;}; typeId= 29629; destinationSolarSystemId= 30004334; destinationStargateId= 50008077 } |> Some
      | 50008260 -> { StargateData.id= 50008260; name= "Stargate (TWJ-AW)"; solarSystemId= 30002613; position= {x = -1.916886589e+12;  y = -1.970519654e+11;  z = -8.324173824e+10;}; typeId= 29633; destinationSolarSystemId= 30002614; destinationStargateId= 50008513 } |> Some
      | 50008357 -> { StargateData.id= 50008357; name= "Stargate (Antem)"; solarSystemId= 30005262; position= {x = 9.246124032e+11;  y = 1.680623616e+11;  z = -4.914129715e+11;}; typeId= 29624; destinationSolarSystemId= 30005261; destinationStargateId= 50007711 } |> Some
      | 50008454 -> { StargateData.id= 50008454; name= "Stargate (C4C-Z4)"; solarSystemId= 30003689; position= {x = -2.540199322e+12;  y = 4.363044987e+12;  z = -2.154289152e+11;}; typeId= 3874; destinationSolarSystemId= 30003697; destinationStargateId= 50010092 } |> Some
      | 50008551 -> { StargateData.id= 50008551; name= "Stargate (Bherdasopt)"; solarSystemId= 30005235; position= {x = -1.939181691e+12;  y = -8.593835213e+11;  z = -2.011764449e+12;}; typeId= 17; destinationSolarSystemId= 30005267; destinationStargateId= 50008585 } |> Some
      | 50008648 -> { StargateData.id= 50008648; name= "Stargate (W-IX39)"; solarSystemId= 30003950; position= {x = -5.965186253e+11;  y = 4.479967519e+12;  z = -5.005014221e+11;}; typeId= 17; destinationSolarSystemId= 30003968; destinationStargateId= 50009050 } |> Some
      | 50008745 -> { StargateData.id= 50008745; name= "Stargate (Ardhis)"; solarSystemId= 30004120; position= {x = 5.4559488e+12;  y = 3.250432819e+11;  z = -1.986668667e+12;}; typeId= 29624; destinationSolarSystemId= 30004118; destinationStargateId= 50008264 } |> Some
      | 50008842 -> { StargateData.id= 50008842; name= "Stargate (F-G7BO)"; solarSystemId= 30000896; position= {x = -5.780967014e+11;  y = 3.840602112e+10;  z = -2.538086523e+12;}; typeId= 16; destinationSolarSystemId= 30000897; destinationStargateId= 50009988 } |> Some
      | 50008939 -> { StargateData.id= 50008939; name= "Stargate (10UZ-P)"; solarSystemId= 30003337; position= {x = -1.836086108e+12;  y = -3.65588521e+11;  z = 1.018375434e+13;}; typeId= 3875; destinationSolarSystemId= 30003336; destinationStargateId= 50008792 } |> Some
      | 50009036 -> { StargateData.id= 50009036; name= "Stargate (Egghelende)"; solarSystemId= 30002695; position= {x = 2.333937254e+11;  y = -2.60401152e+10;  z = -8.828571648e+10;}; typeId= 3875; destinationSolarSystemId= 30002693; destinationStargateId= 50008602 } |> Some
      | 50009133 -> { StargateData.id= 50009133; name= "Stargate (Antollare)"; solarSystemId= 30003049; position= {x = -5.750084813e+11;  y = 5.236764672e+10;  z = 1.108907213e+11;}; typeId= 3875; destinationSolarSystemId= 30003051; destinationStargateId= 50009896 } |> Some
      | 50009230 -> { StargateData.id= 50009230; name= "Stargate (PVF-N9)"; solarSystemId= 30005146; position= {x = -2.251393843e+11;  y = 3.491180544e+10;  z = 1.102768251e+12;}; typeId= 3875; destinationSolarSystemId= 30005147; destinationStargateId= 50009912 } |> Some
      | 50009327 -> { StargateData.id= 50009327; name= "Stargate (YF-P4X)"; solarSystemId= 30004839; position= {x = -4.831453716e+12;  y = 2.38473302e+12;  z = -1.090641961e+12;}; typeId= 3877; destinationSolarSystemId= 30004838; destinationStargateId= 50008888 } |> Some
      | 50009424 -> { StargateData.id= 50009424; name= "Stargate (XEF6-Z)"; solarSystemId= 30003226; position= {x = 9.511613645e+11;  y = 1.058007859e+11;  z = -5.833930752e+11;}; typeId= 3875; destinationSolarSystemId= 30003224; destinationStargateId= 50008846 } |> Some
      | 50009521 -> { StargateData.id= 50009521; name= "Stargate (Ibani)"; solarSystemId= 30003932; position= {x = -7.40665344e+10;  y = 1.13743872e+10;  z = -2.026745856e+10;}; typeId= 29624; destinationSolarSystemId= 30003933; destinationStargateId= 50009617 } |> Some
      | 50009618 -> { StargateData.id= 50009618; name= "Stargate (Irmalin)"; solarSystemId= 30003933; position= {x = -1.602521088e+11;  y = 2.777419776e+10;  z = -6.82762113e+12;}; typeId= 29624; destinationSolarSystemId= 30003935; destinationStargateId= 50009728 } |> Some
      | 50009715 -> { StargateData.id= 50009715; name= "Stargate (O5-YNW)"; solarSystemId= 30002886; position= {x = -3.263731261e+12;  y = 3.740844442e+11;  z = 6.078998569e+12;}; typeId= 3875; destinationSolarSystemId= 30002884; destinationStargateId= 50008913 } |> Some
      | 50009812 -> { StargateData.id= 50009812; name= "Stargate (91-KD8)"; solarSystemId= 30003251; position= {x = -1.916771328e+12;  y = 8.251650048e+10;  z = -2.33145471e+12;}; typeId= 3875; destinationSolarSystemId= 30003253; destinationStargateId= 50012230 } |> Some
      | 50009909 -> { StargateData.id= 50009909; name= "Stargate (1DH-SX)"; solarSystemId= 30004711; position= {x = -1.840504381e+12;  y = -1.754437632e+11;  z = 7.275127726e+12;}; typeId= 29624; destinationSolarSystemId= 30004710; destinationStargateId= 50009866 } |> Some
      | 50010006 -> { StargateData.id= 50010006; name= "Stargate (3HQC-6)"; solarSystemId= 30004515; position= {x = -7.823036006e+11;  y = 1.168086221e+11;  z = -3.100031754e+12;}; typeId= 3874; destinationSolarSystemId= 30004520; destinationStargateId= 50010159 } |> Some
      | 50010103 -> { StargateData.id= 50010103; name= "Stargate (YVSL-2)"; solarSystemId= 30004169; position= {x = 6.256603423e+12;  y = -2.807944397e+11;  z = 1.412052111e+13;}; typeId= 3875; destinationSolarSystemId= 30004174; destinationStargateId= 50010357 } |> Some
      | 50010200 -> { StargateData.id= 50010200; name= "Stargate (YKSC-A)"; solarSystemId= 30003691; position= {x = 8.100671078e+11;  y = -5.48702208e+10;  z = 9.925925683e+11;}; typeId= 3875; destinationSolarSystemId= 30003690; destinationStargateId= 50009843 } |> Some
      | 50010297 -> { StargateData.id= 50010297; name= "Stargate (Mod)"; solarSystemId= 30004138; position= {x = 4.844741837e+11;  y = -2.665230336e+10;  z = 6.95945257e+11;}; typeId= 29624; destinationSolarSystemId= 30004136; destinationStargateId= 50009235 } |> Some
      | 50010394 -> { StargateData.id= 50010394; name= "Stargate (BGN1-O)"; solarSystemId= 30004416; position= {x = 8.390296781e+11;  y = 9.256759296e+10;  z = -3.005835141e+12;}; typeId= 29633; destinationSolarSystemId= 30004417; destinationStargateId= 50011006 } |> Some
      | 50010491 -> { StargateData.id= 50010491; name= "Stargate (Arzi)"; solarSystemId= 30005067; position= {x = 2.538958971e+12;  y = 2.231821517e+11;  z = -2.288490947e+12;}; typeId= 29624; destinationSolarSystemId= 30005065; destinationStargateId= 50010164 } |> Some
      | 50010588 -> { StargateData.id= 50010588; name= "Stargate (RF-K9W)"; solarSystemId= 30004725; position= {x = 8.651038433e+12;  y = -8.267569152e+11;  z = 3.372964454e+12;}; typeId= 29624; destinationSolarSystemId= 30004724; destinationStargateId= 50010535 } |> Some
      | 50010685 -> { StargateData.id= 50010685; name= "Stargate (LS-JEP)"; solarSystemId= 30000317; position= {x = -6.534524928e+10;  y = 6306816000.0;  z = -2.258439782e+11;}; typeId= 16; destinationSolarSystemId= 30000319; destinationStargateId= 50011070 } |> Some
      | 50010782 -> { StargateData.id= 50010782; name= "Stargate (RLDS-R)"; solarSystemId= 30001904; position= {x = -1.475188285e+12;  y = -2.037211546e+11;  z = 5.415979008e+11;}; typeId= 29624; destinationSolarSystemId= 30001902; destinationStargateId= 50010551 } |> Some
      | 50010879 -> { StargateData.id= 50010879; name= "Stargate (IIRH-G)"; solarSystemId= 30003312; position= {x = 1.515879997e+12;  y = 2.045523149e+11;  z = -2.316601344e+11;}; typeId= 3875; destinationSolarSystemId= 30003311; destinationStargateId= 50009262 } |> Some
      | 50010976 -> { StargateData.id= 50010976; name= "Stargate (DP34-U)"; solarSystemId= 30003313; position= {x = 1.303964467e+11;  y = -9510297600.0;  z = -3.631031501e+11;}; typeId= 3875; destinationSolarSystemId= 30003314; destinationStargateId= 50011084 } |> Some
      | 50011073 -> { StargateData.id= 50011073; name= "Stargate (APM-6K)"; solarSystemId= 30004575; position= {x = 1952194560.0;  y = 104079360.0;  z = 2.099042918e+12;}; typeId= 3875; destinationSolarSystemId= 30004576; destinationStargateId= 50011146 } |> Some
      | 50011170 -> { StargateData.id= 50011170; name= "Stargate (Zatsyaki)"; solarSystemId= 30002279; position= {x = 4.432769434e+11;  y = -3.950678016e+10;  z = 3.327333581e+11;}; typeId= 29624; destinationSolarSystemId= 30002280; destinationStargateId= 50011227 } |> Some
      | 50011267 -> { StargateData.id= 50011267; name= "Stargate (Sharios)"; solarSystemId= 30001737; position= {x = 3.656245862e+12;  y = -3.922306253e+11;  z = -7.683325993e+12;}; typeId= 29624; destinationSolarSystemId= 30001739; destinationStargateId= 50012035 } |> Some
      | 50011364 -> { StargateData.id= 50011364; name= "Stargate (Frerstorn)"; solarSystemId= 30002093; position= {x = -3.145515418e+11;  y = 6.030569472e+10;  z = 3.611848704e+10;}; typeId= 29633; destinationSolarSystemId= 30002090; destinationStargateId= 50007987 } |> Some
      | 50011461 -> { StargateData.id= 50011461; name= "Stargate (K-6K16)"; solarSystemId= 30004752; position= {x = 3.304367432e+12;  y = 3.960664474e+11;  z = 3.625893765e+12;}; typeId= 29624; destinationSolarSystemId= 30004751; destinationStargateId= 50011210 } |> Some
      | 50011558 -> { StargateData.id= 50011558; name= "Stargate (VR-YRV)"; solarSystemId= 30003173; position= {x = -1.08128256e+10;  y = -2077040640.0;  z = 8.182001664e+10;}; typeId= 29624; destinationSolarSystemId= 30003175; destinationStargateId= 50012214 } |> Some
      | 50011655 -> { StargateData.id= 50011655; name= "Stargate (9R4-EJ)"; solarSystemId= 30004571; position= {x = 1.882672742e+11;  y = 2.573217792e+10;  z = 1.063763558e+11;}; typeId= 3875; destinationSolarSystemId= 30004569; destinationStargateId= 50011626 } |> Some
      | 50011752 -> { StargateData.id= 50011752; name= "Stargate (SVM-3K)"; solarSystemId= 30004756; position= {x = -3.290247168e+10;  y = -1022484480.0;  z = -3.777171456e+10;}; typeId= 29624; destinationSolarSystemId= 30004758; destinationStargateId= 50012049 } |> Some
      | 50011849 -> { StargateData.id= 50011849; name= "Stargate (DN58-U)"; solarSystemId= 30004192; position= {x = 2.302878474e+12;  y = -3.928533811e+11;  z = 1.417800868e+12;}; typeId= 3875; destinationSolarSystemId= 30004195; destinationStargateId= 50012380 } |> Some
      | 50011946 -> { StargateData.id= 50011946; name= "Stargate (DABV-N)"; solarSystemId= 30001913; position= {x = -8.851163136e+11;  y = -4.810493952e+10;  z = 1.194002473e+12;}; typeId= 29624; destinationSolarSystemId= 30001921; destinationStargateId= 50013500 } |> Some
      | 50012043 -> { StargateData.id= 50012043; name= "Stargate (Derririntel)"; solarSystemId= 30005026; position= {x = -1.631827108e+12;  y = -2.934829056e+10;  z = -4.137142641e+12;}; typeId= 3875; destinationSolarSystemId= 30005025; destinationStargateId= 50011720 } |> Some
      | 50012140 -> { StargateData.id= 50012140; name= "Stargate (Shaggoth)"; solarSystemId= 30004149; position= {x = -1.6026624e+10;  y = 384983040.0;  z = -3.856896e+10;}; typeId= 29624; destinationSolarSystemId= 30004150; destinationStargateId= 50012465 } |> Some
      | 50012237 -> { StargateData.id= 50012237; name= "Stargate (JE-VLG)"; solarSystemId= 30004193; position= {x = 1.765893366e+12;  y = -2.921827123e+11;  z = -1.780666737e+12;}; typeId= 3875; destinationSolarSystemId= 30004192; destinationStargateId= 50011848 } |> Some
      | 50012334 -> { StargateData.id= 50012334; name= "Stargate (E0DR-G)"; solarSystemId= 30004201; position= {x = 2.37268734e+12;  y = 1.852284518e+11;  z = 1.48915753e+12;}; typeId= 3874; destinationSolarSystemId= 30004208; destinationStargateId= 50012686 } |> Some
      | 50012431 -> { StargateData.id= 50012431; name= "Stargate (P5-KCC)"; solarSystemId= 30004075; position= {x = 6.374815703e+12;  y = 3.249180672e+10;  z = -1.996428534e+12;}; typeId= 3875; destinationSolarSystemId= 30004076; destinationStargateId= 50012584 } |> Some
      | 50012528 -> { StargateData.id= 50012528; name= "Stargate (ZXJ-71)"; solarSystemId= 30004032; position= {x = -9.433373368e+12;  y = 4.450578432e+10;  z = 3.599605309e+12;}; typeId= 29624; destinationSolarSystemId= 30004031; destinationStargateId= 50012172 } |> Some
      | 50012625 -> { StargateData.id= 50012625; name= "Stargate (XZ-SKZ)"; solarSystemId= 30004930; position= {x = 3.070912881e+12;  y = 6.164873626e+11;  z = -1.443760988e+12;}; typeId= 29624; destinationSolarSystemId= 30004932; destinationStargateId= 50012634 } |> Some
      | 50012722 -> { StargateData.id= 50012722; name= "Stargate (14YI-D)"; solarSystemId= 30004637; position= {x = -3.595371725e+11;  y = 1.134882816e+10;  z = 2.876791726e+12;}; typeId= 3875; destinationSolarSystemId= 30004639; destinationStargateId= 50012805 } |> Some
      | 50012819 -> { StargateData.id= 50012819; name= "Stargate (Ranni)"; solarSystemId= 30005084; position= {x = -1.69535361e+12;  y = -3.030331392e+10;  z = 4.808744509e+12;}; typeId= 29624; destinationSolarSystemId= 30005085; destinationStargateId= 50012967 } |> Some
      | 50012916 -> { StargateData.id= 50012916; name= "Stargate (Bapraya)"; solarSystemId= 30004293; position= {x = 8.595029606e+11;  y = 1.583273165e+11;  z = 3.032906097e+12;}; typeId= 29624; destinationSolarSystemId= 30004296; destinationStargateId= 50013038 } |> Some
      | 50013013 -> { StargateData.id= 50013013; name= "Stargate (E-DOF2)"; solarSystemId= 30004949; position= {x = 1.640112538e+11;  y = -1.191358464e+10;  z = 3.420002304e+11;}; typeId= 29624; destinationSolarSystemId= 30004948; destinationStargateId= 50012948 } |> Some
      | 50013110 -> { StargateData.id= 50013110; name= "Stargate (E-EFAM)"; solarSystemId= 30004216; position= {x = 2.049700209e+12;  y = 3.308781158e+11;  z = 3.809105879e+12;}; typeId= 3875; destinationSolarSystemId= 30004217; destinationStargateId= 50013376 } |> Some
      | 50013207 -> { StargateData.id= 50013207; name= "Stargate (7-UVMT)"; solarSystemId= 30003222; position= {x = 5.982572544e+10;  y = -717987840.0;  z = -3.837238886e+11;}; typeId= 3875; destinationSolarSystemId= 30003217; destinationStargateId= 50010873 } |> Some
      | 50013304 -> { StargateData.id= 50013304; name= "Stargate (MP5-KR)"; solarSystemId= 30004701; position= {x = -1.065860506e+12;  y = -1.125149491e+11;  z = 2.287419924e+12;}; typeId= 29624; destinationSolarSystemId= 30004702; destinationStargateId= 50013323 } |> Some
      | 50013401 -> { StargateData.id= 50013401; name= "Stargate (Uchoshi)"; solarSystemId= 30000206; position= {x = 3.082877952e+12;  y = 1.404217344e+11;  z = -4.072504934e+11;}; typeId= 16; destinationSolarSystemId= 30000201; destinationStargateId= 50011907 } |> Some
      | 50013498 -> { StargateData.id= 50013498; name= "Stargate (0T-LIB)"; solarSystemId= 30001958; position= {x = 1.847751107e+12;  y = 3.463283098e+11;  z = 2.229011128e+12;}; typeId= 29624; destinationSolarSystemId= 30001961; destinationStargateId= 50013529 } |> Some
      | 50013692 -> { StargateData.id= 50013692; name= "Stargate (Ihakana)"; solarSystemId= 30000194; position= {x = 1.992600576e+12;  y = 2.643522232e+12;  z = -2.21288706e+12;}; typeId= 29627; destinationSolarSystemId= 30000169; destinationStargateId= 50013691 } |> Some
      | 50013789 -> { StargateData.id= 50013789; name= "Stargate (D4-2XN)"; solarSystemId= 30003169; position= {x = 4.112672317e+12;  y = 1.07689218e+12;  z = 6.91135488e+11;}; typeId= 12292; destinationSolarSystemId= 30004491; destinationStargateId= 50013790 } |> Some
      | 50013886 -> { StargateData.id= 50013886; name= "Stargate (Danyana)"; solarSystemId= 30005042; position= {x = 1.905875313e+12;  y = 5.654186803e+11;  z = 1.069827564e+12;}; typeId= 17; destinationSolarSystemId= 30005044; destinationStargateId= 50013885 } |> Some
      | 50013983 -> { StargateData.id= 50013983; name= "Stargate (E-1XVP)"; solarSystemId= 30000463; position= {x = -9.659298202e+11;  y = -1.262247813e+12;  z = -7.432393114e+11;}; typeId= 3877; destinationSolarSystemId= 30000502; destinationStargateId= 50013984 } |> Some
      | 50014080 -> { StargateData.id= 50014080; name= "Stargate (Onga)"; solarSystemId= 30002529; position= {x = 4.887602381e+11;  y = 8.189300736e+10;  z = 4.053679841e+12;}; typeId= 3877; destinationSolarSystemId= 30002568; destinationStargateId= 50014079 } |> Some
      | 50014177 -> { StargateData.id= 50014177; name= "Stargate (Abrat)"; solarSystemId= 30003380; position= {x = 5.242933248e+10;  y = -2714542080.0;  z = 2.399963136e+11;}; typeId= 29633; destinationSolarSystemId= 30013410; destinationStargateId= 50014178 } |> Some
      | 50014274 -> { StargateData.id= 50014274; name= "Stargate (JNG7-K)"; solarSystemId= 30001532; position= {x = -1.504501555e+12;  y = -1.920327229e+12;  z = 1.908501258e+12;}; typeId= 3874; destinationSolarSystemId= 30001542; destinationStargateId= 50014273 } |> Some
      | 50016311 -> { StargateData.id= 50016311; name= "Stargate (Onnamon)"; solarSystemId= 30045325; position= {x = -1.963350835e+11;  y = -516710400.0;  z = 2.430477804e+12;}; typeId= 16; destinationSolarSystemId= 30045324; destinationStargateId= 50016312 } |> Some
      | _ -> None