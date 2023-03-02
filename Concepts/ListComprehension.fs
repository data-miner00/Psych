namespace Psych.Concepts

module ListComprehension =
    [for x in 1..5 do yield x * x] |> ignore // [1;4;9;16;25]
    [for x in 1..5 -> x * x] |> ignore // shortcut

    // Get tuples that does not equal with each other
    [
        for r in 1..8 do
            for c in 1..8 do
                if r <> c then yield (r, c)
    ] |> ignore



