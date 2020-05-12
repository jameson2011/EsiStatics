namespace EsiStatics.Data.Misc
open System
open EsiStatics.Data.Entities
module internal NpcCorps2=
    let getNpcCorp id = 
      match id with 
      | 1000001 -> { NameData.id= 1000001; name= "Doomheim" } |> Some
      | 1000012 -> { NameData.id= 1000012; name= "Top Down" } |> Some
      | 1000023 -> { NameData.id= 1000023; name= "Expert Distribution" } |> Some
      | 1000034 -> { NameData.id= 1000034; name= "House of Records" } |> Some
      | 1000045 -> { NameData.id= 1000045; name= "Science and Trade Institute" } |> Some
      | 1000056 -> { NameData.id= 1000056; name= "Core Complexion Inc." } |> Some
      | 1000067 -> { NameData.id= 1000067; name= "Zoar and Sons" } |> Some
      | 1000078 -> { NameData.id= 1000078; name= "Imperial Chancellor" } |> Some
      | 1000089 -> { NameData.id= 1000089; name= "Kor-Azor Family" } |> Some
      | 1000100 -> { NameData.id= 1000100; name= "Quafe Company" } |> Some
      | 1000111 -> { NameData.id= 1000111; name= "Aliastra" } |> Some
      | 1000122 -> { NameData.id= 1000122; name= "Federation Customs" } |> Some
      | 1000133 -> { NameData.id= 1000133; name= "Salvation Angels" } |> Some
      | 1000144 -> { NameData.id= 1000144; name= "Intaki Bank" } |> Some
      | 1000155 -> { NameData.id= 1000155; name= "Prosper" } |> Some
      | 1000166 -> { NameData.id= 1000166; name= "Imperial Academy" } |> Some
      | 1000177 -> { NameData.id= 1000177; name= "Material Institute" } |> Some
      | 1000232 -> { NameData.id= 1000232; name= "Kinsho Swords" } |> Some
      | 1000243 -> { NameData.id= 1000243; name= "Namtar Elite" } |> Some
      | 1000254 -> { NameData.id= 1000254; name= "Mikramurka Shock Troop" } |> Some
      | 1000276 -> { NameData.id= 1000276; name= "ORE Technologies" } |> Some
      | 1000287 -> { NameData.id= 1000287; name= "Infested Regions Hiveminds" } |> Some
      | 1000298 -> { NameData.id= 1000298; name= "The Convocation of Triglav" } |> Some
      | _ -> None