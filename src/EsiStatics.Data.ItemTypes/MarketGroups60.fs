namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups60=
    let getMarketGroup id = 
      match id with 
      | 1030 -> { MarketGroupData.id= 1030; name= "Logistic Drones"; parentMarketGroupId= Some(357); typeIds= [| 23712; 23524; 23718; 23720; 33705; 33707; 22766; 33672; 23710 |]; description= "Blueprints of logistics drone designs." } |> Some
      | 1127 -> { MarketGroupData.id= 1127; name= "Caldari Defensive Subsystems"; parentMarketGroupId= Some(1625); typeIds= [| 45589; 45590; 45591 |]; description= "Caldari defensive subsystems." } |> Some
      | 1224 -> { MarketGroupData.id= 1224; name= "Large Engineering Rigs"; parentMarketGroupId= Some(961); typeIds= [| 25952; 26368; 25954; 25956; 26374; 26376; 26348; 4397; 25934; 4401; 26372; 26370; 25948; 43898; 25950 |]; description= "Modifications that affect a large starship's energy grid." } |> Some
      | 1515 -> { MarketGroupData.id= 1515; name= "Implant Slot 07"; parentMarketGroupId= Some(1469); typeIds= [| 3470; 17871; 3414; 3415; 19548; 27071 |]; description= "Implant Slot 07" } |> Some
      | 157 -> { MarketGroupData.id= 157; name= "Drones"; parentMarketGroupId= None; typeIds= [|  |]; description= "Drones are semi-autonomous robotic devices used for military and industrial purposes throughout space" } |> Some
      | 1612 -> { MarketGroupData.id= 1612; name= "Special Edition Ships"; parentMarketGroupId= Some(4); typeIds= [|  |]; description= "Rare and visually distinct ships of interest to collectors" } |> Some
      | 1709 -> { MarketGroupData.id= 1709; name= "Scanning Upgrades"; parentMarketGroupId= Some(1708); typeIds= [| 33197; 33199; 33201; 33176; 33178; 33180 |]; description= "Modules that modify scanning" } |> Some
      | 1806 -> { MarketGroupData.id= 1806; name= "Medium Targeting Rigs"; parentMarketGroupId= Some(1796); typeIds= [| 31277; 31325 |]; description= "Blueprints of Medium Targeting Rigs." } |> Some
      | 1903 -> { MarketGroupData.id= 1903; name= "Talocan"; parentMarketGroupId= Some(1897); typeIds= [| 21088; 21089; 21074; 21075; 21076; 21077; 21078; 21079; 21080; 21081; 21082; 21084; 21085; 21086; 21087 |]; description= "Artifacts of the Talocan civilization." } |> Some
      | 2000 -> { MarketGroupData.id= 2000; name= "Navy Faction"; parentMarketGroupId= Some(1999); typeIds= [| 36352; 45826; 45827; 42760; 42761; 40330; 40331; 40332; 40333; 46103; 46104; 46783; 34718; 52767; 46888; 36393; 48170; 53163; 53164; 48499; 48169; 48500; 45885; 42558; 42559; 45767; 45768; 36304; 46937; 46938; 36443; 45021; 45022; 52859; 44903; 44904; 53609; 53610; 46837; 46397; 52720; 52721; 46398; 46836; 45886; 46889; 52858; 45947; 45948; 46782 |]; description= "" } |> Some
      | 2097 -> { MarketGroupData.id= 2097; name= "Gallente"; parentMarketGroupId= Some(2094); typeIds= [| 46442; 52765; 44948; 36405; 42199; 37595; 45930; 46975 |]; description= "" } |> Some
      | 2291 -> { MarketGroupData.id= 2291; name= "Armor Command Burst Charges"; parentMarketGroupId= Some(2290); typeIds= [| 42874; 42875; 42876 |]; description= "Armor Command Burst Charges" } |> Some
      | 2388 -> { MarketGroupData.id= 2388; name= "Caldari"; parentMarketGroupId= Some(2315); typeIds= [| 45810; 46827 |]; description= "Caldari Shuttle Skins" } |> Some
      | 2485 -> { MarketGroupData.id= 2485; name= "Triglavian"; parentMarketGroupId= Some(2483); typeIds= [| 53023; 52353; 52322; 52699; 49924; 49925; 49926; 54221; 52418; 53314; 48650; 50157; 48654; 49935; 53667; 48564; 49934; 52443; 50141; 50142; 50143 |]; description= "Triglavian Cruisers" } |> Some
      | 354692 -> { MarketGroupData.id= 354692; name= "Prototype"; parentMarketGroupId= Some(354686); typeIds= [|  |]; description= "" } |> Some
      | 355468 -> { MarketGroupData.id= 355468; name= "Equipment"; parentMarketGroupId= Some(355458); typeIds= [|  |]; description= "" } |> Some
      | 367593 -> { MarketGroupData.id= 367593; name= "Visual Customization"; parentMarketGroupId= Some(350001); typeIds= [|  |]; description= "" } |> Some
      | 448 -> { MarketGroupData.id= 448; name= "Heavy Assault Cruisers"; parentMarketGroupId= Some(1368); typeIds= [|  |]; description= "Sturdy and powerful cruisers built for all-out combat." } |> Some
      | 642 -> { MarketGroupData.id= 642; name= "Heavy Launchers"; parentMarketGroupId= Some(140); typeIds= [| 16064; 13921; 13922; 8101; 8103; 8105; 2410; 22567; 17487; 501; 20599; 7997 |]; description= "For the launching of heavy missiles." } |> Some
      | 739 -> { MarketGroupData.id= 739; name= "Criminal Dog Tags"; parentMarketGroupId= Some(19); typeIds= [|  |]; description= "Criminal organizations' identification tags. Can be traded to the empires" } |> Some
      | 836 -> { MarketGroupData.id= 836; name= "Minmatar"; parentMarketGroupId= Some(824); typeIds= [| 11961; 11963 |]; description= "Minmatar recon ship designs." } |> Some
      | 933 -> { MarketGroupData.id= 933; name= "Laboratory"; parentMarketGroupId= Some(1285); typeIds= [| 16216; 25305; 28351; 32245; 24567 |]; description= "Structures with research facilities." } |> Some
      | _ -> None