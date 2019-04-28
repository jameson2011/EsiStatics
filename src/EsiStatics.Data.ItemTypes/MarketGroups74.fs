namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups74=
    let getMarketGroup id = 
      match id with 
      | 1141 -> { MarketGroupData.id= 1141; name= "Gallente"; parentMarketGroupId= Some(1138); typeIds= [| 29988 |]; description= "Gallente strategic cruiser designs." } |> Some
      | 1238 -> { MarketGroupData.id= 1238; name= "Medium Projectile Weapon Rigs"; parentMarketGroupId= Some(979); typeIds= [| 31712; 31682; 31688; 31658; 31694; 31664; 31700; 31670; 31706; 31676 |]; description= "Modifications that affect a medium starship's projectile weapons." } |> Some
      | 1335 -> { MarketGroupData.id= 1335; name= "Refined Planetary Materials"; parentMarketGroupId= Some(1332); typeIds= [| 2312; 3725; 2319; 2321; 2327; 2328; 2329; 2463; 44; 3775; 2317; 15317; 9830; 9832; 3689; 3691; 9836; 3693; 9838; 3695; 9840; 3697; 9842; 3828 |]; description= "The third tier of planetary materials." } |> Some
      | 1529 -> { MarketGroupData.id= 1529; name= "Interdiction Probes"; parentMarketGroupId= Some(1520); typeIds= [| 22779 |]; description= "Interdiction Probes" } |> Some
      | 1626 -> { MarketGroupData.id= 1626; name= "Minmatar Subsystems"; parentMarketGroupId= Some(1112); typeIds= [|  |]; description= "Minmatar Subsystems" } |> Some
      | 1723 -> { MarketGroupData.id= 1723; name= "Capital Electronics Superiority Rigs"; parentMarketGroupId= Some(948); typeIds= [| 31267; 31303; 31255; 31339; 31351; 31291 |]; description= "Blueprints of Capital Electronics Superiority Rigs." } |> Some
      | 2014 -> { MarketGroupData.id= 2014; name= "Industrial Upgrades"; parentMarketGroupId= Some(2015); typeIds= [| 34855; 34856; 34857; 34858; 34859; 34860; 34861; 34862; 34863; 34864 |]; description= "Blueprints of Industrial Upgrades." } |> Some
      | 2111 -> { MarketGroupData.id= 2111; name= "Caldari"; parentMarketGroupId= Some(2109); typeIds= [| 36355; 48198; 40615; 46859; 36739; 46132; 36667; 45855 |]; description= "" } |> Some
      | 2208 -> { MarketGroupData.id= 2208; name= "Engineering Equipment"; parentMarketGroupId= Some(2202); typeIds= [|  |]; description= "" } |> Some
      | 2402 -> { MarketGroupData.id= 2402; name= "Biochemical Reaction Formulas"; parentMarketGroupId= Some(1849); typeIds= [| 46219; 46220; 46221; 46222; 46223; 46224; 46225; 46226; 46227; 46228; 46229; 46230; 46231; 46232; 46233; 46234; 46235; 46236; 46237; 46238; 46240; 46241; 46242; 46243; 46244; 46245; 46246; 46247; 46248; 46249; 46250; 46251 |]; description= "Reaction formulas that enable the creation of raw boosters in Refineries" } |> Some
      | 2499 -> { MarketGroupData.id= 2499; name= "Antipharmakon"; parentMarketGroupId= Some(2489); typeIds= [| 36910 |]; description= "Antipharmakon Boosters" } |> Some
      | 354415 -> { MarketGroupData.id= 354415; name= "Advanced"; parentMarketGroupId= Some(353576); typeIds= [|  |]; description= "" } |> Some
      | 364891 -> { MarketGroupData.id= 364891; name= "Advanced"; parentMarketGroupId= Some(364889); typeIds= [|  |]; description= "Advanced medium frames." } |> Some
      | 365 -> { MarketGroupData.id= 365; name= "Corporation Management"; parentMarketGroupId= Some(150); typeIds= [| 3368; 3732; 3363; 3731; 12241 |]; description= "Skills pertaining to management of large social groups" } |> Some
      | 365279 -> { MarketGroupData.id= 365279; name= "Standard"; parentMarketGroupId= Some(365278); typeIds= [|  |]; description= "Standard commando dropsuits." } |> Some
      | 462 -> { MarketGroupData.id= 462; name= "Gallente"; parentMarketGroupId= Some(458); typeIds= [| 12043; 12045 |]; description= "Blueprints of Gallente assault frigate designs." } |> Some
      | 559 -> { MarketGroupData.id= 559; name= "Autocannons"; parentMarketGroupId= Some(87); typeIds= [|  |]; description= "Autocannons are effective at close ranges and possess great tracking ability." } |> Some
      | 656 -> { MarketGroupData.id= 656; name= "Electronics and Sensor Upgrades"; parentMarketGroupId= Some(9); typeIds= [|  |]; description= "Modules that strengthen the sensory capabilities of a spaceship" } |> Some
      | 74 -> { MarketGroupData.id= 74; name= "Amarr"; parentMarketGroupId= Some(6); typeIds= [| 624; 625; 628; 2006 |]; description= "Amarr cruiser designs." } |> Some
      | 753 -> { MarketGroupData.id= 753; name= "Mining Crystals"; parentMarketGroupId= Some(211); typeIds= [| 46359; 18049; 18051; 46357; 18053; 18055; 18057; 18059; 18061; 46350; 18063; 46352; 18065; 18067; 18037; 18039; 18041; 18043; 46361; 18045; 18047 |]; description= "Blueprints of mining crystals." } |> Some
      | 850 -> { MarketGroupData.id= 850; name= "Advanced Railgun Charges"; parentMarketGroupId= Some(100); typeIds= [|  |]; description= "Technologically advanced railgun ammunition." } |> Some
      | _ -> None