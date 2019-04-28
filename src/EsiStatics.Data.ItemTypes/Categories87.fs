namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories87=
    let getCategory id = 
      match id with 
      | 87 -> { CategoryData.id= 87; name= "Fighter"; published= true; groupIds= [| 1537; 1652; 1653 |] } |> Some
      | _ -> None