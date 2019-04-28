namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups48=
    let getGroup id = 
      match id with 
      | 1212 -> { GroupData.id= 1212; name= "Personal Hangar"; categoryId= 23; published= true; typeIds= [| 33149 |] } |> Some
      | 1309 -> { GroupData.id= 1309; name= "Tactical Destroyer Blueprint"; categoryId= 9; published= true; typeIds= [| 34318; 34563; 34829; 35684 |] } |> Some
      | 1406 -> { GroupData.id= 1406; name= "Refinery"; categoryId= 65; published= true; typeIds= [| 35835; 35836 |] } |> Some
      | 145 -> { GroupData.id= 145; name= "Stasis Web Blueprint"; categoryId= 9; published= true; typeIds= [| 1102; 1103; 17501; 17561; 28515; 30329; 41221; 41222 |] } |> Some
      | 1600 -> { GroupData.id= 1600; name= "Structure Laboratory Rig M - Large Ship"; categoryId= 66; published= false; typeIds= [| 37188; 37475 |] } |> Some
      | 1697 -> { GroupData.id= 1697; name= "Ancillary Remote Shield Booster"; categoryId= 7; published= true; typeIds= [| 41480; 41481; 41482; 41483 |] } |> Some
      | 1794 -> { GroupData.id= 1794; name= "Hidden Zenith Caldari Frigate"; categoryId= 11; published= false; typeIds= [| 42822 |] } |> Some
      | 1891 -> { GroupData.id= 1891; name= "Depricated Subsystem Blueprints"; categoryId= 9; published= false; typeIds= [| 30037; 30039; 30041; 30043; 30047; 30049; 30051; 30053; 30057; 30059; 30061; 30063; 30067; 30069; 30071; 30073; 30077; 30079; 30081; 30083; 30087; 30089; 30091; 30093; 30097; 30099; 30101; 30103; 30107; 30109; 30111; 30113; 30140; 30142; 30144; 30146; 30150; 30152; 30154; 30156; 30160; 30162; 30164; 30166; 30170; 30172; 30174; 30176; 30227; 30228; 30229; 30230; 30232; 30233; 30234; 30235; 30237; 30238; 30239; 30240; 30242; 30243; 30244; 30245; 30392; 30393; 30394; 30395; 30397; 30398; 30399; 30400; 30402; 30403; 30404; 30405; 30407; 30408; 30409; 30410 |] } |> Some
      | 1988 -> { GroupData.id= 1988; name= "Entropic Radiation Sink"; categoryId= 7; published= true; typeIds= [| 47908; 47909; 47911; 49734 |] } |> Some
      | 339 -> { GroupData.id= 339; name= "Auxiliary Power Core"; categoryId= 7; published= true; typeIds= [| 4254; 11563; 16537; 16539; 16541; 16543; 28740; 31936 |] } |> Some
      | 436 -> { GroupData.id= 436; name= "Simple Reaction"; categoryId= 24; published= true; typeIds= [| 17941; 17942; 17943; 17944; 17945; 17946; 17947; 17948; 17949; 17950; 17951; 17952; 17953; 17954; 17955; 17956; 17957; 17958; 17961; 20432; 29640; 29641; 29642; 29643; 29644; 29645; 32830; 32831; 32832; 32833; 32834; 32835; 32836; 32837; 32838; 33340; 33341; 33342; 33343 |] } |> Some
      | 48 -> { GroupData.id= 48; name= "Ship Scanner"; categoryId= 7; published= true; typeIds= [| 443; 1855; 6525; 6527; 6529; 6531; 12604 |] } |> Some
      | 533 -> { GroupData.id= 533; name= "Storyline Mission Cruiser"; categoryId= 11; published= false; typeIds= [| 20549; 20552; 21049; 21056; 21061; 21063; 21065; 21068; 21090; 21092; 21101; 21103; 21515; 21597; 21630; 21643; 21647; 21648; 21649; 21650; 21651; 21652; 21670; 21675; 21786; 21787; 21859; 21881; 21882; 21887; 21972; 22042; 22052; 22057; 22058; 22076; 22082; 22088; 22091; 22094; 22104; 22105; 22160; 22171; 22233; 22237; 22239; 22250; 22253; 22322; 23233; 23235; 23422; 23596; 23598; 23601; 23609; 23614; 23628; 23685; 23951; 23965; 24261; 24307; 24661; 25576; 26741; 26744; 26748; 26795; 26859; 26867; 26878; 26879; 26880; 26883 |] } |> Some
      | 630 -> { GroupData.id= 630; name= "Deadspace Serpentis Battleship"; categoryId= 11; published= false; typeIds= [| 17034; 17036; 17037; 17038; 17049; 17050; 17051; 17052; 17053; 17054; 24165; 24166; 24167; 24168; 24169; 24170; 24171; 24172; 24173; 24174 |] } |> Some
      | 727 -> { GroupData.id= 727; name= "Mining Crystal Blueprint"; categoryId= 9; published= true; typeIds= [| 18037; 18039; 18041; 18043; 18045; 18047; 18049; 18051; 18053; 18055; 18057; 18059; 18061; 18063; 18065; 18067; 18591; 18593; 18595; 18597; 18599; 18601; 18603; 18605; 18607; 18609; 18611; 18613; 18615; 18617; 18619; 18625; 46350; 46351; 46352; 46353; 46357; 46358; 46359; 46360; 46361; 46362 |] } |> Some
      | 824 -> { GroupData.id= 824; name= "Mission Thukker Cruiser"; categoryId= 11; published= false; typeIds= [| 23956; 23957 |] } |> Some
      | _ -> None