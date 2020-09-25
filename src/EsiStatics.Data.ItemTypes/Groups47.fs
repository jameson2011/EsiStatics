namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups47=
    let getGroup id = 
      match id with 
      | 1308 -> { GroupData.id= 1308; name= "Rig Anchor"; categoryId= 7; published= true; typeIds= [| 34266; 34268; 34306; 34308 |] } |> Some
      | 1405 -> { GroupData.id= 1405; name= "Laboratory"; categoryId= 65; published= false; typeIds= [| 35828; 35829; 35830 |] } |> Some
      | 1599 -> { GroupData.id= 1599; name= "Structure Laboratory Rig M - Medium Ship"; categoryId= 66; published= false; typeIds= [| 37186; 37187 |] } |> Some
      | 1696 -> { GroupData.id= 1696; name= "OLD Structure Resource Rig L - Ice Reprocessing"; categoryId= 66; published= false; typeIds= [| 41428; 41429 |] } |> Some
      | 1793 -> { GroupData.id= 1793; name= "Hidden Zenith Caldari Cruiser"; categoryId= 11; published= false; typeIds= [| 42821 |] } |> Some
      | 1890 -> { GroupData.id= 1890; name= "Biochemical Reaction Formulas"; categoryId= 9; published= true; typeIds= [| 46219; 46220; 46221; 46222; 46223; 46224; 46225; 46226; 46227; 46228; 46229; 46230; 46231; 46232; 46233; 46234; 46235; 46236; 46237; 46238; 46240; 46241; 46242; 46243; 46244; 46245; 46246; 46247; 46248; 46249; 46250; 46251 |] } |> Some
      | 1987 -> { GroupData.id= 1987; name= "Exotic Plasma Charge"; categoryId= 8; published= true; typeIds= [| 47885; 47886; 47887; 47924; 47925; 47928; 47929; 47932; 47933; 52916; 53301; 53302 |] } |> Some
      | 338 -> { GroupData.id= 338; name= "Shield Boost Amplifier"; categoryId= 7; published= true; typeIds= [| 11561; 14045; 14047; 14636; 14638; 14708; 14710; 14712; 14714; 15905; 15907; 16529; 16531; 16533; 16535; 19289; 19293; 19295; 19297; 19299; 19301; 19303; 19311; 20613; 24443 |] } |> Some
      | 367580 -> { GroupData.id= 367580; name= "Agents"; categoryId= 350001; published= false; typeIds= [| 367578 |] } |> Some
      | 367774 -> { GroupData.id= 367774; name= "Salvage Containers"; categoryId= 350001; published= false; typeIds= [| 367765; 367768 |] } |> Some
      | 435 -> { GroupData.id= 435; name= "Deadspace Overseer"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 47 -> { GroupData.id= 47; name= "Cargo Scanner"; categoryId= 7; published= true; typeIds= [| 442; 2038; 6129; 6131; 6133; 6135 |] } |> Some
      | 532 -> { GroupData.id= 532; name= "Gang Coordinator Blueprint"; categoryId= 9; published= true; typeIds= [| 4263; 4265; 4267; 4269; 4271; 4273; 4275; 4277; 4279; 4281; 4283; 4285; 4287; 4289; 4291; 21095; 21604; 22299; 22300; 22301; 22302; 22303; 22304; 22305; 22306; 22307; 22308; 22309; 22310; 22311; 22554; 22556; 22558; 23736; 28647; 28651; 52695 |] } |> Some
      | 629 -> { GroupData.id= 629; name= "Deadspace Serpentis BattleCruiser"; categoryId= 11; published= false; typeIds= [| 24003; 24024; 24025; 24026; 24027; 24028; 24199; 24200; 24201; 24202; 24203; 24204 |] } |> Some
      | 726 -> { GroupData.id= 726; name= "Advanced Frequency Crystal Blueprint"; categoryId= 9; published= true; typeIds= [| 12553; 12558; 12560; 12562; 12564; 12566; 12811; 12813; 12815; 12817; 12819; 12821; 12823; 12825; 12827; 12829; 12831; 12833; 41331; 41333; 41335; 41337 |] } |> Some
      | 823 -> { GroupData.id= 823; name= "Mission Thukker Battleship"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 920 -> { GroupData.id= 920; name= "Effect Beacon"; categoryId= 2; published= false; typeIds= [| 3069; 3072; 3076; 3493; 3494; 29193; 30391; 30844; 30845; 30846; 30847; 30848; 30849; 30850; 30851; 30852; 30853; 30854; 30860; 30861; 30862; 30863; 30864; 30865; 30866; 30867; 30868; 30869; 30870; 30871; 30872; 30873; 30874; 30875; 30876; 30877; 30878; 30879; 30880; 30881; 30882; 30883; 30884; 35799; 35800; 35801; 35802; 35803; 35804; 37542; 52247; 52248; 52249; 54215; 56057; 56058; 56059; 56060; 56061; 56062; 56063; 56064 |] } |> Some
      | _ -> None