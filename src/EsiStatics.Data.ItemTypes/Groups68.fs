namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups68=
    let getGroup id = 
      match id with 
      | 1232 -> { GroupData.id= 1232; name= "Rig Resource Processing"; categoryId= 7; published= true; typeIds= [| 25902; 26300; 31083; 31085; 31087; 31089; 31091; 31093; 32817; 32819 |] } |> Some
      | 1329 -> { GroupData.id= 1329; name= "Structure Energy Neutralizer"; categoryId= 66; published= true; typeIds= [| 35924; 35925; 46575; 47330; 47332 |] } |> Some
      | 1620 -> { GroupData.id= 1620; name= "Structure Combat Rig M - EW Cap Reduction"; categoryId= 66; published= true; typeIds= [| 37230; 37231 |] } |> Some
      | 165 -> { GroupData.id= 165; name= "Projectile Ammo Blueprint"; categoryId= 9; published= true; typeIds= [| 879; 880; 881; 882; 883; 884; 885; 886; 887; 888; 889; 890; 891; 892; 893; 894; 895; 896; 897; 898; 899; 900; 901; 902; 17665; 17667; 17669; 17671; 17673; 17675; 17677; 17679; 19995; 20003; 28325; 28327; 28329; 28331; 28333; 28335; 28337; 28339; 32802 |] } |> Some
      | 1717 -> { GroupData.id= 1717; name= "Unpublished Structure Modules"; categoryId= 66; published= false; typeIds= [| 35880; 35893; 35895; 35896; 35897; 35898; 35900; 35901; 35904; 35927; 35929; 35930; 35931; 35932; 35933; 35934; 35935; 35936; 35937; 35938; 35939; 35950; 35951; 35952; 35953; 35954; 35955; 35957; 35958; 35961; 35966; 35967; 37963 |] } |> Some
      | 1814 -> { GroupData.id= 1814; name= "♦ Battleship"; categoryId= 11; published= false; typeIds= [| 43561; 43562; 43572; 43573; 43583; 43584; 43594; 43595; 43605; 43606; 43626; 43627; 43643; 43650; 43657; 45055; 45056; 46055; 46057; 46060; 46063; 46069; 46073; 46077; 46081; 46523; 46524; 47198 |] } |> Some
      | 1911 -> { GroupData.id= 1911; name= "Empire Asteroids"; categoryId= 25; published= false; typeIds= [| 46252; 46253; 46254; 46255; 46256; 46257; 46258; 46259 |] } |> Some
      | 2008 -> { GroupData.id= 2008; name= "Mass Entanglers"; categoryId= 7; published= true; typeIds= [| 49099 |] } |> Some
      | 456 -> { GroupData.id= 456; name= "Jaspet"; categoryId= 25; published= true; typeIds= [| 1226; 17448; 17449; 26868; 28406; 28407; 28408; 28621; 46682; 46698 |] } |> Some
      | 553 -> { GroupData.id= 553; name= "Asteroid Angel Cartel Officer"; categoryId= 11; published= false; typeIds= [| 13536; 13538; 13541; 13544 |] } |> Some
      | 650 -> { GroupData.id= 650; name= "Tractor Beam"; categoryId= 7; published= true; typeIds= [| 4250; 4252; 24348; 24620; 24622; 24644 |] } |> Some
      | 68 -> { GroupData.id= 68; name= "Energy Nosferatu"; categoryId= 7; published= true; typeIds= [| 530; 5135; 5137; 5139; 5141; 12257; 12259; 12261; 12263; 13001; 14148; 14150; 14152; 14154; 14156; 14158; 14816; 14818; 14820; 14822; 14824; 14826; 14828; 14830; 15451; 15875; 15877; 15879; 15881; 15883; 15885; 16497; 16499; 16501; 16503; 16505; 16507; 16509; 16511; 19101; 19103; 19105; 19107; 19109; 19111; 19113; 19115; 19117; 19119; 23821; 23824; 23829; 40665; 40666; 40667; 40668; 40669; 40670; 48419; 48423; 48427; 56311 |] } |> Some
      | 747 -> { GroupData.id= 747; name= "Cyber Navigation"; categoryId= 20; published= true; typeIds= [| 3093; 3094; 3095; 3096; 3097; 3100; 3101; 3102; 3103; 3104; 3105; 3108; 3109; 3110; 3111; 3112; 3113; 3116; 3117; 3118; 3119; 3120; 3121; 3124; 13237; 13238; 13239; 13240; 13241; 13242; 13243; 16003; 16004; 16005; 16006; 16008; 16009; 19500; 24663; 24669; 27097; 27098; 27099; 27100; 27101; 27110; 27111; 27112; 27113; 27114; 27115; 33486; 33512 |] } |> Some
      | 844 -> { GroupData.id= 844; name= "Asteroid Rogue Drone Commander Battleship"; categoryId= 11; published= false; typeIds= [| 27722; 27723; 27724; 27725; 27726; 27727; 27728; 27729; 27730; 27731 |] } |> Some
      | 941 -> { GroupData.id= 941; name= "Industrial Command Ship"; categoryId= 6; published= true; typeIds= [| 28606; 33685; 42244 |] } |> Some
      | _ -> None