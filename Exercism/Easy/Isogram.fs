namespace Psych.Exercism.Easy

open System

module Isogram =

    let isIsogram (str: string) =
        let filtered = str.ToUpper() |> String.filter (Char.IsLetter)

        filtered.ToCharArray()
        |> Set.ofArray
        |> fun x -> x.Count = filtered.Length
