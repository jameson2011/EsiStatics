namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups48=
    let getMarketGroup id = 
      match id with 
      | 1018 -> { MarketGroupData.id= 1018; name= "Remote Hull Repairers"; parentMarketGroupId= Some(14); typeIds= [|  |]; description= "Repair the hulls of your allies at range, always handy after those close call situations." } |> Some
      | 1212 -> { MarketGroupData.id= 1212; name= "Large Astronautic Rigs"; parentMarketGroupId= Some(957); typeIds= [| 26304; 26306; 26308; 26310; 26056; 26058; 26060; 26322; 26062; 26320; 26312; 26066; 26068; 26318; 26070; 26072; 34306 |]; description= "Modifications that affect a large starship's astronautics." } |> Some
      | 1406 -> { MarketGroupData.id= 1406; name= "Tops"; parentMarketGroupId= Some(1402); typeIds= [| 4224; 4225; 4226; 4227; 4228; 4229; 4230; 4231; 4232; 34825; 36490; 36491; 4366; 4368; 47192; 50130; 36486; 45734; 33063; 33579; 37808; 36488; 36489; 47187; 4155; 4156; 4157; 4158; 4159; 4160; 4161; 4162; 4163; 4164; 42700; 47479; 36487; 35682; 33487; 47185; 47186; 42707; 33109; 44120; 40527; 4061; 4062; 4063; 4064; 4065; 4066; 37865; 47189; 52198; 4201; 4202; 4203; 4204; 4205; 4206; 4207; 4208; 4209; 4210; 4211; 4212; 4213; 4214; 4215; 4216; 4217; 4218; 4219; 4220; 4221; 4222; 4223 |]; description= "Clothing worn on the torso." } |> Some
      | 1600 -> { MarketGroupData.id= 1600; name= "Orbital Strike"; parentMarketGroupId= Some(100); typeIds= [|  |]; description= "" } |> Some
      | 1697 -> { MarketGroupData.id= 1697; name= "Micro Jump Drives"; parentMarketGroupId= Some(252); typeIds= [|  |]; description= "Blueprints of Micro Jump Drives." } |> Some
      | 1794 -> { MarketGroupData.id= 1794; name= "Resource Processing Rigs"; parentMarketGroupId= Some(943); typeIds= [|  |]; description= "Permanent modification of a ship's resource processing." } |> Some
      | 1988 -> { MarketGroupData.id= 1988; name= "Cruisers"; parentMarketGroupId= Some(1954); typeIds= [|  |]; description= "" } |> Some
      | 2085 -> { MarketGroupData.id= 2085; name= "Standard Industrial Ships"; parentMarketGroupId= Some(2006); typeIds= [|  |]; description= "" } |> Some
      | 2182 -> { MarketGroupData.id= 2182; name= "Resource Processing Service Modules"; parentMarketGroupId= Some(2166); typeIds= [| 37032; 37034; 45540; 45541; 45542 |]; description= "" } |> Some
      | 2279 -> { MarketGroupData.id= 2279; name= "Caldari"; parentMarketGroupId= Some(2277); typeIds= [| 49954; 46147; 46276; 47050; 41681; 41682; 41683; 48212; 47642 |]; description= "" } |> Some
      | 2376 -> { MarketGroupData.id= 2376; name= "Pirate Faction"; parentMarketGroupId= Some(2375); typeIds= [| 46980; 47009; 46044; 46877; 46823 |]; description= "" } |> Some
      | 2473 -> { MarketGroupData.id= 2473; name= "Drone Implants"; parentMarketGroupId= Some(531); typeIds= [|  |]; description= "Drone Implants" } |> Some
      | 339 -> { MarketGroupData.id= 339; name= "Cap Booster Charges"; parentMarketGroupId= Some(211); typeIds= [| 3553; 3555; 11284; 11286; 11288; 1178; 1179; 11290; 41598 |]; description= "Blueprints of cap booster charges." } |> Some
      | 353613 -> { MarketGroupData.id= 353613; name= "Small"; parentMarketGroupId= Some(353605); typeIds= [|  |]; description= "" } |> Some
      | 353710 -> { MarketGroupData.id= 353710; name= "Vehicle Command"; parentMarketGroupId= Some(353633); typeIds= [|  |]; description= "Hardwired neural augmentations used to train new abilities." } |> Some
      | 354389 -> { MarketGroupData.id= 354389; name= "Advanced"; parentMarketGroupId= Some(353600); typeIds= [|  |]; description= "" } |> Some
      | 364768 -> { MarketGroupData.id= 364768; name= "Assault"; parentMarketGroupId= Some(353653); typeIds= [|  |]; description= "The Assault is a low-level aerial attack craft effective against aerial and ground units" } |> Some
      | 366223 -> { MarketGroupData.id= 366223; name= "Advanced"; parentMarketGroupId= Some(366178); typeIds= [|  |]; description= "" } |> Some
      | 436 -> { MarketGroupData.id= 436; name= "Minmatar"; parentMarketGroupId= Some(432); typeIds= [| 11400; 11371 |]; description= "Minmatar assault frigate designs." } |> Some
      | 533 -> { MarketGroupData.id= 533; name= "Materials"; parentMarketGroupId= Some(475); typeIds= [|  |]; description= "Various materials used in manufacturing" } |> Some
      | 630 -> { MarketGroupData.id= 630; name= "Amarr"; parentMarketGroupId= Some(629); typeIds= [| 12753; 12733 |]; description= "Amarr transport ship designs." } |> Some
      | 727 -> { MarketGroupData.id= 727; name= "Magnetometric Sensors"; parentMarketGroupId= Some(685); typeIds= [|  |]; description= "Boost a ship's magnetometric sensor strength for a short duration." } |> Some
      | 824 -> { MarketGroupData.id= 824; name= "Recon Ships"; parentMarketGroupId= Some(1368); typeIds= [|  |]; description= "Cruisers specialized in reconaissance operations and electronic warfare." } |> Some
      | 921 -> { MarketGroupData.id= 921; name= "Standard Cruise Missiles"; parentMarketGroupId= Some(580); typeIds= [| 202; 203; 204; 205 |]; description= "Standard Cruise Missiles" } |> Some
      | _ -> None