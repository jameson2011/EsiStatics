namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups29=
    let getGroup id = 
      match id with 
      | 126 -> { GroupData.id= 126; name= "Propulsion Module Blueprint"; categoryId= 9; published= true; typeIds= [| 1067; 1071; 1072; 1073; 12053; 12055; 12057; 12059; 12067; 12069; 12077; 12085; 15748; 15750; 15752; 15754; 15756; 15758; 15760; 15762; 15765; 15767; 15769; 15771; 21471; 21473; 21475; 21477; 21479; 21481; 21858; 41242; 41243; 41244; 41245; 41246; 41248; 41256; 41257; 41258; 41260; 41261; 41262; 41313 |] } |> Some
      | 1581 -> { GroupData.id= 1581; name= "Structure Assembly Rig M - Small Tech II Ship"; categoryId= 66; published= false; typeIds= [|  |] } |> Some
      | 1678 -> { GroupData.id= 1678; name= "Advanced XL Cruise Missile"; categoryId= 8; published= true; typeIds= [| 41286; 41287; 41290; 41291; 41294; 41295; 41298; 41299 |] } |> Some
      | 1872 -> { GroupData.id= 1872; name= "Structure Entities"; categoryId= 11; published= false; typeIds= [| 44253 |] } |> Some
      | 1969 -> { GroupData.id= 1969; name= "[no messageID: 532741]"; categoryId= 7; published= false; typeIds= [|  |] } |> Some
      | 223 -> { GroupData.id= 223; name= "Sensor Booster Blueprint"; categoryId= 9; published= true; typeIds= [| 11620; 11798; 11799; 11803; 11804; 11808; 17521; 22896; 22926; 22940; 22942; 22944; 22946; 41412 |] } |> Some
      | 29 -> { GroupData.id= 29; name= "Capsule"; categoryId= 6; published= false; typeIds= [| 670; 33328 |] } |> Some
      | 368726 -> { GroupData.id= 368726; name= "Infantry Color Skin"; categoryId= 350001; published= false; typeIds= [| 368725; 368755; 368756; 368776; 368951; 369091; 369092; 369093; 369094; 369102; 369103; 369104; 369105; 369106; 369107; 369108; 369109; 369113; 369114; 369115; 369116; 369158; 369159; 369160; 369161; 369162; 369163; 369164; 369165; 369166; 369167; 369168; 369180; 369200; 369203; 369204; 369205; 369206; 369242; 369243; 369244; 369245; 369246; 369247; 369248; 369249; 369250; 369251; 369252; 369253; 369254; 369255; 369256; 369257; 369258; 369259; 369260; 369261; 369262; 369263; 369264; 369265; 369266; 369267; 369268; 369269; 369270; 369271; 369272; 369273; 369274; 369275; 369276; 369277; 369278; 369279; 369280; 369281; 369282; 369290; 369291; 369292; 369293; 369294; 369295; 369296; 369297; 369302; 369303; 369304; 369305; 369434; 369435; 370308; 370488 |] } |> Some
      | 417 -> { GroupData.id= 417; name= "Mobile Missile Sentry"; categoryId= 23; published= true; typeIds= [| 16222; 16695; 16696; 16697; 17773; 27560; 27562; 27638; 27640; 27641; 27643 |] } |> Some
      | 514 -> { GroupData.id= 514; name= "ECM Stabilizer"; categoryId= 7; published= true; typeIds= [| 25561; 25563; 25565; 25567; 25569; 25571 |] } |> Some
      | 611 -> { GroupData.id= 611; name= "Deadspace Guristas BattleCruiser"; categoryId= 11; published= false; typeIds= [| 24001; 24014; 24015; 24016; 24017; 24018; 24187; 24188; 24189; 24190; 24191; 24192 |] } |> Some
      | 805 -> { GroupData.id= 805; name= "Deadspace Rogue Drone Frigate"; categoryId= 11; published= false; typeIds= [| 3744; 3748; 3749; 3750; 16210; 16211; 18070; 18071; 18072; 18079; 18080; 18085; 18086; 18087; 18088; 18564; 22284; 22285; 23481; 23482; 23483; 23484; 23485; 23486; 27293; 53323 |] } |> Some
      | 902 -> { GroupData.id= 902; name= "Jump Freighter"; categoryId= 6; published= true; typeIds= [| 28844; 28846; 28848; 28850 |] } |> Some
      | _ -> None