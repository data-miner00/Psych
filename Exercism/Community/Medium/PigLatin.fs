namespace Psych.Exercism.Community.Medium

module PigLatin =
    (* Link: https://exercism.org/tracks/fsharp/exercises/pig-latin/solutions/SimonTreanor *)
    module SimonTreanor =
        open System.Text.RegularExpressions

        let private (|Vowel|_|) i =
            let matches = Regex.Match(i, @"^([aeiou]|xr|y[^aeiou])(\w*)")
            if matches.Success then Some () else None

        let private (|Consonant|_|) i =
            let matches = Regex.Match(i, @"^(s*qu|[bcdfghjklmnpqrstvwxz]+|y|[^y]+y)(\w*)")
            if matches.Success then
                let prefix = matches.Groups.[1].Value
                let suffix = matches.Groups.[2].Value
                Some (prefix, suffix)
            else None

        let private translateWord input =
            match input with
            | Vowel -> input + "ay"
            | Consonant (p, s) -> s + p + "ay"
            | _ -> input

        let translate (input: string) =
            input.Split " "
            |> Seq.map translateWord
            |> String.concat " "

    (* Link: https://exercism.org/tracks/fsharp/exercises/pig-latin/solutions/jbristow *)
    module Jbristow =
        open System.Text.RegularExpressions
        open System

        let private latinize (m: Match) = m.Groups.[2].Value + m.Groups.[1].Value + "ay"
        let private join (col: seq<string>) = String.Join(" ", col)

        let translate (input: string): string =
            Regex.Matches
                (input, "(s?qu|[rt]hr?|s?ch|[xy](?=[aeiou])|[b-z-[aeiouxy]]?)(\w+)")
            |> Seq.cast
            |> Seq.map latinize
            |> join
