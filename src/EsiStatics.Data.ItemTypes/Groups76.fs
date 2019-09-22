namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups76=
    let getGroup id = 
      match id with 
      | 1046 -> { GroupData.id= 1046; name= "Nanite Repair Paste Blueprint"; categoryId= 9; published= true; typeIds= [|  |] } |> Some
      | 1143 -> { GroupData.id= 1143; name= "Electronic Warfare Drone Blueprint"; categoryId= 9; published= true; typeIds= [| 23474; 23507; 23511; 23513; 23706; 23708; 23714; 23716; 23722; 23724; 23726; 23728 |] } |> Some
      | 1240 -> { GroupData.id= 1240; name= "Subsystems"; categoryId= 16; published= true; typeIds= [| 30532; 30536; 30537; 30538; 30539; 30540; 30541; 30542; 30543; 30544; 30545; 30546; 30547; 30548; 30549; 30550; 30551; 30552; 30553; 30554 |] } |> Some
      | 1725 -> { GroupData.id= 1725; name= "Irregular Force Auxiliary"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 1822 -> { GroupData.id= 1822; name= "Structure Engineering Rig M - Drone and Fighter ME"; categoryId= 66; published= true; typeIds= [| 37156; 37157 |] } |> Some
      | 2016 -> { GroupData.id= 2016; name= "Upwell Cyno Jammer"; categoryId= 65; published= true; typeIds= [| 37534 |] } |> Some
      | 270 -> { GroupData.id= 270; name= "Science"; categoryId= 16; published= true; typeIds= [| 3402; 3403; 3406; 3408; 3409; 11433; 11441; 11442; 11443; 11444; 11445; 11446; 11447; 11448; 11449; 11450; 11451; 11452; 11453; 11454; 11455; 11487; 11529; 11858; 12179; 20433; 21789; 21790; 21791; 23087; 23121; 23123; 23124; 24270; 24624; 30324; 30325; 30326; 30327; 30788; 52307; 52308 |] } |> Some
      | 367 -> { GroupData.id= 367; name= "Ballistic Control system"; categoryId= 7; published= true; typeIds= [| 12274; 13935; 13937; 14528; 14530; 14532; 14534; 14684; 14686; 14688; 14690; 15681; 15683; 16457; 16459; 16461; 16463; 21482; 21484; 22291; 28563; 46270; 47447; 47448; 49738; 49790 |] } |> Some
      | 464 -> { GroupData.id= 464; name= "Strip Miner"; categoryId= 7; published= true; typeIds= [| 16278; 17482; 22229; 28752; 28754 |] } |> Some
      | 561 -> { GroupData.id= 561; name= "Asteroid Guristas Cruiser"; categoryId= 11; published= false; typeIds= [| 2387; 10265; 11031; 11036; 11928; 11929; 11930; 11931; 21984; 21985; 21986; 21987; 23305; 23306; 23307; 23308; 23309; 23310; 23319; 23320; 23647; 23648; 23649; 23650; 33134; 33145; 33174; 33189 |] } |> Some
      | 658 -> { GroupData.id= 658; name= "Cynosural Field Generator"; categoryId= 7; published= true; typeIds= [| 21096; 28646; 52694 |] } |> Some
      | 755 -> { GroupData.id= 755; name= "Asteroid Rogue Drone BattleCruiser"; categoryId= 11; published= false; typeIds= [| 25640; 25642; 25654; 25655; 25673; 25697 |] } |> Some
      | 76 -> { GroupData.id= 76; name= "Capacitor Booster"; categoryId= 7; published= true; typeIds= [| 577; 2024; 3556; 3558; 3566; 3568; 3576; 3578; 4829; 4831; 4833; 4835; 4955; 4957; 4959; 4961; 5007; 5009; 5011; 5013; 5017; 5047; 5049; 5051; 5053; 14172; 14174; 14176; 14178; 14180; 14182; 14184; 14186; 15128; 15130; 15132; 15134; 15136; 15138; 15140; 15142; 15772; 15774; 15776; 15778; 15780; 15782; 15784; 15786; 20555; 20557; 20559; 23807; 23809; 23811; 41491; 41492; 41493; 41494; 41495 |] } |> Some
      | 852 -> { GroupData.id= 852; name= "Asteroid Serpentis Commander Battleship"; categoryId= 11; published= false; typeIds= [| 13652; 13653; 13658; 13660; 13665; 13666; 23469; 23470; 23471; 23472 |] } |> Some
      | _ -> None