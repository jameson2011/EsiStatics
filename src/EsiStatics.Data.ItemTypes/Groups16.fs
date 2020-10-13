namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups16=
    let getGroup id = 
      match id with 
      | 1083 -> { GroupData.id= 1083; name= "Eyewear"; categoryId= 30; published= true; typeIds= [| 3958; 4009; 4037; 4038; 4039; 4042; 4043; 4046; 4048; 4050; 4052; 32853; 33992; 33993; 40344; 41575; 41576; 42905; 42906; 45736; 45745; 52317; 54965; 54966; 55004; 55005 |] } |> Some
      | 1180 -> { GroupData.id= 1180; name= "FW Caldari State Cruiser"; categoryId= 11; published= true; typeIds= [| 32968 |] } |> Some
      | 1277 -> { GroupData.id= 1277; name= "Encounter Surveillance System Blueprint"; categoryId= 9; published= true; typeIds= [| 33586; 33596; 33609; 33611 |] } |> Some
      | 1568 -> { GroupData.id= 1568; name= "Irregular Frigate"; categoryId= 11; published= false; typeIds= [| 36939; 38659; 40725; 42127; 42512; 46344; 47715; 47717; 48129; 48904; 48905; 48906; 48907; 48940; 48941; 48942; 48955; 49534; 49763; 49807; 53528; 53926; 53927; 53928; 53929; 53930; 53931; 53932; 53933; 54276; 54277; 54278; 54279; 54280; 54281; 54282; 54284; 54285; 54661; 54665; 54674; 54677; 54680; 55016; 55017; 56644; 56645; 56646; 56648; 56649; 56650 |] } |> Some
      | 16 -> { GroupData.id= 16; name= "Station Services"; categoryId= 3; published= false; typeIds= [| 26; 27; 28 |] } |> Some
      | 1665 -> { GroupData.id= 1665; name= "Irregular Cruiser"; categoryId= 11; published= false; typeIds= [| 36940; 38658; 40726; 42128; 42513; 46343; 46346; 46347; 47719; 47720; 47722; 48130; 48900; 48901; 48937; 48938; 48939; 48956; 49536; 49764; 52797; 53524; 53525; 53526; 53936; 53937; 53938; 53939; 53940; 53941; 53942; 54288; 54289; 54290; 54662; 54670; 54672; 54675; 54676; 54679; 54681; 55020; 55021; 56647; 56651; 56652; 56653; 56670 |] } |> Some
      | 1762 -> { GroupData.id= 1762; name= "Irregular Mining Barge"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 1859 -> { GroupData.id= 1859; name= "Structure Engineering Rig L - Capital Ship Efficiency"; categoryId= 66; published= true; typeIds= [| 37172; 37173 |] } |> Some
      | 1956 -> { GroupData.id= 1956; name= "Drifter Reinforcements"; categoryId= 11; published= false; typeIds= [| 47153; 47459 |] } |> Some
      | 210 -> { GroupData.id= 210; name= "Signal Amplifier"; categoryId= 7; published= true; typeIds= [| 1949; 1986; 1987; 6293; 6294; 6295; 6296; 6309; 6310; 6311; 6312; 21527; 41196; 41197 |] } |> Some
      | 307 -> { GroupData.id= 307; name= "Construction Platform"; categoryId= 2; published= true; typeIds= [| 10257; 10258; 10260; 19758 |] } |> Some
      | 404 -> { GroupData.id= 404; name= "Silo"; categoryId= 23; published= true; typeIds= [| 14343; 17764; 17982; 25270; 25271; 25280; 25821; 28314; 28315; 28316; 28317; 28884; 30655 |] } |> Some
      | 501 -> { GroupData.id= 501; name= "Festival Launcher"; categoryId= 7; published= true; typeIds= [| 19660; 44109 |] } |> Some
      | 695 -> { GroupData.id= 695; name= "Mission CONCORD Cruiser"; categoryId= 11; published= false; typeIds= [| 16110; 16111; 16112; 16114; 16115; 33805 |] } |> Some
      | 792 -> { GroupData.id= 792; name= "Asteroid Blood Raiders Commander Frigate"; categoryId= 11; published= false; typeIds= [| 13545; 13546; 13554; 13555; 13558; 13566; 13567; 13568; 13571; 13574; 24390; 24391; 24392; 24393; 24394; 24408 |] } |> Some
      | 889 -> { GroupData.id= 889; name= "Ore Enhancement Blueprints"; categoryId= 9; published= false; typeIds= [|  |] } |> Some
      | 986 -> { GroupData.id= 986; name= "Deadspace Sleeper Emergent Defender"; categoryId= 11; published= false; typeIds= [| 30212; 30213; 30214 |] } |> Some
      | _ -> None