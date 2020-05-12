namespace EsiStatics.Data.Misc
open System
open EsiStatics.Data.Entities
module internal NpcCorps3=
    let getNpcCorp id = 
      match id with 
      | 1000002 -> { NameData.id= 1000002; name= "CBD Corporation" } |> Some
      | 1000013 -> { NameData.id= 1000013; name= "Rapid Assembly" } |> Some
      | 1000024 -> { NameData.id= 1000024; name= "CBD Sell Division" } |> Some
      | 1000035 -> { NameData.id= 1000035; name= "Caldari Navy" } |> Some
      | 1000046 -> { NameData.id= 1000046; name= "Sebiestor Tribe" } |> Some
      | 1000057 -> { NameData.id= 1000057; name= "Boundless Creation" } |> Some
      | 1000068 -> { NameData.id= 1000068; name= "Noble Appliances" } |> Some
      | 1000079 -> { NameData.id= 1000079; name= "Amarr Civil Service" } |> Some
      | 1000090 -> { NameData.id= 1000090; name= "Ardishapur Family" } |> Some
      | 1000101 -> { NameData.id= 1000101; name= "CreoDron" } |> Some
      | 1000112 -> { NameData.id= 1000112; name= "Bank of Luminaire" } |> Some
      | 1000123 -> { NameData.id= 1000123; name= "Ammatar Fleet" } |> Some
      | 1000134 -> { NameData.id= 1000134; name= "Blood Raiders" } |> Some
      | 1000145 -> { NameData.id= 1000145; name= "Intaki Commerce" } |> Some
      | 1000156 -> { NameData.id= 1000156; name= "Royal Khanid Navy" } |> Some
      | 1000167 -> { NameData.id= 1000167; name= "State War Academy" } |> Some
      | 1000178 -> { NameData.id= 1000178; name= "Academy of Aggressive Behaviour" } |> Some
      | 1000222 -> { NameData.id= 1000222; name= "Ostrakon Agency" } |> Some
      | 1000233 -> { NameData.id= 1000233; name= "Expert Intervention" } |> Some
      | 1000244 -> { NameData.id= 1000244; name= "Mannar Focused Warfare" } |> Some
      | 1000255 -> { NameData.id= 1000255; name= "Eyniletti Rangers" } |> Some
      | 1000277 -> { NameData.id= 1000277; name= "Frostline Laboratories" } |> Some
      | 1000288 -> { NameData.id= 1000288; name= "Navka Overminds" } |> Some
      | 1000299 -> { NameData.id= 1000299; name= "PKN Cryptographic" } |> Some
      | _ -> None