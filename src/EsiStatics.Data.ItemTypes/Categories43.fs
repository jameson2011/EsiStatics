namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories43=
    let getCategory id = 
      match id with 
      | 43 -> { CategoryData.id= 43; name= "Planetary Commodities"; published= true; groupIds= [| 1034; 1040; 1041; 1042 |] } |> Some
      | _ -> None