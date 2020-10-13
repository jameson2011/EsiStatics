namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups0=
    let getMarketGroup id = 
      match id with 
      | 1067 -> { MarketGroupData.id= 1067; name= "Caldari"; parentMarketGroupId= Some(1065); typeIds= [| 11194 |]; description= "Caldari electronic attack frigate designs." } |> Some
      | 1261 -> { MarketGroupData.id= 1261; name= "Small Missile Launcher Rigs"; parentMarketGroupId= Some(952); typeIds= [| 31587; 31621; 31599; 31633; 31609; 31645 |]; description= "Blueprints of Small Missile Launcher Rigs." } |> Some
      | 1358 -> { MarketGroupData.id= 1358; name= "Nanite Repair Paste"; parentMarketGroupId= Some(211); typeIds= [| 2739 |]; description= "Blueprints of Nanite Repair Paste." } |> Some
      | 1552 -> { MarketGroupData.id= 1552; name= "Shield Boosters"; parentMarketGroupId= Some(1545); typeIds= [| 20704; 41632; 41633; 1032; 11562; 10837; 10839; 10040; 10841 |]; description= "Shield Boosters" } |> Some
      | 1746 -> { MarketGroupData.id= 1746; name= "Neural Enhancement"; parentMarketGroupId= Some(150); typeIds= [| 25538; 3405; 24242; 3411; 33399; 25530; 24606; 33407 |]; description= "Skills pertaining to managing boosters, implants and clone operations" } |> Some
      | 1843 -> { MarketGroupData.id= 1843; name= "Mobile Scan Inhibitors"; parentMarketGroupId= Some(406); typeIds= [| 33590 |]; description= "" } |> Some
      | 1940 -> { MarketGroupData.id= 1940; name= "Interdiction Sphere Launchers"; parentMarketGroupId= Some(1566); typeIds= [| 22783 |]; description= "" } |> Some
      | 2037 -> { MarketGroupData.id= 2037; name= "Interdictors"; parentMarketGroupId= Some(2036); typeIds= [|  |]; description= "" } |> Some
      | 2134 -> { MarketGroupData.id= 2134; name= "Micro Jump Field Generators"; parentMarketGroupId= Some(252); typeIds= [| 37621 |]; description= "" } |> Some
      | 2231 -> { MarketGroupData.id= 2231; name= "Structure Antisubcapital Launcher"; parentMarketGroupId= Some(2226); typeIds= [| 35922; 47298 |]; description= "" } |> Some
      | 2328 -> { MarketGroupData.id= 2328; name= "ORE"; parentMarketGroupId= Some(2085); typeIds= [| 54920; 56618; 46994; 46743; 43676; 54911 |]; description= "" } |> Some
      | 2425 -> { MarketGroupData.id= 2425; name= "Precursor Frigates"; parentMarketGroupId= Some(1361); typeIds= [|  |]; description= "Precursor Frigates" } |> Some
      | 2522 -> { MarketGroupData.id= 2522; name= "Precursor Destroyers"; parentMarketGroupId= Some(1372); typeIds= [|  |]; description= "Precursor Destroyers" } |> Some
      | 291 -> { MarketGroupData.id= 291; name= "Small"; parentMarketGroupId= Some(286); typeIds= [| 10679; 1112; 1113; 1114; 1115; 1116 |]; description= "Blueprints of small hybrid turrets." } |> Some
      | 485 -> { MarketGroupData.id= 485; name= "Shield Hardening Arrays"; parentMarketGroupId= Some(1285); typeIds= [| 17184; 17185; 17186; 17187 |]; description= "Anchorable structures for the boosting of a control tower's shield resistances." } |> Some
      | 582 -> { MarketGroupData.id= 582; name= "Destroyers"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of destroyer-class vessels." } |> Some
      | 679 -> { MarketGroupData.id= 679; name= "Remote Sensor Dampeners"; parentMarketGroupId= Some(657); typeIds= [| 22945; 1968; 1969; 5299; 5301; 5302 |]; description= "Decrease the targeting speed and range of target ship." } |> Some
      | 776 -> { MarketGroupData.id= 776; name= "Extra Large"; parentMarketGroupId= Some(559); typeIds= [| 41152; 41153; 41154; 20452; 37289; 41080; 3573; 41081; 37304; 37305; 37306; 41083; 41082; 41150; 41151 |]; description= "Capital ship autocannons, for use on dreadnoughts and titans." } |> Some
      | _ -> None