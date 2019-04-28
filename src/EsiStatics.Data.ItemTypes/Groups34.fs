namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups34=
    let getGroup id = 
      match id with 
      | 1004 -> { GroupData.id= 1004; name= "Defense Bunkers"; categoryId= 40; published= false; typeIds= [|  |] } |> Some
      | 1198 -> { GroupData.id= 1198; name= "Orbital Target"; categoryId= 2; published= true; typeIds= [| 33069 |] } |> Some
      | 1295 -> { GroupData.id= 1295; name= "Mobile Decoy Unit Blueprint"; categoryId= 9; published= true; typeIds= [| 33588 |] } |> Some
      | 131 -> { GroupData.id= 131; name= "ECCM Blueprint"; categoryId= 9; published= true; typeIds= [| 11622; 11623; 11624; 11625; 11626; 11750; 11754; 11758; 11762; 11766; 11770; 11771; 20219; 20225; 20231; 20237; 22898; 48949 |] } |> Some
      | 1586 -> { GroupData.id= 1586; name= "Structure Assembly Rig M - Module"; categoryId= 66; published= false; typeIds= [|  |] } |> Some
      | 1683 -> { GroupData.id= 1683; name= "Asteroid Blood Raider Dreadnought"; categoryId= 11; published= false; typeIds= [| 37463; 41397 |] } |> Some
      | 1974 -> { GroupData.id= 1974; name= "Structure Festival Launcher"; categoryId= 66; published= true; typeIds= [| 47303 |] } |> Some
      | 325 -> { GroupData.id= 325; name= "Remote Armor Repairer"; categoryId= 7; published= true; typeIds= [| 3536; 11355; 11357; 11359; 16433; 16435; 16437; 16439; 16441; 16443; 16445; 16447; 16449; 16451; 16453; 16455; 18981; 18983; 18985; 18987; 18989; 18991; 19047; 19049; 19051; 19053; 19055; 19057; 22947; 22949; 22951; 23414; 23416; 24569; 26912; 26913; 26914; 32469; 41463; 41464; 41465; 41466; 41467; 41468 |] } |> Some
      | 422 -> { GroupData.id= 422; name= "Gas Isotopes"; categoryId= 4; published= false; typeIds= [| 16258; 16259; 16260; 16261; 25411; 25412; 25413; 25414 |] } |> Some
      | 519 -> { GroupData.id= 519; name= "Terran Artifacts"; categoryId= 25; published= false; typeIds= [|  |] } |> Some
      | 810 -> { GroupData.id= 810; name= "Asteroid Sansha's Nation Commander Frigate"; categoryId= 11; published= false; typeIds= [| 13610; 13612; 13616; 13617; 13623; 13625; 13627; 13628; 13629; 13632 |] } |> Some
      | 907 -> { GroupData.id= 907; name= "Tracking Script"; categoryId= 8; published= true; typeIds= [| 28999; 29001 |] } |> Some
      | _ -> None