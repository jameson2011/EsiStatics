namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories17=
    let getCategory id = 
      match id with 
      | 17 -> { CategoryData.id= 17; name= "Commodity"; published= true; groupIds= [| 267; 280; 281; 282; 283; 284; 313; 314; 332; 333; 334; 355; 369; 370; 409; 474; 493; 521; 526; 528; 530; 536; 652; 716; 732; 733; 734; 735; 873; 879; 880; 884; 913; 955; 964; 1031; 1118; 1141; 1206; 1248; 1314; 1818; 1886; 1964; 1977; 1979; 1995; 2002; 2026; 4041; 4072 |] } |> Some
      | _ -> None