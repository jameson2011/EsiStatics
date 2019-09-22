﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups45=
    let getGroup id = 
      match id with 
      | 1112 -> { GroupData.id= 1112; name= "Spot Lights"; categoryId= 54; published= true; typeIds= [| 32635 |] } |> Some
      | 1209 -> { GroupData.id= 1209; name= "Shields"; categoryId= 16; published= true; typeIds= [| 3416; 3419; 3420; 3422; 3425; 11206; 11566; 12365; 12366; 12367; 21059; 21802; 24571; 44067 |] } |> Some
      | 1306 -> { GroupData.id= 1306; name= "Ship Modifiers"; categoryId= 7; published= true; typeIds= [| 34319; 34321; 34323; 34564; 34566; 34570; 35676; 35677; 35678; 35686; 35687; 35688 |] } |> Some
      | 142 -> { GroupData.id= 142; name= "Armor Repair Unit Blueprint"; categoryId= 9; published= true; typeIds= [| 1099; 1184; 3529; 3531; 3535; 3539; 3541; 20702; 21854; 22888; 22890; 22892; 23796; 23798; 23800; 41614; 41615; 41616; 41618; 41619 |] } |> Some
      | 1694 -> { GroupData.id= 1694; name= "OLD Structure Resource Rig M - Ice 1 Reprocessing"; categoryId= 66; published= false; typeIds= [| 41424; 41425 |] } |> Some
      | 1791 -> { GroupData.id= 1791; name= "Hidden Zenith Amarr Frigate"; categoryId= 11; published= false; typeIds= [| 42819; 50104 |] } |> Some
      | 1888 -> { GroupData.id= 1888; name= "Composite Reaction Formulas"; categoryId= 9; published= true; typeIds= [| 45732; 46166; 46167; 46168; 46169; 46170; 46171; 46172; 46173; 46174; 46175; 46176; 46177; 46178; 46179; 46180; 46181; 46182; 46183; 46184; 46185; 46186; 46187; 46188; 46189; 46190; 46191; 46192; 46193; 46194; 46195; 46196; 46197; 46198; 46199; 46200; 46201; 46202; 46203; 46204; 46205; 46206; 46207; 46208; 46209; 46210; 46211; 46212; 46213; 46214; 46215; 46216; 46217; 46218 |] } |> Some
      | 336 -> { GroupData.id= 336; name= "Mobile Sentry Gun"; categoryId= 2; published= false; typeIds= [| 10648; 10665; 10666; 10667; 10668; 10766; 10767; 10768; 10769; 10770; 11580 |] } |> Some
      | 530 -> { GroupData.id= 530; name= "Materials and Compounds"; categoryId= 17; published= true; typeIds= [| 20110; 21073; 21075; 21078; 21081; 21086; 21089; 21584; 21585; 21586; 21587; 21588; 21589; 21590; 21591; 21592; 21593; 21594; 21595; 21596; 23138; 23139; 23140; 23141; 23142; 23143; 23144; 23145; 23146; 23147; 23158; 23159; 23160; 23161; 23162; 23163; 23164; 23165; 23166; 23167; 28867 |] } |> Some
      | 724 -> { GroupData.id= 724; name= "Implant Blueprints"; categoryId= 9; published= true; typeIds= [| 11074; 33536; 33543; 33545; 33546; 33547; 33548; 33556; 33558; 33560; 33562; 33564; 33566; 52684; 52685; 52686; 52687; 52688; 52689 |] } |> Some
      | 821 -> { GroupData.id= 821; name= "Deadspace Overseer Battleship"; categoryId= 11; published= false; typeIds= [| 3821; 3823; 3825; 3827; 15396; 15413; 15414; 15415; 17141; 17142; 17162; 17412; 17413; 17744; 17745; 17746; 17749; 17900; 17973; 18565; 19423; 19424; 19592; 19620; 19701; 19704; 19731; 20078; 20079; 20080; 20173; 20174; 22716; 22759; 25374; 25407; 25549; 25578; 25581; 25808; 25818; 25848; 25865; 25870; 25873; 25881; 25884; 25886; 25995; 26118; 26119; 26264; 26679; 26683; 26689; 26692; 26694; 26714; 26716; 26745; 26749; 26757; 26769; 26770; 26771; 26772; 26793; 26796; 26797; 26798; 26799; 26800; 26801; 26802; 26803; 26807; 26810; 26812; 26818; 26832; 26833; 26844; 26881; 28506; 28507; 28509; 28863; 28864 |] } |> Some
      | 918 -> { GroupData.id= 918; name= "Scan Probe Launcher Blueprint"; categoryId= 9; published= true; typeIds= [| 4259; 4261; 17902; 17939; 18640; 25772; 28613; 28757; 28759 |] } |> Some
      | _ -> None