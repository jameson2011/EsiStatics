﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups92=
    let getGroup id = 
      match id with 
      | 1159 -> { GroupData.id= 1159; name= "Salvage Drone"; categoryId= 18; published= true; typeIds= [| 32787; 44274; 55760; 55761 |] } |> Some
      | 1547 -> { GroupData.id= 1547; name= "Structure Anti-Subcapital Missile"; categoryId= 8; published= true; typeIds= [| 37846; 37847; 37848 |] } |> Some
      | 1838 -> { GroupData.id= 1838; name= "Structure Engineering Rig M - Basic Capital Component TE"; categoryId= 66; published= true; typeIds= [| 43872; 43873 |] } |> Some
      | 1935 -> { GroupData.id= 1935; name= "Structure Hybrid Reactor Rig M - TE"; categoryId= 66; published= true; typeIds= [| 46488; 46489 |] } |> Some
      | 286 -> { GroupData.id= 286; name= "Minor Threat"; categoryId= 11; published= false; typeIds= [| 2010; 2052; 3548; 30365; 30366; 30369; 30379; 30380; 30381; 32471; 34579; 34588; 34589; 43922; 43923; 43924 |] } |> Some
      | 383 -> { GroupData.id= 383; name= "Destructible Sentry Gun"; categoryId= 11; published= false; typeIds= [| 13068; 13113; 13114; 13115; 13116; 16739; 16740; 16741; 16742; 16743; 16744; 16745; 16746; 16747; 17144; 17145; 17146; 17147; 17148; 17149; 17150; 17151; 17152; 17153; 17154; 17155; 17156; 17157; 17158; 17159; 17160; 17161; 17163; 17164; 17568; 17569; 17570; 17571; 17572; 17573; 17574; 17575; 17576; 17577; 17578; 17579; 17580; 17581; 17582; 17583; 17584; 17585; 17586; 17587; 17588; 17589; 17590; 17591; 17592; 17593; 17594; 17595; 17596; 17597; 17598; 17599; 17600; 17601; 17602; 17603; 17605; 17606; 17607; 17608; 17609; 17610; 17611; 17612; 17638; 17875; 17876; 17877; 17878; 17879; 17880; 18000; 18001; 18023; 18026; 18027; 18028; 18031; 18032; 18033; 18034; 18035; 19664; 19665; 19666; 19667; 19668; 19669; 19670; 21744; 21745; 21746; 21747; 21748; 21749; 22848; 24767; 24772; 25385; 25626; 25706; 25817; 25827; 25840; 26709; 26747; 26856; 26857; 26858; 27280; 27281; 27282; 27283; 27284; 27285; 27668; 27669; 27670; 27765; 27792; 27793; 27794; 27795; 27796; 27797; 27798; 27799; 27800; 27953; 27954; 27955; 27956; 28139; 28140; 28141; 28142; 28143; 28144; 28145; 28146; 28147; 28148; 28149; 28150; 28151; 28152; 28153; 28571; 28572; 28573; 28574; 28575; 30460; 30461; 30462; 34437; 34454; 34455; 34873; 35663; 47488; 48594; 50023; 53084; 54577; 54578; 54579; 54580 |] } |> Some
      | 4069 -> { GroupData.id= 4069; name= "Vorton Projector Upgrade Blueprints"; categoryId= 9; published= true; typeIds= [| 54873; 54874; 54876 |] } |> Some
      | 480 -> { GroupData.id= 480; name= "Stealth Emitter Array"; categoryId= 23; published= false; typeIds= [| 17899; 18586 |] } |> Some
      | 577 -> { GroupData.id= 577; name= "Asteroid Blood Raiders Destroyer"; categoryId= 11; published= false; typeIds= [| 23245; 23246; 23247; 23248; 23249; 23250 |] } |> Some
      | 674 -> { GroupData.id= 674; name= "Mission Caldari State Battleship"; categoryId= 11; published= false; typeIds= [| 12391; 15326; 15338; 20334; 25083; 25084; 25085; 25086; 25089; 25090; 25092; 25094; 25097; 25098; 25389; 25814; 28171; 28174; 29679; 29680; 29681; 29682; 29683; 29684; 29685; 29686; 29687; 30790; 30791; 30792; 32296; 32297 |] } |> Some
      | 771 -> { GroupData.id= 771; name= "Missile Launcher Heavy Assault"; categoryId= 7; published= true; typeIds= [| 20138; 25707; 25709; 25711; 25713; 25715; 28375; 28377; 28379; 28381; 28383; 28565; 34292 |] } |> Some
      | 868 -> { GroupData.id= 868; name= "Mission Minmatar Republic Carrier"; categoryId= 11; published= false; typeIds= [| 27721 |] } |> Some
      | 92 -> { GroupData.id= 92; name= "Mine"; categoryId= 8; published= false; typeIds= [| 270; 3733; 3735; 3737 |] } |> Some
      | 965 -> { GroupData.id= 965; name= "Hybrid Component Blueprints"; categoryId= 9; published= true; typeIds= [| 29993; 29995; 29997; 30003; 30009; 30465; 30467; 30471; 30475; 30477; 30479; 34397; 45656; 45657; 45658; 45659 |] } |> Some
      | _ -> None