namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups73=
    let getMarketGroup id = 
      match id with 
      | 1140 -> { MarketGroupData.id= 1140; name= "Caldari"; parentMarketGroupId= Some(1138); typeIds= [| 29984 |]; description= "Caldari strategic cruiser designs." } |> Some
      | 1237 -> { MarketGroupData.id= 1237; name= "Small Projectile Weapon Rigs"; parentMarketGroupId= Some(979); typeIds= [| 31680; 31686; 31656; 31692; 31662; 31698; 31668; 31704; 31674; 31710 |]; description= "Modifications that affect a small starship's projectile weapons." } |> Some
      | 1334 -> { MarketGroupData.id= 1334; name= "Processed Planetary Materials"; parentMarketGroupId= Some(1332); typeIds= [| 2400; 2401; 3683; 9828; 3645; 3779; 2389; 2390; 2392; 2393; 2395; 2396; 2397; 2398; 2399 |]; description= "The second tier of planetary materials." } |> Some
      | 1528 -> { MarketGroupData.id= 1528; name= "Light Missiles"; parentMarketGroupId= Some(314); typeIds= [| 811; 812; 813; 814 |]; description= "" } |> Some
      | 1625 -> { MarketGroupData.id= 1625; name= "Caldari Subsystems"; parentMarketGroupId= Some(1112); typeIds= [|  |]; description= "Caldari Subsystems" } |> Some
      | 1819 -> { MarketGroupData.id= 1819; name= "Minmatar"; parentMarketGroupId= Some(1815); typeIds= [| 588 |]; description= "Minmatar rookie ship designs." } |> Some
      | 2013 -> { MarketGroupData.id= 2013; name= "Unknown Components"; parentMarketGroupId= Some(19); typeIds= [| 34560; 34575; 36902; 36949; 40541; 34540; 34541; 34542; 34543; 34544; 34545; 34546; 34547; 34548; 34549; 34551; 34552; 34553; 34554; 34555; 34556; 34557; 34558; 34559 |]; description= "Mysterious pieces of technology of unknown origin" } |> Some
      | 2110 -> { MarketGroupData.id= 2110; name= "Amarr"; parentMarketGroupId= Some(2109); typeIds= [| 42787; 45796; 49819; 53638; 52585; 52779; 49420; 37518; 46805; 50070; 36311; 48857; 42587; 43518 |]; description= "" } |> Some
      | 2207 -> { MarketGroupData.id= 2207; name= "Electronics and Sensor Upgrades"; parentMarketGroupId= Some(2202); typeIds= [|  |]; description= "" } |> Some
      | 2401 -> { MarketGroupData.id= 2401; name= "Exceptional Moon Ores"; parentMarketGroupId= Some(2395); typeIds= [| 45510; 45511; 45512; 45513; 46314; 46315; 46316; 46317; 46318; 46319; 46312; 46313 |]; description= "" } |> Some
      | 2498 -> { MarketGroupData.id= 2498; name= "Sooth Sayer"; parentMarketGroupId= Some(2489); typeIds= [| 28684; 10164; 10165; 10166 |]; description= "Sooth Sayer Boosters" } |> Some
      | 2692 -> { MarketGroupData.id= 2692; name= "Extra Large"; parentMarketGroupId= Some(2463); typeIds= [| 52916; 53301; 53302 |]; description= "For use with dreadnought-sized entropic disintegrators." } |> Some
      | 354414 -> { MarketGroupData.id= 354414; name= "Standard"; parentMarketGroupId= Some(353576); typeIds= [|  |]; description= "" } |> Some
      | 364 -> { MarketGroupData.id= 364; name= "Gunnery"; parentMarketGroupId= Some(150); typeIds= [| 47872; 47873; 47874; 47875; 52998; 20327; 22043; 21666; 21667; 12201; 12202; 12203; 12204; 12205; 12206; 12207; 12208; 12209; 12210; 12211; 12212; 12213; 12214; 12215; 41403; 41404; 41405; 41406; 41407; 41408; 41537; 11082; 11083; 11084; 3300; 3301; 3302; 3303; 3304; 3305; 3306; 3307; 3308; 3309; 3310; 3311; 3312; 3315; 3316; 3317; 47871; 47870; 24563 |]; description= "Skills pertaining to the efficient use of turret-based weapon systems" } |> Some
      | 364890 -> { MarketGroupData.id= 364890; name= "Standard"; parentMarketGroupId= Some(364889); typeIds= [|  |]; description= "Standard medium frames." } |> Some
      | 365278 -> { MarketGroupData.id= 365278; name= "Commando"; parentMarketGroupId= Some(364046); typeIds= [|  |]; description= "Commando dropsuits." } |> Some
      | 368091 -> { MarketGroupData.id= 368091; name= "Basic"; parentMarketGroupId= Some(368105); typeIds= [|  |]; description= "" } |> Some
      | 461 -> { MarketGroupData.id= 461; name= "Caldari"; parentMarketGroupId= Some(458); typeIds= [| 11380; 11382 |]; description= "Blueprints of Caldari assault frigate designs." } |> Some
      | 558 -> { MarketGroupData.id= 558; name= "Pulse Lasers"; parentMarketGroupId= Some(88); typeIds= [|  |]; description= "Pulse lasers emit an oscillating energy beam at their target." } |> Some
      | 655 -> { MarketGroupData.id= 655; name= "Engineering Equipment"; parentMarketGroupId= Some(9); typeIds= [|  |]; description= "Modules that affect a spaceship's capacitor and modify fitting capabilities" } |> Some
      | 73 -> { MarketGroupData.id= 73; name= "Minmatar"; parentMarketGroupId= Some(6); typeIds= [| 630; 629; 622; 631 |]; description= "Minmatar cruiser designs." } |> Some
      | 752 -> { MarketGroupData.id= 752; name= "Criminal DNA Patterns"; parentMarketGroupId= Some(614); typeIds= [| 13288; 17840; 17640; 14483; 14292; 17624; 12250; 13918; 18655 |]; description= "Physical proof of a dastardly villain's demise." } |> Some
      | 849 -> { MarketGroupData.id= 849; name= "Advanced Blaster Charges"; parentMarketGroupId= Some(100); typeIds= [|  |]; description= "Technologically advanced blaster ammunition." } |> Some
      | 946 -> { MarketGroupData.id= 946; name= "Drone Rigs"; parentMarketGroupId= Some(943); typeIds= [|  |]; description= "Permanent modification of a ship's drone facilities." } |> Some
      | _ -> None