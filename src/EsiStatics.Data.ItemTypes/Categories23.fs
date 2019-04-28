namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories23=
    let getCategory id = 
      match id with 
      | 23 -> { CategoryData.id= 23; name= "Starbase"; published= true; groupIds= [| 311; 363; 364; 365; 397; 404; 413; 414; 416; 417; 418; 426; 430; 438; 439; 440; 441; 443; 444; 445; 449; 471; 473; 480; 707; 709; 710; 837; 838; 839; 840; 877; 1212; 1282 |] } |> Some
      | _ -> None