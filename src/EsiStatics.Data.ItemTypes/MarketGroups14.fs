namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups14=
    let getMarketGroup id = 
      match id with 
      | 1081 -> { MarketGroupData.id= 1081; name= "Amarr"; parentMarketGroupId= Some(1080); typeIds= [| 28659 |]; description= "Amarr marauder designs." } |> Some
      | 1275 -> { MarketGroupData.id= 1275; name= "Infrastructure Hubs"; parentMarketGroupId= Some(1272); typeIds= [| 32458 |]; description= "Starbase units for building infrastructure." } |> Some
      | 1372 -> { MarketGroupData.id= 1372; name= "Destroyers"; parentMarketGroupId= Some(4); typeIds= [|  |]; description= "Heavily armed spaceships that sacrifice durability for extra firepower" } |> Some
      | 14 -> { MarketGroupData.id= 14; name= "Hull & Armor "; parentMarketGroupId= Some(9); typeIds= [|  |]; description= "Modules that strengthen the physical frame of a spaceship against external dangers" } |> Some
      | 1469 -> { MarketGroupData.id= 1469; name= "Armor Implants"; parentMarketGroupId= Some(531); typeIds= [|  |]; description= "Armor Implants" } |> Some
      | 1566 -> { MarketGroupData.id= 1566; name= "Electronic Warfare"; parentMarketGroupId= Some(209); typeIds= [|  |]; description= "Electronic Warfare" } |> Some
      | 1663 -> { MarketGroupData.id= 1663; name= "Special Edition Festival Assets"; parentMarketGroupId= Some(1659); typeIds= [| 30221; 30222; 53338; 47264; 33569; 33571; 33572; 33573; 49991; 54564; 47300; 47301; 47302; 47303; 49992; 19658; 19660; 44109; 44110; 53330; 53331; 53332; 53333; 53334; 53335; 53336; 53337; 50138; 53343; 32993; 32994; 32995; 44260; 44261; 44262; 44263; 44264; 44265; 44266; 44267; 44268; 44269; 44270; 44271; 44272; 52219; 53461 |]; description= "Special Edition Festival Assets" } |> Some
      | 1857 -> { MarketGroupData.id= 1857; name= "Minerals"; parentMarketGroupId= Some(533); typeIds= [| 34; 35; 36; 37; 38; 39; 40; 11399; 48927 |]; description= "Minerals harvested from refined asteroid ore." } |> Some
      | 1954 -> { MarketGroupData.id= 1954; name= "Ship SKINs"; parentMarketGroupId= None; typeIds= [|  |]; description= "Super Kerr-Induced Nanocoatings that modify the visual look of a ship" } |> Some
      | 2051 -> { MarketGroupData.id= 2051; name= "Amarr"; parentMarketGroupId= Some(2044); typeIds= [| 52769; 36289; 42754; 42755; 53604; 45762; 45761; 36299; 48844; 43490; 52573; 46776; 43491; 37492; 37493; 46777; 42552; 42553; 53603; 46525; 52574 |]; description= "" } |> Some
      | 208 -> { MarketGroupData.id= 208; name= "Industrial Ships"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of industrial-class vessels." } |> Some
      | 2148 -> { MarketGroupData.id= 2148; name= "Caldari"; parentMarketGroupId= Some(2146); typeIds= [| 37458 |]; description= "Caldari Logistics Frigates" } |> Some
      | 2245 -> { MarketGroupData.id= 2245; name= "Scriptable Armor Hardeners"; parentMarketGroupId= Some(535); typeIds= [| 41515; 41525; 41526; 41527 |]; description= "Armor Hardeners that can be reconfigured on the fly using scripts." } |> Some
      | 2342 -> { MarketGroupData.id= 2342; name= "Large Structure Resource Processing Rigs"; parentMarketGroupId= Some(2204); typeIds= [| 46496; 46497; 37282; 37283; 46639; 46640; 41428; 41429; 46327; 46328 |]; description= "Large Structure Reprocessing and Reaction Rigs" } |> Some
      | 2439 -> { MarketGroupData.id= 2439; name= "Astronautic Mutaplasmids"; parentMarketGroupId= Some(2436); typeIds= [|  |]; description= "Mutaplasmids that can be used on Propulsion modules." } |> Some
      | 2536 -> { MarketGroupData.id= 2536; name= "Triglavian"; parentMarketGroupId= Some(432); typeIds= [| 52250 |]; description= "Triglavian Assault Frigates" } |> Some
      | 305 -> { MarketGroupData.id= 305; name= "Large"; parentMarketGroupId= Some(301); typeIds= [| 1170; 1171; 1172; 1173; 1174; 1175; 1176; 1177 |]; description= "Blueprints of large frequency crystals." } |> Some
      | 353579 -> { MarketGroupData.id= 353579; name= "Dropsuit Modules"; parentMarketGroupId= Some(353562); typeIds= [|  |]; description= "Modules are interchangeable hardware components that enhance or otherwise alter the functionality of the dropsuit they are fitted to." } |> Some
      | 353676 -> { MarketGroupData.id= 353676; name= "Logistics"; parentMarketGroupId= Some(353653); typeIds= [|  |]; description= "" } |> Some
      | 364055 -> { MarketGroupData.id= 364055; name= "Plasma Cannons"; parentMarketGroupId= Some(364047); typeIds= [|  |]; description= "Plasma cannon." } |> Some
      | 365898 -> { MarketGroupData.id= 365898; name= "Ammo Expansion Units"; parentMarketGroupId= Some(353592); typeIds= [|  |]; description= "Ammo Expansion Units." } |> Some
      | 365995 -> { MarketGroupData.id= 365995; name= "Loyalty Store"; parentMarketGroupId= Some(350001); typeIds= [|  |]; description= "An area of the market reserved for items that require loyalty points earned in Factional Contracts" } |> Some
      | 366189 -> { MarketGroupData.id= 366189; name= "Turrets"; parentMarketGroupId= Some(365999); typeIds= [|  |]; description= "" } |> Some
      | 366286 -> { MarketGroupData.id= 366286; name= "Standard"; parentMarketGroupId= Some(366194); typeIds= [|  |]; description= "" } |> Some
      | 366577 -> { MarketGroupData.id= 366577; name= "Prototype"; parentMarketGroupId= Some(366574); typeIds= [|  |]; description= "Prototype." } |> Some
      | 402 -> { MarketGroupData.id= 402; name= "Gallente"; parentMarketGroupId= Some(399); typeIds= [| 11200; 11202 |]; description= "Gallente interceptor designs." } |> Some
      | 499 -> { MarketGroupData.id= 499; name= "Advanced Moon Materials"; parentMarketGroupId= Some(1034); typeIds= [| 16672; 16673; 17317; 16678; 16679; 16680; 16681; 16682; 16683; 33359; 33360; 33361; 33362; 16670; 16671 |]; description= "Materials used for Tech II vessel and equipment production." } |> Some
      | 596 -> { MarketGroupData.id= 596; name= "Laser Batteries"; parentMarketGroupId= Some(480); typeIds= [| 17408; 27776; 27777; 17167; 17168; 27548; 27550; 27551; 27553; 16694; 27775; 27625; 27627; 27628; 27630; 27631; 27633; 27634; 27636; 27774; 27766; 27767; 27768; 27769; 27770; 27771; 27772; 27773; 17406; 17407 |]; description= "Laser turret batteries." } |> Some
      | 693 -> { MarketGroupData.id= 693; name= "Medium"; parentMarketGroupId= Some(662); typeIds= [| 12257; 12259; 15877; 19111; 15883; 14156; 14158; 23824; 19107; 16505; 16507; 19109 |]; description= "Cruiser-sized energy vampires." } |> Some
      | 790 -> { MarketGroupData.id= 790; name= "Gallente"; parentMarketGroupId= Some(787); typeIds= [| 20188 |]; description= "Blueprints of Gallente freighter designs." } |> Some
      | 887 -> { MarketGroupData.id= 887; name= "Minmatar"; parentMarketGroupId= Some(878); typeIds= [| 23774 |]; description= "Blueprints of Minmatar titan designs." } |> Some
      | _ -> None