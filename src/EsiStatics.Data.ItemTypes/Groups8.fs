namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups8=
    let getGroup id = 
      match id with 
      | 105 -> { GroupData.id= 105; name= "Frigate Blueprint"; categoryId= 9; published= true; typeIds= [| 683; 684; 685; 689; 690; 691; 935; 936; 937; 938; 939; 940; 941; 943; 944; 945; 946; 947; 948; 949; 950; 952; 953; 954; 955; 956; 960; 961; 962; 963; 964; 965; 966; 2162; 2835; 3517; 3533; 3752; 3754; 3767; 3769; 11173; 11175; 11177; 11179; 11183; 11185; 11187; 11189; 11191; 11193; 11195; 11197; 11199; 11201; 11203; 11366; 11372; 11374; 11376; 11378; 11380; 11382; 11384; 11388; 11390; 11394; 11401; 12031; 12035; 12037; 12041; 12043; 12045; 17620; 17704; 17706; 17708; 17813; 17842; 17925; 17927; 17929; 17931; 17933; 29249; 32208; 32789; 32881; 32984; 32986; 32988; 32990; 33080; 33082; 33084; 33191; 33398; 33469; 33656; 33658; 33660; 33662; 33664; 33666; 33668; 33670; 33674; 33678; 33698; 33817; 34444; 35780; 39580; 39581; 39583; 40301; 40302; 40315; 40316; 40317; 40318; 42525; 45486; 45533; 47966; 48638; 52251 |] } |> Some
      | 1269 -> { GroupData.id= 1269; name= "Mobile Depot Blueprint"; categoryId= 9; published= true; typeIds= [| 33517; 33521; 33523 |] } |> Some
      | 1657 -> { GroupData.id= 1657; name= "Citadel"; categoryId= 65; published= true; typeIds= [| 35832; 35833; 35834; 40340; 47512; 47513; 47514; 47515; 47516 |] } |> Some
      | 1851 -> { GroupData.id= 1851; name= "Structure Engineering Rig L - Ammunition Efficiency"; categoryId= 66; published= true; typeIds= [| 37164; 37165 |] } |> Some
      | 1948 -> { GroupData.id= 1948; name= "Cyber Scanning Implant Blueprints"; categoryId= 9; published= true; typeIds= [| 47040 |] } |> Some
      | 202 -> { GroupData.id= 202; name= "ECCM"; categoryId= 7; published= true; typeIds= [| 1947; 2002; 2003; 2004; 2005; 2258; 2259; 2260; 2261; 2262; 7867; 7869; 7870; 7887; 7889; 7892; 7893; 7895; 7896; 7914; 7917; 7918; 7922; 7926; 7937; 7948; 7964; 7965; 7966; 7970; 20214; 20216; 20218; 20220; 20222; 20224; 20226; 20228; 20230; 20232; 20234; 20236; 22897 |] } |> Some
      | 299 -> { GroupData.id= 299; name= "Repair Drone"; categoryId= 18; published= false; typeIds= [| 9871 |] } |> Some
      | 396 -> { GroupData.id= 396; name= "Auto-Targeting Cruise Missile"; categoryId= 8; published= true; typeIds= [| 1826; 1828; 1830; 1832; 27457; 27459; 27461; 27463; 27465; 27467; 27469; 27471; 27473; 27475; 27477; 27479 |] } |> Some
      | 493 -> { GroupData.id= 493; name= "Overseer Personal Effects"; categoryId= 17; published= true; typeIds= [| 19400; 19401; 19402; 19403; 19404; 19405; 19406; 19407; 19408; 19409; 19410; 19411; 19412; 19413; 19414; 19415; 19416; 19417; 19418; 19419; 19420; 19421; 19422 |] } |> Some
      | 590 -> { GroupData.id= 590; name= "Jump Portal Generator"; categoryId= 7; published= true; typeIds= [| 23953; 28652 |] } |> Some
      | 687 -> { GroupData.id= 687; name= "Mission Khanid Frigate"; categoryId= 11; published= false; typeIds= [| 11947; 12029; 16171; 16172; 16178; 16212; 29200; 29201 |] } |> Some
      | 784 -> { GroupData.id= 784; name= "Large Collidable Ship"; categoryId= 11; published= false; typeIds= [| 25829 |] } |> Some
      | 8 -> { GroupData.id= 8; name= "Moon"; categoryId= 2; published= false; typeIds= [| 14 |] } |> Some
      | 881 -> { GroupData.id= 881; name= "Freedom Programs"; categoryId= 24; published= false; typeIds= [| 28320 |] } |> Some
      | _ -> None