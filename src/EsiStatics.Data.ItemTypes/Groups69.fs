namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups69=
    let getGroup id = 
      match id with 
      | 1136 -> { GroupData.id= 1136; name= "Fuel Block"; categoryId= 4; published= true; typeIds= [| 4051; 4246; 4247; 4312; 36945 |] } |> Some
      | 1233 -> { GroupData.id= 1233; name= "Rig Scanning"; categoryId= 7; published= true; typeIds= [| 25930; 25932; 25936; 26104; 26342; 26346; 26350; 26362; 31201; 31203; 31205; 31207; 31209; 31211; 31213; 31215; 31217; 31220; 31222; 31224; 31238; 31240; 31242; 31244; 31246; 31248; 31310; 31312; 31314; 31316; 31318; 31320 |] } |> Some
      | 1330 -> { GroupData.id= 1330; name= "Structure Area Denial Module"; categoryId= 66; published= true; typeIds= [| 35926; 47327 |] } |> Some
      | 1621 -> { GroupData.id= 1621; name= "Structure Combat Rig M - Max Targets"; categoryId= 66; published= true; typeIds= [| 37232; 37233 |] } |> Some
      | 166 -> { GroupData.id= 166; name= "Missile Blueprint"; categoryId= 9; published= true; typeIds= [| 803; 804; 805; 806; 807; 808; 809; 810; 811; 812; 813; 814; 1216; 1220; 1221; 1811; 1815; 1817; 1819; 1821; 1823; 1825; 1827; 1829; 1831; 1833; 2179; 2211; 2213; 2507; 2509; 2511; 2513; 2515; 2517; 2614; 2622; 2630; 2638; 2648; 2656; 2680; 2802; 2812; 2818; 17858; 17860; 17862; 17864; 21868; 24472; 24474; 24476; 24487; 24489; 24491; 24496; 24498; 24500; 24502; 24504; 24506; 24508; 24510; 24512; 24514; 24516; 24518; 24520; 24522; 24524; 24526; 24528; 24530; 24532; 24534; 24536; 24538; 24540; 24542; 24543; 24544; 24604; 24605; 24614; 24615; 24616; 24617; 26760; 26761; 26762; 32437; 32439; 32441; 32443; 37852; 37853; 37854; 37855; 37856; 37857; 37858; 37859; 37860; 41278; 41279; 41280; 41281; 41282; 41283; 41284; 41285; 41288; 41289; 41292; 41293; 41296; 41297; 41300; 41301 |] } |> Some
      | 1718 -> { GroupData.id= 1718; name= "Force Auxiliary Blueprint"; categoryId= 9; published= true; typeIds= [| 41582; 41583; 41584; 41585; 42135; 45043; 45644 |] } |> Some
      | 1815 -> { GroupData.id= 1815; name= "Titan Phenomena Generator"; categoryId= 7; published= true; typeIds= [| 43658; 43660; 43662; 43664 |] } |> Some
      | 1912 -> { GroupData.id= 1912; name= "Structure Drilling Rig M - Efficiency"; categoryId= 66; published= true; typeIds= [| 46323; 46324 |] } |> Some
      | 2009 -> { GroupData.id= 2009; name= "Precursor Cache"; categoryId= 11; published= false; typeIds= [| 47951; 49661; 49662; 49663; 49689; 49690 |] } |> Some
      | 360 -> { GroupData.id= 360; name= "Shield Boost Amplifier Blueprint"; categoryId= 9; published= true; typeIds= [| 11562; 15906; 15908; 20614; 24444 |] } |> Some
      | 457 -> { GroupData.id= 457; name= "Kernite"; categoryId= 25; published= true; typeIds= [| 20; 17452; 17453; 28409; 28410; 28411; 28620; 46683; 46699 |] } |> Some
      | 554 -> { GroupData.id= 554; name= "Asteroid Angel Cartel Hauler"; categoryId= 11; published= false; typeIds= [| 13678; 13679; 13680; 13681; 13682; 13683; 13684; 13685; 13686; 13687; 13688; 13689; 22025; 22026; 22027; 22028; 35679 |] } |> Some
      | 651 -> { GroupData.id= 651; name= "Super Weapon Blueprint"; categoryId= 9; published= true; typeIds= [| 24549; 24551; 24553; 24555; 41395; 41438; 41445; 41446; 41447; 41448; 41449; 41450; 41451; 41452; 41532; 42889 |] } |> Some
      | 748 -> { GroupData.id= 748; name= "Cyber Science"; categoryId= 20; published= true; typeIds= [| 27176; 27177; 27178; 27179; 27180; 27181; 27182; 27184; 27185; 27264; 27265; 27267; 27268 |] } |> Some
      | 845 -> { GroupData.id= 845; name= "Asteroid Rogue Drone Commander Cruiser"; categoryId= 11; published= false; typeIds= [| 27738; 27739; 27740; 27741; 27742; 27743; 27744; 27745; 27746; 27747 |] } |> Some
      | _ -> None