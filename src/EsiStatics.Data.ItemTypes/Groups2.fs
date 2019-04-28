namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups2=
    let getGroup id = 
      match id with 
      | 1166 -> { GroupData.id= 1166; name= "FW Minmatar Republic Frigate"; categoryId= 11; published= true; typeIds= [| 32913 |] } |> Some
      | 1845 -> { GroupData.id= 1845; name= "Structure Engineering Rig M - ME Research Accelerator"; categoryId= 66; published= true; typeIds= [| 43882; 43883 |] } |> Some
      | 1942 -> { GroupData.id= 1942; name= "Structure Resource Rig M - Ice Reprocessing"; categoryId= 66; published= true; typeIds= [| 46635; 46636 |] } |> Some
      | 196 -> { GroupData.id= 196; name= "Caldari Education"; categoryId= 14; published= false; typeIds= [| 1657; 1658; 1659; 1660; 1661; 1662 |] } |> Some
      | 2 -> { GroupData.id= 2; name= "Corporation"; categoryId= 1; published= false; typeIds= [| 2 |] } |> Some
      | 487 -> { GroupData.id= 487; name= "Destroyer Blueprint"; categoryId= 9; published= true; typeIds= [| 16237; 16239; 16241; 16243; 22453; 22457; 22461; 22465; 32841; 32843; 32845; 32847; 32849; 32873; 32875; 32877; 32879; 33878; 33880; 33882; 33884; 44106; 49714 |] } |> Some
      | 584 -> { GroupData.id= 584; name= "Asteroid Serpentis BattleCruiser"; categoryId= 11; published= false; typeIds= [| 23438; 23439; 23440; 23441; 23442; 23443 |] } |> Some
      | 681 -> { GroupData.id= 681; name= "Mission Gallente Federation Battlecruiser"; categoryId= 11; published= false; typeIds= [| 25167; 25168; 25169; 25170; 25171; 25173; 28175; 28176 |] } |> Some
      | 778 -> { GroupData.id= 778; name= "Rig Drones"; categoryId= 7; published= true; typeIds= [| 25908; 25910; 25912; 25914; 25916; 25918; 25920; 25922; 25924; 26324; 26326; 26328; 26330; 26332; 26334; 26336; 26338; 26340; 26925; 26927; 32025; 32027; 32029; 32031; 32033; 32035; 32037; 32039; 32041; 32043; 32045; 32047; 32049; 32051; 32053; 32055; 32057; 32059; 32061; 32063; 32065; 32067; 32069; 32071; 32073; 32075; 32077; 32079; 32081; 32083; 32085; 32087; 32089; 32091; 32093; 32095; 33277; 33279; 33281; 33283; 33285; 33287; 33289; 33291; 33293; 33295; 33297; 33298; 33307; 33309; 33311; 33313 |] } |> Some
      | 875 -> { GroupData.id= 875; name= "Mission Faction Transports"; categoryId= 11; published= false; typeIds= [| 2877; 2879; 2882; 3070; 28160; 28161; 28162; 28163; 30970; 32230; 32448; 32449 |] } |> Some
      | 972 -> { GroupData.id= 972; name= "Obsolete Probes"; categoryId= 8; published= false; typeIds= [| 18588; 25797; 28766; 28768 |] } |> Some
      | 99 -> { GroupData.id= 99; name= "Sentry Gun"; categoryId= 11; published= false; typeIds= [| 1194; 3739; 3740; 3741; 3742; 3743 |] } |> Some
      | _ -> None