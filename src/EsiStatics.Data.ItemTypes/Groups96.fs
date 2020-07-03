namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups96=
    let getGroup id = 
      match id with 
      | 1454 -> { GroupData.id= 1454; name= "Irregular Fighter"; categoryId= 11; published= false; typeIds= [| 47276; 47277 |] } |> Some
      | 1551 -> { GroupData.id= 1551; name= "Structure Warp Disruptor Script"; categoryId= 8; published= true; typeIds= [| 47336 |] } |> Some
      | 1648 -> { GroupData.id= 1648; name= "OLD Structure Resource Rig L - Ore Reprocessing"; categoryId= 66; published= false; typeIds= [| 37282; 37283 |] } |> Some
      | 1842 -> { GroupData.id= 1842; name= "Structure Engineering Rig M - Invention Cost Optimization"; categoryId= 66; published= true; typeIds= [| 43878; 43879 |] } |> Some
      | 193 -> { GroupData.id= 193; name= "Phobia Handicap"; categoryId= 14; published= false; typeIds= [| 1628; 1629; 1630; 1631; 1632; 1633; 1634; 1635 |] } |> Some
      | 1939 -> { GroupData.id= 1939; name= "Structure Reactor Rig L - Efficiency"; categoryId= 66; published= true; typeIds= [| 46496; 46497 |] } |> Some
      | 290 -> { GroupData.id= 290; name= "Remote Sensor Booster"; categoryId= 7; published= true; typeIds= [| 1963; 1964; 5279; 5280; 5281; 5282; 22925; 22939; 22941; 41198; 41199 |] } |> Some
      | 387 -> { GroupData.id= 387; name= "Rocket"; categoryId= 8; published= true; typeIds= [| 266; 2512; 2514; 2516; 27313; 27315; 27317; 27319; 27321; 27323; 27325; 27327; 27329; 27331; 27333; 27335; 27883; 27884 |] } |> Some
      | 4073 -> { GroupData.id= 4073; name= "Temporary Collidable Structure"; categoryId= 11; published= false; typeIds= [| 50176; 50177; 50178; 50179; 50180; 53836; 53838; 54197; 54198 |] } |> Some
      | 484 -> { GroupData.id= 484; name= "Complex Reactions"; categoryId= 24; published= true; typeIds= [| 17962; 17963; 17964; 17965; 17966; 17967; 17968; 17969; 17970; 17971; 17972; 33363; 33364; 33365; 33366 |] } |> Some
      | 581 -> { GroupData.id= 581; name= "Asteroid Sansha's Nation Destroyer"; categoryId= 11; published= false; typeIds= [| 23378; 23379; 23405; 23406; 23407; 23408 |] } |> Some
      | 678 -> { GroupData.id= 678; name= "Mission Gallente Federation Cruiser"; categoryId= 11; published= false; typeIds= [| 11661; 12440; 15325; 24271; 25147; 25149; 25150; 25152; 25154; 25156; 25158; 25160; 25161; 25162; 25179; 25180; 25181; 25182; 25183; 25184; 25185; 25186; 25820; 29775; 29776; 29777; 29778; 29779; 29780; 29781; 29782; 29783; 29784; 29785; 29786; 30725; 30726; 30727; 30728; 45466 |] } |> Some
      | 775 -> { GroupData.id= 775; name= "Rig Energy Weapon"; categoryId= 7; published= true; typeIds= [| 25968; 25970; 25972; 25974; 25976; 25978; 25980; 26378; 26380; 26382; 26384; 26386; 26388; 26390; 31418; 31420; 31422; 31424; 31426; 31428; 31430; 31432; 31434; 31436; 31438; 31440; 31442; 31444; 31446; 31448; 31450; 31452; 31454; 31456; 31458; 31460; 31462; 31464; 31466; 31468; 31470; 31472; 31474; 31476; 31478; 31480; 31482; 31484; 31486; 31488; 31490; 31492; 31494; 31496; 31498; 31500 |] } |> Some
      | 872 -> { GroupData.id= 872; name= "Outpost Improvements"; categoryId= 5; published= true; typeIds= [| 28076; 28077; 28078; 28079; 28080; 28081; 28082; 28083; 28084; 28085; 28086; 28087; 28088; 28089; 28090; 28091; 28092; 28093; 28094; 28095; 28096; 28097; 28098; 28099; 28100; 28101; 28102; 28103; 28104; 28105; 28106; 28107; 28108; 28109; 28110; 28111; 28112; 28113; 28114; 28115; 28116; 28117; 28118; 28119; 28120; 28121; 28122; 28123; 28124; 28125; 28126; 28127; 28128; 28129; 28130; 28131; 28132; 28133; 28134; 28135 |] } |> Some
      | 96 -> { GroupData.id= 96; name= "Automated Targeting System"; categoryId= 7; published= true; typeIds= [| 1182; 1436; 6041; 6043; 6045; 6047 |] } |> Some
      | _ -> None