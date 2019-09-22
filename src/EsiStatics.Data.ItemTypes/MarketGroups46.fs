namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups46=
    let getMarketGroup id = 
      match id with 
      | 1016 -> { MarketGroupData.id= 1016; name= "Bombs"; parentMarketGroupId= Some(211); typeIds= [| 27913; 27917; 27919; 27921; 27923; 27925 |]; description= "Blueprints of bombs." } |> Some
      | 1210 -> { MarketGroupData.id= 1210; name= "Small Astronautic Rigs"; parentMarketGroupId= Some(957); typeIds= [| 31105; 31171; 31141; 31111; 31177; 31147; 31117; 31183; 31153; 31123; 31189; 31159; 31129; 34266; 31195; 31165; 31135 |]; description= "Modifications that affect a small starship's astronautics." } |> Some
      | 1404 -> { MarketGroupData.id= 1404; name= "Footwear"; parentMarketGroupId= Some(1402); typeIds= [| 36515; 4116; 4117; 4118; 4119; 4120; 4121; 4122; 4123; 4124; 4125; 4126; 4127; 4128; 4129; 4002; 4003; 4004; 4133; 4134; 4135; 34088; 34089; 36511; 33714; 36516; 33716; 33717; 33718; 33719; 33720; 33721; 33722; 33723; 33724; 33725; 34080; 36513; 34083; 36512; 4130; 4131; 4132; 34363; 34086; 34364; 34365; 36514 |]; description= "Garments worn on the feet, for fashion, protection against the environment, and adornment." } |> Some
      | 143 -> { MarketGroupData.id= 143; name= "Weapon Upgrades"; parentMarketGroupId= Some(10); typeIds= [|  |]; description= "Subsystems designed to improve weapon efficiency." } |> Some
      | 1501 -> { MarketGroupData.id= 1501; name= "Implant Slot 09"; parentMarketGroupId= Some(1473); typeIds= [| 3234; 3235; 3204; 27077; 19687; 3209; 13244; 25868; 19693; 3214; 19696; 3217; 13166; 27081; 27076; 3193; 3194; 3195; 10204 |]; description= "Implant Slot 09" } |> Some
      | 1598 -> { MarketGroupData.id= 1598; name= "Orbital Strike"; parentMarketGroupId= Some(99); typeIds= [|  |]; description= "" } |> Some
      | 1695 -> { MarketGroupData.id= 1695; name= "EM Shield Hardeners"; parentMarketGroupId= Some(553); typeIds= [| 14752; 14753; 14754; 14755; 19265; 13994; 20639; 13965; 19279; 19280; 19281; 19282; 19264; 30420; 2293; 9622; 17499; 19266; 2301; 19263 |]; description= "EM Shield Hardeners" } |> Some
      | 1792 -> { MarketGroupData.id= 1792; name= "Large Targeting Rigs"; parentMarketGroupId= Some(1781); typeIds= [| 26364; 26100; 26358; 26102 |]; description= "Modifications that affect a large starship's targeting." } |> Some
      | 1889 -> { MarketGroupData.id= 1889; name= "Minmatar"; parentMarketGroupId= Some(65); typeIds= [| 11555; 11530; 11691; 11692; 11536; 11538; 11542; 11548; 11551 |]; description= "" } |> Some
      | 1986 -> { MarketGroupData.id= 1986; name= "Gallente"; parentMarketGroupId= Some(1972); typeIds= [| 45929; 36396; 34669; 34670; 45581; 44947; 42198; 46441; 37594; 52764; 46974; 46559 |]; description= "" } |> Some
      | 2083 -> { MarketGroupData.id= 2083; name= "Gallente"; parentMarketGroupId= Some(2068); typeIds= [| 52736; 46946; 37571; 37572; 52735; 46412; 45900; 45901; 46413; 46947; 36382; 44918; 44919; 36383; 42174; 42175 |]; description= "" } |> Some
      | 2180 -> { MarketGroupData.id= 2180; name= "Doomsday Devices"; parentMarketGroupId= Some(2164); typeIds= [| 37030 |]; description= "" } |> Some
      | 2277 -> { MarketGroupData.id= 2277; name= "Force Auxiliaries"; parentMarketGroupId= Some(1968); typeIds= [|  |]; description= "" } |> Some
      | 2374 -> { MarketGroupData.id= 2374; name= "Standard Carriers"; parentMarketGroupId= Some(1970); typeIds= [|  |]; description= "" } |> Some
      | 2471 -> { MarketGroupData.id= 2471; name= "Entropic Radiation Sinks"; parentMarketGroupId= Some(143); typeIds= [| 52244; 52242; 47908; 47909; 47911 |]; description= "Increases damage and rate of fire for Entropic Disintegrators" } |> Some
      | 434 -> { MarketGroupData.id= 434; name= "Caldari"; parentMarketGroupId= Some(432); typeIds= [| 11379; 11381 |]; description= "Caldari assault frigate designs." } |> Some
      | 531 -> { MarketGroupData.id= 531; name= "Skill Hardwiring"; parentMarketGroupId= Some(27); typeIds= [|  |]; description= "Implants designed to increase a pilot's aptitude in a specialized area." } |> Some
      | 725 -> { MarketGroupData.id= 725; name= "Gravimetric Sensors"; parentMarketGroupId= Some(685); typeIds= [|  |]; description= "Boost a ship's gravimetric sensor strength for a short duration." } |> Some
      | 822 -> { MarketGroupData.id= 822; name= "Command Ships"; parentMarketGroupId= Some(1375); typeIds= [|  |]; description= "Battlecruiser-class vessels, designed to aid their allies on the battlefield." } |> Some
      | 919 -> { MarketGroupData.id= 919; name= "Advanced High Precision Heavy Missiles"; parentMarketGroupId= Some(581); typeIds= [| 24513; 24515; 24517; 2655 |]; description= "Advanced High Precision Heavy Missiles" } |> Some
      | _ -> None