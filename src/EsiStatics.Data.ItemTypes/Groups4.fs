namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups4=
    let getGroup id = 
      match id with 
      | 101 -> { GroupData.id= 101; name= "Mining Drone"; categoryId= 18; published= true; typeIds= [| 1202; 3218; 10246; 10248; 10250; 10252; 41030; 43681; 43694; 43699; 43700; 43701 |] } |> Some
      | 1071 -> { GroupData.id= 1071; name= "Flashpoint"; categoryId= 2; published= true; typeIds= [|  |] } |> Some
      | 1168 -> { GroupData.id= 1168; name= "FW Gallente Federation Frigate"; categoryId= 11; published= true; typeIds= [| 32915 |] } |> Some
      | 1265 -> { GroupData.id= 1265; name= "Ghost Sites Sanshas Cruiser"; categoryId= 11; published= true; typeIds= [| 33503; 33504; 33505; 33506 |] } |> Some
      | 1653 -> { GroupData.id= 1653; name= "Heavy Fighter"; categoryId= 87; published= true; typeIds= [| 2948; 32325; 32340; 32342; 32344; 40362; 40363; 40364; 40365; 40560; 40561; 40562; 40563; 40564; 40565; 40566; 40567; 45673; 45675; 47038; 47039; 47116; 47117; 47118; 47119; 47120; 47121; 47122; 47123; 47124; 47125; 47126; 47127; 47128; 47129; 47130 |] } |> Some
      | 1847 -> { GroupData.id= 1847; name= "Structure Engineering Rig M - TE Research Accelerator"; categoryId= 66; published= true; typeIds= [| 43888; 43889 |] } |> Some
      | 1944 -> { GroupData.id= 1944; name= "Structure Resource Rig L - Reprocessing"; categoryId= 66; published= true; typeIds= [| 46639; 46640 |] } |> Some
      | 198 -> { GroupData.id= 198; name= "Minmatar Education"; categoryId= 14; published= false; typeIds= [| 1669; 1670; 1671; 1672; 1673; 1674 |] } |> Some
      | 295 -> { GroupData.id= 295; name= "Shield Resistance Amplifier"; categoryId= 7; published= true; typeIds= [| 1798; 1800; 1802; 1804; 1808; 2529; 2531; 2537; 2539; 2545; 2547; 2553; 9556; 9562; 9566; 9568; 9570; 9574; 9580; 9582; 14029; 14031; 14033; 14035; 14037; 14039; 14041; 14043; 14606; 14610; 14614; 14618; 14622; 14626; 14630; 14634; 14716; 14718; 14720; 14722; 14724; 14726; 14728; 14730; 14732; 14734; 14736; 14738; 14740; 14742; 14744; 14746; 15909; 15911; 15913; 15915; 15917; 15919; 15921; 15923; 19209; 19211; 19213; 19215; 19217; 19219; 19221; 19223; 19225; 19227; 19229; 19231; 19233; 19235; 19237; 19239; 19241; 19243; 19245; 19247; 19249; 19251; 19253; 19255; 20605; 20607; 20609; 20611 |] } |> Some
      | 4 -> { GroupData.id= 4; name= "Constellation"; categoryId= 2; published= false; typeIds= [| 4 |] } |> Some
      | 489 -> { GroupData.id= 489; name= "Battlecruiser Blueprint"; categoryId= 9; published= true; typeIds= [| 4305; 4307; 4309; 4311; 16228; 16230; 16232; 16234; 22443; 22445; 22447; 22449; 22467; 22469; 22471; 22475; 24697; 24699; 24701; 24703; 33152; 33154; 33156; 33158; 33327; 33870; 33872; 33874; 33876; 34474; 49715 |] } |> Some
      | 586 -> { GroupData.id= 586; name= "Drone Modules"; categoryId= 7; published= false; typeIds= [|  |] } |> Some
      | 683 -> { GroupData.id= 683; name= "Mission Minmatar Republic Frigate"; categoryId= 11; published= false; typeIds= [| 11639; 11665; 11745; 13105; 14354; 14360; 14480; 15342; 15581; 15973; 15974; 15975; 15976; 20163; 24777; 24779; 24781; 24784; 24785; 24786; 24787; 24790; 24791; 24793; 24811; 24812; 24813; 24814; 24815; 24816; 24817; 24818; 24819; 24820; 29876; 29878; 29879; 29881; 29882; 29883; 29884; 29885; 29886; 29887; 29888; 29889; 29891; 29892; 29893; 45467 |] } |> Some
      | 877 -> { GroupData.id= 877; name= "Target Painting Battery"; categoryId= 23; published= false; typeIds= [| 28191 |] } |> Some
      | 974 -> { GroupData.id= 974; name= "Hybrid Polymers"; categoryId= 4; published= true; typeIds= [| 30303; 30304; 30305; 30306; 30307; 30308; 30309; 30310; 30311 |] } |> Some
      | _ -> None