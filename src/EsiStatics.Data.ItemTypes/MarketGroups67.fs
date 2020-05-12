namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups67=
    let getMarketGroup id = 
      match id with 
      | 1037 -> { MarketGroupData.id= 1037; name= "Gas Cloud Harvesters"; parentMarketGroupId= Some(1713); typeIds= [| 25812; 25266; 28788; 25540; 25542 |]; description= "Gas cloud harvester designs." } |> Some
      | 1134 -> { MarketGroupData.id= 1134; name= "Amarr Propulsion Subsystems"; parentMarketGroupId= Some(1610); typeIds= [| 45610; 45611; 45612 |]; description= "Amarr propulsion subsystems." } |> Some
      | 1231 -> { MarketGroupData.id= 1231; name= "Small Missile Launcher Rigs"; parentMarketGroupId= Some(964); typeIds= [| 31586; 31620; 31592; 31626; 31650; 31598; 31632; 31604; 31638; 31608; 31644; 31614 |]; description= "Modifications that affect a small starship's missile launchers." } |> Some
      | 1522 -> { MarketGroupData.id= 1522; name= "Materials"; parentMarketGroupId= Some(1041); typeIds= [|  |]; description= "Materials" } |> Some
      | 1619 -> { MarketGroupData.id= 1619; name= "Special Edition Frigates"; parentMarketGroupId= Some(1612); typeIds= [| 11940; 3532; 11942; 2078 |]; description= "Frigates which have been offered to capsuleers on occasion for limited periods." } |> Some
      | 1716 -> { MarketGroupData.id= 1716; name= "Survey Probe Launchers"; parentMarketGroupId= Some(1710); typeIds= [| 33271 |]; description= "Blueprints for building probes for surveying moons." } |> Some
      | 1813 -> { MarketGroupData.id= 1813; name= "NEO YC 114 Team Cards"; parentMarketGroupId= Some(1811); typeIds= [| 33031; 33032; 33033; 33034; 33035; 33036; 33037; 33038; 33039; 33040; 33041; 33042; 33043; 33044; 33045; 33046; 33047; 33048; 33049; 33050; 33051; 33052; 33053; 33054; 33055; 33056; 33057 |]; description= "NEO YC 114 Team Cards" } |> Some
      | 2007 -> { MarketGroupData.id= 2007; name= "Amarr"; parentMarketGroupId= Some(2085); typeIds= [| 34752; 34753; 42595; 42596; 43525; 45804; 42795; 42796; 45805; 53646; 53647; 37524; 37525; 46744; 43524; 46813; 46814 |]; description= "" } |> Some
      | 2104 -> { MarketGroupData.id= 2104; name= "Amarr"; parentMarketGroupId= Some(2102); typeIds= [| 53632; 53633; 37513; 37514; 53007; 42781; 42782; 52774; 46799; 46800; 48852; 48853; 42582; 36312; 36314; 45790; 45791; 48243; 48244; 43513; 43514; 42581 |]; description= "" } |> Some
      | 2201 -> { MarketGroupData.id= 2201; name= "Standard Citadels"; parentMarketGroupId= Some(2199); typeIds= [| 35832; 35833; 35834 |]; description= "" } |> Some
      | 2298 -> { MarketGroupData.id= 2298; name= "Armor Command Burst Charges"; parentMarketGroupId= Some(2297); typeIds= [| 42832; 42833; 42834 |]; description= "Armor Command Burst Charges" } |> Some
      | 2395 -> { MarketGroupData.id= 2395; name= "Moon Ores"; parentMarketGroupId= Some(1031); typeIds= [|  |]; description= "" } |> Some
      | 2492 -> { MarketGroupData.id= 2492; name= "Exile"; parentMarketGroupId= Some(2488); typeIds= [| 15480; 28676; 25349; 15479 |]; description= "Exile Boosters" } |> Some
      | 261 -> { MarketGroupData.id= 261; name= "Caldari"; parentMarketGroupId= Some(205); typeIds= [| 683; 684; 685; 949; 950; 952 |]; description= "Blueprints of Caldari frigate designs." } |> Some
      | 355572 -> { MarketGroupData.id= 355572; name= "Data Miners"; parentMarketGroupId= Some(353584); typeIds= [|  |]; description= "" } |> Some
      | 358 -> { MarketGroupData.id= 358; name= "Mining Drones"; parentMarketGroupId= Some(357); typeIds= [| 1218; 43911; 10247 |]; description= "Blueprints of mining drone designs." } |> Some
      | 365272 -> { MarketGroupData.id= 365272; name= "Pilot"; parentMarketGroupId= Some(364044); typeIds= [|  |]; description= "Pilot dropsuits." } |> Some
      | 365951 -> { MarketGroupData.id= 365951; name= "Heavy Attack Vehicle (HAV)"; parentMarketGroupId= Some(365946); typeIds= [|  |]; description= "HAV." } |> Some
      | 368667 -> { MarketGroupData.id= 368667; name= "Warbarge"; parentMarketGroupId= Some(350001); typeIds= [|  |]; description= "" } |> Some
      | 455 -> { MarketGroupData.id= 455; name= "Caldari"; parentMarketGroupId= Some(453); typeIds= [| 11994; 12012 |]; description= "Blueprints of Caldari heavy assault cruiser designs." } |> Some
      | 552 -> { MarketGroupData.id= 552; name= "Shield Boosters"; parentMarketGroupId= Some(554); typeIds= [|  |]; description= "Convert energy from the ship's core into additional shield power." } |> Some
      | 746 -> { MarketGroupData.id= 746; name= "Sansha"; parentMarketGroupId= Some(739); typeIds= [| 12547; 12548; 12549; 12550; 12551; 17210; 17211; 17212; 17213; 17214 |]; description= "Sansha's Nation identification tags." } |> Some
      | 843 -> { MarketGroupData.id= 843; name= "Combat Utility Drones"; parentMarketGroupId= Some(157); typeIds= [| 23659; 22572; 23702 |]; description= "Drones that interfere with the performance of enemy ships" } |> Some
      | 940 -> { MarketGroupData.id= 940; name= "Starbase Charters"; parentMarketGroupId= Some(19); typeIds= [| 24592; 24593; 24594; 24595; 24596; 24597 |]; description= "The required licenses to operate starbases within the borders of the empires" } |> Some
      | _ -> None