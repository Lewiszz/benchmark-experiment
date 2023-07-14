// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

open BenchmarkDotNet.Attributes
open BenchmarkDotNet.Running
open BenchmarkDotNet.Jobs

[<SimpleJob(RuntimeMoniker.Net60)>]
type Benchmarks() =

    [<Benchmark>]
    member this.Array() = [| 0..10 |] |> Array.map ((+) 1)

BenchmarkRunner.Run<Benchmarks>() |> ignore
