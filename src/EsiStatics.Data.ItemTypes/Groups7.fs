namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups7=
    let getGroup id = 
      match id with 
      | 104 -> { GroupData.id= 104; name= "Clone Blueprint"; categoryId= 9; published= true; typeIds= [| 681; 682 |] } |> Some
      | 1268 -> { GroupData.id= 1268; name= "Mobile Cynosural Inhibitor Blueprint"; categoryId= 9; published= true; typeIds= [| 33518; 34121 |] } |> Some
      | 1462 -> { GroupData.id= 1462; name= "Structure Blueprints"; categoryId= 9; published= true; typeIds= [| 36960; 36961; 36962; 36963; 36964; 36965; 36966; 36967; 36968; 36971; 36972; 36973; 36974; 36975; 36976; 36977; 36978; 36979; 36980; 36981; 37537; 37538; 37539; 37540; 40521; 49625; 49626 |] } |> Some
      | 1559 -> { GroupData.id= 1559; name= "Structure Resistance Switcher Script"; categoryId= 8; published= false; typeIds= [| 37826; 37827; 37828; 37829 |] } |> Some
      | 1850 -> { GroupData.id= 1850; name= "Structure Engineering Rig L - Equipment Efficiency"; categoryId= 66; published= true; typeIds= [| 37170; 37171 |] } |> Some
      | 201 -> { GroupData.id= 201; name= "ECM"; categoryId= 7; published= true; typeIds= [| 1948; 1955; 1956; 1957; 1958; 2559; 2563; 2567; 2571; 2575; 9518; 9519; 9520; 9521; 9522; 19923; 19925; 19927; 19929; 19931; 19933; 19935; 19937; 19939; 19942; 19944; 19946; 19948; 19950; 19952; 20199; 20201; 20203; 20205; 20207; 20573; 20575; 20577; 20579; 28729; 28731; 28733; 28735; 28737 |] } |> Some
      | 298 -> { GroupData.id= 298; name= "Convoy Drone"; categoryId= 11; published= false; typeIds= [| 9869; 10999; 11000; 11001; 11002 |] } |> Some
      | 395 -> { GroupData.id= 395; name= "Auto-Targeting Heavy Missile"; categoryId= 8; published= true; typeIds= [| 1818; 1820; 1822; 1824; 27481; 27483; 27485; 27487; 27489; 27491; 27493; 27495; 27497; 27499; 27501; 27503 |] } |> Some
      | 4081 -> { GroupData.id= 4081; name= "Disrupted Gate"; categoryId= 2; published= false; typeIds= [| 55926; 56232; 56233; 56234; 56235; 56236; 56237; 56238; 56239; 56240; 56241; 56242; 56243; 56244; 56245; 56246; 56247; 56248; 56249; 56250; 56251; 56252; 56253; 56254; 56255; 56256; 56257; 56258; 56259; 56260; 56261; 56262; 56263 |] } |> Some
      | 492 -> { GroupData.id= 492; name= "Survey Probe"; categoryId= 8; published= true; typeIds= [| 18626; 18635; 18637 |] } |> Some
      | 589 -> { GroupData.id= 589; name= "Interdiction Sphere Launcher"; categoryId= 7; published= true; typeIds= [| 22782 |] } |> Some
      | 686 -> { GroupData.id= 686; name= "Mission Minmatar Republic Other"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 7 -> { GroupData.id= 7; name= "Planet"; categoryId= 2; published= false; typeIds= [| 11; 12; 13; 2014; 2015; 2016; 2017; 2063; 30889; 56018; 56019; 56020; 56021; 56022; 56023; 56024 |] } |> Some
      | 783 -> { GroupData.id= 783; name= "Cyber X Specials"; categoryId= 20; published= true; typeIds= [| 22715; 22760 |] } |> Some
      | 880 -> { GroupData.id= 880; name= "Sleeper Components"; categoryId= 17; published= true; typeIds= [| 30744; 30745; 30746; 30747 |] } |> Some
      | 977 -> { GroupData.id= 977; name= "Hybrid Reactions"; categoryId= 24; published= true; typeIds= [| 30344; 30345; 30346; 30348; 30349; 30350; 30351; 30352; 30368 |] } |> Some
      | _ -> None