namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups54=
    let getMarketGroup id = 
      match id with 
      | 1509 -> { MarketGroupData.id= 1509; name= "Implant Slot 08"; parentMarketGroupId= Some(1471); typeIds= [| 3237; 3238; 3239; 13259; 27116; 27117 |]; description= "Implant Slot 08" } |> Some
      | 1703 -> { MarketGroupData.id= 1703; name= "Faction Battlecruisers"; parentMarketGroupId= Some(1374); typeIds= [|  |]; description= "Battlecruisers designed by specific factions." } |> Some
      | 1800 -> { MarketGroupData.id= 1800; name= "Small Resource Processing Rigs"; parentMarketGroupId= Some(1794); typeIds= [| 31084 |]; description= "Blueprints of Small Resource Processing Rigs." } |> Some
      | 1897 -> { MarketGroupData.id= 1897; name= "Faction Materials"; parentMarketGroupId= Some(533); typeIds= [|  |]; description= "" } |> Some
      | 1994 -> { MarketGroupData.id= 1994; name= "Amarr"; parentMarketGroupId= Some(2035); typeIds= [| 53612; 42762; 42763; 53132; 34702; 34703; 34704; 53537; 52394; 45769; 53307; 46526; 42560; 42561; 34700; 45770; 48845; 48219; 43496; 43497; 53611; 44140; 44141; 35062; 53367; 37497; 37498 |]; description= "" } |> Some
      | 2091 -> { MarketGroupData.id= 2091; name= "Minmatar"; parentMarketGroupId= Some(2087); typeIds= [| 40512; 40513; 52898; 45987; 45988; 36841; 36842; 46924; 46925; 52899; 36437; 36438; 36794; 36795; 46748; 46749 |]; description= "" } |> Some
      | 2188 -> { MarketGroupData.id= 2188; name= "Capacitor Power Relays"; parentMarketGroupId= Some(2163); typeIds= [| 47357 |]; description= "" } |> Some
      | 2285 -> { MarketGroupData.id= 2285; name= "Capsules"; parentMarketGroupId= Some(2283); typeIds= [| 47651; 45482; 41579; 41580 |]; description= "" } |> Some
      | 2382 -> { MarketGroupData.id= 2382; name= "Faction Titans"; parentMarketGroupId= Some(1973); typeIds= [|  |]; description= "" } |> Some
      | 2479 -> { MarketGroupData.id= 2479; name= "Abyssal Materials"; parentMarketGroupId= Some(1031); typeIds= [| 48112; 47975 |]; description= "Materials found in Abyssal Deadspace" } |> Some
      | 353716 -> { MarketGroupData.id= 353716; name= "Turret Upgrades"; parentMarketGroupId= Some(353713); typeIds= [|  |]; description= "Hardwired neural augmentations used to train new abilities." } |> Some
      | 354686 -> { MarketGroupData.id= 354686; name= "Laser Rifles"; parentMarketGroupId= Some(364047); typeIds= [|  |]; description= "Laser rifles." } |> Some
      | 355462 -> { MarketGroupData.id= 355462; name= "Weapons"; parentMarketGroupId= Some(355449); typeIds= [|  |]; description= "" } |> Some
      | 442 -> { MarketGroupData.id= 442; name= "Logistics"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of Logistics-class vessels." } |> Some
      | 54 -> { MarketGroupData.id= 54; name= "Standard Ores"; parentMarketGroupId= Some(1031); typeIds= [|  |]; description= "Chunks of raw material harvested from asteroids." } |> Some
      | 636 -> { MarketGroupData.id= 636; name= "Caldari"; parentMarketGroupId= Some(634); typeIds= [| 12730; 12732 |]; description= "Blueprints of Caldari transport designs." } |> Some
      | 733 -> { MarketGroupData.id= 733; name= "CONCORD"; parentMarketGroupId= Some(616); typeIds= [| 16617; 16118; 16119; 16120; 16121; 16122; 16123; 16124; 16125 |]; description= "Officially sanctioned CONCORD insignias." } |> Some
      | 830 -> { MarketGroupData.id= 830; name= "Caldari"; parentMarketGroupId= Some(824); typeIds= [| 11957; 11959 |]; description= "Caldari recon ship designs." } |> Some
      | 927 -> { MarketGroupData.id= 927; name= "Advanced High Damage Light Missiles"; parentMarketGroupId= Some(117); typeIds= [| 24497; 24499; 2613; 24495 |]; description= "Advanced High Damage Light Missiles" } |> Some
      | _ -> None