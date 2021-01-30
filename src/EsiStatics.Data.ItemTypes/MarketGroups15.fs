namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups15=
    let getMarketGroup id = 
      match id with 
      | 1082 -> { MarketGroupData.id= 1082; name= "Caldari"; parentMarketGroupId= Some(1080); typeIds= [| 28710 |]; description= "Caldari marauder designs" } |> Some
      | 112 -> { MarketGroupData.id= 112; name= "Medium"; parentMarketGroupId= Some(845); typeIds= [| 192; 193; 186; 187; 188; 189; 190; 191 |]; description= "Medium projectile shells, fired by cruiser-sized guns." } |> Some
      | 1276 -> { MarketGroupData.id= 1276; name= "Infrastructure Upgrades"; parentMarketGroupId= Some(1272); typeIds= [|  |]; description= "Upgrades which are installed into the Infrastructure Hub." } |> Some
      | 1373 -> { MarketGroupData.id= 1373; name= "Advanced Destroyers"; parentMarketGroupId= Some(1372); typeIds= [|  |]; description= "These destroyers have additional attributes to help them specialize in specific roles." } |> Some
      | 1470 -> { MarketGroupData.id= 1470; name= "Electronic Systems Implants"; parentMarketGroupId= Some(531); typeIds= [|  |]; description= "Electronic Systems Implants" } |> Some
      | 1567 -> { MarketGroupData.id= 1567; name= "Electronic Counter Measures"; parentMarketGroupId= Some(1566); typeIds= [| 11628; 11629; 11630; 11631; 11632; 25562 |]; description= "Electronic Counter Measures" } |> Some
      | 1664 -> { MarketGroupData.id= 1664; name= "Special Edition Blueprints"; parentMarketGroupId= Some(1659); typeIds= [| 33067 |]; description= "Special Edition Blueprints" } |> Some
      | 1761 -> { MarketGroupData.id= 1761; name= "Targeting Implants"; parentMarketGroupId= Some(531); typeIds= [|  |]; description= "Targeting Implants" } |> Some
      | 1858 -> { MarketGroupData.id= 1858; name= "Booster Materials"; parentMarketGroupId= Some(1034); typeIds= [| 25344; 25345; 25346; 25347; 25348; 28693; 28686; 28687; 28688; 28689; 28690; 28691; 28692; 25237; 25241; 25242; 25252; 25283; 25330; 25331; 25332; 25333; 25334; 25335; 25336; 25337; 25338; 25339; 25340; 25341; 25342; 25343 |]; description= "Various types of biochemical boosters, most often used by pod pilots." } |> Some
      | 1955 -> { MarketGroupData.id= 1955; name= "Battlecruisers"; parentMarketGroupId= Some(1954); typeIds= [|  |]; description= "" } |> Some
      | 2052 -> { MarketGroupData.id= 2052; name= "Caldari"; parentMarketGroupId= Some(2044); typeIds= [| 55553; 40587; 40588; 46097; 55570; 36641; 36642; 48163; 48164; 53157; 53158; 57158; 52552; 36713; 36714; 46098; 46830; 46831; 36337; 36347; 45820; 45821 |]; description= "" } |> Some
      | 209 -> { MarketGroupData.id= 209; name= "Ship Equipment"; parentMarketGroupId= Some(2); typeIds= [|  |]; description= "Blueprints of modules and equipment for capsuleer spaceships" } |> Some
      | 2149 -> { MarketGroupData.id= 2149; name= "Gallente"; parentMarketGroupId= Some(2146); typeIds= [| 37459 |]; description= "Gallente Logistics Frigates" } |> Some
      | 2246 -> { MarketGroupData.id= 2246; name= "Scriptable Shield Hardeners"; parentMarketGroupId= Some(553); typeIds= [| 41528; 41529; 41530; 41531; 41516 |]; description= "Shield Hardeners that can be reconfigured on the fly using scripts." } |> Some
      | 2343 -> { MarketGroupData.id= 2343; name= "X-Large Structure Resource Processing Rigs"; parentMarketGroupId= Some(2204); typeIds= [| 46641; 46642; 37284; 37285 |]; description= "X-Large Structure Reprocessing and Reaction Rigs" } |> Some
      | 2440 -> { MarketGroupData.id= 2440; name= "Engineering Mutaplasmids"; parentMarketGroupId= Some(2436); typeIds= [|  |]; description= "Mutaplasmids that can be used on Engineering modules" } |> Some
      | 2537 -> { MarketGroupData.id= 2537; name= "Triglavian"; parentMarketGroupId= Some(2125); typeIds= [| 52254 |]; description= "Triglavian Command Destroyers" } |> Some
      | 306 -> { MarketGroupData.id= 306; name= "Large"; parentMarketGroupId= Some(300); typeIds= [| 1152; 1153; 1146; 1147; 1148; 1149; 1150; 1151 |]; description= "Blueprints of large hybrid ammunition." } |> Some
      | 403 -> { MarketGroupData.id= 403; name= "Minmatar"; parentMarketGroupId= Some(399); typeIds= [| 11196; 11198 |]; description= "Minmatar interceptor designs." } |> Some
      | 500 -> { MarketGroupData.id= 500; name= "Processed Moon Materials"; parentMarketGroupId= Some(1034); typeIds= [| 33339; 16654; 16655; 16656; 16657; 16658; 16659; 16660; 16661; 16662; 16663; 16664; 16665; 16666; 16667; 16668; 16669; 17959; 17960; 32821; 32822; 32823; 32824; 32825; 32826; 32827; 32828; 32829; 33336; 33337; 29659; 29660; 29661; 29662; 29663; 29664; 33338; 17769 |]; description= "Compounds used in complex reactions." } |> Some
      | 597 -> { MarketGroupData.id= 597; name= "Extra Large"; parentMarketGroupId= Some(299); typeIds= [| 17665; 17667; 17669; 17671; 17673; 17675; 17677; 17679 |]; description= "Blueprints of capital-sized projectile ammunition." } |> Some
      | 694 -> { MarketGroupData.id= 694; name= "Heavy"; parentMarketGroupId= Some(662); typeIds= [| 14816; 14818; 19115; 14820; 12261; 14822; 12263; 14152; 19113; 14154; 15879; 14828; 15885; 14830; 19117; 14824; 16499; 16497; 23829; 19119; 14826 |]; description= "Battleship-sized energy vampires." } |> Some
      | 791 -> { MarketGroupData.id= 791; name= "Minmatar"; parentMarketGroupId= Some(787); typeIds= [| 20190 |]; description= "Blueprints of Minmatar freighter designs." } |> Some
      | 888 -> { MarketGroupData.id= 888; name= "Amarr"; parentMarketGroupId= Some(879); typeIds= [| 23920; 23758 |]; description= "Blueprints of Amarr carrier and mothership designs." } |> Some
      | _ -> None