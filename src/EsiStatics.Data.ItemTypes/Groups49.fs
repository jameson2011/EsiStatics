namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups49=
    let getGroup id = 
      match id with 
      | 1019 -> { GroupData.id= 1019; name= "XL Cruise Missile"; categoryId= 8; published= true; typeIds= [| 2178; 2180; 2182; 2188; 32436; 32438; 32440; 32442 |] } |> Some
      | 1213 -> { GroupData.id= 1213; name= "Targeting"; categoryId= 16; published= true; typeIds= [| 3428; 3429; 3430; 3431; 32999; 33000; 33001; 33002 |] } |> Some
      | 1310 -> { GroupData.id= 1310; name= "Drifter Battleship"; categoryId= 11; published= true; typeIds= [| 34495; 34561; 50093 |] } |> Some
      | 1407 -> { GroupData.id= 1407; name= "Observatory Array"; categoryId= 65; published= false; typeIds= [| 35838; 35839; 37533 |] } |> Some
      | 1601 -> { GroupData.id= 1601; name= "Structure Laboratory Rig M - Drone"; categoryId= 66; published= false; typeIds= [| 37190; 37191 |] } |> Some
      | 1698 -> { GroupData.id= 1698; name= "Ancillary Remote Armor Repairer"; categoryId= 7; published= true; typeIds= [| 41476; 41477; 41478; 41479 |] } |> Some
      | 1795 -> { GroupData.id= 1795; name= "Hidden Zenith Gallente Battleship"; categoryId= 11; published= false; typeIds= [| 42823 |] } |> Some
      | 1989 -> { GroupData.id= 1989; name= "Advanced Exotic Plasma Charge"; categoryId= 8; published= true; typeIds= [| 47926; 47927; 47930; 47931; 47934; 47935 |] } |> Some
      | 340 -> { GroupData.id= 340; name= "Secure Cargo Container"; categoryId= 2; published= true; typeIds= [| 3465; 3466; 3467; 11488; 11489; 11490 |] } |> Some
      | 367776 -> { GroupData.id= 367776; name= "Salvage Decryptors"; categoryId= 350001; published= false; typeIds= [| 367770; 367777; 367778; 367779 |] } |> Some
      | 49 -> { GroupData.id= 49; name= "Survey Scanner"; categoryId= 7; published= true; typeIds= [| 444; 2333; 6567; 6569; 6571; 6573 |] } |> Some
      | 534 -> { GroupData.id= 534; name= "Storyline Mission Battleship"; categoryId= 11; published= false; typeIds= [| 21127; 21181; 21448; 21452; 21735; 21788; 21792; 21794; 21795; 21796; 21886; 22040; 22041; 22048; 22075; 22079; 22097; 22153; 22154; 22235; 22238; 22246; 22273; 22276; 23271; 23616; 23623; 23873; 24260; 24282; 24583; 24662; 26139; 26212; 26227; 26244; 26246; 26279; 26284; 26285; 26454; 26742; 26806; 26848; 26882; 26884; 26885 |] } |> Some
      | 631 -> { GroupData.id= 631; name= "Deadspace Serpentis Cruiser"; categoryId= 11; published= false; typeIds= [| 11720; 14347; 16168; 17033; 17039; 17042; 17044; 17045; 17046; 17047; 17048; 17055; 17056; 17110; 17111; 17112; 17114; 17123; 17124; 17125; 17127; 24063; 24064; 24065; 24066; 24067; 24068; 24069; 24070; 24071; 24072; 24073; 24074; 32192 |] } |> Some
      | 728 -> { GroupData.id= 728; name= "Decryptors - Amarr"; categoryId= 35; published= true; typeIds= [| 23178; 23179; 23180; 23181; 23182; 33315; 33316; 33317 |] } |> Some
      | 825 -> { GroupData.id= 825; name= "Mission Thukker Destroyer"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 922 -> { GroupData.id= 922; name= "Capture Point"; categoryId= 11; published= false; typeIds= [| 29207; 29310; 29311; 29312; 29313; 29314; 29315; 29316; 29317; 29318; 29414; 29415; 29416; 29418; 29419; 29420; 29421; 29422; 29423 |] } |> Some
      | _ -> None