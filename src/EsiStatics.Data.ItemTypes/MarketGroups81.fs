namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups81=
    let getMarketGroup id = 
      match id with 
      | 1051 -> { MarketGroupData.id= 1051; name= "Large"; parentMarketGroupId= Some(134); typeIds= [| 14848; 4609; 14850; 13955; 13956; 4613; 14854; 14849; 17546; 15746; 14851; 14852; 14853; 28544; 14855; 15160; 15161; 15162; 15163; 33103; 13957; 3538; 3540; 14552; 14554; 19035; 19036; 19037; 19038; 19039; 19040; 19041; 19042; 19043; 19044; 19045; 19046; 22891; 14067; 23799; 17492; 15743 |]; description= "Armor repair designs, intended for battleship-class vessels." } |> Some
      | 1245 -> { MarketGroupData.id= 1245; name= "Large Drone Rigs"; parentMarketGroupId= Some(946); typeIds= [| 25921; 25925; 25909; 25911; 25913; 25915; 25917; 25919 |]; description= "Blueprints of Large Drone Rigs." } |> Some
      | 1342 -> { MarketGroupData.id= 1342; name= "Cynosural Generator Arrays"; parentMarketGroupId= Some(1841); typeIds= [|  |]; description= "Blueprints of Cynosural Generator Arrays." } |> Some
      | 1536 -> { MarketGroupData.id= 1536; name= "Armor Repairers"; parentMarketGroupId= Some(214); typeIds= [| 3529; 1099; 41614; 41615; 3539; 20702; 21854 |]; description= "Blueprints for Armor Repairers" } |> Some
      | 1633 -> { MarketGroupData.id= 1633; name= "Command Bursts"; parentMarketGroupId= Some(779); typeIds= [| 42528; 42529; 42530; 43555; 43556; 43554; 43552; 42527; 42526; 43551 |]; description= "Command Bursts" } |> Some
      | 1730 -> { MarketGroupData.id= 1730; name= "Capital Armor Rigs"; parentMarketGroupId= Some(956); typeIds= [| 33904; 31043; 31013; 31025; 31049; 31019; 33902; 31081; 30993; 31075; 31061; 31031; 27064; 31001; 27066; 31067; 31037; 31007 |]; description= "Modifications that affect a capital starship's armor." } |> Some
      | 1827 -> { MarketGroupData.id= 1827; name= "Rapid Heavy Missile Launchers"; parentMarketGroupId= Some(140); typeIds= [| 33440; 33441; 33442; 33446; 33448; 33450; 33452; 33453; 33454; 33455; 33456; 33457; 33458; 33459; 33461; 33462; 33463; 33464; 33465; 33466 |]; description= "" } |> Some
      | 1924 -> { MarketGroupData.id= 1924; name= "Expedition Frigates"; parentMarketGroupId= Some(1364); typeIds= [| 33697; 37135 |]; description= "" } |> Some
      | 2021 -> { MarketGroupData.id= 2021; name= "Caldari"; parentMarketGroupId= Some(1951); typeIds= [| 34828 |]; description= "" } |> Some
      | 2215 -> { MarketGroupData.id= 2215; name= "Weapon Disruptors"; parentMarketGroupId= Some(2206); typeIds= [| 35945; 47364 |]; description= "Weapon Disruptors" } |> Some
      | 2312 -> { MarketGroupData.id= 2312; name= "Special Battlecruisers"; parentMarketGroupId= Some(2311); typeIds= [| 47552; 44257; 47010; 49795; 47654; 47649; 43530; 52280; 47546; 47549 |]; description= "" } |> Some
      | 2409 -> { MarketGroupData.id= 2409; name= "Structure-based Fighters"; parentMarketGroupId= Some(2236); typeIds= [|  |]; description= "" } |> Some
      | 2506 -> { MarketGroupData.id= 2506; name= "Other"; parentMarketGroupId= Some(2488); typeIds= [| 3898 |]; description= "Other Boosters" } |> Some
      | 275 -> { MarketGroupData.id= 275; name= "Caldari"; parentMarketGroupId= Some(206); typeIds= [| 968; 977; 686; 687 |]; description= "Blueprints of Caldari cruiser designs." } |> Some
      | 372 -> { MarketGroupData.id= 372; name= "Rigging"; parentMarketGroupId= Some(150); typeIds= [| 26252; 26253; 26254; 26255; 26256; 26257; 26258; 26259; 26260; 26261 |]; description= "Skills pertaining to the fine tuning of a spaceship's installed systems" } |> Some
      | 469 -> { MarketGroupData.id= 469; name= "Standard Battlecruisers"; parentMarketGroupId= Some(1374); typeIds= [|  |]; description= "A class of powerful combat vessels midway between cruisers and battleships." } |> Some
      | 566 -> { MarketGroupData.id= 566; name= "Large"; parentMarketGroupId= Some(555); typeIds= [| 15817; 20591; 3090; 7447; 7449; 7451; 7453; 15818; 3114; 13874; 14387; 13876; 14389; 13878; 13879; 14393; 13882; 13883; 572; 14397; 574; 14399; 14401; 12354; 14403; 12356; 14405; 15814; 14407; 14280; 14409; 14282; 14391; 14284; 14413; 14286; 14415; 15834; 15837; 15838; 14395; 14411; 7407; 7409; 7411; 7413 |]; description= "Slow-tracking, high-damage railguns, for use on battleships." } |> Some
      | 663 -> { MarketGroupData.id= 663; name= "Remote Capacitor Transmitters"; parentMarketGroupId= Some(655); typeIds= [|  |]; description= "Systems allowing transfer of capacitor energy to another ship." } |> Some
      | 81 -> { MarketGroupData.id= 81; name= "Gallente"; parentMarketGroupId= Some(7); typeIds= [| 641; 24690; 645 |]; description= "Gallente battleship designs." } |> Some
      | 857 -> { MarketGroupData.id= 857; name= "Large"; parentMarketGroupId= Some(847); typeIds= [| 12779; 12775 |]; description= "Large ADAC ammunition, fired by battleship-sized guns." } |> Some
      | 954 -> { MarketGroupData.id= 954; name= "Shield Rigs"; parentMarketGroupId= Some(943); typeIds= [|  |]; description= "Permanent modification of a ship's shield facilities." } |> Some
      | _ -> None