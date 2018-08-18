open System

[<EntryPoint>]
let main argv = 
    Console.Write (">")

    let mutable inpt = Console.ReadLine ()

    while inpt <> "exit" do
        let tks = inpt.Split ' '

        let ft = 0.0f
        if Seq.skip 1 tks |> Seq.fold (fun fpar t -> fpar && Single.TryParse(t, ref ft)) true
        then
            match match tks.[0] with
                  | "add" -> match tks.Length with
                             | 3 -> Some((Single.Parse tks.[1] + Single.Parse tks.[2]).ToString())
                             | _ -> None
                  | "sub" -> match tks.Length with
                             | 3 -> Some((Single.Parse tks.[1] - Single.Parse tks.[2]).ToString())
                             | _ -> None
                  | "mul" -> match tks.Length with
                             | 3 -> Some((Single.Parse tks.[1] * Single.Parse tks.[2]).ToString())
                             | _ -> None
                  | "div" -> None
                  | "sq" -> None
                  | "sqrt" -> None
                  | "pow" -> None
                  | "abs" -> None
                  | "ceil" -> None
                  | "floor" -> None
                  | "sum" -> None
                  | "avg" -> None
                  | "med" -> None
                  | "mod" -> None
                  | "max" -> None
                  | "min" -> None
                  | "" -> Some("")
                  | _ -> Some("Invalid arithmetic function.") with
            | Some x -> match x with
                        | "" -> Console.Write ""
                        | _ -> Console.WriteLine (x + Environment.NewLine)
            | None -> printfn "Invalid number of args supplied for %s function." tks.[0]
        else Console.WriteLine "All arguments must be numbers."

        Console.Write ">"

        inpt <- Console.ReadLine ()
    0