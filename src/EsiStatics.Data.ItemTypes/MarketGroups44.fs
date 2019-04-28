namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups44=
    let getMarketGroup id = 
      match id with 
      | 1014 -> { MarketGroupData.id= 1014; name= "Bomb Launchers"; parentMarketGroupId= Some(10); typeIds= [| 4256; 27914 |]; description= "Large launchers, designed for stealth bombers for bomb deployment." } |> Some
      | 1111 -> { MarketGroupData.id= 1111; name= "Rigs"; parentMarketGroupId= Some(955); typeIds= [|  |]; description= "Rigs modify the performance of ships in which they're installed. Destroyed if removed from a ship" } |> Some
      | 1208 -> { MarketGroupData.id= 1208; name= "Large Armor Rigs"; parentMarketGroupId= Some(956); typeIds= [| 25888; 25890; 25892; 25894; 25736; 33900; 25898; 25900; 26286; 26288; 25896; 26290; 26292; 26294; 26296; 26298; 33898; 26302 |]; description= "Modifications that affect a large starship's armor." } |> Some
      | 1402 -> { MarketGroupData.id= 1402; name= "Women's Clothing"; parentMarketGroupId= Some(1396); typeIds= [|  |]; description= "Clothing for a feminine physique" } |> Some
      | 141 -> { MarketGroupData.id= 141; name= "Smartbombs"; parentMarketGroupId= Some(9); typeIds= [|  |]; description= "Omnidirectional energy blasts that damage everything in a radius. Good against drones" } |> Some
      | 1499 -> { MarketGroupData.id= 1499; name= "Implant Slot 07"; parentMarketGroupId= Some(1473); typeIds= [| 3203; 3236; 9957; 19686; 27079; 3208; 19692; 3213; 27078; 19697; 27075; 3220; 3221; 3190; 3191; 3192; 20443; 13245; 13246 |]; description= "Implant Slot 07" } |> Some
      | 1693 -> { MarketGroupData.id= 1693; name= "Kinetic Shield Hardeners"; parentMarketGroupId= Some(553); typeIds= [| 20633; 19271; 9608; 19273; 19274; 19287; 30424; 13997; 13968; 19272; 2291; 17495; 19288; 19257; 19258; 2299; 14748; 14749; 14750; 14751 |]; description= "Kinetic Shield Hardeners" } |> Some
      | 1790 -> { MarketGroupData.id= 1790; name= "Small Targeting Rigs"; parentMarketGroupId= Some(1781); typeIds= [| 31280; 31328; 31274; 31322 |]; description= "Modifications that affect a small starship's targeting." } |> Some
      | 1887 -> { MarketGroupData.id= 1887; name= "Minmatar"; parentMarketGroupId= Some(1883); typeIds= [| 29089; 29065; 29075; 29105; 29043; 29077; 29079; 29049; 29045 |]; description= "" } |> Some
      | 1984 -> { MarketGroupData.id= 1984; name= "Amarr"; parentMarketGroupId= Some(1972); typeIds= [| 46817; 42599; 43528; 46537; 34666; 34667; 42799; 45808; 48369; 36310; 37528 |]; description= "" } |> Some
      | 2081 -> { MarketGroupData.id= 2081; name= "Amarr"; parentMarketGroupId= Some(2068); typeIds= [| 48848; 37508; 37509; 36294; 46791; 46792; 45783; 42573; 42574; 45782; 48849; 43508; 36309; 42774; 42775; 43509 |]; description= "" } |> Some
      | 2178 -> { MarketGroupData.id= 2178; name= "Missile Launchers"; parentMarketGroupId= Some(2164); typeIds= [|  |]; description= "" } |> Some
      | 2275 -> { MarketGroupData.id= 2275; name= "Minmatar"; parentMarketGroupId= Some(2271); typeIds= [| 37606 |]; description= "Minmatar force auxiliary designs." } |> Some
      | 2372 -> { MarketGroupData.id= 2372; name= "Gallente"; parentMarketGroupId= Some(2369); typeIds= [| 46025; 46948; 46414; 45902 |]; description= "" } |> Some
      | 2469 -> { MarketGroupData.id= 2469; name= "Medium"; parentMarketGroupId= Some(2464); typeIds= [| 47930; 47931 |]; description= "Medium Advanced Exotic Plasma Charges" } |> Some
      | 335 -> { MarketGroupData.id= 335; name= "Hull Upgrades"; parentMarketGroupId= Some(214); typeIds= [| 2604; 1334; 1318 |]; description= "Blueprints of hull upgrades." } |> Some
      | 353706 -> { MarketGroupData.id= 353706; name= "Dropsuit Command"; parentMarketGroupId= Some(353633); typeIds= [|  |]; description= "Hardwired neural augmentations used to train new abilities." } |> Some
      | 354385 -> { MarketGroupData.id= 354385; name= "Advanced"; parentMarketGroupId= Some(353602); typeIds= [|  |]; description= "" } |> Some
      | 365249 -> { MarketGroupData.id= 365249; name= "Shield Regulators"; parentMarketGroupId= Some(355590); typeIds= [|  |]; description= "Dropsuit shield regulators." } |> Some
      | 366219 -> { MarketGroupData.id= 366219; name= "Standard"; parentMarketGroupId= Some(366181); typeIds= [|  |]; description= "" } |> Some
      | 367771 -> { MarketGroupData.id= 367771; name= "Salvage"; parentMarketGroupId= Some(350001); typeIds= [|  |]; description= "" } |> Some
      | 369226 -> { MarketGroupData.id= 369226; name= "SKIN"; parentMarketGroupId= Some(365996); typeIds= [|  |]; description= "" } |> Some
      | 432 -> { MarketGroupData.id= 432; name= "Assault Frigates"; parentMarketGroupId= Some(1364); typeIds= [|  |]; description= "Sturdy and powerful frigates built for all-out combat." } |> Some
      | 529 -> { MarketGroupData.id= 529; name= "Jaspet"; parentMarketGroupId= Some(54); typeIds= [| 17448; 17449; 1226; 28406; 28407; 28408; 46682; 46698 |]; description= "Sub-types of jaspet ore." } |> Some
      | 723 -> { MarketGroupData.id= 723; name= "Magnetometric Backup Arrays"; parentMarketGroupId= Some(681); typeIds= [|  |]; description= "Reduces the sensors' vulnerability to magnetometric jamming." } |> Some
      | 820 -> { MarketGroupData.id= 820; name= "Gallente"; parentMarketGroupId= Some(817); typeIds= [| 23913; 42132; 23911 |]; description= "Gallente carrier designs." } |> Some
      | 917 -> { MarketGroupData.id= 917; name= "Advanced High Precision Light Missiles"; parentMarketGroupId= Some(117); typeIds= [| 24505; 24503; 24501; 2647 |]; description= "Advanced High Precision Light Missiles" } |> Some
      | _ -> None