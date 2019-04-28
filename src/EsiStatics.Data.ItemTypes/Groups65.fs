namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups65=
    let getGroup id = 
      match id with 
      | 1035 -> { GroupData.id= 1035; name= "Planet Organic - Raw Resource"; categoryId= 42; published= true; typeIds= [| 2073; 2286; 2287; 2288; 2305 |] } |> Some
      | 1229 -> { GroupData.id= 1229; name= "Cyber Resource Processing"; categoryId= 20; published= true; typeIds= [| 20700; 22534; 22535; 22570; 22571; 27102; 27103; 27149; 27150; 27151; 27169; 27174; 27175; 27238; 27239; 27240 |] } |> Some
      | 1326 -> { GroupData.id= 1326; name= "Structure Advertisement Service Module"; categoryId= 66; published= false; typeIds= [| 37141; 37142; 37143 |] } |> Some
      | 1617 -> { GroupData.id= 1617; name= "Structure Citadel Rig M - Drone Hitpoints"; categoryId= 66; published= false; typeIds= [| 37224; 37225 |] } |> Some
      | 162 -> { GroupData.id= 162; name= "Automated Targeting System Blueprint"; categoryId= 9; published= true; typeIds= [| 1208; 1437 |] } |> Some
      | 2005 -> { GroupData.id= 2005; name= "Deployable Advertisement"; categoryId= 22; published= true; typeIds= [| 48899 |] } |> Some
      | 356 -> { GroupData.id= 356; name= "Tool Blueprint"; categoryId= 9; published= true; typeIds= [| 11857; 11859; 11860; 11861; 11862; 11863; 11864; 11865; 11866; 11867; 11868; 11869; 11870; 11871; 11872; 11873; 11874; 11876; 11877; 11878; 11879; 11880; 11881; 11882; 11883; 11884; 11885; 11886; 11887; 11888; 11889; 11890; 11891; 11892; 20108; 21055; 23888; 24469; 25584; 25585; 25586; 25587; 25852; 25854; 25856; 25858; 26598; 26600; 26602; 26604; 27022; 27024; 27027; 27039; 29227; 30387 |] } |> Some
      | 453 -> { GroupData.id= 453; name= "Dark Ochre"; categoryId= 25; published= true; typeIds= [| 1232; 17436; 17437; 28394; 28395; 28396; 28623; 46675; 46694 |] } |> Some
      | 550 -> { GroupData.id= 550; name= "Asteroid Angel Cartel Frigate"; categoryId= 11; published= false; typeIds= [| 2372; 10013; 10014; 10015; 10016; 10019; 11021; 11022; 11023; 11024; 13032; 13033; 13035; 13036; 16561; 16562; 22005; 22006; 22007; 22008; 22009; 22010; 22011; 22012; 22013; 22014; 22818; 22819; 22834; 22835; 22836; 22837 |] } |> Some
      | 647 -> { GroupData.id= 647; name= "Drone Control Range Module"; categoryId= 7; published= true; typeIds= [| 23527; 24427; 32262; 32927; 32929; 32931; 32933 |] } |> Some
      | 65 -> { GroupData.id= 65; name= "Stasis Web"; categoryId= 7; published= true; typeIds= [| 526; 527; 4025; 4027; 4029; 4031; 14262; 14264; 14266; 14268; 14270; 14648; 14650; 14652; 14654; 15419; 17500; 17559; 28514; 30328; 41038; 47702 |] } |> Some
      | 744 -> { GroupData.id= 744; name= "Cyber Leadership"; categoryId= 20; published= true; typeIds= [| 13209; 21888; 21889; 21890; 22559; 33403; 33404; 33405; 33406; 43775 |] } |> Some
      | 841 -> { GroupData.id= 841; name= "Starbase - Control Tower Blueprints"; categoryId= 9; published= true; typeIds= [| 2774; 2775; 2776; 2777; 2778; 2779; 2780; 2781; 2782; 2783; 2784; 2785; 27677; 27680; 27681; 27682; 27684; 27685; 27688; 27689; 27690; 27694; 27695; 27696; 27697; 27698; 27699; 27703; 27704; 27705; 27706; 27707; 27708; 27712; 27713; 27714; 27781; 27783; 27785; 27787; 27789; 27791 |] } |> Some
      | _ -> None