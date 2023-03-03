namespace Psych.Exercism

open System

module Bob =
    let response (input: string): string =
        input.Trim()
        |> fun input ->
            match input with
            | _ when input.EndsWith("?") && String.exists (fun x -> Char.IsLetter x) input && input = input.ToUpper() ->
                "Calm down, I know what I'm doing!"
            | _ when input.EndsWith("?") -> "Sure."
            | _ when String.IsNullOrWhiteSpace(input) ->
                "Fine. Be that way!"
            | _ when String.exists (fun x -> Char.IsLetter x) input && input = input.ToUpper() ->
                "Whoa, chill out!"
            | _ -> "Whatever."
