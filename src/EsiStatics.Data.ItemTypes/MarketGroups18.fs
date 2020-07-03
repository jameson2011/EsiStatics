namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups18=
    let getMarketGroup id = 
      match id with 
      | 1085 -> { MarketGroupData.id= 1085; name= "Warp Disruption Field Generators"; parentMarketGroupId= Some(657); typeIds= [| 37608; 37610; 37611; 37612; 37613; 28654; 4248 |]; description= "A ship system that generates a local warp disruption field, preventing warp travel." } |> Some
      | 115 -> { MarketGroupData.id= 115; name= "Auto-Targeting"; parentMarketGroupId= Some(114); typeIds= [|  |]; description= "For when targeting systems fail." } |> Some
      | 1376 -> { MarketGroupData.id= 1376; name= "Battleships"; parentMarketGroupId= Some(4); typeIds= [|  |]; description= "Large-sized spaceships with enough offensive and defensive capabilities to tackle all but the biggest problems" } |> Some
      | 1473 -> { MarketGroupData.id= 1473; name= "Gunnery Implants"; parentMarketGroupId= Some(531); typeIds= [|  |]; description= "Gunnery Implants" } |> Some
      | 1570 -> { MarketGroupData.id= 1570; name= "Stasis Webifiers"; parentMarketGroupId= Some(1566); typeIds= [| 1102 |]; description= "Stasis Webifiers" } |> Some
      | 1667 -> { MarketGroupData.id= 1667; name= "Explosive Resistance Plating"; parentMarketGroupId= Some(540); typeIds= [| 28552; 17516; 17553; 18716; 18718; 1264; 14888; 14890; 14892; 14894; 14896; 14898; 14900; 14902; 18744; 18746; 14011; 14013; 14015; 16321; 16323; 18756; 16325; 18758; 15689; 15699; 15188; 15190; 15192; 15194; 18783; 14053; 18793; 14572; 1262; 14576; 1266; 18772; 16319 |]; description= "Explosive Resistance Plating" } |> Some
      | 1764 -> { MarketGroupData.id= 1764; name= "Neural Enhancement Implants"; parentMarketGroupId= Some(531); typeIds= [|  |]; description= "Biology Implants" } |> Some
      | 1861 -> { MarketGroupData.id= 1861; name= "Salvage Materials"; parentMarketGroupId= Some(533); typeIds= [|  |]; description= "" } |> Some
      | 1958 -> { MarketGroupData.id= 1958; name= "Gallente"; parentMarketGroupId= Some(2101); typeIds= [| 53378; 52740; 52741; 52742; 53244; 52397; 47633; 53013; 36376; 54788; 55581; 54430; 55583; 39584; 49956; 47533; 48558; 34611; 34612; 55582; 34614; 34615; 34616; 34617; 52283; 35006; 42177; 42178; 42179; 48836; 37573; 37574; 37575; 46417; 45906; 45907; 52436; 48229; 45905; 46952; 46953; 46951; 46418; 50031; 46419; 44923; 44924; 44925; 46719 |]; description= "" } |> Some
      | 2055 -> { MarketGroupData.id= 2055; name= "Amarr"; parentMarketGroupId= Some(2045); typeIds= [| 55297; 36290; 45763; 43492; 53605; 37494; 42756; 42554; 46778 |]; description= "" } |> Some
      | 2152 -> { MarketGroupData.id= 2152; name= "Structure Management"; parentMarketGroupId= Some(150); typeIds= [| 11584; 37796; 37797; 37798; 37799; 3373 |]; description= "Skills pertaining to the efficient use of player owned structures" } |> Some
      | 2249 -> { MarketGroupData.id= 2249; name= "Burst Projectors"; parentMarketGroupId= Some(657); typeIds= [| 40699; 40700; 40696; 40697; 40698; 40635; 40636; 27678 |]; description= "" } |> Some
      | 2346 -> { MarketGroupData.id= 2346; name= "X-Large Structure Combat Rigs"; parentMarketGroupId= Some(2205); typeIds= [| 37268; 37269; 37272; 37273; 37274; 37275 |]; description= "X-Large Structure Combat Rigs" } |> Some
      | 2443 -> { MarketGroupData.id= 2443; name= "Small Armor Mutaplasmids"; parentMarketGroupId= Some(2437); typeIds= [| 47809; 47810; 47811; 47841; 47766; 47767; 47768 |]; description= "Small Armor Mutaplasmids" } |> Some
      | 2540 -> { MarketGroupData.id= 2540; name= "Talassonite"; parentMarketGroupId= Some(54); typeIds= [| 52306 |]; description= "Talassonite" } |> Some
      | 2734 -> { MarketGroupData.id= 2734; name= "Small"; parentMarketGroupId= Some(2729); typeIds= [| 54769; 54770; 54771; 54772 |]; description= "" } |> Some
      | 309 -> { MarketGroupData.id= 309; name= "Large"; parentMarketGroupId= Some(299); typeIds= [| 896; 897; 898; 899; 900; 901; 902; 895 |]; description= "Blueprints of large projectile ammunition." } |> Some
      | 406 -> { MarketGroupData.id= 406; name= "Deployable Structures"; parentMarketGroupId= Some(1338); typeIds= [|  |]; description= "Blueprints of deployable structures." } |> Some
      | 503 -> { MarketGroupData.id= 503; name= "Extra Large"; parentMarketGroupId= Some(851); typeIds= [| 17680; 17682; 17684; 17686; 17688; 17690; 17692; 17694 |]; description= "For use with dreadnought-sized lasers and stationary defense systems." } |> Some
      | 600 -> { MarketGroupData.id= 600; name= "Capital"; parentMarketGroupId= Some(128); typeIds= [| 3616; 41472; 3618; 41473; 41483; 41474; 3544; 41469; 41470; 41471 |]; description= "Capital ship-sized shield transport units." } |> Some
      | 697 -> { MarketGroupData.id= 697; name= "Large"; parentMarketGroupId= Some(663); typeIds= [| 12225; 12102; 16487; 31946; 23856; 16481 |]; description= "Battleship-sized energy transfer arrays." } |> Some
      | 794 -> { MarketGroupData.id= 794; name= "Extra Large"; parentMarketGroupId= Some(288); typeIds= [| 41120; 41121; 41122; 41123; 41068; 41069; 41070; 41071; 41072; 41105; 41106; 41107; 41108; 20445; 20447 |]; description= "Blueprints of capital-sized laser turrets." } |> Some
      | 891 -> { MarketGroupData.id= 891; name= "Minmatar"; parentMarketGroupId= Some(879); typeIds= [| 24484; 22853 |]; description= "Blueprints of Minmatar carrier and mothership designs." } |> Some
      | 988 -> { MarketGroupData.id= 988; name= "Medium"; parentMarketGroupId= Some(986); typeIds= [| 21896; 21904; 21912; 19994; 19996; 19998; 20000; 20769; 20002; 20771; 20004; 20773; 20006; 20775; 20008; 20777; 20779; 20781; 28334; 20783; 21937; 21922; 28326; 21928 |]; description= "Medium faction ammunition, fired by cruiser-sized guns" } |> Some
      | _ -> None