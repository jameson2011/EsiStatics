namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups90=
    let getGroup id = 
      match id with 
      | 1157 -> { GroupData.id= 1157; name= "Fueled Shield Booster Blueprint"; categoryId= 9; published= true; typeIds= [| 4392; 32773; 32775; 32781; 41638 |] } |> Some
      | 1545 -> { GroupData.id= 1545; name= "Structure Management"; categoryId= 16; published= true; typeIds= [| 3373; 11584; 37796; 37797; 37798; 37799 |] } |> Some
      | 1642 -> { GroupData.id= 1642; name= "Structure Combat Rig XL - Doomsday and Targeting"; categoryId= 66; published= true; typeIds= [| 37274; 37275 |] } |> Some
      | 1739 -> { GroupData.id= 1739; name= "Skill Injectors"; categoryId= 5; published= true; typeIds= [| 40520; 42523; 43630; 45635; 46375; 49703; 49704 |] } |> Some
      | 1836 -> { GroupData.id= 1836; name= "Structure Engineering Rig M - Advanced Component ME"; categoryId= 66; published= true; typeIds= [| 43866; 43867; 45640 |] } |> Some
      | 1933 -> { GroupData.id= 1933; name= "Structure Composite Reactor Rig M - TE"; categoryId= 66; published= true; typeIds= [| 46484; 46485 |] } |> Some
      | 284 -> { GroupData.id= 284; name= "Biohazard"; categoryId= 17; published= true; typeIds= [| 3771; 3773; 4091; 19398; 20510; 26777; 29504 |] } |> Some
      | 381 -> { GroupData.id= 381; name= "Elite Battleship"; categoryId= 6; published= false; typeIds= [|  |] } |> Some
      | 478 -> { GroupData.id= 478; name= "System Scanner Blueprint"; categoryId= 9; published= true; typeIds= [| 17874; 17885 |] } |> Some
      | 575 -> { GroupData.id= 575; name= "Asteroid Angel Cartel Destroyer"; categoryId= 11; published= false; typeIds= [| 22812; 22813; 22814; 22815; 22816; 22817 |] } |> Some
      | 672 -> { GroupData.id= 672; name= "Mission Caldari State Battlecruiser"; categoryId= 11; published= false; typeIds= [| 25063; 25064; 25065; 25066; 25067; 25069; 28172; 28173; 32390 |] } |> Some
      | 769 -> { GroupData.id= 769; name= "Reactor Control Unit"; categoryId= 7; published= true; typeIds= [| 1351; 1353; 1355; 8251; 8253; 8257; 8259; 8261; 8263; 8265; 14128; 14130; 14132; 15112; 15114; 15116; 15118; 15120; 15122; 15124; 15126; 15300; 15302; 15304; 15306; 17522; 23898; 28776 |] } |> Some
      | 866 -> { GroupData.id= 866; name= "Mission Caldari State Carrier"; categoryId= 11; published= false; typeIds= [| 27719 |] } |> Some
      | 90 -> { GroupData.id= 90; name= "Bomb"; categoryId= 8; published= true; typeIds= [| 27912; 27916; 27918; 27920; 41548; 41549; 41550; 41551 |] } |> Some
      | 963 -> { GroupData.id= 963; name= "Strategic Cruiser"; categoryId= 6; published= true; typeIds= [| 29984; 29986; 29988; 29990 |] } |> Some
      | _ -> None