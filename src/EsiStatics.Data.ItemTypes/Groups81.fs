namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups81=
    let getGroup id = 
      match id with 
      | 1051 -> { GroupData.id= 1051; name= "Incursion Sansha's Nation Industrial"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 1245 -> { GroupData.id= 1245; name= "Missile Launcher Rapid Heavy"; categoryId= 7; published= true; typeIds= [| 33440; 33441; 33442; 33446; 33448; 33450; 33452; 33453; 33454; 33455; 33456; 33457; 33458; 33459; 33461; 33462; 33463; 33464; 33465; 33466 |] } |> Some
      | 1633 -> { GroupData.id= 1633; name= "Structure Combat Rig L - AoE Launcher Application and Projection"; categoryId= 66; published= true; typeIds= [| 37256; 37257 |] } |> Some
      | 1730 -> { GroupData.id= 1730; name= "Special Edition Implant"; categoryId= 20; published= true; typeIds= [| 2082; 2589; 33329; 33393; 33394; 33807; 33808 |] } |> Some
      | 178 -> { GroupData.id= 178; name= "Drug Blueprint"; categoryId= 9; published= true; typeIds= [| 29204 |] } |> Some
      | 1827 -> { GroupData.id= 1827; name= "Structure Engineering Rig M - Basic Medium Ship TE"; categoryId= 66; published= true; typeIds= [| 37153; 43919 |] } |> Some
      | 1924 -> { GroupData.id= 1924; name= "♦ Forward Operating Base"; categoryId= 65; published= false; typeIds= [| 46363; 46364 |] } |> Some
      | 275 -> { GroupData.id= 275; name= "Navigation"; categoryId= 16; published= true; typeIds= [| 3449; 3450; 3451; 3452; 3453; 3454; 3455; 3456; 4385; 21603; 21610; 21611; 24562 |] } |> Some
      | 372 -> { GroupData.id= 372; name= "Advanced Autocannon Ammo"; categoryId= 8; published= true; typeIds= [| 12608; 12625; 12627; 12773; 12775; 12777; 12779; 12781; 12783; 41314; 41316 |] } |> Some
      | 469 -> { GroupData.id= 469; name= "Omber"; categoryId= 25; published= true; typeIds= [| 1227; 17867; 17868; 28415; 28416; 28417; 28619; 46684; 46700 |] } |> Some
      | 566 -> { GroupData.id= 566; name= "Asteroid Sansha's Nation Cruiser"; categoryId= 11; published= false; typeIds= [| 10030; 10274; 11037; 11038; 11909; 11910; 11911; 11912; 23366; 23367; 23368; 23369; 23370; 23371; 23381; 23382; 23651; 23652; 23653; 23654; 33136; 33142; 33163; 33183 |] } |> Some
      | 663 -> { GroupData.id= 663; name= "Mercoxit Mining Crystal"; categoryId= 8; published= true; typeIds= [| 18054; 18608 |] } |> Some
      | 760 -> { GroupData.id= 760; name= "Asteroid Rogue Drone Hauler"; categoryId= 11; published= false; typeIds= [| 32901; 32902; 32903; 32904; 32905; 32906; 32907; 32908; 32909; 32910; 32911; 32912 |] } |> Some
      | 857 -> { GroupData.id= 857; name= "Starbase - Warp Scrambling Battery Blueprints"; categoryId= 9; published= true; typeIds= [| 2736; 2740; 27867; 27868; 27869; 27870 |] } |> Some
      | 954 -> { GroupData.id= 954; name= "Defensive Systems"; categoryId= 32; published= true; typeIds= [| 45586; 45587; 45588; 45589; 45590; 45591; 45592; 45593; 45594; 45595; 45596; 45597 |] } |> Some
      | _ -> None