namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups33=
    let getMarketGroup id = 
      match id with 
      | 1003 -> { MarketGroupData.id= 1003; name= "Faction Heavy Assault Missiles"; parentMarketGroupId= Some(968); typeIds= [| 27393; 27397; 27401; 27403; 27405; 27407; 27411; 27413; 27415; 27417; 27419; 27421 |]; description= "Faction issue heavy assault missiles." } |> Some
      | 1197 -> { MarketGroupData.id= 1197; name= "Expanded Cargoholds"; parentMarketGroupId= Some(135); typeIds= [| 1315; 1317; 1319; 5493; 34489; 21493; 21855 |]; description= "The extra bulk this expansion adds to a starship reduces its speed, but gives it more room to store cargo." } |> Some
      | 1585 -> { MarketGroupData.id= 1585; name= "Signal Amplifiers"; parentMarketGroupId= Some(1578); typeIds= [| 11634 |]; description= "Signal Amplifiers" } |> Some
      | 1682 -> { MarketGroupData.id= 1682; name= "Explosive Energized Membranes"; parentMarketGroupId= Some(541); typeIds= [| 15232; 14082; 14084; 14086; 18823; 14984; 14986; 18839; 14988; 15234; 14990; 14992; 14994; 14996; 18837; 14998; 16407; 17540; 18857; 18859; 55862; 18873; 18875; 11225; 11227; 11229; 15725; 18803; 15735; 28538; 15228; 18813; 15230 |]; description= "Explosive Energized Membranes" } |> Some
      | 1779 -> { MarketGroupData.id= 1779; name= "Resource Processing Rigs"; parentMarketGroupId= Some(1111); typeIds= [|  |]; description= "Permanent modification of a ship's resource processing facilities." } |> Some
      | 1973 -> { MarketGroupData.id= 1973; name= "Titans"; parentMarketGroupId= Some(1968); typeIds= [|  |]; description= "" } |> Some
      | 2070 -> { MarketGroupData.id= 2070; name= "Caldari"; parentMarketGroupId= Some(2065); typeIds= [| 47105; 46730; 47628; 45837; 45838; 40601; 40602; 54428; 50074; 49953; 46114; 46115; 52634; 36653; 36654; 53425; 48180; 48181; 53174; 53175; 48833; 53956; 52555; 52558; 55566; 36346; 36725; 36726; 36344; 46841; 46842; 55549; 47614 |]; description= "" } |> Some
      | 2167 -> { MarketGroupData.id= 2167; name= "Electronic Counter Measures"; parentMarketGroupId= Some(2161); typeIds= [| 37041; 46578 |]; description= "" } |> Some
      | 2264 -> { MarketGroupData.id= 2264; name= "Caldari"; parentMarketGroupId= Some(2262); typeIds= [| 41583 |]; description= "Blueprints of Caldari force auxiliary designs." } |> Some
      | 2361 -> { MarketGroupData.id= 2361; name= "Special Covert Ops"; parentMarketGroupId= Some(2044); typeIds= [| 47680; 48576; 48579; 46021; 45991; 54216; 45481; 47001; 55295 |]; description= "" } |> Some
      | 2458 -> { MarketGroupData.id= 2458; name= "Dark Filaments"; parentMarketGroupId= Some(2456); typeIds= [| 56132; 56140; 47762; 47892; 47893; 47894; 47895 |]; description= "Filaments that connect to Abyssal pockets with Dark Matter Fields" } |> Some
      | 2749 -> { MarketGroupData.id= 2749; name= "Quantum Cores"; parentMarketGroupId= Some(2202); typeIds= [| 56201; 56202; 56203; 56204; 56205; 56206; 56207; 56208 |]; description= "Quantum Cores are FTL communications facillities vital to the efficient operation of Upwell structures." } |> Some
      | 421 -> { MarketGroupData.id= 421; name= "Amarr"; parentMarketGroupId= Some(420); typeIds= [| 11188; 12038 |]; description= "Amarr covert ops designs." } |> Some
      | 518 -> { MarketGroupData.id= 518; name= "Veldspar"; parentMarketGroupId= Some(54); typeIds= [| 46689; 50015; 57027; 57028; 28430; 28431; 28432; 46705; 48916; 1230; 56950; 49787; 49789; 17470; 17471 |]; description= "Sub-types of veldspar ore.   " } |> Some
      | 615 -> { MarketGroupData.id= 615; name= "Damage Controls"; parentMarketGroupId= Some(14); typeIds= [| 2048; 521; 40714; 40715; 40716; 40717; 40718; 47254; 47255; 47256; 47257; 47258; 41207; 5839; 41210; 41200; 41201; 41202; 41203; 41204; 41205; 41206; 30839; 41208; 23418; 41211; 2046 |]; description= "Containment field emitters and redundancy systems for prevention of critical system damage. " } |> Some
      | 712 -> { MarketGroupData.id= 712; name= "Scan Probe Launchers"; parentMarketGroupId= Some(1708); typeIds= [| 4258; 4260; 18639; 17938; 28756; 28758 |]; description= "Launcher bays designed to fire scan probes for stellar triangulation." } |> Some
      | _ -> None