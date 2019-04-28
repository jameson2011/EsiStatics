namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module  Categories=
    let getCategory id = 
      let bkt = id % 97
      match bkt with
        | 0 -> Categories0.getCategory id
        | 1 -> Categories1.getCategory id
        | 2 -> Categories2.getCategory id
        | 3 -> Categories3.getCategory id
        | 4 -> Categories4.getCategory id
        | 5 -> Categories5.getCategory id
        | 6 -> Categories6.getCategory id
        | 7 -> Categories7.getCategory id
        | 8 -> Categories8.getCategory id
        | 9 -> Categories9.getCategory id
        | 10 -> Categories10.getCategory id
        | 11 -> Categories11.getCategory id
        | 14 -> Categories14.getCategory id
        | 16 -> Categories16.getCategory id
        | 17 -> Categories17.getCategory id
        | 18 -> Categories18.getCategory id
        | 20 -> Categories20.getCategory id
        | 22 -> Categories22.getCategory id
        | 23 -> Categories23.getCategory id
        | 24 -> Categories24.getCategory id
        | 25 -> Categories25.getCategory id
        | 26 -> Categories26.getCategory id
        | 29 -> Categories29.getCategory id
        | 30 -> Categories30.getCategory id
        | 32 -> Categories32.getCategory id
        | 34 -> Categories34.getCategory id
        | 35 -> Categories35.getCategory id
        | 39 -> Categories39.getCategory id
        | 40 -> Categories40.getCategory id
        | 41 -> Categories41.getCategory id
        | 42 -> Categories42.getCategory id
        | 43 -> Categories43.getCategory id
        | 46 -> Categories46.getCategory id
        | 49 -> Categories49.getCategory id
        | 53 -> Categories53.getCategory id
        | 54 -> Categories54.getCategory id
        | 59 -> Categories59.getCategory id
        | 63 -> Categories63.getCategory id
        | 65 -> Categories65.getCategory id
        | 66 -> Categories66.getCategory id
        | 87 -> Categories87.getCategory id
        | 91 -> Categories91.getCategory id
        | _ -> None
    let categories =
        let ids =  [| 0; 1; 10; 11; 14; 16; 17; 18; 2; 20; 22; 23; 24; 25; 26; 29; 3; 30; 32; 34; 35; 350001; 39; 4; 40; 41; 42; 43; 46; 49; 5; 53; 54; 59; 6; 63; 65; 66; 7; 8; 87; 9; 91 |] 
        (fun () -> ids |> Seq.map getCategory |> Seq.filter Option.isSome |> Seq.map Option.get )