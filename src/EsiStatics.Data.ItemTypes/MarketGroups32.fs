namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups32=
    let getMarketGroup id = 
      match id with 
      | 1002 -> { MarketGroupData.id= 1002; name= "Faction Heavy Missiles"; parentMarketGroupId= Some(581); typeIds= [| 27433; 27435; 27437; 27439; 27441; 27443; 27445; 27447; 27449; 27451; 27453; 27455 |]; description= "Faction issue heavy missiles." } |> Some
      | 1196 -> { MarketGroupData.id= 1196; name= "Nanofiber Internal Structures"; parentMarketGroupId= Some(135); typeIds= [| 15813; 2603; 2605; 14127; 1242; 21500; 5599 |]; description= "Lightweight materials that provide a boost in speed by weakening a starship's internal structure." } |> Some
      | 1390 -> { MarketGroupData.id= 1390; name= "ORE"; parentMarketGroupId= Some(8); typeIds= [| 2998 |]; description= "ORE industrial designs." } |> Some
      | 1584 -> { MarketGroupData.id= 1584; name= "CPU Upgrades"; parentMarketGroupId= Some(1578); typeIds= [| 11619 |]; description= "CPU Upgrades" } |> Some
      | 1681 -> { MarketGroupData.id= 1681; name= "EM Armor Hardeners"; parentMarketGroupId= Some(535); typeIds= [| 18949; 15244; 18957; 15246; 15248; 13970; 13972; 18965; 16359; 18973; 13986; 11301; 18929; 15016; 15018; 15020; 15022; 15024; 15026; 15028; 15030; 18885; 18887; 18901; 18903; 17502; 15711; 16357; 15719; 28522; 14059; 15250; 17832; 18931; 18933; 18935; 11642 |]; description= "EM Armor Hardeners" } |> Some
      | 1972 -> { MarketGroupData.id= 1972; name= "Freighters"; parentMarketGroupId= Some(1968); typeIds= [|  |]; description= "" } |> Some
      | 2069 -> { MarketGroupData.id= 2069; name= "Amarr"; parentMarketGroupId= Some(2065); typeIds= [| 37504; 37505; 47622; 56193; 42770; 42771; 55302; 55346; 42570; 48831; 46528; 53954; 46787; 46788; 36296; 42569; 36298; 45778; 45779; 56192; 52580; 52581; 48850; 43504; 43505; 53620; 53621 |]; description= "" } |> Some
      | 2166 -> { MarketGroupData.id= 2166; name= "Service Modules"; parentMarketGroupId= Some(2158); typeIds= [|  |]; description= "" } |> Some
      | 2263 -> { MarketGroupData.id= 2263; name= "Amarr"; parentMarketGroupId= Some(2262); typeIds= [| 41582 |]; description= "Blueprints of Amarr force auxiliary designs." } |> Some
      | 2360 -> { MarketGroupData.id= 2360; name= "Pirate Faction"; parentMarketGroupId= Some(2359); typeIds= [| 45505; 46041 |]; description= "" } |> Some
      | 2457 -> { MarketGroupData.id= 2457; name= "Exotic Filaments"; parentMarketGroupId= Some(2456); typeIds= [| 56133; 47889; 56141; 47888; 47761; 47890; 47891 |]; description= "Filaments connected to Abyssal pockets with Exotic Particle Storms" } |> Some
      | 420 -> { MarketGroupData.id= 420; name= "Covert Ops"; parentMarketGroupId= Some(1364); typeIds= [|  |]; description= "Frigates designed for clandestine operations." } |> Some
      | 517 -> { MarketGroupData.id= 517; name= "Spodumain"; parentMarketGroupId= Some(54); typeIds= [| 46688; 28418; 28419; 28420; 46704; 19; 17466; 17467 |]; description= "Sub-types of spodumain ore." } |> Some
      | 614 -> { MarketGroupData.id= 614; name= "Criminal Evidence"; parentMarketGroupId= Some(19); typeIds= [| 47450 |]; description= "Proof positive of a bounty hunter's job well done" } |> Some
      | 711 -> { MarketGroupData.id= 711; name= "Cargo Scanners"; parentMarketGroupId= Some(1708); typeIds= [| 442; 6131; 2038; 6135 |]; description= "For remote scanning of a target ship's cargo hold." } |> Some
      | 905 -> { MarketGroupData.id= 905; name= "Tractor Beams"; parentMarketGroupId= Some(1578); typeIds= [| 24349; 24645 |]; description= "Blueprints of tractor beams." } |> Some
      | _ -> None