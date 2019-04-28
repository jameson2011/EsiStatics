namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups64=
    let getGroup id = 
      match id with 
      | 1034 -> { GroupData.id= 1034; name= "Refined Commodities - Tier 2"; categoryId= 43; published= true; typeIds= [| 44; 2312; 2317; 2319; 2321; 2327; 2328; 2329; 2463; 3689; 3691; 3693; 3695; 3697; 3725; 3775; 3828; 9830; 9832; 9836; 9838; 9840; 9842; 15317 |] } |> Some
      | 1228 -> { GroupData.id= 1228; name= "Cyber Targeting"; categoryId= 20; published= true; typeIds= [| 3268; 3269; 3270; 3274; 3275; 3276; 10244; 13233; 27130; 27131; 27227; 27229 |] } |> Some
      | 1325 -> { GroupData.id= 1325; name= "Structure Administration Service Module"; categoryId= 66; published= false; typeIds= [| 35916; 35917; 35918; 35919; 35920 |] } |> Some
      | 161 -> { GroupData.id= 161; name= "Passive Targeting System Blueprint"; categoryId= 9; published= true; typeIds= [| 1212; 2342 |] } |> Some
      | 1616 -> { GroupData.id= 1616; name= "Structure Combat Rig M - Energy Neutralizer Cap Reduction"; categoryId= 66; published= true; typeIds= [| 37222; 37223 |] } |> Some
      | 1810 -> { GroupData.id= 1810; name= "Command Burst Charge Blueprint"; categoryId= 9; published= true; typeIds= [| 42874; 42875; 42876; 42877; 42878; 42879; 42880; 42881; 42882; 42883; 42884; 42885; 42886; 42887; 42888 |] } |> Some
      | 2004 -> { GroupData.id= 2004; name= "Citizen Mining Laser"; categoryId= 7; published= false; typeIds= [| 48780 |] } |> Some
      | 258 -> { GroupData.id= 258; name= "Fleet Support"; categoryId= 16; published= true; typeIds= [| 3348; 3349; 3350; 3351; 3352; 3354; 11569; 11572; 11574; 20494; 20495; 22536; 22552; 24764; 43728 |] } |> Some
      | 355 -> { GroupData.id= 355; name= "Refinables"; categoryId= 17; published= true; typeIds= [| 11724; 11725; 11732; 11733; 11734; 11735; 11736; 11737; 11738; 11739; 11740; 11741 |] } |> Some
      | 452 -> { GroupData.id= 452; name= "Crokite"; categoryId= 25; published= true; typeIds= [| 1225; 17432; 17433; 26851; 28391; 28392; 28393; 28624; 46677; 46693 |] } |> Some
      | 549 -> { GroupData.id= 549; name= "Fighter Drone"; categoryId= 18; published= false; typeIds= [|  |] } |> Some
      | 646 -> { GroupData.id= 646; name= "Drone Tracking Modules"; categoryId= 7; published= true; typeIds= [| 23533; 24438; 31942; 32935; 32937; 32939; 32941; 33826; 41031; 41032 |] } |> Some
      | 743 -> { GroupData.id= 743; name= "Cyber Production"; categoryId= 20; published= true; typeIds= [| 27167; 27170; 27171 |] } |> Some
      | 840 -> { GroupData.id= 840; name= "Structure Repair Array"; categoryId= 23; published= false; typeIds= [| 27676 |] } |> Some
      | 937 -> { GroupData.id= 937; name= "Decorations"; categoryId= 29; published= false; typeIds= [| 2733; 29495; 29496; 29497; 29530 |] } |> Some
      | _ -> None