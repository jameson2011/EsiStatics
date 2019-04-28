namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups44=
    let getGroup id = 
      match id with 
      | 1111 -> { GroupData.id= 1111; name= "Box Lights"; categoryId= 54; published= true; typeIds= [| 32633 |] } |> Some
      | 1305 -> { GroupData.id= 1305; name= "Tactical Destroyer"; categoryId= 6; published= true; typeIds= [| 34317; 34562; 34828; 35683 |] } |> Some
      | 1402 -> { GroupData.id= 1402; name= "Amarr Navy Roaming Battleship"; categoryId= 11; published= false; typeIds= [| 35812; 35816 |] } |> Some
      | 141 -> { GroupData.id= 141; name= "Capacitor Battery Blueprint"; categoryId= 9; published= true; typeIds= [| 1186; 2019; 2021; 2023; 3473; 3489; 3497; 3505; 23802; 23804; 23806; 41639; 41640; 41641; 41642; 41643 |] } |> Some
      | 1596 -> { GroupData.id= 1596; name= "Structure Assembly Rig XL - All Components"; categoryId= 66; published= false; typeIds= [|  |] } |> Some
      | 1693 -> { GroupData.id= 1693; name= "OLD Structure Resource Rig M - LNS Ore Reprocessing"; categoryId= 66; published= false; typeIds= [| 41422; 41423 |] } |> Some
      | 1790 -> { GroupData.id= 1790; name= "Hidden Zenith Amarr Cruiser"; categoryId= 11; published= false; typeIds= [| 42818; 50105; 50117 |] } |> Some
      | 1887 -> { GroupData.id= 1887; name= "Structure Moon Drilling Service Module"; categoryId= 66; published= true; typeIds= [| 45009 |] } |> Some
      | 1984 -> { GroupData.id= 1984; name= "Outpost Conversion Rigs"; categoryId= 66; published= true; typeIds= [| 47881; 47882; 47883; 47884; 47979; 47980; 47981; 47982; 47983; 47984; 47985; 47986; 47987; 47988; 47989; 47990; 47991; 47992; 47993; 47994; 47995; 47996; 47997; 47998; 47999; 48000; 48001; 48002; 48003; 48004; 48005; 48006; 48007; 48008; 48009; 48010; 48011; 48012; 48013; 48014; 48015; 48016; 48017; 48018; 48019; 48020; 48021; 48022; 48023; 48024; 48025; 48026; 48027; 48028; 48029; 48030; 48031; 48032; 48033; 48034; 48035; 48036; 48037; 48038; 48039; 48040; 48041; 48042; 48043; 48044; 48045; 48046; 48047; 48048; 48049; 48050; 48051; 48052; 48053; 48054; 48055; 48056; 48057; 48058; 48059; 48060; 48061; 48062; 48063; 48064; 48065; 48066; 48067; 48068; 48069; 48070; 48071; 48072; 48073; 48074; 48075; 48076; 48077; 48078 |] } |> Some
      | 335 -> { GroupData.id= 335; name= "Temporary Cloud"; categoryId= 11; published= false; typeIds= [| 11546; 25816; 25860 |] } |> Some
      | 723 -> { GroupData.id= 723; name= "Tractor Beam Blueprint"; categoryId= 9; published= true; typeIds= [| 4251; 4253; 24349; 24645 |] } |> Some
      | 820 -> { GroupData.id= 820; name= "Deadspace Overseer Cruiser"; categoryId= 11; published= false; typeIds= [| 2846; 2847; 3882; 3884; 3889; 3890; 3891; 17165; 17166; 17284; 17615; 17616; 17823; 17824; 18584; 18641; 24582; 24584; 25306; 25877; 25990; 26117; 26130; 26678; 26682; 26686; 26690; 26691; 26756; 26758; 26763; 26764; 26765; 26766; 26768 |] } |> Some
      | 917 -> { GroupData.id= 917; name= "Data Miner Blueprint"; categoryId= 9; published= true; typeIds= [| 3582; 3590; 3794; 22176; 22178; 22326; 22328; 22330; 22332; 27015; 27020; 30833; 30835; 41535; 41536; 49972 |] } |> Some
      | _ -> None