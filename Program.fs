open System

open PairsOfBears

[<EntryPoint>]
let main argv =
    printfn "We are running"
    printfn "%s %b" <|| (bears 3 "88Bifk8hB8BB8BBBB888chl8BhBfd")
    0 // return an integer exit code
