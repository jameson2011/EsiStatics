namespace EsiStatics.Benchmarks

open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running
open BenchmarkDotNet.Configs
open BenchmarkDotNet.Jobs
open EsiStatics


[<CoreJob>]
[<RankColumn>][<MinColumn>][<Q1Column>][<Q3Column>][<MaxColumn>]
[<MaxIterationCount(1000)>]
type SolarSystemDeepGetBenchmark()=
    
    

    [<Params(30005003, 30000142, 30002089, 31000005)>]
    member val SolarSystemId = 0 with get, set
    
    [<Benchmark>]
    member this.GetSystem() =
        let sys = EsiStatics.SolarSystems.byId this.SolarSystemId |> Option.get
        
        
        sys.Celestials() |> List.ofSeq
        

