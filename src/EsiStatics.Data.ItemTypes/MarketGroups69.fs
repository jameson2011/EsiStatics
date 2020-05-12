namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups69=
    let getMarketGroup id = 
      match id with 
      | 1039 -> { MarketGroupData.id= 1039; name= "Mining Lasers"; parentMarketGroupId= Some(1713); typeIds= [| 482; 483; 21841; 28748; 12108; 28750; 5233; 3651; 18068; 5239; 5245 |]; description= "Mining laser designs." } |> Some
      | 1136 -> { MarketGroupData.id= 1136; name= "Gallente Propulsion Subsystems"; parentMarketGroupId= Some(1627); typeIds= [| 45616; 45617; 45618 |]; description= "Gallente propulsion subsystems." } |> Some
      | 1233 -> { MarketGroupData.id= 1233; name= "Large Missile Launcher Rigs"; parentMarketGroupId= Some(964); typeIds= [| 26016; 26020; 26406; 26022; 26412; 26026; 26028; 26030; 26416; 26418; 26420; 26414 |]; description= "Modifications that affect a large starship's missile launchers." } |> Some
      | 1427 -> { MarketGroupData.id= 1427; name= "Aurum Tokens"; parentMarketGroupId= Some(19); typeIds= [| 32792; 2833; 44204; 32793 |]; description= "An Aurum Token is a physical chit that can be redeemed for a predefined amount of AUR currency" } |> Some
      | 1621 -> { MarketGroupData.id= 1621; name= "Special Edition Heavy Assault Cruisers"; parentMarketGroupId= Some(1612); typeIds= [| 32209; 2836; 3518 |]; description= "Heavy Assault Cruisers which have been offered to capsuleers on occasion for limited periods." } |> Some
      | 1718 -> { MarketGroupData.id= 1718; name= "Analyzers"; parentMarketGroupId= Some(1708); typeIds= [| 22177; 3581; 30832; 30834; 49791; 41533; 41534; 22175 |]; description= "Modules that analyze old or recent computer systems in exploration sites." } |> Some
      | 1815 -> { MarketGroupData.id= 1815; name= "Corvettes"; parentMarketGroupId= Some(4); typeIds= [|  |]; description= "Small entry-level and expendable ships" } |> Some
      | 1912 -> { MarketGroupData.id= 1912; name= "Construction Platforms"; parentMarketGroupId= Some(798); typeIds= [|  |]; description= "" } |> Some
      | 2009 -> { MarketGroupData.id= 2009; name= "Gallente"; parentMarketGroupId= Some(2085); typeIds= [| 45575; 45576; 45577; 45578; 44940; 44941; 44942; 44943; 44944; 52757; 52758; 52759; 52760; 52761; 46750; 46438; 34755; 34756; 46435; 46434; 42191; 42192; 42193; 42194; 42195; 37588; 37589; 37590; 37591; 46436; 46437; 48656; 45922; 45923; 45924; 45925; 45926; 37587; 46968; 46969; 46970; 46971; 46972 |]; description= "" } |> Some
      | 2106 -> { MarketGroupData.id= 2106; name= "Gallente"; parentMarketGroupId= Some(2102); typeIds= [| 42180; 42181; 46421; 52743; 37576; 37577; 46954; 46955; 36398; 36400; 52744; 45908; 45909; 46420; 44926; 44927 |]; description= "" } |> Some
      | 2203 -> { MarketGroupData.id= 2203; name= "Structure Modifications"; parentMarketGroupId= None; typeIds= [|  |]; description= "Rigs that improve functionality in Structures" } |> Some
      | 2300 -> { MarketGroupData.id= 2300; name= "Mining Foreman Burst Charges"; parentMarketGroupId= Some(2297); typeIds= [| 42829; 42830; 42831 |]; description= "Mining Foreman Burst Charges" } |> Some
      | 2397 -> { MarketGroupData.id= 2397; name= "Common Moon Ores"; parentMarketGroupId= Some(2395); typeIds= [| 46294; 46295; 46288; 46289; 46290; 46291; 46292; 46293; 45494; 45495; 45496; 45497 |]; description= "" } |> Some
      | 2494 -> { MarketGroupData.id= 2494; name= "X-Instinct"; parentMarketGroupId= Some(2488); typeIds= [| 15457; 15458; 15459; 28682 |]; description= "X-Instinct Boosters" } |> Some
      | 354410 -> { MarketGroupData.id= 354410; name= "Standard"; parentMarketGroupId= Some(353574); typeIds= [|  |]; description= "" } |> Some
      | 364886 -> { MarketGroupData.id= 364886; name= "Standard"; parentMarketGroupId= Some(364885); typeIds= [|  |]; description= "Standard light frames." } |> Some
      | 365274 -> { MarketGroupData.id= 365274; name= "Standard"; parentMarketGroupId= Some(365272); typeIds= [|  |]; description= "Standard pilot dropsuits." } |> Some
      | 457 -> { MarketGroupData.id= 457; name= "Minmatar"; parentMarketGroupId= Some(453); typeIds= [| 12000; 12016 |]; description= "Blueprints of Minmatar heavy assault cruiser designs." } |> Some
      | 554 -> { MarketGroupData.id= 554; name= "Shield"; parentMarketGroupId= Some(9); typeIds= [|  |]; description= "Modules that strengthen the energy barrier surrounding spaceships against external dangers" } |> Some
      | 748 -> { MarketGroupData.id= 748; name= "Shadow Serpentis"; parentMarketGroupId= Some(739); typeIds= [| 17262; 17263; 17264; 17266; 17267; 17268; 17269; 17270; 17271; 17272 |]; description= "Shadow Serpentis identification tags." } |> Some
      | 845 -> { MarketGroupData.id= 845; name= "Standard Ammo"; parentMarketGroupId= Some(99); typeIds= [|  |]; description= "Standard projectile rounds." } |> Some
      | _ -> None