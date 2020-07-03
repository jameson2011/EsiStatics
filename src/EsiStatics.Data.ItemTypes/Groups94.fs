namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups94=
    let getGroup id = 
      match id with 
      | 1452 -> { GroupData.id= 1452; name= "Irregular Drone"; categoryId= 11; published= false; typeIds= [| 48929; 48930; 48931; 48932 |] } |> Some
      | 1549 -> { GroupData.id= 1549; name= "Structure ECM script"; categoryId= 8; published= true; typeIds= [| 37821; 37822; 37823; 37824 |] } |> Some
      | 1840 -> { GroupData.id= 1840; name= "Structure Engineering Rig M - Structure ME"; categoryId= 66; published= true; typeIds= [| 43874; 43875 |] } |> Some
      | 191 -> { GroupData.id= 191; name= "Physical Benefit"; categoryId= 14; published= false; typeIds= [| 1611; 1612; 1613; 1614; 1615; 1616; 1617; 1618; 1619; 1620; 1621; 1622; 1623; 1624; 1625; 1626; 1627 |] } |> Some
      | 1937 -> { GroupData.id= 1937; name= "Structure Biochemical Reactor Rig M - TE"; categoryId= 66; published= true; typeIds= [| 46492; 46493 |] } |> Some
      | 288 -> { GroupData.id= 288; name= "Faction Drone"; categoryId= 11; published= false; typeIds= [| 3883; 3886; 9997; 9998; 9999; 10000; 10001; 10003; 10046; 10047; 10048; 10050; 10052; 10053; 10054; 10056; 10057; 10058; 10060; 10076; 10077; 10078; 10079; 10080; 10082; 10083; 10084; 10085; 10086; 10089; 10090; 10091; 10092; 10095; 10106; 10107; 10108; 10109; 10111; 10112; 10113; 10125; 10126; 10133; 10134; 10650; 10651; 10652; 10653; 10654; 10655; 10656; 10657; 10658; 10663; 10664; 10669; 10670; 10676; 10677; 11127; 11137; 11138; 11139; 11140; 24265 |] } |> Some
      | 385 -> { GroupData.id= 385; name= "Heavy Missile"; categoryId= 8; published= true; typeIds= [| 206; 207; 208; 209; 2212; 27433; 27435; 27437; 27439; 27441; 27443; 27445; 27447; 27449; 27451; 27453; 27455; 27889; 27890; 30428; 52477 |] } |> Some
      | 4071 -> { GroupData.id= 4071; name= "Type Graveyard"; categoryId= 29; published= false; typeIds= [| 54790; 54793; 54824; 54825; 54839 |] } |> Some
      | 482 -> { GroupData.id= 482; name= "Mining Crystal"; categoryId= 8; published= true; typeIds= [| 18036; 18038; 18040; 18042; 18044; 18046; 18048; 18050; 18052; 18056; 18058; 18060; 18062; 18064; 18066; 18590; 18592; 18594; 18596; 18598; 18600; 18602; 18604; 18606; 18610; 18612; 18614; 18616; 18618; 18624; 46355; 46356; 46365; 46366; 46367; 46368; 46369; 46370; 46371; 46372 |] } |> Some
      | 579 -> { GroupData.id= 579; name= "Asteroid Guristas Destroyer"; categoryId= 11; published= false; typeIds= [| 23312; 23313; 23314; 23315; 23328; 23329; 23940; 23941 |] } |> Some
      | 676 -> { GroupData.id= 676; name= "Mission Caldari State Destroyer"; categoryId= 11; published= false; typeIds= [| 25020; 25021; 25022; 25024; 25026; 25028; 45462 |] } |> Some
      | 773 -> { GroupData.id= 773; name= "Rig Armor"; categoryId= 7; published= true; typeIds= [| 25736; 25888; 25890; 25892; 25894; 25896; 25898; 25900; 26286; 26288; 26290; 26292; 26294; 26296; 26298; 26302; 27064; 27066; 27068; 30987; 30993; 30997; 30999; 31001; 31003; 31005; 31007; 31009; 31011; 31013; 31015; 31017; 31019; 31021; 31023; 31025; 31027; 31029; 31031; 31033; 31035; 31037; 31039; 31041; 31043; 31045; 31047; 31049; 31051; 31053; 31055; 31057; 31059; 31061; 31063; 31065; 31067; 31069; 31071; 31073; 31075; 31077; 31079; 31081; 33890; 33892; 33894; 33896; 33898; 33900; 33902; 33904 |] } |> Some
      | 870 -> { GroupData.id= 870; name= "Remote Hull Repairer Blueprint"; categoryId= 9; published= true; typeIds= [| 3991; 4298; 4300; 27905; 27931; 27933; 27935; 41631 |] } |> Some
      | 94 -> { GroupData.id= 94; name= "Trading"; categoryId= 10; published= false; typeIds= [| 52 |] } |> Some
      | 967 -> { GroupData.id= 967; name= "Wormhole Minerals"; categoryId= 4; published= false; typeIds= [| 29998; 30000; 30016; 30017; 30020; 30023; 30025; 30027; 30247; 30249; 30250; 30253; 30255; 30256; 30257; 30260; 30261; 30262; 30263; 30264; 30265; 30266; 30267; 30272; 30312; 30313; 30314; 30315; 30316; 30317; 30318; 30319; 30320; 30321; 30322 |] } |> Some
      | _ -> None