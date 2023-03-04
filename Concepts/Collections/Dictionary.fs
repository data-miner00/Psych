namespace Psych.Concepts.Collections

module Dictionary =
    let parts = [ "Nuts", 15; "Bolts", 25; "Washers", 7 ] |> dict
    let nutsQuantity = parts["Nuts"]
    // Can't mutate, add or remove items~!

    (* .NET mutable dictionoary *)
    open System.Collections.Generic

    let dict' = new Dictionary<string, int>()
    let dict = new Dictionary<_, _>() // Using F# strong type inference
    dict["a"] <- 1
    dict["b"] <- 2
