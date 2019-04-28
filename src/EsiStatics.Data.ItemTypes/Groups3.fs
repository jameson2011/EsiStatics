namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups3=
    let getGroup id = 
      match id with 
      | 100 -> { GroupData.id= 100; name= "Combat Drone"; categoryId= 18; published= true; typeIds= [| 1201; 2173; 2175; 2183; 2185; 2193; 2195; 2203; 2205; 2436; 2444; 2446; 2454; 2456; 2464; 2466; 2476; 2478; 2486; 2488; 3549; 15508; 15510; 16206; 21638; 21640; 22780; 23525; 23559; 23561; 23563; 23759; 28209; 28211; 28213; 28215; 28262; 28264; 28266; 28268; 28270; 28272; 28274; 28276; 28278; 28280; 28282; 28284; 28286; 28288; 28290; 28292; 28294; 28296; 28298; 28300; 28302; 28304; 28306; 28308; 31864; 31866; 31868; 31870; 31872; 31874; 31876; 31878; 31880; 31882; 31884; 31886; 31888; 31890; 31892; 31894; 32465; 33681; 48744 |] } |> Some
      | 1167 -> { GroupData.id= 1167; name= "FW Caldari State Frigate"; categoryId= 11; published= true; typeIds= [| 32914 |] } |> Some
      | 1652 -> { GroupData.id= 1652; name= "Light Fighter"; categoryId= 87; published= true; typeIds= [| 23055; 23057; 23059; 23061; 40358; 40359; 40360; 40361; 40552; 40553; 40554; 40555; 40556; 40557; 40558; 40559; 45669; 45671; 47035; 47036; 47138; 47139; 47140; 47141; 47142; 47143; 47144; 47145; 47146; 47147; 47148; 47149; 47150; 47151 |] } |> Some
      | 1846 -> { GroupData.id= 1846; name= "Structure Engineering Rig M - TE Research Cost Optimization"; categoryId= 66; published= true; typeIds= [| 43886; 43887 |] } |> Some
      | 1943 -> { GroupData.id= 1943; name= "Structure Resource Rig M - Moon Ore Reprocessing"; categoryId= 66; published= true; typeIds= [| 46637; 46638 |] } |> Some
      | 197 -> { GroupData.id= 197; name= "Gallente Education"; categoryId= 14; published= false; typeIds= [| 1663; 1664; 1665; 1666; 1667; 1668 |] } |> Some
      | 3 -> { GroupData.id= 3; name= "Region"; categoryId= 2; published= false; typeIds= [| 3 |] } |> Some
      | 585 -> { GroupData.id= 585; name= "Remote Hull Repairer"; categoryId= 7; published= true; typeIds= [| 3986; 4296; 4299; 27904; 27930; 27932; 27934; 41475 |] } |> Some
      | 682 -> { GroupData.id= 682; name= "Mission Gallente Federation Other"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 779 -> { GroupData.id= 779; name= "Rig Launcher"; categoryId= 7; published= true; typeIds= [| 26016; 26018; 26020; 26022; 26024; 26026; 26028; 26030; 26406; 26408; 26410; 26412; 26414; 26416; 26418; 26420; 31586; 31588; 31590; 31592; 31594; 31596; 31598; 31600; 31602; 31604; 31606; 31608; 31610; 31612; 31614; 31616; 31618; 31620; 31622; 31624; 31626; 31628; 31630; 31632; 31634; 31636; 31638; 31640; 31642; 31644; 31646; 31648; 31650; 31652; 31654; 33301 |] } |> Some
      | 876 -> { GroupData.id= 876; name= "Outpost Upgrades"; categoryId= 5; published= true; typeIds= [| 28183; 28184; 28185 |] } |> Some
      | 973 -> { GroupData.id= 973; name= "Subsystem Blueprints"; categoryId= 9; published= true; typeIds= [| 45681; 45682; 45683; 45684; 45685; 45686; 45687; 45688; 45689; 45690; 45691; 45692; 45693; 45694; 45695; 45696; 45697; 45698; 45699; 45700; 45701; 45702; 45703; 45704; 45705; 45706; 45707; 45708; 45709; 45710; 45711; 45712; 45713; 45714; 45715; 45716; 45717; 45718; 45719; 45720; 45721; 45722; 45723; 45724; 45725; 45726; 45727; 45728 |] } |> Some
      | _ -> None