namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups52=
    let getMarketGroup id = 
      match id with 
      | 1022 -> { MarketGroupData.id= 1022; name= "Improvement Platforms"; parentMarketGroupId= Some(1021); typeIds= [|  |]; description= "" } |> Some
      | 1313 -> { MarketGroupData.id= 1313; name= "Heavy Fighters"; parentMarketGroupId= Some(2237); typeIds= [| 47233; 47234; 47235; 47236; 32326; 47241; 45674; 41355; 45676; 47245; 47247; 41361; 41363; 47243; 32341; 32343; 32345; 41365 |]; description= "Blueprints of heavy fighter designs." } |> Some
      | 1410 -> { MarketGroupData.id= 1410; name= "Orbital Infrastructure"; parentMarketGroupId= Some(1320); typeIds= [| 3962 |]; description= "Gives capsuleers stronger control over a planet's resources" } |> Some
      | 1507 -> { MarketGroupData.id= 1507; name= "Implant Slot 06"; parentMarketGroupId= Some(1471); typeIds= [| 27142; 27143; 13216; 3240; 3241; 3246; 3256; 3257; 3258; 3262; 3263; 3264; 3265; 3266; 3267; 13254; 13260; 13261; 27118; 27119; 27126; 27127; 27128; 27129 |]; description= "Implant Slot 06" } |> Some
      | 1701 -> { MarketGroupData.id= 1701; name= "Personal Hangar Arrays"; parentMarketGroupId= Some(1841); typeIds= [| 33150 |]; description= "Blueprints of Personal Hangar Arrays." } |> Some
      | 1798 -> { MarketGroupData.id= 1798; name= "Large Resource Processing Rigs"; parentMarketGroupId= Some(1794); typeIds= [| 25903 |]; description= "Blueprints of Large Resource Processing Rigs." } |> Some
      | 1992 -> { MarketGroupData.id= 1992; name= "Gallente"; parentMarketGroupId= Some(2028); typeIds= [| 53376; 34689; 34690; 34691; 34692; 34693; 34694; 34695; 34696; 47502; 36369; 54787; 55573; 44182; 44183; 44184; 44185; 46405; 48555; 46406; 55574; 46404; 47529; 47530; 46407; 54446; 56882; 55603; 42166; 42167; 42168; 42169; 37563; 37564; 37565; 37566; 37057; 45892; 45893; 45894; 45895; 48721; 50002; 52435; 48228; 46562; 55577; 46564; 57062; 53137; 57020; 44910; 44911; 44912; 44913; 52395; 46718; 52727; 52728; 52729; 52730; 45565; 45566 |]; description= "" } |> Some
      | 2089 -> { MarketGroupData.id= 2089; name= "Caldari"; parentMarketGroupId= Some(2087); typeIds= [| 55561; 36747; 36748; 46869; 46870; 52639; 52640; 46754; 46755; 45865; 45866; 55724; 40623; 40624; 46142; 46143; 36675; 36676; 48208; 52561; 53202; 53203; 48209; 36348; 36349; 55551 |]; description= "" } |> Some
      | 2186 -> { MarketGroupData.id= 2186; name= "Point Defense Batteries"; parentMarketGroupId= Some(2163); typeIds= [| 37029 |]; description= "" } |> Some
      | 2283 -> { MarketGroupData.id= 2283; name= "Capsules"; parentMarketGroupId= Some(1954); typeIds= [|  |]; description= "" } |> Some
      | 2380 -> { MarketGroupData.id= 2380; name= "Pirate Faction"; parentMarketGroupId= Some(2378); typeIds= [| 46979; 46043; 46876; 46822 |]; description= "" } |> Some
      | 2477 -> { MarketGroupData.id= 2477; name= "Implant Slot 09"; parentMarketGroupId= Some(2473); typeIds= [| 54540; 48148; 48149; 54542; 54541 |]; description= "Implant Slot 09" } |> Some
      | 343 -> { MarketGroupData.id= 343; name= "Weapon Upgrades"; parentMarketGroupId= Some(210); typeIds= [| 11616; 11617; 11621; 33401; 1096; 35772; 49971; 35791; 27952; 28584; 12275; 52245; 20281; 9945; 11612; 48095 |]; description= "Blueprints of weapon upgrades." } |> Some
      | 440 -> { MarketGroupData.id= 440; name= "Gallente"; parentMarketGroupId= Some(437); typeIds= [| 11989 |]; description= "Gallente logistics vessel designs." } |> Some
      | 52 -> { MarketGroupData.id= 52; name= "Propulsion "; parentMarketGroupId= Some(9); typeIds= [|  |]; description= "Modules that affect the navigational properties of a spaceship" } |> Some
      | 537 -> { MarketGroupData.id= 537; name= "Remote Armor Repairers"; parentMarketGroupId= Some(14); typeIds= [|  |]; description= "Patch up your comrades at a distance." } |> Some
      | 634 -> { MarketGroupData.id= 634; name= "Transport Ships"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of transport-class vessels." } |> Some
      | 731 -> { MarketGroupData.id= 731; name= "Ammatar Navy"; parentMarketGroupId= Some(616); typeIds= [| 15617; 15618; 15619; 15620; 15621; 15622; 15623; 16001; 15979; 17999; 15672; 15993; 15671; 15640; 15641; 15642; 15643 |]; description= "Officially sanctioned Ammatar Navy insignias." } |> Some
      | 828 -> { MarketGroupData.id= 828; name= "Caldari"; parentMarketGroupId= Some(822); typeIds= [| 22470; 22446 |]; description= "Caldari command ship designs." } |> Some
      | 925 -> { MarketGroupData.id= 925; name= "Advanced High Damage Cruise Missiles"; parentMarketGroupId= Some(580); typeIds= [| 24531; 2621; 24535; 24533 |]; description= "Advanced High Damage Cruise Missiles" } |> Some
      | _ -> None