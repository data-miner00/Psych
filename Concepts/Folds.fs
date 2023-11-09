namespace Psych.Concepts

/// Useful compositions with Folds
module Folds =

    ///
    ///
    let sum =
        List.fold (+) 0

    let and' =
        List.fold (&&) true

    let or' =
        List.fold (||) false

    let count e =
        List.fold (fun x acc -> if e = x then acc + 1 else acc) 0

    let count' e =
        e
        |> List.map (fun _ -> 1)
        |> sum

    let isAll e =
        List.fold (fun x acc -> e = x && acc) true

    let length =
        List.fold (fun _ -> (+) 1) 0

    let max x y =
        if x > y then x else y

    module StateFolder =
        type NotificationState =
        | Accepted
        | Snoozed

        type Reminder = {
            Accepted: int
            Snoozed: int
        }

        let list = [Accepted; Snoozed; Snoozed]

        let initialState = {
            Accepted = 0
            Snoozed = 0
        }

        let folder state current =
            match current with
            | Accepted -> { state with Accepted = state.Accepted + 1 }
            | Snoozed -> { state with Snoozed = state.Snoozed + 1 }

            
        List.fold folder initialState list |> printfn "%A"

