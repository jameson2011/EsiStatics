namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups38=
    let getMarketGroup id = 
      match id with 
      | 1008 -> { MarketGroupData.id= 1008; name= "Cargo Containers"; parentMarketGroupId= Some(406); typeIds= [| 32864; 32865; 32866; 32867; 32868; 32869; 32870; 32871; 33004; 27309; 33006; 33008; 33010; 33012; 32858; 32859; 32860; 32861; 32862; 32863 |]; description= "Blueprints of Cargo Containers." } |> Some
      | 1105 -> { MarketGroupData.id= 1105; name= "Scripts"; parentMarketGroupId= Some(211); typeIds= [| 41230; 40336; 40337; 35796; 37834; 29000; 37833; 29002; 37835; 37836; 29006; 29008; 41592; 29010; 45011; 29012; 35797; 29014; 29016; 47337; 41590; 41591; 29004; 41593; 41594; 41595; 41596; 41597 |]; description= "Blueprints of scripts." } |> Some
      | 1202 -> { MarketGroupData.id= 1202; name= "Large Armor Rigs"; parentMarketGroupId= Some(944); typeIds= [| 25889; 25891; 25893; 25895; 25897; 25899; 25901; 33899; 25737 |]; description= "Blueprints of Large Armor Rigs." } |> Some
      | 135 -> { MarketGroupData.id= 135; name= "Hull Upgrades"; parentMarketGroupId= Some(14); typeIds= [|  |]; description= "Hull modifications with various applications." } |> Some
      | 1396 -> { MarketGroupData.id= 1396; name= "Apparel"; parentMarketGroupId= None; typeIds= [|  |]; description= "Capsuleers can choose from a variety of exclusive clothing and accessories" } |> Some
      | 1493 -> { MarketGroupData.id= 1493; name= "Implant Slot 06"; parentMarketGroupId= Some(1476); typeIds= [| 24641; 24642; 27259; 13231; 27257; 3144; 3145; 13226; 3148; 3149; 3150; 3151; 3176; 27091; 3182; 3177; 27256; 3180; 27258; 3183; 3181 |]; description= "Implant Slot 06" } |> Some
      | 1590 -> { MarketGroupData.id= 1590; name= "Minmatar"; parentMarketGroupId= Some(1097); typeIds= [| 29090; 29046; 29066; 29106; 29076; 29078; 29080; 29044; 29050 |]; description= "Minmatar" } |> Some
      | 1687 -> { MarketGroupData.id= 1687; name= "Energized Armor Layering"; parentMarketGroupId= Some(14); typeIds= [| 16417; 11235; 16421; 11239; 16423; 16419; 11237 |]; description= "Energized Armor Layering" } |> Some
      | 1784 -> { MarketGroupData.id= 1784; name= "Large Resource Processing Rigs"; parentMarketGroupId= Some(1779); typeIds= [| 26300; 25902 |]; description= "Modifications that affect a large starship's resource processing." } |> Some
      | 1978 -> { MarketGroupData.id= 1978; name= "Amarr"; parentMarketGroupId= Some(2381); typeIds= [| 43523; 50071; 53645; 55313; 37523; 47639; 49432; 49824; 42794; 52781; 53422; 36293; 46540; 46812; 42594; 53009; 45803; 48367; 34672; 34673; 46711; 55722 |]; description= "" } |> Some
      | 2075 -> { MarketGroupData.id= 2075; name= "Gallente"; parentMarketGroupId= Some(2066); typeIds= [| 46944; 37569; 36386; 46410; 52733; 55633; 44916; 42172; 45898 |]; description= "" } |> Some
      | 2172 -> { MarketGroupData.id= 2172; name= "Warp Scramblers"; parentMarketGroupId= Some(2161); typeIds= [| 37087 |]; description= "" } |> Some
      | 2269 -> { MarketGroupData.id= 2269; name= "Gallente"; parentMarketGroupId= Some(912); typeIds= [| 41440; 24554; 41443; 43662 |]; description= "" } |> Some
      | 2463 -> { MarketGroupData.id= 2463; name= "Standard Exotic Plasma Charges"; parentMarketGroupId= Some(2462); typeIds= [|  |]; description= "Standard Exotic Plasma Charges" } |> Some
      | 523 -> { MarketGroupData.id= 523; name= "Kernite"; parentMarketGroupId= Some(54); typeIds= [| 46683; 46699; 17452; 17453; 20; 28409; 28410; 28411 |]; description= "Sub-types of kernite ore." } |> Some
      | 620 -> { MarketGroupData.id= 620; name= "Implant Slot 03"; parentMarketGroupId= Some(532); typeIds= [| 28800; 33921; 53892; 31958; 28806; 33927; 53898; 28812; 33933; 33808; 28818; 33939; 54406; 53904; 33945; 20506; 20507; 42202; 33951; 33563; 33957; 33393; 54400; 33963; 33969; 52787; 42206; 33975; 52921; 53855; 22715; 20158; 52680; 53708; 19536; 33528; 53715; 9942; 14296; 31972; 22111; 54394; 31966; 22117; 19553; 10212; 10213; 32105; 31978; 22123; 32111; 22129; 32116; 42212; 22136; 32121; 28794; 13285 |]; description= "Implants intended for Subcervical Processing Slot 3." } |> Some
      | 717 -> { MarketGroupData.id= 717; name= "Gravimetric Jammers"; parentMarketGroupId= Some(677); typeIds= [| 20577; 1955; 19942; 19944; 19946; 2571; 28735 |]; description= "Targeting jammers specialized for use against gravimetric sensors." } |> Some
      | 814 -> { MarketGroupData.id= 814; name= "Caldari"; parentMarketGroupId= Some(812); typeIds= [| 3764 |]; description= "Caldari titan designs." } |> Some
      | 911 -> { MarketGroupData.id= 911; name= "Sentry Drones"; parentMarketGroupId= Some(159); typeIds= [| 23525; 31878; 23559; 23561; 23563; 31886; 28209; 28211; 28213; 31894; 28215; 31868 |]; description= "Deployable watchdogs." } |> Some
      | _ -> None