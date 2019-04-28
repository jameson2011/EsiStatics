﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups57=
    let getGroup id = 
      match id with 
      | 1027 -> { GroupData.id= 1027; name= "Command Centers"; categoryId= 41; published= true; typeIds= [| 2129; 2130; 2131; 2132; 2133; 2134; 2135; 2136; 2137; 2138; 2139; 2140; 2141; 2142; 2143; 2144; 2145; 2146; 2147; 2148; 2149; 2150; 2151; 2152; 2153; 2154; 2155; 2156; 2157; 2158; 2159; 2160; 2254; 2524; 2525; 2533; 2534; 2549; 2550; 2551; 2574; 2576; 2577; 2578; 2581; 2582; 2585; 2586 |] } |> Some
      | 1318 -> { GroupData.id= 1318; name= "Entosis Link Blueprint"; categoryId= 9; published= true; typeIds= [| 34594; 34596; 40311; 40312; 40313; 40314 |] } |> Some
      | 1415 -> { GroupData.id= 1415; name= "Structure Engineering Service Module"; categoryId= 66; published= true; typeIds= [| 35877; 35878; 35881; 35886; 35891; 45550 |] } |> Some
      | 154 -> { GroupData.id= 154; name= "Hybrid Weapon Blueprint"; categoryId= 9; published= true; typeIds= [| 1112; 1113; 1114; 1115; 1116; 1117; 1118; 1119; 1120; 1121; 1122; 1123; 1124; 1125; 1126; 3075; 3083; 3091; 3099; 3107; 3115; 3123; 3131; 3139; 3147; 3155; 3163; 3171; 3179; 3187; 3547; 3557; 10679; 10681; 12345; 12347; 12355; 12357; 15819; 15822; 15839; 15842; 20449; 20451; 20588; 20590; 20592; 22900; 22902; 22904; 22906; 22908; 22910; 22912; 22914; 22916; 24621; 24623; 34279; 34281; 34283; 41085; 41086; 41087; 41088; 41089; 41090; 41091; 41132; 41133; 41134; 41135; 41136; 41137; 41143; 41144; 41145; 41146; 41147; 41148 |] } |> Some
      | 1609 -> { GroupData.id= 1609; name= "Structure Laboratory Rig L - Subsystem"; categoryId= 66; published= false; typeIds= [| 37208; 37209 |] } |> Some
      | 1706 -> { GroupData.id= 1706; name= "Capital Sensor Array"; categoryId= 7; published= true; typeIds= [| 41411 |] } |> Some
      | 1803 -> { GroupData.id= 1803; name= "♦ Frigate"; categoryId= 11; published= false; typeIds= [| 42841; 42842; 42843; 42845; 42846; 43563; 43564; 43565; 43566; 43567; 43574; 43575; 43576; 43577; 43578; 43585; 43586; 43587; 43588; 43589; 43596; 43597; 43598; 43599; 43600; 43614; 43615; 43616; 43617; 43618; 43633; 43634; 43635; 43636; 43638; 43644; 43645; 43646; 43647; 43648; 43653; 43654; 43655; 44107; 44108; 44953; 45680; 46052; 46053; 46058; 46061; 46066; 46070; 46074; 46078; 46382; 47194; 47195; 47196; 47197 |] } |> Some
      | 1997 -> { GroupData.id= 1997; name= "Abyssal Drone Entities"; categoryId= 11; published= false; typeIds= [| 47847; 47848; 47849; 47850; 47851; 47852; 47853; 47854; 47855; 47856; 47857; 47858; 47859; 47860; 48253; 48262; 48263; 48264; 48265 |] } |> Some
      | 348 -> { GroupData.id= 348; name= "Armor Hardener Blueprint"; categoryId= 9; published= true; typeIds= [| 11278; 11302; 11304; 11306; 11643; 11645; 11647; 11649; 15706; 15708; 15710; 15712; 15714; 15716; 15718; 15720; 17503; 17505; 17507; 17509; 17833; 17835; 17837; 17839; 28523; 28525; 28527; 28529 |] } |> Some
      | 445 -> { GroupData.id= 445; name= "Force Field Array"; categoryId= 23; published= false; typeIds= [| 17188 |] } |> Some
      | 57 -> { GroupData.id= 57; name= "Shield Power Relay"; categoryId= 7; published= true; typeIds= [| 1419; 1422; 2331; 8331; 8333; 8335; 8337; 8339; 8341; 8343; 8345; 37820 |] } |> Some
      | 639 -> { GroupData.id= 639; name= "Electronic Warfare Drone"; categoryId= 18; published= true; typeIds= [| 23473; 23506; 23510; 23512; 23705; 23707; 23713; 23715; 23721; 23723; 23725; 23727 |] } |> Some
      | 833 -> { GroupData.id= 833; name= "Force Recon Ship"; categoryId= 6; published= true; typeIds= [| 11957; 11963; 11965; 11969; 33395; 33675; 44995; 45531; 48635 |] } |> Some
      | _ -> None