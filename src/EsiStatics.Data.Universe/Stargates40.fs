﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stargates40=
    let getStargate id = 
      match id with 
      | 50000048 -> { StargateData.id= 50000048; name= "Stargate (1NZV-7)"; solarSystemId= 30001075; position= {x = -2.224287744e+10;  y = 3180748800.0;  z = -7.31191296e+10;}; typeId= 3875; destinationSolarSystemId= 30001081; destinationStargateId= 50001477 } |> Some
      | 50000145 -> { StargateData.id= 50000145; name= "Stargate (Stetille)"; solarSystemId= 30002706; position= {x = -4.441887498e+12;  y = -2.336913408e+11;  z = -1.970259149e+11;}; typeId= 3875; destinationSolarSystemId= 30002711; destinationStargateId= 50002101 } |> Some
      | 50000242 -> { StargateData.id= 50000242; name= "Stargate (TDP-T3)"; solarSystemId= 30005088; position= {x = 5.351510139e+12;  y = -1.038159913e+12;  z = 1.885548012e+12;}; typeId= 3875; destinationSolarSystemId= 30005089; destinationStargateId= 50000928 } |> Some
      | 50000339 -> { StargateData.id= 50000339; name= "Stargate (D3S-EA)"; solarSystemId= 30002289; position= {x = -7.952986522e+11;  y = -9.665630208e+10;  z = -3.414976143e+12;}; typeId= 3875; destinationSolarSystemId= 30002295; destinationStargateId= 50003080 } |> Some
      | 50000436 -> { StargateData.id= 50000436; name= "Stargate (78-0R6)"; solarSystemId= 30000772; position= {x = -3.377705165e+12;  y = -1.559952998e+11;  z = -3.188087808e+12;}; typeId= 29633; destinationSolarSystemId= 30000773; destinationStargateId= 50001041 } |> Some
      | 50000533 -> { StargateData.id= 50000533; name= "Stargate (N06Z-Q)"; solarSystemId= 30002302; position= {x = 2.407989658e+11;  y = 6371205120.0;  z = -2.237596877e+11;}; typeId= 3875; destinationSolarSystemId= 30002309; destinationStargateId= 50002999 } |> Some
      | 50000630 -> { StargateData.id= 50000630; name= "Stargate (Misneden)"; solarSystemId= 30002662; position= {x = 2.025890243e+12;  y = 1.747163136e+11;  z = 2.532515635e+12;}; typeId= 3875; destinationSolarSystemId= 30002665; destinationStargateId= 50003186 } |> Some
      | 50000727 -> { StargateData.id= 50000727; name= "Stargate (1P-WGB)"; solarSystemId= 30001172; position= {x = 2.121704448e+12;  y = 3.804547891e+11;  z = -1.774000128e+11;}; typeId= 29624; destinationSolarSystemId= 30001170; destinationStargateId= 50000407 } |> Some
      | 50000824 -> { StargateData.id= 50000824; name= "Stargate (5H-SM2)"; solarSystemId= 30000579; position= {x = 2.744801157e+12;  y = 9.634492416e+10;  z = -5.070672568e+12;}; typeId= 29633; destinationSolarSystemId= 30000581; destinationStargateId= 50001505 } |> Some
      | 50000921 -> { StargateData.id= 50000921; name= "Stargate (8P-LKL)"; solarSystemId= 30001564; position= {x = -2.22363906e+12;  y = -7.28107008e+10;  z = 1.020200018e+12;}; typeId= 3875; destinationSolarSystemId= 30001561; destinationStargateId= 50000013 } |> Some
      | 50001018 -> { StargateData.id= 50001018; name= "Stargate (EIN-QG)"; solarSystemId= 30000662; position= {x = 1.594959053e+11;  y = -2.765058048e+10;  z = 4.601867059e+11;}; typeId= 29633; destinationSolarSystemId= 30000655; destinationStargateId= 50000094 } |> Some
      | 50001115 -> { StargateData.id= 50001115; name= "Stargate (J7M-3W)"; solarSystemId= 30002835; position= {x = 6.240356352e+11;  y = 8.807965901e+11;  z = -2.16510124e+12;}; typeId= 29632; destinationSolarSystemId= 30002285; destinationStargateId= 50001847 } |> Some
      | 50001212 -> { StargateData.id= 50001212; name= "Stargate (C0O6-K)"; solarSystemId= 30000567; position= {x = -1.720568832e+12;  y = -1.918017946e+11;  z = -1.132934799e+12;}; typeId= 29633; destinationSolarSystemId= 30000568; destinationStargateId= 50001283 } |> Some
      | 50001406 -> { StargateData.id= 50001406; name= "Stargate (Grinacanne)"; solarSystemId= 30004970; position= {x = 9.169360896e+11;  y = 1.580141322e+12;  z = 7.392813466e+11;}; typeId= 29632; destinationSolarSystemId= 30002636; destinationStargateId= 50004886 } |> Some
      | 50001503 -> { StargateData.id= 50001503; name= "Stargate (78-0R6)"; solarSystemId= 30000542; position= {x = -2.790385951e+12;  y = -1.02941823e+12;  z = 9.051437875e+11;}; typeId= 29635; destinationSolarSystemId= 30000773; destinationStargateId= 50001044 } |> Some
      | 50001600 -> { StargateData.id= 50001600; name= "Stargate (M-EKDF)"; solarSystemId= 30000924; position= {x = 1.374861312e+11;  y = 2.126352384e+10;  z = 5.191200768e+10;}; typeId= 29633; destinationSolarSystemId= 30000922; destinationStargateId= 50001357 } |> Some
      | 50001697 -> { StargateData.id= 50001697; name= "Stargate (Charmerout)"; solarSystemId= 30004973; position= {x = 1.340993495e+12;  y = 1.241959219e+11;  z = 3.910657843e+12;}; typeId= 3875; destinationSolarSystemId= 30004976; destinationStargateId= 50003039 } |> Some
      | 50001794 -> { StargateData.id= 50001794; name= "Stargate (YPW-M4)"; solarSystemId= 30000787; position= {x = 1.462698394e+11;  y = 1.665798144e+10;  z = -4.102508544e+10;}; typeId= 29633; destinationSolarSystemId= 30000784; destinationStargateId= 50000721 } |> Some
      | 50001988 -> { StargateData.id= 50001988; name= "Stargate (Shedoo)"; solarSystemId= 30000048; position= {x = -9.457515602e+12;  y = -5.491407667e+11;  z = 6.178596864e+11;}; typeId= 17; destinationSolarSystemId= 30000106; destinationStargateId= 50003164 } |> Some
      | 50002085 -> { StargateData.id= 50002085; name= "Stargate (Akpivem)"; solarSystemId= 30000007; position= {x = 2.816209306e+11;  y = 3.376263168e+10;  z = -2.062790246e+11;}; typeId= 29624; destinationSolarSystemId= 30000003; destinationStargateId= 50000345 } |> Some
      | 50002182 -> { StargateData.id= 50002182; name= "Stargate (WRL4-2)"; solarSystemId= 30000599; position= {x = -3.632309453e+11;  y = -3.969626112e+10;  z = 1.457377567e+12;}; typeId= 29633; destinationSolarSystemId= 30000602; destinationStargateId= 50004763 } |> Some
      | 50002279 -> { StargateData.id= 50002279; name= "Stargate (Penirgman)"; solarSystemId= 30003492; position= {x = -1.019649761e+12;  y = 1.175343514e+11;  z = 2.672687923e+11;}; typeId= 29624; destinationSolarSystemId= 30003488; destinationStargateId= 50000125 } |> Some
      | 50002376 -> { StargateData.id= 50002376; name= "Stargate (Atreen)"; solarSystemId= 30005194; position= {x = 1.237473731e+12;  y = 2.464546406e+11;  z = -1.170173829e+12;}; typeId= 29624; destinationSolarSystemId= 30005197; destinationStargateId= 50002638 } |> Some
      | 50002473 -> { StargateData.id= 50002473; name= "Stargate (6WT-BE)"; solarSystemId= 30000964; position= {x = -5.515770962e+12;  y = -4.256687309e+11;  z = 6.716967444e+12;}; typeId= 29633; destinationSolarSystemId= 30000967; destinationStargateId= 50004926 } |> Some
      | 50002570 -> { StargateData.id= 50002570; name= "Stargate (Asghed)"; solarSystemId= 30002976; position= {x = 1.380381082e+11;  y = 1.597476864e+10;  z = 9.452269117e+12;}; typeId= 29624; destinationSolarSystemId= 30002978; destinationStargateId= 50004748 } |> Some
      | 50002667 -> { StargateData.id= 50002667; name= "Stargate (TZE-UB)"; solarSystemId= 30000600; position= {x = 2.536970772e+12;  y = 7.033024512e+10;  z = -4.03432108e+12;}; typeId= 29633; destinationSolarSystemId= 30000601; destinationStargateId= 50003503 } |> Some
      | 50002764 -> { StargateData.id= 50002764; name= "Stargate (8Q-T7B)"; solarSystemId= 30000699; position= {x = 3.486234624e+11;  y = -9175326720.0;  z = 8.104833024e+10;}; typeId= 29633; destinationSolarSystemId= 30000697; destinationStargateId= 50001171 } |> Some
      | 50002861 -> { StargateData.id= 50002861; name= "Stargate (QPTT-F)"; solarSystemId= 30000724; position= {x = -1.415244595e+11;  y = 3518423040.0;  z = 2.76173525e+12;}; typeId= 29633; destinationSolarSystemId= 30000722; destinationStargateId= 50002557 } |> Some
      | 50002958 -> { StargateData.id= 50002958; name= "Stargate (FVXK-D)"; solarSystemId= 30000977; position= {x = -2.313139692e+12;  y = 1.009777828e+12;  z = -8.511033876e+12;}; typeId= 3877; destinationSolarSystemId= 30000906; destinationStargateId= 50000382 } |> Some
      | 50003055 -> { StargateData.id= 50003055; name= "Stargate (D87E-A)"; solarSystemId= 30001015; position= {x = 1.052153487e+12;  y = -1.355711693e+11;  z = -6.049059226e+11;}; typeId= 29633; destinationSolarSystemId= 30001010; destinationStargateId= 50000894 } |> Some
      | 50003152 -> { StargateData.id= 50003152; name= "Stargate (AZA-QE)"; solarSystemId= 30001103; position= {x = 1.760865362e+12;  y = 3.59830229e+12;  z = -4.910079222e+12;}; typeId= 3874; destinationSolarSystemId= 30001070; destinationStargateId= 50002106 } |> Some
      | 50003249 -> { StargateData.id= 50003249; name= "Stargate (4HF-4R)"; solarSystemId= 30001559; position= {x = 5.076599194e+11;  y = 1.01703721e+11;  z = -1.483129528e+12;}; typeId= 3875; destinationSolarSystemId= 30001558; destinationStargateId= 50003146 } |> Some
      | 50003346 -> { StargateData.id= 50003346; name= "Stargate (Itsyamil)"; solarSystemId= 30002984; position= {x = -1.551348572e+12;  y = 5.813563392e+10;  z = -1.514262159e+12;}; typeId= 29624; destinationSolarSystemId= 30002985; destinationStargateId= 50003454 } |> Some
      | 50003443 -> { StargateData.id= 50003443; name= "Stargate (Ouelletta)"; solarSystemId= 30005296; position= {x = -5.049952543e+12;  y = -1.30459607e+11;  z = 1.041405665e+12;}; typeId= 3875; destinationSolarSystemId= 30005297; destinationStargateId= 50003816 } |> Some
      | 50003540 -> { StargateData.id= 50003540; name= "Stargate (Cat)"; solarSystemId= 30004993; position= {x = 3.077149778e+12;  y = 5.398392422e+11;  z = -4.13102764e+12;}; typeId= 3874; destinationSolarSystemId= 30005026; destinationStargateId= 50012042 } |> Some
      | 50003637 -> { StargateData.id= 50003637; name= "Stargate (ZOPZ-6)"; solarSystemId= 30001126; position= {x = -2.16284713e+12;  y = 9.15757056e+10;  z = 1.563457536e+11;}; typeId= 3875; destinationSolarSystemId= 30001131; destinationStargateId= 50009001 } |> Some
      | 50003734 -> { StargateData.id= 50003734; name= "Stargate (47L-J4)"; solarSystemId= 30000259; position= {x = 1.076067656e+12;  y = 1.28492544e+11;  z = -5.168264356e+12;}; typeId= 16; destinationSolarSystemId= 30000255; destinationStargateId= 50001434 } |> Some
      | 50003831 -> { StargateData.id= 50003831; name= "Stargate (LW-YEW)"; solarSystemId= 30005093; position= {x = 2.721069588e+12;  y = 2.253035151e+12;  z = 8.196141466e+11;}; typeId= 3874; destinationSolarSystemId= 30005106; destinationStargateId= 50004823 } |> Some
      | 50003928 -> { StargateData.id= 50003928; name= "Stargate (Avesber)"; solarSystemId= 30002526; position= {x = -2.819152159e+12;  y = 4.233725952e+11;  z = -1.42745899e+12;}; typeId= 29633; destinationSolarSystemId= 30002530; destinationStargateId= 50006542 } |> Some
      | 50004025 -> { StargateData.id= 50004025; name= "Stargate (FC-3YI)"; solarSystemId= 30003719; position= {x = 2.686170931e+12;  y = -3.089140531e+11;  z = 7.856813261e+11;}; typeId= 29624; destinationSolarSystemId= 30003718; destinationStargateId= 50003749 } |> Some
      | 50004122 -> { StargateData.id= 50004122; name= "Stargate (Lossa)"; solarSystemId= 30001688; position= {x = 1.54181972e+12;  y = -2.223281357e+11;  z = 4.69334016e+10;}; typeId= 29624; destinationSolarSystemId= 30001687; destinationStargateId= 50004006 } |> Some
      | 50004219 -> { StargateData.id= 50004219; name= "Stargate (G7AQ-7)"; solarSystemId= 30003714; position= {x = -2.685764813e+11;  y = 2865684480.0;  z = 2.99472937e+11;}; typeId= 29624; destinationSolarSystemId= 30003713; destinationStargateId= 50003580 } |> Some
      | 50004316 -> { StargateData.id= 50004316; name= "Stargate (5C-RPA)"; solarSystemId= 30000494; position= {x = -4.051888497e+12;  y = -2.687659008e+12;  z = 2.016895672e+12;}; typeId= 29635; destinationSolarSystemId= 30000844; destinationStargateId= 50004078 } |> Some
      | 50004510 -> { StargateData.id= 50004510; name= "Stargate (Maturat)"; solarSystemId= 30003399; position= {x = -2.78126039e+12;  y = 4.763171635e+11;  z = 2.846527611e+12;}; typeId= 29633; destinationSolarSystemId= 30003396; destinationStargateId= 50003999 } |> Some
      | 50004607 -> { StargateData.id= 50004607; name= "Stargate (TP-RTO)"; solarSystemId= 30002329; position= {x = 8.533793587e+11;  y = -5.3111808e+10;  z = 1.849818685e+12;}; typeId= 3875; destinationSolarSystemId= 30002327; destinationStargateId= 50003894 } |> Some
      | 50004704 -> { StargateData.id= 50004704; name= "Stargate (43-1TL)"; solarSystemId= 30002351; position= {x = 2.892237251e+12;  y = 1.540810752e+11;  z = -1.349232599e+12;}; typeId= 3875; destinationSolarSystemId= 30002350; destinationStargateId= 50004628 } |> Some
      | 50004801 -> { StargateData.id= 50004801; name= "Stargate (H6-CX8)"; solarSystemId= 30003724; position= {x = 1.197710254e+12;  y = 6938910720.0;  z = 3.992925389e+11;}; typeId= 29624; destinationSolarSystemId= 30003723; destinationStargateId= 50003485 } |> Some
      | 50004898 -> { StargateData.id= 50004898; name= "Stargate (K-6SNI)"; solarSystemId= 30000891; position= {x = 1.497527132e+12;  y = 8.345063424e+10;  z = 2.008318894e+12;}; typeId= 16; destinationSolarSystemId= 30000890; destinationStargateId= 50004515 } |> Some
      | 50004995 -> { StargateData.id= 50004995; name= "Stargate (LP1M-Q)"; solarSystemId= 30000598; position= {x = 1.825795645e+12;  y = 2.370213888e+11;  z = 2.176579707e+12;}; typeId= 3877; destinationSolarSystemId= 30000533; destinationStargateId= 50004395 } |> Some
      | 50005092 -> { StargateData.id= 50005092; name= "Stargate (DW-N2S)"; solarSystemId= 30002145; position= {x = 1.08997632e+11;  y = -1.46343936e+10;  z = 3.206051021e+11;}; typeId= 29633; destinationSolarSystemId= 30002146; destinationStargateId= 50005676 } |> Some
      | 50005286 -> { StargateData.id= 50005286; name= "Stargate (08Z-JJ)"; solarSystemId= 30003741; position= {x = -3.287754301e+12;  y = -3.530488627e+11;  z = 2.224908165e+12;}; typeId= 29624; destinationSolarSystemId= 30003743; destinationStargateId= 50005947 } |> Some
      | 50005383 -> { StargateData.id= 50005383; name= "Stargate (Archee)"; solarSystemId= 30002700; position= {x = -1.883336294e+11;  y = -2268487680.0;  z = -3.081892946e+12;}; typeId= 3875; destinationSolarSystemId= 30002702; destinationStargateId= 50007831 } |> Some
      | 50005480 -> { StargateData.id= 50005480; name= "Stargate (OZ-VAE)"; solarSystemId= 30001283; position= {x = -1.63145687e+11;  y = 1.421438976e+10;  z = 1.232662118e+11;}; typeId= 16; destinationSolarSystemId= 30001282; destinationStargateId= 50005424 } |> Some
      | 50005577 -> { StargateData.id= 50005577; name= "Stargate (Erstur)"; solarSystemId= 30003417; position= {x = 2.927371592e+12;  y = 4.1728512e+11;  z = 5.611707187e+11;}; typeId= 29633; destinationSolarSystemId= 30003419; destinationStargateId= 50005759 } |> Some
      | 50005674 -> { StargateData.id= 50005674; name= "Stargate (3GXF-U)"; solarSystemId= 30003749; position= {x = 4.890422354e+12;  y = -2.213276467e+11;  z = -3.097594552e+12;}; typeId= 29624; destinationSolarSystemId= 30003748; destinationStargateId= 50005411 } |> Some
      | 50005771 -> { StargateData.id= 50005771; name= "Stargate (PDF-3Z)"; solarSystemId= 30004826; position= {x = -3.684594033e+12;  y = 3.620450304e+10;  z = -5.721748808e+12;}; typeId= 29633; destinationSolarSystemId= 30004825; destinationStargateId= 50005604 } |> Some
      | 50005868 -> { StargateData.id= 50005868; name= "Stargate (YN3-E3)"; solarSystemId= 30002434; position= {x = -4.41658368e+11;  y = 8.446390272e+10;  z = -7.597412352e+10;}; typeId= 16; destinationSolarSystemId= 30002432; destinationStargateId= 50004978 } |> Some
      | 50005965 -> { StargateData.id= 50005965; name= "Stargate (N-RMSH)"; solarSystemId= 30003760; position= {x = 2.00056873e+11;  y = 2.400448512e+10;  z = -1.891134259e+11;}; typeId= 29624; destinationSolarSystemId= 30003763; destinationStargateId= 50009901 } |> Some
      | 50006062 -> { StargateData.id= 50006062; name= "Stargate (K-IYNW)"; solarSystemId= 30000998; position= {x = -2.667461714e+12;  y = -3.441439949e+11;  z = 2.240500163e+12;}; typeId= 29633; destinationSolarSystemId= 30001000; destinationStargateId= 50006795 } |> Some
      | 50006159 -> { StargateData.id= 50006159; name= "Stargate (Brellystier)"; solarSystemId= 30003808; position= {x = -7.058127667e+11;  y = -5.402652672e+10;  z = 7.09150593e+12;}; typeId= 3875; destinationSolarSystemId= 30003809; destinationStargateId= 50006222 } |> Some
      | 50006256 -> { StargateData.id= 50006256; name= "Stargate (HOHF-B)"; solarSystemId= 30002593; position= {x = -1.061525053e+12;  y = -4977254400.0;  z = 6.497640038e+11;}; typeId= 29633; destinationSolarSystemId= 30002596; destinationStargateId= 50006321 } |> Some
      | 50006353 -> { StargateData.id= 50006353; name= "Stargate (6E-MOW)"; solarSystemId= 30002598; position= {x = -1.103769231e+12;  y = 5.374529741e+12;  z = -3.855959532e+12;}; typeId= 3877; destinationSolarSystemId= 30002619; destinationStargateId= 50007100 } |> Some
      | 50006450 -> { StargateData.id= 50006450; name= "Stargate (5-N2EY)"; solarSystemId= 30001239; position= {x = 3.462856827e+12;  y = 4.51667927e+11;  z = 3.889850081e+12;}; typeId= 29624; destinationSolarSystemId= 30001241; destinationStargateId= 50006694 } |> Some
      | 50006547 -> { StargateData.id= 50006547; name= "Stargate (Lasleinur)"; solarSystemId= 30002061; position= {x = -9.857144832e+11;  y = -1.835771904e+11;  z = -1.218243502e+12;}; typeId= 29633; destinationSolarSystemId= 30002065; destinationStargateId= 50009194 } |> Some
      | 50006644 -> { StargateData.id= 50006644; name= "Stargate (Petidu)"; solarSystemId= 30005239; position= {x = 3.379584492e+12;  y = -5.369704858e+11;  z = 2.467138314e+12;}; typeId= 29624; destinationSolarSystemId= 30005241; destinationStargateId= 50007294 } |> Some
      | 50006741 -> { StargateData.id= 50006741; name= "Stargate (AK-L0Z)"; solarSystemId= 30005139; position= {x = -6.224618496e+12;  y = 1.891184517e+12;  z = -5.501163479e+12;}; typeId= 3874; destinationSolarSystemId= 30005098; destinationStargateId= 50005478 } |> Some
      | 50006838 -> { StargateData.id= 50006838; name= "Stargate (Berta)"; solarSystemId= 30000111; position= {x = 6.387706675e+11;  y = -8.91930624e+10;  z = -1.130798162e+12;}; typeId= 29624; destinationSolarSystemId= 30000109; destinationStargateId= 50006306 } |> Some
      | 50006935 -> { StargateData.id= 50006935; name= "Stargate (KOI8-Z)"; solarSystemId= 30005125; position= {x = 1.335586406e+11;  y = -1.016844288e+10;  z = 1.028039885e+11;}; typeId= 3875; destinationSolarSystemId= 30005124; destinationStargateId= 50006360 } |> Some
      | 50007032 -> { StargateData.id= 50007032; name= "Stargate (GTQ-C9)"; solarSystemId= 30003200; position= {x = -3.68529322e+12;  y = -5.454998323e+11;  z = -3.9031296e+11;}; typeId= 3875; destinationSolarSystemId= 30003199; destinationStargateId= 50006735 } |> Some
      | 50007129 -> { StargateData.id= 50007129; name= "Stargate (K25-XD)"; solarSystemId= 30002463; position= {x = 2.961114931e+12;  y = 3.432732672e+11;  z = 1.473971528e+12;}; typeId= 16; destinationSolarSystemId= 30002464; destinationStargateId= 50007154 } |> Some
      | 50007226 -> { StargateData.id= 50007226; name= "Stargate (VRH-H7)"; solarSystemId= 30003683; position= {x = -9.87961344e+10;  y = -1.370099712e+10;  z = -1.102369382e+12;}; typeId= 3875; destinationSolarSystemId= 30003685; destinationStargateId= 50007641 } |> Some
      | 50007323 -> { StargateData.id= 50007323; name= "Stargate (Habu)"; solarSystemId= 30005249; position= {x = -5.750216417e+12;  y = 3.553312358e+11;  z = 2.259024814e+12;}; typeId= 29624; destinationSolarSystemId= 30005250; destinationStargateId= 50007403 } |> Some
      | 50007420 -> { StargateData.id= 50007420; name= "Stargate (LHJ-2G)"; solarSystemId= 30001340; position= {x = -1.528155955e+12;  y = -1.229248512e+11;  z = 5.979369062e+11;}; typeId= 16; destinationSolarSystemId= 30001337; destinationStargateId= 50006777 } |> Some
      | 50007517 -> { StargateData.id= 50007517; name= "Stargate (C-J7CR)"; solarSystemId= 30000272; position= {x = -1.653921792e+11;  y = 1.548742656e+10;  z = -3.567674573e+11;}; typeId= 16; destinationSolarSystemId= 30000273; destinationStargateId= 50007959 } |> Some
      | 50007614 -> { StargateData.id= 50007614; name= "Stargate (Ansasos)"; solarSystemId= 30004106; position= {x = -1.506791793e+12;  y = 1.198511309e+11;  z = 2.845542605e+12;}; typeId= 29624; destinationSolarSystemId= 30004104; destinationStargateId= 50006810 } |> Some
      | 50007711 -> { StargateData.id= 50007711; name= "Stargate (Djimame)"; solarSystemId= 30005261; position= {x = -7.600171008e+11;  y = 3.855126528e+10;  z = 3.308351078e+11;}; typeId= 29624; destinationSolarSystemId= 30005262; destinationStargateId= 50008357 } |> Some
      | 50007808 -> { StargateData.id= 50007808; name= "Stargate (FHB-QA)"; solarSystemId= 30001345; position= {x = -6.151297843e+11;  y = -2.949451776e+10;  z = -4.7937024e+11;}; typeId= 16; destinationSolarSystemId= 30001344; destinationStargateId= 50007723 } |> Some
      | 50007905 -> { StargateData.id= 50007905; name= "Stargate (Ouranienen)"; solarSystemId= 30001412; position= {x = 1.508041114e+11;  y = -5.771041874e+12;  z = 2.786280284e+12;}; typeId= 29627; destinationSolarSystemId= 30001370; destinationStargateId= 50004392 } |> Some
      | 50008002 -> { StargateData.id= 50008002; name= "Stargate (RQH-MY)"; solarSystemId= 30002035; position= {x = 7.809760174e+12;  y = 1.258152346e+11;  z = -1.064552583e+13;}; typeId= 16; destinationSolarSystemId= 30002039; destinationStargateId= 50010123 } |> Some
      | 50008099 -> { StargateData.id= 50008099; name= "Stargate (01TG-J)"; solarSystemId= 30002608; position= {x = 3.910791168e+10;  y = 4484259840.0;  z = 1.416289075e+11;}; typeId= 29633; destinationSolarSystemId= 30002609; destinationStargateId= 50008233 } |> Some
      | 50008196 -> { StargateData.id= 50008196; name= "Stargate (7V-KHW)"; solarSystemId= 30003947; position= {x = 3.382909379e+12;  y = -6.490886554e+11;  z = 2.595404882e+12;}; typeId= 29624; destinationSolarSystemId= 30003945; destinationStargateId= 50008152 } |> Some
      | 50008293 -> { StargateData.id= 50008293; name= "Stargate (Neesher)"; solarSystemId= 30005057; position= {x = -7.575196877e+11;  y = 4.550823936e+10;  z = 2.576510976e+10;}; typeId= 29624; destinationSolarSystemId= 30005058; destinationStargateId= 50008343 } |> Some
      | 50008390 -> { StargateData.id= 50008390; name= "Stargate (H-S5BM)"; solarSystemId= 30001341; position= {x = -1.599011021e+12;  y = 1.837779763e+11;  z = 7.254528e+10;}; typeId= 16; destinationSolarSystemId= 30001343; destinationStargateId= 50011991 } |> Some
      | 50008487 -> { StargateData.id= 50008487; name= "Stargate (Chamemi)"; solarSystemId= 30003909; position= {x = -4.113357619e+11;  y = -5.722779648e+10;  z = -1.358519869e+12;}; typeId= 29624; destinationSolarSystemId= 30003905; destinationStargateId= 50007940 } |> Some
      | 50008584 -> { StargateData.id= 50008584; name= "Stargate (FR-B1H)"; solarSystemId= 30002629; position= {x = -4158382080.0;  y = -174858240.0;  z = 1.373595648e+11;}; typeId= 29633; destinationSolarSystemId= 30002630; destinationStargateId= 50009440 } |> Some
      | 50008681 -> { StargateData.id= 50008681; name= "Stargate (Earwik)"; solarSystemId= 30003415; position= {x = -1.759014052e+12;  y = 9.664493568e+11;  z = 7.127591731e+11;}; typeId= 3877; destinationSolarSystemId= 30003441; destinationStargateId= 50008830 } |> Some
      | 50008778 -> { StargateData.id= 50008778; name= "Stargate (C9N-CC)"; solarSystemId= 30003110; position= {x = -3.596344934e+11;  y = -5.932634112e+10;  z = 5.990325043e+11;}; typeId= 29624; destinationSolarSystemId= 30003109; destinationStargateId= 50008593 } |> Some
      | 50008875 -> { StargateData.id= 50008875; name= "Stargate (Lamadent)"; solarSystemId= 30002719; position= {x = 1.886587085e+12;  y = -2.434797158e+11;  z = -2.231910359e+12;}; typeId= 3875; destinationSolarSystemId= 30002722; destinationStargateId= 50010455 } |> Some
      | 50008972 -> { StargateData.id= 50008972; name= "Stargate (Pelkia)"; solarSystemId= 30002213; position= {x = -7.445681357e+11;  y = -3.317428224e+10;  z = 3.814746931e+11;}; typeId= 29624; destinationSolarSystemId= 30002211; destinationStargateId= 50005683 } |> Some
      | 50009069 -> { StargateData.id= 50009069; name= "Stargate (9-HM04)"; solarSystemId= 30003955; position= {x = 1.820952207e+12;  y = 2.58455593e+11;  z = 2.448355738e+11;}; typeId= 29624; destinationSolarSystemId= 30003961; destinationStargateId= 50010235 } |> Some
      | 50009166 -> { StargateData.id= 50009166; name= "Stargate (R-YWID)"; solarSystemId= 30003632; position= {x = 4.984541184e+10;  y = -7979212800.0;  z = -7.984753459e+11;}; typeId= 16; destinationSolarSystemId= 30003631; destinationStargateId= 50009158 } |> Some
      | 50009263 -> { StargateData.id= 50009263; name= "Stargate (Thelan)"; solarSystemId= 30002721; position= {x = -1.275863163e+12;  y = 3.40322304e+10;  z = 2.047420047e+12;}; typeId= 3875; destinationSolarSystemId= 30002720; destinationStargateId= 50009222 } |> Some
      | 50009360 -> { StargateData.id= 50009360; name= "Stargate (Nagamanen)"; solarSystemId= 30002808; position= {x = 1.443932774e+12;  y = 2.73522647e+11;  z = -3.766185861e+12;}; typeId= 16; destinationSolarSystemId= 30002807; destinationStargateId= 50008275 } |> Some
      | 50009457 -> { StargateData.id= 50009457; name= "Stargate (06-70G)"; solarSystemId= 30001121; position= {x = -8.87780352e+11;  y = 1.573550899e+11;  z = -6.041607168e+12;}; typeId= 3875; destinationSolarSystemId= 30001120; destinationStargateId= 50009137 } |> Some
      | 50009554 -> { StargateData.id= 50009554; name= "Stargate (E-PR0S)"; solarSystemId= 30004450; position= {x = 3.3788928e+10;  y = -4709867520.0;  z = -4.917474509e+11;}; typeId= 29633; destinationSolarSystemId= 30004451; destinationStargateId= 50009754 } |> Some
      | 50009651 -> { StargateData.id= 50009651; name= "Stargate (P-E9GN)"; solarSystemId= 30002470; position= {x = -6.828961382e+11;  y = 2.519519232e+10;  z = 2.342659645e+12;}; typeId= 16; destinationSolarSystemId= 30002467; destinationStargateId= 50005918 } |> Some
      | 50009748 -> { StargateData.id= 50009748; name= "Stargate (Arifsdald)"; solarSystemId= 30002079; position= {x = 5.438808515e+12;  y = -7.557182669e+11;  z = -4.022879478e+12;}; typeId= 29633; destinationSolarSystemId= 30002080; destinationStargateId= 50011096 } |> Some
      | 50009845 -> { StargateData.id= 50009845; name= "Stargate (S-DLKC)"; solarSystemId= 30001894; position= {x = 2.295033446e+11;  y = -4.384223232e+10;  z = 3.078893568e+10;}; typeId= 29624; destinationSolarSystemId= 30001893; destinationStargateId= 50009663 } |> Some
      | 50009942 -> { StargateData.id= 50009942; name= "Stargate (P-NRD3)"; solarSystemId= 30004168; position= {x = 3.62207232e+10;  y = -2313461760.0;  z = 2901565440.0;}; typeId= 3875; destinationSolarSystemId= 30004170; destinationStargateId= 50010121 } |> Some
      | 50010039 -> { StargateData.id= 50010039; name= "Stargate (X-9ZZR)"; solarSystemId= 30003244; position= {x = -5.72102615e+11;  y = 4.099289088e+10;  z = -1.826956493e+11;}; typeId= 3875; destinationSolarSystemId= 30003245; destinationStargateId= 50010370 } |> Some
      | 50010136 -> { StargateData.id= 50010136; name= "Stargate (Gateway)"; solarSystemId= 30005281; position= {x = -4.190887526e+11;  y = 4541030400.0;  z = -2.60118528e+10;}; typeId= 29624; destinationSolarSystemId= 30005282; destinationStargateId= 50011075 } |> Some
      | 50010233 -> { StargateData.id= 50010233; name= "Stargate (A4UG-O)"; solarSystemId= 30001897; position= {x = -1.093489336e+12;  y = 1.006700544e+11;  z = -7.700922778e+11;}; typeId= 29624; destinationSolarSystemId= 30001896; destinationStargateId= 50010198 } |> Some
      | 50010330 -> { StargateData.id= 50010330; name= "Stargate (0N-3RO)"; solarSystemId= 30004719; position= {x = -2.615110656e+12;  y = -3.839136154e+11;  z = -2.136385167e+12;}; typeId= 29624; destinationSolarSystemId= 30004720; destinationStargateId= 50010475 } |> Some
      | 50010427 -> { StargateData.id= 50010427; name= "Stargate (W4E-IT)"; solarSystemId= 30002164; position= {x = 1.113879306e+12;  y = -1.369027338e+12;  z = -4.621887283e+12;}; typeId= 3877; destinationSolarSystemId= 30002172; destinationStargateId= 50010637 } |> Some
      | 50010524 -> { StargateData.id= 50010524; name= "Stargate (DG-L7S)"; solarSystemId= 30004017; position= {x = 4.994483405e+11;  y = 2.71276032e+10;  z = 9.510896026e+11;}; typeId= 29624; destinationSolarSystemId= 30004016; destinationStargateId= 50010404 } |> Some
      | 50010621 -> { StargateData.id= 50010621; name= "Stargate (BF-SDP)"; solarSystemId= 30004526; position= {x = 2.265274368e+11;  y = -7.340508365e+11;  z = -1.315932365e+12;}; typeId= 3874; destinationSolarSystemId= 30004506; destinationStargateId= 50009593 } |> Some
      | 50010718 -> { StargateData.id= 50010718; name= "Stargate (Brapelille)"; solarSystemId= 30002704; position= {x = 6.687998362e+11;  y = -2.557784064e+10;  z = 3.949612646e+11;}; typeId= 3875; destinationSolarSystemId= 30002699; destinationStargateId= 50001763 } |> Some
      | 50010815 -> { StargateData.id= 50010815; name= "Stargate (0-MX34)"; solarSystemId= 30004675; position= {x = 9.209073254e+11;  y = -1.26685225e+11;  z = -5.0052574e+12;}; typeId= 29624; destinationSolarSystemId= 30004674; destinationStargateId= 50010741 } |> Some
      | 50010912 -> { StargateData.id= 50010912; name= "Stargate (Y-C4AL)"; solarSystemId= 30002170; position= {x = -4.29656064e+10;  y = -651386880.0;  z = 4.222614528e+12;}; typeId= 29633; destinationSolarSystemId= 30002169; destinationStargateId= 50010869 } |> Some
      | 50011009 -> { StargateData.id= 50011009; name= "Stargate (OU-X3P)"; solarSystemId= 30004054; position= {x = 1.420179333e+12;  y = -1.993104998e+11;  z = -2.205672284e+12;}; typeId= 3875; destinationSolarSystemId= 30004052; destinationStargateId= 50010982 } |> Some
      | 50011106 -> { StargateData.id= 50011106; name= "Stargate (Palpis)"; solarSystemId= 30003007; position= {x = 1.081763021e+11;  y = 1.26179328e+10;  z = 3.026387067e+12;}; typeId= 29624; destinationSolarSystemId= 30003008; destinationStargateId= 50011784 } |> Some
      | 50011203 -> { StargateData.id= 50011203; name= "Stargate (Olide)"; solarSystemId= 30003060; position= {x = -2.430034207e+12;  y = -2.707231949e+11;  z = 1.219224736e+13;}; typeId= 3875; destinationSolarSystemId= 30003058; destinationStargateId= 50008988 } |> Some
      | 50011300 -> { StargateData.id= 50011300; name= "Stargate (7MMJ-3)"; solarSystemId= 30005151; position= {x = 1.641963479e+12;  y = 1.183433933e+11;  z = -1.279066644e+12;}; typeId= 3875; destinationSolarSystemId= 30005146; destinationStargateId= 50009232 } |> Some
      | 50011397 -> { StargateData.id= 50011397; name= "Stargate (6-AOLS)"; solarSystemId= 30003670; position= {x = 2.472062607e+12;  y = 3.040970711e+12;  z = -1.133900636e+12;}; typeId= 29627; destinationSolarSystemId= 30003640; destinationStargateId= 50010422 } |> Some
      | 50011494 -> { StargateData.id= 50011494; name= "Stargate (F-G7BO)"; solarSystemId= 30000898; position= {x = -1.893738455e+12;  y = 1.657613107e+11;  z = 1.147883397e+12;}; typeId= 16; destinationSolarSystemId= 30000897; destinationStargateId= 50009989 } |> Some
      | 50011591 -> { StargateData.id= 50011591; name= "Stargate (SVB-RE)"; solarSystemId= 30004376; position= {x = 9.054006067e+11;  y = 9.89534208e+10;  z = 5.014013952e+11;}; typeId= 16; destinationSolarSystemId= 30004377; destinationStargateId= 50011704 } |> Some
      | 50011688 -> { StargateData.id= 50011688; name= "Stargate (3PPT-9)"; solarSystemId= 30004681; position= {x = -3.573992448e+12;  y = -7.127783424e+11;  z = -2.348986491e+12;}; typeId= 29624; destinationSolarSystemId= 30004682; destinationStargateId= 50012209 } |> Some
      | 50011785 -> { StargateData.id= 50011785; name= "Stargate (Q-JQSG)"; solarSystemId= 30004784; position= {x = 1.739965686e+12;  y = 3.122290237e+12;  z = -2.543801426e+12;}; typeId= 17; destinationSolarSystemId= 30004749; destinationStargateId= 50011124 } |> Some
      | 50011882 -> { StargateData.id= 50011882; name= "Stargate (YVBE-E)"; solarSystemId= 30004563; position= {x = -5.759138611e+11;  y = 1.788186624e+10;  z = 4.180624589e+11;}; typeId= 3875; destinationSolarSystemId= 30004561; destinationStargateId= 50011729 } |> Some
      | 50011979 -> { StargateData.id= 50011979; name= "Stargate (O-2RNZ)"; solarSystemId= 30002933; position= {x = -2.494662205e+12;  y = -2.464836403e+11;  z = 3.769846579e+11;}; typeId= 16; destinationSolarSystemId= 30002935; destinationStargateId= 50012187 } |> Some
      | 50012076 -> { StargateData.id= 50012076; name= "Stargate (DIBH-Q)"; solarSystemId= 30003160; position= {x = 5.900077056e+11;  y = 9.478828032e+10;  z = -5.520173875e+11;}; typeId= 29624; destinationSolarSystemId= 30003156; destinationStargateId= 50010481 } |> Some
      | 50012173 -> { StargateData.id= 50012173; name= "Stargate (ES-Q0W)"; solarSystemId= 30004031; position= {x = 1.411428803e+12;  y = 1.790296474e+11;  z = 1.574393856e+11;}; typeId= 29624; destinationSolarSystemId= 30004033; destinationStargateId= 50012645 } |> Some
      | 50012270 -> { StargateData.id= 50012270; name= "Stargate (4DTQ-K)"; solarSystemId= 30004388; position= {x = -8.260665754e+11;  y = 1.430823322e+11;  z = -4.68005204e+12;}; typeId= 16; destinationSolarSystemId= 30004384; destinationStargateId= 50010599 } |> Some
      | 50012367 -> { StargateData.id= 50012367; name= "Stargate (Getrenjesa)"; solarSystemId= 30004285; position= {x = 4.897968538e+11;  y = 3.6750336e+10;  z = 3.266130125e+12;}; typeId= 29624; destinationSolarSystemId= 30004282; destinationStargateId= 50012249 } |> Some
      | 50012464 -> { StargateData.id= 50012464; name= "Stargate (Murini)"; solarSystemId= 30004150; position= {x = -8.063025562e+11;  y = 2.466544312e+12;  z = 3.279078605e+11;}; typeId= 17; destinationSolarSystemId= 30004092; destinationStargateId= 50004438 } |> Some
      | 50012561 -> { StargateData.id= 50012561; name= "Stargate (7-K6UE)"; solarSystemId= 30004792; position= {x = -4.052250624e+10;  y = -2465341440.0;  z = 5.254342656e+11;}; typeId= 29624; destinationSolarSystemId= 30004790; destinationStargateId= 50012006 } |> Some
      | 50012658 -> { StargateData.id= 50012658; name= "Stargate (Kadlina)"; solarSystemId= 30002419; position= {x = -3.417502925e+11;  y = 5.519659008e+10;  z = -6.03688919e+11;}; typeId= 29633; destinationSolarSystemId= 30002417; destinationStargateId= 50012340 } |> Some
      | 50012755 -> { StargateData.id= 50012755; name= "Stargate (M-NP5O)"; solarSystemId= 30001596; position= {x = -1.182769029e+12;  y = 2.008199578e+11;  z = 8.554044211e+11;}; typeId= 3875; destinationSolarSystemId= 30001597; destinationStargateId= 50012795 } |> Some
      | 50012852 -> { StargateData.id= 50012852; name= "Stargate (Y-CWQY)"; solarSystemId= 30004940; position= {x = 1.895386276e+12;  y = -1.759689523e+11;  z = -5.486711194e+11;}; typeId= 29624; destinationSolarSystemId= 30004941; destinationStargateId= 50013017 } |> Some
      | 50012949 -> { StargateData.id= 50012949; name= "Stargate (0OTX-J)"; solarSystemId= 30004948; position= {x = -7.502810726e+11;  y = -6.369865728e+10;  z = -3.976157184e+11;}; typeId= 29624; destinationSolarSystemId= 30004950; destinationStargateId= 50013041 } |> Some
      | 50013046 -> { StargateData.id= 50013046; name= "Stargate (4N-BUI)"; solarSystemId= 30002948; position= {x = 2.548303872e+11;  y = -1.437462528e+10;  z = -4774993920.0;}; typeId= 16; destinationSolarSystemId= 30002944; destinationStargateId= 50012830 } |> Some
      | 50013143 -> { StargateData.id= 50013143; name= "Stargate (VJ0-81)"; solarSystemId= 30004547; position= {x = 2.330902979e+12;  y = -3.151150694e+11;  z = 4933017600.0;}; typeId= 3875; destinationSolarSystemId= 30004551; destinationStargateId= 50013485 } |> Some
      | 50013240 -> { StargateData.id= 50013240; name= "Stargate (LGL-SD)"; solarSystemId= 30001951; position= {x = -1.954737807e+12;  y = -1.393364582e+11;  z = 1.36787841e+12;}; typeId= 29624; destinationSolarSystemId= 30001953; destinationStargateId= 50013286 } |> Some
      | 50013337 -> { StargateData.id= 50013337; name= "Stargate (EMIG-F)"; solarSystemId= 30004879; position= {x = -8.282479411e+11;  y = -1.272666931e+11;  z = -2.46495916e+12;}; typeId= 29633; destinationSolarSystemId= 30004880; destinationStargateId= 50013339 } |> Some
      | 50013434 -> { StargateData.id= 50013434; name= "Stargate (66-PMM)"; solarSystemId= 30004924; position= {x = -1.596254208e+11;  y = -1.612443648e+10;  z = 1.349456732e+12;}; typeId= 29633; destinationSolarSystemId= 30004923; destinationStargateId= 50013410 } |> Some
      | 50013531 -> { StargateData.id= 50013531; name= "Stargate (Aeter)"; solarSystemId= 30003587; position= {x = 1.855696896e+10;  y = -2199429120.0;  z = 7.839903744e+10;}; typeId= 3875; destinationSolarSystemId= 30003585; destinationStargateId= 50011437 } |> Some
      | 50013628 -> { StargateData.id= 50013628; name= "Stargate (Daran)"; solarSystemId= 30005035; position= {x = 9.417519514e+11;  y = 4.475063624e+12;  z = -5.130326016e+10;}; typeId= 17; destinationSolarSystemId= 30005074; destinationStargateId= 50013627 } |> Some
      | 50013822 -> { StargateData.id= 50013822; name= "Stargate (U2-28D)"; solarSystemId= 30000978; position= {x = -4.052539392e+11;  y = -5.573714534e+12;  z = -4.141139927e+12;}; typeId= 12292; destinationSolarSystemId= 30000703; destinationStargateId= 50013821 } |> Some
      | 50013919 -> { StargateData.id= 50013919; name= "Stargate (Alikara)"; solarSystemId= 30000145; position= {x = -5.188611686e+11;  y = 5.566047437e+11;  z = 1.493590303e+12;}; typeId= 29629; destinationSolarSystemId= 30002754; destinationStargateId= 50013920 } |> Some
      | 50014016 -> { StargateData.id= 50014016; name= "Stargate (Muttokon)"; solarSystemId= 30002420; position= {x = -2.72858837e+12;  y = 1.077668782e+12;  z = 1.239644037e+12;}; typeId= 3877; destinationSolarSystemId= 30002394; destinationStargateId= 50014015 } |> Some
      | 50014113 -> { StargateData.id= 50014113; name= "Stargate (Urhinichi)"; solarSystemId= 30002791; position= {x = -1.51209431e+12;  y = -2360893440.0;  z = -1.042429993e+12;}; typeId= 16; destinationSolarSystemId= 30040141; destinationStargateId= 50014114 } |> Some
      | 50014210 -> { StargateData.id= 50014210; name= "Stargate (9P4O-F)"; solarSystemId= 30002866; position= {x = -2.459231969e+12;  y = 3.093229978e+11;  z = 1.055297987e+12;}; typeId= 29632; destinationSolarSystemId= 30002472; destinationStargateId= 50014209 } |> Some
      | 50016247 -> { StargateData.id= 50016247; name= "Stargate (Martoh)"; solarSystemId= 30045308; position= {x = 1.614106829e+12;  y = 3.719695196e+12;  z = -1.253805466e+12;}; typeId= 29627; destinationSolarSystemId= 30045318; destinationStargateId= 50016248 } |> Some
      | 50016344 -> { StargateData.id= 50016344; name= "Stargate (Mushikegi)"; solarSystemId= 30045331; position= {x = -9.910759834e+11;  y = -1.901457408e+10;  z = -6.262555853e+11;}; typeId= 16; destinationSolarSystemId= 30045334; destinationStargateId= 50016343 } |> Some
      | _ -> None