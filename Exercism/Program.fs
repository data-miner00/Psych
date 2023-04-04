namespace Psych.Exercism

open Psych.Exercism.Easy

module Program =
    Pangram.isPangram "The quick brown fox jumps over the lazy dog." |> printfn "%b"
