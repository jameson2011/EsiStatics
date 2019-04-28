namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups27=
    let getGroup id = 
      match id with 
      | 1191 -> { GroupData.id= 1191; name= "Micro Jump Drive Blueprint"; categoryId= 9; published= true; typeIds= [| 4384; 33916 |] } |> Some
      | 1288 -> { GroupData.id= 1288; name= "Ghost Sites Mordu's Legion"; categoryId= 11; published= true; typeIds= [| 33886; 33887; 33888 |] } |> Some
      | 1579 -> { GroupData.id= 1579; name= "Structure Assembly Rig M - Medium Tech I Ship"; categoryId= 66; published= false; typeIds= [|  |] } |> Some
      | 1676 -> { GroupData.id= 1676; name= "Named Components"; categoryId= 4; published= true; typeIds= [| 41263; 41264; 41265; 41266; 41267; 41268; 41269; 41302; 41303; 41304; 41305; 41306; 41307; 41308; 41309; 41310; 41311; 41312 |] } |> Some
      | 1773 -> { GroupData.id= 1773; name= "Information Command Burst Charges"; categoryId= 8; published= true; typeIds= [| 42835; 42836; 42837 |] } |> Some
      | 1870 -> { GroupData.id= 1870; name= "Structure Engineering Rig XL - Laboratory Optimization"; categoryId= 66; published= true; typeIds= [| 37182; 37183 |] } |> Some
      | 1967 -> { GroupData.id= 1967; name= "Structure Capacitor Power Relay"; categoryId= 66; published= true; typeIds= [| 47356; 47358 |] } |> Some
      | 27 -> { GroupData.id= 27; name= "Battleship"; categoryId= 6; published= true; typeIds= [| 638; 639; 640; 641; 642; 643; 644; 645; 1912; 1914; 1916; 1918; 4005; 11936; 11938; 13202; 17636; 17726; 17728; 17732; 17736; 17738; 17740; 17918; 17920; 24688; 24690; 24692; 24694; 26840; 26842; 32305; 32307; 32309; 32311; 33472; 33623; 33625; 33627; 33629; 33631; 33633; 33635; 33637; 33820; 34118; 34151; 34213; 34215; 34217; 34225; 34227; 34229; 34237; 34239; 34247; 34249; 34251; 34441; 34457; 34459; 34461; 34463; 34465; 34467; 34469; 34471; 47271; 47466 |] } |> Some
      | 318 -> { GroupData.id= 318; name= "Landmark"; categoryId= 2; published= false; typeIds= [| 11367 |] } |> Some
      | 512 -> { GroupData.id= 512; name= "Missile Launcher Defender"; categoryId= 7; published= true; typeIds= [| 44102 |] } |> Some
      | 706 -> { GroupData.id= 706; name= "Mission Minmatar Republic Battleship"; categoryId= 11; published= false; typeIds= [| 2916; 12389; 15327; 15341; 20333; 20459; 20460; 20461; 24867; 24868; 24869; 24870; 24875; 24876; 24883; 24884; 24886; 24888; 28181; 28182; 29698; 29700; 29701; 29702; 29703; 29704; 29705; 29706; 29707; 32293 |] } |> Some
      | 803 -> { GroupData.id= 803; name= "Deadspace Rogue Drone Cruiser"; categoryId= 11; published= false; typeIds= [| 3745; 3746; 18076; 18077; 18078; 18082; 18083; 18084; 22148; 22280; 22281; 22282; 22283; 22729; 23487; 23488; 23491; 23492; 23493; 23494; 23495; 23496; 23686; 23687; 23921; 23922; 23923; 23924; 26269; 45636 |] } |> Some
      | 900 -> { GroupData.id= 900; name= "Marauder"; categoryId= 6; published= true; typeIds= [| 28659; 28661; 28665; 28710; 34219; 34221; 34223; 34231; 34233; 34235; 34241; 34243; 34245; 34253; 34255; 34257; 47727; 47728 |] } |> Some
      | 997 -> { GroupData.id= 997; name= "Sleeper Hull Relics"; categoryId= 34; published= true; typeIds= [| 30752; 30753; 30754; 34412; 34414; 34416 |] } |> Some
      | _ -> None