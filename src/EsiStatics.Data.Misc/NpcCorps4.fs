namespace EsiStatics.Data.Misc
open System
open EsiStatics.Data.Entities
module internal NpcCorps4=
    let getNpcCorp id = 
      match id with 
      | 1000003 -> { NameData.id= 1000003; name= "Prompt Delivery" } |> Some
      | 1000014 -> { NameData.id= 1000014; name= "Perkone" } |> Some
      | 1000025 -> { NameData.id= 1000025; name= "Sukuuvestaa Corporation" } |> Some
      | 1000036 -> { NameData.id= 1000036; name= "Internal Security" } |> Some
      | 1000047 -> { NameData.id= 1000047; name= "Krusual Tribe" } |> Some
      | 1000058 -> { NameData.id= 1000058; name= "Eifyr and Co." } |> Some
      | 1000069 -> { NameData.id= 1000069; name= "Ducia Foundry" } |> Some
      | 1000080 -> { NameData.id= 1000080; name= "Ministry of War" } |> Some
      | 1000091 -> { NameData.id= 1000091; name= "Tash-Murkon Family" } |> Some
      | 1000102 -> { NameData.id= 1000102; name= "Roden Shipyards" } |> Some
      | 1000113 -> { NameData.id= 1000113; name= "Pend Insurance" } |> Some
      | 1000124 -> { NameData.id= 1000124; name= "Archangels" } |> Some
      | 1000135 -> { NameData.id= 1000135; name= "Serpentis Corporation" } |> Some
      | 1000146 -> { NameData.id= 1000146; name= "Intaki Space Police" } |> Some
      | 1000157 -> { NameData.id= 1000157; name= "Serpentis Inquest" } |> Some
      | 1000168 -> { NameData.id= 1000168; name= "Federal Navy Academy" } |> Some
      | 1000179 -> { NameData.id= 1000179; name= "24th Imperial Crusade" } |> Some
      | 1000223 -> { NameData.id= 1000223; name= "Fraternity of St. Venefice" } |> Some
      | 1000234 -> { NameData.id= 1000234; name= "Onikanabo Brigade" } |> Some
      | 1000245 -> { NameData.id= 1000245; name= "Resheph Interstellar Strategy" } |> Some
      | 1000256 -> { NameData.id= 1000256; name= "Sebiestor Field Sappers" } |> Some
      | 1000289 -> { NameData.id= 1000289; name= "Unshackled Overminds" } |> Some
      | 1000300 -> { NameData.id= 1000300; name= "PKN Interstellar" } |> Some
      | _ -> None