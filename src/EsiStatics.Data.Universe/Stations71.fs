﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Stations71=
    let getStation id = 
      match id with 
      | 60000100 -> { StationData.id= 60000100; name= "Oppold IX - Moon 6 - CBD Corporation Storage"; solarSystemId= 30003430; position= {x = -4.40351404e+12;  y = -4.988639232e+11;  z = 2.968522138e+12;}; typeId= 1531; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60000391 -> { StationData.id= 60000391; name= "Otanuomi VI - Moon 9 - The Convocation of Triglav Proving Complex"; solarSystemId= 30000192; position= {x = -2.314164511e+12;  y = 1.322435789e+11;  z = 1.967015485e+12;}; typeId= 1531; services= [| "reprocessing-plant"; "market"; "cloning"; "repair-facilities"; "factory"; "fitting"; "paintshop"; "news"; "storage"; "docking"; "office-rental"; "jump-clone-facility"; "loyalty-point-store" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60000682 -> { StationData.id= 60000682; name= "New Caldari Prime - Moon 1 - Poksu Mineral Group Mineral Reserve"; solarSystemId= 30000145; position= {x = 5.596919194e+11;  y = -1.615128576e+10;  z = -5.358646272e+11;}; typeId= 4023; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60000973 -> { StationData.id= 60000973; name= "Uchoshi XI - Moon 4 - Caldari Provisions Food Packaging"; solarSystemId= 30000201; position= {x = -2.51675136e+12;  y = -5.094465946e+11;  z = 1.004569436e+12;}; typeId= 4024; services= [| "courier-missions"; "reprocessing-plant"; "market"; "fitting"; "news"; "storage"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001264 -> { StationData.id= 60001264; name= "Parchanier VI - Moon 16 - Wiyrkomi Corporation Factory"; solarSystemId= 30002676; position= {x = 5.03158825e+11;  y = -1.236430848e+10;  z = 1.042336358e+12;}; typeId= 4024; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001555 -> { StationData.id= 60001555; name= "Ajanen VIII - Moon 2 - Perkone Factory"; solarSystemId= 30001414; position= {x = 2.004451738e+11;  y = 7642767360.0;  z = 5.75960064e+11;}; typeId= 4024; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60001846 -> { StationData.id= 60001846; name= "Trer VIII - Moon 7 - Nugoeihuvi Corporation Development Studio"; solarSystemId= 30002562; position= {x = 3.733813248e+11;  y = 291594240.0;  z = -1.617727365e+12;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60002137 -> { StationData.id= 60002137; name= "Altrinur XII - Moon 15 - Ishukone Corporation Factory"; solarSystemId= 30003389; position= {x = 2.147706593e+12;  y = -2.478242611e+11;  z = -2.721646387e+12;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "refinery"; "market"; "black-market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "factory"; "labratory"; "gambling"; "fitting"; "paintshop"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60002428 -> { StationData.id= 60002428; name= "Liekuri VII - Moon 22 - Expert Distribution Warehouse"; solarSystemId= 30000154; position= {x = -4.61830103e+11;  y = -4.830130176e+10;  z = -1.311795732e+12;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60002719 -> { StationData.id= 60002719; name= "Hatakani VI - Moon 13 - CBD Sell Division Retail Center"; solarSystemId= 30002764; position= {x = -5.095146701e+11;  y = 3.48174336e+10;  z = -3.424333824e+10;}; typeId= 1531; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "fitting"; "paintshop"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003010 -> { StationData.id= 60003010; name= "Atai II - Moon 2 - Caldari Constructions Production Plant"; solarSystemId= 30001419; position= {x = -1.042808463e+12;  y = 2.106579763e+11;  z = 3.713270538e+12;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003301 -> { StationData.id= 60003301; name= "Nourvukaiken VII - Moon 13 - Modern Finances Depository"; solarSystemId= 30001376; position= {x = 1.49282304e+12;  y = -1.223244595e+11;  z = -7.500338381e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003592 -> { StationData.id= 60003592; name= "Reynire IX - Moon 2 - Caldari Business Tribunal Archives"; solarSystemId= 30003803; position= {x = -5.876321894e+11;  y = -1.673170944e+10;  z = -8.061659136e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60003883 -> { StationData.id= 60003883; name= "Umokka VII - Moon 5 - Caldari Navy Testing Facilities"; solarSystemId= 30001409; position= {x = 3.982854144e+11;  y = 6.92533248e+10;  z = 3.975095501e+11;}; typeId= 54; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004174 -> { StationData.id= 60004174; name= "Enderailen VI - Moon 11 - Spacelane Patrol Assembly Plant"; solarSystemId= 30002769; position= {x = -9.639653376e+10;  y = 1.16914176e+10;  z = -5.470650778e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004465 -> { StationData.id= 60004465; name= "Uchoshi X - Moon 11 - Science and Trade Institute School"; solarSystemId= 30000201; position= {x = -1.049428009e+12;  y = -2.124294144e+11;  z = -1.04475648e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60004756 -> { StationData.id= 60004756; name= "Eystur III - Moon 1 - Republic Fleet Assembly Plant"; solarSystemId= 30002543; position= {x = -5.737181184e+10;  y = 7771791360.0;  z = 2.853341184e+11;}; typeId= 2498; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005047 -> { StationData.id= 60005047; name= "Osoggur VI - Urban Management Information Center"; solarSystemId= 30002506; position= {x = -1.716094157e+11;  y = 3.101405184e+10;  z = -2.156454298e+11;}; typeId= 2502; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005338 -> { StationData.id= 60005338; name= "Datulen IV - Moon 12 - Minmatar Mining Corporation Refinery"; solarSystemId= 30003405; position= {x = 4.182047539e+11;  y = 4.562669568e+10;  z = -1.173753446e+11;}; typeId= 2497; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "refinery"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005629 -> { StationData.id= 60005629; name= "Iderion IX - Moon 18 - Core Complexion Inc. Factory"; solarSystemId= 30005227; position= {x = 7.396929946e+11;  y = -4420116480.0;  z = 4.088105779e+11;}; typeId= 2497; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60005920 -> { StationData.id= 60005920; name= "Uphallant VII - Moon 2 - Freedom Extension Storage"; solarSystemId= 30003799; position= {x = -2.498902548e+12;  y = 6.14270976e+10;  z = -9.164956877e+11;}; typeId= 2501; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006211 -> { StationData.id= 60006211; name= "Halibai IV - Moon 1 - Amarr Constructions Production Plant"; solarSystemId= 30004100; position= {x = -2.100588134e+11;  y = 3.03814656e+10;  z = 8.704242893e+11;}; typeId= 1928; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006502 -> { StationData.id= 60006502; name= "Atlar VI - Moon 4 - Imperial Armaments Factory"; solarSystemId= 30002389; position= {x = -3.425931264e+10;  y = -1131601920.0;  z = -5.663213568e+11;}; typeId= 1928; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60006793 -> { StationData.id= 60006793; name= "Amane VII - Moon 11 - Ducia Foundry Mineral Reserve"; solarSystemId= 30004983; position= {x = -6.145866547e+11;  y = -5.07697152e+10;  z = 3.224691917e+11;}; typeId= 1929; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007084 -> { StationData.id= 60007084; name= "Chamume VII - Moon 2 - Imperial Shipment Storage"; solarSystemId= 30001664; position= {x = -1.032598733e+11;  y = -1.907355648e+10;  z = -1.68874242e+12;}; typeId= 1929; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007375 -> { StationData.id= 60007375; name= "Elonaya XI - Joint Harvesting Plantation"; solarSystemId= 30001399; position= {x = 1.572840038e+12;  y = 1.986943795e+11;  z = -1.715887596e+12;}; typeId= 1930; services= [| "courier-missions"; "reprocessing-plant"; "market"; "fitting"; "news"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007666 -> { StationData.id= 60007666; name= "Arraron VII - Moon 7 - Nurtura Food Packaging"; solarSystemId= 30005330; position= {x = -1.078064701e+12;  y = 1.092303667e+11;  z = -4.367008973e+11;}; typeId= 1928; services= [| "courier-missions"; "reprocessing-plant"; "market"; "fitting"; "news"; "storage"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60007957 -> { StationData.id= 60007957; name= "Hophib VI - Moon 3 - Ministry of War Archives"; solarSystemId= 30004309; position= {x = 3.441265459e+11;  y = -407838720.0;  z = -7693393920.0;}; typeId= 1931; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008248 -> { StationData.id= 60008248; name= "Sukirah VIII - Moon 5 - Amarr Trade Registry Archives"; solarSystemId= 30002200; position= {x = 1.162458194e+12;  y = -1.459901645e+11;  z = 6.677528986e+11;}; typeId= 1931; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008539 -> { StationData.id= 60008539; name= "Riavayed II - Emperor Family Bureau"; solarSystemId= 30002993; position= {x = 1.430065152e+10;  y = 794910720.0;  z = -6.381932544e+10;}; typeId= 1932; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60008830 -> { StationData.id= 60008830; name= "Soliara IX - Moon 18 - Civic Court Tribunal"; solarSystemId= 30004273; position= {x = 4.154283172e+12;  y = -4.14539735e+11;  z = 1.57299585e+12;}; typeId= 1929; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009121 -> { StationData.id= 60009121; name= "Abudban VIII - Moon 19 - TransStellar Shipping Storage"; solarSystemId= 30002507; position= {x = -2.726084198e+11;  y = 3.773853696e+10;  z = 6.994058035e+11;}; typeId= 3870; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009412 -> { StationData.id= 60009412; name= "Brybier I - Moon 1 - Federal Freight Storage"; solarSystemId= 30002703; position= {x = -1.341490913e+12;  y = -1.453003162e+11;  z = 3.648588595e+11;}; typeId= 3870; services= [| "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009703 -> { StationData.id= 60009703; name= "Athinard VII - Moon 2 - Astral Mining Inc. Mineral Reserve"; solarSystemId= 30003031; position= {x = -2.245604352e+12;  y = 1.02989783e+11;  z = 6.51972649e+11;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60009994 -> { StationData.id= 60009994; name= "Habu VIII - Moon 1 - Quafe Company Factory"; solarSystemId= 30005250; position= {x = -5.759121408e+11;  y = 2.910818304e+10;  z = 2.805901025e+12;}; typeId= 3867; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010285 -> { StationData.id= 60010285; name= "Peyiri XI - Moon 21 - CreoDron Warehouse"; solarSystemId= 30004114; position= {x = 1.400965325e+12;  y = 2.451233587e+11;  z = 2.152841748e+12;}; typeId= 3870; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010576 -> { StationData.id= 60010576; name= "Uphene VI - Moon 16 - Egonics Inc. Development Studio"; solarSystemId= 30003043; position= {x = -1.338186547e+11;  y = -1.03397376e+10;  z = -4.542017126e+11;}; typeId= 56; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "gambling"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60010867 -> { StationData.id= 60010867; name= "Scuelazyns VII - Moon 1 - Duvolle Laboratories Factory"; solarSystemId= 30003054; position= {x = 4.268529869e+12;  y = 6.767848243e+11;  z = 3.173618074e+11;}; typeId= 3867; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "refinery"; "market"; "black-market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "factory"; "labratory"; "gambling"; "fitting"; "paintshop"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011158 -> { StationData.id= 60011158; name= "Iswa II - Aliastra Warehouse"; solarSystemId= 30001726; position= {x = 8542986240.0;  y = 1503928320.0;  z = 8.72761344e+10;}; typeId= 3870; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011449 -> { StationData.id= 60011449; name= "Arza II - Pend Insurance Vault"; solarSystemId= 30005086; position= {x = 2931548160.0;  y = 369008640.0;  z = -4.143600845e+11;}; typeId= 3868; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "stock-exchange"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60011740 -> { StationData.id= 60011740; name= "Oursulaert III - Federation Navy Testing Facilities"; solarSystemId= 30004969; position= {x = -7.273279488e+10;  y = 1.073246208e+10;  z = -3.878449152e+10;}; typeId= 3869; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "labratory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012031 -> { StationData.id= 60012031; name= "Direrie I - Federation Customs Logistic Support"; solarSystemId= 30002646; position= {x = 2930565120.0;  y = 534405120.0;  z = -3.825266688e+10;}; typeId= 3868; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012322 -> { StationData.id= 60012322; name= "Uchoshi IX - Moon 2 - CONCORD Assembly Plant"; solarSystemId= 30000201; position= {x = -6.511692595e+11;  y = -1.318115328e+11;  z = 3.767135846e+11;}; typeId= 1529; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012613 -> { StationData.id= 60012613; name= "Apanake VIII - Moon 8 - Sisters of EVE Bureau"; solarSystemId= 30005216; position= {x = -5.776641638e+11;  y = -101867520.0;  z = 1.502377943e+12;}; typeId= 1932; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60012904 -> { StationData.id= 60012904; name= "Litom XI - Moon 2 - Guardian Angels Assembly Plant"; solarSystemId= 30001048; position= {x = 1.906866463e+12;  y = 1.130543923e+11;  z = 8.034151219e+11;}; typeId= 3867; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013195 -> { StationData.id= 60013195; name= "Yashunen III - Genolution Biotech Production"; solarSystemId= 30002762; position= {x = 1.323345101e+11;  y = -1.431023616e+10;  z = -1.420781568e+11;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "dna-therapy"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013486 -> { StationData.id= 60013486; name= "A-SJ8X VII - Moon 1 - Intaki Syndicate Bureau"; solarSystemId= 30003335; position= {x = 1.150577664e+12;  y = -1.65660672e+10;  z = 1.033875456e+10;}; typeId= 56; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60013777 -> { StationData.id= 60013777; name= "7-8XK0 VI - Jovian Directorate Bureau"; solarSystemId= 30001608; position= {x = -3.284477952e+11;  y = -5.029122048e+10;  z = 1.959642317e+11;}; typeId= 3865; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "market"; "stock-exchange"; "cloning"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014068 -> { StationData.id= 60014068; name= "Nakah I - Moon 1 - Thukker Mix Factory"; solarSystemId= 30000072; position= {x = 1.808573645e+11;  y = -2.064666624e+10;  z = 7074078720.0;}; typeId= 2497; services= [| "bounty-missions"; "courier-missions"; "interbus"; "reprocessing-plant"; "refinery"; "market"; "black-market"; "stock-exchange"; "cloning"; "surgery"; "dna-therapy"; "repair-facilities"; "factory"; "labratory"; "gambling"; "fitting"; "paintshop"; "news"; "storage"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014359 -> { StationData.id= 60014359; name= "O5Y3-W VI - Moon 1 - True Power Logistic Support"; solarSystemId= 30001855; position= {x = 8.089841664e+10;  y = 6606397440.0;  z = -1.557261558e+12;}; typeId= 3868; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014650 -> { StationData.id= 60014650; name= "Azedi V - Moon 1 - Imperial Academy"; solarSystemId= 30005275; position= {x = 7.07035177e+11;  y = -3.341807616e+10;  z = 7.174438502e+11;}; typeId= 1931; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60014941 -> { StationData.id= 60014941; name= "Z3V-1W VII - Blood Raiders Assembly Plant"; solarSystemId= 30004707; position= {x = 1.624928256e+10;  y = -836198400.0;  z = 2.04662526e+12;}; typeId= 1927; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60015038 -> { StationData.id= 60015038; name= "Krilmokenur VII - Moon 8 - Republic Military School"; solarSystemId= 30022547; position= {x = 4.095726797e+11;  y = -1.594773504e+10;  z = -8.676811162e+11;}; typeId= 2500; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "repair-facilities"; "factory"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | 60015135 -> { StationData.id= 60015135; name= "Myyhera III - 24th Imperial Crusade Logistic Support"; solarSystemId= 30003075; position= {x = -2.595065856e+10;  y = -2733219840.0;  z = -1.071399322e+11;}; typeId= 1927; services= [| "bounty-missions"; "courier-missions"; "reprocessing-plant"; "market"; "cloning"; "surgery"; "repair-facilities"; "fitting"; "news"; "insurance"; "docking"; "office-rental"; "loyalty-point-store"; "navy-offices"; "security-offices" |]; maxDockableShipVolume= 50000000 } |> Some
      | _ -> None