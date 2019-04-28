namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups39=
    let getGroup id = 
      match id with 
      | 1106 -> { GroupData.id= 1106; name= "Orbital Construction Platform"; categoryId= 46; published= true; typeIds= [| 3962 |] } |> Some
      | 136 -> { GroupData.id= 136; name= "Missile Launcher Blueprint"; categoryId= 9; published= true; typeIds= [| 786; 788; 790; 1876; 1878; 2405; 2411; 2421; 3564; 3570; 4257; 10630; 10632; 10643; 13321; 16063; 16066; 17486; 17489; 19740; 20540; 20594; 20596; 20598; 20600; 20602; 20604; 21543; 22783; 25716; 26174; 26759; 27915; 28376; 28378; 28380; 28382; 28384; 28512; 28566; 32445; 33447; 33449; 33451; 33460; 34291; 34293; 34295; 41177; 41178; 41179; 41183; 41184; 41185; 41187; 41190; 41225; 41226; 41227; 41228; 41229; 44103 |] } |> Some
      | 1397 -> { GroupData.id= 1397; name= "Missile Guidance Enhancer Blueprint"; categoryId= 9; published= true; typeIds= [| 35772; 35773 |] } |> Some
      | 1591 -> { GroupData.id= 1591; name= "Structure Assembly Rig L - Tech I Capital Component"; categoryId= 66; published= false; typeIds= [|  |] } |> Some
      | 1688 -> { GroupData.id= 1688; name= "Asteroid Sansha's Nation Supercarrier"; categoryId= 11; published= false; typeIds= [| 40671 |] } |> Some
      | 1882 -> { GroupData.id= 1882; name= "MassiveEnvironments"; categoryId= 2; published= false; typeIds= [| 36464; 42532; 47204; 47205; 47380; 47383; 47386; 47389; 47392; 47451; 47452; 47453; 47454; 47455; 47456; 47949; 47950; 49700; 50096 |] } |> Some
      | 1979 -> { GroupData.id= 1979; name= "Abyssal Filaments"; categoryId= 17; published= true; typeIds= [| 47711; 47761; 47762; 47763; 47764; 47765; 47888; 47889; 47890; 47891; 47892; 47893; 47894; 47895; 47896; 47897; 47898; 47899; 47900; 47901; 47902; 47903; 47904; 47905; 47906; 47907 |] } |> Some
      | 330 -> { GroupData.id= 330; name= "Cloaking Device"; categoryId= 7; published= true; typeIds= [| 11370; 11577; 11578; 14234; 14776; 14778; 14780; 14782; 15790; 16126; 20561; 20563; 20565; 32260 |] } |> Some
      | 39 -> { GroupData.id= 39; name= "Shield Recharger"; categoryId= 7; published= true; typeIds= [| 393; 394; 6485; 6487; 6489; 6491; 37805 |] } |> Some
      | 427 -> { GroupData.id= 427; name= "Moon Materials"; categoryId= 4; published= true; typeIds= [| 16633; 16634; 16635; 16636; 16637; 16638; 16639; 16640; 16641; 16642; 16643; 16644; 16646; 16647; 16648; 16649; 16650; 16651; 16652; 16653 |] } |> Some
      | 524 -> { GroupData.id= 524; name= "Missile Launcher XL Torpedo"; categoryId= 7; published= true; typeIds= [| 3565; 20539; 37294; 41180; 41181; 41182 |] } |> Some
      | 621 -> { GroupData.id= 621; name= "Deadspace Sansha's Nation Battleship"; categoryId= 11; published= false; typeIds= [| 17058; 17066; 17071; 17082; 17085; 17090; 17095; 17096; 17107; 17108; 19737; 24155; 24156; 24157; 24158; 24159; 24160; 24161; 24162; 24163; 24164 |] } |> Some
      | 718 -> { GroupData.id= 718; name= "Booster Blueprints"; categoryId= 9; published= true; typeIds= [| 2839; 25303; 25307; 25308; 25309; 25310; 25311; 25314; 25322; 25323; 25327; 25328; 25329; 25503; 25504; 25505; 25506; 25507; 25508; 25509; 25510; 25511; 25512; 25513; 25539; 28671; 28673; 28675; 28677; 28679; 28681; 28683; 28685; 33088; 33112; 48923; 48924; 48925; 48926; 48945; 48946; 48947; 48948; 49967; 49968; 49969; 49970; 50011; 50012; 50013; 50014 |] } |> Some
      | 815 -> { GroupData.id= 815; name= "Clone Vat Bay"; categoryId= 7; published= true; typeIds= [| 23735 |] } |> Some
      | 912 -> { GroupData.id= 912; name= "Script Blueprint"; categoryId= 9; published= true; typeIds= [| 2739; 4408; 29000; 29002; 29004; 29006; 29008; 29010; 29012; 29014; 29016; 35796; 35797; 37833; 37834; 37835; 37836; 37837; 37838; 37839; 37840; 40336; 40337; 41230; 41590; 41591; 41592; 41593; 41594; 41595; 41596; 41597; 45011; 47337 |] } |> Some
      | _ -> None