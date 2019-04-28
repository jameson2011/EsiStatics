namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups84=
    let getGroup id = 
      match id with 
      | 1054 -> { GroupData.id= 1054; name= "Incursion Sansha's Nation Cruiser"; categoryId= 11; published= false; typeIds= [| 2191; 2207; 2208; 2209; 2859; 2931; 2936; 2950; 3511; 3527 |] } |> Some
      | 1151 -> { GroupData.id= 1151; name= "Armor Resistance Shift Hardener Blueprint"; categoryId= 9; published= true; typeIds= [| 4404; 41657; 41658; 41659; 41660 |] } |> Some
      | 1248 -> { GroupData.id= 1248; name= "Empire Bounty Reimbursement Tags"; categoryId= 17; published= true; typeIds= [| 33482; 33483; 33484; 33485; 33597; 33598; 33599; 33600; 33601; 33602; 33603; 33604; 33605; 33606; 33607; 33612 |] } |> Some
      | 1442 -> { GroupData.id= 1442; name= "Structure Warp Scrambler"; categoryId= 66; published= true; typeIds= [| 35949; 47334 |] } |> Some
      | 1830 -> { GroupData.id= 1830; name= "Structure Engineering Rig M - Advanced Small Ship ME"; categoryId= 66; published= true; typeIds= [| 43854; 43855 |] } |> Some
      | 1927 -> { GroupData.id= 1927; name= "Irregular Structure"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 2024 -> { GroupData.id= 2024; name= "Fluorite"; categoryId= 25; published= false; typeIds= [| 50015 |] } |> Some
      | 278 -> { GroupData.id= 278; name= "Social"; categoryId= 16; published= true; typeIds= [| 3355; 3356; 3357; 3358; 3359; 3361; 3362; 3893; 3894; 3895 |] } |> Some
      | 375 -> { GroupData.id= 375; name= "Advanced Pulse Laser Crystal"; categoryId= 8; published= true; typeIds= [| 12561; 12563; 12565; 12810; 12812; 12814; 12816; 12818; 12820; 41330; 41332 |] } |> Some
      | 472 -> { GroupData.id= 472; name= "System Scanner"; categoryId= 7; published= true; typeIds= [| 17696; 17873; 17884; 21047 |] } |> Some
      | 569 -> { GroupData.id= 569; name= "Asteroid Sansha's Nation Officer"; categoryId= 11; published= false; typeIds= [| 13609; 13615; 13622; 13635 |] } |> Some
      | 666 -> { GroupData.id= 666; name= "Mission Amarr Empire Battlecruiser"; categoryId= 11; published= false; typeIds= [| 24956; 24957; 24958; 24959; 24960; 24962; 28169; 28170; 30737; 30738; 50110; 50111 |] } |> Some
      | 763 -> { GroupData.id= 763; name= "Nanofiber Internal Structure"; categoryId= 7; published= true; typeIds= [| 1242; 2603; 2605; 5559; 5561; 5591; 5593; 5595; 5597; 5599; 5601; 14127; 15813; 21500 |] } |> Some
      | 860 -> { GroupData.id= 860; name= "Starbase - Energy Neutralizing Battery Blueprints"; categoryId= 9; published= true; typeIds= [| 2799; 27875; 27876; 27877; 27878 |] } |> Some
      | 957 -> { GroupData.id= 957; name= "Propulsion Systems"; categoryId= 32; published= true; typeIds= [| 45610; 45611; 45612; 45613; 45614; 45615; 45616; 45617; 45618; 45619; 45620; 45621 |] } |> Some
      | _ -> None