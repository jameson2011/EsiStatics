namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module internal Constellations69=
    let getConstellation id = 
      match id with 
      | 20000014 -> { ConstellationData.id= 20000014; name= "Mal"; regionId= 10000001; solarSystemIds= [| 30000095; 30000096; 30000097; 30000098; 30000099; 30000100; 30000101; 30000102; 30000103; 30000104; 30000105 |]; position= {x = -6.702541548e+16;  y = 6.906534372e+16;  z = -8.37385466e+16;} } |> Some
      | 20000111 -> { ConstellationData.id= 20000111; name= "8-4EFQ"; regionId= 10000009; solarSystemIds= [| 30000756; 30000757; 30000758; 30000759; 30000760; 30000761; 30000762; 30000763 |]; position= {x = 1.524538826e+17;  y = 9.15146696e+15;  z = -1.339581975e+17;} } |> Some
      | 20000208 -> { ConstellationData.id= 20000208; name= "Pietanen"; regionId= 10000016; solarSystemIds= [| 30001416; 30001417; 30001418; 30001419; 30001420; 30001421; 30001422; 30001423 |]; position= {x = -2.063408206e+17;  y = 9.287636528e+16;  z = 1.89728719e+17;} } |> Some
      | 20000305 -> { ConstellationData.id= 20000305; name= "Ani"; regionId= 10000042; solarSystemIds= [| 30002068; 30002069; 30002070; 30002071; 30002072; 30002073; 30002074; 30002075 |]; position= {x = -1.311384575e+17;  y = 5.031694649e+16;  z = 5.383375545e+16;} } |> Some
      | 20000402 -> { ConstellationData.id= 20000402; name= "Nagaslaiken"; regionId= 10000033; solarSystemIds= [| 30002743; 30002744; 30002745; 30002746; 30002747; 30002748 |]; position= {x = -1.369214324e+17;  y = 6.296967207e+16;  z = 1.347800803e+17;} } |> Some
      | 20000499 -> { ConstellationData.id= 20000499; name= "Ergruk"; regionId= 10000042; solarSystemIds= [| 30003422; 30003423; 30003424; 30003425; 30003426; 30003427 |]; position= {x = -8.011383713e+16;  y = 7.855037065e+16;  z = 6.114148462e+16;} } |> Some
      | 20000596 -> { ConstellationData.id= 20000596; name= "Megeh"; regionId= 10000052; solarSystemIds= [| 30004077; 30004078; 30004079; 30004080; 30004081; 30004082; 30004083 |]; position= {x = -2.094959511e+17;  y = 4.859573535e+16;  z = -2.669281815e+16;} } |> Some
      | 20000693 -> { ConstellationData.id= 20000693; name= "YX-LYK"; regionId= 10000060; solarSystemIds= [| 30004737; 30004738; 30004739; 30004740; 30004741; 30004742; 30004743 |]; position= {x = -4.184056953e+17;  y = 2.151603246e+16;  z = -1.874484111e+17;} } |> Some
      | 21000084 -> { ConstellationData.id= 21000084; name= "C-C00084"; regionId= 11000009; solarSystemIds= [| 31000930; 31000931; 31000932; 31000933; 31000934; 31000935 |]; position= {x = 7.793612441e+18;  y = 2.411148137e+16;  z = -9.844546453e+18;} } |> Some
      | 21000181 -> { ConstellationData.id= 21000181; name= "D-C00181"; regionId= 11000019; solarSystemIds= [| 31001560; 31001561; 31001562; 31001563; 31001564; 31001565 |]; position= {x = 7.432218279e+18;  y = 1.402575264e+16;  z = -9.553660093e+18;} } |> Some
      | 21000278 -> { ConstellationData.id= 21000278; name= "E-C00278"; regionId= 11000028; solarSystemIds= [| 31002224; 31002225; 31002226; 31002227; 31002228; 31002229; 31002491 |]; position= {x = 8.091474123e+18;  y = 3.578720942e+16;  z = -9.882207771e+18;} } |> Some
      | _ -> None