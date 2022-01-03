namespace Psych.Functions

/// <summary>
/// 
/// </summary>
module Common =
    
    open System

    /// <summary>
    /// Logarithm function with custom base value - log_base(num)
    /// </summary>
    /// <param name="base'">The base value of the log function</param>
    /// <param name="num">The number to be evaluated</param>
    let logx base' num =
        log num / log base'

    /// <summary>
    /// Natural logarithm function - log_e(num)
    /// </summary>
    /// <param name="num">The number to be evaluated</param>
    let ln num =
        logx Math.E num

    module Factorial =

        let rec factorial x =
            if x < 0 then failwith "factorial cannot be supplied with negative numbers"

            match x with
            | 0 | 1 -> 1
            | x -> x * factorial x - 1

        let factorial' n = [1..n] |> List.fold (*) 1
        let factorial'' n = [1..n] |> List.reduce (*)

        let factorial''' (num:int) =
            seq { for n in [1..num] -> n }
            |> Seq.reduce (fun acc n -> acc * n)

        let factorial'''' num =
            [1..num] |> Seq.fold (fun acc n -> acc * n) 1
    
        let factorial''''' n =
            let rec loop i acc =
                match i with
                | 0 | 1 -> acc
                | _ -> loop (i-1) (acc * i)
            loop n 1
    
    let rec fibonacci index =
        if index <= 0 then failwith "index must not be smaller than 1"

        match index with
        | 1 -> 0
        | 2 -> 1
        | index -> fibonacci(index - 1) + fibonacci(index - 2)

    let pythogorasTheorem x y =
        sqrt(x ** 2.0 + y ** 2.0)

    let termOfArithmeticProgression n a d =
        a + (n - 1) * d

    let termOfArithmeticProgression'(n:int, seq':int list) =
        let a = seq'.Head
        let b = seq'.Item(1)
        let d = b - a

        termOfArithmeticProgression n a d

    let sumOfFirstNthTermOfAP'' (seq': List<int>) =
        seq'.Length * (seq'.Item(seq'.Length - 1) + seq'.Head) / 2

    let sumOfFirstNthTermOfAP n a d =
        n * (2 * a + (n - 1) * d) / 2

    let sumOfFirstNthTermOfAP' n a l =
        n * (a + l) / 2

    let termOfGeometricProgression n a r =
        a * r ** (n - 1.0)
