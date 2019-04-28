﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stargates34=
    let getStargate id = 
      match id with 
      | 50000042 -> { StargateData.id= 50000042; name= "Stargate (Gensela)"; solarSystemId= 30004078; position= {x = -5.360224543e+12;  y = 7.936255181e+11;  z = -3.64114047e+12;}; typeId= 29624; destinationSolarSystemId= 30004083; destinationStargateId= 50002345 } |> Some
      | 50000139 -> { StargateData.id= 50000139; name= "Stargate (KRPF-A)"; solarSystemId= 30002283; position= {x = 2.504220058e+12;  y = 3.470026752e+11;  z = -7.148840141e+11;}; typeId= 3875; destinationSolarSystemId= 30002286; destinationStargateId= 50001967 } |> Some
      | 50000333 -> { StargateData.id= 50000333; name= "Stargate (AG-SYG)"; solarSystemId= 30001535; position= {x = 3.915769405e+12;  y = -1.150590566e+11;  z = -5.12327553e+12;}; typeId= 3875; destinationSolarSystemId= 30001539; destinationStargateId= 50001549 } |> Some
      | 50000430 -> { StargateData.id= 50000430; name= "Stargate (QQ3-YI)"; solarSystemId= 30000907; position= {x = 2.528670106e+11;  y = -3.162096968e+12;  z = -1.011183329e+12;}; typeId= 3877; destinationSolarSystemId= 30000938; destinationStargateId= 50000714 } |> Some
      | 50000527 -> { StargateData.id= 50000527; name= "Stargate (Direrie)"; solarSystemId= 30002643; position= {x = -3.453361398e+12;  y = -1.023205786e+11;  z = -3.507081216e+10;}; typeId= 3875; destinationSolarSystemId= 30002646; destinationStargateId= 50003099 } |> Some
      | 50000721 -> { StargateData.id= 50000721; name= "Stargate (74-VZA)"; solarSystemId= 30000784; position= {x = -8.66332373e+12;  y = 6.242745139e+11;  z = -2.31008514e+12;}; typeId= 29633; destinationSolarSystemId= 30000787; destinationStargateId= 50001794 } |> Some
      | 50000818 -> { StargateData.id= 50000818; name= "Stargate (Alf)"; solarSystemId= 30003374; position= {x = -3.761021338e+11;  y = -3.64824576e+10;  z = -4.43230335e+12;}; typeId= 29633; destinationSolarSystemId= 30003380; destinationStargateId= 50003872 } |> Some
      | 50000915 -> { StargateData.id= 50000915; name= "Stargate (E-OGL4)"; solarSystemId= 30000848; position= {x = 5.510851092e+12;  y = 6.692097638e+11;  z = -3.62245632e+12;}; typeId= 16; destinationSolarSystemId= 30000846; destinationStargateId= 50000378 } |> Some
      | 50001012 -> { StargateData.id= 50001012; name= "Stargate (Tunttaras)"; solarSystemId= 30002752; position= {x = -5.485241549e+11;  y = -2.980450714e+11;  z = -1.622369034e+12;}; typeId= 29629; destinationSolarSystemId= 30001379; destinationStargateId= 50001710 } |> Some
      | 50001109 -> { StargateData.id= 50001109; name= "Stargate (F-TQWO)"; solarSystemId= 30001065; position= {x = -3.373725327e+12;  y = -5.799555072e+10;  z = -2.494926889e+12;}; typeId= 3875; destinationSolarSystemId= 30001064; destinationStargateId= 50000643 } |> Some
      | 50001206 -> { StargateData.id= 50001206; name= "Stargate (BNX-AS)"; solarSystemId= 30002321; position= {x = 2.437652767e+12;  y = 6.781710336e+10;  z = -1.957958861e+11;}; typeId= 3875; destinationSolarSystemId= 30002318; destinationStargateId= 50000649 } |> Some
      | 50001303 -> { StargateData.id= 50001303; name= "Stargate (M-CNUD)"; solarSystemId= 30000619; position= {x = -7.788872909e+11;  y = 5.065125888e+10;  z = -2.669338214e+11;}; typeId= 29633; destinationSolarSystemId= 30000620; destinationStargateId= 50001420 } |> Some
      | 50001400 -> { StargateData.id= 50001400; name= "Stargate (A0M-R8)"; solarSystemId= 30001080; position= {x = -2.117491507e+11;  y = -1.515196416e+10;  z = 5.103109325e+11;}; typeId= 3875; destinationSolarSystemId= 30001077; destinationStargateId= 50000823 } |> Some
      | 50001497 -> { StargateData.id= 50001497; name= "Stargate (Agha)"; solarSystemId= 30000057; position= {x = -2.630437478e+12;  y = 3.989762458e+11;  z = -3.937143398e+12;}; typeId= 29624; destinationSolarSystemId= 30000061; destinationStargateId= 50007289 } |> Some
      | 50001594 -> { StargateData.id= 50001594; name= "Stargate (Kazna)"; solarSystemId= 30000015; position= {x = 1.615606456e+12;  y = -3.04813953e+12;  z = -5.110823731e+11;}; typeId= 17; destinationSolarSystemId= 30000018; destinationStargateId= 50000424 } |> Some
      | 50001691 -> { StargateData.id= 50001691; name= "Stargate (TK-DLH)"; solarSystemId= 30000740; position= {x = 1.852422144e+11;  y = 2239242240.0;  z = 7.468966748e+12;}; typeId= 29633; destinationSolarSystemId= 30000742; destinationStargateId= 50002252 } |> Some
      | 50001788 -> { StargateData.id= 50001788; name= "Stargate (Cherore)"; solarSystemId= 30003017; position= {x = -6.434135654e+11;  y = 5.537452032e+10;  z = -7.403678515e+11;}; typeId= 3875; destinationSolarSystemId= 30003019; destinationStargateId= 50002883 } |> Some
      | 50001982 -> { StargateData.id= 50001982; name= "Stargate (Konola)"; solarSystemId= 30002739; position= {x = -4.146795725e+11;  y = -1.56530688e+10;  z = 1.524931338e+12;}; typeId= 16; destinationSolarSystemId= 30002737; destinationStargateId= 50001093 } |> Some
      | 50002079 -> { StargateData.id= 50002079; name= "Stargate (Nirbhi)"; solarSystemId= 30000006; position= {x = -1.622192333e+12;  y = 1.865346662e+11;  z = 6.805557658e+11;}; typeId= 29624; destinationSolarSystemId= 30000008; destinationStargateId= 50002193 } |> Some
      | 50002176 -> { StargateData.id= 50002176; name= "Stargate (Unpas)"; solarSystemId= 30000130; position= {x = -6.322311168e+10;  y = -1.090916352e+10;  z = 1.117073818e+11;}; typeId= 16; destinationSolarSystemId= 30000129; destinationStargateId= 50001428 } |> Some
      | 50002273 -> { StargateData.id= 50002273; name= "Stargate (KGT3-6)"; solarSystemId= 30002288; position= {x = -4.760760361e+12;  y = -9.202814976e+10;  z = -4.953908306e+12;}; typeId= 3874; destinationSolarSystemId= 30002296; destinationStargateId= 50000361 } |> Some
      | 50002370 -> { StargateData.id= 50002370; name= "Stargate (J2-PZ6)"; solarSystemId= 30000676; position= {x = -5.800735949e+11;  y = -1.02959063e+11;  z = 2.897653064e+12;}; typeId= 29633; destinationSolarSystemId= 30000677; destinationStargateId= 50002904 } |> Some
      | 50002467 -> { StargateData.id= 50002467; name= "Stargate (Huola)"; solarSystemId= 30002975; position= {x = 3.509567447e+12;  y = 5.18760407e+11;  z = 2.435884278e+12;}; typeId= 29626; destinationSolarSystemId= 30003067; destinationStargateId= 50001717 } |> Some
      | 50002564 -> { StargateData.id= 50002564; name= "Stargate (B-T6BT)"; solarSystemId= 30000628; position= {x = 2.245714944e+12;  y = -2.38163927e+11;  z = -4.486786376e+12;}; typeId= 29633; destinationSolarSystemId= 30000624; destinationStargateId= 50001236 } |> Some
      | 50002661 -> { StargateData.id= 50002661; name= "Stargate (DL1C-E)"; solarSystemId= 30000881; position= {x = 1.281434788e+12;  y = 1.237945958e+11;  z = 2.963009741e+12;}; typeId= 16; destinationSolarSystemId= 30000879; destinationStargateId= 50002353 } |> Some
      | 50002855 -> { StargateData.id= 50002855; name= "Stargate (G3D-ZT)"; solarSystemId= 30000464; position= {x = -4.061231923e+11;  y = -8.190554112e+10;  z = 1.611338588e+12;}; typeId= 29633; destinationSolarSystemId= 30000460; destinationStargateId= 50000200 } |> Some
      | 50002952 -> { StargateData.id= 50002952; name= "Stargate (Alillere)"; solarSystemId= 30002664; position= {x = 2.884063764e+12;  y = 3.36873984e+12;  z = 3.151884411e+12;}; typeId= 3874; destinationSolarSystemId= 30002712; destinationStargateId= 50000669 } |> Some
      | 50003146 -> { StargateData.id= 50003146; name= "Stargate (Y8K-5B)"; solarSystemId= 30001558; position= {x = 4.829842268e+12;  y = 3.080982528e+10;  z = -9.252943872e+11;}; typeId= 3875; destinationSolarSystemId= 30001559; destinationStargateId= 50003249 } |> Some
      | 50003243 -> { StargateData.id= 50003243; name= "Stargate (Cailanar)"; solarSystemId= 30002206; position= {x = -1.175284163e+12;  y = 1.002500506e+11;  z = 2.297793331e+11;}; typeId= 29624; destinationSolarSystemId= 30002207; destinationStargateId= 50004030 } |> Some
      | 50003340 -> { StargateData.id= 50003340; name= "Stargate (WNM-V0)"; solarSystemId= 30002856; position= {x = -1.261632307e+11;  y = -2.086096896e+10;  z = -1.414541353e+12;}; typeId= 3875; destinationSolarSystemId= 30002854; destinationStargateId= 50002850 } |> Some
      | 50003437 -> { StargateData.id= 50003437; name= "Stargate (Iyen-Oursta)"; solarSystemId= 30002647; position= {x = 6.028041708e+12;  y = -7.316101939e+11;  z = 6.829830144e+10;}; typeId= 3875; destinationSolarSystemId= 30002642; destinationStargateId= 50000303 } |> Some
      | 50003534 -> { StargateData.id= 50003534; name= "Stargate (C-6YHJ)"; solarSystemId= 30000636; position= {x = -1.564393882e+11;  y = -2.057908224e+10;  z = 3.28566743e+11;}; typeId= 29633; destinationSolarSystemId= 30000632; destinationStargateId= 50002648 } |> Some
      | 50003631 -> { StargateData.id= 50003631; name= "Stargate (Obalyu)"; solarSystemId= 30004994; position= {x = 7.373157581e+11;  y = -8.10657792e+10;  z = 3.543098696e+12;}; typeId= 3875; destinationSolarSystemId= 30004996; destinationStargateId= 50004120 } |> Some
      | 50003728 -> { StargateData.id= 50003728; name= "Stargate (Shedoo)"; solarSystemId= 30000107; position= {x = 1.091953336e+12;  y = -2.409910272e+10;  z = 3.947311104e+10;}; typeId= 29624; destinationSolarSystemId= 30000106; destinationStargateId= 50003165 } |> Some
      | 50003825 -> { StargateData.id= 50003825; name= "Stargate (KBP7-G)"; solarSystemId= 30002968; position= {x = -9.299724288e+11;  y = -2.171637228e+12;  z = -5.809425654e+12;}; typeId= 29625; destinationSolarSystemId= 30003729; destinationStargateId= 50004021 } |> Some
      | 50003922 -> { StargateData.id= 50003922; name= "Stargate (Ohbochi)"; solarSystemId= 30001434; position= {x = -4.085465211e+12;  y = -5.770758144e+11;  z = 4.657287537e+12;}; typeId= 16; destinationSolarSystemId= 30001435; destinationStargateId= 50004632 } |> Some
      | 50004019 -> { StargateData.id= 50004019; name= "Stargate (6Y-WRK)"; solarSystemId= 30000296; position= {x = 2.407223747e+12;  y = -8.541794304e+10;  z = 2.921431818e+12;}; typeId= 16; destinationSolarSystemId= 30000297; destinationStargateId= 50004031 } |> Some
      | 50004116 -> { StargateData.id= 50004116; name= "Stargate (JZ-B5Y)"; solarSystemId= 30000638; position= {x = 5.835036549e+12;  y = 3.946774118e+11;  z = 1.83162796e+13;}; typeId= 29633; destinationSolarSystemId= 30000640; destinationStargateId= 50004497 } |> Some
      | 50004213 -> { StargateData.id= 50004213; name= "Stargate (C-FD0D)"; solarSystemId= 30004817; position= {x = 6.033958134e+12;  y = 2.173035725e+11;  z = -1.231911444e+12;}; typeId= 29633; destinationSolarSystemId= 30004818; destinationStargateId= 50004287 } |> Some
      | 50004310 -> { StargateData.id= 50004310; name= "Stargate (Nehkiah)"; solarSystemId= 30001694; position= {x = -7.880691302e+11;  y = 1.082397082e+11;  z = -6.477336576e+10;}; typeId= 29624; destinationSolarSystemId= 30001695; destinationStargateId= 50004730 } |> Some
      | 50004407 -> { StargateData.id= 50004407; name= "Stargate (Polstodur)"; solarSystemId= 30003390; position= {x = 1.391796019e+12;  y = -1.512822252e+12;  z = 2.52155904e+10;}; typeId= 3877; destinationSolarSystemId= 30003434; destinationStargateId= 50007455 } |> Some
      | 50004504 -> { StargateData.id= 50004504; name= "Stargate (Ono)"; solarSystemId= 30002778; position= {x = 2.244544635e+12;  y = 2.50298327e+11;  z = -2.04430209e+12;}; typeId= 16; destinationSolarSystemId= 30002779; destinationStargateId= 50005887 } |> Some
      | 50004601 -> { StargateData.id= 50004601; name= "Stargate (Alillere)"; solarSystemId= 30002716; position= {x = 1.713201562e+11;  y = 1.880272896e+10;  z = 2.688180511e+12;}; typeId= 3875; destinationSolarSystemId= 30002712; destinationStargateId= 50000672 } |> Some
      | 50004698 -> { StargateData.id= 50004698; name= "Stargate (Inder)"; solarSystemId= 30002068; position= {x = 4.93293527e+11;  y = 2.95385088e+10;  z = 6.712785715e+11;}; typeId= 29633; destinationSolarSystemId= 30002072; destinationStargateId= 50007440 } |> Some
      | 50004795 -> { StargateData.id= 50004795; name= "Stargate (Leremblompes)"; solarSystemId= 30003038; position= {x = -9.68536105e+11;  y = -7.593897984e+10;  z = 9.189999821e+11;}; typeId= 3875; destinationSolarSystemId= 30003039; destinationStargateId= 50004901 } |> Some
      | 50004892 -> { StargateData.id= 50004892; name= "Stargate (WNS-7J)"; solarSystemId= 30001847; position= {x = -1.101785457e+12;  y = -1.400844288e+10;  z = 4.220791603e+11;}; typeId= 29624; destinationSolarSystemId= 30001849; destinationStargateId= 50006289 } |> Some
      | 50004989 -> { StargateData.id= 50004989; name= "Stargate (N0C-UN)"; solarSystemId= 30001301; position= {x = -1.811274547e+11;  y = -2.119766016e+10;  z = 3.777238917e+12;}; typeId= 16; destinationSolarSystemId= 30001302; destinationStargateId= 50005075 } |> Some
      | 50005086 -> { StargateData.id= 50005086; name= "Stargate (Sitanan)"; solarSystemId= 30002226; position= {x = 1.763192463e+12;  y = 3.563656397e+11;  z = 2.263473316e+12;}; typeId= 29624; destinationSolarSystemId= 30002229; destinationStargateId= 50005398 } |> Some
      | 50005183 -> { StargateData.id= 50005183; name= "Stargate (Serren)"; solarSystemId= 30005221; position= {x = 4.742117376e+11;  y = -6.225088512e+10;  z = -1.592546058e+12;}; typeId= 29624; destinationSolarSystemId= 30005222; destinationStargateId= 50005514 } |> Some
      | 50005280 -> { StargateData.id= 50005280; name= "Stargate (Elarel)"; solarSystemId= 30003040; position= {x = 1.242542776e+12;  y = -8641536000.0;  z = -9.594574848e+11;}; typeId= 3875; destinationSolarSystemId= 30003044; destinationStargateId= 50006652 } |> Some
      | 50005377 -> { StargateData.id= 50005377; name= "Stargate (Karjataimon)"; solarSystemId= 30001442; position= {x = -1.456301261e+11;  y = 5642526720.0;  z = -9.117272064e+11;}; typeId= 16; destinationSolarSystemId= 30001440; destinationStargateId= 50004539 } |> Some
      | 50005474 -> { StargateData.id= 50005474; name= "Stargate (Leremblompes)"; solarSystemId= 30003041; position= {x = -1.495394181e+12;  y = -2.101116518e+11;  z = 1.797272003e+12;}; typeId= 3875; destinationSolarSystemId= 30003039; destinationStargateId= 50004903 } |> Some
      | 50005571 -> { StargateData.id= 50005571; name= "Stargate (JS-E8E)"; solarSystemId= 30001852; position= {x = 9.609326592e+10;  y = 1.593372672e+10;  z = 5.177634816e+10;}; typeId= 29624; destinationSolarSystemId= 30001851; destinationStargateId= 50005168 } |> Some
      | 50005668 -> { StargateData.id= 50005668; name= "Stargate (Sortet)"; solarSystemId= 30005324; position= {x = 7.018970726e+11;  y = -6.152245248e+10;  z = 6.764798362e+11;}; typeId= 3875; destinationSolarSystemId= 30005323; destinationStargateId= 50005600 } |> Some
      | 50005765 -> { StargateData.id= 50005765; name= "Stargate (Estene)"; solarSystemId= 30002672; position= {x = 7.533244416e+10;  y = -1.336578048e+10;  z = 4.530741043e+12;}; typeId= 3875; destinationSolarSystemId= 30002673; destinationStargateId= 50006326 } |> Some
      | 50005862 -> { StargateData.id= 50005862; name= "Stargate (VG-6CH)"; solarSystemId= 30001324; position= {x = -2.444393226e+12;  y = 5.267639132e+12;  z = -2.038994657e+12;}; typeId= 29627; destinationSolarSystemId= 30001303; destinationStargateId= 50005101 } |> Some
      | 50005959 -> { StargateData.id= 50005959; name= "Stargate (TXME-A)"; solarSystemId= 30002902; position= {x = 2.966098452e+12;  y = 3.174136996e+12;  z = 1.630987469e+11;}; typeId= 29627; destinationSolarSystemId= 30002901; destinationStargateId= 50005542 } |> Some
      | 50006056 -> { StargateData.id= 50006056; name= "Stargate (Zith)"; solarSystemId= 30001729; position= {x = -1.389479485e+12;  y = 1.796789453e+11;  z = -1.99015895e+12;}; typeId= 29624; destinationSolarSystemId= 30001732; destinationStargateId= 50007749 } |> Some
      | 50006153 -> { StargateData.id= 50006153; name= "Stargate (Isikemi)"; solarSystemId= 30001364; position= {x = 4.748276122e+11;  y = 1.137414144e+10;  z = 9.44176128e+11;}; typeId= 16; destinationSolarSystemId= 30001365; destinationStargateId= 50006892 } |> Some
      | 50006250 -> { StargateData.id= 50006250; name= "Stargate (Q7E-DU)"; solarSystemId= 30001762; position= {x = 2.494355743e+12;  y = 1.35655465e+11;  z = -4.296402125e+11;}; typeId= 3875; destinationSolarSystemId= 30001763; destinationStargateId= 50006463 } |> Some
      | 50006347 -> { StargateData.id= 50006347; name= "Stargate (L-SDU7)"; solarSystemId= 30000431; position= {x = -2.328405811e+12;  y = 1.430462054e+11;  z = -3.150222828e+12;}; typeId= 3876; destinationSolarSystemId= 30000430; destinationStargateId= 50006335 } |> Some
      | 50006444 -> { StargateData.id= 50006444; name= "Stargate (KS8G-M)"; solarSystemId= 30001588; position= {x = 1.084320031e+12;  y = -2.105107661e+11;  z = -1.602438881e+12;}; typeId= 3875; destinationSolarSystemId= 30001589; destinationStargateId= 50006617 } |> Some
      | 50006541 -> { StargateData.id= 50006541; name= "Stargate (Tamekamur)"; solarSystemId= 30003404; position= {x = -7.094959718e+11;  y = 1.326537523e+11;  z = -1.456576143e+12;}; typeId= 29633; destinationSolarSystemId= 30003407; destinationStargateId= 50007449 } |> Some
      | 50006638 -> { StargateData.id= 50006638; name= "Stargate (O-RXCZ)"; solarSystemId= 30000976; position= {x = -4.436265984e+12;  y = -5.083952333e+11;  z = -3.595664179e+11;}; typeId= 29633; destinationSolarSystemId= 30000975; destinationStargateId= 50005790 } |> Some
      | 50006735 -> { StargateData.id= 50006735; name= "Stargate (M-NWLB)"; solarSystemId= 30003199; position= {x = 3.137280614e+12;  y = -1.55791319e+11;  z = -9.411661824e+10;}; typeId= 3875; destinationSolarSystemId= 30003200; destinationStargateId= 50007032 } |> Some
      | 50006832 -> { StargateData.id= 50006832; name= "Stargate (YA0-XJ)"; solarSystemId= 30002905; position= {x = 1.035757855e+12;  y = 1.5902208e+11;  z = -9.222093619e+11;}; typeId= 16; destinationSolarSystemId= 30002902; destinationStargateId= 50005961 } |> Some
      | 50006929 -> { StargateData.id= 50006929; name= "Stargate (Piekura)"; solarSystemId= 30001366; position= {x = -3.476514202e+12;  y = 1.990632284e+12;  z = 7.818376397e+11;}; typeId= 29627; destinationSolarSystemId= 30001391; destinationStargateId= 50002269 } |> Some
      | 50007026 -> { StargateData.id= 50007026; name= "Stargate (B-CZXG)"; solarSystemId= 30001322; position= {x = -5.868420833e+12;  y = -5.159645184e+10;  z = 1.246516716e+12;}; typeId= 16; destinationSolarSystemId= 30001321; destinationStargateId= 50006947 } |> Some
      | 50007123 -> { StargateData.id= 50007123; name= "Stargate (T-HMWP)"; solarSystemId= 30003193; position= {x = 5.361331814e+11;  y = -7.414001664e+10;  z = -4.52794368e+10;}; typeId= 3875; destinationSolarSystemId= 30003195; destinationStargateId= 50007582 } |> Some
      | 50007220 -> { StargateData.id= 50007220; name= "Stargate (Purjola)"; solarSystemId= 30000162; position= {x = 6.150265651e+11;  y = 4.929441792e+10;  z = -8.800052429e+11;}; typeId= 16; destinationSolarSystemId= 30000161; destinationStargateId= 50004744 } |> Some
      | 50007317 -> { StargateData.id= 50007317; name= "Stargate (Hisoufad)"; solarSystemId= 30003533; position= {x = 2.256502333e+12;  y = -5.644578816e+10;  z = 1.363515679e+12;}; typeId= 29624; destinationSolarSystemId= 30003531; destinationStargateId= 50005840 } |> Some
      | 50007414 -> { StargateData.id= 50007414; name= "Stargate (Q0J-RH)"; solarSystemId= 30000504; position= {x = -4849950720.0;  y = 879943680.0;  z = 6.172003123e+11;}; typeId= 29633; destinationSolarSystemId= 30000507; destinationStargateId= 50007690 } |> Some
      | 50007511 -> { StargateData.id= 50007511; name= "Stargate (A-CJGE)"; solarSystemId= 30003101; position= {x = 7.954574131e+11;  y = 1.162468147e+11;  z = 6.170073907e+11;}; typeId= 29624; destinationSolarSystemId= 30003100; destinationStargateId= 50007394 } |> Some
      | 50007608 -> { StargateData.id= 50007608; name= "Stargate (Sehsasez)"; solarSystemId= 30003870; position= {x = -2.051541811e+11;  y = -1.941786624e+10;  z = -4.948155187e+11;}; typeId= 29624; destinationSolarSystemId= 30003869; destinationStargateId= 50007491 } |> Some
      | 50007705 -> { StargateData.id= 50007705; name= "Stargate (Talidal)"; solarSystemId= 30003888; position= {x = -4.650163814e+11;  y = 7.510683648e+10;  z = 7.697829888e+10;}; typeId= 29624; destinationSolarSystemId= 30003889; destinationStargateId= 50008105 } |> Some
      | 50007802 -> { StargateData.id= 50007802; name= "Stargate (Khabi)"; solarSystemId= 30000113; position= {x = 2.93600809e+12;  y = -2.468790682e+11;  z = 7.924397261e+11;}; typeId= 29624; destinationSolarSystemId= 30000117; destinationStargateId= 50011894 } |> Some
      | 50007899 -> { StargateData.id= 50007899; name= "Stargate (Rand)"; solarSystemId= 30001705; position= {x = -3.018885489e+12;  y = -5.105375232e+11;  z = -5.165500293e+12;}; typeId= 17; destinationSolarSystemId= 30001727; destinationStargateId= 50011471 } |> Some
      | 50007996 -> { StargateData.id= 50007996; name= "Stargate (QP0K-B)"; solarSystemId= 30002474; position= {x = 1.394357821e+12;  y = 1.141573632e+11;  z = 2.017195008e+12;}; typeId= 16; destinationSolarSystemId= 30002479; destinationStargateId= 50009957 } |> Some
      | 50008093 -> { StargateData.id= 50008093; name= "Stargate (RORZ-H)"; solarSystemId= 30002032; position= {x = -1.322899415e+12;  y = -3.016839168e+10;  z = -2.086032138e+12;}; typeId= 16; destinationSolarSystemId= 30002033; destinationStargateId= 50008222 } |> Some
      | 50008190 -> { StargateData.id= 50008190; name= "Stargate (Archavoinet)"; solarSystemId= 30003827; position= {x = 1.235802808e+12;  y = -2.222959411e+11;  z = -1.063361618e+12;}; typeId= 3875; destinationSolarSystemId= 30003824; destinationStargateId= 50007628 } |> Some
      | 50008287 -> { StargateData.id= 50008287; name= "Stargate (X-M2LR)"; solarSystemId= 30003327; position= {x = 1.437209764e+12;  y = -6.048115507e+11;  z = -3.976640471e+12;}; typeId= 3874; destinationSolarSystemId= 30003278; destinationStargateId= 50008131 } |> Some
      | 50008384 -> { StargateData.id= 50008384; name= "Stargate (BJD4-E)"; solarSystemId= 30004421; position= {x = -2.429351731e+12;  y = 2.286046003e+11;  z = 1.075879526e+11;}; typeId= 29633; destinationSolarSystemId= 30004422; destinationStargateId= 50008394 } |> Some
      | 50008481 -> { StargateData.id= 50008481; name= "Stargate (31-MLU)"; solarSystemId= 30003331; position= {x = 3.982395187e+12;  y = 7.74928343e+11;  z = 1.18795137e+12;}; typeId= 3875; destinationSolarSystemId= 30003329; destinationStargateId= 50008417 } |> Some
      | 50008578 -> { StargateData.id= 50008578; name= "Stargate (1EO-OE)"; solarSystemId= 30003215; position= {x = -6.920761344e+10;  y = 1.2033024e+10;  z = -1.060116849e+12;}; typeId= 3875; destinationSolarSystemId= 30003211; destinationStargateId= 50008014 } |> Some
      | 50008675 -> { StargateData.id= 50008675; name= "Stargate (Lirerim)"; solarSystemId= 30003414; position= {x = 1.80798591e+12;  y = -4.660963369e+12;  z = -3.641641083e+12;}; typeId= 3877; destinationSolarSystemId= 30003459; destinationStargateId= 50009208 } |> Some
      | 50008772 -> { StargateData.id= 50008772; name= "Stargate (Kamda)"; solarSystemId= 30004113; position= {x = 1.856808346e+12;  y = -2.865798758e+11;  z = 1.374465024e+12;}; typeId= 29624; destinationSolarSystemId= 30004115; destinationStargateId= 50012975 } |> Some
      | 50008869 -> { StargateData.id= 50008869; name= "Stargate (Anchauttes)"; solarSystemId= 30003839; position= {x = -9.578470195e+11;  y = 3.36746496e+10;  z = 8.520554496e+11;}; typeId= 3875; destinationSolarSystemId= 30003840; destinationStargateId= 50008934 } |> Some
      | 50008966 -> { StargateData.id= 50008966; name= "Stargate (U-JJEW)"; solarSystemId= 30004437; position= {x = 1.041645158e+11;  y = 1.463709696e+10;  z = 8.731643904e+10;}; typeId= 29633; destinationSolarSystemId= 30004439; destinationStargateId= 50009264 } |> Some
      | 50009063 -> { StargateData.id= 50009063; name= "Stargate (Mod)"; solarSystemId= 30004121; position= {x = 3.510968525e+12;  y = 5.953044357e+12;  z = -3.293089382e+11;}; typeId= 17; destinationSolarSystemId= 30004136; destinationStargateId= 50009233 } |> Some
      | 50009160 -> { StargateData.id= 50009160; name= "Stargate (J1-KJP)"; solarSystemId= 30003631; position= {x = -2.030982881e+12;  y = -1.594936934e+11;  z = -2.881872568e+12;}; typeId= 16; destinationSolarSystemId= 30003634; destinationStargateId= 50009256 } |> Some
      | 50009257 -> { StargateData.id= 50009257; name= "Stargate (HB-FSO)"; solarSystemId= 30003634; position= {x = 2.631492526e+12;  y = -5.301904589e+11;  z = 3.216248218e+12;}; typeId= 16; destinationSolarSystemId= 30003633; destinationStargateId= 50009228 } |> Some
      | 50009354 -> { StargateData.id= 50009354; name= "Stargate (4-PCHD)"; solarSystemId= 30004164; position= {x = 4721664000.0;  y = -634429440.0;  z = 1.02682583e+11;}; typeId= 3875; destinationSolarSystemId= 30004165; destinationStargateId= 50009438 } |> Some
      | 50009451 -> { StargateData.id= 50009451; name= "Stargate (Elore)"; solarSystemId= 30003568; position= {x = -2.798889001e+12;  y = -3.749684429e+11;  z = 8.241474724e+12;}; typeId= 3875; destinationSolarSystemId= 30003570; destinationStargateId= 50009638 } |> Some
      | 50009548 -> { StargateData.id= 50009548; name= "Stargate (P7Z-R3)"; solarSystemId= 30004360; position= {x = -1.947568251e+12;  y = 1.593249792e+10;  z = -1.181036544e+10;}; typeId= 16; destinationSolarSystemId= 30004362; destinationStargateId= 50010043 } |> Some
      | 50009645 -> { StargateData.id= 50009645; name= "Stargate (MQ-NPY)"; solarSystemId= 30002038; position= {x = 1.02111744e+12;  y = -9.412718592e+10;  z = -2.597108982e+12;}; typeId= 16; destinationSolarSystemId= 30002035; destinationStargateId= 50008001 } |> Some
      | 50009742 -> { StargateData.id= 50009742; name= "Stargate (450I-W)"; solarSystemId= 30003148; position= {x = -4.055188685e+11;  y = -1.186487378e+12;  z = 3.205299855e+12;}; typeId= 17; destinationSolarSystemId= 30003131; destinationStargateId= 50009545 } |> Some
      | 50009839 -> { StargateData.id= 50009839; name= "Stargate (JD-TYH)"; solarSystemId= 30003149; position= {x = 1.492581949e+12;  y = 2.685546086e+11;  z = 8.280537784e+12;}; typeId= 29624; destinationSolarSystemId= 30003148; destinationStargateId= 50009743 } |> Some
      | 50009936 -> { StargateData.id= 50009936; name= "Stargate (Andrub)"; solarSystemId= 30005069; position= {x = -1.426852209e+12;  y = -1.854619607e+12;  z = -7.157220557e+11;}; typeId= 17; destinationSolarSystemId= 30005049; destinationStargateId= 50009305 } |> Some
      | 50010033 -> { StargateData.id= 50010033; name= "Stargate (Ruerrotta)"; solarSystemId= 30003844; position= {x = 3.057417216e+12;  y = 5.357948928e+10;  z = 9.960671232e+11;}; typeId= 3875; destinationSolarSystemId= 30003845; destinationStargateId= 50010321 } |> Some
      | 50010130 -> { StargateData.id= 50010130; name= "Stargate (3BK-O7)"; solarSystemId= 30003999; position= {x = 1.441972838e+12;  y = -1.54419241e+11;  z = 1.897907036e+12;}; typeId= 29624; destinationSolarSystemId= 30004000; destinationStargateId= 50010169 } |> Some
      | 50010227 -> { StargateData.id= 50010227; name= "Stargate (Ansalle)"; solarSystemId= 30005312; position= {x = 6.26297303e+12;  y = 3.675737702e+11;  z = -1.873139712e+11;}; typeId= 3875; destinationSolarSystemId= 30005309; destinationStargateId= 50006471 } |> Some
      | 50010324 -> { StargateData.id= 50010324; name= "Stargate (NIZJ-0)"; solarSystemId= 30003143; position= {x = 3.429272371e+11;  y = -4.938412032e+10;  z = -5.939415859e+11;}; typeId= 29624; destinationSolarSystemId= 30003141; destinationStargateId= 50010142 } |> Some
      | 50010421 -> { StargateData.id= 50010421; name= "Stargate (L-P3XM)"; solarSystemId= 30003640; position= {x = 1.631496192e+11;  y = -2.491478016e+10;  z = 2.193317929e+12;}; typeId= 16; destinationSolarSystemId= 30003643; destinationStargateId= 50011019 } |> Some
      | 50010518 -> { StargateData.id= 50010518; name= "Stargate (9S-GPT)"; solarSystemId= 30005178; position= {x = 6.997702656e+11;  y = -2.47865684e+12;  z = -1.454742036e+12;}; typeId= 29632; destinationSolarSystemId= 30001796; destinationStargateId= 50011173 } |> Some
      | 50010615 -> { StargateData.id= 50010615; name= "Stargate (LS3-HP)"; solarSystemId= 30002832; position= {x = 2.16967041e+12;  y = -2.366844518e+11;  z = -3.179350303e+12;}; typeId= 3875; destinationSolarSystemId= 30002830; destinationStargateId= 50005570 } |> Some
      | 50010712 -> { StargateData.id= 50010712; name= "Stargate (E-BWUU)"; solarSystemId= 30004556; position= {x = -3.580396216e+12;  y = 1.748035953e+12;  z = 1.619706962e+12;}; typeId= 3874; destinationSolarSystemId= 30004567; destinationStargateId= 50010854 } |> Some
      | 50010809 -> { StargateData.id= 50010809; name= "Stargate (7T6P-C)"; solarSystemId= 30002927; position= {x = -7.382904422e+11;  y = -3.064467456e+10;  z = 2.208510566e+12;}; typeId= 16; destinationSolarSystemId= 30002929; destinationStargateId= 50011276 } |> Some
      | 50010906 -> { StargateData.id= 50010906; name= "Stargate (VF-FN6)"; solarSystemId= 30004431; position= {x = -9.211629158e+11;  y = 1.090337587e+11;  z = -1.576608154e+11;}; typeId= 29633; destinationSolarSystemId= 30004433; destinationStargateId= 50011142 } |> Some
      | 50011003 -> { StargateData.id= 50011003; name= "Stargate (YI-8ZM)"; solarSystemId= 30004053; position= {x = -2.421404099e+12;  y = 4.394915021e+11;  z = -1.579103232e+12;}; typeId= 3875; destinationSolarSystemId= 30004051; destinationStargateId= 50010923 } |> Some
      | 50011100 -> { StargateData.id= 50011100; name= "Stargate (QC-YX6)"; solarSystemId= 30004747; position= {x = 4.379665736e+12;  y = -7.41230592e+10;  z = -3.972146749e+12;}; typeId= 29624; destinationSolarSystemId= 30004744; destinationStargateId= 50010727 } |> Some
      | 50011197 -> { StargateData.id= 50011197; name= "Stargate (AR-5SY)"; solarSystemId= 30003655; position= {x = 3.120476283e+12;  y = -1.111640064e+11;  z = 1.814432932e+12;}; typeId= 16; destinationSolarSystemId= 30003656; destinationStargateId= 50011663 } |> Some
      | 50011294 -> { StargateData.id= 50011294; name= "Stargate (ZWV-GD)"; solarSystemId= 30004686; position= {x = 1.34151721e+12;  y = 1.622309683e+11;  z = -1.144346911e+12;}; typeId= 29624; destinationSolarSystemId= 30004687; destinationStargateId= 50011312 } |> Some
      | 50011391 -> { StargateData.id= 50011391; name= "Stargate (PNQY-Y)"; solarSystemId= 30004560; position= {x = -1.897855918e+12;  y = 1.123456205e+11;  z = 6.018628854e+12;}; typeId= 3875; destinationSolarSystemId= 30004559; destinationStargateId= 50010827 } |> Some
      | 50011585 -> { StargateData.id= 50011585; name= "Stargate (XZH-4X)"; solarSystemId= 30004059; position= {x = -3.182593843e+12;  y = -6.370749235e+11;  z = -1.881725952e+12;}; typeId= 3875; destinationSolarSystemId= 30004062; destinationStargateId= 50011811 } |> Some
      | 50011682 -> { StargateData.id= 50011682; name= "Stargate (Sahtogas)"; solarSystemId= 30003091; position= {x = -3.245627843e+12;  y = 5.430228173e+11;  z = 2.219065958e+12;}; typeId= 29624; destinationSolarSystemId= 30003086; destinationStargateId= 50007970 } |> Some
      | 50011779 -> { StargateData.id= 50011779; name= "Stargate (L-1SW8)"; solarSystemId= 30004592; position= {x = -8.047980134e+11;  y = -1.424354918e+11;  z = 1.814786458e+11;}; typeId= 3875; destinationSolarSystemId= 30004593; destinationStargateId= 50011809 } |> Some
      | 50011876 -> { StargateData.id= 50011876; name= "Stargate (A1RR-M)"; solarSystemId= 30003657; position= {x = -1.565346816e+12;  y = 3.042349056e+10;  z = -9.956456448e+11;}; typeId= 16; destinationSolarSystemId= 30003655; destinationStargateId= 50011198 } |> Some
      | 50011973 -> { StargateData.id= 50011973; name= "Stargate (Tukanas)"; solarSystemId= 30004274; position= {x = -8.20406231e+11;  y = -7.489376256e+10;  z = -3.226967654e+11;}; typeId= 29624; destinationSolarSystemId= 30004275; destinationStargateId= 50012145 } |> Some
      | 50012070 -> { StargateData.id= 50012070; name= "Stargate (Talidal)"; solarSystemId= 30003895; position= {x = 1.78476798e+12;  y = -1.569980006e+11;  z = -6.617531597e+11;}; typeId= 29624; destinationSolarSystemId= 30003889; destinationStargateId= 50008106 } |> Some
      | 50012167 -> { StargateData.id= 50012167; name= "Stargate (G5-EN3)"; solarSystemId= 30004535; position= {x = 1.801896223e+12;  y = -1.488311501e+11;  z = -5.846049792e+12;}; typeId= 3875; destinationSolarSystemId= 30004536; destinationStargateId= 50012259 } |> Some
      | 50012264 -> { StargateData.id= 50012264; name= "Stargate (EAWE-2)"; solarSystemId= 30001932; position= {x = -2.837141791e+12;  y = -4.848541286e+11;  z = 1.629418414e+12;}; typeId= 29624; destinationSolarSystemId= 30001933; destinationStargateId= 50012668 } |> Some
      | 50012361 -> { StargateData.id= 50012361; name= "Stargate (Atier)"; solarSystemId= 30002705; position= {x = 8.648650752e+10;  y = -9374638080.0;  z = 4.109784269e+11;}; typeId= 3875; destinationSolarSystemId= 30002701; destinationStargateId= 50007466 } |> Some
      | 50012458 -> { StargateData.id= 50012458; name= "Stargate (OW-QXW)"; solarSystemId= 30001818; position= {x = 3.12340992e+12;  y = 3.262353408e+10;  z = -1.246709391e+12;}; typeId= 3875; destinationSolarSystemId= 30001819; destinationStargateId= 50012590 } |> Some
      | 50012555 -> { StargateData.id= 50012555; name= "Stargate (Heorah)"; solarSystemId= 30005289; position= {x = -1.47821826e+12;  y = -2.97633792e+10;  z = -1.49802283e+12;}; typeId= 29624; destinationSolarSystemId= 30005290; destinationStargateId= 50012743 } |> Some
      | 50012652 -> { StargateData.id= 50012652; name= "Stargate (O-PNSN)"; solarSystemId= 30004650; position= {x = 6.551038894e+12;  y = 1.320627118e+12;  z = -1.990248653e+12;}; typeId= 3875; destinationSolarSystemId= 30004649; destinationStargateId= 50012521 } |> Some
      | 50012749 -> { StargateData.id= 50012749; name= "Stargate (X-KHRZ)"; solarSystemId= 30001595; position= {x = 1.464022917e+12;  y = -1.301973811e+11;  z = -2.352408453e+12;}; typeId= 3875; destinationSolarSystemId= 30001594; destinationStargateId= 50012730 } |> Some
      | 50012846 -> { StargateData.id= 50012846; name= "Stargate (Illi)"; solarSystemId= 30004292; position= {x = 5.674070016e+10;  y = -4345159680.0;  z = -2.487414374e+11;}; typeId= 29624; destinationSolarSystemId= 30004294; destinationStargateId= 50012989 } |> Some
      | 50012943 -> { StargateData.id= 50012943; name= "Stargate (GY5-26)"; solarSystemId= 30002946; position= {x = -3.017044378e+11;  y = -3.189633024e+10;  z = 3.238643712e+11;}; typeId= 16; destinationSolarSystemId= 30002947; destinationStargateId= 50012985 } |> Some
      | 50013040 -> { StargateData.id= 50013040; name= "Stargate (Fobiner)"; solarSystemId= 30004296; position= {x = -2.464658596e+12;  y = 9.303457382e+11;  z = 2.214142157e+12;}; typeId= 17; destinationSolarSystemId= 30004303; destinationStargateId= 50013198 } |> Some
      | 50013137 -> { StargateData.id= 50013137; name= "Stargate (R-ZESX)"; solarSystemId= 30003221; position= {x = -9.192177254e+11;  y = -1.459265126e+11;  z = -5.810492621e+11;}; typeId= 3875; destinationSolarSystemId= 30003218; destinationStargateId= 50011528 } |> Some
      | 50013234 -> { StargateData.id= 50013234; name= "Stargate (ZU-MS3)"; solarSystemId= 30004956; position= {x = 3.253711258e+11;  y = 2.58066432e+10;  z = 9.474208973e+11;}; typeId= 29624; destinationSolarSystemId= 30004955; destinationStargateId= 50013030 } |> Some
      | 50013331 -> { StargateData.id= 50013331; name= "Stargate (3ZTV-V)"; solarSystemId= 30004629; position= {x = 5.508195164e+12;  y = 2.918191104e+10;  z = -1.902720246e+12;}; typeId= 3875; destinationSolarSystemId= 30004628; destinationStargateId= 50013063 } |> Some
      | 50013428 -> { StargateData.id= 50013428; name= "Stargate (ZID-LE)"; solarSystemId= 30004490; position= {x = 2.404200038e+11;  y = -3.11334912e+10;  z = 4.639758336e+11;}; typeId= 29633; destinationSolarSystemId= 30004489; destinationStargateId= 50013382 } |> Some
      | 50013525 -> { StargateData.id= 50013525; name= "Stargate (Fihrneh)"; solarSystemId= 30004266; position= {x = -2.406837043e+11;  y = -2.931683328e+10;  z = 6.500149248e+11;}; typeId= 29624; destinationSolarSystemId= 30004254; destinationStargateId= 50011265 } |> Some
      | 50013622 -> { StargateData.id= 50013622; name= "Stargate (Biphi)"; solarSystemId= 30001668; position= {x = 4.938317414e+11;  y = 1.358531912e+12;  z = -3.31917312e+10;}; typeId= 29626; destinationSolarSystemId= 30003561; destinationStargateId= 50013621 } |> Some
      | 50013719 -> { StargateData.id= 50013719; name= "Stargate (Yarebap)"; solarSystemId= 30004110; position= {x = 2.099066266e+12;  y = 3.093239808e+11;  z = -7.000088986e+11;}; typeId= 29624; destinationSolarSystemId= 30004111; destinationStargateId= 50013720 } |> Some
      | 50013816 -> { StargateData.id= 50013816; name= "Stargate (A24L-V)"; solarSystemId= 30000786; position= {x = -3.678674534e+11;  y = -8.549069414e+12;  z = -4.73763926e+12;}; typeId= 12292; destinationSolarSystemId= 30000794; destinationStargateId= 50013815 } |> Some
      | 50013913 -> { StargateData.id= 50013913; name= "Stargate (Muvolailen)"; solarSystemId= 30000142; position= {x = 2.658067661e+11;  y = 6.079769764e+12;  z = 1.593583411e+12;}; typeId= 29629; destinationSolarSystemId= 30002780; destinationStargateId= 50013914 } |> Some
      | 50014010 -> { StargateData.id= 50014010; name= "Stargate (U-INPD)"; solarSystemId= 30003681; position= {x = -2.415642624e+11;  y = 2.013603471e+12;  z = -3.668914545e+12;}; typeId= 29632; destinationSolarSystemId= 30001997; destinationStargateId= 50014009 } |> Some
      | 50014107 -> { StargateData.id= 50014107; name= "Stargate (Sakenta)"; solarSystemId= 30000138; position= {x = -1.591270195e+11;  y = -1.103302656e+10;  z = -4.08874967e+11;}; typeId= 16; destinationSolarSystemId= 30010141; destinationStargateId= 50014108 } |> Some
      | 50014204 -> { StargateData.id= 50014204; name= "Stargate (SF-XJS)"; solarSystemId= 30004228; position= {x = -2.72804524e+12;  y = 6.019214131e+11;  z = 1.172485939e+12;}; typeId= 29632; destinationSolarSystemId= 30003654; destinationStargateId= 50014203 } |> Some
      | 50016241 -> { StargateData.id= 50016241; name= "Stargate (Kehjari)"; solarSystemId= 30045311; position= {x = 9.699607757e+11;  y = 5338275840.0;  z = 1.956609761e+12;}; typeId= 16; destinationSolarSystemId= 30045308; destinationStargateId= 50016242 } |> Some
      | 50016338 -> { StargateData.id= 50016338; name= "Stargate (Asakai)"; solarSystemId= 30045337; position= {x = 1.234974843e+12;  y = 1.079980032e+10;  z = -8.04919296e+10;}; typeId= 16; destinationSolarSystemId= 30045332; destinationStargateId= 50016337 } |> Some
      | _ -> None