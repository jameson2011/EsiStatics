namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups91=
    let getGroup id = 
      match id with 
      | 1158 -> { GroupData.id= 1158; name= "Heavy Defender Missile"; categoryId= 8; published= false; typeIds= [| 265 |] } |> Some
      | 1255 -> { GroupData.id= 1255; name= "Ghost Sites Blood Raiders Cruiser"; categoryId= 11; published= true; typeIds= [| 33495; 33496; 33497; 33498 |] } |> Some
      | 1546 -> { GroupData.id= 1546; name= "Structure Anti-Capital Missile"; categoryId= 8; published= true; typeIds= [| 37843; 37844; 37845 |] } |> Some
      | 1837 -> { GroupData.id= 1837; name= "Structure Engineering Rig M - Advanced Component TE"; categoryId= 66; published= true; typeIds= [| 43868; 43869 |] } |> Some
      | 1934 -> { GroupData.id= 1934; name= "Structure Composite Reactor Rig M - ME"; categoryId= 66; published= true; typeIds= [| 46486; 46487 |] } |> Some
      | 285 -> { GroupData.id= 285; name= "CPU Enhancer"; categoryId= 7; published= true; typeIds= [| 3469; 3887; 3888; 8743; 8744; 8745; 8746; 8747; 8748; 8749; 8750; 14230; 14232; 14768; 14770; 14772; 14774; 15308; 15310; 15312; 15314; 15425; 15675; 15677; 20567; 20569; 28561 |] } |> Some
      | 382 -> { GroupData.id= 382; name= "Shipping Crates"; categoryId= 2; published= false; typeIds= [| 12847; 12850; 12851; 12852; 12853; 12854; 12856 |] } |> Some
      | 479 -> { GroupData.id= 479; name= "Scanner Probe"; categoryId= 8; published= true; typeIds= [| 30013; 30028; 30486; 30488; 32246 |] } |> Some
      | 576 -> { GroupData.id= 576; name= "Asteroid Angel Cartel BattleCruiser"; categoryId= 11; published= false; typeIds= [| 22822; 22823; 22824; 22825; 22826; 22827 |] } |> Some
      | 673 -> { GroupData.id= 673; name= "Mission Caldari State Cruiser"; categoryId= 11; published= false; typeIds= [| 2222; 11712; 12394; 15320; 15349; 16162; 22800; 25043; 25045; 25046; 25048; 25050; 25052; 25054; 25056; 25057; 25058; 25075; 25076; 25077; 25078; 25079; 25080; 25081; 25082; 29761; 29762; 29763; 29764; 29765; 29766; 29767; 29768; 29769; 29770; 29771; 29772; 30729; 30730; 30731; 30732; 30950; 45463 |] } |> Some
      | 770 -> { GroupData.id= 770; name= "Shield Flux Coil"; categoryId= 7; published= true; typeIds= [| 508; 1254; 1256; 8291; 8293; 8295; 8297; 8323; 8325; 8327; 8329; 37825 |] } |> Some
      | 867 -> { GroupData.id= 867; name= "Mission Gallente Federation Carrier"; categoryId= 11; published= false; typeIds= [| 27720 |] } |> Some
      | 964 -> { GroupData.id= 964; name= "Hybrid Tech Components"; categoryId= 17; published= true; typeIds= [| 29992; 29994; 29996; 30002; 30008; 30464; 30466; 30470; 30474; 30476; 30478; 34396; 45652; 45653; 45654; 45655 |] } |> Some
      | _ -> None