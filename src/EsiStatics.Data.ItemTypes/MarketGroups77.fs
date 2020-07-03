namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups77=
    let getMarketGroup id = 
      match id with 
      | 1047 -> { MarketGroupData.id= 1047; name= "Capital Industrial Ships"; parentMarketGroupId= Some(1381); typeIds= [|  |]; description= "Capital ships designed to be the industrial backbone of any fleet." } |> Some
      | 1241 -> { MarketGroupData.id= 1241; name= "Medium Astronautic Rigs"; parentMarketGroupId= Some(945); typeIds= [| 31108; 31144; 31180; 31120; 31156; 31192; 31162; 31132; 34269 |]; description= "Blueprints of Medium Astronautic Rigs." } |> Some
      | 1338 -> { MarketGroupData.id= 1338; name= "Structures"; parentMarketGroupId= Some(2); typeIds= [|  |]; description= "Blueprints of structures in space" } |> Some
      | 1532 -> { MarketGroupData.id= 1532; name= "Medium Scout Drones"; parentMarketGroupId= Some(1530); typeIds= [| 2184; 48745; 15509; 2174; 15511 |]; description= "Blueprints of medium scout drone designs." } |> Some
      | 1726 -> { MarketGroupData.id= 1726; name= "Capital Hybrid Weapon Rigs"; parentMarketGroupId= Some(951); typeIds= [| 31555; 31531; 31567; 31507; 31543; 31579; 31519 |]; description= "Blueprints of Capital Hybrid Weapon Rigs." } |> Some
      | 1823 -> { MarketGroupData.id= 1823; name= "Planet Management"; parentMarketGroupId= Some(150); typeIds= [| 13279; 2505; 2403; 2406; 2495 |]; description= "Skills required for the control and remote operation of planetary colonies" } |> Some
      | 1920 -> { MarketGroupData.id= 1920; name= "Fuel Blocks"; parentMarketGroupId= Some(800); typeIds= [| 4313; 4314; 4315; 4316 |]; description= "" } |> Some
      | 2017 -> { MarketGroupData.id= 2017; name= "Strategic Upgrades"; parentMarketGroupId= Some(2015); typeIds= [| 34865; 34866; 34867; 34868 |]; description= "Blueprints of Strategic Upgrades" } |> Some
      | 2114 -> { MarketGroupData.id= 2114; name= "Capital Industrial Ships"; parentMarketGroupId= Some(1968); typeIds= [|  |]; description= "" } |> Some
      | 2211 -> { MarketGroupData.id= 2211; name= "Electronic Counter Measures"; parentMarketGroupId= Some(2206); typeIds= [| 46577; 47338; 35940 |]; description= "" } |> Some
      | 2308 -> { MarketGroupData.id= 2308; name= "Amarr"; parentMarketGroupId= Some(2307); typeIds= [| 45752; 44146; 55332; 42909; 42543 |]; description= "" } |> Some
      | 2502 -> { MarketGroupData.id= 2502; name= "Booster Slot 11"; parentMarketGroupId= Some(977); typeIds= [|  |]; description= "Booster Slot 11" } |> Some
      | 368 -> { MarketGroupData.id= 368; name= "Engineering"; parentMarketGroupId= Some(150); typeIds= [| 3424; 3426; 28164; 11207; 3432; 32797; 28879; 28880; 3413; 3318; 3417; 3418; 24572; 3421; 3423 |]; description= "Skills pertaining to management of a spaceship's hardware" } |> Some
      | 465 -> { MarketGroupData.id= 465; name= "Amarr"; parentMarketGroupId= Some(464); typeIds= [| 32874; 16236 |]; description= "Amarr destroyer designs." } |> Some
      | 562 -> { MarketGroupData.id= 562; name= "Medium"; parentMarketGroupId= Some(556); typeIds= [| 7703; 7705; 7707; 7709; 566; 568; 569; 3130; 13884; 13885; 3138; 7619; 13892; 7621; 7623; 7625; 3146; 15830; 15831; 15832; 34280; 7663; 7665; 7667; 7669; 22905; 22907; 22909 |]; description= "Medium-sized blasters, for use on cruisers." } |> Some
      | 659 -> { MarketGroupData.id= 659; name= "Reactor Control Units"; parentMarketGroupId= Some(655); typeIds= [| 15112; 15114; 15116; 15118; 15120; 15122; 15124; 15126; 8263; 14128; 14130; 14132; 15300; 15302; 1351; 15304; 1353; 15306; 1355; 23898; 28776; 17522 |]; description= "Run power core optimization subroutines for maximum efficiency." } |> Some
      | 77 -> { MarketGroupData.id= 77; name= "Gallente"; parentMarketGroupId= Some(5); typeIds= [| 608; 609; 592; 593; 594; 607 |]; description= "Gallente frigate designs." } |> Some
      | 853 -> { MarketGroupData.id= 853; name= "Advanced Pulse Laser Crystals"; parentMarketGroupId= Some(101); typeIds= [|  |]; description= "Technologically advanced pulse laser crystals." } |> Some
      | 950 -> { MarketGroupData.id= 950; name= "Energy Weapon Rigs"; parentMarketGroupId= Some(943); typeIds= [|  |]; description= "Permanent modification of a ship's energy weapon facilities." } |> Some
      | _ -> None