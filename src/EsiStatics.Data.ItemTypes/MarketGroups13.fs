namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups13=
    let getMarketGroup id = 
      match id with 
      | 1080 -> { MarketGroupData.id= 1080; name= "Marauders"; parentMarketGroupId= Some(1377); typeIds= [|  |]; description= "Battleship-Class vessels, intended for prolonged frontline deployment." } |> Some
      | 1274 -> { MarketGroupData.id= 1274; name= "Sovereignty Blockade Units"; parentMarketGroupId= Some(1272); typeIds= [|  |]; description= "Starbase units for blockading sovereignty." } |> Some
      | 1371 -> { MarketGroupData.id= 1371; name= "Pirate Faction"; parentMarketGroupId= Some(1369); typeIds= [| 17922; 17715; 17718; 17720; 17722; 33818; 33470 |]; description= "Pirate faction cruiser designs." } |> Some
      | 1565 -> { MarketGroupData.id= 1565; name= "Energy Neutralizers"; parentMarketGroupId= Some(1546); typeIds= [| 40672; 40673; 40674; 12266; 12270; 1109 |]; description= "Energy Neutralizers" } |> Some
      | 1662 -> { MarketGroupData.id= 1662; name= "Special Edition Apparel"; parentMarketGroupId= Some(1659); typeIds= [| 34210; 34211; 33767; 33064; 33769; 33770; 33803; 33804; 33768; 33812; 33813 |]; description= "Special Edition Apparel" } |> Some
      | 1856 -> { MarketGroupData.id= 1856; name= "Alloys & Compounds"; parentMarketGroupId= Some(1031); typeIds= [| 11724; 11725; 11732; 11733; 11734; 11735; 11736; 11737; 11738; 11739; 11740; 11741 |]; description= "Various compounds composed of asteroid ores." } |> Some
      | 1953 -> { MarketGroupData.id= 1953; name= "Minmatar"; parentMarketGroupId= Some(1951); typeIds= [| 34562 |]; description= "" } |> Some
      | 2050 -> { MarketGroupData.id= 2050; name= "Minmatar"; parentMarketGroupId= Some(2043); typeIds= [| 46880; 46881; 48491; 36804; 36805; 52423; 52424; 36427; 48492; 36429; 45939; 45940; 36757; 36758; 40473; 40474 |]; description= "" } |> Some
      | 207 -> { MarketGroupData.id= 207; name= "Battleships"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of battleship-class vessels." } |> Some
      | 2147 -> { MarketGroupData.id= 2147; name= "Amarr"; parentMarketGroupId= Some(2146); typeIds= [| 37457 |]; description= "Amarr Logistics Frigates" } |> Some
      | 2244 -> { MarketGroupData.id= 2244; name= "Capital"; parentMarketGroupId= Some(538); typeIds= [| 41512; 41513; 41514; 41511 |]; description= "Hull repair system designs, intended for Capital vessels." } |> Some
      | 2341 -> { MarketGroupData.id= 2341; name= "Medium Structure Resource Processing Rigs"; parentMarketGroupId= Some(2204); typeIds= [| 46484; 46485; 46486; 46487; 46488; 46489; 46490; 46491; 46492; 46493; 46494; 46495; 37280; 37281; 46633; 46634; 46635; 46636; 46637; 46638; 41422; 41423; 41424; 41425; 41426; 41427; 46323; 46324; 46325; 46326 |]; description= "Medium Structure Reprocessing and Reaction Rigs" } |> Some
      | 2438 -> { MarketGroupData.id= 2438; name= "Shield Mutaplasmids"; parentMarketGroupId= Some(2436); typeIds= [|  |]; description= "Mutaplasmids that can be used on shield modules." } |> Some
      | 2535 -> { MarketGroupData.id= 2535; name= "Triglavian"; parentMarketGroupId= Some(448); typeIds= [| 52252 |]; description= "Triglavian Heavy Assault Cruisers" } |> Some
      | 354354 -> { MarketGroupData.id= 354354; name= "Prototype"; parentMarketGroupId= Some(353572); typeIds= [|  |]; description= "" } |> Some
      | 356973 -> { MarketGroupData.id= 356973; name= "Prototype"; parentMarketGroupId= Some(354489); typeIds= [|  |]; description= "" } |> Some
      | 363472 -> { MarketGroupData.id= 363472; name= "Prototype"; parentMarketGroupId= Some(354340); typeIds= [|  |]; description= "Prototype" } |> Some
      | 364054 -> { MarketGroupData.id= 364054; name= "Prototype"; parentMarketGroupId= Some(364051); typeIds= [|  |]; description= "Prototype." } |> Some
      | 366285 -> { MarketGroupData.id= 366285; name= "Prototype"; parentMarketGroupId= Some(366282); typeIds= [|  |]; description= "" } |> Some
      | 366576 -> { MarketGroupData.id= 366576; name= "Advanced"; parentMarketGroupId= Some(366574); typeIds= [|  |]; description= "Advanced." } |> Some
      | 401 -> { MarketGroupData.id= 401; name= "Caldari"; parentMarketGroupId= Some(399); typeIds= [| 11176; 11178 |]; description= "Caldari interceptor designs." } |> Some
      | 595 -> { MarketGroupData.id= 595; name= "Hybrid Batteries"; parentMarketGroupId= Some(480); typeIds= [| 27616; 27618; 27547; 27621; 27622; 27624; 27619; 16690; 16691; 16692; 27542; 27544; 27545; 17402; 17403; 17404; 27613; 27615 |]; description= "Hybrid turret batteries." } |> Some
      | 692 -> { MarketGroupData.id= 692; name= "Small"; parentMarketGroupId= Some(662); typeIds= [| 19105; 15875; 14148; 14150; 13001; 23821; 5137; 530; 5141; 15881; 19101; 19103 |]; description= "Frigate-sized energy vampires." } |> Some
      | 789 -> { MarketGroupData.id= 789; name= "Caldari"; parentMarketGroupId= Some(787); typeIds= [| 20186 |]; description= "Blueprints of Caldari freighter designs." } |> Some
      | 886 -> { MarketGroupData.id= 886; name= "Gallente"; parentMarketGroupId= Some(878); typeIds= [| 1002 |]; description= "Blueprints of Gallente titan designs." } |> Some
      | 983 -> { MarketGroupData.id= 983; name= "Booster Gas Clouds"; parentMarketGroupId= Some(1032); typeIds= [| 28697; 28699; 28700; 28701; 28698; 25268; 28694; 28695; 28696; 25273; 25274; 25275; 25276; 25277; 25278; 25279 |]; description= "Voluminous clouds of various gases that can be found in space." } |> Some
      | _ -> None