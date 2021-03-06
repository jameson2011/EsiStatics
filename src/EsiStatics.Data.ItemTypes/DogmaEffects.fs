﻿namespace EsiStatics.Data.ItemTypes
open System
open EsiStatics.Data.Entities
module  DogmaEffects=
    let getDogmaEffect id = 
      let bkt = id % 97
      match bkt with
        | 0 -> DogmaEffects0.getDogmaEffect id
        | 1 -> DogmaEffects1.getDogmaEffect id
        | 2 -> DogmaEffects2.getDogmaEffect id
        | 3 -> DogmaEffects3.getDogmaEffect id
        | 4 -> DogmaEffects4.getDogmaEffect id
        | 5 -> DogmaEffects5.getDogmaEffect id
        | 6 -> DogmaEffects6.getDogmaEffect id
        | 7 -> DogmaEffects7.getDogmaEffect id
        | 8 -> DogmaEffects8.getDogmaEffect id
        | 9 -> DogmaEffects9.getDogmaEffect id
        | 10 -> DogmaEffects10.getDogmaEffect id
        | 11 -> DogmaEffects11.getDogmaEffect id
        | 12 -> DogmaEffects12.getDogmaEffect id
        | 13 -> DogmaEffects13.getDogmaEffect id
        | 14 -> DogmaEffects14.getDogmaEffect id
        | 15 -> DogmaEffects15.getDogmaEffect id
        | 16 -> DogmaEffects16.getDogmaEffect id
        | 17 -> DogmaEffects17.getDogmaEffect id
        | 18 -> DogmaEffects18.getDogmaEffect id
        | 19 -> DogmaEffects19.getDogmaEffect id
        | 20 -> DogmaEffects20.getDogmaEffect id
        | 21 -> DogmaEffects21.getDogmaEffect id
        | 22 -> DogmaEffects22.getDogmaEffect id
        | 23 -> DogmaEffects23.getDogmaEffect id
        | 24 -> DogmaEffects24.getDogmaEffect id
        | 25 -> DogmaEffects25.getDogmaEffect id
        | 26 -> DogmaEffects26.getDogmaEffect id
        | 27 -> DogmaEffects27.getDogmaEffect id
        | 28 -> DogmaEffects28.getDogmaEffect id
        | 29 -> DogmaEffects29.getDogmaEffect id
        | 30 -> DogmaEffects30.getDogmaEffect id
        | 31 -> DogmaEffects31.getDogmaEffect id
        | 32 -> DogmaEffects32.getDogmaEffect id
        | 33 -> DogmaEffects33.getDogmaEffect id
        | 34 -> DogmaEffects34.getDogmaEffect id
        | 35 -> DogmaEffects35.getDogmaEffect id
        | 36 -> DogmaEffects36.getDogmaEffect id
        | 37 -> DogmaEffects37.getDogmaEffect id
        | 38 -> DogmaEffects38.getDogmaEffect id
        | 39 -> DogmaEffects39.getDogmaEffect id
        | 40 -> DogmaEffects40.getDogmaEffect id
        | 41 -> DogmaEffects41.getDogmaEffect id
        | 42 -> DogmaEffects42.getDogmaEffect id
        | 43 -> DogmaEffects43.getDogmaEffect id
        | 44 -> DogmaEffects44.getDogmaEffect id
        | 45 -> DogmaEffects45.getDogmaEffect id
        | 46 -> DogmaEffects46.getDogmaEffect id
        | 47 -> DogmaEffects47.getDogmaEffect id
        | 48 -> DogmaEffects48.getDogmaEffect id
        | 49 -> DogmaEffects49.getDogmaEffect id
        | 50 -> DogmaEffects50.getDogmaEffect id
        | 51 -> DogmaEffects51.getDogmaEffect id
        | 52 -> DogmaEffects52.getDogmaEffect id
        | 53 -> DogmaEffects53.getDogmaEffect id
        | 54 -> DogmaEffects54.getDogmaEffect id
        | 55 -> DogmaEffects55.getDogmaEffect id
        | 56 -> DogmaEffects56.getDogmaEffect id
        | 57 -> DogmaEffects57.getDogmaEffect id
        | 58 -> DogmaEffects58.getDogmaEffect id
        | 59 -> DogmaEffects59.getDogmaEffect id
        | 60 -> DogmaEffects60.getDogmaEffect id
        | 61 -> DogmaEffects61.getDogmaEffect id
        | 62 -> DogmaEffects62.getDogmaEffect id
        | 63 -> DogmaEffects63.getDogmaEffect id
        | 64 -> DogmaEffects64.getDogmaEffect id
        | 65 -> DogmaEffects65.getDogmaEffect id
        | 66 -> DogmaEffects66.getDogmaEffect id
        | 67 -> DogmaEffects67.getDogmaEffect id
        | 68 -> DogmaEffects68.getDogmaEffect id
        | 69 -> DogmaEffects69.getDogmaEffect id
        | 70 -> DogmaEffects70.getDogmaEffect id
        | 71 -> DogmaEffects71.getDogmaEffect id
        | 72 -> DogmaEffects72.getDogmaEffect id
        | 73 -> DogmaEffects73.getDogmaEffect id
        | 74 -> DogmaEffects74.getDogmaEffect id
        | 75 -> DogmaEffects75.getDogmaEffect id
        | 76 -> DogmaEffects76.getDogmaEffect id
        | 77 -> DogmaEffects77.getDogmaEffect id
        | 78 -> DogmaEffects78.getDogmaEffect id
        | 79 -> DogmaEffects79.getDogmaEffect id
        | 80 -> DogmaEffects80.getDogmaEffect id
        | 81 -> DogmaEffects81.getDogmaEffect id
        | 82 -> DogmaEffects82.getDogmaEffect id
        | 83 -> DogmaEffects83.getDogmaEffect id
        | 84 -> DogmaEffects84.getDogmaEffect id
        | 85 -> DogmaEffects85.getDogmaEffect id
        | 86 -> DogmaEffects86.getDogmaEffect id
        | 87 -> DogmaEffects87.getDogmaEffect id
        | 88 -> DogmaEffects88.getDogmaEffect id
        | 89 -> DogmaEffects89.getDogmaEffect id
        | 90 -> DogmaEffects90.getDogmaEffect id
        | 91 -> DogmaEffects91.getDogmaEffect id
        | 92 -> DogmaEffects92.getDogmaEffect id
        | 93 -> DogmaEffects93.getDogmaEffect id
        | 94 -> DogmaEffects94.getDogmaEffect id
        | 95 -> DogmaEffects95.getDogmaEffect id
        | 96 -> DogmaEffects96.getDogmaEffect id
        | _ -> None