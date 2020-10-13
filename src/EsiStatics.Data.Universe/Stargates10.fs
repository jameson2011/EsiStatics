﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stargates10=
    let getStargate id = 
      match id with 
      | 50000018 -> { StargateData.id= 50000018; name= "Stargate (Amattens)"; solarSystemId= 30003009; position= {x = -7.957499904e+10;  y = -9434603520.0;  z = 1.493815296e+10;}; typeId= 3875; destinationSolarSystemId= 30003012; destinationStargateId= 50003929 } |> Some
      | 50000115 -> { StargateData.id= 50000115; name= "Stargate (Aikoro)"; solarSystemId= 30002750; position= {x = -2.124672983e+12;  y = -8052940800.0;  z = 2.47772418e+12;}; typeId= 16; destinationSolarSystemId= 30002753; destinationStargateId= 50001198 } |> Some
      | 50000212 -> { StargateData.id= 50000212; name= "Stargate (Lamaa)"; solarSystemId= 30002957; position= {x = 3.225468518e+11;  y = 2.191164826e+12;  z = -1.995504722e+12;}; typeId= 29626; destinationSolarSystemId= 30003063; destinationStargateId= 50000130 } |> Some
      | 50000309 -> { StargateData.id= 50000309; name= "Stargate (Semiki)"; solarSystemId= 30001357; position= {x = 6.061777306e+11;  y = 3.102191616e+10;  z = -7.272280474e+11;}; typeId= 16; destinationSolarSystemId= 30001359; destinationStargateId= 50001308 } |> Some
      | 50000406 -> { StargateData.id= 50000406; name= "Stargate (F4R2-Q)"; solarSystemId= 30001170; position= {x = 3.250709176e+12;  y = -5.393973658e+11;  z = -3.439228477e+12;}; typeId= 29624; destinationSolarSystemId= 30001171; destinationStargateId= 50000514 } |> Some
      | 50000503 -> { StargateData.id= 50000503; name= "Stargate (VW-PXL)"; solarSystemId= 30001052; position= {x = 2.222675436e+12;  y = 4.398667776e+11;  z = 1.331599811e+12;}; typeId= 3875; destinationSolarSystemId= 30001054; destinationStargateId= 50001462 } |> Some
      | 50000600 -> { StargateData.id= 50000600; name= "Stargate (Ilahed)"; solarSystemId= 30000089; position= {x = -9.33054505e+11;  y = 9.141522432e+10;  z = 1.840220774e+12;}; typeId= 29624; destinationSolarSystemId= 30000090; destinationStargateId= 50001082 } |> Some
      | 50000697 -> { StargateData.id= 50000697; name= "Stargate (7-YHRX)"; solarSystemId= 30002851; position= {x = 2.493386711e+12;  y = 1.890801377e+12;  z = 8.510925619e+11;}; typeId= 29632; destinationSolarSystemId= 30001057; destinationStargateId= 50000597 } |> Some
      | 50000794 -> { StargateData.id= 50000794; name= "Stargate (SY-0AM)"; solarSystemId= 30002834; position= {x = 3.979014513e+12;  y = -3.488915866e+11;  z = 1.661043302e+12;}; typeId= 3875; destinationSolarSystemId= 30002835; destinationStargateId= 50001114 } |> Some
      | 50000891 -> { StargateData.id= 50000891; name= "Stargate (K-B2D3)"; solarSystemId= 30001010; position= {x = 1.423695421e+12;  y = -1.346493235e+11;  z = 1.39192062e+12;}; typeId= 29633; destinationSolarSystemId= 30001011; destinationStargateId= 50001524 } |> Some
      | 50000988 -> { StargateData.id= 50000988; name= "Stargate (Q-K2T7)"; solarSystemId= 30000680; position= {x = -1.192537498e+12;  y = -1.47280896e+11;  z = 1.439567462e+11;}; typeId= 29633; destinationSolarSystemId= 30000682; destinationStargateId= 50001681 } |> Some
      | 50001085 -> { StargateData.id= 50001085; name= "Stargate (Kassigainen)"; solarSystemId= 30002762; position= {x = -2.082859131e+12;  y = 2.252519424e+11;  z = -1.571741245e+12;}; typeId= 16; destinationSolarSystemId= 30002761; destinationStargateId= 50000741 } |> Some
      | 50001182 -> { StargateData.id= 50001182; name= "Stargate (2-2EWC)"; solarSystemId= 30000618; position= {x = 3.203728712e+12;  y = -1.95590185e+11;  z = 1.161598034e+12;}; typeId= 3877; destinationSolarSystemId= 30000611; destinationStargateId= 50000414 } |> Some
      | 50001279 -> { StargateData.id= 50001279; name= "Stargate (A0M-R8)"; solarSystemId= 30001078; position= {x = -4.213091328e+12;  y = -5.74904279e+11;  z = -2.275493929e+12;}; typeId= 3875; destinationSolarSystemId= 30001077; destinationStargateId= 50000822 } |> Some
      | 50001376 -> { StargateData.id= 50001376; name= "Stargate (F-RT6Q)"; solarSystemId= 30000856; position= {x = 8.886767616e+10;  y = 1.777176576e+10;  z = -2.905449554e+12;}; typeId= 16; destinationSolarSystemId= 30000853; destinationStargateId= 50000884 } |> Some
      | 50001473 -> { StargateData.id= 50001473; name= "Stargate (9PX2-F)"; solarSystemId= 30000669; position= {x = -4.194829517e+11;  y = -4.62145536e+10;  z = 7.694241792e+10;}; typeId= 29633; destinationSolarSystemId= 30000668; destinationStargateId= 50001234 } |> Some
      | 50001570 -> { StargateData.id= 50001570; name= "Stargate (Q-GQHN)"; solarSystemId= 30000582; position= {x = 9.324538307e+12;  y = 1.42930686e+12;  z = 1.045085442e+13;}; typeId= 29633; destinationSolarSystemId= 30000586; destinationStargateId= 50002303 } |> Some
      | 50001667 -> { StargateData.id= 50001667; name= "Stargate (W2T-TR)"; solarSystemId= 30000621; position= {x = 2.896894771e+11;  y = -2.625171456e+10;  z = -2.271833334e+12;}; typeId= 29633; destinationSolarSystemId= 30000617; destinationStargateId= 50001067 } |> Some
      | 50001764 -> { StargateData.id= 50001764; name= "Stargate (Caretyn)"; solarSystemId= 30002699; position= {x = -2.025306317e+12;  y = -2.125479076e+12;  z = 3.007359345e+12;}; typeId= 3874; destinationSolarSystemId= 30002735; destinationStargateId= 50013216 } |> Some
      | 50001861 -> { StargateData.id= 50001861; name= "Stargate (C0O6-K)"; solarSystemId= 30000570; position= {x = -7.235443507e+11;  y = -6.6567168e+10;  z = -2.609426227e+12;}; typeId= 29633; destinationSolarSystemId= 30000568; destinationStargateId= 50001286 } |> Some
      | 50002055 -> { StargateData.id= 50002055; name= "Stargate (UT-UZB)"; solarSystemId= 30000925; position= {x = -7.494152602e+11;  y = 2.738884608e+10;  z = -2.28834644e+12;}; typeId= 29633; destinationSolarSystemId= 30000921; destinationStargateId= 50001315 } |> Some
      | 50002152 -> { StargateData.id= 50002152; name= "Stargate (J-RXYN)"; solarSystemId= 30000593; position= {x = -1.2031488e+11;  y = -5387427840.0;  z = -3.892081828e+12;}; typeId= 29633; destinationSolarSystemId= 30000594; destinationStargateId= 50002709 } |> Some
      | 50002249 -> { StargateData.id= 50002249; name= "Stargate (I-NGI8)"; solarSystemId= 30002136; position= {x = 2.936899215e+12;  y = 5.775007334e+11;  z = 1.420774318e+12;}; typeId= 29633; destinationSolarSystemId= 30002134; destinationStargateId= 50002168 } |> Some
      | 50002346 -> { StargateData.id= 50002346; name= "Stargate (Shera)"; solarSystemId= 30004083; position= {x = -1.58033449e+12;  y = 3.093002281e+12;  z = 2.067375268e+12;}; typeId= 29626; destinationSolarSystemId= 30005192; destinationStargateId= 50000492 } |> Some
      | 50002443 -> { StargateData.id= 50002443; name= "Stargate (WU-FHQ)"; solarSystemId= 30000434; position= {x = 3.32310528e+10;  y = 2252021760.0;  z = 3.843756442e+11;}; typeId= 29633; destinationSolarSystemId= 30000433; destinationStargateId= 50001247 } |> Some
      | 50002540 -> { StargateData.id= 50002540; name= "Stargate (1-GBVE)"; solarSystemId= 30000462; position= {x = -4.82894377e+12;  y = -5.116599091e+11;  z = -3.130304717e+12;}; typeId= 29633; destinationSolarSystemId= 30000463; destinationStargateId= 50002612 } |> Some
      | 50002637 -> { StargateData.id= 50002637; name= "Stargate (X47L-Q)"; solarSystemId= 30001963; position= {x = -3.727671828e+12;  y = -5.505855898e+11;  z = -1.915370742e+12;}; typeId= 16; destinationSolarSystemId= 30001967; destinationStargateId= 50003161 } |> Some
      | 50002734 -> { StargateData.id= 50002734; name= "Stargate (R-KZK7)"; solarSystemId= 30001266; position= {x = -1.363539149e+11;  y = -1.164742656e+10;  z = -9.718691021e+11;}; typeId= 16; destinationSolarSystemId= 30001265; destinationStargateId= 50002727 } |> Some
      | 50002831 -> { StargateData.id= 50002831; name= "Stargate (N06Z-Q)"; solarSystemId= 30001091; position= {x = -9.78507817e+11;  y = 1.550530191e+12;  z = -2.195347661e+12;}; typeId= 29632; destinationSolarSystemId= 30002309; destinationStargateId= 50003001 } |> Some
      | 50002928 -> { StargateData.id= 50002928; name= "Stargate (Poinen)"; solarSystemId= 30000154; position= {x = -4.482946253e+11;  y = -4.689088512e+10;  z = -1.321484329e+12;}; typeId= 16; destinationSolarSystemId= 30000153; destinationStargateId= 50002772 } |> Some
      | 50003025 -> { StargateData.id= 50003025; name= "Stargate (4U90-Z)"; solarSystemId= 30002890; position= {x = 1.594714153e+12;  y = -3.201266074e+11;  z = 2.038159319e+12;}; typeId= 16; destinationSolarSystemId= 30002889; destinationStargateId= 50002994 } |> Some
      | 50003122 -> { StargateData.id= 50003122; name= "Stargate (F9E-KX)"; solarSystemId= 30003709; position= {x = 2.08170455e+12;  y = -2.423984824e+12;  z = -2.17786454e+12;}; typeId= 29626; destinationSolarSystemId= 30001153; destinationStargateId= 50000280 } |> Some
      | 50003219 -> { StargateData.id= 50003219; name= "Stargate (Hemin)"; solarSystemId= 30001046; position= {x = 6.413157581e+11;  y = 9.871429632e+10;  z = -8.795628749e+11;}; typeId= 29633; destinationSolarSystemId= 30001044; destinationStargateId= 50002706 } |> Some
      | 50003316 -> { StargateData.id= 50003316; name= "Stargate (JDAS-0)"; solarSystemId= 30002115; position= {x = 4.324288512e+11;  y = 4.366209024e+10;  z = 1.912993014e+12;}; typeId= 29633; destinationSolarSystemId= 30002112; destinationStargateId= 50002226 } |> Some
      | 50003413 -> { StargateData.id= 50003413; name= "Stargate (Onne)"; solarSystemId= 30004987; position= {x = 2.712716452e+12;  y = 2.243141222e+11;  z = -1.61028096e+10;}; typeId= 3875; destinationSolarSystemId= 30004990; destinationStargateId= 50007481 } |> Some
      | 50003510 -> { StargateData.id= 50003510; name= "Stargate (G-G78S)"; solarSystemId= 30001003; position= {x = 1.024743629e+12;  y = -2.4185856e+10;  z = 2.200318648e+12;}; typeId= 29633; destinationSolarSystemId= 30001002; destinationStargateId= 50002761 } |> Some
      | 50003607 -> { StargateData.id= 50003607; name= "Stargate (JTA2-2)"; solarSystemId= 30002326; position= {x = -2.296343224e+12;  y = 2.528429261e+11;  z = 2.082759844e+12;}; typeId= 3875; destinationSolarSystemId= 30002323; destinationStargateId= 50000768 } |> Some
      | 50003704 -> { StargateData.id= 50003704; name= "Stargate (Jorund)"; solarSystemId= 30001047; position= {x = 2.110032691e+11;  y = 1.059729408e+10;  z = 2.22930985e+11;}; typeId= 29633; destinationSolarSystemId= 30001046; destinationStargateId= 50003220 } |> Some
      | 50003801 -> { StargateData.id= 50003801; name= "Stargate (RIU-GC)"; solarSystemId= 30001089; position= {x = -7.246886093e+11;  y = -5.03126016e+10;  z = -1.230670602e+12;}; typeId= 3875; destinationSolarSystemId= 30001090; destinationStargateId= 50003896 } |> Some
      | 50003898 -> { StargateData.id= 50003898; name= "Stargate (XD-TOV)"; solarSystemId= 30000888; position= {x = 7.235517235e+11;  y = 2.79263232e+10;  z = 2.524000666e+11;}; typeId= 16; destinationSolarSystemId= 30000889; destinationStargateId= 50004196 } |> Some
      | 50004092 -> { StargateData.id= 50004092; name= "Stargate (LGK-VP)"; solarSystemId= 30001835; position= {x = 1.312272998e+12;  y = 1.104468787e+11;  z = 3.242309345e+12;}; typeId= 29624; destinationSolarSystemId= 30001833; destinationStargateId= 50003976 } |> Some
      | 50004189 -> { StargateData.id= 50004189; name= "Stargate (Chesoh)"; solarSystemId= 30003528; position= {x = -5.215689523e+11;  y = 2.673273201e+12;  z = -4.977595146e+12;}; typeId= 17; destinationSolarSystemId= 30003527; destinationStargateId= 50004168 } |> Some
      | 50004286 -> { StargateData.id= 50004286; name= "Stargate (L-HV5C)"; solarSystemId= 30002429; position= {x = -1.311568282e+11;  y = -2.388037632e+10;  z = -2.717468959e+12;}; typeId= 16; destinationSolarSystemId= 30002434; destinationStargateId= 50005866 } |> Some
      | 50004480 -> { StargateData.id= 50004480; name= "Stargate (KA6D-K)"; solarSystemId= 30001206; position= {x = -6.641139302e+11;  y = 1.621110006e+12;  z = 1.402509926e+12;}; typeId= 17; destinationSolarSystemId= 30001231; destinationStargateId= 50006649 } |> Some
      | 50004577 -> { StargateData.id= 50004577; name= "Stargate (Sayartchen)"; solarSystemId= 30003509; position= {x = -3.834702643e+11;  y = -6.473428992e+10;  z = 3.031114138e+11;}; typeId= 29624; destinationSolarSystemId= 30003508; destinationStargateId= 50001531 } |> Some
      | 50004674 -> { StargateData.id= 50004674; name= "Stargate (6A-FUY)"; solarSystemId= 30001133; position= {x = 1.391120425e+12;  y = -2.090091725e+11;  z = -2.542736302e+12;}; typeId= 3875; destinationSolarSystemId= 30001134; destinationStargateId= 50005078 } |> Some
      | 50004771 -> { StargateData.id= 50004771; name= "Stargate (Shastal)"; solarSystemId= 30002995; position= {x = -3.71533824e+10;  y = 1899110400.0;  z = -1.89577175e+11;}; typeId= 29624; destinationSolarSystemId= 30002999; destinationStargateId= 50009113 } |> Some
      | 50004868 -> { StargateData.id= 50004868; name= "Stargate (O31W-6)"; solarSystemId= 30002858; position= {x = -6.65833513e+11;  y = -2.963292365e+12;  z = 4.716913091e+12;}; typeId= 3874; destinationSolarSystemId= 30002851; destinationStargateId= 50000699 } |> Some
      | 50005159 -> { StargateData.id= 50005159; name= "Stargate (ND-X7X)"; solarSystemId= 30001135; position= {x = -1.405930168e+12;  y = 5.227672781e+11;  z = -4.797066486e+12;}; typeId= 29632; destinationSolarSystemId= 30003186; destinationStargateId= 50003135 } |> Some
      | 50005256 -> { StargateData.id= 50005256; name= "Stargate (2V-ZHM)"; solarSystemId= 30005117; position= {x = -1.954997576e+12;  y = 2.41222656e+11;  z = -7.845316608e+11;}; typeId= 3874; destinationSolarSystemId= 30005096; destinationStargateId= 50005171 } |> Some
      | 50005353 -> { StargateData.id= 50005353; name= "Stargate (W-16DY)"; solarSystemId= 30004823; position= {x = -1.196266906e+12;  y = -4.365348864e+10;  z = 4.615226941e+12;}; typeId= 29633; destinationSolarSystemId= 30004822; destinationStargateId= 50004935 } |> Some
      | 50005450 -> { StargateData.id= 50005450; name= "Stargate (Ostingele)"; solarSystemId= 30003794; position= {x = -9.752630477e+11;  y = -1.401870459e+12;  z = 4.132426752e+12;}; typeId= 3874; destinationSolarSystemId= 30003792; destinationStargateId= 50005550 } |> Some
      | 50005547 -> { StargateData.id= 50005547; name= "Stargate (Lachailes)"; solarSystemId= 30000030; position= {x = 1.778452685e+12;  y = -3.280634266e+11;  z = 2.010022502e+12;}; typeId= 29624; destinationSolarSystemId= 30000029; destinationStargateId= 50005227 } |> Some
      | 50005644 -> { StargateData.id= 50005644; name= "Stargate (W-RFUO)"; solarSystemId= 30000933; position= {x = 2.230474138e+12;  y = 1.089809203e+11;  z = -1.688719565e+12;}; typeId= 29633; destinationSolarSystemId= 30000932; destinationStargateId= 50005559 } |> Some
      | 50005741 -> { StargateData.id= 50005741; name= "Stargate (Nebian)"; solarSystemId= 30005032; position= {x = -2.582333891e+12;  y = 3.858886656e+10;  z = 7.978651238e+11;}; typeId= 29624; destinationSolarSystemId= 30005031; destinationStargateId= 50005696 } |> Some
      | 50005838 -> { StargateData.id= 50005838; name= "Stargate (Anila)"; solarSystemId= 30003531; position= {x = -3.900848579e+12;  y = -1.106555167e+12;  z = -1.368642478e+12;}; typeId= 17; destinationSolarSystemId= 30003515; destinationStargateId= 50001945 } |> Some
      | 50005935 -> { StargateData.id= 50005935; name= "Stargate (Paye)"; solarSystemId= 30001716; position= {x = -1.568095027e+11;  y = 2.444070912e+10;  z = -4.892475802e+11;}; typeId= 29624; destinationSolarSystemId= 30001718; destinationStargateId= 50008898 } |> Some
      | 50006032 -> { StargateData.id= 50006032; name= "Stargate (Outuni)"; solarSystemId= 30000134; position= {x = -1.044893983e+12;  y = -6.06001152e+10;  z = 7.463641498e+11;}; typeId= 16; destinationSolarSystemId= 30000135; destinationStargateId= 50007274 } |> Some
      | 50006129 -> { StargateData.id= 50006129; name= "Stargate (FBH-JN)"; solarSystemId= 30002831; position= {x = -8.525341901e+11;  y = 4.541952e+10;  z = 3.746157773e+11;}; typeId= 3875; destinationSolarSystemId= 30002827; destinationStargateId= 50000846 } |> Some
      | 50006226 -> { StargateData.id= 50006226; name= "Stargate (Doza)"; solarSystemId= 30005243; position= {x = 2.648534508e+12;  y = -5.194363822e+12;  z = 8.800929423e+12;}; typeId= 17; destinationSolarSystemId= 30005293; destinationStargateId= 50012896 } |> Some
      | 50006323 -> { StargateData.id= 50006323; name= "Stargate (BND-16)"; solarSystemId= 30002441; position= {x = -2.821721702e+11;  y = -2.630479872e+10;  z = 1.591751885e+11;}; typeId= 16; destinationSolarSystemId= 30002438; destinationStargateId= 50004362 } |> Some
      | 50006420 -> { StargateData.id= 50006420; name= "Stargate (9-XN3F)"; solarSystemId= 30002143; position= {x = 3.059516252e+12;  y = 1.380837335e+12;  z = -1.169694351e+12;}; typeId= 3877; destinationSolarSystemId= 30002159; destinationStargateId= 50006485 } |> Some
      | 50006517 -> { StargateData.id= 50006517; name= "Stargate (EZA-FM)"; solarSystemId= 30003280; position= {x = -4.753010319e+12;  y = -6.109408051e+11;  z = 1.828245504e+10;}; typeId= 3875; destinationSolarSystemId= 30003281; destinationStargateId= 50006523 } |> Some
      | 50006614 -> { StargateData.id= 50006614; name= "Stargate (Toon)"; solarSystemId= 30005213; position= {x = 9.136424141e+11;  y = 5.470973952e+10;  z = 7.098297139e+11;}; typeId= 29624; destinationSolarSystemId= 30005212; destinationStargateId= 50006584 } |> Some
      | 50006711 -> { StargateData.id= 50006711; name= "Stargate (Grinacanne)"; solarSystemId= 30002640; position= {x = 2.876971131e+12;  y = 3.500601754e+11;  z = 4.097466778e+11;}; typeId= 3875; destinationSolarSystemId= 30002636; destinationStargateId= 50004889 } |> Some
      | 50006808 -> { StargateData.id= 50006808; name= "Stargate (Iderion)"; solarSystemId= 30004104; position= {x = 7.559945011e+11;  y = 2.199894712e+12;  z = 1.019622605e+11;}; typeId= 29626; destinationSolarSystemId= 30005227; destinationStargateId= 50006233 } |> Some
      | 50006905 -> { StargateData.id= 50006905; name= "Stargate (Luromooh)"; solarSystemId= 30002259; position= {x = -1.215477473e+12;  y = -6.602256384e+10;  z = -5.565640827e+12;}; typeId= 29624; destinationSolarSystemId= 30002261; destinationStargateId= 50007881 } |> Some
      | 50007002 -> { StargateData.id= 50007002; name= "Stargate (4GQ-XQ)"; solarSystemId= 30001864; position= {x = -3.20105472e+11;  y = -2.542350336e+10;  z = 3.33179904e+11;}; typeId= 29624; destinationSolarSystemId= 30001858; destinationStargateId= 50006272 } |> Some
      | 50007099 -> { StargateData.id= 50007099; name= "Stargate (Mattere)"; solarSystemId= 30003032; position= {x = 3.688147231e+12;  y = -6.138913997e+11;  z = -1.012623483e+12;}; typeId= 3875; destinationSolarSystemId= 30003034; destinationStargateId= 50008102 } |> Some
      | 50007196 -> { StargateData.id= 50007196; name= "Stargate (0-QP56)"; solarSystemId= 30003201; position= {x = 1.373770138e+11;  y = -1325260800.0;  z = -4.547984179e+11;}; typeId= 3875; destinationSolarSystemId= 30003198; destinationStargateId= 50006620 } |> Some
      | 50007293 -> { StargateData.id= 50007293; name= "Stargate (PFP-GU)"; solarSystemId= 30003273; position= {x = 3.391667036e+12;  y = 3.045810463e+12;  z = 2.344972001e+12;}; typeId= 3874; destinationSolarSystemId= 30003295; destinationStargateId= 50009757 } |> Some
      | 50007390 -> { StargateData.id= 50007390; name= "Stargate (CT8K-0)"; solarSystemId= 30002375; position= {x = 6.586897613e+11;  y = 7564369920.0;  z = 1.872925901e+11;}; typeId= 3875; destinationSolarSystemId= 30002373; destinationStargateId= 50007166 } |> Some
      | 50007487 -> { StargateData.id= 50007487; name= "Stargate (F9O-U9)"; solarSystemId= 30000505; position= {x = 5.653390172e+12;  y = -9.447209779e+11;  z = -3.151691366e+11;}; typeId= 29633; destinationSolarSystemId= 30000500; destinationStargateId= 50005466 } |> Some
      | 50007584 -> { StargateData.id= 50007584; name= "Stargate (LA2-KV)"; solarSystemId= 30003195; position= {x = 8.572780954e+11;  y = 9.813849293e+11;  z = 1.795305923e+12;}; typeId= 3874; destinationSolarSystemId= 30003255; destinationStargateId= 50009289 } |> Some
      | 50007681 -> { StargateData.id= 50007681; name= "Stargate (E-ACV6)"; solarSystemId= 30000506; position= {x = 3.129254584e+12;  y = 5.043104563e+11;  z = -1.177644687e+12;}; typeId= 29633; destinationSolarSystemId= 30000503; destinationStargateId= 50006794 } |> Some
      | 50007778 -> { StargateData.id= 50007778; name= "Stargate (Parses)"; solarSystemId= 30003903; position= {x = 6.753134592e+11;  y = -3.723988992e+10;  z = 1.797977334e+12;}; typeId= 29624; destinationSolarSystemId= 30003909; destinationStargateId= 50008486 } |> Some
      | 50007875 -> { StargateData.id= 50007875; name= "Stargate (Agrallarier)"; solarSystemId= 30002659; position= {x = -3.344876052e+12;  y = 1.956248371e+11;  z = -1.35018025e+12;}; typeId= 3875; destinationSolarSystemId= 30002658; destinationStargateId= 50007297 } |> Some
      | 50007972 -> { StargateData.id= 50007972; name= "Stargate (Maila)"; solarSystemId= 30000163; position= {x = -2.452775854e+12;  y = -2.95815168e+10;  z = 1.921441505e+12;}; typeId= 16; destinationSolarSystemId= 30000162; destinationStargateId= 50007221 } |> Some
      | 50008069 -> { StargateData.id= 50008069; name= "Stargate (LXWN-W)"; solarSystemId= 30004333; position= {x = -1.980903383e+12;  y = 1.428019323e+12;  z = -2.409432883e+12;}; typeId= 29627; destinationSolarSystemId= 30004364; destinationStargateId= 50009477 } |> Some
      | 50008166 -> { StargateData.id= 50008166; name= "Stargate (T8H-66)"; solarSystemId= 30003946; position= {x = -6.572729549e+11;  y = -8593858560.0;  z = -2.3514001e+12;}; typeId= 29624; destinationSolarSystemId= 30003943; destinationStargateId= 50007966 } |> Some
      | 50008263 -> { StargateData.id= 50008263; name= "Stargate (Bushemal)"; solarSystemId= 30004118; position= {x = 5.71855872e+11;  y = 3.147411456e+10;  z = 4.83972096e+11;}; typeId= 29624; destinationSolarSystemId= 30004117; destinationStargateId= 50007556 } |> Some
      | 50008360 -> { StargateData.id= 50008360; name= "Stargate (Hangond)"; solarSystemId= 30005262; position= {x = -4.777762284e+12;  y = -8.67874775e+11;  z = -3.130296607e+12;}; typeId= 29624; destinationSolarSystemId= 30005265; destinationStargateId= 50008628 } |> Some
      | 50008457 -> { StargateData.id= 50008457; name= "Stargate (Ordion)"; solarSystemId= 30005059; position= {x = 1.074226913e+12;  y = -1.430459597e+11;  z = -5.168285737e+12;}; typeId= 29624; destinationSolarSystemId= 30005060; destinationStargateId= 50008518 } |> Some
      | 50008554 -> { StargateData.id= 50008554; name= "Stargate (EA-HSA)"; solarSystemId= 30002126; position= {x = -1.311531786e+12;  y = -1.540658381e+11;  z = 1.143430226e+12;}; typeId= 29633; destinationSolarSystemId= 30002124; destinationStargateId= 50005612 } |> Some
      | 50008651 -> { StargateData.id= 50008651; name= "Stargate (1BWK-S)"; solarSystemId= 30003623; position= {x = 3.037041869e+11;  y = 6.063255552e+10;  z = -2.120052326e+11;}; typeId= 16; destinationSolarSystemId= 30003624; destinationStargateId= 50008703 } |> Some
      | 50008748 -> { StargateData.id= 50008748; name= "Stargate (QCWA-Z)"; solarSystemId= 30004345; position= {x = 1.957370634e+12;  y = -2.958396211e+11;  z = -1.352474911e+12;}; typeId= 16; destinationSolarSystemId= 30004343; destinationStargateId= 50008379 } |> Some
      | 50008845 -> { StargateData.id= 50008845; name= "Stargate (SON-TW)"; solarSystemId= 30003224; position= {x = 2.678020792e+12;  y = 3.492848026e+11;  z = -3.875344343e+12;}; typeId= 3875; destinationSolarSystemId= 30003225; destinationStargateId= 50009278 } |> Some
      | 50008942 -> { StargateData.id= 50008942; name= "Stargate (Valmu)"; solarSystemId= 30003559; position= {x = 2.286352589e+12;  y = -2.915388826e+12;  z = 6.358605619e+12;}; typeId= 17; destinationSolarSystemId= 30003483; destinationStargateId= 50001051 } |> Some
      | 50009039 -> { StargateData.id= 50009039; name= "Stargate (Adrel)"; solarSystemId= 30005018; position= {x = -1.374830715e+12;  y = 8.094928896e+10;  z = 1.818507264e+11;}; typeId= 3875; destinationSolarSystemId= 30005021; destinationStargateId= 50011493 } |> Some
      | 50009136 -> { StargateData.id= 50009136; name= "Stargate (LO5-LN)"; solarSystemId= 30001120; position= {x = -6.671571763e+11;  y = -1.105368269e+11;  z = -5.955828081e+12;}; typeId= 3875; destinationSolarSystemId= 30001119; destinationStargateId= 50008902 } |> Some
      | 50009233 -> { StargateData.id= 50009233; name= "Stargate (Menri)"; solarSystemId= 30004136; position= {x = -4.008798167e+12;  y = -6.797142467e+12;  z = 3.76002601e+11;}; typeId= 17; destinationSolarSystemId= 30004121; destinationStargateId= 50009063 } |> Some
      | 50009330 -> { StargateData.id= 50009330; name= "Stargate (M2-2V1)"; solarSystemId= 30001334; position= {x = 4.012864512e+12;  y = -1.402850918e+11;  z = 5.67806976e+11;}; typeId= 16; destinationSolarSystemId= 30001332; destinationStargateId= 50007077 } |> Some
      | 50009427 -> { StargateData.id= 50009427; name= "Stargate (Tabbetzur)"; solarSystemId= 30003460; position= {x = 2.610704794e+11;  y = -4.275400704e+10;  z = -4.422177178e+11;}; typeId= 29633; destinationSolarSystemId= 30003465; destinationStargateId= 50009927 } |> Some
      | 50009524 -> { StargateData.id= 50009524; name= "Stargate (0PU2-R)"; solarSystemId= 30003250; position= {x = -1.493669069e+11;  y = -2.366066688e+10;  z = -5.80206551e+11;}; typeId= 3875; destinationSolarSystemId= 30003251; destinationStargateId= 50009810 } |> Some
      | 50009621 -> { StargateData.id= 50009621; name= "Stargate (WX-6UX)"; solarSystemId= 30003121; position= {x = -1.427023503e+12;  y = 1.13950679e+11;  z = 7.462023168e+10;}; typeId= 29624; destinationSolarSystemId= 30003120; destinationStargateId= 50009212 } |> Some
      | 50009718 -> { StargateData.id= 50009718; name= "Stargate (NIZJ-0)"; solarSystemId= 30003140; position= {x = -4.241599242e+12;  y = 7.8847488e+11;  z = -5.730786386e+12;}; typeId= 29624; destinationSolarSystemId= 30003141; destinationStargateId= 50010140 } |> Some
      | 50009815 -> { StargateData.id= 50009815; name= "Stargate (V1V-6F)"; solarSystemId= 30001891; position= {x = -2.277535457e+12;  y = 2.864923853e+11;  z = -3.099879137e+12;}; typeId= 29624; destinationSolarSystemId= 30001892; destinationStargateId= 50010053 } |> Some
      | 50009912 -> { StargateData.id= 50009912; name= "Stargate (7MMJ-3)"; solarSystemId= 30005147; position= {x = -3.135886541e+11;  y = -1.454395392e+10;  z = -3.362101617e+12;}; typeId= 3875; destinationSolarSystemId= 30005146; destinationStargateId= 50009230 } |> Some
      | 50010009 -> { StargateData.id= 50010009; name= "Stargate (1DH-SX)"; solarSystemId= 30004013; position= {x = -3.013168742e+11;  y = 5.879029064e+12;  z = 8.697804104e+12;}; typeId= 29626; destinationSolarSystemId= 30004710; destinationStargateId= 50009867 } |> Some
      | 50010106 -> { StargateData.id= 50010106; name= "Stargate (MGAM-4)"; solarSystemId= 30000320; position= {x = 1.108170056e+12;  y = 2.18668032e+11;  z = -6.364232294e+12;}; typeId= 16; destinationSolarSystemId= 30000321; destinationStargateId= 50011335 } |> Some
      | 50010203 -> { StargateData.id= 50010203; name= "Stargate (Y-YHZQ)"; solarSystemId= 30003652; position= {x = -2.474803077e+12;  y = -4.354104115e+11;  z = -5.003741184e+11;}; typeId= 16; destinationSolarSystemId= 30003651; destinationStargateId= 50010184 } |> Some
      | 50010300 -> { StargateData.id= 50010300; name= "Stargate (RV5-DW)"; solarSystemId= 30001899; position= {x = -1.478693069e+12;  y = -2.830308557e+11;  z = -6.223868314e+11;}; typeId= 29624; destinationSolarSystemId= 30001900; destinationStargateId= 50010311 } |> Some
      | 50010397 -> { StargateData.id= 50010397; name= "Stargate (Agrallarier)"; solarSystemId= 30002661; position= {x = -2.539461427e+11;  y = -1.92178176e+10;  z = -3.751082803e+11;}; typeId= 3875; destinationSolarSystemId= 30002658; destinationStargateId= 50007299 } |> Some
      | 50010494 -> { StargateData.id= 50010494; name= "Stargate (QZ-DIZ)"; solarSystemId= 30003240; position= {x = -1.35735815e+13;  y = 2.387697623e+12;  z = -6.114078351e+12;}; typeId= 3875; destinationSolarSystemId= 30003236; destinationStargateId= 50009165 } |> Some
      | 50010591 -> { StargateData.id= 50010591; name= "Stargate (T-J6HT)"; solarSystemId= 30004725; position= {x = 8.651015578e+12;  y = -8.267578982e+11;  z = 3.372970353e+12;}; typeId= 29624; destinationSolarSystemId= 30004729; destinationStargateId= 50010724 } |> Some
      | 50010688 -> { StargateData.id= 50010688; name= "Stargate (G-B3PR)"; solarSystemId= 30004890; position= {x = 3.494680781e+12;  y = -4.63415255e+11;  z = -3.69405825e+12;}; typeId= 29633; destinationSolarSystemId= 30004892; destinationStargateId= 50010959 } |> Some
      | 50010785 -> { StargateData.id= 50010785; name= "Stargate (NGM-OK)"; solarSystemId= 30005171; position= {x = 2.073531802e+12;  y = -1.011790234e+11;  z = 1.972926505e+12;}; typeId= 3875; destinationSolarSystemId= 30005170; destinationStargateId= 50010710 } |> Some
      | 50010882 -> { StargateData.id= 50010882; name= "Stargate (Augnais)"; solarSystemId= 30002681; position= {x = 4.546258944e+11;  y = 4.445097984e+10;  z = -4.544909722e+11;}; typeId= 3875; destinationSolarSystemId= 30002680; destinationStargateId= 50010435 } |> Some
      | 50010979 -> { StargateData.id= 50010979; name= "Stargate (3-JCJT)"; solarSystemId= 30004008; position= {x = -2.437055693e+11;  y = 3160104960.0;  z = 3.785950863e+12;}; typeId= 29624; destinationSolarSystemId= 30004004; destinationStargateId= 50009907 } |> Some
      | 50011076 -> { StargateData.id= 50011076; name= "Stargate (Central Point)"; solarSystemId= 30005282; position= {x = -6.845571441e+12;  y = 7.405878067e+11;  z = -4.468815913e+12;}; typeId= 29624; destinationSolarSystemId= 30005283; destinationStargateId= 50012648 } |> Some
      | 50011173 -> { StargateData.id= 50011173; name= "Stargate (PFV-ZH)"; solarSystemId= 30001796; position= {x = -1.415895982e+12;  y = 5.015245578e+12;  z = 2.943484846e+12;}; typeId= 29632; destinationSolarSystemId= 30005178; destinationStargateId= 50010518 } |> Some
      | 50011270 -> { StargateData.id= 50011270; name= "Stargate (57-YRU)"; solarSystemId= 30003351; position= {x = 2.097348895e+12;  y = 3.360901939e+11;  z = 3.233129226e+12;}; typeId= 3875; destinationSolarSystemId= 30003350; destinationStargateId= 50010386 } |> Some
      | 50011367 -> { StargateData.id= 50011367; name= "Stargate (Eszur)"; solarSystemId= 30002093; position= {x = 9.817339085e+11;  y = -1.881930547e+11;  z = -2.417847706e+12;}; typeId= 29633; destinationSolarSystemId= 30002095; destinationStargateId= 50012091 } |> Some
      | 50011464 -> { StargateData.id= 50011464; name= "Stargate (3-JG3X)"; solarSystemId= 30003234; position= {x = 3.321531187e+11;  y = -2.673168384e+10;  z = -1.307026514e+12;}; typeId= 3875; destinationSolarSystemId= 30003231; destinationStargateId= 50010211 } |> Some
      | 50011561 -> { StargateData.id= 50011561; name= "Stargate (8-YNBE)"; solarSystemId= 30004028; position= {x = 9.813153792e+11;  y = 8.156270592e+10;  z = -1.029126144e+11;}; typeId= 29624; destinationSolarSystemId= 30004025; destinationStargateId= 50010745 } |> Some
      | 50011658 -> { StargateData.id= 50011658; name= "Stargate (Yvelet)"; solarSystemId= 30003590; position= {x = -1.174431744e+11;  y = 4542259200.0;  z = 1.256134779e+12;}; typeId= 3875; destinationSolarSystemId= 30003591; destinationStargateId= 50011850 } |> Some
      | 50011755 -> { StargateData.id= 50011755; name= "Stargate (CH9L-K)"; solarSystemId= 30004397; position= {x = -3.351416832e+10;  y = 5475164160.0;  z = 8.188992307e+11;}; typeId= 16; destinationSolarSystemId= 30004401; destinationStargateId= 50012876 } |> Some
      | 50011852 -> { StargateData.id= 50011852; name= "Stargate (DBRN-Z)"; solarSystemId= 30004594; position= {x = 1.263046042e+12;  y = 1.745890099e+11;  z = -4.913982259e+11;}; typeId= 3875; destinationSolarSystemId= 30004595; destinationStargateId= 50011862 } |> Some
      | 50011949 -> { StargateData.id= 50011949; name= "Stargate (GA58-7)"; solarSystemId= 30001810; position= {x = -1.315164611e+12;  y = -2.918290637e+11;  z = -1.746491597e+12;}; typeId= 3874; destinationSolarSystemId= 30001811; destinationStargateId= 50012012 } |> Some
      | 50012046 -> { StargateData.id= 50012046; name= "Stargate (CNC-4V)"; solarSystemId= 30001256; position= {x = 1.986584986e+11;  y = -627302400.0;  z = 1.287316685e+11;}; typeId= 29624; destinationSolarSystemId= 30001254; destinationStargateId= 50011311 } |> Some
      | 50012143 -> { StargateData.id= 50012143; name= "Stargate (X-M9ON)"; solarSystemId= 30004074; position= {x = 4.669971456e+12;  y = -6.822107136e+11;  z = -4.404462797e+11;}; typeId= 3875; destinationSolarSystemId= 30004075; destinationStargateId= 50012430 } |> Some
      | 50012240 -> { StargateData.id= 50012240; name= "Stargate (3-FKCZ)"; solarSystemId= 30004022; position= {x = 3.315412992e+10;  y = 2337300480.0;  z = 5.407936512e+10;}; typeId= 29624; destinationSolarSystemId= 30004019; destinationStargateId= 50010336 } |> Some
      | 50012337 -> { StargateData.id= 50012337; name= "Stargate (5P-AIP)"; solarSystemId= 30004474; position= {x = 1.892973896e+12;  y = 1.675900109e+11;  z = -1.787297096e+12;}; typeId= 29633; destinationSolarSystemId= 30004477; destinationStargateId= 50012537 } |> Some
      | 50012434 -> { StargateData.id= 50012434; name= "Stargate (3FKU-H)"; solarSystemId= 30004901; position= {x = -4.048319078e+12;  y = -5.323272192e+10;  z = -1.552025149e+12;}; typeId= 29633; destinationSolarSystemId= 30004900; destinationStargateId= 50012352 } |> Some
      | 50012531 -> { StargateData.id= 50012531; name= "Stargate (NU4-2G)"; solarSystemId= 30004032; position= {x = 9.321286902e+12;  y = -4.399755264e+10;  z = -9.210590454e+12;}; typeId= 29624; destinationSolarSystemId= 30004035; destinationStargateId= 50012946 } |> Some
      | 50012628 -> { StargateData.id= 50012628; name= "Stargate (XUDX-A)"; solarSystemId= 30004854; position= {x = 2.59480277e+12;  y = -2.704277914e+11;  z = -3.709699277e+11;}; typeId= 29633; destinationSolarSystemId= 30004856; destinationStargateId= 50012699 } |> Some
      | 50012725 -> { StargateData.id= 50012725; name= "Stargate (0OYZ-G)"; solarSystemId= 30004484; position= {x = -4.535371776e+11;  y = 7.908175872e+10;  z = 7.690256794e+11;}; typeId= 29633; destinationSolarSystemId= 30004483; destinationStargateId= 50012477 } |> Some
      | 50012822 -> { StargateData.id= 50012822; name= "Stargate (LJ-TZW)"; solarSystemId= 30004640; position= {x = 2.698815037e+12;  y = 5.342859264e+10;  z = 1.817327739e+12;}; typeId= 3875; destinationSolarSystemId= 30004641; destinationStargateId= 50012880 } |> Some
      | 50012919 -> { StargateData.id= 50012919; name= "Stargate (Ajna)"; solarSystemId= 30004279; position= {x = 1.240417444e+12;  y = 1.805663846e+11;  z = 4.012355174e+11;}; typeId= 29624; destinationSolarSystemId= 30004277; destinationStargateId= 50012408 } |> Some
      | 50013016 -> { StargateData.id= 50013016; name= "Stargate (Sechmaren)"; solarSystemId= 30004141; position= {x = -1.532379095e+12;  y = -4.469600256e+10;  z = 5.978904576e+11;}; typeId= 29624; destinationSolarSystemId= 30004139; destinationStargateId= 50010500 } |> Some
      | 50013113 -> { StargateData.id= 50013113; name= "Stargate (NZW-ZO)"; solarSystemId= 30004862; position= {x = 1.176155382e+12;  y = -1592893440.0;  z = -1.540319232e+11;}; typeId= 29633; destinationSolarSystemId= 30004863; destinationStargateId= 50013256 } |> Some
      | 50013210 -> { StargateData.id= 50013210; name= "Stargate (HF-K3O)"; solarSystemId= 30003222; position= {x = 1.479249715e+12;  y = -1.804750848e+10;  z = -3.293695549e+12;}; typeId= 3875; destinationSolarSystemId= 30003220; destinationStargateId= 50012097 } |> Some
      | 50013307 -> { StargateData.id= 50013307; name= "Stargate (0P-U0Q)"; solarSystemId= 30004873; position= {x = 1.650231337e+12;  y = -1.281479885e+11;  z = 4.122983424e+12;}; typeId= 29633; destinationSolarSystemId= 30004874; destinationStargateId= 50013333 } |> Some
      | 50013404 -> { StargateData.id= 50013404; name= "Stargate (Fobiner)"; solarSystemId= 30004306; position= {x = 9.504277709e+11;  y = 2.168844288e+10;  z = -2.830512538e+11;}; typeId= 29624; destinationSolarSystemId= 30004303; destinationStargateId= 50013201 } |> Some
      | 50013501 -> { StargateData.id= 50013501; name= "Stargate (J-AYLV)"; solarSystemId= 30001921; position= {x = 6.350719795e+11;  y = 3.299291136e+10;  z = 6.007973069e+11;}; typeId= 29624; destinationSolarSystemId= 30001920; destinationStargateId= 50013465 } |> Some
      | 50013792 -> { StargateData.id= 50013792; name= "Stargate (X-7BIX)"; solarSystemId= 30004452; position= {x = -7.365427323e+12;  y = 3.878098084e+12;  z = -3.112181883e+12;}; typeId= 12292; destinationSolarSystemId= 30003110; destinationStargateId= 50013791 } |> Some
      | 50013889 -> { StargateData.id= 50013889; name= "Stargate (Sobaseki)"; solarSystemId= 30001393; position= {x = -1.781503181e+11;  y = -7.482579763e+11;  z = -4.717479936e+11;}; typeId= 29627; destinationSolarSystemId= 30001363; destinationStargateId= 50013890 } |> Some
      | 50013986 -> { StargateData.id= 50013986; name= "Stargate (77S8-E)"; solarSystemId= 30004878; position= {x = 2.969874801e+12;  y = -1.464998584e+12;  z = 5.687835648e+12;}; typeId= 29635; destinationSolarSystemId= 30000483; destinationStargateId= 50013985 } |> Some
      | 50014083 -> { StargateData.id= 50014083; name= "Stargate (Trytedald)"; solarSystemId= 30002524; position= {x = -6.100462387e+11;  y = -8.5410816e+10;  z = -6.628186399e+12;}; typeId= 3877; destinationSolarSystemId= 30002508; destinationStargateId= 50014084 } |> Some
      | 50014180 -> { StargateData.id= 50014180; name= "Stargate (Leurtmar)"; solarSystemId= 30023410; position= {x = -1.307771904e+12;  y = -5398732800.0;  z = -1.569906647e+12;}; typeId= 29633; destinationSolarSystemId= 30003409; destinationStargateId= 50014179 } |> Some
      | 50014277 -> { StargateData.id= 50014277; name= "Stargate (M-NP5O)"; solarSystemId= 30001559; position= {x = 1.035535688e+12;  y = 6.951800709e+12;  z = -1.615108547e+12;}; typeId= 3874; destinationSolarSystemId= 30001597; destinationStargateId= 50014278 } |> Some
      | 50016314 -> { StargateData.id= 50016314; name= "Stargate (Onnamon)"; solarSystemId= 30045326; position= {x = -4.617424527e+12;  y = -1.066157261e+11;  z = 5.544005222e+11;}; typeId= 16; destinationSolarSystemId= 30045324; destinationStargateId= 50016313 } |> Some
      | 50016508 -> { StargateData.id= 50016508; name= "Stargate (Urhinichi)"; solarSystemId= 30000192; position= {x = 6.820391199e+12;  y = -3.897512583e+11;  z = 5.884231218e+12;}; typeId= 56317; destinationSolarSystemId= 30040141; destinationStargateId= 50016549 } |> Some
      | _ -> None