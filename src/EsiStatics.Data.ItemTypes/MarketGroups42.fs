namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups42=
    let getMarketGroup id = 
      match id with 
      | 1012 -> { MarketGroupData.id= 1012; name= "Cynosural System Jammer"; parentMarketGroupId= Some(1285); typeIds= [| 27674 |]; description= "The lock and key to a system's highway of cynosural passage." } |> Some
      | 1109 -> { MarketGroupData.id= 1109; name= "Sleeper Components"; parentMarketGroupId= Some(19); typeIds= [| 30744; 30745; 30746; 30747 |]; description= "Mysterious pieces of technology of Sleeper origin, coveted by some empire corporations" } |> Some
      | 1206 -> { MarketGroupData.id= 1206; name= "Small Armor Rigs"; parentMarketGroupId= Some(956); typeIds= [| 31009; 31077; 31051; 33892; 31045; 31015; 33890; 30987; 31021; 31057; 31027; 30997; 31063; 31033; 31003; 27068; 31069; 31039 |]; description= "Modifications that affect a small starship's armor." } |> Some
      | 139 -> { MarketGroupData.id= 139; name= "Cap Booster Charges"; parentMarketGroupId= Some(11); typeIds= [| 3552; 3554; 41490; 33334; 32006; 263; 264; 33330; 31982; 41489; 32014; 11283; 33332; 11285; 31990; 11287; 11289; 31998 |]; description= "Give an instant boost to a spaceship's capacitor" } |> Some
      | 1400 -> { MarketGroupData.id= 1400; name= "Footwear"; parentMarketGroupId= Some(1397); typeIds= [| 36505; 36506; 36507; 36508; 36509; 36510; 4001; 4008; 34360; 34361; 34362; 4172; 4173; 4174; 4175; 4176; 4177; 4178; 4179; 33771; 33772; 33773; 33774; 33775; 33776; 33777; 33778; 33779; 33780; 3966 |]; description= "Garments worn on the feet, for fashion, protection against the environment, and adornment." } |> Some
      | 1497 -> { MarketGroupData.id= 1497; name= "Implant Slot 10"; parentMarketGroupId= Some(1476); typeIds= [| 3136; 3137; 3140; 13249; 13228; 27247; 27096; 20371; 27249; 3160; 3161; 3164; 24638 |]; description= "Implant Slot 10" } |> Some
      | 1594 -> { MarketGroupData.id= 1594; name= "Gallente"; parentMarketGroupId= Some(1591); typeIds= [| 17344; 17345; 17323; 17357; 17329; 17331; 17337; 17339; 17341 |]; description= "Gallente" } |> Some
      | 1691 -> { MarketGroupData.id= 1691; name= "EM Resistance Amplifiers"; parentMarketGroupId= Some(550); typeIds= [| 20611; 1798; 19215; 1808; 14740; 14742; 19223; 14744; 14746; 19231; 19245; 14630; 14634; 15917; 19247; 19255; 14041; 9562; 14043; 15909; 9580; 2553 |]; description= "EM Resistance Amplifiers" } |> Some
      | 1788 -> { MarketGroupData.id= 1788; name= "Large Scanning Rigs"; parentMarketGroupId= Some(1780); typeIds= [| 26342; 25930; 25932; 26350; 25936; 26104; 26362; 26346 |]; description= "Modifications that affect a large starship's scanning." } |> Some
      | 1885 -> { MarketGroupData.id= 1885; name= "Caldari"; parentMarketGroupId= Some(1883); typeIds= [| 29057; 29059; 29093; 29097; 29099; 29101; 29071; 29107; 29055 |]; description= "" } |> Some
      | 1982 -> { MarketGroupData.id= 1982; name= "Gallente"; parentMarketGroupId= Some(2377); typeIds= [| 36395; 45572; 34663; 34664; 42187; 37583; 44936; 46964; 46430; 52753; 46557; 45918 |]; description= "" } |> Some
      | 2079 -> { MarketGroupData.id= 2079; name= "Gallente"; parentMarketGroupId= Some(2067); typeIds= [| 36384; 46945; 37570; 45899; 46411; 44917; 42173; 52734; 48725 |]; description= "" } |> Some
      | 2176 -> { MarketGroupData.id= 2176; name= "Energy Neutralizers"; parentMarketGroupId= Some(2163); typeIds= [| 46576; 37043; 37044 |]; description= "" } |> Some
      | 2273 -> { MarketGroupData.id= 2273; name= "Caldari"; parentMarketGroupId= Some(2271); typeIds= [| 37605 |]; description= "Caldari force auxiliary designs." } |> Some
      | 2370 -> { MarketGroupData.id= 2370; name= "Caldari"; parentMarketGroupId= Some(2369); typeIds= [| 48544; 46024; 45997; 52303; 48816; 46120; 45843; 48186; 48543; 46847 |]; description= "" } |> Some
      | 2467 -> { MarketGroupData.id= 2467; name= "Large"; parentMarketGroupId= Some(2463); typeIds= [| 47932; 47933; 47887 |]; description= "Large Exotic Plasma Charges" } |> Some
      | 430 -> { MarketGroupData.id= 430; name= "Cloaking Devices"; parentMarketGroupId= Some(1578); typeIds= [| 13000 |]; description= "Blueprints of cloaking devices." } |> Some
      | 527 -> { MarketGroupData.id= 527; name= "Hedbergite"; parentMarketGroupId= Some(54); typeIds= [| 17440; 17441; 46696; 28400; 28401; 28402; 21; 46680 |]; description= "Sub-types of hedbergite ore." } |> Some
      | 721 -> { MarketGroupData.id= 721; name= "Ladar Backup Arrays"; parentMarketGroupId= Some(681); typeIds= [|  |]; description= "Reduces the sensors' vulnerability to Ladar jamming." } |> Some
      | 818 -> { MarketGroupData.id= 818; name= "Amarr"; parentMarketGroupId= Some(817); typeIds= [| 23757; 23919 |]; description= "Amarr carrier designs." } |> Some
      | _ -> None