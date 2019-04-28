﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stargates59=
    let getStargate id = 
      match id with 
      | 50000067 -> { StargateData.id= 50000067; name= "Stargate (Sasta)"; solarSystemId= 30000002; position= {x = 1.43831298e+12;  y = 8.674701312e+10;  z = -6.056559821e+11;}; typeId= 29624; destinationSolarSystemId= 30000005; destinationStargateId= 50001740 } |> Some
      | 50000164 -> { StargateData.id= 50000164; name= "Stargate (Isanamo)"; solarSystemId= 30001368; position= {x = 8.018103091e+11;  y = 9.792173875e+12;  z = 1.475352207e+12;}; typeId= 29627; destinationSolarSystemId= 30001389; destinationStargateId= 50001271 } |> Some
      | 50000261 -> { StargateData.id= 50000261; name= "Stargate (AZF-GH)"; solarSystemId= 30000918; position= {x = 5.015422157e+11;  y = -5332623360.0;  z = 2.831581471e+12;}; typeId= 29633; destinationSolarSystemId= 30000920; destinationStargateId= 50001207 } |> Some
      | 50000455 -> { StargateData.id= 50000455; name= "Stargate (2G-VDP)"; solarSystemId= 30002284; position= {x = -1.149202022e+11;  y = -6626058240.0;  z = -4.725572813e+11;}; typeId= 3875; destinationSolarSystemId= 30002283; destinationStargateId= 50000137 } |> Some
      | 50000552 -> { StargateData.id= 50000552; name= "Stargate (N-HSK0)"; solarSystemId= 30000216; position= {x = -2.06106071e+12;  y = 3.753525658e+11;  z = 9.632075366e+11;}; typeId= 16; destinationSolarSystemId= 30000215; destinationStargateId= 50000154 } |> Some
      | 50000649 -> { StargateData.id= 50000649; name= "Stargate (FB-MPY)"; solarSystemId= 30002318; position= {x = -5.511469056e+11;  y = 8.271138816e+10;  z = 2.352041533e+12;}; typeId= 3875; destinationSolarSystemId= 30002321; destinationStargateId= 50001206 } |> Some
      | 50000746 -> { StargateData.id= 50000746; name= "Stargate (C-KW6X)"; solarSystemId= 30001083; position= {x = -4.420927857e+12;  y = 1.093387469e+11;  z = 1.963407729e+12;}; typeId= 3875; destinationSolarSystemId= 30001085; destinationStargateId= 50002220 } |> Some
      | 50000843 -> { StargateData.id= 50000843; name= "Stargate (UY5A-D)"; solarSystemId= 30000546; position= {x = -6.251277926e+11;  y = -1.258543104e+11;  z = -4.287586714e+11;}; typeId= 29633; destinationSolarSystemId= 30000549; destinationStargateId= 50003052 } |> Some
      | 50001037 -> { StargateData.id= 50001037; name= "Stargate (F2-NXA)"; solarSystemId= 30000692; position= {x = -1.25306327e+12;  y = 9.830879232e+10;  z = 1.728991273e+12;}; typeId= 29633; destinationSolarSystemId= 30000695; destinationStargateId= 50001727 } |> Some
      | 50001231 -> { StargateData.id= 50001231; name= "Stargate (1QZ-Y9)"; solarSystemId= 30000774; position= {x = -1.805708206e+12;  y = 1.166567092e+13;  z = 5.459798385e+12;}; typeId= 29635; destinationSolarSystemId= 30000720; destinationStargateId= 50001332 } |> Some
      | 50001328 -> { StargateData.id= 50001328; name= "Stargate (FY0W-N)"; solarSystemId= 30000849; position= {x = 1.611727258e+11;  y = 3.222392832e+10;  z = -2.304631726e+12;}; typeId= 16; destinationSolarSystemId= 30000850; destinationStargateId= 50003303 } |> Some
      | 50001522 -> { StargateData.id= 50001522; name= "Stargate (Tennen)"; solarSystemId= 30002766; position= {x = -1.955712614e+11;  y = 3.288772608e+10;  z = -3.532449792e+11;}; typeId= 16; destinationSolarSystemId= 30002763; destinationStargateId= 50001101 } |> Some
      | 50001619 -> { StargateData.id= 50001619; name= "Stargate (Y-DSSK)"; solarSystemId= 30000956; position= {x = 1.142721946e+12;  y = 4.686262272e+10;  z = -1.079987036e+12;}; typeId= 29633; destinationSolarSystemId= 30000958; destinationStargateId= 50002459 } |> Some
      | 50001716 -> { StargateData.id= 50001716; name= "Stargate (Kourmonen)"; solarSystemId= 30003067; position= {x = -1.846187213e+11;  y = -2.392805376e+10;  z = 2.971645133e+11;}; typeId= 29624; destinationSolarSystemId= 30003068; destinationStargateId= 50001857 } |> Some
      | 50001813 -> { StargateData.id= 50001813; name= "Stargate (Teshkat)"; solarSystemId= 30001647; position= {x = 9.445742592e+11;  y = 8.547015107e+12;  z = 7.152611328e+10;}; typeId= 17; destinationSolarSystemId= 30001681; destinationStargateId= 50003982 } |> Some
      | 50002007 -> { StargateData.id= 50002007; name= "Stargate (SY-0AM)"; solarSystemId= 30002837; position= {x = -3.423100723e+12;  y = 3.897238733e+11;  z = -2.22550315e+12;}; typeId= 3875; destinationSolarSystemId= 30002835; destinationStargateId= 50001116 } |> Some
      | 50002104 -> { StargateData.id= 50002104; name= "Stargate (SV5-8N)"; solarSystemId= 30001161; position= {x = 1.14393047e+11;  y = 2022236160.0;  z = 1.40679426e+12;}; typeId= 29624; destinationSolarSystemId= 30001158; destinationStargateId= 50001319 } |> Some
      | 50002201 -> { StargateData.id= 50002201; name= "Stargate (Hirtamon)"; solarSystemId= 30000145; position= {x = 5.850165658e+11;  y = -1.455445893e+12;  z = -5.909907456e+11;}; typeId= 29627; destinationSolarSystemId= 30000133; destinationStargateId= 50001775 } |> Some
      | 50002395 -> { StargateData.id= 50002395; name= "Stargate (Ahrosseas)"; solarSystemId= 30001653; position= {x = 1.478051635e+12;  y = 4.467900703e+12;  z = -5.103017533e+12;}; typeId= 17; destinationSolarSystemId= 30001649; destinationStargateId= 50002388 } |> Some
      | 50002492 -> { StargateData.id= 50002492; name= "Stargate (VKU-BG)"; solarSystemId= 30000928; position= {x = 5.702351954e+12;  y = 1.007381914e+12;  z = -2.203841126e+12;}; typeId= 29633; destinationSolarSystemId= 30000927; destinationStargateId= 50001361 } |> Some
      | 50002589 -> { StargateData.id= 50002589; name= "Stargate (YKE4-3)"; solarSystemId= 30001028; position= {x = 1.152478618e+12;  y = 1.998641971e+11;  z = 3.423686246e+11;}; typeId= 29633; destinationSolarSystemId= 30001024; destinationStargateId= 50000678 } |> Some
      | 50002686 -> { StargateData.id= 50002686; name= "Stargate (V7D-JD)"; solarSystemId= 30001014; position= {x = -1.753926083e+12;  y = 1.966513766e+11;  z = 4.987416576e+10;}; typeId= 29633; destinationSolarSystemId= 30001015; destinationStargateId= 50003056 } |> Some
      | 50002977 -> { StargateData.id= 50002977; name= "Stargate (TYB-69)"; solarSystemId= 30000453; position= {x = 3.347246408e+12;  y = 3.559963484e+12;  z = -1.728564634e+12;}; typeId= 3877; destinationSolarSystemId= 30000485; destinationStargateId= 50003595 } |> Some
      | 50003074 -> { StargateData.id= 50003074; name= "Stargate (RNF-YH)"; solarSystemId= 30001183; position= {x = -1.088766321e+12;  y = -1.54392576e+10;  z = 7.540297728e+10;}; typeId= 29624; destinationSolarSystemId= 30001187; destinationStargateId= 50010114 } |> Some
      | 50003171 -> { StargateData.id= 50003171; name= "Stargate (1L-AED)"; solarSystemId= 30000915; position= {x = -1.905116897e+12;  y = 6.619315446e+12;  z = 3.905310843e+12;}; typeId= 3877; destinationSolarSystemId= 30000962; destinationStargateId= 50003903 } |> Some
      | 50003268 -> { StargateData.id= 50003268; name= "Stargate (Iitanmadan)"; solarSystemId= 30001420; position= {x = -1.413341307e+12;  y = -1.006698086e+11;  z = -1.814314598e+11;}; typeId= 16; destinationSolarSystemId= 30001422; destinationStargateId= 50003324 } |> Some
      | 50003365 -> { StargateData.id= 50003365; name= "Stargate (Milal)"; solarSystemId= 30002201; position= {x = -1.796301988e+12;  y = -4.715148042e+12;  z = -2.20479959e+12;}; typeId= 17; destinationSolarSystemId= 30002236; destinationStargateId= 50005156 } |> Some
      | 50003462 -> { StargateData.id= 50003462; name= "Stargate (5U-3PW)"; solarSystemId= 30002315; position= {x = 7449354240.0;  y = -178053120.0;  z = 3.091160678e+11;}; typeId= 3875; destinationSolarSystemId= 30002313; destinationStargateId= 50002793 } |> Some
      | 50003559 -> { StargateData.id= 50003559; name= "Stargate (IS-OBW)"; solarSystemId= 30002332; position= {x = -4.539519836e+12;  y = -6.807671194e+11;  z = -3.696477389e+11;}; typeId= 3875; destinationSolarSystemId= 30002331; destinationStargateId= 50003159 } |> Some
      | 50003656 -> { StargateData.id= 50003656; name= "Stargate (HLR-GL)"; solarSystemId= 30001745; position= {x = -3.16387369e+11;  y = -5.196828672e+10;  z = -2.099759923e+11;}; typeId= 3875; destinationSolarSystemId= 30001744; destinationStargateId= 50003646 } |> Some
      | 50003753 -> { StargateData.id= 50003753; name= "Stargate (MUXX-4)"; solarSystemId= 30001214; position= {x = 1.735479337e+12;  y = -2433638400.0;  z = 3.565835674e+12;}; typeId= 29624; destinationSolarSystemId= 30001213; destinationStargateId= 50003436 } |> Some
      | 50003850 -> { StargateData.id= 50003850; name= "Stargate (H-1EOH)"; solarSystemId= 30000277; position= {x = -1.990445998e+12;  y = -2.884857446e+11;  z = -1.050765312e+11;}; typeId= 16; destinationSolarSystemId= 30000276; destinationStargateId= 50003676 } |> Some
      | 50003947 -> { StargateData.id= 50003947; name= "Stargate (Muetralle)"; solarSystemId= 30005298; position= {x = -7.673732014e+12;  y = 1.864884634e+11;  z = -4.493329736e+12;}; typeId= 3875; destinationSolarSystemId= 30005299; destinationStargateId= 50003949 } |> Some
      | 50004044 -> { StargateData.id= 50004044; name= "Stargate (Arnon)"; solarSystemId= 30005002; position= {x = 1.444469268e+12;  y = -2.196899021e+11;  z = -6.629839258e+11;}; typeId= 3875; destinationSolarSystemId= 30005001; destinationStargateId= 50003639 } |> Some
      | 50004141 -> { StargateData.id= 50004141; name= "Stargate (KBP7-G)"; solarSystemId= 30003730; position= {x = 1.180856771e+12;  y = 6.174855168e+10;  z = 2.926599782e+11;}; typeId= 29624; destinationSolarSystemId= 30003729; destinationStargateId= 50004022 } |> Some
      | 50004238 -> { StargateData.id= 50004238; name= "Stargate (IR-DYY)"; solarSystemId= 30000278; position= {x = -1.054877737e+12;  y = -1.170108826e+11;  z = -3.455605555e+11;}; typeId= 16; destinationSolarSystemId= 30000277; destinationStargateId= 50003851 } |> Some
      | 50004335 -> { StargateData.id= 50004335; name= "Stargate (ZMV9-A)"; solarSystemId= 30004819; position= {x = -1.826543616e+11;  y = -2.616766464e+10;  z = 1.852534333e+12;}; typeId= 29633; destinationSolarSystemId= 30004820; destinationStargateId= 50004523 } |> Some
      | 50004432 -> { StargateData.id= 50004432; name= "Stargate (Vey)"; solarSystemId= 30003788; position= {x = 1.939919708e+12;  y = 1.168523674e+11;  z = 4.250207969e+12;}; typeId= 3875; destinationSolarSystemId= 30003790; destinationStargateId= 50005090 } |> Some
      | 50004529 -> { StargateData.id= 50004529; name= "Stargate (Jurlesel)"; solarSystemId= 30003014; position= {x = -3.89484503e+11;  y = -4.099854336e+10;  z = -2.914429747e+11;}; typeId= 3875; destinationSolarSystemId= 30003013; destinationStargateId= 50003979 } |> Some
      | 50004626 -> { StargateData.id= 50004626; name= "Stargate (Tongofur)"; solarSystemId= 30002536; position= {x = -5.475280896e+11;  y = -7.515058176e+10;  z = 1.126412575e+12;}; typeId= 29633; destinationSolarSystemId= 30002532; destinationStargateId= 50003945 } |> Some
      | 50004723 -> { StargateData.id= 50004723; name= "Stargate (Annancale)"; solarSystemId= 30003789; position= {x = 2.723623035e+12;  y = 4.73073623e+11;  z = 7.793065574e+11;}; typeId= 3875; destinationSolarSystemId= 30003791; destinationStargateId= 50005405 } |> Some
      | 50004820 -> { StargateData.id= 50004820; name= "Stargate (M-4KDB)"; solarSystemId= 30004821; position= {x = 1.423219876e+12;  y = -2.01402409e+11;  z = -9.156968079e+12;}; typeId= 29633; destinationSolarSystemId= 30004823; destinationStargateId= 50005352 } |> Some
      | 50004917 -> { StargateData.id= 50004917; name= "Stargate (Oisio)"; solarSystemId= 30002796; position= {x = 5.334124093e+12;  y = -4.483083878e+11;  z = -4.235431404e+12;}; typeId= 16; destinationSolarSystemId= 30002799; destinationStargateId= 50006295 } |> Some
      | 50005014 -> { StargateData.id= 50005014; name= "Stargate (Murzi)"; solarSystemId= 30002220; position= {x = -1.68466772e+12;  y = 6.629666611e+12;  z = -3.736430961e+12;}; typeId= 17; destinationSolarSystemId= 30003526; destinationStargateId= 50003628 } |> Some
      | 50005111 -> { StargateData.id= 50005111; name= "Stargate (N-YLOE)"; solarSystemId= 30001140; position= {x = -1.742087332e+12;  y = -2.528055337e+12;  z = 1.010172764e+12;}; typeId= 3874; destinationSolarSystemId= 30001062; destinationStargateId= 50003907 } |> Some
      | 50005305 -> { StargateData.id= 50005305; name= "Stargate (4YO-QK)"; solarSystemId= 30000644; position= {x = 3.008560742e+11;  y = -5.382623232e+10;  z = -3.130354483e+11;}; typeId= 29633; destinationSolarSystemId= 30000646; destinationStargateId= 50005704 } |> Some
      | 50005402 -> { StargateData.id= 50005402; name= "Stargate (F7A-MR)"; solarSystemId= 30000995; position= {x = -8.2113024e+11;  y = 3.337668157e+12;  z = -5.695809331e+12;}; typeId= 3877; destinationSolarSystemId= 30000981; destinationStargateId= 50003681 } |> Some
      | 50005499 -> { StargateData.id= 50005499; name= "Stargate (MQ-O27)"; solarSystemId= 30000281; position= {x = -4.326969754e+11;  y = 3676938240.0;  z = 1.45659777e+12;}; typeId= 16; destinationSolarSystemId= 30000280; destinationStargateId= 50002981 } |> Some
      | 50005596 -> { StargateData.id= 50005596; name= "Stargate (Shastal)"; solarSystemId= 30002996; position= {x = 2.303794176e+12;  y = -4.461828096e+11;  z = -5.805867418e+11;}; typeId= 29624; destinationSolarSystemId= 30002999; destinationStargateId= 50009115 } |> Some
      | 50005693 -> { StargateData.id= 50005693; name= "Stargate (2-WNTD)"; solarSystemId= 30003190; position= {x = -1.382654362e+11;  y = -2.23488e+10;  z = -1.403526758e+11;}; typeId= 3875; destinationSolarSystemId= 30003188; destinationStargateId= 50004773 } |> Some
      | 50005790 -> { StargateData.id= 50005790; name= "Stargate (4M-P1I)"; solarSystemId= 30000975; position= {x = 1.525092557e+12;  y = 2.327286989e+11;  z = -1.306341089e+12;}; typeId= 29633; destinationSolarSystemId= 30000976; destinationStargateId= 50006638 } |> Some
      | 50005887 -> { StargateData.id= 50005887; name= "Stargate (Tasabeshi)"; solarSystemId= 30002779; position= {x = -4.946786427e+12;  y = -5.061337498e+11;  z = -9.699617587e+11;}; typeId= 16; destinationSolarSystemId= 30002778; destinationStargateId= 50004504 } |> Some
      | 50005984 -> { StargateData.id= 50005984; name= "Stargate (C-H9X7)"; solarSystemId= 30001993; position= {x = 2.169587712e+11;  y = 2984140800.0;  z = -1.394681856e+11;}; typeId= 16; destinationSolarSystemId= 30001992; destinationStargateId= 50005620 } |> Some
      | 50006081 -> { StargateData.id= 50006081; name= "Stargate (Altbrard)"; solarSystemId= 30002402; position= {x = 6.632706048e+10;  y = 1105059840.0;  z = 1.894496256e+11;}; typeId= 29633; destinationSolarSystemId= 30002407; destinationStargateId= 50008330 } |> Some
      | 50006178 -> { StargateData.id= 50006178; name= "Stargate (OTJ9-E)"; solarSystemId= 30001587; position= {x = 2.87879209e+11;  y = -1.780862976e+10;  z = -3.220142776e+12;}; typeId= 3875; destinationSolarSystemId= 30001586; destinationStargateId= 50005927 } |> Some
      | 50006275 -> { StargateData.id= 50006275; name= "Stargate (Ami)"; solarSystemId= 30005036; position= {x = 1.95356971e+12;  y = -2.459370824e+12;  z = 3.144504975e+12;}; typeId= 17; destinationSolarSystemId= 30005035; destinationStargateId= 50006123 } |> Some
      | 50006372 -> { StargateData.id= 50006372; name= "Stargate (Polfaly)"; solarSystemId= 30005044; position= {x = -3.122377114e+11;  y = 153477120.0;  z = 1.847329997e+11;}; typeId= 29624; destinationSolarSystemId= 30005048; destinationStargateId= 50009276 } |> Some
      | 50006469 -> { StargateData.id= 50006469; name= "Stargate (Covryn)"; solarSystemId= 30003802; position= {x = 3.372836905e+12;  y = 1.342108508e+12;  z = -6.014500086e+12;}; typeId= 3874; destinationSolarSystemId= 30003795; destinationStargateId= 50006492 } |> Some
      | 50006566 -> { StargateData.id= 50006566; name= "Stargate (PVH8-0)"; solarSystemId= 30003272; position= {x = 2.679500759e+12;  y = 2.602741064e+12;  z = -4.305065165e+11;}; typeId= 3874; destinationSolarSystemId= 30003283; destinationStargateId= 50006715 } |> Some
      | 50006663 -> { StargateData.id= 50006663; name= "Stargate (Eram)"; solarSystemId= 30003412; position= {x = 2.873945825e+12;  y = 5.015773594e+11;  z = -5.571212943e+12;}; typeId= 29633; destinationSolarSystemId= 30003413; destinationStargateId= 50007772 } |> Some
      | 50006760 -> { StargateData.id= 50006760; name= "Stargate (VXO-OM)"; solarSystemId= 30000993; position= {x = -7.81574185e+11;  y = -7.20816169e+11;  z = -1.853282427e+12;}; typeId= 3877; destinationSolarSystemId= 30000924; destinationStargateId= 50001601 } |> Some
      | 50006857 -> { StargateData.id= 50006857; name= "Stargate (Sehsasez)"; solarSystemId= 30003867; position= {x = -3.838359183e+12;  y = -5.481336422e+11;  z = -1.927128392e+12;}; typeId= 29624; destinationSolarSystemId= 30003869; destinationStargateId= 50007489 } |> Some
      | 50006954 -> { StargateData.id= 50006954; name= "Stargate (8KE-YS)"; solarSystemId= 30002355; position= {x = -4.836151296e+10;  y = 2961776640.0;  z = -2.414003405e+11;}; typeId= 3875; destinationSolarSystemId= 30002354; destinationStargateId= 50006747 } |> Some
      | 50007051 -> { StargateData.id= 50007051; name= "Stargate (SAI-T9)"; solarSystemId= 30000509; position= {x = 3030343680.0;  y = -581591040.0;  z = 1.17954601e+11;}; typeId= 29633; destinationSolarSystemId= 30000508; destinationStargateId= 50006229 } |> Some
      | 50007148 -> { StargateData.id= 50007148; name= "Stargate (Arzanni)"; solarSystemId= 30003883; position= {x = 8.543882035e+11;  y = -1.51139328e+11;  z = 2.966254019e+12;}; typeId= 29624; destinationSolarSystemId= 30003885; destinationStargateId= 50007396 } |> Some
      | 50007245 -> { StargateData.id= 50007245; name= "Stargate (Agtver)"; solarSystemId= 30003405; position= {x = -2.001806008e+12;  y = -2.183804928e+11;  z = 2.02349568e+11;}; typeId= 29633; destinationSolarSystemId= 30003404; destinationStargateId= 50006540 } |> Some
      | 50007342 -> { StargateData.id= 50007342; name= "Stargate (CT8K-0)"; solarSystemId= 30002374; position= {x = -1.178506568e+12;  y = -1.562123059e+11;  z = -3.622179226e+11;}; typeId= 3875; destinationSolarSystemId= 30002373; destinationStargateId= 50007165 } |> Some
      | 50007439 -> { StargateData.id= 50007439; name= "Stargate (H-GKI6)"; solarSystemId= 30003753; position= {x = 1.373969326e+12;  y = 9.874477056e+10;  z = 2.63006208e+10;}; typeId= 29624; destinationSolarSystemId= 30003752; destinationStargateId= 50007309 } |> Some
      | 50007536 -> { StargateData.id= 50007536; name= "Stargate (IL-OL1)"; solarSystemId= 30001143; position= {x = 2686033920.0;  y = 508846080.0;  z = -6.984511488e+10;}; typeId= 3875; destinationSolarSystemId= 30001146; destinationStargateId= 50008441 } |> Some
      | 50007633 -> { StargateData.id= 50007633; name= "Stargate (W5-VBR)"; solarSystemId= 30003204; position= {x = -3.805835674e+11;  y = -2.901651456e+10;  z = -1.612707717e+12;}; typeId= 3875; destinationSolarSystemId= 30003205; destinationStargateId= 50008153 } |> Some
      | 50007730 -> { StargateData.id= 50007730; name= "Stargate (Fegomenko)"; solarSystemId= 30002399; position= {x = 1.987582157e+12;  y = -1.086457037e+11;  z = 6.242660352e+10;}; typeId= 3877; destinationSolarSystemId= 30002408; destinationStargateId= 50009538 } |> Some
      | 50007827 -> { StargateData.id= 50007827; name= "Stargate (8ZO-CK)"; solarSystemId= 30001878; position= {x = 5.983295447e+12;  y = 7.158901555e+11;  z = 7.3810944e+10;}; typeId= 29624; destinationSolarSystemId= 30001877; destinationStargateId= 50007762 } |> Some
      | 50007924 -> { StargateData.id= 50007924; name= "Stargate (A3-LOG)"; solarSystemId= 30003942; position= {x = -6.198206054e+11;  y = -2.27653632e+10;  z = -3.646701158e+11;}; typeId= 29624; destinationSolarSystemId= 30003944; destinationStargateId= 50008109 } |> Some
      | 50008021 -> { StargateData.id= 50008021; name= "Stargate (CX-1XF)"; solarSystemId= 30004331; position= {x = 2.718516142e+12;  y = 5.316048937e+12;  z = 1.441280532e+12;}; typeId= 29627; destinationSolarSystemId= 30004335; destinationStargateId= 50008210 } |> Some
      | 50008118 -> { StargateData.id= 50008118; name= "Stargate (Nidupad)"; solarSystemId= 30004124; position= {x = -1.394136269e+11;  y = 7798579200.0;  z = 7.782002688e+10;}; typeId= 29624; destinationSolarSystemId= 30004126; destinationStargateId= 50008969 } |> Some
      | 50008215 -> { StargateData.id= 50008215; name= "Stargate (Vay)"; solarSystemId= 30005319; position= {x = -3.0063215e+12;  y = -5.024802816e+11;  z = -5.77069953e+12;}; typeId= 3875; destinationSolarSystemId= 30005318; destinationStargateId= 50005589 } |> Some
      | 50008312 -> { StargateData.id= 50008312; name= "Stargate (Parses)"; solarSystemId= 30003908; position= {x = -2.537038234e+11;  y = 3584040960.0;  z = 3.076260618e+12;}; typeId= 29624; destinationSolarSystemId= 30003909; destinationStargateId= 50008488 } |> Some
      | 50008409 -> { StargateData.id= 50008409; name= "Stargate (Javrendei)"; solarSystemId= 30002565; position= {x = -2.334133862e+11;  y = -3866664960.0;  z = -1.132964659e+11;}; typeId= 29633; destinationSolarSystemId= 30002564; destinationStargateId= 50006670 } |> Some
      | 50008506 -> { StargateData.id= 50008506; name= "Stargate (Vimeini)"; solarSystemId= 30002084; position= {x = 2.905387008e+10;  y = -1778442240.0;  z = -5.957393203e+11;}; typeId= 29633; destinationSolarSystemId= 30002088; destinationStargateId= 50010473 } |> Some
      | 50008603 -> { StargateData.id= 50008603; name= "Stargate (Aliette)"; solarSystemId= 30002693; position= {x = -1.34427562e+12;  y = -2.705757389e+11;  z = -2.659832586e+12;}; typeId= 3875; destinationSolarSystemId= 30002698; destinationStargateId= 50012894 } |> Some
      | 50008700 -> { StargateData.id= 50008700; name= "Stargate (Warouh)"; solarSystemId= 30003555; position= {x = 3.938071757e+11;  y = 8240209920.0;  z = 8.28086231e+11;}; typeId= 29624; destinationSolarSystemId= 30003553; destinationStargateId= 50008476 } |> Some
      | 50008797 -> { StargateData.id= 50008797; name= "Stargate (JKWP-U)"; solarSystemId= 30002149; position= {x = 1.140674519e+12;  y = 2.943676416e+10;  z = 2.730331546e+12;}; typeId= 29633; destinationSolarSystemId= 30002150; destinationStargateId= 50009398 } |> Some
      | 50008894 -> { StargateData.id= 50008894; name= "Stargate (Tollus)"; solarSystemId= 30003437; position= {x = -9.383302349e+11;  y = 9.419624448e+10;  z = -2.537971507e+12;}; typeId= 29633; destinationSolarSystemId= 30003436; destinationStargateId= 50008661 } |> Some
      | 50008991 -> { StargateData.id= 50008991; name= "Stargate (3-JG3X)"; solarSystemId= 30003229; position= {x = 1.450985472e+11;  y = 2.396196864e+10;  z = 3.532970803e+11;}; typeId= 3875; destinationSolarSystemId= 30003231; destinationStargateId= 50010207 } |> Some
      | 50009088 -> { StargateData.id= 50009088; name= "Stargate (M-NWLB)"; solarSystemId= 30003235; position= {x = 2.293961318e+12;  y = -3.488739779e+12;  z = -4.483162644e+12;}; typeId= 3874; destinationSolarSystemId= 30003200; destinationStargateId= 50007035 } |> Some
      | 50009185 -> { StargateData.id= 50009185; name= "Stargate (CB4-Q2)"; solarSystemId= 30001209; position= {x = -2.240249487e+12;  y = 3.081937306e+11;  z = -1.764916224e+12;}; typeId= 29624; destinationSolarSystemId= 30001205; destinationStargateId= 50003405 } |> Some
      | 50009282 -> { StargateData.id= 50009282; name= "Stargate (Oimmo)"; solarSystemId= 30001445; position= {x = -6.106493952e+12;  y = 1.085005947e+12;  z = -4.025020293e+12;}; typeId= 16; destinationSolarSystemId= 30001444; destinationStargateId= 50009271 } |> Some
      | 50009379 -> { StargateData.id= 50009379; name= "Stargate (Kiainti)"; solarSystemId= 30000190; position= {x = 1.851340431e+12;  y = 3.595538842e+11;  z = 2.112979476e+12;}; typeId= 16; destinationSolarSystemId= 30000189; destinationStargateId= 50009058 } |> Some
      | 50009476 -> { StargateData.id= 50009476; name= "Stargate (Aimoguier)"; solarSystemId= 30003569; position= {x = 1.014219694e+12;  y = 4064010240.0;  z = 1.437504184e+12;}; typeId= 3875; destinationSolarSystemId= 30003566; destinationStargateId= 50009180 } |> Some
      | 50009573 -> { StargateData.id= 50009573; name= "Stargate (X6AB-Y)"; solarSystemId= 30003770; position= {x = -1.291112817e+12;  y = 2.473488384e+10;  z = -9.768577843e+11;}; typeId= 29624; destinationSolarSystemId= 30003773; destinationStargateId= 50011445 } |> Some
      | 50009670 -> { StargateData.id= 50009670; name= "Stargate (E9G-MT)"; solarSystemId= 30003361; position= {x = 3.666077491e+12;  y = 2.320628244e+12;  z = 4.306754396e+12;}; typeId= 29632; destinationSolarSystemId= 30004499; destinationStargateId= 50008985 } |> Some
      | 50009767 -> { StargateData.id= 50009767; name= "Stargate (0TKF-6)"; solarSystemId= 30003959; position= {x = 1.623318651e+12;  y = 1.05144361e+11;  z = 2.850888499e+11;}; typeId= 29624; destinationSolarSystemId= 30003957; destinationStargateId= 50009182 } |> Some
      | 50009864 -> { StargateData.id= 50009864; name= "Stargate (Z3V-1W)"; solarSystemId= 30004710; position= {x = 4.007046758e+11;  y = -5.723983872e+10;  z = 3.799805092e+12;}; typeId= 29624; destinationSolarSystemId= 30004707; destinationStargateId= 50009775 } |> Some
      | 50009961 -> { StargateData.id= 50009961; name= "Stargate (Eskunen)"; solarSystemId= 30000136; position= {x = -1.211940987e+12;  y = 3.893342208e+10;  z = -6.298714522e+11;}; typeId= 16; destinationSolarSystemId= 30000137; destinationStargateId= 50009976 } |> Some
      | 50010058 -> { StargateData.id= 50010058; name= "Stargate (33FN-P)"; solarSystemId= 30004518; position= {x = -1.174159565e+12;  y = -1.807961702e+11;  z = 8.613842534e+11;}; typeId= 3875; destinationSolarSystemId= 30004517; destinationStargateId= 50010036 } |> Some
      | 50010155 -> { StargateData.id= 50010155; name= "Stargate (Onatoh)"; solarSystemId= 30002809; position= {x = -3.791736422e+11;  y = -2.401284096e+10;  z = 2.726800712e+12;}; typeId= 16; destinationSolarSystemId= 30002811; destinationStargateId= 50011800 } |> Some
      | 50010252 -> { StargateData.id= 50010252; name= "Stargate (H65-HE)"; solarSystemId= 30004448; position= {x = 1.889292411e+12;  y = -3.11769047e+11;  z = 2.651823268e+12;}; typeId= 29633; destinationSolarSystemId= 30004443; destinationStargateId= 50009148 } |> Some
      | 50010349 -> { StargateData.id= 50010349; name= "Stargate (JZ-UQC)"; solarSystemId= 30005138; position= {x = -5.617335091e+11;  y = -1.649750016e+10;  z = -4.640280576e+10;}; typeId= 3875; destinationSolarSystemId= 30005135; destinationStargateId= 50009218 } |> Some
      | 50010446 -> { StargateData.id= 50010446; name= "Stargate (NEH-CS)"; solarSystemId= 30004378; position= {x = -6.291690701e+11;  y = -2.029228032e+10;  z = 7.262004879e+12;}; typeId= 16; destinationSolarSystemId= 30004383; destinationStargateId= 50011015 } |> Some
      | 50010543 -> { StargateData.id= 50010543; name= "Stargate (4K-TRB)"; solarSystemId= 30004730; position= {x = 4.951910523e+12;  y = -1.160660951e+12;  z = 2.853176402e+12;}; typeId= 17; destinationSolarSystemId= 30004716; destinationStargateId= 50010272 } |> Some
      | 50010640 -> { StargateData.id= 50010640; name= "Stargate (XF-TQL)"; solarSystemId= 30004553; position= {x = -8.224714752e+10;  y = -687022080.0;  z = 4.072917443e+12;}; typeId= 3875; destinationSolarSystemId= 30004552; destinationStargateId= 50010586 } |> Some
      | 50010737 -> { StargateData.id= 50010737; name= "Stargate (Shura)"; solarSystemId= 30004134; position= {x = 5.900980224e+10;  y = -3062046720.0;  z = -2.918510592e+10;}; typeId= 29624; destinationSolarSystemId= 30004135; destinationStargateId= 50011180 } |> Some
      | 50010834 -> { StargateData.id= 50010834; name= "Stargate (DUV-5Y)"; solarSystemId= 30003356; position= {x = -2.928290734e+12;  y = 3.018657792e+10;  z = -2.027484733e+12;}; typeId= 3875; destinationSolarSystemId= 30003359; destinationStargateId= 50011960 } |> Some
      | 50010931 -> { StargateData.id= 50010931; name= "Stargate (Q-JQSG)"; solarSystemId= 30004745; position= {x = 3.810628116e+12;  y = 3.947037082e+11;  z = -1.850316509e+13;}; typeId= 29624; destinationSolarSystemId= 30004749; destinationStargateId= 50011122 } |> Some
      | 50011028 -> { StargateData.id= 50011028; name= "Stargate (VAF1-P)"; solarSystemId= 30004178; position= {x = 1.049072886e+12;  y = -2.355708764e+12;  z = 1.757336986e+12;}; typeId= 3874; destinationSolarSystemId= 30004196; destinationStargateId= 50011980 } |> Some
      | 50011125 -> { StargateData.id= 50011125; name= "Stargate (C-LBQS)"; solarSystemId= 30004373; position= {x = 7.497117696e+10;  y = -5870346240.0;  z = -5.68193962e+12;}; typeId= 16; destinationSolarSystemId= 30004372; destinationStargateId= 50010825 } |> Some
      | 50011222 -> { StargateData.id= 50011222; name= "Stargate (8-SNUD)"; solarSystemId= 30003989; position= {x = 1.099511808e+11;  y = 1.89462528e+10;  z = -1.90445568e+10;}; typeId= 29624; destinationSolarSystemId= 30003985; destinationStargateId= 50009390 } |> Some
      | 50011319 -> { StargateData.id= 50011319; name= "Stargate (FAT-6P)"; solarSystemId= 30001255; position= {x = 4.180314931e+11;  y = 5.223591936e+10;  z = -1.90534398e+12;}; typeId= 29624; destinationSolarSystemId= 30001256; destinationStargateId= 50012047 } |> Some
      | 50011416 -> { StargateData.id= 50011416; name= "Stargate (Nema)"; solarSystemId= 30004268; position= {x = 5.131923456e+10;  y = 2537349120.0;  z = 7.096343347e+11;}; typeId= 29624; destinationSolarSystemId= 30004267; destinationStargateId= 50011348 } |> Some
      | 50011513 -> { StargateData.id= 50011513; name= "Stargate (K8L-X7)"; solarSystemId= 30004568; position= {x = -1.711550915e+12;  y = 3.467234918e+11;  z = -3.729573028e+12;}; typeId= 3875; destinationSolarSystemId= 30004572; destinationStargateId= 50011706 } |> Some
      | 50011610 -> { StargateData.id= 50011610; name= "Stargate (9-4RP2)"; solarSystemId= 30004060; position= {x = 2.12354347e+12;  y = -3.772358246e+11;  z = -4.405406147e+12;}; typeId= 3875; destinationSolarSystemId= 30004059; destinationStargateId= 50011583 } |> Some
      | 50011707 -> { StargateData.id= 50011707; name= "Stargate (SPLE-Y)"; solarSystemId= 30004572; position= {x = 2.434390057e+12;  y = 3.144606106e+11;  z = -1.347730268e+12;}; typeId= 3875; destinationSolarSystemId= 30004570; destinationStargateId= 50011654 } |> Some
      | 50011804 -> { StargateData.id= 50011804; name= "Stargate (VR-YRV)"; solarSystemId= 30003174; position= {x = 1.416083988e+12;  y = 2.673845453e+11;  z = 1.669158912e+11;}; typeId= 29624; destinationSolarSystemId= 30003175; destinationStargateId= 50012215 } |> Some
      | 50011901 -> { StargateData.id= 50011901; name= "Stargate (Keproh)"; solarSystemId= 30005079; position= {x = -6.761631744e+10;  y = -8031313920.0;  z = -1.257750405e+12;}; typeId= 29624; destinationSolarSystemId= 30005078; destinationStargateId= 50011858 } |> Some
      | 50011998 -> { StargateData.id= 50011998; name= "Stargate (ESC-RI)"; solarSystemId= 30004605; position= {x = 2.531104481e+12;  y = 4.996579738e+11;  z = 3.404943237e+12;}; typeId= 3875; destinationSolarSystemId= 30004603; destinationStargateId= 50011941 } |> Some
      | 50012095 -> { StargateData.id= 50012095; name= "Stargate (R-ZESX)"; solarSystemId= 30003220; position= {x = 1.377132503e+12;  y = -2.253939917e+11;  z = 2.995781591e+12;}; typeId= 3875; destinationSolarSystemId= 30003218; destinationStargateId= 50011527 } |> Some
      | 50012192 -> { StargateData.id= 50012192; name= "Stargate (75FA-Z)"; solarSystemId= 30004617; position= {x = 3.050167296e+12;  y = -2.555416166e+11;  z = -3.518953267e+12;}; typeId= 3875; destinationSolarSystemId= 30004620; destinationStargateId= 50012363 } |> Some
      | 50012289 -> { StargateData.id= 50012289; name= "Stargate (JUE-DX)"; solarSystemId= 30001802; position= {x = 2.939497636e+12;  y = 2.826732134e+12;  z = 2.13177004e+12;}; typeId= 3874; destinationSolarSystemId= 30001743; destinationStargateId= 50003478 } |> Some
      | 50012386 -> { StargateData.id= 50012386; name= "Stargate (BE-UUN)"; solarSystemId= 30002497; position= {x = -8.211811123e+11;  y = -5.729931264e+10;  z = 2.573450035e+11;}; typeId= 16; destinationSolarSystemId= 30002498; destinationStargateId= 50013249 } |> Some
      | 50012483 -> { StargateData.id= 50012483; name= "Stargate (Z-40CG)"; solarSystemId= 30004541; position= {x = 2.475785011e+11;  y = -8564367360.0;  z = 2.465890591e+12;}; typeId= 3875; destinationSolarSystemId= 30004542; destinationStargateId= 50012756 } |> Some
      | 50012580 -> { StargateData.id= 50012580; name= "Stargate (0-NTIS)"; solarSystemId= 30004928; position= {x = -6.692671488e+10;  y = -1557012480.0;  z = -1.142178202e+11;}; typeId= 29624; destinationSolarSystemId= 30004930; destinationStargateId= 50012624 } |> Some
      | 50012677 -> { StargateData.id= 50012677; name= "Stargate (Akhmoh)"; solarSystemId= 30004146; position= {x = -2.18802303e+12;  y = -9.335451648e+10;  z = -4.33806336e+11;}; typeId= 29624; destinationSolarSystemId= 30004147; destinationStargateId= 50012886 } |> Some
      | 50012774 -> { StargateData.id= 50012774; name= "Stargate (2I-520)"; solarSystemId= 30004694; position= {x = 4.460956262e+12;  y = -7.536243917e+11;  z = 1.529268019e+12;}; typeId= 29624; destinationSolarSystemId= 30004693; destinationStargateId= 50012719 } |> Some
      | 50012871 -> { StargateData.id= 50012871; name= "Stargate (Heorah)"; solarSystemId= 30005292; position= {x = -1.518717297e+12;  y = 1.237818163e+11;  z = 5.090032312e+12;}; typeId= 29624; destinationSolarSystemId= 30005290; destinationStargateId= 50012745 } |> Some
      | 50012968 -> { StargateData.id= 50012968; name= "Stargate (Arza)"; solarSystemId= 30005085; position= {x = 2.741451571e+11;  y = -2700533760.0;  z = 2.109397279e+12;}; typeId= 29624; destinationSolarSystemId= 30005086; destinationStargateId= 50013022 } |> Some
      | 50013065 -> { StargateData.id= 50013065; name= "Stargate (MO-YDG)"; solarSystemId= 30004222; position= {x = 1.963025572e+12;  y = -1.849981747e+11;  z = 2.147785974e+12;}; typeId= 3875; destinationSolarSystemId= 30004223; destinationStargateId= 50013088 } |> Some
      | 50013162 -> { StargateData.id= 50013162; name= "Stargate (MO-YDG)"; solarSystemId= 30004224; position= {x = 6.620292096e+12;  y = 2.185225421e+11;  z = -8.260193894e+11;}; typeId= 3875; destinationSolarSystemId= 30004223; destinationStargateId= 50013089 } |> Some
      | 50013259 -> { StargateData.id= 50013259; name= "Stargate (PA-VE3)"; solarSystemId= 30004963; position= {x = 7.091175014e+11;  y = -6.590779392e+10;  z = -6.988197888e+10;}; typeId= 29624; destinationSolarSystemId= 30004961; destinationStargateId= 50013231 } |> Some
      | 50013356 -> { StargateData.id= 50013356; name= "Stargate (ZV-72W)"; solarSystemId= 30003373; position= {x = 1.108930191e+12;  y = 1.11529943e+11;  z = -4.618743398e+11;}; typeId= 3875; destinationSolarSystemId= 30003369; destinationStargateId= 50012859 } |> Some
      | 50013453 -> { StargateData.id= 50013453; name= "Stargate (1H4V-O)"; solarSystemId= 30001955; position= {x = 8.396172902e+11;  y = 3.732590592e+10;  z = 2.645051105e+12;}; typeId= 29624; destinationSolarSystemId= 30001952; destinationStargateId= 50013242 } |> Some
      | 50013550 -> { StargateData.id= 50013550; name= "Stargate (Liparer)"; solarSystemId= 30005053; position= {x = 8.48781865e+12;  y = 4.775956439e+12;  z = -1.373905674e+12;}; typeId= 17; destinationSolarSystemId= 30005087; destinationStargateId= 50013549 } |> Some
      | 50013647 -> { StargateData.id= 50013647; name= "Stargate (93PI-4)"; solarSystemId= 30001442; position= {x = -4.260031488e+12;  y = 8.055036518e+12;  z = -1.934712422e+11;}; typeId= 3873; destinationSolarSystemId= 30001990; destinationStargateId= 50013648 } |> Some
      | 50013841 -> { StargateData.id= 50013841; name= "Stargate (EOY-BG)"; solarSystemId= 30001346; position= {x = 4.516315546e+11;  y = -3.927084442e+12;  z = 3.924059873e+12;}; typeId= 12292; destinationSolarSystemId= 30003612; destinationStargateId= 50013842 } |> Some
      | 50013938 -> { StargateData.id= 50013938; name= "Stargate (Vullat)"; solarSystemId= 30002543; position= {x = 1.152014623e+12;  y = -8.011084186e+11;  z = -1.739180237e+12;}; typeId= 3877; destinationSolarSystemId= 30002573; destinationStargateId= 50013937 } |> Some
      | 50014035 -> { StargateData.id= 50014035; name= "Stargate (X6AB-Y)"; solarSystemId= 30003756; position= {x = -2.230134743e+12;  y = 1.599864054e+12;  z = 1.134296678e+11;}; typeId= 17; destinationSolarSystemId= 30003773; destinationStargateId= 50014036 } |> Some
      | 50014132 -> { StargateData.id= 50014132; name= "Stargate (Assiad)"; solarSystemId= 30011672; position= {x = -2.957064192e+11;  y = 4.816883712e+10;  z = 8.587224269e+11;}; typeId= 29624; destinationSolarSystemId= 30001723; destinationStargateId= 50014131 } |> Some
      | 50014229 -> { StargateData.id= 50014229; name= "Stargate (RT64-C)"; solarSystemId= 30000647; position= {x = 8.269407437e+11;  y = 4.319668224e+11;  z = 6.703978783e+12;}; typeId= 29635; destinationSolarSystemId= 30001773; destinationStargateId= 50014230 } |> Some
      | 50016266 -> { StargateData.id= 50016266; name= "Stargate (Kinakka)"; solarSystemId= 30045315; position= {x = 4.000928686e+12;  y = 3.111381811e+11;  z = -2.006481101e+12;}; typeId= 16; destinationSolarSystemId= 30045314; destinationStargateId= 50016265 } |> Some
      | 50016363 -> { StargateData.id= 50016363; name= "Stargate (Rakapas)"; solarSystemId= 30045353; position= {x = 1.118951424e+11;  y = 1.597427712e+10;  z = 6.357121843e+11;}; typeId= 16; destinationSolarSystemId= 30045349; destinationStargateId= 50016364 } |> Some
      | _ -> None