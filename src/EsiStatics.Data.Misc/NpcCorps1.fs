namespace EsiStatics.Data.Misc
open System
open EsiStatics.Data.Entities
module internal NpcCorps1=
    let getNpcCorp id = 
      match id with 
      | 1000011 -> { NameData.id= 1000011; name= "Wiyrkomi Corporation" } |> Some
      | 1000022 -> { NameData.id= 1000022; name= "Propel Dynamics" } |> Some
      | 1000033 -> { NameData.id= 1000033; name= "Caldari Business Tribunal" } |> Some
      | 1000044 -> { NameData.id= 1000044; name= "School of Applied Knowledge" } |> Some
      | 1000055 -> { NameData.id= 1000055; name= "Minmatar Mining Corporation" } |> Some
      | 1000066 -> { NameData.id= 1000066; name= "Viziam" } |> Some
      | 1000077 -> { NameData.id= 1000077; name= "Royal Amarr Institute" } |> Some
      | 1000088 -> { NameData.id= 1000088; name= "Sarum Family" } |> Some
      | 1000099 -> { NameData.id= 1000099; name= "Combined Harvest" } |> Some
      | 1000110 -> { NameData.id= 1000110; name= "FedMart" } |> Some
      | 1000121 -> { NameData.id= 1000121; name= "Federal Intelligence Office" } |> Some
      | 1000132 -> { NameData.id= 1000132; name= "Secure Commerce Commission" } |> Some
      | 1000143 -> { NameData.id= 1000143; name= "Inner Circle" } |> Some
      | 1000154 -> { NameData.id= 1000154; name= "Nefantar Miner Association" } |> Some
      | 1000165 -> { NameData.id= 1000165; name= "Hedion University" } |> Some
      | 1000176 -> { NameData.id= 1000176; name= "Pann's Peeps" } |> Some
      | 1000198 -> { NameData.id= 1000198; name= "Imperial Guard" } |> Some
      | 1000220 -> { NameData.id= 1000220; name= "Sanmatar Kelkoons" } |> Some
      | 1000231 -> { NameData.id= 1000231; name= "Holdfast Syndicate" } |> Some
      | 1000253 -> { NameData.id= 1000253; name= "Krullefor Organization" } |> Some
      | 1000286 -> { NameData.id= 1000286; name= "Republic Fleet Ordnance" } |> Some
      | 1000297 -> { NameData.id= 1000297; name= "AEGIS" } |> Some
      | _ -> None