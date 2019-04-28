namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups72=
    let getGroup id = 
      match id with 
      | 1042 -> { GroupData.id= 1042; name= "Basic Commodities - Tier 1"; categoryId= 43; published= true; typeIds= [| 2389; 2390; 2392; 2393; 2395; 2396; 2397; 2398; 2399; 2400; 2401; 3645; 3683; 3779; 9828 |] } |> Some
      | 1139 -> { GroupData.id= 1139; name= "Mining Laser Upgrade Blueprint"; categoryId= 9; published= true; typeIds= [| 22543; 22577; 28577; 28579; 49973 |] } |> Some
      | 1333 -> { GroupData.id= 1333; name= "Structure Doomsday Weapon"; categoryId= 66; published= true; typeIds= [| 35928 |] } |> Some
      | 1430 -> { GroupData.id= 1430; name= "Structure Fitting Module"; categoryId= 66; published= true; typeIds= [| 35963; 35965; 47344; 47347 |] } |> Some
      | 1527 -> { GroupData.id= 1527; name= "Logistics Frigate"; categoryId= 6; published= true; typeIds= [| 37457; 37458; 37459; 37460 |] } |> Some
      | 169 -> { GroupData.id= 169; name= "Capacitor Booster Charge Blueprint"; categoryId= 9; published= true; typeIds= [| 1178; 1179; 3553; 3555; 11284; 11286; 11288; 11290; 41598 |] } |> Some
      | 1721 -> { GroupData.id= 1721; name= "Roaming Serpentis Cruiser"; categoryId= 11; published= false; typeIds= [| 42140 |] } |> Some
      | 1818 -> { GroupData.id= 1818; name= "Strong Boxes"; categoryId= 17; published= true; typeIds= [| 43682; 43683; 43684; 43685; 43686; 43687; 43688; 43689; 43690; 43691; 43692; 43693; 43695; 43696; 43697; 43698; 45677; 45678; 45679; 46381; 46444; 46445; 46446; 46447; 46448; 46449; 46450; 46451; 46452; 46453; 46454; 46455; 46456; 46457; 46458; 46459; 46460; 46461; 46462; 46463; 46464; 46465; 46466; 46467; 46468; 46469; 46470; 46471; 46472; 46473; 46474; 46475; 46476; 46477; 46478; 46479; 46480; 46481; 46482; 46483; 46579; 46580; 46601; 46602; 46603; 46771; 46772 |] } |> Some
      | 1915 -> { GroupData.id= 1915; name= "Moon Mining Beacon"; categoryId= 2; published= false; typeIds= [| 46329 |] } |> Some
      | 266 -> { GroupData.id= 266; name= "Corporation Management"; categoryId= 16; published= true; typeIds= [| 3363; 3364; 3365; 3366; 3367; 3368; 3369; 3370; 3371; 3372; 3731; 3732; 12241 |] } |> Some
      | 363 -> { GroupData.id= 363; name= "Ship Maintenance Array"; categoryId= 23; published= true; typeIds= [| 12237; 24646 |] } |> Some
      | 460 -> { GroupData.id= 460; name= "Scordite"; categoryId= 25; published= true; typeIds= [| 1228; 17463; 17464; 28427; 28428; 28429; 46687; 46703 |] } |> Some
      | 557 -> { GroupData.id= 557; name= "Asteroid Blood Raiders Frigate"; categoryId= 11; published= false; typeIds= [| 10275; 10276; 10277; 10278; 10279; 10280; 11039; 11040; 11041; 11042; 13037; 13038; 13039; 13040; 23259; 23260; 23261; 23262; 23263; 23264; 24385; 24386; 24387; 24388; 24389; 24407 |] } |> Some
      | 654 -> { GroupData.id= 654; name= "Advanced Heavy Assault Missile"; categoryId= 8; published= true; typeIds= [| 2679; 13856; 24486; 24488; 24490; 24492; 24493; 24494 |] } |> Some
      | 72 -> { GroupData.id= 72; name= "Smart Bomb"; categoryId= 7; published= true; typeIds= [| 1547; 1549; 1551; 1553; 1557; 1559; 1563; 1565; 3897; 3899; 3901; 3903; 3907; 3909; 3913; 3915; 3937; 3939; 3941; 3943; 3947; 3949; 3953; 3955; 3977; 3979; 3981; 3983; 3987; 3989; 3993; 3995; 9668; 9670; 9678; 9680; 9702; 9706; 9728; 9734; 9744; 9750; 9762; 9772; 9784; 9790; 9800; 9808; 14188; 14190; 14192; 14194; 14196; 14198; 14200; 14202; 14204; 14206; 14208; 14210; 14212; 14214; 14218; 14220; 14222; 14224; 14226; 14228; 14544; 14546; 14548; 14550; 14692; 14694; 14696; 14698; 14784; 14786; 14788; 14790; 14792; 14794; 14796; 14798; 15152; 15154; 15156; 15158; 15405; 15925; 15927; 15929; 15931; 15933; 15935; 15937; 15939; 15941; 15943; 15945; 15947; 15949; 15951; 15953; 15955; 15957; 15959; 15961; 15963; 21532; 21534; 21536; 21538; 23864; 23866; 23868; 28545; 28550; 28557 |] } |> Some
      | 751 -> { GroupData.id= 751; name= "Cyber Trade"; categoryId= 20; published= true; typeIds= [|  |] } |> Some
      | 848 -> { GroupData.id= 848; name= "Asteroid Angel Cartel Commander Battleship"; categoryId= 11; published= false; typeIds= [| 13535; 13537; 13539; 13540; 13542; 13543; 22871; 22872; 22873; 22874 |] } |> Some
      | 945 -> { GroupData.id= 945; name= "Industrial Command Ship Blueprint"; categoryId= 9; published= true; typeIds= [| 28607; 33686; 43910 |] } |> Some
      | _ -> None