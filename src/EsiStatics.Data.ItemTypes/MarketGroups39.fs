namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups39=
    let getMarketGroup id = 
      match id with 
      | 1009 -> { MarketGroupData.id= 1009; name= "Energy Neutralization Batteries"; parentMarketGroupId= Some(480); typeIds= [| 27672; 27856; 27857; 27858; 27855 |]; description= "A starbase array designed to neutralize the capacitor of hostile ships in the area." } |> Some
      | 1203 -> { MarketGroupData.id= 1203; name= "Small Armor Rigs"; parentMarketGroupId= Some(944); typeIds= [| 31010; 33891; 31046; 30988; 31022; 30998; 31064; 31034; 27069 |]; description= "Blueprints of Small Armor Rigs." } |> Some
      | 1397 -> { MarketGroupData.id= 1397; name= "Men's Clothing"; parentMarketGroupId= Some(1396); typeIds= [|  |]; description= "Clothing for a masculine physique" } |> Some
      | 1494 -> { MarketGroupData.id= 1494; name= "Implant Slot 07"; parentMarketGroupId= Some(1476); typeIds= [| 13229; 3128; 3129; 24636; 24637; 3134; 13247; 13248; 27092; 27093; 3158; 3159; 3165; 3166; 3167; 27109; 3132; 27245; 27246; 3133; 27250; 27251; 3135; 3157 |]; description= "Implant Slot 07" } |> Some
      | 1591 -> { MarketGroupData.id= 1591; name= "Advanced Components"; parentMarketGroupId= Some(800); typeIds= [|  |]; description= "Advanced Components" } |> Some
      | 1688 -> { MarketGroupData.id= 1688; name= "Thermal Resistance Amplifiers"; parentMarketGroupId= Some(550); typeIds= [| 14724; 14726; 14728; 14730; 19211; 19219; 14614; 14618; 19227; 19237; 19239; 15913; 1800; 15921; 19251; 14033; 14035; 9566; 9568; 2537; 2539; 20607 |]; description= "Thermal Resistance Amplifiers" } |> Some
      | 1785 -> { MarketGroupData.id= 1785; name= "Capital Resource Processing Rigs"; parentMarketGroupId= Some(1779); typeIds= [| 31093; 31087 |]; description= "Modifications that affect a capital starship's resource processing." } |> Some
      | 1979 -> { MarketGroupData.id= 1979; name= "Gallente"; parentMarketGroupId= Some(2381); typeIds= [| 45921; 46967; 46551; 46433; 50152; 44939; 37586; 42190; 34674; 34675; 47540; 45582; 36375; 52440; 49428; 52756; 47643; 53431; 50079 |]; description= "" } |> Some
      | 2076 -> { MarketGroupData.id= 2076; name= "Minmatar"; parentMarketGroupId= Some(2066); typeIds= [| 46018; 48507; 36773; 52871; 45960; 40490; 46897; 36434; 36820; 47163 |]; description= "" } |> Some
      | 2173 -> { MarketGroupData.id= 2173; name= "CPU Upgrades"; parentMarketGroupId= Some(2162); typeIds= [| 37028 |]; description= "" } |> Some
      | 2270 -> { MarketGroupData.id= 2270; name= "Minmatar"; parentMarketGroupId= Some(912); typeIds= [| 43664; 41441; 23674; 41444 |]; description= "" } |> Some
      | 2464 -> { MarketGroupData.id= 2464; name= "Advanced Exotic Plasma Charges"; parentMarketGroupId= Some(2462); typeIds= [|  |]; description= "Advanced Exotic Plasma Charges" } |> Some
      | 2658 -> { MarketGroupData.id= 2658; name= "Triglavian"; parentMarketGroupId= Some(65); typeIds= [| 53288; 53289; 53290; 52310; 52311; 52312; 52313; 52314 |]; description= "Advanced Components of Triglavian origin." } |> Some
      | 353604 -> { MarketGroupData.id= 353604; name= "Sentinel"; parentMarketGroupId= Some(364046); typeIds= [|  |]; description= "Sentinel dropsuits." } |> Some
      | 354380 -> { MarketGroupData.id= 354380; name= "Standard"; parentMarketGroupId= Some(353604); typeIds= [|  |]; description= "" } |> Some
      | 354671 -> { MarketGroupData.id= 354671; name= "Scan Enhancers"; parentMarketGroupId= Some(353584); typeIds= [|  |]; description= "" } |> Some
      | 363304 -> { MarketGroupData.id= 363304; name= "180mm Armor Plates"; parentMarketGroupId= Some(354444); typeIds= [|  |]; description= "Heavy armor plating" } |> Some
      | 365244 -> { MarketGroupData.id= 365244; name= "Armor Plates"; parentMarketGroupId= Some(354423); typeIds= [|  |]; description= "Dropsuit armor plates." } |> Some
      | 366214 -> { MarketGroupData.id= 366214; name= "Advanced"; parentMarketGroupId= Some(366189); typeIds= [|  |]; description= "" } |> Some
      | 369221 -> { MarketGroupData.id= 369221; name= "SKIN"; parentMarketGroupId= Some(369220); typeIds= [|  |]; description= "" } |> Some
      | 427 -> { MarketGroupData.id= 427; name= "Caldari"; parentMarketGroupId= Some(419); typeIds= [| 11193; 12031 |]; description= "Blueprints of Caldari covert ops designs." } |> Some
      | 621 -> { MarketGroupData.id= 621; name= "Implant Slot 04"; parentMarketGroupId= Some(532); typeIds= [| 54401; 28804; 33925; 54407; 28810; 33559; 32109; 28816; 33937; 20502; 20503; 53905; 33967; 2589; 53893; 33955; 33943; 33961; 33949; 52788; 33973; 52919; 20159; 33931; 33526; 52681; 53706; 31970; 53712; 19537; 31956; 9943; 42200; 14298; 33807; 31964; 22109; 42207; 53856; 19554; 22115; 53899; 42213; 13287; 31976; 22121; 32103; 10221; 10222; 22127; 32114; 22134; 32119; 28792; 54395; 28798; 33919 |]; description= "Implants intended for Subcervical Processing Slot 4." } |> Some
      | 718 -> { MarketGroupData.id= 718; name= "Radar Jammers"; parentMarketGroupId= Some(677); typeIds= [| 28737; 20579; 1956; 19948; 19950; 2575; 19952 |]; description= "Targeting jammers specialized for use against radar sensors." } |> Some
      | 815 -> { MarketGroupData.id= 815; name= "Gallente"; parentMarketGroupId= Some(812); typeIds= [| 671 |]; description= "Gallente titan designs." } |> Some
      | 912 -> { MarketGroupData.id= 912; name= "Superweapons"; parentMarketGroupId= Some(10); typeIds= [|  |]; description= "The titan's fist." } |> Some
      | _ -> None