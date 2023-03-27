namespace Psych.Concepts.ActivePattern

module Prefix =
    let (|Prefix|_|) (p:string) (s:string) =
        if s.StartsWith(p) then
            Some(s.Substring(p.Length))
        else
            None

    match "Hello world" with
    | Prefix "The" rest -> printfn "Started with 'The', rest is %s" rest
    | Prefix "Hello" rest -> printfn "Started with 'Hello', rest is %s" rest
    | _ -> printfn "neither"
