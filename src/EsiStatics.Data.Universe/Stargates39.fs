﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stargates39=
    let getStargate id = 
      match id with 
      | 50000047 -> { StargateData.id= 50000047; name= "Stargate (B-VFDD)"; solarSystemId= 30001075; position= {x = -2.224705536e+10;  y = 3186155520.0;  z = -7.31191296e+10;}; typeId= 3875; destinationSolarSystemId= 30001076; destinationStargateId= 50000314 } |> Some
      | 50000144 -> { StargateData.id= 50000144; name= "Stargate (Abenync)"; solarSystemId= 30002706; position= {x = 2.374000435e+12;  y = -2.801436303e+12;  z = -3.240793006e+12;}; typeId= 3874; destinationSolarSystemId= 30002713; destinationStargateId= 50001959 } |> Some
      | 50000241 -> { StargateData.id= 50000241; name= "Stargate (Nomaa)"; solarSystemId= 30000126; position= {x = -8.429033472e+11;  y = 1.54073088e+10;  z = 3.097380741e+12;}; typeId= 16; destinationSolarSystemId= 30000131; destinationStargateId= 50002451 } |> Some
      | 50000338 -> { StargateData.id= 50000338; name= "Stargate (PXE-RG)"; solarSystemId= 30002289; position= {x = 7.492781261e+11;  y = 9.11652864e+10;  z = 2.648136499e+11;}; typeId= 3875; destinationSolarSystemId= 30002290; destinationStargateId= 50000569 } |> Some
      | 50000435 -> { StargateData.id= 50000435; name= "Stargate (YPW-M4)"; solarSystemId= 30000772; position= {x = -1.814491177e+12;  y = 4.280149402e+12;  z = 2.126057103e+12;}; typeId= 3877; destinationSolarSystemId= 30000784; destinationStargateId= 50000718 } |> Some
      | 50000532 -> { StargateData.id= 50000532; name= "Stargate (BY-7PY)"; solarSystemId= 30002302; position= {x = -1.20817963e+12;  y = -3.195604992e+10;  z = 6.589475635e+11;}; typeId= 3875; destinationSolarSystemId= 30002305; destinationStargateId= 50002382 } |> Some
      | 50000629 -> { StargateData.id= 50000629; name= "Stargate (Jaschercis)"; solarSystemId= 30002662; position= {x = -3.466670531e+12;  y = -2.639099904e+11;  z = -8.221159834e+11;}; typeId= 29632; destinationSolarSystemId= 30003029; destinationStargateId= 50001137 } |> Some
      | 50000823 -> { StargateData.id= 50000823; name= "Stargate (QCGG-Q)"; solarSystemId= 30001077; position= {x = 4.07734272e+10;  y = 1130618880.0;  z = 7.214395392e+10;}; typeId= 3875; destinationSolarSystemId= 30001080; destinationStargateId= 50001400 } |> Some
      | 50000920 -> { StargateData.id= 50000920; name= "Stargate (Kamela)"; solarSystemId= 30003064; position= {x = 2.023783834e+12;  y = 1.041458381e+11;  z = 1.805696655e+12;}; typeId= 29624; destinationSolarSystemId= 30003069; destinationStargateId= 50001996 } |> Some
      | 50001017 -> { StargateData.id= 50001017; name= "Stargate (G-0Q86)"; solarSystemId= 30001039; position= {x = 1.042057421e+12;  y = 1420861440.0;  z = 4.268689859e+12;}; typeId= 29633; destinationSolarSystemId= 30001041; destinationStargateId= 50002096 } |> Some
      | 50001114 -> { StargateData.id= 50001114; name= "Stargate (AU2V-J)"; solarSystemId= 30002835; position= {x = -2.881180877e+11;  y = -6645964800.0;  z = 2.180402258e+12;}; typeId= 3875; destinationSolarSystemId= 30002834; destinationStargateId= 50000794 } |> Some
      | 50001211 -> { StargateData.id= 50001211; name= "Stargate (Erila)"; solarSystemId= 30002738; position= {x = 1.781147443e+12;  y = -3.423123456e+11;  z = 2.828075459e+12;}; typeId= 16; destinationSolarSystemId= 30002742; destinationStargateId= 50005655 } |> Some
      | 50001308 -> { StargateData.id= 50001308; name= "Stargate (Antiainen)"; solarSystemId= 30001359; position= {x = 3.036573696e+10;  y = -5257420800.0;  z = 7.6816896e+11;}; typeId= 16; destinationSolarSystemId= 30001357; destinationStargateId= 50000309 } |> Some
      | 50001405 -> { StargateData.id= 50001405; name= "Stargate (Du Annes)"; solarSystemId= 30004970; position= {x = 7.71007488e+11;  y = 1.699283067e+12;  z = 6.341449728e+11;}; typeId= 29632; destinationSolarSystemId= 30002633; destinationStargateId= 50003181 } |> Some
      | 50001502 -> { StargateData.id= 50001502; name= "Stargate (MLQ-O9)"; solarSystemId= 30000542; position= {x = -1.363412214e+12;  y = -1.970426266e+11;  z = -2.4678144e+12;}; typeId= 29633; destinationSolarSystemId= 30000539; destinationStargateId= 50000422 } |> Some
      | 50001599 -> { StargateData.id= 50001599; name= "Stargate (UT-UZB)"; solarSystemId= 30000924; position= {x = 3.469017784e+12;  y = 5.358471168e+11;  z = -3.836774031e+12;}; typeId= 29633; destinationSolarSystemId= 30000921; destinationStargateId= 50001314 } |> Some
      | 50001696 -> { StargateData.id= 50001696; name= "Stargate (Mesybier)"; solarSystemId= 30004973; position= {x = -4.936481587e+11;  y = -4.569673728e+10;  z = 2.799116698e+11;}; typeId= 3875; destinationSolarSystemId= 30004975; destinationStargateId= 50002779 } |> Some
      | 50001890 -> { StargateData.id= 50001890; name= "Stargate (5-2PQU)"; solarSystemId= 30000622; position= {x = -3.196847923e+12;  y = 2.671992422e+11;  z = -1.231730319e+12;}; typeId= 29635; destinationSolarSystemId= 30000762; destinationStargateId= 50001738 } |> Some
      | 50001987 -> { StargateData.id= 50001987; name= "Stargate (Mifrata)"; solarSystemId= 30000048; position= {x = 7.177807872e+11;  y = 1.061425152e+10;  z = -3.603982049e+12;}; typeId= 29624; destinationSolarSystemId= 30000046; destinationStargateId= 50001049 } |> Some
      | 50002084 -> { StargateData.id= 50002084; name= "Stargate (Tanoo)"; solarSystemId= 30000007; position= {x = -4.429246464e+10;  y = -5346631680.0;  z = 5.613651149e+11;}; typeId= 29624; destinationSolarSystemId= 30000001; destinationStargateId= 50000058 } |> Some
      | 50002181 -> { StargateData.id= 50002181; name= "Stargate (F5M-CC)"; solarSystemId= 30000599; position= {x = 3.026017075e+11;  y = 3.306811392e+10;  z = -2.746449961e+12;}; typeId= 29633; destinationSolarSystemId= 30000600; destinationStargateId= 50002665 } |> Some
      | 50002375 -> { StargateData.id= 50002375; name= "Stargate (Vecamia)"; solarSystemId= 30005194; position= {x = 3.19819518e+12;  y = 6.36798935e+11;  z = 2.106457006e+12;}; typeId= 29624; destinationSolarSystemId= 30005195; destinationStargateId= 50002503 } |> Some
      | 50002472 -> { StargateData.id= 50002472; name= "Stargate (UNJ-GX)"; solarSystemId= 30000964; position= {x = -5.515770962e+12;  y = -4.256667648e+11;  z = 6.716967199e+12;}; typeId= 29633; destinationSolarSystemId= 30000965; destinationStargateId= 50003491 } |> Some
      | 50002569 -> { StargateData.id= 50002569; name= "Stargate (Arayar)"; solarSystemId= 30002976; position= {x = 1.380356506e+11;  y = 1.59922176e+10;  z = 9.452263465e+12;}; typeId= 29624; destinationSolarSystemId= 30002977; destinationStargateId= 50004542 } |> Some
      | 50002666 -> { StargateData.id= 50002666; name= "Stargate (H-HHTH)"; solarSystemId= 30000600; position= {x = 2.369968742e+12;  y = -3.913924239e+12;  z = 2.559588065e+12;}; typeId= 3877; destinationSolarSystemId= 30000547; destinationStargateId= 50002457 } |> Some
      | 50002763 -> { StargateData.id= 50002763; name= "Stargate (OSY-UD)"; solarSystemId= 30001002; position= {x = -6.10625495e+11;  y = 3.691450368e+10;  z = -1.455439503e+12;}; typeId= 29633; destinationSolarSystemId= 30001005; destinationStargateId= 50004146 } |> Some
      | 50002860 -> { StargateData.id= 50002860; name= "Stargate (1-GBBP)"; solarSystemId= 30000264; position= {x = 6.01496875e+12;  y = 2.458282598e+12;  z = 8.847609446e+11;}; typeId= 29627; destinationSolarSystemId= 30000301; destinationStargateId= 50004221 } |> Some
      | 50003054 -> { StargateData.id= 50003054; name= "Stargate (ZH-GKG)"; solarSystemId= 30000549; position= {x = 4.091680973e+12;  y = 8.263641907e+11;  z = 2.309703475e+12;}; typeId= 29633; destinationSolarSystemId= 30000551; destinationStargateId= 50003684 } |> Some
      | 50003151 -> { StargateData.id= 50003151; name= "Stargate (F2A-GX)"; solarSystemId= 30000805; position= {x = -2.464532767e+12;  y = -5.39006976e+10;  z = 5.862112051e+11;}; typeId= 29633; destinationSolarSystemId= 30000804; destinationStargateId= 50002623 } |> Some
      | 50003248 -> { StargateData.id= 50003248; name= "Stargate (Eystur)"; solarSystemId= 30003388; position= {x = -3.078241444e+12;  y = -2.078532526e+12;  z = -4.137257779e+11;}; typeId= 29635; destinationSolarSystemId= 30002543; destinationStargateId= 50004634 } |> Some
      | 50003345 -> { StargateData.id= 50003345; name= "Stargate (Soosat)"; solarSystemId= 30002984; position= {x = -1.551365284e+12;  y = 5.8149888e+10;  z = -1.514247905e+12;}; typeId= 29624; destinationSolarSystemId= 30002983; destinationStargateId= 50003179 } |> Some
      | 50003442 -> { StargateData.id= 50003442; name= "Stargate (Murethand)"; solarSystemId= 30005296; position= {x = 2.200865219e+12;  y = 5.697908736e+10;  z = 1.631073853e+12;}; typeId= 3875; destinationSolarSystemId= 30005295; destinationStargateId= 50003289 } |> Some
      | 50003539 -> { StargateData.id= 50003539; name= "Stargate (Old Man Star)"; solarSystemId= 30004993; position= {x = 2.723857613e+11;  y = -5.37532416e+10;  z = 8.612130816e+10;}; typeId= 3875; destinationSolarSystemId= 30005000; destinationStargateId= 50006126 } |> Some
      | 50003636 -> { StargateData.id= 50003636; name= "Stargate (DOA-YU)"; solarSystemId= 30001126; position= {x = -2.16284713e+12;  y = 9.15769344e+10;  z = 1.563450163e+11;}; typeId= 3875; destinationSolarSystemId= 30001130; destinationStargateId= 50007431 } |> Some
      | 50003733 -> { StargateData.id= 50003733; name= "Stargate (7JF-0Z)"; solarSystemId= 30000954; position= {x = 9.441291878e+11;  y = -4.85111808e+10;  z = -3.871841894e+11;}; typeId= 29633; destinationSolarSystemId= 30000955; destinationStargateId= 50003835 } |> Some
      | 50003830 -> { StargateData.id= 50003830; name= "Stargate (OJT-J3)"; solarSystemId= 30005093; position= {x = -9.897854976e+11;  y = -8.42336256e+10;  z = -1.09510914e+12;}; typeId= 3875; destinationSolarSystemId= 30005091; destinationStargateId= 50003118 } |> Some
      | 50003927 -> { StargateData.id= 50003927; name= "Stargate (Gyng)"; solarSystemId= 30002526; position= {x = -2.819151667e+12;  y = 4.233873408e+11;  z = -1.427455058e+12;}; typeId= 29633; destinationSolarSystemId= 30002529; destinationStargateId= 50006181 } |> Some
      | 50004024 -> { StargateData.id= 50004024; name= "Stargate (U-HYMT)"; solarSystemId= 30003719; position= {x = 5.97485568e+10;  y = -6827089920.0;  z = 9.369797837e+11;}; typeId= 29624; destinationSolarSystemId= 30003717; destinationStargateId= 50003385 } |> Some
      | 50004121 -> { StargateData.id= 50004121; name= "Stargate (Parts)"; solarSystemId= 30004996; position= {x = 1.548173107e+12;  y = 7.260229632e+10;  z = 4.486242509e+12;}; typeId= 3875; destinationSolarSystemId= 30004998; destinationStargateId= 50005921 } |> Some
      | 50004218 -> { StargateData.id= 50004218; name= "Stargate (D-SKWC)"; solarSystemId= 30001292; position= {x = -7.243935744e+10;  y = 4444200960.0;  z = 5.446275072e+10;}; typeId= 16; destinationSolarSystemId= 30001299; destinationStargateId= 50005302 } |> Some
      | 50004315 -> { StargateData.id= 50004315; name= "Stargate (0-XIDJ)"; solarSystemId= 30001293; position= {x = -1.190440182e+12;  y = -1.353391718e+11;  z = -6.149235917e+11;}; typeId= 16; destinationSolarSystemId= 30001295; destinationStargateId= 50004545 } |> Some
      | 50004606 -> { StargateData.id= 50004606; name= "Stargate (Gratesier)"; solarSystemId= 30002652; position= {x = 6.184578662e+11;  y = 6.858780672e+10;  z = -7.626155213e+11;}; typeId= 3875; destinationSolarSystemId= 30002653; destinationStargateId= 50005688 } |> Some
      | 50004703 -> { StargateData.id= 50004703; name= "Stargate (Y-4CFK)"; solarSystemId= 30001290; position= {x = -4.38165246e+12;  y = -8.085116928e+11;  z = 1.116016435e+12;}; typeId= 16; destinationSolarSystemId= 30001291; destinationStargateId= 50004909 } |> Some
      | 50004800 -> { StargateData.id= 50004800; name= "Stargate (MQFX-Q)"; solarSystemId= 30001277; position= {x = 1.090886984e+12;  y = 2.131971686e+11;  z = 2.752318956e+12;}; typeId= 16; destinationSolarSystemId= 30001278; destinationStargateId= 50005109 } |> Some
      | 50004897 -> { StargateData.id= 50004897; name= "Stargate (XD-TOV)"; solarSystemId= 30000891; position= {x = -1.016481178e+12;  y = -5.66016e+10;  z = -1.108799201e+12;}; typeId= 16; destinationSolarSystemId= 30000889; destinationStargateId= 50004198 } |> Some
      | 50004994 -> { StargateData.id= 50004994; name= "Stargate (07-SLO)"; solarSystemId= 30000598; position= {x = -2.498156667e+12;  y = 1.760746291e+11;  z = 6.67623383e+11;}; typeId= 29633; destinationSolarSystemId= 30000596; destinationStargateId= 50003308 } |> Some
      | 50005091 -> { StargateData.id= 50005091; name= "Stargate (B9E-H6)"; solarSystemId= 30002145; position= {x = -7.846282445e+11;  y = -2.283943158e+12;  z = 4.254486528e+10;}; typeId= 3877; destinationSolarSystemId= 30002110; destinationStargateId= 50000693 } |> Some
      | 50005188 -> { StargateData.id= 50005188; name= "Stargate (Toon)"; solarSystemId= 30005210; position= {x = -2.254178304e+11;  y = -4.419514368e+10;  z = -2.114957353e+12;}; typeId= 29624; destinationSolarSystemId= 30005212; destinationStargateId= 50006583 } |> Some
      | 50005285 -> { StargateData.id= 50005285; name= "Stargate (TU-RI6)"; solarSystemId= 30003741; position= {x = -1.802333798e+11;  y = -1.931268096e+10;  z = -5.345904108e+12;}; typeId= 29624; destinationSolarSystemId= 30003742; destinationStargateId= 50005343 } |> Some
      | 50005382 -> { StargateData.id= 50005382; name= "Stargate (Atier)"; solarSystemId= 30002700; position= {x = 1.917855744e+11;  y = 2317639680.0;  z = 1.034222592e+12;}; typeId= 3875; destinationSolarSystemId= 30002701; destinationStargateId= 50007465 } |> Some
      | 50005479 -> { StargateData.id= 50005479; name= "Stargate (N6G-H3)"; solarSystemId= 30001283; position= {x = -8.88834048e+10;  y = 7736401920.0;  z = 8520376320.0;}; typeId= 16; destinationSolarSystemId= 30001280; destinationStargateId= 50003589 } |> Some
      | 50005576 -> { StargateData.id= 50005576; name= "Stargate (Hardbako)"; solarSystemId= 30003417; position= {x = 2.927390515e+12;  y = 4.17234985e+11;  z = 5.611928371e+11;}; typeId= 29633; destinationSolarSystemId= 30003418; destinationStargateId= 50005731 } |> Some
      | 50005673 -> { StargateData.id= 50005673; name= "Stargate (P-E9GN)"; solarSystemId= 30002450; position= {x = 3.485602406e+12;  y = -3.474658959e+12;  z = 1.607364403e+12;}; typeId= 29627; destinationSolarSystemId= 30002467; destinationStargateId= 50005916 } |> Some
      | 50005770 -> { StargateData.id= 50005770; name= "Stargate (Hulmate)"; solarSystemId= 30004989; position= {x = -9.671087309e+11;  y = -1.359371059e+11;  z = 1.613069722e+12;}; typeId= 3875; destinationSolarSystemId= 30004988; destinationStargateId= 50004521 } |> Some
      | 50005867 -> { StargateData.id= 50005867; name= "Stargate (D0-F4W)"; solarSystemId= 30002434; position= {x = 3.024902185e+12;  y = -5.776504013e+11;  z = 1.980905841e+12;}; typeId= 16; destinationSolarSystemId= 30002430; destinationStargateId= 50004621 } |> Some
      | 50005964 -> { StargateData.id= 50005964; name= "Stargate (DNR-7M)"; solarSystemId= 30003760; position= {x = -2.059024097e+12;  y = -2.4703488e+11;  z = -6.480277094e+11;}; typeId= 29624; destinationSolarSystemId= 30003762; destinationStargateId= 50008082 } |> Some
      | 50006061 -> { StargateData.id= 50006061; name= "Stargate (UD-AOK)"; solarSystemId= 30000998; position= {x = -2.676853555e+11;  y = -3.454021632e+10;  z = -1.64397097e+11;}; typeId= 29633; destinationSolarSystemId= 30000997; destinationStargateId= 50005991 } |> Some
      | 50006158 -> { StargateData.id= 50006158; name= "Stargate (Pelille)"; solarSystemId= 30003808; position= {x = -2.920364851e+11;  y = -2.2201344e+10;  z = -4.982677094e+11;}; typeId= 3875; destinationSolarSystemId= 30003806; destinationStargateId= 50005943 } |> Some
      | 50006255 -> { StargateData.id= 50006255; name= "Stargate (IRE-98)"; solarSystemId= 30002593; position= {x = -1.246272676e+12;  y = -6032056320.0;  z = -2.860467364e+12;}; typeId= 29633; destinationSolarSystemId= 30002595; destinationStargateId= 50006299 } |> Some
      | 50006352 -> { StargateData.id= 50006352; name= "Stargate (Y-6B0E)"; solarSystemId= 30002598; position= {x = -4.663105536e+11;  y = -1.917923328e+10;  z = 1.447966433e+12;}; typeId= 29633; destinationSolarSystemId= 30002597; destinationStargateId= 50006345 } |> Some
      | 50006449 -> { StargateData.id= 50006449; name= "Stargate (KH0Z-0)"; solarSystemId= 30001239; position= {x = -3.023837061e+12;  y = -3.944498381e+11;  z = -1.081935421e+12;}; typeId= 29624; destinationSolarSystemId= 30001240; destinationStargateId= 50006665 } |> Some
      | 50006546 -> { StargateData.id= 50006546; name= "Stargate (Evati)"; solarSystemId= 30002061; position= {x = -9.85612247e+11;  y = -1.835973427e+11;  z = -1.218288722e+12;}; typeId= 29633; destinationSolarSystemId= 30002060; destinationStargateId= 50004614 } |> Some
      | 50006643 -> { StargateData.id= 50006643; name= "Stargate (Gayar)"; solarSystemId= 30005239; position= {x = -2.190781686e+12;  y = 3.481004851e+11;  z = 6.15268393e+11;}; typeId= 29624; destinationSolarSystemId= 30005240; destinationStargateId= 50007030 } |> Some
      | 50006740 -> { StargateData.id= 50006740; name= "Stargate (M-9V5D)"; solarSystemId= 30002600; position= {x = -5.546838835e+11;  y = -5.921427456e+10;  z = -6.397000704e+12;}; typeId= 29633; destinationSolarSystemId= 30002601; destinationStargateId= 50007066 } |> Some
      | 50006837 -> { StargateData.id= 50006837; name= "Stargate (Nieril)"; solarSystemId= 30000111; position= {x = 7.810374451e+11;  y = -1.090698854e+11;  z = -3.435055227e+12;}; typeId= 29624; destinationSolarSystemId= 30000108; destinationStargateId= 50003744 } |> Some
      | 50006934 -> { StargateData.id= 50006934; name= "Stargate (H-29TM)"; solarSystemId= 30005125; position= {x = 5087354880.0;  y = -371957760.0;  z = 8.376152064e+10;}; typeId= 3875; destinationSolarSystemId= 30005123; destinationStargateId= 50006287 } |> Some
      | 50007031 -> { StargateData.id= 50007031; name= "Stargate (Naka)"; solarSystemId= 30005240; position= {x = -5.925822874e+11;  y = 1.193372467e+11;  z = 1.365945139e+11;}; typeId= 29624; destinationSolarSystemId= 30005242; destinationStargateId= 50007375 } |> Some
      | 50007128 -> { StargateData.id= 50007128; name= "Stargate (6L78-1)"; solarSystemId= 30002463; position= {x = -3.216948019e+11;  y = -3.728683008e+10;  z = -3.210491904e+11;}; typeId= 16; destinationSolarSystemId= 30002459; destinationStargateId= 50006068 } |> Some
      | 50007225 -> { StargateData.id= 50007225; name= "Stargate (L-SCBU)"; solarSystemId= 30003683; position= {x = 1.061586248e+12;  y = 1.469093069e+11;  z = -4.346572431e+12;}; typeId= 3875; destinationSolarSystemId= 30003684; destinationStargateId= 50007540 } |> Some
      | 50007322 -> { StargateData.id= 50007322; name= "Stargate (Imya)"; solarSystemId= 30005249; position= {x = 3.497483182e+12;  y = -5.675078246e+12;  z = 1.377340908e+12;}; typeId= 17; destinationSolarSystemId= 30005246; destinationStargateId= 50006768 } |> Some
      | 50007419 -> { StargateData.id= 50007419; name= "Stargate (Q-U96U)"; solarSystemId= 30001246; position= {x = -2.048219013e+12;  y = -1.91256576e+10;  z = 2.954727014e+11;}; typeId= 29624; destinationSolarSystemId= 30001248; destinationStargateId= 50007841 } |> Some
      | 50007516 -> { StargateData.id= 50007516; name= "Stargate (MO-FIF)"; solarSystemId= 30000272; position= {x = -5.27288279e+11;  y = 4.94966784e+10;  z = 3.828489708e+12;}; typeId= 16; destinationSolarSystemId= 30000270; destinationStargateId= 50005654 } |> Some
      | 50007613 -> { StargateData.id= 50007613; name= "Stargate (HQ-TDJ)"; solarSystemId= 30001868; position= {x = -2.73235071e+12;  y = -2.164065485e+11;  z = 1.508428308e+12;}; typeId= 29624; destinationSolarSystemId= 30001871; destinationStargateId= 50009006 } |> Some
      | 50007710 -> { StargateData.id= 50007710; name= "Stargate (Imya)"; solarSystemId= 30005261; position= {x = 2.323905331e+11;  y = 2.035679109e+12;  z = 1.01310591e+12;}; typeId= 17; destinationSolarSystemId= 30005246; destinationStargateId= 50006769 } |> Some
      | 50007807 -> { StargateData.id= 50007807; name= "Stargate (M-ZJWJ)"; solarSystemId= 30000513; position= {x = -4.939575828e+12;  y = 3.724688548e+12;  z = 5.227731763e+11;}; typeId= 29635; destinationSolarSystemId= 30002181; destinationStargateId= 50012808 } |> Some
      | 50007904 -> { StargateData.id= 50007904; name= "Stargate (RXTY-4)"; solarSystemId= 30001139; position= {x = 1.336223785e+12;  y = -1.145847398e+11;  z = 3.700317266e+12;}; typeId= 3875; destinationSolarSystemId= 30001138; destinationStargateId= 50007852 } |> Some
      | 50008001 -> { StargateData.id= 50008001; name= "Stargate (TFA0-U)"; solarSystemId= 30002035; position= {x = -2.104569815e+12;  y = -3.391033344e+10;  z = 4.550452224e+12;}; typeId= 16; destinationSolarSystemId= 30002038; destinationStargateId= 50009645 } |> Some
      | 50008098 -> { StargateData.id= 50008098; name= "Stargate (L6BY-P)"; solarSystemId= 30002608; position= {x = 4.349134848e+11;  y = 4.99402752e+10;  z = -1.083514921e+12;}; typeId= 29633; destinationSolarSystemId= 30002607; destinationStargateId= 50007816 } |> Some
      | 50008195 -> { StargateData.id= 50008195; name= "Stargate (RK-Q51)"; solarSystemId= 30002379; position= {x = 1.100841001e+12;  y = 5.936074752e+10;  z = -3.077850194e+12;}; typeId= 3875; destinationSolarSystemId= 30002380; destinationStargateId= 50009492 } |> Some
      | 50008292 -> { StargateData.id= 50008292; name= "Stargate (Kizama)"; solarSystemId= 30005057; position= {x = 1.286168863e+12;  y = -7.724077056e+10;  z = 8.139520819e+11;}; typeId= 29624; destinationSolarSystemId= 30005056; destinationStargateId= 50007919 } |> Some
      | 50008389 -> { StargateData.id= 50008389; name= "Stargate (AZ-UWB)"; solarSystemId= 30001341; position= {x = 4.078494228e+12;  y = -4.686772224e+11;  z = 3.099852104e+12;}; typeId= 16; destinationSolarSystemId= 30001342; destinationStargateId= 50008630 } |> Some
      | 50008486 -> { StargateData.id= 50008486; name= "Stargate (Afnakat)"; solarSystemId= 30003909; position= {x = -4.112155853e+11;  y = -5.71508736e+10;  z = -1.358419108e+12;}; typeId= 29624; destinationSolarSystemId= 30003903; destinationStargateId= 50007778 } |> Some
      | 50008583 -> { StargateData.id= 50008583; name= "Stargate (FG-1GH)"; solarSystemId= 30002629; position= {x = -5.254163128e+12;  y = -2.234242253e+11;  z = -6.951456768e+10;}; typeId= 29633; destinationSolarSystemId= 30002628; destinationStargateId= 50007560 } |> Some
      | 50008680 -> { StargateData.id= 50008680; name= "Stargate (Eram)"; solarSystemId= 30003415; position= {x = 6.652798157e+11;  y = -1.112406835e+11;  z = -5.977474253e+11;}; typeId= 29633; destinationSolarSystemId= 30003413; destinationStargateId= 50007774 } |> Some
      | 50008777 -> { StargateData.id= 50008777; name= "Stargate (B-GC1T)"; solarSystemId= 30004326; position= {x = 1.196554445e+12;  y = -1.940890829e+11;  z = -4.006957056e+10;}; typeId= 16; destinationSolarSystemId= 30004328; destinationStargateId= 50010630 } |> Some
      | 50008874 -> { StargateData.id= 50008874; name= "Stargate (Thelan)"; solarSystemId= 30002719; position= {x = 1.886565704e+12;  y = -2.435394355e+11;  z = -2.231918961e+12;}; typeId= 3875; destinationSolarSystemId= 30002720; destinationStargateId= 50009221 } |> Some
      | 50008971 -> { StargateData.id= 50008971; name= "Stargate (Zimse)"; solarSystemId= 30004126; position= {x = 7.402254336e+10;  y = -1272176640.0;  z = -4.071591076e+12;}; typeId= 29624; destinationSolarSystemId= 30004127; destinationStargateId= 50009126 } |> Some
      | 50009068 -> { StargateData.id= 50009068; name= "Stargate (9ES-SI)"; solarSystemId= 30003955; position= {x = 1.006511309e+11;  y = 1.429819392e+10;  z = -1.23339092e+12;}; typeId= 29624; destinationSolarSystemId= 30003954; destinationStargateId= 50008951 } |> Some
      | 50009165 -> { StargateData.id= 50009165; name= "Stargate (U-RELP)"; solarSystemId= 30003236; position= {x = 3.806482022e+11;  y = 6.989377536e+10;  z = -5.753277235e+11;}; typeId= 3875; destinationSolarSystemId= 30003240; destinationStargateId= 50010494 } |> Some
      | 50009262 -> { StargateData.id= 50009262; name= "Stargate (35-RK9)"; solarSystemId= 30003311; position= {x = -1.452244623e+12;  y = -5.377634304e+10;  z = 1.369513943e+12;}; typeId= 3875; destinationSolarSystemId= 30003312; destinationStargateId= 50010879 } |> Some
      | 50009359 -> { StargateData.id= 50009359; name= "Stargate (ZIU-EP)"; solarSystemId= 30004358; position= {x = -3.470828052e+12;  y = 1.763002368e+11;  z = 4.118629294e+12;}; typeId= 16; destinationSolarSystemId= 30004363; destinationStargateId= 50011712 } |> Some
      | 50009456 -> { StargateData.id= 50009456; name= "Stargate (Irmalin)"; solarSystemId= 30003931; position= {x = -1.659214356e+12;  y = -1.01263319e+11;  z = -1.273269903e+12;}; typeId= 29624; destinationSolarSystemId= 30003935; destinationStargateId= 50009727 } |> Some
      | 50009553 -> { StargateData.id= 50009553; name= "Stargate (QBH5-F)"; solarSystemId= 30004450; position= {x = -4.318154465e+12;  y = 4.837445345e+12;  z = 3.362400707e+12;}; typeId= 3877; destinationSolarSystemId= 30004408; destinationStargateId= 50007014 } |> Some
      | 50009650 -> { StargateData.id= 50009650; name= "Stargate (Ansen)"; solarSystemId= 30002078; position= {x = -1.134444012e+12;  y = -1.094739149e+11;  z = 9.301697741e+11;}; typeId= 29633; destinationSolarSystemId= 30002081; destinationStargateId= 50012689 } |> Some
      | 50009747 -> { StargateData.id= 50009747; name= "Stargate (Arwa)"; solarSystemId= 30002079; position= {x = 5.438815396e+12;  y = -7.557153178e+11;  z = -4.022872596e+12;}; typeId= 29633; destinationSolarSystemId= 30002078; destinationStargateId= 50009648 } |> Some
      | 50009844 -> { StargateData.id= 50009844; name= "Stargate (C-OK0R)"; solarSystemId= 30003690; position= {x = -5.099273134e+12;  y = 3.032615731e+11;  z = -3.881660867e+12;}; typeId= 3875; destinationSolarSystemId= 30003692; destinationStargateId= 50010218 } |> Some
      | 50009941 -> { StargateData.id= 50009941; name= "Stargate (9KE-IT)"; solarSystemId= 30004168; position= {x = -1.563637555e+12;  y = 9.968873472e+10;  z = 3.241840435e+12;}; typeId= 3875; destinationSolarSystemId= 30004169; destinationStargateId= 50010101 } |> Some
      | 50010038 -> { StargateData.id= 50010038; name= "Stargate (HO4E-Q)"; solarSystemId= 30003244; position= {x = 1.2942336e+10;  y = -906977280.0;  z = 9.912969216e+11;}; typeId= 3875; destinationSolarSystemId= 30003243; destinationStargateId= 50009505 } |> Some
      | 50010135 -> { StargateData.id= 50010135; name= "Stargate (Access)"; solarSystemId= 30005281; position= {x = -1.017522217e+12;  y = -6.824228045e+11;  z = 1.077906432e+12;}; typeId= 17; destinationSolarSystemId= 30005266; destinationStargateId= 50008915 } |> Some
      | 50010232 -> { StargateData.id= 50010232; name= "Stargate (42-UOW)"; solarSystemId= 30001897; position= {x = 3.235615949e+11;  y = -2.978746368e+10;  z = 3.328831488e+10;}; typeId= 29624; destinationSolarSystemId= 30001894; destinationStargateId= 50009848 } |> Some
      | 50010329 -> { StargateData.id= 50010329; name= "Stargate (FWST-8)"; solarSystemId= 30004719; position= {x = -5.824756531e+11;  y = -8.554082304e+10;  z = 2.951328154e+11;}; typeId= 29624; destinationSolarSystemId= 30004718; destinationStargateId= 50010304 } |> Some
      | 50010426 -> { StargateData.id= 50010426; name= "Stargate (Y-FZ5N)"; solarSystemId= 30002164; position= {x = 2.210152489e+12;  y = -2.035208602e+11;  z = 3.911870915e+12;}; typeId= 29633; destinationSolarSystemId= 30002162; destinationStargateId= 50009015 } |> Some
      | 50010523 -> { StargateData.id= 50010523; name= "Stargate (O-MCZR)"; solarSystemId= 30004672; position= {x = -3.162509722e+11;  y = 5.251510272e+10;  z = 3.120671539e+11;}; typeId= 29624; destinationSolarSystemId= 30004671; destinationStargateId= 50010488 } |> Some
      | 50010620 -> { StargateData.id= 50010620; name= "Stargate (3-JCJT)"; solarSystemId= 30004007; position= {x = 2.568523776e+10;  y = 4598538240.0;  z = -3.727601664e+10;}; typeId= 29624; destinationSolarSystemId= 30004004; destinationStargateId= 50009906 } |> Some
      | 50010717 -> { StargateData.id= 50010717; name= "Stargate (XW-JHT)"; solarSystemId= 30004380; position= {x = -1.844310221e+12;  y = 2.919760282e+11;  z = 8.997464064e+11;}; typeId= 16; destinationSolarSystemId= 30004382; destinationStargateId= 50010916 } |> Some
      | 50010814 -> { StargateData.id= 50010814; name= "Stargate (4Y-OBL)"; solarSystemId= 30004675; position= {x = 9.209252659e+11;  y = -1.266031411e+11;  z = -5.005240934e+12;}; typeId= 29624; destinationSolarSystemId= 30004673; destinationStargateId= 50010663 } |> Some
      | 50010911 -> { StargateData.id= 50010911; name= "Stargate (PFV-ZH)"; solarSystemId= 30005179; position= {x = 4.955390362e+11;  y = -6017556480.0;  z = 4.661500723e+11;}; typeId= 3875; destinationSolarSystemId= 30005178; destinationStargateId= 50010517 } |> Some
      | 50011008 -> { StargateData.id= 50011008; name= "Stargate (Ihakana)"; solarSystemId= 30000171; position= {x = -1.41713449e+11;  y = 2.099564544e+10;  z = 2.755055616e+10;}; typeId= 16; destinationSolarSystemId= 30000169; destinationStargateId= 50008509 } |> Some
      | 50011105 -> { StargateData.id= 50011105; name= "Stargate (Uktiad)"; solarSystemId= 30003007; position= {x = 7.655889715e+11;  y = 8.945577984e+10;  z = -1.447755817e+12;}; typeId= 29624; destinationSolarSystemId= 30003005; destinationStargateId= 50010547 } |> Some
      | 50011202 -> { StargateData.id= 50011202; name= "Stargate (Esmes)"; solarSystemId= 30002729; position= {x = 5.849001984e+10;  y = 5052211200.0;  z = -2.913569464e+12;}; typeId= 3875; destinationSolarSystemId= 30002730; destinationStargateId= 50011758 } |> Some
      | 50011299 -> { StargateData.id= 50011299; name= "Stargate (7AH-SF)"; solarSystemId= 30005151; position= {x = 4.575424143e+12;  y = 3.298547712e+11;  z = -3.957049344e+11;}; typeId= 3875; destinationSolarSystemId= 30005145; destinationStargateId= 50007139 } |> Some
      | 50011396 -> { StargateData.id= 50011396; name= "Stargate (Shousran)"; solarSystemId= 30001668; position= {x = -3.167476531e+11;  y = 4.32666624e+10;  z = 1.27503446e+12;}; typeId= 29624; destinationSolarSystemId= 30001667; destinationStargateId= 50011323 } |> Some
      | 50011493 -> { StargateData.id= 50011493; name= "Stargate (Noghere)"; solarSystemId= 30005021; position= {x = 2.579501752e+12;  y = -2.942380032e+11;  z = 2.502201876e+12;}; typeId= 3875; destinationSolarSystemId= 30005018; destinationStargateId= 50009039 } |> Some
      | 50011590 -> { StargateData.id= 50011590; name= "Stargate (KMQ4-V)"; solarSystemId= 30004376; position= {x = -4.726246195e+11;  y = -5.172006912e+10;  z = -1.533382287e+12;}; typeId= 16; destinationSolarSystemId= 30004375; destinationStargateId= 50011255 } |> Some
      | 50011687 -> { StargateData.id= 50011687; name= "Stargate (LUL-WX)"; solarSystemId= 30004681; position= {x = 1.144962785e+12;  y = 2.283588403e+11;  z = -6.081205985e+12;}; typeId= 29624; destinationSolarSystemId= 30004680; destinationStargateId= 50011449 } |> Some
      | 50011784 -> { StargateData.id= 50011784; name= "Stargate (Arveyil)"; solarSystemId= 30003008; position= {x = -2.064496927e+12;  y = 1.764754637e+11;  z = -7.087449907e+12;}; typeId= 29624; destinationSolarSystemId= 30003007; destinationStargateId= 50011106 } |> Some
      | 50011881 -> { StargateData.id= 50011881; name= "Stargate (Y-N4EF)"; solarSystemId= 30002175; position= {x = -2.696697324e+12;  y = 1.644982272e+10;  z = 1.643021476e+12;}; typeId= 29633; destinationSolarSystemId= 30002176; destinationStargateId= 50011892 } |> Some
      | 50011978 -> { StargateData.id= 50011978; name= "Stargate (LEK-N5)"; solarSystemId= 30002933; position= {x = -2.494654095e+12;  y = -2.464787251e+11;  z = 3.770158694e+11;}; typeId= 16; destinationSolarSystemId= 30002932; destinationStargateId= 50011679 } |> Some
      | 50012075 -> { StargateData.id= 50012075; name= "Stargate (AC2E-3)"; solarSystemId= 30004565; position= {x = -1.868085535e+12;  y = -1.789863936e+11;  z = -1.159418388e+12;}; typeId= 3875; destinationSolarSystemId= 30004563; destinationStargateId= 50011884 } |> Some
      | 50012172 -> { StargateData.id= 50012172; name= "Stargate (F-NXLQ)"; solarSystemId= 30004031; position= {x = 1.41135532e+12;  y = 1.789492838e+11;  z = 1.573012685e+11;}; typeId= 29624; destinationSolarSystemId= 30004032; destinationStargateId= 50012528 } |> Some
      | 50012269 -> { StargateData.id= 50012269; name= "Stargate (3ZTV-V)"; solarSystemId= 30004625; position= {x = -2.245767168e+10;  y = 1646223360.0;  z = -2.93601239e+11;}; typeId= 3875; destinationSolarSystemId= 30004628; destinationStargateId= 50013062 } |> Some
      | 50012366 -> { StargateData.id= 50012366; name= "Stargate (75FA-Z)"; solarSystemId= 30004621; position= {x = -2.587972608e+12;  y = 1.507414426e+11;  z = 1.217071718e+12;}; typeId= 3875; destinationSolarSystemId= 30004620; destinationStargateId= 50012364 } |> Some
      | 50012463 -> { StargateData.id= 50012463; name= "Stargate (J1AU-9)"; solarSystemId= 30002940; position= {x = -4.258196275e+11;  y = -5.092601856e+10;  z = 4.496684237e+11;}; typeId= 16; destinationSolarSystemId= 30002942; destinationStargateId= 50012714 } |> Some
      | 50012560 -> { StargateData.id= 50012560; name= "Stargate (VR-YRV)"; solarSystemId= 30003176; position= {x = -2.881200538e+11;  y = -3.882135552e+10;  z = 6.431270093e+11;}; typeId= 29624; destinationSolarSystemId= 30003175; destinationStargateId= 50012216 } |> Some
      | 50012657 -> { StargateData.id= 50012657; name= "Stargate (3PPT-9)"; solarSystemId= 30004685; position= {x = -4.658426388e+12;  y = 5.57047849e+11;  z = 3.554437079e+12;}; typeId= 29624; destinationSolarSystemId= 30004682; destinationStargateId= 50012211 } |> Some
      | 50012754 -> { StargateData.id= 50012754; name= "Stargate (WIW-X8)"; solarSystemId= 30001596; position= {x = -1.182761165e+12;  y = 2.008440422e+11;  z = 8.55474217e+11;}; typeId= 3875; destinationSolarSystemId= 30001595; destinationStargateId= 50012750 } |> Some
      | 50012851 -> { StargateData.id= 50012851; name= "Stargate (VR-YIQ)"; solarSystemId= 30004940; position= {x = -4.054357156e+12;  y = -5.996065628e+12;  z = 1.778043249e+12;}; typeId= 17; destinationSolarSystemId= 30004931; destinationStargateId= 50012632 } |> Some
      | 50012948 -> { StargateData.id= 50012948; name= "Stargate (48I1-X)"; solarSystemId= 30004948; position= {x = 3.520780984e+12;  y = 2.973906125e+11;  z = -9.733758198e+12;}; typeId= 29624; destinationSolarSystemId= 30004949; destinationStargateId= 50013013 } |> Some
      | 50013045 -> { StargateData.id= 50013045; name= "Stargate (Ommare)"; solarSystemId= 30005028; position= {x = -1.19163777e+12;  y = -4.974882816e+10;  z = 1.060266762e+12;}; typeId= 3875; destinationSolarSystemId= 30005027; destinationStargateId= 50012343 } |> Some
      | 50013142 -> { StargateData.id= 50013142; name= "Stargate (YVA-F0)"; solarSystemId= 30004547; position= {x = 1.829726208e+11;  y = -2.483392512e+10;  z = -5.914852147e+11;}; typeId= 3875; destinationSolarSystemId= 30004548; destinationStargateId= 50013270 } |> Some
      | 50013239 -> { StargateData.id= 50013239; name= "Stargate (1H4V-O)"; solarSystemId= 30001951; position= {x = -1.954726257e+12;  y = -1.393086874e+11;  z = 1.367886766e+12;}; typeId= 29624; destinationSolarSystemId= 30001952; destinationStargateId= 50013241 } |> Some
      | 50013336 -> { StargateData.id= 50013336; name= "Stargate (46DP-O)"; solarSystemId= 30004879; position= {x = 2.162431181e+11;  y = 3.325784064e+10;  z = 1.538445681e+12;}; typeId= 29633; destinationSolarSystemId= 30004878; destinationStargateId= 50013326 } |> Some
      | 50013433 -> { StargateData.id= 50013433; name= "Stargate (QN-6J2)"; solarSystemId= 30002184; position= {x = -2.021485363e+11;  y = 1.405587456e+10;  z = -1.849189048e+12;}; typeId= 29633; destinationSolarSystemId= 30002186; destinationStargateId= 50013463 } |> Some
      | 50013530 -> { StargateData.id= 50013530; name= "Stargate (Sarline)"; solarSystemId= 30003587; position= {x = 1.855844352e+10;  y = -2202624000.0;  z = 7.840272384e+10;}; typeId= 3875; destinationSolarSystemId= 30003584; destinationStargateId= 50011374 } |> Some
      | 50013627 -> { StargateData.id= 50013627; name= "Stargate (Ami)"; solarSystemId= 30005074; position= {x = -1.541691433e+12;  y = -7.325886013e+12;  z = 8.398565376e+10;}; typeId= 17; destinationSolarSystemId= 30005035; destinationStargateId= 50013628 } |> Some
      | 50013821 -> { StargateData.id= 50013821; name= "Stargate (PUZ-IO)"; solarSystemId= 30000703; position= {x = 2.70916608e+11;  y = 3.72608766e+12;  z = 2.768396329e+12;}; typeId= 12292; destinationSolarSystemId= 30000978; destinationStargateId= 50013822 } |> Some
      | 50013918 -> { StargateData.id= 50013918; name= "Stargate (Tunttaras)"; solarSystemId= 30001377; position= {x = 5.694640251e+12;  y = 4.312147968e+11;  z = -2.566347571e+11;}; typeId= 16; destinationSolarSystemId= 30001379; destinationStargateId= 50013917 } |> Some
      | 50014015 -> { StargateData.id= 50014015; name= "Stargate (Egbinger)"; solarSystemId= 30002394; position= {x = 1.573491057e+12;  y = -6.214576128e+11;  z = -7.148638618e+11;}; typeId= 3877; destinationSolarSystemId= 30002420; destinationStargateId= 50014016 } |> Some
      | 50014112 -> { StargateData.id= 50014112; name= "Stargate (Unpas)"; solarSystemId= 30030141; position= {x = -1.791128003e+12;  y = 2.171300659e+11;  z = -1.206732349e+12;}; typeId= 16; destinationSolarSystemId= 30000129; destinationStargateId= 50014111 } |> Some
      | 50014209 -> { StargateData.id= 50014209; name= "Stargate (1S-SU1)"; solarSystemId= 30002472; position= {x = 3.327229993e+12;  y = -4.184999117e+11;  z = -1.427770614e+12;}; typeId= 29629; destinationSolarSystemId= 30002866; destinationStargateId= 50014210 } |> Some
      | 50016246 -> { StargateData.id= 50016246; name= "Stargate (Okagaiken)"; solarSystemId= 30004055; position= {x = 5.965719921e+12;  y = 6.963890995e+11;  z = 2.219405599e+12;}; typeId= 3876; destinationSolarSystemId= 30045307; destinationStargateId= 50016245 } |> Some
      | 50016343 -> { StargateData.id= 50016343; name= "Stargate (Vaaralen)"; solarSystemId= 30045334; position= {x = 1.672488591e+12;  y = 4388167680.0;  z = 6.949361664e+11;}; typeId= 16; destinationSolarSystemId= 30045331; destinationStargateId= 50016344 } |> Some
      | _ -> None