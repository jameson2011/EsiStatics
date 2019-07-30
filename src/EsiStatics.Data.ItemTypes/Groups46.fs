namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups46=
    let getGroup id = 
      match id with 
      | 1016 -> { GroupData.id= 1016; name= "Strategic Upgrades"; categoryId= 39; published= true; typeIds= [| 2001; 2008; 2009; 32422 |] } |> Some
      | 1210 -> { GroupData.id= 1210; name= "Armor"; categoryId= 16; published= true; typeIds= [| 3392; 3393; 3394; 16069; 21803; 22806; 22807; 22808; 22809; 24568; 27902; 27936; 33078 |] } |> Some
      | 1307 -> { GroupData.id= 1307; name= "Roaming Sleepers Cruiser"; categoryId= 11; published= true; typeIds= [| 34337 |] } |> Some
      | 1404 -> { GroupData.id= 1404; name= "Engineering Complex"; categoryId= 65; published= true; typeIds= [| 35825; 35826; 35827 |] } |> Some
      | 143 -> { GroupData.id= 143; name= "Hull Repair Unit Blueprint"; categoryId= 9; published= true; typeIds= [| 1100; 2356; 3654; 3656; 3664; 3666; 21505; 21507; 21509; 41627; 41628; 41629; 41630 |] } |> Some
      | 1598 -> { GroupData.id= 1598; name= "Structure Laboratory Rig M - Small Ship"; categoryId= 66; published= false; typeIds= [| 37184; 37185 |] } |> Some
      | 1695 -> { GroupData.id= 1695; name= "OLD Structure Resource Rig M - Ice 2 Reprocessing"; categoryId= 66; published= false; typeIds= [| 41426; 41427 |] } |> Some
      | 1792 -> { GroupData.id= 1792; name= "Hidden Zenith Caldari Battleship "; categoryId= 11; published= false; typeIds= [| 42820 |] } |> Some
      | 1889 -> { GroupData.id= 1889; name= "Polymer Reaction Formulas"; categoryId= 9; published= true; typeIds= [| 46157; 46158; 46159; 46160; 46161; 46162; 46163; 46164; 46165 |] } |> Some
      | 1986 -> { GroupData.id= 1986; name= "Precursor Weapon"; categoryId= 7; published= true; typeIds= [| 47272; 47273; 47274; 47912; 47913; 47914; 47915; 47916; 47917; 47918; 47919; 47920; 47921; 47922; 47923; 52236; 52238; 52240 |] } |> Some
      | 337 -> { GroupData.id= 337; name= "Mission Drone"; categoryId= 11; published= false; typeIds= [| 15395; 16102; 16104; 24754 |] } |> Some
      | 46 -> { GroupData.id= 46; name= "Propulsion Module"; categoryId= 7; published= true; typeIds= [| 434; 438; 439; 440; 5945; 5955; 5971; 5973; 5975; 6001; 6003; 6005; 12052; 12054; 12056; 12058; 12066; 12068; 12076; 12084; 14102; 14104; 14106; 14108; 14110; 14112; 14114; 14116; 14118; 14120; 14122; 14124; 14484; 14486; 14488; 14490; 14492; 14494; 14496; 14498; 14500; 14502; 14504; 14506; 14508; 14510; 14512; 14514; 15747; 15749; 15751; 15753; 15755; 15757; 15759; 15761; 15764; 15766; 15768; 15770; 18658; 18660; 18662; 18664; 18666; 18668; 18670; 18672; 18674; 18676; 18680; 18682; 18684; 18686; 18688; 18690; 18692; 18694; 18696; 18698; 19313; 19315; 19317; 19319; 19321; 19323; 19325; 19327; 19329; 19335; 19337; 19339; 19341; 19343; 19345; 19347; 19349; 19351; 19353; 19359; 19491; 21470; 21472; 21474; 21476; 21478; 21480; 21857; 35656; 35657; 35658; 35659; 35660; 35661; 35662; 41236; 41237; 41238; 41239; 41240; 41241; 41249; 41250; 41251; 41252; 41253; 41254; 41255; 47408; 47740; 47745; 47749; 47753; 47757 |] } |> Some
      | 725 -> { GroupData.id= 725; name= "Advanced Projectile Ammo Blueprint"; categoryId= 9; published= true; typeIds= [| 12609; 12626; 12628; 12630; 12632; 12634; 12762; 12764; 12766; 12768; 12770; 12772; 12774; 12776; 12778; 12780; 12782; 12784; 41315; 41317; 41319; 41321 |] } |> Some
      | 822 -> { GroupData.id= 822; name= "Mission Thukker Battlecruiser"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | _ -> None