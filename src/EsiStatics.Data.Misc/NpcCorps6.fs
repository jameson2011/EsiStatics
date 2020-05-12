namespace EsiStatics.Data.Misc
open System
open EsiStatics.Data.Entities
module internal NpcCorps6=
    let getNpcCorp id = 
      match id with 
      | 1000005 -> { NameData.id= 1000005; name= "Hyasyoda Corporation" } |> Some
      | 1000016 -> { NameData.id= 1000016; name= "Zainou" } |> Some
      | 1000027 -> { NameData.id= 1000027; name= "Expert Housing" } |> Some
      | 1000038 -> { NameData.id= 1000038; name= "Ishukone Watch" } |> Some
      | 1000049 -> { NameData.id= 1000049; name= "Brutor Tribe" } |> Some
      | 1000060 -> { NameData.id= 1000060; name= "Native Freshfood" } |> Some
      | 1000071 -> { NameData.id= 1000071; name= "Inherent Implants" } |> Some
      | 1000082 -> { NameData.id= 1000082; name= "Ministry of Internal Order" } |> Some
      | 1000093 -> { NameData.id= 1000093; name= "Theology Council" } |> Some
      | 1000104 -> { NameData.id= 1000104; name= "Poteque Pharmaceuticals" } |> Some
      | 1000115 -> { NameData.id= 1000115; name= "University of Caille" } |> Some
      | 1000126 -> { NameData.id= 1000126; name= "Ammatar Consulate" } |> Some
      | 1000137 -> { NameData.id= 1000137; name= "DED" } |> Some
      | 1000148 -> { NameData.id= 1000148; name= "InterBus" } |> Some
      | 1000159 -> { NameData.id= 1000159; name= "The Sanctuary" } |> Some
      | 1000170 -> { NameData.id= 1000170; name= "Republic Military School" } |> Some
      | 1000181 -> { NameData.id= 1000181; name= "Federal Defense Union" } |> Some
      | 1000214 -> { NameData.id= 1000214; name= "Seituoda Taskforce Command" } |> Some
      | 1000225 -> { NameData.id= 1000225; name= "Paladin Survey Force" } |> Some
      | 1000236 -> { NameData.id= 1000236; name= "Storm Wind Strikeforce" } |> Some
      | 1000247 -> { NameData.id= 1000247; name= "Chatelain Rapid Response" } |> Some
      | 1000258 -> { NameData.id= 1000258; name= "Seykal Expeditionary Group" } |> Some
      | 1000280 -> { NameData.id= 1000280; name= "CONCORD Aerospace" } |> Some
      | 1000291 -> { NameData.id= 1000291; name= "Scylla Infestation" } |> Some
      | _ -> None