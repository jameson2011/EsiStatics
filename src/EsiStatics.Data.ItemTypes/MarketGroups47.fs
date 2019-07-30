namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups47=
    let getMarketGroup id = 
      match id with 
      | 1211 -> { MarketGroupData.id= 1211; name= "Medium Astronautic Rigs"; parentMarketGroupId= Some(957); typeIds= [| 31137; 31107; 31173; 31143; 31113; 31179; 31149; 31119; 31185; 31155; 31125; 31191; 31161; 31131; 34268; 31197; 31167 |]; description= "Modifications that affect a medium starship's astronautics." } |> Some
      | 1405 -> { MarketGroupData.id= 1405; name= "Outerwear"; parentMarketGroupId= Some(1402); typeIds= [| 4136; 4137; 4138; 4139; 4140; 4141; 34350; 4143; 4144; 4145; 4146; 4149; 4150; 4151; 4152; 4153; 4154; 46658; 46660; 46661; 46663; 40523; 46668; 46669; 46671; 46673; 34394; 45735; 45737; 45738; 47287; 45514; 46273; 45515; 33740; 33741; 42706; 45518; 42703; 37600; 37601; 48380; 48381; 48382; 48386; 4142; 34351; 34353; 34091; 34094; 34097; 34099; 34100; 49980; 45519; 47475; 34169; 34170; 34171; 34172; 34173; 34174; 34175; 34176; 34177; 34178; 34179; 34180; 34181; 3975; 33715; 47031; 37816; 33726; 33727; 33728; 33729; 33730; 33731; 33732; 33733; 33734; 33735; 33736; 33737; 33738; 33739; 45516; 45517; 33742; 33743; 45520; 48081; 4054; 46039; 37863 |]; description= "Clothing worn on the outside of other clothing." } |> Some
      | 1502 -> { MarketGroupData.id= 1502; name= "Implant Slot 10"; parentMarketGroupId= Some(1473); typeIds= [| 3205; 3210; 25867; 3215; 3222; 3223; 3224; 3228; 3229; 3230; 13217; 13218; 13219; 13252; 27080; 27088; 27089; 27090; 19688; 19694; 19698; 16249; 3196; 3197; 3198 |]; description= "Implant Slot 10" } |> Some
      | 1599 -> { MarketGroupData.id= 1599; name= "Orbital Strike"; parentMarketGroupId= Some(101); typeIds= [|  |]; description= "" } |> Some
      | 1696 -> { MarketGroupData.id= 1696; name= "Adaptive Shield Hardeners"; parentMarketGroupId= Some(553); typeIds= [| 9632; 578; 46010; 2281; 14764; 2050; 13998; 14765; 20637; 13969; 17498; 14766; 14767; 4345; 4346; 4347; 4348; 4349 |]; description= "Adaptive Shield Hardeners" } |> Some
      | 1793 -> { MarketGroupData.id= 1793; name= "Capital Targeting Rigs"; parentMarketGroupId= Some(1781); typeIds= [| 31332; 31284; 31326; 31278 |]; description= "Modifications that affect a capital starship's targeting." } |> Some
      | 1987 -> { MarketGroupData.id= 1987; name= "Minmatar"; parentMarketGroupId= Some(1972); typeIds= [| 40514; 45989; 36444; 36843; 46926; 34671; 36796 |]; description= "" } |> Some
      | 2084 -> { MarketGroupData.id= 2084; name= "Minmatar"; parentMarketGroupId= Some(2068); typeIds= [| 36775; 36776; 45962; 45963; 40492; 40493; 36430; 36431; 46899; 46900; 36822; 36823; 48509; 48510 |]; description= "" } |> Some
      | 2181 -> { MarketGroupData.id= 2181; name= "Citadel Service Modules"; parentMarketGroupId= Some(2166); typeIds= [| 37022; 37023 |]; description= "" } |> Some
      | 2278 -> { MarketGroupData.id= 2278; name= "Amarr"; parentMarketGroupId= Some(2277); typeIds= [| 49825; 46146; 47049; 52588; 49421; 41680; 47640; 48858; 42908; 42653 |]; description= "" } |> Some
      | 2375 -> { MarketGroupData.id= 2375; name= "Faction Carriers"; parentMarketGroupId= Some(1970); typeIds= [|  |]; description= "" } |> Some
      | 338 -> { MarketGroupData.id= 338; name= "Mining Lasers"; parentMarketGroupId= Some(1711); typeIds= [| 38660; 17483; 12109; 785; 25267; 16279 |]; description= "Blueprints of mining lasers." } |> Some
      | 354388 -> { MarketGroupData.id= 354388; name= "Standard"; parentMarketGroupId= Some(353600); typeIds= [|  |]; description= "" } |> Some
      | 366222 -> { MarketGroupData.id= 366222; name= "Standard"; parentMarketGroupId= Some(366178); typeIds= [|  |]; description= "" } |> Some
      | 435 -> { MarketGroupData.id= 435; name= "Gallente"; parentMarketGroupId= Some(432); typeIds= [| 12042; 12044 |]; description= "Gallente assault frigate designs." } |> Some
      | 532 -> { MarketGroupData.id= 532; name= "Attribute Enhancers"; parentMarketGroupId= Some(27); typeIds= [|  |]; description= "Implants designed to augment specific aspects of the pilot's mental make-up." } |> Some
      | 629 -> { MarketGroupData.id= 629; name= "Transport Ships"; parentMarketGroupId= Some(1385); typeIds= [|  |]; description= "Advanced technologies for the transportation of valuable materials." } |> Some
      | 726 -> { MarketGroupData.id= 726; name= "Ladar Sensors"; parentMarketGroupId= Some(685); typeIds= [|  |]; description= "Boost a ship's Ladar sensor strength for a short duration." } |> Some
      | 823 -> { MarketGroupData.id= 823; name= "Interdictors"; parentMarketGroupId= Some(1373); typeIds= [|  |]; description= "Destroyer-class vessels designed to pull other starships out of warp." } |> Some
      | 920 -> { MarketGroupData.id= 920; name= "Standard Light Missiles"; parentMarketGroupId= Some(117); typeIds= [| 210; 211; 212; 213 |]; description= "Standard Light Missiles" } |> Some
      | _ -> None