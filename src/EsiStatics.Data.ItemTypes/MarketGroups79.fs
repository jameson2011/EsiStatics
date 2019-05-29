namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups79=
    let getMarketGroup id = 
      match id with 
      | 1049 -> { MarketGroupData.id= 1049; name= "Small "; parentMarketGroupId= Some(134); typeIds= [| 15744; 13962; 13963; 17548; 19011; 1183; 52265; 4529; 4531; 33076; 4533; 18999; 19001; 19003; 19005; 19007; 19009; 523; 19013; 19015; 13964; 4535; 17494; 21853; 22887; 28556; 23795; 14069; 15741 |]; description= "Armor repair designs, intended for frigate-class vessels." } |> Some
      | 1243 -> { MarketGroupData.id= 1243; name= "Small Drone Rigs"; parentMarketGroupId= Some(946); typeIds= [| 32034; 32070; 32042; 32082; 32050; 32026; 32090; 32058 |]; description= "Blueprints of Small Drone Rigs." } |> Some
      | 1340 -> { MarketGroupData.id= 1340; name= "Assembly Arrays"; parentMarketGroupId= Some(1841); typeIds= [|  |]; description= "Blueprints of Assembly Arrays." } |> Some
      | 1534 -> { MarketGroupData.id= 1534; name= "Weapon Batteries"; parentMarketGroupId= Some(1841); typeIds= [|  |]; description= "Weapon Batteries" } |> Some
      | 1631 -> { MarketGroupData.id= 1631; name= "Faction Shuttles"; parentMarketGroupId= Some(391); typeIds= [| 21097; 21628 |]; description= "Faction Shuttles" } |> Some
      | 1728 -> { MarketGroupData.id= 1728; name= "Capital Projectile Weapon Rigs"; parentMarketGroupId= Some(953); typeIds= [| 31673; 31697; 31661; 31709; 31685 |]; description= "Blueprints of Capital Projectile Weapon Rigs." } |> Some
      | 1922 -> { MarketGroupData.id= 1922; name= "Pilot's Services"; parentMarketGroupId= None; typeIds= [|  |]; description= "Services available to capsuleers include PLEX, Multiple Pilot Training, Pilot's Body Resculpt Certificates, and Skill Trading items" } |> Some
      | 2213 -> { MarketGroupData.id= 2213; name= "Stasis Webifiers"; parentMarketGroupId= Some(2206); typeIds= [| 47351; 35943 |]; description= "" } |> Some
      | 2310 -> { MarketGroupData.id= 2310; name= "Amarr"; parentMarketGroupId= Some(2309); typeIds= [| 46786; 42564; 44101; 45773; 50069; 49816; 42907; 46527 |]; description= "" } |> Some
      | 2407 -> { MarketGroupData.id= 2407; name= "Structure Burst Projectors"; parentMarketGroupId= Some(2161); typeIds= [| 47107; 47109; 47110; 47111; 47112; 47113; 47114 |]; description= "" } |> Some
      | 2504 -> { MarketGroupData.id= 2504; name= "Overclocker"; parentMarketGroupId= Some(2502); typeIds= [| 48114; 46004; 46005; 46006 |]; description= "Overclocker Boosters" } |> Some
      | 273 -> { MarketGroupData.id= 273; name= "Minmatar"; parentMarketGroupId= Some(206); typeIds= [| 976; 692; 974; 975 |]; description= "Blueprints of Minmatar cruiser designs." } |> Some
      | 355196 -> { MarketGroupData.id= 355196; name= "Prototype"; parentMarketGroupId= Some(355193); typeIds= [|  |]; description= "" } |> Some
      | 363441 -> { MarketGroupData.id= 363441; name= "Heavy"; parentMarketGroupId= Some(354448); typeIds= [|  |]; description= " " } |> Some
      | 364896 -> { MarketGroupData.id= 364896; name= "Prototype"; parentMarketGroupId= Some(364893); typeIds= [|  |]; description= "Prototype heavy frames." } |> Some
      | 365769 -> { MarketGroupData.id= 365769; name= "Rail Rifles"; parentMarketGroupId= Some(364047); typeIds= [|  |]; description= "Rail Rifles." } |> Some
      | 366254 -> { MarketGroupData.id= 366254; name= ""; parentMarketGroupId= Some(366190); typeIds= [|  |]; description= "" } |> Some
      | 366351 -> { MarketGroupData.id= 366351; name= "Faction Booster Gallente"; parentMarketGroupId= Some(354534); typeIds= [|  |]; description= "" } |> Some
      | 370 -> { MarketGroupData.id= 370; name= "Fleet Support"; parentMarketGroupId= Some(150); typeIds= [| 22552; 11574; 22536; 20494; 20495; 43728; 11569; 3348; 3349; 3350; 3351; 3352; 11572; 3354; 24764 |]; description= "Skills pertaining to the operation of Command Burst modules" } |> Some
      | 467 -> { MarketGroupData.id= 467; name= "Gallente"; parentMarketGroupId= Some(464); typeIds= [| 16240; 32872 |]; description= "Gallente destroyer designs." } |> Some
      | 564 -> { MarketGroupData.id= 564; name= "Small"; parentMarketGroupId= Some(555); typeIds= [| 3074; 3098; 13894; 13864; 13865; 13866; 13867; 561; 565; 10678; 10680; 10688; 10690; 10692; 13893; 10694; 15816; 7247; 15824; 7249; 7251; 7253; 15823; 15836; 15843; 15844; 20587; 7287; 7289; 7291; 7293 |]; description= "Fast-tracking, low-damage railguns, for use on frigates." } |> Some
      | 661 -> { MarketGroupData.id= 661; name= "Energy Neutralizers"; parentMarketGroupId= Some(655); typeIds= [|  |]; description= "Neutralize a portion of the target ship's capacitor energy." } |> Some
      | 79 -> { MarketGroupData.id= 79; name= "Amarr"; parentMarketGroupId= Some(7); typeIds= [| 642; 643; 24692 |]; description= "Amarr battleship designs." } |> Some
      | 855 -> { MarketGroupData.id= 855; name= "Medium"; parentMarketGroupId= Some(846); typeIds= [| 12771; 12767 |]; description= "Medium ADAR ammunition, fired by cruiser-sized guns." } |> Some
      | 952 -> { MarketGroupData.id= 952; name= "Missile Launcher Rigs"; parentMarketGroupId= Some(943); typeIds= [|  |]; description= "Permanent modification of a ship's missile launcher facilities." } |> Some
      | _ -> None