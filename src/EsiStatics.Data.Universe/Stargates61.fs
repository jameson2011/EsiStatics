﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stargates61=
    let getStargate id = 
      match id with 
      | 50000069 -> { StargateData.id= 50000069; name= "Stargate (Pettinck)"; solarSystemId= 30004967; position= {x = 3.022043136e+11;  y = 3.764417126e+12;  z = 1.427882189e+12;}; typeId= 29632; destinationSolarSystemId= 30002632; destinationStargateId= 50000446 } |> Some
      | 50000166 -> { StargateData.id= 50000166; name= "Stargate (Ouranienen)"; solarSystemId= 30001368; position= {x = 6.516306862e+12;  y = -8.252054323e+11;  z = -6.199383859e+12;}; typeId= 16; destinationSolarSystemId= 30001370; destinationStargateId= 50004390 } |> Some
      | 50000263 -> { StargateData.id= 50000263; name= "Stargate (VXO-OM)"; solarSystemId= 30000918; position= {x = -1.252802273e+12;  y = 1.307897856e+10;  z = -1.359152456e+12;}; typeId= 29633; destinationSolarSystemId= 30000924; destinationStargateId= 50001597 } |> Some
      | 50000360 -> { StargateData.id= 50000360; name= "Stargate (MF-PGF)"; solarSystemId= 30002296; position= {x = 4.280877343e+12;  y = 2.146405171e+11;  z = -3.322505994e+12;}; typeId= 3875; destinationSolarSystemId= 30002299; destinationStargateId= 50002020 } |> Some
      | 50000457 -> { StargateData.id= 50000457; name= "Stargate (QNXJ-M)"; solarSystemId= 30002284; position= {x = -1.149307699e+11;  y = -6647193600.0;  z = -4.725413069e+11;}; typeId= 3875; destinationSolarSystemId= 30002288; destinationStargateId= 50002274 } |> Some
      | 50000554 -> { StargateData.id= 50000554; name= "Stargate (X97D-W)"; solarSystemId= 30000216; position= {x = -2.061048914e+12;  y = 3.753545318e+11;  z = 9.632473498e+11;}; typeId= 16; destinationSolarSystemId= 30000221; destinationStargateId= 50005011 } |> Some
      | 50000651 -> { StargateData.id= 50000651; name= "Stargate (FVXK-D)"; solarSystemId= 30000909; position= {x = 1.709789553e+12;  y = -2.900251853e+11;  z = 7.298045092e+12;}; typeId= 29633; destinationSolarSystemId= 30000906; destinationStargateId= 50000381 } |> Some
      | 50000748 -> { StargateData.id= 50000748; name= "Stargate (F-WZYG)"; solarSystemId= 30001083; position= {x = 1.059469271e+12;  y = -2.616643584e+10;  z = -1.064982897e+12;}; typeId= 3875; destinationSolarSystemId= 30001087; destinationStargateId= 50002862 } |> Some
      | 50000845 -> { StargateData.id= 50000845; name= "Stargate (BVRQ-O)"; solarSystemId= 30002827; position= {x = -4.317751296e+11;  y = 1.445965824e+10;  z = 2.274143846e+11;}; typeId= 3875; destinationSolarSystemId= 30002828; destinationStargateId= 50002529 } |> Some
      | 50000942 -> { StargateData.id= 50000942; name= "Stargate (YPW-M4)"; solarSystemId= 30000786; position= {x = 1.46764075e+12;  y = 2.848462848e+11;  z = -6.66124972e+12;}; typeId= 29633; destinationSolarSystemId= 30000784; destinationStargateId= 50000720 } |> Some
      | 50001039 -> { StargateData.id= 50001039; name= "Stargate (DAYP-G)"; solarSystemId= 30000248; position= {x = -2.639042765e+12;  y = 4.415797248e+11;  z = 4.881543537e+12;}; typeId= 16; destinationSolarSystemId= 30000253; destinationStargateId= 50002338 } |> Some
      | 50001136 -> { StargateData.id= 50001136; name= "Stargate (Vaurent)"; solarSystemId= 30003029; position= {x = 1.846390825e+12;  y = -2.66585088e+11;  z = 5.853531955e+12;}; typeId= 3875; destinationSolarSystemId= 30003027; destinationStargateId= 50000442 } |> Some
      | 50001233 -> { StargateData.id= 50001233; name= "Stargate (ARG-3R)"; solarSystemId= 30000668; position= {x = -4.944226345e+12;  y = 2.310592143e+12;  z = -4.742178447e+12;}; typeId= 3877; destinationSolarSystemId= 30000656; destinationStargateId= 50000119 } |> Some
      | 50001330 -> { StargateData.id= 50001330; name= "Stargate (4-CM8I)"; solarSystemId= 30000720; position= {x = -1.013607997e+12;  y = 6.576918528e+10;  z = 1.47332395e+12;}; typeId= 29633; destinationSolarSystemId= 30000718; destinationStargateId= 50001187 } |> Some
      | 50001427 -> { StargateData.id= 50001427; name= "Stargate (Urlen)"; solarSystemId= 30000129; position= {x = -2.9207663e+12;  y = 1.861885256e+12;  z = 3.285723955e+11;}; typeId= 29627; destinationSolarSystemId= 30000139; destinationStargateId= 50000548 } |> Some
      | 50001524 -> { StargateData.id= 50001524; name= "Stargate (D87E-A)"; solarSystemId= 30001011; position= {x = -2.281637437e+12;  y = 3.31815936e+11;  z = 1.531380572e+12;}; typeId= 29633; destinationSolarSystemId= 30001010; destinationStargateId= 50000891 } |> Some
      | 50001621 -> { StargateData.id= 50001621; name= "Stargate (1C-953)"; solarSystemId= 30000956; position= {x = 1.012357816e+12;  y = 4.14025728e+10;  z = 3.960381481e+12;}; typeId= 29633; destinationSolarSystemId= 30000963; destinationStargateId= 50004377 } |> Some
      | 50001718 -> { StargateData.id= 50001718; name= "Stargate (JMH-PT)"; solarSystemId= 30000664; position= {x = -4.794127442e+12;  y = 3.466495181e+11;  z = -6.847789056e+11;}; typeId= 29633; destinationSolarSystemId= 30000662; destinationStargateId= 50001019 } |> Some
      | 50001815 -> { StargateData.id= 50001815; name= "Stargate (KDF-GY)"; solarSystemId= 30001168; position= {x = 1.18313472e+12;  y = -1.326338458e+11;  z = 1.053203251e+11;}; typeId= 29624; destinationSolarSystemId= 30001164; destinationStargateId= 50000851 } |> Some
      | 50002009 -> { StargateData.id= 50002009; name= "Stargate (Z-EKCY)"; solarSystemId= 30002837; position= {x = 3.624238572e+12;  y = -2.45623124e+12;  z = 1.089407508e+12;}; typeId= 29632; destinationSolarSystemId= 30001097; destinationStargateId= 50002968 } |> Some
      | 50002106 -> { StargateData.id= 50002106; name= "Stargate (2XI8-Y)"; solarSystemId= 30001070; position= {x = -2.302348616e+12;  y = -4.704815309e+12;  z = 6.419976561e+12;}; typeId= 3874; destinationSolarSystemId= 30001103; destinationStargateId= 50003152 } |> Some
      | 50002203 -> { StargateData.id= 50002203; name= "Stargate (Asgeir)"; solarSystemId= 30003385; position= {x = -1.706274447e+12;  y = -2.61504983e+11;  z = -3.311622144e+11;}; typeId= 29633; destinationSolarSystemId= 30003384; destinationStargateId= 50002145 } |> Some
      | 50002300 -> { StargateData.id= 50002300; name= "Stargate (X0-6LH)"; solarSystemId= 30000810; position= {x = 5.503096627e+12;  y = -7.226945126e+11;  z = -6.302230979e+12;}; typeId= 29633; destinationSolarSystemId= 30000808; destinationStargateId= 50001545 } |> Some
      | 50002397 -> { StargateData.id= 50002397; name= "Stargate (Imeshasa)"; solarSystemId= 30001653; position= {x = -1.934190305e+12;  y = 3.070229299e+11;  z = -5.9991074e+12;}; typeId= 29624; destinationSolarSystemId= 30001655; destinationStargateId= 50003433 } |> Some
      | 50002494 -> { StargateData.id= 50002494; name= "Stargate (Harerget)"; solarSystemId= 30003018; position= {x = 1.103879578e+12;  y = -7.057158144e+10;  z = 1.949207224e+12;}; typeId= 3875; destinationSolarSystemId= 30003017; destinationStargateId= 50001787 } |> Some
      | 50002591 -> { StargateData.id= 50002591; name= "Stargate (Hemin)"; solarSystemId= 30001028; position= {x = -1.904457032e+12;  y = -1.907971277e+11;  z = 2.545431306e+12;}; typeId= 3877; destinationSolarSystemId= 30001044; destinationStargateId= 50002704 } |> Some
      | 50002688 -> { StargateData.id= 50002688; name= "Stargate (K-YL9T)"; solarSystemId= 30001569; position= {x = 1.084958552e+13;  y = 7.750711296e+11;  z = 6.877473546e+12;}; typeId= 3875; destinationSolarSystemId= 30001572; destinationStargateId= 50003272 } |> Some
      | 50002785 -> { StargateData.id= 50002785; name= "Stargate (C-62I5)"; solarSystemId= 30000548; position= {x = 3.738823188e+12;  y = 2.790961152e+10;  z = 2.93043671e+12;}; typeId= 29633; destinationSolarSystemId= 30000550; destinationStargateId= 50003605 } |> Some
      | 50002882 -> { StargateData.id= 50002882; name= "Stargate (Jaschercis)"; solarSystemId= 30003019; position= {x = -3.242041713e+12;  y = -2.043847188e+12;  z = -3.452993249e+12;}; typeId= 3874; destinationSolarSystemId= 30003029; destinationStargateId= 50001139 } |> Some
      | 50002979 -> { StargateData.id= 50002979; name= "Stargate (8B-2YA)"; solarSystemId= 30001202; position= {x = -2.822145761e+12;  y = 6.931273728e+11;  z = 3.246826168e+12;}; typeId= 17; destinationSolarSystemId= 30001219; destinationStargateId= 50003512 } |> Some
      | 50003076 -> { StargateData.id= 50003076; name= "Stargate (Asilem)"; solarSystemId= 30000102; position= {x = 2.332944015e+12;  y = 6.878072832e+10;  z = 1.787913462e+12;}; typeId= 29624; destinationSolarSystemId= 30000095; destinationStargateId= 50000211 } |> Some
      | 50003173 -> { StargateData.id= 50003173; name= "Stargate (3GD6-8)"; solarSystemId= 30001831; position= {x = -1.975739597e+11;  y = -6.994478285e+11;  z = 2.349160735e+12;}; typeId= 29626; destinationSolarSystemId= 30001200; destinationStargateId= 50002578 } |> Some
      | 50003270 -> { StargateData.id= 50003270; name= "Stargate (Gekutami)"; solarSystemId= 30000148; position= {x = 1.579458023e+13;  y = 2.641931059e+11;  z = -9.311672033e+12;}; typeId= 16; destinationSolarSystemId= 30000149; destinationStargateId= 50003661 } |> Some
      | 50003367 -> { StargateData.id= 50003367; name= "Stargate (G-7WUF)"; solarSystemId= 30001184; position= {x = -6.714445824e+10;  y = -1.002565632e+10;  z = -1.941365146e+11;}; typeId= 29624; destinationSolarSystemId= 30001183; destinationStargateId= 50003073 } |> Some
      | 50003464 -> { StargateData.id= 50003464; name= "Stargate (Dantumi)"; solarSystemId= 30001361; position= {x = -4.285401539e+12;  y = 2.294065152e+11;  z = 9.885026304e+11;}; typeId= 16; destinationSolarSystemId= 30001356; destinationStargateId= 50000024 } |> Some
      | 50003561 -> { StargateData.id= 50003561; name= "Stargate (B-2VXB)"; solarSystemId= 30002332; position= {x = 1.023927951e+12;  y = 1.535128781e+11;  z = -6.922908058e+11;}; typeId= 3875; destinationSolarSystemId= 30002334; destinationStargateId= 50003760 } |> Some
      | 50003658 -> { StargateData.id= 50003658; name= "Stargate (QHH-13)"; solarSystemId= 30001745; position= {x = 3.512324383e+12;  y = 6.144191324e+12;  z = 8.080555991e+12;}; typeId= 3874; destinationSolarSystemId= 30001749; destinationStargateId= 50004299 } |> Some
      | 50003755 -> { StargateData.id= 50003755; name= "Stargate (AOK-WQ)"; solarSystemId= 30001214; position= {x = -1.810087526e+11;  y = 228188160.0;  z = -2.283320893e+12;}; typeId= 29624; destinationSolarSystemId= 30001216; destinationStargateId= 50004871 } |> Some
      | 50003852 -> { StargateData.id= 50003852; name= "Stargate (F-D49D)"; solarSystemId= 30000277; position= {x = 2.348378112e+11;  y = 3.401945088e+10;  z = -3.928430592e+11;}; typeId= 16; destinationSolarSystemId= 30000279; destinationStargateId= 50004971 } |> Some
      | 50003949 -> { StargateData.id= 50003949; name= "Stargate (Costolle)"; solarSystemId= 30005299; position= {x = -1.624707072e+10;  y = 728064000.0;  z = -3.175256064e+10;}; typeId= 3875; destinationSolarSystemId= 30005298; destinationStargateId= 50003947 } |> Some
      | 50004046 -> { StargateData.id= 50004046; name= "Stargate (Attyn)"; solarSystemId= 30005002; position= {x = 1.444465336e+12;  y = -2.197191475e+11;  z = -6.629217485e+11;}; typeId= 3875; destinationSolarSystemId= 30005004; destinationStargateId= 50007217 } |> Some
      | 50004143 -> { StargateData.id= 50004143; name= "Stargate (TU-O0T)"; solarSystemId= 30003730; position= {x = -1.791044936e+12;  y = -9.367302144e+10;  z = 3.774641357e+11;}; typeId= 29624; destinationSolarSystemId= 30003733; destinationStargateId= 50004838 } |> Some
      | 50004531 -> { StargateData.id= 50004531; name= "Stargate (Leremblompes)"; solarSystemId= 30003014; position= {x = 7.197709517e+11;  y = -1.153171169e+12;  z = 1.039831081e+12;}; typeId= 3874; destinationSolarSystemId= 30003039; destinationStargateId= 50004900 } |> Some
      | 50004628 -> { StargateData.id= 50004628; name= "Stargate (O-LJOO)"; solarSystemId= 30002350; position= {x = -1.456846479e+12;  y = 7.158951936e+10;  z = 1.119274476e+12;}; typeId= 3875; destinationSolarSystemId= 30002351; destinationStargateId= 50004704 } |> Some
      | 50004725 -> { StargateData.id= 50004725; name= "Stargate (AY9X-Q)"; solarSystemId= 30005095; position= {x = -3.665544192e+12;  y = -6.391443456e+10;  z = -1.325690511e+12;}; typeId= 3875; destinationSolarSystemId= 30005094; destinationStargateId= 50003023 } |> Some
      | 50004822 -> { StargateData.id= 50004822; name= "Stargate (8CIX-S)"; solarSystemId= 30001297; position= {x = -6.405875712e+11;  y = 8.180355072e+10;  z = 2.326736609e+12;}; typeId= 16; destinationSolarSystemId= 30001298; destinationStargateId= 50005027 } |> Some
      | 50005016 -> { StargateData.id= 50005016; name= "Stargate (Maiah)"; solarSystemId= 30002220; position= {x = 3.146162627e+12;  y = -2.356444815e+12;  z = 6.730552074e+12;}; typeId= 17; destinationSolarSystemId= 30003546; destinationStargateId= 50006261 } |> Some
      | 50005113 -> { StargateData.id= 50005113; name= "Stargate (RWML-A)"; solarSystemId= 30001140; position= {x = -1.39305898e+12;  y = -2.81398272e+11;  z = -6.381980467e+11;}; typeId= 3875; destinationSolarSystemId= 30001142; destinationStargateId= 50007508 } |> Some
      | 50005210 -> { StargateData.id= 50005210; name= "Stargate (Hurjafren)"; solarSystemId= 30002528; position= {x = 2.545585398e+12;  y = 6.498927821e+11;  z = 3.516281856e+12;}; typeId= 3877; destinationSolarSystemId= 30002572; destinationStargateId= 50008616 } |> Some
      | 50005307 -> { StargateData.id= 50005307; name= "Stargate (9IPC-E)"; solarSystemId= 30001307; position= {x = 1.6107264e+12;  y = 4.080930816e+10;  z = 4.124161229e+11;}; typeId= 16; destinationSolarSystemId= 30001306; destinationStargateId= 50005272 } |> Some
      | 50005404 -> { StargateData.id= 50005404; name= "Stargate (Agoze)"; solarSystemId= 30003791; position= {x = 3.224972083e+11;  y = -6.212456448e+10;  z = -1.277544161e+12;}; typeId= 3875; destinationSolarSystemId= 30003787; destinationStargateId= 50004207 } |> Some
      | 50005501 -> { StargateData.id= 50005501; name= "Stargate (VBPT-T)"; solarSystemId= 30000807; position= {x = 2.292516495e+12;  y = -4.180635648e+10;  z = -1.441579868e+12;}; typeId= 29633; destinationSolarSystemId= 30000806; destinationStargateId= 50004340 } |> Some
      | 50005598 -> { StargateData.id= 50005598; name= "Stargate (MHC-R3)"; solarSystemId= 30003793; position= {x = -2.559906816e+12;  y = -4.981067981e+12;  z = -7.922691686e+11;}; typeId= 3876; destinationSolarSystemId= 30003268; destinationStargateId= 50006102 } |> Some
      | 50005695 -> { StargateData.id= 50005695; name= "Stargate (Fensi)"; solarSystemId= 30005031; position= {x = 3.640659517e+12;  y = -4.357517722e+11;  z = 9.815834419e+12;}; typeId= 29624; destinationSolarSystemId= 30005030; destinationStargateId= 50004451 } |> Some
      | 50005792 -> { StargateData.id= 50005792; name= "Stargate (D-JVGJ)"; solarSystemId= 30001758; position= {x = -2.662670623e+12;  y = 4.169612083e+11;  z = 6.823544218e+12;}; typeId= 3875; destinationSolarSystemId= 30001761; destinationStargateId= 50006214 } |> Some
      | 50005889 -> { StargateData.id= 50005889; name= "Stargate (Kusomonmon)"; solarSystemId= 30002801; position= {x = 3.666389115e+12;  y = 5.608065024e+11;  z = -2.788632576e+11;}; typeId= 16; destinationSolarSystemId= 30002802; destinationStargateId= 50006698 } |> Some
      | 50005986 -> { StargateData.id= 50005986; name= "Stargate (U-INPD)"; solarSystemId= 30001993; position= {x = -2.160704348e+12;  y = -2.961641472e+10;  z = -1.567602156e+12;}; typeId= 16; destinationSolarSystemId= 30001997; destinationStargateId= 50007335 } |> Some
      | 50006083 -> { StargateData.id= 50006083; name= "Stargate (PI5-39)"; solarSystemId= 30003736; position= {x = 2.530853069e+12;  y = -3.161271091e+11;  z = -1.097528525e+11;}; typeId= 29624; destinationSolarSystemId= 30003735; destinationStargateId= 50004833 } |> Some
      | 50006180 -> { StargateData.id= 50006180; name= "Stargate (KS8G-M)"; solarSystemId= 30001587; position= {x = 2.879175475e+11;  y = -1.78010112e+10;  z = -3.220123361e+12;}; typeId= 3875; destinationSolarSystemId= 30001589; destinationStargateId= 50006616 } |> Some
      | 50006277 -> { StargateData.id= 50006277; name= "Stargate (Kor-Azor Prime)"; solarSystemId= 30005036; position= {x = -1.866310656e+12;  y = -2.800249651e+11;  z = -5.075048448e+11;}; typeId= 29624; destinationSolarSystemId= 30005038; destinationStargateId= 50006460 } |> Some
      | 50006374 -> { StargateData.id= 50006374; name= "Stargate (Ezzara)"; solarSystemId= 30002960; position= {x = -2.351712952e+12;  y = 2.214168576e+11;  z = 3.096263762e+12;}; typeId= 29624; destinationSolarSystemId= 30002962; destinationStargateId= 50006885 } |> Some
      | 50006471 -> { StargateData.id= 50006471; name= "Stargate (Gisleres)"; solarSystemId= 30005309; position= {x = -5.749517107e+11;  y = -1.826869248e+10;  z = -1.257635144e+12;}; typeId= 3875; destinationSolarSystemId= 30005312; destinationStargateId= 50010227 } |> Some
      | 50006568 -> { StargateData.id= 50006568; name= "Stargate (ATY-2U)"; solarSystemId= 30003272; position= {x = -5.93507328e+11;  y = -1.196795904e+11;  z = 5.41157376e+10;}; typeId= 3875; destinationSolarSystemId= 30003273; destinationStargateId= 50007291 } |> Some
      | 50006665 -> { StargateData.id= 50006665; name= "Stargate (NH-1X6)"; solarSystemId= 30001240; position= {x = -1.00759425e+12;  y = -3.808014336e+10;  z = 5.432444928e+11;}; typeId= 29624; destinationSolarSystemId= 30001239; destinationStargateId= 50006449 } |> Some
      | 50006762 -> { StargateData.id= 50006762; name= "Stargate (5FCV-A)"; solarSystemId= 30000993; position= {x = 2.017101005e+11;  y = -3.834753024e+10;  z = -3.967086182e+11;}; typeId= 29633; destinationSolarSystemId= 30000992; destinationStargateId= 50006208 } |> Some
      | 50006859 -> { StargateData.id= 50006859; name= "Stargate (Ilonarav)"; solarSystemId= 30002258; position= {x = 3.090886042e+12;  y = -3.574459638e+12;  z = -6.864936346e+12;}; typeId= 17; destinationSolarSystemId= 30002208; destinationStargateId= 50005240 } |> Some
      | 50006956 -> { StargateData.id= 50006956; name= "Stargate (E-SCTX)"; solarSystemId= 30000282; position= {x = 3.53234473e+12;  y = 1.524750336e+11;  z = -1.899827159e+12;}; typeId= 16; destinationSolarSystemId= 30000283; destinationStargateId= 50007765 } |> Some
      | 50007053 -> { StargateData.id= 50007053; name= "Stargate (RT-9WL)"; solarSystemId= 30000509; position= {x = -5.648745677e+11;  y = 1.083625882e+11;  z = -1.257580831e+12;}; typeId= 29633; destinationSolarSystemId= 30000511; destinationStargateId= 50007268 } |> Some
      | 50007150 -> { StargateData.id= 50007150; name= "Stargate (Pamah)"; solarSystemId= 30005231; position= {x = -2.328163738e+12;  y = 1.470319411e+11;  z = -3.150221353e+12;}; typeId= 29624; destinationSolarSystemId= 30005232; destinationStargateId= 50007537 } |> Some
      | 50007247 -> { StargateData.id= 50007247; name= "Stargate (Osmallanais)"; solarSystemId= 30003815; position= {x = -1.012220314e+11;  y = -256450560.0;  z = 6.086576947e+11;}; typeId= 3875; destinationSolarSystemId= 30003812; destinationStargateId= 50006750 } |> Some
      | 50007344 -> { StargateData.id= 50007344; name= "Stargate (NZG-LF)"; solarSystemId= 30001873; position= {x = -1.012042015e+12;  y = 5.317226496e+10;  z = -1.644601221e+12;}; typeId= 29624; destinationSolarSystemId= 30001874; destinationStargateId= 50007499 } |> Some
      | 50007441 -> { StargateData.id= 50007441; name= "Stargate (Uriok)"; solarSystemId= 30002072; position= {x = -2.763421655e+12;  y = 3.164198093e+11;  z = -2.399738388e+12;}; typeId= 29633; destinationSolarSystemId= 30002070; destinationStargateId= 50006972 } |> Some
      | 50007538 -> { StargateData.id= 50007538; name= "Stargate (Leran)"; solarSystemId= 30005232; position= {x = 2.739818496e+10;  y = -2131845120.0;  z = 1.180288205e+11;}; typeId= 29624; destinationSolarSystemId= 30005233; destinationStargateId= 50007548 } |> Some
      | 50007635 -> { StargateData.id= 50007635; name= "Stargate (M-75WN)"; solarSystemId= 30002870; position= {x = 9.094780109e+11;  y = 5.570531328e+10;  z = -4.324653097e+12;}; typeId= 3875; destinationSolarSystemId= 30002869; destinationStargateId= 50007569 } |> Some
      | 50007732 -> { StargateData.id= 50007732; name= "Stargate (M-75WN)"; solarSystemId= 30002871; position= {x = -2.639225242e+11;  y = -3562168320.0;  z = -6.970647552e+12;}; typeId= 3875; destinationSolarSystemId= 30002869; destinationStargateId= 50007570 } |> Some
      | 50007829 -> { StargateData.id= 50007829; name= "Stargate (8KQR-O)"; solarSystemId= 30001878; position= {x = -5.067108803e+12;  y = -4.185941484e+12;  z = 8.639868518e+11;}; typeId= 17; destinationSolarSystemId= 30001887; destinationStargateId= 50008399 } |> Some
      | 50007926 -> { StargateData.id= 50007926; name= "Stargate (Floseswin)"; solarSystemId= 30002083; position= {x = -3.562457088e+11;  y = 4.631113728e+10;  z = 3.898590413e+11;}; typeId= 29633; destinationSolarSystemId= 30002082; destinationStargateId= 50007685 } |> Some
      | 50008023 -> { StargateData.id= 50008023; name= "Stargate (5V-Q1R)"; solarSystemId= 30005154; position= {x = -3.303480115e+11;  y = 2.882383872e+10;  z = 5.539384934e+11;}; typeId= 3875; destinationSolarSystemId= 30005152; destinationStargateId= 50007383 } |> Some
      | 50008120 -> { StargateData.id= 50008120; name= "Stargate (EQWO-Y)"; solarSystemId= 30004837; position= {x = -5.564335104e+12;  y = -8.546359296e+11;  z = 7.788552806e+12;}; typeId= 29633; destinationSolarSystemId= 30004835; destinationStargateId= 50007787 } |> Some
      | 50008217 -> { StargateData.id= 50008217; name= "Stargate (H1-ESN)"; solarSystemId= 30003609; position= {x = 6.796405555e+11;  y = -1.11364055e+11;  z = -7.621480858e+11;}; typeId= 16; destinationSolarSystemId= 30003608; destinationStargateId= 50008164 } |> Some
      | 50008314 -> { StargateData.id= 50008314; name= "Stargate (0-UVHJ)"; solarSystemId= 30003614; position= {x = 1.129273713e+12;  y = 1.152478003e+11;  z = 1.197240115e+12;}; typeId= 16; destinationSolarSystemId= 30003615; destinationStargateId= 50008402 } |> Some
      | 50008411 -> { StargateData.id= 50008411; name= "Stargate (CX-1XF)"; solarSystemId= 30004336; position= {x = -8.185829376e+11;  y = -9.228521472e+10;  z = -1.170187346e+12;}; typeId= 16; destinationSolarSystemId= 30004335; destinationStargateId= 50008211 } |> Some
      | 50008508 -> { StargateData.id= 50008508; name= "Stargate (Friggi)"; solarSystemId= 30000169; position= {x = -1.2951885e+12;  y = 1.110484992e+11;  z = -3.079595213e+11;}; typeId= 16; destinationSolarSystemId= 30000168; destinationStargateId= 50008052 } |> Some
      | 50008605 -> { StargateData.id= 50008605; name= "Stargate (Orvolle)"; solarSystemId= 30003831; position= {x = 1.27973929e+12;  y = 2.39564759e+11;  z = -4.635090739e+12;}; typeId= 3875; destinationSolarSystemId= 30003830; destinationStargateId= 50008581 } |> Some
      | 50008702 -> { StargateData.id= 50008702; name= "Stargate (Arton)"; solarSystemId= 30003555; position= {x = 6.315139277e+12;  y = 1.36566743e+11;  z = 3.627588403e+11;}; typeId= 29624; destinationSolarSystemId= 30003556; destinationStargateId= 50009066 } |> Some
      | 50008799 -> { StargateData.id= 50008799; name= "Stargate (1BWK-S)"; solarSystemId= 30003626; position= {x = 7.031443046e+11;  y = -1.34674391e+11;  z = -7.718413517e+11;}; typeId= 16; destinationSolarSystemId= 30003624; destinationStargateId= 50008704 } |> Some
      | 50008896 -> { StargateData.id= 50008896; name= "Stargate (XT-R36)"; solarSystemId= 30004039; position= {x = -5.384388157e+12;  y = 4.486276301e+11;  z = -1.263747195e+12;}; typeId= 3875; destinationSolarSystemId= 30004038; destinationStargateId= 50008760 } |> Some
      | 50008993 -> { StargateData.id= 50008993; name= "Stargate (Youl)"; solarSystemId= 30003496; position= {x = -4.300547236e+12;  y = 3.46395648e+11;  z = 6.964493722e+12;}; typeId= 29624; destinationSolarSystemId= 30003493; destinationStargateId= 50000833 } |> Some
      | 50009090 -> { StargateData.id= 50009090; name= "Stargate (Y-0HVF)"; solarSystemId= 30003235; position= {x = -2.704260588e+12;  y = 2.379184128e+11;  z = -1.173699256e+12;}; typeId= 3875; destinationSolarSystemId= 30003237; destinationStargateId= 50010082 } |> Some
      | 50009187 -> { StargateData.id= 50009187; name= "Stargate (YQTK-R)"; solarSystemId= 30003242; position= {x = -2.850674811e+12;  y = -5.41627392e+11;  z = -4.170376397e+11;}; typeId= 3874; destinationSolarSystemId= 30003212; destinationStargateId= 50008240 } |> Some
      | 50009478 -> { StargateData.id= 50009478; name= "Stargate (C-LP3N)"; solarSystemId= 30004364; position= {x = -3.628763136e+11;  y = 800808960.0;  z = 3.018983424e+11;}; typeId= 16; destinationSolarSystemId= 30004365; destinationStargateId= 50009724 } |> Some
      | 50009575 -> { StargateData.id= 50009575; name= "Stargate (GA9P-0)"; solarSystemId= 30003778; position= {x = 1.231661998e+12;  y = 5.796212736e+10;  z = 4.093722747e+12;}; typeId= 29624; destinationSolarSystemId= 30003777; destinationStargateId= 50009334 } |> Some
      | 50009672 -> { StargateData.id= 50009672; name= "Stargate (OCU4-R)"; solarSystemId= 30004427; position= {x = 2.708341924e+12;  y = 4.669197926e+11;  z = 8.194927411e+11;}; typeId= 29633; destinationSolarSystemId= 30004426; destinationStargateId= 50009120 } |> Some
      | 50009769 -> { StargateData.id= 50009769; name= "Stargate (Zahefeus)"; solarSystemId= 30003928; position= {x = -7.15937833e+11;  y = -1.102957363e+11;  z = -2.10304512e+12;}; typeId= 29624; destinationSolarSystemId= 30003927; destinationStargateId= 50009569 } |> Some
      | 50009866 -> { StargateData.id= 50009866; name= "Stargate (PR-8CA)"; solarSystemId= 30004710; position= {x = -1.584983654e+11;  y = 2.269925376e+10;  z = -7.878005146e+11;}; typeId= 29624; destinationSolarSystemId= 30004711; destinationStargateId= 50009909 } |> Some
      | 50009963 -> { StargateData.id= 50009963; name= "Stargate (7MMJ-3)"; solarSystemId= 30005148; position= {x = -2.85508866e+12;  y = 5.454998323e+11;  z = 1.235300475e+12;}; typeId= 3875; destinationSolarSystemId= 30005146; destinationStargateId= 50009231 } |> Some
      | 50010060 -> { StargateData.id= 50010060; name= "Stargate (Bantish)"; solarSystemId= 30005275; position= {x = 3.359748096e+10;  y = 5.172521656e+12;  z = -2.40451842e+12;}; typeId= 17; destinationSolarSystemId= 30005257; destinationStargateId= 50008305 } |> Some
      | 50010157 -> { StargateData.id= 50010157; name= "Stargate (5B-YDD)"; solarSystemId= 30001106; position= {x = -6.859538842e+11;  y = -1.099066982e+11;  z = -1.741004268e+12;}; typeId= 3875; destinationSolarSystemId= 30001104; destinationStargateId= 50005331 } |> Some
      | 50010254 -> { StargateData.id= 50010254; name= "Stargate (Gusandall)"; solarSystemId= 30002561; position= {x = -2.227192504e+12;  y = 2.480798515e+11;  z = 3.069066486e+12;}; typeId= 29633; destinationSolarSystemId= 30002556; destinationStargateId= 50006148 } |> Some
      | 50010351 -> { StargateData.id= 50010351; name= "Stargate (DCHR-L)"; solarSystemId= 30003363; position= {x = -1.247932785e+12;  y = 3.923324928e+10;  z = 3.134788116e+12;}; typeId= 3875; destinationSolarSystemId= 30003364; destinationStargateId= 50010800 } |> Some
      | 50010448 -> { StargateData.id= 50010448; name= "Stargate (RV5-DW)"; solarSystemId= 30001901; position= {x = -1.00149289e+11;  y = -1.63792896e+10;  z = 1.122522317e+11;}; typeId= 29624; destinationSolarSystemId= 30001900; destinationStargateId= 50010312 } |> Some
      | 50010545 -> { StargateData.id= 50010545; name= "Stargate (T5ZI-S)"; solarSystemId= 30004730; position= {x = 3.562567066e+12;  y = -6.286861517e+11;  z = -3.875554714e+12;}; typeId= 29624; destinationSolarSystemId= 30004735; destinationStargateId= 50010894 } |> Some
      | 50010642 -> { StargateData.id= 50010642; name= "Stargate (Heluene)"; solarSystemId= 30003595; position= {x = 3.775469691e+12;  y = -1.226046259e+11;  z = -2.514279506e+12;}; typeId= 3875; destinationSolarSystemId= 30003594; destinationStargateId= 50010510 } |> Some
      | 50010739 -> { StargateData.id= 50010739; name= "Stargate (Shemah)"; solarSystemId= 30004134; position= {x = -3.52703361e+12;  y = 5.583289836e+12;  z = -5.736324588e+12;}; typeId= 17; destinationSolarSystemId= 30004155; destinationStargateId= 50012028 } |> Some
      | 50010836 -> { StargateData.id= 50010836; name= "Stargate (Ebtesham)"; solarSystemId= 30002278; position= {x = 4.032662938e+12;  y = -1.756612608e+11;  z = 4.14722089e+11;}; typeId= 29624; destinationSolarSystemId= 30002277; destinationStargateId= 50009602 } |> Some
      | 50010933 -> { StargateData.id= 50010933; name= "Stargate (YZS5-4)"; solarSystemId= 30004584; position= {x = 2.588630753e+12;  y = -7.484204237e+11;  z = -8.729479987e+11;}; typeId= 3874; destinationSolarSystemId= 30004554; destinationStargateId= 50010669 } |> Some
      | 50011030 -> { StargateData.id= 50011030; name= "Stargate (N-M1A3)"; solarSystemId= 30004009; position= {x = 1.762207457e+12;  y = 1.764282778e+11;  z = -3.200870277e+12;}; typeId= 29624; destinationSolarSystemId= 30004011; destinationStargateId= 50011450 } |> Some
      | 50011127 -> { StargateData.id= 50011127; name= "Stargate (NHKO-4)"; solarSystemId= 30001790; position= {x = -3.859402383e+12;  y = -2.350538342e+11;  z = -1.225286984e+12;}; typeId= 3875; destinationSolarSystemId= 30001789; destinationStargateId= 50010777 } |> Some
      | 50011224 -> { StargateData.id= 50011224; name= "Stargate (3-FKCZ)"; solarSystemId= 30004020; position= {x = 1.54008662e+12;  y = 2.02399703e+11;  z = 1.823311012e+12;}; typeId= 29624; destinationSolarSystemId= 30004019; destinationStargateId= 50010335 } |> Some
      | 50011321 -> { StargateData.id= 50011321; name= "Stargate (Nuzair)"; solarSystemId= 30001667; position= {x = -1.522356756e+12;  y = -2.530223309e+11;  z = -1.426021786e+12;}; typeId= 29624; destinationSolarSystemId= 30001665; destinationStargateId= 50010282 } |> Some
      | 50011418 -> { StargateData.id= 50011418; name= "Stargate (Sazilid)"; solarSystemId= 30004268; position= {x = 8.793807667e+11;  y = 4.149891072e+10;  z = -2.367947612e+12;}; typeId= 29624; destinationSolarSystemId= 30004270; destinationStargateId= 50011452 } |> Some
      | 50011515 -> { StargateData.id= 50011515; name= "Stargate (8W-OSE)"; solarSystemId= 30003696; position= {x = 1.60134697e+12;  y = 1.537846886e+11;  z = -1.387344568e+12;}; typeId= 3875; destinationSolarSystemId= 30003695; destinationStargateId= 50011289 } |> Some
      | 50011612 -> { StargateData.id= 50011612; name= "Stargate (MJYW-3)"; solarSystemId= 30004060; position= {x = -7.24349952e+11;  y = 1.28663593e+11;  z = -6.990526464e+11;}; typeId= 3875; destinationSolarSystemId= 30004064; destinationStargateId= 50011922 } |> Some
      | 50011709 -> { StargateData.id= 50011709; name= "Stargate (UAYL-F)"; solarSystemId= 30004572; position= {x = -2.016376136e+12;  y = 1.150331658e+12;  z = -3.345884406e+12;}; typeId= 3874; destinationSolarSystemId= 30004602; destinationStargateId= 50011935 } |> Some
      | 50011806 -> { StargateData.id= 50011806; name= "Stargate (Mateber)"; solarSystemId= 30003446; position= {x = 3.259702886e+11;  y = -1.118343168e+10;  z = -2.566838231e+12;}; typeId= 29633; destinationSolarSystemId= 30003444; destinationStargateId= 50011330 } |> Some
      | 50011903 -> { StargateData.id= 50011903; name= "Stargate (J94-MU)"; solarSystemId= 30004461; position= {x = -1.883649761e+12;  y = 1.748681933e+11;  z = 6.346935091e+11;}; typeId= 29633; destinationSolarSystemId= 30004460; destinationStargateId= 50011831 } |> Some
      | 50012000 -> { StargateData.id= 50012000; name= "Stargate (57-KJB)"; solarSystemId= 30004605; position= {x = -3.979192934e+12;  y = 5.231136768e+10;  z = -2.499070894e+12;}; typeId= 3874; destinationSolarSystemId= 30004643; destinationStargateId= 50012495 } |> Some
      | 50012097 -> { StargateData.id= 50012097; name= "Stargate (Q-ITV5)"; solarSystemId= 30003220; position= {x = 1.377196646e+12;  y = -2.254038221e+11;  z = 2.995808379e+12;}; typeId= 3875; destinationSolarSystemId= 30003222; destinationStargateId= 50013210 } |> Some
      | 50012194 -> { StargateData.id= 50012194; name= "Stargate (Serpentis Prime)"; solarSystemId= 30004617; position= {x = -2.471357768e+12;  y = 2.070165504e+11;  z = -1.920264192e+11;}; typeId= 3875; destinationSolarSystemId= 30004623; destinationStargateId= 50012375 } |> Some
      | 50012291 -> { StargateData.id= 50012291; name= "Stargate (J7X-VN)"; solarSystemId= 30001802; position= {x = -4.14944981e+12;  y = 1.315257139e+11;  z = -5.151012864e+11;}; typeId= 3875; destinationSolarSystemId= 30001800; destinationStargateId= 50012083 } |> Some
      | 50012388 -> { StargateData.id= 50012388; name= "Stargate (Eggheron)"; solarSystemId= 30003604; position= {x = 2.453610455e+12;  y = -2.062760755e+11;  z = -4.667819213e+11;}; typeId= 3875; destinationSolarSystemId= 30003605; destinationStargateId= 50012763 } |> Some
      | 50012485 -> { StargateData.id= 50012485; name= "Stargate (ZS-2LT)"; solarSystemId= 30004470; position= {x = 2.899945021e+12;  y = -2.472297677e+11;  z = -3.33928575e+12;}; typeId= 29633; destinationSolarSystemId= 30004469; destinationStargateId= 50012254 } |> Some
      | 50012582 -> { StargateData.id= 50012582; name= "Stargate (28O-JY)"; solarSystemId= 30004076; position= {x = -1.690048512e+11;  y = 7064739840.0;  z = -3.013869158e+11;}; typeId= 3875; destinationSolarSystemId= 30004071; destinationStargateId= 50011490 } |> Some
      | 50012679 -> { StargateData.id= 50012679; name= "Stargate (TL-T9Z)"; solarSystemId= 30001909; position= {x = -2.95092265e+11;  y = 5.46797568e+10;  z = 2.288689275e+12;}; typeId= 29624; destinationSolarSystemId= 30001908; destinationStargateId= 50012619 } |> Some
      | 50012776 -> { StargateData.id= 50012776; name= "Stargate (G1D0-G)"; solarSystemId= 30004694; position= {x = -4.77456126e+12;  y = 8.065107149e+11;  z = -6.970114499e+12;}; typeId= 29624; destinationSolarSystemId= 30004697; destinationStargateId= 50013245 } |> Some
      | 50012873 -> { StargateData.id= 50012873; name= "Stargate (Martha)"; solarSystemId= 30004152; position= {x = -2.345113313e+12;  y = -3.062646252e+12;  z = 8.973802291e+11;}; typeId= 29626; destinationSolarSystemId= 30002194; destinationStargateId= 50004830 } |> Some
      | 50012970 -> { StargateData.id= 50012970; name= "Stargate (31X-RE)"; solarSystemId= 30004787; position= {x = 3.470756045e+12;  y = -5.550159053e+11;  z = 3.007206605e+11;}; typeId= 29624; destinationSolarSystemId= 30004786; destinationStargateId= 50012023 } |> Some
      | 50013067 -> { StargateData.id= 50013067; name= "Stargate (3SFU-S)"; solarSystemId= 30002491; position= {x = 4.211678822e+11;  y = 1.284820992e+10;  z = 1.010901688e+12;}; typeId= 16; destinationSolarSystemId= 30002486; destinationStargateId= 50010088 } |> Some
      | 50013164 -> { StargateData.id= 50013164; name= "Stargate (0B-HLZ)"; solarSystemId= 30003786; position= {x = 2.926240973e+11;  y = -4.786753536e+10;  z = 3.917727744e+11;}; typeId= 29624; destinationSolarSystemId= 30003782; destinationStargateId= 50010974 } |> Some
      | 50013261 -> { StargateData.id= 50013261; name= "Stargate (Fobiner)"; solarSystemId= 30004305; position= {x = 1.407460516e+12;  y = 9.887133696e+10;  z = -3.604916675e+12;}; typeId= 29624; destinationSolarSystemId= 30004303; destinationStargateId= 50013200 } |> Some
      | 50013358 -> { StargateData.id= 50013358; name= "Stargate (CY-ZLP)"; solarSystemId= 30003373; position= {x = 1.647401779e+11;  y = 1.654910976e+10;  z = 7.556248781e+11;}; typeId= 3875; destinationSolarSystemId= 30003371; destinationStargateId= 50013116 } |> Some
      | 50013455 -> { StargateData.id= 50013455; name= "Stargate (Mamet)"; solarSystemId= 30003564; position= {x = -3.843658752e+12;  y = -2.335581389e+11;  z = -3.170616975e+12;}; typeId= 29624; destinationSolarSystemId= 30003559; destinationStargateId= 50008947 } |> Some
      | 50013552 -> { StargateData.id= 50013552; name= "Stargate (Bittanshal)"; solarSystemId= 30003484; position= {x = 1.501182321e+12;  y = -3.756286894e+12;  z = 3.762240307e+11;}; typeId= 17; destinationSolarSystemId= 30003555; destinationStargateId= 50013551 } |> Some
      | 50013649 -> { StargateData.id= 50013649; name= "Stargate (Uanzin)"; solarSystemId= 30000065; position= {x = 4.334445773e+11;  y = -5.740309586e+12;  z = 2.789438546e+12;}; typeId= 17; destinationSolarSystemId= 30000118; destinationStargateId= 50013650 } |> Some
      | 50013843 -> { StargateData.id= 50013843; name= "Stargate (Q1U-IU)"; solarSystemId= 30004401; position= {x = 1.077737841e+12;  y = -2.842083779e+12;  z = -1.932431647e+12;}; typeId= 12292; destinationSolarSystemId= 30003669; destinationStargateId= 50013844 } |> Some
      | 50013940 -> { StargateData.id= 50013940; name= "Stargate (Eystur)"; solarSystemId= 30002545; position= {x = -1.188499046e+11;  y = -4195983360.0;  z = 8.299229061e+12;}; typeId= 29633; destinationSolarSystemId= 30002543; destinationStargateId= 50013939 } |> Some
      | 50014037 -> { StargateData.id= 50014037; name= "Stargate (F7C-H0)"; solarSystemId= 30003841; position= {x = -1.282387599e+12;  y = -1.459455713e+12;  z = 6.310899302e+11;}; typeId= 3876; destinationSolarSystemId= 30004046; destinationStargateId= 50014038 } |> Some
      | 50014134 -> { StargateData.id= 50014134; name= "Stargate (Hilaban)"; solarSystemId= 30021672; position= {x = -1.031391683e+12;  y = 1.680399974e+11;  z = -1.770525204e+12;}; typeId= 29624; destinationSolarSystemId= 30001674; destinationStargateId= 50014133 } |> Some
      | 50014231 -> { StargateData.id= 50014231; name= "Stargate (G-VFVB)"; solarSystemId= 30001565; position= {x = 2.91178967e+12;  y = 1.979680973e+12;  z = 3.621996012e+12;}; typeId= 3874; destinationSolarSystemId= 30001569; destinationStargateId= 50014232 } |> Some
      | 50016268 -> { StargateData.id= 50016268; name= "Stargate (Raihbaka)"; solarSystemId= 30001435; position= {x = 1.017227059e+12;  y = 2.090570834e+12;  z = -6.936292147e+11;}; typeId= 29629; destinationSolarSystemId= 30045315; destinationStargateId= 50016267 } |> Some
      | 50016365 -> { StargateData.id= 50016365; name= "Stargate (Hirri)"; solarSystemId= 30045353; position= {x = 1.119551078e+11;  y = 1.595756544e+10;  z = 6.35672617e+11;}; typeId= 16; destinationSolarSystemId= 30045345; destinationStargateId= 50016366 } |> Some
      | _ -> None