namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations65=
    let getConstellation id = 
      match id with 
      | 20000010 -> { ConstellationData.id= 20000010; name= "Bedaleya"; regionId= 10000001; solarSystemIds= [| 30000070; 30000071; 30000072; 30000073; 30000074; 30000075 |]; position= {x = -1.055499876e+17;  y = 7.133708486e+16;  z = -9.244230022e+16;} } |> Some
      | 20000107 -> { ConstellationData.id= 20000107; name= "CN5-F2"; regionId= 10000008; solarSystemIds= [| 30000730; 30000731; 30000732; 30000733; 30000734; 30000735 |]; position= {x = 6.155602353e+16;  y = 2.667279104e+16;  z = -1.365639935e+17;} } |> Some
      | 20000204 -> { ConstellationData.id= 20000204; name= "Sela"; regionId= 10000016; solarSystemIds= [| 30001392; 30001393; 30001394; 30001395; 30001396; 30001397 |]; position= {x = -1.448763344e+17;  y = 1.009726794e+17;  z = 1.468188462e+17;} } |> Some
      | 20000301 -> { ConstellationData.id= 20000301; name= "0A-73B"; regionId= 10000023; solarSystemIds= [| 30002042; 30002043; 30002044; 30002045; 30002046; 30002047 |]; position= {x = -3.193940671e+17;  y = 3.652730541e+16;  z = 2.241602882e+17;} } |> Some
      | 20000398 -> { ConstellationData.id= 20000398; name= "Aeman"; regionId= 10000032; solarSystemIds= [| 30002718; 30002719; 30002720; 30002721; 30002722; 30002723 |]; position= {x = -1.452061263e+17;  y = 1.483804101e+16;  z = 6.979195273e+16;} } |> Some
      | 20000495 -> { ConstellationData.id= 20000495; name= "Jonar"; regionId= 10000042; solarSystemIds= [| 30003393; 30003394; 30003395; 30003396; 30003397; 30003398; 30003399 |]; position= {x = -9.396891573e+16;  y = 3.741247308e+16;  z = 5.987239306e+16;} } |> Some
      | 20000592 -> { ConstellationData.id= 20000592; name= "Tinnimerci"; regionId= 10000051; solarSystemIds= [| 30004050; 30004051; 30004052; 30004053; 30004054; 30004055; 30004056 |]; position= {x = -3.12984798e+17;  y = 7.075549603e+16;  z = 1.631296415e+17;} } |> Some
      | 20000689 -> { ConstellationData.id= 20000689; name= "B4H-9W"; regionId= 10000060; solarSystemIds= [| 30004712; 30004713; 30004714; 30004715; 30004716; 30004717 |]; position= {x = -4.163803604e+17;  y = 4.18621983e+16;  z = -2.1648421e+17;} } |> Some
      | 20000786 -> { ConstellationData.id= 20000786; name= "Kurala"; regionId= 10000069; solarSystemIds= [| 30045330; 30045331; 30045332; 30045333; 30045334; 30045335; 30045336; 30045337 |]; position= {x = -1.899107556e+17;  y = 7.517634814e+16;  z = 1.469400475e+17;} } |> Some
      | 21000080 -> { ConstellationData.id= 21000080; name= "C-C00080"; regionId= 11000009; solarSystemIds= [| 31000905; 31000906; 31000907; 31000908; 31000909; 31000910; 31000911 |]; position= {x = 7.74741742e+18;  y = 1.931810509e+16;  z = -9.814181332e+18;} } |> Some
      | 21000177 -> { ConstellationData.id= 21000177; name= "D-C00177"; regionId= 11000019; solarSystemIds= [| 31001533; 31001534; 31001535; 31001536; 31001537; 31001538; 31001539 |]; position= {x = 7.440458887e+18;  y = -1.096084133e+16;  z = -9.533654458e+18;} } |> Some
      | 21000274 -> { ConstellationData.id= 21000274; name= "E-C00274"; regionId= 11000028; solarSystemIds= [| 31002194; 31002195; 31002196; 31002197; 31002198; 31002199; 31002200; 31002201; 31002202 |]; position= {x = 8.097900167e+18;  y = 3.071619133e+16;  z = -9.924291675e+18;} } |> Some
      | _ -> None