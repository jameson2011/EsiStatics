namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups20=
    let getGroup id = 
      match id with 
      | 1087 -> { GroupData.id= 1087; name= "Mid Layer"; categoryId= 30; published= false; typeIds= [|  |] } |> Some
      | 1184 -> { GroupData.id= 1184; name= "FW Caldari State Battlecruiser"; categoryId= 11; published= true; typeIds= [| 32972 |] } |> Some
      | 1766 -> { GroupData.id= 1766; name= "♦ Mining Exhumer"; categoryId= 11; published= false; typeIds= [| 42535; 49964 |] } |> Some
      | 1863 -> { GroupData.id= 1863; name= "Structure Engineering Rig L - Invention Optimization"; categoryId= 66; published= true; typeIds= [| 43722; 43723 |] } |> Some
      | 20 -> { GroupData.id= 20; name= "Drug"; categoryId= 4; published= false; typeIds= [|  |] } |> Some
      | 311 -> { GroupData.id= 311; name= "Reprocessing Array"; categoryId= 23; published= true; typeIds= [| 12238; 19470 |] } |> Some
      | 408 -> { GroupData.id= 408; name= "Drone Upgrade Blueprint"; categoryId= 9; published= true; typeIds= [| 23528; 23534; 24284; 24396; 24418; 24428; 24439; 31943; 33823; 33825; 41413; 41416; 41418 |] } |> Some
      | 505 -> { GroupData.id= 505; name= "Fake Skills"; categoryId= 16; published= false; typeIds= [| 20127 |] } |> Some
      | 602 -> { GroupData.id= 602; name= "Deadspace Blood Raiders BattleCruiser"; categoryId= 11; published= false; typeIds= [| 2072; 24000; 24009; 24010; 24011; 24012; 24013; 24181; 24182; 24183; 24184; 24185; 24186 |] } |> Some
      | 699 -> { GroupData.id= 699; name= "Mission Mordu Frigate"; categoryId= 11; published= false; typeIds= [| 16019; 16020; 16021; 16022; 16023; 16024; 16040; 16703 |] } |> Some
      | 796 -> { GroupData.id= 796; name= "Asteroid Blood Raiders Commander Destroyer"; categoryId= 11; published= false; typeIds= [| 23287; 23288; 23289; 23290; 23291; 23292 |] } |> Some
      | 893 -> { GroupData.id= 893; name= "Electronic Attack Ship"; categoryId= 6; published= true; typeIds= [| 11174; 11190; 11194; 11387 |] } |> Some
      | 990 -> { GroupData.id= 990; name= "Sleeper Electronics Relics"; categoryId= 34; published= true; typeIds= [| 30599; 30600; 30605 |] } |> Some
      | _ -> None