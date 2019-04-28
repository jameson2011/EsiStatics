namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories35=
    let getCategory id = 
      match id with 
      | 35 -> { CategoryData.id= 35; name= "Decryptors"; published= true; groupIds= [| 728; 729; 730; 731; 979; 1304 |] } |> Some
      | _ -> None