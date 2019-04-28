namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups0=
    let getGroup id = 
      match id with 
      | 0 -> { GroupData.id= 0; name= "#System"; categoryId= 0; published= false; typeIds= [| 0; 48464; 48465; 49782 |] } |> Some
      | 1067 -> { GroupData.id= 1067; name= "MaterialZone"; categoryId= 26; published= false; typeIds= [|  |] } |> Some
      | 1455 -> { GroupData.id= 1455; name= "Irregular Fighter Squadron"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 1649 -> { GroupData.id= 1649; name= "OLD Structure Resource Rig XL - Reprocessing"; categoryId= 66; published= false; typeIds= [| 37284; 37285 |] } |> Some
      | 1843 -> { GroupData.id= 1843; name= "Structure Engineering Rig M - Invention Accelerator"; categoryId= 66; published= true; typeIds= [| 43880; 43881 |] } |> Some
      | 194 -> { GroupData.id= 194; name= "Social Handicap"; categoryId= 14; published= false; typeIds= [|  |] } |> Some
      | 1940 -> { GroupData.id= 1940; name= "Moon Chunk"; categoryId= 2; published= false; typeIds= [| 45008; 46030; 46031; 46032 |] } |> Some
      | 291 -> { GroupData.id= 291; name= "Weapon Disruptor"; categoryId= 7; published= true; typeIds= [| 2108; 2109; 5319; 5320; 5321; 5322; 22931; 22933; 32416; 32417; 37543; 37544; 37545; 37546 |] } |> Some
      | 485 -> { GroupData.id= 485; name= "Dreadnought"; categoryId= 6; published= true; typeIds= [| 19720; 19722; 19724; 19726; 34339; 34341; 34343; 34345; 42124; 42243; 45647 |] } |> Some
      | 582 -> { GroupData.id= 582; name= "Asteroid Sansha's Nation BattleCruiser"; categoryId= 11; published= false; typeIds= [| 23383; 23384; 23385; 23386; 23387; 23388 |] } |> Some
      | 679 -> { GroupData.id= 679; name= "Mission Gallente Federation Destroyer"; categoryId= 11; published= false; typeIds= [| 25125; 25126; 25127; 25129; 25131; 25133; 45465 |] } |> Some
      | 776 -> { GroupData.id= 776; name= "Rig Hybrid Weapon"; categoryId= 7; published= true; typeIds= [| 25996; 25998; 26000; 26002; 26004; 26006; 26008; 26392; 26394; 26396; 26398; 26400; 26402; 26404; 31502; 31504; 31506; 31508; 31510; 31512; 31514; 31516; 31518; 31520; 31522; 31524; 31526; 31528; 31530; 31532; 31534; 31536; 31538; 31540; 31542; 31544; 31546; 31548; 31550; 31552; 31554; 31556; 31558; 31560; 31562; 31564; 31566; 31568; 31570; 31572; 31574; 31576; 31578; 31580; 31582; 31584 |] } |> Some
      | 873 -> { GroupData.id= 873; name= "Capital Construction Components"; categoryId= 17; published= true; typeIds= [| 21009; 21011; 21013; 21017; 21019; 21021; 21023; 21025; 21027; 21029; 21035; 21037; 21039; 21041; 24545; 24547; 24556; 24558; 24560 |] } |> Some
      | 97 -> { GroupData.id= 97; name= "Proximity Drone"; categoryId= 18; published= false; typeIds= [|  |] } |> Some
      | _ -> None