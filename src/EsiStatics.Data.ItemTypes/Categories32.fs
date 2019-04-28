namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories32=
    let getCategory id = 
      match id with 
      | 32 -> { CategoryData.id= 32; name= "Subsystem"; published= true; groupIds= [| 954; 956; 957; 958 |] } |> Some
      | _ -> None