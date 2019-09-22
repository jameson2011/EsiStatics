namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups29=
    let getMarketGroup id = 
      match id with 
      | 1193 -> { MarketGroupData.id= 1193; name= "Standard XL Torpedoes"; parentMarketGroupId= Some(505); typeIds= [| 17857; 17859; 17861; 17863 |]; description= "Standard XL torpedo designs." } |> Some
      | 126 -> { MarketGroupData.id= 126; name= "Shield Rechargers"; parentMarketGroupId= Some(554); typeIds= [| 393; 394; 6485; 37805 |]; description= "Provide an increase to the shield's recharge rate." } |> Some
      | 1484 -> { MarketGroupData.id= 1484; name= "Implant Slot 06"; parentMarketGroupId= Some(1478); typeIds= [| 27177; 27179; 27180 |]; description= "Implant Slot 06" } |> Some
      | 1581 -> { MarketGroupData.id= 1581; name= "Sensor Boosters"; parentMarketGroupId= Some(1578); typeIds= [| 41412; 11620 |]; description= "Sensor Boosters" } |> Some
      | 1678 -> { MarketGroupData.id= 1678; name= "Thermal Armor Hardeners"; parentMarketGroupId= Some(535); typeIds= [| 11648; 18945; 18947; 18955; 11277; 18963; 15252; 15254; 15256; 15258; 18971; 13982; 13984; 18979; 13992; 17838; 15032; 15034; 15036; 15038; 15040; 15042; 15044; 15046; 18913; 18897; 18899; 15705; 15713; 18915; 17508; 18917; 18919; 28528; 14065; 16377; 16379; 16381; 16383 |]; description= "Thermal Armor Hardeners" } |> Some
      | 1775 -> { MarketGroupData.id= 1775; name= "Implant Slot 08"; parentMarketGroupId= Some(1764); typeIds= [| 27147; 27148 |]; description= "Implant Slot 08" } |> Some
      | 1872 -> { MarketGroupData.id= 1872; name= "Research Equipment"; parentMarketGroupId= Some(475); typeIds= [|  |]; description= "Various items used in research and invention" } |> Some
      | 1969 -> { MarketGroupData.id= 1969; name= "ORE"; parentMarketGroupId= Some(2114); typeIds= [| 42625; 46992; 43813; 44071; 43787; 43852; 46742; 43773; 43760; 43826; 46547; 34646; 43800; 42682; 48735; 42652; 43674; 43839 |]; description= "" } |> Some
      | 2066 -> { MarketGroupData.id= 2066; name= "Heavy Interdiction Cruisers"; parentMarketGroupId= Some(2064); typeIds= [|  |]; description= "" } |> Some
      | 2163 -> { MarketGroupData.id= 2163; name= "Engineering Equipment"; parentMarketGroupId= Some(2158); typeIds= [|  |]; description= "" } |> Some
      | 2260 -> { MarketGroupData.id= 2260; name= "Advanced High Precision XL Cruise Missiles"; parentMarketGroupId= Some(1316); typeIds= [| 41290; 41298; 41286; 41295 |]; description= "Advanced High Precision XL Cruise Missiles" } |> Some
      | 2357 -> { MarketGroupData.id= 2357; name= "Faction Force Auxiliaries"; parentMarketGroupId= Some(2271); typeIds= [| 42242; 45645 |]; description= "Faction force auxiliary designs." } |> Some
      | 2454 -> { MarketGroupData.id= 2454; name= "Medium Engineering Mutaplasmids"; parentMarketGroupId= Some(2440); typeIds= [| 48420; 48421; 48422; 48433; 48434; 48432; 47825; 47826; 47827 |]; description= "Medium Engineering Mutaplasmids" } |> Some
      | 320 -> { MarketGroupData.id= 320; name= "Scan Probes"; parentMarketGroupId= Some(1520); typeIds= [| 30029; 30014 |]; description= "Blueprints of scan probes." } |> Some
      | 417 -> { MarketGroupData.id= 417; name= "Gallente"; parentMarketGroupId= Some(414); typeIds= [| 11130 |]; description= "Blueprints of Gallente shuttle designs." } |> Some
      | 514 -> { MarketGroupData.id= 514; name= "Bistot"; parentMarketGroupId= Some(54); typeIds= [| 28388; 28389; 28390; 1223; 46692; 17428; 17429; 46676 |]; description= "Sub-types of bistot ore." } |> Some
      | 611 -> { MarketGroupData.id= 611; name= "Large"; parentMarketGroupId= Some(552); typeIds= [| 10880; 19201; 19203; 14597; 14599; 20621; 15900; 19205; 15904; 4391; 19207; 10838; 19194; 19200; 10876; 10858; 14700; 14701; 14702; 14703; 19193; 10874; 13947; 13948; 10878; 19199 |]; description= "Battleship-class shield boosters." } |> Some
      | 708 -> { MarketGroupData.id= 708; name= "Remote Tracking Computers"; parentMarketGroupId= Some(143); typeIds= [| 14240; 2103; 2104; 22937; 5339; 5340; 5342; 15967 |]; description= "Designed to give a boost to another ship's tracking speed." } |> Some
      | 902 -> { MarketGroupData.id= 902; name= "Gallente"; parentMarketGroupId= Some(882); typeIds= [| 11970; 11972 |]; description= "Blueprints of Gallente recon ship designs." } |> Some
      | 999 -> { MarketGroupData.id= 999; name= "Faction Rockets"; parentMarketGroupId= Some(118); typeIds= [| 27329; 27331; 27333; 27335; 27313; 27315; 27317; 27319; 27321; 27323; 27325; 27327 |]; description= "Faction issue rockets." } |> Some
      | _ -> None