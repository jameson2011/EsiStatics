namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups17=
    let getGroup id = 
      match id with 
      | 1084 -> { GroupData.id= 1084; name= "Tattoos"; categoryId= 30; published= true; typeIds= [| 33377; 33378; 33379; 33380; 33381; 33382; 33383; 33384; 33995; 33996; 33997; 33998; 33999; 34000; 34001; 34002; 34003; 34004; 34005; 34006; 34007; 34008; 34009; 34010; 34011; 34012; 34013; 34014; 34015; 34016 |] } |> Some
      | 1181 -> { GroupData.id= 1181; name= "FW Gallente Federation Cruiser"; categoryId= 11; published= true; typeIds= [| 32969 |] } |> Some
      | 1569 -> { GroupData.id= 1569; name= "Guidance Disruption Script"; categoryId= 8; published= true; typeIds= [| 40334; 40335 |] } |> Some
      | 1666 -> { GroupData.id= 1666; name= "Irregular Battlecruiser"; categoryId= 11; published= false; typeIds= [| 36941; 38657; 42129; 42514; 47721; 48959; 49537; 53523; 53943; 53944; 54664; 55022; 55023; 56654; 56671; 56799; 56874 |] } |> Some
      | 17 -> { GroupData.id= 17; name= "Money"; categoryId= 4; published= true; typeIds= [| 29; 52996 |] } |> Some
      | 1860 -> { GroupData.id= 1860; name= "Structure Engineering Rig L - Advanced Component Efficiency"; categoryId= 66; published= true; typeIds= [| 37174; 37175; 45641 |] } |> Some
      | 211 -> { GroupData.id= 211; name= "Tracking Enhancer"; categoryId= 7; published= true; typeIds= [| 1951; 1998; 1999; 6321; 6322; 6323; 6324; 6325; 6326; 6327; 6328; 14100; 14640; 14642; 14644; 14646; 15965 |] } |> Some
      | 308 -> { GroupData.id= 308; name= "Countermeasure Launcher"; categoryId= 7; published= false; typeIds= [| 10642 |] } |> Some
      | 405 -> { GroupData.id= 405; name= "Anti Cloaking Pulse"; categoryId= 7; published= false; typeIds= [|  |] } |> Some
      | 502 -> { GroupData.id= 502; name= "Cosmic Signature"; categoryId= 2; published= false; typeIds= [| 19728; 25880 |] } |> Some
      | 696 -> { GroupData.id= 696; name= "Mission CONCORD Battlecruiser"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 793 -> { GroupData.id= 793; name= "Asteroid Angel Cartel Commander BattleCruiser"; categoryId= 11; published= false; typeIds= [| 22865; 22866; 22867; 22868; 22869; 22870 |] } |> Some
      | 890 -> { GroupData.id= 890; name= "Ice Compression Blueprints"; categoryId= 9; published= true; typeIds= [| 28494; 28495; 28496; 28497; 28498; 28499; 28500; 28501; 28502; 28503; 28504; 28505 |] } |> Some
      | 987 -> { GroupData.id= 987; name= "Deadspace Sleeper Emergent Patroller"; categoryId= 11; published= false; typeIds= [| 30209; 30210; 30211 |] } |> Some
      | _ -> None