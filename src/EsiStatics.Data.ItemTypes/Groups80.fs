namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups80=
    let getGroup id = 
      match id with 
      | 1147 -> { GroupData.id= 1147; name= "Stasis Webifying Drone Blueprint"; categoryId= 9; published= true; typeIds= [| 23537; 23730; 23732 |] } |> Some
      | 1535 -> { GroupData.id= 1535; name= "Structure Signal Amplifier"; categoryId= 66; published= true; typeIds= [| 37532; 47348 |] } |> Some
      | 1632 -> { GroupData.id= 1632; name= "Structure Combat Rig L - EW Projection and Cap Reduction"; categoryId= 66; published= true; typeIds= [| 37254; 37255 |] } |> Some
      | 1729 -> { GroupData.id= 1729; name= "Roaming Angel Cartel Frigate"; categoryId= 11; published= false; typeIds= [| 42144 |] } |> Some
      | 177 -> { GroupData.id= 177; name= "Mining Drone Blueprint"; categoryId= 9; published= true; typeIds= [| 1218; 10247; 10251; 43911; 43912; 43913; 43914; 43915; 43916; 43934 |] } |> Some
      | 1826 -> { GroupData.id= 1826; name= "Structure Engineering Rig M - Basic Medium Ship ME"; categoryId= 66; published= true; typeIds= [| 37146; 37147 |] } |> Some
      | 1923 -> { GroupData.id= 1923; name= "Exceptional Moon Asteroids"; categoryId= 25; published= true; typeIds= [| 45510; 45511; 45512; 45513; 46312; 46313; 46314; 46315; 46316; 46317; 46318; 46319 |] } |> Some
      | 2020 -> { GroupData.id= 2020; name= "Cynosural Fields"; categoryId= 2; published= false; typeIds= [| 21094; 52696 |] } |> Some
      | 274 -> { GroupData.id= 274; name= "Trade"; categoryId= 16; published= true; typeIds= [| 3443; 3444; 3445; 3446; 3447; 3448; 11015; 12834; 13069; 13070; 13071; 13072; 13073; 13074; 13075; 16594; 16595; 16596; 16597; 16598; 16622; 18580; 25233; 25235; 28261; 33467 |] } |> Some
      | 371 -> { GroupData.id= 371; name= "Mobile Warp Disruptor Blueprint"; categoryId= 9; published= true; typeIds= [| 4387; 12297; 12300; 12301; 26850; 26889; 26891; 26893; 28771; 28773; 28775 |] } |> Some
      | 4057 -> { GroupData.id= 4057; name= "Masks"; categoryId= 30; published= true; typeIds= [| 54714; 54715; 54716; 54718; 54719; 54720; 54830 |] } |> Some
      | 468 -> { GroupData.id= 468; name= "Mercoxit"; categoryId= 25; published= true; typeIds= [| 11396; 17869; 17870; 28412; 28413; 28414; 28626 |] } |> Some
      | 565 -> { GroupData.id= 565; name= "Asteroid Sansha's Nation Battleship"; categoryId= 11; published= false; typeIds= [| 11913; 11914; 11915; 11916; 23372; 23373; 23374; 23375; 23376; 23377 |] } |> Some
      | 662 -> { GroupData.id= 662; name= "Complex Biochemical Reactions"; categoryId= 24; published= true; typeIds= [| 25240; 25282; 25289; 25290; 25291; 25292; 25293; 25294; 25295; 25296; 25297; 25298; 25299; 25300; 25301; 25302 |] } |> Some
      | 759 -> { GroupData.id= 759; name= "Asteroid Rogue Drone Frigate"; categoryId= 11; published= false; typeIds= [| 25636; 25641; 25645; 25656; 25658; 25667; 25668; 25674; 25676; 25679; 25681; 25684; 25686; 25687; 25689; 25690; 25691; 25692; 25693; 25698 |] } |> Some
      | 80 -> { GroupData.id= 80; name= "Burst Jammer"; categoryId= 7; published= true; typeIds= [| 580; 2117; 5359; 5361; 5363; 5365; 20581; 40690; 40691; 40692; 40693; 40694 |] } |> Some
      | 856 -> { GroupData.id= 856; name= "Starbase - ECM Jamming Array Blueprints"; categoryId= 9; published= true; typeIds= [| 2792; 2794; 2796; 2798; 27859; 27860; 27861; 27862; 27863; 27864; 27865; 27866 |] } |> Some
      | _ -> None