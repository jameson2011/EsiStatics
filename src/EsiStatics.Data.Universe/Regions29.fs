namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Regions29=
    let getRegion id = 
      match id with 
      | 10000050 -> { RegionData.id= 10000050; name= "Querious"; constellationIds= [| 20000576; 20000577; 20000578; 20000579; 20000580; 20000581; 20000582; 20000583; 20000584; 20000585; 20000586; 20000587; 20000588; 20000589 |] } |> Some
      | 11000023 -> { RegionData.id= 11000023; name= "D-R00023"; constellationIds= [| 21000227; 21000228; 21000229; 21000230; 21000231 |] } |> Some
      | _ -> None