namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups58=
    let getGroup id = 
      match id with 
      | 1028 -> { GroupData.id= 1028; name= "Processors"; categoryId= 41; published= true; typeIds= [| 2469; 2470; 2471; 2472; 2473; 2474; 2475; 2480; 2481; 2482; 2483; 2484; 2485; 2490; 2491; 2492; 2493; 2494 |] } |> Some
      | 1222 -> { GroupData.id= 1222; name= "ECM Stabilizer Blueprint"; categoryId= 9; published= true; typeIds= [| 25562; 25564 |] } |> Some
      | 1319 -> { GroupData.id= 1319; name= "Miscellaneous"; categoryId= 29; published= false; typeIds= [| 60; 34870 |] } |> Some
      | 1416 -> { GroupData.id= 1416; name= "Structure Research Service Module"; categoryId= 66; published= false; typeIds= [| 35888; 35889; 35890 |] } |> Some
      | 1610 -> { GroupData.id= 1610; name= "Structure Laboratory Rig XL - Equipment"; categoryId= 66; published= false; typeIds= [| 37210; 37211 |] } |> Some
      | 1707 -> { GroupData.id= 1707; name= "Structure Module Blueprint"; categoryId= 9; published= true; typeIds= [| 37008; 37020; 37022; 37023; 37028; 37029; 37030; 37032; 37034; 37041; 37043; 37044; 37045; 37047; 37048; 37060; 37066; 37080; 37081; 37083; 37087; 37541; 43925; 43926; 43927; 43928; 43929; 45540; 45541; 45542; 45551; 46576; 46578; 47107; 47109; 47110; 47111; 47112; 47113; 47114; 47115; 47322; 47324; 47326; 47328; 47331; 47333; 47335; 47339; 47341; 47343; 47345; 47346; 47349; 47350; 47354; 47355; 47357; 47359; 47361; 47363; 47365; 47367; 47369 |] } |> Some
      | 1804 -> { GroupData.id= 1804; name= "Hidden Zenith Amarr Capital"; categoryId= 11; published= false; typeIds= [| 42844; 50097; 50106; 52329 |] } |> Some
      | 1998 -> { GroupData.id= 1998; name= "Station Conversion Monuments"; categoryId= 2; published= false; typeIds= [| 48270; 48271; 48272; 48273; 48274; 48275; 48276; 48277; 48278; 48279; 48280; 48281; 48282; 48283; 48284; 48285; 48286; 48287; 48288; 48289; 48290; 48291; 48292; 48293; 48294; 48295; 48296; 48297; 48298; 48299; 48300; 48301; 48302; 48303; 48304; 48305; 48306; 48307; 48308; 48309; 48310; 48311; 48312; 48313; 48314; 48315; 48316; 48317; 48318; 48319; 48320; 48321; 48322; 48323; 48324; 48325; 48326; 48327; 48328; 48329; 48330; 48331; 48332; 48333; 48334; 48335; 48336; 48337; 48338; 48339; 48340; 48341; 48342; 48343; 48344; 48345; 48346; 48347; 48348; 48349; 48350; 48351; 48352; 48353; 48354; 48355; 48356; 48357; 48358; 48359; 48360; 48361; 48362; 48363; 48364 |] } |> Some
      | 349 -> { GroupData.id= 349; name= "Armor Reinforcer Blueprint"; categoryId= 9; published= true; typeIds= [| 11280; 11292; 11294; 11296; 11298; 11300; 20344; 20346; 20348; 20350; 20352; 20354; 23784; 23786; 23788; 23790; 23792; 23794; 28779; 28781; 28783; 28785; 28787; 31897; 31899; 31901; 31903; 31905; 31907; 31909; 31911; 31917; 31919; 41607; 41608; 41609; 41610; 41611; 41612; 41613 |] } |> Some
      | 4035 -> { GroupData.id= 4035; name= "Retaliating Caldari Entities"; categoryId= 11; published= false; typeIds= [| 52932; 52933; 52934; 52935; 52936; 52937; 52938; 52939; 52940; 52965 |] } |> Some
      | 446 -> { GroupData.id= 446; name= "Customs Official"; categoryId= 11; published= false; typeIds= [| 17286; 19365; 19366; 19367; 19368; 19369; 19370; 19371; 19372; 19383; 19384; 19385; 19386; 19387; 19388; 19563; 19564 |] } |> Some
      | 543 -> { GroupData.id= 543; name= "Exhumer"; categoryId= 6; published= true; typeIds= [| 22544; 22546; 22548; 33683 |] } |> Some
      | 640 -> { GroupData.id= 640; name= "Logistic Drone"; categoryId= 18; published= true; typeIds= [| 22765; 23523; 23709; 23711; 23717; 23719; 28197; 28199; 28201; 28203; 28205; 28207; 33671; 33704; 33706; 33708; 33710; 33712 |] } |> Some
      | 737 -> { GroupData.id= 737; name= "Gas Cloud Harvester"; categoryId= 7; published= true; typeIds= [| 25266; 25540; 25542; 25812; 28788 |] } |> Some
      | 834 -> { GroupData.id= 834; name= "Stealth Bomber"; categoryId= 6; published= true; typeIds= [| 11377; 12032; 12034; 12038; 45530 |] } |> Some
      | _ -> None