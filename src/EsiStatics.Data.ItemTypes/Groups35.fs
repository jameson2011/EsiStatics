﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups35=
    let getGroup id = 
      match id with 
      | 1005 -> { GroupData.id= 1005; name= "Sovereignty Blockade Unit"; categoryId= 40; published= false; typeIds= [| 32250; 32302 |] } |> Some
      | 1199 -> { GroupData.id= 1199; name= "Ancillary Armor Repairer"; categoryId= 7; published= true; typeIds= [| 33076; 33101; 33103; 41503; 47842; 47844; 47846 |] } |> Some
      | 132 -> { GroupData.id= 132; name= "Warp Scrambler Blueprint"; categoryId= 9; published= true; typeIds= [| 1079; 1080; 3243; 3245; 4249; 15888; 15890; 15892; 15894; 21511; 21513; 22477; 28517; 28519; 28655; 40740; 40741; 40742; 40743; 40744; 40746; 40747; 40751; 40753; 40755; 40757; 40759; 40763; 40765 |] } |> Some
      | 1587 -> { GroupData.id= 1587; name= "Structure Assembly Rig L - Module, Consumable, Drone"; categoryId= 66; published= false; typeIds= [|  |] } |> Some
      | 1684 -> { GroupData.id= 1684; name= "Asteroid Blood Raider Titan"; categoryId= 11; published= false; typeIds= [| 37464 |] } |> Some
      | 1878 -> { GroupData.id= 1878; name= "♦ Titan"; categoryId= 11; published= false; typeIds= [| 45471; 45472 |] } |> Some
      | 1975 -> { GroupData.id= 1975; name= "Non-Interactable Object"; categoryId= 2; published= false; typeIds= [| 47378; 47379; 47381; 47382; 47384; 47385; 47387; 47388; 47390; 47391; 47393; 47402; 47403; 47404; 47405; 47406; 47407; 47409; 47410; 47412; 47413; 47414; 47415; 47416; 47417; 47418; 47419; 47420; 47421; 47422; 47423; 47424; 47425; 47426; 47427; 47428; 47671; 47672; 47673; 47674; 47675; 47676; 47677; 47678; 47679; 47936; 47937; 47938; 47939; 47940; 47941; 47942; 47943; 47944; 47945; 47946; 47947; 47948; 47964; 47965; 48920; 48921; 48922; 48960; 48963; 48968; 49104; 49105; 49106; 49107; 49110; 49418; 49557; 49558; 49559; 49560; 49561; 49562; 49615; 49691; 49747; 49755; 49757; 49758; 49766; 50094; 50118; 50119; 50120; 50121; 50122; 50123; 50124; 50125; 50126; 50127; 50128 |] } |> Some
      | 326 -> { GroupData.id= 326; name= "Armor Plating Energized"; categoryId= 7; published= true; typeIds= [| 11215; 11217; 11219; 11225; 11227; 11229; 11235; 11237; 11239; 11245; 11247; 11249; 11255; 11257; 11259; 11265; 11267; 11269; 14070; 14072; 14074; 14076; 14078; 14080; 14082; 14084; 14086; 14088; 14090; 14092; 14094; 14096; 14098; 14936; 14938; 14940; 14942; 14944; 14946; 14948; 14950; 14952; 14954; 14956; 14958; 14960; 14962; 14964; 14966; 14968; 14970; 14972; 14974; 14976; 14978; 14980; 14982; 14984; 14986; 14988; 14990; 14992; 14994; 14996; 14998; 15000; 15002; 15004; 15006; 15008; 15010; 15012; 15014; 15204; 15206; 15208; 15210; 15212; 15214; 15216; 15218; 15220; 15222; 15224; 15226; 15228; 15230; 15232; 15234; 15236; 15238; 15240; 15242; 15453; 15455; 15721; 15723; 15725; 15727; 15729; 15731; 15733; 15735; 15737; 15739; 16385; 16387; 16389; 16391; 16393; 16395; 16397; 16399; 16401; 16403; 16405; 16407; 16409; 16411; 16413; 16415; 16417; 16419; 16421; 16423; 16425; 16427; 16429; 16431; 17536; 17538; 17540; 17542; 17544; 18799; 18801; 18803; 18805; 18807; 18809; 18811; 18813; 18815; 18817; 18819; 18821; 18823; 18825; 18827; 18829; 18831; 18833; 18835; 18837; 18839; 18841; 18843; 18845; 18847; 18849; 18851; 18853; 18855; 18857; 18859; 18861; 18863; 18865; 18867; 18869; 18871; 18873; 18875; 18877; 18879; 18881; 18883; 19361; 19363; 22879; 22881; 22883; 28534; 28536; 28538; 28540; 28542 |] } |> Some
      | 423 -> { GroupData.id= 423; name= "Ice Product"; categoryId= 4; published= true; typeIds= [| 16272; 16273; 16274; 16275; 17887; 17888; 17889 |] } |> Some
      | 520 -> { GroupData.id= 520; name= "Storyline Frigate"; categoryId= 11; published= false; typeIds= [| 20462; 20463; 20464; 20465; 20466; 20467; 20468; 20469; 20470; 20471; 20472; 20473; 20474; 20475; 21060; 21130; 21131; 21767; 21768; 21769; 21770; 21771; 21772; 21773; 21774; 21775; 21776; 21779; 21780; 21781; 21782; 22255; 22256; 22257; 22258; 22259; 22260; 22261; 22270; 22661; 22662; 22663; 22664; 22665; 22666; 22673; 23242; 23243; 23277; 23280; 23665; 23671; 23672; 24683; 26717; 26718; 32199; 32222 |] } |> Some
      | 811 -> { GroupData.id= 811; name= "Asteroid Serpentis Commander BattleCruiser"; categoryId= 11; published= false; typeIds= [| 23463; 23464; 23465; 23466; 23467; 23468 |] } |> Some
      | 908 -> { GroupData.id= 908; name= "Warp Disruption Script"; categoryId= 8; published= true; typeIds= [| 29003; 45010 |] } |> Some
      | _ -> None