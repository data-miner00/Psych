namespace Psych.Exercism.Easy

open System.Numerics

module Grains =
    let square (n: int): Result<uint64,string> =
        if n > 64 || n <= 0 then
            Error "square must be between 1 and 64"
        else
            BigInteger.Pow(2UL, n - 1) |> uint64 |> Ok

    let unwrap (res: Result<uint64, string>) =
        match res with
        | Ok num -> num
        | Error(_) -> 0UL

    let total: Result<uint64,string> =
        [1..64] 
        |> List.map square
        |> List.map unwrap
        |> List.fold (+) 0UL
        |> Ok
