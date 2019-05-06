#r @"bin\Debug\netcoreapp2.2\EsiStatics.dll"
#r @"bin\Debug\netcoreapp2.2\EsiStatics.Data.Entities.dll"
#r @"bin\Debug\netcoreapp2.2\EsiStatics.Data.ItemTypes.dll"
#r @"bin\Debug\netcoreapp2.2\EsiStatics.Data.Universe.dll"

#time

open EsiStatics

open EsiStatics.Data.Entities

let solarSystems = Regions.all() 
                    |> Seq.collect (fun r -> r.Constellations())
                    |> Seq.collect (fun c -> c.SolarSystems())
                    |> Array.ofSeq
                    

let solarSystemFinder = new EsiStatics.SolarSystemFinder()

let adi = solarSystemFinder.Find "adirain" |> Seq.head
let ded = solarSystemFinder.Find "dead end" |> Seq.head

let route = Navigation.findRoute Navigation.euclideanSystemDistanceAvoidHighsec (adi, ded) |> Array.ofSeq

route |> Array.map (fun s -> s.Name)

solarSystemFinder.Find "adirain" 
            |> Seq.collect (fun s -> UniverseExtensions.Neighbours s 1)
            |> Array.ofSeq

let adi = solarSystemFinder.Find "adirain" |> Seq.head
let adiPlanets = adi |> UniverseExtensions.Planets |> Array.ofSeq
let adiStar = adi |> UniverseExtensions.Star |> Option.get

solarSystemFinder.Find "thera" |> Array.ofSeq

let itemTypesFinder = new ItemTypesFinder()
let mgs = MarketGroups.rootMarketGroups() |> Array.ofSeq
let shipMg = MarketGroups.marketGroup 4 |> Option.get
let shipItemTypes = shipMg |> MarketGroups.itemTypes
let shipChildren = MarketGroups.childMarketGroups shipMg |> Array.ofSeq
let frigates = shipChildren |> Seq.filter (fun mg -> mg.Name = "Frigates") |> Seq.head
let frigateGroups = frigates |> MarketGroups.childMarketGroups |> Array.ofSeq
let factionFrigates = frigateGroups 
                        |> Seq.filter (fun mg -> mg.Name = "Faction Frigates") 
                        |> Seq.head
                        |> MarketGroups.childMarketGroups
                        |> Seq.filter (fun mg -> mg.Name = "Navy Faction")
                        |> Seq.head
let parentage = factionFrigates |> MarketGroups.parentage


let categories = Categories.categories() |> Array.ofSeq

let cat = categories |> Seq.skip 3 |> Seq.head
cat |> Categories.groups |> Array.ofSeq

// cat 6 = ship
let cat = Categories.category 6 |> Option.get
let catGroups = cat |> Categories.groups |> Array.ofSeq

// citizen ships = group 2001
let shipGroup = Groups.group 2001 |> Option.get
let itemTypes = shipGroup |> Groups.itemTypes |> Array.ofSeq
let cat = shipGroup |> Groups.category