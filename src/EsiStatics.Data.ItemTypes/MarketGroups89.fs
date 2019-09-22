namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups89=
    let getMarketGroup id = 
      match id with 
      | 1059 -> { MarketGroupData.id= 1059; name= "Small"; parentMarketGroupId= Some(537); typeIds= [| 26912; 19051; 41476; 18981; 18983; 18985; 19047; 22947; 16433; 16435; 19049; 16439; 11355 |]; description= "Remote armor repair system designs, intended for frigate-class vessels." } |> Some
      | 1253 -> { MarketGroupData.id= 1253; name= "Medium Engineering Rigs"; parentMarketGroupId= Some(949); typeIds= [| 43904; 31361; 31397; 4396; 31373; 31409; 31385; 31229 |]; description= "Blueprints of Medium Energy Grid Rigs." } |> Some
      | 1350 -> { MarketGroupData.id= 1350; name= "Projectile Batteries"; parentMarketGroupId= Some(1534); typeIds= [| 2816; 2819; 2805; 2807; 2810; 2814 |]; description= "Blueprints of Projectile Batteries." } |> Some
      | 1544 -> { MarketGroupData.id= 1544; name= "Resistance Plating"; parentMarketGroupId= Some(214); typeIds= [| 1285; 1295; 1265; 1204; 1305; 1275 |]; description= "Blueprints for Resistance Plating" } |> Some
      | 1641 -> { MarketGroupData.id= 1641; name= "Cynosural Field Generators"; parentMarketGroupId= Some(779); typeIds= [| 21096; 52694; 28646 |]; description= "Cynosural Field Generators" } |> Some
      | 1835 -> { MarketGroupData.id= 1835; name= "Mobile Siphon Units"; parentMarketGroupId= Some(404); typeIds= [| 33583; 33477; 33581 |]; description= "Steals resources from Player Owned Structures." } |> Some
      | 1932 -> { MarketGroupData.id= 1932; name= "Special Edition Interceptors"; parentMarketGroupId= Some(1612); typeIds= [| 33673; 35779 |]; description= "" } |> Some
      | 2029 -> { MarketGroupData.id= 2029; name= "Faction Cruisers"; parentMarketGroupId= Some(1988); typeIds= [|  |]; description= "" } |> Some
      | 2126 -> { MarketGroupData.id= 2126; name= "Amarr"; parentMarketGroupId= Some(2125); typeIds= [| 37481 |]; description= "" } |> Some
      | 2223 -> { MarketGroupData.id= 2223; name= "Energy Neutralizers"; parentMarketGroupId= Some(2208); typeIds= [| 47332; 47330; 35924; 35925; 46575 |]; description= "" } |> Some
      | 2320 -> { MarketGroupData.id= 2320; name= "Expedition Frigates"; parentMarketGroupId= Some(2042); typeIds= [| 43777; 43778; 46982; 46983; 43790; 43791; 43803; 43804; 43816; 43817; 42672; 42673; 43829; 43830; 43842; 43843; 43750; 43751; 43763; 43764; 42615; 42616 |]; description= "" } |> Some
      | 2417 -> { MarketGroupData.id= 2417; name= "CONCORD"; parentMarketGroupId= Some(2416); typeIds= [| 45534 |]; description= "" } |> Some
      | 2514 -> { MarketGroupData.id= 2514; name= "Heat Sink Mutaplasmids"; parentMarketGroupId= Some(2512); typeIds= [| 49728; 49729; 49727 |]; description= "" } |> Some
      | 283 -> { MarketGroupData.id= 283; name= "Gallente"; parentMarketGroupId= Some(208); typeIds= [| 992; 985; 989; 990; 991 |]; description= "Blueprints of Gallente industrial designs." } |> Some
      | 380 -> { MarketGroupData.id= 380; name= "Micro"; parentMarketGroupId= Some(141); typeIds= [| 14212; 14218; 14224; 9750; 21532; 15927; 3897; 3899; 15933; 9790; 3903; 3907; 3909; 15943; 3913; 3915; 15951; 15959; 9702; 9706; 3901; 14196; 14198 |]; description= "The smallest smartbombs available, for when powergrid and CPU are scarce." } |> Some
      | 477 -> { MarketGroupData.id= 477; name= "Structures"; parentMarketGroupId= None; typeIds= [|  |]; description= "Capsuleers have many options when they decide to set up a home in space, from personal deployables to capsuleer-controlled outpost stations" } |> Some
      | 574 -> { MarketGroupData.id= 574; name= "Small"; parentMarketGroupId= Some(559); typeIds= [| 8863; 8865; 8867; 8869; 21545; 16046; 16049; 16050; 8759; 2873; 2881; 2889; 13773; 13776; 8785; 8787; 8789; 484; 485; 486; 13777; 34284; 8815; 8817; 8819; 8821 |]; description= "Frigate-sized autocannons, effective at very close ranges." } |> Some
      | 671 -> { MarketGroupData.id= 671; name= "Sensor Boosters"; parentMarketGroupId= Some(656); typeIds= [| 1952; 15280; 41411; 41191; 41192; 17520; 41194; 41195; 15276; 15278; 6159; 6160; 15282; 1973; 41193; 22895; 14236 |]; description= "Provide a boost to a ship's targeting range and target acquisition time." } |> Some
      | 768 -> { MarketGroupData.id= 768; name= "Caldari"; parentMarketGroupId= Some(766); typeIds= [| 20185 |]; description= "Caldari freighter designs." } |> Some
      | 865 -> { MarketGroupData.id= 865; name= "Small"; parentMarketGroupId= Some(850); typeIds= [| 12618; 12620 |]; description= "Small advanced railgun ammunition, fired by frigate-sized guns." } |> Some
      | 962 -> { MarketGroupData.id= 962; name= "Energy Weapon Rigs"; parentMarketGroupId= Some(1111); typeIds= [|  |]; description= "Permanent modification of a ship's energy weapon facilities." } |> Some
      | _ -> None