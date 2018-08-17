open System

[<EntryPoint>]
let main argv = 
    let mutable inpt = Console.ReadLine ()

    while inpt <> "exit" do
        let res = match inpt with
                  | "add" -> 1
                  | "sub" -> 2
                  | "mul" -> 3
                  | "div" -> 4
                  | "sq" -> 5
                  | "sqrt" -> 6
                  | "pow" -> 7
                  | "abs" -> 8
                  | "ceil" -> 9
                  | "floor" -> 10
                  | "sum" -> 11
                  | "avg" -> 12
                  | "med" -> 13
                  | "mod" -> 14
                  | "max" -> 15
                  | "min" -> 16
                  | _ -> -1
                
        printfn "%A" res

        inpt <- Console.ReadLine ()

    0