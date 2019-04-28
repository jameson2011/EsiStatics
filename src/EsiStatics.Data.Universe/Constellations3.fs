namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations3=
    let getConstellation id = 
      match id with 
      | 20000045 -> { ConstellationData.id= 20000045; name= "9KX-M0"; regionId= 10000003; solarSystemIds= [| 30000314; 30000315; 30000316; 30000317; 30000318; 30000319 |]; position= {x = 1.109511359e+16;  y = 9.054197089e+16;  z = 1.607054929e+17;} } |> Some
      | 20000142 -> { ConstellationData.id= 20000142; name= "DYK-G8"; regionId= 10000011; solarSystemIds= [| 30000971; 30000972; 30000973; 30000974; 30000975; 30000976 |]; position= {x = 5.103582846e+16;  y = 1.555611311e+16;  z = -5.977824772e+16;} } |> Some
      | 20000239 -> { ConstellationData.id= 20000239; name= "6I-9Y2"; regionId= 10000019; solarSystemIds= [| 30001618; 30001619; 30001620; 30001621; 30001622; 30001623 |]; position= {x = 9.008183784e+14;  y = 6.361120851e+16;  z = 3.020222111e+17;} } |> Some
      | 20000336 -> { ConstellationData.id= 20000336; name= "D-GU3R"; regionId= 10000027; solarSystemIds= [| 30002289; 30002290; 30002291; 30002292; 30002293; 30002294; 30002295 |]; position= {x = 1.548530695e+17;  y = 4.684558256e+16;  z = 7.995840573e+16;} } |> Some
      | 20000433 -> { ConstellationData.id= 20000433; name= "Semou"; regionId= 10000036; solarSystemIds= [| 30002957; 30002958; 30002959; 30002960; 30002961; 30002962 |]; position= {x = -1.41793323e+17;  y = 2.205652237e+16;  z = -3.032297168e+16;} } |> Some
      | 20000530 -> { ConstellationData.id= 20000530; name= "X-FHU3"; regionId= 10000045; solarSystemIds= [| 30003636; 30003637; 30003638; 30003639; 30003640; 30003641; 30003642; 30003643 |]; position= {x = -6.425631254e+16;  y = 2.500064549e+16;  z = 4.34585701e+17;} } |> Some
      | 20000627 -> { ConstellationData.id= 20000627; name= "Maal"; regionId= 10000054; solarSystemIds= [| 30004288; 30004289; 30004290; 30004291; 30004292; 30004293; 30004294; 30004295; 30004296 |]; position= {x = -4.03308556e+17;  y = 1.010341752e+16;  z = -8.769609004e+16;} } |> Some
      | 20000724 -> { ConstellationData.id= 20000724; name= "NOK-FZ"; regionId= 10000063; solarSystemIds= [| 30004947; 30004948; 30004949; 30004950; 30004951; 30004952; 30004953; 30004954 |]; position= {x = -4.20410078e+17;  y = 7.121113785e+16;  z = -4.059554399e+17;} } |> Some
      | 21000018 -> { ConstellationData.id= 21000018; name= "A-C00018"; regionId= 11000003; solarSystemIds= [| 31000323; 31000324; 31000325; 31000326; 31000327; 31000328; 31000329; 31000330; 31000331; 31000332; 31000333 |]; position= {x = 7.641016605e+18;  y = 3.953593813e+16;  z = -9.382544437e+18;} } |> Some
      | 21000115 -> { ConstellationData.id= 21000115; name= "C-C00115"; regionId= 11000012; solarSystemIds= [| 31001134; 31001135; 31001136; 31001137; 31001138; 31001139 |]; position= {x = 7.470930129e+18;  y = -7.507233109e+15;  z = -9.330938451e+18;} } |> Some
      | 21000212 -> { ConstellationData.id= 21000212; name= "D-C00212"; regionId= 11000021; solarSystemIds= [| 31001759; 31001760; 31001761; 31001762; 31001763; 31001764 |]; position= {x = 7.553441411e+18;  y = 1.134828577e+16;  z = -9.084891978e+18;} } |> Some
      | 21000309 -> { ConstellationData.id= 21000309; name= "F-C00309"; regionId= 11000030; solarSystemIds= [| 31002457; 31002458; 31002459; 31002460; 31002461; 31002462; 31002463; 31002498 |]; position= {x = 7.349354243e+18;  y = -2.9488185e+14;  z = -9.885493066e+18;} } |> Some
      | _ -> None