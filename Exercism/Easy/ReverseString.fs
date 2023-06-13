namespace Psych.Exercism.Easy

open System
open System.Globalization

module ReverseString =
    let reverse (input: string): string =
        StringInfo.ParseCombiningCharacters(input)
        |> Seq.map (fun i -> StringInfo.GetNextTextElement(input, i))
        |> Seq.fold (fun acc y -> y + acc) ""

    let rec private reverseHelper xs acc =
        match xs with
        | [] -> acc
        | h::t -> reverseHelper t (h::acc)

    let private rev (input: char list): char list =
        match input with
        | [] -> input
        | [_] -> input
        | h1::h2::t -> reverseHelper t [h2;h1]

    let reverse' (input: string): string =
        input
        |> Seq.toList
        |> rev
        |> fun x -> String.Join("", x)

