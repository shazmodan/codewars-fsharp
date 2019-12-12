open System

open Tribonacci

[<EntryPoint>]
let main argv =
    printfn "We are running"
    printfn "%A" (tribonacci [1;2;3] 10)

    0 // return an integer exit code
