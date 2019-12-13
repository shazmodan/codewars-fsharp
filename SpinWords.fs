module SpinWords

let spinWords (str: string) =
    str.Split(' ')
    |> Seq.map (fun x ->
        if x.Length > 4 then
            x
            |> Seq.rev
            |> System.String.Concat
        else
            x)
    |> Seq.reduce (fun acc elem -> acc + " " + elem)
