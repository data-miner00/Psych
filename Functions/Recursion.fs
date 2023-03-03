namespace Psych.Functions

open System

module Recursion =
    let rec ackermann m n =
        match (m, n) with
        | (a, b) when a = 0 -> b + 1
        | (a, b) when a > 0 && b = 0 -> ackermann (a - 1) 1
        | (a, b) when a > 0 && b > 0 -> ackermann (a - 1) (ackermann a b-1)
        | _ -> raise (ArgumentException("Something Wrong"))

    let rec ackermann' m n =
        match m, n with
        | 0, n -> n + 1
        | m, 0 -> ackermann' (m - 1) 1
        | m, n -> ackermann' (m - 1) (ackermann' m (n - 1))
