namespace Psych.Concepts.Syntax

open System.Text.RegularExpressions

module ActivePattern =
    let (|Even|Odd|) input = if input % 2 = 0 then Even else Odd

    let testNumber input =
        match input with
        | Even -> printfn "%d is even" input
        | Odd -> printfn "%d is odd" input


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
