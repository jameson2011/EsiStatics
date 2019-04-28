namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations48=
    let getConstellation id = 
      match id with 
      | 20000090 -> { ConstellationData.id= 20000090; name= "VS-8P0"; regionId= 10000007; solarSystemIds= [| 30000617; 30000618; 30000619; 30000620; 30000621; 30000622; 30000623 |]; position= {x = 1.839516589e+17;  y = 9.761231144e+15;  z = -1.202284204e+17;} } |> Some
      | 20000187 -> { ConstellationData.id= 20000187; name= "N32Z-Z"; regionId= 10000015; solarSystemIds= [| 30001280; 30001281; 30001282; 30001283; 30001284; 30001285 |]; position= {x = -1.232834244e+17;  y = 1.303559167e+17;  z = 2.720870693e+17;} } |> Some
      | 20000284 -> { ConstellationData.id= 20000284; name= "W-ULNA"; regionId= 10000022; solarSystemIds= [| 30001923; 30001924; 30001925; 30001926; 30001927; 30001928; 30001929; 30001930 |]; position= {x = -1.848838795e+17;  y = 8.058567653e+16;  z = -2.948257613e+17;} } |> Some
      | 20000381 -> { ConstellationData.id= 20000381; name= "1A-WYQ"; regionId= 10000031; solarSystemIds= [| 30002599; 30002600; 30002601; 30002602; 30002603; 30002604 |]; position= {x = -4.263334249e+16;  y = 1.570332719e+15;  z = -3.611181295e+17;} } |> Some
      | 20000478 -> { ConstellationData.id= 20000478; name= "Z-6NQ6"; regionId= 10000041; solarSystemIds= [| 30003268; 30003269; 30003270; 30003271; 30003272; 30003273; 30003274; 30003275; 30003276; 30003277; 30003278; 30003279 |]; position= {x = -2.98267992e+17;  y = 1.536435136e+16;  z = 7.668686634e+16;} } |> Some
      | 20000575 -> { ConstellationData.id= 20000575; name= "Alpakian"; regionId= 10000049; solarSystemIds= [| 30003936; 30003937; 30003938; 30003939; 30003940; 30003941 |]; position= {x = -3.644048369e+17;  y = -2.337595555e+16;  z = -1.209739209e+17;} } |> Some
      | 20000672 -> { ConstellationData.id= 20000672; name= "Kraken"; regionId= 10000058; solarSystemIds= [| 30004602; 30004603; 30004604; 30004605; 30004606; 30004607 |]; position= {x = -4.603204614e+17;  y = 5.759898585e+16;  z = -7.856590659e+15;} } |> Some
      | 20000769 -> { ConstellationData.id= 20000769; name= "Makh"; regionId= 10000067; solarSystemIds= [| 30005255; 30005256; 30005257; 30005258; 30005259; 30005260 |]; position= {x = -2.937368035e+17;  y = 1.010606463e+16;  z = -4.199136907e+16;} } |> Some
      | 21000063 -> { ConstellationData.id= 21000063; name= "B-C00063"; regionId= 11000008; solarSystemIds= [| 31000783; 31000784; 31000785; 31000786; 31000787; 31000788; 31000789; 31000790; 31000791 |]; position= {x = 7.486513878e+18;  y = 4.189659527e+16;  z = -9.625978818e+18;} } |> Some
      | 21000160 -> { ConstellationData.id= 21000160; name= "D-C00160"; regionId= 11000016; solarSystemIds= [| 31001423; 31001424; 31001425; 31001426; 31001427; 31001428 |]; position= {x = 7.965336189e+18;  y = 2.662157059e+16;  z = -9.674900997e+18;} } |> Some
      | 21000257 -> { ConstellationData.id= 21000257; name= "E-C00257"; regionId= 11000026; solarSystemIds= [| 31002069; 31002070; 31002071; 31002072; 31002073; 31002074 |]; position= {x = 7.677747371e+18;  y = 9.914671959e+15;  z = -8.969782592e+18;} } |> Some
      | _ -> None