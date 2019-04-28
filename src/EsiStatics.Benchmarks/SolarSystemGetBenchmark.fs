namespace EsiStatics.Benchmarks

open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running
open BenchmarkDotNet.Configs
open BenchmarkDotNet.Jobs

[<CoreJob>]
[<RankColumn>][<MinColumn>][<Q1Column>][<Q3Column>][<MaxColumn>]
[<MaxIterationCount(1000)>]
type SolarSystemGetBenchmark()=
    
    [<Params(30005003, 30000142, 30002089, 31000005)>]
    member val SolarSystemId = 0 with get, set
    
    [<Benchmark>]
    member this.GetSystem() =
        EsiStatics.SolarSystems.byId this.SolarSystemId

