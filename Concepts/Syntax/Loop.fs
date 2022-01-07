﻿namespace Psych.Concepts.Syntax

open System

module Loop =

    let mutable input = ""
    while not (true) do
        input <- Console.ReadLine()

    for i = 1 to 10 do
        printf "%i" i

    for i = 10 downto 1 do
        printf "%i" i

    for i in [1..10] do
        printf "%i" i

    // Preferred way if iterating
    [1..10] |> List.iter(printfn "%i")
    let sum = List.reduce (+)
