namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups57=
    let getMarketGroup id = 
      match id with 
      | 1027 -> { MarketGroupData.id= 1027; name= "Outpost Upgrade Platforms"; parentMarketGroupId= Some(1021); typeIds= [|  |]; description= "Upgrade platforms for outposts, intended as a base for further improvements." } |> Some
      | 1124 -> { MarketGroupData.id= 1124; name= "Gallente Core Subsystems"; parentMarketGroupId= Some(1627); typeIds= [| 45628; 45629; 45630 |]; description= "Gallente core subsystems." } |> Some
      | 1221 -> { MarketGroupData.id= 1221; name= "Large Electronics Superiority Rigs"; parentMarketGroupId= Some(960); typeIds= [| 26112; 26352; 25928; 26096; 26344; 26354; 26356; 26366; 26360; 26106; 26108; 26110 |]; description= "Modifications that affect a large starship's electronic warfare capabilities." } |> Some
      | 1512 -> { MarketGroupData.id= 1512; name= "Implant Slot 08"; parentMarketGroupId= Some(1470); typeIds= [| 50053; 50066; 3277; 3278; 3279; 13234; 50067; 47262; 47263; 47261; 27230; 27231 |]; description= "Implant Slot 08" } |> Some
      | 1803 -> { MarketGroupData.id= 1803; name= "Large Scanning Rigs"; parentMarketGroupId= Some(1795); typeIds= [| 25937; 25931; 25933; 26105 |]; description= "Blueprints of Large Scanning Rigs." } |> Some
      | 1900 -> { MarketGroupData.id= 1900; name= "Guristas"; parentMarketGroupId= Some(1897); typeIds= [| 21728; 21587; 21588; 21589; 21590; 21591; 21724; 21725; 21726; 21727 |]; description= "Materials used in the construction of specific factional equipment." } |> Some
      | 1997 -> { MarketGroupData.id= 1997; name= "Minmatar"; parentMarketGroupId= Some(2035); typeIds= [| 35586; 44167; 44168; 48527; 53144; 34714; 34715; 36764; 36765; 53535; 40480; 40481; 52406; 53310; 36811; 36812; 56926; 56927; 55648; 48231; 57065; 52861; 53362; 55667; 52860; 45949; 45950 |]; description= "" } |> Some
      | 2094 -> { MarketGroupData.id= 2094; name= "Jump Freighters"; parentMarketGroupId= Some(1968); typeIds= [|  |]; description= "" } |> Some
      | 2191 -> { MarketGroupData.id= 2191; name= "Structure Anticapital Missiles"; parentMarketGroupId= Some(314); typeIds= [| 37852; 37853; 37854 |]; description= "" } |> Some
      | 2288 -> { MarketGroupData.id= 2288; name= "Faction Dreadnoughts"; parentMarketGroupId= Some(761); typeIds= [| 42243; 42124; 45647 |]; description= "Faction Dreadnought designs." } |> Some
      | 2482 -> { MarketGroupData.id= 2482; name= "Triglavian"; parentMarketGroupId= Some(2481); typeIds= [| 50145; 52323; 54916; 49928; 48651; 50156; 48655; 48565; 54907 |]; description= "Triglavian Battleships" } |> Some
      | 445 -> { MarketGroupData.id= 445; name= "Gallente"; parentMarketGroupId= Some(442); typeIds= [| 11990 |]; description= "Blueprints of Gallente logistics designs." } |> Some
      | 542 -> { MarketGroupData.id= 542; name= "Afterburners"; parentMarketGroupId= Some(52); typeIds= [| 18688; 18690; 18692; 14486; 15766; 18696; 15753; 18698; 15757; 14488; 14484; 41237; 14102; 41239; 14104; 41241; 14490; 14108; 12058; 14110; 15749; 14112; 12066; 12068; 18694; 14502; 14504; 14506; 18686; 438; 439; 5955; 35656; 35657; 14106; 21474; 12056; 41238; 14500; 21470; 21472; 21857; 18658; 18660; 18662; 15761; 18664; 18666; 18668; 18670; 18672; 6001; 18674; 6003; 18676; 6005; 18680; 41236; 18682; 18684; 15770; 41240 |]; description= "Provide additional thrust to the ship's engines." } |> Some
      | 639 -> { MarketGroupData.id= 639; name= "Rocket Launchers"; parentMarketGroupId= Some(140); typeIds= [| 16065; 16523; 22564; 10629; 21542; 10631; 16521; 13931; 13933; 16525; 17488; 20593; 34290; 16527; 28511 |]; description= "For the launching of swift-moving rocket projectiles." } |> Some
      | 736 -> { MarketGroupData.id= 736; name= "Minmatar Fleet"; parentMarketGroupId= Some(616); typeIds= [| 15664; 28231; 15625; 15626; 15627; 15628; 15629; 15630; 15631; 15632; 15666; 15662; 15661; 15660; 15674; 15663; 15997; 15998 |]; description= "Officially sanctioned Minmatar Fleet insignias." } |> Some
      | 833 -> { MarketGroupData.id= 833; name= "Gallente"; parentMarketGroupId= Some(824); typeIds= [| 11969; 11971 |]; description= "Gallente recon ship designs." } |> Some
      | 930 -> { MarketGroupData.id= 930; name= "Advanced Anti-Ship Rockets"; parentMarketGroupId= Some(118); typeIds= [| 24473; 2817; 24475; 24471 |]; description= "Advanced Anti-Ship Rockets" } |> Some
      | _ -> None