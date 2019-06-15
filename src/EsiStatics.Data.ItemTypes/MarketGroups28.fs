namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups28=
    let getMarketGroup id = 
      match id with 
      | 1192 -> { MarketGroupData.id= 1192; name= "Faction Auto-Targeting"; parentMarketGroupId= Some(115); typeIds= [| 27489; 27459; 27525; 27495; 27465; 27501; 27471; 27507; 27477; 27513; 27483; 27519 |]; description= "Faction auto-targeting designs." } |> Some
      | 1483 -> { MarketGroupData.id= 1483; name= "Implant Slot 09"; parentMarketGroupId= Some(1479); typeIds= [| 27107; 13263; 3088; 3089; 3092; 16248 |]; description= "Implant Slot 09" } |> Some
      | 1580 -> { MarketGroupData.id= 1580; name= "Remote Sensor Boosters"; parentMarketGroupId= Some(1578); typeIds= [| 11798 |]; description= "Remote Sensor Boosters" } |> Some
      | 1774 -> { MarketGroupData.id= 1774; name= "Implant Slot 10"; parentMarketGroupId= Some(1763); typeIds= [| 27260 |]; description= "Implant Slot 10" } |> Some
      | 1968 -> { MarketGroupData.id= 1968; name= "Capital Ships"; parentMarketGroupId= Some(1954); typeIds= [|  |]; description= "" } |> Some
      | 2065 -> { MarketGroupData.id= 2065; name= "Heavy Assault Cruisers"; parentMarketGroupId= Some(2064); typeIds= [|  |]; description= "" } |> Some
      | 2162 -> { MarketGroupData.id= 2162; name= "Electronics and Sensor Upgrades"; parentMarketGroupId= Some(2158); typeIds= [|  |]; description= "" } |> Some
      | 2259 -> { MarketGroupData.id= 2259; name= "Advanced Long Range XL Torpedoes"; parentMarketGroupId= Some(505); typeIds= [| 41272; 41274; 41276; 41270 |]; description= "Advanced Long Range Torpedoes" } |> Some
      | 2356 -> { MarketGroupData.id= 2356; name= "Gallente"; parentMarketGroupId= Some(2309); typeIds= [| 50146; 46403; 47528; 44909; 45891; 42165; 46552; 45564; 46941 |]; description= "" } |> Some
      | 2453 -> { MarketGroupData.id= 2453; name= "Small Engineering Mutaplasmids"; parentMarketGroupId= Some(2440); typeIds= [| 48416; 48417; 48418; 48428; 47821; 47822; 47823; 48430; 48429 |]; description= "Small Engineering Mutaplasmids" } |> Some
      | 354563 -> { MarketGroupData.id= 354563; name= "Heavy Machine Guns"; parentMarketGroupId= Some(364049); typeIds= [|  |]; description= "Heavy Machine guns." } |> Some
      | 366203 -> { MarketGroupData.id= 366203; name= "Standard"; parentMarketGroupId= Some(366175); typeIds= [|  |]; description= "" } |> Some
      | 368919 -> { MarketGroupData.id= 368919; name= "Heat Sinks"; parentMarketGroupId= Some(368918); typeIds= [|  |]; description= "" } |> Some
      | 416 -> { MarketGroupData.id= 416; name= ""; parentMarketGroupId= Some(414); typeIds= [| 967 |]; description= "" } |> Some
      | 610 -> { MarketGroupData.id= 610; name= "Medium"; parentMarketGroupId= Some(552); typeIds= [| 10850; 32772; 20619; 19181; 19183; 19185; 10866; 19187; 10868; 19189; 10870; 19191; 10872; 10836; 15899; 13949; 13950; 15903 |]; description= "Cruiser-class shield boosters." } |> Some
      | 707 -> { MarketGroupData.id= 707; name= "Tracking Enhancers"; parentMarketGroupId= Some(143); typeIds= [| 1998; 1999; 14640; 14642; 14100; 6325; 14646; 14644; 15965; 1951 |]; description= "Hardwired systems designed to improve turret tracking." } |> Some
      | 901 -> { MarketGroupData.id= 901; name= "Caldari"; parentMarketGroupId= Some(882); typeIds= [| 11960; 11958 |]; description= "Blueprints of Caldari recon ship designs." } |> Some
      | 998 -> { MarketGroupData.id= 998; name= "Faction Light Missiles"; parentMarketGroupId= Some(117); typeIds= [| 27361; 27365; 27367; 27369; 27371; 27375; 27385; 27379; 27381; 27383; 27353; 27387 |]; description= "Faction issue light missiles." } |> Some
      | _ -> None