﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stations82=
    let getStation id = 
      match id with 
      | 60000208 -> { StationData.id= 60000208; name= "Ami V - Moon 1 - CBD Corporation Storage"; solarSystemId= 30005035; position= {x = 1.575679181e+11;  y = -1332879360.0;  z = 1.431474586e+11;}; typeId= 1531; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60000499 -> { StationData.id= 60000499; name= "Eruka VIII - Moon 18 - Hyasyoda Corporation Mining Outpost"; solarSystemId= 30000203; position= {x = 5.866501325e+11;  y = 7.712894976e+10;  z = -1.465714975e+12;}; typeId= 4023; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60000790 -> { StationData.id= 60000790; name= "Hentogaira II - Moon 6 - Minedrill Refinery"; solarSystemId= 30000188; position= {x = 5.181912269e+11;  y = -4.40752128e+10;  z = -1.727346156e+12;}; typeId= 4024; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001081 -> { StationData.id= 60001081; name= "Tividu III - Kaalakiota Corporation Factory"; solarSystemId= 30001644; position= {x = -7.906185216e+10;  y = 446177280.0;  z = 2.340081254e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "refinery"; "market"; "black-market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "factory"; "labratory"; "gambling"; "fitting"; "paintshop"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001372 -> { StationData.id= 60001372; name= "Groothese X - Moon 11 - Wiyrkomi Corporation Factory"; solarSystemId= 30003057; position= {x = -6.847943885e+11;  y = -2.31499776e+10;  z = 7.542894182e+11;}; typeId= 4024; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001663 -> { StationData.id= 60001663; name= "Iidoken VIII - Caldari Steel Factory"; solarSystemId= 30001374; position= {x = 1.4490146e+12;  y = -5.811720192e+10;  z = 6.79338025e+11;}; typeId= 4024; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001954 -> { StationData.id= 60001954; name= "Scolluzer VIII - Moon 10 - Nugoeihuvi Corporation Publisher"; solarSystemId= 30005322; position= {x = -1.04194007e+11;  y = 1.027289088e+10;  z = -1.030230467e+12;}; typeId= 3872; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60002245 -> { StationData.id= 60002245; name= "Airkio VII - Moon 3 - Lai Dai Corporation Factory"; solarSystemId= 30001404; position= {x = -6.720863846e+11;  y = 4.41489408e+10;  z = 3.796187136e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "refinery"; "market"; "black-market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "factory"; "labratory"; "gambling"; "fitting"; "paintshop"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60002536 -> { StationData.id= 60002536; name= "Anher VII - Moon 3 - Expert Distribution Retail Center"; solarSystemId= 30002051; position= {x = 4.744530739e+11;  y = -8.676421632e+10;  z = -3.486523269e+12;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "fitting"; "paintshop"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60002827 -> { StationData.id= 60002827; name= "Suroken V - Moon 2 - Sukuuvestaa Corporation Production Plant"; solarSystemId= 30002801; position= {x = -1.080214733e+11;  y = -1.65230592e+10;  z = -9.71077632e+10;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003118 -> { StationData.id= 60003118; name= "Santola IV - Moon 1 - Expert Housing Production Plant"; solarSystemId= 30002785; position= {x = 1.13674199e+11;  y = 1.204998144e+10;  z = 1.195353293e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003409 -> { StationData.id= 60003409; name= "Aikantoh I - Moon 1 - Mercantile Club Academy"; solarSystemId= 30001418; position= {x = 6.258855936e+10;  y = 4582072320.0;  z = -5.037060096e+10;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003700 -> { StationData.id= 60003700; name= "Jesoyeh VIII - Moon 8 - Caldari Business Tribunal Archives"; solarSystemId= 30003532; position= {x = -1.990202573e+11;  y = 3236782080.0;  z = 4.192905216e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003991 -> { StationData.id= 60003991; name= "Daras III - Ishukone Watch Assembly Plant"; solarSystemId= 30001420; position= {x = 2.874445824e+10;  y = 2049761280.0;  z = -1.228066406e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004282 -> { StationData.id= 60004282; name= "Arvasaras II - Moon 3 - Wiyrkomi Peace Corps Testing Facilities"; solarSystemId= 30001381; position= {x = -7.177310208e+10;  y = -1.064767488e+10;  z = -1.847914906e+11;}; typeId= 54; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004573 -> { StationData.id= 60004573; name= "Eldulf V - Moon 6 - Vherokior Tribe Academy"; solarSystemId= 30002398; position= {x = 8.455582925e+11;  y = 7.46108928e+10;  z = 5.540328653e+11;}; typeId= 2502; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004864 -> { StationData.id= 60004864; name= "Ofstold V - Moon 13 - Republic Fleet Logistic Support"; solarSystemId= 30002061; position= {x = 2.403413606e+11;  y = 4.476506112e+10;  z = 6.078496358e+11;}; typeId= 2501; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005155 -> { StationData.id= 60005155; name= "Scolluzer XI - Republic Security Services Assembly Plant"; solarSystemId= 30005322; position= {x = -2.914124882e+12;  y = 2.87313961e+11;  z = 9.888899482e+11;}; typeId= 2498; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005446 -> { StationData.id= 60005446; name= "Pain VI - Core Complexion Inc. Storage"; solarSystemId= 30003804; position= {x = 6.44241322e+12;  y = -1.365343027e+11;  z = 1.056022057e+13;}; typeId= 2501; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005737 -> { StationData.id= 60005737; name= "Lustrevik VII - Moon 7 - Six Kin Development Warehouse"; solarSystemId= 30002545; position= {x = 1.306248192e+12;  y = 4.630106112e+10;  z = 9.914781696e+10;}; typeId= 2501; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006028 -> { StationData.id= 60006028; name= "Aset II - Moon 1 - Freedom Extension Storage"; solarSystemId= 30002084; position= {x = 1.282412544e+10;  y = -793927680.0;  z = -1.445224858e+11;}; typeId= 2501; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006319 -> { StationData.id= 60006319; name= "Shabura VI - Moon 10 - Carthum Conglomerate Warehouse"; solarSystemId= 30002267; position= {x = 3.092492698e+11;  y = -5.10425088e+10;  z = -4.006181683e+11;}; typeId= 1929; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006610 -> { StationData.id= 60006610; name= "Esa VIII - Moon 2 - Viziam Warehouse"; solarSystemId= 30001736; position= {x = 2.797092987e+12;  y = 2.8603392e+10;  z = -2.69620224e+11;}; typeId= 1929; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006901 -> { StationData.id= 60006901; name= "Gererique II - Moon 1 - Ducia Foundry Mining Outpost"; solarSystemId= 30003586; position= {x = -1.548979814e+11;  y = -2.275209216e+10;  z = -6.66630144e+10;}; typeId= 1930; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007192 -> { StationData.id= 60007192; name= "Malma VII - Amarr Certified News Development Studio"; solarSystemId= 30005235; position= {x = -6.747533722e+11;  y = -1.32375552e+11;  z = -8.605913088e+10;}; typeId= 1931; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007483 -> { StationData.id= 60007483; name= "Trytedald VIII - Moon 23 - Joint Harvesting Plantation"; solarSystemId= 30002508; position= {x = -9.211540685e+11;  y = 1.73176873e+11;  z = -1.860320993e+12;}; typeId= 1930; services= [| "courier-missions"; "reprocessing-plant"; "market"; "fitting"; "news"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007774 -> { StationData.id= 60007774; name= "Ziona VI - Moon 8 - Amarr Civil Service Bureau Offices"; solarSystemId= 30002203; position= {x = 2.458087834e+11;  y = 1.589194752e+10;  z = 2.692837786e+11;}; typeId= 1926; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008065 -> { StationData.id= 60008065; name= "Bahromab IX - Moon 4 - Ministry of Assessment Information Center"; solarSystemId= 30003502; position= {x = 1.360601702e+12;  y = -1.727563776e+11;  z = 1.221764014e+12;}; typeId= 1926; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008356 -> { StationData.id= 60008356; name= "Nasreri V - Moon 4 - Amarr Trade Registry Information Center"; solarSystemId= 30005289; position= {x = 1.223183155e+11;  y = 2456494080.0;  z = -2.526876058e+11;}; typeId= 1926; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008647 -> { StationData.id= 60008647; name= "Akhmoh VII - Moon 6 - Kador Family Academy"; solarSystemId= 30004147; position= {x = -1.914310287e+12;  y = 3.578878771e+11;  z = -1.108761108e+12;}; typeId= 1932; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008938 -> { StationData.id= 60008938; name= "Ashab VIII - Moon 10 - Theology Council Tribunal"; solarSystemId= 30003491; position= {x = -6.428002836e+12;  y = -6.258866995e+11;  z = 4.084042752e+12;}; typeId= 1929; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009229 -> { StationData.id= 60009229; name= "Hakeri III - TransStellar Shipping Storage"; solarSystemId= 30003449; position= {x = 9.065189376e+10;  y = 4835696640.0;  z = 9050972160.0;}; typeId= 3870; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009520 -> { StationData.id= 60009520; name= "Bereye VI - Moon 2 - Material Acquisition Refinery"; solarSystemId= 30003014; position= {x = 2.031562752e+10;  y = 2138726400.0;  z = -8.990752358e+11;}; typeId= 3867; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009811 -> { StationData.id= 60009811; name= "Caslemon IX - Moon 16 - Combined Harvest Warehouse"; solarSystemId= 30004973; position= {x = 9.75817728e+11;  y = 9.038770176e+10;  z = -3.337530163e+11;}; typeId= 3870; services= [| "courier-missions"; "reprocessing-plant"; "market"; "fitting"; "news"; "storage"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010102 -> { StationData.id= 60010102; name= "Annaro VIII - Moon 4 - Quafe Company Factory"; solarSystemId= 30002776; position= {x = 6.328896307e+11;  y = 9.23682816e+10;  z = -7.284536525e+11;}; typeId= 3867; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010393 -> { StationData.id= 60010393; name= "Anckee V - Moon 10 - Allotek Industries Factory"; solarSystemId= 30003571; position= {x = 1.336215429e+12;  y = -1.424467968e+11;  z = -3.438096384e+10;}; typeId= 3867; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010684 -> { StationData.id= 60010684; name= "Heorah VI - Moon 17 - The Scope Development Studio"; solarSystemId= 30005290; position= {x = 5407088640.0;  y = 879697920.0;  z = -2.482789294e+12;}; typeId= 56; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010975 -> { StationData.id= 60010975; name= "Allebin VI - FedMart Warehouse"; solarSystemId= 30005009; position= {x = 1.660719514e+11;  y = 2.881572864e+10;  z = -5.555440435e+11;}; typeId= 3870; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011266 -> { StationData.id= 60011266; name= "Ation VI - Aliastra Warehouse"; solarSystemId= 30002695; position= {x = -1.620535296e+11;  y = 1.80504576e+10;  z = -1.454775091e+11;}; typeId= 3870; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011557 -> { StationData.id= 60011557; name= "Pucherie VI - Moon 2 - Garoun Investment Bank Vault"; solarSystemId= 30002733; position= {x = -7.528441037e+11;  y = 949493760.0;  z = 3.599659008e+10;}; typeId= 3868; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011848 -> { StationData.id= 60011848; name= "Vittenyn VI - Moon 13 - Federation Navy Assembly Plant"; solarSystemId= 30002731; position= {x = -2.191892275e+12;  y = -3.597989069e+11;  z = 1.887263908e+12;}; typeId= 3867; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012139 -> { StationData.id= 60012139; name= "Serad IV - Moon 12 - Ammatar Fleet Logistic Support"; solarSystemId= 30000103; position= {x = 2.170023567e+12;  y = -6.924619776e+10;  z = -1.285030748e+12;}; typeId= 2501; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012430 -> { StationData.id= 60012430; name= "Klingt VIII - CONCORD Logistic Support"; solarSystemId= 30002414; position= {x = -1.110013133e+11;  y = 2.091036672e+10;  z = -5.944731648e+11;}; typeId= 3868; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012721 -> { StationData.id= 60012721; name= "Rens VII - Moon 20 - Sisters of EVE Bureau"; solarSystemId= 30002510; position= {x = 8.188965274e+11;  y = -8.382173184e+10;  z = -1.161729516e+12;}; typeId= 2502; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013012 -> { StationData.id= 60013012; name= "Asghatil IX - Moon 3 - DED Assembly Plant"; solarSystemId= 30000084; position= {x = -1.612042936e+12;  y = -8.25157632e+10;  z = 4.031984026e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013303 -> { StationData.id= 60013303; name= "Assiettes IV - Impro Factory"; solarSystemId= 30002724; position= {x = -5.109884928e+11;  y = 9.57192192e+10;  z = 1.979425997e+11;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "refinery"; "market"; "black-market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "factory"; "labratory"; "gambling"; "fitting"; "paintshop"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013594 -> { StationData.id= 60013594; name= "TO21-U VIII - Moon 1 - Jove Navy Assembly Plant"; solarSystemId= 30001519; position= {x = -5.337038438e+11;  y = 8.199892992e+10;  z = 9.53588736e+11;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013885 -> { StationData.id= 60013885; name= "0M-M64 VI - Prosper Depository"; solarSystemId= 30001521; position= {x = 2.195360563e+11;  y = 2.239229952e+10;  z = 3.741915955e+11;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014176 -> { StationData.id= 60014176; name= "UF-KKH III - Moon 4 - True Creations Shipyard"; solarSystemId= 30001854; position= {x = 9.285175296e+11;  y = 6.968930304e+10;  z = -8.455681229e+11;}; typeId= 1530; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "paintshop"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014467 -> { StationData.id= 60014467; name= "KN7M-N V - Moon 17 - X-Sense Reprocessing Facility"; solarSystemId= 30001485; position= {x = -3.687521894e+11;  y = -2.309689344e+10;  z = 1.900317942e+12;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014758 -> { StationData.id= 60014758; name= "Dudreda VI - Moon 4 - Republic Military School"; solarSystemId= 30002076; position= {x = -2.464002908e+12;  y = 2.004687667e+11;  z = 1.415849288e+12;}; typeId= 2500; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014952 -> { StationData.id= 60014952; name= "I3Q-II VII - Moon 2 - Blood Raiders Assembly Plant"; solarSystemId= 30004723; position= {x = -3.719614464e+10;  y = -5844541440.0;  z = 5.094313574e+11;}; typeId= 1927; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60015049 -> { StationData.id= 60015049; name= "Synchelle I - Federal Navy Academy"; solarSystemId= 30005015; position= {x = -3.357806592e+10;  y = 114155520.0;  z = -9057607680.0;}; typeId= 56; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60015146 -> { StationData.id= 60015146; name= "Tintoh VIII - Caldari Navy Testing Facilities"; solarSystemId= 30002784; position= {x = 2.199749222e+12;  y = -1.475219866e+11;  z = 3.364438426e+11;}; typeId= 54; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | _ -> None