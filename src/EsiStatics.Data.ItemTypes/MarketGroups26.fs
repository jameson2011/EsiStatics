namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups26=
    let getMarketGroup id = 
      match id with 
      | 1093 -> { MarketGroupData.id= 1093; name= "Minmatar"; parentMarketGroupId= Some(1089); typeIds= [| 28846 |]; description= "Minmatar jump freighter designs." } |> Some
      | 1287 -> { MarketGroupData.id= 1287; name= "Standard XL Cruise Missiles"; parentMarketGroupId= Some(1316); typeIds= [| 32440; 32442; 32436; 32438 |]; description= "Standard XL cruise missile designs." } |> Some
      | 1384 -> { MarketGroupData.id= 1384; name= "Mining Barges"; parentMarketGroupId= Some(4); typeIds= [|  |]; description= "Ships specially designed to harvest resources in space" } |> Some
      | 1481 -> { MarketGroupData.id= 1481; name= "Implant Slot 07"; parentMarketGroupId= Some(1479); typeIds= [| 27105; 3080; 3081; 3084; 10228; 16246; 32255 |]; description= "Implant Slot 07" } |> Some
      | 1578 -> { MarketGroupData.id= 1578; name= "Electronics and Sensor Upgrades"; parentMarketGroupId= Some(209); typeIds= [|  |]; description= "Electronics and Sensor Upgrades" } |> Some
      | 1675 -> { MarketGroupData.id= 1675; name= "800mm Armor Plate"; parentMarketGroupId= Some(133); typeIds= [| 11299; 31916; 31918; 23793; 28786; 11317; 11319; 20351 |]; description= "800mm Armor Plate" } |> Some
      | 1772 -> { MarketGroupData.id= 1772; name= "Implant Slot 08"; parentMarketGroupId= Some(1763); typeIds= [| 27194; 27195; 27188 |]; description= "Implant Slot 08" } |> Some
      | 1869 -> { MarketGroupData.id= 1869; name= "Minmatar Improvement Platforms"; parentMarketGroupId= Some(1022); typeIds= [|  |]; description= "Improvements specifically designed for Minmatar outposts." } |> Some
      | 1966 -> { MarketGroupData.id= 1966; name= "Gallente"; parentMarketGroupId= Some(1962); typeIds= [| 46720; 44929; 44930; 44931; 52438; 49152; 45569; 52746; 46423; 52748; 45570; 53014; 46424; 47634; 53379; 49814; 46425; 53138; 54789; 49957; 34636; 46379; 52396; 47534; 36403; 53429; 37578; 37056; 34635; 42182; 42183; 42184; 34633; 34634; 37579; 37580; 34637; 34638; 34639; 34640; 47698; 46550; 45911; 45912; 45913; 46556; 47501; 46957; 46958; 46959; 34802; 52747; 48895 |]; description= "" } |> Some
      | 2063 -> { MarketGroupData.id= 2063; name= "Navy Faction"; parentMarketGroupId= Some(2029); typeIds= [| 45568; 36353; 48513; 49155; 48847; 46849; 36363; 47372; 45965; 45966; 46416; 52739; 45844; 45845; 45785; 42776; 42777; 49955; 53181; 46121; 36394; 47531; 48556; 52738; 52877; 36406; 46903; 42577; 48187; 48188; 47165; 46848; 52576; 46902; 52577; 52876; 46794; 46795; 52556; 45903; 42576; 36305; 48215; 36441; 45786; 46415; 45023; 45024; 45904; 36322; 46949; 46950; 36455; 47613; 48512; 53182; 44921; 44922; 53627; 53628; 46122 |]; description= "" } |> Some
      | 2160 -> { MarketGroupData.id= 2160; name= "Structure Resource Processing Rigs"; parentMarketGroupId= Some(2157); typeIds= [| 46501; 46503; 46505; 46506; 46508; 46510; 46512; 46514; 46643; 46516; 46645; 46518; 46647; 46649; 46651 |]; description= "Blueprints for structure reprocessing and reactions rigs." } |> Some
      | 2257 -> { MarketGroupData.id= 2257; name= "Extra Large"; parentMarketGroupId= Some(852); typeIds= [| 41336; 41334 |]; description= "For use with dreadnought-sized lasers and stationary defense systems." } |> Some
      | 2354 -> { MarketGroupData.id= 2354; name= "Gallente"; parentMarketGroupId= Some(2307); typeIds= [| 44888; 44173; 45870 |]; description= "" } |> Some
      | 2451 -> { MarketGroupData.id= 2451; name= "Medium Astronautic Mutaplasmids"; parentMarketGroupId= Some(2439); typeIds= [| 47297; 47750; 47751; 47752; 47741; 47742 |]; description= "Medium Astronautic Mutaplasmids" } |> Some
      | 353591 -> { MarketGroupData.id= 353591; name= "Propulsion"; parentMarketGroupId= Some(353580); typeIds= [|  |]; description= "" } |> Some
      | 354367 -> { MarketGroupData.id= 354367; name= "Prototype"; parentMarketGroupId= Some(353571); typeIds= [|  |]; description= "" } |> Some
      | 366201 -> { MarketGroupData.id= 366201; name= "Advanced"; parentMarketGroupId= Some(366173); typeIds= [|  |]; description= "" } |> Some
      | 368917 -> { MarketGroupData.id= 368917; name= "Shield Regulators"; parentMarketGroupId= Some(368916); typeIds= [|  |]; description= "" } |> Some
      | 414 -> { MarketGroupData.id= 414; name= "Shuttles"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of shuttle-class vessels." } |> Some
      | 608 -> { MarketGroupData.id= 608; name= "Large"; parentMarketGroupId= Some(551); typeIds= [| 3841; 8419; 28744; 8529; 20631; 31930; 31932; 3839 |]; description= "Battleship-class shield extension systems." } |> Some
      | 705 -> { MarketGroupData.id= 705; name= "Large"; parentMarketGroupId= Some(664); typeIds= [| 41218; 41219; 2020; 4871; 3504; 41220; 23805 |]; description= "Battleship-sized capacitor batteries." } |> Some
      | 802 -> { MarketGroupData.id= 802; name= "Amarr"; parentMarketGroupId= Some(65); typeIds= [| 11554; 11557; 11689; 11532; 11694; 11537; 11539; 11543; 11549 |]; description= "" } |> Some
      | 899 -> { MarketGroupData.id= 899; name= "Minmatar"; parentMarketGroupId= Some(881); typeIds= [| 22445; 22469 |]; description= "Blueprints of Minmatar command ship designs." } |> Some
      | 996 -> { MarketGroupData.id= 996; name= "Medium"; parentMarketGroupId= Some(994); typeIds= [| 20865; 20867; 20869; 20871; 20873; 20875; 20877; 20879; 21272; 21274; 21276; 21278; 21280; 21282; 21284; 21286; 20010; 20012; 20014; 20016; 23089; 23091; 23093; 23095; 23097; 23099; 23101; 23103; 21450; 20825; 21210; 20827; 21212; 20829; 21214; 20831; 21216; 21218; 21220; 21222 |]; description= "Medium faction issue frequenzy crystals, for use with cruiser-size lasers." } |> Some
      | _ -> None