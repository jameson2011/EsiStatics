namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories25=
    let getCategory id = 
      match id with 
      | 25 -> { CategoryData.id= 25; name= "Asteroid"; published= true; groupIds= [| 450; 451; 452; 453; 454; 455; 456; 457; 458; 459; 460; 461; 462; 465; 467; 468; 469; 519; 903; 1884; 1911; 1920; 1921; 1922; 1923; 2006; 2022; 2024; 4029; 4030; 4031 |] } |> Some
      | 350001 -> { CategoryData.id= 350001; name= "Infantry"; published= false; groupIds= [| 350858; 351064; 351121; 351210; 351648; 351844; 354641; 354753; 364204; 367487; 367580; 367594; 367774; 367776; 368656; 368666; 368726 |] } |> Some
      | _ -> None