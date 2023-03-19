namespace Psych.Concepts

(* Functors is something that can be mapped *)
module Functors =
    let mapForLoop f (list: 'a list) =
        [for x in list -> f x]

    // Not optimized
    let rec map f list =
        match list with
        | [] -> []
        | x::xs -> f x :: map f xs

    [1..10] |> mapForLoop string |> ignore
    [1..10] |> map string |> ignore

    let map' f x =
        match x with
        | Some s -> Some <| f s
        | None -> None

    Some 2 |> map' string |> ignore

    type Box<'a> = Box of 'a

    let map'' f (Box x) =
        Box <| f x

    // Generic List or Box most likely is a functor
