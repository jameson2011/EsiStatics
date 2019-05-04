
#r @"bin\Debug\netcoreapp2.2\EsiStatics.dll"
#r @"bin\Debug\netcoreapp2.2\EsiStatics.Data.Entities.dll"
#r @"bin\Debug\netcoreapp2.2\EsiStatics.Data.Universe.dll"

#time

open EsiStatics
open EsiStatics.Data.Entities
open EsiStatics.Data.Universe

let solarSystems = Regions.all() 
                    |> Seq.collect (fun r -> r.Constellations())
                    |> Seq.collect (fun c -> c.SolarSystems())
                    |> Array.ofSeq

let indexValues = solarSystems 
                    |> Array.map (fun s -> (s.Name, (s.Name, s.Id)))

let index =  new EsiStatics.MutableTrie<string * int>(indexValues)

index.Find "adi"

let solarSystemFinder = new EsiStatics.SolarSystemFinder()

solarSystemFinder.Find "adi" |> Array.ofSeq

solarSystemFinder.Find "adirain" |> Array.ofSeq

solarSystemFinder.Find "thera" |> Array.ofSeq