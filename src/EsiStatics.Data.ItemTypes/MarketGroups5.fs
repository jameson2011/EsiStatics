namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups5=
    let getMarketGroup id = 
      match id with 
      | 102 -> { MarketGroupData.id= 102; name= "Small"; parentMarketGroupId= Some(851); typeIds= [| 239; 240; 241; 242; 243; 244; 245; 246 |]; description= "Small frequency crystals, for use with frigate-sized lasers." } |> Some
      | 1072 -> { MarketGroupData.id= 1072; name= "Caldari"; parentMarketGroupId= Some(1070); typeIds= [| 11995 |]; description= "Caldari heavy interdiction cruiser designs." } |> Some
      | 1266 -> { MarketGroupData.id= 1266; name= "Large Projectile Weapon Rigs"; parentMarketGroupId= Some(953); typeIds= [| 26041; 26049; 26043; 26047; 26039 |]; description= "Blueprints of Large Projectile Weapon Rigs." } |> Some
      | 1557 -> { MarketGroupData.id= 1557; name= "Capacitor Power Relays"; parentMarketGroupId= Some(1546); typeIds= [| 1446 |]; description= "Capacitor Power Relays" } |> Some
      | 1945 -> { MarketGroupData.id= 1945; name= "Compression Array"; parentMarketGroupId= Some(1841); typeIds= [|  |]; description= "Blueprint of the Compression Array." } |> Some
      | 2042 -> { MarketGroupData.id= 2042; name= "Advanced Frigates"; parentMarketGroupId= Some(1998); typeIds= [|  |]; description= "" } |> Some
      | 2139 -> { MarketGroupData.id= 2139; name= "Gallente"; parentMarketGroupId= Some(2136); typeIds= [| 40323; 44902; 45884; 42160; 46936; 46396 |]; description= "" } |> Some
      | 2236 -> { MarketGroupData.id= 2236; name= "Fighters"; parentMarketGroupId= Some(157); typeIds= [|  |]; description= "Fighters are small combat craft launched in squadrons from Capital Ships and Structures" } |> Some
      | 2333 -> { MarketGroupData.id= 2333; name= "Industrial Command Ships"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of industrial command ships" } |> Some
      | 2430 -> { MarketGroupData.id= 2430; name= "Triglavian"; parentMarketGroupId= Some(2429); typeIds= [| 47271 |]; description= "Triglavian Battleships" } |> Some
      | 2527 -> { MarketGroupData.id= 2527; name= "Mutadaptive Remote Armor Repairers"; parentMarketGroupId= Some(14); typeIds= [|  |]; description= "" } |> Some
      | 296 -> { MarketGroupData.id= 296; name= "Small"; parentMarketGroupId= Some(287); typeIds= [| 819; 820; 821; 822; 823 |]; description= "Blueprints of small projectile turrets." } |> Some
      | 353570 -> { MarketGroupData.id= 353570; name= "Sniper Rifles"; parentMarketGroupId= Some(364047); typeIds= [|  |]; description= "Sniper rifles." } |> Some
      | 356965 -> { MarketGroupData.id= 356965; name= "Prototype"; parentMarketGroupId= Some(354490); typeIds= [|  |]; description= "" } |> Some
      | 363464 -> { MarketGroupData.id= 363464; name= "Standard"; parentMarketGroupId= Some(354338); typeIds= [|  |]; description= "Standard" } |> Some
      | 364046 -> { MarketGroupData.id= 364046; name= "Heavy"; parentMarketGroupId= Some(353562); typeIds= [|  |]; description= "Heavy dropsuit frames." } |> Some
      | 366180 -> { MarketGroupData.id= 366180; name= "Weapons"; parentMarketGroupId= Some(365998); typeIds= [|  |]; description= "" } |> Some
      | 366277 -> { MarketGroupData.id= 366277; name= "Advanced"; parentMarketGroupId= Some(366275); typeIds= [|  |]; description= "" } |> Some
      | 393 -> { MarketGroupData.id= 393; name= "Amarr"; parentMarketGroupId= Some(391); typeIds= [| 11134 |]; description= "Amarr shuttle designs." } |> Some
      | 490 -> { MarketGroupData.id= 490; name= "Reactors"; parentMarketGroupId= Some(1285); typeIds= [| 30656; 22634; 24684; 16869; 20175 |]; description= "Deployable structures where chemical processes take place." } |> Some
      | 5 -> { MarketGroupData.id= 5; name= "Standard Frigates"; parentMarketGroupId= Some(1361); typeIds= [|  |]; description= "Small, fast vessels suited to a variety of purposes." } |> Some
      | 781 -> { MarketGroupData.id= 781; name= "Standard Capital Ship Components"; parentMarketGroupId= Some(1035); typeIds= [| 24547; 21025; 21027; 24545; 21029; 21041; 21035; 24556; 21037; 24558; 21039; 24560; 21009; 21011; 21013; 21017; 21019; 21021; 21023 |]; description= "Modular components used in the manufacture of capital ships." } |> Some
      | 878 -> { MarketGroupData.id= 878; name= "Titans"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of titan-class vessels." } |> Some
      | 975 -> { MarketGroupData.id= 975; name= "Heavy Assault Missiles"; parentMarketGroupId= Some(314); typeIds= [| 26760; 26761; 26762; 21868 |]; description= "Blueprints of heavy assault missiles." } |> Some
      | _ -> None