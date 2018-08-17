open System

[<EntryPoint>]
let main argv = 
    let mutable inpt = Console.ReadLine ()

    while inpt <> "exit" do
        let tks = inpt.Split ' '

        let res = match tks.[0] with
                  | "add" -> Some(Convert.ToDouble(tks.[1]) + Convert.ToDouble(tks.[2]))
                  | "sub" -> Some(Convert.ToDouble(tks.[1]) - Convert.ToDouble(tks.[2]))
                  | "mul" -> Some(Convert.ToDouble(tks.[1]) * Convert.ToDouble(tks.[2]))
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
                  | _ -> None
                
        match res with
        | Some x -> printfn "%f" x
        | None -> printfn "%s" "Invalid arithmetic function."

        inpt <- Console.ReadLine ()

    0