﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stations30=
    let getStation id = 
      match id with 
      | 60000253 -> { StationData.id= 60000253; name= "Suner VII - Moon 16 - CBD Corporation Storage"; solarSystemId= 30004101; position= {x = 2.181223096e+12;  y = -1.104777216e+10;  z = 1.756483215e+12;}; typeId= 1531; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60000544 -> { StationData.id= 60000544; name= "Iivinen X - Moon 10 - Hyasyoda Corporation Mineral Reserve"; solarSystemId= 30002766; position= {x = 1.706836992e+12;  y = -2.866712986e+11;  z = 3.55187454e+12;}; typeId= 4023; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60000835 -> { StationData.id= 60000835; name= "Aramachi VI - Moon 4 - Minedrill Mining Outpost"; solarSystemId= 30002817; position= {x = -1.213488538e+12;  y = -9.008001024e+10;  z = 2.867850854e+11;}; typeId= 4023; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001126 -> { StationData.id= 60001126; name= "Getrenjesa IX - Moon 1 - Kaalakiota Corporation Factory"; solarSystemId= 30004282; position= {x = 371957760.0;  y = 34775040.0;  z = -2.2720179e+12;}; typeId= 4024; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001417 -> { StationData.id= 60001417; name= "Bordan VII - Moon 11 - Wiyrkomi Corporation Factory"; solarSystemId= 30004106; position= {x = 1.463340442e+12;  y = -1.163763302e+11;  z = 1.967099904e+10;}; typeId= 4024; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001708 -> { StationData.id= 60001708; name= "Vaajaita III - Caldari Steel Factory"; solarSystemId= 30001383; position= {x = -8.26988544e+10;  y = -8830033920.0;  z = 2.57916887e+11;}; typeId= 4024; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001999 -> { StationData.id= 60001999; name= "Hakisalki VIII - Moon 14 - Nugoeihuvi Corporation Development Studio"; solarSystemId= 30002077; position= {x = -9.442756608e+11;  y = -1.875501466e+11;  z = -1.819180646e+11;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60002290 -> { StationData.id= 60002290; name= "Otitoh IV - Moon 1 - Lai Dai Corporation Factory"; solarSystemId= 30000171; position= {x = -1.417962701e+11;  y = 2.099712e+10;  z = 2.727481344e+10;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "refinery"; "market"; "black-market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "factory"; "labratory"; "gambling"; "fitting"; "paintshop"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60002581 -> { StationData.id= 60002581; name= "Imih III - Moon 9 - Expert Distribution Warehouse"; solarSystemId= 30005053; position= {x = 4.327168819e+11;  y = -7.857795072e+10;  z = -1.317965783e+12;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60002872 -> { StationData.id= 60002872; name= "Yashunen VII - Sukuuvestaa Corporation Warehouse"; solarSystemId= 30002762; position= {x = -7.909804032e+11;  y = 8.553762816e+10;  z = -1.524157686e+12;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003163 -> { StationData.id= 60003163; name= "Kaimon III - Moon 15 - Caldari Funds Unlimited Depository"; solarSystemId= 30002751; position= {x = -2.535184097e+12;  y = 3.940716134e+11;  z = -4.171610235e+12;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003454 -> { StationData.id= 60003454; name= "Maurasi VIII - Moon 14 - Caldari Business Tribunal"; solarSystemId= 30000140; position= {x = -5.76101376e+11;  y = -6.271709184e+10;  z = -9.08544e+10;}; typeId= 1530; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003745 -> { StationData.id= 60003745; name= "Kirras IX - House of Records Information Center"; solarSystemId= 30001410; position= {x = 1.552260342e+12;  y = 2.794346496e+11;  z = -7.953681162e+12;}; typeId= 3872; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004036 -> { StationData.id= 60004036; name= "Torrinos V - Moon 6 - Home Guard Assembly Plant"; solarSystemId= 30001429; position= {x = 2.407318733e+11;  y = 9545932800.0;  z = 7.453663642e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004327 -> { StationData.id= 60004327; name= "Kaimon II - Moon 10 - Corporate Police Force Assembly Plant"; solarSystemId= 30002751; position= {x = 1.316860355e+12;  y = -2.047007539e+11;  z = 8.418089779e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004618 -> { StationData.id= 60004618; name= "Ivar IX - Moon 4 - Brutor Tribe Bureau"; solarSystemId= 30002524; position= {x = 2.385776271e+12;  y = 3.343632384e+11;  z = -5.015370547e+11;}; typeId= 2502; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004909 -> { StationData.id= 60004909; name= "Hrober VII - Moon 5 - Republic Fleet Testing Facilities"; solarSystemId= 30002392; position= {x = 3.132475392e+11;  y = 7206789120.0;  z = 9.881885491e+11;}; typeId= 2500; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005200 -> { StationData.id= 60005200; name= "Tannolen VI - Moon 14 - Republic Security Services Testing Facilities"; solarSystemId= 30002812; position= {x = -4.703203738e+11;  y = -7.046885376e+10;  z = -2.437367808e+11;}; typeId= 2500; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005491 -> { StationData.id= 60005491; name= "Shapisin VII - Moon 2 - Core Complexion Inc. Factory"; solarSystemId= 30005271; position= {x = -1.084893635e+12;  y = -1.814840525e+11;  z = 8.40886272e+10;}; typeId= 2497; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005782 -> { StationData.id= 60005782; name= "Hagilur V - Moon 7 - Freedom Extension Warehouse"; solarSystemId= 30002050; position= {x = 1.542663168e+12;  y = 2.867226624e+11;  z = -7.017692774e+11;}; typeId= 2501; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006073 -> { StationData.id= 60006073; name= "Oddelulf VII - Moon 1 - The Leisure Group Development Studio"; solarSystemId= 30002388; position= {x = 1.036509389e+12;  y = -9.261920256e+10;  z = -3.869538017e+12;}; typeId= 2496; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006364 -> { StationData.id= 60006364; name= "Myyhera V - Moon 1 - Carthum Conglomerate Factory"; solarSystemId= 30003075; position= {x = -2.631100416e+11;  y = -2.76473856e+10;  z = -1.258911744e+11;}; typeId= 1928; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "refinery"; "market"; "black-market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "factory"; "labratory"; "gambling"; "fitting"; "paintshop"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006655 -> { StationData.id= 60006655; name= "Ziriert VIII - Moon 3 - Zoar and Sons Factory"; solarSystemId= 30003562; position= {x = -6711582720.0;  y = -79994880.0;  z = -1.312465428e+12;}; typeId= 1928; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006946 -> { StationData.id= 60006946; name= "Kador Prime VIII - Moon 3 - Inherent Implants Biotech Production"; solarSystemId= 30004095; position= {x = -1.246683095e+12;  y = 1.600105267e+11;  z = 1.816654234e+11;}; typeId= 1928; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "dna-therapy"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007237 -> { StationData.id= 60007237; name= "Ilas IX - Moon 4 - Amarr Certified News Development Studio"; solarSystemId= 30001731; position= {x = -2.034504131e+12;  y = 3.738145997e+11;  z = 1.805472768e+12;}; typeId= 1931; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007528 -> { StationData.id= 60007528; name= "Sieh III - Moon 13 - Nurtura Plantation"; solarSystemId= 30003557; position= {x = 1.881978102e+12;  y = 2.501548032e+11;  z = 2.936479703e+12;}; typeId= 1930; services= [| "courier-missions"; "reprocessing-plant"; "market"; "fitting"; "news"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007819 -> { StationData.id= 60007819; name= "Kor-Azor Prime V - Moon 2 - Amarr Civil Service Bureau Offices"; solarSystemId= 30005038; position= {x = -1.526564905e+12;  y = -5.527867392e+10;  z = 1.093471887e+12;}; typeId= 1926; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008110 -> { StationData.id= 60008110; name= "Uusanen IV - Moon 1 - Ministry of Assessment Information Center"; solarSystemId= 30003077; position= {x = 2.929809408e+11;  y = 3.120427008e+10;  z = -5.379237888e+11;}; typeId= 1926; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008401 -> { StationData.id= 60008401; name= "Pashanai III - Moon 2 - Amarr Navy Assembly Plant"; solarSystemId= 30005231; position= {x = -8.316235776e+10;  y = 5251768320.0;  z = -3.832999526e+11;}; typeId= 1927; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008692 -> { StationData.id= 60008692; name= "Kor-Azor Prime II - Kor-Azor Family Bureau"; solarSystemId= 30005038; position= {x = -1.462951526e+11;  y = -5297725440.0;  z = 1.402381517e+11;}; typeId= 1932; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008983 -> { StationData.id= 60008983; name= "Hostni VII - Moon 14 - Theology Council Tribunal"; solarSystemId= 30001690; position= {x = 3.508355359e+12;  y = -2.857317581e+11;  z = -6.174069965e+11;}; typeId= 1929; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009274 -> { StationData.id= 60009274; name= "Sorzielang VII - Moon 1 - TransStellar Shipping Storage"; solarSystemId= 30003510; position= {x = 1.018616095e+12;  y = 1.138710528e+11;  z = 2.76758569e+11;}; typeId= 3870; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009565 -> { StationData.id= 60009565; name= "Vaere VIII - Moon 11 - Astral Mining Inc. Mineral Reserve"; solarSystemId= 30005306; position= {x = 9.263763456e+10;  y = -7865180160.0;  z = -1.185290527e+12;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009856 -> { StationData.id= 60009856; name= "Ardallabier VII - Moon 3 - Quafe Company Warehouse"; solarSystemId= 30003030; position= {x = 4.010268303e+12;  y = 4.47162409e+11;  z = 1.691917148e+12;}; typeId= 3870; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010147 -> { StationData.id= 60010147; name= "Hakeri XI - Moon 5 - CreoDron Factory"; solarSystemId= 30003449; position= {x = -1.522366095e+12;  y = -8.120242176e+10;  z = 1.382115041e+12;}; typeId= 3867; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010438 -> { StationData.id= 60010438; name= "Nani V - Moon 18 - Svarog Clade Bioadaptation Chambers"; solarSystemId= 30001413; position= {x = -1.935938888e+12;  y = -1.611746918e+11;  z = 1.613542564e+12;}; typeId= 3869; services= [| "reprocessing-plant"; "market"; "cloning"; "repair-facilities"; "factory"; "fitting"; "paintshop"; "news"; "storage"; "docking"; "office-rental"; "jump-clone-facility"; "loyalty-point-store" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010729 -> { StationData.id= 60010729; name= "Unel IX - Chemal Tech Factory"; solarSystemId= 30002707; position= {x = 3.957344379e+12;  y = -4.748310528e+11;  z = 3.06003284e+12;}; typeId= 3867; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "refinery"; "market"; "black-market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "factory"; "labratory"; "gambling"; "fitting"; "paintshop"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011020 -> { StationData.id= 60011020; name= "Evaulon V - Moon 2 - FedMart Storage"; solarSystemId= 30003839; position= {x = 4.55519232e+11;  y = -1.601875968e+10;  z = -3.466532045e+11;}; typeId= 3870; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011311 -> { StationData.id= 60011311; name= "Algogille IX - Moon 3 - Bank of Luminaire Depository"; solarSystemId= 30004972; position= {x = -5.009718067e+11;  y = 8.31019008e+10;  z = -6.206164992e+10;}; typeId= 57; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011602 -> { StationData.id= 60011602; name= "Villore VII - Moon 6 - Senate Bureau"; solarSystemId= 30004993; position= {x = 1.501197558e+12;  y = -2.962817434e+11;  z = -1.869853286e+12;}; typeId= 56; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011893 -> { StationData.id= 60011893; name= "Stacmon V - Moon 9 - Federation Navy Assembly Plant"; solarSystemId= 30003794; position= {x = 1.81835735e+11;  y = 2.106740736e+10;  z = -5.315603251e+11;}; typeId= 3867; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012184 -> { StationData.id= 60012184; name= "K-MGJ7 IV - Moon 11 - Archangels Testing Facilities"; solarSystemId= 30001006; position= {x = 2.638060339e+11;  y = -4.148072448e+10;  z = 4.174197965e+11;}; typeId= 1931; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012475 -> { StationData.id= 60012475; name= "Rannoze V - Moon 8 - CONCORD Bureau"; solarSystemId= 30005080; position= {x = 1.17895508e+12;  y = -2.36916695e+11;  z = 3.086579712e+11;}; typeId= 2502; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012766 -> { StationData.id= 60012766; name= "M-N7WD VIII - Moon 18 - Salvation Angels Trading Post"; solarSystemId= 30001032; position= {x = 1.649852375e+12;  y = 3.024952934e+11;  z = 1.580829942e+12;}; typeId= 3868; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013057 -> { StationData.id= 60013057; name= "XX9-WV VII - Moon 1 - Dominations Logistic Support"; solarSystemId= 30001021; position= {x = 1.085876675e+12;  y = 2.128490496e+10;  z = 7.502658355e+11;}; typeId= 2501; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013348 -> { StationData.id= 60013348; name= "Vevelonel VI - Moon 1 - Impro Factory"; solarSystemId= 30003572; position= {x = -3.211442995e+11;  y = -4.442443776e+10;  z = 6.654508646e+11;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "refinery"; "market"; "black-market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "factory"; "labratory"; "gambling"; "fitting"; "paintshop"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013639 -> { StationData.id= 60013639; name= "FR-RCH IV - Moon 2 - Jove Navy Assembly Plant"; solarSystemId= 30001637; position= {x = 5.215019213e+12;  y = 2.43864576e+11;  z = 1.364598682e+13;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013930 -> { StationData.id= 60013930; name= "QU7-EE V - Moon 7 - Prosper Vault"; solarSystemId= 30001617; position= {x = -7.046766182e+11;  y = 7.4284032e+10;  z = 6.092711117e+11;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014221 -> { StationData.id= 60014221; name= "9RQ-L8 VII - Moon 11 - True Creations Shipyard"; solarSystemId= 30001840; position= {x = 2.463533875e+11;  y = -4.415483904e+10;  z = 4.748981453e+11;}; typeId= 2498; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "paintshop"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014512 -> { StationData.id= 60014512; name= "Stetille V - X-Sense Chemical Refinery"; solarSystemId= 30002711; position= {x = -9.663127142e+11;  y = 1.594509312e+11;  z = 6.734695219e+11;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014803 -> { StationData.id= 60014803; name= "Earwik VI - Moon 10 - Republic University"; solarSystemId= 30003441; position= {x = -1.320172216e+12;  y = 2.28774912e+11;  z = -8.749767475e+11;}; typeId= 2500; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60015094 -> { StationData.id= 60015094; name= "Lulm IV - Tribal Liberation Force Logistic Support"; solarSystemId= 30002516; position= {x = 6.399697306e+11;  y = -1.059283354e+11;  z = 6.069378662e+11;}; typeId= 2501; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | _ -> None