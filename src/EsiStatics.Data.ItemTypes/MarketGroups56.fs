namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups56=
    let getMarketGroup id = 
      match id with 
      | 1123 -> { MarketGroupData.id= 1123; name= "Caldari Core Subsystems"; parentMarketGroupId= Some(1625); typeIds= [| 45625; 45626; 45627 |]; description= "Caldari core subsystems." } |> Some
      | 1220 -> { MarketGroupData.id= 1220; name= "Medium Electronics Superiority Rigs"; parentMarketGroupId= Some(960); typeIds= [| 31264; 31300; 31270; 31336; 31306; 31342; 31252; 31288; 31348; 31258; 31354; 31294 |]; description= "Modifications that affect a medium starship's electronic warfare capabilities." } |> Some
      | 1317 -> { MarketGroupData.id= 1317; name= "Faction XL Cruise Missiles"; parentMarketGroupId= Some(1316); typeIds= [| 2188; 2178; 2180; 2182 |]; description= "Faction XL cruise missile designs." } |> Some
      | 1802 -> { MarketGroupData.id= 1802; name= "Medium Scanning Rigs"; parentMarketGroupId= Some(1795); typeIds= [| 31216; 31241; 31204; 31313 |]; description= "Blueprints of Medium Scanning Rigs." } |> Some
      | 1899 -> { MarketGroupData.id= 1899; name= "Blood Raiders"; parentMarketGroupId= Some(1897); typeIds= [| 23148; 23149; 23150; 23151; 23152; 23158; 23159; 23160; 23161; 23162 |]; description= "Materials used in the construction of specific factional equipment." } |> Some
      | 1996 -> { MarketGroupData.id= 1996; name= "Gallente"; parentMarketGroupId= Some(2035); typeIds= [| 45887; 53377; 55575; 55576; 34706; 34707; 44180; 34709; 34710; 34711; 34712; 53536; 39585; 47526; 52398; 46400; 42161; 42162; 37560; 37561; 53309; 46399; 45888; 46548; 46549; 53140; 35038; 48227; 57061; 44905; 44906; 52722; 52723; 34708; 45562; 45563; 44181 |]; description= "" } |> Some
      | 2093 -> { MarketGroupData.id= 2093; name= "Minmatar"; parentMarketGroupId= Some(2381); typeIds= [| 36450; 55638; 36837; 46920; 56938; 47371; 48526; 36790; 49431; 50085; 40508; 47645; 52894; 45983 |]; description= "" } |> Some
      | 2190 -> { MarketGroupData.id= 2190; name= "Missile Guidance Enhancers"; parentMarketGroupId= Some(2179); typeIds= [| 37045 |]; description= "" } |> Some
      | 2287 -> { MarketGroupData.id= 2287; name= "Faction Titans"; parentMarketGroupId= Some(812); typeIds= [| 42241; 42126; 45649 |]; description= "Faction Titan designs." } |> Some
      | 2481 -> { MarketGroupData.id= 2481; name= "Precursor Battleships"; parentMarketGroupId= Some(1960); typeIds= [|  |]; description= "Precursor Battleships" } |> Some
      | 444 -> { MarketGroupData.id= 444; name= "Caldari"; parentMarketGroupId= Some(442); typeIds= [| 11986 |]; description= "Blueprints of Caldari logistics designs." } |> Some
      | 541 -> { MarketGroupData.id= 541; name= "Energized Armor Resistance Membranes"; parentMarketGroupId= Some(14); typeIds= [|  |]; description= "Energized Armor Resistance Membranes" } |> Some
      | 638 -> { MarketGroupData.id= 638; name= "Minmatar"; parentMarketGroupId= Some(634); typeIds= [| 12736; 12748 |]; description= "Blueprints of Minmatar transport designs." } |> Some
      | 735 -> { MarketGroupData.id= 735; name= "Khanid Navy"; parentMarketGroupId= Some(616); typeIds= [| 15981; 16179; 16180; 16181; 16182; 16183; 16184; 16185; 16186; 16187; 16188; 16189 |]; description= "Officially sanctioned Khanid Navy insignias." } |> Some
      | 832 -> { MarketGroupData.id= 832; name= "Gallente"; parentMarketGroupId= Some(823); typeIds= [| 22460 |]; description= "Gallente interdictor designs." } |> Some
      | 929 -> { MarketGroupData.id= 929; name= "Advanced Long Range Torpedoes"; parentMarketGroupId= Some(387); typeIds= [| 2801; 24529; 24525; 24527 |]; description= "Advanced Long Range Torpedoes" } |> Some
      | _ -> None