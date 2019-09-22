﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups12=
    let getMarketGroup id = 
      match id with 
      | 1079 -> { MarketGroupData.id= 1079; name= "Minmatar"; parentMarketGroupId= Some(1075); typeIds= [| 22440 |]; description= "Minmatar black ops designs." } |> Some
      | 109 -> { MarketGroupData.id= 109; name= "Large"; parentMarketGroupId= Some(845); typeIds= [| 194; 195; 196; 197; 198; 199; 200; 201 |]; description= "Large projectile shells, fired by battleship-sized guns." } |> Some
      | 1273 -> { MarketGroupData.id= 1273; name= "Territorial Claim Units"; parentMarketGroupId= Some(1272); typeIds= [| 32226 |]; description= "Starbase units for claiming territory." } |> Some
      | 1370 -> { MarketGroupData.id= 1370; name= "Navy Faction"; parentMarketGroupId= Some(1369); typeIds= [| 29344; 17634; 17709; 17713; 17843; 29336; 29337; 29340 |]; description= "Navy faction cruiser designs." } |> Some
      | 1564 -> { MarketGroupData.id= 1564; name= "Energy Nosferatu"; parentMarketGroupId= Some(1546); typeIds= [| 12258; 12262; 40684; 40685; 40686; 1106 |]; description= "Energy Nosferatu" } |> Some
      | 1661 -> { MarketGroupData.id= 1661; name= "Special Edition Commodities"; parentMarketGroupId= Some(1659); typeIds= [| 37888; 37889; 48642; 37892; 37893; 37894; 37895; 37896; 48137; 48138; 48139; 48140; 48141; 48142; 48143; 48144; 33809; 46766; 41496; 45060; 45061; 45062; 49653; 49705; 48135; 49708; 49709; 52783; 48136; 47154; 46771; 52276; 52277; 49719; 46772; 52290; 52274; 52292; 52293; 52294; 46151; 52296; 52297; 52298; 41035; 52300; 52301; 49746; 49748; 48760; 48593; 48748; 48749; 48750; 48751; 48752; 34417; 34418; 34419; 34420; 34421; 34422; 34423; 34424; 34425; 34426; 34427; 34428; 34429; 34430; 34431; 34432; 34433; 34434; 34435; 34436; 49802; 49803; 49804; 47042; 49975; 47043; 47253; 47044; 44187; 44188; 44189; 43678; 43679; 44192; 44193; 44194; 44195; 46756; 44197; 44198; 44199; 28840; 44205; 44206; 44207; 44208; 44209; 44210; 44211; 44212; 44213; 44214; 44215; 44216; 48756; 52291; 48757; 48374; 48587; 48758; 48759; 49619; 48589; 40656; 43640; 48590; 47062; 47045; 48591; 50042; 48375; 48592; 47057; 46825; 49620; 47058; 47059; 42229; 42230; 33015; 33016; 33017; 33018; 33019; 33020; 33021; 33022; 33023; 33024; 33025; 33026; 33027; 33028; 33029; 33030; 49621; 47063; 47064; 48377; 48928; 48376; 33058; 33059; 33060; 33061; 33575; 33065; 33066; 46381; 49707; 52299; 52275; 48950; 48753; 48952; 48953; 47060; 49981; 49974; 48951; 49634; 49805; 48754; 47961; 47962; 47963; 48954; 48584; 50029; 50030; 48755; 50036; 50039; 50040; 50041; 47482; 50045; 50046; 50047; 50048; 48531; 48532; 48533; 48534; 48535; 48536; 43930; 43931; 43932; 43933; 52295; 45996; 49650; 49651; 44190; 52273; 44191; 33213; 33214; 33215; 33217; 33218; 33219; 33220; 33221; 47046; 47047; 47048; 48585; 48586; 42231; 48588; 47053; 47054; 47055; 47056; 34769; 34770; 34771; 34772; 34773; 34774; 34775; 34776; 34777; 34778; 48378; 46050; 48379; 49641; 49644; 49645; 49646; 49647; 49648; 49649; 37874; 37875; 49652; 37877; 37878; 37879; 37880; 37881; 37882; 37883; 37884; 37885; 37886; 37887 |]; description= "Special Edition Commodities" } |> Some
      | 1855 -> { MarketGroupData.id= 1855; name= "Ice Ores"; parentMarketGroupId= Some(1031); typeIds= [| 16262; 16263; 16264; 16265; 16266; 16267; 16268; 16269; 28433; 28434; 28435; 28436; 28437; 28438; 28439; 28440; 28441; 28442; 28443; 28444; 17975; 17976; 17977; 17978 |]; description= "Materials gathered from ice asteroids." } |> Some
      | 1952 -> { MarketGroupData.id= 1952; name= "Amarr"; parentMarketGroupId= Some(1951); typeIds= [| 34317 |]; description= "" } |> Some
      | 2049 -> { MarketGroupData.id= 2049; name= "Gallente"; parentMarketGroupId= Some(2043); typeIds= [| 44896; 46390; 36388; 36389; 46389; 52712; 42153; 42154; 46930; 37553; 37554; 47523; 45877; 45878; 52713; 47524; 46929; 44895 |]; description= "" } |> Some
      | 206 -> { MarketGroupData.id= 206; name= "Cruisers"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of cruiser-class vessels." } |> Some
      | 2146 -> { MarketGroupData.id= 2146; name= "Logistics Frigates"; parentMarketGroupId= Some(1364); typeIds= [|  |]; description= "Frigates specialized in repairing their allies" } |> Some
      | 2243 -> { MarketGroupData.id= 2243; name= "Capital"; parentMarketGroupId= Some(668); typeIds= [| 41491; 41492; 41493; 41494; 41495 |]; description= "Capital-sized capacitor boosters." } |> Some
      | 2340 -> { MarketGroupData.id= 2340; name= "Structure Engineering Rigs"; parentMarketGroupId= Some(2203); typeIds= [|  |]; description= "Structure Engineering Rigs" } |> Some
      | 2437 -> { MarketGroupData.id= 2437; name= "Armor Mutaplasmids"; parentMarketGroupId= Some(2436); typeIds= [|  |]; description= "Mutaplasmids that are used on Armor modules" } |> Some
      | 2534 -> { MarketGroupData.id= 2534; name= "Assault Damage Control Mutaplasmids"; parentMarketGroupId= Some(2532); typeIds= [| 52228; 52229; 52231 |]; description= "Assault Damage Control Mutaplasmids" } |> Some
      | 303 -> { MarketGroupData.id= 303; name= "Medium"; parentMarketGroupId= Some(301); typeIds= [| 1162; 1163; 1164; 1165; 1166; 1167; 1168; 1169 |]; description= "Blueprints of medium frequency crystals." } |> Some
      | 400 -> { MarketGroupData.id= 400; name= "Amarr"; parentMarketGroupId= Some(399); typeIds= [| 11184; 11186 |]; description= "Amarr interceptor designs." } |> Some
      | 497 -> { MarketGroupData.id= 497; name= "ORE"; parentMarketGroupId= Some(496); typeIds= [| 17481; 17477; 17479 |]; description= "Blueprints of ORE mining barge designs." } |> Some
      | 594 -> { MarketGroupData.id= 594; name= "Projectile Batteries"; parentMarketGroupId= Some(480); typeIds= [| 27649; 27554; 27556; 27557; 27559; 27653; 17770; 17771; 17772; 27650; 16688; 16689; 16631; 27655; 27652; 27644; 27646; 27647 |]; description= "Projectile turret batteries." } |> Some
      | 691 -> { MarketGroupData.id= 691; name= "Heavy"; parentMarketGroupId= Some(661); typeIds= [| 37629; 15798; 15804; 23819; 12269; 16477; 12271; 14832; 14840; 14834; 14836; 37630; 14838; 14168; 37628; 14170; 16475; 14844; 14842; 14846; 37631 |]; description= "Battleship-sized energy destabilizers." } |> Some
      | 788 -> { MarketGroupData.id= 788; name= "Amarr"; parentMarketGroupId= Some(787); typeIds= [| 20184 |]; description= "Blueprints of Amarr freighter designs." } |> Some
      | 885 -> { MarketGroupData.id= 885; name= "Caldari"; parentMarketGroupId= Some(878); typeIds= [| 3765 |]; description= "Blueprints of Caldari titan designs." } |> Some
      | _ -> None