namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups26=
    let getGroup id = 
      match id with 
      | 1093 -> { GroupData.id= 1093; name= "Makeup"; categoryId= 30; published= false; typeIds= [|  |] } |> Some
      | 1190 -> { GroupData.id= 1190; name= "Salvage Drone Blueprint"; categoryId= 9; published= true; typeIds= [| 32982 |] } |> Some
      | 123 -> { GroupData.id= 123; name= "Capacitor Recharger Blueprint"; categoryId= 9; published= true; typeIds= [| 1196; 2033; 15789; 17527; 23814; 28531 |] } |> Some
      | 1287 -> { GroupData.id= 1287; name= "Asteroid Mordus Legion Commander Battleship"; categoryId= 11; published= false; typeIds= [| 33866 |] } |> Some
      | 1772 -> { GroupData.id= 1772; name= "Skirmish Command Burst Charges"; categoryId= 8; published= true; typeIds= [| 42838; 42839; 42840 |] } |> Some
      | 1869 -> { GroupData.id= 1869; name= "Structure Engineering Rig XL - Structure and Component Efficiency"; categoryId= 66; published= true; typeIds= [| 43704; 43705; 45548 |] } |> Some
      | 1966 -> { GroupData.id= 1966; name= "Structure Capacitor Battery"; categoryId= 66; published= true; typeIds= [| 47352; 47353 |] } |> Some
      | 26 -> { GroupData.id= 26; name= "Cruiser"; categoryId= 6; published= true; typeIds= [| 620; 621; 622; 623; 624; 625; 626; 627; 628; 629; 630; 631; 632; 633; 634; 635; 1904; 2006; 11011; 17634; 17709; 17713; 17715; 17718; 17720; 17722; 17843; 17922; 25560; 29336; 29337; 29340; 29344; 33470; 33553; 33639; 33641; 33643; 33645; 33647; 33649; 33651; 33653; 33818; 34445; 34475; 34590; 47270; 49712; 52267 |] } |> Some
      | 317 -> { GroupData.id= 317; name= "Computer Interface Node"; categoryId= 7; published= false; typeIds= [|  |] } |> Some
      | 414 -> { GroupData.id= 414; name= "Mobile Power Core"; categoryId= 23; published= false; typeIds= [| 16217; 17172; 17173 |] } |> Some
      | 511 -> { GroupData.id= 511; name= "Missile Launcher Rapid Light"; categoryId= 7; published= true; typeIds= [| 1875; 1877; 8007; 8023; 8025; 8027; 13919; 13920; 16061; 17484; 20597; 22566 |] } |> Some
      | 705 -> { GroupData.id= 705; name= "Mission Minmatar Republic Cruiser"; categoryId= 11; published= false; typeIds= [| 11636; 11660; 11710; 12438; 15324; 15343; 16163; 22789; 24821; 24823; 24824; 24826; 24828; 24830; 24832; 24834; 24835; 24836; 24859; 24860; 24861; 24862; 24863; 24864; 24865; 24866; 25883; 29787; 29788; 29789; 29790; 29791; 29792; 29793; 29794; 29795; 29796; 29797; 29798; 30739; 30740; 30741; 30742; 32190; 45469 |] } |> Some
      | 802 -> { GroupData.id= 802; name= "Deadspace Rogue Drone Battleship"; categoryId= 11; published= false; typeIds= [| 10299; 21814; 23497; 23498; 23499; 23500; 23501; 23502; 23503; 23504; 23505; 25379; 28136; 45638; 52833; 52834; 52835; 52836; 53326 |] } |> Some
      | 899 -> { GroupData.id= 899; name= "Warp Disrupt Field Generator"; categoryId= 7; published= true; typeIds= [| 4248; 28654; 37608; 37610; 37611; 37612; 37613 |] } |> Some
      | 996 -> { GroupData.id= 996; name= "Strategic Cruiser Blueprints"; categoryId= 9; published= true; typeIds= [| 29985; 29987; 29989; 29991 |] } |> Some
      | _ -> None