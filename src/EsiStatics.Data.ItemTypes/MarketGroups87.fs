namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups87=
    let getMarketGroup id = 
      match id with 
      | 1057 -> { MarketGroupData.id= 1057; name= "Large"; parentMarketGroupId= Some(537); typeIds= [| 16449; 26914; 16451; 41478; 16455; 23416; 11359 |]; description= "Remote armor repair system designs, intended for battleship-class vessels." } |> Some
      | 1251 -> { MarketGroupData.id= 1251; name= "Large Electronics Superiority Rigs"; parentMarketGroupId= Some(948); typeIds= [| 26113; 25929; 26097; 26107; 26109; 26111 |]; description= "Blueprints of Large Electronics Superiority Rigs." } |> Some
      | 1348 -> { MarketGroupData.id= 1348; name= "Laser Batteries"; parentMarketGroupId= Some(1534); typeIds= [| 2825; 2826; 2827; 2828; 2829; 2830 |]; description= "Blueprints of Laser Batteries." } |> Some
      | 1542 -> { MarketGroupData.id= 1542; name= "Damage Controls"; parentMarketGroupId= Some(214); typeIds= [| 40720; 40721; 40719; 47259; 2047 |]; description= "Blueprints for Damage Controls" } |> Some
      | 1639 -> { MarketGroupData.id= 1639; name= "Command Processors"; parentMarketGroupId= Some(779); typeIds= [|  |]; description= "Command Processors" } |> Some
      | 1736 -> { MarketGroupData.id= 1736; name= "Capital Engineering Rigs"; parentMarketGroupId= Some(961); typeIds= [| 31392; 31362; 31236; 31398; 31368; 31404; 31374; 31410; 31380; 33303; 31416; 33305; 31386; 43900; 31230 |]; description= "Modifications that affect a capital starship's energy grid." } |> Some
      | 1833 -> { MarketGroupData.id= 1833; name= "Mobile Tractor Units"; parentMarketGroupId= Some(404); typeIds= [| 33475; 33700; 33702 |]; description= "" } |> Some
      | 2027 -> { MarketGroupData.id= 2027; name= "Minmatar"; parentMarketGroupId= Some(2023); typeIds= [| 36833; 46914; 48518; 47176; 55689; 48522; 52432; 52888; 36786; 45977; 40504; 35705 |]; description= "" } |> Some
      | 2221 -> { MarketGroupData.id= 2221; name= "Point Defense Batteries"; parentMarketGroupId= Some(2208); typeIds= [| 35926; 47327 |]; description= "" } |> Some
      | 2318 -> { MarketGroupData.id= 2318; name= "ORE"; parentMarketGroupId= Some(1972); typeIds= [| 43811; 56614; 43785; 43850; 43758; 43824; 43672; 46990; 43798; 42680; 43771; 43837; 42623 |]; description= "" } |> Some
      | 2415 -> { MarketGroupData.id= 2415; name= "Armor Reinforcers"; parentMarketGroupId= Some(2163); typeIds= [| 47361 |]; description= "" } |> Some
      | 2512 -> { MarketGroupData.id= 2512; name= "Weapon Upgrade Mutaplasmids"; parentMarketGroupId= Some(2436); typeIds= [|  |]; description= "" } |> Some
      | 2706 -> { MarketGroupData.id= 2706; name= "Jump Filaments"; parentMarketGroupId= Some(2456); typeIds= [| 53984; 53985; 53986; 53987; 53977; 53983 |]; description= "Filaments that jump fleets unpredictably to other locations in known space." } |> Some
      | 281 -> { MarketGroupData.id= 281; name= "Gallente"; parentMarketGroupId= Some(207); typeIds= [| 24691; 995; 999 |]; description= "Blueprints of Gallente battleship designs." } |> Some
      | 378 -> { MarketGroupData.id= 378; name= "Trade"; parentMarketGroupId= Some(150); typeIds= [| 18580; 16598; 16595; 16622; 25233; 16594; 3443; 3444; 16597; 3446; 3447; 16596; 33467; 25235 |]; description= "Skills pertaining to managing commercial activities" } |> Some
      | 475 -> { MarketGroupData.id= 475; name= "Manufacture & Research"; parentMarketGroupId= None; typeIds= [|  |]; description= "The perpetual engine of space industry is driven by vast quantities of materials, components and research equipment that are constantly being traded on the capsuleer market" } |> Some
      | 572 -> { MarketGroupData.id= 572; name= "Medium"; parentMarketGroupId= Some(558); typeIds= [| 13825; 13828; 6919; 6921; 6923; 6925; 6805; 6807; 6809; 6811; 23842; 3512; 3520; 456; 458; 34274; 13801; 15851; 15854; 13807; 15866; 15869 |]; description= "Medium pulse lasers, suitable for cruiser use." } |> Some
      | 669 -> { MarketGroupData.id= 669; name= "Signal Amplifiers"; parentMarketGroupId= Some(656); typeIds= [| 1986; 1987; 41196; 41197; 21527; 6296; 1949 |]; description= "Augment a ship's targeting range and target acquisition time." } |> Some
      | 766 -> { MarketGroupData.id= 766; name= "Freighters"; parentMarketGroupId= Some(1381); typeIds= [|  |]; description= "Capital ships, able to transport a world and a half and then some." } |> Some
      | 863 -> { MarketGroupData.id= 863; name= "Large"; parentMarketGroupId= Some(850); typeIds= [| 12803; 12807 |]; description= "Large advanced railgun ammunition, fired by battleship-sized guns." } |> Some
      | 87 -> { MarketGroupData.id= 87; name= "Projectile Turrets"; parentMarketGroupId= Some(10); typeIds= [|  |]; description= "Built to house cannons capable of firing superheated gunshells." } |> Some
      | 960 -> { MarketGroupData.id= 960; name= "Electronics Superiority Rigs"; parentMarketGroupId= Some(1111); typeIds= [|  |]; description= "Permanent modification of a ship's electronics superiority facilities." } |> Some
      | _ -> None