namespace Psych.Functions

open System

module Recursion =
    let rec ackermann m n =
        match (m, n) with
        | (a, b) when a = 0 -> b + 1
        | (a, b) when a > 0 && b = 0 -> ackermann (a - 1) 1
        | (a, b) when a > 0 && b > 0 -> ackermann (a - 1) (ackermann a b-1)
        | _ -> raise (ArgumentException("Something Wrong"))

    let rec ackermann' m n =
        match m, n with
        | 0, n -> n + 1
        | m, 0 -> ackermann' (m - 1) 1
        | m, n -> ackermann' (m - 1) (ackermann' m (n - 1))

    let sum_imperative items =
        let mutable total = 0
        for item in items do total <- total + item
        total

    let rec sum = function
        | [] -> 0
        | head::tail ->
            head + (sum tail)

    let sum' items =
        let rec loop accumulator items =
            match items with
            | [] -> accumulator
            | head::tail -> loop (accumulator + head) tail
        loop 0 items

    //let fold f accumulator items =
    //    let rec loop accumulator items =
    //        match items with
    //        | [] -> accumulator
    //        | head::tail -> loop f (f accumulator head) tail
    //    loop f accumulator items
    let sum'' = List.fold (+) 0
    let prod = List.fold (*) 1

module TailRecursion =
    let rec sum running_total items =
        match items with
        | [] -> running_total
        | head::tail ->
            sum (running_total + head) tail

    let imperative =
        let mutable state = 0
        let mutable running = true

        while running do
            printfn $"State: {state}"
            let i = Console.ReadLine()
            let (s, v) = Int32.TryParse i
            match s with
            | true -> state <- state + v
            | false -> if i = "x" then running <- false

    let rec functional state =
        printfn $"State: {state}"
        let i = Console.ReadLine()
        let (s, v) = Int32.TryParse i
        match s with
        | true -> functional (state + v)
        | _ -> if i <> "x" then functional state
    functional 0