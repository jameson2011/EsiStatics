namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups54=
    let getGroup id = 
      match id with 
      | 1121 -> { GroupData.id= 1121; name= "Perception Points"; categoryId= 29; published= true; typeIds= [| 32682 |] } |> Some
      | 1218 -> { GroupData.id= 1218; name= "Resource Processing"; categoryId= 16; published= true; typeIds= [| 3385; 3386; 3389; 3390; 3410; 11395; 12180; 12181; 12182; 12183; 12184; 12185; 12186; 12187; 12188; 12189; 12190; 12191; 12192; 12193; 12194; 12195; 12196; 16281; 18025; 22578; 25544; 25863; 28373; 28585; 45746; 45748; 45749; 45750; 46152; 46153; 46154; 46155; 46156; 56631; 56632; 56633 |] } |> Some
      | 1412 -> { GroupData.id= 1412; name= "Amarr Navy Roaming Capital"; categoryId= 11; published= false; typeIds= [| 35819; 50100 |] } |> Some
      | 151 -> { GroupData.id= 151; name= "Energy Neutralizer Blueprint"; categoryId= 9; published= true; typeIds= [| 1109; 12266; 12268; 12270; 12272; 13004; 15795; 15797; 15799; 15801; 15803; 15805; 23816; 23818; 23820; 40672; 40673; 40674; 40675; 40676; 40677 |] } |> Some
      | 1606 -> { GroupData.id= 1606; name= "Structure Laboratory Rig L - Component"; categoryId= 66; published= false; typeIds= [| 37202; 37203 |] } |> Some
      | 1703 -> { GroupData.id= 1703; name= "Burst Projector Blueprint"; categoryId= 9; published= true; typeIds= [| 27679; 41388; 41389; 41390; 41391; 41392; 41393; 41394 |] } |> Some
      | 1800 -> { GroupData.id= 1800; name= "Hidden Zenith Minmatar Frigate"; categoryId= 11; published= false; typeIds= [| 42815 |] } |> Some
      | 1994 -> { GroupData.id= 1994; name= "Advanced Exotic Plasma Charge Blueprint"; categoryId= 9; published= true; typeIds= [| 48100; 48101; 48105; 48106; 48110; 48111 |] } |> Some
      | 345 -> { GroupData.id= 345; name= "Remote Tracking Computer Blueprint"; categoryId= 9; published= true; typeIds= [| 11617; 11851; 15968; 22936; 22938 |] } |> Some
      | 4031 -> { GroupData.id= 4031; name= "Bezdnacine"; categoryId= 25; published= true; typeIds= [| 52316; 56627; 56628 |] } |> Some
      | 54 -> { GroupData.id= 54; name= "Mining Laser"; categoryId= 7; published= true; typeIds= [| 482; 483; 3651; 5231; 5233; 5235; 5237; 5239; 5241; 5243; 5245; 12108; 21841; 22921; 22923; 28369; 28748; 28750; 37450; 37451; 37452 |] } |> Some
      | 733 -> { GroupData.id= 733; name= "Decryptors - Yan Jung"; categoryId= 17; published= true; typeIds= [| 23168; 23169; 23170; 23171; 23172 |] } |> Some
      | 830 -> { GroupData.id= 830; name= "Covert Ops"; categoryId= 6; published= true; typeIds= [| 11172; 11182; 11188; 11192; 33397; 42246; 44993; 48636 |] } |> Some
      | 927 -> { GroupData.id= 927; name= "Mission Faction Industrials"; categoryId= 11; published= false; typeIds= [| 2878; 2883; 2884; 2885; 11714; 16160; 29144; 29145; 29146; 29147; 29290; 29291; 29292; 29293; 29466; 30948; 32348; 32388; 32446; 32447; 32455 |] } |> Some
      | _ -> None