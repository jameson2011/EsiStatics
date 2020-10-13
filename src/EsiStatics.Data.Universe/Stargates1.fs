﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stargates1=
    let getStargate id = 
      match id with 
      | 50000009 -> { StargateData.id= 50000009; name= "Stargate (7-JT09)"; solarSystemId= 30000756; position= {x = -3.828575846e+11;  y = 3.50754816e+10;  z = -9.261305856e+10;}; typeId= 29633; destinationSolarSystemId= 30000759; destinationStargateId= 50000293 } |> Some
      | 50000203 -> { StargateData.id= 50000203; name= "Stargate (Joamma)"; solarSystemId= 30004084; position= {x = 3.07045847e+12;  y = 9.799839744e+10;  z = -1.075313418e+12;}; typeId= 29624; destinationSolarSystemId= 30004086; destinationStargateId= 50003315 } |> Some
      | 50000300 -> { StargateData.id= 50000300; name= "Stargate (Jayneleb)"; solarSystemId= 30000017; position= {x = 5.966452777e+12;  y = 9.25848576e+11;  z = -1.231914148e+12;}; typeId= 29624; destinationSolarSystemId= 30000022; destinationStargateId= 50001978 } |> Some
      | 50000397 -> { StargateData.id= 50000397; name= "Stargate (VK6-EZ)"; solarSystemId= 30001526; position= {x = 1.706308362e+12;  y = 2.185958646e+12;  z = 1.059351613e+13;}; typeId= 3874; destinationSolarSystemId= 30001566; destinationStargateId= 50001573 } |> Some
      | 50000494 -> { StargateData.id= 50000494; name= "Stargate (Kamda)"; solarSystemId= 30005192; position= {x = 9.527098982e+11;  y = -3.179679375e+12;  z = 1.437915587e+12;}; typeId= 29626; destinationSolarSystemId= 30004115; destinationStargateId= 50012974 } |> Some
      | 50000688 -> { StargateData.id= 50000688; name= "Stargate (DG-8VJ)"; solarSystemId= 30000455; position= {x = 3.489517978e+11;  y = -1.218103665e+12;  z = -3.995267604e+12;}; typeId= 3877; destinationSolarSystemId= 30000441; destinationStargateId= 50001507 } |> Some
      | 50000785 -> { StargateData.id= 50000785; name= "Stargate (Dresi)"; solarSystemId= 30004081; position= {x = 3.257273426e+12;  y = -3.378530304e+11;  z = 5.167208448e+11;}; typeId= 29624; destinationSolarSystemId= 30004078; destinationStargateId= 50000040 } |> Some
      | 50000882 -> { StargateData.id= 50000882; name= "Stargate (N-FK87)"; solarSystemId= 30000853; position= {x = 3.173637366e+12;  y = -4.593985905e+12;  z = 1.131867218e+12;}; typeId= 29627; destinationSolarSystemId= 30000862; destinationStargateId= 50000991 } |> Some
      | 50000979 -> { StargateData.id= 50000979; name= "Stargate (K-XJJT)"; solarSystemId= 30001541; position= {x = 9.899334451e+11;  y = -5.897121792e+10;  z = 9.125276467e+11;}; typeId= 3875; destinationSolarSystemId= 30001543; destinationStargateId= 50002894 } |> Some
      | 50001173 -> { StargateData.id= 50001173; name= "Stargate (Arnatele)"; solarSystemId= 30003010; position= {x = -1.776019907e+12;  y = 2.042822246e+11;  z = -4.134334464e+10;}; typeId= 3875; destinationSolarSystemId= 30003009; destinationStargateId= 50000016 } |> Some
      | 50001270 -> { StargateData.id= 50001270; name= "Stargate (Saatuban)"; solarSystemId= 30001389; position= {x = 8.073047654e+11;  y = 1.05648169e+11;  z = 6.743404954e+11;}; typeId= 16; destinationSolarSystemId= 30001386; destinationStargateId= 50000004 } |> Some
      | 50001367 -> { StargateData.id= 50001367; name= "Stargate (Otelen)"; solarSystemId= 30003066; position= {x = -6.543260467e+11;  y = 4.853428224e+10;  z = -2.771424092e+12;}; typeId= 29624; destinationSolarSystemId= 30003065; destinationStargateId= 50000974 } |> Some
      | 50001464 -> { StargateData.id= 50001464; name= "Stargate (Riramia)"; solarSystemId= 30001652; position= {x = -4.022096241e+12;  y = 8.03908608e+11;  z = 6.67144151e+11;}; typeId= 29624; destinationSolarSystemId= 30001650; destinationStargateId= 50001024 } |> Some
      | 50001561 -> { StargateData.id= 50001561; name= "Stargate (E1F-LK)"; solarSystemId= 30002130; position= {x = 7.42189056e+10;  y = -3871825920.0;  z = 5.002467779e+12;}; typeId= 29633; destinationSolarSystemId= 30002136; destinationStargateId= 50002248 } |> Some
      | 50001658 -> { StargateData.id= 50001658; name= "Stargate (1-7B6D)"; solarSystemId= 30000572; position= {x = 8.503206298e+11;  y = -9.486348288e+10;  z = -1.114691052e+12;}; typeId= 29633; destinationSolarSystemId= 30000573; destinationStargateId= 50002692 } |> Some
      | 50001755 -> { StargateData.id= 50001755; name= "Stargate (ZLO3-V)"; solarSystemId= 30000448; position= {x = 1.215520236e+12;  y = -9.324883968e+10;  z = -3.780129178e+11;}; typeId= 29633; destinationSolarSystemId= 30000449; destinationStargateId= 50002423 } |> Some
      | 50001852 -> { StargateData.id= 50001852; name= "Stargate (Ides)"; solarSystemId= 30003514; position= {x = -5.443587686e+11;  y = 1.315319808e+10;  z = 4.435956941e+11;}; typeId= 29624; destinationSolarSystemId= 30003513; destinationStargateId= 50001804 } |> Some
      | 50001949 -> { StargateData.id= 50001949; name= "Stargate (WU-FHQ)"; solarSystemId= 30000458; position= {x = -1.483849114e+12;  y = -5.811871334e+11;  z = -1.514231808e+11;}; typeId= 3877; destinationSolarSystemId= 30000433; destinationStargateId= 50001246 } |> Some
      | 50002046 -> { StargateData.id= 50002046; name= "Stargate (P65-TA)"; solarSystemId= 30001540; position= {x = 2.930104934e+12;  y = -2.741045699e+12;  z = 1.813491425e+12;}; typeId= 3874; destinationSolarSystemId= 30001568; destinationStargateId= 50002377 } |> Some
      | 50002143 -> { StargateData.id= 50002143; name= "Stargate (D87E-A)"; solarSystemId= 30001012; position= {x = 3.0739968e+11;  y = 4.9757184e+10;  z = 5.777226547e+11;}; typeId= 29633; destinationSolarSystemId= 30001010; destinationStargateId= 50000892 } |> Some
      | 50002240 -> { StargateData.id= 50002240; name= "Stargate (Kassigainen)"; solarSystemId= 30004972; position= {x = 7.763576832e+11;  y = 1.680369869e+12;  z = 3.585004954e+12;}; typeId= 3876; destinationSolarSystemId= 30002761; destinationStargateId= 50000743 } |> Some
      | 50002337 -> { StargateData.id= 50002337; name= "Stargate (KRUN-N)"; solarSystemId= 30000253; position= {x = -7.660376064e+10;  y = 1.190572032e+10;  z = -1.099275878e+11;}; typeId= 16; destinationSolarSystemId= 30000246; destinationStargateId= 50000319 } |> Some
      | 50002434 -> { StargateData.id= 50002434; name= "Stargate (Madirmilire)"; solarSystemId= 30003502; position= {x = -2.686440038e+12;  y = 3.410864947e+11;  z = 2.792717476e+12;}; typeId= 29624; destinationSolarSystemId= 30003503; destinationStargateId= 50002714 } |> Some
      | 50002531 -> { StargateData.id= 50002531; name= "Stargate (QI-S9W)"; solarSystemId= 30002138; position= {x = -1.614777999e+12;  y = 4.786059264e+11;  z = -1.230012826e+11;}; typeId= 3877; destinationSolarSystemId= 30002104; destinationStargateId= 50000611 } |> Some
      | 50002628 -> { StargateData.id= 50002628; name= "Stargate (CI4M-T)"; solarSystemId= 30000950; position= {x = -1.912129905e+12;  y = 1.838032896e+11;  z = 1.378430362e+12;}; typeId= 29633; destinationSolarSystemId= 30000951; destinationStargateId= 50002695 } |> Some
      | 50002725 -> { StargateData.id= 50002725; name= "Stargate (DFTK-D)"; solarSystemId= 30001556; position= {x = 1.70671104e+11;  y = -6116843520.0;  z = 7.683439411e+11;}; typeId= 3875; destinationSolarSystemId= 30001557; destinationStargateId= 50002946 } |> Some
      | 50002822 -> { StargateData.id= 50002822; name= "Stargate (9-F0B2)"; solarSystemId= 30003705; position= {x = -7.115140424e+12;  y = -4.43844649e+11;  z = 7.789272146e+12;}; typeId= 29624; destinationSolarSystemId= 30003704; destinationStargateId= 50002729 } |> Some
      | 50002919 -> { StargateData.id= 50002919; name= "Stargate (VI2K-J)"; solarSystemId= 30000227; position= {x = 2.704555254e+12;  y = 3.16618838e+12;  z = 1.485313352e+12;}; typeId= 29627; destinationSolarSystemId= 30000295; destinationStargateId= 50004001 } |> Some
      | 50003016 -> { StargateData.id= 50003016; name= "Stargate (Kronsur)"; solarSystemId= 30002520; position= {x = -1.792888136e+12;  y = 2.13003264e+11;  z = 1.260248801e+12;}; typeId= 29633; destinationSolarSystemId= 30002519; destinationStargateId= 50002966 } |> Some
      | 50003113 -> { StargateData.id= 50003113; name= "Stargate (E4-E8W)"; solarSystemId= 30001530; position= {x = 7.817515008e+10;  y = -1.138962432e+10;  z = 3.775377039e+12;}; typeId= 3875; destinationSolarSystemId= 30001527; destinationStargateId= 50001313 } |> Some
      | 50003210 -> { StargateData.id= 50003210; name= "Stargate (O-8SOC)"; solarSystemId= 30000979; position= {x = -3.89681025e+12;  y = 5.810959565e+11;  z = 3.551481569e+12;}; typeId= 29633; destinationSolarSystemId= 30000982; destinationStargateId= 50003752 } |> Some
      | 50003307 -> { StargateData.id= 50003307; name= "Stargate (Z-A8FS)"; solarSystemId= 30000596; position= {x = -2.66535678e+12;  y = 3.57306409e+11;  z = -3.137664983e+12;}; typeId= 29633; destinationSolarSystemId= 30000597; destinationStargateId= 50003789 } |> Some
      | 50003404 -> { StargateData.id= 50003404; name= "Stargate (WJ-9YO)"; solarSystemId= 30001205; position= {x = -1.74079488e+12;  y = -6.131970048e+10;  z = 3.736709407e+12;}; typeId= 29624; destinationSolarSystemId= 30001207; destinationStargateId= 50007364 } |> Some
      | 50003598 -> { StargateData.id= 50003598; name= "Stargate (EL8-4Q)"; solarSystemId= 30001972; position= {x = 1.444698808e+12;  y = -2.742766387e+11;  z = 3.020327731e+11;}; typeId= 16; destinationSolarSystemId= 30001970; destinationStargateId= 50003381 } |> Some
      | 50003695 -> { StargateData.id= 50003695; name= "Stargate (6NJ8-V)"; solarSystemId= 30001286; position= {x = -1.081388114e+12;  y = 6.710194176e+10;  z = 6.080496845e+11;}; typeId= 16; destinationSolarSystemId= 30001290; destinationStargateId= 50004701 } |> Some
      | 50003792 -> { StargateData.id= 50003792; name= "Stargate (Hagilur)"; solarSystemId= 30002052; position= {x = 7.066300416e+10;  y = -1936220160.0;  z = 6.200119296e+10;}; typeId= 29633; destinationSolarSystemId= 30002050; destinationStargateId= 50003143 } |> Some
      | 50003986 -> { StargateData.id= 50003986; name= "Stargate (Gekutami)"; solarSystemId= 30000151; position= {x = 2.295593165e+12;  y = -4.162008269e+11;  z = -7.645636608e+11;}; typeId= 16; destinationSolarSystemId= 30000149; destinationStargateId= 50003662 } |> Some
      | 50004083 -> { StargateData.id= 50004083; name= "Stargate (H-HWQR)"; solarSystemId= 30004813; position= {x = -4.112019456e+10;  y = -1385472000.0;  z = -6.159314534e+11;}; typeId= 29633; destinationSolarSystemId= 30004814; destinationStargateId= 50004397 } |> Some
      | 50004180 -> { StargateData.id= 50004180; name= "Stargate (2EV-BA)"; solarSystemId= 30001748; position= {x = -1.795374981e+12;  y = -3.132158362e+11;  z = -6.158368358e+11;}; typeId= 3875; destinationSolarSystemId= 30001746; destinationStargateId= 50003714 } |> Some
      | 50004277 -> { StargateData.id= 50004277; name= "Stargate (OR-7N5)"; solarSystemId= 30000606; position= {x = 7.088869786e+11;  y = 3.395506176e+10;  z = -2.572661146e+11;}; typeId= 29633; destinationSolarSystemId= 30000607; destinationStargateId= 50004594 } |> Some
      | 50004471 -> { StargateData.id= 50004471; name= "Stargate (Hysera)"; solarSystemId= 30002795; position= {x = -9.738663936e+11;  y = -1.14075648e+10;  z = -1.025142743e+12;}; typeId= 16; destinationSolarSystemId= 30002796; destinationStargateId= 50004916 } |> Some
      | 50004568 -> { StargateData.id= 50004568; name= "Stargate (Saranen)"; solarSystemId= 30001441; position= {x = -3.106211021e+11;  y = 619683840.0;  z = 2.685359309e+11;}; typeId= 16; destinationSolarSystemId= 30001442; destinationStargateId= 50005378 } |> Some
      | 50004665 -> { StargateData.id= 50004665; name= "Stargate (Fredagod)"; solarSystemId= 30003416; position= {x = -1.506629837e+12;  y = -2.74507776e+10;  z = -4.807194624e+11;}; typeId= 29633; destinationSolarSystemId= 30003420; destinationStargateId= 50007205 } |> Some
      | 50004762 -> { StargateData.id= 50004762; name= "Stargate (Uhtafal)"; solarSystemId= 30000103; position= {x = -7.076786135e+12;  y = 2.258336563e+11;  z = -2.307344425e+12;}; typeId= 29624; destinationSolarSystemId= 30000101; destinationStargateId= 50002926 } |> Some
      | 50004859 -> { StargateData.id= 50004859; name= "Stargate (T-RPFU)"; solarSystemId= 30001232; position= {x = -3.179207762e+12;  y = -2.12466389e+12;  z = -1.2486912e+12;}; typeId= 29626; destinationSolarSystemId= 30003715; destinationStargateId= 50004709 } |> Some
      | 50005053 -> { StargateData.id= 50005053; name= "Stargate (SH1-6P)"; solarSystemId= 30000870; position= {x = -1.664532111e+12;  y = -1.779067699e+11;  z = 3.715939123e+11;}; typeId= 16; destinationSolarSystemId= 30000868; destinationStargateId= 50002595 } |> Some
      | 50005150 -> { StargateData.id= 50005150; name= "Stargate (4CJ-AC)"; solarSystemId= 30000794; position= {x = -6.719428608e+11;  y = 6.483652608e+10;  z = -7.593474048e+11;}; typeId= 29633; destinationSolarSystemId= 30000795; destinationStargateId= 50006738 } |> Some
      | 50005247 -> { StargateData.id= 50005247; name= "Stargate (Tamekamur)"; solarSystemId= 30003401; position= {x = -3.947869102e+12;  y = -7.353602458e+11;  z = 1.040275169e+12;}; typeId= 29633; destinationSolarSystemId= 30003407; destinationStargateId= 50007448 } |> Some
      | 50005344 -> { StargateData.id= 50005344; name= "Stargate (AY-YCU)"; solarSystemId= 30003742; position= {x = -1.174578831e+12;  y = 4.96674816e+10;  z = 2.339700326e+11;}; typeId= 29624; destinationSolarSystemId= 30003746; destinationStargateId= 50007159 } |> Some
      | 50005441 -> { StargateData.id= 50005441; name= "Stargate (Hedion)"; solarSystemId= 30002196; position= {x = -1.004665651e+11;  y = -7366778880.0;  z = 2.133176525e+12;}; typeId= 29624; destinationSolarSystemId= 30002189; destinationStargateId= 50000800 } |> Some
      | 50005538 -> { StargateData.id= 50005538; name= "Stargate (Silen)"; solarSystemId= 30000175; position= {x = -4.961654784e+11;  y = -2.733379584e+10;  z = 2.033562624e+12;}; typeId= 16; destinationSolarSystemId= 30000179; destinationStargateId= 50008889 } |> Some
      | 50005635 -> { StargateData.id= 50005635; name= "Stargate (WU9-ZR)"; solarSystemId= 30002345; position= {x = 7.508615578e+11;  y = 7432888320.0;  z = -3.041169408e+10;}; typeId= 3875; destinationSolarSystemId= 30002348; destinationStargateId= 50006197 } |> Some
      | 50005732 -> { StargateData.id= 50005732; name= "Stargate (Fredagod)"; solarSystemId= 30003418; position= {x = 6.002863718e+11;  y = -4889763840.0;  z = -5.323015373e+11;}; typeId= 29633; destinationSolarSystemId= 30003420; destinationStargateId= 50007206 } |> Some
      | 50005829 -> { StargateData.id= 50005829; name= "Stargate (3GXF-U)"; solarSystemId= 30003750; position= {x = 1.008147456e+12;  y = 3324764160.0;  z = 2.114101125e+12;}; typeId= 29624; destinationSolarSystemId= 30003748; destinationStargateId= 50005412 } |> Some
      | 50005926 -> { StargateData.id= 50005926; name= "Stargate (F-5WYK)"; solarSystemId= 30001586; position= {x = -5.0966016e+11;  y = -1.259171389e+12;  z = -6.990528922e+11;}; typeId= 29632; destinationSolarSystemId= 30005103; destinationStargateId= 50004690 } |> Some
      | 50006023 -> { StargateData.id= 50006023; name= "Stargate (WVJU-4)"; solarSystemId= 30001141; position= {x = 1.440732365e+11;  y = 2.904625152e+10;  z = 1.492010189e+11;}; typeId= 3875; destinationSolarSystemId= 30001140; destinationStargateId= 50005112 } |> Some
      | 50006120 -> { StargateData.id= 50006120; name= "Stargate (Danyana)"; solarSystemId= 30004097; position= {x = -9.163563418e+11;  y = 2.028620145e+12;  z = -1.266929787e+12;}; typeId= 29626; destinationSolarSystemId= 30005044; destinationStargateId= 50006369 } |> Some
      | 50006314 -> { StargateData.id= 50006314; name= "Stargate (B-E3KQ)"; solarSystemId= 30000308; position= {x = -1.442539315e+12;  y = 1.994687693e+11;  z = -3.604698317e+11;}; typeId= 16; destinationSolarSystemId= 30000307; destinationStargateId= 50006259 } |> Some
      | 50006411 -> { StargateData.id= 50006411; name= "Stargate (Magiko)"; solarSystemId= 30002568; position= {x = 2.548711956e+12;  y = -4.695246029e+11;  z = -8.665326797e+11;}; typeId= 29633; destinationSolarSystemId= 30002570; destinationStargateId= 50007049 } |> Some
      | 50006508 -> { StargateData.id= 50006508; name= "Stargate (Parts)"; solarSystemId= 30005009; position= {x = -2.774805258e+12;  y = -2.62411137e+12;  z = -1.742857421e+11;}; typeId= 3874; destinationSolarSystemId= 30004998; destinationStargateId= 50005922 } |> Some
      | 50006605 -> { StargateData.id= 50006605; name= "Stargate (Berta)"; solarSystemId= 30000110; position= {x = 7.686715392e+11;  y = 1.544565965e+11;  z = 2.53773484e+12;}; typeId= 29624; destinationSolarSystemId= 30000109; destinationStargateId= 50006305 } |> Some
      | 50006702 -> { StargateData.id= 50006702; name= "Stargate (ZVN5-H)"; solarSystemId= 30003282; position= {x = -3.641043763e+11;  y = -7.073353851e+12;  z = 4.578105385e+12;}; typeId= 3874; destinationSolarSystemId= 30003272; destinationStargateId= 50006565 } |> Some
      | 50006799 -> { StargateData.id= 50006799; name= "Stargate (Hror)"; solarSystemId= 30002056; position= {x = 7.12522199e+12;  y = 1.308579471e+12;  z = 1.590442979e+13;}; typeId= 29633; destinationSolarSystemId= 30002054; destinationStargateId= 50004580 } |> Some
      | 50006896 -> { StargateData.id= 50006896; name= "Stargate (Horaka)"; solarSystemId= 30002398; position= {x = 1.833973801e+12;  y = 1.618871501e+11;  z = 5.92078848e+10;}; typeId= 29633; destinationSolarSystemId= 30002397; destinationStargateId= 50006169 } |> Some
      | 50006993 -> { StargateData.id= 50006993; name= "Stargate (JK-Q77)"; solarSystemId= 30004833; position= {x = -1.501966049e+12;  y = 1.901531136e+10;  z = -2.493453066e+12;}; typeId= 29633; destinationSolarSystemId= 30004836; destinationStargateId= 50007868 } |> Some
      | 50007090 -> { StargateData.id= 50007090; name= "Stargate (R1O-GN)"; solarSystemId= 30002876; position= {x = 1.116958679e+12;  y = -1.854223565e+11;  z = -2.216668324e+12;}; typeId= 3875; destinationSolarSystemId= 30002874; destinationStargateId= 50006826 } |> Some
      | 50007187 -> { StargateData.id= 50007187; name= "Stargate (Lanngisi)"; solarSystemId= 30002071; position= {x = 6.041547203e+12;  y = 1.24653527e+11;  z = 1.7808913e+13;}; typeId= 29633; destinationSolarSystemId= 30002074; destinationStargateId= 50008317 } |> Some
      | 50007284 -> { StargateData.id= 50007284; name= "Stargate (Ronne)"; solarSystemId= 30003085; position= {x = -2.740550246e+12;  y = 8.108740608e+10;  z = 8.289311539e+11;}; typeId= 29624; destinationSolarSystemId= 30003081; destinationStargateId= 50006588 } |> Some
      | 50007381 -> { StargateData.id= 50007381; name= "Stargate (C6CG-W)"; solarSystemId= 30005152; position= {x = -8.987616461e+11;  y = 3.592795054e+12;  z = 5.019523031e+12;}; typeId= 3874; destinationSolarSystemId= 30005122; destinationStargateId= 50006815 } |> Some
      | 50007478 -> { StargateData.id= 50007478; name= "Stargate (I-9GI1)"; solarSystemId= 30000518; position= {x = -1.774746378e+12;  y = 2.683046707e+11;  z = 2.248292475e+12;}; typeId= 29633; destinationSolarSystemId= 30000520; destinationStargateId= 50007666 } |> Some
      | 50007575 -> { StargateData.id= 50007575; name= "Stargate (D-I9HJ)"; solarSystemId= 30002482; position= {x = -1.942868091e+12;  y = -6.04944384e+10;  z = -3.044296827e+12;}; typeId= 16; destinationSolarSystemId= 30002481; destinationStargateId= 50007459 } |> Some
      | 50007672 -> { StargateData.id= 50007672; name= "Stargate (Kaira)"; solarSystemId= 30003886; position= {x = 8.377380864e+10;  y = -1.190301696e+10;  z = -2.159124357e+12;}; typeId= 29624; destinationSolarSystemId= 30003887; destinationStargateId= 50007697 } |> Some
      | 50007769 -> { StargateData.id= 50007769; name= "Stargate (MHC-R3)"; solarSystemId= 30003275; position= {x = 3649904640.0;  y = -697098240.0;  z = 6.823981056e+10;}; typeId= 3875; destinationSolarSystemId= 30003268; destinationStargateId= 50006105 } |> Some
      | 50007866 -> { StargateData.id= 50007866; name= "Stargate (C-HCGU)"; solarSystemId= 30004320; position= {x = -1.877750047e+12;  y = -3.011340288e+11;  z = 1.502044938e+12;}; typeId= 16; destinationSolarSystemId= 30004319; destinationStargateId= 50007688 } |> Some
      | 50007963 -> { StargateData.id= 50007963; name= "Stargate (A2-V27)"; solarSystemId= 30003943; position= {x = -5.639288832e+11;  y = -7.3946112e+10;  z = 3.064134574e+12;}; typeId= 29624; destinationSolarSystemId= 30003942; destinationStargateId= 50007923 } |> Some
      | 50008060 -> { StargateData.id= 50008060; name= "Stargate (Bomana)"; solarSystemId= 30003912; position= {x = 8.714085581e+11;  y = -1.506065203e+11;  z = -2.068265165e+12;}; typeId= 29624; destinationSolarSystemId= 30003913; destinationStargateId= 50008090 } |> Some
      | 50008157 -> { StargateData.id= 50008157; name= "Stargate (M-V0PQ)"; solarSystemId= 30002378; position= {x = 1.261995418e+12;  y = -6.150033408e+10;  z = -1.295507866e+11;}; typeId= 3875; destinationSolarSystemId= 30002377; destinationStargateId= 50007891 } |> Some
      | 50008254 -> { StargateData.id= 50008254; name= "Stargate (L-C3O7)"; solarSystemId= 30003688; position= {x = -8.924049408e+10;  y = -1.238863872e+10;  z = 1.806597734e+11;}; typeId= 3875; destinationSolarSystemId= 30003689; destinationStargateId= 50008453 } |> Some
      | 50008351 -> { StargateData.id= 50008351; name= "Stargate (Ham)"; solarSystemId= 30003917; position= {x = -2.906390938e+11;  y = 1.004689453e+13;  z = -3.350001869e+12;}; typeId= 17; destinationSolarSystemId= 30003900; destinationStargateId= 50008064 } |> Some
      | 50008448 -> { StargateData.id= 50008448; name= "Stargate (6U-MFQ)"; solarSystemId= 30003214; position= {x = 2.866472141e+11;  y = 2.422173696e+10;  z = 1.453318349e+12;}; typeId= 3875; destinationSolarSystemId= 30003210; destinationStargateId= 50007978 } |> Some
      | 50008545 -> { StargateData.id= 50008545; name= "Stargate (Aedald)"; solarSystemId= 30002394; position= {x = -2.037594931e+11;  y = -1.197109248e+10;  z = 4.923549696e+11;}; typeId= 29633; destinationSolarSystemId= 30002393; destinationStargateId= 50008095 } |> Some
      | 50008642 -> { StargateData.id= 50008642; name= "Stargate (Arera)"; solarSystemId= 30002248; position= {x = -6.937399296e+10;  y = -201891840.0;  z = -1.566170726e+11;}; typeId= 29624; destinationSolarSystemId= 30002244; destinationStargateId= 50006393 } |> Some
      | 50008739 -> { StargateData.id= 50008739; name= "Stargate (C0T-77)"; solarSystemId= 30004494; position= {x = 1.565563822e+12;  y = 1.051441152e+11;  z = 9.758727782e+11;}; typeId= 3875; destinationSolarSystemId= 30004493; destinationStargateId= 50008730 } |> Some
      | 50008836 -> { StargateData.id= 50008836; name= "Stargate (L-POLO)"; solarSystemId= 30005159; position= {x = 1.237302927e+12;  y = 2.55043584e+10;  z = 3.547246633e+12;}; typeId= 3875; destinationSolarSystemId= 30005163; destinationStargateId= 50009765 } |> Some
      | 50008933 -> { StargateData.id= 50008933; name= "Stargate (A-G1FM)"; solarSystemId= 30004357; position= {x = 1.55149824e+12;  y = 8.121274368e+10;  z = 3.949855826e+12;}; typeId= 16; destinationSolarSystemId= 30004359; destinationStargateId= 50009485 } |> Some
      | 50009030 -> { StargateData.id= 50009030; name= "Stargate (Raravath)"; solarSystemId= 30003537; position= {x = 3.129320448e+12;  y = -3.398500762e+11;  z = -5.104830996e+12;}; typeId= 29624; destinationSolarSystemId= 30003530; destinationStargateId= 50005662 } |> Some
      | 50009127 -> { StargateData.id= 50009127; name= "Stargate (Koona)"; solarSystemId= 30004127; position= {x = -1.235262259e+11;  y = 1.765036032e+10;  z = -1.132453478e+11;}; typeId= 29624; destinationSolarSystemId= 30004128; destinationStargateId= 50009169 } |> Some
      | 50009224 -> { StargateData.id= 50009224; name= "Stargate (Efa)"; solarSystemId= 30003891; position= {x = 4.943119565e+11;  y = -8.088612864e+10;  z = -4.171718246e+11;}; typeId= 29624; destinationSolarSystemId= 30003892; destinationStargateId= 50010700 } |> Some
      | 50009321 -> { StargateData.id= 50009321; name= "Stargate (ZAU-JW)"; solarSystemId= 30003982; position= {x = 8.517199872e+11;  y = -7.235843973e+12;  z = 4.201934316e+12;}; typeId= 17; destinationSolarSystemId= 30003996; destinationStargateId= 50009597 } |> Some
      | 50009418 -> { StargateData.id= 50009418; name= "Stargate (Taisy)"; solarSystemId= 30001446; position= {x = 4.23933825e+12;  y = 5.549785498e+11;  z = 5.218326528e+11;}; typeId= 16; destinationSolarSystemId= 30001447; destinationStargateId= 50010722 } |> Some
      | 50009515 -> { StargateData.id= 50009515; name= "Stargate (C-9RRR)"; solarSystemId= 30003970; position= {x = -1.201471353e+13;  y = 1.46014679e+12;  z = -1.075153564e+13;}; typeId= 29624; destinationSolarSystemId= 30003976; destinationStargateId= 50011440 } |> Some
      | 50009612 -> { StargateData.id= 50009612; name= "Stargate (U-O2DA)"; solarSystemId= 30003636; position= {x = -8.915275776e+10;  y = -6066708480.0;  z = -1.605598003e+11;}; typeId= 16; destinationSolarSystemId= 30003637; destinationStargateId= 50009642 } |> Some
      | 50009709 -> { StargateData.id= 50009709; name= "Stargate (BY-7PY)"; solarSystemId= 30002381; position= {x = -1.313433723e+12;  y = 1.517912187e+12;  z = 7.92911831e+11;}; typeId= 3874; destinationSolarSystemId= 30002305; destinationStargateId= 50002384 } |> Some
      | 50009806 -> { StargateData.id= 50009806; name= "Stargate (Z3V-1W)"; solarSystemId= 30004708; position= {x = 1.998620959e+12;  y = 9.736556544e+10;  z = 6.98569728e+11;}; typeId= 29624; destinationSolarSystemId= 30004707; destinationStargateId= 50009773 } |> Some
      | 50009903 -> { StargateData.id= 50009903; name= "Stargate (IWZ3-C)"; solarSystemId= 30003763; position= {x = -3.896122614e+12;  y = 4.976329114e+11;  z = 1.01820457e+11;}; typeId= 29624; destinationSolarSystemId= 30003765; destinationStargateId= 50010468 } |> Some
      | 50010000 -> { StargateData.id= 50010000; name= "Stargate (XKM-DE)"; solarSystemId= 30003262; position= {x = -2.458125558e+12;  y = 3.880316928e+10;  z = -1.230969446e+12;}; typeId= 3875; destinationSolarSystemId= 30003263; destinationStargateId= 50010604 } |> Some
      | 50010097 -> { StargateData.id= 50010097; name= "Stargate (Isikesu)"; solarSystemId= 30002805; position= {x = 6.719524454e+11;  y = -4.580192256e+10;  z = -2.855129702e+12;}; typeId= 16; destinationSolarSystemId= 30002804; destinationStargateId= 50009376 } |> Some
      | 50010194 -> { StargateData.id= 50010194; name= "Stargate (Ridoner)"; solarSystemId= 30003455; position= {x = 7.63213824e+10;  y = 4802273280.0;  z = 7.687973683e+11;}; typeId= 29633; destinationSolarSystemId= 30003457; destinationStargateId= 50011963 } |> Some
      | 50010291 -> { StargateData.id= 50010291; name= "Stargate (ZD4-G9)"; solarSystemId= 30001353; position= {x = 5.595957289e+12;  y = 6.153596928e+10;  z = -2.999123436e+12;}; typeId= 16; destinationSolarSystemId= 30001354; destinationStargateId= 50011066 } |> Some
      | 50010388 -> { StargateData.id= 50010388; name= "Stargate (JI-K5H)"; solarSystemId= 30004669; position= {x = -2.940950323e+12;  y = 5.490432e+11;  z = -1.047947551e+12;}; typeId= 29624; destinationSolarSystemId= 30004667; destinationStargateId= 50010375 } |> Some
      | 50010485 -> { StargateData.id= 50010485; name= "Stargate (Umokka)"; solarSystemId= 30001408; position= {x = 3.605925888e+10;  y = 6997401600.0;  z = -2.798905958e+12;}; typeId= 16; destinationSolarSystemId= 30001409; destinationStargateId= 50011242 } |> Some
      | 50010582 -> { StargateData.id= 50010582; name= "Stargate (24I-FE)"; solarSystemId= 30001783; position= {x = -3.331966157e+11;  y = -5.663698944e+10;  z = -2.343001006e+12;}; typeId= 3875; destinationSolarSystemId= 30001784; destinationStargateId= 50011138 } |> Some
      | 50010679 -> { StargateData.id= 50010679; name= "Stargate (Y2-I3W)"; solarSystemId= 30004455; position= {x = -9.857636352e+11;  y = -1.485657293e+11;  z = -5.379209994e+12;}; typeId= 29633; destinationSolarSystemId= 30004456; destinationStargateId= 50010953 } |> Some
      | 50010776 -> { StargateData.id= 50010776; name= "Stargate (JBUH-H)"; solarSystemId= 30001789; position= {x = -1.322193838e+12;  y = -4.14964224e+12;  z = -3.082323517e+12;}; typeId= 3874; destinationSolarSystemId= 30001777; destinationStargateId= 50010113 } |> Some
      | 50010873 -> { StargateData.id= 50010873; name= "Stargate (Q-ITV5)"; solarSystemId= 30003217; position= {x = 7.676096102e+11;  y = -2.289537024e+10;  z = 9.14248704e+11;}; typeId= 3875; destinationSolarSystemId= 30003222; destinationStargateId= 50013207 } |> Some
      | 50010970 -> { StargateData.id= 50010970; name= "Stargate (Kamih)"; solarSystemId= 30004241; position= {x = 1.073436955e+13;  y = 1.877447516e+12;  z = 3.408402309e+12;}; typeId= 29624; destinationSolarSystemId= 30004239; destinationStargateId= 50010941 } |> Some
      | 50011067 -> { StargateData.id= 50011067; name= "Stargate (0-7XA8)"; solarSystemId= 30001937; position= {x = -3.745459814e+11;  y = 1.298455388e+12;  z = 1.288147722e+12;}; typeId= 17; destinationSolarSystemId= 30001904; destinationStargateId= 50010783 } |> Some
      | 50011164 -> { StargateData.id= 50011164; name= "Stargate (PS-94K)"; solarSystemId= 30004766; position= {x = -6.813069312e+10;  y = -548659200.0;  z = -1.052355379e+11;}; typeId= 29624; destinationSolarSystemId= 30004770; destinationStargateId= 50012732 } |> Some
      | 50011261 -> { StargateData.id= 50011261; name= "Stargate (Kamih)"; solarSystemId= 30004254; position= {x = 1.013071258e+12;  y = -3.68274346e+12;  z = -1.667223921e+12;}; typeId= 17; destinationSolarSystemId= 30004239; destinationStargateId= 50010942 } |> Some
      | 50011358 -> { StargateData.id= 50011358; name= "Stargate (Astabih)"; solarSystemId= 30000116; position= {x = -5.579237376e+11;  y = 7.430148096e+10;  z = -1.60771584e+12;}; typeId= 29624; destinationSolarSystemId= 30000113; destinationStargateId= 50007801 } |> Some
      | 50011455 -> { StargateData.id= 50011455; name= "Stargate (I-CMZA)"; solarSystemId= 30004180; position= {x = 3.313798717e+12;  y = -5.453418086e+11;  z = 6.863950234e+11;}; typeId= 3875; destinationSolarSystemId= 30004177; destinationStargateId= 50010877 } |> Some
      | 50011552 -> { StargateData.id= 50011552; name= "Stargate (VORM-W)"; solarSystemId= 30000323; position= {x = 8.787754598e+11;  y = 6.678147072e+10;  z = 8.492845056e+11;}; typeId= 16; destinationSolarSystemId= 30000322; destinationStargateId= 50011544 } |> Some
      | 50011649 -> { StargateData.id= 50011649; name= "Stargate (9-4RP2)"; solarSystemId= 30004061; position= {x = 2.407877468e+12;  y = 2.912070451e+11;  z = 2.801375601e+12;}; typeId= 3875; destinationSolarSystemId= 30004059; destinationStargateId= 50011584 } |> Some
      | 50011746 -> { StargateData.id= 50011746; name= "Stargate (U1-C18)"; solarSystemId= 30004465; position= {x = -5.00291924e+12;  y = -2.70617727e+12;  z = -1.34600577e+12;}; typeId= 3877; destinationSolarSystemId= 30004441; destinationStargateId= 50010027 } |> Some
      | 50011843 -> { StargateData.id= 50011843; name= "Stargate (U6-FCE)"; solarSystemId= 30001928; position= {x = 9.008664576e+10;  y = -1.758498816e+10;  z = -1.470376796e+12;}; typeId= 29624; destinationSolarSystemId= 30001927; destinationStargateId= 50011598 } |> Some
      | 50011940 -> { StargateData.id= 50011940; name= "Stargate (671-ST)"; solarSystemId= 30004603; position= {x = 2.17365504e+11;  y = -5515714560.0;  z = 5.58043177e+11;}; typeId= 3875; destinationSolarSystemId= 30004604; destinationStargateId= 50011967 } |> Some
      | 50012037 -> { StargateData.id= 50012037; name= "Stargate (P9F-ZG)"; solarSystemId= 30003167; position= {x = -6.45504983e+11;  y = 1.291349606e+11;  z = -4.911409152e+11;}; typeId= 29624; destinationSolarSystemId= 30003163; destinationStargateId= 50010407 } |> Some
      | 50012134 -> { StargateData.id= 50012134; name= "Stargate (Weld)"; solarSystemId= 30002416; position= {x = -2.464075407e+12;  y = 1.919101747e+11;  z = 1.788488786e+12;}; typeId= 29633; destinationSolarSystemId= 30002415; destinationStargateId= 50011829 } |> Some
      | 50012231 -> { StargateData.id= 50012231; name= "Stargate (YZ-LQL)"; solarSystemId= 30004618; position= {x = 2.186785997e+11;  y = -1.98469632e+10;  z = -2.695231488e+11;}; typeId= 3875; destinationSolarSystemId= 30004617; destinationStargateId= 50012190 } |> Some
      | 50012328 -> { StargateData.id= 50012328; name= "Stargate (8WA-Z6)"; solarSystemId= 30004765; position= {x = -7.019966054e+11;  y = 5.173334016e+10;  z = 4.01588183e+11;}; typeId= 29624; destinationSolarSystemId= 30004760; destinationStargateId= 50011056 } |> Some
      | 50012425 -> { StargateData.id= 50012425; name= "Stargate (Sadana)"; solarSystemId= 30004244; position= {x = 4.111946097e+12;  y = -1.302054912e+11;  z = 1.691631575e+12;}; typeId= 29624; destinationSolarSystemId= 30004242; destinationStargateId= 50011018 } |> Some
      | 50012522 -> { StargateData.id= 50012522; name= "Stargate (C-FER9)"; solarSystemId= 30004649; position= {x = -2.178246205e+12;  y = -3.177346253e+11;  z = -2.224115712e+10;}; typeId= 3875; destinationSolarSystemId= 30004651; destinationStargateId= 50012736 } |> Some
      | 50012619 -> { StargateData.id= 50012619; name= "Stargate (E7-WSY)"; solarSystemId= 30001908; position= {x = -4.252703662e+12;  y = 8.136493056e+11;  z = -1.24899668e+12;}; typeId= 29624; destinationSolarSystemId= 30001909; destinationStargateId= 50012679 } |> Some
      | 50012716 -> { StargateData.id= 50012716; name= "Stargate (6VDT-H)"; solarSystemId= 30004616; position= {x = -1.404563497e+12;  y = 1.460503757e+11;  z = 3.374861107e+11;}; typeId= 3875; destinationSolarSystemId= 30004608; destinationStargateId= 50011986 } |> Some
      | 50012813 -> { StargateData.id= 50012813; name= "Stargate (TCAG-3)"; solarSystemId= 30004936; position= {x = -1.188454441e+12;  y = 2.38925783e+11;  z = -6.301838131e+11;}; typeId= 29624; destinationSolarSystemId= 30004937; destinationStargateId= 50012825 } |> Some
      | 50012910 -> { StargateData.id= 50012910; name= "Stargate (08S-39)"; solarSystemId= 30004947; position= {x = 2.468798915e+12;  y = 3.64484567e+11;  z = -2.100195533e+12;}; typeId= 29624; destinationSolarSystemId= 30004954; destinationStargateId= 50013213 } |> Some
      | 50013007 -> { StargateData.id= 50013007; name= "Stargate (Central Point)"; solarSystemId= 30005285; position= {x = -1.649008435e+12;  y = -1.926393446e+11;  z = -1.044169974e+12;}; typeId= 29624; destinationSolarSystemId= 30005283; destinationStargateId= 50012650 } |> Some
      | 50013104 -> { StargateData.id= 50013104; name= "Stargate (8KR9-5)"; solarSystemId= 30004943; position= {x = 3.108109885e+12;  y = -2.403892838e+11;  z = -1.752375091e+12;}; typeId= 29624; destinationSolarSystemId= 30004942; destinationStargateId= 50013085 } |> Some
      | 50013201 -> { StargateData.id= 50013201; name= "Stargate (Karan)"; solarSystemId= 30004303; position= {x = -3.67368192e+10;  y = 1588715520.0;  z = -4652851200.0;}; typeId= 29624; destinationSolarSystemId= 30004306; destinationStargateId= 50013404 } |> Some
      | 50013298 -> { StargateData.id= 50013298; name= "Stargate (T7-JNB)"; solarSystemId= 30001917; position= {x = 6.58862592e+12;  y = -3.839028019e+11;  z = -2.168717722e+11;}; typeId= 29624; destinationSolarSystemId= 30001916; destinationStargateId= 50013102 } |> Some
      | 50013395 -> { StargateData.id= 50013395; name= "Stargate (Z-6YQC)"; solarSystemId= 30001954; position= {x = -3.309885481e+12;  y = -6.979269304e+12;  z = -4.631004488e+12;}; typeId= 17; destinationSolarSystemId= 30001956; destinationStargateId= 50013460 } |> Some
      | 50013492 -> { StargateData.id= 50013492; name= "Stargate (O-N589)"; solarSystemId= 30004704; position= {x = 5.141172634e+11;  y = -4.729270272e+10;  z = 5.722264781e+11;}; typeId= 29624; destinationSolarSystemId= 30004703; destinationStargateId= 50013447 } |> Some
      | 50013686 -> { StargateData.id= 50013686; name= "Stargate (Ofage)"; solarSystemId= 30000199; position= {x = -1.610815488e+11;  y = 5.225588613e+12;  z = -4.218156933e+12;}; typeId= 3873; destinationSolarSystemId= 30003446; destinationStargateId= 50013685 } |> Some
      | 50013783 -> { StargateData.id= 50013783; name= "Stargate (HY-RWO)"; solarSystemId= 30001252; position= {x = 3.162287432e+12;  y = -5.533233562e+11;  z = 1.277505331e+12;}; typeId= 12292; destinationSolarSystemId= 30001159; destinationStargateId= 50013784 } |> Some
      | 50013977 -> { StargateData.id= 50013977; name= "Stargate (EOA-ZC)"; solarSystemId= 30000200; position= {x = 1.121369088e+12;  y = -6.67379712e+10;  z = 4.092992102e+12;}; typeId= 3873; destinationSolarSystemId= 30002475; destinationStargateId= 50013978 } |> Some
      | 50014074 -> { StargateData.id= 50014074; name= "Stargate (Colelie)"; solarSystemId= 30002048; position= {x = -3.539447931e+12;  y = 2.188707717e+12;  z = -2.025127158e+12;}; typeId= 29634; destinationSolarSystemId= 30002682; destinationStargateId= 50014073 } |> Some
      | 50014171 -> { StargateData.id= 50014171; name= "Stargate (Oirtlair)"; solarSystemId= 30002708; position= {x = 2.079402271e+12;  y = 1.59983616e+10;  z = -1.348435599e+12;}; typeId= 3875; destinationSolarSystemId= 30022715; destinationStargateId= 50014172 } |> Some
      | 50014268 -> { StargateData.id= 50014268; name= "Stargate (APES-G)"; solarSystemId= 30001551; position= {x = -4.701657907e+11;  y = -4.53294207e+12;  z = 1.137775288e+12;}; typeId= 29632; destinationSolarSystemId= 30001114; destinationStargateId= 50014267 } |> Some
      | 50016305 -> { StargateData.id= 50016305; name= "Stargate (Rohamaa)"; solarSystemId= 30045321; position= {x = -1.573582725e+12;  y = -6599516160.0;  z = -3.404812984e+12;}; typeId= 16; destinationSolarSystemId= 30045325; destinationStargateId= 50016306 } |> Some
      | 50016402 -> { StargateData.id= 50016402; name= "Stargate (Akkio)"; solarSystemId= 30002062; position= {x = 2.457912484e+12;  y = 1.983769682e+12;  z = 1.917866435e+12;}; typeId= 29634; destinationSolarSystemId= 30000200; destinationStargateId= 50016403 } |> Some
      | 50016499 -> { StargateData.id= 50016499; name= "Stargate (Harva)"; solarSystemId= 30003495; position= {x = 4.994654674e+10;  y = -2461793787.0;  z = -920024320.6;}; typeId= 56317; destinationSolarSystemId= 30002225; destinationStargateId= 50016498 } |> Some
      | _ -> None