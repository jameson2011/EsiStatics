﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stations15=
    let getStation id = 
      match id with 
      | 60000238 -> { StationData.id= 60000238; name= "Inis-Ilix V - CBD Corporation Storage"; solarSystemId= 30004102; position= {x = -5.221152768e+11;  y = -4.44278784e+10;  z = -1.578676224e+10;}; typeId= 1531; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60000529 -> { StationData.id= 60000529; name= "Airaken VI - Moon 3 - Hyasyoda Corporation Mineral Reserve"; solarSystemId= 30000185; position= {x = -1.829842944e+10;  y = -2109972480.0;  z = -1.335223788e+12;}; typeId= 4023; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60000820 -> { StationData.id= 60000820; name= "Hakonen IX - Moon 16 - Minedrill Refinery"; solarSystemId= 30001448; position= {x = 4.117193073e+12;  y = -6.012905472e+11;  z = -1.801198387e+11;}; typeId= 4024; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001111 -> { StationData.id= 60001111; name= "Ebasgerdur V - Moon 11 - Kaalakiota Corporation Factory"; solarSystemId= 30002535; position= {x = 1.060303626e+12;  y = -3.729420288e+10;  z = 4660961280.0;}; typeId= 4024; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001402 -> { StationData.id= 60001402; name= "Charmerout IX - Wiyrkomi Corporation Factory"; solarSystemId= 30004976; position= {x = 2.006996951e+12;  y = -3.122268979e+11;  z = -7.663473869e+11;}; typeId= 4024; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001693 -> { StationData.id= 60001693; name= "Huttaken I - Moon 1 - Caldari Steel Factory"; solarSystemId= 30002774; position= {x = -1.387567104e+11;  y = -2.80492032e+10;  z = -7.28549376e+10;}; typeId= 4024; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001984 -> { StationData.id= 60001984; name= "Derririntel V - Moon 15 - Nugoeihuvi Corporation Publisher"; solarSystemId= 30005025; position= {x = 1.073075405e+11;  y = 1.002123264e+10;  z = 5.542950912e+11;}; typeId= 3872; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60002275 -> { StationData.id= 60002275; name= "Silen III - Moon 9 - Lai Dai Corporation Research Center"; solarSystemId= 30000179; position= {x = -5.64109271e+11;  y = -3.519885312e+10;  z = 1.267584614e+11;}; typeId= 54; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60002566 -> { StationData.id= 60002566; name= "Simbeloud IX - Moon 1 - Expert Distribution Warehouse"; solarSystemId= 30002195; position= {x = 1.106489303e+12;  y = -8.013090816e+10;  z = -1.137722204e+12;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60002857 -> { StationData.id= 60002857; name= "Soshin VIII - Sukuuvestaa Corporation Factory"; solarSystemId= 30000175; position= {x = 1.489326858e+12;  y = 8.211099648e+10;  z = 7.48650455e+11;}; typeId= 4024; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003148 -> { StationData.id= 60003148; name= "Hykkota V - Moon 17 - Caldari Funds Unlimited Depository"; solarSystemId= 30000134; position= {x = -1.031500063e+12;  y = -5.957677056e+10;  z = 7.603560038e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003439 -> { StationData.id= 60003439; name= "Ishomilken IX - Moon 12 - Mercantile Club Bureau"; solarSystemId= 30002756; position= {x = 9.687740006e+11;  y = 1.252630118e+11;  z = -4.126181376e+11;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003730 -> { StationData.id= 60003730; name= "Ansila VIII - Moon 14 - House of Records Bureau Offices"; solarSystemId= 30000132; position= {x = 7.981130957e+11;  y = -9431162880.0;  z = -1.472192225e+12;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004021 -> { StationData.id= 60004021; name= "Isikemi I - Home Guard Assembly Plant"; solarSystemId= 30001365; position= {x = 6153461760.0;  y = 621895680.0;  z = -3.476803584e+10;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004312 -> { StationData.id= 60004312; name= "Usi V - Moon 1 - Corporate Police Force Logistic Support"; solarSystemId= 30002755; position= {x = -4.696118477e+11;  y = 5.683851264e+10;  z = 4.140504269e+11;}; typeId= 1530; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004603 -> { StationData.id= 60004603; name= "Amamake II - Brutor Tribe Bureau"; solarSystemId= 30002537; position= {x = 5.499531264e+10;  y = 7304355840.0;  z = -1.63545047e+11;}; typeId= 2502; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004894 -> { StationData.id= 60004894; name= "Auner V - Republic Fleet Logistic Support"; solarSystemId= 30002059; position= {x = 1.100993741e+11;  y = -1.947316224e+10;  z = 1.338766541e+11;}; typeId= 2501; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005185 -> { StationData.id= 60005185; name= "Croleur III - Moon 1 - Republic Security Services Testing Facilities"; solarSystemId= 30002705; position= {x = 1.034975232e+11;  y = -1.122398208e+10;  z = 1.103714304e+11;}; typeId= 2500; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005476 -> { StationData.id= 60005476; name= "Ahala VII - Moon 1 - Core Complexion Inc. Warehouse"; solarSystemId= 30002247; position= {x = -6.135552e+11;  y = 8.943218688e+10;  z = 1.124178739e+11;}; typeId= 2501; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005767 -> { StationData.id= 60005767; name= "Gulfonodi X - Moon 13 - Native Freshfood Plantation"; solarSystemId= 30002384; position= {x = -7.113342566e+11;  y = 4.724625408e+10;  z = -1.830180741e+12;}; typeId= 2499; services= [| "courier-missions"; "reprocessing-plant"; "market"; "fitting"; "news"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006058 -> { StationData.id= 60006058; name= "Illuin VI - Moon 8 - The Leisure Group Development Studio"; solarSystemId= 30003377; position= {x = 4.07068545e+12;  y = 5.138528256e+11;  z = 3.885944709e+12;}; typeId= 2496; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006349 -> { StationData.id= 60006349; name= "Bahromab IX - Moon 5 - Carthum Conglomerate Factory"; solarSystemId= 30003502; position= {x = 1.360661668e+12;  y = -1.727637504e+11;  z = 1.221794488e+12;}; typeId= 1928; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "refinery"; "market"; "black-market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "factory"; "labratory"; "gambling"; "fitting"; "paintshop"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006640 -> { StationData.id= 60006640; name= "Polfaly VI - Moon 7 - Zoar and Sons Warehouse"; solarSystemId= 30005048; position= {x = -7.144234598e+11;  y = 7.382618112e+10;  z = 1.534320353e+12;}; typeId= 1929; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006931 -> { StationData.id= 60006931; name= "Pedel VII - HZO Refinery Mining Outpost"; solarSystemId= 30003516; position= {x = 1.821100646e+12;  y = 5.643620352e+10;  z = 2.45513687e+12;}; typeId= 1930; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007222 -> { StationData.id= 60007222; name= "Fihrneh VI - Moon 10 - Amarr Certified News Development Studio"; solarSystemId= 30004254; position= {x = -1.03020417e+12;  y = -6.1350912e+10;  z = -2.197997937e+12;}; typeId= 1931; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007513 -> { StationData.id= 60007513; name= "Shesha VII - Nurtura Plantation"; solarSystemId= 30001673; position= {x = 1.686037709e+11;  y = 3.125563392e+10;  z = 7.082875699e+11;}; typeId= 1930; services= [| "courier-missions"; "reprocessing-plant"; "market"; "fitting"; "news"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007804 -> { StationData.id= 60007804; name= "Aphend VIII - Moon 3 - Amarr Civil Service Bureau Offices"; solarSystemId= 30004079; position= {x = -2.743169065e+12;  y = 8.402153472e+10;  z = 6.109498982e+11;}; typeId= 1926; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008095 -> { StationData.id= 60008095; name= "Vecamia V - Moon 1 - Ministry of Assessment Archives"; solarSystemId= 30005195; position= {x = -8565104640.0;  y = -462888960.0;  z = -2.099347046e+11;}; typeId= 1931; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008386 -> { StationData.id= 60008386; name= "Kamih V - Amarr Navy Logistic Support"; solarSystemId= 30004239; position= {x = 7.628212224e+11;  y = 5.487464448e+10;  z = 2.739908198e+11;}; typeId= 1929; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008677 -> { StationData.id= 60008677; name= "Faswiba IX - Moon 8 - Sarum Family Assembly Plant"; solarSystemId= 30003541; position= {x = -2.728686797e+11;  y = 2.054541312e+10;  z = -4.647638262e+12;}; typeId= 1927; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008968 -> { StationData.id= 60008968; name= "Inis-Ilix II - Moon 1 - Theology Council Law School"; solarSystemId= 30004102; position= {x = 1.207230874e+11;  y = 1.027239936e+10;  z = -1.189564416e+10;}; typeId= 1929; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009259 -> { StationData.id= 60009259; name= "VSIG-K V - Moon 8 - TransStellar Shipping Storage"; solarSystemId= 30003361; position= {x = 7.04628695e+11;  y = 3.592507392e+10;  z = -4.463845786e+11;}; typeId= 3870; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009550 -> { StationData.id= 60009550; name= "Alentene VII - Moon 1 - Astral Mining Inc. Mineral Reserve"; solarSystemId= 30005304; position= {x = 2856099840.0;  y = -111452160.0;  z = -2.476517253e+12;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009841 -> { StationData.id= 60009841; name= "Vivanier VII - Moon 17 - Combined Harvest Food Packaging"; solarSystemId= 30003810; position= {x = -2.206199931e+12;  y = 3.83486976e+11;  z = 1.055045837e+12;}; typeId= 3866; services= [| "courier-missions"; "reprocessing-plant"; "market"; "fitting"; "news"; "storage"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010132 -> { StationData.id= 60010132; name= "Jambu VI - Moon 3 - CreoDron Factory"; solarSystemId= 30003554; position= {x = 6.865773773e+11;  y = 1.137218765e+11;  z = 2.426237338e+11;}; typeId= 3867; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010423 -> { StationData.id= 60010423; name= "Nahol X - Moon 1 - Poteque Pharmaceuticals Biotech Production"; solarSystemId= 30005069; position= {x = -1.361998848e+12;  y = 9.184579584e+10;  z = 1.756926075e+12;}; typeId= 3867; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "dna-therapy"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010714 -> { StationData.id= 60010714; name= "Mabnen VIII - Moon 2 - The Scope Development Studio"; solarSystemId= 30002190; position= {x = -1.299717857e+12;  y = -1.500894413e+11;  z = -6.127392768e+11;}; typeId= 56; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011005 -> { StationData.id= 60011005; name= "Anchauttes III - Moon 13 - FedMart Retail Center"; solarSystemId= 30003840; position= {x = -1.515875942e+11;  y = 8698552320.0;  z = -1.456746086e+11;}; typeId= 57; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "fitting"; "paintshop"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011296 -> { StationData.id= 60011296; name= "Ragnarg IV - Moon 2 - Aliastra Warehouse"; solarSystemId= 30002052; position= {x = -1.032719155e+11;  y = 2819727360.0;  z = 3.286807757e+11;}; typeId= 3870; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011587 -> { StationData.id= 60011587; name= "Scolluzer VII - Moon 1 - University of Caille"; solarSystemId= 30005322; position= {x = -1.261497139e+11;  y = 1.24372992e+10;  z = -5.338616218e+11;}; typeId= 57; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011878 -> { StationData.id= 60011878; name= "Iges VI - Moon 12 - Federation Navy Assembly Plant"; solarSystemId= 30003796; position= {x = 9.565802496e+10;  y = -1.812615168e+10;  z = 8.566764749e+11;}; typeId= 3867; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012169 -> { StationData.id= 60012169; name= "Nakah IV - Moon 1 - Ammatar Fleet Logistic Support"; solarSystemId= 30000072; position= {x = 3.714181939e+11;  y = -4.240134144e+10;  z = -3.603099648e+10;}; typeId= 2501; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012460 -> { StationData.id= 60012460; name= "Istodard IX - Moon 16 - CONCORD Bureau"; solarSystemId= 30002402; position= {x = -2.607324488e+12;  y = -4.348710912e+10;  z = -2.643642409e+12;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012751 -> { StationData.id= 60012751; name= "5E-VR8 I - Moon 10 - Salvation Angels Chemical Refinery"; solarSystemId= 30001014; position= {x = -1.739431895e+12;  y = 1.950898176e+11;  z = 3.862990848e+10;}; typeId= 1928; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013042 -> { StationData.id= 60013042; name= "Mastakomon IX - Moon 3 - DED Assembly Plant"; solarSystemId= 30000202; position= {x = -5.314819277e+11;  y = 1.77174528e+10;  z = -3.624312422e+11;}; typeId= 1927; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013333 -> { StationData.id= 60013333; name= "Stacmon VII - Moon 1 - Impro Factory"; solarSystemId= 30003794; position= {x = 5.544339456e+11;  y = 6.42349056e+10;  z = -1.033516769e+12;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "refinery"; "market"; "black-market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "factory"; "labratory"; "gambling"; "fitting"; "paintshop"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013624 -> { StationData.id= 60013624; name= "KF1-DU VII - Moon 3 - Jove Navy Assembly Plant"; solarSystemId= 30001515; position= {x = -1.897580667e+12;  y = 3.495312998e+11;  z = -3.884090573e+11;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013915 -> { StationData.id= 60013915; name= "PQWA-L XI - Moon 6 - Prosper Depository"; solarSystemId= 30001628; position= {x = -2.385831936e+11;  y = 4.399484928e+10;  z = 1.944255406e+12;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014206 -> { StationData.id= 60014206; name= "D9D-GD V - Moon 2 - True Creations Shipyard"; solarSystemId= 30001881; position= {x = -3.416871322e+11;  y = -4.653379584e+10;  z = -4.642709914e+11;}; typeId= 1927; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "paintshop"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014497 -> { StationData.id= 60014497; name= "Scolluzer VIII - Moon 1 - X-Sense Chemical Storage"; solarSystemId= 30005322; position= {x = -1.050303283e+11;  y = 1.035522048e+10;  z = -1.029623194e+12;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014788 -> { StationData.id= 60014788; name= "Sirekur VIII - Moon 1 - Republic University"; solarSystemId= 30002092; position= {x = -3.618555617e+12;  y = -1877975040.0;  z = -8.640409805e+12;}; typeId= 2500; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60015079 -> { StationData.id= 60015079; name= "Aivonen VI - State Protectorate Logistic Support"; solarSystemId= 30045340; position= {x = -4.808042496e+11;  y = -5719203840.0;  z = -4.904282112e+11;}; typeId= 1530; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | _ -> None