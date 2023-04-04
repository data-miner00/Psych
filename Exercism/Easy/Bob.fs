namespace Psych.Exercism.Easy

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

    let response' (input: string): string =
        let input = input.Trim()

        let isQuestion = input.EndsWith("?")
        let isShouting = String.exists (fun x -> Char.IsLetter x) input && input = input.ToUpper()
        let isSilence = input = ""

        match isQuestion, isShouting, isSilence with
        | true, false, false -> "Sure."
        | true, true, false -> "Calm down, I know what I'm doing!"
        | false, true, false -> "Whoa, chill out!"
        | false, false, true -> "Fine. Be that way!"
        | _ -> "Whatever."
