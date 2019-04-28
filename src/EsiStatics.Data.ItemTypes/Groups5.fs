namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups5=
    let getGroup id = 
      match id with 
      | 1169 -> { GroupData.id= 1169; name= "FW Amarr Empire Frigate"; categoryId= 11; published= true; typeIds= [| 32916 |] } |> Some
      | 1848 -> { GroupData.id= 1848; name= "Structure Engineering Rig M - Blueprint Copy Cost Optimization"; categoryId= 66; published= true; typeIds= [| 43890; 43891 |] } |> Some
      | 1945 -> { GroupData.id= 1945; name= "Structure Resource Rig XL - Reprocessing"; categoryId= 66; published= true; typeIds= [| 46641; 46642 |] } |> Some
      | 199 -> { GroupData.id= 199; name= "Career Bonus"; categoryId= 14; published= false; typeIds= [| 1675; 1676; 1677; 1678; 1679; 1680 |] } |> Some
      | 296 -> { GroupData.id= 296; name= "Shield Resistance Amplifier Blueprint"; categoryId= 9; published= true; typeIds= [| 1809; 2530; 2532; 2538; 2540; 2546; 2548; 2554; 15910; 15912; 15914; 15916; 15918; 15920; 15922; 15924; 20606; 20608; 20610; 20612 |] } |> Some
      | 490 -> { GroupData.id= 490; name= "Strip Miner Blueprint"; categoryId= 9; published= true; typeIds= [| 16279; 17483; 17913; 22230; 24306; 28753; 28755 |] } |> Some
      | 5 -> { GroupData.id= 5; name= "Solar System"; categoryId= 2; published= false; typeIds= [| 5 |] } |> Some
      | 684 -> { GroupData.id= 684; name= "Mission Minmatar Republic Destroyer"; categoryId= 11; published= false; typeIds= [| 24797; 24798; 24799; 24801; 24805; 24810; 45468 |] } |> Some
      | 781 -> { GroupData.id= 781; name= "Rig Core"; categoryId= 7; published= true; typeIds= [| 4395; 4397; 4399; 4401; 25934; 25948; 25950; 25952; 25954; 25956; 26348; 26368; 26370; 26372; 26374; 26376; 26929; 26931; 31226; 31228; 31230; 31232; 31234; 31236; 31358; 31360; 31362; 31364; 31366; 31368; 31370; 31372; 31374; 31376; 31378; 31380; 31382; 31384; 31386; 31388; 31390; 31392; 31394; 31396; 31398; 31400; 31402; 31404; 31406; 31408; 31410; 31412; 31414; 31416; 33303; 33305; 43894; 43896; 43898; 43900 |] } |> Some
      | 878 -> { GroupData.id= 878; name= "Cloak Enhancements"; categoryId= 7; published= false; typeIds= [|  |] } |> Some
      | _ -> None