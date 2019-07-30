namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups53=
    let getGroup id = 
      match id with 
      | 1023 -> { GroupData.id= 1023; name= "Fighter Bomber"; categoryId= 18; published= false; typeIds= [|  |] } |> Some
      | 1217 -> { GroupData.id= 1217; name= "Scanning"; categoryId= 16; published= true; typeIds= [| 3412; 3551; 13278; 21718; 25739; 25810; 25811 |] } |> Some
      | 1314 -> { GroupData.id= 1314; name= "Unknown Components"; categoryId= 17; published= true; typeIds= [| 34540; 34541; 34542; 34543; 34544; 34545; 34546; 34547; 34548; 34549; 34551; 34552; 34553; 34554; 34555; 34556; 34557; 34558; 34559; 34560; 34575; 36902; 40541; 42640 |] } |> Some
      | 1411 -> { GroupData.id= 1411; name= "Amarr Navy Roaming Cruiser"; categoryId= 11; published= false; typeIds= [| 35814; 35815 |] } |> Some
      | 1605 -> { GroupData.id= 1605; name= "Structure Laboratory Rig L - Ship"; categoryId= 66; published= false; typeIds= [| 37198; 37199 |] } |> Some
      | 1702 -> { GroupData.id= 1702; name= "Flex Shield Hardener Script"; categoryId= 8; published= true; typeIds= [| 41521; 41522; 41523; 41524 |] } |> Some
      | 1799 -> { GroupData.id= 1799; name= "Hidden Zenith Minmatar Cruiser"; categoryId= 11; published= false; typeIds= [| 42827 |] } |> Some
      | 1896 -> { GroupData.id= 1896; name= "♦ Industrial Command "; categoryId= 11; published= false; typeIds= [| 46046; 46047; 46048; 46049; 48134 |] } |> Some
      | 1993 -> { GroupData.id= 1993; name= "Exotic Plasma Charge Blueprint"; categoryId= 9; published= true; typeIds= [| 48097; 48098; 48099; 48102; 48103; 48104; 48107; 48108; 48109 |] } |> Some
      | 344 -> { GroupData.id= 344; name= "Tracking Enhancer Blueprint"; categoryId= 9; published= true; typeIds= [| 11616; 11848; 15966 |] } |> Some
      | 4030 -> { GroupData.id= 4030; name= "Rakovene"; categoryId= 25; published= false; typeIds= [| 52315 |] } |> Some
      | 441 -> { GroupData.id= 441; name= "Stasis Webification Battery"; categoryId= 23; published= true; typeIds= [| 17178; 27570; 27573 |] } |> Some
      | 53 -> { GroupData.id= 53; name= "Energy Weapon"; categoryId= 7; published= true; typeIds= [| 450; 451; 452; 453; 454; 455; 456; 457; 458; 459; 460; 461; 462; 463; 464; 2985; 2993; 3001; 3009; 3017; 3025; 3033; 3041; 3049; 3057; 3065; 3285; 3512; 3520; 3559; 3561; 3634; 3636; 3638; 3640; 4044; 4045; 4049; 4147; 5175; 5177; 5179; 5181; 5215; 5217; 5219; 5221; 6631; 6633; 6635; 6637; 6671; 6673; 6675; 6677; 6715; 6717; 6719; 6721; 6757; 6759; 6761; 6763; 6805; 6807; 6809; 6811; 6859; 6861; 6863; 6865; 6919; 6921; 6923; 6925; 6959; 6961; 6963; 6965; 6999; 7001; 7003; 7005; 7043; 7045; 7047; 7049; 7083; 7085; 7087; 7089; 7123; 7125; 7127; 7131; 7167; 7169; 7171; 7173; 13791; 13793; 13795; 13797; 13799; 13801; 13803; 13805; 13807; 13809; 13811; 13813; 13815; 13817; 13819; 13820; 13821; 13822; 13823; 13824; 13825; 13826; 13827; 13828; 13829; 13830; 13831; 13832; 13833; 13834; 14417; 14419; 14421; 14423; 14425; 14427; 14429; 14431; 14433; 14435; 14437; 14439; 14441; 14443; 14445; 14447; 14449; 14451; 14453; 14455; 15399; 15401; 15403; 15427; 15429; 15845; 15846; 15847; 15848; 15849; 15850; 15851; 15852; 15853; 15854; 15855; 15856; 15857; 15858; 15859; 15860; 15861; 15862; 15863; 15864; 15865; 15866; 15867; 15868; 15869; 15870; 15871; 15872; 15873; 15874; 16128; 16129; 16131; 20444; 20446; 23834; 23836; 23838; 23840; 23842; 23844; 23846; 23848; 23850; 34271; 34272; 34274; 34276; 34580; 37290; 37296; 37297; 37298; 37299; 41063; 41064; 41065; 41066; 41067; 41099; 41100; 41101; 41102; 41103; 41104; 41114; 41115; 41116; 41117; 41118; 41119; 47446; 52264 |] } |> Some
      | 538 -> { GroupData.id= 538; name= "Data Miners"; categoryId= 7; published= true; typeIds= [| 3581; 3793; 22175; 22177; 22325; 22327; 22329; 22331; 22333; 22335; 22337; 22339; 27014; 27019; 30832; 30834; 41533; 41534; 49791 |] } |> Some
      | 732 -> { GroupData.id= 732; name= "Decryptors - Sleepers"; categoryId= 17; published= true; typeIds= [| 21568; 21569; 21570; 21571; 21572 |] } |> Some
      | 829 -> { GroupData.id= 829; name= "Mission Generic Destroyers"; categoryId= 11; published= false; typeIds= [| 27295; 27296; 27297; 27298 |] } |> Some
      | _ -> None