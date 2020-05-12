namespace EsiStatics.Data.Misc
open System
open EsiStatics.Data.Entities
module internal NpcCorps5=
    let getNpcCorp id = 
      match id with 
      | 1000004 -> { NameData.id= 1000004; name= "Ytiri" } |> Some
      | 1000015 -> { NameData.id= 1000015; name= "Caldari Steel" } |> Some
      | 1000026 -> { NameData.id= 1000026; name= "Caldari Constructions" } |> Some
      | 1000037 -> { NameData.id= 1000037; name= "Lai Dai Protection Service" } |> Some
      | 1000048 -> { NameData.id= 1000048; name= "Vherokior Tribe" } |> Some
      | 1000059 -> { NameData.id= 1000059; name= "Six Kin Development" } |> Some
      | 1000070 -> { NameData.id= 1000070; name= "HZO Refinery" } |> Some
      | 1000081 -> { NameData.id= 1000081; name= "Ministry of Assessment" } |> Some
      | 1000092 -> { NameData.id= 1000092; name= "Civic Court" } |> Some
      | 1000103 -> { NameData.id= 1000103; name= "Allotek Industries" } |> Some
      | 1000114 -> { NameData.id= 1000114; name= "Garoun Investment Bank" } |> Some
      | 1000125 -> { NameData.id= 1000125; name= "CONCORD" } |> Some
      | 1000136 -> { NameData.id= 1000136; name= "Guardian Angels" } |> Some
      | 1000147 -> { NameData.id= 1000147; name= "Intaki Syndicate" } |> Some
      | 1000158 -> { NameData.id= 1000158; name= "Shapeset" } |> Some
      | 1000169 -> { NameData.id= 1000169; name= "Center for Advanced Studies" } |> Some
      | 1000180 -> { NameData.id= 1000180; name= "State Protectorate" } |> Some
      | 1000213 -> { NameData.id= 1000213; name= "Osmon Surveillance" } |> Some
      | 1000224 -> { NameData.id= 1000224; name= "Shining Flame" } |> Some
      | 1000235 -> { NameData.id= 1000235; name= "Kirkinen Risk Control" } |> Some
      | 1000246 -> { NameData.id= 1000246; name= "Sinq Laison Gendarmes" } |> Some
      | 1000257 -> { NameData.id= 1000257; name= "Forty-Nine Fedayeen" } |> Some
      | 1000279 -> { NameData.id= 1000279; name= "Project Discovery" } |> Some
      | 1000290 -> { NameData.id= 1000290; name= "Karybdis Infestation" } |> Some
      | 1000301 -> { NameData.id= 1000301; name= "Vimoksha Chorus" } |> Some
      | _ -> None