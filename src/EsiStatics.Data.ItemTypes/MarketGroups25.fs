namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups25=
    let getMarketGroup id = 
      match id with 
      | 1092 -> { MarketGroupData.id= 1092; name= "Gallente"; parentMarketGroupId= Some(1089); typeIds= [| 28848 |]; description= "Gallente jump freighter designs." } |> Some
      | 1286 -> { MarketGroupData.id= 1286; name= "XL Cruise Missiles"; parentMarketGroupId= Some(314); typeIds= [| 32441; 32443; 32437; 32439 |]; description= "Blueprints of XL Cruise Missiles." } |> Some
      | 1480 -> { MarketGroupData.id= 1480; name= "Implant Slot 06"; parentMarketGroupId= Some(1479); typeIds= [| 27104; 13253; 3078; 3079; 16245; 3077 |]; description= "Implant Slot 06" } |> Some
      | 1577 -> { MarketGroupData.id= 1577; name= "Projected ECCM"; parentMarketGroupId= Some(1566); typeIds= [|  |]; description= "Projected ECCM" } |> Some
      | 1674 -> { MarketGroupData.id= 1674; name= "400mm Armor Plate"; parentMarketGroupId= Some(133); typeIds= [| 11297; 31908; 31910; 23789; 11309; 28784; 11311; 20349 |]; description= "400mm Armor Plate" } |> Some
      | 1771 -> { MarketGroupData.id= 1771; name= "Implant Slot 07"; parentMarketGroupId= Some(1763); typeIds= [| 27192; 27193; 27187 |]; description= "Implant Slot 07" } |> Some
      | 1868 -> { MarketGroupData.id= 1868; name= "Gallente Improvement Platforms"; parentMarketGroupId= Some(1022); typeIds= [|  |]; description= "Improvements specifically designed for Gallentean outposts." } |> Some
      | 1965 -> { MarketGroupData.id= 1965; name= "Caldari"; parentMarketGroupId= Some(1962); typeIds= [| 36736; 36737; 36738; 47617; 46856; 46857; 46858; 46732; 53134; 53189; 45852; 45853; 45854; 40773; 56864; 56865; 40612; 40613; 40614; 46376; 53191; 52400; 46129; 46130; 46131; 56887; 36664; 36665; 36666; 57019; 47498; 52286; 48195; 48196; 34629; 34630; 34631; 34632; 41419; 53190; 53374; 47313; 45012; 48731; 48732; 57055; 55521; 55522; 55523; 34797; 54768; 48894; 46715; 48197 |]; description= "" } |> Some
      | 2062 -> { MarketGroupData.id= 2062; name= "Minmatar"; parentMarketGroupId= Some(2046); typeIds= [| 55685; 55692; 47635; 36762; 36763; 40478; 40479; 46885; 46886; 57009; 36809; 36426; 56894; 36425; 36810; 56908; 45944; 48496; 48497; 52855; 52856; 45945 |]; description= "" } |> Some
      | 2159 -> { MarketGroupData.id= 2159; name= "Structure Combat Rigs"; parentMarketGroupId= Some(2157); typeIds= [| 37378; 37435; 37380; 37413; 37382; 37415; 37384; 37417; 37386; 37419; 37388; 37410; 37390; 37421; 37392; 37394; 37396; 37431; 37433; 37423; 37437 |]; description= "Blueprints for Structure Combat rigs." } |> Some
      | 2256 -> { MarketGroupData.id= 2256; name= "Extra Large"; parentMarketGroupId= Some(853); typeIds= [| 41330; 41332 |]; description= "For use with dreadnought-sized lasers and stationary defense systems." } |> Some
      | 2353 -> { MarketGroupData.id= 2353; name= "Caldari"; parentMarketGroupId= Some(2307); typeIds= [| 44147; 55533; 45811 |]; description= "" } |> Some
      | 2450 -> { MarketGroupData.id= 2450; name= "Small Astronautic Mutaplasmids"; parentMarketGroupId= Some(2439); typeIds= [| 47746; 47747; 47748; 47737; 47738; 47739 |]; description= "Small Atronautic Mutaplasmids" } |> Some
      | 2741 -> { MarketGroupData.id= 2741; name= "Vorton Projectors"; parentMarketGroupId= Some(10); typeIds= [|  |]; description= "Vorton Projectors made by Upwell" } |> Some
      | 316 -> { MarketGroupData.id= 316; name= "Defender"; parentMarketGroupId= Some(314); typeIds= [| 32783 |]; description= "Blueprints of defender missiles." } |> Some
      | 413 -> { MarketGroupData.id= 413; name= "Minmatar"; parentMarketGroupId= Some(408); typeIds= [| 11197; 11199 |]; description= "Blueprints of Minmatar interceptor designs." } |> Some
      | 704 -> { MarketGroupData.id= 704; name= "Medium"; parentMarketGroupId= Some(664); typeIds= [| 41216; 41217; 2018; 3496; 6073; 23803; 41215 |]; description= "Cruiser-sized capacitor batteries." } |> Some
      | 801 -> { MarketGroupData.id= 801; name= "Siege Modules"; parentMarketGroupId= Some(143); typeIds= [| 4292; 4294; 28583; 42890; 27951; 33400; 20280 |]; description= "Modules designed to augment and enhance a capital ship's siege warfare abilities." } |> Some
      | 898 -> { MarketGroupData.id= 898; name= "Gallente"; parentMarketGroupId= Some(881); typeIds= [| 22443; 22467 |]; description= "Blueprints of Gallente command ship designs." } |> Some
      | 995 -> { MarketGroupData.id= 995; name= "Large"; parentMarketGroupId= Some(994); typeIds= [| 20881; 20883; 20885; 20887; 20889; 20891; 20893; 20895; 21288; 21290; 21292; 21298; 21294; 21296; 20018; 20020; 20022; 20024; 21300; 23109; 23105; 23107; 21302; 23111; 23113; 23115; 23117; 23119; 20833; 20835; 20837; 20839; 21224; 21226; 21228; 21230; 21232; 21234; 21236; 21238 |]; description= "Large faction issue frequenzy crystals, for use with battleship-size lasers." } |> Some
      | _ -> None