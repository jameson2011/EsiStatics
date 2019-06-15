namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups33=
    let getGroup id = 
      match id with 
      | 1003 -> { GroupData.id= 1003; name= "Territorial Claim Unit"; categoryId= 40; published= true; typeIds= [| 32226; 32300 |] } |> Some
      | 1197 -> { GroupData.id= 1197; name= "Special Edition Commodity Blueprints"; categoryId= 9; published= true; typeIds= [| 33067 |] } |> Some
      | 1294 -> { GroupData.id= 1294; name= "Mobile Micro Jump Unit Blueprint"; categoryId= 9; published= true; typeIds= [| 33592 |] } |> Some
      | 130 -> { GroupData.id= 130; name= "ECM Blueprint"; categoryId= 9; published= true; typeIds= [| 11628; 11629; 11630; 11631; 11632; 11775; 11779; 11783; 11787; 11791; 20574; 20576; 20578; 20580; 28730; 28732; 28734; 28736; 28738 |] } |> Some
      | 1585 -> { GroupData.id= 1585; name= "Structure Assembly Rig M - Consumable"; categoryId= 66; published= false; typeIds= [|  |] } |> Some
      | 1682 -> { GroupData.id= 1682; name= "Asteroid Angel Cartel Titan"; categoryId= 11; published= false; typeIds= [| 37462 |] } |> Some
      | 1876 -> { GroupData.id= 1876; name= "♦ Engineering Complex"; categoryId= 65; published= false; typeIds= [| 45006 |] } |> Some
      | 1973 -> { GroupData.id= 1973; name= "Locators"; categoryId= 2; published= false; typeIds= [| 47460; 47461; 47462; 47463; 47464; 48093; 48094; 50135; 50137 |] } |> Some
      | 227 -> { GroupData.id= 227; name= "Cloud"; categoryId= 2; published= false; typeIds= [| 2894; 3073; 10065; 10066; 10067; 10068; 10069; 10128; 10129; 10130; 10131; 10132; 10232; 10233; 10753; 10754; 10755; 10756; 10757; 10758; 10759; 10760; 10761; 10762; 10763; 10764; 10765; 19713; 19746; 19747; 19748; 19749; 19750; 19751; 19752; 19753; 19754; 19755; 19756; 23767; 24578; 26467; 33014; 34333; 35645; 41581; 42116; 42536; 42697; 42901; 43549; 43917; 43918; 44066; 44105; 45017; 45729; 45730; 45731; 45993; 45994; 45995; 46064; 46065; 46082; 46083; 46084; 46085; 46086; 46088; 46565; 46566; 46567; 46568; 46569; 46570; 46571; 46572; 46573; 46574; 47152; 47329; 47398; 47399; 47400; 47861; 48933; 49126; 49696; 49697; 49698; 49754; 50016; 52220; 52221; 52222; 52223; 52510; 52511 |] } |> Some
      | 324 -> { GroupData.id= 324; name= "Assault Frigate"; categoryId= 6; published= true; typeIds= [| 2834; 3516; 11365; 11371; 11373; 11375; 11379; 11381; 11383; 11389; 11393; 11400; 12036; 12042; 12044; 32207; 32788; 52250 |] } |> Some
      | 518 -> { GroupData.id= 518; name= "Anti Ballistic Defense System"; categoryId= 7; published= false; typeIds= [|  |] } |> Some
      | 615 -> { GroupData.id= 615; name= "Deadspace Guristas Frigate"; categoryId= 11; published= false; typeIds= [| 16565; 16566; 16981; 16983; 16985; 16986; 16987; 16989; 16990; 16993; 16994; 16996; 16997; 16999; 17001; 17002; 17006; 17008; 17012; 17013; 17015; 17019; 17022; 17023; 17026; 17027; 17032; 24045; 24046; 24047; 24048; 24049; 24050; 25825; 32391 |] } |> Some
      | 712 -> { GroupData.id= 712; name= "Biochemical Material"; categoryId= 4; published= true; typeIds= [| 25237; 25241; 25242; 25252; 25283; 25330; 25331; 25332; 25333; 25334; 25335; 25336; 25337; 25338; 25339; 25340; 25341; 25342; 25343; 25344; 25345; 25346; 25347; 25348; 28686; 28687; 28688; 28689; 28690; 28691; 28692; 28693 |] } |> Some
      | 809 -> { GroupData.id= 809; name= "Asteroid Sansha's Nation Commander Destroyer"; categoryId= 11; published= false; typeIds= [| 23391; 23392; 23409; 23410; 23411; 23412 |] } |> Some
      | 906 -> { GroupData.id= 906; name= "Combat Recon Ship"; categoryId= 6; published= true; typeIds= [| 11959; 11961; 11971; 20125 |] } |> Some
      | _ -> None