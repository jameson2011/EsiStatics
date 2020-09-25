namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups71=
    let getGroup id = 
      match id with 
      | 1041 -> { GroupData.id= 1041; name= "Advanced Commodities - Tier 4"; categoryId= 43; published= true; typeIds= [| 2867; 2868; 2869; 2870; 2871; 2872; 2875; 2876 |] } |> Some
      | 1332 -> { GroupData.id= 1332; name= "Structure ECM Battery"; categoryId= 66; published= true; typeIds= [| 35940; 46577; 47338 |] } |> Some
      | 1429 -> { GroupData.id= 1429; name= "Structure Weapon Upgrade"; categoryId= 66; published= true; typeIds= [| 35959; 35962; 47340; 47342 |] } |> Some
      | 168 -> { GroupData.id= 168; name= "Frequency Crystal Blueprint"; categoryId= 9; published= true; typeIds= [| 1154; 1155; 1156; 1157; 1158; 1159; 1160; 1161; 1162; 1163; 1164; 1165; 1166; 1167; 1168; 1169; 1170; 1171; 1172; 1173; 1174; 1175; 1176; 1177; 17681; 17683; 17685; 17687; 17689; 17691; 17693; 17695; 23072; 32800 |] } |> Some
      | 1720 -> { GroupData.id= 1720; name= "Roaming Serpentis Battleship"; categoryId= 11; published= false; typeIds= [| 42139 |] } |> Some
      | 1914 -> { GroupData.id= 1914; name= "Structure Drilling Rig L - Proficiency"; categoryId= 66; published= true; typeIds= [| 46327; 46328 |] } |> Some
      | 459 -> { GroupData.id= 459; name= "Pyroxeres"; categoryId= 25; published= true; typeIds= [| 1224; 17459; 17460; 28424; 28425; 28426; 28618; 46686; 46702 |] } |> Some
      | 556 -> { GroupData.id= 556; name= "Asteroid Blood Raiders Battleship"; categoryId= 11; published= false; typeIds= [| 11905; 11906; 11907; 11908; 23265; 23266; 23267; 23268; 23269; 23270 |] } |> Some
      | 653 -> { GroupData.id= 653; name= "Advanced Light Missile"; categoryId= 8; published= true; typeIds= [| 2613; 2647; 24495; 24497; 24499; 24501; 24503; 24505 |] } |> Some
      | 71 -> { GroupData.id= 71; name= "Energy Neutralizer"; categoryId= 7; published= true; typeIds= [| 533; 4471; 4473; 4475; 4477; 12265; 12267; 12269; 12271; 13003; 14160; 14162; 14164; 14166; 14168; 14170; 14832; 14834; 14836; 14838; 14840; 14842; 14844; 14846; 15794; 15796; 15798; 15800; 15802; 15804; 16465; 16467; 16469; 16471; 16473; 16475; 16477; 16479; 23815; 23817; 23819; 37622; 37623; 37624; 37625; 37626; 37627; 37628; 37629; 37630; 37631; 40659; 40660; 40661; 40662; 40663; 40664; 47824; 47828; 47832; 56312 |] } |> Some
      | 750 -> { GroupData.id= 750; name= "Cyber Social"; categoryId= 20; published= true; typeIds= [| 27152; 27153; 27154; 27155; 27156; 27157; 27158; 27159; 27160; 27161; 27162; 27163; 27164; 27165; 27166; 27269; 27270; 27271; 27272; 27273 |] } |> Some
      | 847 -> { GroupData.id= 847; name= "Asteroid Rogue Drone Commander Frigate"; categoryId= 11; published= false; typeIds= [| 27754; 27755; 27756; 27757; 27758; 27759; 27760; 27761; 27762; 27763 |] } |> Some
      | 944 -> { GroupData.id= 944; name= "Capital Industrial Ship Blueprint"; categoryId= 9; published= true; typeIds= [| 28353; 33688 |] } |> Some
      | _ -> None