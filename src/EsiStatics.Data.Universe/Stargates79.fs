﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stargates79=
    let getStargate id = 
      match id with 
      | 50000087 -> { StargateData.id= 50000087; name= "Stargate (ETO-OT)"; solarSystemId= 30001534; position= {x = -4.157348659e+11;  y = 6.9817344e+10;  z = 3.733513421e+11;}; typeId= 3875; destinationSolarSystemId= 30001535; destinationStargateId= 50000331 } |> Some
      | 50000184 -> { StargateData.id= 50000184; name= "Stargate (Ongund)"; solarSystemId= 30003381; position= {x = -2.217099878e+12;  y = -1.642278912e+10;  z = -1.862955049e+12;}; typeId= 29633; destinationSolarSystemId= 30003386; destinationStargateId= 50002487 } |> Some
      | 50000281 -> { StargateData.id= 50000281; name= "Stargate (S-E6ES)"; solarSystemId= 30000659; position= {x = 1.128395366e+12;  y = -1.68230953e+11;  z = 8.666110771e+11;}; typeId= 29633; destinationSolarSystemId= 30000657; destinationStargateId= 50000169 } |> Some
      | 50000378 -> { StargateData.id= 50000378; name= "Stargate (M-OEE8)"; solarSystemId= 30000846; position= {x = -3.54015105e+12;  y = -1.573834752e+10;  z = -1.70233172e+12;}; typeId= 16; destinationSolarSystemId= 30000848; destinationStargateId= 50000915 } |> Some
      | 50000572 -> { StargateData.id= 50000572; name= "Stargate (LQ-OAI)"; solarSystemId= 30000703; position= {x = -8.577214464e+11;  y = -5.98505472e+10;  z = -7.38702336e+11;}; typeId= 29633; destinationSolarSystemId= 30000704; destinationStargateId= 50001511 } |> Some
      | 50000669 -> { StargateData.id= 50000669; name= "Stargate (Alles)"; solarSystemId= 30002712; position= {x = -2.189765714e+12;  y = -2.557762806e+12;  z = -2.393112207e+12;}; typeId= 3874; destinationSolarSystemId= 30002664; destinationStargateId= 50002952 } |> Some
      | 50000766 -> { StargateData.id= 50000766; name= "Stargate (R-6KYM)"; solarSystemId= 30002323; position= {x = -6.812517581e+11;  y = -6.588321792e+10;  z = -5.102358528e+10;}; typeId= 3875; destinationSolarSystemId= 30002324; destinationStargateId= 50001345 } |> Some
      | 50000863 -> { StargateData.id= 50000863; name= "Stargate (Camal)"; solarSystemId= 30000045; position= {x = -1.001793085e+12;  y = -1.843577242e+11;  z = -2.597622989e+11;}; typeId= 29624; destinationSolarSystemId= 30000049; destinationStargateId= 50002513 } |> Some
      | 50000960 -> { StargateData.id= 50000960; name= "Stargate (Irshah)"; solarSystemId= 30000085; position= {x = 1.160741069e+12;  y = 2.50887721e+12;  z = -5.648903823e+12;}; typeId= 17; destinationSolarSystemId= 30000073; destinationStargateId= 50001641 } |> Some
      | 50001057 -> { StargateData.id= 50001057; name= "Stargate (G9NE-B)"; solarSystemId= 30000566; position= {x = 1.684768236e+12;  y = 2.935547904e+11;  z = -5.566797005e+11;}; typeId= 29633; destinationSolarSystemId= 30000570; destinationStargateId= 50001860 } |> Some
      | 50001154 -> { StargateData.id= 50001154; name= "Stargate (RERZ-L)"; solarSystemId= 30000779; position= {x = 2.066570035e+11;  y = 2.557145088e+10;  z = -1.328369664e+10;}; typeId= 29633; destinationSolarSystemId= 30000780; destinationStargateId= 50001161 } |> Some
      | 50001251 -> { StargateData.id= 50001251; name= "Stargate (504Z-V)"; solarSystemId= 30000913; position= {x = 7.363223962e+11;  y = -3.579260928e+10;  z = -1.549205791e+12;}; typeId= 29633; destinationSolarSystemId= 30000912; destinationStargateId= 50000836 } |> Some
      | 50001348 -> { StargateData.id= 50001348; name= "Stargate (C8H5-X)"; solarSystemId= 30000747; position= {x = 2.345668608e+10;  y = 717004800.0;  z = 1.064261345e+12;}; typeId= 29633; destinationSolarSystemId= 30000743; destinationStargateId= 50000234 } |> Some
      | 50001445 -> { StargateData.id= 50001445; name= "Stargate (Sendaya)"; solarSystemId= 30000013; position= {x = 3.579704402e+12;  y = -1.574597837e+11;  z = -9.29888256e+10;}; typeId= 29624; destinationSolarSystemId= 30000015; destinationStargateId= 50001596 } |> Some
      | 50001542 -> { StargateData.id= 50001542; name= "Stargate (DAI-SH)"; solarSystemId= 30001084; position= {x = -2.684727706e+11;  y = 5.0924544e+10;  z = 2.661284659e+11;}; typeId= 3875; destinationSolarSystemId= 30001083; destinationStargateId= 50000745 } |> Some
      | 50001639 -> { StargateData.id= 50001639; name= "Stargate (AF0-V5)"; solarSystemId= 30002105; position= {x = -9.904730112e+10;  y = 1.451618304e+10;  z = -9.475769549e+11;}; typeId= 29633; destinationSolarSystemId= 30002107; destinationStargateId= 50001855 } |> Some
      | 50001736 -> { StargateData.id= 50001736; name= "Stargate (7-JT09)"; solarSystemId= 30000762; position= {x = -2.193709916e+12;  y = -1.450830643e+11;  z = -1.505822515e+12;}; typeId= 29633; destinationSolarSystemId= 30000759; destinationStargateId= 50000296 } |> Some
      | 50001833 -> { StargateData.id= 50001833; name= "Stargate (Isutaka)"; solarSystemId= 30002776; position= {x = 6.342344294e+11;  y = 9.253195776e+10;  z = -7.308131942e+11;}; typeId= 16; destinationSolarSystemId= 30002777; destinationStargateId= 50003885 } |> Some
      | 50001930 -> { StargateData.id= 50001930; name= "Stargate (0-TRV1)"; solarSystemId= 30001068; position= {x = -7.48923605e+12;  y = 1.326665687e+12;  z = 7.761639629e+12;}; typeId= 3875; destinationSolarSystemId= 30001065; destinationStargateId= 50001110 } |> Some
      | 50002027 -> { StargateData.id= 50002027; name= "Stargate (W2T-TR)"; solarSystemId= 30000623; position= {x = 3.344862044e+12;  y = -5.044998144e+10;  z = -1.004088975e+12;}; typeId= 29633; destinationSolarSystemId= 30000617; destinationStargateId= 50001069 } |> Some
      | 50002124 -> { StargateData.id= 50002124; name= "Stargate (A-4JOO)"; solarSystemId= 30000588; position= {x = 9.307314954e+12;  y = -1.472734372e+12;  z = 3.433568256e+11;}; typeId= 29633; destinationSolarSystemId= 30000587; destinationStargateId= 50001796 } |> Some
      | 50002221 -> { StargateData.id= 50002221; name= "Stargate (Iidoken)"; solarSystemId= 30001410; position= {x = 1.200275497e+12;  y = 5.760301056e+11;  z = -8.8194961e+12;}; typeId= 29627; destinationSolarSystemId= 30001374; destinationStargateId= 50000463 } |> Some
      | 50002318 -> { StargateData.id= 50002318; name= "Stargate (ZXIC-7)"; solarSystemId= 30001169; position= {x = -1.635785318e+12;  y = 1.156100506e+11;  z = -2.26716672e+11;}; typeId= 29624; destinationSolarSystemId= 30001168; destinationStargateId= 50001817 } |> Some
      | 50002415 -> { StargateData.id= 50002415; name= "Stargate (WFFE-4)"; solarSystemId= 30000721; position= {x = -1.172471439e+12;  y = 7.32481536e+10;  z = 3.408198574e+12;}; typeId= 29633; destinationSolarSystemId= 30000725; destinationStargateId= 50003192 } |> Some
      | 50002512 -> { StargateData.id= 50002512; name= "Stargate (VVB-QH)"; solarSystemId= 30001071; position= {x = -1.128171479e+12;  y = -1.2530688e+10;  z = -3.990861619e+12;}; typeId= 3875; destinationSolarSystemId= 30001073; destinationStargateId= 50002921 } |> Some
      | 50002609 -> { StargateData.id= 50002609; name= "Stargate (DL1C-E)"; solarSystemId= 30000880; position= {x = 4.054369935e+12;  y = -5.862669926e+11;  z = 3.755544576e+10;}; typeId= 16; destinationSolarSystemId= 30000879; destinationStargateId= 50002352 } |> Some
      | 50002706 -> { StargateData.id= 50002706; name= "Stargate (Jorund)"; solarSystemId= 30001044; position= {x = -5.682252595e+11;  y = -1.007603712e+10;  z = 1.659799757e+12;}; typeId= 29633; destinationSolarSystemId= 30001046; destinationStargateId= 50003219 } |> Some
      | 50002803 -> { StargateData.id= 50002803; name= "Stargate (Hedion)"; solarSystemId= 30002190; position= {x = 1.032070349e+11;  y = 1.188532224e+10;  z = 8.37050327e+11;}; typeId= 29624; destinationSolarSystemId= 30002189; destinationStargateId= 50000799 } |> Some
      | 50002900 -> { StargateData.id= 50002900; name= "Stargate (Jolia)"; solarSystemId= 30002677; position= {x = 2.377645302e+12;  y = 7.3208832e+10;  z = 2.949917491e+11;}; typeId= 3875; destinationSolarSystemId= 30002679; destinationStargateId= 50009776 } |> Some
      | 50002997 -> { StargateData.id= 50002997; name= "Stargate (VVB-QH)"; solarSystemId= 30001074; position= {x = -6.013662413e+11;  y = -6.685863936e+10;  z = 8.802545664e+10;}; typeId= 3875; destinationSolarSystemId= 30001073; destinationStargateId= 50002922 } |> Some
      | 50003094 -> { StargateData.id= 50003094; name= "Stargate (Jofan)"; solarSystemId= 30000077; position= {x = -5.64728832e+11;  y = 5.582303232e+10;  z = 2.103824794e+11;}; typeId= 29624; destinationSolarSystemId= 30000078; destinationStargateId= 50003253 } |> Some
      | 50003191 -> { StargateData.id= 50003191; name= "Stargate (3GXF-U)"; solarSystemId= 30003708; position= {x = 6.650483098e+11;  y = -3.980125102e+12;  z = -7.447320576e+11;}; typeId= 17; destinationSolarSystemId= 30003748; destinationStargateId= 50005410 } |> Some
      | 50003288 -> { StargateData.id= 50003288; name= "Stargate (Mesybier)"; solarSystemId= 30005295; position= {x = 3.412343316e+12;  y = 1.723733238e+12;  z = -2.733570908e+12;}; typeId= 29632; destinationSolarSystemId= 30004975; destinationStargateId= 50002781 } |> Some
      | 50003385 -> { StargateData.id= 50003385; name= "Stargate (QR-K85)"; solarSystemId= 30003717; position= {x = -3.758558208e+12;  y = 7.152047309e+11;  z = -1.882590536e+12;}; typeId= 29624; destinationSolarSystemId= 30003719; destinationStargateId= 50004024 } |> Some
      | 50003482 -> { StargateData.id= 50003482; name= "Stargate (Chesoh)"; solarSystemId= 30003524; position= {x = -3.258126336e+10;  y = -3927613440.0;  z = 1.006145126e+11;}; typeId= 29624; destinationSolarSystemId= 30003527; destinationStargateId= 50004167 } |> Some
      | 50003579 -> { StargateData.id= 50003579; name= "Stargate (FSW-3C)"; solarSystemId= 30003713; position= {x = 1.285797519e+12;  y = -3.652866048e+10;  z = -3.470051697e+12;}; typeId= 29624; destinationSolarSystemId= 30003710; destinationStargateId= 50003207 } |> Some
      | 50003676 -> { StargateData.id= 50003676; name= "Stargate (IR-DYY)"; solarSystemId= 30000276; position= {x = 9.111656448e+11;  y = -1.093377638e+11;  z = 7.996552397e+11;}; typeId= 16; destinationSolarSystemId= 30000277; destinationStargateId= 50003850 } |> Some
      | 50003870 -> { StargateData.id= 50003870; name= "Stargate (Reset)"; solarSystemId= 30003389; position= {x = 8.976390144e+11;  y = -1.03577641e+11;  z = 4.821201592e+12;}; typeId= 29633; destinationSolarSystemId= 30003391; destinationStargateId= 50004455 } |> Some
      | 50003967 -> { StargateData.id= 50003967; name= "Stargate (Sifilar)"; solarSystemId= 30002958; position= {x = -5.505450394e+11;  y = 9.640218624e+10;  z = 1.734086246e+11;}; typeId= 29624; destinationSolarSystemId= 30002959; destinationStargateId= 50004260 } |> Some
      | 50004064 -> { StargateData.id= 50004064; name= "Stargate (Gammel)"; solarSystemId= 30003071; position= {x = -3.497999278e+12;  y = -5.795896934e+11;  z = -5.493571707e+12;}; typeId= 29624; destinationSolarSystemId= 30003076; destinationStargateId= 50004852 } |> Some
      | 50004161 -> { StargateData.id= 50004161; name= "Stargate (XCF-8N)"; solarSystemId= 30002896; position= {x = -1.138958131e+12;  y = 1.018243891e+11;  z = -2.41661055e+12;}; typeId= 16; destinationSolarSystemId= 30002897; destinationStargateId= 50004711 } |> Some
      | 50004355 -> { StargateData.id= 50004355; name= "Stargate (Laurvier)"; solarSystemId= 30005003; position= {x = 5.933070336e+11;  y = 1.161703834e+11;  z = 3.813248901e+12;}; typeId= 3875; destinationSolarSystemId= 30005002; destinationStargateId= 50004045 } |> Some
      | 50004452 -> { StargateData.id= 50004452; name= "Stargate (Bridi)"; solarSystemId= 30005030; position= {x = 6.484071629e+11;  y = -8.510951424e+10;  z = -2.267429806e+12;}; typeId= 29624; destinationSolarSystemId= 30005034; destinationStargateId= 50005982 } |> Some
      | 50004549 -> { StargateData.id= 50004549; name= "Stargate (Vard)"; solarSystemId= 30002537; position= {x = -3.549220454e+11;  y = -4.715925504e+10;  z = -5.208625152e+10;}; typeId= 29633; destinationSolarSystemId= 30002538; destinationStargateId= 50006870 } |> Some
      | 50004646 -> { StargateData.id= 50004646; name= "Stargate (P7-45V)"; solarSystemId= 30000641; position= {x = -1.447190815e+12;  y = 2.570781082e+11;  z = 2.178590269e+12;}; typeId= 29633; destinationSolarSystemId= 30000638; destinationStargateId= 50004117 } |> Some
      | 50004743 -> { StargateData.id= 50004743; name= "Stargate (Reisen)"; solarSystemId= 30000161; position= {x = -5.44425984e+10;  y = -5446410240.0;  z = -1.87825152e+11;}; typeId= 16; destinationSolarSystemId= 30000160; destinationStargateId= 50004571 } |> Some
      | 50004840 -> { StargateData.id= 50004840; name= "Stargate (Y9-MDG)"; solarSystemId= 30003733; position= {x = -4.715575296e+11;  y = 8911134720.0;  z = -8.224321536e+10;}; typeId= 29624; destinationSolarSystemId= 30003734; destinationStargateId= 50004941 } |> Some
      | 50004937 -> { StargateData.id= 50004937; name= "Stargate (BVRQ-O)"; solarSystemId= 30002829; position= {x = 1.251115377e+12;  y = 5.893189632e+10;  z = 1.168908902e+12;}; typeId= 3875; destinationSolarSystemId= 30002828; destinationStargateId= 50002530 } |> Some
      | 50005034 -> { StargateData.id= 50005034; name= "Stargate (Sinid)"; solarSystemId= 30001678; position= {x = 7.033106842e+11;  y = 1.508898202e+12;  z = -1.842597519e+12;}; typeId= 17; destinationSolarSystemId= 30001729; destinationStargateId= 50006053 } |> Some
      | 50005131 -> { StargateData.id= 50005131; name= "Stargate (Aralgrund)"; solarSystemId= 30002553; position= {x = 7.03115305e+11;  y = 1.042195661e+11;  z = -7.72438057e+11;}; typeId= 29633; destinationSolarSystemId= 30002551; destinationStargateId= 50004790 } |> Some
      | 50005228 -> { StargateData.id= 50005228; name= "Stargate (52V6-B)"; solarSystemId= 30000990; position= {x = -5.865528115e+11;  y = -4.375842816e+10;  z = 1.418773094e+12;}; typeId= 29633; destinationSolarSystemId= 30000989; destinationStargateId= 50004424 } |> Some
      | 50005325 -> { StargateData.id= 50005325; name= "Stargate (Merz)"; solarSystemId= 30003539; position= {x = 5.98315733e+12;  y = -1.187873219e+12;  z = -1.605728625e+12;}; typeId= 29624; destinationSolarSystemId= 30003538; destinationStargateId= 50005260 } |> Some
      | 50005422 -> { StargateData.id= 50005422; name= "Stargate (O-O2GN)"; solarSystemId= 30001752; position= {x = -1.48428927e+12;  y = -2.618414285e+11;  z = -3.218667479e+12;}; typeId= 3875; destinationSolarSystemId= 30001751; destinationStargateId= 50005346 } |> Some
      | 50005519 -> { StargateData.id= 50005519; name= "Stargate (Ekid)"; solarSystemId= 30002231; position= {x = 1.456582287e+12;  y = -3.060107796e+12;  z = 3.609981542e+12;}; typeId= 17; destinationSolarSystemId= 30003494; destinationStargateId= 50007719 } |> Some
      | 50005616 -> { StargateData.id= 50005616; name= "Stargate (Ishisomo)"; solarSystemId= 30000166; position= {x = -9.571048243e+11;  y = 1.406114611e+11;  z = 2.195048571e+12;}; typeId= 16; destinationSolarSystemId= 30000165; destinationStargateId= 50005009 } |> Some
      | 50005713 -> { StargateData.id= 50005713; name= "Stargate (PZOZ-K)"; solarSystemId= 30001309; position= {x = 4.123626086e+12;  y = 5.041716019e+11;  z = 3.00801282e+12;}; typeId= 16; destinationSolarSystemId= 30001310; destinationStargateId= 50005803 } |> Some
      | 50005810 -> { StargateData.id= 50005810; name= "Stargate (9-MJVQ)"; solarSystemId= 30004827; position= {x = -3.494886973e+12;  y = -7.047159398e+11;  z = 1.838021714e+12;}; typeId= 29633; destinationSolarSystemId= 30004826; destinationStargateId= 50005772 } |> Some
      | 50005907 -> { StargateData.id= 50005907; name= "Stargate (ZM-DNR)"; solarSystemId= 30000934; position= {x = -3.344465142e+12;  y = 4.342659072e+11;  z = -8.420906189e+11;}; typeId= 29633; destinationSolarSystemId= 30000935; destinationStargateId= 50005940 } |> Some
      | 50006004 -> { StargateData.id= 50006004; name= "Stargate (RVCZ-C)"; solarSystemId= 30000300; position= {x = -3.055937249e+12;  y = 3.721269658e+11;  z = 3.993210839e+12;}; typeId= 16; destinationSolarSystemId= 30000298; destinationStargateId= 50004185 } |> Some
      | 50006101 -> { StargateData.id= 50006101; name= "Stargate (EH2I-P)"; solarSystemId= 30005114; position= {x = 1.135717171e+11;  y = 2.228539392e+10;  z = -1.384280064e+10;}; typeId= 3875; destinationSolarSystemId= 30005108; destinationStargateId= 50005581 } |> Some
      | 50006198 -> { StargateData.id= 50006198; name= "Stargate (89-JPE)"; solarSystemId= 30002348; position= {x = -1.541533901e+12;  y = -1.669748736e+11;  z = -4.860780134e+11;}; typeId= 3875; destinationSolarSystemId= 30002346; destinationStargateId= 50005845 } |> Some
      | 50006295 -> { StargateData.id= 50006295; name= "Stargate (Hysera)"; solarSystemId= 30002799; position= {x = -1.64085289e+12;  y = 4.701671424e+10;  z = 1.887429059e+12;}; typeId= 16; destinationSolarSystemId= 30002796; destinationStargateId= 50004917 } |> Some
      | 50006392 -> { StargateData.id= 50006392; name= "Stargate (Ahala)"; solarSystemId= 30002244; position= {x = -3.786438205e+12;  y = 6.938024755e+11;  z = -3.940787282e+12;}; typeId= 29624; destinationSolarSystemId= 30002247; destinationStargateId= 50008612 } |> Some
      | 50006489 -> { StargateData.id= 50006489; name= "Stargate (Neyi)"; solarSystemId= 30003858; position= {x = -2.537126707e+11;  y = 487464960.0;  z = -2.136144568e+12;}; typeId= 29624; destinationSolarSystemId= 30003859; destinationStargateId= 50006495 } |> Some
      | 50006586 -> { StargateData.id= 50006586; name= "Stargate (Jarkkolen)"; solarSystemId= 30003081; position= {x = 5.535283569e+12;  y = -2.590314086e+11;  z = -1.232577958e+13;}; typeId= 29624; destinationSolarSystemId= 30003080; destinationStargateId= 50006478 } |> Some
      | 50006683 -> { StargateData.id= 50006683; name= "Stargate (KW-OAM)"; solarSystemId= 30004832; position= {x = -2.002605466e+12;  y = 5.711425536e+10;  z = -1.676449751e+12;}; typeId= 29633; destinationSolarSystemId= 30004833; destinationStargateId= 50006992 } |> Some
      | 50006780 -> { StargateData.id= 50006780; name= "Stargate (Enedore)"; solarSystemId= 30003046; position= {x = 7.493103206e+11;  y = -1.18293504e+11;  z = -8.177667686e+11;}; typeId= 3875; destinationSolarSystemId= 30003045; destinationStargateId= 50005218 } |> Some
      | 50006877 -> { StargateData.id= 50006877; name= "Stargate (8-JYPM)"; solarSystemId= 30003284; position= {x = 2.826487357e+12;  y = 5.348476109e+11;  z = -3.395551519e+12;}; typeId= 3875; destinationSolarSystemId= 30003282; destinationStargateId= 50006703 } |> Some
      | 50006974 -> { StargateData.id= 50006974; name= "Stargate (RD-G2R)"; solarSystemId= 30002024; position= {x = 1.341331907e+12;  y = -1.375072666e+11;  z = 5.964486451e+12;}; typeId= 16; destinationSolarSystemId= 30002023; destinationStargateId= 50006383 } |> Some
      | 50007071 -> { StargateData.id= 50007071; name= "Stargate (Gasavak)"; solarSystemId= 30004116; position= {x = 5.17687296e+10;  y = -9805455360.0;  z = -3.897102336e+10;}; typeId= 29624; destinationSolarSystemId= 30004119; destinationStargateId= 50008667 } |> Some
      | 50007168 -> { StargateData.id= 50007168; name= "Stargate (Hrober)"; solarSystemId= 30002391; position= {x = 1.132843008e+10;  y = 754851840.0;  z = 6.338998272e+10;}; typeId= 29633; destinationSolarSystemId= 30002392; destinationStargateId= 50007836 } |> Some
      | 50007265 -> { StargateData.id= 50007265; name= "Stargate (Z0H2-4)"; solarSystemId= 30001093; position= {x = -6.581458944e+11;  y = 1.278552883e+11;  z = -1.148076442e+11;}; typeId= 3875; destinationSolarSystemId= 30001091; destinationStargateId= 50002833 } |> Some
      | 50007362 -> { StargateData.id= 50007362; name= "Stargate (EOA-ZC)"; solarSystemId= 30002473; position= {x = -2.199462298e+11;  y = -2.243555328e+10;  z = -8.23928832e+10;}; typeId= 16; destinationSolarSystemId= 30002475; destinationStargateId= 50008570 } |> Some
      | 50007459 -> { StargateData.id= 50007459; name= "Stargate (P-6I0B)"; solarSystemId= 30002481; position= {x = 2.064374292e+12;  y = -2.932016333e+11;  z = -9.739194778e+11;}; typeId= 16; destinationSolarSystemId= 30002482; destinationStargateId= 50007575 } |> Some
      | 50007556 -> { StargateData.id= 50007556; name= "Stargate (Ardhis)"; solarSystemId= 30004117; position= {x = -1.766537011e+12;  y = 2.739030835e+11;  z = 2.52386304e+11;}; typeId= 29624; destinationSolarSystemId= 30004118; destinationStargateId= 50008263 } |> Some
      | 50007653 -> { StargateData.id= 50007653; name= "Stargate (Chantrousse)"; solarSystemId= 30005332; position= {x = 1.801923379e+11;  y = -5031813120.0;  z = 4.086321562e+11;}; typeId= 3875; destinationSolarSystemId= 30005331; destinationStargateId= 50006707 } |> Some
      | 50007750 -> { StargateData.id= 50007750; name= "Stargate (Alra)"; solarSystemId= 30001732; position= {x = 8.499969638e+11;  y = -6.672003072e+10;  z = 3.062323569e+12;}; typeId= 29624; destinationSolarSystemId= 30001730; destinationStargateId= 50007177 } |> Some
      | 50007847 -> { StargateData.id= 50007847; name= "Stargate (J9A-BH)"; solarSystemId= 30003196; position= {x = -1.556655022e+12;  y = -4.913575404e+12;  z = 3.647514993e+12;}; typeId= 29632; destinationSolarSystemId= 30005158; destinationStargateId= 50008279 } |> Some
      | 50007944 -> { StargateData.id= 50007944; name= "Stargate (6Q4-X6)"; solarSystemId= 30005127; position= {x = 5.96592599e+11;  y = 7.729410048e+10;  z = 1.751519232e+10;}; typeId= 3875; destinationSolarSystemId= 30005128; destinationStargateId= 50008262 } |> Some
      | 50008041 -> { StargateData.id= 50008041; name= "Stargate (Madimal)"; solarSystemId= 30002223; position= {x = 2.266920346e+12;  y = 1.22162049e+12;  z = -2.439493755e+12;}; typeId= 17; destinationSolarSystemId= 30003558; destinationStargateId= 50010606 } |> Some
      | 50008138 -> { StargateData.id= 50008138; name= "Stargate (KTHT-O)"; solarSystemId= 30003294; position= {x = -1.724928614e+12;  y = -2.515485082e+11;  z = 8.186402365e+12;}; typeId= 3875; destinationSolarSystemId= 30003300; destinationStargateId= 50013171 } |> Some
      | 50008235 -> { StargateData.id= 50008235; name= "Stargate (Gaha)"; solarSystemId= 30002209; position= {x = -1.209006612e+12;  y = -9278054400.0;  z = 2.217055887e+12;}; typeId= 29624; destinationSolarSystemId= 30002204; destinationStargateId= 50001203 } |> Some
      | 50008332 -> { StargateData.id= 50008332; name= "Stargate (Eldulf)"; solarSystemId= 30002400; position= {x = 5.997047808e+10;  y = -1.108586496e+10;  z = 8.14307328e+10;}; typeId= 29633; destinationSolarSystemId= 30002398; destinationStargateId= 50006897 } |> Some
      | 50008429 -> { StargateData.id= 50008429; name= "Stargate (Z-ENUD)"; solarSystemId= 30005134; position= {x = -1.335670825e+12;  y = -2.565276058e+11;  z = -3.156106322e+12;}; typeId= 3875; destinationSolarSystemId= 30005132; destinationStargateId= 50008018 } |> Some
      | 50008526 -> { StargateData.id= 50008526; name= "Stargate (6YC-TU)"; solarSystemId= 30002499; position= {x = 2.320940114e+12;  y = 4.43142058e+12;  z = 1.464708833e+12;}; typeId= 29627; destinationSolarSystemId= 30002465; destinationStargateId= 50007209 } |> Some
      | 50008623 -> { StargateData.id= 50008623; name= "Stargate (UTKS-5)"; solarSystemId= 30003307; position= {x = -3.107427533e+11;  y = -4.33133568e+10;  z = 5.113871032e+12;}; typeId= 3875; destinationSolarSystemId= 30003306; destinationStargateId= 50008561 } |> Some
      | 50008720 -> { StargateData.id= 50008720; name= "Stargate (TSG-NO)"; solarSystemId= 30004884; position= {x = -1.774133699e+12;  y = 1.56416041e+11;  z = 4.204967117e+11;}; typeId= 29635; destinationSolarSystemId= 30004423; destinationStargateId= 50008627 } |> Some
      | 50008817 -> { StargateData.id= 50008817; name= "Stargate (KLYN-8)"; solarSystemId= 30003342; position= {x = 3.964975104e+11;  y = -4.443328512e+10;  z = -1.754391552e+12;}; typeId= 3875; destinationSolarSystemId= 30003344; destinationStargateId= 50009171 } |> Some
      | 50008914 -> { StargateData.id= 50008914; name= "Stargate (Angur)"; solarSystemId= 30005266; position= {x = 7.048373453e+11;  y = 2318131200.0;  z = 2.210497044e+12;}; typeId= 29624; destinationSolarSystemId= 30005264; destinationStargateId= 50008445 } |> Some
      | 50009011 -> { StargateData.id= 50009011; name= "Stargate (Hostakoh)"; solarSystemId= 30004131; position= {x = -1.843636224e+11;  y = -1.244049408e+10;  z = 2.574904934e+11;}; typeId= 29624; destinationSolarSystemId= 30004130; destinationStargateId= 50008744 } |> Some
      | 50009108 -> { StargateData.id= 50009108; name= "Stargate (Abath)"; solarSystemId= 30003922; position= {x = -4.293833073e+12;  y = 2.18852438e+12;  z = -2.714110157e+12;}; typeId= 29626; destinationSolarSystemId= 30005062; destinationStargateId= 50009167 } |> Some
      | 50009205 -> { StargateData.id= 50009205; name= "Stargate (5-IZGE)"; solarSystemId= 30004415; position= {x = -2.267820319e+12;  y = 2.821436621e+11;  z = 6.542381015e+12;}; typeId= 29633; destinationSolarSystemId= 30004412; destinationStargateId= 50007630 } |> Some
      | 50009302 -> { StargateData.id= 50009302; name= "Stargate (M4-KX5)"; solarSystemId= 30005157; position= {x = 8.267910758e+11;  y = -1.638232474e+11;  z = 4.547246531e+12;}; typeId= 3875; destinationSolarSystemId= 30005153; destinationStargateId= 50007464 } |> Some
      | 50009399 -> { StargateData.id= 50009399; name= "Stargate (JU-OWQ)"; solarSystemId= 30002913; position= {x = -9.696459571e+11;  y = 1.71021312e+11;  z = -3.649860526e+12;}; typeId= 16; destinationSolarSystemId= 30002911; destinationStargateId= 50008699 } |> Some
      | 50009496 -> { StargateData.id= 50009496; name= "Stargate (J9SH-A)"; solarSystemId= 30004505; position= {x = -3.50914646e+12;  y = 3.037875855e+12;  z = 2.679493018e+11;}; typeId= 3874; destinationSolarSystemId= 30004514; destinationStargateId= 50009947 } |> Some
      | 50009593 -> { StargateData.id= 50009593; name= "Stargate (L3-XYO)"; solarSystemId= 30004506; position= {x = -6.50867712e+11;  y = 2.109105562e+12;  z = 3.780990935e+12;}; typeId= 3874; destinationSolarSystemId= 30004526; destinationStargateId= 50010621 } |> Some
      | 50009690 -> { StargateData.id= 50009690; name= "Stargate (Vasala)"; solarSystemId= 30000192; position= {x = 3.560028979e+11;  y = -2.036944896e+10;  z = -1.14628522e+12;}; typeId= 16; destinationSolarSystemId= 30000190; destinationStargateId= 50009381 } |> Some
      | 50009787 -> { StargateData.id= 50009787; name= "Stargate (Kurmaru)"; solarSystemId= 30003092; position= {x = -1.54537046e+12;  y = 1.757364634e+11;  z = -3.374174331e+12;}; typeId= 29624; destinationSolarSystemId= 30003096; destinationStargateId= 50012502 } |> Some
      | 50009884 -> { StargateData.id= 50009884; name= "Stargate (42-UOW)"; solarSystemId= 30001895; position= {x = 2.054829466e+12;  y = -9.62033664e+10;  z = 9.91559639e+11;}; typeId= 29624; destinationSolarSystemId= 30001894; destinationStargateId= 50009846 } |> Some
      | 50009981 -> { StargateData.id= 50009981; name= "Stargate (DS-LO3)"; solarSystemId= 30003994; position= {x = 1.479129907e+11;  y = -1.551888384e+10;  z = 7.841657242e+11;}; typeId= 29624; destinationSolarSystemId= 30003992; destinationStargateId= 50009837 } |> Some
      | 50010078 -> { StargateData.id= 50010078; name= "Stargate (1P-QWR)"; solarSystemId= 30003230; position= {x = 1.259668316e+12;  y = 2.00548393e+11;  z = 5.423049523e+11;}; typeId= 3875; destinationSolarSystemId= 30003233; destinationStargateId= 50011355 } |> Some
      | 50010175 -> { StargateData.id= 50010175; name= "Stargate (UC3H-Y)"; solarSystemId= 30002027; position= {x = 4.94227796e+12;  y = 3.624951398e+11;  z = -2.427220378e+11;}; typeId= 16; destinationSolarSystemId= 30002024; destinationStargateId= 50006976 } |> Some
      | 50010272 -> { StargateData.id= 50010272; name= "Stargate (D-W7F0)"; solarSystemId= 30004716; position= {x = -3.172808417e+12;  y = 7.436634931e+11;  z = -1.828098908e+12;}; typeId= 17; destinationSolarSystemId= 30004730; destinationStargateId= 50010543 } |> Some
      | 50010369 -> { StargateData.id= 50010369; name= "Stargate (L3-I3K)"; solarSystemId= 30004006; position= {x = -7.274532864e+10;  y = 1.196544e+10;  z = 4.83627049e+11;}; typeId= 29624; destinationSolarSystemId= 30004003; destinationStargateId= 50009635 } |> Some
      | 50010466 -> { StargateData.id= 50010466; name= "Stargate (W-IX39)"; solarSystemId= 30003974; position= {x = 2.807187456e+11;  y = 1.48973568e+10;  z = -6.209654784e+10;}; typeId= 29624; destinationSolarSystemId= 30003968; destinationStargateId= 50009053 } |> Some
      | 50010563 -> { StargateData.id= 50010563; name= "Stargate (TY2X-C)"; solarSystemId= 30004840; position= {x = 2.938540155e+12;  y = 3.114780672e+11;  z = 1.302345032e+12;}; typeId= 29633; destinationSolarSystemId= 30004844; destinationStargateId= 50012157 } |> Some
      | 50010660 -> { StargateData.id= 50010660; name= "Stargate (Dal)"; solarSystemId= 30002542; position= {x = 3.22981589e+12;  y = -2.027941478e+11;  z = 7.840413696e+11;}; typeId= 29633; destinationSolarSystemId= 30002541; destinationStargateId= 50009560 } |> Some
      | 50010757 -> { StargateData.id= 50010757; name= "Stargate (Angymonne)"; solarSystemId= 30003056; position= {x = 1.363510026e+12;  y = 1.449216e+11;  z = 1.074257879e+12;}; typeId= 3875; destinationSolarSystemId= 30003046; destinationStargateId= 50006785 } |> Some
      | 50010854 -> { StargateData.id= 50010854; name= "Stargate (IR-WT1)"; solarSystemId= 30004567; position= {x = 5.975598981e+12;  y = -2.917431828e+12;  z = -2.703253463e+12;}; typeId= 3874; destinationSolarSystemId= 30004556; destinationStargateId= 50010712 } |> Some
      | 50010951 -> { StargateData.id= 50010951; name= "Stargate (DL-CDY)"; solarSystemId= 30003171; position= {x = -2.894338867e+11;  y = 5.067239424e+10;  z = 2.64583127e+11;}; typeId= 29624; destinationSolarSystemId= 30003170; destinationStargateId= 50010507 } |> Some
      | 50011048 -> { StargateData.id= 50011048; name= "Stargate (EAWE-2)"; solarSystemId= 30001931; position= {x = 1.325332931e+12;  y = 2.302782259e+11;  z = 5.417372099e+12;}; typeId= 29624; destinationSolarSystemId= 30001933; destinationStargateId= 50012667 } |> Some
      | 50011145 -> { StargateData.id= 50011145; name= "Stargate (8ESL-G)"; solarSystemId= 30004576; position= {x = -6.362218906e+11;  y = 4.929490944e+10;  z = 3.204403323e+12;}; typeId= 3875; destinationSolarSystemId= 30004574; destinationStargateId= 50011042 } |> Some
      | 50011242 -> { StargateData.id= 50011242; name= "Stargate (Ruvas)"; solarSystemId= 30001409; position= {x = 7.530780672e+11;  y = 1.309339238e+11;  z = 1.739588813e+11;}; typeId= 16; destinationSolarSystemId= 30001408; destinationStargateId= 50010485 } |> Some
      | 50011339 -> { StargateData.id= 50011339; name= "Stargate (AL8-V4)"; solarSystemId= 30004581; position= {x = 4.790527304e+12;  y = -9.044355072e+11;  z = -1.702228378e+11;}; typeId= 3875; destinationSolarSystemId= 30004578; destinationStargateId= 50011241 } |> Some
      | 50011436 -> { StargateData.id= 50011436; name= "Stargate (Sarline)"; solarSystemId= 30003585; position= {x = -1.61503998e+12;  y = -2.736273408e+11;  z = 7.130928783e+12;}; typeId= 3875; destinationSolarSystemId= 30003584; destinationStargateId= 50011373 } |> Some
      | 50011533 -> { StargateData.id= 50011533; name= "Stargate (Afrah)"; solarSystemId= 30004273; position= {x = -1.724272681e+12;  y = -7.74243029e+12;  z = 2.31954985e+12;}; typeId= 17; destinationSolarSystemId= 30004271; destinationStargateId= 50011468 } |> Some
      | 50011630 -> { StargateData.id= 50011630; name= "Stargate (H23-B5)"; solarSystemId= 30004181; position= {x = 1.801069978e+12;  y = 3.095513088e+11;  z = -1.981878067e+12;}; typeId= 3875; destinationSolarSystemId= 30004178; destinationStargateId= 50011026 } |> Some
      | 50011727 -> { StargateData.id= 50011727; name= "Stargate (RP2-OQ)"; solarSystemId= 30004561; position= {x = -4.257180918e+12;  y = 3.425526989e+11;  z = 1.85543553e+12;}; typeId= 3875; destinationSolarSystemId= 30004560; destinationStargateId= 50011392 } |> Some
      | 50011824 -> { StargateData.id= 50011824; name= "Stargate (F-A3TR)"; solarSystemId= 30005183; position= {x = 7.546241434e+11;  y = 7.586942976e+10;  z = -2.015275131e+12;}; typeId= 3875; destinationSolarSystemId= 30005184; destinationStargateId= 50011957 } |> Some
      | 50011921 -> { StargateData.id= 50011921; name= "Stargate (UTDH-N)"; solarSystemId= 30004467; position= {x = 2.071020749e+11;  y = 1.812148224e+10;  z = 1.905334272e+11;}; typeId= 29633; destinationSolarSystemId= 30004468; destinationStargateId= 50012020 } |> Some
      | 50012018 -> { StargateData.id= 50012018; name= "Stargate (NY6-FH)"; solarSystemId= 30004609; position= {x = -5.531922432e+10;  y = -4573470720.0;  z = -4.925435904e+10;}; typeId= 3875; destinationSolarSystemId= 30004612; destinationStargateId= 50012132 } |> Some
      | 50012115 -> { StargateData.id= 50012115; name= "Stargate (CNHV-M)"; solarSystemId= 30001814; position= {x = 2.624822108e+12;  y = -4.65786581e+12;  z = -3.166351565e+12;}; typeId= 3874; destinationSolarSystemId= 30001825; destinationStargateId= 50012493 } |> Some
      | 50012212 -> { StargateData.id= 50012212; name= "Stargate (NDH-NV)"; solarSystemId= 30004613; position= {x = -3.056596378e+12;  y = 4.682582016e+11;  z = -3.090072822e+12;}; typeId= 3875; destinationSolarSystemId= 30004609; destinationStargateId= 50012019 } |> Some
      | 50012309 -> { StargateData.id= 50012309; name= "Stargate (B8HU-Z)"; solarSystemId= 30004846; position= {x = 5.568559104e+11;  y = 3.296710656e+10;  z = 1.389045965e+12;}; typeId= 29633; destinationSolarSystemId= 30004848; destinationStargateId= 50012358 } |> Some
      | 50012406 -> { StargateData.id= 50012406; name= "Stargate (Soliara)"; solarSystemId= 30004277; position= {x = -2.775088374e+12;  y = -2.173844275e+11;  z = -1.124707738e+12;}; typeId= 29624; destinationSolarSystemId= 30004273; destinationStargateId= 50011537 } |> Some
      | 50012503 -> { StargateData.id= 50012503; name= "Stargate (Kattegaud)"; solarSystemId= 30002418; position= {x = 8.165610701e+11;  y = 1.551125299e+11;  z = 2.131653304e+12;}; typeId= 29633; destinationSolarSystemId= 30002416; destinationStargateId= 50012136 } |> Some
      | 50012600 -> { StargateData.id= 50012600; name= "Stargate (7-K6UE)"; solarSystemId= 30004793; position= {x = 4.692146995e+11;  y = 6269214720.0;  z = 1.056578396e+12;}; typeId= 29624; destinationSolarSystemId= 30004790; destinationStargateId= 50012007 } |> Some
      | 50012697 -> { StargateData.id= 50012697; name= "Stargate (4LNE-M)"; solarSystemId= 30004205; position= {x = -3.423920333e+12;  y = -2.119278182e+11;  z = -1.338553098e+12;}; typeId= 3875; destinationSolarSystemId= 30004206; destinationStargateId= 50013004 } |> Some
      | 50012794 -> { StargateData.id= 50012794; name= "Stargate (WIW-X8)"; solarSystemId= 30001597; position= {x = -2.551362478e+12;  y = -4.020986266e+11;  z = 3.137081795e+12;}; typeId= 3875; destinationSolarSystemId= 30001595; destinationStargateId= 50012751 } |> Some
      | 50012891 -> { StargateData.id= 50012891; name= "Stargate (O-PNSN)"; solarSystemId= 30004652; position= {x = 1.95984384e+11;  y = -4555284480.0;  z = 2.095333786e+11;}; typeId= 3875; destinationSolarSystemId= 30004649; destinationStargateId= 50012523 } |> Some
      | 50012988 -> { StargateData.id= 50012988; name= "Stargate (Anohel)"; solarSystemId= 30004294; position= {x = 1.706719519e+12;  y = -2.057182003e+11;  z = 2.429395354e+11;}; typeId= 29624; destinationSolarSystemId= 30004291; destinationStargateId= 50012637 } |> Some
      | 50013085 -> { StargateData.id= 50013085; name= "Stargate (VQE-CN)"; solarSystemId= 30004942; position= {x = -4.052594074e+12;  y = 7.920354509e+11;  z = -3.956612014e+12;}; typeId= 29624; destinationSolarSystemId= 30004943; destinationStargateId= 50013104 } |> Some
      | 50013182 -> { StargateData.id= 50013182; name= "Stargate (38IA-E)"; solarSystemId= 30004634; position= {x = -3.358171668e+12;  y = 3.48022825e+11;  z = 2.952664719e+12;}; typeId= 3875; destinationSolarSystemId= 30004632; destinationStargateId= 50012577 } |> Some
      | 50013279 -> { StargateData.id= 50013279; name= "Stargate (Ondree)"; solarSystemId= 30003607; position= {x = -1.632780165e+12;  y = 6.48136704e+10;  z = -6.168982733e+11;}; typeId= 3875; destinationSolarSystemId= 30003603; destinationStargateId= 50011861 } |> Some
      | 50013376 -> { StargateData.id= 50013376; name= "Stargate (4GSZ-1)"; solarSystemId= 30004217; position= {x = -1.178309837e+11;  y = 847994880.0;  z = -2.67514368e+12;}; typeId= 3875; destinationSolarSystemId= 30004216; destinationStargateId= 50013110 } |> Some
      | 50013473 -> { StargateData.id= 50013473; name= "Stargate (G-D0N3)"; solarSystemId= 30004877; position= {x = 1.860465009e+12;  y = -2.234908262e+11;  z = 3.634695168e+12;}; typeId= 29633; destinationSolarSystemId= 30004876; destinationStargateId= 50013427 } |> Some
      | 50013570 -> { StargateData.id= 50013570; name= "Stargate (Yveve)"; solarSystemId= 30003591; position= {x = 3.055036293e+12;  y = 5.914754212e+12;  z = 8.275489997e+11;}; typeId= 3874; destinationSolarSystemId= 30003567; destinationStargateId= 50013569 } |> Some
      | 50013667 -> { StargateData.id= 50013667; name= "Stargate (Lermireve)"; solarSystemId= 30003062; position= {x = -3.743968051e+11;  y = 4.276990403e+12;  z = 6.433959936e+10;}; typeId= 29632; destinationSolarSystemId= 30002728; destinationStargateId= 50013668 } |> Some
      | 50013958 -> { StargateData.id= 50013958; name= "Stargate (Dodixie)"; solarSystemId= 30003032; position= {x = -1.073569014e+12;  y = 6.37271126e+12;  z = -1.666637414e+11;}; typeId= 29632; destinationSolarSystemId= 30002659; destinationStargateId= 50013957 } |> Some
      | 50014055 -> { StargateData.id= 50014055; name= "Stargate (Venilen)"; solarSystemId= 30001372; position= {x = -2.051748618e+12;  y = 3.705610691e+12;  z = -4.359604101e+12;}; typeId= 29629; destinationSolarSystemId= 30002798; destinationStargateId= 50014056 } |> Some
      | 50014249 -> { StargateData.id= 50014249; name= "Stargate (Y-RAW3)"; solarSystemId= 30003228; position= {x = 2.174548746e+12;  y = -3.393617633e+12;  z = 2.458710712e+12;}; typeId= 29632; destinationSolarSystemId= 30004171; destinationStargateId= 50014250 } |> Some
      | 50016286 -> { StargateData.id= 50016286; name= "Stargate (Nennamaila)"; solarSystemId= 30045339; position= {x = -2.113635533e+11;  y = -4.114010112e+10;  z = 2.165075558e+11;}; typeId= 16; destinationSolarSystemId= 30045344; destinationStargateId= 50016285 } |> Some
      | 50016480 -> { StargateData.id= 50016480; name= "Stargate (Oichiya)"; solarSystemId= 30031392; position= {x = -1.250081464e+12;  y = 5.913833472e+10;  z = -3.923021414e+11;}; typeId= 16; destinationSolarSystemId= 30002818; destinationStargateId= 50016481 } |> Some
      | _ -> None