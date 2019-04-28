namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions39=
    let getRegion id = 
      match id with 
      | 10000060 -> { RegionData.id= 10000060; name= "Delve"; constellationIds= [| 20000688; 20000689; 20000690; 20000691; 20000692; 20000693; 20000694; 20000695; 20000696; 20000697; 20000698; 20000699; 20000700; 20000701; 20000702 |] } |> Some
      | 11000033 -> { RegionData.id= 11000033; name= "K-R00033"; constellationIds= [| 21000334 |] } |> Some
      | _ -> None