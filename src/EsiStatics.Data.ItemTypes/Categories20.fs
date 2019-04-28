namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories20=
    let getCategory id = 
      match id with 
      | 20 -> { CategoryData.id= 20; name= "Implant"; published= true; groupIds= [| 300; 303; 304; 721; 738; 739; 740; 741; 742; 743; 744; 745; 746; 747; 748; 749; 750; 751; 783; 1228; 1229; 1230; 1231; 1730 |] } |> Some
      | _ -> None