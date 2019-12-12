module PairsOfBears

open System

let rec getPairs (chars: List<char>) =
    match chars with
    | [] -> []
    | [ _ ] -> []
    | 'B' :: '8' :: xs -> 'B' :: '8' :: getPairs xs
    | '8' :: 'B' :: xs -> '8' :: 'B' :: getPairs xs
    | 'B' :: _ :: xs -> getPairs ('B' :: xs)
    | '8' :: _ :: xs -> getPairs ('8' :: xs)
    | _ :: _ :: xs -> getPairs xs

let bears (x: int) (s: string): string * bool =
    let xs = Seq.toList s
    let pairsCharArray = getPairs xs

    printfn "%A" pairsCharArray

    let str =
        pairsCharArray
        |> Array.ofList
        |> String

    (str, x > (str.Length / 2))
