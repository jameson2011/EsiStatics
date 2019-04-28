namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories18=
    let getCategory id = 
      match id with 
      | 18 -> { CategoryData.id= 18; name= "Drone"; published= true; groupIds= [| 97; 100; 101; 299; 470; 544; 545; 549; 639; 640; 641; 1023; 1159 |] } |> Some
      | _ -> None