namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups18=
    let getGroup id = 
      match id with 
      | 1085 -> { GroupData.id= 1085; name= "Piercings"; categoryId= 30; published= false; typeIds= [|  |] } |> Some
      | 1182 -> { GroupData.id= 1182; name= "FW Minmatar Republic Cruiser"; categoryId= 11; published= true; typeIds= [| 32970 |] } |> Some
      | 1570 -> { GroupData.id= 1570; name= "Structure Assembly Rig M - Small Tech I Ship"; categoryId= 66; published= false; typeIds= [|  |] } |> Some
      | 1667 -> { GroupData.id= 1667; name= "Irregular Battleship"; categoryId= 11; published= false; typeIds= [| 40727; 40728; 42238; 46348; 46349; 47275; 47723; 47724; 48131; 48799; 48800; 48801; 48936; 48957; 49118; 49120; 49122; 49124; 49765; 53520; 53945; 53946; 53947; 53948; 55024; 55026; 55027 |] } |> Some
      | 1764 -> { GroupData.id= 1764; name= "♦ Mining Frigate"; categoryId= 11; published= false; typeIds= [| 42533 |] } |> Some
      | 18 -> { GroupData.id= 18; name= "Mineral"; categoryId= 4; published= true; typeIds= [| 34; 35; 36; 37; 38; 39; 40; 11399; 27029; 48927 |] } |> Some
      | 1861 -> { GroupData.id= 1861; name= "Structure Engineering Rig L - Basic Capital Component Efficiency"; categoryId= 66; published= true; typeIds= [| 43718; 43719; 45546 |] } |> Some
      | 212 -> { GroupData.id= 212; name= "Sensor Booster"; categoryId= 7; published= true; typeIds= [| 1952; 1973; 6157; 6158; 6159; 6160; 14236; 15276; 15278; 15280; 15282; 17520; 22895; 41191; 41192; 41193; 41194; 41195 |] } |> Some
      | 309 -> { GroupData.id= 309; name= "Autopilot"; categoryId= 7; published= false; typeIds= [|  |] } |> Some
      | 406 -> { GroupData.id= 406; name= "Smartbomb Supercharger"; categoryId= 7; published= false; typeIds= [|  |] } |> Some
      | 503 -> { GroupData.id= 503; name= "Elite Industrial Blueprint"; categoryId= 9; published= true; typeIds= [| 12730; 12732; 12734; 12736; 12744; 12746; 12748; 12754 |] } |> Some
      | 697 -> { GroupData.id= 697; name= "Mission CONCORD Battleship"; categoryId= 11; published= false; typeIds= [| 16116; 16117; 16615; 16616; 29228; 33806 |] } |> Some
      | 794 -> { GroupData.id= 794; name= "Asteroid Angel Cartel Commander Destroyer"; categoryId= 11; published= false; typeIds= [| 22857; 22858; 22859; 22860; 22861; 22862 |] } |> Some
      | 891 -> { GroupData.id= 891; name= "Starbase - Mobile Laboratory Blueprints"; categoryId= 9; published= true; typeIds= [| 2820; 2821; 28605 |] } |> Some
      | 988 -> { GroupData.id= 988; name= "Wormhole"; categoryId= 2; published= false; typeIds= [| 30579; 30583; 30584; 30642; 30643; 30644; 30645; 30646; 30647; 30648; 30649; 30657; 30658; 30659; 30660; 30661; 30662; 30663; 30664; 30665; 30666; 30667; 30668; 30671; 30672; 30673; 30674; 30675; 30676; 30677; 30678; 30679; 30680; 30681; 30682; 30683; 30684; 30685; 30686; 30687; 30688; 30689; 30690; 30691; 30692; 30693; 30694; 30695; 30696; 30697; 30698; 30699; 30700; 30701; 30702; 30703; 30704; 30705; 30706; 30707; 30708; 30709; 30710; 30711; 30712; 30713; 30714; 30715; 30831; 32894; 32895; 34134; 34135; 34136; 34137; 34138; 34139; 34140; 34338; 34366; 34367; 34368; 34369; 34370; 34371; 34372; 34439; 35650; 35651; 35652; 35653; 35654 |] } |> Some
      | _ -> None