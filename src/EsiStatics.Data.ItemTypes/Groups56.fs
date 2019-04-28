namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups56=
    let getGroup id = 
      match id with 
      | 1026 -> { GroupData.id= 1026; name= "Extractors"; categoryId= 41; published= true; typeIds= [| 2409; 2412; 2413; 2414; 2415; 2416; 2417; 2418; 2419; 2422; 2423; 2424; 2425; 2426; 2427; 2428; 2429; 2430; 2431; 2432; 2433; 2434; 2435; 2438; 2439; 2440; 2441; 2442; 2443; 2448; 2449; 2450; 2451; 2452; 2453; 2458; 2459; 2460; 2461; 2462 |] } |> Some
      | 1123 -> { GroupData.id= 1123; name= "Salvager Blueprint"; categoryId= 9; published= true; typeIds= [| 25862; 26984; 30837 |] } |> Some
      | 1220 -> { GroupData.id= 1220; name= "Neural Enhancement"; categoryId= 16; published= true; typeIds= [| 3405; 3411; 24242; 24606; 25530; 25538; 33399; 33407 |] } |> Some
      | 1317 -> { GroupData.id= 1317; name= "Infrastructure Upgrade Blueprint"; categoryId= 9; published= true; typeIds= [| 34841; 34842; 34843; 34844; 34845; 34846; 34847; 34848; 34849; 34850; 34851; 34852; 34853; 34854; 34855; 34856; 34857; 34858; 34859; 34860; 34861; 34862; 34863; 34864; 34865; 34866; 34867; 34868; 34869 |] } |> Some
      | 1414 -> { GroupData.id= 1414; name= "Amarr Navy Roaming Frigate"; categoryId= 11; published= false; typeIds= [| 35820 |] } |> Some
      | 1608 -> { GroupData.id= 1608; name= "Structure Laboratory Rig L - Structure Component"; categoryId= 66; published= false; typeIds= [| 37206; 37207 |] } |> Some
      | 1996 -> { GroupData.id= 1996; name= "Abyssal Materials"; categoryId= 4; published= true; typeIds= [| 47975; 48080; 48112 |] } |> Some
      | 347 -> { GroupData.id= 347; name= "Signal Amplifier Blueprint"; categoryId= 9; published= true; typeIds= [| 11634; 11812; 11820; 11821; 11824; 11825; 11828; 11829; 11832; 11833; 11836; 11837; 20239; 20241; 20243; 20245; 20247; 20249; 20251; 20253; 20255; 20261; 20263; 20265; 21522; 21524; 21526; 21528; 21530 |] } |> Some
      | 368656 -> { GroupData.id= 368656; name= "Battle Salvage"; categoryId= 350001; published= false; typeIds= [| 366967; 366968; 366969; 366970; 366971 |] } |> Some
      | 444 -> { GroupData.id= 444; name= "Shield Hardening Array"; categoryId= 23; published= true; typeIds= [| 17184; 17185; 17186; 17187 |] } |> Some
      | 541 -> { GroupData.id= 541; name= "Interdictor"; categoryId= 6; published= true; typeIds= [| 22452; 22456; 22460; 22464 |] } |> Some
      | 56 -> { GroupData.id= 56; name= "Missile Launcher"; categoryId= 7; published= false; typeIds= [|  |] } |> Some
      | 638 -> { GroupData.id= 638; name= "Navigation Computer"; categoryId= 7; published= false; typeIds= [|  |] } |> Some
      | 735 -> { GroupData.id= 735; name= "Decryptors - Talocan"; categoryId= 17; published= true; typeIds= [| 21074; 21077; 21084; 21085; 21087 |] } |> Some
      | 832 -> { GroupData.id= 832; name= "Logistics"; categoryId= 6; published= true; typeIds= [| 11978; 11985; 11987; 11989; 32790; 42245; 49713 |] } |> Some
      | _ -> None