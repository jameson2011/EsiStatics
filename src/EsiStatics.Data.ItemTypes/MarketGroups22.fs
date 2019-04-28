namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups22=
    let getMarketGroup id = 
      match id with 
      | 1089 -> { MarketGroupData.id= 1089; name= "Jump Freighters"; parentMarketGroupId= Some(1381); typeIds= [|  |]; description= "Capital cargo ships with jump drive capabilities, bringing trade and commerce to distant stars." } |> Some
      | 1283 -> { MarketGroupData.id= 1283; name= "Industrial Upgrades"; parentMarketGroupId= Some(1276); typeIds= [| 2053; 2054; 2055; 2056; 2057; 2040; 2041; 2042; 2043; 2044 |]; description= "Industrial upgrades to sovereignty structures." } |> Some
      | 1380 -> { MarketGroupData.id= 1380; name= "Pirate Faction"; parentMarketGroupId= Some(1378); typeIds= [| 17920; 33472; 17736; 17738; 17740; 33820; 17918 |]; description= "Pirate faction battleship designs." } |> Some
      | 1477 -> { MarketGroupData.id= 1477; name= "Navigation Implants"; parentMarketGroupId= Some(531); typeIds= [|  |]; description= "Navigation Implants" } |> Some
      | 1574 -> { MarketGroupData.id= 1574; name= "Weapon Disruptors"; parentMarketGroupId= Some(1566); typeIds= [| 40338; 11614 |]; description= "Weapon Disruptors" } |> Some
      | 1768 -> { MarketGroupData.id= 1768; name= "Implant Slot 08"; parentMarketGroupId= Some(1762); typeIds= [| 27169; 27174; 27238; 27239; 27240; 27175 |]; description= "Implant Slot 08" } |> Some
      | 1865 -> { MarketGroupData.id= 1865; name= "Structure Components"; parentMarketGroupId= Some(1035); typeIds= [| 21953; 21955; 21957; 21959; 21961; 21963; 21965; 36957; 21967; 21969; 49720; 21947; 36956; 21949; 36958; 21951 |]; description= "Modular items used in the manufacture of Space Stations." } |> Some
      | 1962 -> { MarketGroupData.id= 1962; name= "Standard Battleships"; parentMarketGroupId= Some(1960); typeIds= [|  |]; description= "" } |> Some
      | 2059 -> { MarketGroupData.id= 2059; name= "Amarr"; parentMarketGroupId= Some(2046); typeIds= [| 36288; 46779; 45764; 42757; 42758; 43494; 43493; 47621; 48843; 45765; 37495; 37496; 42555; 42556; 46780; 36287 |]; description= "" } |> Some
      | 2156 -> { MarketGroupData.id= 2156; name= "Citadels"; parentMarketGroupId= Some(1338); typeIds= [| 36968; 36966; 36967 |]; description= "Blueprints of Citadel structures." } |> Some
      | 22 -> { MarketGroupData.id= 22; name= "Radioactive Goods"; parentMarketGroupId= Some(19); typeIds= [| 3729; 19398; 3727 |]; description= "Chemicals and waste, pulsing with radiation. Can be bought and sold for profit" } |> Some
      | 2253 -> { MarketGroupData.id= 2253; name= "Extra Large"; parentMarketGroupId= Some(847); typeIds= [| 41314; 41316 |]; description= "Fired by dreadnaught-sized guns and stationary defense systems." } |> Some
      | 2350 -> { MarketGroupData.id= 2350; name= "Special Edition Destroyers"; parentMarketGroupId= Some(1612); typeIds= [| 42685 |]; description= "Destroyers which have been offered to capsuleers on occasion for limited periods." } |> Some
      | 2447 -> { MarketGroupData.id= 2447; name= "Medium Shield Mutaplasmids"; parentMarketGroupId= Some(2438); typeIds= [| 47835; 47782; 47783; 47784; 47801; 47802; 47803 |]; description= "Medium Shield Mutaplasmids" } |> Some
      | 313 -> { MarketGroupData.id= 313; name= "Small"; parentMarketGroupId= Some(299); typeIds= [| 879; 880; 881; 882; 883; 884; 885; 886 |]; description= "Blueprints of small projectile ammunition." } |> Some
      | 353587 -> { MarketGroupData.id= 353587; name= "Shield"; parentMarketGroupId= Some(353580); typeIds= [|  |]; description= "" } |> Some
      | 353684 -> { MarketGroupData.id= 353684; name= "Weapons"; parentMarketGroupId= Some(353681); typeIds= [|  |]; description= "Hardwired neural augmentations used to train new abilities." } |> Some
      | 354460 -> { MarketGroupData.id= 354460; name= "Afterburners (Aerial)"; parentMarketGroupId= Some(353591); typeIds= [|  |]; description= "These speed boost modules only apply to aerial vehicles" } |> Some
      | 366197 -> { MarketGroupData.id= 366197; name= "Standard"; parentMarketGroupId= Some(366174); typeIds= [|  |]; description= "" } |> Some
      | 410 -> { MarketGroupData.id= 410; name= "Amarr"; parentMarketGroupId= Some(408); typeIds= [| 11185; 11187 |]; description= "Blueprints of Amarr interceptor designs." } |> Some
      | 604 -> { MarketGroupData.id= 604; name= "Micro"; parentMarketGroupId= Some(128); typeIds= [| 406 |]; description= "The smallest of the shield transporters, for when CPU and powergrid are scarce." } |> Some
      | 701 -> { MarketGroupData.id= 701; name= "Heavy"; parentMarketGroupId= Some(668); typeIds= [| 15136; 15138; 23811; 15140; 15142; 15132; 15130; 15778; 20559; 15128; 15134; 5047; 3576; 5049; 3578; 5051; 14172; 5053; 14174; 15786 |]; description= "Battleship-sized capacitor boosters." } |> Some
      | 798 -> { MarketGroupData.id= 798; name= "Outpost Components"; parentMarketGroupId= Some(800); typeIds= [|  |]; description= "Blueprints of Outpost Construction Platforms." } |> Some
      | 895 -> { MarketGroupData.id= 895; name= "Minmatar"; parentMarketGroupId= Some(880); typeIds= [| 22457 |]; description= "Blueprints of Minmatar interdictor designs." } |> Some
      | 992 -> { MarketGroupData.id= 992; name= "Medium"; parentMarketGroupId= Some(990); typeIds= [| 21400; 21402; 21404; 21406; 21408; 21410; 21412; 21414; 22987; 22989; 22977; 22979; 22981; 22983; 22985; 20043; 20045; 20047; 20049; 20051; 20053; 20055; 21336; 20057; 21338; 22991; 21340; 21342; 21344; 20961; 21346; 20963; 21348; 20965; 21350; 20967; 20969; 20971; 20973; 20975; 23025; 23027; 23029; 23031; 23033; 23035; 23037; 23039 |]; description= "Medium faction issue hybrid shells, fired by cruiser-sized guns." } |> Some
      | _ -> None