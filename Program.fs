open System

open GetSum

[<EntryPoint>]
let main argv =
    printfn "We are running"
    printfn "%A" (getSum 5 -1)

    0 // return an integer exit code
