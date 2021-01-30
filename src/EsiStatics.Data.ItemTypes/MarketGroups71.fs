namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups71=
    let getMarketGroup id = 
      match id with 
      | 1041 -> { MarketGroupData.id= 1041; name= "Manufacture & Research"; parentMarketGroupId= Some(2); typeIds= [|  |]; description= "Blueprints of items used for manufacturing and research processes" } |> Some
      | 1138 -> { MarketGroupData.id= 1138; name= "Strategic Cruisers"; parentMarketGroupId= Some(1368); typeIds= [|  |]; description= "Highly advanced cruisers that use modular components to achieve maximum versatility." } |> Some
      | 1235 -> { MarketGroupData.id= 1235; name= "Medium Shield Rigs"; parentMarketGroupId= Some(965); typeIds= [| 31824; 31778; 31748; 31718; 31784; 31754; 31724; 31790; 31760; 31730; 31796; 31766; 31736; 31812; 31802; 31772; 31818; 31742 |]; description= "Modifications that affect a medium starship's shields." } |> Some
      | 1332 -> { MarketGroupData.id= 1332; name= "Planetary Materials"; parentMarketGroupId= Some(533); typeIds= [|  |]; description= "Materials sourced from planets" } |> Some
      | 1526 -> { MarketGroupData.id= 1526; name= "Cruise Missiles"; parentMarketGroupId= Some(314); typeIds= [| 803; 804; 805; 806 |]; description= "Cruise Missiles" } |> Some
      | 1623 -> { MarketGroupData.id= 1623; name= "Special Edition Assault Frigates"; parentMarketGroupId= Some(1612); typeIds= [| 32788; 2834; 3516; 32207 |]; description= "Assault Frigates which have been offered to capsuleers on occasion for limited periods." } |> Some
      | 1720 -> { MarketGroupData.id= 1720; name= "Capital Astronautic Rigs"; parentMarketGroupId= Some(945); typeIds= [| 34309; 31110; 31146; 31182; 31122; 31158; 31194; 31164; 31134 |]; description= "Blueprints of Capital Astronautic Rigs." } |> Some
      | 1817 -> { MarketGroupData.id= 1817; name= "Caldari"; parentMarketGroupId= Some(1815); typeIds= [| 601 |]; description= "Caldari rookie ship designs." } |> Some
      | 2011 -> { MarketGroupData.id= 2011; name= "Mining Barges"; parentMarketGroupId= Some(1954); typeIds= [|  |]; description= "" } |> Some
      | 2108 -> { MarketGroupData.id= 2108; name= "Navy Faction"; parentMarketGroupId= Some(1961); typeIds= [| 36354; 44934; 44935; 48520; 53641; 48855; 36364; 46861; 46862; 52751; 52752; 48856; 47618; 46429; 52889; 47172; 45978; 45979; 49820; 49821; 45857; 45858; 42789; 42790; 52776; 36392; 46428; 52778; 48519; 55986; 42589; 53640; 48562; 46134; 36407; 55608; 55609; 55543; 52890; 46915; 46916; 47174; 48200; 48201; 53194; 46135; 53195; 56791; 36306; 45027; 47535; 56790; 46807; 46808; 55335; 45916; 45917; 42590; 45026; 36323; 55718; 45798; 45799; 36456; 52583; 52584; 46962; 46963; 54902; 55336; 55544; 55674; 55675 |]; description= "" } |> Some
      | 2205 -> { MarketGroupData.id= 2205; name= "Structure Combat Rigs"; parentMarketGroupId= Some(2203); typeIds= [|  |]; description= "Structure Combat Rigs" } |> Some
      | 2302 -> { MarketGroupData.id= 2302; name= "Skirmish Command Burst Charges"; parentMarketGroupId= Some(2297); typeIds= [| 42840; 42838; 42839 |]; description= "Skirmish Command Burst Charges" } |> Some
      | 2496 -> { MarketGroupData.id= 2496; name= "Drop"; parentMarketGroupId= Some(2489); typeIds= [| 15466; 15477; 15478; 28674 |]; description= "Drop Boosters" } |> Some
      | 2690 -> { MarketGroupData.id= 2690; name= "Precursor Dreadnoughts"; parentMarketGroupId= Some(761); typeIds= [| 52907 |]; description= "Triglavian Dreadnoughts" } |> Some
      | 459 -> { MarketGroupData.id= 459; name= "Amarr"; parentMarketGroupId= Some(458); typeIds= [| 11394; 11366 |]; description= "Blueprints of Amarr assault frigate designs." } |> Some
      | 556 -> { MarketGroupData.id= 556; name= "Blasters"; parentMarketGroupId= Some(86); typeIds= [|  |]; description= "Blasters fire magnetically contained balls of subatomic particles." } |> Some
      | 750 -> { MarketGroupData.id= 750; name= "Commanders"; parentMarketGroupId= Some(739); typeIds= [| 17287; 17288; 17289; 17290; 17291; 17292; 17293; 17294; 17295; 17296; 17297; 17298; 17299; 17300; 17301; 17302; 17303; 17304; 17305; 17306; 17847; 17852; 17743; 17623; 19663; 17630; 17642; 18679 |]; description= "The identification tags of CONCORD's most wanted." } |> Some
      | 847 -> { MarketGroupData.id= 847; name= "Advanced Autocannon Ammo"; parentMarketGroupId= Some(99); typeIds= [|  |]; description= "Sophisticated autocannon munitions incorporating cutting-edge technology." } |> Some
      | 944 -> { MarketGroupData.id= 944; name= "Armor Rigs"; parentMarketGroupId= Some(943); typeIds= [|  |]; description= "Permanent modification of a ship's armor facilities." } |> Some
      | _ -> None