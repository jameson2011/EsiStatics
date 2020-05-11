namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups27=
    let getMarketGroup id = 
      match id with 
      | 1094 -> { MarketGroupData.id= 1094; name= "Scripts"; parentMarketGroupId= Some(11); typeIds= [| 40334; 40335; 41517; 41518; 41519; 41520; 41521; 41522; 41523; 41524; 37821; 37822; 37823; 37824; 41155; 28999; 29001; 29003; 29005; 29007; 29009; 35794; 29011; 29013; 29015; 47336; 45010; 35795 |]; description= "Scripts that allow for tuning the effects of certain modules" } |> Some
      | 1191 -> { MarketGroupData.id= 1191; name= "Subsystem Components"; parentMarketGroupId= Some(800); typeIds= [| 30465; 45659; 30467; 30471; 30475; 29993; 29995; 29997; 30477; 30003; 45657; 45656; 30009; 45658; 30479; 34397 |]; description= "Blueprints of Subsystem Components." } |> Some
      | 1385 -> { MarketGroupData.id= 1385; name= ""; parentMarketGroupId= Some(1382); typeIds= [|  |]; description= "" } |> Some
      | 1482 -> { MarketGroupData.id= 1482; name= "Implant Slot 08"; parentMarketGroupId= Some(1479); typeIds= [| 27106; 3085; 13262; 3087; 3086; 16247 |]; description= "Implant Slot 08" } |> Some
      | 1579 -> { MarketGroupData.id= 1579; name= "Automated Targeting Systems"; parentMarketGroupId= Some(1578); typeIds= [| 1208 |]; description= "Automated Targeting Systems" } |> Some
      | 1676 -> { MarketGroupData.id= 1676; name= "1600mm Armor Plate"; parentMarketGroupId= Some(133); typeIds= [| 20353; 23785; 28780; 11279; 31900; 11325; 31902; 11327 |]; description= "1600mm Armor Plate" } |> Some
      | 1773 -> { MarketGroupData.id= 1773; name= "Implant Slot 09"; parentMarketGroupId= Some(1763); typeIds= [| 47028; 27196; 27197; 27198 |]; description= "Implant Slot 09" } |> Some
      | 1870 -> { MarketGroupData.id= 1870; name= "Fuel Blocks"; parentMarketGroupId= Some(1035); typeIds= [| 4312; 4051; 4246; 4247 |]; description= "Assembled blocks of fuel for starbases and other structures." } |> Some
      | 1967 -> { MarketGroupData.id= 1967; name= "Minmatar"; parentMarketGroupId= Some(1962); typeIds= [| 48896; 48514; 48515; 48516; 46725; 47505; 48530; 45973; 45974; 45975; 49157; 49959; 46380; 36782; 36783; 36784; 40500; 40501; 40502; 52404; 46910; 46911; 46912; 47171; 47173; 40695; 34641; 34642; 34643; 47319; 36829; 36830; 36831; 47638; 45559; 34808; 34809 |]; description= "" } |> Some
      | 2064 -> { MarketGroupData.id= 2064; name= "Advanced Cruisers"; parentMarketGroupId= Some(1988); typeIds= [|  |]; description= "" } |> Some
      | 2161 -> { MarketGroupData.id= 2161; name= "Electronic Warfare"; parentMarketGroupId= Some(2158); typeIds= [|  |]; description= "" } |> Some
      | 2258 -> { MarketGroupData.id= 2258; name= "Advanced Anti-Ship XL Torpedoes"; parentMarketGroupId= Some(505); typeIds= [| 41273; 41275; 41277; 41271 |]; description= "Advanced Anti-Ship Torpedoes" } |> Some
      | 2355 -> { MarketGroupData.id= 2355; name= "Minmatar"; parentMarketGroupId= Some(2307); typeIds= [| 44160; 45932 |]; description= "" } |> Some
      | 2452 -> { MarketGroupData.id= 2452; name= "Large Astronautic Mutaplasmids"; parentMarketGroupId= Some(2439); typeIds= [| 47744; 47299; 47754; 47755; 47756; 47743 |]; description= "Large Astronautic Mutaplasmids" } |> Some
      | 27 -> { MarketGroupData.id= 27; name= "Implants"; parentMarketGroupId= Some(24); typeIds= [|  |]; description= "Implants improve a pilot's performance in various areas. They cannot be removed once inserted" } |> Some
      | 318 -> { MarketGroupData.id= 318; name= "Rockets"; parentMarketGroupId= Some(314); typeIds= [| 2513; 2515; 1220; 2517 |]; description= "Blueprints of rockets." } |> Some
      | 353592 -> { MarketGroupData.id= 353592; name= "Turret Upgrades"; parentMarketGroupId= Some(353580); typeIds= [|  |]; description= "" } |> Some
      | 366202 -> { MarketGroupData.id= 366202; name= "Prototype"; parentMarketGroupId= Some(366173); typeIds= [|  |]; description= "" } |> Some
      | 368918 -> { MarketGroupData.id= 368918; name= "Heat Sinks"; parentMarketGroupId= Some(353592); typeIds= [|  |]; description= "" } |> Some
      | 415 -> { MarketGroupData.id= 415; name= ""; parentMarketGroupId= Some(414); typeIds= [| 11135 |]; description= "" } |> Some
      | 512 -> { MarketGroupData.id= 512; name= "Arkonor"; parentMarketGroupId= Some(54); typeIds= [| 28385; 28387; 46678; 28367; 17425; 17426; 46691; 22 |]; description= "Sub-types of arkonor ore." } |> Some
      | 609 -> { MarketGroupData.id= 609; name= "Small"; parentMarketGroupId= Some(552); typeIds= [| 13952; 19169; 19171; 6437; 32774; 6439; 6441; 19177; 6443; 399; 400; 19173; 19175; 19179; 10039; 20617; 15898; 15902; 13951 |]; description= "Frigate-class shield boosters." } |> Some
      | 706 -> { MarketGroupData.id= 706; name= "Tracking Computers"; parentMarketGroupId= Some(143); typeIds= [| 6176; 15290; 15792; 22929; 15284; 15286; 15288; 1977; 1978; 6173; 14238 |]; description= "Computerized systems designed to improve turret tracking." } |> Some
      | 803 -> { MarketGroupData.id= 803; name= "Caldari"; parentMarketGroupId= Some(65); typeIds= [| 11552; 11558; 11690; 11533; 11534; 11693; 11540; 11544; 11550 |]; description= "" } |> Some
      | 900 -> { MarketGroupData.id= 900; name= "Amarr"; parentMarketGroupId= Some(882); typeIds= [| 20126; 11966 |]; description= "Blueprints of Amarr recon ship designs." } |> Some
      | 997 -> { MarketGroupData.id= 997; name= "Small"; parentMarketGroupId= Some(994); typeIds= [| 21256; 19978; 19980; 19982; 19984; 21266; 21268; 21270; 23071; 23073; 23075; 23077; 23079; 23081; 23083; 23085; 21258; 21262; 21260; 21194; 21196; 21198; 21200; 20817; 21202; 20819; 21204; 20821; 21206; 20823; 21208; 21264; 20849; 20851; 20853; 20855; 20857; 20859; 20861; 20863 |]; description= "Small faction issue frequenzy crystals, for use with frigate-size lasers." } |> Some
      | _ -> None