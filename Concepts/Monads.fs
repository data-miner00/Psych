namespace Psych.Concepts

(* Something that bind and return *)
module Monads =
    let bind f xOpt =
        match xOpt with
        | Some x -> f x
        | None -> None

    let (>>=) x f = bind f x

    let isPositive num =
        match num with
        | 0 -> None
        | x -> Some (x > 0)

    Some 2 >>= isPositive |> ignore
