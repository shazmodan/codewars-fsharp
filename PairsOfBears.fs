module PairsOfBears

open System

let rec getPairs (chars: List<char>) =
    match chars with
    | [] -> []
    | [ _ ] -> []
    | 'B' :: '8' :: xs -> 'B' :: '8' :: getPairs xs
    | '8' :: 'B' :: xs -> '8' :: 'B' :: getPairs xs
    | _ :: 'B' :: xs -> getPairs ('B' :: xs)
    | _ :: '8' :: xs -> getPairs ('8' :: xs)
    | _ :: _ :: xs -> getPairs xs

let bears (x: int) (s: string): string * bool =
    let pairs =
        Seq.toList s
        |> getPairs
        |> Array.ofList
        |> String

    (pairs, pairs.Length / 2 >= x)
