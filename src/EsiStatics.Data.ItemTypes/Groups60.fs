namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups60=
    let getGroup id = 
      match id with 
      | 1030 -> { GroupData.id= 1030; name= "Spaceports"; categoryId= 41; published= true; typeIds= [| 2256; 2542; 2543; 2544; 2552; 2555; 2556; 2557 |] } |> Some
      | 1224 -> { GroupData.id= 1224; name= "Scanning Upgrade Blueprint"; categoryId= 9; published= true; typeIds= [| 33179; 33181; 33200; 33202 |] } |> Some
      | 1321 -> { GroupData.id= 1321; name= "Structure Citadel Service Module"; categoryId= 66; published= true; typeIds= [| 35892; 35894 |] } |> Some
      | 157 -> { GroupData.id= 157; name= "Shield Hardener Blueprint"; categoryId= 9; published= true; typeIds= [| 1129; 2282; 2290; 2292; 2294; 2296; 2298; 2300; 2302; 2304; 20634; 20636; 20638; 20640; 20642; 30343; 30421; 30423; 30425; 46011 |] } |> Some
      | 1612 -> { GroupData.id= 1612; name= "Structure Laboratory Rig XL - All Components"; categoryId= 66; published= false; typeIds= [| 37214; 37215 |] } |> Some
      | 1709 -> { GroupData.id= 1709; name= "Unpublished Structure Module and Rig Blueprints"; categoryId= 9; published= false; typeIds= [| 36997; 36999; 37000; 37001; 37002; 37003; 37004; 37005; 37006; 37007; 37011; 37012; 37014; 37015; 37021; 37024; 37025; 37026; 37027; 37031; 37033; 37037; 37038; 37039; 37040; 37042; 37046; 37049; 37050; 37051; 37052; 37053; 37054; 37058; 37061; 37062; 37063; 37064; 37065; 37067; 37068; 37069; 37071; 37072; 37073; 37074; 37075; 37076; 37077; 37078; 37079; 37084; 37085; 37138; 37139; 37140; 37323; 37324; 37325; 37326; 37327; 37336; 37337; 37340; 37341; 37386; 37387; 37388; 37389; 37398; 37399; 37400; 37401; 37402; 37403; 37404; 37405; 37406; 37407; 37408; 37409; 37415; 37416; 37425; 37426; 37427; 37428; 37429; 37430; 37433; 37434; 37441; 37442; 37443; 37444; 37445; 37446; 37447; 37448; 37964; 41430; 41431; 41432; 41433; 41434; 41435; 41436; 41437 |] } |> Some
      | 1806 -> { GroupData.id= 1806; name= "Hidden Zenith Gallente Capital"; categoryId= 11; published= false; typeIds= [| 42848 |] } |> Some
      | 448 -> { GroupData.id= 448; name= "Audit Log Secure Container"; categoryId= 2; published= true; typeIds= [| 17363; 17364; 17365; 17366; 17367; 17368 |] } |> Some
      | 545 -> { GroupData.id= 545; name= "Warp Scrambling Drone"; categoryId= 18; published= false; typeIds= [| 22574; 22713 |] } |> Some
      | 60 -> { GroupData.id= 60; name= "Damage Control"; categoryId= 7; published= true; typeIds= [| 521; 2046; 2048; 5829; 5831; 5833; 5835; 5837; 5839; 5841; 5843; 22893; 23418; 30839; 40714; 40715; 40716; 40717; 40718; 41200; 41201; 41202; 41203; 41204; 41205; 41206; 41207; 41208; 41210; 41211; 47254; 47255; 47256; 47257; 47258 |] } |> Some
      | 642 -> { GroupData.id= 642; name= "Super Gang Enhancer"; categoryId= 7; published= false; typeIds= [|  |] } |> Some
      | 739 -> { GroupData.id= 739; name= "Cyber Drones"; categoryId= 20; published= true; typeIds= [| 48148; 48149; 48746; 48747 |] } |> Some
      | 836 -> { GroupData.id= 836; name= "Station Improvement Platform"; categoryId= 2; published= true; typeIds= [| 27662; 27664; 27666; 27937; 27939; 27941; 27957; 27959; 27961; 27963; 27965; 27967; 27969; 27971; 27973; 27975; 27977; 27979; 27981; 27983; 27985; 27987; 27989; 27991; 27993; 27995; 27997; 27999; 28001; 28003; 28005; 28007; 28009; 28011; 28013; 28015; 28017; 28019; 28021; 28023; 28025; 28027; 28029; 28031; 28033; 28035; 28037; 28039; 28041; 28043; 28045; 28047; 28049; 28051; 28053; 28055; 28057; 28059; 28061; 28063 |] } |> Some
      | _ -> None