namespace Psych.Concepts.Syntax

module Operator =
    let (>>) f g =
        fun x -> x |> f |> g

    let inline (<^^>) f h =
        f + h

    let distance x y = if x > y then x - y else y - x
    let (|><|) x y = distance x y
    
    printfn "%i" (1 |><| 3) // Infix
    printfn "%i" ((|><|) 1 3) // Prefix


module Pipe =
    sin 2. + 1. |> ignore // evaluates to (sin 2.) + 1.
    
    (* Backward pipe *)
    sin <| 2. + 1. |> ignore // evaluates to sin (2. + 1.)

    // Use backward pipe to make a function looks like infix
    min 15 8 |> ignore
    15 |> min <| 8 |> ignore

    (* Flow two parameters *)
    module BinaryPipe =
        (15, 8) ||> min |> ignore
        min <|| (15, 8) |> ignore

    (* Flow three parameters *)
    module TernaryPipe =
        let mult3 a b c = a * b * c
        (2, 4, 8) |||> mult3 |> ignore
        mult3 <||| (2, 4, 8) |> ignore
