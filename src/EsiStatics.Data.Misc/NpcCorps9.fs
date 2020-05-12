namespace EsiStatics.Data.Misc
open System
open EsiStatics.Data.Entities
module internal NpcCorps9=
    let getNpcCorp id = 
      match id with 
      | 1000008 -> { NameData.id= 1000008; name= "Minedrill" } |> Some
      | 1000019 -> { NameData.id= 1000019; name= "Ishukone Corporation" } |> Some
      | 1000030 -> { NameData.id= 1000030; name= "Modern Finances" } |> Some
      | 1000041 -> { NameData.id= 1000041; name= "Spacelane Patrol" } |> Some
      | 1000052 -> { NameData.id= 1000052; name= "Republic Justice Department" } |> Some
      | 1000063 -> { NameData.id= 1000063; name= "Amarr Constructions" } |> Some
      | 1000074 -> { NameData.id= 1000074; name= "Joint Harvesting" } |> Some
      | 1000085 -> { NameData.id= 1000085; name= "Court Chamberlain" } |> Some
      | 1000096 -> { NameData.id= 1000096; name= "Inner Zone Shipping" } |> Some
      | 1000107 -> { NameData.id= 1000107; name= "The Scope" } |> Some
      | 1000118 -> { NameData.id= 1000118; name= "Supreme Court" } |> Some
      | 1000129 -> { NameData.id= 1000129; name= "Outer Ring Excavations" } |> Some
      | 1000140 -> { NameData.id= 1000140; name= "Genolution" } |> Some
      | 1000151 -> { NameData.id= 1000151; name= "Khanid Innovation" } |> Some
      | 1000162 -> { NameData.id= 1000162; name= "True Power" } |> Some
      | 1000173 -> { NameData.id= 1000173; name= "Polaris Corporation" } |> Some
      | 1000206 -> { NameData.id= 1000206; name= "Royal Uhlans" } |> Some
      | 1000217 -> { NameData.id= 1000217; name= "Villore Sec Ops" } |> Some
      | 1000228 -> { NameData.id= 1000228; name= "Tal-Romon Legion" } |> Some
      | 1000239 -> { NameData.id= 1000239; name= "Intara Direct Action" } |> Some
      | 1000250 -> { NameData.id= 1000250; name= "Condotta Rouvenor" } |> Some
      | 1000261 -> { NameData.id= 1000261; name= "State Peacekeepers" } |> Some
      | 1000283 -> { NameData.id= 1000283; name= "Imperial War Reserves" } |> Some
      | 1000294 -> { NameData.id= 1000294; name= "Svarog Clade" } |> Some
      | _ -> None