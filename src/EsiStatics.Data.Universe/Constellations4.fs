namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations4=
    let getConstellation id = 
      match id with 
      | 20000046 -> { ConstellationData.id= 20000046; name= "88G-M4"; regionId= 10000003; solarSystemIds= [| 30000320; 30000321; 30000322; 30000323; 30000324; 30000325 |]; position= {x = 7.984492458e+15;  y = 6.891422053e+16;  z = 1.680771971e+17;} } |> Some
      | 20000143 -> { ConstellationData.id= 20000143; name= "L-TEVM"; regionId= 10000011; solarSystemIds= [| 30000977; 30000978; 30000979; 30000980; 30000981; 30000982 |]; position= {x = 7.964181933e+16;  y = 3.650222155e+16;  z = -6.779745947e+16;} } |> Some
      | 20000240 -> { ConstellationData.id= 20000240; name= "B9J-NT"; regionId= 10000019; solarSystemIds= [| 30001624; 30001625; 30001626; 30001627; 30001628; 30001629; 30001630 |]; position= {x = 2.292783557e+16;  y = 7.803153129e+16;  z = 3.052119113e+17;} } |> Some
      | 20000337 -> { ConstellationData.id= 20000337; name= "N-APJ8"; regionId= 10000027; solarSystemIds= [| 30002296; 30002297; 30002298; 30002299; 30002300; 30002301 |]; position= {x = 1.262775102e+17;  y = 4.82004599e+16;  z = 1.975065831e+16;} } |> Some
      | 20000434 -> { ConstellationData.id= 20000434; name= "Ryra"; regionId= 10000036; solarSystemIds= [| 30002963; 30002964; 30002965; 30002966; 30002967; 30002968 |]; position= {x = -1.235252764e+17;  y = 5.86399047e+16;  z = -7.141493718e+16;} } |> Some
      | 20000531 -> { ConstellationData.id= 20000531; name= "GFE-SS"; regionId= 10000045; solarSystemIds= [| 30003644; 30003645; 30003646; 30003647; 30003648; 30003649 |]; position= {x = -6.77766562e+16;  y = 7.492544264e+16;  z = 4.329322979e+17;} } |> Some
      | 20000628 -> { ConstellationData.id= 20000628; name= "Fabai"; regionId= 10000054; solarSystemIds= [| 30004297; 30004298; 30004299; 30004300; 30004301; 30004302 |]; position= {x = -3.946789224e+17;  y = -5.883182984e+15;  z = -1.170302267e+17;} } |> Some
      | 20000725 -> { ConstellationData.id= 20000725; name= "6KFH-X"; regionId= 10000063; solarSystemIds= [| 30004955; 30004956; 30004957; 30004958; 30004959; 30004960 |]; position= {x = -4.217609389e+17;  y = 1.014709261e+17;  z = -3.916483357e+17;} } |> Some
      | 21000019 -> { ConstellationData.id= 21000019; name= "A-C00019"; regionId= 11000003; solarSystemIds= [| 31000334; 31000335; 31000336; 31000337; 31000338; 31000339; 31000340; 31000341; 31000342 |]; position= {x = 7.623614311e+18;  y = 1.607076442e+16;  z = -9.309596152e+18;} } |> Some
      | 21000116 -> { ConstellationData.id= 21000116; name= "C-C00116"; regionId= 11000012; solarSystemIds= [| 31001140; 31001141; 31001142; 31001143; 31001144; 31001145 |]; position= {x = 7.458705698e+18;  y = 1.019246217e+16;  z = -9.307818303e+18;} } |> Some
      | 21000213 -> { ConstellationData.id= 21000213; name= "D-C00213"; regionId= 11000022; solarSystemIds= [| 31001765; 31001766; 31001767; 31001768; 31001769; 31001770 |]; position= {x = 7.958447416e+18;  y = 2.11844542e+16;  z = -9.173445105e+18;} } |> Some
      | 21000310 -> { ConstellationData.id= 21000310; name= "F-C00310"; regionId= 11000030; solarSystemIds= [| 31002464; 31002465; 31002466; 31002467; 31002468; 31002469; 31002470; 31002492; 31002495 |]; position= {x = 7.315882341e+18;  y = 3.668325619e+16;  z = -9.815114439e+18;} } |> Some
      | _ -> None