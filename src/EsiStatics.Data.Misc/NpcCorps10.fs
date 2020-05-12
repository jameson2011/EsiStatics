namespace EsiStatics.Data.Misc
open System
open EsiStatics.Data.Entities
module internal NpcCorps10=
    let getNpcCorp id = 
      match id with 
      | 1000009 -> { NameData.id= 1000009; name= "Caldari Provisions" } |> Some
      | 1000020 -> { NameData.id= 1000020; name= "Lai Dai Corporation" } |> Some
      | 1000031 -> { NameData.id= 1000031; name= "Chief Executive Panel" } |> Some
      | 1000042 -> { NameData.id= 1000042; name= "Wiyrkomi Peace Corps" } |> Some
      | 1000053 -> { NameData.id= 1000053; name= "Urban Management" } |> Some
      | 1000064 -> { NameData.id= 1000064; name= "Carthum Conglomerate" } |> Some
      | 1000075 -> { NameData.id= 1000075; name= "Nurtura" } |> Some
      | 1000086 -> { NameData.id= 1000086; name= "Emperor Family" } |> Some
      | 1000097 -> { NameData.id= 1000097; name= "Material Acquisition" } |> Some
      | 1000108 -> { NameData.id= 1000108; name= "Chemal Tech" } |> Some
      | 1000119 -> { NameData.id= 1000119; name= "Federal Administration" } |> Some
      | 1000130 -> { NameData.id= 1000130; name= "Sisters of EVE" } |> Some
      | 1000141 -> { NameData.id= 1000141; name= "Guristas Production" } |> Some
      | 1000152 -> { NameData.id= 1000152; name= "Khanid Transport" } |> Some
      | 1000163 -> { NameData.id= 1000163; name= "Trust Partners" } |> Some
      | 1000174 -> { NameData.id= 1000174; name= "Polaris Bug Hunters" } |> Some
      | 1000207 -> { NameData.id= 1000207; name= "Bragian Order" } |> Some
      | 1000218 -> { NameData.id= 1000218; name= "Circle of Huskarl" } |> Some
      | 1000229 -> { NameData.id= 1000229; name= "Kameira Lodge" } |> Some
      | 1000240 -> { NameData.id= 1000240; name= "Ikomari-Onu Enforcement" } |> Some
      | 1000251 -> { NameData.id= 1000251; name= "Brutor Vanguard" } |> Some
      | 1000262 -> { NameData.id= 1000262; name= "Federal Marines" } |> Some
      | 1000284 -> { NameData.id= 1000284; name= "State Military Stockpile" } |> Some
      | _ -> None