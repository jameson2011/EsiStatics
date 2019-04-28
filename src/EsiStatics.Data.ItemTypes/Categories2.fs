namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories2=
    let getCategory id = 
      match id with 
      | 2 -> { CategoryData.id= 2; name= "Celestial"; published= true; groupIds= [| 3; 4; 5; 6; 7; 8; 9; 10; 11; 12; 13; 14; 186; 226; 227; 305; 307; 310; 312; 318; 336; 340; 366; 368; 382; 411; 448; 502; 517; 649; 711; 835; 836; 874; 885; 897; 920; 988; 995; 1071; 1165; 1198; 1316; 1704; 1882; 1915; 1940; 1971; 1973; 1975; 1978; 1980; 1981; 1983; 1991; 1998; 2020 |] } |> Some
      | _ -> None