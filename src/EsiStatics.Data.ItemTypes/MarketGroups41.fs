namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups41=
    let getMarketGroup id = 
      match id with 
      | 1011 -> { MarketGroupData.id= 1011; name= "Jump Bridge "; parentMarketGroupId= Some(1285); typeIds= [| 27897 |]; description= "A bridge of light, spanning the cold and empty void between the stars." } |> Some
      | 1399 -> { MarketGroupData.id= 1399; name= "Outerwear"; parentMarketGroupId= Some(1397); typeIds= [| 33792; 4097; 4098; 33795; 33796; 33797; 33798; 33793; 33800; 4233; 4234; 4235; 4236; 4237; 4238; 4239; 40464; 48387; 4244; 4245; 46674; 48385; 54177; 54307; 53382; 33799; 34348; 34349; 45742; 48082; 45744; 55857; 37810; 55858; 47286; 37815; 46038; 37817; 37818; 46666; 34347; 46274; 46659; 46662; 46664; 46665; 40522; 46667; 48384; 47032; 42702; 46672; 42705; 45522; 45523; 45524; 40462; 45526; 45527; 34393; 49978; 45525; 45741; 33794; 37603; 55012; 45521; 37864; 47476; 34156; 34157; 34158; 34159; 34160; 34161; 34162; 34163; 34164; 34165; 34166; 34167; 34168; 48383; 33791 |]; description= "Clothing worn on the outside of other clothing." } |> Some
      | 1496 -> { MarketGroupData.id= 1496; name= "Implant Slot 09"; parentMarketGroupId= Some(1476); typeIds= [| 3168; 3169; 13250; 3172; 3141; 3142; 3143; 3175; 13230; 27255; 27252; 27253; 27254; 27095; 27108; 24639; 3174; 3173 |]; description= "Implant Slot 09" } |> Some
      | 1593 -> { MarketGroupData.id= 1593; name= "Caldari"; parentMarketGroupId= Some(1591); typeIds= [| 17351; 17352; 17353; 17354; 17356; 17327; 17328; 17332; 17340 |]; description= "Caldari" } |> Some
      | 1690 -> { MarketGroupData.id= 1690; name= "Explosive Shield Amplifiers"; parentMarketGroupId= Some(550); typeIds= [| 14720; 2529; 14722; 2531; 20605; 19233; 19209; 15915; 1804; 14029; 14606; 14031; 19235; 19217; 14610; 15923; 9556; 19225; 14716; 19249; 14718 |]; description= "Explosive Shield Amplifiers" } |> Some
      | 1787 -> { MarketGroupData.id= 1787; name= "Medium Scanning Rigs"; parentMarketGroupId= Some(1780); typeIds= [| 31203; 31318; 31240; 31209; 31246; 31215; 31312; 31222 |]; description= "Modifications that affect a medium starship's scanning." } |> Some
      | 1884 -> { MarketGroupData.id= 1884; name= "Amarr"; parentMarketGroupId= Some(1883); typeIds= [| 29095; 29063; 29067; 29039; 29073; 29109; 29047; 29103; 29053 |]; description= "" } |> Some
      | 1981 -> { MarketGroupData.id= 1981; name= "Caldari"; parentMarketGroupId= Some(2377); typeIds= [| 45859; 36741; 34662; 40617; 48202; 53196; 55725; 46863; 55517; 47314; 52563; 46136; 46716; 36669; 48734; 34661 |]; description= "" } |> Some
      | 2078 -> { MarketGroupData.id= 2078; name= "Caldari"; parentMarketGroupId= Some(2067); typeIds= [| 45840; 55556; 46117; 54439; 46844; 48183; 52557; 54908; 36656; 48724; 36343; 36728; 53177; 50075; 40604; 54917 |]; description= "" } |> Some
      | 2175 -> { MarketGroupData.id= 2175; name= "Capacitor Batteries"; parentMarketGroupId= Some(2163); typeIds= [| 47354 |]; description= "" } |> Some
      | 2272 -> { MarketGroupData.id= 2272; name= "Amarr"; parentMarketGroupId= Some(2271); typeIds= [| 37604 |]; description= "Amarr force auxiliary designs." } |> Some
      | 2369 -> { MarketGroupData.id= 2369; name= "Strategic Cruisers"; parentMarketGroupId= Some(2064); typeIds= [|  |]; description= "" } |> Some
      | 2466 -> { MarketGroupData.id= 2466; name= "Medium"; parentMarketGroupId= Some(2463); typeIds= [| 47928; 47929; 47886 |]; description= "Medium Exotic Plasma Charges" } |> Some
      | 332 -> { MarketGroupData.id= 332; name= "Propulsion Upgrades"; parentMarketGroupId= Some(252); typeIds= [| 1404; 1245; 11613 |]; description= "Blueprints of propulsion upgrades." } |> Some
      | 429 -> { MarketGroupData.id= 429; name= "Minmatar"; parentMarketGroupId= Some(419); typeIds= [| 12035; 11183 |]; description= "Blueprints of Minmatar covert ops designs." } |> Some
      | 526 -> { MarketGroupData.id= 526; name= "Omber"; parentMarketGroupId= Some(54); typeIds= [| 28416; 28417; 17867; 46700; 1227; 17868; 46684; 28415 |]; description= "Sub-types of omber ore." } |> Some
      | 720 -> { MarketGroupData.id= 720; name= "Gravimetric Backup Arrays"; parentMarketGroupId= Some(681); typeIds= [|  |]; description= "Reduces the sensors' vulnerability to gravimetric jamming." } |> Some
      | 817 -> { MarketGroupData.id= 817; name= "Carriers"; parentMarketGroupId= Some(1381); typeIds= [|  |]; description= "Capital warships, able to transport and deploy hordes of smaller vessels into the field." } |> Some
      | 914 -> { MarketGroupData.id= 914; name= "Standard Auto-Targeting"; parentMarketGroupId= Some(115); typeIds= [| 1824; 1826; 1828; 1830; 1832; 269; 1810; 1814; 1816; 1818; 1820; 1822 |]; description= "Standard Auto-Targeting" } |> Some
      | _ -> None