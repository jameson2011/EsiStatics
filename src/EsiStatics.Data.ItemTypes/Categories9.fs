﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Categories9=
    let getCategory id = 
      match id with 
      | 9 -> { CategoryData.id= 9; name= "Blueprint"; published= true; groupIds= [| 104; 105; 106; 107; 108; 109; 110; 111; 118; 119; 120; 121; 123; 126; 127; 128; 129; 130; 131; 132; 133; 134; 135; 136; 137; 139; 140; 141; 142; 143; 145; 147; 148; 151; 152; 154; 156; 157; 158; 160; 161; 162; 163; 165; 166; 167; 168; 169; 170; 172; 174; 175; 176; 177; 178; 218; 223; 224; 296; 342; 343; 344; 345; 346; 347; 348; 349; 350; 352; 356; 360; 371; 400; 401; 408; 410; 447; 477; 478; 486; 487; 489; 490; 503; 504; 516; 525; 532; 535; 537; 643; 651; 718; 722; 723; 724; 725; 726; 727; 787; 841; 853; 854; 855; 856; 857; 858; 859; 860; 870; 871; 888; 889; 890; 891; 912; 914; 915; 917; 918; 944; 945; 965; 973; 996; 1013; 1045; 1046; 1048; 1123; 1137; 1139; 1142; 1143; 1144; 1145; 1146; 1147; 1151; 1152; 1155; 1157; 1160; 1162; 1190; 1191; 1197; 1200; 1222; 1224; 1227; 1239; 1267; 1268; 1269; 1270; 1277; 1293; 1294; 1295; 1309; 1317; 1318; 1397; 1399; 1461; 1462; 1542; 1543; 1679; 1703; 1707; 1708; 1709; 1718; 1723; 1810; 1812; 1888; 1889; 1890; 1891; 1948; 1990; 1992; 1993; 1994; 2010; 2019; 2023; 4052; 4064; 4065; 4066; 4069 |] } |> Some
      | _ -> None