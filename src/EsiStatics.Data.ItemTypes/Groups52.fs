namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups52=
    let getGroup id = 
      match id with 
      | 1022 -> { GroupData.id= 1022; name= "Prototype Exploration Ship"; categoryId= 6; published= true; typeIds= [| 2078 |] } |> Some
      | 1216 -> { GroupData.id= 1216; name= "Engineering"; categoryId= 16; published= true; typeIds= [| 3318; 3413; 3417; 3418; 3421; 3423; 3424; 3426; 3432; 11204; 11207; 24572; 28164; 28879; 28880; 32797 |] } |> Some
      | 1313 -> { GroupData.id= 1313; name= "Entosis Link"; categoryId= 7; published= true; typeIds= [| 34593; 34595; 34826; 40307; 40308; 40309; 40310 |] } |> Some
      | 1410 -> { GroupData.id= 1410; name= "Advertisement Center"; categoryId= 65; published= false; typeIds= [| 37535; 37536 |] } |> Some
      | 1604 -> { GroupData.id= 1604; name= "Structure Laboratory Rig L - Module, Consumable, Drone"; categoryId= 66; published= false; typeIds= [| 37196; 37197 |] } |> Some
      | 1701 -> { GroupData.id= 1701; name= "Flex Armor Hardener Script"; categoryId= 8; published= true; typeIds= [| 41517; 41518; 41519; 41520 |] } |> Some
      | 1798 -> { GroupData.id= 1798; name= "Hidden Zenith Minmatar Battleship"; categoryId= 11; published= false; typeIds= [| 42826 |] } |> Some
      | 1895 -> { GroupData.id= 1895; name= "Irregular Industrial"; categoryId= 11; published= false; typeIds= [| 48119; 48132; 49793; 56943 |] } |> Some
      | 1992 -> { GroupData.id= 1992; name= "Entropic Radiation Sink Blueprint"; categoryId= 9; published= true; typeIds= [| 48095; 48096; 52243; 52245 |] } |> Some
      | 343 -> { GroupData.id= 343; name= "Weapon Disruptor Blueprint"; categoryId= 9; published= true; typeIds= [| 11614; 11844; 22932; 22934; 40338; 40339 |] } |> Some
      | 4029 -> { GroupData.id= 4029; name= "Talassonite"; categoryId= 25; published= true; typeIds= [| 52306; 56625; 56626 |] } |> Some
      | 440 -> { GroupData.id= 440; name= "Sensor Dampening Battery"; categoryId= 23; published= true; typeIds= [| 17180; 27778; 27779 |] } |> Some
      | 52 -> { GroupData.id= 52; name= "Warp Scrambler"; categoryId= 7; published= true; typeIds= [| 447; 448; 3242; 3244; 5399; 5401; 5403; 5405; 5439; 5441; 5443; 5445; 14242; 14244; 14246; 14248; 14250; 14252; 14254; 14256; 14258; 14260; 14656; 14658; 14660; 14662; 14664; 14666; 14668; 14670; 15431; 15433; 15887; 15889; 15891; 15893; 16140; 21510; 21512; 22476; 28516; 28518; 32459; 40730; 40731; 40732; 40733; 40734; 40736; 40737; 40750; 40752; 40754; 40756; 40758; 40762; 40764; 41061; 41062; 47732; 47736; 56303; 56304 |] } |> Some
      | 537 -> { GroupData.id= 537; name= "Dreadnought Blueprint"; categoryId= 9; published= true; typeIds= [| 19721; 19723; 19725; 19727; 34340; 34342; 34344; 34346; 42136; 45044; 45646; 53029 |] } |> Some
      | 731 -> { GroupData.id= 731; name= "Decryptors - Caldari"; categoryId= 35; published= true; typeIds= [| 21573; 21574; 21575; 21576; 21577; 33319; 33322; 33325 |] } |> Some
      | 828 -> { GroupData.id= 828; name= "Mission Generic Battle Cruisers"; categoryId= 11; published= false; typeIds= [| 26959 |] } |> Some
      | 925 -> { GroupData.id= 925; name= "FW Infrastructure Hub"; categoryId= 11; published= false; typeIds= [| 29286; 29302; 29303; 29304 |] } |> Some
      | _ -> None