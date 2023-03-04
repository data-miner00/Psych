namespace Psych.Playground

/// <summary>
/// A sample implementation for Console Interface application
/// with recursion and immutability.
/// </summary>
module UserConsole =
    open System

    let private getAmount () =
        Console.Write("Enter the amount of the transaction: ")
        Console.ReadLine() |> Decimal.Parse

    let run() =
        let rec loop balance =
            printfn "Balance: %A" balance

            let action = "w"
            printfn "You told me to do this: %A" action

            match action with
            | "d" -> loop (balance + getAmount())
            | "w" -> loop (balance - getAmount())
            | "x" -> ()
            | _ ->
                printfn $"Invalid action: {action}"
                loop balance
        loop 0m
        ()

    // Improved version with error handling
    let private getAmount'() =
        Console.Write("Enter the amount of the transaction: ")
        Console.ReadLine() |> Decimal.TryParse
        |> fun x ->
            match x with
            | true, value -> Ok value
            | false, _ -> Error "Cant parse"

    let run'() =
        let rec loop balance =
            printfn "Balance: %A" balance

            let action = "w"
            printfn "You told me to do this: %A" action

            match action with
            | "d" | "w" ->
                match getAmount'() with
                | Ok value ->
                    match action with
                    | "d" -> loop (balance + value)
                    | "w" -> loop (balance - value)
                    | _ -> loop balance
                | Error message ->
                    printfn "%A" message
                    loop balance
            | "x" -> ()
            | _ ->
                printfn $"Invalid action: {action}"
                loop balance

        loop 0m
        ()
