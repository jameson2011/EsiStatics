namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups82=
    let getGroup id = 
      match id with 
      | 1052 -> { GroupData.id= 1052; name= "Incursion Sansha's Nation Capital"; categoryId= 11; published= false; typeIds= [| 2192; 3071 |] } |> Some
      | 1149 -> { GroupData.id= 1149; name= "Mobile Jump Disruptor"; categoryId= 22; published= false; typeIds= [| 4386 |] } |> Some
      | 1246 -> { GroupData.id= 1246; name= "Mobile Depot"; categoryId= 22; published= true; typeIds= [| 33474; 33520; 33522 |] } |> Some
      | 1537 -> { GroupData.id= 1537; name= "Support Fighter"; categoryId= 87; published= true; typeIds= [| 37599; 40345; 40346; 40347; 40568; 40569; 40570; 40571; 45651; 47037; 47131; 47132; 47133; 47134; 47135; 47136; 47137 |] } |> Some
      | 1634 -> { GroupData.id= 1634; name= "Structure Combat Rig L - Point Defense Battery Application and Projection"; categoryId= 66; published= true; typeIds= [| 37258; 37259 |] } |> Some
      | 1731 -> { GroupData.id= 1731; name= "Irregular Super Carrier"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 1828 -> { GroupData.id= 1828; name= "Structure Engineering Rig M - Basic Large Ship ME"; categoryId= 66; published= true; typeIds= [| 37152; 43732 |] } |> Some
      | 1925 -> { GroupData.id= 1925; name= "Irregular Industrial Command Ship"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 2022 -> { GroupData.id= 2022; name= "Temporal Resources"; categoryId= 25; published= false; typeIds= [| 49789; 56950; 57027; 57028 |] } |> Some
      | 373 -> { GroupData.id= 373; name= "Advanced Railgun Charge"; categoryId= 8; published= true; typeIds= [| 12616; 12618; 12620; 12797; 12799; 12801; 12803; 12805; 12807; 41326; 41328 |] } |> Some
      | 470 -> { GroupData.id= 470; name= "Unanchoring Drone"; categoryId= 18; published= false; typeIds= [| 17565 |] } |> Some
      | 567 -> { GroupData.id= 567; name= "Asteroid Sansha's Nation Frigate"; categoryId= 11; published= false; typeIds= [| 10025; 10026; 10027; 10028; 10273; 11032; 11033; 11034; 11035; 13045; 13046; 13047; 13048; 23360; 23361; 23362; 23363; 23364; 23365 |] } |> Some
      | 761 -> { GroupData.id= 761; name= "Asteroid Rogue Drone Swarm"; categoryId= 11; published= false; typeIds= [| 25633; 25634; 25637; 25638; 25649; 25657; 25659; 25660; 25663; 25670; 25701; 25702 |] } |> Some
      | 82 -> { GroupData.id= 82; name= "Passive Targeting System"; categoryId= 7; published= true; typeIds= [| 581; 2341; 5865; 5867; 5869; 5871 |] } |> Some
      | 858 -> { GroupData.id= 858; name= "Starbase - Stasis Webification Battery Blueprints"; categoryId= 9; published= true; typeIds= [| 2741; 27871; 27872 |] } |> Some
      | 955 -> { GroupData.id= 955; name= "Depricated Subsystems"; categoryId= 17; published= false; typeIds= [| 29964; 29965; 29966; 29967; 29969; 29970; 29971; 29972; 29974; 29975; 29976; 29977; 29979; 29980; 29981; 29982; 30036; 30038; 30040; 30042; 30046; 30048; 30050; 30052; 30056; 30058; 30060; 30062; 30066; 30068; 30070; 30072; 30076; 30078; 30080; 30082; 30086; 30088; 30090; 30092; 30096; 30098; 30100; 30102; 30106; 30108; 30110; 30112; 30117; 30118; 30119; 30120; 30122; 30123; 30124; 30125; 30127; 30128; 30129; 30130; 30132; 30133; 30134; 30135; 30139; 30141; 30143; 30145; 30149; 30151; 30153; 30155; 30159; 30161; 30163; 30165; 30169; 30171; 30173; 30175 |] } |> Some
      | _ -> None