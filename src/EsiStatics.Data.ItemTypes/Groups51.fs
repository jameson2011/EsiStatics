namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups51=
    let getGroup id = 
      match id with 
      | 1021 -> { GroupData.id= 1021; name= "Military Upgrades"; categoryId= 39; published= true; typeIds= [| 2026; 2027; 2028; 2029; 2030; 2031; 2034; 2035; 2036; 2037; 2058; 2059; 2060; 2061; 2062 |] } |> Some
      | 1118 -> { GroupData.id= 1118; name= "Surface Infrastructure Prefab Units"; categoryId= 17; published= false; typeIds= [| 4093 |] } |> Some
      | 1312 -> { GroupData.id= 1312; name= "Observatory Structures"; categoryId= 22; published= true; typeIds= [|  |] } |> Some
      | 1409 -> { GroupData.id= 1409; name= "Administration Hub"; categoryId= 65; published= false; typeIds= [| 35842; 35843; 35844 |] } |> Some
      | 148 -> { GroupData.id= 148; name= "Energy Nosferatu Blueprint"; categoryId= 9; published= true; typeIds= [| 1106; 12258; 12260; 12262; 12264; 13002; 15876; 15878; 15880; 15882; 15884; 15886; 23822; 23825; 23830; 40684; 40685; 40686; 40687; 40688; 40689 |] } |> Some
      | 1603 -> { GroupData.id= 1603; name= "Structure Laboratory Rig M - Module"; categoryId= 66; published= false; typeIds= [| 37194; 37195 |] } |> Some
      | 1700 -> { GroupData.id= 1700; name= "Flex Shield Hardener"; categoryId= 7; published= true; typeIds= [| 41516; 41528; 41529; 41530; 41531 |] } |> Some
      | 1797 -> { GroupData.id= 1797; name= "Hidden Zenith Gallente Frigate"; categoryId= 11; published= false; typeIds= [| 42825 |] } |> Some
      | 1894 -> { GroupData.id= 1894; name= "Non-Repeating Hardeners"; categoryId= 7; published= false; typeIds= [| 46010; 46012 |] } |> Some
      | 1991 -> { GroupData.id= 1991; name= "Abyssal Trace"; categoryId= 2; published= false; typeIds= [| 47458; 47833; 47834; 48964; 53451; 55834; 56693; 56879 |] } |> Some
      | 342 -> { GroupData.id= 342; name= "Anti Warp Scrambler Blueprint"; categoryId= 9; published= true; typeIds= [| 11613; 11641; 22876; 22878 |] } |> Some
      | 367487 -> { GroupData.id= 367487; name= "Services "; categoryId= 350001; published= false; typeIds= [| 367499; 367596; 367597; 367598; 367843; 367845 |] } |> Some
      | 4028 -> { GroupData.id= 4028; name= "Triglavian Entities"; categoryId= 11; published= false; typeIds= [| 52182; 52183; 52184; 52185; 52186; 52187; 52205; 52206; 52207; 52208; 52209; 52210; 52211; 52212; 52213; 52214; 52215; 52216; 52217; 52218; 52232; 52233; 52234; 52320; 52336; 52337; 52338; 52473; 52474; 52475; 52478; 52479; 52480; 52481; 52482; 52483; 52484; 52485; 52486; 52487; 52488; 52489; 52490; 52491; 52492; 52493; 52494; 52495; 52496; 52497; 52498; 52499; 52500; 52501; 52502; 52503; 52645; 52646; 52647; 52648; 52649; 52650; 52651; 52652; 52653; 52654; 52655; 52656; 52657; 52658; 52659; 52692; 52701; 52815; 53390; 54108; 54109; 54110; 54111; 54112; 54113; 54114; 54115; 54116; 54117; 54118; 54119; 54120; 54121; 54122; 54123; 54124; 54125; 54126; 54127; 54128; 54129; 54130; 54131; 54132; 54133; 54134; 54135; 54136; 54137; 54138; 54139; 54140; 54141; 54142; 54143; 54144; 54145; 54146; 54147; 54148; 54149; 54150; 54151; 54152; 54153; 54154; 54155; 54199; 54200; 54201; 54202; 54203; 54204; 54205; 54206; 54207; 54208; 54209; 54210; 54211; 54212; 54213; 54214; 54568; 54569; 54570 |] } |> Some
      | 439 -> { GroupData.id= 439; name= "Electronic Warfare Battery"; categoryId= 23; published= true; typeIds= [| 17174; 17175; 17176; 17177; 27574; 27576; 27577; 27579; 27580; 27582; 27583; 27585 |] } |> Some
      | 536 -> { GroupData.id= 536; name= "Structure Components"; categoryId= 17; published= true; typeIds= [| 21947; 21949; 21951; 21953; 21955; 21957; 21959; 21961; 21963; 21965; 21967; 21969; 36956; 36957; 36958; 49720 |] } |> Some
      | 633 -> { GroupData.id= 633; name= "Deadspace Serpentis Frigate"; categoryId= 11; published= false; typeIds= [| 2126; 16569; 17035; 17040; 17041; 17043; 17113; 17115; 17116; 17117; 17118; 17119; 17120; 17121; 17122; 17126; 17128; 17129; 17130; 17131; 17132; 17133; 17134; 17278; 17279; 17280; 17281; 24057; 24058; 24059; 24060; 24061; 24062 |] } |> Some
      | 730 -> { GroupData.id= 730; name= "Decryptors - Gallente"; categoryId= 35; published= true; typeIds= [| 23183; 23184; 23185; 23186; 23187; 33320; 33323; 33326 |] } |> Some
      | 827 -> { GroupData.id= 827; name= "Mission Thukker Other"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 924 -> { GroupData.id= 924; name= "Mission Faction Battleship"; categoryId= 11; published= false; typeIds= [| 29236; 29237; 29240; 29243; 32784 |] } |> Some
      | _ -> None