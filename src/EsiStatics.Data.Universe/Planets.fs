﻿namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module  Planets=
    let getPlanet id = 
      let bkt = id % 97
      match bkt with
        | 0 -> Planets0.getPlanet id
        | 1 -> Planets1.getPlanet id
        | 2 -> Planets2.getPlanet id
        | 3 -> Planets3.getPlanet id
        | 4 -> Planets4.getPlanet id
        | 5 -> Planets5.getPlanet id
        | 6 -> Planets6.getPlanet id
        | 7 -> Planets7.getPlanet id
        | 8 -> Planets8.getPlanet id
        | 9 -> Planets9.getPlanet id
        | 10 -> Planets10.getPlanet id
        | 11 -> Planets11.getPlanet id
        | 12 -> Planets12.getPlanet id
        | 13 -> Planets13.getPlanet id
        | 14 -> Planets14.getPlanet id
        | 15 -> Planets15.getPlanet id
        | 16 -> Planets16.getPlanet id
        | 17 -> Planets17.getPlanet id
        | 18 -> Planets18.getPlanet id
        | 19 -> Planets19.getPlanet id
        | 20 -> Planets20.getPlanet id
        | 21 -> Planets21.getPlanet id
        | 22 -> Planets22.getPlanet id
        | 23 -> Planets23.getPlanet id
        | 24 -> Planets24.getPlanet id
        | 25 -> Planets25.getPlanet id
        | 26 -> Planets26.getPlanet id
        | 27 -> Planets27.getPlanet id
        | 28 -> Planets28.getPlanet id
        | 29 -> Planets29.getPlanet id
        | 30 -> Planets30.getPlanet id
        | 31 -> Planets31.getPlanet id
        | 32 -> Planets32.getPlanet id
        | 33 -> Planets33.getPlanet id
        | 34 -> Planets34.getPlanet id
        | 35 -> Planets35.getPlanet id
        | 36 -> Planets36.getPlanet id
        | 37 -> Planets37.getPlanet id
        | 38 -> Planets38.getPlanet id
        | 39 -> Planets39.getPlanet id
        | 40 -> Planets40.getPlanet id
        | 41 -> Planets41.getPlanet id
        | 42 -> Planets42.getPlanet id
        | 43 -> Planets43.getPlanet id
        | 44 -> Planets44.getPlanet id
        | 45 -> Planets45.getPlanet id
        | 46 -> Planets46.getPlanet id
        | 47 -> Planets47.getPlanet id
        | 48 -> Planets48.getPlanet id
        | 49 -> Planets49.getPlanet id
        | 50 -> Planets50.getPlanet id
        | 51 -> Planets51.getPlanet id
        | 52 -> Planets52.getPlanet id
        | 53 -> Planets53.getPlanet id
        | 54 -> Planets54.getPlanet id
        | 55 -> Planets55.getPlanet id
        | 56 -> Planets56.getPlanet id
        | 57 -> Planets57.getPlanet id
        | 58 -> Planets58.getPlanet id
        | 59 -> Planets59.getPlanet id
        | 60 -> Planets60.getPlanet id
        | 61 -> Planets61.getPlanet id
        | 62 -> Planets62.getPlanet id
        | 63 -> Planets63.getPlanet id
        | 64 -> Planets64.getPlanet id
        | 65 -> Planets65.getPlanet id
        | 66 -> Planets66.getPlanet id
        | 67 -> Planets67.getPlanet id
        | 68 -> Planets68.getPlanet id
        | 69 -> Planets69.getPlanet id
        | 70 -> Planets70.getPlanet id
        | 71 -> Planets71.getPlanet id
        | 72 -> Planets72.getPlanet id
        | 73 -> Planets73.getPlanet id
        | 74 -> Planets74.getPlanet id
        | 75 -> Planets75.getPlanet id
        | 76 -> Planets76.getPlanet id
        | 77 -> Planets77.getPlanet id
        | 78 -> Planets78.getPlanet id
        | 79 -> Planets79.getPlanet id
        | 80 -> Planets80.getPlanet id
        | 81 -> Planets81.getPlanet id
        | 82 -> Planets82.getPlanet id
        | 83 -> Planets83.getPlanet id
        | 84 -> Planets84.getPlanet id
        | 85 -> Planets85.getPlanet id
        | 86 -> Planets86.getPlanet id
        | 87 -> Planets87.getPlanet id
        | 88 -> Planets88.getPlanet id
        | 89 -> Planets89.getPlanet id
        | 90 -> Planets90.getPlanet id
        | 91 -> Planets91.getPlanet id
        | 92 -> Planets92.getPlanet id
        | 93 -> Planets93.getPlanet id
        | 94 -> Planets94.getPlanet id
        | 95 -> Planets95.getPlanet id
        | 96 -> Planets96.getPlanet id
        | _ -> None