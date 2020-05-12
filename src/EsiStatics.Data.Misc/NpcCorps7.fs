namespace EsiStatics.Data.Misc
open System
open EsiStatics.Data.Entities
module internal NpcCorps7=
    let getNpcCorp id = 
      match id with 
      | 1000006 -> { NameData.id= 1000006; name= "Deep Core Mining Inc." } |> Some
      | 1000017 -> { NameData.id= 1000017; name= "Nugoeihuvi Corporation" } |> Some
      | 1000028 -> { NameData.id= 1000028; name= "Caldari Funds Unlimited" } |> Some
      | 1000039 -> { NameData.id= 1000039; name= "Home Guard" } |> Some
      | 1000050 -> { NameData.id= 1000050; name= "Republic Parliament" } |> Some
      | 1000061 -> { NameData.id= 1000061; name= "Freedom Extension" } |> Some
      | 1000072 -> { NameData.id= 1000072; name= "Imperial Shipment" } |> Some
      | 1000083 -> { NameData.id= 1000083; name= "Amarr Trade Registry" } |> Some
      | 1000094 -> { NameData.id= 1000094; name= "TransStellar Shipping" } |> Some
      | 1000105 -> { NameData.id= 1000105; name= "Impetus" } |> Some
      | 1000116 -> { NameData.id= 1000116; name= "President" } |> Some
      | 1000127 -> { NameData.id= 1000127; name= "Guristas" } |> Some
      | 1000138 -> { NameData.id= 1000138; name= "Dominations" } |> Some
      | 1000149 -> { NameData.id= 1000149; name= "Jove Navy" } |> Some
      | 1000160 -> { NameData.id= 1000160; name= "Thukker Mix" } |> Some
      | 1000171 -> { NameData.id= 1000171; name= "Republic University" } |> Some
      | 1000182 -> { NameData.id= 1000182; name= "Tribal Liberation Force" } |> Some
      | 1000193 -> { NameData.id= 1000193; name= "Arkombine" } |> Some
      | 1000215 -> { NameData.id= 1000215; name= "Algintal Core" } |> Some
      | 1000226 -> { NameData.id= 1000226; name= "Ametat Security" } |> Some
      | 1000237 -> { NameData.id= 1000237; name= "Commando Perkone" } |> Some
      | 1000248 -> { NameData.id= 1000248; name= "Edimmu Warfighters" } |> Some
      | 1000259 -> { NameData.id= 1000259; name= "Krusual Covert Operators" } |> Some
      | 1000270 -> { NameData.id= 1000270; name= "Outer Ring Development" } |> Some
      | 1000281 -> { NameData.id= 1000281; name= "Independent Gaming Commission" } |> Some
      | 1000292 -> { NameData.id= 1000292; name= "Veles Clade" } |> Some
      | _ -> None