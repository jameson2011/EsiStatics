namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups31=
    let getGroup id = 
      match id with 
      | 1195 -> { GroupData.id= 1195; name= "Tournament Cards: New Eden Open YC 114"; categoryId= 63; published= true; typeIds= [| 33031; 33032; 33033; 33034; 33035; 33036; 33037; 33038; 33039; 33040; 33041; 33042; 33043; 33044; 33045; 33046; 33047; 33048; 33049; 33050; 33051; 33052; 33053; 33054; 33055; 33056; 33057 |] } |> Some
      | 128 -> { GroupData.id= 128; name= "Ship Scanner Blueprint"; categoryId= 9; published= true; typeIds= [| 1075; 1856 |] } |> Some
      | 1292 -> { GroupData.id= 1292; name= "Drone Tracking Enhancer"; categoryId= 7; published= true; typeIds= [| 33822; 33824; 33828; 33830; 33832; 33834; 33836; 33838; 33840; 41033 |] } |> Some
      | 1583 -> { GroupData.id= 1583; name= "Structure Assembly Rig M - Large Tech II Ship"; categoryId= 66; published= false; typeIds= [|  |] } |> Some
      | 1971 -> { GroupData.id= 1971; name= "Abyssal Hazards"; categoryId= 2; published= false; typeIds= [| 47436; 47439; 47440; 47441; 47465; 47467; 47468; 47472; 47473; 47620 |] } |> Some
      | 225 -> { GroupData.id= 225; name= "Cheat Module Group"; categoryId= 7; published= false; typeIds= [|  |] } |> Some
      | 31 -> { GroupData.id= 31; name= "Shuttle"; categoryId= 6; published= true; typeIds= [| 672; 11129; 11132; 11134; 21097; 21628; 27299; 27301; 27303; 27305; 29266; 29328; 29330; 29332; 29334; 30842; 33513; 34496 |] } |> Some
      | 419 -> { GroupData.id= 419; name= "Combat Battlecruiser"; categoryId= 6; published= true; typeIds= [| 3756; 16227; 16229; 16231; 16233; 24696; 24698; 24700; 24702; 33151; 33153; 33155; 33157; 33869; 33871; 33873; 33875; 34473; 49711 |] } |> Some
      | 516 -> { GroupData.id= 516; name= "Siege Module Blueprint"; categoryId= 9; published= true; typeIds= [| 4293; 4295; 20281; 23954; 27952; 28584; 28653; 33401; 42891 |] } |> Some
      | 613 -> { GroupData.id= 613; name= "Deadspace Guristas Cruiser"; categoryId= 11; published= false; typeIds= [| 11601; 11718; 14344; 16169; 16980; 16982; 16991; 16995; 16998; 17000; 17003; 17004; 17007; 17009; 17016; 17017; 17020; 17021; 17024; 17025; 17028; 17029; 24087; 24088; 24089; 24090; 24091; 24092; 24093; 24094; 24095; 24096; 24097; 24098 |] } |> Some
      | 710 -> { GroupData.id= 710; name= "Logistics Array"; categoryId= 23; published= false; typeIds= [|  |] } |> Some
      | 807 -> { GroupData.id= 807; name= "Asteroid Sansha's Nation Commander BattleCruiser"; categoryId= 11; published= false; typeIds= [| 23394; 23395; 23396; 23397; 23398; 23399 |] } |> Some
      | 904 -> { GroupData.id= 904; name= "Rig Mining"; categoryId= 7; published= false; typeIds= [| 28888; 28890; 28892; 28894 |] } |> Some
      | _ -> None