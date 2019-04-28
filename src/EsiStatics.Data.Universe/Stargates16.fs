﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stargates16=
    let getStargate id = 
      match id with 
      | 50000024 -> { StargateData.id= 50000024; name= "Stargate (Aurohunen)"; solarSystemId= 30001356; position= {x = 3.921716429e+11;  y = 4.641288192e+10;  z = 1.510551921e+12;}; typeId= 16; destinationSolarSystemId= 30001361; destinationStargateId= 50003464 } |> Some
      | 50000121 -> { StargateData.id= 50000121; name= "Stargate (K212-A)"; solarSystemId= 30000656; position= {x = 5.929981133e+11;  y = -1.045572403e+11;  z = -4.109189161e+12;}; typeId= 29633; destinationSolarSystemId= 30000665; destinationStargateId= 50002172 } |> Some
      | 50000315 -> { StargateData.id= 50000315; name= "Stargate (1NZV-7)"; solarSystemId= 30001076; position= {x = 8.594253005e+11;  y = 6.150795264e+10;  z = 8.136338227e+11;}; typeId= 3875; destinationSolarSystemId= 30001081; destinationStargateId= 50001478 } |> Some
      | 50000412 -> { StargateData.id= 50000412; name= "Stargate (OTJ-4W)"; solarSystemId= 30001536; position= {x = -3.031462011e+12;  y = -3.774022042e+11;  z = 8.969017344e+11;}; typeId= 3875; destinationSolarSystemId= 30001538; destinationStargateId= 50001290 } |> Some
      | 50000509 -> { StargateData.id= 50000509; name= "Stargate (V-IUEL)"; solarSystemId= 30001009; position= {x = 1.196440166e+12;  y = 1.588586496e+11;  z = -2.781586637e+11;}; typeId= 29633; destinationSolarSystemId= 30001008; destinationStargateId= 50000426 } |> Some
      | 50000703 -> { StargateData.id= 50000703; name= "Stargate (U-QVWD)"; solarSystemId= 30001156; position= {x = 2.560579707e+12;  y = -1.312101581e+11;  z = 6.463051653e+12;}; typeId= 29624; destinationSolarSystemId= 30001155; destinationStargateId= 50000565 } |> Some
      | 50000800 -> { StargateData.id= 50000800; name= "Stargate (Ebidan)"; solarSystemId= 30002189; position= {x = 2.0353058e+12;  y = -1.476836966e+11;  z = -4.811320934e+11;}; typeId= 29624; destinationSolarSystemId= 30002196; destinationStargateId= 50005441 } |> Some
      | 50000994 -> { StargateData.id= 50000994; name= "Stargate (Jeras)"; solarSystemId= 30002755; position= {x = 8.364081439e+12;  y = -2.13241983e+12;  z = 3.424106496e+11;}; typeId= 29627; destinationSolarSystemId= 30002748; destinationStargateId= 50002041 } |> Some
      | 50001091 -> { StargateData.id= 50001091; name= "Stargate (CYB-BZ)"; solarSystemId= 30002311; position= {x = -7.121460019e+11;  y = 1.411577856e+11;  z = -3.655211827e+11;}; typeId= 3875; destinationSolarSystemId= 30002312; destinationStargateId= 50001780 } |> Some
      | 50001188 -> { StargateData.id= 50001188; name= "Stargate (Z8-81T)"; solarSystemId= 30002119; position= {x = -3.365302886e+12;  y = -4.814082048e+10;  z = 7.257871565e+11;}; typeId= 29633; destinationSolarSystemId= 30002117; destinationStargateId= 50000065 } |> Some
      | 50001285 -> { StargateData.id= 50001285; name= "Stargate (X9V-15)"; solarSystemId= 30000568; position= {x = -3.266609357e+12;  y = 1.09627945e+12;  z = -3.528476221e+12;}; typeId= 29635; destinationSolarSystemId= 30000664; destinationStargateId= 50001719 } |> Some
      | 50001382 -> { StargateData.id= 50001382; name= "Stargate (LZ-6SU)"; solarSystemId= 30000211; position= {x = 1.539026166e+12;  y = -1.303214899e+11;  z = 2.381861315e+12;}; typeId= 16; destinationSolarSystemId= 30000208; destinationStargateId= 50000188 } |> Some
      | 50001479 -> { StargateData.id= 50001479; name= "Stargate (LY-WRW)"; solarSystemId= 30001081; position= {x = 3.265969766e+11;  y = -4.118065152e+10;  z = -5.779627622e+11;}; typeId= 3875; destinationSolarSystemId= 30001078; destinationStargateId= 50001280 } |> Some
      | 50001576 -> { StargateData.id= 50001576; name= "Stargate (Ilahed)"; solarSystemId= 30000014; position= {x = -4.738148229e+12;  y = 4.145132052e+12;  z = -3.261912392e+12;}; typeId= 17; destinationSolarSystemId= 30000090; destinationStargateId= 50001083 } |> Some
      | 50001770 -> { StargateData.id= 50001770; name= "Stargate (H-RXNZ)"; solarSystemId= 30002133; position= {x = -4.300488008e+12;  y = 5.422492508e+12;  z = -3.293271122e+12;}; typeId= 3877; destinationSolarSystemId= 30002120; destinationStargateId= 50001341 } |> Some
      | 50001867 -> { StargateData.id= 50001867; name= "Stargate (M-N7WD)"; solarSystemId= 30001031; position= {x = -1.020013732e+12;  y = 5.764263936e+10;  z = 2.113335583e+12;}; typeId= 29633; destinationSolarSystemId= 30001032; destinationStargateId= 50001927 } |> Some
      | 50002061 -> { StargateData.id= 50002061; name= "Stargate (XTJ-5Q)"; solarSystemId= 30002821; position= {x = -2.866873098e+12;  y = -2.742672998e+11;  z = 1.99723561e+12;}; typeId= 3875; destinationSolarSystemId= 30002822; destinationStargateId= 50002216 } |> Some
      | 50002158 -> { StargateData.id= 50002158; name= "Stargate (Caslemon)"; solarSystemId= 30004974; position= {x = -6.815127552e+11;  y = 5.701595136e+10;  z = 7.022890598e+11;}; typeId= 3875; destinationSolarSystemId= 30004973; destinationStargateId= 50001695 } |> Some
      | 50002255 -> { StargateData.id= 50002255; name= "Stargate (R-K4QY)"; solarSystemId= 30001194; position= {x = 1.35417385e+12;  y = 1.690262323e+11;  z = 1.040781926e+12;}; typeId= 29624; destinationSolarSystemId= 30001189; destinationStargateId= 50000620 } |> Some
      | 50002352 -> { StargateData.id= 50002352; name= "Stargate (YLS8-J)"; solarSystemId= 30000879; position= {x = -7.02009385e+11;  y = -1.141297152e+10;  z = -2.571325563e+12;}; typeId= 16; destinationSolarSystemId= 30000880; destinationStargateId= 50002609 } |> Some
      | 50002449 -> { StargateData.id= 50002449; name= "Stargate (Bashakru)"; solarSystemId= 30002198; position= {x = 2.446935245e+11;  y = 4.708061184e+10;  z = -1.750536315e+12;}; typeId= 29624; destinationSolarSystemId= 30002199; destinationStargateId= 50002841 } |> Some
      | 50002546 -> { StargateData.id= 50002546; name= "Stargate (VW-PXL)"; solarSystemId= 30001056; position= {x = -7.010533786e+11;  y = 1.315615949e+11;  z = 3.57537792e+10;}; typeId= 3875; destinationSolarSystemId= 30001054; destinationStargateId= 50001463 } |> Some
      | 50002643 -> { StargateData.id= 50002643; name= "Stargate (JWJ-P1)"; solarSystemId= 30001013; position= {x = -6.446659584e+11;  y = 6.892449792e+10;  z = 4.651265434e+12;}; typeId= 29633; destinationSolarSystemId= 30001007; destinationStargateId= 50000384 } |> Some
      | 50002740 -> { StargateData.id= 50002740; name= "Stargate (7Q-8Z2)"; solarSystemId= 30000944; position= {x = -1.703582515e+11;  y = 1.054691328e+10;  z = -5.469313843e+11;}; typeId= 29633; destinationSolarSystemId= 30000943; destinationStargateId= 50002561 } |> Some
      | 50002837 -> { StargateData.id= 50002837; name= "Stargate (8-2JZA)"; solarSystemId= 30001072; position= {x = -4.756818739e+11;  y = 8.396255232e+10;  z = 2.707908157e+12;}; typeId= 3875; destinationSolarSystemId= 30001071; destinationStargateId= 50002511 } |> Some
      | 50002934 -> { StargateData.id= 50002934; name= "Stargate (52CW-6)"; solarSystemId= 30000452; position= {x = 1.243557028e+12;  y = -2.203981824e+11;  z = -9.183883469e+12;}; typeId= 29633; destinationSolarSystemId= 30000453; destinationStargateId= 50002976 } |> Some
      | 50003031 -> { StargateData.id= 50003031; name= "Stargate (Daras)"; solarSystemId= 30001419; position= {x = -1.041908244e+12;  y = 2.097874944e+11;  z = 3.713675059e+12;}; typeId= 16; destinationSolarSystemId= 30001420; destinationStargateId= 50003266 } |> Some
      | 50003128 -> { StargateData.id= 50003128; name= "Stargate (Soosat)"; solarSystemId= 30002982; position= {x = -3.034323763e+11;  y = 5.630865408e+10;  z = 1.756639642e+11;}; typeId= 29624; destinationSolarSystemId= 30002983; destinationStargateId= 50003178 } |> Some
      | 50003225 -> { StargateData.id= 50003225; name= "Stargate (Baviasi)"; solarSystemId= 30001671; position= {x = 6.60366336e+11;  y = 6.52720128e+10;  z = 4.195937894e+11;}; typeId= 29624; destinationSolarSystemId= 30001670; destinationStargateId= 50002989 } |> Some
      | 50003322 -> { StargateData.id= 50003322; name= "Stargate (2E-ZR5)"; solarSystemId= 30002422; position= {x = 6.036026573e+11;  y = -1.054360781e+11;  z = 2.414576148e+12;}; typeId= 16; destinationSolarSystemId= 30002424; destinationStargateId= 50003784 } |> Some
      | 50003419 -> { StargateData.id= 50003419; name= "Stargate (3ET-G8)"; solarSystemId= 30001550; position= {x = -1.129410601e+12;  y = 6.476156928e+10;  z = 7.877783593e+12;}; typeId= 3875; destinationSolarSystemId= 30001553; destinationStargateId= 50006606 } |> Some
      | 50003516 -> { StargateData.id= 50003516; name= "Stargate (EC-P8R)"; solarSystemId= 30001429; position= {x = -3.727968952e+12;  y = -5.682862449e+12;  z = -1.566221476e+12;}; typeId= 3873; destinationSolarSystemId= 30001984; destinationStargateId= 50003951 } |> Some
      | 50003613 -> { StargateData.id= 50003613; name= "Stargate (Elanoda)"; solarSystemId= 30001432; position= {x = -5.745758331e+12;  y = 3.126147072e+11;  z = -3.419139686e+11;}; typeId= 16; destinationSolarSystemId= 30001434; destinationStargateId= 50003921 } |> Some
      | 50003710 -> { StargateData.id= 50003710; name= "Stargate (Emrayur)"; solarSystemId= 30001673; position= {x = 1.686214656e+11;  y = 3.12649728e+10;  z = 7.08294697e+11;}; typeId= 29624; destinationSolarSystemId= 30001672; destinationStargateId= 50003467 } |> Some
      | 50003807 -> { StargateData.id= 50003807; name= "Stargate (Merolles)"; solarSystemId= 30005301; position= {x = 6.66114048e+10;  y = -1415700480.0;  z = 2.561776435e+11;}; typeId= 3875; destinationSolarSystemId= 30005303; destinationStargateId= 50004177 } |> Some
      | 50003904 -> { StargateData.id= 50003904; name= "Stargate (1C-953)"; solarSystemId= 30000962; position= {x = -1.244731515e+12;  y = -7.912894464e+10;  z = 9.137825341e+12;}; typeId= 29633; destinationSolarSystemId= 30000963; destinationStargateId= 50004378 } |> Some
      | 50004001 -> { StargateData.id= 50004001; name= "Stargate (FMBR-8)"; solarSystemId= 30000295; position= {x = -5.030356132e+12;  y = -5.888974234e+12;  z = -2.762619003e+12;}; typeId= 29627; destinationSolarSystemId= 30000227; destinationStargateId= 50002919 } |> Some
      | 50004098 -> { StargateData.id= 50004098; name= "Stargate (Ikami)"; solarSystemId= 30000152; position= {x = 2.129100349e+12;  y = -1.525581005e+11;  z = -2.482421883e+12;}; typeId= 29627; destinationSolarSystemId= 30000159; destinationStargateId= 50004558 } |> Some
      | 50004195 -> { StargateData.id= 50004195; name= "Stargate (GIH-ZG)"; solarSystemId= 30000889; position= {x = -6.676386202e+11;  y = 1.205301658e+11;  z = 4.905469133e+11;}; typeId= 16; destinationSolarSystemId= 30000887; destinationStargateId= 50003665 } |> Some
      | 50004292 -> { StargateData.id= 50004292; name= "Stargate (4RX-EE)"; solarSystemId= 30001288; position= {x = 2.173312082e+12;  y = 1.993357025e+12;  z = 6.466371133e+12;}; typeId= 29627; destinationSolarSystemId= 30001300; destinationStargateId= 50004960 } |> Some
      | 50004389 -> { StargateData.id= 50004389; name= "Stargate (L-TLFU)"; solarSystemId= 30002843; position= {x = 2.237201818e+12;  y = 1.248398131e+11;  z = -4.768794255e+12;}; typeId= 3875; destinationSolarSystemId= 30002842; destinationStargateId= 50003120 } |> Some
      | 50004486 -> { StargateData.id= 50004486; name= "Stargate (Kasrasi)"; solarSystemId= 30000026; position= {x = 1.749647155e+12;  y = 1.329208934e+11;  z = 2.296315453e+12;}; typeId= 29624; destinationSolarSystemId= 30000030; destinationStargateId= 50005546 } |> Some
      | 50004583 -> { StargateData.id= 50004583; name= "Stargate (Saikamon)"; solarSystemId= 30003075; position= {x = 9.056643072e+11;  y = 9.509523456e+10;  z = 2.001752187e+12;}; typeId= 29624; destinationSolarSystemId= 30003079; destinationStargateId= 50007518 } |> Some
      | 50004680 -> { StargateData.id= 50004680; name= "Stargate (G-AOTH)"; solarSystemId= 30001226; position= {x = 1.539279053e+12;  y = -2.332474982e+11;  z = -6.342943949e+11;}; typeId= 29624; destinationSolarSystemId= 30001227; destinationStargateId= 50005002 } |> Some
      | 50004777 -> { StargateData.id= 50004777; name= "Stargate (TU-O0T)"; solarSystemId= 30003732; position= {x = -5.179564646e+12;  y = 5.06652672e+10;  z = -2.76545237e+12;}; typeId= 29624; destinationSolarSystemId= 30003733; destinationStargateId= 50004839 } |> Some
      | 50004874 -> { StargateData.id= 50004874; name= "Stargate (7LHB-Z)"; solarSystemId= 30001216; position= {x = -3.260353536e+12;  y = 3.02663639e+11;  z = -3.207104717e+12;}; typeId= 29624; destinationSolarSystemId= 30001218; destinationStargateId= 50005137 } |> Some
      | 50004971 -> { StargateData.id= 50004971; name= "Stargate (IR-DYY)"; solarSystemId= 30000279; position= {x = -2.254970757e+12;  y = 4.255141478e+11;  z = 3.077693399e+12;}; typeId= 16; destinationSolarSystemId= 30000277; destinationStargateId= 50003852 } |> Some
      | 50005165 -> { StargateData.id= 50005165; name= "Stargate (O-EUHA)"; solarSystemId= 30002357; position= {x = 8.012701286e+11;  y = -6.094737408e+10;  z = -4.961683169e+12;}; typeId= 3875; destinationSolarSystemId= 30002358; destinationStargateId= 50005180 } |> Some
      | 50005262 -> { StargateData.id= 50005262; name= "Stargate (Faswiba)"; solarSystemId= 30003538; position= {x = -2.121091891e+11;  y = -3.631632384e+10;  z = 7.423586304e+10;}; typeId= 29624; destinationSolarSystemId= 30003541; destinationStargateId= 50006001 } |> Some
      | 50005456 -> { StargateData.id= 50005456; name= "Stargate (Maturat)"; solarSystemId= 30003428; position= {x = -3.08268159e+12;  y = -6.821915443e+11;  z = 2.51705045e+12;}; typeId= 3877; destinationSolarSystemId= 30003396; destinationStargateId= 50004000 } |> Some
      | 50005553 -> { StargateData.id= 50005553; name= "Stargate (Pelille)"; solarSystemId= 30003792; position= {x = -8.315696333e+11;  y = 2.005594153e+12;  z = 1.471305277e+12;}; typeId= 3874; destinationSolarSystemId= 30003806; destinationStargateId= 50005941 } |> Some
      | 50005650 -> { StargateData.id= 50005650; name= "Stargate (Thashkarai)"; solarSystemId= 30001700; position= {x = 1.502363197e+12;  y = -9.629128704e+11;  z = 1.153142784e+10;}; typeId= 17; destinationSolarSystemId= 30001677; destinationStargateId= 50004449 } |> Some
      | 50005747 -> { StargateData.id= 50005747; name= "Stargate (AA-YRK)"; solarSystemId= 30001284; position= {x = 2.083177636e+12;  y = -4.542271488e+10;  z = 5.580864307e+11;}; typeId= 16; destinationSolarSystemId= 30001285; destinationStargateId= 50006125 } |> Some
      | 50005844 -> { StargateData.id= 50005844; name= "Stargate (6-WMKE)"; solarSystemId= 30002346; position= {x = -1.915590697e+12;  y = -3.443886612e+12;  z = 3.237335409e+12;}; typeId= 29632; destinationSolarSystemId= 30001111; destinationStargateId= 50006138 } |> Some
      | 50005941 -> { StargateData.id= 50005941; name= "Stargate (Ostingele)"; solarSystemId= 30003806; position= {x = 2.166327583e+12;  y = -5.224786698e+12;  z = -3.832907244e+12;}; typeId= 3874; destinationSolarSystemId= 30003792; destinationStargateId= 50005553 } |> Some
      | 50006038 -> { StargateData.id= 50006038; name= "Stargate (Tash-Murkon Prime)"; solarSystemId= 30001722; position= {x = 8.727697367e+12;  y = 2.052086784e+12;  z = 5.224944722e+12;}; typeId= 17; destinationSolarSystemId= 30001671; destinationStargateId= 50003230 } |> Some
      | 50006135 -> { StargateData.id= 50006135; name= "Stargate (0GN-VO)"; solarSystemId= 30001857; position= {x = 8.937737011e+11;  y = -3.318373171e+11;  z = 1.851730207e+12;}; typeId= 17; destinationSolarSystemId= 30001856; destinationStargateId= 50005909 } |> Some
      | 50006232 -> { StargateData.id= 50006232; name= "Stargate (Dom-Aphis)"; solarSystemId= 30005227; position= {x = -8.575911936e+11;  y = 5078016000.0;  z = 1.951560622e+12;}; typeId= 29624; destinationSolarSystemId= 30005226; destinationStargateId= 50006000 } |> Some
      | 50006329 -> { StargateData.id= 50006329; name= "Stargate (P-33KR)"; solarSystemId= 30003678; position= {x = -1.58665642e+12;  y = -2.975771443e+11;  z = -1.894858383e+12;}; typeId= 3875; destinationSolarSystemId= 30003680; destinationStargateId= 50006960 } |> Some
      | 50006426 -> { StargateData.id= 50006426; name= "Stargate (REB-KR)"; solarSystemId= 30002144; position= {x = -2.659547259e+12;  y = -4.481594573e+11;  z = -1.823572746e+12;}; typeId= 29633; destinationSolarSystemId= 30002140; destinationStargateId= 50003447 } |> Some
      | 50006523 -> { StargateData.id= 50006523; name= "Stargate (6-CZ49)"; solarSystemId= 30003281; position= {x = 6.465027809e+12;  y = 8.72667095e+11;  z = -4.880132383e+12;}; typeId= 3875; destinationSolarSystemId= 30003280; destinationStargateId= 50006517 } |> Some
      | 50006620 -> { StargateData.id= 50006620; name= "Stargate (ORB4-J)"; solarSystemId= 30003198; position= {x = 1.386287555e+12;  y = 2.374740787e+11;  z = 1.93023959e+11;}; typeId= 3875; destinationSolarSystemId= 30003201; destinationStargateId= 50007196 } |> Some
      | 50006717 -> { StargateData.id= 50006717; name= "Stargate (GN7-XY)"; solarSystemId= 30003737; position= {x = 1.311265628e+12;  y = 1.724270592e+11;  z = -2.764761293e+12;}; typeId= 29624; destinationSolarSystemId= 30003736; destinationStargateId= 50006084 } |> Some
      | 50006814 -> { StargateData.id= 50006814; name= "Stargate (K-3PQW)"; solarSystemId= 30005122; position= {x = -5.413695037e+12;  y = -1.880158618e+11;  z = -1.084957532e+12;}; typeId= 3875; destinationSolarSystemId= 30005120; destinationStargateId= 50006503 } |> Some
      | 50006911 -> { StargateData.id= 50006911; name= "Stargate (Hirizan)"; solarSystemId= 30005247; position= {x = -1.417064571e+12;  y = -2.83425792e+11;  z = -2.528952852e+12;}; typeId= 29624; destinationSolarSystemId= 30005248; destinationStargateId= 50006939 } |> Some
      | 50007008 -> { StargateData.id= 50007008; name= "Stargate (Vylade)"; solarSystemId= 30002656; position= {x = 2.700748186e+12;  y = 3875020800.0;  z = -3.194433577e+12;}; typeId= 3875; destinationSolarSystemId= 30002655; destinationStargateId= 50000402 } |> Some
      | 50007105 -> { StargateData.id= 50007105; name= "Stargate (CFLF-P)"; solarSystemId= 30004410; position= {x = -1.218916393e+12;  y = 1.417029181e+12;  z = 1.279079178e+12;}; typeId= 3877; destinationSolarSystemId= 30004407; destinationStargateId= 50006869 } |> Some
      | 50007202 -> { StargateData.id= 50007202; name= "Stargate (BWF-ZZ)"; solarSystemId= 30002442; position= {x = -4.78810153e+11;  y = -3.758493696e+10;  z = 1.185512448e+12;}; typeId= 16; destinationSolarSystemId= 30002440; destinationStargateId= 50005903 } |> Some
      | 50007299 -> { StargateData.id= 50007299; name= "Stargate (Botane)"; solarSystemId= 30002658; position= {x = -1.713018593e+12;  y = 6.25207296e+10;  z = 2.052652032e+12;}; typeId= 3875; destinationSolarSystemId= 30002661; destinationStargateId= 50010397 } |> Some
      | 50007396 -> { StargateData.id= 50007396; name= "Stargate (Keberz)"; solarSystemId= 30003885; position= {x = 1.982762557e+12;  y = 1.207946035e+11;  z = -6.093679411e+11;}; typeId= 29624; destinationSolarSystemId= 30003883; destinationStargateId= 50007148 } |> Some
      | 50007493 -> { StargateData.id= 50007493; name= "Stargate (XW-6TC)"; solarSystemId= 30001329; position= {x = -3.154800353e+12;  y = -1.384735949e+11;  z = -1.074329887e+12;}; typeId= 16; destinationSolarSystemId= 30001325; destinationStargateId= 50005938 } |> Some
      | 50007590 -> { StargateData.id= 50007590; name= "Stargate (Choga)"; solarSystemId= 30005050; position= {x = -2.135820288e+11;  y = -1.336307712e+10;  z = 8.03897303e+11;}; typeId= 29624; destinationSolarSystemId= 30005051; destinationStargateId= 50007618 } |> Some
      | 50007687 -> { StargateData.id= 50007687; name= "Stargate (NTV0-1)"; solarSystemId= 30004319; position= {x = -1.333248614e+12;  y = -1.085591962e+11;  z = -3.246659297e+12;}; typeId= 16; destinationSolarSystemId= 30004318; destinationStargateId= 50007646 } |> Some
      | 50007784 -> { StargateData.id= 50007784; name= "Stargate (Zith)"; solarSystemId= 30001733; position= {x = 3.009578189e+11;  y = -4.352937984e+10;  z = 7.585322189e+11;}; typeId= 29624; destinationSolarSystemId= 30001732; destinationStargateId= 50007752 } |> Some
      | 50007881 -> { StargateData.id= 50007881; name= "Stargate (Sahdil)"; solarSystemId= 30002261; position= {x = 3.306832404e+12;  y = -3.729111859e+11;  z = 6.871175578e+11;}; typeId= 29624; destinationSolarSystemId= 30002259; destinationStargateId= 50006905 } |> Some
      | 50007978 -> { StargateData.id= 50007978; name= "Stargate (5-9L3H)"; solarSystemId= 30003210; position= {x = -1.379857613e+11;  y = 2.416447488e+10;  z = -4.725540864e+11;}; typeId= 3875; destinationSolarSystemId= 30003214; destinationStargateId= 50008448 } |> Some
      | 50008075 -> { StargateData.id= 50008075; name= "Stargate (Aakari)"; solarSystemId= 30001397; position= {x = -9.366204826e+11;  y = -3.545960448e+10;  z = -3.754356326e+11;}; typeId= 16; destinationSolarSystemId= 30001396; destinationStargateId= 50006648 } |> Some
      | 50008172 -> { StargateData.id= 50008172; name= "Stargate (Y5J-EU)"; solarSystemId= 30000312; position= {x = -9.519301018e+11;  y = -1.495871078e+11;  z = 4.280635392e+10;}; typeId= 16; destinationSolarSystemId= 30000308; destinationStargateId= 50006317 } |> Some
      | 50008269 -> { StargateData.id= 50008269; name= "Stargate (PNS7-J)"; solarSystemId= 30003611; position= {x = -3.566352384e+11;  y = 6.83022336e+10;  z = 7.264396493e+11;}; typeId= 16; destinationSolarSystemId= 30003613; destinationStargateId= 50008298 } |> Some
      | 50008366 -> { StargateData.id= 50008366; name= "Stargate (K-X5AX)"; solarSystemId= 30004420; position= {x = 6.813281894e+11;  y = 6.154039296e+10;  z = -1.535536374e+12;}; typeId= 29633; destinationSolarSystemId= 30004421; destinationStargateId= 50008383 } |> Some
      | 50008463 -> { StargateData.id= 50008463; name= "Stargate (MS-RXH)"; solarSystemId= 30005156; position= {x = -4.797837312e+10;  y = 1047552000.0;  z = 6.610219008e+10;}; typeId= 3875; destinationSolarSystemId= 30005155; destinationStargateId= 50008392 } |> Some
      | 50008560 -> { StargateData.id= 50008560; name= "Stargate (A-ZLHX)"; solarSystemId= 30003306; position= {x = -4.000681574e+11;  y = 6286417920.0;  z = 1.436234834e+12;}; typeId= 3875; destinationSolarSystemId= 30003305; destinationStargateId= 50008542 } |> Some
      | 50008657 -> { StargateData.id= 50008657; name= "Stargate (D2-HOS)"; solarSystemId= 30002037; position= {x = 8.901808128e+10;  y = 6132817920.0;  z = 3.079330652e+12;}; typeId= 16; destinationSolarSystemId= 30002036; destinationStargateId= 50008178 } |> Some
      | 50008754 -> { StargateData.id= 50008754; name= "Stargate (R8WV-7)"; solarSystemId= 30003223; position= {x = -3.683617628e+12;  y = 1.103333253e+12;  z = -5.028898775e+12;}; typeId= 3874; destinationSolarSystemId= 30003209; destinationStargateId= 50008695 } |> Some
      | 50008851 -> { StargateData.id= 50008851; name= "Stargate (Ebolfer)"; solarSystemId= 30002091; position= {x = -3.106732155e+12;  y = -3.684555571e+11;  z = 7.938000077e+11;}; typeId= 29633; destinationSolarSystemId= 30002094; destinationStargateId= 50012051 } |> Some
      | 50008948 -> { StargateData.id= 50008948; name= "Stargate (Hrondmund)"; solarSystemId= 30002577; position= {x = -6.579376128e+10;  y = -1.25650944e+10;  z = -1.896124416e+10;}; typeId= 29633; destinationSolarSystemId= 30002576; destinationStargateId= 50008857 } |> Some
      | 50009045 -> { StargateData.id= 50009045; name= "Stargate (GOP-GE)"; solarSystemId= 30003962; position= {x = -3.456585523e+12;  y = -2.47250903e+11;  z = 5.471403663e+12;}; typeId= 29624; destinationSolarSystemId= 30003963; destinationStargateId= 50009046 } |> Some
      | 50009142 -> { StargateData.id= 50009142; name= "Stargate (G06-8Y)"; solarSystemId= 30003630; position= {x = 2.437326029e+11;  y = -7.723439923e+12;  z = 3.536107315e+12;}; typeId= 29627; destinationSolarSystemId= 30003636; destinationStargateId= 50009611 } |> Some
      | 50009239 -> { StargateData.id= 50009239; name= "Stargate (Meunvon)"; solarSystemId= 30003567; position= {x = -2.342473728e+10;  y = 354754560.0;  z = -2.451542016e+10;}; typeId= 3875; destinationSolarSystemId= 30003568; destinationStargateId= 50009450 } |> Some
      | 50009336 -> { StargateData.id= 50009336; name= "Stargate (C1-HAB)"; solarSystemId= 30003777; position= {x = -1.737629983e+12;  y = -5.718528e+10;  z = -3.503050752e+10;}; typeId= 29624; destinationSolarSystemId= 30003780; destinationStargateId= 50010191 } |> Some
      | 50009433 -> { StargateData.id= 50009433; name= "Stargate (4A-XJ6)"; solarSystemId= 30001884; position= {x = 2.465747313e+12;  y = -3.842159002e+11;  z = -4.680443904e+11;}; typeId= 29624; destinationSolarSystemId= 30001882; destinationStargateId= 50008525 } |> Some
      | 50009530 -> { StargateData.id= 50009530; name= "Stargate (4F6-VZ)"; solarSystemId= 30005161; position= {x = -6.719980216e+12;  y = -9.195654758e+11;  z = -3.27935103e+12;}; typeId= 3875; destinationSolarSystemId= 30005159; destinationStargateId= 50008835 } |> Some
      | 50009627 -> { StargateData.id= 50009627; name= "Stargate (Vittenyn)"; solarSystemId= 30002734; position= {x = 2.158444954e+11;  y = -2.05867008e+10;  z = 1.008388915e+11;}; typeId= 3875; destinationSolarSystemId= 30002731; destinationStargateId= 50007937 } |> Some
      | 50009724 -> { StargateData.id= 50009724; name= "Stargate (LXWN-W)"; solarSystemId= 30004365; position= {x = 9.943817011e+11;  y = -7.269224448e+10;  z = 6.214409011e+11;}; typeId= 16; destinationSolarSystemId= 30004364; destinationStargateId= 50009478 } |> Some
      | 50009821 -> { StargateData.id= 50009821; name= "Stargate (0TKF-6)"; solarSystemId= 30003960; position= {x = 2.859915878e+12;  y = 4.795039334e+11;  z = 4.994140692e+12;}; typeId= 29624; destinationSolarSystemId= 30003957; destinationStargateId= 50009183 } |> Some
      | 50009918 -> { StargateData.id= 50009918; name= "Stargate (3D-CQU)"; solarSystemId= 30003781; position= {x = 1.179396096e+11;  y = -4708638720.0;  z = 8.329638298e+11;}; typeId= 29624; destinationSolarSystemId= 30003786; destinationStargateId= 50013163 } |> Some
      | 50010015 -> { StargateData.id= 50010015; name= "Stargate (Z-XX2J)"; solarSystemId= 30003987; position= {x = -2.122626048e+12;  y = 2.015601869e+11;  z = 1.096709038e+12;}; typeId= 29624; destinationSolarSystemId= 30003989; destinationStargateId= 50011223 } |> Some
      | 50010112 -> { StargateData.id= 50010112; name= "Stargate (XDTW-F)"; solarSystemId= 30001777; position= {x = -4.552103117e+11;  y = -8.965189632e+10;  z = 2.812452495e+12;}; typeId= 3875; destinationSolarSystemId= 30001778; destinationStargateId= 50010206 } |> Some
      | 50010209 -> { StargateData.id= 50010209; name= "Stargate (GK3-RX)"; solarSystemId= 30003231; position= {x = 7.164345139e+11;  y = 7315415040.0;  z = 3.056103014e+11;}; typeId= 3875; destinationSolarSystemId= 30003232; destinationStargateId= 50010644 } |> Some
      | 50010306 -> { StargateData.id= 50010306; name= "Stargate (Wysalan)"; solarSystemId= 30005019; position= {x = -1.714984919e+12;  y = -7.131697152e+10;  z = 1.513352356e+12;}; typeId= 3875; destinationSolarSystemId= 30005016; destinationStargateId= 50008039 } |> Some
      | 50010403 -> { StargateData.id= 50010403; name= "Stargate (RKM-GE)"; solarSystemId= 30004016; position= {x = 1.033354322e+12;  y = -1.62174935e+11;  z = -3.497279078e+11;}; typeId= 29624; destinationSolarSystemId= 30004015; destinationStargateId= 50010355 } |> Some
      | 50010500 -> { StargateData.id= 50010500; name= "Stargate (Hiremir)"; solarSystemId= 30004139; position= {x = 2.390337577e+12;  y = 2.334517248e+11;  z = 3.394553856e+11;}; typeId= 29624; destinationSolarSystemId= 30004141; destinationStargateId= 50013016 } |> Some
      | 50010597 -> { StargateData.id= 50010597; name= "Stargate (B8O-KJ)"; solarSystemId= 30004384; position= {x = 2.385777992e+12;  y = -9.536311296e+10;  z = -1.356914074e+12;}; typeId= 29627; destinationSolarSystemId= 30004346; destinationStargateId= 50008855 } |> Some
      | 50010694 -> { StargateData.id= 50010694; name= "Stargate (Odebeinn)"; solarSystemId= 30003469; position= {x = 3.247200461e+12;  y = -5.614720205e+11;  z = -1.506963825e+12;}; typeId= 29633; destinationSolarSystemId= 30003470; destinationStargateId= 50010705 } |> Some
      | 50010791 -> { StargateData.id= 50010791; name= "Stargate (Gens)"; solarSystemId= 30004237; position= {x = -1.074547507e+11;  y = -9279283200.0;  z = -4.33916928e+11;}; typeId= 29624; destinationSolarSystemId= 30004238; destinationStargateId= 50010926 } |> Some
      | 50010888 -> { StargateData.id= 50010888; name= "Stargate (QM-O7J)"; solarSystemId= 30001923; position= {x = 2.839187497e+12;  y = -2.314306806e+12;  z = -1.661025853e+12;}; typeId= 17; destinationSolarSystemId= 30001903; destinationStargateId= 50010762 } |> Some
      | 50010985 -> { StargateData.id= 50010985; name= "Stargate (ZA9-PY)"; solarSystemId= 30004739; position= {x = 3.819074888e+12;  y = -4.76616745e+11;  z = -1.764574618e+12;}; typeId= 29624; destinationSolarSystemId= 30004741; destinationStargateId= 50011363 } |> Some
      | 50011082 -> { StargateData.id= 50011082; name= "Stargate (Alamel)"; solarSystemId= 30003852; position= {x = 4.449326899e+12;  y = -8.680853914e+11;  z = -3.42734377e+12;}; typeId= 3875; destinationSolarSystemId= 30003854; destinationStargateId= 50011636 } |> Some
      | 50011179 -> { StargateData.id= 50011179; name= "Stargate (Hilmar)"; solarSystemId= 30004135; position= {x = -2.578937856e+11;  y = -3.579629568e+10;  z = 4.719546778e+11;}; typeId= 29624; destinationSolarSystemId= 30004133; destinationStargateId= 50009394 } |> Some
      | 50011276 -> { StargateData.id= 50011276; name= "Stargate (5W3-DG)"; solarSystemId= 30002929; position= {x = 1.269021204e+12;  y = 9.419378688e+10;  z = 8.308874035e+11;}; typeId= 16; destinationSolarSystemId= 30002927; destinationStargateId= 50010809 } |> Some
      | 50011373 -> { StargateData.id= 50011373; name= "Stargate (Aeter)"; solarSystemId= 30003584; position= {x = -3.129762202e+11;  y = 1.385312256e+10;  z = -1.051052237e+12;}; typeId= 3875; destinationSolarSystemId= 30003585; destinationStargateId= 50011436 } |> Some
      | 50011470 -> { StargateData.id= 50011470; name= "Stargate (Rumida)"; solarSystemId= 30001727; position= {x = 2.07599063e+12;  y = 3.807012864e+11;  z = -2.909146276e+12;}; typeId= 29624; destinationSolarSystemId= 30001724; destinationStargateId= 50006580 } |> Some
      | 50011567 -> { StargateData.id= 50011567; name= "Stargate (C2-1B5)"; solarSystemId= 30004190; position= {x = -1.901138289e+12;  y = 1.317884314e+11;  z = 1.957724774e+12;}; typeId= 3875; destinationSolarSystemId= 30004191; destinationStargateId= 50011780 } |> Some
      | 50011664 -> { StargateData.id= 50011664; name= "Stargate (OE-4HB)"; solarSystemId= 30003656; position= {x = 1.125522678e+12;  y = 1.145975194e+11;  z = -1.204931666e+12;}; typeId= 16; destinationSolarSystemId= 30003657; destinationStargateId= 50011877 } |> Some
      | 50011761 -> { StargateData.id= 50011761; name= "Stargate (M-ZJWJ)"; solarSystemId= 30002179; position= {x = -2.864918938e+11;  y = -1.39585536e+10;  z = 1.49536002e+12;}; typeId= 29633; destinationSolarSystemId= 30002181; destinationStargateId= 50012809 } |> Some
      | 50011858 -> { StargateData.id= 50011858; name= "Stargate (Zatamaka)"; solarSystemId= 30005078; position= {x = -1.963156685e+11;  y = 6164766720.0;  z = 3.314296013e+11;}; typeId= 29624; destinationSolarSystemId= 30005079; destinationStargateId= 50011901 } |> Some
      | 50011955 -> { StargateData.id= 50011955; name= "Stargate (9IZ-HU)"; solarSystemId= 30005184; position= {x = -1.942257254e+11;  y = 2.185089024e+10;  z = 3.736703386e+11;}; typeId= 3875; destinationSolarSystemId= 30005180; destinationStargateId= 50011413 } |> Some
      | 50012052 -> { StargateData.id= 50012052; name= "Stargate (Sirekur)"; solarSystemId= 30002094; position= {x = -2.97807999e+12;  y = 5.830684262e+11;  z = -1.573219246e+12;}; typeId= 29633; destinationSolarSystemId= 30002092; destinationStargateId= 50010812 } |> Some
      | 50012149 -> { StargateData.id= 50012149; name= "Stargate (JSI-LL)"; solarSystemId= 30003667; position= {x = 7.749350154e+12;  y = 4.250543309e+11;  z = -3.278250025e+12;}; typeId= 16; destinationSolarSystemId= 30003664; destinationStargateId= 50011377 } |> Some
      | 50012246 -> { StargateData.id= 50012246; name= "Stargate (OE-9UF)"; solarSystemId= 30002009; position= {x = 5.111693722e+11;  y = -1.269018624e+10;  z = 6.325927526e+11;}; typeId= 16; destinationSolarSystemId= 30002008; destinationStargateId= 50009972 } |> Some
      | 50012343 -> { StargateData.id= 50012343; name= "Stargate (Andole)"; solarSystemId= 30005027; position= {x = 4.435327795e+11;  y = -3116605440.0;  z = 7.521264845e+11;}; typeId= 3875; destinationSolarSystemId= 30005028; destinationStargateId= 50013045 } |> Some
      | 50012440 -> { StargateData.id= 50012440; name= "Stargate (MZ1E-P)"; solarSystemId= 30002938; position= {x = -8.302830797e+11;  y = 1.045889434e+11;  z = 6.160275456e+11;}; typeId= 16; destinationSolarSystemId= 30002940; destinationStargateId= 50012462 } |> Some
      | 50012537 -> { StargateData.id= 50012537; name= "Stargate (GHZ-SJ)"; solarSystemId= 30004477; position= {x = 2.645567447e+12;  y = -3.416690688e+10;  z = 5.77187967e+12;}; typeId= 29633; destinationSolarSystemId= 30004474; destinationStargateId= 50012337 } |> Some
      | 50012634 -> { StargateData.id= 50012634; name= "Stargate (0-NTIS)"; solarSystemId= 30004932; position= {x = -2.083653181e+12;  y = -3.614636851e+11;  z = -3.935982182e+12;}; typeId= 29624; destinationSolarSystemId= 30004930; destinationStargateId= 50012625 } |> Some
      | 50012731 -> { StargateData.id= 50012731; name= "Stargate (D2EZ-X)"; solarSystemId= 30004903; position= {x = -7.076737229e+12;  y = 2.269899571e+11;  z = -2.307329188e+12;}; typeId= 29633; destinationSolarSystemId= 30004902; destinationStargateId= 50012573 } |> Some
      | 50012828 -> { StargateData.id= 50012828; name= "Stargate (XCBK-X)"; solarSystemId= 30002944; position= {x = -8.258850816e+10;  y = 9170903040.0;  z = 2.765683507e+11;}; typeId= 16; destinationSolarSystemId= 30002946; destinationStargateId= 50012942 } |> Some
      | 50012925 -> { StargateData.id= 50012925; name= "Stargate (4HS-CR)"; solarSystemId= 30004642; position= {x = 3.735118234e+11;  y = 5346140160.0;  z = -6.95937282e+12;}; typeId= 3874; destinationSolarSystemId= 30004661; destinationStargateId= 50013074 } |> Some
      | 50013022 -> { StargateData.id= 50013022; name= "Stargate (Ranni)"; solarSystemId= 30005086; position= {x = 2919997440.0;  y = 355491840.0;  z = -4.143910502e+11;}; typeId= 29624; destinationSolarSystemId= 30005085; destinationStargateId= 50012968 } |> Some
      | 50013119 -> { StargateData.id= 50013119; name= "Stargate (00GD-D)"; solarSystemId= 30004600; position= {x = 1.828384727e+12;  y = -6.676918272e+10;  z = 9.000757248e+11;}; typeId= 3875; destinationSolarSystemId= 30004596; destinationStargateId= 50011767 } |> Some
      | 50013216 -> { StargateData.id= 50013216; name= "Stargate (Brapelille)"; solarSystemId= 30002735; position= {x = 8.072177664e+11;  y = 8.471431987e+11;  z = -1.19863038e+12;}; typeId= 3874; destinationSolarSystemId= 30002699; destinationStargateId= 50001764 } |> Some
      | 50013313 -> { StargateData.id= 50013313; name= "Stargate (0M-103)"; solarSystemId= 30003649; position= {x = 4.780600934e+11;  y = -9.070866432e+10;  z = -6.589505126e+11;}; typeId= 16; destinationSolarSystemId= 30003647; destinationStargateId= 50011938 } |> Some
      | 50013410 -> { StargateData.id= 50013410; name= "Stargate (OKEO-X)"; solarSystemId= 30004923; position= {x = -7.441246986e+12;  y = -5.977493914e+11;  z = -8.437213962e+12;}; typeId= 29633; destinationSolarSystemId= 30004924; destinationStargateId= 50013434 } |> Some
      | 50013507 -> { StargateData.id= 50013507; name= "Stargate (Ellmay)"; solarSystemId= 30005314; position= {x = 2.618377421e+11;  y = 4.6629888e+10;  z = 3.638330573e+11;}; typeId= 3875; destinationSolarSystemId= 30005313; destinationStargateId= 50011112 } |> Some
      | 50013604 -> { StargateData.id= 50013604; name= "Stargate (Keberz)"; solarSystemId= 30001161; position= {x = -1.466887987e+12;  y = 3.450088243e+11;  z = 3.737076941e+11;}; typeId= 29625; destinationSolarSystemId= 30003883; destinationStargateId= 50013603 } |> Some
      | 50013701 -> { StargateData.id= 50013701; name= "Stargate (Stegette)"; solarSystemId= 30002651; position= {x = 1.542131098e+12;  y = 9.454301184e+10;  z = 2.087142728e+12;}; typeId= 3874; destinationSolarSystemId= 30002696; destinationStargateId= 50013702 } |> Some
      | 50013798 -> { StargateData.id= 50013798; name= "Stargate (JI-LGM)"; solarSystemId= 30004842; position= {x = -5.67904297e+11;  y = 1.48450603e+12;  z = -8.626661499e+12;}; typeId= 12292; destinationSolarSystemId= 30004435; destinationStargateId= 50013797 } |> Some
      | 50013992 -> { StargateData.id= 50013992; name= "Stargate (04-EHC)"; solarSystemId= 30000830; position= {x = 1.043215196e+12;  y = 3.745277829e+12;  z = 1.177050685e+12;}; typeId= 3877; destinationSolarSystemId= 30000822; destinationStargateId= 50013991 } |> Some
      | 50014089 -> { StargateData.id= 50014089; name= "Stargate (Juunigaishi)"; solarSystemId= 30002768; position= {x = 2.836438671e+12;  y = 1.434982932e+12;  z = -5.176193434e+11;}; typeId= 29627; destinationSolarSystemId= 30002803; destinationStargateId= 50014090 } |> Some
      | 50014186 -> { StargateData.id= 50014186; name= "Stargate (Eystur)"; solarSystemId= 30012547; position= {x = 3.726361805e+11;  y = -1.450807296e+10;  z = 2.940202598e+11;}; typeId= 29633; destinationSolarSystemId= 30002543; destinationStargateId= 50014185 } |> Some
      | 50014283 -> { StargateData.id= 50014283; name= "Stargate (B-U299)"; solarSystemId= 30004200; position= {x = 1.259031798e+12;  y = 3.835747e+12;  z = -5.377073357e+12;}; typeId= 3874; destinationSolarSystemId= 30004194; destinationStargateId= 50014284 } |> Some
      | 50016320 -> { StargateData.id= 50016320; name= "Stargate (Tsuruma)"; solarSystemId= 30045323; position= {x = -1.257056625e+12;  y = -1.820676096e+10;  z = 3.316977377e+12;}; typeId= 16; destinationSolarSystemId= 30045327; destinationStargateId= 50016319 } |> Some
      | _ -> None