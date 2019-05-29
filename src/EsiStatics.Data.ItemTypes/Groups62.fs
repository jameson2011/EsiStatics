namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups62=
    let getGroup id = 
      match id with 
      | 1032 -> { GroupData.id= 1032; name= "Planet Solid - Raw Resource"; categoryId= 42; published= true; typeIds= [| 2267; 2270; 2272; 2306; 2307 |] } |> Some
      | 1226 -> { GroupData.id= 1226; name= "Survey Probe Launcher"; categoryId= 7; published= true; typeIds= [| 33270; 33272 |] } |> Some
      | 1323 -> { GroupData.id= 1323; name= "Structure Observatory Service Module"; categoryId= 66; published= false; typeIds= [| 35905; 35906; 35907; 35908; 35909; 35910; 35911 |] } |> Some
      | 1614 -> { GroupData.id= 1614; name= "Structure Combat Rig M - Missile Projection"; categoryId= 66; published= true; typeIds= [| 37220; 37221 |] } |> Some
      | 2002 -> { GroupData.id= 2002; name= "Triglavian Datastreams"; categoryId= 17; published= true; typeIds= [| 48764; 48765; 48767; 48768; 48769; 48770; 48771; 48772; 48774; 48775; 48777; 48778; 52190; 52191; 52192; 52195; 52196; 52197; 52408; 52409; 52410; 52411; 52412; 52413 |] } |> Some
      | 256 -> { GroupData.id= 256; name= "Missiles"; categoryId= 16; published= true; typeIds= [| 3319; 3320; 3321; 3322; 3323; 3324; 3325; 3326; 12441; 12442; 20209; 20210; 20211; 20212; 20213; 20312; 20314; 20315; 21071; 21668; 25718; 25719; 28073; 32435; 41409; 41410 |] } |> Some
      | 353 -> { GroupData.id= 353; name= "QA Module"; categoryId= 7; published= false; typeIds= [| 2528; 4360; 4371; 4372; 4373; 4374; 4375; 4376; 4377; 4380; 11744; 17617; 18642; 20197; 26869; 30223; 33375; 33762; 37136; 37137; 42240; 44278; 44281; 46690; 52266 |] } |> Some
      | 450 -> { GroupData.id= 450; name= "Arkonor"; categoryId= 25; published= true; typeIds= [| 22; 17425; 17426; 26852; 28367; 28385; 28387; 28625; 46678; 46691 |] } |> Some
      | 547 -> { GroupData.id= 547; name= "Carrier"; categoryId= 6; published= true; typeIds= [| 23757; 23911; 23915; 24483; 42132 |] } |> Some
      | 62 -> { GroupData.id= 62; name= "Armor Repair Unit"; categoryId= 7; published= true; typeIds= [| 523; 1183; 3528; 3530; 3534; 3538; 3540; 4529; 4531; 4533; 4535; 4569; 4571; 4573; 4575; 4579; 4609; 4611; 4613; 4615; 4621; 13955; 13956; 13957; 13958; 13959; 13960; 13962; 13963; 13964; 14067; 14068; 14069; 14552; 14554; 14848; 14849; 14850; 14851; 14852; 14853; 14854; 14855; 15160; 15161; 15162; 15163; 15741; 15742; 15743; 15744; 15745; 15746; 17492; 17493; 17494; 17546; 17547; 17548; 18999; 19001; 19003; 19005; 19007; 19009; 19011; 19013; 19015; 19017; 19019; 19021; 19023; 19025; 19027; 19029; 19031; 19033; 19035; 19036; 19037; 19038; 19039; 19040; 19041; 19042; 19043; 19044; 19045; 19046; 20701; 21853; 22887; 22889; 22891; 23795; 23797; 23799; 28544; 28549; 28556; 41498; 41499; 41500; 41501; 41502; 47769; 47773; 47777; 52265 |] } |> Some
      | 644 -> { GroupData.id= 644; name= "Drone Navigation Computer"; categoryId= 7; published= true; typeIds= [| 24395; 24417; 32943; 32945; 32947; 32949; 33850; 33852 |] } |> Some
      | 741 -> { GroupData.id= 741; name= "Cyber Engineering"; categoryId= 20; published= true; typeIds= [| 3237; 3238; 3239; 3240; 3241; 3246; 3247; 3248; 3249; 3250; 3251; 3252; 3253; 3254; 3255; 3256; 3257; 3258; 3262; 3263; 3264; 3265; 3266; 3267; 13216; 13251; 13254; 13255; 13259; 13260; 13261; 13265; 27116; 27117; 27118; 27119; 27120; 27121; 27122; 27123; 27124; 27125; 27126; 27127; 27128; 27129; 27142; 27143; 27223 |] } |> Some
      | 838 -> { GroupData.id= 838; name= "Cynosural Generator Array"; categoryId= 23; published= true; typeIds= [| 27673 |] } |> Some
      | 935 -> { GroupData.id= 935; name= "WorldSpace"; categoryId= 26; published= false; typeIds= [| 32571; 32574; 32575; 32576; 32577; 32578; 32579; 32580; 32581; 32643; 32746; 32748; 32751; 32752 |] } |> Some
      | _ -> None