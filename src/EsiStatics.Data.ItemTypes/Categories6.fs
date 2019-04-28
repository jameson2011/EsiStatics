﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories6=
    let getCategory id = 
      match id with 
      | 6 -> { CategoryData.id= 6; name= "Ship"; published= true; groupIds= [| 25; 26; 27; 28; 29; 30; 31; 237; 324; 358; 380; 381; 419; 420; 463; 485; 513; 540; 541; 543; 547; 659; 830; 831; 832; 833; 834; 883; 893; 894; 898; 900; 902; 906; 941; 963; 1022; 1201; 1202; 1283; 1305; 1527; 1534; 1538; 1972; 2001 |] } |> Some
      | _ -> None