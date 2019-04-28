namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups96=
    let getMarketGroup id = 
      match id with 
      | 1066 -> { MarketGroupData.id= 1066; name= "Amarr"; parentMarketGroupId= Some(1065); typeIds= [| 11190 |]; description= "Amarr electronic attack frigate designs." } |> Some
      | 1260 -> { MarketGroupData.id= 1260; name= "Large Hybrid Weapon Rigs"; parentMarketGroupId= Some(951); typeIds= [| 25997; 25999; 26001; 26003; 26005; 26007; 26009 |]; description= "Blueprints of Large Hybrid Weapon Rigs." } |> Some
      | 1551 -> { MarketGroupData.id= 1551; name= "Shield Rechargers"; parentMarketGroupId= Some(1545); typeIds= [| 1026 |]; description= "Shield Rechargers" } |> Some
      | 1745 -> { MarketGroupData.id= 1745; name= "Armor"; parentMarketGroupId= Some(150); typeIds= [| 3392; 3393; 3394; 33078; 16069; 21803; 27936; 24568; 22806; 22807; 22808; 22809; 27902 |]; description= "Skills pertaining to efficiently protecting the structural integrity of spaceships" } |> Some
      | 1842 -> { MarketGroupData.id= 1842; name= "Mobile Micro Jump Units"; parentMarketGroupId= Some(406); typeIds= [| 33592 |]; description= "" } |> Some
      | 1939 -> { MarketGroupData.id= 1939; name= "Warp Scramblers"; parentMarketGroupId= Some(1566); typeIds= [| 40753; 40751; 40757; 40755; 1079 |]; description= "" } |> Some
      | 2036 -> { MarketGroupData.id= 2036; name= "Advanced Destroyers"; parentMarketGroupId= Some(1989); typeIds= [|  |]; description= "" } |> Some
      | 2133 -> { MarketGroupData.id= 2133; name= "Minmatar"; parentMarketGroupId= Some(2125); typeIds= [| 37480 |]; description= "" } |> Some
      | 2230 -> { MarketGroupData.id= 2230; name= "Structure Anticapital Launcher"; parentMarketGroupId= Some(2226); typeIds= [| 35921; 47323 |]; description= "" } |> Some
      | 2327 -> { MarketGroupData.id= 2327; name= "Refineries"; parentMarketGroupId= Some(477); typeIds= [| 35835; 35836 |]; description= "" } |> Some
      | 2521 -> { MarketGroupData.id= 2521; name= "Triglavian"; parentMarketGroupId= Some(2520); typeIds= [| 52321; 49923; 50140; 49933; 50158 |]; description= "Triglavian Destroyers" } |> Some
      | 290 -> { MarketGroupData.id= 290; name= "Medium"; parentMarketGroupId= Some(286); typeIds= [| 1120; 1121; 12345; 1117; 1118; 1119 |]; description= "Blueprints of medium hybrid turrets." } |> Some
      | 354340 -> { MarketGroupData.id= 354340; name= "Flux Grenades"; parentMarketGroupId= Some(353557); typeIds= [|  |]; description= "" } |> Some
      | 354534 -> { MarketGroupData.id= 354534; name= "Boosters"; parentMarketGroupId= Some(369234); typeIds= [|  |]; description= "" } |> Some
      | 366174 -> { MarketGroupData.id= 366174; name= "Dropsuits"; parentMarketGroupId= Some(365997); typeIds= [|  |]; description= "" } |> Some
      | 366271 -> { MarketGroupData.id= 366271; name= "Prototype"; parentMarketGroupId= Some(366191); typeIds= [|  |]; description= "" } |> Some
      | 368017 -> { MarketGroupData.id= 368017; name= "Loadouts"; parentMarketGroupId= Some(350001); typeIds= [|  |]; description= "" } |> Some
      | 387 -> { MarketGroupData.id= 387; name= "Torpedoes"; parentMarketGroupId= Some(114); typeIds= [|  |]; description= "Devastating jet-propelled projectiles carrying huge payloads." } |> Some
      | 484 -> { MarketGroupData.id= 484; name= "Ship Maintenance Arrays"; parentMarketGroupId= Some(1285); typeIds= [| 12237; 24646 |]; description= "Mobile hangar and fitting structures." } |> Some
      | 581 -> { MarketGroupData.id= 581; name= "Heavy Missiles"; parentMarketGroupId= Some(114); typeIds= [|  |]; description= "Jet-propelled projectiles for heavy launchers." } |> Some
      | 678 -> { MarketGroupData.id= 678; name= "ECM Bursts"; parentMarketGroupId= Some(657); typeIds= [| 580; 20581; 41350; 40693; 5361; 40690; 5363; 40692; 5365; 40694; 40691; 2117 |]; description= "Targeting jammers emitting multi-frequency disruptive signals." } |> Some
      | 775 -> { MarketGroupData.id= 775; name= "Extra Large"; parentMarketGroupId= Some(560); typeIds= [| 41156; 20454; 41158; 41159; 41160; 3571; 37307; 41157 |]; description= "Capital ship artillery cannons, for use on dreadnoughts and titans." } |> Some
      | 872 -> { MarketGroupData.id= 872; name= "Tractor Beams"; parentMarketGroupId= Some(656); typeIds= [| 24644; 24348; 4250; 4252 |]; description= "Tractor Beams" } |> Some
      | _ -> None