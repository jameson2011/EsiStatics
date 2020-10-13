﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups25=
    let getGroup id = 
      match id with 
      | 1092 -> { GroupData.id= 1092; name= "Headwear"; categoryId= 30; published= true; typeIds= [| 4086; 4088; 4096; 34056; 34057; 34058; 34059; 34060; 34061; 34062; 34063; 34064; 34065; 34066; 34067; 34068; 34069; 34070; 34071; 34072; 34073; 34074; 34075; 34076; 34077; 34078; 42698; 42699; 42708; 42709; 42710; 42711; 42712; 42713; 42714; 42715; 42716; 42717; 42718; 42719; 42720; 42721; 42722; 42723; 42724; 42725; 42726; 42727; 42728; 42729; 42730; 42731; 42732; 42733; 42734; 42735; 42736; 42737; 42738; 42739; 42740; 42741; 42742; 42743; 42744; 42745; 44122; 44125; 45739; 45740; 47191; 47193; 47477; 47478; 50132; 50133; 52201; 52202; 53381; 53384; 54304; 54310; 54322; 54327; 54948; 54949; 55002; 55003; 55010; 55011; 55751; 55752; 55753; 55754; 55755; 55756; 55757; 55758; 56144; 56145; 56209; 56210; 56634; 56637 |] } |> Some
      | 1189 -> { GroupData.id= 1189; name= "Micro Jump Drive"; categoryId= 7; published= true; typeIds= [| 4383; 33915 |] } |> Some
      | 1286 -> { GroupData.id= 1286; name= "Asteroid Mordus Legion Commander Cruiser"; categoryId= 11; published= false; typeIds= [| 33865 |] } |> Some
      | 1674 -> { GroupData.id= 1674; name= "Missile Launcher XL Cruise"; categoryId= 7; published= true; typeIds= [| 3563; 32444; 37295; 41174; 41175; 41176 |] } |> Some
      | 1771 -> { GroupData.id= 1771; name= "Mining Foreman Burst Charges"; categoryId= 8; published= true; typeIds= [| 42829; 42830; 42831 |] } |> Some
      | 1868 -> { GroupData.id= 1868; name= "Structure Engineering Rig XL - Ship Efficiency"; categoryId= 66; published= true; typeIds= [| 37180; 37181 |] } |> Some
      | 25 -> { GroupData.id= 25; name= "Frigate"; categoryId= 6; published= true; typeIds= [| 582; 583; 584; 585; 586; 587; 589; 590; 591; 592; 593; 594; 595; 597; 598; 599; 600; 602; 603; 605; 607; 608; 609; 613; 614; 616; 618; 619; 1896; 1898; 1900; 1902; 2161; 3532; 3751; 3753; 3766; 3768; 11019; 11940; 11942; 17360; 17619; 17703; 17705; 17707; 17812; 17841; 17924; 17926; 17928; 17930; 17932; 29248; 32880; 32983; 32985; 32987; 32989; 33190; 33468; 33655; 33657; 33659; 33661; 33663; 33665; 33667; 33669; 33677; 33816; 34443; 37453; 37454; 37455; 37456; 47269; 54731 |] } |> Some
      | 316 -> { GroupData.id= 316; name= "Gang Coordinator"; categoryId= 7; published= false; typeIds= [| 4262; 4264; 4266; 4268; 4270; 4272; 4274; 4276; 4278; 4280; 4282; 4284; 4286; 4288; 4290; 11014; 11017; 11052; 20069; 20070; 20124; 20405; 20406; 20408; 20409; 20514; 22227; 22228; 22553; 22555; 22557 |] } |> Some
      | 351844 -> { GroupData.id= 351844; name= "Infantry Equipment"; categoryId= 350001; published= false; typeIds= [| 351858; 351915; 351916; 352493; 353213; 353214; 353215; 353216; 353217; 353218; 353219; 353220; 353222; 353223; 353224; 353225; 353229; 353230; 353231; 353232; 353233; 353234; 353235; 353236; 353237; 353238; 353239; 353240; 353244; 353245; 353246; 353247; 353248; 353249; 353250; 353251; 353252; 353253; 353254; 353255; 353256; 353748; 354106; 354107; 354108; 354626; 354627; 354664; 354714; 354884; 355266; 355267; 355268; 355269; 355270; 355271; 355428; 355435; 355508; 355577; 356305; 356306; 356709; 356710; 356819; 356843; 356844; 356845; 356846; 356877; 356878; 356882; 356883; 356900; 356901; 356918; 357011; 357018; 363400; 363409; 363410; 363411; 363412; 364408; 364409; 364410; 364411; 364412; 364413; 364414; 364564; 364781; 364782; 364783; 364784; 364785; 364789; 364790; 364791; 366004; 366104; 366105; 366106; 366107; 366108; 366409; 366410; 366411; 366441; 366442; 366483; 366484; 366485; 366486; 366487; 366488; 366525; 366526; 366527; 366528; 366529; 366530; 366532; 366534; 366749; 366750; 366751; 368242; 368243; 368244; 369211; 370658 |] } |> Some
      | 413 -> { GroupData.id= 413; name= "Laboratory"; categoryId= 23; published= true; typeIds= [| 16216; 24567; 28351; 32245 |] } |> Some
      | 510 -> { GroupData.id= 510; name= "Missile Launcher Heavy"; categoryId= 7; published= true; typeIds= [| 501; 2410; 7997; 8101; 8103; 8105; 13921; 13922; 16064; 16137; 17487; 20599; 22567 |] } |> Some
      | 704 -> { GroupData.id= 704; name= "Mission Mordu Other"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 801 -> { GroupData.id= 801; name= "Deadspace Rogue Drone BattleCruiser"; categoryId= 11; published= false; typeIds= [| 3747; 18073; 18074; 18075; 23489; 23490; 45637 |] } |> Some
      | 898 -> { GroupData.id= 898; name= "Black Ops"; categoryId= 6; published= true; typeIds= [| 22428; 22430; 22436; 22440; 44996 |] } |> Some
      | 995 -> { GroupData.id= 995; name= "Secondary Sun"; categoryId= 2; published= false; typeIds= [| 2064; 30574; 30575; 30576; 30577; 30669; 30670 |] } |> Some
      | _ -> None