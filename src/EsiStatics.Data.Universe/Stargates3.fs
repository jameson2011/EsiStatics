﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stargates3=
    let getStargate id = 
      match id with 
      | 50000011 -> { StargateData.id= 50000011; name= "Stargate (O31W-6)"; solarSystemId= 30002846; position= {x = -5.394419712e+10;  y = -3536855040.0;  z = 1.380545741e+11;}; typeId= 3875; destinationSolarSystemId= 30002851; destinationStargateId= 50000696 } |> Some
      | 50000108 -> { StargateData.id= 50000108; name= "Stargate (Vaurent)"; solarSystemId= 30003024; position= {x = -2.079988654e+12;  y = -1.087304909e+11;  z = 2.652195103e+12;}; typeId= 3875; destinationSolarSystemId= 30003027; destinationStargateId= 50000441 } |> Some
      | 50000205 -> { StargateData.id= 50000205; name= "Stargate (Aband)"; solarSystemId= 30004084; position= {x = -9.676933939e+11;  y = -3.1030272e+10;  z = -1.980025651e+11;}; typeId= 29624; destinationSolarSystemId= 30004090; destinationStargateId= 50005097 } |> Some
      | 50000302 -> { StargateData.id= 50000302; name= "Stargate (Perimeter)"; solarSystemId= 30002642; position= {x = 1.05653588e+12;  y = 7.604199014e+11;  z = 9.417082061e+11;}; typeId= 3876; destinationSolarSystemId= 30000144; destinationStargateId= 50002183 } |> Some
      | 50000399 -> { StargateData.id= 50000399; name= "Stargate (GZM-KB)"; solarSystemId= 30001526; position= {x = -1.720637891e+12;  y = 2.79917568e+11;  z = -5.413137162e+12;}; typeId= 3875; destinationSolarSystemId= 30001531; destinationStargateId= 50003568 } |> Some
      | 50000690 -> { StargateData.id= 50000690; name= "Stargate (Y19P-1)"; solarSystemId= 30002110; position= {x = 1.85401086e+12;  y = 3.465172992e+11;  z = -2.053722317e+12;}; typeId= 29633; destinationSolarSystemId= 30002109; destinationStargateId= 50000534 } |> Some
      | 50000787 -> { StargateData.id= 50000787; name= "Stargate (Gamdis)"; solarSystemId= 30004081; position= {x = -2.370633277e+12;  y = 3.257846784e+12;  z = -3.006295695e+12;}; typeId= 17; destinationSolarSystemId= 30004085; destinationStargateId= 50001799 } |> Some
      | 50000884 -> { StargateData.id= 50000884; name= "Stargate (F-749O)"; solarSystemId= 30000853; position= {x = -1.63220779e+12;  y = -7.539585024e+10;  z = 4.914791424e+12;}; typeId= 16; destinationSolarSystemId= 30000856; destinationStargateId= 50001376 } |> Some
      | 50000981 -> { StargateData.id= 50000981; name= "Stargate (C8H5-X)"; solarSystemId= 30000745; position= {x = -2.228401644e+12;  y = 4.030794547e+11;  z = -2.658388255e+12;}; typeId= 29633; destinationSolarSystemId= 30000743; destinationStargateId= 50000233 } |> Some
      | 50001078 -> { StargateData.id= 50001078; name= "Stargate (SAH-AD)"; solarSystemId= 30002297; position= {x = -6.36478464e+11;  y = 7.83845376e+10;  z = -5.452032369e+12;}; typeId= 3875; destinationSolarSystemId= 30002298; destinationStargateId= 50001879 } |> Some
      | 50001175 -> { StargateData.id= 50001175; name= "Stargate (Bereye)"; solarSystemId= 30003010; position= {x = 4.053370061e+11;  y = -4.665913344e+10;  z = 2.491955159e+12;}; typeId= 3875; destinationSolarSystemId= 30003014; destinationStargateId= 50004527 } |> Some
      | 50001272 -> { StargateData.id= 50001272; name= "Stargate (Iidoken)"; solarSystemId= 30001389; position= {x = 1.322558054e+12;  y = -3.363956736e+11;  z = -2.083527107e+12;}; typeId= 29627; destinationSolarSystemId= 30001374; destinationStargateId= 50000461 } |> Some
      | 50001369 -> { StargateData.id= 50001369; name= "Stargate (JPL-RA)"; solarSystemId= 30000923; position= {x = -2.788450714e+11;  y = -7.979835802e+11;  z = 8.785363354e+11;}; typeId= 3877; destinationSolarSystemId= 30000901; destinationStargateId= 50000255 } |> Some
      | 50001466 -> { StargateData.id= 50001466; name= "Stargate (Jarzalad)"; solarSystemId= 30001652; position= {x = 2.864017121e+12;  y = -5.724452045e+11;  z = -1.318051062e+12;}; typeId= 29624; destinationSolarSystemId= 30001653; destinationStargateId= 50002394 } |> Some
      | 50001563 -> { StargateData.id= 50001563; name= "Stargate (ZJA-6U)"; solarSystemId= 30002131; position= {x = -1.559127368e+12;  y = -2.313475277e+11;  z = -1.253097677e+12;}; typeId= 29633; destinationSolarSystemId= 30002130; destinationStargateId= 50001558 } |> Some
      | 50001660 -> { StargateData.id= 50001660; name= "Stargate (4-EFLU)"; solarSystemId= 30000572; position= {x = -3.153984922e+12;  y = 3.518918246e+11;  z = -6.287291597e+11;}; typeId= 29633; destinationSolarSystemId= 30000576; destinationStargateId= 50006593 } |> Some
      | 50001757 -> { StargateData.id= 50001757; name= "Stargate (Auberulle)"; solarSystemId= 30002710; position= {x = -4.089603809e+12;  y = 7.51579177e+11;  z = 3.732898898e+12;}; typeId= 3875; destinationSolarSystemId= 30002709; destinationStargateId= 50001684 } |> Some
      | 50001854 -> { StargateData.id= 50001854; name= "Stargate (Etav)"; solarSystemId= 30003514; position= {x = -5.443816243e+11;  y = 1.31966976e+10;  z = 4.436458291e+11;}; typeId= 29624; destinationSolarSystemId= 30003517; destinationStargateId= 50002542 } |> Some
      | 50001951 -> { StargateData.id= 50001951; name= "Stargate (XV-MWG)"; solarSystemId= 30000683; position= {x = -1.130417234e+12;  y = 1.654659072e+11;  z = 6.514105958e+11;}; typeId= 29633; destinationSolarSystemId= 30000678; destinationStargateId= 50000027 } |> Some
      | 50002145 -> { StargateData.id= 50002145; name= "Stargate (Evuldgenzo)"; solarSystemId= 30003384; position= {x = 1.347574579e+11;  y = 1.706102784e+10;  z = 6.1696512e+11;}; typeId= 29633; destinationSolarSystemId= 30003385; destinationStargateId= 50002203 } |> Some
      | 50002242 -> { StargateData.id= 50002242; name= "Stargate (Synchelle)"; solarSystemId= 30004972; position= {x = -1.348481311e+12;  y = 3.115183841e+12;  z = 2.180793999e+12;}; typeId= 3874; destinationSolarSystemId= 30005015; destinationStargateId= 50006513 } |> Some
      | 50002339 -> { StargateData.id= 50002339; name= "Stargate (YMJG-4)"; solarSystemId= 30000253; position= {x = 8.622331699e+12;  y = -3.409118945e+12;  z = 3.282338488e+12;}; typeId= 29627; destinationSolarSystemId= 30000241; destinationStargateId= 50001626 } |> Some
      | 50002436 -> { StargateData.id= 50002436; name= "Stargate (Saana)"; solarSystemId= 30003502; position= {x = 1.360417137e+12;  y = -1.728212582e+11;  z = 1.221871165e+12;}; typeId= 29624; destinationSolarSystemId= 30003506; destinationStargateId= 50003790 } |> Some
      | 50002533 -> { StargateData.id= 50002533; name= "Stargate (REB-KR)"; solarSystemId= 30002138; position= {x = 6.156522701e+11;  y = -4.801253376e+10;  z = 1.405527859e+12;}; typeId= 29633; destinationSolarSystemId= 30002140; destinationStargateId= 50003445 } |> Some
      | 50002630 -> { StargateData.id= 50002630; name= "Stargate (LT-XI4)"; solarSystemId= 30000444; position= {x = 3.357925417e+12;  y = -2.274686976e+11;  z = -1.206897992e+12;}; typeId= 3877; destinationSolarSystemId= 30000466; destinationStargateId= 50002701 } |> Some
      | 50002727 -> { StargateData.id= 50002727; name= "Stargate (9-R6GU)"; solarSystemId= 30001265; position= {x = 4.980854784e+10;  y = -7486955520.0;  z = 7.983876096e+11;}; typeId= 16; destinationSolarSystemId= 30001266; destinationStargateId= 50002734 } |> Some
      | 50002824 -> { StargateData.id= 50002824; name= "Stargate (XHQ-7V)"; solarSystemId= 30003705; position= {x = -8.866863145e+12;  y = -6.894547968e+12;  z = 2.958445486e+12;}; typeId= 17; destinationSolarSystemId= 30003731; destinationStargateId= 50004199 } |> Some
      | 50002921 -> { StargateData.id= 50002921; name= "Stargate (8-2JZA)"; solarSystemId= 30001073; position= {x = -4.91466793e+11;  y = -6.373502976e+10;  z = 2.629564416e+11;}; typeId= 3875; destinationSolarSystemId= 30001071; destinationStargateId= 50002512 } |> Some
      | 50003018 -> { StargateData.id= 50003018; name= "Stargate (Obrolber)"; solarSystemId= 30002520; position= {x = -1.792867246e+12;  y = 2.129649254e+11;  z = 1.260276081e+12;}; typeId= 29633; destinationSolarSystemId= 30002522; destinationStargateId= 50003333 } |> Some
      | 50003115 -> { StargateData.id= 50003115; name= "Stargate (YP-J33)"; solarSystemId= 30001270; position= {x = -2.368969974e+12;  y = 3.124124467e+11;  z = 5.696381706e+12;}; typeId= 16; destinationSolarSystemId= 30001271; destinationStargateId= 50003201 } |> Some
      | 50003212 -> { StargateData.id= 50003212; name= "Stargate (1-EVAX)"; solarSystemId= 30001110; position= {x = -1.901812531e+11;  y = -5750169600.0;  z = 1.119000576e+11;}; typeId= 3875; destinationSolarSystemId= 30001109; destinationStargateId= 50003198 } |> Some
      | 50003309 -> { StargateData.id= 50003309; name= "Stargate (G063-U)"; solarSystemId= 30000596; position= {x = 3.845837414e+12;  y = 1.045417452e+12;  z = 2.186064814e+12;}; typeId= 3877; destinationSolarSystemId= 30000537; destinationStargateId= 50005467 } |> Some
      | 50003406 -> { StargateData.id= 50003406; name= "Stargate (X47L-Q)"; solarSystemId= 30001977; position= {x = 3.118545838e+12;  y = 3.977044378e+11;  z = 6.553009766e+11;}; typeId= 29627; destinationSolarSystemId= 30001967; destinationStargateId= 50003163 } |> Some
      | 50003503 -> { StargateData.id= 50003503; name= "Stargate (F5M-CC)"; solarSystemId= 30000601; position= {x = -3.712252723e+11;  y = -7.165980672e+10;  z = -5.844267418e+11;}; typeId= 29633; destinationSolarSystemId= 30000600; destinationStargateId= 50002667 } |> Some
      | 50003600 -> { StargateData.id= 50003600; name= "Stargate (1-KCSA)"; solarSystemId= 30002824; position= {x = -4.463904399e+12;  y = -5.49785641e+11;  z = -7.330043904e+11;}; typeId= 3875; destinationSolarSystemId= 30002823; destinationStargateId= 50002331 } |> Some
      | 50003794 -> { StargateData.id= 50003794; name= "Stargate (Kiereend)"; solarSystemId= 30000025; position= {x = 6.658797158e+11;  y = 6.497857536e+10;  z = -1.436086395e+12;}; typeId= 29624; destinationSolarSystemId= 30000024; destinationStargateId= 50002891 } |> Some
      | 50003988 -> { StargateData.id= 50003988; name= "Stargate (EL8-4Q)"; solarSystemId= 30001974; position= {x = 4.814766612e+12;  y = -5.564216525e+11;  z = -4.957429801e+12;}; typeId= 16; destinationSolarSystemId= 30001970; destinationStargateId= 50003382 } |> Some
      | 50004085 -> { StargateData.id= 50004085; name= "Stargate (Mohas)"; solarSystemId= 30000035; position= {x = 1.3148783e+12;  y = -2.40338903e+11;  z = 1.57857878e+12;}; typeId= 29624; destinationSolarSystemId= 30000031; destinationStargateId= 50000468 } |> Some
      | 50004182 -> { StargateData.id= 50004182; name= "Stargate (WK2F-Y)"; solarSystemId= 30001748; position= {x = 4.399284019e+12;  y = 3.456824525e+11;  z = 4.08364757e+12;}; typeId= 3874; destinationSolarSystemId= 30001755; destinationStargateId= 50004341 } |> Some
      | 50004279 -> { StargateData.id= 50004279; name= "Stargate (Alenia)"; solarSystemId= 30005304; position= {x = 2732974080.0;  y = -135290880.0;  z = -2.47664087e+12;}; typeId= 3875; destinationSolarSystemId= 30005302; destinationStargateId= 50004152 } |> Some
      | 50004376 -> { StargateData.id= 50004376; name= "Stargate (Uzistoon)"; solarSystemId= 30000043; position= {x = 7.643741798e+11;  y = -274636800.0;  z = 3.228896748e+12;}; typeId= 29624; destinationSolarSystemId= 30000040; destinationStargateId= 50001494 } |> Some
      | 50004473 -> { StargateData.id= 50004473; name= "Stargate (Obanen)"; solarSystemId= 30000158; position= {x = -4.84992e+11;  y = 7.215132672e+10;  z = 2.394239386e+11;}; typeId= 16; destinationSolarSystemId= 30000155; destinationStargateId= 50003533 } |> Some
      | 50004570 -> { StargateData.id= 50004570; name= "Stargate (Ikami)"; solarSystemId= 30000160; position= {x = -3.589459599e+12;  y = 6.771942605e+11;  z = 2.096835011e+12;}; typeId= 16; destinationSolarSystemId= 30000159; destinationStargateId= 50004559 } |> Some
      | 50004667 -> { StargateData.id= 50004667; name= "Stargate (Tidacha)"; solarSystemId= 30000079; position= {x = 2.186923622e+11;  y = -6898360320.0;  z = 1.538442486e+12;}; typeId= 29624; destinationSolarSystemId= 30000076; destinationStargateId= 50000490 } |> Some
      | 50004764 -> { StargateData.id= 50004764; name= "Stargate (V7G-RL)"; solarSystemId= 30000602; position= {x = 1.565607936e+11;  y = -1.564594176e+10;  z = -3.400402084e+12;}; typeId= 29633; destinationSolarSystemId= 30000603; destinationStargateId= 50006965 } |> Some
      | 50004861 -> { StargateData.id= 50004861; name= "Stargate (X-7OMU)"; solarSystemId= 30002010; position= {x = -2.16983212e+12;  y = -2.642455634e+12;  z = 5.256780718e+12;}; typeId= 29627; destinationSolarSystemId= 30001978; destinationStargateId= 50003624 } |> Some
      | 50005055 -> { StargateData.id= 50005055; name= "Stargate (WH-JCA)"; solarSystemId= 30000870; position= {x = 1.347933757e+12;  y = 1.440820838e+11;  z = 2.987972567e+12;}; typeId= 16; destinationSolarSystemId= 30000871; destinationStargateId= 50005121 } |> Some
      | 50005152 -> { StargateData.id= 50005152; name= "Stargate (K42-IE)"; solarSystemId= 30002449; position= {x = -6.911738266e+11;  y = 1.792487424e+10;  z = -1.182095892e+12;}; typeId= 16; destinationSolarSystemId= 30002447; destinationStargateId= 50004867 } |> Some
      | 50005249 -> { StargateData.id= 50005249; name= "Stargate (Ebidan)"; solarSystemId= 30002195; position= {x = -1.29235968e+11;  y = 9368985600.0;  z = -1.875406848e+10;}; typeId= 29624; destinationSolarSystemId= 30002196; destinationStargateId= 50005443 } |> Some
      | 50005346 -> { StargateData.id= 50005346; name= "Stargate (I-HRX3)"; solarSystemId= 30001751; position= {x = 7.462311936e+11;  y = -9.337344e+10;  z = 3.72239659e+12;}; typeId= 3875; destinationSolarSystemId= 30001752; destinationStargateId= 50005422 } |> Some
      | 50005443 -> { StargateData.id= 50005443; name= "Stargate (Simbeloud)"; solarSystemId= 30002196; position= {x = 1.871178547e+11;  y = 1.364938752e+10;  z = 1.005195264e+10;}; typeId= 29624; destinationSolarSystemId= 30002195; destinationStargateId= 50005249 } |> Some
      | 50005637 -> { StargateData.id= 50005637; name= "Stargate (Mimen)"; solarSystemId= 30001680; position= {x = 1.613238067e+12;  y = -5255700480.0;  z = 1.782187991e+12;}; typeId= 29624; destinationSolarSystemId= 30001676; destinationStargateId= 50003884 } |> Some
      | 50005831 -> { StargateData.id= 50005831; name= "Stargate (Lossa)"; solarSystemId= 30001708; position= {x = -9.824858112e+10;  y = 1.543968645e+12;  z = -6.183934771e+11;}; typeId= 17; destinationSolarSystemId= 30001687; destinationStargateId= 50004008 } |> Some
      | 50005928 -> { StargateData.id= 50005928; name= "Stargate (7-QOYS)"; solarSystemId= 30001586; position= {x = -1.790840832e+10;  y = -2974064640.0;  z = 1.388740977e+12;}; typeId= 3875; destinationSolarSystemId= 30001588; destinationStargateId= 50006442 } |> Some
      | 50006025 -> { StargateData.id= 50006025; name= "Stargate (V-JCJS)"; solarSystemId= 30001141; position= {x = -2.017479475e+11;  y = -4.06370304e+10;  z = -1.359164006e+12;}; typeId= 3875; destinationSolarSystemId= 30001143; destinationStargateId= 50007534 } |> Some
      | 50006122 -> { StargateData.id= 50006122; name= "Stargate (Bridi)"; solarSystemId= 30005035; position= {x = -5.191634534e+11;  y = 4286668800.0;  z = 1.962113065e+12;}; typeId= 29624; destinationSolarSystemId= 30005034; destinationStargateId= 50005983 } |> Some
      | 50006316 -> { StargateData.id= 50006316; name= "Stargate (G5ED-Y)"; solarSystemId= 30000308; position= {x = 1.094522266e+12;  y = -1.513585459e+11;  z = 3.561122611e+11;}; typeId= 16; destinationSolarSystemId= 30000310; destinationStargateId= 50006915 } |> Some
      | 50006413 -> { StargateData.id= 50006413; name= "Stargate (Atarli)"; solarSystemId= 30005238; position= {x = 5.147879055e+12;  y = 1.947822367e+12;  z = -3.513590047e+12;}; typeId= 29626; destinationSolarSystemId= 30005077; destinationStargateId= 50010766 } |> Some
      | 50006510 -> { StargateData.id= 50006510; name= "Stargate (Haine)"; solarSystemId= 30005009; position= {x = -1.273731072e+11;  y = -2.209296384e+10;  z = 3.473138688e+12;}; typeId= 3875; destinationSolarSystemId= 30005012; destinationStargateId= 50007093 } |> Some
      | 50006607 -> { StargateData.id= 50006607; name= "Stargate (91-KD8)"; solarSystemId= 30001553; position= {x = 7.601123328e+10;  y = 1.184531866e+12;  z = 3.496095744e+10;}; typeId= 29632; destinationSolarSystemId= 30003253; destinationStargateId= 50012228 } |> Some
      | 50006704 -> { StargateData.id= 50006704; name= "Stargate (QWF-6P)"; solarSystemId= 30003282; position= {x = 4.114817802e+12;  y = 5.26954156e+12;  z = 5.140443832e+12;}; typeId= 3874; destinationSolarSystemId= 30003292; destinationStargateId= 50007286 } |> Some
      | 50006801 -> { StargateData.id= 50006801; name= "Stargate (Hadozeko)"; solarSystemId= 30002056; position= {x = 1.244776231e+13;  y = 2.286060872e+12;  z = -5.69024852e+12;}; typeId= 29633; destinationSolarSystemId= 30002057; destinationStargateId= 50006849 } |> Some
      | 50006898 -> { StargateData.id= 50006898; name= "Stargate (Aunsou)"; solarSystemId= 30003805; position= {x = 1.442190336e+12;  y = -1.253011046e+11;  z = 3.61611178e+12;}; typeId= 3875; destinationSolarSystemId= 30003801; destinationStargateId= 50006313 } |> Some
      | 50006995 -> { StargateData.id= 50006995; name= "Stargate (LF-2KP)"; solarSystemId= 30003751; position= {x = -3.23407319e+12;  y = 3.524828897e+12;  z = -2.985342689e+12;}; typeId= 17; destinationSolarSystemId= 30003759; destinationStargateId= 50010056 } |> Some
      | 50007092 -> { StargateData.id= 50007092; name= "Stargate (I2D3-5)"; solarSystemId= 30002876; position= {x = 1.116930417e+12;  y = -1.85417687e+11;  z = -2.216696832e+12;}; typeId= 3875; destinationSolarSystemId= 30002877; destinationStargateId= 50007191 } |> Some
      | 50007189 -> { StargateData.id= 50007189; name= "Stargate (R1O-GN)"; solarSystemId= 30002877; position= {x = -1.467150336e+10;  y = -2606653440.0;  z = 6.661289779e+12;}; typeId= 3875; destinationSolarSystemId= 30002874; destinationStargateId= 50006827 } |> Some
      | 50007286 -> { StargateData.id= 50007286; name= "Stargate (8-JYPM)"; solarSystemId= 30003292; position= {x = -2.396702761e+12;  y = -3.069279314e+12;  z = -2.994085601e+12;}; typeId= 3874; destinationSolarSystemId= 30003282; destinationStargateId= 50006704 } |> Some
      | 50007383 -> { StargateData.id= 50007383; name= "Stargate (4F9Y-3)"; solarSystemId= 30005152; position= {x = -3.284447232e+10;  y = 5092761600.0;  z = -8.774995968e+10;}; typeId= 3875; destinationSolarSystemId= 30005154; destinationStargateId= 50008023 } |> Some
      | 50007480 -> { StargateData.id= 50007480; name= "Stargate (QG3-Z0)"; solarSystemId= 30001773; position= {x = -1.218887885e+12;  y = 2.01728041e+11;  z = -8.94011351e+11;}; typeId= 3875; destinationSolarSystemId= 30001772; destinationStargateId= 50007411 } |> Some
      | 50007577 -> { StargateData.id= 50007577; name= "Stargate (Iderion)"; solarSystemId= 30004122; position= {x = 6.598377062e+11;  y = -5.087951954e+12;  z = 2.795154678e+12;}; typeId= 29626; destinationSolarSystemId= 30005227; destinationStargateId= 50006235 } |> Some
      | 50007674 -> { StargateData.id= 50007674; name= "Stargate (Soumi)"; solarSystemId= 30005054; position= {x = 1.399908557e+12;  y = -2.330653901e+11;  z = 3.861527347e+11;}; typeId= 29624; destinationSolarSystemId= 30005052; destinationStargateId= 50007640 } |> Some
      | 50007771 -> { StargateData.id= 50007771; name= "Stargate (H-93YV)"; solarSystemId= 30000526; position= {x = -1.273297183e+12;  y = 2.854219776e+10;  z = -8.208736666e+11;}; typeId= 29633; destinationSolarSystemId= 30000523; destinationStargateId= 50007145 } |> Some
      | 50007868 -> { StargateData.id= 50007868; name= "Stargate (KW-OAM)"; solarSystemId= 30004836; position= {x = 2.829731021e+11;  y = -2.207502336e+10;  z = 6.753913651e+11;}; typeId= 29633; destinationSolarSystemId= 30004833; destinationStargateId= 50006993 } |> Some
      | 50007965 -> { StargateData.id= 50007965; name= "Stargate (7V-KHW)"; solarSystemId= 30003943; position= {x = -6.496086221e+12;  y = -8.513705165e+11;  z = -3.828946944e+11;}; typeId= 29624; destinationSolarSystemId= 30003945; destinationStargateId= 50008151 } |> Some
      | 50008062 -> { StargateData.id= 50008062; name= "Stargate (Vezila)"; solarSystemId= 30003900; position= {x = 1.926814065e+12;  y = -2.468267213e+11;  z = -8.441164186e+11;}; typeId= 29624; destinationSolarSystemId= 30003899; destinationStargateId= 50008032 } |> Some
      | 50008159 -> { StargateData.id= 50008159; name= "Stargate (RK-Q51)"; solarSystemId= 30002378; position= {x = 1.022994432e+11;  y = -4880916480.0;  z = 4.754071142e+11;}; typeId= 3875; destinationSolarSystemId= 30002380; destinationStargateId= 50009491 } |> Some
      | 50008256 -> { StargateData.id= 50008256; name= "Stargate (Seshala)"; solarSystemId= 30003902; position= {x = -2.562190909e+12;  y = -3.239258112e+11;  z = -4.900933509e+12;}; typeId= 29624; destinationSolarSystemId= 30003898; destinationStargateId= 50007764 } |> Some
      | 50008353 -> { StargateData.id= 50008353; name= "Stargate (Ashkoo)"; solarSystemId= 30003917; position= {x = -9.147890442e+12;  y = 9.051199488e+11;  z = -2.874596106e+12;}; typeId= 29624; destinationSolarSystemId= 30003919; destinationStargateId= 50008746 } |> Some
      | 50008450 -> { StargateData.id= 50008450; name= "Stargate (FZCR-3)"; solarSystemId= 30003214; position= {x = 9.908737229e+11;  y = 8.353001472e+10;  z = -2.161851064e+12;}; typeId= 3875; destinationSolarSystemId= 30003213; destinationStargateId= 50008423 } |> Some
      | 50008547 -> { StargateData.id= 50008547; name= "Stargate (S-DLKC)"; solarSystemId= 30001870; position= {x = -3.246296801e+12;  y = 4.785698365e+12;  z = 3.696046694e+12;}; typeId= 17; destinationSolarSystemId= 30001893; destinationStargateId= 50009662 } |> Some
      | 50008644 -> { StargateData.id= 50008644; name= "Stargate (H65-HE)"; solarSystemId= 30004424; position= {x = 1.616283525e+12;  y = 1.13586217e+11;  z = -2.601469747e+12;}; typeId= 3877; destinationSolarSystemId= 30004443; destinationStargateId= 50009146 } |> Some
      | 50008741 -> { StargateData.id= 50008741; name= "Stargate (ZQP-QV)"; solarSystemId= 30004494; position= {x = -1.309915177e+12;  y = -8.806232064e+10;  z = -3.558244762e+11;}; typeId= 3875; destinationSolarSystemId= 30004496; destinationStargateId= 50008807 } |> Some
      | 50008838 -> { StargateData.id= 50008838; name= "Stargate (3L-Y9M)"; solarSystemId= 30004425; position= {x = 1.409906074e+12;  y = -3.880031969e+12;  z = -5.298706391e+12;}; typeId= 3877; destinationSolarSystemId= 30004419; destinationStargateId= 50008249 } |> Some
      | 50008935 -> { StargateData.id= 50008935; name= "Stargate (Esesier)"; solarSystemId= 30003840; position= {x = -5.02478721e+12;  y = 2.883454157e+11;  z = 4.200224317e+12;}; typeId= 3875; destinationSolarSystemId= 30003842; destinationStargateId= 50009073 } |> Some
      | 50009032 -> { StargateData.id= 50009032; name= "Stargate (Vlillirier)"; solarSystemId= 30003841; position= {x = 2.228796211e+11;  y = 5582315520.0;  z = 1.457664e+10;}; typeId= 3875; destinationSolarSystemId= 30003836; destinationStargateId= 50008693 } |> Some
      | 50009129 -> { StargateData.id= 50009129; name= "Stargate (Baratar)"; solarSystemId= 30003923; position= {x = -9.101572915e+11;  y = 2.718176256e+12;  z = -2.634149437e+12;}; typeId= 17; destinationSolarSystemId= 30003920; destinationStargateId= 50009004 } |> Some
      | 50009226 -> { StargateData.id= 50009226; name= "Stargate (Iffrue)"; solarSystemId= 30003817; position= {x = -1.144053228e+12;  y = 9.410531328e+10;  z = 2.803535462e+11;}; typeId= 3875; destinationSolarSystemId= 30003815; destinationStargateId= 50007251 } |> Some
      | 50009323 -> { StargateData.id= 50009323; name= "Stargate (1BWK-S)"; solarSystemId= 30003627; position= {x = 3.009885389e+11;  y = 3.014234112e+10;  z = -2.380146893e+12;}; typeId= 16; destinationSolarSystemId= 30003624; destinationStargateId= 50008705 } |> Some
      | 50009420 -> { StargateData.id= 50009420; name= "Stargate (F-UVBV)"; solarSystemId= 30003128; position= {x = -1.385065144e+12;  y = 4.585009152e+10;  z = 4.952541143e+12;}; typeId= 29624; destinationSolarSystemId= 30003126; destinationStargateId= 50009124 } |> Some
      | 50009517 -> { StargateData.id= 50009517; name= "Stargate (Shalne)"; solarSystemId= 30005271; position= {x = -1.083588403e+12;  y = -1.812731904e+11;  z = 8.381067264e+10;}; typeId= 29624; destinationSolarSystemId= 30005270; destinationStargateId= 50009093 } |> Some
      | 50009614 -> { StargateData.id= 50009614; name= "Stargate (SZ6-TA)"; solarSystemId= 30003636; position= {x = 5.56810113e+12;  y = 3.789753139e+11;  z = 2.608804209e+12;}; typeId= 16; destinationSolarSystemId= 30003639; destinationStargateId= 50009852 } |> Some
      | 50009711 -> { StargateData.id= 50009711; name= "Stargate (T-IDGH)"; solarSystemId= 30002381; position= {x = -2.509857178e+11;  y = -9703219200.0;  z = 1.945866363e+12;}; typeId= 3875; destinationSolarSystemId= 30002382; destinationStargateId= 50009756 } |> Some
      | 50009808 -> { StargateData.id= 50009808; name= "Stargate (Larryn)"; solarSystemId= 30003580; position= {x = 8.190823219e+11;  y = 6.24605184e+10;  z = 1.289150915e+12;}; typeId= 3875; destinationSolarSystemId= 30003579; destinationStargateId= 50009623 } |> Some
      | 50009905 -> { StargateData.id= 50009905; name= "Stargate (W-IIYI)"; solarSystemId= 30004004; position= {x = 1.733063885e+11;  y = 2.417700864e+10;  z = -1.6433664e+11;}; typeId= 29624; destinationSolarSystemId= 30004005; destinationStargateId= 50010364 } |> Some
      | 50010002 -> { StargateData.id= 50010002; name= "Stargate (J9SH-A)"; solarSystemId= 30004515; position= {x = 4.99750871e+11;  y = -4.287565824e+10;  z = 2.864947569e+12;}; typeId= 3875; destinationSolarSystemId= 30004514; destinationStargateId= 50009948 } |> Some
      | 50010099 -> { StargateData.id= 50010099; name= "Stargate (Antollare)"; solarSystemId= 30003053; position= {x = -2.591723397e+12;  y = 2.651454259e+11;  z = 8.85663744e+10;}; typeId= 3875; destinationSolarSystemId= 30003051; destinationStargateId= 50009897 } |> Some
      | 50010196 -> { StargateData.id= 50010196; name= "Stargate (42-UOW)"; solarSystemId= 30001896; position= {x = 3.403970765e+12;  y = -1.460877312e+11;  z = -1.142903071e+12;}; typeId= 29624; destinationSolarSystemId= 30001894; destinationStargateId= 50009847 } |> Some
      | 50010293 -> { StargateData.id= 50010293; name= "Stargate (Y-0HVF)"; solarSystemId= 30003239; position= {x = -8.286114202e+11;  y = -1.028811571e+11;  z = 2.500068557e+11;}; typeId= 3875; destinationSolarSystemId= 30003237; destinationStargateId= 50010083 } |> Some
      | 50010390 -> { StargateData.id= 50010390; name= "Stargate (9T-APQ)"; solarSystemId= 30004669; position= {x = -1.370866115e+12;  y = 2.558878925e+11;  z = -1.898891059e+12;}; typeId= 29624; destinationSolarSystemId= 30004672; destinationStargateId= 50010522 } |> Some
      | 50010487 -> { StargateData.id= 50010487; name= "Stargate (JI-K5H)"; solarSystemId= 30004671; position= {x = -2.966900736e+10;  y = 14868480.0;  z = 1.122475622e+11;}; typeId= 29624; destinationSolarSystemId= 30004667; destinationStargateId= 50010376 } |> Some
      | 50010584 -> { StargateData.id= 50010584; name= "Stargate (V-SEE6)"; solarSystemId= 30001783; position= {x = -6.055331021e+11;  y = -1.028460134e+11;  z = 1.239205356e+12;}; typeId= 3875; destinationSolarSystemId= 30001787; destinationStargateId= 50012436 } |> Some
      | 50010681 -> { StargateData.id= 50010681; name= "Stargate (IP6V-X)"; solarSystemId= 30004728; position= {x = 3.801392456e+12;  y = -2.767706112e+11;  z = -2.385290895e+12;}; typeId= 29624; destinationSolarSystemId= 30004726; destinationStargateId= 50010626 } |> Some
      | 50010778 -> { StargateData.id= 50010778; name= "Stargate (VH-9VO)"; solarSystemId= 30001789; position= {x = 1.591592141e+11;  y = -8172871680.0;  z = 5510799360.0;}; typeId= 3875; destinationSolarSystemId= 30001794; destinationStargateId= 50012902 } |> Some
      | 50010875 -> { StargateData.id= 50010875; name= "Stargate (H23-B5)"; solarSystemId= 30004177; position= {x = 3.638649201e+12;  y = 1.706298163e+11;  z = 3.005455933e+12;}; typeId= 3875; destinationSolarSystemId= 30004178; destinationStargateId= 50011024 } |> Some
      | 50010972 -> { StargateData.id= 50010972; name= "Stargate (3KB-J0)"; solarSystemId= 30003782; position= {x = 1.162669793e+12;  y = -3.65893632e+10;  z = -1.072387891e+12;}; typeId= 29624; destinationSolarSystemId= 30003781; destinationStargateId= 50009916 } |> Some
      | 50011069 -> { StargateData.id= 50011069; name= "Stargate (M-SG47)"; solarSystemId= 30005142; position= {x = 2.063294054e+11;  y = 1.53237504e+10;  z = 1.271222723e+12;}; typeId= 3875; destinationSolarSystemId= 30005140; destinationStargateId= 50007333 } |> Some
      | 50011166 -> { StargateData.id= 50011166; name= "Stargate (Oraekja)"; solarSystemId= 30003449; position= {x = -4.41061417e+11;  y = -2.355867648e+10;  z = -1.280077824e+10;}; typeId= 29633; destinationSolarSystemId= 30003450; destinationStargateId= 50011834 } |> Some
      | 50011263 -> { StargateData.id= 50011263; name= "Stargate (Edilkam)"; solarSystemId= 30004254; position= {x = -1.026960138e+12;  y = -6.108696576e+10;  z = -2.196852204e+12;}; typeId= 29624; destinationSolarSystemId= 30004256; destinationStargateId= 50012323 } |> Some
      | 50011360 -> { StargateData.id= 50011360; name= "Stargate (Bimener)"; solarSystemId= 30000116; position= {x = -5.579188224e+11;  y = 7.428820992e+10;  z = -1.607718543e+12;}; typeId= 29624; destinationSolarSystemId= 30000115; destinationStargateId= 50011133 } |> Some
      | 50011457 -> { StargateData.id= 50011457; name= "Stargate (E-BYOS)"; solarSystemId= 30004180; position= {x = -2.130960261e+12;  y = 3.506738381e+11;  z = 3.471683052e+12;}; typeId= 3875; destinationSolarSystemId= 30004181; destinationStargateId= 50011632 } |> Some
      | 50011554 -> { StargateData.id= 50011554; name= "Stargate (M2-XFE)"; solarSystemId= 30004772; position= {x = -3.621888369e+12;  y = 5.065709568e+11;  z = 4.843048673e+12;}; typeId= 29624; destinationSolarSystemId= 30004773; destinationStargateId= 50011642 } |> Some
      | 50011651 -> { StargateData.id= 50011651; name= "Stargate (9S-GPT)"; solarSystemId= 30001799; position= {x = -1.416667546e+11;  y = -1422827520.0;  z = 4.365441024e+11;}; typeId= 3875; destinationSolarSystemId= 30001796; destinationStargateId= 50011176 } |> Some
      | 50011748 -> { StargateData.id= 50011748; name= "Stargate (23M-PX)"; solarSystemId= 30004465; position= {x = -2.205034045e+12;  y = 4.229108122e+11;  z = 4.81604481e+12;}; typeId= 29633; destinationSolarSystemId= 30004467; destinationStargateId= 50011920 } |> Some
      | 50011845 -> { StargateData.id= 50011845; name= "Stargate (Safizon)"; solarSystemId= 30004148; position= {x = 6.42101588e+12;  y = 1.177669018e+12;  z = -2.390931579e+12;}; typeId= 29626; destinationSolarSystemId= 30002279; destinationStargateId= 50011172 } |> Some
      | 50011942 -> { StargateData.id= 50011942; name= "Stargate (H-S80W)"; solarSystemId= 30004603; position= {x = -1.37511039e+12;  y = 3.511578624e+10;  z = -4.555873075e+11;}; typeId= 3875; destinationSolarSystemId= 30004606; destinationStargateId= 50012098 } |> Some
      | 50012039 -> { StargateData.id= 50012039; name= "Stargate (NDH-NV)"; solarSystemId= 30004610; position= {x = 2.541725e+12;  y = -1.844002406e+11;  z = 1.317859615e+12;}; typeId= 3875; destinationSolarSystemId= 30004609; destinationStargateId= 50012017 } |> Some
      | 50012136 -> { StargateData.id= 50012136; name= "Stargate (Hegfunden)"; solarSystemId= 30002416; position= {x = 1.347341722e+12;  y = -1.049234227e+11;  z = 6.546010522e+11;}; typeId= 29633; destinationSolarSystemId= 30002418; destinationStargateId= 50012503 } |> Some
      | 50012233 -> { StargateData.id= 50012233; name= "Stargate (Atarli)"; solarSystemId= 30005081; position= {x = -4.299891917e+11;  y = 4.7975424e+10;  z = 1.456608092e+12;}; typeId= 29624; destinationSolarSystemId= 30005077; destinationStargateId= 50010771 } |> Some
      | 50012330 -> { StargateData.id= 50012330; name= "Stargate (Shafrak)"; solarSystemId= 30004284; position= {x = 3.809990861e+12;  y = -6.595772006e+11;  z = -1.879117824e+10;}; typeId= 29624; destinationSolarSystemId= 30004283; destinationStargateId= 50012261 } |> Some
      | 50012427 -> { StargateData.id= 50012427; name= "Stargate (TDE4-H)"; solarSystemId= 30002503; position= {x = -1.846907658e+12;  y = -1.404158362e+11;  z = 1.623449887e+12;}; typeId= 16; destinationSolarSystemId= 30002502; destinationStargateId= 50011390 } |> Some
      | 50012524 -> { StargateData.id= 50012524; name= "Stargate (2-YO2K)"; solarSystemId= 30005144; position= {x = 3.803822899e+11;  y = -2.378870784e+10;  z = -1.765867069e+12;}; typeId= 3875; destinationSolarSystemId= 30005139; destinationStargateId= 50006745 } |> Some
      | 50012621 -> { StargateData.id= 50012621; name= "Stargate (Osaa)"; solarSystemId= 30000203; position= {x = 4.983209042e+12;  y = 6.551591731e+11;  z = 3.057573028e+12;}; typeId= 16; destinationSolarSystemId= 30000207; destinationStargateId= 50013417 } |> Some
      | 50012718 -> { StargateData.id= 50012718; name= "Stargate (O-97ZG)"; solarSystemId= 30004693; position= {x = 2.426463314e+12;  y = -2.465230848e+10;  z = -3.980229059e+12;}; typeId= 29624; destinationSolarSystemId= 30004692; destinationStargateId= 50012550 } |> Some
      | 50012815 -> { StargateData.id= 50012815; name= "Stargate (C1XD-X)"; solarSystemId= 30004599; position= {x = 3.947033027e+12;  y = -4.95818711e+11;  z = 1.322351862e+12;}; typeId= 3875; destinationSolarSystemId= 30004597; destinationStargateId= 50012108 } |> Some
      | 50012912 -> { StargateData.id= 50012912; name= "Stargate (A-5M31)"; solarSystemId= 30004543; position= {x = -4.03136852e+12;  y = -1.13224446e+12;  z = 1.864455414e+12;}; typeId= 3874; destinationSolarSystemId= 30004544; destinationStargateId= 50012955 } |> Some
      | 50013009 -> { StargateData.id= 50013009; name= "Stargate (98Q-8O)"; solarSystemId= 30003370; position= {x = 4.810469376e+10;  y = -283975680.0;  z = 2.838662799e+12;}; typeId= 3875; destinationSolarSystemId= 30003373; destinationStargateId= 50013357 } |> Some
      | 50013106 -> { StargateData.id= 50013106; name= "Stargate (Q-02UL)"; solarSystemId= 30004789; position= {x = -3.00752855e+11;  y = 4.54944768e+10;  z = -7.636789248e+11;}; typeId= 29624; destinationSolarSystemId= 30004787; destinationStargateId= 50012972 } |> Some
      | 50013203 -> { StargateData.id= 50013203; name= "Stargate (MMUF-8)"; solarSystemId= 30004914; position= {x = -1.766012559e+12;  y = -4.677267456e+10;  z = -1.815426294e+12;}; typeId= 29633; destinationSolarSystemId= 30004913; destinationStargateId= 50013169 } |> Some
      | 50013300 -> { StargateData.id= 50013300; name= "Stargate (Z-R96X)"; solarSystemId= 30001917; position= {x = 6.588624937e+12;  y = -3.839005901e+11;  z = -2.168653824e+11;}; typeId= 29624; destinationSolarSystemId= 30001919; destinationStargateId= 50013458 } |> Some
      | 50013397 -> { StargateData.id= 50013397; name= "Stargate (Fanathor)"; solarSystemId= 30003940; position= {x = 5.610579026e+12;  y = 1.108908564e+12;  z = -5.972227277e+11;}; typeId= 29624; destinationSolarSystemId= 30003938; destinationStargateId= 50011931 } |> Some
      | 50013494 -> { StargateData.id= 50013494; name= "Stargate (OOO-FS)"; solarSystemId= 30001947; position= {x = -4.653457859e+12;  y = -4.30751785e+11;  z = 3.701171405e+11;}; typeId= 29624; destinationSolarSystemId= 30001946; destinationStargateId= 50013491 } |> Some
      | 50013688 -> { StargateData.id= 50013688; name= "Stargate (Akora)"; solarSystemId= 30000186; position= {x = -1.060970619e+12;  y = -6.351328911e+12;  z = -7.792591258e+11;}; typeId= 29627; destinationSolarSystemId= 30000163; destinationStargateId= 50013687 } |> Some
      | 50013785 -> { StargateData.id= 50013785; name= "Stargate (6X7-JO)"; solarSystemId= 30001159; position= {x = 1.13720021e+12;  y = 2.740227686e+11;  z = -5.535064474e+11;}; typeId= 12292; destinationSolarSystemId= 30001197; destinationStargateId= 50013786 } |> Some
      | 50013979 -> { StargateData.id= 50013979; name= "Stargate (QP0K-B)"; solarSystemId= 30000288; position= {x = -2.929777336e+12;  y = -2.230117048e+12;  z = -5.167369052e+12;}; typeId= 29629; destinationSolarSystemId= 30002479; destinationStargateId= 50013980 } |> Some
      | 50014076 -> { StargateData.id= 50014076; name= "Stargate (Odatrik)"; solarSystemId= 30002507; position= {x = 1.661273088e+12;  y = -2.30021161e+11;  z = 2.522921779e+11;}; typeId= 29633; destinationSolarSystemId= 30002509; destinationStargateId= 50014075 } |> Some
      | 50014173 -> { StargateData.id= 50014173; name= "Stargate (Olelon)"; solarSystemId= 30002711; position= {x = -5.933763379e+11;  y = 9.790992384e+10;  z = 2.898238218e+12;}; typeId= 3875; destinationSolarSystemId= 30032715; destinationStargateId= 50014174 } |> Some
      | 50014270 -> { StargateData.id= 50014270; name= "Stargate (JAWX-R)"; solarSystemId= 30001533; position= {x = -2.359779041e+12;  y = -1.906212987e+12;  z = 3.129092874e+12;}; typeId= 29632; destinationSolarSystemId= 30002336; destinationStargateId= 50014269 } |> Some
      | 50016307 -> { StargateData.id= 50016307; name= "Stargate (Ahtila)"; solarSystemId= 30045322; position= {x = -1.519931597e+12;  y = -7742054400.0;  z = -9.342294835e+11;}; typeId= 16; destinationSolarSystemId= 30045328; destinationStargateId= 50016308 } |> Some
      | _ -> None