namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups53=
    let getMarketGroup id = 
      match id with 
      | 150 -> { MarketGroupData.id= 150; name= "Skills"; parentMarketGroupId= None; typeIds= [|  |]; description= "Skills are learned by capsuleer pilots using special data chips known as skillbooks, and these are available for almost any imaginable activity that can be carried out in space" } |> Some
      | 1508 -> { MarketGroupData.id= 1508; name= "Implant Slot 07"; parentMarketGroupId= Some(1471); typeIds= [| 27120; 13265; 13251; 27123; 13255; 27122; 3247; 3248; 3249; 3250; 3251; 3252; 3253; 3254; 3255; 27124; 27121; 27125 |]; description= "Implant Slot 07" } |> Some
      | 1702 -> { MarketGroupData.id= 1702; name= "Personal Hangar Arrays"; parentMarketGroupId= Some(1285); typeIds= [| 33149 |]; description= "A large hangar structure, for easy storage of materials and modules." } |> Some
      | 1799 -> { MarketGroupData.id= 1799; name= "Medium Resource Processing Rigs"; parentMarketGroupId= Some(1794); typeIds= [| 32818; 32820; 31086 |]; description= "Blueprints of Medium Resource Processing Rigs." } |> Some
      | 1993 -> { MarketGroupData.id= 1993; name= "Minmatar"; parentMarketGroupId= Some(2028); typeIds= [| 45954; 45955; 45956; 45957; 34697; 34698; 44171; 44172; 47506; 46723; 36767; 36768; 36769; 36770; 40484; 40485; 40486; 40487; 49801; 46893; 46894; 44169; 47161; 47164; 44170; 46017; 34699; 36814; 36815; 36816; 36817; 48722; 47317; 48232; 48501; 48502; 48503; 48504 |]; description= "" } |> Some
      | 2090 -> { MarketGroupData.id= 2090; name= "Gallente"; parentMarketGroupId= Some(2087); typeIds= [| 46752; 46440; 46978; 46439; 36390; 36391; 45928; 45579; 45580; 44945; 44946; 45927; 42196; 42197; 37592; 37593; 46973; 46751 |]; description= "" } |> Some
      | 2187 -> { MarketGroupData.id= 2187; name= "Ship Tractor Beams"; parentMarketGroupId= Some(2162); typeIds= [|  |]; description= "" } |> Some
      | 2381 -> { MarketGroupData.id= 2381; name= "Standard Titans"; parentMarketGroupId= Some(1973); typeIds= [|  |]; description= "" } |> Some
      | 2478 -> { MarketGroupData.id= 2478; name= "Implant Slot 10"; parentMarketGroupId= Some(2473); typeIds= [|  |]; description= "Implant Slot 10" } |> Some
      | 353715 -> { MarketGroupData.id= 353715; name= "Turret Operation"; parentMarketGroupId= Some(353713); typeIds= [|  |]; description= "Hardwired neural augmentations used to train new abilities." } |> Some
      | 354491 -> { MarketGroupData.id= 354491; name= "Large"; parentMarketGroupId= Some(353608); typeIds= [|  |]; description= "" } |> Some
      | 355461 -> { MarketGroupData.id= 355461; name= "Vehicles"; parentMarketGroupId= Some(355449); typeIds= [|  |]; description= "" } |> Some
      | 356916 -> { MarketGroupData.id= 356916; name= "Scanners"; parentMarketGroupId= Some(353589); typeIds= [|  |]; description= "" } |> Some
      | 441 -> { MarketGroupData.id= 441; name= "Minmatar"; parentMarketGroupId= Some(437); typeIds= [| 11978 |]; description= "Minmatar logistics vessel designs." } |> Some
      | 538 -> { MarketGroupData.id= 538; name= "Hull Repairers"; parentMarketGroupId= Some(14); typeIds= [|  |]; description= "For on-the-fly structural restoration." } |> Some
      | 635 -> { MarketGroupData.id= 635; name= "Amarr"; parentMarketGroupId= Some(634); typeIds= [| 12754; 12734 |]; description= "Blueprints of Amarr transport designs." } |> Some
      | 732 -> { MarketGroupData.id= 732; name= "Caldari Navy"; parentMarketGroupId= Some(616); typeIds= [| 15653; 15654; 15655; 15656; 15657; 15596; 15597; 15598; 15599; 15600; 15601; 15602; 15604; 15605; 15996; 28237; 15999 |]; description= "Officially sanctioned Caldari Navy insignias." } |> Some
      | 829 -> { MarketGroupData.id= 829; name= "Caldari"; parentMarketGroupId= Some(823); typeIds= [| 22464 |]; description= "Caldari interdictor designs." } |> Some
      | 926 -> { MarketGroupData.id= 926; name= "Advanced High Damage Heavy Missiles"; parentMarketGroupId= Some(581); typeIds= [| 24511; 24507; 2629; 24509 |]; description= "Advanced High Damage Heavy Missiles" } |> Some
      | _ -> None