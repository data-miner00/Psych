namespace Psych.Exercism.Medium

open System
open System.Text.RegularExpressions

module PhoneNumber =
    let clean (input : string) =
        let regex = Regex(@"^\+?(1?)\(?(\d+)[\)\.-]?(.{3})[\.-]?(\d+)$", RegexOptions.Compiled)

        let content = input.Trim().Split(' ') |> String.concat ""
        
        let cleansed =
            regex.Match(content)
            |> fun x -> [x.Groups[1].Value; x.Groups[2].Value; x.Groups[3].Value; x.Groups[4].Value]
            |> String.concat ""

        match cleansed with
        | _ when cleansed.Length < 10 -> Error "incorrect number of digits"
        | _ when cleansed.Length = 11 && not (cleansed.StartsWith('1')) -> Error "11 digits must start with 1"
        | _ when cleansed.Length > 11 -> Error "more than 11 digits"
        | _ ->
            let standard = if cleansed.Length = 11 then cleansed.Substring(1) else cleansed
            match standard with
            | _ when standard.StartsWith('1') -> Error "area code cannot start with one"
            | _ when standard.StartsWith('0') -> Error "area code cannot start with zero"
            | _ when standard.Substring(3).StartsWith('1') -> Error "exchange code cannot start with one"
            | _ when standard.Substring(3).StartsWith('0') -> Error "exchange code cannot start with zero"
            | _ when standard |> Seq.exists(fun c -> Char.IsLetter(c)) -> Error "letters not permitted"
            | _ when standard |> Seq.exists(fun c -> Char.IsPunctuation(c)) -> Error "punctuations not permitted"
            | _ -> Ok (standard |> uint64)

