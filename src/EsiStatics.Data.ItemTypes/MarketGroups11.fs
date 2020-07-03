namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups11=
    let getMarketGroup id = 
      match id with 
      | 1078 -> { MarketGroupData.id= 1078; name= "Gallente"; parentMarketGroupId= Some(1075); typeIds= [| 22430 |]; description= "Gallente black ops designs." } |> Some
      | 108 -> { MarketGroupData.id= 108; name= "Medium"; parentMarketGroupId= Some(848); typeIds= [| 224; 225; 226; 227; 228; 229; 230; 223 |]; description= "Medium hybrid shells, fired by cruiser-sized guns." } |> Some
      | 11 -> { MarketGroupData.id= 11; name= "Ammunition & Charges"; parentMarketGroupId= None; typeIds= [|  |]; description= "Ammunition for turret, missile and bomb systems can be found in this category, together with cap booster charges, mining crystals, probes, nanite repair paste and module scripts" } |> Some
      | 1272 -> { MarketGroupData.id= 1272; name= "Sovereignty Structures"; parentMarketGroupId= Some(477); typeIds= [|  |]; description= "Structures pertaining to the control and exploitation of solar systems" } |> Some
      | 1369 -> { MarketGroupData.id= 1369; name= "Faction Cruisers"; parentMarketGroupId= Some(1367); typeIds= [|  |]; description= "Cruisers designed by specific factions." } |> Some
      | 1563 -> { MarketGroupData.id= 1563; name= "Capacitor Boosters"; parentMarketGroupId= Some(1546); typeIds= [| 1128; 3577; 41644; 41645; 3567 |]; description= "Capacitor Boosters" } |> Some
      | 1660 -> { MarketGroupData.id= 1660; name= "Special Edition Tournament Cards"; parentMarketGroupId= Some(1659); typeIds= [|  |]; description= "Special Edition Tournament Cards" } |> Some
      | 1854 -> { MarketGroupData.id= 1854; name= "Polymer Reactions"; parentMarketGroupId= Some(1849); typeIds= [|  |]; description= "Chemical processes through which raw materials are made into hybrid polymers" } |> Some
      | 1951 -> { MarketGroupData.id= 1951; name= "Tactical Destroyers"; parentMarketGroupId= Some(1373); typeIds= [|  |]; description= "" } |> Some
      | 2048 -> { MarketGroupData.id= 2048; name= "Caldari"; parentMarketGroupId= Some(2043); typeIds= [| 55552; 40585; 40586; 46095; 46096; 55569; 52629; 52630; 36639; 36640; 48161; 48162; 53155; 53156; 36711; 36712; 46828; 46829; 36339; 36340; 45818; 45819 |]; description= "" } |> Some
      | 205 -> { MarketGroupData.id= 205; name= "Frigates"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of frigate-class vessels." } |> Some
      | 2145 -> { MarketGroupData.id= 2145; name= "Minmatar"; parentMarketGroupId= Some(2141); typeIds= [| 40517; 40326; 54919; 46890; 55693; 52862; 54910; 45951 |]; description= "" } |> Some
      | 2242 -> { MarketGroupData.id= 2242; name= "Capital"; parentMarketGroupId= Some(664); typeIds= [| 41488; 41484; 41485; 41486; 41487 |]; description= "Capital-sized capacitor batteries." } |> Some
      | 2339 -> { MarketGroupData.id= 2339; name= "Structure Engineering Rigs"; parentMarketGroupId= Some(2157); typeIds= [| 37376; 44032; 44034; 44036; 44038; 44040; 44042; 44044; 44046; 44048; 44050; 44052; 44054; 44056; 44058; 44060; 44062; 44064; 44074; 44076; 44078; 44080; 44082; 44084; 44086; 44088; 44090; 44092; 37309; 37310; 44096; 44002; 37330; 37332; 37334; 37338; 37343; 37346; 44004; 44006; 44008; 44010; 44012; 44014; 44016; 44018; 44020; 44094; 44022; 44024; 44026; 44028; 44030 |]; description= "Blueprints for Structure Combat rigs." } |> Some
      | 2436 -> { MarketGroupData.id= 2436; name= "Mutaplasmids"; parentMarketGroupId= Some(955); typeIds= [|  |]; description= "Mutaplasmids permanently alter a module's attributes" } |> Some
      | 2533 -> { MarketGroupData.id= 2533; name= "Damage Control Mutaplasmids"; parentMarketGroupId= Some(2532); typeIds= [| 52224; 52225; 52226 |]; description= "Damage Control Mutaplasmids" } |> Some
      | 302 -> { MarketGroupData.id= 302; name= "Small"; parentMarketGroupId= Some(301); typeIds= [| 1154; 1155; 1156; 1157; 1158; 1159; 1160; 1161 |]; description= "Blueprints of small frequency crystals." } |> Some
      | 399 -> { MarketGroupData.id= 399; name= "Interceptors"; parentMarketGroupId= Some(1364); typeIds= [|  |]; description= "Lightning-fast, highly maneuverable frigates." } |> Some
      | 496 -> { MarketGroupData.id= 496; name= "Mining Barges"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of mining barge-class vessels." } |> Some
      | 593 -> { MarketGroupData.id= 593; name= "Mining Crystals"; parentMarketGroupId= Some(11); typeIds= [| 18048; 18050; 18052; 18054; 18056; 18058; 18060; 18062; 18064; 18066; 46355; 46356; 46365; 18590; 46367; 18592; 46369; 18594; 46371; 18596; 18598; 18600; 18602; 18604; 18606; 18608; 18610; 18612; 46366; 18614; 18616; 18618; 18624; 46368; 46370; 46372; 18036; 18038; 18040; 18042; 18044; 18046 |]; description= "Frequency crystals custom-cut for different ore types" } |> Some
      | 690 -> { MarketGroupData.id= 690; name= "Medium"; parentMarketGroupId= Some(661); typeIds= [| 12265; 12267; 16467; 14164; 16469; 14166; 23817; 15796; 15802; 37627; 37625; 37626 |]; description= "Cruiser-sized energy destabilizers." } |> Some
      | 787 -> { MarketGroupData.id= 787; name= "Freighters"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of freighter-class vessels." } |> Some
      | 884 -> { MarketGroupData.id= 884; name= "Amarr"; parentMarketGroupId= Some(878); typeIds= [| 11568 |]; description= "Blueprints of Amarr titan designs." } |> Some
      | _ -> None