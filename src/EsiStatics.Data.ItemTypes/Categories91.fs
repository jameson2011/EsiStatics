namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories91=
    let getCategory id = 
      match id with 
      | 91 -> { CategoryData.id= 91; name= "SKINs"; published= true; groupIds= [| 1950; 1951; 1952; 1953; 1954; 1955 |] } |> Some
      | _ -> None