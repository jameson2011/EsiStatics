namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups75=
    let getGroup id = 
      match id with 
      | 1045 -> { GroupData.id= 1045; name= "Sovereignty Structure Blueprint"; categoryId= 9; published= true; typeIds= [| 2735; 2737; 2738 |] } |> Some
      | 1142 -> { GroupData.id= 1142; name= "Energy Neutralizer Drone Blueprint"; categoryId= 9; published= true; typeIds= [| 22573; 23660; 23703 |] } |> Some
      | 1239 -> { GroupData.id= 1239; name= "Scanning Upgrade Time Blueprint"; categoryId= 9; published= true; typeIds= [| 33177; 33198 |] } |> Some
      | 1530 -> { GroupData.id= 1530; name= "Drifter Response Battleship"; categoryId= 11; published= false; typeIds= [| 37473 |] } |> Some
      | 172 -> { GroupData.id= 172; name= "Bomb Blueprint"; categoryId= 9; published= true; typeIds= [| 27913; 27917; 27919; 27921; 27923; 27925 |] } |> Some
      | 1724 -> { GroupData.id= 1724; name= "Irregular Dreadnought"; categoryId= 11; published= false; typeIds= [| 40729 |] } |> Some
      | 1821 -> { GroupData.id= 1821; name= "Structure Engineering Rig M - Ammunition TE"; categoryId= 66; published= true; typeIds= [| 37150; 37151 |] } |> Some
      | 2015 -> { GroupData.id= 2015; name= "Upwell Monument"; categoryId= 65; published= false; typeIds= [| 35845; 49600; 49601 |] } |> Some
      | 269 -> { GroupData.id= 269; name= "Rigging"; categoryId= 16; published= true; typeIds= [| 26252; 26253; 26254; 26255; 26256; 26257; 26258; 26259; 26260; 26261 |] } |> Some
      | 366 -> { GroupData.id= 366; name= "Warp Gate"; categoryId= 2; published= false; typeIds= [| 4077; 12273; 17831; 23828; 24706; 28074; 35776; 42902; 47685; 47686; 48964; 49563; 49784; 49785; 49786; 52670 |] } |> Some
      | 463 -> { GroupData.id= 463; name= "Mining Barge"; categoryId= 6; published= true; typeIds= [| 17476; 17478; 17480 |] } |> Some
      | 560 -> { GroupData.id= 560; name= "Asteroid Guristas Battleship"; categoryId= 11; published= false; typeIds= [| 11932; 11933; 11934; 11935; 23337; 23338; 23339; 23340; 23341; 23342 |] } |> Some
      | 657 -> { GroupData.id= 657; name= "Advanced Torpedo"; categoryId= 8; published= true; typeIds= [| 2801; 2811; 24519; 24521; 24523; 24525; 24527; 24529 |] } |> Some
      | 754 -> { GroupData.id= 754; name= "Salvaged Materials"; categoryId= 4; published= true; typeIds= [| 25588; 25589; 25590; 25591; 25592; 25593; 25594; 25595; 25596; 25597; 25598; 25599; 25600; 25601; 25602; 25603; 25604; 25605; 25606; 25607; 25608; 25609; 25610; 25611; 25612; 25613; 25614; 25615; 25616; 25617; 25618; 25619; 25620; 25621; 25622; 25623; 25624; 25625 |] } |> Some
      | 851 -> { GroupData.id= 851; name= "Asteroid Sansha's Nation Commander Battleship"; categoryId= 11; published= false; typeIds= [| 13606; 13614; 13620; 13621; 13633; 13634; 23400; 23401; 23402; 23403 |] } |> Some
      | _ -> None