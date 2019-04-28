namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups77=
    let getGroup id = 
      match id with 
      | 1144 -> { GroupData.id= 1144; name= "Logistic Drone Blueprint"; categoryId= 9; published= true; typeIds= [| 22766; 23524; 23710; 23712; 23718; 23720; 28198; 28200; 28202; 28204; 28206; 28208; 33672; 33705; 33707; 33709; 33711; 33713 |] } |> Some
      | 1241 -> { GroupData.id= 1241; name= "Planet Management"; categoryId= 16; published= true; typeIds= [| 2403; 2406; 2495; 2505; 13279 |] } |> Some
      | 1629 -> { GroupData.id= 1629; name= "Structure Combat Rig L - Missile Application and Projection"; categoryId= 66; published= true; typeIds= [| 37248; 37249 |] } |> Some
      | 1726 -> { GroupData.id= 1726; name= "Irregular Carrier"; categoryId= 11; published= false; typeIds= [| 47180; 47181 |] } |> Some
      | 174 -> { GroupData.id= 174; name= "Mine Blueprint"; categoryId= 9; published= true; typeIds= [| 1217; 3734; 3736; 3738 |] } |> Some
      | 1823 -> { GroupData.id= 1823; name= "Structure Engineering Rig M - Drone and Fighter TE"; categoryId= 66; published= true; typeIds= [| 37148; 37149 |] } |> Some
      | 1920 -> { GroupData.id= 1920; name= "Common Moon Asteroids"; categoryId= 25; published= true; typeIds= [| 45494; 45495; 45496; 45497; 46288; 46289; 46290; 46291; 46292; 46293; 46294; 46295 |] } |> Some
      | 2017 -> { GroupData.id= 2017; name= "Upwell Cyno Beacon"; categoryId= 65; published= true; typeIds= [| 35840 |] } |> Some
      | 368 -> { GroupData.id= 368; name= "Global Warp Disruptor"; categoryId= 2; published= false; typeIds= [| 12293 |] } |> Some
      | 465 -> { GroupData.id= 465; name= "Ice"; categoryId= 25; published= true; typeIds= [| 16262; 16263; 16264; 16265; 16266; 16267; 16268; 16269; 17975; 17976; 17977; 17978; 28433; 28434; 28435; 28436; 28437; 28438; 28439; 28440; 28441; 28442; 28443; 28444; 28627; 28628 |] } |> Some
      | 562 -> { GroupData.id= 562; name= "Asteroid Guristas Frigate"; categoryId= 11; published= false; typeIds= [| 2382; 2383; 2384; 2385; 2386; 10266; 11027; 11028; 11029; 11030; 13041; 13042; 13043; 13044; 21974; 21975; 21976; 21977; 21978; 21979; 21980; 21981; 21982; 21983; 23330; 23331; 23332; 23333; 23334; 23335; 25806 |] } |> Some
      | 659 -> { GroupData.id= 659; name= "Supercarrier"; categoryId= 6; published= true; typeIds= [| 3514; 3628; 22852; 23913; 23917; 23919; 42125 |] } |> Some
      | 756 -> { GroupData.id= 756; name= "Asteroid Rogue Drone Battleship"; categoryId= 11; published= false; typeIds= [| 25648; 25650; 25651; 25652; 25653; 25662; 25665; 25675; 25699; 25700 |] } |> Some
      | 77 -> { GroupData.id= 77; name= "Shield Hardener"; categoryId= 7; published= true; typeIds= [| 578; 2050; 2281; 2289; 2291; 2293; 2295; 2297; 2299; 2301; 2303; 4345; 4346; 4347; 4348; 4349; 9608; 9622; 9632; 9646; 9660; 13965; 13966; 13967; 13968; 13969; 13994; 13995; 13996; 13997; 13998; 14748; 14749; 14750; 14751; 14752; 14753; 14754; 14755; 14756; 14757; 14758; 14759; 14760; 14761; 14762; 14763; 14764; 14765; 14766; 14767; 15407; 15418; 17495; 17496; 17497; 17498; 17499; 19257; 19258; 19259; 19260; 19261; 19262; 19263; 19264; 19265; 19266; 19267; 19268; 19269; 19270; 19271; 19272; 19273; 19274; 19275; 19276; 19277; 19278; 19279; 19280; 19281; 19282; 19283; 19284; 19285; 19286; 19287; 19288; 20633; 20635; 20637; 20639; 20641; 30342; 30420; 30422; 30424 |] } |> Some
      | 853 -> { GroupData.id= 853; name= "Starbase - Laser Battery Blueprints"; categoryId= 9; published= true; typeIds= [| 2825; 2826; 2827; 2828; 2829; 2830; 27807; 27808; 27809; 27810; 27811; 27812; 27813; 27814; 27815; 27816; 27817; 27818; 27819; 27820; 27821; 27822; 27823; 27824; 27825; 27826; 27827; 27828; 27829; 27830 |] } |> Some
      | _ -> None