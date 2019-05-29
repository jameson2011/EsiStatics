namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups70=
    let getMarketGroup id = 
      match id with 
      | 1040 -> { MarketGroupData.id= 1040; name= "Strip Miners"; parentMarketGroupId= Some(1713); typeIds= [| 17912; 24305; 17482; 28754 |]; description= "Strip miner designs." } |> Some
      | 1137 -> { MarketGroupData.id= 1137; name= "Minmatar Propulsion Subsystems"; parentMarketGroupId= Some(1626); typeIds= [| 45619; 45620; 45621 |]; description= "Minmatar propulsion subsystems." } |> Some
      | 1234 -> { MarketGroupData.id= 1234; name= "Small Shield Rigs"; parentMarketGroupId= Some(965); typeIds= [| 31776; 31746; 31716; 31782; 31752; 31722; 31788; 31810; 31758; 31728; 31816; 31794; 31764; 31822; 31734; 31800; 31770; 31740 |]; description= "Modifications that affect a small starship's shields." } |> Some
      | 1525 -> { MarketGroupData.id= 1525; name= "Afterburners"; parentMarketGroupId= Some(252); typeIds= [| 12067; 1072; 12057; 41242; 41243; 41244 |]; description= "Blueprints of afterburners." } |> Some
      | 1719 -> { MarketGroupData.id= 1719; name= "Capital Armor Rigs"; parentMarketGroupId= Some(944); typeIds= [| 31076; 31014; 31026; 33903; 30994; 27065; 31002; 31068; 31038 |]; description= "Blueprints of Capital Armor Rigs." } |> Some
      | 1816 -> { MarketGroupData.id= 1816; name= "Amarr"; parentMarketGroupId= Some(1815); typeIds= [| 596 |]; description= "Amarr rookie ship designs." } |> Some
      | 1913 -> { MarketGroupData.id= 1913; name= "Structure Components"; parentMarketGroupId= Some(800); typeIds= [| 21952; 21954; 21956; 21958; 21960; 21962; 21964; 21966; 21968; 21970; 49721; 36953; 36954; 36955; 21948; 21950 |]; description= "" } |> Some
      | 2010 -> { MarketGroupData.id= 2010; name= "Minmatar"; parentMarketGroupId= Some(2085); typeIds= [| 45984; 45985; 45986; 34757; 36838; 36839; 36840; 46921; 46922; 46923; 36791; 36792; 36793; 46747; 40509; 40510; 40511 |]; description= "" } |> Some
      | 2107 -> { MarketGroupData.id= 2107; name= "Minmatar"; parentMarketGroupId= Some(2102); typeIds= [| 36448; 47169; 45970; 49958; 46908; 46907; 36780; 36781; 52431; 52304; 40498; 40499; 48819; 45971; 36827; 36828; 36446 |]; description= "" } |> Some
      | 2204 -> { MarketGroupData.id= 2204; name= "Structure Resource Processing Rigs"; parentMarketGroupId= Some(2203); typeIds= [|  |]; description= "Structure Reprocessing and Reaction Rigs" } |> Some
      | 2301 -> { MarketGroupData.id= 2301; name= "Shield Command Burst Charges"; parentMarketGroupId= Some(2297); typeIds= [| 42696; 42694; 42695 |]; description= "Shield Command Burst Charges" } |> Some
      | 2398 -> { MarketGroupData.id= 2398; name= "Uncommon Moon Ores"; parentMarketGroupId= Some(2395); typeIds= [| 46299; 46298; 46300; 46301; 46296; 46297; 45498; 45499; 45500; 45501; 46302; 46303 |]; description= "" } |> Some
      | 2495 -> { MarketGroupData.id= 2495; name= "Antipharmakon"; parentMarketGroupId= Some(2488); typeIds= [| 36912; 36908; 36909 |]; description= "Antipharmakon Boosters" } |> Some
      | 264 -> { MarketGroupData.id= 264; name= "Minmatar"; parentMarketGroupId= Some(205); typeIds= [| 945; 946; 689; 690; 691; 3767 |]; description= "Blueprints of Minmatar frigate designs." } |> Some
      | 354411 -> { MarketGroupData.id= 354411; name= "Advanced"; parentMarketGroupId= Some(353574); typeIds= [|  |]; description= "" } |> Some
      | 355187 -> { MarketGroupData.id= 355187; name= "Standard"; parentMarketGroupId= Some(355181); typeIds= [|  |]; description= "" } |> Some
      | 364887 -> { MarketGroupData.id= 364887; name= "Advanced"; parentMarketGroupId= Some(364885); typeIds= [|  |]; description= "Advanced light frame dropsuits." } |> Some
      | 458 -> { MarketGroupData.id= 458; name= "Assault Frigates"; parentMarketGroupId= Some(204); typeIds= [|  |]; description= "Blueprints of assault-class vessels." } |> Some
      | 555 -> { MarketGroupData.id= 555; name= "Railguns"; parentMarketGroupId= Some(86); typeIds= [|  |]; description= "Railguns use magnetic rails to fire solid chunks of matter at hypersonic speed." } |> Some
      | 749 -> { MarketGroupData.id= 749; name= "True Sansha"; parentMarketGroupId= Some(739); typeIds= [| 17252; 17253; 17254; 17255; 17256; 17257; 17258; 17259; 17260; 17261 |]; description= "True Sansha identification tags." } |> Some
      | 846 -> { MarketGroupData.id= 846; name= "Advanced Artillery Ammo"; parentMarketGroupId= Some(99); typeIds= [|  |]; description= "Ultra-heavy shells incorporating cutting-edge technology." } |> Some
      | 943 -> { MarketGroupData.id= 943; name= "Ship Modifications"; parentMarketGroupId= Some(2); typeIds= [|  |]; description= "Blueprints of rigs used to modify ship performance" } |> Some
      | _ -> None