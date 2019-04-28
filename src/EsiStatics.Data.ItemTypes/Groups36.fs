namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups36=
    let getGroup id = 
      match id with 
      | 1006 -> { GroupData.id= 1006; name= "Mission Faction Cruiser"; categoryId= 11; published= false; typeIds= [| 2224; 29235; 29238; 29241; 29244; 32457; 32785 |] } |> Some
      | 1200 -> { GroupData.id= 1200; name= "Fueled Armor Repairer Blueprint"; categoryId= 9; published= true; typeIds= [| 33077; 33102; 33104; 41620 |] } |> Some
      | 1297 -> { GroupData.id= 1297; name= "Mobile Vault"; categoryId= 22; published= true; typeIds= [| 34120 |] } |> Some
      | 133 -> { GroupData.id= 133; name= "Energy Weapon Blueprint"; categoryId= 9; published= true; typeIds= [| 834; 835; 836; 837; 838; 839; 840; 841; 842; 843; 844; 845; 846; 847; 848; 2986; 2994; 3002; 3010; 3018; 3026; 3034; 3042; 3050; 3058; 3066; 3286; 3513; 3521; 3560; 3562; 4148; 20445; 20447; 23835; 23837; 23839; 23841; 23843; 23845; 23847; 23849; 23851; 34273; 34275; 34277; 41068; 41069; 41070; 41071; 41072; 41073; 41074; 41075; 41105; 41106; 41107; 41108; 41110; 41111; 41113; 41120; 41121; 41122; 41123; 41124; 41125; 41186 |] } |> Some
      | 1588 -> { GroupData.id= 1588; name= "Structure Assembly Rig L - Tech I Ship"; categoryId= 66; published= false; typeIds= [|  |] } |> Some
      | 1685 -> { GroupData.id= 1685; name= "Asteroid Guristas Dreadnought"; categoryId= 11; published= false; typeIds= [| 37465; 41398 |] } |> Some
      | 1879 -> { GroupData.id= 1879; name= "♦ Force Auxiliary"; categoryId= 11; published= false; typeIds= [| 45473 |] } |> Some
      | 1976 -> { GroupData.id= 1976; name= "Structure Festival Charges"; categoryId= 8; published= true; typeIds= [| 47300; 47301 |] } |> Some
      | 521 -> { GroupData.id= 521; name= "Identification"; categoryId= 17; published= true; typeIds= [| 20476; 20477; 20478; 20479; 20480; 20481; 21808; 21809; 21810; 21811; 21812; 21813; 22095; 22194; 22203; 22204; 23878; 27276 |] } |> Some
      | 715 -> { GroupData.id= 715; name= "Destructible Agents In Space"; categoryId= 11; published= false; typeIds= [| 21161; 23952; 25351; 25365; 25368; 25371; 25392; 25396; 25409; 25531; 25532; 25533; 25534; 25535; 30908 |] } |> Some
      | 812 -> { GroupData.id= 812; name= "Asteroid Serpentis Commander Cruiser"; categoryId= 11; published= false; typeIds= [| 13637; 13638; 13639; 13641; 13651; 13656; 13663; 13664; 13668; 13669 |] } |> Some
      | 909 -> { GroupData.id= 909; name= "Tracking Disruption Script"; categoryId= 8; published= true; typeIds= [| 29005; 29007 |] } |> Some
      | _ -> None