module Exercism

open System

// [WARN]: Message

let message (logLine: string): string =
    logLine
    |> fun x -> x.Split(": ")
    |> fun x -> x.GetValue(1)
    |> fun x -> x.ToString()
    |> fun x -> x.Trim()

let logLevel(logLine: string): string =
    logLine
    |> fun x -> x.Split(": ")
    |> fun x -> x.GetValue(0)
    |> fun x -> x.ToString()
    |> Seq.filter Char.IsLetter
    |> String.Concat
    |> fun x -> x.ToLower()

let reformat(logLine: string): string =
    sprintf "%s (%s)" (message logLine) (logLevel logLine)
