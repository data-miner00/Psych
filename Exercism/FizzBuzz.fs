namespace Psych.Exercism

module FizzBuzz =
    let transform num =
        let dividable3 = num % 3 = 0
        let dividable5 = num % 5 = 0

        match dividable3, dividable5 with
        | true, false -> "Fizz"
        | false, true -> "Buzz"
        | true, true -> "FizzBuzz"
        | _ -> num.ToString()

    // Other implem
    let transformMany' number =
        [1..number]
        |> List.map (fun x -> (x, x % 3, x % 5))
        |> List.map (function
            | (_, 0, 0) -> "FizzBuzz"
            | (_, 0, _) -> "Fizz"
            | (_, _, 0) -> "Buzz"
            | (n, _, _) -> string n)
        |> String.concat "\n"
        |> printfn "%s" 
