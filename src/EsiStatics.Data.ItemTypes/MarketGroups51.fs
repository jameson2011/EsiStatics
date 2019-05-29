namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups51=
    let getMarketGroup id = 
      match id with 
      | 1021 -> { MarketGroupData.id= 1021; name= "Outpost Components"; parentMarketGroupId= Some(1035); typeIds= [|  |]; description= "Components to those glorious centers of community, outposts." } |> Some
      | 1215 -> { MarketGroupData.id= 1215; name= "Large Drone Rigs"; parentMarketGroupId= Some(958); typeIds= [| 25920; 26338; 26340; 25924; 26326; 26332; 26328; 25908; 26334; 25910; 25912; 26324; 25914; 25916; 26330; 25918 |]; description= "Modifications that affect a large starship's drones." } |> Some
      | 1506 -> { MarketGroupData.id= 1506; name= "Implant Slot 06"; parentMarketGroupId= Some(1472); typeIds= [| 28801; 33922; 28807; 33928; 28813; 33934; 28819; 33940; 33946; 20508; 20509; 33952; 33958; 33964; 33565; 33970; 33976; 20161; 33529; 19539; 31959; 42203; 31967; 22112; 42209; 28795; 19556; 31973; 22118; 42215; 31979; 22124; 22130; 22137; 32122; 32123; 32124; 32125 |]; description= "Implant Slot 06" } |> Some
      | 1603 -> { MarketGroupData.id= 1603; name= "Orbital Strike"; parentMarketGroupId= Some(299); typeIds= [|  |]; description= "" } |> Some
      | 1700 -> { MarketGroupData.id= 1700; name= "Security Tags"; parentMarketGroupId= Some(19); typeIds= [| 33138; 33139; 33140; 33141 |]; description= "These tags can be turned in, in low-security space, for a boost to security rating" } |> Some
      | 1797 -> { MarketGroupData.id= 1797; name= "Capital Resource Processing Rigs"; parentMarketGroupId= Some(1794); typeIds= [| 31088 |]; description= "Blueprints of Capital Resource Processing Rigs." } |> Some
      | 1991 -> { MarketGroupData.id= 1991; name= "Caldari"; parentMarketGroupId= Some(2028); typeIds= [| 34688; 45833; 45834; 45835; 45836; 40597; 40598; 40599; 40600; 46110; 46111; 46112; 46113; 36649; 36650; 36651; 36652; 52399; 48176; 48177; 48178; 48179; 46729; 47499; 40772; 41421; 47311; 48720; 45014; 48224; 47612; 34685; 36721; 36722; 36723; 36724; 34686; 46713; 34687; 44156; 44157; 44158; 44159 |]; description= "" } |> Some
      | 2088 -> { MarketGroupData.id= 2088; name= "Amarr"; parentMarketGroupId= Some(2087); typeIds= [| 46816; 48859; 42597; 42598; 43527; 43526; 36300; 36301; 42798; 42797; 45806; 37526; 37527; 46745; 46746; 45807; 48860; 46815 |]; description= "" } |> Some
      | 2185 -> { MarketGroupData.id= 2185; name= "Guided Bomb Launchers"; parentMarketGroupId= Some(2164); typeIds= [| 37008 |]; description= "" } |> Some
      | 2476 -> { MarketGroupData.id= 2476; name= "Implant Slot 08"; parentMarketGroupId= Some(2473); typeIds= [|  |]; description= "Implant Slot 08" } |> Some
      | 353713 -> { MarketGroupData.id= 353713; name= "Turret Operation"; parentMarketGroupId= Some(353633); typeIds= [|  |]; description= "Hardwired neural augmentations used to train new abilities." } |> Some
      | 354489 -> { MarketGroupData.id= 354489; name= "Large"; parentMarketGroupId= Some(354478); typeIds= [|  |]; description= "" } |> Some
      | 355459 -> { MarketGroupData.id= 355459; name= "Modules"; parentMarketGroupId= Some(355449); typeIds= [|  |]; description= "" } |> Some
      | 439 -> { MarketGroupData.id= 439; name= "Caldari"; parentMarketGroupId= Some(437); typeIds= [| 11985 |]; description= "Caldari logistics vessel designs." } |> Some
      | 633 -> { MarketGroupData.id= 633; name= "Minmatar"; parentMarketGroupId= Some(629); typeIds= [| 12747; 12735 |]; description= "Minmatar transport ship designs." } |> Some
      | 730 -> { MarketGroupData.id= 730; name= "Amarr Navy"; parentMarketGroupId= Some(616); typeIds= [| 16000; 28238; 15992; 15634; 15635; 15636; 15669; 15670; 15607; 15608; 15609; 15610; 15611; 15612; 15613; 15614; 15615 |]; description= "Officially sanctioned Imperial Navy insignias." } |> Some
      | 827 -> { MarketGroupData.id= 827; name= "Amarr"; parentMarketGroupId= Some(824); typeIds= [| 11965; 20125 |]; description= "Amarr recon ship designs." } |> Some
      | 924 -> { MarketGroupData.id= 924; name= "Standard Heavy Missiles"; parentMarketGroupId= Some(581); typeIds= [| 208; 209; 206; 207 |]; description= "Standard Heavy Missiles" } |> Some
      | _ -> None