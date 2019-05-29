namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups37=
    let getMarketGroup id = 
      match id with 
      | 1007 -> { MarketGroupData.id= 1007; name= "Extra Large"; parentMarketGroupId= Some(994); typeIds= [| 21248; 21312; 21250; 21252; 21254; 20897; 20899; 20901; 20903; 20905; 20907; 20909; 20911; 21304; 20026; 20028; 20030; 20032; 21314; 21316; 21318; 21308; 21306; 20841; 20843; 20845; 20847; 21310; 21240; 21242; 21244; 21246 |]; description= "Faction issue frequenzy crystals for use with dreadnought-sized lasers and stationary defense systems." } |> Some
      | 1201 -> { MarketGroupData.id= 1201; name= "Interdiction Probes"; parentMarketGroupId= Some(120); typeIds= [| 22778; 34260; 41402 |]; description= "Interdiction probe designs." } |> Some
      | 134 -> { MarketGroupData.id= 134; name= "Armor Repairers"; parentMarketGroupId= Some(14); typeIds= [|  |]; description= "Nano-assembler technology at its best. Repair armor on the fly." } |> Some
      | 1492 -> { MarketGroupData.id= 1492; name= "Implant Slot 09"; parentMarketGroupId= Some(1477); typeIds= [| 16006; 3112; 3113; 3116; 13243; 27100 |]; description= "Implant Slot 09" } |> Some
      | 1589 -> { MarketGroupData.id= 1589; name= "Gallente"; parentMarketGroupId= Some(1097); typeIds= [| 29088; 29092; 29062; 29052; 29070; 29042; 29082; 29084; 29086 |]; description= "Gallente" } |> Some
      | 1686 -> { MarketGroupData.id= 1686; name= "Energized Adaptive Plating"; parentMarketGroupId= Some(541); typeIds= [| 17536; 11265; 11267; 11269; 16385; 18829; 18831; 16387; 16389; 18849; 18851; 16391; 18819; 22879; 46012; 18881; 18883; 28534; 14936; 15204; 14938; 14940; 14942; 15455; 14944; 14946; 14948; 15206; 14950; 15208; 15210; 18799; 15729; 14070; 14072; 18809; 14074; 15739 |]; description= "Energized Adaptive Plating" } |> Some
      | 1783 -> { MarketGroupData.id= 1783; name= "Medium Resource Processing Rigs"; parentMarketGroupId= Some(1779); typeIds= [| 32817; 31091; 31085; 32819 |]; description= "Modifications that affect a medium starship's resource processing." } |> Some
      | 1880 -> { MarketGroupData.id= 1880; name= "Datacores"; parentMarketGroupId= Some(1872); typeIds= [| 20114; 20115; 25887; 20410; 20411; 20412; 20413; 20414; 20415; 20416; 20417; 20418; 20419; 20420; 20421; 20423; 20424; 20425; 20171; 20172; 52309; 11496 |]; description= "Research Data" } |> Some
      | 1977 -> { MarketGroupData.id= 1977; name= "Minmatar"; parentMarketGroupId= Some(2374); typeIds= [| 46726; 48524; 48525; 47508; 49430; 45981; 45982; 46919; 36788; 36789; 40506; 40507; 47292; 46014; 46015; 46918; 36449; 47177; 47179; 52434; 36835; 47321; 34657; 34658; 36451; 36836; 45555; 45556 |]; description= "" } |> Some
      | 2074 -> { MarketGroupData.id= 2074; name= "Caldari"; parentMarketGroupId= Some(2066); typeIds= [| 36655; 46843; 46116; 45839; 48182; 36727; 36345; 40603 |]; description= "" } |> Some
      | 2171 -> { MarketGroupData.id= 2171; name= "Weapon Disruptors"; parentMarketGroupId= Some(2161); typeIds= [| 37083 |]; description= "Weapon Disruptors" } |> Some
      | 2268 -> { MarketGroupData.id= 2268; name= "Caldari"; parentMarketGroupId= Some(912); typeIds= [| 24552; 41442; 43660; 41439 |]; description= "" } |> Some
      | 2462 -> { MarketGroupData.id= 2462; name= "Exotic Plasma Charges"; parentMarketGroupId= Some(11); typeIds= [|  |]; description= "Exotic Plasma Charges are used in Entropic Disintegrators" } |> Some
      | 353602 -> { MarketGroupData.id= 353602; name= "Logistics"; parentMarketGroupId= Some(364045); typeIds= [|  |]; description= "Logistics dropsuits." } |> Some
      | 354378 -> { MarketGroupData.id= 354378; name= "Prototype"; parentMarketGroupId= Some(353601); typeIds= [|  |]; description= "" } |> Some
      | 366212 -> { MarketGroupData.id= 366212; name= "Prototype"; parentMarketGroupId= Some(366186); typeIds= [|  |]; description= "" } |> Some
      | 367570 -> { MarketGroupData.id= 367570; name= "Services"; parentMarketGroupId= Some(369234); typeIds= [|  |]; description= "" } |> Some
      | 425 -> { MarketGroupData.id= 425; name= "Amarr"; parentMarketGroupId= Some(419); typeIds= [| 12041; 11189 |]; description= "Blueprints of Amarr covert ops designs." } |> Some
      | 522 -> { MarketGroupData.id= 522; name= "Dark Ochre"; parentMarketGroupId= Some(54); typeIds= [| 46694; 28394; 28395; 28396; 1232; 46675; 17436; 17437 |]; description= "Sub-types of dark ochre ore." } |> Some
      | 619 -> { MarketGroupData.id= 619; name= "Implant Slot 02"; parentMarketGroupId= Some(532); typeIds= [| 28803; 33924; 28809; 33930; 28815; 33936; 20500; 20501; 33942; 33948; 33954; 33960; 33966; 33972; 20157; 33525; 31969; 42146; 19535; 31955; 9941; 14297; 31963; 22108; 42205; 19551; 10208; 10209; 22114; 42211; 13284; 32102; 31975; 22120; 32108; 22126; 32113; 33394; 22133; 32118; 28791; 28797; 33918; 33557 |]; description= "Implants intended for Subcervical Processing Slot 2." } |> Some
      | 716 -> { MarketGroupData.id= 716; name= "Ladar Jammers"; parentMarketGroupId= Some(677); typeIds= [| 19937; 19939; 1958; 2559; 19935; 28733; 20575 |]; description= "Targeting jammers specialized for use against Ladar sensors." } |> Some
      | 813 -> { MarketGroupData.id= 813; name= "Amarr"; parentMarketGroupId= Some(812); typeIds= [| 11567 |]; description= "Amarr titan designs." } |> Some
      | 910 -> { MarketGroupData.id= 910; name= "Capital"; parentMarketGroupId= Some(663); typeIds= [| 12219; 41566; 12223; 41565; 3575 |]; description= "Capital ship-sized energy transfer arrays." } |> Some
      | _ -> None