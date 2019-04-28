namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups50=
    let getGroup id = 
      match id with 
      | 1020 -> { GroupData.id= 1020; name= "Industrial Upgrades"; categoryId= 39; published= true; typeIds= [| 2040; 2041; 2042; 2043; 2044; 2053; 2054; 2055; 2056; 2057 |] } |> Some
      | 1311 -> { GroupData.id= 1311; name= "Super Kerr-Induced Nanocoatings"; categoryId= 5; published= true; typeIds= [|  |] } |> Some
      | 1408 -> { GroupData.id= 1408; name= "Upwell Jump Gate"; categoryId= 65; published= true; typeIds= [| 35837; 35841 |] } |> Some
      | 147 -> { GroupData.id= 147; name= "Remote Capacitor Transmitter Blueprint"; categoryId= 9; published= true; typeIds= [| 1105; 1191; 3580; 12103; 12218; 12220; 12222; 12224; 12226; 23853; 23855; 23857; 31947; 31949; 31951; 41697; 41698 |] } |> Some
      | 1602 -> { GroupData.id= 1602; name= "Structure Laboratory Rig M - Consumable"; categoryId= 66; published= false; typeIds= [| 37192; 37193 |] } |> Some
      | 1699 -> { GroupData.id= 1699; name= "Flex Armor Hardener"; categoryId= 7; published= true; typeIds= [| 41515; 41525; 41526; 41527 |] } |> Some
      | 1796 -> { GroupData.id= 1796; name= "Hidden Zenith Gallente Cruiser"; categoryId= 11; published= false; typeIds= [| 42824 |] } |> Some
      | 1990 -> { GroupData.id= 1990; name= "Precursor Weapon Blueprint"; categoryId= 9; published= true; typeIds= [| 47969; 47970; 47971; 47972; 47973; 47974; 48469; 48470; 48471; 48472; 48473; 48474 |] } |> Some
      | 341 -> { GroupData.id= 341; name= "Signature Scrambling"; categoryId= 7; published= false; typeIds= [| 12711; 12713; 12715; 12717; 20367; 22885 |] } |> Some
      | 438 -> { GroupData.id= 438; name= "Mobile Reactor"; categoryId= 23; published= true; typeIds= [| 16869; 20175; 20176; 22634; 24684; 28318; 28319; 30656 |] } |> Some
      | 535 -> { GroupData.id= 535; name= "Construction Platform Blueprint"; categoryId= 9; published= true; typeIds= [| 21943; 21944; 21945; 21946; 27657; 27659; 27661; 27663; 27665; 27667; 27938; 27940; 27942; 27958; 27960; 27962; 27964; 27966; 27968; 27970; 27972; 27974; 27976; 27978; 27980; 27982; 27984; 27986; 27988; 27990; 27992; 27994; 27996; 27998; 28000; 28002; 28004; 28006; 28008; 28010; 28012; 28014; 28016; 28018; 28020; 28022; 28024; 28026; 28028; 28030; 28032; 28034; 28036; 28038; 28040; 28042; 28044; 28046; 28048; 28050; 28052; 28054; 28056; 28058; 28060; 28062; 28064 |] } |> Some
      | 632 -> { GroupData.id= 632; name= "Deadspace Serpentis Destroyer"; categoryId= 11; published= false; typeIds= [| 2098; 2128; 23973; 23994; 23995; 23996; 23997; 23998; 24205; 24206; 24207; 24208; 24209; 24210 |] } |> Some
      | 729 -> { GroupData.id= 729; name= "Decryptors - Minmatar"; categoryId= 35; published= true; typeIds= [| 21579; 21580; 21581; 21582; 21583; 33318; 33321; 33324 |] } |> Some
      | 826 -> { GroupData.id= 826; name= "Mission Thukker Frigate"; categoryId= 11; published= false; typeIds= [| 10110; 23955; 23958; 23959 |] } |> Some
      | _ -> None