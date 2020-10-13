﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stargates70=
    let getStargate id = 
      match id with 
      | 50000078 -> { StargateData.id= 50000078; name= "Stargate (S1-XTL)"; solarSystemId= 30000666; position= {x = -3.191821517e+11;  y = -1.952944128e+10;  z = 4.073941279e+12;}; typeId= 29633; destinationSolarSystemId= 30000667; destinationStargateId= 50000450 } |> Some
      | 50000175 -> { StargateData.id= 50000175; name= "Stargate (Q-NA5H)"; solarSystemId= 30000715; position= {x = -1.772418294e+12;  y = 3.58660055e+11;  z = 2.4407518e+12;}; typeId= 29633; destinationSolarSystemId= 30000717; destinationStargateId= 50000789 } |> Some
      | 50000272 -> { StargateData.id= 50000272; name= "Stargate (G9NE-B)"; solarSystemId= 30000565; position= {x = -3.260285706e+12;  y = -4.815125299e+11;  z = 2.512789955e+12;}; typeId= 29633; destinationSolarSystemId= 30000570; destinationStargateId= 50001859 } |> Some
      | 50000369 -> { StargateData.id= 50000369; name= "Stargate (GK5Z-T)"; solarSystemId= 30000790; position= {x = -9.01868544e+11;  y = -3.455889408e+10;  z = -4.483803955e+11;}; typeId= 29633; destinationSolarSystemId= 30000789; destinationStargateId= 50000246 } |> Some
      | 50000466 -> { StargateData.id= 50000466; name= "Stargate (GM-50Y)"; solarSystemId= 30000540; position= {x = -4.117665178e+12;  y = 7.125264384e+11;  z = -2.783469281e+12;}; typeId= 29633; destinationSolarSystemId= 30000544; destinationStargateId= 50001747 } |> Some
      | 50000563 -> { StargateData.id= 50000563; name= "Stargate (G-0Q86)"; solarSystemId= 30001038; position= {x = -5.659229184e+12;  y = 7.916326502e+11;  z = -1.83658156e+12;}; typeId= 29633; destinationSolarSystemId= 30001041; destinationStargateId= 50002095 } |> Some
      | 50000660 -> { StargateData.id= 50000660; name= "Stargate (Yeeramoun)"; solarSystemId= 30003490; position= {x = 6.871192781e+11;  y = 3.774380237e+12;  z = 5.083752653e+12;}; typeId= 17; destinationSolarSystemId= 30003514; destinationStargateId= 50001851 } |> Some
      | 50000757 -> { StargateData.id= 50000757; name= "Stargate (Oijamon)"; solarSystemId= 30002745; position= {x = 2.847593226e+12;  y = -4.599053107e+11;  z = 2.848054518e+12;}; typeId= 16; destinationSolarSystemId= 30002746; destinationStargateId= 50001129 } |> Some
      | 50000854 -> { StargateData.id= 50000854; name= "Stargate (Bairshir)"; solarSystemId= 30000039; position= {x = 8.796668314e+11;  y = -6.4766976e+10;  z = 2.993093468e+12;}; typeId= 29624; destinationSolarSystemId= 30000041; destinationStargateId= 50003107 } |> Some
      | 50001048 -> { StargateData.id= 50001048; name= "Stargate (Sendaya)"; solarSystemId= 30000046; position= {x = 2.84713513e+12;  y = 4.013541089e+12;  z = -4.920305664e+11;}; typeId= 17; destinationSolarSystemId= 30000015; destinationStargateId= 50001595 } |> Some
      | 50001145 -> { StargateData.id= 50001145; name= "Stargate (NFM-0V)"; solarSystemId= 30000229; position= {x = 1.839787622e+11;  y = 3.00423168e+10;  z = -4.553408102e+11;}; typeId= 16; destinationSolarSystemId= 30000230; destinationStargateId= 50001352 } |> Some
      | 50001242 -> { StargateData.id= 50001242; name= "Stargate (EKPB-3)"; solarSystemId= 30000739; position= {x = -2.583638016e+10;  y = -86384640.0;  z = 7.744794624e+10;}; typeId= 29633; destinationSolarSystemId= 30000740; destinationStargateId= 50001689 } |> Some
      | 50001339 -> { StargateData.id= 50001339; name= "Stargate (Z8-81T)"; solarSystemId= 30002120; position= {x = 1.330363392e+12;  y = -6.203731968e+10;  z = -4.02743255e+11;}; typeId= 29633; destinationSolarSystemId= 30002117; destinationStargateId= 50000066 } |> Some
      | 50001436 -> { StargateData.id= 50001436; name= "Stargate (O8W-5O)"; solarSystemId= 30003183; position= {x = 2.171697193e+12;  y = -1.204518506e+13;  z = -1.19239938e+12;}; typeId= 29632; destinationSolarSystemId= 30001068; destinationStargateId= 50001931 } |> Some
      | 50001533 -> { StargateData.id= 50001533; name= "Stargate (Abaim)"; solarSystemId= 30003508; position= {x = 3.995284316e+12;  y = 2.766433075e+11;  z = -8.341918925e+11;}; typeId= 29624; destinationSolarSystemId= 30003512; destinationStargateId= 50006796 } |> Some
      | 50001630 -> { StargateData.id= 50001630; name= "Stargate (Ardallabier)"; solarSystemId= 30002692; position= {x = -2.194527068e+12;  y = -1.071800771e+12;  z = -3.59319552e+10;}; typeId= 29632; destinationSolarSystemId= 30003030; destinationStargateId= 50001222 } |> Some
      | 50001727 -> { StargateData.id= 50001727; name= "Stargate (SD4A-2)"; solarSystemId= 30000695; position= {x = 6.908391014e+11;  y = -1.122981888e+11;  z = -2.178720031e+12;}; typeId= 29633; destinationSolarSystemId= 30000692; destinationStargateId= 50001037 } |> Some
      | 50001824 -> { StargateData.id= 50001824; name= "Stargate (Odatrik)"; solarSystemId= 30002510; position= {x = -2.553413345e+12;  y = 2.613786624e+11;  z = -2.99492266e+12;}; typeId= 29633; destinationSolarSystemId= 30002509; destinationStargateId= 50001326 } |> Some
      | 50001921 -> { StargateData.id= 50001921; name= "Stargate (DG-8VJ)"; solarSystemId= 30000442; position= {x = 1.13961726e+12;  y = 1.113495552e+11;  z = 2.334480753e+12;}; typeId= 29633; destinationSolarSystemId= 30000441; destinationStargateId= 50001509 } |> Some
      | 50002018 -> { StargateData.id= 50002018; name= "Stargate (N3-JBX)"; solarSystemId= 30000670; position= {x = -1.928610079e+12;  y = -1.682289869e+11;  z = -3.664423526e+12;}; typeId= 29633; destinationSolarSystemId= 30000669; destinationStargateId= 50001474 } |> Some
      | 50002115 -> { StargateData.id= 50002115; name= "Stargate (GPLB-C)"; solarSystemId= 30000557; position= {x = 3.456424305e+12;  y = 5.877531034e+11;  z = 2.839906591e+12;}; typeId= 29633; destinationSolarSystemId= 30000552; destinationStargateId= 50000077 } |> Some
      | 50002212 -> { StargateData.id= 50002212; name= "Stargate (Q-L07F)"; solarSystemId= 30000252; position= {x = -4.931146138e+11;  y = 2.370093588e+12;  z = 4.433645568e+10;}; typeId= 29627; destinationSolarSystemId= 30000256; destinationStargateId= 50001453 } |> Some
      | 50002406 -> { StargateData.id= 50002406; name= "Stargate (1-EVAX)"; solarSystemId= 30001055; position= {x = 5.264475218e+12;  y = -3.290138173e+12;  z = 7.177359483e+12;}; typeId= 3874; destinationSolarSystemId= 30001109; destinationStargateId= 50003197 } |> Some
      | 50002503 -> { StargateData.id= 50002503; name= "Stargate (Cleyd)"; solarSystemId= 30005195; position= {x = -2.423144817e+12;  y = -1.309513728e+11;  z = -1.610230579e+11;}; typeId= 29624; destinationSolarSystemId= 30005194; destinationStargateId= 50002375 } |> Some
      | 50002600 -> { StargateData.id= 50002600; name= "Stargate (PQRE-W)"; solarSystemId= 30000435; position= {x = -6.87400919e+11;  y = 1.819889664e+10;  z = -8.608813056e+10;}; typeId= 29633; destinationSolarSystemId= 30000438; destinationStargateId= 50005437 } |> Some
      | 50002697 -> { StargateData.id= 50002697; name= "Stargate (QE-E1D)"; solarSystemId= 30002139; position= {x = 1.565131284e+12;  y = -9.966784512e+10;  z = 1.937551565e+12;}; typeId= 29633; destinationSolarSystemId= 30002138; destinationStargateId= 50002532 } |> Some
      | 50002794 -> { StargateData.id= 50002794; name= "Stargate (LT-XI4)"; solarSystemId= 30000467; position= {x = -4.70406058e+12;  y = 1.787081933e+11;  z = -1.559726531e+12;}; typeId= 29633; destinationSolarSystemId= 30000466; destinationStargateId= 50002702 } |> Some
      | 50002891 -> { StargateData.id= 50002891; name= "Stargate (Rashy)"; solarSystemId= 30000024; position= {x = 2.068290355e+11;  y = -3.259232256e+10;  z = 6.276549427e+11;}; typeId= 29624; destinationSolarSystemId= 30000025; destinationStargateId= 50003794 } |> Some
      | 50002988 -> { StargateData.id= 50002988; name= "Stargate (Pimebeka)"; solarSystemId= 30001670; position= {x = 9.739030118e+11;  y = -1.929327821e+11;  z = 1.453497139e+11;}; typeId= 29624; destinationSolarSystemId= 30001669; destinationStargateId= 50002618 } |> Some
      | 50003085 -> { StargateData.id= 50003085; name= "Stargate (Kaaputenen)"; solarSystemId= 30002788; position= {x = -1.674740736e+12;  y = -3.179776819e+11;  z = -2.21244076e+12;}; typeId= 16; destinationSolarSystemId= 30002789; destinationStargateId= 50003584 } |> Some
      | 50003182 -> { StargateData.id= 50003182; name= "Stargate (Balle)"; solarSystemId= 30002633; position= {x = 4.644430234e+11;  y = 2.166755328e+10;  z = 1.327292006e+11;}; typeId= 3875; destinationSolarSystemId= 30002634; destinationStargateId= 50004135 } |> Some
      | 50003279 -> { StargateData.id= 50003279; name= "Stargate (YM-SRU)"; solarSystemId= 30001117; position= {x = 2.843466424e+12;  y = -4.753532928e+11;  z = -1.058077778e+12;}; typeId= 3875; destinationSolarSystemId= 30001118; destinationStargateId= 50008026 } |> Some
      | 50003376 -> { StargateData.id= 50003376; name= "Stargate (Bagodan)"; solarSystemId= 30003523; position= {x = -1.825462272e+11;  y = -5485240320.0;  z = -1.427564913e+12;}; typeId= 29624; destinationSolarSystemId= 30003525; destinationStargateId= 50003591 } |> Some
      | 50003473 -> { StargateData.id= 50003473; name= "Stargate (0FG-KS)"; solarSystemId= 30005101; position= {x = 6.159587328e+11;  y = 9.404289024e+10;  z = 2.195063562e+12;}; typeId= 3875; destinationSolarSystemId= 30005102; destinationStargateId= 50004511 } |> Some
      | 50003570 -> { StargateData.id= 50003570; name= "Stargate (Mimen)"; solarSystemId= 30001675; position= {x = 8.895178752e+11;  y = -4.056969216e+10;  z = -3.232996762e+12;}; typeId= 29624; destinationSolarSystemId= 30001676; destinationStargateId= 50003882 } |> Some
      | 50003667 -> { StargateData.id= 50003667; name= "Stargate (4-P4FE)"; solarSystemId= 30004812; position= {x = 4.651449139e+11;  y = -2.971717632e+10;  z = 1.67347925e+12;}; typeId= 29633; destinationSolarSystemId= 30004811; destinationStargateId= 50003615 } |> Some
      | 50003764 -> { StargateData.id= 50003764; name= "Stargate (Arnatele)"; solarSystemId= 30003011; position= {x = -5.923815014e+11;  y = -8.45826048e+10;  z = -4.643646259e+11;}; typeId= 3875; destinationSolarSystemId= 30003009; destinationStargateId= 50000017 } |> Some
      | 50003861 -> { StargateData.id= 50003861; name= "Stargate (HG-YEQ)"; solarSystemId= 30001132; position= {x = 1.041838694e+12;  y = 5.04674304e+10;  z = 3.454513152e+10;}; typeId= 3875; destinationSolarSystemId= 30001135; destinationStargateId= 50005160 } |> Some
      | 50003958 -> { StargateData.id= 50003958; name= "Stargate (Halaima)"; solarSystemId= 30002782; position= {x = -5.320105574e+11;  y = -7.335161856e+10;  z = 2.350501847e+12;}; typeId= 16; destinationSolarSystemId= 30002781; destinationStargateId= 50003005 } |> Some
      | 50004055 -> { StargateData.id= 50004055; name= "Stargate (N-SFZK)"; solarSystemId= 30002339; position= {x = 2.163779789e+12;  y = -4.269968179e+11;  z = -2.024731238e+12;}; typeId= 3875; destinationSolarSystemId= 30002341; destinationStargateId= 50004328 } |> Some
      | 50004152 -> { StargateData.id= 50004152; name= "Stargate (Alentene)"; solarSystemId= 30005302; position= {x = 8.839778304e+10;  y = 5384478720.0;  z = 4.337645568e+11;}; typeId= 3875; destinationSolarSystemId= 30005304; destinationStargateId= 50004279 } |> Some
      | 50004249 -> { StargateData.id= 50004249; name= "Stargate (Uusanen)"; solarSystemId= 30003072; position= {x = -1.001025823e+12;  y = -1.999477555e+11;  z = 3.071178056e+12;}; typeId= 29624; destinationSolarSystemId= 30003077; destinationStargateId= 50006365 } |> Some
      | 50004346 -> { StargateData.id= 50004346; name= "Stargate (P-GKF5)"; solarSystemId= 30001294; position= {x = 2.746360996e+12;  y = -3.36835584e+11;  z = -3.4583373e+12;}; typeId= 16; destinationSolarSystemId= 30001293; destinationStargateId= 50004314 } |> Some
      | 50004443 -> { StargateData.id= 50004443; name= "Stargate (Egbonbet)"; solarSystemId= 30003400; position= {x = -2.083375104e+11;  y = 1.276710912e+10;  z = -2.839744512e+10;}; typeId= 29633; destinationSolarSystemId= 30003401; destinationStargateId= 50005246 } |> Some
      | 50004637 -> { StargateData.id= 50004637; name= "Stargate (HPMN-V)"; solarSystemId= 30001584; position= {x = -1.860640727e+12;  y = -2.29521408e+10;  z = 1.457698038e+12;}; typeId= 3875; destinationSolarSystemId= 30001583; destinationStargateId= 50004563 } |> Some
      | 50004734 -> { StargateData.id= 50004734; name= "Stargate (Siyi)"; solarSystemId= 30001695; position= {x = -9.435373609e+12;  y = -2.896587571e+11;  z = -4.836973486e+12;}; typeId= 29624; destinationSolarSystemId= 30001699; destinationStargateId= 50012759 } |> Some
      | 50004831 -> { StargateData.id= 50004831; name= "Stargate (Akila)"; solarSystemId= 30003480; position= {x = 5.059345736e+12;  y = 1.615221965e+11;  z = 6.332537119e+12;}; typeId= 29624; destinationSolarSystemId= 30003479; destinationStargateId= 50004050 } |> Some
      | 50004928 -> { StargateData.id= 50004928; name= "Stargate (9SNK-O)"; solarSystemId= 30000967; position= {x = -8.575444992e+11;  y = -4257914880.0;  z = 2.204452086e+12;}; typeId= 29633; destinationSolarSystemId= 30000969; destinationStargateId= 50005647 } |> Some
      | 50005025 -> { StargateData.id= 50005025; name= "Stargate (Kuoka)"; solarSystemId= 30001371; position= {x = -3.104660644e+12;  y = 2.32663806e+12;  z = -1.228768666e+12;}; typeId= 29627; destinationSolarSystemId= 30001415; destinationStargateId= 50012452 } |> Some
      | 50005122 -> { StargateData.id= 50005122; name= "Stargate (Q-CAB2)"; solarSystemId= 30000871; position= {x = 3.500567962e+12;  y = -3.701817754e+11;  z = 4.43935273e+12;}; typeId= 16; destinationSolarSystemId= 30000872; destinationStargateId= 50005281 } |> Some
      | 50005219 -> { StargateData.id= 50005219; name= "Stargate (Averon)"; solarSystemId= 30003045; position= {x = -6.108972687e+12;  y = -1.482359194e+11;  z = -5.146766991e+12;}; typeId= 3875; destinationSolarSystemId= 30003047; destinationStargateId= 50006996 } |> Some
      | 50005316 -> { StargateData.id= 50005316; name= "Stargate (Nifshed)"; solarSystemId= 30002228; position= {x = -5.019398554e+11;  y = -7.579250688e+10;  z = -7.79798569e+11;}; typeId= 29624; destinationSolarSystemId= 30002234; destinationStargateId= 50005813 } |> Some
      | 50005413 -> { StargateData.id= 50005413; name= "Stargate (Eitu)"; solarSystemId= 30002741; position= {x = 1.150336819e+12;  y = 1.263630336e+11;  z = -1.437876019e+12;}; typeId= 16; destinationSolarSystemId= 30002740; destinationStargateId= 50002429 } |> Some
      | 50005510 -> { StargateData.id= 50005510; name= "Stargate (Nakatre)"; solarSystemId= 30002993; position= {x = 3.21195135e+12;  y = 1.78541568e+11;  z = -2.882410045e+12;}; typeId= 29624; destinationSolarSystemId= 30002988; destinationStargateId= 50004469 } |> Some
      | 50005607 -> { StargateData.id= 50005607; name= "Stargate (YN3-E3)"; solarSystemId= 30002433; position= {x = 1.154745999e+12;  y = 1.758121574e+11;  z = 7.560058061e+11;}; typeId= 16; destinationSolarSystemId= 30002432; destinationStargateId= 50004977 } |> Some
      | 50005704 -> { StargateData.id= 50005704; name= "Stargate (U93O-A)"; solarSystemId= 30000646; position= {x = -1.371901747e+12;  y = -2.321595187e+11;  z = -1.540069417e+12;}; typeId= 29633; destinationSolarSystemId= 30000644; destinationStargateId= 50005305 } |> Some
      | 50005801 -> { StargateData.id= 50005801; name= "Stargate (Sobenah)"; solarSystemId= 30002238; position= {x = -2.564532756e+12;  y = 1.91517696e+11;  z = -1.10578815e+12;}; typeId= 29624; destinationSolarSystemId= 30002237; destinationStargateId= 50005445 } |> Some
      | 50005898 -> { StargateData.id= 50005898; name= "Stargate (IL-H0A)"; solarSystemId= 30002370; position= {x = -2.284370289e+12;  y = -3.600427008e+11;  z = -1.444869366e+12;}; typeId= 3875; destinationSolarSystemId= 30002372; destinationStargateId= 50007021 } |> Some
      | 50005995 -> { StargateData.id= 50005995; name= "Stargate (68FT-6)"; solarSystemId= 30002589; position= {x = 4.233711329e+12;  y = 3.534968832e+11;  z = -7.308254454e+12;}; typeId= 29633; destinationSolarSystemId= 30002593; destinationStargateId= 50006253 } |> Some
      | 50006092 -> { StargateData.id= 50006092; name= "Stargate (Jerma)"; solarSystemId= 30002251; position= {x = 2.578303795e+11;  y = 3.766530048e+10;  z = -6.054515098e+11;}; typeId= 29624; destinationSolarSystemId= 30002254; destinationStargateId= 50008183 } |> Some
      | 50006189 -> { StargateData.id= 50006189; name= "Stargate (Osmon)"; solarSystemId= 30000181; position= {x = -5.594925343e+12;  y = 8.773650432e+11;  z = -1.062378148e+13;}; typeId= 16; destinationSolarSystemId= 30000180; destinationStargateId= 50006098 } |> Some
      | 50006286 -> { StargateData.id= 50006286; name= "Stargate (KOI8-Z)"; solarSystemId= 30005123; position= {x = 8.787103334e+11;  y = 6.801051648e+10;  z = 8.492038963e+11;}; typeId= 3875; destinationSolarSystemId= 30005124; destinationStargateId= 50006359 } |> Some
      | 50006383 -> { StargateData.id= 50006383; name= "Stargate (UC3H-Y)"; solarSystemId= 30002023; position= {x = -1.062605414e+12;  y = 4.467781632e+10;  z = -1.220771144e+12;}; typeId= 16; destinationSolarSystemId= 30002024; destinationStargateId= 50006974 } |> Some
      | 50006480 -> { StargateData.id= 50006480; name= "Stargate (Z-DRIY)"; solarSystemId= 30005129; position= {x = -2.202145874e+12;  y = 3.04803582e+12;  z = -4.223720448e+12;}; typeId= 29632; destinationSolarSystemId= 30002292; destinationStargateId= 50001635 } |> Some
      | 50006577 -> { StargateData.id= 50006577; name= "Stargate (H-93YV)"; solarSystemId= 30000521; position= {x = -4.301297664e+11;  y = -4.228018176e+10;  z = 2.696740454e+11;}; typeId= 29633; destinationSolarSystemId= 30000523; destinationStargateId= 50007142 } |> Some
      | 50006674 -> { StargateData.id= 50006674; name= "Stargate (Tzvi)"; solarSystemId= 30002961; position= {x = -4.071665664e+10;  y = -7826350080.0;  z = -5.369908838e+11;}; typeId= 29624; destinationSolarSystemId= 30002957; destinationStargateId= 50000215 } |> Some
      | 50006771 -> { StargateData.id= 50006771; name= "Stargate (Osmallanais)"; solarSystemId= 30003813; position= {x = 3.439344968e+12;  y = -6.860716032e+11;  z = 3.050579681e+12;}; typeId= 3875; destinationSolarSystemId= 30003812; destinationStargateId= 50006749 } |> Some
      | 50006868 -> { StargateData.id= 50006868; name= "Stargate (9-ZFCG)"; solarSystemId= 30004407; position= {x = 3.428272005e+12;  y = -1.445045453e+11;  z = 9.082383974e+11;}; typeId= 29633; destinationSolarSystemId= 30004409; destinationStargateId= 50007072 } |> Some
      | 50006965 -> { StargateData.id= 50006965; name= "Stargate (WRL4-2)"; solarSystemId= 30000603; position= {x = -2.949238088e+12;  y = 4.260277862e+11;  z = 3.495959962e+12;}; typeId= 29633; destinationSolarSystemId= 30000602; destinationStargateId= 50004764 } |> Some
      | 50007062 -> { StargateData.id= 50007062; name= "Stargate (2H-TSE)"; solarSystemId= 30002454; position= {x = 1.752330363e+12;  y = 1.313219789e+11;  z = -4.178149663e+12;}; typeId= 16; destinationSolarSystemId= 30002455; destinationStargateId= 50011110 } |> Some
      | 50007159 -> { StargateData.id= 50007159; name= "Stargate (TU-RI6)"; solarSystemId= 30003746; position= {x = 1.452074189e+11;  y = -5751889920.0;  z = -6.267949056e+10;}; typeId= 29624; destinationSolarSystemId= 30003742; destinationStargateId= 50005344 } |> Some
      | 50007256 -> { StargateData.id= 50007256; name= "Stargate (Hadonoo)"; solarSystemId= 30002263; position= {x = 1.896155136e+11;  y = 3.007524864e+10;  z = 2.584987853e+12;}; typeId= 29624; destinationSolarSystemId= 30002264; destinationStargateId= 50009677 } |> Some
      | 50007353 -> { StargateData.id= 50007353; name= "Stargate (Palas)"; solarSystemId= 30003879; position= {x = 1.016270316e+12;  y = 1.554123571e+11;  z = 3.936462643e+12;}; typeId= 29624; destinationSolarSystemId= 30003878; destinationStargateId= 50007240 } |> Some
      | 50007450 -> { StargateData.id= 50007450; name= "Stargate (Naka)"; solarSystemId= 30005255; position= {x = -6.658595635e+11;  y = 4.992775373e+11;  z = -4.107926692e+12;}; typeId= 17; destinationSolarSystemId= 30005242; destinationStargateId= 50007376 } |> Some
      | 50007547 -> { StargateData.id= 50007547; name= "Stargate (Pashanai)"; solarSystemId= 30005233; position= {x = 2.065829683e+12;  y = 2.316645581e+11;  z = -1.445695488e+10;}; typeId= 29624; destinationSolarSystemId= 30005231; destinationStargateId= 50007151 } |> Some
      | 50007644 -> { StargateData.id= 50007644; name= "Stargate (Nare)"; solarSystemId= 30005053; position= {x = 8.463828787e+12;  y = -1.536976527e+12;  z = -2.439730422e+12;}; typeId= 29624; destinationSolarSystemId= 30005054; destinationStargateId= 50007675 } |> Some
      | 50007741 -> { StargateData.id= 50007741; name= "Stargate (RWML-A)"; solarSystemId= 30001144; position= {x = 3.110419538e+12;  y = -4.171049779e+11;  z = 2.12209791e+12;}; typeId= 3875; destinationSolarSystemId= 30001142; destinationStargateId= 50007510 } |> Some
      | 50007838 -> { StargateData.id= 50007838; name= "Stargate (Foves)"; solarSystemId= 30002667; position= {x = -1.544472945e+12;  y = -5.027745792e+10;  z = -1.836104294e+12;}; typeId= 3875; destinationSolarSystemId= 30002663; destinationStargateId= 50000707 } |> Some
      | 50007935 -> { StargateData.id= 50007935; name= "Stargate (Mirilene)"; solarSystemId= 30002731; position= {x = 4.357188772e+12;  y = 7.151966208e+11;  z = -2.894278533e+12;}; typeId= 3875; destinationSolarSystemId= 30002732; destinationStargateId= 50008439 } |> Some
      | 50008032 -> { StargateData.id= 50008032; name= "Stargate (Ham)"; solarSystemId= 30003899; position= {x = -4.914239939e+12;  y = 1.150937088e+11;  z = 3.945958072e+12;}; typeId= 29624; destinationSolarSystemId= 30003900; destinationStargateId= 50008062 } |> Some
      | 50008129 -> { StargateData.id= 50008129; name= "Stargate (FD-MLJ)"; solarSystemId= 30003278; position= {x = 2.27662295e+12;  y = 3.551235686e+11;  z = -2.03168428e+12;}; typeId= 3875; destinationSolarSystemId= 30003276; destinationStargateId= 50007814 } |> Some
      | 50008226 -> { StargateData.id= 50008226; name= "Stargate (BR-6XP)"; solarSystemId= 30000313; position= {x = -1.52621396e+12;  y = -1.114891469e+11;  z = 1.39646423e+12;}; typeId= 16; destinationSolarSystemId= 30000311; destinationStargateId= 50007587 } |> Some
      | 50008323 -> { StargateData.id= 50008323; name= "Stargate (Odixie)"; solarSystemId= 30003048; position= {x = -4.322625823e+12;  y = -4.415082086e+11;  z = -1.645636116e+12;}; typeId= 3875; destinationSolarSystemId= 30003050; destinationStargateId= 50009737 } |> Some
      | 50008420 -> { StargateData.id= 50008420; name= "Stargate (Arnstur)"; solarSystemId= 30002063; position= {x = 2.603193754e+12;  y = -3.062431334e+11;  z = 2.491096228e+12;}; typeId= 29633; destinationSolarSystemId= 30002064; destinationStargateId= 50008718 } |> Some
      | 50008517 -> { StargateData.id= 50008517; name= "Stargate (Espigoure)"; solarSystemId= 30003820; position= {x = 3.034597908e+12;  y = 3.850202726e+11;  z = 9.827820749e+11;}; typeId= 3875; destinationSolarSystemId= 30003822; destinationStargateId= 50009827 } |> Some
      | 50008614 -> { StargateData.id= 50008614; name= "Stargate (Uriok)"; solarSystemId= 30002075; position= {x = -3.32489601e+12;  y = 3.780195533e+11;  z = -3.098784154e+11;}; typeId= 29633; destinationSolarSystemId= 30002070; destinationStargateId= 50006973 } |> Some
      | 50008711 -> { StargateData.id= 50008711; name= "Stargate (Stegette)"; solarSystemId= 30002694; position= {x = 8.14688256e+10;  y = 2301419520.0;  z = -3.54752471e+11;}; typeId= 3875; destinationSolarSystemId= 30002696; destinationStargateId= 50009501 } |> Some
      | 50008808 -> { StargateData.id= 50008808; name= "Stargate (UO9-YG)"; solarSystemId= 30004496; position= {x = -2.876240486e+12;  y = -2.824277606e+11;  z = 1.902902845e+12;}; typeId= 3875; destinationSolarSystemId= 30004495; destinationStargateId= 50008765 } |> Some
      | 50008905 -> { StargateData.id= 50008905; name= "Stargate (Iosantin)"; solarSystemId= 30000065; position= {x = -4.277599027e+11;  y = 1.665626112e+10;  z = 2.611183165e+12;}; typeId= 29624; destinationSolarSystemId= 30000062; destinationStargateId= 50007888 } |> Some
      | 50009002 -> { StargateData.id= 50009002; name= "Stargate (DOA-YU)"; solarSystemId= 30001131; position= {x = 5.063532134e+11;  y = 7.101198336e+10;  z = -3.761837261e+11;}; typeId= 3875; destinationSolarSystemId= 30001130; destinationStargateId= 50007432 } |> Some
      | 50009099 -> { StargateData.id= 50009099; name= "Stargate (9MWZ-B)"; solarSystemId= 30004886; position= {x = -1.860787446e+12;  y = -1.35688151e+11;  z = -6.034163712e+11;}; typeId= 29633; destinationSolarSystemId= 30004884; destinationStargateId= 50008722 } |> Some
      | 50009196 -> { StargateData.id= 50009196; name= "Stargate (Yooh)"; solarSystemId= 30004132; position= {x = 1.699232563e+11;  y = 2.306789376e+10;  z = 2.364472934e+11;}; typeId= 29624; destinationSolarSystemId= 30004131; destinationStargateId= 50009012 } |> Some
      | 50009293 -> { StargateData.id= 50009293; name= "Stargate (9CG6-H)"; solarSystemId= 30003981; position= {x = -1.023270789e+12;  y = -4.359696384e+10;  z = 1.236638884e+12;}; typeId= 29624; destinationSolarSystemId= 30003979; destinationStargateId= 50009104 } |> Some
      | 50009390 -> { StargateData.id= 50009390; name= "Stargate (Z-XX2J)"; solarSystemId= 30003985; position= {x = 5.476306944e+10;  y = 7505633280.0;  z = 2.914567373e+11;}; typeId= 29624; destinationSolarSystemId= 30003989; destinationStargateId= 50011222 } |> Some
      | 50009487 -> { StargateData.id= 50009487; name= "Stargate (I-7RIS)"; solarSystemId= 30004359; position= {x = -3.088123945e+12;  y = 6.217367962e+11;  z = -1.339618714e+12;}; typeId= 16; destinationSolarSystemId= 30004361; destinationStargateId= 50009687 } |> Some
      | 50009584 -> { StargateData.id= 50009584; name= "Stargate (Isenairos)"; solarSystemId= 30002816; position= {x = 3.45438167e+11;  y = -6.6235392e+10;  z = -2.373482496e+11;}; typeId= 16; destinationSolarSystemId= 30002815; destinationStargateId= 50008783 } |> Some
      | 50009681 -> { StargateData.id= 50009681; name= "Stargate (BX2-ZX)"; solarSystemId= 30003991; position= {x = 6.440665498e+11;  y = 2.370809856e+10;  z = -7.319171482e+11;}; typeId= 29624; destinationSolarSystemId= 30003993; destinationStargateId= 50009969 } |> Some
      | 50009778 -> { StargateData.id= 50009778; name= "Stargate (Barmalie)"; solarSystemId= 30002679; position= {x = 9.563713536e+10;  y = 3527024640.0;  z = 9.443315712e+10;}; typeId= 3875; destinationSolarSystemId= 30002683; destinationStargateId= 50013332 } |> Some
      | 50009875 -> { StargateData.id= 50009875; name= "Stargate (2-F3OE)"; solarSystemId= 30004452; position= {x = 3.472359383e+12;  y = 4.90309632e+10;  z = 4.56689664e+10;}; typeId= 29633; destinationSolarSystemId= 30004454; destinationStargateId= 50009992 } |> Some
      | 50009972 -> { StargateData.id= 50009972; name= "Stargate (PFU-LH)"; solarSystemId= 30002008; position= {x = 3.297635942e+11;  y = -1.53163776e+10;  z = -1.056656179e+11;}; typeId= 16; destinationSolarSystemId= 30002009; destinationStargateId= 50012246 } |> Some
      | 50010069 -> { StargateData.id= 50010069; name= "Stargate (Aldali)"; solarSystemId= 30002215; position= {x = -1.285765079e+12;  y = 1.775322317e+11;  z = -8.549372314e+11;}; typeId= 29624; destinationSolarSystemId= 30002216; destinationStargateId= 50010893 } |> Some
      | 50010166 -> { StargateData.id= 50010166; name= "Stargate (5WAE-M)"; solarSystemId= 30004510; position= {x = -2.470272492e+12;  y = 6.16593408e+10;  z = -4.325006008e+12;}; typeId= 3875; destinationSolarSystemId= 30004508; destinationStargateId= 50009699 } |> Some
      | 50010263 -> { StargateData.id= 50010263; name= "Stargate (G-YZUX)"; solarSystemId= 30003137; position= {x = -2.631675372e+12;  y = -1.256616346e+11;  z = -1.270565683e+11;}; typeId= 29624; destinationSolarSystemId= 30003133; destinationStargateId= 50009632 } |> Some
      | 50010360 -> { StargateData.id= 50010360; name= "Stargate (C-4ZOS)"; solarSystemId= 30004356; position= {x = -5.583407309e+12;  y = -1.927530701e+12;  z = 1.993861939e+11;}; typeId= 29627; destinationSolarSystemId= 30004378; destinationStargateId= 50010444 } |> Some
      | 50010457 -> { StargateData.id= 50010457; name= "Stargate (33-JRO)"; solarSystemId= 30004670; position= {x = 8.11250946e+12;  y = 1.526391153e+12;  z = -6.27666985e+11;}; typeId= 29624; destinationSolarSystemId= 30004668; destinationStargateId= 50010382 } |> Some
      | 50010554 -> { StargateData.id= 50010554; name= "Stargate (R-OCBA)"; solarSystemId= 30004523; position= {x = 5.013966152e+12;  y = 9.94512937e+11;  z = -3.970167644e+12;}; typeId= 3875; destinationSolarSystemId= 30004522; destinationStargateId= 50010504 } |> Some
      | 50010651 -> { StargateData.id= 50010651; name= "Stargate (YRV-MZ)"; solarSystemId= 30003177; position= {x = 1.057185423e+12;  y = 4.644360192e+10;  z = 1.167716352e+10;}; typeId= 29624; destinationSolarSystemId= 30003178; destinationStargateId= 50010909 } |> Some
      | 50010748 -> { StargateData.id= 50010748; name= "Stargate (Iosantin)"; solarSystemId= 30000067; position= {x = 2.017356227e+12;  y = 1.280595149e+11;  z = 5.359493161e+12;}; typeId= 29624; destinationSolarSystemId= 30000062; destinationStargateId= 50007889 } |> Some
      | 50010845 -> { StargateData.id= 50010845; name= "Stargate (Earwik)"; solarSystemId= 30003443; position= {x = 5.774953267e+11;  y = 7847731200.0;  z = 1.219504128e+11;}; typeId= 29633; destinationSolarSystemId= 30003441; destinationStargateId= 50008832 } |> Some
      | 50010942 -> { StargateData.id= 50010942; name= "Stargate (Fihrneh)"; solarSystemId= 30004239; position= {x = -1.554535096e+12;  y = 5.651087401e+12;  z = 2.558317978e+12;}; typeId= 17; destinationSolarSystemId= 30004254; destinationStargateId= 50011261 } |> Some
      | 50011039 -> { StargateData.id= 50011039; name= "Stargate (6-4V20)"; solarSystemId= 30004055; position= {x = -5.796421755e+12;  y = -4.41984e+11;  z = 3.020809421e+11;}; typeId= 3875; destinationSolarSystemId= 30004053; destinationStargateId= 50011004 } |> Some
      | 50011136 -> { StargateData.id= 50011136; name= "Stargate (6SB-BN)"; solarSystemId= 30003181; position= {x = -1.585974682e+12;  y = -1.898632397e+11;  z = 1.065715261e+12;}; typeId= 29624; destinationSolarSystemId= 30003179; destinationStargateId= 50010999 } |> Some
      | 50011233 -> { StargateData.id= 50011233; name= "Stargate (SN-Q1T)"; solarSystemId= 30001806; position= {x = -1.022188339e+11;  y = -2868142080.0;  z = -1.593438904e+12;}; typeId= 3875; destinationSolarSystemId= 30001808; destinationStargateId= 50011620 } |> Some
      | 50011330 -> { StargateData.id= 50011330; name= "Stargate (Ofage)"; solarSystemId= 30003444; position= {x = -1.941003878e+11;  y = 1.517457408e+10;  z = 6.919912243e+11;}; typeId= 29633; destinationSolarSystemId= 30003446; destinationStargateId= 50011806 } |> Some
      | 50011427 -> { StargateData.id= 50011427; name= "Stargate (XPUM-L)"; solarSystemId= 30004895; position= {x = 7.602970214e+11;  y = -3.775500288e+10;  z = 2.224557466e+12;}; typeId= 29633; destinationSolarSystemId= 30004894; destinationStargateId= 50011400 } |> Some
      | 50011524 -> { StargateData.id= 50011524; name= "Stargate (A-3ES3)"; solarSystemId= 30003317; position= {x = -1.324693709e+12;  y = -4.783362048e+10;  z = 6.970565837e+11;}; typeId= 3875; destinationSolarSystemId= 30003319; destinationStargateId= 50011893 } |> Some
      | 50011621 -> { StargateData.id= 50011621; name= "Stargate (ZZK-VF)"; solarSystemId= 30001808; position= {x = 4.861745971e+11;  y = -1.64825088e+10;  z = -4.877443277e+12;}; typeId= 3875; destinationSolarSystemId= 30001807; destinationStargateId= 50011291 } |> Some
      | 50011718 -> { StargateData.id= 50011718; name= "Stargate (Tierijev)"; solarSystemId= 30005025; position= {x = -5.962735411e+12;  y = 2.457172992e+12;  z = 1.247154954e+12;}; typeId= 29632; destinationSolarSystemId= 30005334; destinationStargateId= 50008471 } |> Some
      | 50011815 -> { StargateData.id= 50011815; name= "Stargate (RIT-A7)"; solarSystemId= 30004471; position= {x = 5.779536691e+11;  y = -5.72848128e+10;  z = -1.362157117e+12;}; typeId= 29633; destinationSolarSystemId= 30004472; destinationStargateId= 50012056 } |> Some
      | 50011912 -> { StargateData.id= 50011912; name= "Stargate (Efa)"; solarSystemId= 30003894; position= {x = -2.090101555e+11;  y = 1.320136704e+10;  z = -6.001840128e+10;}; typeId= 29624; destinationSolarSystemId= 30003892; destinationStargateId= 50010702 } |> Some
      | 50012009 -> { StargateData.id= 50012009; name= "Stargate (9P4O-F)"; solarSystemId= 30002471; position= {x = -1.858088264e+12;  y = -1.523317555e+11;  z = 7.770204979e+11;}; typeId= 16; destinationSolarSystemId= 30002472; destinationStargateId= 50013262 } |> Some
      | 50012106 -> { StargateData.id= 50012106; name= "Stargate (00GD-D)"; solarSystemId= 30004597; position= {x = 8.125436314e+11;  y = 1.356852019e+11;  z = -3.128764416e+11;}; typeId= 3875; destinationSolarSystemId= 30004596; destinationStargateId= 50011766 } |> Some
      | 50012203 -> { StargateData.id= 50012203; name= "Stargate (Sechmaren)"; solarSystemId= 30004140; position= {x = -3.645447782e+11;  y = 5.279059968e+10;  z = -3.609537331e+11;}; typeId= 29624; destinationSolarSystemId= 30004139; destinationStargateId= 50010499 } |> Some
      | 50012300 -> { StargateData.id= 50012300; name= "Stargate (CIS-7X)"; solarSystemId= 30003367; position= {x = -5.59045632e+11;  y = -1.002196992e+10;  z = -3.585524122e+11;}; typeId= 3875; destinationSolarSystemId= 30003363; destinationStargateId= 50010353 } |> Some
      | 50012397 -> { StargateData.id= 50012397; name= "Stargate (A-1CON)"; solarSystemId= 30004630; position= {x = 8.769683866e+11;  y = -4.862531789e+12;  z = 3.418533028e+12;}; typeId= 3874; destinationSolarSystemId= 30004619; destinationStargateId= 50012319 } |> Some
      | 50012494 -> { StargateData.id= 50012494; name= "Stargate (NEU-UD)"; solarSystemId= 30001825; position= {x = -1.09680513e+12;  y = 2.13315625e+11;  z = -3.171843564e+12;}; typeId= 3875; destinationSolarSystemId= 30001826; destinationStargateId= 50012672 } |> Some
      | 50012591 -> { StargateData.id= 50012591; name= "Stargate (UEPO-D)"; solarSystemId= 30001819; position= {x = 7.221118034e+12;  y = -1.091558646e+12;  z = 4.416809779e+11;}; typeId= 3875; destinationSolarSystemId= 30001821; destinationStargateId= 50012747 } |> Some
      | 50012688 -> { StargateData.id= 50012688; name= "Stargate (0B-VOJ)"; solarSystemId= 30004208; position= {x = 5.351056589e+11;  y = 6.213390336e+10;  z = 5.923795354e+11;}; typeId= 3875; destinationSolarSystemId= 30004214; destinationStargateId= 50013232 } |> Some
      | 50012882 -> { StargateData.id= 50012882; name= "Stargate (Sakht)"; solarSystemId= 30004298; position= {x = -2.787802276e+12;  y = -3.061067366e+11;  z = -2.852109926e+11;}; typeId= 29624; destinationSolarSystemId= 30004299; destinationStargateId= 50012997 } |> Some
      | 50012979 -> { StargateData.id= 50012979; name= "Stargate (Mercomesier)"; solarSystemId= 30003856; position= {x = 5.940875674e+11;  y = 1.071844147e+11;  z = -3.2336785e+12;}; typeId= 3875; destinationSolarSystemId= 30003853; destinationStargateId= 50011117 } |> Some
      | 50013076 -> { StargateData.id= 50013076; name= "Stargate (Z-YN5Y)"; solarSystemId= 30004661; position= {x = -8.867589734e+11;  y = -1.38894336e+11;  z = 2.638577541e+12;}; typeId= 3875; destinationSolarSystemId= 30004666; destinationStargateId= 50013522 } |> Some
      | 50013173 -> { StargateData.id= 50013173; name= "Stargate (OBK-K8)"; solarSystemId= 30004488; position= {x = 2.147138888e+12;  y = 1.133161267e+11;  z = -1.542819717e+12;}; typeId= 29633; destinationSolarSystemId= 30004487; destinationStargateId= 50013071 } |> Some
      | 50013270 -> { StargateData.id= 50013270; name= "Stargate (VBFC-8)"; solarSystemId= 30004548; position= {x = -4919992320.0;  y = 866181120.0;  z = 4.325680374e+12;}; typeId= 3875; destinationSolarSystemId= 30004547; destinationStargateId= 50013142 } |> Some
      | 50013367 -> { StargateData.id= 50013367; name= "Stargate (RG9-7U)"; solarSystemId= 30002953; position= {x = -5.229071155e+11;  y = -7.218499584e+10;  z = -6.391120282e+11;}; typeId= 16; destinationSolarSystemId= 30002954; destinationStargateId= 50013369 } |> Some
      | 50013464 -> { StargateData.id= 50013464; name= "Stargate (LB0-A1)"; solarSystemId= 30001920; position= {x = 4.542324204e+12;  y = -2.217016934e+11;  z = -1.663563325e+12;}; typeId= 29624; destinationSolarSystemId= 30001917; destinationStargateId= 50013301 } |> Some
      | 50013561 -> { StargateData.id= 50013561; name= "Stargate (Arzad)"; solarSystemId= 30002979; position= {x = 2.426535076e+12;  y = -6.386887188e+12;  z = 1.539338281e+12;}; typeId= 17; destinationSolarSystemId= 30002960; destinationStargateId= 50013562 } |> Some
      | 50013658 -> { StargateData.id= 50013658; name= "Stargate (Weld)"; solarSystemId= 30002419; position= {x = 3.67746048e+11;  y = -5.940178944e+10;  z = 1.380435026e+12;}; typeId= 29633; destinationSolarSystemId= 30002415; destinationStargateId= 50013657 } |> Some
      | 50013852 -> { StargateData.id= 50013852; name= "Stargate (Y-1918)"; solarSystemId= 30002955; position= {x = 1.172373123e+13;  y = -5.307765105e+12;  z = 2.995064463e+12;}; typeId= 12292; destinationSolarSystemId= 30004396; destinationStargateId= 50013851 } |> Some
      | 50013949 -> { StargateData.id= 50013949; name= "Stargate (Doussivitte)"; solarSystemId= 30003034; position= {x = 4.050051932e+12;  y = 3.033288991e+12;  z = 2.490323067e+12;}; typeId= 29632; destinationSolarSystemId= 30002706; destinationStargateId= 50013950 } |> Some
      | 50014046 -> { StargateData.id= 50014046; name= "Stargate (Sakht)"; solarSystemId= 30004738; position= {x = 2.507433984e+11;  y = -5.423334605e+11;  z = 1.402248438e+12;}; typeId= 29625; destinationSolarSystemId= 30004299; destinationStargateId= 50014045 } |> Some
      | 50014143 -> { StargateData.id= 50014143; name= "Stargate (Ichinumi)"; solarSystemId= 30001379; position= {x = -1.825303142e+12;  y = -4.196880384e+10;  z = -1.181795328e+12;}; typeId= 16; destinationSolarSystemId= 30041407; destinationStargateId= 50014144 } |> Some
      | 50014240 -> { StargateData.id= 50014240; name= "Stargate (Y-0HVF)"; solarSystemId= 30005190; position= {x = 5.955090309e+12;  y = 5.463411548e+12;  z = 3.386441318e+11;}; typeId= 29632; destinationSolarSystemId= 30003237; destinationStargateId= 50014239 } |> Some
      | 50016277 -> { StargateData.id= 50016277; name= "Stargate (Hikkoken)"; solarSystemId= 30045343; position= {x = 1.663580529e+12;  y = 9.511563264e+10;  z = -1.104927498e+12;}; typeId= 16; destinationSolarSystemId= 30045338; destinationStargateId= 50016278 } |> Some
      | 50016374 -> { StargateData.id= 50016374; name= "Stargate (Kedama)"; solarSystemId= 30045345; position= {x = 1.365307392e+10;  y = 94248960.0;  z = 6.107953152e+11;}; typeId= 16; destinationSolarSystemId= 30045346; destinationStargateId= 50016373 } |> Some
      | _ -> None