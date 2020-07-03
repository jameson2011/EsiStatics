namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups30=
    let getMarketGroup id = 
      match id with 
      | 1000 -> { MarketGroupData.id= 1000; name= "Faction Torpedoes"; parentMarketGroupId= Some(387); typeIds= [| 27363; 27337; 27339; 27341; 27343; 27345; 27347; 27349; 27351; 27355; 27357; 27359 |]; description= "Faction issue torpedoes." } |> Some
      | 1097 -> { MarketGroupData.id= 1097; name= "Advanced Capital Ship Components"; parentMarketGroupId= Some(800); typeIds= [|  |]; description= "Blueprints of Advanced Capital Ship Components." } |> Some
      | 1194 -> { MarketGroupData.id= 1194; name= "Faction XL Torpedoes"; parentMarketGroupId= Some(505); typeIds= [| 29616; 29618; 29620; 29622 |]; description= "Faction XL torpedo designs." } |> Some
      | 1485 -> { MarketGroupData.id= 1485; name= "Implant Slot 07"; parentMarketGroupId= Some(1478); typeIds= [| 27176; 27181; 27182 |]; description= "Implant Slot 07" } |> Some
      | 1582 -> { MarketGroupData.id= 1582; name= "Passive Targeting Systems"; parentMarketGroupId= Some(1578); typeIds= [| 1212 |]; description= "Passive Targeting Systems" } |> Some
      | 1679 -> { MarketGroupData.id= 1679; name= "Kinetic Armor Hardeners"; parentMarketGroupId= Some(535); typeIds= [| 13980; 18953; 18961; 18969; 13978; 15260; 15262; 15264; 18977; 15266; 13990; 11305; 17836; 15048; 15050; 15052; 18893; 15054; 18895; 15056; 15058; 15060; 15062; 15707; 18909; 18911; 17506; 15715; 18921; 18923; 28526; 14063; 16373; 16375; 11644; 18941; 18943 |]; description= "" } |> Some
      | 1776 -> { MarketGroupData.id= 1776; name= "Implant Slot 09"; parentMarketGroupId= Some(1764); typeIds= [| 25545; 25546 |]; description= "Implant Slot 09" } |> Some
      | 1873 -> { MarketGroupData.id= 1873; name= "Decryptors"; parentMarketGroupId= Some(1872); typeIds= [| 34208; 34201; 34202; 34203; 34204; 34205; 34206; 34207 |]; description= "" } |> Some
      | 1970 -> { MarketGroupData.id= 1970; name= "Carriers"; parentMarketGroupId= Some(1968); typeIds= [|  |]; description= "" } |> Some
      | 2067 -> { MarketGroupData.id= 2067; name= "Logistics"; parentMarketGroupId= Some(2064); typeIds= [|  |]; description= "" } |> Some
      | 2164 -> { MarketGroupData.id= 2164; name= "Structure Weapons"; parentMarketGroupId= Some(2158); typeIds= [|  |]; description= "" } |> Some
      | 2261 -> { MarketGroupData.id= 2261; name= "Advanced High Damage XL Cruise Missiles"; parentMarketGroupId= Some(1316); typeIds= [| 41299; 41291; 41294; 41287 |]; description= "Advanced High Damage XL Cruise Missiles" } |> Some
      | 2358 -> { MarketGroupData.id= 2358; name= "Skill Trading"; parentMarketGroupId= Some(1922); typeIds= [| 40520; 46375; 45635; 40519 |]; description= "Items used to extract and inject skill points." } |> Some
      | 2455 -> { MarketGroupData.id= 2455; name= "Large Engineering Mutaplasmids"; parentMarketGroupId= Some(2440); typeIds= [| 48438; 48424; 48425; 48426; 48436; 47829; 47830; 47831; 48437 |]; description= "Large Engineering Mutaplasmids" } |> Some
      | 418 -> { MarketGroupData.id= 418; name= "Minmatar"; parentMarketGroupId= Some(414); typeIds= [| 11133 |]; description= "Blueprints of Minmatar shuttle designs." } |> Some
      | 515 -> { MarketGroupData.id= 515; name= "Pyroxeres"; parentMarketGroupId= Some(54); typeIds= [| 1224; 28425; 28426; 46702; 28424; 17459; 17460; 46686 |]; description= "Sub-types of Pyroxeres ore." } |> Some
      | 612 -> { MarketGroupData.id= 612; name= "Extra Large"; parentMarketGroupId= Some(552); typeIds= [| 13953; 13954; 10884; 19206; 10888; 14601; 14603; 32780; 19202; 20623; 15897; 19204; 15901; 19208; 10840; 10842; 14704; 14705; 14706; 14707; 19195; 19196; 19197; 19198 |]; description= "Supercharged shield boosting units for advanced battleship pilots." } |> Some
      | 903 -> { MarketGroupData.id= 903; name= "Minmatar"; parentMarketGroupId= Some(882); typeIds= [| 11962; 11964 |]; description= "Blueprints of Minmatar recon ship designs." } |> Some
      | _ -> None