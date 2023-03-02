namespace Psych.Concepts.Syntax

module Operator =
    let (>>) f g =
        fun x -> x |> f |> g

    let inline (<^^>) f h =
        f + h
