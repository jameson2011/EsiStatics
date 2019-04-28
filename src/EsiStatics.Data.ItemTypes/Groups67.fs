namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups67=
    let getGroup id = 
      match id with 
      | 1231 -> { GroupData.id= 1231; name= "Cyber Biology"; categoryId= 20; published= true; typeIds= [| 25545; 25546; 25547; 25548; 27147; 27148 |] } |> Some
      | 1328 -> { GroupData.id= 1328; name= "Structure Guided Bomb Launcher"; categoryId= 66; published= true; typeIds= [| 35923; 47325 |] } |> Some
      | 1619 -> { GroupData.id= 1619; name= "Structure Combat Rig M - EW projection"; categoryId= 66; published= true; typeIds= [| 37228; 37229 |] } |> Some
      | 1813 -> { GroupData.id= 1813; name= "♦ Cruiser"; categoryId= 11; published= false; typeIds= [| 43557; 43558; 43559; 43560; 43568; 43569; 43570; 43571; 43579; 43580; 43581; 43582; 43590; 43591; 43592; 43593; 43601; 43602; 43603; 43604; 43622; 43623; 43624; 43625; 43641; 43642; 43649; 43656; 46054; 46056; 46059; 46062; 46067; 46071; 46075; 46079; 46581; 46760; 48583 |] } |> Some
      | 358 -> { GroupData.id= 358; name= "Heavy Assault Cruiser"; categoryId= 6; published= true; typeIds= [| 2836; 3518; 11993; 11999; 12003; 12005; 12011; 12015; 12019; 12023; 32209; 34477; 34479 |] } |> Some
      | 455 -> { GroupData.id= 455; name= "Hemorphite"; categoryId= 25; published= true; typeIds= [| 1231; 17444; 17445; 28403; 28404; 28405; 46681; 46697 |] } |> Some
      | 552 -> { GroupData.id= 552; name= "Asteroid Angel Cartel Battleship"; categoryId= 11; published= false; typeIds= [| 11898; 11899; 11900; 11927; 22838; 22839; 22840; 22841; 22842; 22843 |] } |> Some
      | 649 -> { GroupData.id= 649; name= "Freight Container"; categoryId= 2; published= true; typeIds= [| 3468; 24445; 33003; 33005; 33007; 33009; 33011 |] } |> Some
      | 67 -> { GroupData.id= 67; name= "Remote Capacitor Transmitter"; categoryId= 7; published= true; typeIds= [| 529; 1190; 3575; 5087; 5089; 5091; 5093; 12102; 12217; 12219; 12221; 12223; 12225; 16481; 16483; 16485; 16487; 16489; 16491; 16493; 16495; 19065; 19067; 19069; 19071; 19073; 19075; 19077; 19079; 19081; 19083; 19085; 19087; 23852; 23854; 23856; 31946; 31948; 31950; 41565; 41566 |] } |> Some
      | 746 -> { GroupData.id= 746; name= "Cyber Missile"; categoryId= 20; published= true; typeIds= [| 3125; 3126; 3127; 3128; 3129; 3132; 3133; 3134; 3135; 3136; 3137; 3140; 3141; 3142; 3143; 3144; 3145; 3148; 3149; 3150; 3151; 3152; 3153; 3156; 3157; 3158; 3159; 3160; 3161; 3164; 3165; 3166; 3167; 3168; 3169; 3172; 3173; 3174; 3175; 3176; 3177; 3180; 3181; 3182; 3183; 13226; 13227; 13228; 13229; 13230; 13231; 13247; 13248; 13249; 13250; 20371; 24632; 24636; 24637; 24638; 24639; 24640; 24641; 24642; 27091; 27092; 27093; 27094; 27095; 27096; 27108; 27109; 27204; 27205; 27206; 27243; 27244; 27245; 27246; 27247; 27249; 27250; 27251; 27252; 27253; 27254; 27255; 27256; 27257; 27258; 27259 |] } |> Some
      | 843 -> { GroupData.id= 843; name= "Asteroid Rogue Drone Commander BattleCruiser"; categoryId= 11; published= false; typeIds= [| 27732; 27733; 27734; 27735; 27736; 27737 |] } |> Some
      | 940 -> { GroupData.id= 940; name= "Furniture"; categoryId= 49; published= true; typeIds= [| 3910; 3911; 3914; 3916; 3919; 3930; 3931; 3932; 3933; 3934; 32617; 32619; 32620; 32621; 32622; 32627; 32630; 32640; 32641; 32650; 32654; 32665; 32684; 32697; 32711; 32712; 32713; 32714; 32715; 32716; 32717; 32739; 32740; 32741; 32742 |] } |> Some
      | _ -> None