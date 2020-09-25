namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups73=
    let getGroup id = 
      match id with 
      | 170 -> { GroupData.id= 170; name= "Defender Missile Blueprint"; categoryId= 9; published= true; typeIds= [| 32783 |] } |> Some
      | 1722 -> { GroupData.id= 1722; name= "Roaming Serpentis Frigate"; categoryId= 11; published= false; typeIds= [| 42141 |] } |> Some
      | 1819 -> { GroupData.id= 1819; name= "Structure Engineering Rig M - Equipment TE"; categoryId= 66; published= true; typeIds= [| 37160; 37161 |] } |> Some
      | 2013 -> { GroupData.id= 2013; name= "Stasis Nullifiers"; categoryId= 7; published= true; typeIds= [| 48944 |] } |> Some
      | 267 -> { GroupData.id= 267; name= "Obsolete Books"; categoryId= 17; published= false; typeIds= [| 3374; 3375; 3376; 3377; 3378; 3379; 3404; 12376; 12383; 12385; 12386; 12387; 16546; 16547; 16548; 16549; 16550; 16551; 16552 |] } |> Some
      | 364 -> { GroupData.id= 364; name= "Mobile Storage"; categoryId= 23; published= false; typeIds= [| 12240; 16219 |] } |> Some
      | 4050 -> { GroupData.id= 4050; name= "Abyssal Proving Filaments"; categoryId= 17; published= true; typeIds= [| 53965; 54951; 55808; 55819; 55820; 55821; 55822; 55823; 55824; 55825; 55982; 55983; 56092; 56093; 56094; 56353; 56354; 56355; 56356; 56357; 56358; 56359; 56360; 56361 |] } |> Some
      | 461 -> { GroupData.id= 461; name= "Spodumain"; categoryId= 25; published= true; typeIds= [| 19; 17466; 17467; 28418; 28419; 28420; 46688; 46704 |] } |> Some
      | 558 -> { GroupData.id= 558; name= "Asteroid Blood Raiders Hauler"; categoryId= 11; published= false; typeIds= [| 13690; 13691; 13692; 13693; 13694; 13695; 13696; 13697; 13698; 13699; 13700; 13701; 24381; 24382; 24383; 24384 |] } |> Some
      | 655 -> { GroupData.id= 655; name= "Advanced Heavy Missile"; categoryId= 8; published= true; typeIds= [| 2629; 2655; 24507; 24509; 24511; 24513; 24515; 24517 |] } |> Some
      | 849 -> { GroupData.id= 849; name= "Asteroid Blood Raiders Commander Battleship"; categoryId= 11; published= false; typeIds= [| 13556; 13559; 13560; 13562; 13563; 13572; 23299; 23300; 23301; 23302 |] } |> Some
      | _ -> None