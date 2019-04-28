namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories5=
    let getCategory id = 
      match id with 
      | 5 -> { CategoryData.id= 5; name= "Accessories"; published= true; groupIds= [| 23; 24; 872; 876; 943; 1301; 1311; 1739; 1875 |] } |> Some
      | _ -> None