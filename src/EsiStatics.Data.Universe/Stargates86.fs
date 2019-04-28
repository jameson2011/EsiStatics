﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stargates86=
    let getStargate id = 
      match id with 
      | 50000094 -> { StargateData.id= 50000094; name= "Stargate (JMH-PT)"; solarSystemId= 30000655; position= {x = 3.933027164e+12;  y = -7.388116992e+11;  z = 1.626680402e+12;}; typeId= 29633; destinationSolarSystemId= 30000662; destinationStargateId= 50001018 } |> Some
      | 50000191 -> { StargateData.id= 50000191; name= "Stargate (R0-DMM)"; solarSystemId= 30000679; position= {x = 1.727256207e+12;  y = -6.067212657e+12;  z = -1.409881006e+12;}; typeId= 29635; destinationSolarSystemId= 30000563; destinationStargateId= 50001613 } |> Some
      | 50000288 -> { StargateData.id= 50000288; name= "Stargate (RNM-Y6)"; solarSystemId= 30000672; position= {x = -1.232251576e+12;  y = -9.889984512e+10;  z = 5.561484288e+12;}; typeId= 29633; destinationSolarSystemId= 30000673; destinationStargateId= 50000353 } |> Some
      | 50000482 -> { StargateData.id= 50000482; name= "Stargate (X5-0EM)"; solarSystemId= 30000778; position= {x = 4.231806566e+11;  y = -5.2608e+10;  z = 1.161790956e+12;}; typeId= 29633; destinationSolarSystemId= 30000777; destinationStargateId= 50000001 } |> Some
      | 50000579 -> { StargateData.id= 50000579; name= "Stargate (GM-0K7)"; solarSystemId= 30002129; position= {x = 7.633580483e+12;  y = -6.207854592e+11;  z = -4.123432673e+12;}; typeId= 29633; destinationSolarSystemId= 30002133; destinationStargateId= 50001769 } |> Some
      | 50000773 -> { StargateData.id= 50000773; name= "Stargate (A4B-V5)"; solarSystemId= 30002111; position= {x = -2.753715118e+12;  y = -5.505710899e+11;  z = -3.083566694e+11;}; typeId= 29633; destinationSolarSystemId= 30002113; destinationStargateId= 50002463 } |> Some
      | 50000870 -> { StargateData.id= 50000870; name= "Stargate (QSM-LM)"; solarSystemId= 30001157; position= {x = 2.788999127e+12;  y = -1.157339136e+11;  z = 8.099422618e+11;}; typeId= 17; destinationSolarSystemId= 30001163; destinationStargateId= 50000539 } |> Some
      | 50000967 -> { StargateData.id= 50000967; name= "Stargate (Sharji)"; solarSystemId= 30003501; position= {x = -2.212394557e+12;  y = 2.80285225e+11;  z = 3.308164301e+11;}; typeId= 29624; destinationSolarSystemId= 30003500; destinationStargateId= 50000178 } |> Some
      | 50001064 -> { StargateData.id= 50001064; name= "Stargate (Kehrara)"; solarSystemId= 30000097; position= {x = -1.47939201e+12;  y = 2.060172902e+11;  z = -2.501993226e+12;}; typeId= 29624; destinationSolarSystemId= 30000098; destinationStargateId= 50001875 } |> Some
      | 50001161 -> { StargateData.id= 50001161; name= "Stargate (SHBF-V)"; solarSystemId= 30000780; position= {x = -5.010457805e+11;  y = -1.625837568e+10;  z = -1.509113733e+12;}; typeId= 29633; destinationSolarSystemId= 30000779; destinationStargateId= 50001154 } |> Some
      | 50001258 -> { StargateData.id= 50001258; name= "Stargate (Enderailen)"; solarSystemId= 30002767; position= {x = 2.489690972e+12;  y = 4.29032448e+11;  z = 2.996107715e+12;}; typeId= 16; destinationSolarSystemId= 30002769; destinationStargateId= 50002678 } |> Some
      | 50001452 -> { StargateData.id= 50001452; name= "Stargate (IFJ-EL)"; solarSystemId= 30000256; position= {x = -2.05968384e+11;  y = 3.221704704e+10;  z = -4.741334753e+12;}; typeId= 16; destinationSolarSystemId= 30000254; destinationStargateId= 50000044 } |> Some
      | 50001549 -> { StargateData.id= 50001549; name= "Stargate (ETO-OT)"; solarSystemId= 30001539; position= {x = 1.87706241e+12;  y = 1.517829734e+11;  z = 2.302601503e+12;}; typeId= 3875; destinationSolarSystemId= 30001535; destinationStargateId= 50000333 } |> Some
      | 50001646 -> { StargateData.id= 50001646; name= "Stargate (K8X-6B)"; solarSystemId= 30000249; position= {x = -1.077710316e+12;  y = -1.697089536e+11;  z = -1.130838835e+11;}; typeId= 16; destinationSolarSystemId= 30000244; destinationStargateId= 50000085 } |> Some
      | 50001743 -> { StargateData.id= 50001743; name= "Stargate (Hirtamon)"; solarSystemId= 30000132; position= {x = 5.365866086e+11;  y = -6292070400.0;  z = 5.898329702e+11;}; typeId= 16; destinationSolarSystemId= 30000133; destinationStargateId= 50001774 } |> Some
      | 50001840 -> { StargateData.id= 50001840; name= "Stargate (2-KPW6)"; solarSystemId= 30000710; position= {x = -1.370157097e+12;  y = -8.223216845e+11;  z = -1.401530573e+12;}; typeId= 3877; destinationSolarSystemId= 30000684; destinationStargateId= 50002238 } |> Some
      | 50002034 -> { StargateData.id= 50002034; name= "Stargate (J7M-3W)"; solarSystemId= 30002287; position= {x = 5.661437952e+10;  y = 7108976640.0;  z = 1.043441664e+11;}; typeId= 3875; destinationSolarSystemId= 30002285; destinationStargateId= 50001848 } |> Some
      | 50002131 -> { StargateData.id= 50002131; name= "Stargate (Assah)"; solarSystemId= 30000074; position= {x = -3.359842099e+12;  y = 4.1812992e+10;  z = -4.339673088e+11;}; typeId= 29624; destinationSolarSystemId= 30000075; destinationStargateId= 50002264 } |> Some
      | 50002228 -> { StargateData.id= 50002228; name= "Stargate (B9E-H6)"; solarSystemId= 30002122; position= {x = 2.608704676e+12;  y = 1.152077414e+11;  z = -8.60100649e+11;}; typeId= 3877; destinationSolarSystemId= 30002110; destinationStargateId= 50000692 } |> Some
      | 50002422 -> { StargateData.id= 50002422; name= "Stargate (Zemalu)"; solarSystemId= 30000054; position= {x = 2.581523866e+12;  y = -3.766818816e+11;  z = -3.70966487e+11;}; typeId= 29624; destinationSolarSystemId= 30000055; destinationStargateId= 50005362 } |> Some
      | 50002519 -> { StargateData.id= 50002519; name= "Stargate (3GD6-8)"; solarSystemId= 30001199; position= {x = -1.712542556e+12;  y = 3.321349325e+11;  z = -8.668735488e+11;}; typeId= 29624; destinationSolarSystemId= 30001200; destinationStargateId= 50002575 } |> Some
      | 50002616 -> { StargateData.id= 50002616; name= "Stargate (Tolle)"; solarSystemId= 30005201; position= {x = 4.930271232e+11;  y = -3.283694346e+12;  z = -2.167724483e+12;}; typeId= 29625; destinationSolarSystemId= 30003052; destinationStargateId= 50009978 } |> Some
      | 50002713 -> { StargateData.id= 50002713; name= "Stargate (Romi)"; solarSystemId= 30003503; position= {x = -3.887677809e+12;  y = 1.109440635e+12;  z = -1.755797791e+12;}; typeId= 29626; destinationSolarSystemId= 30004080; destinationStargateId= 50000702 } |> Some
      | 50002907 -> { StargateData.id= 50002907; name= "Stargate (XA5-TY)"; solarSystemId= 30000468; position= {x = 1.046015877e+12;  y = 1.834217472e+10;  z = -5.677386547e+11;}; typeId= 29633; destinationSolarSystemId= 30000470; destinationStargateId= 50003241 } |> Some
      | 50003004 -> { StargateData.id= 50003004; name= "Stargate (Huttaken)"; solarSystemId= 30002781; position= {x = -4.919012106e+12;  y = -2.484501996e+12;  z = -2.586960814e+12;}; typeId= 29627; destinationSolarSystemId= 30002774; destinationStargateId= 50002914 } |> Some
      | 50003101 -> { StargateData.id= 50003101; name= "Stargate (H-5GUI)"; solarSystemId= 30002421; position= {x = -3.650037473e+12;  y = 3.853773742e+12;  z = 4.021599314e+12;}; typeId= 29629; destinationSolarSystemId= 30000225; destinationStargateId= 50002553 } |> Some
      | 50003198 -> { StargateData.id= 50003198; name= "Stargate (I8-AJY)"; solarSystemId= 30001109; position= {x = 4.842962657e+12;  y = -2.474366976e+11;  z = -1.790389494e+12;}; typeId= 3875; destinationSolarSystemId= 30001110; destinationStargateId= 50003212 } |> Some
      | 50003295 -> { StargateData.id= 50003295; name= "Stargate (Rauntaka)"; solarSystemId= 30001421; position= {x = 2.082701722e+11;  y = -3.57255168e+10;  z = -1.65011755e+12;}; typeId= 16; destinationSolarSystemId= 30001417; destinationStargateId= 50002858 } |> Some
      | 50003392 -> { StargateData.id= 50003392; name= "Stargate (CB4-Q2)"; solarSystemId= 30001181; position= {x = -1.60038826e+12;  y = 3.836813353e+12;  z = 3.12850944e+12;}; typeId= 17; destinationSolarSystemId= 30001205; destinationStargateId= 50003402 } |> Some
      | 50003489 -> { StargateData.id= 50003489; name= "Stargate (Aeddin)"; solarSystemId= 30002384; position= {x = 1.627795046e+11;  y = -1.077792768e+10;  z = 6.663800832e+11;}; typeId= 29633; destinationSolarSystemId= 30002383; destinationStargateId= 50003397 } |> Some
      | 50003586 -> { StargateData.id= 50003586; name= "Stargate (9-266Q)"; solarSystemId= 30001280; position= {x = -2.727983063e+12;  y = -2.629378499e+12;  z = -1.334003712e+11;}; typeId= 29627; destinationSolarSystemId= 30001273; destinationStargateId= 50003429 } |> Some
      | 50003683 -> { StargateData.id= 50003683; name= "Stargate (Frarn)"; solarSystemId= 30002525; position= {x = 5.951883387e+12;  y = -8.427035443e+11;  z = 4.280255324e+12;}; typeId= 29633; destinationSolarSystemId= 30002526; destinationStargateId= 50003925 } |> Some
      | 50003780 -> { StargateData.id= 50003780; name= "Stargate (Ebasgerdur)"; solarSystemId= 30002531; position= {x = -1.709629071e+12;  y = -1.515337728e+11;  z = 4.83632812e+12;}; typeId= 29633; destinationSolarSystemId= 30002535; destinationStargateId= 50004588 } |> Some
      | 50003877 -> { StargateData.id= 50003877; name= "Stargate (Tamo)"; solarSystemId= 30001438; position= {x = 5.742763622e+11;  y = -1.037113344e+11;  z = -7.751839334e+11;}; typeId= 16; destinationSolarSystemId= 30001437; destinationStargateId= 50003867 } |> Some
      | 50003974 -> { StargateData.id= 50003974; name= "Stargate (MB4D-4)"; solarSystemId= 30001833; position= {x = -2.680762368e+10;  y = -5043118080.0;  z = 8.460079104e+10;}; typeId= 29624; destinationSolarSystemId= 30001832; destinationStargateId= 50003488 } |> Some
      | 50004071 -> { StargateData.id= 50004071; name= "Stargate (P7-45V)"; solarSystemId= 30000637; position= {x = 2.595213681e+12;  y = -2.842328678e+11;  z = 6.075937997e+11;}; typeId= 29633; destinationSolarSystemId= 30000638; destinationStargateId= 50004114 } |> Some
      | 50004168 -> { StargateData.id= 50004168; name= "Stargate (Herila)"; solarSystemId= 30003527; position= {x = 2.28085801e+11;  y = -1.169041121e+12;  z = 2.176736993e+12;}; typeId= 17; destinationSolarSystemId= 30003528; destinationStargateId= 50004189 } |> Some
      | 50004265 -> { StargateData.id= 50004265; name= "Stargate (O7-RFZ)"; solarSystemId= 30001100; position= {x = 1.82736937e+11;  y = 2.245152768e+10;  z = -1.868892979e+11;}; typeId= 3875; destinationSolarSystemId= 30001099; destinationStargateId= 50003521 } |> Some
      | 50004362 -> { StargateData.id= 50004362; name= "Stargate (4-CUM5)"; solarSystemId= 30002438; position= {x = 6.202892698e+11;  y = 1.251924787e+11;  z = 5.112999936e+10;}; typeId= 16; destinationSolarSystemId= 30002441; destinationStargateId= 50006323 } |> Some
      | 50004459 -> { StargateData.id= 50004459; name= "Stargate (WW-KGD)"; solarSystemId= 30001976; position= {x = -9.188036198e+11;  y = -2.12046508e+12;  z = -3.431303209e+12;}; typeId= 29627; destinationSolarSystemId= 30001998; destinationStargateId= 50004624 } |> Some
      | 50004556 -> { StargateData.id= 50004556; name= "Stargate (3S-6VU)"; solarSystemId= 30000735; position= {x = -2.165428224e+10;  y = 1196728320.0;  z = -1.301103821e+11;}; typeId= 29633; destinationSolarSystemId= 30000733; destinationStargateId= 50004232 } |> Some
      | 50004653 -> { StargateData.id= 50004653; name= "Stargate (Illuin)"; solarSystemId= 30003409; position= {x = -1.254949478e+12;  y = -8.728538726e+11;  z = -9.572122214e+11;}; typeId= 3877; destinationSolarSystemId= 30003377; destinationStargateId= 50002943 } |> Some
      | 50004750 -> { StargateData.id= 50004750; name= "Stargate (Tararan)"; solarSystemId= 30002978; position= {x = -1.890981519e+12;  y = 2.936008704e+10;  z = 1.705123553e+12;}; typeId= 29624; destinationSolarSystemId= 30002979; destinationStargateId= 50004814 } |> Some
      | 50004847 -> { StargateData.id= 50004847; name= "Stargate (7R5-7R)"; solarSystemId= 30001846; position= {x = 9.764503142e+11;  y = 7.0990848e+10;  z = 5.351494042e+11;}; typeId= 29624; destinationSolarSystemId= 30001845; destinationStargateId= 50004586 } |> Some
      | 50004944 -> { StargateData.id= 50004944; name= "Stargate (Enden)"; solarSystemId= 30003422; position= {x = 2.218263306e+12;  y = -1.901703168e+10;  z = 2.525480141e+11;}; typeId= 29633; destinationSolarSystemId= 30003424; destinationStargateId= 50006654 } |> Some
      | 50005041 -> { StargateData.id= 50005041; name= "Stargate (G-AOTH)"; solarSystemId= 30001228; position= {x = -1.159931904e+11;  y = 7038443520.0;  z = -1.272630067e+11;}; typeId= 29624; destinationSolarSystemId= 30001227; destinationStargateId= 50005003 } |> Some
      | 50005138 -> { StargateData.id= 50005138; name= "Stargate (K42-IE)"; solarSystemId= 30002448; position= {x = -2.69340119e+12;  y = -2.43111936e+10;  z = 2.198400246e+12;}; typeId= 16; destinationSolarSystemId= 30002447; destinationStargateId= 50004866 } |> Some
      | 50005235 -> { StargateData.id= 50005235; name= "Stargate (Z0-TJW)"; solarSystemId= 30001305; position= {x = 2.436859085e+11;  y = -3.683733504e+10;  z = -1.054557512e+12;}; typeId= 16; destinationSolarSystemId= 30001304; destinationStargateId= 50005192 } |> Some
      | 50005332 -> { StargateData.id= 50005332; name= "Stargate (Y-XZA7)"; solarSystemId= 30001104; position= {x = 8.392544256e+10;  y = 7215390720.0;  z = -9.297426432e+11;}; typeId= 3875; destinationSolarSystemId= 30001108; destinationStargateId= 50011866 } |> Some
      | 50005429 -> { StargateData.id= 50005429; name= "Stargate (Kirras)"; solarSystemId= 30001411; position= {x = 1.435525079e+12;  y = -1.513181184e+10;  z = -4.357050778e+11;}; typeId= 16; destinationSolarSystemId= 30001410; destinationStargateId= 50002222 } |> Some
      | 50005526 -> { StargateData.id= 50005526; name= "Stargate (N-CREL)"; solarSystemId= 30002584; position= {x = -1.892303954e+12;  y = -3.267898982e+11;  z = 1.012213064e+12;}; typeId= 29633; destinationSolarSystemId= 30002583; destinationStargateId= 50005216 } |> Some
      | 50005623 -> { StargateData.id= 50005623; name= "Stargate (Avyuh)"; solarSystemId= 30005216; position= {x = -1.073741046e+12;  y = -210247680.0;  z = 2.378147635e+12;}; typeId= 29624; destinationSolarSystemId= 30005215; destinationStargateId= 50004738 } |> Some
      | 50005720 -> { StargateData.id= 50005720; name= "Stargate (Ostingele)"; solarSystemId= 30003800; position= {x = 1.553901281e+12;  y = -4.047015813e+12;  z = 1.268352e+12;}; typeId= 3874; destinationSolarSystemId= 30003792; destinationStargateId= 50005552 } |> Some
      | 50005817 -> { StargateData.id= 50005817; name= "Stargate (Atlar)"; solarSystemId= 30002396; position= {x = -2.297692201e+12;  y = 3.584129065e+12;  z = -1.013206671e+12;}; typeId= 3877; destinationSolarSystemId= 30002389; destinationStargateId= 50005376 } |> Some
      | 50005914 -> { StargateData.id= 50005914; name= "Stargate (Endrulf)"; solarSystemId= 30002555; position= {x = 3.027430072e+12;  y = -4.422479462e+11;  z = 2.462078976e+11;}; typeId= 29633; destinationSolarSystemId= 30002558; destinationStargateId= 50007819 } |> Some
      | 50006011 -> { StargateData.id= 50006011; name= "Stargate (89-JPE)"; solarSystemId= 30002347; position= {x = 2.56831746e+12;  y = 4.012903219e+11;  z = -1.037709926e+12;}; typeId= 3875; destinationSolarSystemId= 30002346; destinationStargateId= 50005843 } |> Some
      | 50006108 -> { StargateData.id= 50006108; name= "Stargate (Reblier)"; solarSystemId= 30005327; position= {x = -5.784280474e+12;  y = -6.82803241e+11;  z = 4.08167424e+11;}; typeId= 3875; destinationSolarSystemId= 30005328; destinationStargateId= 50006243 } |> Some
      | 50006205 -> { StargateData.id= 50006205; name= "Stargate (9G5J-1)"; solarSystemId= 30003191; position= {x = -4.58105131e+12;  y = 6.223591219e+12;  z = -4.687728845e+12;}; typeId= 3874; destinationSolarSystemId= 30003249; destinationStargateId= 50009198 } |> Some
      | 50006302 -> { StargateData.id= 50006302; name= "Stargate (N-7ECY)"; solarSystemId= 30002595; position= {x = -1.602094326e+12;  y = -4.857368863e+12;  z = -2.254159503e+12;}; typeId= 3877; destinationSolarSystemId= 30002612; destinationStargateId= 50006900 } |> Some
      | 50006399 -> { StargateData.id= 50006399; name= "Stargate (Sonama)"; solarSystemId= 30004102; position= {x = 7.84732201e+11;  y = 6.676156416e+10;  z = -1.391432909e+11;}; typeId= 29624; destinationSolarSystemId= 30004099; destinationStargateId= 50006333 } |> Some
      | 50006496 -> { StargateData.id= 50006496; name= "Stargate (Assez)"; solarSystemId= 30005228; position= {x = -1.490715894e+12;  y = -2.951662387e+11;  z = -2.364215009e+12;}; typeId= 29624; destinationSolarSystemId= 30005224; destinationStargateId= 50005783 } |> Some
      | 50006593 -> { StargateData.id= 50006593; name= "Stargate (F-QQ5N)"; solarSystemId= 30000576; position= {x = 1.814860186e+11;  y = 2769592320.0;  z = -8.06234112e+10;}; typeId= 29633; destinationSolarSystemId= 30000572; destinationStargateId= 50001660 } |> Some
      | 50006690 -> { StargateData.id= 50006690; name= "Stargate (Sazre)"; solarSystemId= 30003864; position= {x = -1.312679977e+12;  y = -8.339017728e+10;  z = -1.497018778e+11;}; typeId= 29624; destinationSolarSystemId= 30003865; destinationStargateId= 50006719 } |> Some
      | 50006787 -> { StargateData.id= 50006787; name= "Stargate (2R-CRW)"; solarSystemId= 30002904; position= {x = 4.22643585e+12;  y = -1.838372045e+11;  z = -4.115731046e+12;}; typeId= 16; destinationSolarSystemId= 30002905; destinationStargateId= 50006834 } |> Some
      | 50006884 -> { StargateData.id= 50006884; name= "Stargate (EWN-2U)"; solarSystemId= 30004313; position= {x = -3.717574656e+10;  y = -5405614080.0;  z = 1.890143846e+11;}; typeId= 16; destinationSolarSystemId= 30004314; destinationStargateId= 50006894 } |> Some
      | 50006981 -> { StargateData.id= 50006981; name= "Stargate (QG3-Z0)"; solarSystemId= 30001768; position= {x = 1.080261587e+13;  y = -1.480024105e+12;  z = 9.645729423e+12;}; typeId= 3875; destinationSolarSystemId= 30001772; destinationStargateId= 50007410 } |> Some
      | 50007078 -> { StargateData.id= 50007078; name= "Stargate (Sankkasen)"; solarSystemId= 30002784; position= {x = -2.702235648e+11;  y = 1.81721088e+10;  z = -4.108476826e+11;}; typeId= 16; destinationSolarSystemId= 30002783; destinationStargateId= 50005447 } |> Some
      | 50007175 -> { StargateData.id= 50007175; name= "Stargate (Sinid)"; solarSystemId= 30001730; position= {x = 4.779885773e+11;  y = -8.258973696e+10;  z = 5.86889257e+11;}; typeId= 29624; destinationSolarSystemId= 30001729; destinationStargateId= 50006054 } |> Some
      | 50007272 -> { StargateData.id= 50007272; name= "Stargate (E8-YS9)"; solarSystemId= 30002161; position= {x = 4.952471593e+12;  y = -9.618074419e+11;  z = 2.438397542e+11;}; typeId= 29633; destinationSolarSystemId= 30002163; destinationStargateId= 50009857 } |> Some
      | 50007369 -> { StargateData.id= 50007369; name= "Stargate (Kamio)"; solarSystemId= 30002786; position= {x = 9.703525171e+11;  y = -1.592331878e+11;  z = 1.319458529e+12;}; typeId= 16; destinationSolarSystemId= 30002782; destinationStargateId= 50003959 } |> Some
      | 50007466 -> { StargateData.id= 50007466; name= "Stargate (Croleur)"; solarSystemId= 30002701; position= {x = 5.661360538e+11;  y = -4.886581248e+10;  z = -3.22932695e+11;}; typeId= 3875; destinationSolarSystemId= 30002705; destinationStargateId= 50012361 } |> Some
      | 50007563 -> { StargateData.id= 50007563; name= "Stargate (Aghesi)"; solarSystemId= 30002222; position= {x = 7.407875727e+12;  y = -2.203785216e+11;  z = 6.851247022e+12;}; typeId= 29624; destinationSolarSystemId= 30002220; destinationStargateId= 50005018 } |> Some
      | 50007660 -> { StargateData.id= 50007660; name= "Stargate (Oppold)"; solarSystemId= 30003431; position= {x = -1.830178775e+12;  y = 1.189265818e+11;  z = -3.856395264e+12;}; typeId= 29633; destinationSolarSystemId= 30003430; destinationStargateId= 50006724 } |> Some
      | 50007757 -> { StargateData.id= 50007757; name= "Stargate (Sahdil)"; solarSystemId= 30002260; position= {x = 1.979411374e+12;  y = -3.004429517e+11;  z = 2.42302636e+12;}; typeId= 29624; destinationSolarSystemId= 30002259; destinationStargateId= 50006904 } |> Some
      | 50007854 -> { StargateData.id= 50007854; name= "Stargate (P-2TTL)"; solarSystemId= 30002031; position= {x = -2.300666266e+11;  y = 9855098880.0;  z = 4.765793894e+11;}; typeId= 16; destinationSolarSystemId= 30002030; destinationStargateId= 50007444 } |> Some
      | 50007951 -> { StargateData.id= 50007951; name= "Stargate (XW-2XP)"; solarSystemId= 30004329; position= {x = 6.136933171e+11;  y = -6.348458803e+11;  z = -2.641682473e+12;}; typeId= 29627; destinationSolarSystemId= 30004320; destinationStargateId= 50007867 } |> Some
      | 50008048 -> { StargateData.id= 50008048; name= "Stargate (U9U-TQ)"; solarSystemId= 30002165; position= {x = 3.625097503e+12;  y = -1.450995302e+11;  z = 7.216409764e+12;}; typeId= 29633; destinationSolarSystemId= 30002166; destinationStargateId= 50009533 } |> Some
      | 50008145 -> { StargateData.id= 50008145; name= "Stargate (XQ-PXU)"; solarSystemId= 30002003; position= {x = -2.015980339e+11;  y = -3.82568448e+10;  z = 4.31290368e+10;}; typeId= 16; destinationSolarSystemId= 30001999; destinationStargateId= 50007532 } |> Some
      | 50008242 -> { StargateData.id= 50008242; name= "Stargate (Z-ENUD)"; solarSystemId= 30005133; position= {x = -1.000431821e+12;  y = -2.01064489e+11;  z = -2.309491507e+11;}; typeId= 3875; destinationSolarSystemId= 30005132; destinationStargateId= 50008017 } |> Some
      | 50008339 -> { StargateData.id= 50008339; name= "Stargate (Lisbaetanne)"; solarSystemId= 30005006; position= {x = -4.408121549e+12;  y = -3.279287501e+11;  z = 3.231945155e+12;}; typeId= 3875; destinationSolarSystemId= 30005007; destinationStargateId= 50010119 } |> Some
      | 50008436 -> { StargateData.id= 50008436; name= "Stargate (Tegheon)"; solarSystemId= 30003916; position= {x = 1.681753989e+12;  y = 6.983580672e+12;  z = -1.348651635e+13;}; typeId= 17; destinationSolarSystemId= 30003907; destinationStargateId= 50008114 } |> Some
      | 50008533 -> { StargateData.id= 50008533; name= "Stargate (Bittanshal)"; solarSystemId= 30003554; position= {x = -1.727757066e+12;  y = -2.86173143e+11;  z = -6.057072108e+12;}; typeId= 29624; destinationSolarSystemId= 30003555; destinationStargateId= 50008701 } |> Some
      | 50008630 -> { StargateData.id= 50008630; name= "Stargate (OJ-CT4)"; solarSystemId= 30001342; position= {x = -5.298586829e+11;  y = 5.575888896e+10;  z = -8.341204992e+10;}; typeId= 16; destinationSolarSystemId= 30001341; destinationStargateId= 50008389 } |> Some
      | 50008727 -> { StargateData.id= 50008727; name= "Stargate (Yeder)"; solarSystemId= 30001714; position= {x = -9.465376358e+11;  y = -1.36853545e+11;  z = 1.037377413e+12;}; typeId= 29624; destinationSolarSystemId= 30001710; destinationStargateId= 50006165 } |> Some
      | 50008824 -> { StargateData.id= 50008824; name= "Stargate (P-ZMZV)"; solarSystemId= 30003953; position= {x = -1.73481431e+12;  y = -9.63684311e+11;  z = -3.138578964e+12;}; typeId= 17; destinationSolarSystemId= 30003978; destinationStargateId= 50009096 } |> Some
      | 50008921 -> { StargateData.id= 50008921; name= "Stargate (Dantbeinn)"; solarSystemId= 30003447; position= {x = -3.272757658e+11;  y = -6.186749952e+10;  z = -9.095846707e+11;}; typeId= 29633; destinationSolarSystemId= 30003451; destinationStargateId= 50013499 } |> Some
      | 50009018 -> { StargateData.id= 50009018; name= "Stargate (0T-AMZ)"; solarSystemId= 30004500; position= {x = 9.14788393e+11;  y = -6.476362998e+12;  z = -8.616442675e+11;}; typeId= 29632; destinationSolarSystemId= 30003349; destinationStargateId= 50009150 } |> Some
      | 50009115 -> { StargateData.id= 50009115; name= "Stargate (Lower Debyl)"; solarSystemId= 30002999; position= {x = 9.496399872e+10;  y = 1.590349824e+10;  z = 3.109001011e+12;}; typeId= 29624; destinationSolarSystemId= 30002996; destinationStargateId= 50005596 } |> Some
      | 50009212 -> { StargateData.id= 50009212; name= "Stargate (BZ-0GW)"; solarSystemId= 30003120; position= {x = 2.366816133e+12;  y = -2.938487194e+11;  z = -1.11104127e+12;}; typeId= 29624; destinationSolarSystemId= 30003121; destinationStargateId= 50009621 } |> Some
      | 50009309 -> { StargateData.id= 50009309; name= "Stargate (P-2TTL)"; solarSystemId= 30002034; position= {x = 8.17758167e+11;  y = 4.537700352e+10;  z = 1.739699282e+12;}; typeId= 16; destinationSolarSystemId= 30002030; destinationStargateId= 50007447 } |> Some
      | 50009406 -> { StargateData.id= 50009406; name= "Stargate (TZL-WT)"; solarSystemId= 30002495; position= {x = 1.748030669e+11;  y = -2.748936192e+10;  z = 2.123385938e+12;}; typeId= 16; destinationSolarSystemId= 30002494; destinationStargateId= 50008189 } |> Some
      | 50009503 -> { StargateData.id= 50009503; name= "Stargate (Aliette)"; solarSystemId= 30002696; position= {x = 4.446876426e+12;  y = -4.015804416e+10;  z = -1.621669356e+12;}; typeId= 3875; destinationSolarSystemId= 30002698; destinationStargateId= 50012895 } |> Some
      | 50009600 -> { StargateData.id= 50009600; name= "Stargate (8-GE2P)"; solarSystemId= 30003996; position= {x = 1.036792259e+12;  y = -1822679040.0;  z = 3.467139932e+12;}; typeId= 29624; destinationSolarSystemId= 30004001; destinationStargateId= 50010454 } |> Some
      | 50009697 -> { StargateData.id= 50009697; name= "Stargate (BF-SDP)"; solarSystemId= 30004508; position= {x = 3.154711142e+12;  y = 7.348492984e+12;  z = 3.155974963e+11;}; typeId= 3874; destinationSolarSystemId= 30004506; destinationStargateId= 50009592 } |> Some
      | 50009794 -> { StargateData.id= 50009794; name= "Stargate (RKE-CP)"; solarSystemId= 30003650; position= {x = -3.972770611e+11;  y = -1.33217538e+12;  z = 2.201300582e+11;}; typeId= 29627; destinationSolarSystemId= 30003626; destinationStargateId= 50008802 } |> Some
      | 50009891 -> { StargateData.id= 50009891; name= "Stargate (Porsharrah)"; solarSystemId= 30002271; position= {x = -1.039933809e+12;  y = 1.049347277e+11;  z = -1.626039214e+12;}; typeId= 29624; destinationSolarSystemId= 30002273; destinationStargateId= 50010221 } |> Some
      | 50009988 -> { StargateData.id= 50009988; name= "Stargate (NJ4X-S)"; solarSystemId= 30000897; position= {x = -7.383536026e+11;  y = -8.774725632e+10;  z = 2.178701353e+12;}; typeId= 16; destinationSolarSystemId= 30000896; destinationStargateId= 50008842 } |> Some
      | 50010085 -> { StargateData.id= 50010085; name= "Stargate (Z-MO29)"; solarSystemId= 30003152; position= {x = -9.77874985e+11;  y = 3.135501312e+12;  z = -6.67711488e+10;}; typeId= 17; destinationSolarSystemId= 30003154; destinationStargateId= 50010147 } |> Some
      | 50010182 -> { StargateData.id= 50010182; name= "Stargate (PFV-ZH)"; solarSystemId= 30005177; position= {x = -5.476000973e+11;  y = 1.065690317e+11;  z = -1.026046771e+11;}; typeId= 3875; destinationSolarSystemId= 30005178; destinationStargateId= 50010516 } |> Some
      | 50010279 -> { StargateData.id= 50010279; name= "Stargate (QXQ-BA)"; solarSystemId= 30004355; position= {x = 1.587601121e+12;  y = 3.148358861e+11;  z = -1.36511361e+12;}; typeId= 16; destinationSolarSystemId= 30004354; destinationStargateId= 50010214 } |> Some
      | 50010376 -> { StargateData.id= 50010376; name= "Stargate (O-MCZR)"; solarSystemId= 30004667; position= {x = -8.620261786e+11;  y = 1.053864346e+11;  z = -1.633204224e+11;}; typeId= 29624; destinationSolarSystemId= 30004671; destinationStargateId= 50010487 } |> Some
      | 50010473 -> { StargateData.id= 50010473; name= "Stargate (Aset)"; solarSystemId= 30002088; position= {x = 2.943557837e+12;  y = 5.727148032e+11;  z = -5.372086272e+11;}; typeId= 29633; destinationSolarSystemId= 30002084; destinationStargateId= 50008506 } |> Some
      | 50010570 -> { StargateData.id= 50010570; name= "Stargate (Schmaeel)"; solarSystemId= 30005068; position= {x = -1.735978967e+12;  y = -2.327586816e+11;  z = -6.692571955e+11;}; typeId= 29624; destinationSolarSystemId= 30005063; destinationStargateId= 50009793 } |> Some
      | 50010667 -> { StargateData.id= 50010667; name= "Stargate (G06-8Y)"; solarSystemId= 30003641; position= {x = 5.611875901e+12;  y = 6.007442227e+11;  z = 6.661335859e+11;}; typeId= 16; destinationSolarSystemId= 30003636; destinationStargateId= 50009616 } |> Some
      | 50010764 -> { StargateData.id= 50010764; name= "Stargate (DCJ-ZT)"; solarSystemId= 30003645; position= {x = 3.822444134e+11;  y = -7.265169408e+10;  z = -1.811485041e+12;}; typeId= 16; destinationSolarSystemId= 30003644; destinationStargateId= 50009741 } |> Some
      | 50010861 -> { StargateData.id= 50010861; name= "Stargate (MMR-LZ)"; solarSystemId= 30001911; position= {x = -7.30469376e+11;  y = 4.587466752e+10;  z = 1.956675133e+12;}; typeId= 29624; destinationSolarSystemId= 30001913; destinationStargateId= 50011943 } |> Some
      | 50010958 -> { StargateData.id= 50010958; name= "Stargate (Amasiree)"; solarSystemId= 30003847; position= {x = -2.413278413e+11;  y = -1.578774528e+10;  z = 8.674501018e+11;}; typeId= 3875; destinationSolarSystemId= 30003848; destinationStargateId= 50011853 } |> Some
      | 50011055 -> { StargateData.id= 50011055; name= "Stargate (5BTK-M)"; solarSystemId= 30004760; position= {x = -1.393309901e+12;  y = -4.09208832e+10;  z = -3.390012211e+11;}; typeId= 29624; destinationSolarSystemId= 30004761; destinationStargateId= 50011152 } |> Some
      | 50011152 -> { StargateData.id= 50011152; name= "Stargate (8WA-Z6)"; solarSystemId= 30004761; position= {x = 1.785946522e+11;  y = -4705689600.0;  z = -1.775069798e+12;}; typeId= 29624; destinationSolarSystemId= 30004760; destinationStargateId= 50011055 } |> Some
      | 50011249 -> { StargateData.id= 50011249; name= "Stargate (Sagain)"; solarSystemId= 30001720; position= {x = -1.706328515e+12;  y = -6.796652544e+10;  z = 5.597212262e+11;}; typeId= 29624; destinationSolarSystemId= 30001719; destinationStargateId= 50010991 } |> Some
      | 50011346 -> { StargateData.id= 50011346; name= "Stargate (APM-6K)"; solarSystemId= 30004582; position= {x = 6.620660122e+11;  y = 1.243229798e+11;  z = 8.201938944e+11;}; typeId= 3875; destinationSolarSystemId= 30004576; destinationStargateId= 50011149 } |> Some
      | 50011443 -> { StargateData.id= 50011443; name= "Stargate (O7-VJ5)"; solarSystemId= 30002178; position= {x = 2.0175693e+12;  y = -3.452464742e+11;  z = -2.26031874e+12;}; typeId= 29633; destinationSolarSystemId= 30002179; destinationStargateId= 50011759 } |> Some
      | 50011540 -> { StargateData.id= 50011540; name= "Stargate (F76-8Q)"; solarSystemId= 30002151; position= {x = -9.339652915e+11;  y = -4.955344896e+10;  z = -8.603086848e+10;}; typeId= 29633; destinationSolarSystemId= 30002152; destinationStargateId= 50011613 } |> Some
      | 50011637 -> { StargateData.id= 50011637; name= "Stargate (Mantenault)"; solarSystemId= 30003854; position= {x = -2.326899548e+12;  y = -1.842768691e+11;  z = 5.113420308e+12;}; typeId= 3875; destinationSolarSystemId= 30003855; destinationStargateId= 50012288 } |> Some
      | 50011734 -> { StargateData.id= 50011734; name= "Stargate (Arnstur)"; solarSystemId= 30002067; position= {x = 2.071681966e+12;  y = 2.678652518e+11;  z = 3.138245222e+12;}; typeId= 29633; destinationSolarSystemId= 30002064; destinationStargateId= 50008719 } |> Some
      | 50011831 -> { StargateData.id= 50011831; name= "Stargate (M2GJ-X)"; solarSystemId= 30004460; position= {x = 2.154778829e+12;  y = 3.491745792e+10;  z = 3.999954125e+11;}; typeId= 29633; destinationSolarSystemId= 30004461; destinationStargateId= 50011903 } |> Some
      | 50011928 -> { StargateData.id= 50011928; name= "Stargate (QE2-FS)"; solarSystemId= 30003219; position= {x = 2.783240602e+11;  y = -3.705950208e+10;  z = -1.164581315e+12;}; typeId= 3875; destinationSolarSystemId= 30003221; destinationStargateId= 50013138 } |> Some
      | 50012025 -> { StargateData.id= 50012025; name= "Stargate (M2GJ-X)"; solarSystemId= 30004462; position= {x = 1.716864983e+12;  y = 3.163681997e+11;  z = 2.233225912e+12;}; typeId= 29633; destinationSolarSystemId= 30004461; destinationStargateId= 50011904 } |> Some
      | 50012122 -> { StargateData.id= 50012122; name= "Stargate (IZ-AOB)"; solarSystemId= 30004534; position= {x = 1.71173929e+11;  y = 2.502955008e+10;  z = -5.471563776e+10;}; typeId= 3875; destinationSolarSystemId= 30004535; destinationStargateId= 50012166 } |> Some
      | 50012219 -> { StargateData.id= 50012219; name= "Stargate (3T7-M8)"; solarSystemId= 30002936; position= {x = -8.958138163e+12;  y = -3.425823252e+12;  z = -3.617716224e+11;}; typeId= 29627; destinationSolarSystemId= 30002938; destinationStargateId= 50012438 } |> Some
      | 50012316 -> { StargateData.id= 50012316; name= "Stargate (JL-ZUQ)"; solarSystemId= 30001592; position= {x = 3.275266867e+11;  y = -4.701990912e+10;  z = 1.697200128e+11;}; typeId= 3875; destinationSolarSystemId= 30001593; destinationStargateId= 50012329 } |> Some
      | 50012413 -> { StargateData.id= 50012413; name= "Stargate (9GNS-2)"; solarSystemId= 30004799; position= {x = -8.081362944e+10;  y = 732979200.0;  z = 1.807971533e+11;}; typeId= 29624; destinationSolarSystemId= 30004796; destinationStargateId= 50012153 } |> Some
      | 50012510 -> { StargateData.id= 50012510; name= "Stargate (J9-5MQ)"; solarSystemId= 30004389; position= {x = 1.525538611e+12;  y = -2.320808755e+11;  z = -2.583608156e+12;}; typeId= 16; destinationSolarSystemId= 30004385; destinationStargateId= 50011216 } |> Some
      | 50012607 -> { StargateData.id= 50012607; name= "Stargate (JU-UYK)"; solarSystemId= 30001938; position= {x = 3.806408294e+11;  y = 6.314323968e+10;  z = 8.557462733e+11;}; typeId= 29624; destinationSolarSystemId= 30001937; destinationStargateId= 50011068 } |> Some
      | 50012704 -> { StargateData.id= 50012704; name= "Stargate (25S-6P)"; solarSystemId= 30001257; position= {x = -8.791006003e+11;  y = -1.380496589e+11;  z = 1.742290084e+12;}; typeId= 29624; destinationSolarSystemId= 30001258; destinationStargateId= 50012964 } |> Some
      | 50012801 -> { StargateData.id= 50012801; name= "Stargate (PEM-LC)"; solarSystemId= 30004908; position= {x = 1.288978883e+12;  y = -2.079420826e+11;  z = 2.696250778e+12;}; typeId= 29633; destinationSolarSystemId= 30004906; destinationStargateId= 50012694 } |> Some
      | 50012898 -> { StargateData.id= 50012898; name= "Stargate (Agal)"; solarSystemId= 30005293; position= {x = 1.717652152e+12;  y = 9.006698496e+10;  z = -7.578415104e+10;}; typeId= 29624; destinationSolarSystemId= 30005292; destinationStargateId= 50012872 } |> Some
      | 50012995 -> { StargateData.id= 50012995; name= "Stargate (I-7JR4)"; solarSystemId= 30004402; position= {x = -1.589702124e+12;  y = -2.722528051e+11;  z = -2.53147435e+12;}; typeId= 16; destinationSolarSystemId= 30004400; destinationStargateId= 50012481 } |> Some
      | 50013092 -> { StargateData.id= 50013092; name= "Stargate (Atonder)"; solarSystemId= 30003458; position= {x = -7.990521446e+11;  y = -1.193055437e+11;  z = 3.145837363e+11;}; typeId= 29633; destinationSolarSystemId= 30003455; destinationStargateId= 50010195 } |> Some
      | 50013189 -> { StargateData.id= 50013189; name= "Stargate (48I1-X)"; solarSystemId= 30004952; position= {x = -3.695985869e+11;  y = -3.889926144e+10;  z = -2.953048351e+12;}; typeId= 29624; destinationSolarSystemId= 30004949; destinationStargateId= 50013015 } |> Some
      | 50013286 -> { StargateData.id= 50013286; name= "Stargate (5J-UEX)"; solarSystemId= 30001953; position= {x = -3.9975936e+10;  y = 4668579840.0;  z = -2.858258842e+11;}; typeId= 29624; destinationSolarSystemId= 30001951; destinationStargateId= 50013240 } |> Some
      | 50013383 -> { StargateData.id= 50013383; name= "Stargate (2-RSC7)"; solarSystemId= 30004489; position= {x = -9.886368154e+11;  y = 1.66549463e+11;  z = -1.973371085e+12;}; typeId= 29633; destinationSolarSystemId= 30004492; destinationStargateId= 50013506 } |> Some
      | 50013480 -> { StargateData.id= 50013480; name= "Stargate (66-PMM)"; solarSystemId= 30004925; position= {x = 1.678691082e+12;  y = 3.232428442e+11;  z = -2.512003523e+12;}; typeId= 29633; destinationSolarSystemId= 30004923; destinationStargateId= 50013411 } |> Some
      | 50013577 -> { StargateData.id= 50013577; name= "Stargate (XG-D1L)"; solarSystemId= 30004076; position= {x = 1.34620459e+12;  y = -1.798111273e+12;  z = 6.939828634e+11;}; typeId= 3874; destinationSolarSystemId= 30004069; destinationStargateId= 50013578 } |> Some
      | 50013674 -> { StargateData.id= 50013674; name= "Stargate (Egmar)"; solarSystemId= 30002066; position= {x = -2.379254538e+12;  y = 3.773540229e+12;  z = -4.369436221e+12;}; typeId= 3877; destinationSolarSystemId= 30002099; destinationStargateId= 50013673 } |> Some
      | 50013771 -> { StargateData.id= 50013771; name= "Stargate (6Q-R50)"; solarSystemId= 30004708; position= {x = -1.162846495e+12;  y = -8.118582067e+11;  z = 1.850259825e+12;}; typeId= 12292; destinationSolarSystemId= 30004740; destinationStargateId= 50013772 } |> Some
      | 50013965 -> { StargateData.id= 50013965; name= "Stargate (Kemerk)"; solarSystemId= 30005201; position= {x = -1.042603622e+11;  y = -1.338052608e+10;  z = 2.489896428e+12;}; typeId= 29624; destinationSolarSystemId= 30005206; destinationStargateId= 50013966 } |> Some
      | 50014062 -> { StargateData.id= 50014062; name= "Stargate (Auga)"; solarSystemId= 30003068; position= {x = 1.237946573e+12;  y = 8.254722048e+10;  z = 5.384843796e+12;}; typeId= 29625; destinationSolarSystemId= 30002542; destinationStargateId= 50014061 } |> Some
      | 50014159 -> { StargateData.id= 50014159; name= "Stargate (Clellinon)"; solarSystemId= 30005316; position= {x = 4.467421594e+11;  y = -4.101156864e+10;  z = 1.903436882e+12;}; typeId= 3875; destinationSolarSystemId= 30045305; destinationStargateId= 50014160 } |> Some
      | 50014256 -> { StargateData.id= 50014256; name= "Stargate (QE2-FS)"; solarSystemId= 30005175; position= {x = -8.737405747e+11;  y = 3.350867927e+12;  z = 2.409535119e+12;}; typeId= 29632; destinationSolarSystemId= 30003221; destinationStargateId= 50014255 } |> Some
      | 50016293 -> { StargateData.id= 50016293; name= "Stargate (Aldranette)"; solarSystemId= 30045344; position= {x = -2.776254013e+12;  y = 5.636866253e+12;  z = 6.516613571e+12;}; typeId= 3873; destinationSolarSystemId= 30003837; destinationStargateId= 50016294 } |> Some
      | 50016487 -> { StargateData.id= 50016487; name= "Stargate (Siseide)"; solarSystemId= 30002095; position= {x = -2.125678645e+11;  y = -1.745836259e+10;  z = 2.648298079e+11;}; typeId= 29635; destinationSolarSystemId= 30002539; destinationStargateId= 50016486 } |> Some
      | _ -> None