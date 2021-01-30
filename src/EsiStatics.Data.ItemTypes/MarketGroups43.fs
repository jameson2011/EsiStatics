namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups43=
    let getMarketGroup id = 
      match id with 
      | 1013 -> { MarketGroupData.id= 1013; name= "Cynosural Generator Array"; parentMarketGroupId= Some(1285); typeIds= [| 27673 |]; description= "A lighthouse in the sea of nothing, casting its cynosural light out to far-off ships." } |> Some
      | 1110 -> { MarketGroupData.id= 1110; name= "Scanning"; parentMarketGroupId= Some(150); typeIds= [| 25739; 25810; 25811; 3412; 21718; 13278; 3551 |]; description= "Skills pertaining to signature recognition and identification procedures" } |> Some
      | 1207 -> { MarketGroupData.id= 1207; name= "Medium Armor Rigs"; parentMarketGroupId= Some(956); typeIds= [| 31041; 31011; 33894; 31047; 33896; 31017; 31073; 31079; 31053; 31023; 31055; 31059; 31029; 30999; 31065; 31035; 31005; 31071 |]; description= "Modifications that affect a medium starship's armor." } |> Some
      | 140 -> { MarketGroupData.id= 140; name= "Missile Launchers"; parentMarketGroupId= Some(10); typeIds= [|  |]; description= "For the launching of jet-propelled guided missiles." } |> Some
      | 1401 -> { MarketGroupData.id= 1401; name= "Bottoms"; parentMarketGroupId= Some(1397); typeIds= [| 36493; 36494; 36495; 36496; 36497; 36498; 3992; 54308; 34354; 34355; 34356; 4165; 4166; 4167; 4168; 4169; 4170; 4171; 40524; 44124; 56849; 56850; 33781; 33782; 33783; 33784; 33785; 33786; 33787; 33788; 33789; 33790 |]; description= "Any of various garments worn below the waist. " } |> Some
      | 1498 -> { MarketGroupData.id= 1498; name= "Implant Slot 06"; parentMarketGroupId= Some(1473); typeIds= [| 3200; 3201; 3202; 19691; 3207; 13224; 13225; 19690; 13223; 3212; 19700; 3225; 3226; 3227; 27084; 27082; 27083; 3199 |]; description= "Implant Slot 06" } |> Some
      | 1595 -> { MarketGroupData.id= 1595; name= "Minmatar"; parentMarketGroupId= Some(1591); typeIds= [| 17346; 17347; 17322; 17355; 17324; 17325; 17326; 17333; 17342 |]; description= "Minmatar" } |> Some
      | 1692 -> { MarketGroupData.id= 1692; name= "Thermal Shield Hardeners"; parentMarketGroupId= Some(553); typeIds= [| 14763; 19268; 30342; 14760; 14761; 14762; 13995; 19277; 13966; 19267; 19284; 19278; 2295; 54295; 17497; 19283; 20635; 9660; 19261; 19262; 2303 |]; description= "Thermal Shield Hardeners" } |> Some
      | 1789 -> { MarketGroupData.id= 1789; name= "Capital Scanning Rigs"; parentMarketGroupId= Some(1780); typeIds= [| 31205; 31320; 31242; 31211; 31248; 31217; 31314; 31224 |]; description= "Modifications that affect a capital starship's scanning." } |> Some
      | 1886 -> { MarketGroupData.id= 1886; name= "Gallente"; parentMarketGroupId= Some(1883); typeIds= [| 29083; 29061; 29069; 29041; 29091; 29081; 29051; 29085; 29087 |]; description= "" } |> Some
      | 1983 -> { MarketGroupData.id= 1983; name= "Minmatar"; parentMarketGroupId= Some(2377); typeIds= [| 46016; 36834; 46917; 34665; 48523; 55664; 52433; 36787; 45558; 47320; 40505; 52891; 45980; 56600 |]; description= "" } |> Some
      | 2080 -> { MarketGroupData.id= 2080; name= "Minmatar"; parentMarketGroupId= Some(2067); typeIds= [| 56898; 54436; 36774; 52872; 45961; 40491; 55695; 36432; 46898; 36821; 48726; 48508; 47166 |]; description= "" } |> Some
      | 2177 -> { MarketGroupData.id= 2177; name= "Reactor Control Units"; parentMarketGroupId= Some(2163); typeIds= [| 37060 |]; description= "" } |> Some
      | 2274 -> { MarketGroupData.id= 2274; name= "Gallente"; parentMarketGroupId= Some(2271); typeIds= [| 42133; 37607 |]; description= "Gallente force auxiliary designs." } |> Some
      | 2371 -> { MarketGroupData.id= 2371; name= "Amarr"; parentMarketGroupId= Some(2369); typeIds= [| 45784; 46793; 53626; 55330; 46022 |]; description= "" } |> Some
      | 2468 -> { MarketGroupData.id= 2468; name= "Small"; parentMarketGroupId= Some(2464); typeIds= [| 47926; 47927 |]; description= "Small Advanced Exotic Plasma Charges" } |> Some
      | 528 -> { MarketGroupData.id= 528; name= "Hemorphite"; parentMarketGroupId= Some(54); typeIds= [| 17444; 17445; 46697; 1231; 28403; 28404; 28405; 46681 |]; description= "Sub-types of hemorphite ore." } |> Some
      | 722 -> { MarketGroupData.id= 722; name= "Radar Backup Arrays"; parentMarketGroupId= Some(681); typeIds= [|  |]; description= "Reduces the sensors' vulnerability to Radar jamming." } |> Some
      | 819 -> { MarketGroupData.id= 819; name= "Caldari"; parentMarketGroupId= Some(817); typeIds= [| 23915; 23917 |]; description= "Caldari carrier designs." } |> Some
      | _ -> None