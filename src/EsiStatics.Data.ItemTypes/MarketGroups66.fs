namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups66=
    let getMarketGroup id = 
      match id with 
      | 1133 -> { MarketGroupData.id= 1133; name= "Minmatar Offensive Subsystems"; parentMarketGroupId= Some(1626); typeIds= [| 45608; 45609; 45607 |]; description= "Minmatar offensive subsystems." } |> Some
      | 1230 -> { MarketGroupData.id= 1230; name= "Large Hybrid Weapon Rigs"; parentMarketGroupId= Some(963); typeIds= [| 26400; 26402; 26404; 25996; 25998; 26000; 26392; 26002; 26004; 26006; 26008; 26394; 26396; 26398 |]; description= "Modifications that affect a large starship's hybrid weapons." } |> Some
      | 1521 -> { MarketGroupData.id= 1521; name= "Survey Probes"; parentMarketGroupId= Some(1520); typeIds= [| 32855; 32854; 32839 |]; description= "Survey Probes" } |> Some
      | 1618 -> { MarketGroupData.id= 1618; name= "Special Edition Shuttles"; parentMarketGroupId= Some(1612); typeIds= [| 34496; 33513; 29266; 30842 |]; description= "Shuttles which have been offered to capsuleers on occasion for limited periods." } |> Some
      | 1715 -> { MarketGroupData.id= 1715; name= "Salvagers"; parentMarketGroupId= Some(1713); typeIds= [| 30836; 25861 |]; description= "" } |> Some
      | 1812 -> { MarketGroupData.id= 1812; name= "Alliance Tournament All Star Teams"; parentMarketGroupId= Some(1810); typeIds= [| 33388; 33387; 33386; 33223; 33224; 33225; 33226; 33227; 33228; 33229; 33230; 33231; 33232; 33390; 33385; 33392; 33391; 33373; 33374; 33389 |]; description= "Alliance Tournament All Star Teams" } |> Some
      | 1909 -> { MarketGroupData.id= 1909; name= "Ancient Relics"; parentMarketGroupId= Some(1872); typeIds= [| 30752; 30753; 30562; 30628; 30614; 30632; 30633; 30187; 34412; 30754; 34414; 34416; 30582; 30615; 30586; 30588; 30618; 30558 |]; description= "" } |> Some
      | 2006 -> { MarketGroupData.id= 2006; name= "Industrial Ships"; parentMarketGroupId= Some(1954); typeIds= [|  |]; description= "" } |> Some
      | 2103 -> { MarketGroupData.id= 2103; name= "Navy Faction"; parentMarketGroupId= Some(2100); typeIds= [| 44928; 47616; 45910; 46855; 52745; 36366; 45972; 45851; 42783; 48548; 48551; 48559; 46128; 48561; 36408; 46909; 47168; 48194; 52430; 46801; 48851; 52437; 46422; 42583; 45792; 45025; 36325; 36458; 46956 |]; description= "" } |> Some
      | 2200 -> { MarketGroupData.id= 2200; name= "Faction Citadels"; parentMarketGroupId= Some(2199); typeIds= [| 40340; 47512; 47513; 47514; 47515; 47516 |]; description= "" } |> Some
      | 2297 -> { MarketGroupData.id= 2297; name= "Command Burst Charges"; parentMarketGroupId= Some(11); typeIds= [|  |]; description= "Command Burst Charges" } |> Some
      | 2491 -> { MarketGroupData.id= 2491; name= "Blue Pill"; parentMarketGroupId= Some(2488); typeIds= [| 32248; 10155; 10156; 28670; 9950 |]; description= "Blue Pill Boosters" } |> Some
      | 357 -> { MarketGroupData.id= 357; name= "Drones"; parentMarketGroupId= Some(2); typeIds= [|  |]; description= "Blueprints of drone designs" } |> Some
      | 454 -> { MarketGroupData.id= 454; name= "Amarr"; parentMarketGroupId= Some(453); typeIds= [| 12020; 12004 |]; description= "Blueprints of Amarr heavy assault cruiser designs." } |> Some
      | 551 -> { MarketGroupData.id= 551; name= "Shield Extenders"; parentMarketGroupId= Some(554); typeIds= [|  |]; description= "Boost the maximum strength of the ship's shield system." } |> Some
      | 648 -> { MarketGroupData.id= 648; name= "Magnetic Field Stabilizers"; parentMarketGroupId= Some(143); typeIds= [| 11105; 44113; 22919; 15144; 15148; 15146; 10188; 10190; 15416; 44114; 15150; 15895; 9944; 13945 |]; description= "Systems designed to improve hybrid weapon efficiency." } |> Some
      | 745 -> { MarketGroupData.id= 745; name= "Guristas"; parentMarketGroupId= Some(739); typeIds= [| 12544; 12545; 12546; 17205; 17206; 17207; 17208; 17209; 12542; 12543 |]; description= "Guristas identification tags." } |> Some
      | 842 -> { MarketGroupData.id= 842; name= "Logistic Drones"; parentMarketGroupId= Some(157); typeIds= [| 28203; 23523; 23717; 23719; 33704; 28201; 33706; 28199; 33708; 22765; 33710; 28205; 33712; 28197; 33671; 28207; 23709; 23711 |]; description= "Drones that provide support to friendly ships" } |> Some
      | 939 -> { MarketGroupData.id= 939; name= "Drone Upgrades"; parentMarketGroupId= Some(209); typeIds= [| 41413; 23528; 4394; 24396; 23534; 24284; 33823 |]; description= "Blueprints of drone upgrades." } |> Some
      | _ -> None