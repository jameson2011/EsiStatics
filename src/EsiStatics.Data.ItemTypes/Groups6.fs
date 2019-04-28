namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups6=
    let getGroup id = 
      match id with 
      | 1073 -> { GroupData.id= 1073; name= "Test Orbitals"; categoryId= 46; published= false; typeIds= [| 3522 |] } |> Some
      | 1267 -> { GroupData.id= 1267; name= "Mobile Siphon Unit Blueprint"; categoryId= 9; published= true; typeIds= [| 33515; 33582; 33584 |] } |> Some
      | 1461 -> { GroupData.id= 1461; name= "Unknown Blueprint"; categoryId= 9; published= false; typeIds= [| 36949 |] } |> Some
      | 1849 -> { GroupData.id= 1849; name= "Structure Engineering Rig M - Blueprint Copy Accelerator"; categoryId= 66; published= true; typeIds= [| 43892; 43893 |] } |> Some
      | 297 -> { GroupData.id= 297; name= "Convoy"; categoryId= 11; published= false; typeIds= [| 10043; 10044; 10045; 10114; 10115; 10116; 10117; 10118; 10823; 10824; 10825; 10826; 10827; 10828; 10829; 10830; 10831; 10832; 10833; 10834; 20716; 20717; 20718; 20719 |] } |> Some
      | 394 -> { GroupData.id= 394; name= "Auto-Targeting Light Missile"; categoryId= 8; published= true; typeIds= [| 269; 1810; 1814; 1816; 27505; 27507; 27509; 27511; 27513; 27515; 27517; 27519; 27521; 27523; 27525; 27527 |] } |> Some
      | 588 -> { GroupData.id= 588; name= "Super Weapon"; categoryId= 7; published= true; typeIds= [| 23674; 24550; 24552; 24554; 37474; 40631; 40632; 40633; 40634; 41439; 41440; 41441; 41442; 41443; 41444; 42522 |] } |> Some
      | 6 -> { GroupData.id= 6; name= "Sun"; categoryId= 2; published= false; typeIds= [| 6; 7; 8; 9; 10; 3796; 3797; 3798; 3799; 3800; 3801; 3802; 3803; 34331; 45030; 45031; 45032; 45033; 45034; 45035; 45036; 45037; 45038; 45039; 45040; 45041; 45042; 45046; 45047 |] } |> Some
      | 685 -> { GroupData.id= 685; name= "Mission Minmatar Republic Battlecruiser"; categoryId= 11; published= false; typeIds= [| 24843; 24847; 24848; 24851; 24855; 24857; 28179; 28180 |] } |> Some
      | 782 -> { GroupData.id= 782; name= "Rig Navigation"; categoryId= 7; published= true; typeIds= [| 26056; 26058; 26060; 26062; 26064; 26066; 26068; 26070; 26072; 26304; 26306; 26308; 26310; 26312; 26314; 26318; 26320; 26322; 31105; 31107; 31109; 31111; 31113; 31115; 31117; 31119; 31121; 31123; 31125; 31127; 31129; 31131; 31133; 31135; 31137; 31139; 31141; 31143; 31145; 31147; 31149; 31151; 31153; 31155; 31157; 31159; 31161; 31163; 31165; 31167; 31169; 31171; 31173; 31175; 31177; 31179; 31181; 31183; 31185; 31187; 31189; 31191; 31193; 31195; 31197; 31199 |] } |> Some
      | 879 -> { GroupData.id= 879; name= "Slave Reception"; categoryId= 17; published= true; typeIds= [| 18029 |] } |> Some
      | 976 -> { GroupData.id= 976; name= "Festival Charges Expired"; categoryId= 63; published= true; typeIds= [| 19658; 30222 |] } |> Some
      | _ -> None