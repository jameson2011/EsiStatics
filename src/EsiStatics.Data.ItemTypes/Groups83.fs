namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal Groups83=
    let getGroup id = 
      match id with 
      | 1053 -> { GroupData.id= 1053; name= "Incursion Sansha's Nation Frigate"; categoryId= 11; published= false; typeIds= [| 2190; 2907; 2909; 2939; 2966; 3259; 3492; 3524; 3525; 3526 |] } |> Some
      | 1150 -> { GroupData.id= 1150; name= "Armor Resistance Shift Hardener"; categoryId= 7; published= true; typeIds= [| 4403 |] } |> Some
      | 1247 -> { GroupData.id= 1247; name= "Mobile Siphon Unit"; categoryId= 22; published= true; typeIds= [| 33477; 33478; 33479; 33581; 33583 |] } |> Some
      | 1441 -> { GroupData.id= 1441; name= "Structure Stasis Webifier"; categoryId= 66; published= true; typeIds= [| 35943; 47351 |] } |> Some
      | 1538 -> { GroupData.id= 1538; name= "Force Auxiliary"; categoryId= 6; published= true; typeIds= [| 37604; 37605; 37606; 37607; 42133; 42242; 45645 |] } |> Some
      | 1635 -> { GroupData.id= 1635; name= "Structure Combat Rig L - Max Targets and Sensor Boosting"; categoryId= 66; published= true; typeIds= [| 37260; 37261 |] } |> Some
      | 180 -> { GroupData.id= 180; name= "Protective Sentry Gun"; categoryId= 11; published= false; typeIds= [|  |] } |> Some
      | 1829 -> { GroupData.id= 1829; name= "Structure Engineering Rig M - Basic Large Ship TE"; categoryId= 66; published= true; typeIds= [| 43733; 43734 |] } |> Some
      | 1926 -> { GroupData.id= 1926; name= "Irregular Freighter"; categoryId= 11; published= false; typeIds= [| 49694; 49695; 50109 |] } |> Some
      | 2023 -> { GroupData.id= 2023; name= "Cyber Electronics Implant Blueprints"; categoryId= 9; published= true; typeIds= [| 50068; 50072; 50073 |] } |> Some
      | 374 -> { GroupData.id= 374; name= "Advanced Beam Laser Crystal"; categoryId= 8; published= true; typeIds= [| 12552; 12557; 12559; 12822; 12824; 12826; 12828; 12830; 12832; 41334; 41336 |] } |> Some
      | 4060 -> { GroupData.id= 4060; name= "Vorton Projector"; categoryId= 7; published= true; typeIds= [| 54739; 54740; 54741; 54742; 54743; 54745; 54746; 54747; 54748; 54749; 54750; 54751; 54752; 54753; 54754 |] } |> Some
      | 471 -> { GroupData.id= 471; name= "Corporate Hangar Array"; categoryId= 23; published= true; typeIds= [| 17621; 24652 |] } |> Some
      | 568 -> { GroupData.id= 568; name= "Asteroid Sansha's Nation Hauler"; categoryId= 11; published= false; typeIds= [| 13726; 13727; 13728; 13729; 13730; 13731; 13732; 13733; 13734; 13735; 13736; 13737 |] } |> Some
      | 665 -> { GroupData.id= 665; name= "Mission Amarr Empire Frigate"; categoryId= 11; published= false; typeIds= [| 11657; 11658; 11662; 11663; 14351; 14352; 14362; 14363; 14364; 14479; 14482; 15344; 15347; 15577; 15578; 15977; 15978; 15982; 15983; 15984; 15985; 15986; 15987; 16244; 24891; 24892; 24893; 24894; 24895; 24896; 24897; 24898; 24899; 24900; 24901; 24902; 24903; 24904; 24905; 24906; 24907; 24908; 24909; 24910; 24923; 24924; 24925; 24926; 24927; 24928; 24929; 24930; 24931; 24932; 29804; 29805; 29806; 29807; 29808; 29809; 29810; 29811; 29812; 29813; 29814; 29815; 30763; 30764; 30765; 30766; 30818; 45050 |] } |> Some
      | 762 -> { GroupData.id= 762; name= "Inertial Stabilizer"; categoryId= 7; published= true; typeIds= [| 1401; 1403; 1405; 5519; 5521; 5523; 5525; 5527; 5529; 5531; 5533; 21498; 34481; 34483 |] } |> Some
      | 83 -> { GroupData.id= 83; name= "Projectile Ammo"; categoryId= 8; published= true; typeIds= [| 178; 179; 180; 181; 182; 183; 184; 185; 186; 187; 188; 189; 190; 191; 192; 193; 194; 195; 196; 197; 198; 199; 200; 201; 17664; 17666; 17668; 17670; 17672; 17674; 17676; 17678; 19970; 19972; 19974; 19976; 19986; 19988; 19990; 19992; 19994; 19996; 19998; 20000; 20002; 20004; 20006; 20008; 20721; 20723; 20725; 20727; 20729; 20731; 20733; 20735; 20737; 20739; 20741; 20743; 20745; 20747; 20749; 20751; 20753; 20755; 20757; 20759; 20761; 20763; 20765; 20767; 20769; 20771; 20773; 20775; 20777; 20779; 20781; 20783; 20785; 20787; 20789; 20791; 20793; 20795; 20797; 20799; 20801; 20803; 20805; 20807; 20809; 20811; 20813; 20815; 21894; 21896; 21898; 21900; 21902; 21904; 21906; 21908; 21910; 21912; 21914; 21916; 21918; 21920; 21922; 21924; 21926; 21928; 21931; 21933; 21935; 21937; 21939; 21941; 28324; 28326; 28328; 28330; 28332; 28334; 28336; 28338; 32801 |] } |> Some
      | 859 -> { GroupData.id= 859; name= "Starbase - Sensor Dampening Array Blueprints"; categoryId= 9; published= true; typeIds= [| 27873; 27874 |] } |> Some
      | 956 -> { GroupData.id= 956; name= "Offensive Subsystem"; categoryId= 32; published= true; typeIds= [| 45598; 45599; 45600; 45601; 45602; 45603; 45604; 45605; 45606; 45607; 45608; 45609 |] } |> Some
      | _ -> None