namespace Psych.Concepts.Syntax

open System

module Exceptions =

    let trye =
        try
            4 / 0
        with
        | :? System.DivideByZeroException -> 6

    let tryex =
        try
            if 0 = 0 then raise(DivideByZeroException("Cannot divide by 0"))
            else
                printf "Ok"
        with
        | :? System.DivideByZeroException as ex -> printf "not ok"; ()
        | ex -> printfn "%A" ex; ()

    (* Create exceptions with optional data *)
    exception Error1 of string * int
    exception Error2 of string * int * int

    let func1 x y =
        try
            if x = y then raise (Error1($"Value are equal", x))
            else raise (Error2($"Value not equal", x, y))
        with
            | Error1(str, x) -> printfn "%s: %i" str x
            | Error2(str, x, y) -> printfn "%s: %i %i" str x y
            | _ -> ()
