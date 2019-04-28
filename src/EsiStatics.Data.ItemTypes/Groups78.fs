﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups78=
    let getGroup id = 
      match id with 
      | 1048 -> { GroupData.id= 1048; name= "Starbase Blueprint"; categoryId= 9; published= true; typeIds= [| 2742; 2743; 2744; 2745; 2746; 2747; 2748; 2749; 2750; 2751; 2752; 2753; 2754; 2755; 2756; 2757; 2758; 2759; 2760; 2761; 2762; 2763; 2764; 2765; 2766; 2767; 2768; 2769; 2770; 2771; 2772; 2773; 2786; 2787; 2788; 2789; 2790; 2791; 2793; 2795; 2797; 2800; 3963; 33150; 33868 |] } |> Some
      | 1145 -> { GroupData.id= 1145; name= "Heavy Fighter Blueprint"; categoryId= 9; published= true; typeIds= [| 2949; 32326; 32341; 32343; 32345; 41351; 41352; 41353; 41354; 41355; 41356; 41361; 41362; 41363; 41364; 41365; 41366; 45674; 45676; 47232; 47233; 47234; 47235; 47236; 47237; 47238; 47239; 47240; 47241; 47242; 47243; 47244; 47245; 47246; 47247; 47248 |] } |> Some
      | 1533 -> { GroupData.id= 1533; name= "Micro Jump Field Generators"; categoryId= 7; published= true; typeIds= [| 37479 |] } |> Some
      | 1630 -> { GroupData.id= 1630; name= "Structure Combat Rig L - Energy Neutralizer Projection and Cap Reduction"; categoryId= 66; published= true; typeIds= [| 37250; 37251 |] } |> Some
      | 1727 -> { GroupData.id= 1727; name= "Roaming Angel Cartel Battleship"; categoryId= 11; published= false; typeIds= [| 42142 |] } |> Some
      | 175 -> { GroupData.id= 175; name= "Proximity Drone Blueprint"; categoryId= 9; published= true; typeIds= [|  |] } |> Some
      | 1824 -> { GroupData.id= 1824; name= "Structure Engineering Rig M - Basic Small Ship ME"; categoryId= 66; published= true; typeIds= [| 37154; 37155 |] } |> Some
      | 1921 -> { GroupData.id= 1921; name= "Uncommon Moon Asteroids"; categoryId= 25; published= true; typeIds= [| 45498; 45499; 45500; 45501; 46296; 46297; 46298; 46299; 46300; 46301; 46302; 46303 |] } |> Some
      | 2018 -> { GroupData.id= 2018; name= "Mutadaptive Remote Armor Repairer"; categoryId= 7; published= true; typeIds= [| 49770; 49771; 49772; 49773; 49774 |] } |> Some
      | 272 -> { GroupData.id= 272; name= "Electronic Systems"; categoryId= 16; published= true; typeIds= [| 3427; 3433; 3434; 3435; 4411; 11208; 11579; 12368; 19759; 19760; 19761; 19766; 19767; 19921; 19922; 27906; 27911; 28604; 28631 |] } |> Some
      | 351121 -> { GroupData.id= 351121; name= "Infantry Modules"; categoryId= 350001; published= false; typeIds= [| 351610; 351611; 351614; 351615; 351620; 351630; 351631; 351632; 351633; 351669; 351670; 351671; 351673; 351674; 351675; 351679; 351680; 351681; 351684; 351686; 351687; 351688; 351689; 351690; 351696; 351697; 351698; 351699; 351700; 351701; 351732; 351865; 351905; 351906; 351907; 351908; 351909; 351910; 352017; 352018; 352019; 352020; 352021; 352022; 352032; 352034; 352035; 352041; 352042; 352043; 352045; 352046; 352047; 352048; 352049; 352050; 352051; 352052; 352057; 352067; 352068; 352069; 352070; 352071; 352072; 352073; 352074; 352076; 352077; 352078; 352079; 352083; 352089; 352101; 352108; 352221; 352274; 352277; 352279; 352293; 352536; 352537; 352538; 352550; 352604; 352687; 352929; 353041; 353283; 353284; 353285; 353742; 353743; 353744; 353907; 353919; 353931; 353932; 353933; 353934; 353935; 353936; 353980; 353981; 353982; 353983; 353984; 353985; 353986; 353987; 353988; 353989; 353990; 353991; 353992; 354011; 354012; 354122; 354123; 354124; 354125; 354126; 354127; 354128; 354129; 354130; 354131; 354132; 354133; 354134; 354135; 354140; 354141; 354142; 354147; 354148; 354149; 354150; 354151; 354152; 354153; 354154; 354155; 354156; 354158; 354159; 354160; 354169; 354170; 354171; 354172; 354173; 354174; 354175; 354176; 354177; 354178; 354179; 354180; 354181; 354182; 354183; 354184; 354185; 354186; 354187; 354188; 354264; 354265; 354266; 354267; 354667; 354669; 354867; 354869; 354870; 354903; 354904; 354905; 354906; 354907; 354908; 354912; 354913; 354914; 354915; 354916; 354917; 354918; 354919; 354921; 354922; 354923; 354924; 354926; 355294; 355297; 355299; 355308; 355329; 355331; 355332; 355375; 355402; 355403; 355404; 355405; 355406; 355407; 355408; 355409; 355411; 355412; 355413; 355414; 355415; 355416; 355421; 355422; 355442; 355517; 355518; 355519; 355520; 355521; 355523; 355526; 355527; 355528; 355532; 355533; 355534; 355535; 355536; 355537; 355566; 355567; 355568; 355569; 355570; 355571; 355582; 355583; 355584; 355585; 355586; 355587; 355591; 355607; 355610; 355611; 355613; 355614; 355785; 355786; 355787; 355788; 355789; 355790; 355791; 355792; 355793; 355798; 355799; 355800; 355801; 355802; 355803; 355804; 355805; 355807; 355808; 355809; 355810; 355811; 355894; 355895; 355896; 355897; 355898; 355903; 355904; 355905; 355906; 355908; 355909; 355910; 355927; 355928; 355929; 355930; 355931; 356416; 356471; 356473; 356495; 356496; 356497; 356498; 356499; 356500; 356526; 356562; 356563; 356564; 356565; 356566; 356567; 356590; 356591; 356593; 356594; 356629; 356703; 356704; 356705; 356707; 356708; 356711; 356788; 356789; 356790; 356791; 356792; 356793; 356794; 356795; 356796; 356797; 356798; 356799; 356800; 356801; 356802; 356803; 356804; 356805; 356854; 356855; 356857; 356858; 356859; 356860; 356861; 356862; 356863; 356864; 356865; 356866; 356867; 356868; 356869; 356870; 363096; 363388; 363389; 363390; 363405; 364173; 364174; 364175; 364176; 364177; 364245; 364248; 364249; 364250; 364506; 365200; 365229; 365230; 365231; 365233; 365234; 365235; 365237; 365238; 365239; 365240; 365241; 365242; 365243; 365252; 365253; 365254; 365255; 365256; 365294; 365295; 365296; 365351; 365352; 365353; 365360; 365361; 365362; 365424; 365777; 365778; 365779; 365783; 365784; 365785; 365786; 365787; 365788; 365902; 365903; 365904; 365905; 365906; 365907; 365908; 365952; 365956; 366289; 366290; 366291; 366292; 366293; 366294; 366295; 366296; 366297; 366298; 366299; 366300; 366301; 366302; 366303; 366304; 366305; 366306; 366307; 366308; 366309; 366310; 366311; 366312; 366313; 366314; 366315; 366316; 366317; 366318; 366319; 366320; 366321; 366322; 366323; 366324; 366391; 366392; 366393; 366394; 366395; 366396; 366397; 366398; 366399; 366400; 366401; 366402; 366403; 366404; 366405; 366406; 366407; 366408; 366435; 366436; 366437; 366438; 366439; 366440; 366465; 366466; 366467; 366468; 366469; 366470; 366471; 366472; 366473; 366474; 366475; 366476; 366477; 366478; 366479; 366480; 366481; 366482; 366522; 366523; 366524; 368777; 368893; 368894; 368895; 368898; 368899; 368900 |] } |> Some
      | 369 -> { GroupData.id= 369; name= "Ship Logs"; categoryId= 17; published= true; typeIds= [| 12306; 12339; 12340; 12341; 12342; 12343; 12369; 12370; 12371; 12372; 12373; 12374; 12375; 12377; 12378; 12379; 12380; 12381; 12382; 12384; 12444; 12445; 12446; 12447; 12448; 12449; 12450; 12451; 12452; 12453; 12454; 12455; 12456; 12457; 12460; 12461; 12462; 12463; 12465; 12466; 12467; 12468; 12469; 12474; 12475; 12476; 12477; 12479; 12480; 12481; 12597; 12598; 12599; 12600; 12601; 29150 |] } |> Some
      | 563 -> { GroupData.id= 563; name= "Asteroid Guristas Hauler"; categoryId= 11; published= false; typeIds= [| 13714; 13715; 13716; 13717; 13718; 13719; 13720; 13721; 13722; 13723; 13724; 13725; 22001; 22002; 22003; 22004; 22029 |] } |> Some
      | 660 -> { GroupData.id= 660; name= "Energy Vampire Slayer"; categoryId= 7; published= false; typeIds= [|  |] } |> Some
      | 757 -> { GroupData.id= 757; name= "Asteroid Rogue Drone Cruiser"; categoryId= 11; published= false; typeIds= [| 25632; 25635; 25639; 25643; 25644; 25646; 25664; 25677; 25678; 25680; 25682; 25683; 25685; 25688; 25694; 25695; 25696; 25703; 25704; 25705 |] } |> Some
      | 78 -> { GroupData.id= 78; name= "Reinforced Bulkhead"; categoryId= 7; published= true; typeIds= [| 1240; 1333; 1335; 5643; 5645; 5647; 5649; 5675; 5677; 5679; 5681; 21496; 22537; 34485; 34487 |] } |> Some
      | 854 -> { GroupData.id= 854; name= "Starbase - Projectile Battery Blueprints"; categoryId= 9; published= true; typeIds= [| 2805; 2807; 2810; 2814; 2816; 2819; 27831; 27832; 27833; 27834; 27835; 27836; 27837; 27838; 27839; 27840; 27841; 27842 |] } |> Some
      | _ -> None