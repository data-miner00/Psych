namespace Psych.Concepts.Syntax

open System.Text.RegularExpressions
open System.Collections.Generic

module ActivePattern =
    let (|Even|Odd|) input = if input % 2 = 0 then Even else Odd
    let (|Even'|_|) input = if input % 2 = 0 then Some input else None
    let (|Odd'|_|) input = if input % 2 <> 0 then Some input else None

    let testNumber input =
        match input with
        | Even -> printfn "%d is even" input
        | Odd -> printfn "%d is odd" input

    // Using partial will lead to more coverage
    let testNumber' input =
        match input with
        | Even' _ -> printfn "%d is even" input
        | Odd' _ -> printfn "%d is odd" input
        | _ -> printfn "Unknown"

    (* Define Domain in one place *)
    let (|Email|Phone|Other|) (contact: string) =
        if contact.Contains "@" then
            Email
        elif contact.Contains "-" then
            Phone
        else
            Other

    (* Extension Extraction *)
    let (|FileExtension|) (file: string) =
        let ext = System.IO.Path.GetExtension file
        ext

    let files = ["ssf.txt"; "index.fs"]
    for FileExtension ext in files do
        printfn $"Ext: {ext}"

    (* Dictionary *)
    let dict = Dictionary [
        KeyValuePair ("1", "A")
        KeyValuePair ("2", "V")
    ]

    for KeyValue (key, value) in dict do printf $"{key}: {value}"

    (* Regex *)
    let (|Match|_|) pattern input =
        let m = Regex.Match(input, pattern) in
        if m.Success then Some (List.tryLast [for g in m.Groups -> g.Value]) else None

    let containsUrl value =
        match value with
        | Match "(http:\/\/S+)" result -> Some result
        | _ -> None

    let isPhone value =
        match value with
        | Match @"\(([0-9]{3})\)[-. ]?([0-9]{3})[-. ]?([0-9]{4})" a ->
            Some (a)
        | _ -> None
