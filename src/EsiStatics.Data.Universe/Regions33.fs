namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions33=
    let getRegion id = 
      match id with 
      | 10000054 -> { RegionData.id= 10000054; name= "Aridia"; constellationIds= [| 20000619; 20000620; 20000621; 20000622; 20000623; 20000624; 20000625; 20000626; 20000627; 20000628; 20000629 |] } |> Some
      | 11000027 -> { RegionData.id= 11000027; name= "E-R00027"; constellationIds= [| 21000265; 21000266; 21000267; 21000268; 21000269; 21000270; 21000271; 21000272; 21000273 |] } |> Some
      | _ -> None