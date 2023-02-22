namespace Psych.Concepts.Syntax

module Conditionals =
    
    (* If else *)

    if true then
        printf ""
    elif false then
        printf ""
    else
        printf ""

    (* Match *)

    let number = 42
    let evaluatedString =
        match number with
        | number when number > 8 -> "eight"
        | number when number < 5 -> "five"
        | _ -> number.ToString()

    (* Operators *)
    let t = true || false
    let t' = true && false
    let t'' = not true
