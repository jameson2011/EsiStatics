namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions19=
    let getRegion id = 
      match id with 
      | 10000040 -> { RegionData.id= 10000040; name= "Oasa"; constellationIds= [| 20000465; 20000466; 20000467; 20000468; 20000469; 20000470; 20000471; 20000472; 20000473; 20000474; 20000475; 20000476; 20000477 |] } |> Some
      | 11000013 -> { RegionData.id= 11000013; name= "C-R00013"; constellationIds= [| 21000122; 21000123; 21000124; 21000125; 21000126; 21000127; 21000128 |] } |> Some
      | _ -> None