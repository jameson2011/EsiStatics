﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stargates11=
    let getStargate id = 
      match id with 
      | 50000019 -> { StargateData.id= 50000019; name= "Stargate (Jurlesel)"; solarSystemId= 30003009; position= {x = -7.958556672e+10;  y = -9413713920.0;  z = 1.492881408e+10;}; typeId= 3875; destinationSolarSystemId= 30003013; destinationStargateId= 50003977 } |> Some
      | 50000116 -> { StargateData.id= 50000116; name= "Stargate (Isaziwa)"; solarSystemId= 30002750; position= {x = -1.614642586e+12;  y = 4.641721836e+12;  z = 2.979820954e+12;}; typeId= 29627; destinationSolarSystemId= 30002739; destinationStargateId= 50001981 } |> Some
      | 50000213 -> { StargateData.id= 50000213; name= "Stargate (Raa)"; solarSystemId= 30002957; position= {x = -1.76360448e+11;  y = 2.549747712e+10;  z = -4.884967834e+11;}; typeId= 29624; destinationSolarSystemId= 30002958; destinationStargateId= 50003966 } |> Some
      | 50000310 -> { StargateData.id= 50000310; name= "Stargate (Kiskoken)"; solarSystemId= 30001357; position= {x = 1.23945726e+12;  y = 6.337646592e+10;  z = -1.147285094e+11;}; typeId= 16; destinationSolarSystemId= 30001360; destinationStargateId= 50002660 } |> Some
      | 50000407 -> { StargateData.id= 50000407; name= "Stargate (K0CN-3)"; solarSystemId= 30001170; position= {x = 3.250710405e+12;  y = -5.394212045e+11;  z = -3.439219139e+12;}; typeId= 29624; destinationSolarSystemId= 30001172; destinationStargateId= 50000727 } |> Some
      | 50000504 -> { StargateData.id= 50000504; name= "Stargate (Zororzih)"; solarSystemId= 30002197; position= {x = 2.143011226e+11;  y = 2.229703434e+12;  z = 1.665810555e+12;}; typeId= 29626; destinationSolarSystemId= 30004081; destinationStargateId= 50000786 } |> Some
      | 50000601 -> { StargateData.id= 50000601; name= "Stargate (Eshwil)"; solarSystemId= 30000089; position= {x = -4.56347775e+12;  y = 4.467731251e+11;  z = -9.661556736e+11;}; typeId= 29624; destinationSolarSystemId= 30000091; destinationStargateId= 50002901 } |> Some
      | 50000698 -> { StargateData.id= 50000698; name= "Stargate (B1UE-J)"; solarSystemId= 30002851; position= {x = -3.130069402e+11;  y = 6828810240.0;  z = 1.840679117e+12;}; typeId= 3875; destinationSolarSystemId= 30002850; destinationStargateId= 50000654 } |> Some
      | 50000795 -> { StargateData.id= 50000795; name= "Stargate (QZX-L9)"; solarSystemId= 30002834; position= {x = 3.979007877e+12;  y = -3.489036288e+11;  z = 1.6610782e+12;}; typeId= 3875; destinationSolarSystemId= 30002837; destinationStargateId= 50002006 } |> Some
      | 50000892 -> { StargateData.id= 50000892; name= "Stargate (PO4F-3)"; solarSystemId= 30001010; position= {x = 2.70600192e+10;  y = -2567577600.0;  z = -6.859026432e+10;}; typeId= 29633; destinationSolarSystemId= 30001012; destinationStargateId= 50002143 } |> Some
      | 50001086 -> { StargateData.id= 50001086; name= "Stargate (Tennen)"; solarSystemId= 30002762; position= {x = 2.002379858e+12;  y = -2.165520384e+11;  z = 1.34124884e+12;}; typeId= 16; destinationSolarSystemId= 30002763; destinationStargateId= 50001099 } |> Some
      | 50001183 -> { StargateData.id= 50001183; name= "Stargate (BLMX-B)"; solarSystemId= 30000618; position= {x = 4.728662016e+11;  y = 3.789361152e+10;  z = -1.157377352e+12;}; typeId= 29633; destinationSolarSystemId= 30000619; destinationStargateId= 50001302 } |> Some
      | 50001280 -> { StargateData.id= 50001280; name= "Stargate (1NZV-7)"; solarSystemId= 30001078; position= {x = -4.213102879e+12;  y = -5.749197619e+11;  z = -2.275460506e+12;}; typeId= 3875; destinationSolarSystemId= 30001081; destinationStargateId= 50001479 } |> Some
      | 50001377 -> { StargateData.id= 50001377; name= "Stargate (B-S42H)"; solarSystemId= 30000856; position= {x = -3.461634417e+12;  y = -6.922952294e+11;  z = -2.665475482e+12;}; typeId= 16; destinationSolarSystemId= 30000854; destinationStargateId= 50001260 } |> Some
      | 50001474 -> { StargateData.id= 50001474; name= "Stargate (SG-75T)"; solarSystemId= 30000669; position= {x = 9.893310874e+11;  y = 1.090910208e+11;  z = -5.207345971e+11;}; typeId= 29633; destinationSolarSystemId= 30000670; destinationStargateId= 50002018 } |> Some
      | 50001571 -> { StargateData.id= 50001571; name= "Stargate (F9-FUV)"; solarSystemId= 30002322; position= {x = -3.577423872e+11;  y = -6.203240448e+10;  z = -1.092765082e+12;}; typeId= 3875; destinationSolarSystemId= 30002320; destinationStargateId= 50000902 } |> Some
      | 50001668 -> { StargateData.id= 50001668; name= "Stargate (Q-UEN6)"; solarSystemId= 30000621; position= {x = 3.745958093e+12;  y = -3.392565658e+11;  z = -2.508927836e+12;}; typeId= 29633; destinationSolarSystemId= 30000618; destinationStargateId= 50001184 } |> Some
      | 50001862 -> { StargateData.id= 50001862; name= "Stargate (4-43BW)"; solarSystemId= 30000570; position= {x = -5.055982387e+11;  y = 2.501146829e+12;  z = 1.538249073e+12;}; typeId= 29635; destinationSolarSystemId= 30000730; destinationStargateId= 50002720 } |> Some
      | 50001959 -> { StargateData.id= 50001959; name= "Stargate (Doussivitte)"; solarSystemId= 30002713; position= {x = -1.728297492e+12;  y = 2.039475364e+12;  z = 2.359331758e+12;}; typeId= 3874; destinationSolarSystemId= 30002706; destinationStargateId= 50000144 } |> Some
      | 50002056 -> { StargateData.id= 50002056; name= "Stargate (LZ-6SU)"; solarSystemId= 30000213; position= {x = -3.386414899e+12;  y = -5.8584576e+11;  z = -3.352712847e+12;}; typeId= 16; destinationSolarSystemId= 30000208; destinationStargateId= 50000189 } |> Some
      | 50002153 -> { StargateData.id= 50002153; name= "Stargate (DUO-51)"; solarSystemId= 30000593; position= {x = -1.203163546e+11;  y = -5385953280.0;  z = -3.89208404e+12;}; typeId= 29633; destinationSolarSystemId= 30000595; destinationStargateId= 50003255 } |> Some
      | 50002250 -> { StargateData.id= 50002250; name= "Stargate (GM-0K7)"; solarSystemId= 30002137; position= {x = 2.52055511e+11;  y = 4.674146304e+10;  z = 5.530456474e+11;}; typeId= 29633; destinationSolarSystemId= 30002133; destinationStargateId= 50001773 } |> Some
      | 50002347 -> { StargateData.id= 50002347; name= "Stargate (Zororzih)"; solarSystemId= 30004083; position= {x = -4.618738483e+11;  y = 4.997566464e+10;  z = -1.427057172e+12;}; typeId= 29624; destinationSolarSystemId= 30004081; destinationStargateId= 50000788 } |> Some
      | 50002444 -> { StargateData.id= 50002444; name= "Stargate (B-5UFY)"; solarSystemId= 30000434; position= {x = -2.584547205e+12;  y = -1.750618522e+11;  z = -1.080172585e+12;}; typeId= 29633; destinationSolarSystemId= 30000435; destinationStargateId= 50002599 } |> Some
      | 50002541 -> { StargateData.id= 50002541; name= "Stargate (Ides)"; solarSystemId= 30003517; position= {x = 5.708986368e+11;  y = 5.920591872e+10;  z = -3.293457162e+12;}; typeId= 29624; destinationSolarSystemId= 30003513; destinationStargateId= 50001805 } |> Some
      | 50002638 -> { StargateData.id= 50002638; name= "Stargate (Cleyd)"; solarSystemId= 30005197; position= {x = 6.073359974e+11;  y = -1.979338752e+10;  z = 1.988759962e+11;}; typeId= 29624; destinationSolarSystemId= 30005194; destinationStargateId= 50002376 } |> Some
      | 50002735 -> { StargateData.id= 50002735; name= "Stargate (4U90-Z)"; solarSystemId= 30001266; position= {x = -2.106473718e+12;  y = 1.684537221e+12;  z = 4.91990999e+11;}; typeId= 29629; destinationSolarSystemId= 30002889; destinationStargateId= 50002993 } |> Some
      | 50002832 -> { StargateData.id= 50002832; name= "Stargate (63-7Q6)"; solarSystemId= 30001091; position= {x = -1.492053565e+12;  y = 2.000450765e+11;  z = -1.131689779e+12;}; typeId= 3875; destinationSolarSystemId= 30001092; destinationStargateId= 50003565 } |> Some
      | 50002929 -> { StargateData.id= 50002929; name= "Stargate (Obanen)"; solarSystemId= 30000154; position= {x = -5.291495424e+10;  y = -5495070720.0;  z = -2.930045338e+11;}; typeId= 16; destinationSolarSystemId= 30000155; destinationStargateId= 50003532 } |> Some
      | 50003026 -> { StargateData.id= 50003026; name= "Stargate (FO8M-2)"; solarSystemId= 30002890; position= {x = 1.594704077e+12;  y = -3.201219379e+11;  z = 2.038183895e+12;}; typeId= 16; destinationSolarSystemId= 30002891; destinationStargateId= 50003576 } |> Some
      | 50003123 -> { StargateData.id= 50003123; name= "Stargate (FSW-3C)"; solarSystemId= 30003709; position= {x = -3.509528863e+12;  y = -5.665370112e+10;  z = 1.932675072e+11;}; typeId= 29624; destinationSolarSystemId= 30003710; destinationStargateId= 50003205 } |> Some
      | 50003220 -> { StargateData.id= 50003220; name= "Stargate (Doril)"; solarSystemId= 30001046; position= {x = -3.164928e+11;  y = -4.875964416e+10;  z = 4.575850906e+11;}; typeId= 29633; destinationSolarSystemId= 30001047; destinationStargateId= 50003704 } |> Some
      | 50003317 -> { StargateData.id= 50003317; name= "Stargate (O7-7UX)"; solarSystemId= 30002115; position= {x = -1.098243686e+11;  y = -1.097723904e+10;  z = 2.051438592e+11;}; typeId= 29633; destinationSolarSystemId= 30002116; destinationStargateId= 50004179 } |> Some
      | 50003414 -> { StargateData.id= 50003414; name= "Stargate (Y-ORBJ)"; solarSystemId= 30004810; position= {x = -1.322234143e+12;  y = 2.584605082e+11;  z = 1.715579167e+12;}; typeId= 29633; destinationSolarSystemId= 30004809; destinationStargateId= 50003351 } |> Some
      | 50003511 -> { StargateData.id= 50003511; name= "Stargate (K-MGJ7)"; solarSystemId= 30001003; position= {x = -3.70075521e+12;  y = 8.748453888e+10;  z = -1.17715415e+12;}; typeId= 29633; destinationSolarSystemId= 30001006; destinationStargateId= 50007998 } |> Some
      | 50003608 -> { StargateData.id= 50003608; name= "Stargate (TP-RTO)"; solarSystemId= 30002326; position= {x = -2.296349614e+12;  y = 2.52853248e+11;  z = 2.082743869e+12;}; typeId= 3875; destinationSolarSystemId= 30002327; destinationStargateId= 50003892 } |> Some
      | 50003705 -> { StargateData.id= 50003705; name= "Stargate (Ansone)"; solarSystemId= 30002670; position= {x = -1.202966938e+11;  y = -1.216376832e+10;  z = 1.939564585e+12;}; typeId= 3875; destinationSolarSystemId= 30002669; destinationStargateId= 50003378 } |> Some
      | 50003802 -> { StargateData.id= 50003802; name= "Stargate (SLVP-D)"; solarSystemId= 30000480; position= {x = -1.841065206e+12;  y = 2.154294067e+11;  z = 1.013013996e+12;}; typeId= 29633; destinationSolarSystemId= 30000479; destinationStargateId= 50003357 } |> Some
      | 50003899 -> { StargateData.id= 50003899; name= "Stargate (504Z-V)"; solarSystemId= 30000917; position= {x = 3.037374259e+12;  y = 1.879006003e+11;  z = -1.333069455e+12;}; typeId= 29633; destinationSolarSystemId= 30000912; destinationStargateId= 50000839 } |> Some
      | 50004093 -> { StargateData.id= 50004093; name= "Stargate (E-C0SR)"; solarSystemId= 30001835; position= {x = 1.312268083e+12;  y = 1.104611328e+11;  z = 3.242310083e+12;}; typeId= 29624; destinationSolarSystemId= 30001834; destinationStargateId= 50004066 } |> Some
      | 50004190 -> { StargateData.id= 50004190; name= "Stargate (Chemilip)"; solarSystemId= 30003528; position= {x = -2.281029181e+12;  y = -2.530370765e+11;  z = 2.515464192e+10;}; typeId= 29624; destinationSolarSystemId= 30003529; destinationStargateId= 50004419 } |> Some
      | 50004287 -> { StargateData.id= 50004287; name= "Stargate (ZD1-Z2)"; solarSystemId= 30004818; position= {x = -3.856919962e+12;  y = -4.618652467e+11;  z = 3.042202952e+12;}; typeId= 29633; destinationSolarSystemId= 30004817; destinationStargateId= 50004213 } |> Some
      | 50004384 -> { StargateData.id= 50004384; name= "Stargate (Aeddin)"; solarSystemId= 30002385; position= {x = -2.480053862e+11;  y = -1.825959936e+10;  z = -3.488955187e+11;}; typeId= 29633; destinationSolarSystemId= 30002383; destinationStargateId= 50003398 } |> Some
      | 50004481 -> { StargateData.id= 50004481; name= "Stargate (UQ-PWD)"; solarSystemId= 30001206; position= {x = -2.737435853e+11;  y = 1.98715392e+10;  z = -1.341445325e+11;}; typeId= 29624; destinationSolarSystemId= 30001208; destinationStargateId= 50007479 } |> Some
      | 50004578 -> { StargateData.id= 50004578; name= "Stargate (Hek)"; solarSystemId= 30002054; position= {x = 9.654276096e+10;  y = 2.649930916e+12;  z = 1.418219397e+12;}; typeId= 3877; destinationSolarSystemId= 30002053; destinationStargateId= 50003917 } |> Some
      | 50004675 -> { StargateData.id= 50004675; name= "Stargate (HG-YEQ)"; solarSystemId= 30001133; position= {x = 1.391112561e+12;  y = -2.08990249e+11;  z = -2.542728192e+12;}; typeId= 3875; destinationSolarSystemId= 30001135; destinationStargateId= 50005161 } |> Some
      | 50004772 -> { StargateData.id= 50004772; name= "Stargate (DGDT-3)"; solarSystemId= 30003188; position= {x = 2.805091123e+11;  y = 4.37716992e+10;  z = 3.451838915e+12;}; typeId= 3875; destinationSolarSystemId= 30003187; destinationStargateId= 50004649 } |> Some
      | 50004869 -> { StargateData.id= 50004869; name= "Stargate (G-KCFT)"; solarSystemId= 30002858; position= {x = -5.748573389e+11;  y = 8.194461696e+10;  z = -5.067004846e+12;}; typeId= 3875; destinationSolarSystemId= 30002853; destinationStargateId= 50002537 } |> Some
      | 50004966 -> { StargateData.id= 50004966; name= "Stargate (Heydieles)"; solarSystemId= 30004980; position= {x = -3.29207255e+12;  y = -3.692024218e+11;  z = 8.017206067e+11;}; typeId= 3875; destinationSolarSystemId= 30004979; destinationStargateId= 50003311 } |> Some
      | 50005063 -> { StargateData.id= 50005063; name= "Stargate (Offugen)"; solarSystemId= 30002552; position= {x = -2.257771192e+12;  y = -4.30123008e+10;  z = -3.049496125e+12;}; typeId= 29633; destinationSolarSystemId= 30002549; destinationStargateId= 50004721 } |> Some
      | 50005160 -> { StargateData.id= 50005160; name= "Stargate (863P-X)"; solarSystemId= 30001135; position= {x = -2.09395753e+11;  y = 3.120672768e+10;  z = 2.611985203e+11;}; typeId= 3875; destinationSolarSystemId= 30001132; destinationStargateId= 50003861 } |> Some
      | 50005257 -> { StargateData.id= 50005257; name= "Stargate (PE-SAM)"; solarSystemId= 30005117; position= {x = -6.553055232e+10;  y = -4073840640.0;  z = -2.258437325e+11;}; typeId= 3875; destinationSolarSystemId= 30005118; destinationStargateId= 50005459 } |> Some
      | 50005354 -> { StargateData.id= 50005354; name= "Stargate (FX4L-2)"; solarSystemId= 30000836; position= {x = 1.967981568e+12;  y = 4.642639872e+10;  z = -1.491789373e+12;}; typeId= 29633; destinationSolarSystemId= 30000835; destinationStargateId= 50004973 } |> Some
      | 50005451 -> { StargateData.id= 50005451; name= "Stargate (Covryn)"; solarSystemId= 30003794; position= {x = -1.121184031e+12;  y = -1.299511296e+11;  z = 1.536274883e+12;}; typeId= 3875; destinationSolarSystemId= 30003795; destinationStargateId= 50006491 } |> Some
      | 50005548 -> { StargateData.id= 50005548; name= "Stargate (Arnola)"; solarSystemId= 30000030; position= {x = 2.926240604e+12;  y = -5.186552218e+11;  z = 1.177248154e+11;}; typeId= 17; destinationSolarSystemId= 30000112; destinationStargateId= 50007746 } |> Some
      | 50005645 -> { StargateData.id= 50005645; name= "Stargate (F-MKH3)"; solarSystemId= 30000933; position= {x = 2.230482739e+12;  y = 1.089961574e+11;  z = -1.688711455e+12;}; typeId= 29633; destinationSolarSystemId= 30000934; destinationStargateId= 50005906 } |> Some
      | 50005742 -> { StargateData.id= 50005742; name= "Stargate (Jeni)"; solarSystemId= 30005032; position= {x = -2.582355026e+12;  y = 3.857559552e+10;  z = 7.978611917e+11;}; typeId= 29624; destinationSolarSystemId= 30005033; destinationStargateId= 50005861 } |> Some
      | 50005839 -> { StargateData.id= 50005839; name= "Stargate (Chemilip)"; solarSystemId= 30003531; position= {x = 1.950359962e+11;  y = 3.20034816e+10;  z = -1.705733775e+12;}; typeId= 29624; destinationSolarSystemId= 30003529; destinationStargateId= 50004421 } |> Some
      | 50005936 -> { StargateData.id= 50005936; name= "Stargate (PF-QHK)"; solarSystemId= 30001325; position= {x = -1.872388301e+12;  y = -2.213178163e+11;  z = 6.877464576e+11;}; typeId= 16; destinationSolarSystemId= 30001324; destinationStargateId= 50005863 } |> Some
      | 50006033 -> { StargateData.id= 50006033; name= "Stargate (Ohmahailen)"; solarSystemId= 30000134; position= {x = -1.044904305e+12;  y = -6.064508928e+10;  z = 7.462334054e+11;}; typeId= 16; destinationSolarSystemId= 30000136; destinationStargateId= 50009959 } |> Some
      | 50006130 -> { StargateData.id= 50006130; name= "Stargate (U8MM-3)"; solarSystemId= 30000428; position= {x = -1.514331464e+12;  y = -1.270351872e+11;  z = -2.364219924e+12;}; typeId= 3876; destinationSolarSystemId= 30000427; destinationStargateId= 50006028 } |> Some
      | 50006227 -> { StargateData.id= 50006227; name= "Stargate (N-5476)"; solarSystemId= 30001312; position= {x = 5.061660058e+12;  y = 9.933212467e+11;  z = -9.239626138e+11;}; typeId= 16; destinationSolarSystemId= 30001309; destinationStargateId= 50005714 } |> Some
      | 50006324 -> { StargateData.id= 50006324; name= "Stargate (RLSI-V)"; solarSystemId= 30002441; position= {x = 3.965495255e+12;  y = 3.700822426e+11;  z = -2.155351695e+12;}; typeId= 16; destinationSolarSystemId= 30002443; destinationStargateId= 50008707 } |> Some
      | 50006421 -> { StargateData.id= 50006421; name= "Stargate (L-B55M)"; solarSystemId= 30001238; position= {x = 5.113014313e+12;  y = -2.378217923e+12;  z = -3.693055549e+12;}; typeId= 17; destinationSolarSystemId= 30001223; destinationStargateId= 50005821 } |> Some
      | 50006518 -> { StargateData.id= 50006518; name= "Stargate (PVH8-0)"; solarSystemId= 30003280; position= {x = -4.752948388e+12;  y = -6.110145331e+11;  z = 1.847513088e+10;}; typeId= 3875; destinationSolarSystemId= 30003283; destinationStargateId= 50006713 } |> Some
      | 50006615 -> { StargateData.id= 50006615; name= "Stargate (OTJ9-E)"; solarSystemId= 30001589; position= {x = -3.11087063e+11;  y = -3.47510784e+10;  z = 6.222184858e+11;}; typeId= 3875; destinationSolarSystemId= 30001586; destinationStargateId= 50005929 } |> Some
      | 50006712 -> { StargateData.id= 50006712; name= "Stargate (Metserel)"; solarSystemId= 30002640; position= {x = 2.876967444e+12;  y = 3.500852429e+11;  z = 4.097427456e+11;}; typeId= 3875; destinationSolarSystemId= 30002637; destinationStargateId= 50004951 } |> Some
      | 50006809 -> { StargateData.id= 50006809; name= "Stargate (Dehrokh)"; solarSystemId= 30004104; position= {x = -6.185792717e+11;  y = -1.44021504e+10;  z = -1.486374912e+11;}; typeId= 29624; destinationSolarSystemId= 30004105; destinationStargateId= 50007238 } |> Some
      | 50007003 -> { StargateData.id= 50007003; name= "Stargate (GDO-7H)"; solarSystemId= 30001864; position= {x = -2.557986939e+12;  y = 4.037562655e+12;  z = 2.186655375e+12;}; typeId= 17; destinationSolarSystemId= 30001873; destinationStargateId= 50007343 } |> Some
      | 50007100 -> { StargateData.id= 50007100; name= "Stargate (F-3H2P)"; solarSystemId= 30002619; position= {x = 1.016694989e+12;  y = -4.950543852e+12;  z = 3.551770337e+12;}; typeId= 3877; destinationSolarSystemId= 30002598; destinationStargateId= 50006353 } |> Some
      | 50007197 -> { StargateData.id= 50007197; name= "Stargate (GTQ-C9)"; solarSystemId= 30003201; position= {x = 1.104303759e+12;  y = -1.063907328e+10;  z = 6.970615603e+12;}; typeId= 3875; destinationSolarSystemId= 30003199; destinationStargateId= 50006736 } |> Some
      | 50007294 -> { StargateData.id= 50007294; name= "Stargate (Aring)"; solarSystemId= 30005241; position= {x = -4.972710175e+12;  y = 5.312899891e+11;  z = -2.75431723e+12;}; typeId= 29624; destinationSolarSystemId= 30005239; destinationStargateId= 50006644 } |> Some
      | 50007391 -> { StargateData.id= 50007391; name= "Stargate (Gare)"; solarSystemId= 30003818; position= {x = -2.291368796e+12;  y = -7.728784957e+12;  z = -4.793040691e+12;}; typeId= 3874; destinationSolarSystemId= 30003805; destinationStargateId= 50006899 } |> Some
      | 50007488 -> { StargateData.id= 50007488; name= "Stargate (BOZ1-O)"; solarSystemId= 30000505; position= {x = 5.653391155e+12;  y = -9.447261389e+11;  z = -3.15165696e+11;}; typeId= 29633; destinationSolarSystemId= 30000504; destinationStargateId= 50007413 } |> Some
      | 50007585 -> { StargateData.id= 50007585; name= "Stargate (G5ED-Y)"; solarSystemId= 30000311; position= {x = 3.100388966e+11;  y = -2467799040.0;  z = 8.01451991e+11;}; typeId= 16; destinationSolarSystemId= 30000310; destinationStargateId= 50006917 } |> Some
      | 50007682 -> { StargateData.id= 50007682; name= "Stargate (Pashanai)"; solarSystemId= 30005234; position= {x = -2.538891141e+12;  y = 5.144158618e+11;  z = -1.080157102e+12;}; typeId= 29624; destinationSolarSystemId= 30005231; destinationStargateId= 50007152 } |> Some
      | 50007779 -> { StargateData.id= 50007779; name= "Stargate (AY-YCU)"; solarSystemId= 30003774; position= {x = 1.959673405e+12;  y = -7.548460646e+11;  z = 1.803446723e+12;}; typeId= 17; destinationSolarSystemId= 30003746; destinationStargateId= 50007161 } |> Some
      | 50007876 -> { StargateData.id= 50007876; name= "Stargate (Botane)"; solarSystemId= 30002659; position= {x = -3.344888095e+12;  y = 1.956216422e+11;  z = -1.350143386e+12;}; typeId= 3875; destinationSolarSystemId= 30002661; destinationStargateId= 50010398 } |> Some
      | 50007973 -> { StargateData.id= 50007973; name= "Stargate (Messoya)"; solarSystemId= 30000163; position= {x = 7.121487053e+11;  y = 8573214720.0;  z = -6.991466496e+10;}; typeId= 16; destinationSolarSystemId= 30000164; destinationStargateId= 50008446 } |> Some
      | 50008070 -> { StargateData.id= 50008070; name= "Stargate (Sahtogas)"; solarSystemId= 30003087; position= {x = 7.508238459e+12;  y = 4.374244147e+11;  z = 2.409405358e+12;}; typeId= 29624; destinationSolarSystemId= 30003086; destinationStargateId= 50007968 } |> Some
      | 50008167 -> { StargateData.id= 50008167; name= "Stargate (Oppold)"; solarSystemId= 30003433; position= {x = -2.095216189e+12;  y = 3.289919078e+11;  z = 8.274647654e+12;}; typeId= 29633; destinationSolarSystemId= 30003430; destinationStargateId= 50006725 } |> Some
      | 50008264 -> { StargateData.id= 50008264; name= "Stargate (Iaokit)"; solarSystemId= 30004118; position= {x = -8.975345664e+11;  y = -4.940918784e+10;  z = 2.186552893e+12;}; typeId= 29624; destinationSolarSystemId= 30004120; destinationStargateId= 50008745 } |> Some
      | 50008361 -> { StargateData.id= 50008361; name= "Stargate (Z-K495)"; solarSystemId= 30004342; position= {x = -3.923038618e+11;  y = -70164480.0;  z = -1.694471578e+12;}; typeId= 16; destinationSolarSystemId= 30004341; destinationStargateId= 50008301 } |> Some
      | 50008458 -> { StargateData.id= 50008458; name= "Stargate (W5-VBR)"; solarSystemId= 30003206; position= {x = 2.08697303e+11;  y = 1.974718464e+10;  z = 1.57116457e+11;}; typeId= 3875; destinationSolarSystemId= 30003205; destinationStargateId= 50008154 } |> Some
      | 50008555 -> { StargateData.id= 50008555; name= "Stargate (FYI-49)"; solarSystemId= 30002126; position= {x = 3.294932582e+11;  y = 3.869601792e+10;  z = -3.537598464e+11;}; typeId= 29633; destinationSolarSystemId= 30002128; destinationStargateId= 50009429 } |> Some
      | 50008652 -> { StargateData.id= 50008652; name= "Stargate (KMV-CQ)"; solarSystemId= 30003623; position= {x = -9.065342976e+11;  y = -1.810633114e+11;  z = -3.483649229e+11;}; typeId= 16; destinationSolarSystemId= 30003625; destinationStargateId= 50008751 } |> Some
      | 50008749 -> { StargateData.id= 50008749; name= "Stargate (52G-NZ)"; solarSystemId= 30004345; position= {x = 1.957366211e+12;  y = -2.95849943e+11;  z = -1.352445665e+12;}; typeId= 16; destinationSolarSystemId= 30004344; destinationStargateId= 50008671 } |> Some
      | 50008846 -> { StargateData.id= 50008846; name= "Stargate (V-X0KM)"; solarSystemId= 30003224; position= {x = -2.014488576e+11;  y = -2.629496832e+10;  z = 3.256163942e+11;}; typeId= 3875; destinationSolarSystemId= 30003226; destinationStargateId= 50009424 } |> Some
      | 50008943 -> { StargateData.id= 50008943; name= "Stargate (Hoshoun)"; solarSystemId= 30003559; position= {x = 4.821980652e+12;  y = -1.152468173e+11;  z = -4.63624704e+12;}; typeId= 29624; destinationSolarSystemId= 30003560; destinationStargateId= 50009253 } |> Some
      | 50009040 -> { StargateData.id= 50009040; name= "Stargate (9GYL-O)"; solarSystemId= 30003340; position= {x = 3.48762071e+11;  y = 2.300030976e+10;  z = -1.3537391e+12;}; typeId= 3875; destinationSolarSystemId= 30003338; destinationStargateId= 50008980 } |> Some
      | 50009137 -> { StargateData.id= 50009137; name= "Stargate (UYG-YX)"; solarSystemId= 30001120; position= {x = -1.628571648e+11;  y = -2.716250112e+10;  z = 1.060212204e+12;}; typeId= 3875; destinationSolarSystemId= 30001121; destinationStargateId= 50009457 } |> Some
      | 50009234 -> { StargateData.id= 50009234; name= "Stargate (Omam)"; solarSystemId= 30004136; position= {x = -4.052886528e+12;  y = 7.363620864e+10;  z = -3.344555581e+12;}; typeId= 29624; destinationSolarSystemId= 30004137; destinationStargateId= 50009511 } |> Some
      | 50009331 -> { StargateData.id= 50009331; name= "Stargate (4S-PVC)"; solarSystemId= 30001334; position= {x = -2.335985541e+12;  y = 8.177872896e+10;  z = 1.264547021e+11;}; typeId= 16; destinationSolarSystemId= 30001335; destinationStargateId= 50010989 } |> Some
      | 50009428 -> { StargateData.id= 50009428; name= "Stargate (9CG6-H)"; solarSystemId= 30003983; position= {x = 1.906801336e+12;  y = -3.647114035e+11;  z = -3.985742684e+12;}; typeId= 29624; destinationSolarSystemId= 30003979; destinationStargateId= 50009105 } |> Some
      | 50009525 -> { StargateData.id= 50009525; name= "Stargate (Osmeden)"; solarSystemId= 30003835; position= {x = -9.289141862e+11;  y = 5803745280.0;  z = -1.514423624e+12;}; typeId= 3875; destinationSolarSystemId= 30003831; destinationStargateId= 50008607 } |> Some
      | 50009622 -> { StargateData.id= 50009622; name= "Stargate (Oerse)"; solarSystemId= 30003579; position= {x = -2.786612429e+11;  y = -2.957663846e+11;  z = 2.079297085e+12;}; typeId= 3874; destinationSolarSystemId= 30003577; destinationStargateId= 50009466 } |> Some
      | 50009719 -> { StargateData.id= 50009719; name= "Stargate (6-TYRX)"; solarSystemId= 30003140; position= {x = -7.800221245e+12;  y = 1.450028114e+12;  z = -5.507522028e+12;}; typeId= 29624; destinationSolarSystemId= 30003145; destinationStargateId= 50011434 } |> Some
      | 50009816 -> { StargateData.id= 50009816; name= "Stargate (4-PCHD)"; solarSystemId= 30004167; position= {x = 6.33745367e+11;  y = 3.426328166e+11;  z = -3.173807186e+12;}; typeId= 3874; destinationSolarSystemId= 30004165; destinationStargateId= 50009439 } |> Some
      | 50009913 -> { StargateData.id= 50009913; name= "Stargate (9-EXU9)"; solarSystemId= 30005147; position= {x = 1.560134861e+11;  y = 7231365120.0;  z = 9.458528256e+10;}; typeId= 3875; destinationSolarSystemId= 30005148; destinationStargateId= 50009964 } |> Some
      | 50010010 -> { StargateData.id= 50010010; name= "Stargate (4-2UXV)"; solarSystemId= 30004013; position= {x = -4.081087242e+12;  y = 7.945387622e+11;  z = -3.851033395e+11;}; typeId= 29624; destinationSolarSystemId= 30004014; destinationStargateId= 50010048 } |> Some
      | 50010107 -> { StargateData.id= 50010107; name= "Stargate (VORM-W)"; solarSystemId= 30000320; position= {x = 1.108167352e+12;  y = 2.186650829e+11;  z = -6.364231066e+12;}; typeId= 16; destinationSolarSystemId= 30000322; destinationStargateId= 50011542 } |> Some
      | 50010204 -> { StargateData.id= 50010204; name= "Stargate (GW7P-8)"; solarSystemId= 30003652; position= {x = 1.256856822e+12;  y = 2.211531571e+11;  z = -2.632557773e+11;}; typeId= 16; destinationSolarSystemId= 30003653; destinationStargateId= 50010244 } |> Some
      | 50010301 -> { StargateData.id= 50010301; name= "Stargate (RLDS-R)"; solarSystemId= 30001899; position= {x = -1.478695035e+12;  y = -2.830367539e+11;  z = -6.223932211e+11;}; typeId= 29624; destinationSolarSystemId= 30001902; destinationStargateId= 50010549 } |> Some
      | 50010398 -> { StargateData.id= 50010398; name= "Stargate (Dodixie)"; solarSystemId= 30002661; position= {x = 7.005977395e+11;  y = 5.30552832e+10;  z = 2.101114429e+12;}; typeId= 3875; destinationSolarSystemId= 30002659; destinationStargateId= 50007876 } |> Some
      | 50010495 -> { StargateData.id= 50010495; name= "Stargate (IAMJ-Q)"; solarSystemId= 30003240; position= {x = -4.834464522e+12;  y = 8.504263066e+11;  z = 7.958623642e+12;}; typeId= 3875; destinationSolarSystemId= 30003241; destinationStargateId= 50010915 } |> Some
      | 50010592 -> { StargateData.id= 50010592; name= "Stargate (Nafrivik)"; solarSystemId= 30001707; position= {x = 2.435210035e+11;  y = -1.46331648e+10;  z = 3.926943744e+11;}; typeId= 29624; destinationSolarSystemId= 30001702; destinationStargateId= 50006418 } |> Some
      | 50010689 -> { StargateData.id= 50010689; name= "Stargate (KR8-27)"; solarSystemId= 30004890; position= {x = 3.49469184e+12;  y = -4.634280346e+11;  z = -3.694067835e+12;}; typeId= 29633; destinationSolarSystemId= 30004895; destinationStargateId= 50011426 } |> Some
      | 50010786 -> { StargateData.id= 50010786; name= "Stargate (QKQ3-L)"; solarSystemId= 30005171; position= {x = -5.476638106e+12;  y = 2.672626483e+11;  z = -4.915739443e+11;}; typeId= 3875; destinationSolarSystemId= 30005172; destinationStargateId= 50010907 } |> Some
      | 50010883 -> { StargateData.id= 50010883; name= "Stargate (Colelie)"; solarSystemId= 30002681; position= {x = 1.965635789e+12;  y = 1.922269594e+11;  z = 1.367373865e+12;}; typeId= 3875; destinationSolarSystemId= 30002682; destinationStargateId= 50011472 } |> Some
      | 50010980 -> { StargateData.id= 50010980; name= "Stargate (49-U6U)"; solarSystemId= 30004008; position= {x = 1.344824402e+12;  y = -1.746776064e+10;  z = -1.512542085e+12;}; typeId= 29624; destinationSolarSystemId= 30004009; destinationStargateId= 50011029 } |> Some
      | 50011077 -> { StargateData.id= 50011077; name= "Stargate (R2TJ-1)"; solarSystemId= 30004893; position= {x = -8.138554982e+11;  y = 5.919240192e+10;  z = -1.867682734e+12;}; typeId= 29633; destinationSolarSystemId= 30004891; destinationStargateId= 50010944 } |> Some
      | 50011174 -> { StargateData.id= 50011174; name= "Stargate (UAJ5-K)"; solarSystemId= 30001796; position= {x = 1.077850522e+11;  y = -5528739840.0;  z = -3.642228326e+11;}; typeId= 3875; destinationSolarSystemId= 30001797; destinationStargateId= 50011518 } |> Some
      | 50011271 -> { StargateData.id= 50011271; name= "Stargate (UFXF-C)"; solarSystemId= 30003351; position= {x = -2.758089523e+11;  y = -4.426174464e+10;  z = -9.910922035e+11;}; typeId= 3875; destinationSolarSystemId= 30003352; destinationStargateId= 50011361 } |> Some
      | 50011368 -> { StargateData.id= 50011368; name= "Stargate (6Z9-0M)"; solarSystemId= 30004058; position= {x = 6.602129818e+11;  y = -5.05952256e+10;  z = -9.644986368e+10;}; typeId= 3875; destinationSolarSystemId= 30004057; destinationStargateId= 50011178 } |> Some
      | 50011465 -> { StargateData.id= 50011465; name= "Stargate (GK3-RX)"; solarSystemId= 30003234; position= {x = 3.321858048e+11;  y = -2.674962432e+10;  z = -1.307040276e+12;}; typeId= 3875; destinationSolarSystemId= 30003232; destinationStargateId= 50010646 } |> Some
      | 50011562 -> { StargateData.id= 50011562; name= "Stargate (Z9PP-H)"; solarSystemId= 30004586; position= {x = 6.10613207e+11;  y = -8893440000.0;  z = -1.533482803e+12;}; typeId= 3875; destinationSolarSystemId= 30004584; destinationStargateId= 50010935 } |> Some
      | 50011659 -> { StargateData.id= 50011659; name= "Stargate (Lazer)"; solarSystemId= 30003590; position= {x = -3.785132851e+11;  y = 1.469952e+10;  z = 3.76157184e+11;}; typeId= 3875; destinationSolarSystemId= 30003592; destinationStargateId= 50012551 } |> Some
      | 50011756 -> { StargateData.id= 50011756; name= "Stargate (B17O-R)"; solarSystemId= 30004591; position= {x = -1.229439836e+12;  y = 2.316496896e+10;  z = 5.446701466e+11;}; typeId= 3875; destinationSolarSystemId= 30004590; destinationStargateId= 50011666 } |> Some
      | 50011853 -> { StargateData.id= 50011853; name= "Stargate (Amoen)"; solarSystemId= 30003848; position= {x = -1.51557206e+12;  y = -2.193959731e+11;  z = -3.836607406e+12;}; typeId= 3875; destinationSolarSystemId= 30003847; destinationStargateId= 50010958 } |> Some
      | 50011950 -> { StargateData.id= 50011950; name= "Stargate (ZWV-GD)"; solarSystemId= 30004689; position= {x = 3.537297039e+12;  y = -4.861438771e+11;  z = -7.039288812e+12;}; typeId= 29624; destinationSolarSystemId= 30004687; destinationStargateId= 50011314 } |> Some
      | 50012047 -> { StargateData.id= 50012047; name= "Stargate (Y-PNRL)"; solarSystemId= 30001256; position= {x = -3.652835328e+11;  y = 1179525120.0;  z = -7.938134016e+10;}; typeId= 29624; destinationSolarSystemId= 30001255; destinationStargateId= 50011319 } |> Some
      | 50012144 -> { StargateData.id= 50012144; name= "Stargate (Soliara)"; solarSystemId= 30004275; position= {x = -7.977788621e+11;  y = -7.952510976e+10;  z = 3.26647124e+12;}; typeId= 29624; destinationSolarSystemId= 30004273; destinationStargateId= 50011535 } |> Some
      | 50012241 -> { StargateData.id= 50012241; name= "Stargate (ED-L9T)"; solarSystemId= 30004022; position= {x = -1.595181834e+12;  y = -1.12918487e+11;  z = -3.379831235e+12;}; typeId= 29624; destinationSolarSystemId= 30004020; destinationStargateId= 50011226 } |> Some
      | 50012338 -> { StargateData.id= 50012338; name= "Stargate (Kattegaud)"; solarSystemId= 30002417; position= {x = -4.346372383e+12;  y = -4.962807398e+11;  z = 3.300610007e+12;}; typeId= 29633; destinationSolarSystemId= 30002416; destinationStargateId= 50012135 } |> Some
      | 50012435 -> { StargateData.id= 50012435; name= "Stargate (D2EZ-X)"; solarSystemId= 30004901; position= {x = -8.605730611e+12;  y = -1.128818688e+11;  z = 1.683382395e+12;}; typeId= 29633; destinationSolarSystemId= 30004902; destinationStargateId= 50012572 } |> Some
      | 50012532 -> { StargateData.id= 50012532; name= "Stargate (3D5K-R)"; solarSystemId= 30004032; position= {x = -9.433373123e+12;  y = 4.453257216e+10;  z = 3.599583683e+12;}; typeId= 29624; destinationSolarSystemId= 30004036; destinationStargateId= 50013346 } |> Some
      | 50012629 -> { StargateData.id= 50012629; name= "Stargate (QLU-P0)"; solarSystemId= 30004854; position= {x = 7.487079629e+11;  y = -7.803285504e+10;  z = -3.819102904e+12;}; typeId= 29633; destinationSolarSystemId= 30004857; destinationStargateId= 50012770 } |> Some
      | 50012726 -> { StargateData.id= 50012726; name= "Stargate (OBK-K8)"; solarSystemId= 30004484; position= {x = -1.959240376e+12;  y = -3.852222874e+11;  z = -5.599726387e+11;}; typeId= 3877; destinationSolarSystemId= 30004487; destinationStargateId= 50013070 } |> Some
      | 50012823 -> { StargateData.id= 50012823; name= "Stargate (KVN-36)"; solarSystemId= 30004640; position= {x = -8.164958085e+12;  y = -1.616703898e+11;  z = 5.880536678e+11;}; typeId= 3875; destinationSolarSystemId= 30004642; destinationStargateId= 50012924 } |> Some
      | 50012920 -> { StargateData.id= 50012920; name= "Stargate (QCDG-H)"; solarSystemId= 30004859; position= {x = 1.907946701e+11;  y = 2.829398876e+12;  z = 4.409370624e+11;}; typeId= 3877; destinationSolarSystemId= 30004855; destinationStargateId= 50012662 } |> Some
      | 50013017 -> { StargateData.id= 50013017; name= "Stargate (1-NJLK)"; solarSystemId= 30004941; position= {x = -3.057314611e+11;  y = -1.675554816e+10;  z = 1.008527647e+12;}; typeId= 29624; destinationSolarSystemId= 30004940; destinationStargateId= 50012852 } |> Some
      | 50013114 -> { StargateData.id= 50013114; name= "Stargate (5-NZNW)"; solarSystemId= 30004862; position= {x = 1.749144084e+12;  y = -2528501760.0;  z = -1.919951217e+12;}; typeId= 29633; destinationSolarSystemId= 30004865; destinationStargateId= 50013441 } |> Some
      | 50013211 -> { StargateData.id= 50013211; name= "Stargate (XUW-3X)"; solarSystemId= 30004656; position= {x = 9.243646771e+11;  y = 1.598559437e+11;  z = -1.766159032e+12;}; typeId= 3875; destinationSolarSystemId= 30004655; destinationStargateId= 50012981 } |> Some
      | 50013308 -> { StargateData.id= 50013308; name= "Stargate (D9Z-VY)"; solarSystemId= 30004225; position= {x = 4.145795482e+11;  y = -1.231884288e+10;  z = -1.119194358e+12;}; typeId= 3875; destinationSolarSystemId= 30004222; destinationStargateId= 50013066 } |> Some
      | 50013405 -> { StargateData.id= 50013405; name= "Stargate (Huna)"; solarSystemId= 30004306; position= {x = 9.504275251e+11;  y = 2.16926208e+10;  z = -2.830470758e+11;}; typeId= 29624; destinationSolarSystemId= 30004304; destinationStargateId= 50013225 } |> Some
      | 50013502 -> { StargateData.id= 50013502; name= "Stargate (ZH-KEV)"; solarSystemId= 30001921; position= {x = -8.273676288e+11;  y = -4.293586944e+10;  z = -3.823628575e+12;}; typeId= 29624; destinationSolarSystemId= 30001922; destinationStargateId= 50013516 } |> Some
      | 50013793 -> { StargateData.id= 50013793; name= "Stargate (OKEO-X)"; solarSystemId= 30004486; position= {x = 1.500781486e+12;  y = -9.416699904e+10;  z = 5.27497175e+11;}; typeId= 12292; destinationSolarSystemId= 30004924; destinationStargateId= 50013794 } |> Some
      | 50013890 -> { StargateData.id= 50013890; name= "Stargate (Malkalen)"; solarSystemId= 30001363; position= {x = 6.506723328e+11;  y = 2.732922348e+12;  z = 1.723003331e+12;}; typeId= 29627; destinationSolarSystemId= 30001393; destinationStargateId= 50013889 } |> Some
      | 50013987 -> { StargateData.id= 50013987; name= "Stargate (IAS-I5)"; solarSystemId= 30000492; position= {x = -5.536636477e+12;  y = -8.020867891e+11;  z = -1.691178394e+12;}; typeId= 3877; destinationSolarSystemId= 30000509; destinationStargateId= 50013988 } |> Some
      | 50014084 -> { StargateData.id= 50014084; name= "Stargate (Ivar)"; solarSystemId= 30002508; position= {x = 3.818268672e+11;  y = 5.345857536e+10;  z = 4.148570726e+12;}; typeId= 3877; destinationSolarSystemId= 30002524; destinationStargateId= 50014083 } |> Some
      | 50014181 -> { StargateData.id= 50014181; name= "Stargate (Erego)"; solarSystemId= 30003403; position= {x = 6.574481818e+11;  y = -1.105790976e+11;  z = -4.713500959e+12;}; typeId= 29633; destinationSolarSystemId= 30033410; destinationStargateId= 50014182 } |> Some
      | 50014278 -> { StargateData.id= 50014278; name= "Stargate (Y8K-5B)"; solarSystemId= 30001597; position= {x = -6.418379981e+11;  y = -4.308812636e+12;  z = 1.001064407e+12;}; typeId= 3874; destinationSolarSystemId= 30001559; destinationStargateId= 50014277 } |> Some
      | 50016315 -> { StargateData.id= 50016315; name= "Stargate (Tsuruma)"; solarSystemId= 30045324; position= {x = -3.976052122e+12;  y = -1.849910477e+11;  z = -5.765769339e+12;}; typeId= 16; destinationSolarSystemId= 30045327; destinationStargateId= 50016316 } |> Some
      | 50016509 -> { StargateData.id= 50016509; name= "Stargate (Senda)"; solarSystemId= 30045328; position= {x = 8.216986109e+11;  y = 5.254739104e+10;  z = 1.283241369e+12;}; typeId= 56317; destinationSolarSystemId= 30020141; destinationStargateId= 50016548 } |> Some
      | _ -> None