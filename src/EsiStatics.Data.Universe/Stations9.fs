﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stations9=
    let getStation id = 
      match id with 
      | 60000232 -> { StationData.id= 60000232; name= "Sinid VI - Moon 2 - CBD Corporation Storage"; solarSystemId= 30001729; position= {x = 9.811050086e+11;  y = -1.268742144e+11;  z = 4.297505587e+11;}; typeId= 1531; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60000523 -> { StationData.id= 60000523; name= "Nuken VII - Moon 20 - Hyasyoda Corporation Mining Outpost"; solarSystemId= 30000183; position= {x = -6.061669171e+11;  y = -5.289013248e+10;  z = 3.175458816e+11;}; typeId= 4023; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60000814 -> { StationData.id= 60000814; name= "Airkio III - Moon 1 - Minedrill Mineral Reserve"; solarSystemId= 30001404; position= {x = -4.778840064e+10;  y = 3139215360.0;  z = 1.393917542e+11;}; typeId= 4023; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001105 -> { StationData.id= 60001105; name= "Tongofur VIII - Kaalakiota Corporation Warehouse"; solarSystemId= 30002532; position= {x = -4.081607885e+11;  y = 7.242190848e+10;  z = -2.50716119e+11;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001396 -> { StationData.id= 60001396; name= "Vlillirier III - Moon 2 - Wiyrkomi Corporation Factory"; solarSystemId= 30003836; position= {x = -3497533440.0;  y = -685547520.0;  z = -1.85527296e+11;}; typeId= 4024; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001687 -> { StationData.id= 60001687; name= "Paara II - Caldari Steel Warehouse"; solarSystemId= 30002775; position= {x = -8.197656576e+10;  y = -3789004800.0;  z = -2.922074112e+10;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001978 -> { StationData.id= 60001978; name= "Tadadan VI - Nugoeihuvi Corporation Development Studio"; solarSystemId= 30005070; position= {x = 3.492346675e+11;  y = 6.503804928e+10;  z = -1.490088346e+11;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60002269 -> { StationData.id= 60002269; name= "Akkilen V - Moon 3 - Lai Dai Corporation Factory"; solarSystemId= 30000178; position= {x = -8.334938112e+10;  y = 1.058648064e+10;  z = 1.603622093e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "refinery"; "market"; "black-market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "factory"; "labratory"; "gambling"; "fitting"; "paintshop"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60002560 -> { StationData.id= 60002560; name= "Simbeloud VI - Expert Distribution Warehouse"; solarSystemId= 30002195; position= {x = 3.635093914e+11;  y = -2.632568832e+10;  z = -8.735551488e+10;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60002851 -> { StationData.id= 60002851; name= "Silen III - Moon 15 - Sukuuvestaa Corporation Production Plant"; solarSystemId= 30000179; position= {x = -5.692041216e+11;  y = -3.551760384e+10;  z = 1.230047232e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003142 -> { StationData.id= 60003142; name= "Maila III - Moon 1 - Caldari Funds Unlimited Depository"; solarSystemId= 30000162; position= {x = -1.836580454e+11;  y = -1.471475712e+10;  z = 1.400844288e+10;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003433 -> { StationData.id= 60003433; name= "Kamokor VII - Moon 1 - Mercantile Club Bureau"; solarSystemId= 30001406; position= {x = -6.452393165e+11;  y = 8.235503616e+10;  z = 2.733320233e+12;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003724 -> { StationData.id= 60003724; name= "New Caldari V (Oniteseru) - Moon 2 - House of Records Archives"; solarSystemId= 30000145; position= {x = -1.438275871e+12;  y = 4.150407168e+10;  z = -5.020376678e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004015 -> { StationData.id= 60004015; name= "Isikemi V - Home Guard Assembly Plant"; solarSystemId= 30001365; position= {x = -3.208481587e+11;  y = -3.250876416e+10;  z = -8.509114368e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004306 -> { StationData.id= 60004306; name= "Kusomonmon VI - Moon 23 - Corporate Police Force Testing Facilities"; solarSystemId= 30002802; position= {x = -1.118785905e+12;  y = -6.498521088e+10;  z = -4.047387156e+12;}; typeId= 54; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004597 -> { StationData.id= 60004597; name= "Amamake VI - Moon 6 - Brutor Tribe Bureau"; solarSystemId= 30002537; position= {x = -4.424946893e+11;  y = -5.87839488e+10;  z = 1.019237622e+12;}; typeId= 2502; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004888 -> { StationData.id= 60004888; name= "Ardar V - Moon 2 - Republic Fleet Logistic Support"; solarSystemId= 30002058; position= {x = 8.636511437e+11;  y = 1.249049395e+11;  z = 5.00101079e+11;}; typeId= 2501; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005179 -> { StationData.id= 60005179; name= "Neesher VI - Moon 15 - Republic Security Services Assembly Plant"; solarSystemId= 30005058; position= {x = 1.282967101e+12;  y = -2.351228928e+11;  z = 4.663550362e+11;}; typeId= 2498; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005470 -> { StationData.id= 60005470; name= "Ahala VIII - Core Complexion Inc. Warehouse"; solarSystemId= 30002247; position= {x = 2.215735296e+10;  y = -3240468480.0;  z = 1.492769219e+12;}; typeId= 2501; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005761 -> { StationData.id= 60005761; name= "Gelfiven V - Native Freshfood Warehouse"; solarSystemId= 30002386; position= {x = -1.600985088e+11;  y = 1.905119232e+10;  z = -7.088812032e+10;}; typeId= 2501; services= [| "courier-missions"; "reprocessing-plant"; "market"; "fitting"; "news"; "storage"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006052 -> { StationData.id= 60006052; name= "Eddar VIII - Moon 8 - The Leisure Group Development Studio"; solarSystemId= 30002552; position= {x = -2.051793592e+12;  y = -3.910176768e+10;  z = -5.310973133e+11;}; typeId= 2496; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006343 -> { StationData.id= 60006343; name= "Namaili VII - Moon 2 - Carthum Conglomerate Warehouse"; solarSystemId= 30003534; position= {x = -3.602272051e+12;  y = 1.589736653e+11;  z = 5.048045568e+10;}; typeId= 1929; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006634 -> { StationData.id= 60006634; name= "Sigga VIII - Moon 4 - Zoar and Sons Factory"; solarSystemId= 30005219; position= {x = -1.145632236e+12;  y = -1.020824371e+11;  z = -2.795531059e+11;}; typeId= 1928; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006925 -> { StationData.id= 60006925; name= "Pedel IV - Moon 1 - HZO Refinery Mining Outpost"; solarSystemId= 30003516; position= {x = 2.476288819e+11;  y = 7675944960.0;  z = -1.842527846e+11;}; typeId= 1930; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007216 -> { StationData.id= 60007216; name= "Uhodoh VI - Moon 1 - Amarr Certified News Development Studio"; solarSystemId= 30001735; position= {x = 4.385384448e+11;  y = -943104000.0;  z = 5.858361754e+11;}; typeId= 1931; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007507 -> { StationData.id= 60007507; name= "Uchoshi X - Moon 1 - Joint Harvesting Mineral Reserve"; solarSystemId= 30000201; position= {x = -1.050868408e+12;  y = -2.127191654e+11;  z = -1.055850086e+11;}; typeId= 1929; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007798 -> { StationData.id= 60007798; name= "Djimame VIII - Moon 2 - Amarr Civil Service Bureau Offices"; solarSystemId= 30005262; position= {x = -2.962457518e+12;  y = -5.380987699e+11;  z = 3.486010982e+11;}; typeId= 1926; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008089 -> { StationData.id= 60008089; name= "Bika VII - Moon 3 - Ministry of Assessment Bureau Offices"; solarSystemId= 30002252; position= {x = 6.610446336e+11;  y = -1.077695693e+11;  z = 2.769689395e+11;}; typeId= 1926; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008380 -> { StationData.id= 60008380; name= "Kenahehab VII - Moon 4 - Amarr Navy Assembly Plant"; solarSystemId= 30004237; position= {x = 3.489400013e+11;  y = 3.060854784e+10;  z = 1.209964339e+12;}; typeId= 1927; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008671 -> { StationData.id= 60008671; name= "Nakri V - Moon 5 - Sarum Family Assembly Plant"; solarSystemId= 30003496; position= {x = -1.547632435e+12;  y = 1.246542643e+11;  z = 2.723661005e+11;}; typeId= 1927; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008962 -> { StationData.id= 60008962; name= "Kothe VI - Moon 15 - Theology Council Accounting"; solarSystemId= 30004103; position= {x = 8.328646656e+10;  y = -1.195610112e+10;  z = -7.640328192e+11;}; typeId= 1931; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009253 -> { StationData.id= 60009253; name= "RSS-KA VIII - Moon 19 - TransStellar Shipping Storage"; solarSystemId= 30003362; position= {x = -2.879556772e+12;  y = -4.426994074e+11;  z = -8.009576448e+10;}; typeId= 3870; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009544 -> { StationData.id= 60009544; name= "Babirmoult VI - Moon 15 - Material Acquisition Mineral Reserve"; solarSystemId= 30003601; position= {x = -1.498323763e+11;  y = -2.413768704e+10;  z = -8.024650138e+11;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009835 -> { StationData.id= 60009835; name= "Chardalane III - Moon 2 - Combined Harvest Plantation"; solarSystemId= 30003834; position= {x = 7.983550464e+10;  y = 1.566093312e+10;  z = -1.606937395e+11;}; typeId= 3866; services= [| "courier-missions"; "reprocessing-plant"; "market"; "fitting"; "news"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010126 -> { StationData.id= 60010126; name= "Avele V - Moon 11 - CreoDron Warehouse"; solarSystemId= 30003053; position= {x = 5.38064855e+11;  y = -5.504618496e+10;  z = 3.50840832e+10;}; typeId= 3870; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010417 -> { StationData.id= 60010417; name= "Floseswin VI - Moon 2 - Poteque Pharmaceuticals Biotech Production"; solarSystemId= 30002082; position= {x = -1.08646441e+11;  y = -3563642880.0;  z = -2.799060173e+11;}; typeId= 3867; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "dna-therapy"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010708 -> { StationData.id= 60010708; name= "Kizama V - Moon 3 - The Scope Development Studio"; solarSystemId= 30005056; position= {x = -2.937973555e+11;  y = -4.887343104e+10;  z = -7.137380352e+11;}; typeId= 56; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010999 -> { StationData.id= 60010999; name= "Archavoinet III - Moon 1 - FedMart Storage"; solarSystemId= 30003824; position= {x = -8.09023488e+10;  y = -2686525440.0;  z = -3.239519478e+12;}; typeId= 3870; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011290 -> { StationData.id= 60011290; name= "Anher V - Moon 8 - Aliastra Retail Center"; solarSystemId= 30002051; position= {x = -3.323947008e+11;  y = 6.078615552e+10;  z = -1.623862886e+11;}; typeId= 57; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "fitting"; "paintshop"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011581 -> { StationData.id= 60011581; name= "Eletta VIII - Moon 19 - University of Caille"; solarSystemId= 30005315; position= {x = 1.134366597e+12;  y = -2.182119014e+11;  z = 5.976502272e+10;}; typeId= 57; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011872 -> { StationData.id= 60011872; name= "Aunia I - Moon 11 - Federation Navy Assembly Plant"; solarSystemId= 30002657; position= {x = -1.183745434e+12;  y = 1.93293312e+11;  z = -1.596023194e+11;}; typeId= 3867; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012163 -> { StationData.id= 60012163; name= "Faspera I - Ammatar Fleet Testing Facilities"; solarSystemId= 30000044; position= {x = -4023459840.0;  y = -626073600.0;  z = 6.74064384e+10;}; typeId= 2500; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012454 -> { StationData.id= 60012454; name= "Half VII - Moon 1 - CONCORD Bureau"; solarSystemId= 30002404; position= {x = 2.113841971e+11;  y = 1.842180096e+10;  z = 3.775833293e+11;}; typeId= 56; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012745 -> { StationData.id= 60012745; name= "G-G78S VII - Salvation Angels Chemical Refinery"; solarSystemId= 30001002; position= {x = -8.598441984e+10;  y = 5218099200.0;  z = 2.213060198e+11;}; typeId= 1928; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013036 -> { StationData.id= 60013036; name= "Tividu IV - Moon 3 - DED Assembly Plant"; solarSystemId= 30001644; position= {x = -4.687158067e+11;  y = 2647449600.0;  z = -2.498404762e+11;}; typeId= 1927; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013327 -> { StationData.id= 60013327; name= "Inghenges VI - Moon 4 - Impro Factory"; solarSystemId= 30002672; position= {x = -7.6076544e+11;  y = 1.348820582e+11;  z = 2.177837752e+12;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "refinery"; "market"; "black-market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "factory"; "labratory"; "gambling"; "fitting"; "paintshop"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013618 -> { StationData.id= 60013618; name= "8-ULAA VI - Moon 13 - Jove Navy Testing Facilities"; solarSystemId= 30001514; position= {x = -3.834995098e+11;  y = -2.974715904e+10;  z = 4.940824166e+11;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013909 -> { StationData.id= 60013909; name= "J-JS0D VIII - Moon 15 - Prosper Vault"; solarSystemId= 30001505; position= {x = 6.199476634e+11;  y = 5.281861632e+10;  z = 8.784603955e+11;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014200 -> { StationData.id= 60014200; name= "0T-LIB V - Moon 6 - True Creations Testing Facilities"; solarSystemId= 30001961; position= {x = 7.1089152e+10;  y = 1.035251712e+10;  z = -2.667372134e+11;}; typeId= 54; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014491 -> { StationData.id= 60014491; name= "Masalle VIII - Moon 1 - X-Sense Chemical Refinery"; solarSystemId= 30005325; position= {x = -1.218054021e+12;  y = -1.259236147e+11;  z = -3.802549985e+12;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014782 -> { StationData.id= 60014782; name= "Illuin V - Moon 13 - Republic University"; solarSystemId= 30003377; position= {x = 2.180442931e+11;  y = 2.752499712e+10;  z = -1.162985841e+12;}; typeId= 2500; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60015073 -> { StationData.id= 60015073; name= "Nisuwa VII - State Protectorate Logistic Support"; solarSystemId= 30045352; position= {x = -1.660161638e+11;  y = -2.386661376e+10;  z = -9.614621491e+11;}; typeId= 1530; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | _ -> None