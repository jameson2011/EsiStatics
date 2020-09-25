namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups66=
    let getGroup id = 
      match id with 
      | 1036 -> { GroupData.id= 1036; name= "Planetary Links"; categoryId= 41; published= true; typeIds= [| 2280 |] } |> Some
      | 1230 -> { GroupData.id= 1230; name= "Cyber Scanning"; categoryId= 20; published= true; typeIds= [| 27186; 27187; 27188; 27190; 27191; 27192; 27193; 27194; 27195; 27196; 27197; 27198; 27260; 47028 |] } |> Some
      | 1327 -> { GroupData.id= 1327; name= "Structure XL Missile Launcher"; categoryId= 66; published= true; typeIds= [| 35921; 47323 |] } |> Some
      | 1618 -> { GroupData.id= 1618; name= "Structure Citadel Rig M - Drone Speed"; categoryId= 66; published= false; typeIds= [| 37226; 37227 |] } |> Some
      | 163 -> { GroupData.id= 163; name= "Armor Coating Blueprint"; categoryId= 9; published= true; typeIds= [| 1204; 1205; 1265; 1267; 1275; 1277; 1285; 1287; 1295; 1297; 1305; 1307; 11216; 11218; 11220; 11226; 11228; 11230; 11236; 11238; 11240; 11246; 11248; 11250; 11256; 11258; 11260; 11266; 11268; 11270; 15686; 15688; 15690; 15692; 15694; 15696; 15698; 15700; 15702; 15704; 15722; 15724; 15726; 15728; 15730; 15732; 15734; 15736; 15738; 15740; 17513; 17515; 17517; 17519; 17537; 17539; 17541; 17543; 17545; 17550; 17552; 17554; 17556; 17558; 22880; 22882; 22884; 28521; 28535; 28537; 28539; 28541; 28543; 28548; 28553; 28555; 28560; 32810; 46013; 55861; 55863 |] } |> Some
      | 1812 -> { GroupData.id= 1812; name= "Command Burst Blueprint"; categoryId= 9; published= true; typeIds= [| 43544; 43545; 43546; 43547; 43548; 43607; 43608; 43609; 43610; 43611; 43659; 43661; 43663; 43665 |] } |> Some
      | 1909 -> { GroupData.id= 1909; name= "♦ Battlecruiser"; categoryId= 11; published= false; typeIds= [| 46068; 46072; 46076; 46080 |] } |> Some
      | 2006 -> { GroupData.id= 2006; name= "Deadspace Asteroids"; categoryId= 25; published= false; typeIds= [| 48916; 48917; 48918; 48919 |] } |> Some
      | 357 -> { GroupData.id= 357; name= "DroneBayExpander"; categoryId= 7; published= false; typeIds= [|  |] } |> Some
      | 364204 -> { GroupData.id= 364204; name= "Surface Infrastructure"; categoryId= 350001; published= false; typeIds= [| 364205; 364206; 364207 |] } |> Some
      | 368666 -> { GroupData.id= 368666; name= "Warbarge"; categoryId= 350001; published= false; typeIds= [| 368497 |] } |> Some
      | 454 -> { GroupData.id= 454; name= "Hedbergite"; categoryId= 25; published= true; typeIds= [| 21; 17440; 17441; 28400; 28401; 28402; 46680; 46696 |] } |> Some
      | 551 -> { GroupData.id= 551; name= "Asteroid Angel Cartel Cruiser"; categoryId= 11; published= false; typeIds= [| 10017; 10018; 11025; 11026; 11894; 11895; 11896; 11897; 22820; 22821; 22828; 22829; 22830; 22831; 22832; 22833; 23638; 23639; 23640; 23641; 33132; 33143; 33173; 33175 |] } |> Some
      | 648 -> { GroupData.id= 648; name= "Advanced Rocket"; categoryId= 8; published= true; typeIds= [| 2817; 13119; 24471; 24473; 24475; 24477; 24478; 24479 |] } |> Some
      | 745 -> { GroupData.id= 745; name= "Cyber Learning"; categoryId= 20; published= true; typeIds= [| 9899; 9941; 9942; 9943; 9956; 10208; 10209; 10210; 10211; 10212; 10213; 10214; 10215; 10216; 10217; 10218; 10219; 10221; 10222; 10223; 10224; 10225; 10226; 10227; 13283; 13284; 13285; 13286; 13287; 14295; 14296; 14297; 14298; 14299 |] } |> Some
      | 842 -> { GroupData.id= 842; name= "Burst Projectors"; categoryId= 7; published= true; typeIds= [| 27678; 40635; 40636; 40696; 40697; 40698; 40699; 40700; 41350 |] } |> Some
      | _ -> None