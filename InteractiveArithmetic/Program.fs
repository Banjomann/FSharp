open System

[<EntryPoint>]
let main argv = 
    Console.Write (">")

    let mutable inpt = (Console.ReadLine ()).Trim ()

    while inpt <> "exit" do
        let tks = inpt.Split([|' '|],StringSplitOptions.RemoveEmptyEntries)
        
        if tks.Length > 0
        then
            let mutable ft = 0.0f
            let param = [for tk in tks do
                            if Single.TryParse(tk,&ft)
                            then
                                yield ft]

            if param.Length = tks.Length - 1
            then
                if param.Length > 0
                then
                    match match tks.[0] with
                          | "add" -> match param.Length with
                                     | 2 -> Some((param.[0] + param.[1]).ToString())
                                     | _ -> None
                          | "sub" -> match param.Length with
                                     | 2 -> Some((param.[0] - param.[1]).ToString())
                                     | _ -> None
                          | "mul" -> match param.Length with
                                     | 2 -> Some((param.[0] * param.[1]).ToString())
                                     | _ -> None
                          | "div" -> match param.Length with
                                     | 2 -> Some((param.[0] / param.[1]).ToString())
                                     | _ -> None
                          | "sq" -> match param.Length with
                                    | 1 -> Some((param.[0] * param.[0]).ToString())
                                    | _ -> None
                          | "sqrt" -> None
                          | "pow" -> None
                          | "abs" -> None
                          | "ceil" -> None
                          | "floor" -> None
                          | "sum" -> Some((param |> List.fold (+) 0.0f).ToString())
                          | "avg" -> None
                          | "med" -> None
                          | "mod" -> None
                          | "max" -> None
                          | "min" -> None
                          | _ -> Some("Invalid arithmetic function.") with
                    | Some x -> Console.WriteLine x
                    | None -> printfn "Invalid number of parameters supplied for %s function." tks.[0]
                else Console.WriteLine "All functions must include at least one parameter."
            else Console.WriteLine "All parameters must be numbers."
            Console.WriteLine "" // Empty line after returned message or value
        else Console.Write "" // No empty line if no input

        Console.Write ">"

        inpt <- Console.ReadLine ()
    0