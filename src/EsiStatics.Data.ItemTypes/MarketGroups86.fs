namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module internal MarketGroups86=
    let getMarketGroup id = 
      match id with 
      | 1056 -> { MarketGroupData.id= 1056; name= "Capital"; parentMarketGroupId= Some(537); typeIds= [| 41479; 41463; 3536; 41465; 41464; 24569; 41466; 41467; 41468 |]; description= "Remote armor repair system designs, intended for capital-class vessels." } |> Some
      | 1250 -> { MarketGroupData.id= 1250; name= "Medium Electronics Superiority Rigs"; parentMarketGroupId= Some(948); typeIds= [| 31265; 31301; 31337; 31349; 31289; 31253 |]; description= "Blueprints of Medium Electronics Superiority Rigs." } |> Some
      | 1347 -> { MarketGroupData.id= 1347; name= "Hybrid Batteries"; parentMarketGroupId= Some(1534); typeIds= [| 2803; 2804; 2806; 2808; 2813; 2815 |]; description= "Blueprints of Hybrid Batteries." } |> Some
      | 1541 -> { MarketGroupData.id= 1541; name= "Armor Plates"; parentMarketGroupId= Some(214); typeIds= [| 11296; 11298; 11300; 41607; 41608; 41609; 11280; 11292; 11294 |]; description= "Blueprints for Armor Plates" } |> Some
      | 1735 -> { MarketGroupData.id= 1735; name= "Capital Energy Weapon Rigs"; parentMarketGroupId= Some(962); typeIds= [| 31488; 31458; 31428; 31494; 31464; 31434; 31500; 31470; 31440; 31476; 31446; 31482; 31452; 31422 |]; description= "Modifications that affect a capital starship's energy weapons." } |> Some
      | 1832 -> { MarketGroupData.id= 1832; name= "Mobile Cynosural Inhibitors"; parentMarketGroupId= Some(404); typeIds= [| 33476 |]; description= "" } |> Some
      | 2026 -> { MarketGroupData.id= 2026; name= "Gallente"; parentMarketGroupId= Some(2023); typeIds= [| 34817; 45571; 44933; 42186; 37582; 46961; 49426; 36404; 52750; 46427; 45915; 46555; 50149 |]; description= "" } |> Some
      | 2220 -> { MarketGroupData.id= 2220; name= "Capacitor Power Relays"; parentMarketGroupId= Some(2208); typeIds= [| 47356; 47358 |]; description= "" } |> Some
      | 2317 -> { MarketGroupData.id= 2317; name= "Strong Boxes"; parentMarketGroupId= Some(19); typeIds= [| 46601; 46602; 46603; 45584; 45585; 43682; 43683; 43684; 43685; 43686; 43687; 43688; 43689; 43690; 43691; 43692; 43693; 43695; 43696; 43697; 43698; 45677; 45678; 45679; 46579; 46580 |]; description= "" } |> Some
      | 2414 -> { MarketGroupData.id= 2414; name= "Armor Reinforcers"; parentMarketGroupId= Some(2208); typeIds= [| 47360; 47362 |]; description= "" } |> Some
      | 2511 -> { MarketGroupData.id= 2511; name= "Navigation Structures"; parentMarketGroupId= Some(477); typeIds= [| 35840; 35841; 37534 |]; description= "" } |> Some
      | 280 -> { MarketGroupData.id= 280; name= "Caldari"; parentMarketGroupId= Some(207); typeIds= [| 688; 24689; 994 |]; description= "Blueprints of Caldari battleship designs." } |> Some
      | 377 -> { MarketGroupData.id= 377; name= "Spaceship Command"; parentMarketGroupId= Some(150); typeIds= [| 3328; 3329; 3330; 3331; 3332; 3333; 3334; 3335; 3336; 3337; 3338; 3339; 3340; 3341; 3342; 3343; 3344; 3345; 3346; 3347; 17940; 32918; 22551; 37615; 33093; 28656; 33856; 19719; 20524; 20525; 20526; 20527; 20528; 40328; 20530; 20531; 20532; 20533; 35685; 30650; 30651; 12092; 12093; 12095; 12096; 28609; 12098; 33091; 33092; 29637; 33094; 28615; 33096; 33097; 33098; 30652; 34390; 49742; 16591; 47445; 23950; 28374; 40535; 40536; 40537; 40538; 49743; 34533; 35680; 33095; 47867; 29029; 34327; 22761; 30653; 3184; 20342; 24311; 24312; 24313; 24314; 28667; 47868; 47869; 3327 |]; description= "Skills required for commanding all shapes and sizes of spaceships" } |> Some
      | 668 -> { MarketGroupData.id= 668; name= "Capacitor Boosters"; parentMarketGroupId= Some(655); typeIds= [|  |]; description= "Provide quick injections of power into the capacitor." } |> Some
      | 765 -> { MarketGroupData.id= 765; name= "Minmatar"; parentMarketGroupId= Some(761); typeIds= [| 19722 |]; description= "Minmatar dreadnought designs." } |> Some
      | 86 -> { MarketGroupData.id= 86; name= "Hybrid Turrets"; parentMarketGroupId= Some(10); typeIds= [|  |]; description= "Hybrid turrets are specifically designed to house railguns and blasters." } |> Some
      | 862 -> { MarketGroupData.id= 862; name= "Small"; parentMarketGroupId= Some(849); typeIds= [| 12612; 12614 |]; description= "Small advanced hybrid shells, fired by frigate-sized guns." } |> Some
      | _ -> None