namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups19=
    let getGroup id = 
      match id with 
      | 1086 -> { GroupData.id= 1086; name= "Scars"; categoryId= 30; published= false; typeIds= [|  |] } |> Some
      | 1183 -> { GroupData.id= 1183; name= "FW Amarr Empire Battlecruiser"; categoryId= 11; published= true; typeIds= [| 32971 |] } |> Some
      | 1765 -> { GroupData.id= 1765; name= "♦ Mining Barge"; categoryId= 11; published= false; typeIds= [| 42534 |] } |> Some
      | 1862 -> { GroupData.id= 1862; name= "Structure Engineering Rig L - Structure Efficiency"; categoryId= 66; published= true; typeIds= [| 43720; 43721 |] } |> Some
      | 19 -> { GroupData.id= 19; name= "Faction"; categoryId= 1; published= false; typeIds= [| 30 |] } |> Some
      | 213 -> { GroupData.id= 213; name= "Tracking Computer"; categoryId= 7; published= true; typeIds= [| 1977; 1978; 6173; 6174; 6175; 6176; 14238; 15284; 15286; 15288; 15290; 15792; 22927; 22929 |] } |> Some
      | 310 -> { GroupData.id= 310; name= "Beacon"; categoryId= 2; published= false; typeIds= [| 10645; 19706; 23733; 25354; 29296; 29297; 29298; 29299; 29300; 32798; 33621; 33857; 34112; 36465; 42131; 47374; 53837; 53992; 53993; 54722; 54723; 55706; 55708; 55709; 55736; 55737; 55738; 55739; 55740; 55741; 55742; 55790; 55791; 55792; 55793; 55794; 55795; 55796; 55833; 55935; 55936; 55937; 55938; 55939; 55940; 55941 |] } |> Some
      | 407 -> { GroupData.id= 407; name= "Fighter Support Unit"; categoryId= 7; published= true; typeIds= [| 24283; 32951; 32953; 32955; 32957; 41414; 41415; 41417 |] } |> Some
      | 504 -> { GroupData.id= 504; name= "Target Painter Blueprint"; categoryId= 9; published= true; typeIds= [| 12710; 19807; 19809; 19811; 19813; 19815; 21541; 31945; 32415 |] } |> Some
      | 698 -> { GroupData.id= 698; name= "Mission CONCORD Other"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 795 -> { GroupData.id= 795; name= "Asteroid Blood Raiders Commander BattleCruiser"; categoryId= 11; published= false; typeIds= [| 23293; 23294; 23295; 23296; 23297; 23298 |] } |> Some
      | 892 -> { GroupData.id= 892; name= "Planet Satellites"; categoryId= 8; published= false; typeIds= [| 28612 |] } |> Some
      | _ -> None