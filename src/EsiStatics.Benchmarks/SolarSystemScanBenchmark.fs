namespace EsiStatics.Benchmarks

open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running
open BenchmarkDotNet.Configs
open BenchmarkDotNet.Jobs
open EsiStatics

[<CoreJob>]
[<RankColumn>][<MinColumn>][<Q1Column>][<Q3Column>][<MaxColumn>]
[<MaxIterationCount(1000)>]
type SolarSystemScanBenchmark()=
    
    [<Benchmark>]
    member this.GetSystems() =
        let ss = Regions.all()
                    |> Seq.collect (fun r -> r.Constellations())
                    |> Seq.collect (fun c -> c.SolarSystems())

        ss |> Seq.length


