namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups95=
    let getGroup id = 
      match id with 
      | 1162 -> { GroupData.id= 1162; name= "Container Blueprints"; categoryId= 9; published= true; typeIds= [| 27309; 32858; 32859; 32860; 32861; 32862; 32863; 32864; 32865; 32866; 32867; 32868; 32869; 32870; 32871; 33004; 33006; 33008; 33010; 33012 |] } |> Some
      | 1259 -> { GroupData.id= 1259; name= "Ghost Sites Guristas Cruiser"; categoryId= 11; published= true; typeIds= [| 33499; 33500; 33501; 33502 |] } |> Some
      | 1453 -> { GroupData.id= 1453; name= "Irregular EW Drone"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 1550 -> { GroupData.id= 1550; name= "Structure Stasis Webifier Script"; categoryId= 8; published= false; typeIds= [|  |] } |> Some
      | 1647 -> { GroupData.id= 1647; name= "OLD Structure Resource Rig M - HS Ore Reprocessing"; categoryId= 66; published= false; typeIds= [| 37280; 37281 |] } |> Some
      | 1841 -> { GroupData.id= 1841; name= "Structure Engineering Rig M - Structure TE"; categoryId= 66; published= true; typeIds= [| 43876; 43877 |] } |> Some
      | 192 -> { GroupData.id= 192; name= "Physical Handicap"; categoryId= 14; published= false; typeIds= [| 1636; 1639; 1640; 1641; 1642; 1643; 1644 |] } |> Some
      | 1938 -> { GroupData.id= 1938; name= "Structure Biochemical Reactor Rig M - ME"; categoryId= 66; published= true; typeIds= [| 46494; 46495 |] } |> Some
      | 289 -> { GroupData.id= 289; name= "Projected ECCM"; categoryId= 7; published= true; typeIds= [| 1959; 1960; 7217; 7218; 7219; 7220 |] } |> Some
      | 386 -> { GroupData.id= 386; name= "Cruise Missile"; categoryId= 8; published= true; typeIds= [| 202; 203; 204; 205; 2165; 17908; 27373; 27377; 27389; 27391; 27395; 27399; 27409; 27423; 27425; 27427; 27429; 27431; 27893; 27894; 30426 |] } |> Some
      | 483 -> { GroupData.id= 483; name= "Frequency Mining Laser"; categoryId= 7; published= true; typeIds= [| 17912; 18068; 24305 |] } |> Some
      | 580 -> { GroupData.id= 580; name= "Asteroid Guristas BattleCruiser"; categoryId= 11; published= false; typeIds= [| 23321; 23322; 23323; 23324; 23325; 23326 |] } |> Some
      | 677 -> { GroupData.id= 677; name= "Mission Gallente Federation Frigate"; categoryId= 11; published= false; typeIds= [| 11666; 13112; 14353; 14361; 14481; 15345; 15580; 15988; 15989; 15990; 15991; 21840; 22706; 25103; 25105; 25106; 25107; 25110; 25112; 25116; 25117; 25118; 25120; 25124; 25137; 25138; 25139; 25140; 25141; 25142; 25143; 25144; 25145; 25146; 29831; 29859; 29863; 29864; 29865; 29866; 29867; 29868; 29869; 29870; 29871; 29872; 29873; 29874; 29875; 45464 |] } |> Some
      | 774 -> { GroupData.id= 774; name= "Rig Shield"; categoryId= 7; published= true; typeIds= [| 25906; 26076; 26078; 26080; 26082; 26084; 26086; 26088; 26090; 26436; 26438; 26440; 26442; 26444; 26446; 26448; 26450; 26452; 26964; 26966; 31716; 31718; 31720; 31722; 31724; 31726; 31728; 31730; 31732; 31734; 31736; 31738; 31740; 31742; 31744; 31746; 31748; 31750; 31752; 31754; 31756; 31758; 31760; 31762; 31764; 31766; 31768; 31770; 31772; 31774; 31776; 31778; 31780; 31782; 31784; 31786; 31788; 31790; 31792; 31794; 31796; 31798; 31800; 31802; 31804; 31810; 31812; 31814; 31816; 31818; 31820; 31822; 31824; 31826 |] } |> Some
      | 871 -> { GroupData.id= 871; name= "Starbase - Missile Battery Blueprints"; categoryId= 9; published= true; typeIds= [| 2822; 2823; 2824; 27944; 27945; 27946; 27947; 27948; 27949 |] } |> Some
      | 95 -> { GroupData.id= 95; name= "Trade Session"; categoryId= 10; published= false; typeIds= [| 53 |] } |> Some
      | _ -> None