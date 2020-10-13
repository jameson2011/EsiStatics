﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stations79=
    let getStation id = 
      match id with 
      | 60000205 -> { StationData.id= 60000205; name= "Nebian II - CBD Corporation Storage"; solarSystemId= 30005031; position= {x = 6.761607168e+10;  y = -8097177600.0;  z = 1.367223091e+11;}; typeId= 1531; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60000496 -> { StationData.id= 60000496; name= "Uchoshi XI - Moon 12 - Hyasyoda Corporation Mineral Reserve"; solarSystemId= 30000201; position= {x = -2.515113124e+12;  y = -5.091150643e+11;  z = 1.004579267e+12;}; typeId= 4023; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60000787 -> { StationData.id= 60000787; name= "Vasala VI - Moon 10 - Minedrill Refinery"; solarSystemId= 30000190; position= {x = -9.072487219e+11;  y = -1.762014413e+11;  z = -8.497902797e+11;}; typeId= 4024; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001078 -> { StationData.id= 60001078; name= "Tividu IV - Moon 3 - Kaalakiota Corporation Factory"; solarSystemId= 30001644; position= {x = -4.687143322e+11;  y = 2647941120.0;  z = -2.498399846e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "refinery"; "market"; "black-market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "factory"; "labratory"; "gambling"; "fitting"; "paintshop"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001369 -> { StationData.id= 60001369; name= "Olide V - Moon 10 - Wiyrkomi Corporation Factory"; solarSystemId= 30003058; position= {x = -1.29560064e+12;  y = -1.015798579e+11;  z = -1.008705331e+12;}; typeId= 4024; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001660 -> { StationData.id= 60001660; name= "Nourvukaiken IV - Moon 2 - Caldari Steel Factory"; solarSystemId= 30001376; position= {x = 2.965334016e+11;  y = -2.429816832e+10;  z = 1.145819136e+10;}; typeId= 4024; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001951 -> { StationData.id= 60001951; name= "Scolluzer XI - Moon 4 - Nugoeihuvi Corporation Development Studio"; solarSystemId= 30005322; position= {x = -2.917135933e+12;  y = 2.876056781e+11;  z = 9.992455373e+11;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60002242 -> { StationData.id= 60002242; name= "Otanuomi IV - Moon 4 - Perun Clade Proving Complex"; solarSystemId= 30000192; position= {x = 3.337837363e+11;  y = -1.9074048e+10;  z = 4.034028749e+11;}; typeId= 1529; services= [| "reprocessing-plant"; "market"; "cloning"; "repair-facilities"; "factory"; "fitting"; "paintshop"; "news"; "storage"; "docking"; "office-rental"; "jump-clone-facility"; "loyalty-point-store" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60002533 -> { StationData.id= 60002533; name= "ZV-72W VII - Moon 8 - Expert Distribution Retail Center"; solarSystemId= 30003369; position= {x = -3.780660019e+11;  y = -5.421379584e+10;  z = -1.172327178e+12;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "fitting"; "paintshop"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60002824 -> { StationData.id= 60002824; name= "Kusomonmon VI - Moon 23 - Sukuuvestaa Corporation Foundry"; solarSystemId= 30002802; position= {x = -1.118793523e+12;  y = -6.498496512e+10;  z = -4.047390106e+12;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003115 -> { StationData.id= 60003115; name= "Sankkasen VII - Moon 6 - Expert Housing Production Plant"; solarSystemId= 30002783; position= {x = 2.725189632e+11;  y = -5.339025408e+10;  z = 5.300978074e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003406 -> { StationData.id= 60003406; name= "Jotenen V - Mercantile Club Bureau"; solarSystemId= 30001423; position= {x = -6.995289293e+11;  y = 6.619680768e+10;  z = -9.024677069e+11;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003697 -> { StationData.id= 60003697; name= "Chemilip IV - Moon 16 - Caldari Business Tribunal"; solarSystemId= 30003529; position= {x = 2.60388864e+10;  y = 5152235520.0;  z = -8.340456653e+11;}; typeId= 1530; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003988 -> { StationData.id= 60003988; name= "Isinokka VI - Moon 1 - Ishukone Watch Logistic Support"; solarSystemId= 30001426; position= {x = -4.857769574e+11;  y = -7.770525696e+10;  z = 1.739239711e+12;}; typeId= 1530; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004279 -> { StationData.id= 60004279; name= "Isikano IX - Moon 11 - Wiyrkomi Peace Corps Logistic Support"; solarSystemId= 30001387; position= {x = -1.655631421e+12;  y = -3.261831168e+11;  z = -2.054145024e+12;}; typeId= 1530; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004570 -> { StationData.id= 60004570; name= "Eldulf VI - Moon 3 - Vherokior Tribe Academy"; solarSystemId= 30002398; position= {x = 1.834086851e+12;  y = 1.61836032e+11;  z = 5.929340928e+10;}; typeId= 2502; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004861 -> { StationData.id= 60004861; name= "Lasleinur V - Moon 11 - Republic Fleet Assembly Plant"; solarSystemId= 30002065; position= {x = 9.030488064e+10;  y = 6845521920.0;  z = -1.390823055e+12;}; typeId= 2498; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005152 -> { StationData.id= 60005152; name= "Masalle VII - Moon 17 - Republic Security Services Logistic Support"; solarSystemId= 30005325; position= {x = -1.81586645e+12;  y = -1.877280768e+11;  z = -9.700503552e+10;}; typeId= 2501; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005443 -> { StationData.id= 60005443; name= "Reynire X - Moon 1 - Core Complexion Inc. Storage"; solarSystemId= 30003803; position= {x = -1.452349317e+12;  y = -4.135194624e+10;  z = 6.510825062e+11;}; typeId= 2501; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005734 -> { StationData.id= 60005734; name= "Lustrevik VIII - Moon 7 - Six Kin Development Warehouse"; solarSystemId= 30002545; position= {x = 2.555750769e+12;  y = 9.058922496e+10;  z = -6.979980902e+11;}; typeId= 2501; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006025 -> { StationData.id= 60006025; name= "Floseswin I - Moon 1 - Freedom Extension Storage"; solarSystemId= 30002082; position= {x = -1470750720.0;  y = -48291840.0;  z = -3.486806016e+10;}; typeId= 2501; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006316 -> { StationData.id= 60006316; name= "Jarshitsan VIII - Moon 8 - Carthum Conglomerate Factory"; solarSystemId= 30002263; position= {x = 1.888814285e+11;  y = 3.002830848e+10;  z = 2.58509353e+12;}; typeId= 1928; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "refinery"; "market"; "black-market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "factory"; "labratory"; "gambling"; "fitting"; "paintshop"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006607 -> { StationData.id= 60006607; name= "Uhodoh IX - Viziam Factory"; solarSystemId= 30001735; position= {x = -3.228366397e+12;  y = 6937681920.0;  z = -3.511973069e+11;}; typeId= 1928; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006898 -> { StationData.id= 60006898; name= "Aeter III - Moon 5 - Ducia Foundry Mineral Reserve"; solarSystemId= 30003585; position= {x = 3.414519398e+11;  y = 5.781762048e+10;  z = -8.675115418e+11;}; typeId= 1929; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007189 -> { StationData.id= 60007189; name= "Pashanai III - Moon 9 - Amarr Certified News Development Studio"; solarSystemId= 30005231; position= {x = -8.387383296e+10;  y = 5296988160.0;  z = -3.831402086e+11;}; typeId= 1931; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007480 -> { StationData.id= 60007480; name= "Trytedald VIII - Moon 20 - Joint Harvesting Plantation"; solarSystemId= 30002508; position= {x = -9.06618839e+11;  y = 1.704462336e+11;  z = -1.857822843e+12;}; typeId= 1930; services= [| "courier-missions"; "reprocessing-plant"; "market"; "fitting"; "news"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007771 -> { StationData.id= 60007771; name= "Akhragan V - Moon 1 - Amarr Civil Service Bureau Offices"; solarSystemId= 30002197; position= {x = -7.563251712e+10;  y = -1.213698048e+10;  z = -3.673471795e+11;}; typeId= 1926; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008062 -> { StationData.id= 60008062; name= "Fabum III - Ministry of Assessment Archives"; solarSystemId= 30003505; position= {x = -6.761877504e+10;  y = -8070144000.0;  z = -2.73784873e+11;}; typeId= 1931; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008353 -> { StationData.id= 60008353; name= "Imata VII - Amarr Trade Registry Archives"; solarSystemId= 30003094; position= {x = -7.651709338e+11;  y = 1.064240333e+11;  z = -1.05401684e+12;}; typeId= 1931; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008644 -> { StationData.id= 60008644; name= "Salah III - Kador Family Bureau"; solarSystemId= 30004146; position= {x = -7.859245056e+10;  y = -3345653760.0;  z = 2.728439808e+10;}; typeId= 1932; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008935 -> { StationData.id= 60008935; name= "Arshat VII - Moon 4 - Theology Council Law School"; solarSystemId= 30002253; position= {x = 7.273946726e+11;  y = -1.236852326e+11;  z = -7.433199206e+11;}; typeId= 1929; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009226 -> { StationData.id= 60009226; name= "Dantbeinn III - Moon 6 - TransStellar Shipping Storage"; solarSystemId= 30003451; position= {x = 2.257191322e+11;  y = 1.936134144e+10;  z = -2.142932582e+11;}; typeId= 3870; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009517 -> { StationData.id= 60009517; name= "Jurlesel II - Material Acquisition Refinery"; solarSystemId= 30003013; position= {x = 5.056843776e+10;  y = 8752865280.0;  z = -3.936301056e+10;}; typeId= 3867; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009808 -> { StationData.id= 60009808; name= "Mesybier VII - Combined Harvest Food Packaging"; solarSystemId= 30004975; position= {x = -9.685867315e+11;  y = -1.960106803e+11;  z = 1.659274445e+11;}; typeId= 3866; services= [| "courier-missions"; "reprocessing-plant"; "market"; "fitting"; "news"; "storage"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010099 -> { StationData.id= 60010099; name= "Arbaz VI - Moon 8 - Quafe Company Warehouse"; solarSystemId= 30003487; position= {x = -1.09466284e+12;  y = 3.191967744e+10;  z = 8.894092493e+11;}; typeId= 3870; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010390 -> { StationData.id= 60010390; name= "Elore V - Moon 4 - Allotek Industries Warehouse"; solarSystemId= 30003570; position= {x = 9.786445824e+10;  y = -1.321095168e+10;  z = -6.476192563e+11;}; typeId= 3870; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010681 -> { StationData.id= 60010681; name= "Vitrauze XI - Moon 8 - The Scope Development Studio"; solarSystemId= 30004991; position= {x = -5.083158528e+11;  y = -6590914560.0;  z = 2.378554122e+12;}; typeId= 56; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010972 -> { StationData.id= 60010972; name= "Isenan VIII - Moon 12 - FedMart Warehouse"; solarSystemId= 30005014; position= {x = 5.836781568e+11;  y = -5.138436096e+10;  z = -2.40363479e+11;}; typeId= 3870; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011263 -> { StationData.id= 60011263; name= "Jel VIII - Aliastra Retail Center"; solarSystemId= 30002692; position= {x = 1.570538988e+12;  y = -2.660232806e+11;  z = -1.547054408e+12;}; typeId= 57; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "fitting"; "paintshop"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011554 -> { StationData.id= 60011554; name= "Pucherie VI - Moon 18 - Garoun Investment Bank Vault"; solarSystemId= 30002733; position= {x = -7.556666573e+11;  y = 953425920.0;  z = 4.187762688e+10;}; typeId= 3868; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011845 -> { StationData.id= 60011845; name= "Caretyn VII - Moon 18 - Federation Navy Assembly Plant"; solarSystemId= 30002735; position= {x = 4.652365824e+11;  y = 7.910117376e+10;  z = -1.439328461e+12;}; typeId= 3867; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012136 -> { StationData.id= 60012136; name= "Dysa II - Ammatar Fleet Assembly Plant"; solarSystemId= 30000102; position= {x = -8.361086976e+10;  y = -2468782080.0;  z = -5.733101568e+10;}; typeId= 2498; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012427 -> { StationData.id= 60012427; name= "Egbinger V - CONCORD Treasury"; solarSystemId= 30002420; position= {x = 1.832933376e+11;  y = 3.675549696e+10;  z = 5.678665728e+10;}; typeId= 1530; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012718 -> { StationData.id= 60012718; name= "Vattuolen X - Moon 15 - Sisters of EVE Bureau"; solarSystemId= 30000173; position= {x = 6.021435802e+11;  y = -3.056652288e+10;  z = 2.068910531e+12;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013009 -> { StationData.id= 60013009; name= "Gelhan V - Moon 1 - DED Assembly Plant"; solarSystemId= 30000087; position= {x = -2.569129574e+11;  y = 3.873656832e+10;  z = 1.583909683e+11;}; typeId= 1927; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013300 -> { StationData.id= 60013300; name= "Goinard IV - Moon 5 - Impro Factory"; solarSystemId= 30002725; position= {x = -9.45459241e+11;  y = 4.213960704e+10;  z = 8.000577946e+11;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "refinery"; "market"; "black-market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "factory"; "labratory"; "gambling"; "fitting"; "paintshop"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013591 -> { StationData.id= 60013591; name= "1C-TD6 X - Moon 4 - Jove Navy Testing Facilities"; solarSystemId= 30001524; position= {x = 8.422574899e+11;  y = -2630983680.0;  z = 6.079317197e+11;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013882 -> { StationData.id= 60013882; name= "7-8XK0 VIII - Moon 5 - Prosper Depository"; solarSystemId= 30001608; position= {x = -7.758044774e+11;  y = -1.187919053e+11;  z = -9.029702861e+11;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014173 -> { StationData.id= 60014173; name= "6Y-0TW II - Moon 16 - True Creations Assembly Plant"; solarSystemId= 30001907; position= {x = -4.862488166e+11;  y = 7.196086272e+10;  z = -3.106828493e+12;}; typeId= 1927; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014464 -> { StationData.id= 60014464; name= "9-ERCP VII - Moon 9 - X-Sense Chemical Refinery"; solarSystemId= 30001484; position= {x = 9.715336397e+11;  y = 1.757974118e+11;  z = -5.652043776e+11;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014755 -> { StationData.id= 60014755; name= "Dumkirinur V - Republic Military School"; solarSystemId= 30002520; position= {x = -1.039919923e+11;  y = 1.23537408e+10;  z = 1.596721152e+11;}; typeId= 2500; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014949 -> { StationData.id= 60014949; name= "YZ9-F6 V - Blood Raiders Assembly Plant"; solarSystemId= 30004719; position= {x = -2.93673984e+11;  y = -4.311379968e+10;  z = 1.883970355e+11;}; typeId= 1927; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60015046 -> { StationData.id= 60015046; name= "Embod IV - Moon 10 - Pator Tech School"; solarSystemId= 30023410; position= {x = 5.116225536e+11;  y = 2112921600.0;  z = -2.729964749e+11;}; typeId= 2500; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60015143 -> { StationData.id= 60015143; name= "Aidart IV - Federal Defense Union Logistic Support"; solarSystemId= 30005307; position= {x = -1.437785702e+11;  y = -2.735837184e+10;  z = 1.472718029e+11;}; typeId= 3868; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | _ -> None