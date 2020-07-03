namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories8=
    let getCategory id = 
      match id with 
      | 8 -> { CategoryData.id= 8; name= "Charge"; published= true; groupIds= [| 83; 85; 86; 87; 88; 89; 90; 92; 372; 373; 374; 375; 376; 377; 384; 385; 386; 387; 394; 395; 396; 425; 476; 479; 482; 492; 497; 498; 500; 548; 648; 653; 654; 655; 656; 657; 663; 772; 863; 864; 892; 907; 908; 909; 910; 911; 916; 972; 1010; 1019; 1153; 1158; 1400; 1546; 1547; 1548; 1549; 1550; 1551; 1559; 1569; 1677; 1678; 1701; 1702; 1769; 1771; 1772; 1773; 1774; 1976; 1987; 1989; 4061; 4062 |] } |> Some
      | _ -> None