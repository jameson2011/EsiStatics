namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups45=
    let getMarketGroup id = 
      match id with 
      | 1015 -> { MarketGroupData.id= 1015; name= "Bombs"; parentMarketGroupId= Some(11); typeIds= [| 27912; 27916; 27918; 27920; 27922; 27924; 34264 |]; description= "Large, area of effect weapons, used by stealth bombers" } |> Some
      | 1112 -> { MarketGroupData.id= 1112; name= "Subsystems"; parentMarketGroupId= Some(955); typeIds= [|  |]; description= "Components used to piece together advanced modular spaceships" } |> Some
      | 1403 -> { MarketGroupData.id= 1403; name= "Bottoms"; parentMarketGroupId= Some(1402); typeIds= [| 4101; 4102; 4103; 4104; 4105; 4106; 4107; 4108; 4109; 4110; 4111; 4112; 4113; 4114; 4115; 36500; 36501; 36502; 36503; 36504; 3997; 3998; 3999; 36499; 44121; 34358; 4016; 4017; 4018; 4019; 4020; 4021; 4022; 34108; 34105; 4026; 4028; 4030; 34111; 4032; 4033; 4034; 4035; 4036; 34102; 34359; 40525; 42701; 33744; 33745; 33746; 33747; 33748; 33749; 33750; 33751; 33752; 33753; 33754; 33755; 33756; 33757; 33758; 33759; 33760; 33761; 4069; 4070; 4071; 4072; 4073; 4074; 4075; 4076; 34357; 4078; 34110; 4085 |]; description= "Any of various garments worn below the waist." } |> Some
      | 1500 -> { MarketGroupData.id= 1500; name= "Implant Slot 08"; parentMarketGroupId= Some(1473); typeIds= [| 3232; 3233; 13220; 13221; 3206; 19689; 3211; 27085; 27086; 19695; 3216; 3185; 19699; 3188; 3189; 13222; 27087; 3231 |]; description= "Implant Slot 08" } |> Some
      | 1694 -> { MarketGroupData.id= 1694; name= "Explosive Shield Hardeners"; parentMarketGroupId= Some(553); typeIds= [| 20641; 14756; 14757; 14758; 14759; 19276; 19275; 13996; 9646; 13967; 30422; 2289; 19270; 19285; 19286; 17496; 2297; 19259; 19260; 19269 |]; description= "Explosive Shield Hardeners" } |> Some
      | 1791 -> { MarketGroupData.id= 1791; name= "Medium Targeting Rigs"; parentMarketGroupId= Some(1781); typeIds= [| 31324; 31282; 31276; 31330 |]; description= "Modifications that affect a medium starship's targeting." } |> Some
      | 1888 -> { MarketGroupData.id= 1888; name= "Gallente"; parentMarketGroupId= Some(65); typeIds= [| 11553; 11556; 11688; 11695; 11531; 11535; 11541; 11545; 11547 |]; description= "" } |> Some
      | 1985 -> { MarketGroupData.id= 1985; name= "Caldari"; parentMarketGroupId= Some(1972); typeIds= [| 46144; 36677; 45867; 34668; 36749; 40625; 48210; 46871 |]; description= "" } |> Some
      | 2082 -> { MarketGroupData.id= 2082; name= "Caldari"; parentMarketGroupId= Some(2068); typeIds= [| 46846; 48549; 46118; 45841; 46119; 45842; 46845; 36657; 36658; 36341; 36342; 48185; 48184; 36729; 36730; 40605; 40606 |]; description= "" } |> Some
      | 2179 -> { MarketGroupData.id= 2179; name= "Weapon Upgrades"; parentMarketGroupId= Some(2164); typeIds= [|  |]; description= "" } |> Some
      | 2276 -> { MarketGroupData.id= 2276; name= "Non-Racial"; parentMarketGroupId= Some(912); typeIds= [| 40633; 40634 |]; description= "" } |> Some
      | 2373 -> { MarketGroupData.id= 2373; name= "Minmatar"; parentMarketGroupId= Some(2369); typeIds= [| 52428; 46026; 45964; 46901; 48511 |]; description= "" } |> Some
      | 2470 -> { MarketGroupData.id= 2470; name= "Large"; parentMarketGroupId= Some(2464); typeIds= [| 47934; 47935 |]; description= "Large Advanced Exotic Plasma Charges" } |> Some
      | 353707 -> { MarketGroupData.id= 353707; name= "Dropsuit Command"; parentMarketGroupId= Some(353706); typeIds= [|  |]; description= "Hardwired neural augmentations used to train new abilities." } |> Some
      | 354386 -> { MarketGroupData.id= 354386; name= "Prototype"; parentMarketGroupId= Some(353602); typeIds= [|  |]; description= "" } |> Some
      | 354483 -> { MarketGroupData.id= 354483; name= "Large"; parentMarketGroupId= Some(353605); typeIds= [|  |]; description= "" } |> Some
      | 364765 -> { MarketGroupData.id= 364765; name= "Scout"; parentMarketGroupId= Some(353652); typeIds= [|  |]; description= "The Scout is a high speed, highly maneuverable vehicle optimized for guerilla warfare " } |> Some
      | 365250 -> { MarketGroupData.id= 365250; name= "Shield Rechargers"; parentMarketGroupId= Some(354433); typeIds= [|  |]; description= "Dropsuit shield rechargers." } |> Some
      | 366220 -> { MarketGroupData.id= 366220; name= "Advanced"; parentMarketGroupId= Some(366181); typeIds= [|  |]; description= "" } |> Some
      | 367772 -> { MarketGroupData.id= 367772; name= "Containers"; parentMarketGroupId= Some(367771); typeIds= [|  |]; description= "" } |> Some
      | 369227 -> { MarketGroupData.id= 369227; name= "SKIN"; parentMarketGroupId= Some(369226); typeIds= [|  |]; description= "" } |> Some
      | 433 -> { MarketGroupData.id= 433; name= "Amarr"; parentMarketGroupId= Some(432); typeIds= [| 11393; 11365 |]; description= "Amarr assault frigate designs." } |> Some
      | 530 -> { MarketGroupData.id= 530; name= "Mercoxit"; parentMarketGroupId= Some(54); typeIds= [| 11396; 17869; 17870; 28412; 28413; 28414 |]; description= "An extremely rare and valuable ore, yielding a unique mineral." } |> Some
      | 724 -> { MarketGroupData.id= 724; name= "Multi-Frequency Backup Arrays"; parentMarketGroupId= Some(681); typeIds= [|  |]; description= "Reduces the sensors' vulnerability to multiple forms of jamming." } |> Some
      | 821 -> { MarketGroupData.id= 821; name= "Minmatar"; parentMarketGroupId= Some(817); typeIds= [| 24483; 22852 |]; description= "Minmatar carrier designs." } |> Some
      | 918 -> { MarketGroupData.id= 918; name= "Advanced High Precision Cruise Missiles"; parentMarketGroupId= Some(580); typeIds= [| 24537; 24539; 2637; 24541 |]; description= "Advanced High Precision Cruise Missiles" } |> Some
      | _ -> None