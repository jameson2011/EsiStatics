namespace EsiStatics.Data.Misc
open System
open EsiStatics.Data.Entities
module internal NpcCorps8=
    let getNpcCorp id = 
      match id with 
      | 1000007 -> { NameData.id= 1000007; name= "Poksu Mineral Group" } |> Some
      | 1000018 -> { NameData.id= 1000018; name= "Echelon Entertainment" } |> Some
      | 1000029 -> { NameData.id= 1000029; name= "State and Region Bank" } |> Some
      | 1000040 -> { NameData.id= 1000040; name= "Peace and Order Unit" } |> Some
      | 1000051 -> { NameData.id= 1000051; name= "Republic Fleet" } |> Some
      | 1000062 -> { NameData.id= 1000062; name= "The Leisure Group" } |> Some
      | 1000073 -> { NameData.id= 1000073; name= "Amarr Certified News" } |> Some
      | 1000084 -> { NameData.id= 1000084; name= "Amarr Navy" } |> Some
      | 1000095 -> { NameData.id= 1000095; name= "Federal Freight" } |> Some
      | 1000106 -> { NameData.id= 1000106; name= "Egonics Inc." } |> Some
      | 1000117 -> { NameData.id= 1000117; name= "Senate" } |> Some
      | 1000128 -> { NameData.id= 1000128; name= "Mordu's Legion" } |> Some
      | 1000139 -> { NameData.id= 1000139; name= "Food Relief" } |> Some
      | 1000150 -> { NameData.id= 1000150; name= "Jovian Directorate" } |> Some
      | 1000161 -> { NameData.id= 1000161; name= "True Creations" } |> Some
      | 1000172 -> { NameData.id= 1000172; name= "Pator Tech School" } |> Some
      | 1000205 -> { NameData.id= 1000205; name= "Amarr Templars" } |> Some
      | 1000216 -> { NameData.id= 1000216; name= "Crux Special Tasks Group" } |> Some
      | 1000227 -> { NameData.id= 1000227; name= "Company of Marcher Lords" } |> Some
      | 1000238 -> { NameData.id= 1000238; name= "Isuuaya Tactical" } |> Some
      | 1000249 -> { NameData.id= 1000249; name= "Kang Lo Directorate" } |> Some
      | 1000271 -> { NameData.id= 1000271; name= "Outer Ring Prospecting" } |> Some
      | 1000282 -> { NameData.id= 1000282; name= "Directive Intelligence Agency" } |> Some
      | 1000293 -> { NameData.id= 1000293; name= "Perun Clade" } |> Some
      | _ -> None