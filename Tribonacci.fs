module Tribonacci

let naiveTribonacci xs n =
    let rec trib lst number =
        if number = 0 then
            lst
        else
            match lst with
            | [] -> []
            | a :: b :: c :: _ -> trib ((a + b + c) :: lst) (number - 1)
            | _ -> []
    List.rev (trib (List.rev xs) (n - xs.Length))

let tribonacci xs n =
    let trib = Seq.unfold (fun (a, b, c) -> Some(a, (b, c, a + b + c)))

    match xs with
    | fst :: snd :: thrd :: _ ->
        trib (fst, snd, thrd)
        |> Seq.take n
        |> Seq.toList
    | _ -> []
