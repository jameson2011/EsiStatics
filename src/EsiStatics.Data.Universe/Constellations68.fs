namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations68=
    let getConstellation id = 
      match id with 
      | 20000013 -> { ConstellationData.id= 20000013; name= "Aguh"; regionId= 10000001; solarSystemIds= [| 30000089; 30000090; 30000091; 30000092; 30000093; 30000094 |]; position= {x = -8.537691234e+16;  y = 7.462751145e+16;  z = -9.520390288e+16;} } |> Some
      | 20000110 -> { ConstellationData.id= 20000110; name= "E-95ID"; regionId= 10000009; solarSystemIds= [| 30000750; 30000751; 30000752; 30000753; 30000754; 30000755 |]; position= {x = 1.730730281e+17;  y = -1.311749777e+16;  z = -1.394285072e+17;} } |> Some
      | 20000207 -> { ConstellationData.id= 20000207; name= "Kainokai"; regionId= 10000016; solarSystemIds= [| 30001410; 30001411; 30001412; 30001414; 30001415 |]; position= {x = -1.590764556e+17;  y = 7.565032608e+16;  z = 1.294249196e+17;} } |> Some
      | 20000304 -> { ConstellationData.id= 20000304; name= "Aldodan"; regionId= 10000042; solarSystemIds= [| 30002060; 30002061; 30002062; 30002063; 30002064; 30002065; 30002066; 30002067 |]; position= {x = -1.074774583e+17;  y = -6.953093209e+15;  z = 4.036681486e+16;} } |> Some
      | 20000401 -> { ConstellationData.id= 20000401; name= "Imurukka"; regionId= 10000033; solarSystemIds= [| 30002738; 30002739; 30002740; 30002741; 30002742 |]; position= {x = -1.286970424e+17;  y = 9.81819818e+16;  z = 1.488765953e+17;} } |> Some
      | 20000498 -> { ConstellationData.id= 20000498; name= "Aptetter"; regionId= 10000042; solarSystemIds= [| 30003416; 30003417; 30003418; 30003419; 30003420; 30003421 |]; position= {x = -9.37051771e+16;  y = 6.938879881e+16;  z = 5.568269754e+16;} } |> Some
      | 20000595 -> { ConstellationData.id= 20000595; name= "Miennue"; regionId= 10000051; solarSystemIds= [| 30004071; 30004072; 30004073; 30004074; 30004075; 30004076 |]; position= {x = -3.211094883e+17;  y = 9.434014295e+16;  z = 1.751561436e+17;} } |> Some
      | 20000692 -> { ConstellationData.id= 20000692; name= "SPNZ-Z"; regionId= 10000060; solarSystemIds= [| 30004730; 30004731; 30004732; 30004733; 30004734; 30004735; 30004736 |]; position= {x = -4.412261658e+17;  y = 2.946863347e+16;  z = -2.195108093e+17;} } |> Some
      | 20000789 -> { ConstellationData.id= 20000789; name= "Krai Veles"; regionId= 10000070; solarSystemIds= [| 30000206; 30001381; 30002652; 30002702; 30002797; 30003046; 30005029; 30020141; 30045329 |]; position= {x = -1.639337539e+17;  y = 5.637768841e+16;  z = 7.132697112e+16;} } |> Some
      | 21000083 -> { ConstellationData.id= 21000083; name= "C-C00083"; regionId= 11000009; solarSystemIds= [| 31000924; 31000925; 31000926; 31000927; 31000928; 31000929 |]; position= {x = 7.765074068e+18;  y = 7.376672694e+15;  z = -9.818484322e+18;} } |> Some
      | 21000180 -> { ConstellationData.id= 21000180; name= "D-C00180"; regionId= 11000019; solarSystemIds= [| 31001553; 31001554; 31001555; 31001556; 31001557; 31001558; 31001559 |]; position= {x = 7.473045697e+18;  y = 2.671713016e+16;  z = -9.579326279e+18;} } |> Some
      | 21000277 -> { ConstellationData.id= 21000277; name= "E-C00277"; regionId= 11000028; solarSystemIds= [| 31002215; 31002216; 31002217; 31002218; 31002219; 31002220; 31002221; 31002222; 31002223 |]; position= {x = 8.092106411e+18;  y = 2.326616713e+16;  z = -9.855283673e+18;} } |> Some
      | _ -> None