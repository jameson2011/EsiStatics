namespace EsiStatics.Data.Misc
open System
open EsiStatics.Data.Entities
module internal NpcCorps0=
    let getNpcCorp id = 
      match id with 
      | 1000010 -> { NameData.id= 1000010; name= "Kaalakiota Corporation" } |> Some
      | 1000021 -> { NameData.id= 1000021; name= "Zero-G Research Firm" } |> Some
      | 1000032 -> { NameData.id= 1000032; name= "Mercantile Club" } |> Some
      | 1000043 -> { NameData.id= 1000043; name= "Corporate Police Force" } |> Some
      | 1000054 -> { NameData.id= 1000054; name= "Republic Security Services" } |> Some
      | 1000065 -> { NameData.id= 1000065; name= "Imperial Armaments" } |> Some
      | 1000076 -> { NameData.id= 1000076; name= "Further Foodstuffs" } |> Some
      | 1000087 -> { NameData.id= 1000087; name= "Kador Family" } |> Some
      | 1000098 -> { NameData.id= 1000098; name= "Astral Mining Inc." } |> Some
      | 1000109 -> { NameData.id= 1000109; name= "Duvolle Laboratories" } |> Some
      | 1000120 -> { NameData.id= 1000120; name= "Federation Navy" } |> Some
      | 1000131 -> { NameData.id= 1000131; name= "Society of Conscious Thought" } |> Some
      | 1000142 -> { NameData.id= 1000142; name= "Impro" } |> Some
      | 1000153 -> { NameData.id= 1000153; name= "Khanid Works" } |> Some
      | 1000164 -> { NameData.id= 1000164; name= "X-Sense" } |> Some
      | 1000175 -> { NameData.id= 1000175; name= "Polaris Events" } |> Some
      | 1000197 -> { NameData.id= 1000197; name= "Templis Dragonaurs" } |> Some
      | 1000208 -> { NameData.id= 1000208; name= "Zumari Force Projection" } |> Some
      | 1000219 -> { NameData.id= 1000219; name= "Tronhadar Free Guard" } |> Some
      | 1000230 -> { NameData.id= 1000230; name= "Red and Silver Hand" } |> Some
      | 1000252 -> { NameData.id= 1000252; name= "Vherokior Combat Logistics" } |> Some
      | 1000263 -> { NameData.id= 1000263; name= "Republic Command" } |> Some
      | 1000274 -> { NameData.id= 1000274; name= "Vigilant Tyrannos" } |> Some
      | 1000285 -> { NameData.id= 1000285; name= "Federal Strategic Materiel" } |> Some
      | _ -> None