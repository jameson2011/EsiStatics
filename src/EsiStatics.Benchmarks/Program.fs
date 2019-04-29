namespace EsiStatics.Benchmarks

module Program=
    open System
    open BenchmarkDotNet.Running

    [<EntryPoint>]
    let main argv =
    
        let switch =
            BenchmarkSwitcher [|    typedefof<SolarSystemGetBenchmark>;
                                    typedefof<SolarSystemScanBenchmark>;
                                    typedefof<SolarSystemDeepGetBenchmark>;
                                    typedefof<SolarSystemCelestialDistancesBenchmark>;
                                    typedefof<SolarSystemNeighboursBenchmark>;
                                    |]
    
        switch.Run argv |> ignore
        0 
