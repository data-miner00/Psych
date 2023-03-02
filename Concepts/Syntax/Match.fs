namespace Psych.Concepts.Syntax

module Match =
    let printFirstFew (items : string list) =
        match items with
        | [] -> printfn "Empty list"
        | [a] -> printfn "Array with one element %s" a
        | [a;b] -> printfn "Array with 2 elements %s %s" a b
        | a :: b :: _ -> printfn "Array with more than two elements %s %s" a b

    let tryFirst (items : string list) =
        match items with
        | [] -> None
        | f :: _ -> Some f

    let firstOrDefault df (items : string list) =
        match tryFirst items with
        | Some x -> x
        | None -> df

    type MayHap<'T> =
    | Summat of 'T
    | Nowt

    let tryFirst' (items : string list) =
        match items with
        | [] -> Nowt
        | f :: _ -> Summat f

    let firstOrDefault' df (items : string list) =
        match tryFirst' items with
        | Summat x -> x
        | Nowt -> df

    (* Shortcut for matching: Function matching pattern *)
    let matchSomething = function
        | 0 | 1 | 2 -> "0, 1 or 2"
        | _ -> "otherwise"
