namespace Psych.Exercism

module Pangram =
    open System

    let isPangram (input: string): bool =
        input.ToLower()
        |> String.filter Char.IsLetter
        |> Seq.toList
        |> Seq.distinct
        |> Seq.length
        |> fun x -> x = 26
