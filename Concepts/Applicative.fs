namespace Psych.Concepts

(* Have a optional function that has arguments applied *)
module Applicative =
    let apply fOpt xOpt =
        match fOpt, xOpt with
        | Some f, Some x -> Some <| f x
        | _ -> None

    let someAdd = Some (+)
    let (<*>) = apply

    someAdd <*> Some 2 <*> Some 1 |> ignore

    // Something that apply and return
