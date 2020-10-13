namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups88=
    let getMarketGroup id = 
      match id with 
      | 1058 -> { MarketGroupData.id= 1058; name= "Medium"; parentMarketGroupId= Some(537); typeIds= [| 26913; 22949; 18987; 41477; 18989; 19053; 18991; 19057; 16441; 19055; 16443; 11357; 16447 |]; description= "Remote armor repair system designs, intended for cruiser-class vessels." } |> Some
      | 1252 -> { MarketGroupData.id= 1252; name= "Small Engineering Rigs"; parentMarketGroupId= Some(949); typeIds= [| 31395; 31371; 31407; 26930; 31383; 31227; 43902; 31359 |]; description= "Blueprints of Small Energy Grid Rigs." } |> Some
      | 1349 -> { MarketGroupData.id= 1349; name= "Missile Batteries"; parentMarketGroupId= Some(1534); typeIds= [| 2824; 2822; 2823 |]; description= "Blueprints of Missile Batteries." } |> Some
      | 1543 -> { MarketGroupData.id= 1543; name= "Energized Armor Membranes"; parentMarketGroupId= Some(214); typeIds= [| 11268; 11238; 11248; 11218; 11258; 11228; 46013 |]; description= "Blueprints for Energized Armor Membranes" } |> Some
      | 1640 -> { MarketGroupData.id= 1640; name= "Jump Portal Generators"; parentMarketGroupId= Some(779); typeIds= [| 23953; 28652 |]; description= "Jump Portal Generators" } |> Some
      | 1737 -> { MarketGroupData.id= 1737; name= "Capital Electronics Superiority Rigs"; parentMarketGroupId= Some(960); typeIds= [| 31296; 31266; 31350; 31302; 31272; 31356; 31338; 31308; 31344; 31254; 31290; 31260 |]; description= "Modifications that affect a capital starship's electronic warfare capabilities." } |> Some
      | 1834 -> { MarketGroupData.id= 1834; name= "Mobile Siphon Units"; parentMarketGroupId= Some(406); typeIds= [|  |]; description= "Blueprints of Mobile Siphon Units." } |> Some
      | 1931 -> { MarketGroupData.id= 1931; name= "Warp Accelerators"; parentMarketGroupId= Some(132); typeIds= [| 33985; 33981; 33983 |]; description= "" } |> Some
      | 2028 -> { MarketGroupData.id= 2028; name= "Standard Cruisers"; parentMarketGroupId= Some(1988); typeIds= [|  |]; description= "" } |> Some
      | 2125 -> { MarketGroupData.id= 2125; name= "Command Destroyers"; parentMarketGroupId= Some(1373); typeIds= [|  |]; description= "" } |> Some
      | 2222 -> { MarketGroupData.id= 2222; name= "Reactor Control Units"; parentMarketGroupId= Some(2208); typeIds= [| 47347; 35965 |]; description= "" } |> Some
      | 2319 -> { MarketGroupData.id= 2319; name= "Mining Barges"; parentMarketGroupId= Some(2011); typeIds= [| 43779; 43780; 43781; 46984; 46985; 46986; 46735; 43792; 43793; 43666; 43667; 43668; 42645; 42646; 43805; 43806; 43807; 56608; 56609; 56610; 43818; 43819; 43820; 42674; 42675; 42676; 43831; 43832; 43833; 43844; 43845; 43846; 42617; 46736; 46737; 43752; 43753; 43754; 43794; 43765; 43766; 43767; 42644; 42618; 42619 |]; description= "" } |> Some
      | 2416 -> { MarketGroupData.id= 2416; name= "Flag Cruisers"; parentMarketGroupId= Some(1368); typeIds= [|  |]; description= "" } |> Some
      | 2513 -> { MarketGroupData.id= 2513; name= "Magnetic Field Stabilizer Mutaplasmids"; parentMarketGroupId= Some(2512); typeIds= [| 49723; 49724; 49725 |]; description= "" } |> Some
      | 282 -> { MarketGroupData.id= 282; name= "Minmatar"; parentMarketGroupId= Some(208); typeIds= [| 986; 987; 988 |]; description= "Blueprints of Minmatar industrial designs." } |> Some
      | 379 -> { MarketGroupData.id= 379; name= "Cargo Containers"; parentMarketGroupId= Some(404); typeIds= [|  |]; description= "For deep-space storage of valuable materials." } |> Some
      | 573 -> { MarketGroupData.id= 573; name= "Large"; parentMarketGroupId= Some(558); typeIds= [| 15873; 13832; 7001; 7003; 23846; 7083; 7085; 7087; 7089; 4147; 13791; 7005; 460; 462; 6999; 14425; 14427; 14429; 14431; 34276; 15847; 14441; 14443; 14445; 14447; 3057; 15858; 15862; 13815; 13821 |]; description= "Large pulse lasers, suitable for battleship use." } |> Some
      | 670 -> { MarketGroupData.id= 670; name= "Automated Targeting Systems"; parentMarketGroupId= Some(656); typeIds= [| 6041; 6043; 1436; 6045; 1182; 6047 |]; description= "For automated targeting of hostiles." } |> Some
      | 767 -> { MarketGroupData.id= 767; name= "Amarr"; parentMarketGroupId= Some(766); typeIds= [| 20183 |]; description= "Amarr freighter designs." } |> Some
      | 864 -> { MarketGroupData.id= 864; name= "Medium"; parentMarketGroupId= Some(850); typeIds= [| 12801; 12805 |]; description= "Medium advanced railgun ammunition, fired by cruiser-sized guns." } |> Some
      | 88 -> { MarketGroupData.id= 88; name= "Energy Turrets"; parentMarketGroupId= Some(10); typeIds= [|  |]; description= "Laser turrets are built to house beam and pulse lasers." } |> Some
      | 961 -> { MarketGroupData.id= 961; name= "Engineering Rigs"; parentMarketGroupId= Some(1111); typeIds= [|  |]; description= "Permanent modification of a ship's energy grid facilities." } |> Some
      | _ -> None