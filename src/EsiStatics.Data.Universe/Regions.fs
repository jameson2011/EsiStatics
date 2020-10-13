namespace EsiStatics.Data.Universe
open System
open EsiStatics.Data.Entities
module  Regions=
    let getRegion id = 
      let bkt = id % 97
      match bkt with
        | 0 -> Regions0.getRegion id
        | 1 -> Regions1.getRegion id
        | 2 -> Regions2.getRegion id
        | 4 -> Regions4.getRegion id
        | 6 -> Regions6.getRegion id
        | 7 -> Regions7.getRegion id
        | 8 -> Regions8.getRegion id
        | 9 -> Regions9.getRegion id
        | 10 -> Regions10.getRegion id
        | 11 -> Regions11.getRegion id
        | 12 -> Regions12.getRegion id
        | 13 -> Regions13.getRegion id
        | 14 -> Regions14.getRegion id
        | 15 -> Regions15.getRegion id
        | 16 -> Regions16.getRegion id
        | 17 -> Regions17.getRegion id
        | 18 -> Regions18.getRegion id
        | 19 -> Regions19.getRegion id
        | 20 -> Regions20.getRegion id
        | 21 -> Regions21.getRegion id
        | 22 -> Regions22.getRegion id
        | 23 -> Regions23.getRegion id
        | 24 -> Regions24.getRegion id
        | 25 -> Regions25.getRegion id
        | 26 -> Regions26.getRegion id
        | 27 -> Regions27.getRegion id
        | 28 -> Regions28.getRegion id
        | 29 -> Regions29.getRegion id
        | 30 -> Regions30.getRegion id
        | 31 -> Regions31.getRegion id
        | 32 -> Regions32.getRegion id
        | 33 -> Regions33.getRegion id
        | 34 -> Regions34.getRegion id
        | 35 -> Regions35.getRegion id
        | 36 -> Regions36.getRegion id
        | 37 -> Regions37.getRegion id
        | 38 -> Regions38.getRegion id
        | 39 -> Regions39.getRegion id
        | 40 -> Regions40.getRegion id
        | 41 -> Regions41.getRegion id
        | 42 -> Regions42.getRegion id
        | 43 -> Regions43.getRegion id
        | 44 -> Regions44.getRegion id
        | 45 -> Regions45.getRegion id
        | 46 -> Regions46.getRegion id
        | 47 -> Regions47.getRegion id
        | 48 -> Regions48.getRegion id
        | 49 -> Regions49.getRegion id
        | 61 -> Regions61.getRegion id
        | 77 -> Regions77.getRegion id
        | 78 -> Regions78.getRegion id
        | 79 -> Regions79.getRegion id
        | 80 -> Regions80.getRegion id
        | 81 -> Regions81.getRegion id
        | 82 -> Regions82.getRegion id
        | 83 -> Regions83.getRegion id
        | 84 -> Regions84.getRegion id
        | 85 -> Regions85.getRegion id
        | 86 -> Regions86.getRegion id
        | 87 -> Regions87.getRegion id
        | 88 -> Regions88.getRegion id
        | 89 -> Regions89.getRegion id
        | 90 -> Regions90.getRegion id
        | 91 -> Regions91.getRegion id
        | 92 -> Regions92.getRegion id
        | 93 -> Regions93.getRegion id
        | 94 -> Regions94.getRegion id
        | 95 -> Regions95.getRegion id
        | 96 -> Regions96.getRegion id
        | _ -> None
    let regions =
        let ids =  [| 10000001; 10000002; 10000003; 10000004; 10000005; 10000006; 10000007; 10000008; 10000009; 10000010; 10000011; 10000012; 10000013; 10000014; 10000015; 10000016; 10000017; 10000018; 10000019; 10000020; 10000021; 10000022; 10000023; 10000025; 10000027; 10000028; 10000029; 10000030; 10000031; 10000032; 10000033; 10000034; 10000035; 10000036; 10000037; 10000038; 10000039; 10000040; 10000041; 10000042; 10000043; 10000044; 10000045; 10000046; 10000047; 10000048; 10000049; 10000050; 10000051; 10000052; 10000053; 10000054; 10000055; 10000056; 10000057; 10000058; 10000059; 10000060; 10000061; 10000062; 10000063; 10000064; 10000065; 10000066; 10000067; 10000068; 10000069; 10000070; 11000001; 11000002; 11000003; 11000004; 11000005; 11000006; 11000007; 11000008; 11000009; 11000010; 11000011; 11000012; 11000013; 11000014; 11000015; 11000016; 11000017; 11000018; 11000019; 11000020; 11000021; 11000022; 11000023; 11000024; 11000025; 11000026; 11000027; 11000028; 11000029; 11000030; 11000031; 11000032; 11000033; 12000001; 12000002; 12000003; 12000004; 12000005; 13000001 |] 
        (fun () -> ids |> Seq.map getRegion |> Seq.filter Option.isSome |> Seq.map Option.get )